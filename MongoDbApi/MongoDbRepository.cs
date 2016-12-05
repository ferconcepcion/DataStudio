using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using Utils;

namespace MongoDbApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// MongoDb Repository.
    /// </summary>
    public class MongoDbRepository : IRepository
    {
        #region Private members

        private string _connectionString;
        private bool _useDefaultConnection;
        string _dataBaseName;

        #endregion

        #region Constructors

        public MongoDbRepository(string dataBaseName)
        {
            _connectionString = string.Empty;
            _useDefaultConnection = true;
            _dataBaseName = dataBaseName;
        }

        public MongoDbRepository(string connectionString, string dataBaseName)
        {
            _connectionString = connectionString;
            _useDefaultConnection = false;
            _dataBaseName = dataBaseName;
        }

        #endregion

        #region Mongo Client

        private IMongoClient GetClient()
        {
            return _useDefaultConnection ? new MongoClient() : new MongoClient(_connectionString);
        }

        #endregion

        #region Collections

        public IList<string> GetCollections()
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                var collections = db.ListCollections();
                var list = new List<string>();

                foreach (var item in db.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
                {
                    list.Add(item["name"].ToString());
                }

                return list;
            }
            catch
            {
                return new List<string>();
            }
        }

        public bool InsertCollection(string newCollectionName, out string comments)
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                db.CreateCollection(newCollectionName);

                comments = "Collection inserted!";

                return true;
            }
            catch (Exception e)
            {
                comments = e.ToString();
                return false;
            }
        }

        public bool DeleteCollection(string collectionName, out string comments)
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                db.DropCollection(collectionName);

                comments = "Collection removed!";

                return true;
            }
            catch (Exception e)
            {
                comments = e.ToString();
                return false;
            }
        }

        #endregion

        #region Element

        public IList<string> GetElementsIds(string collectionName)
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                var collection = db.GetCollection<BsonDocument>(collectionName);

                // Select _ids
                var list = new List<string>();
                var result = collection.Find(x => true).ToList();
                foreach (var item in result)
                {
                    list.Add(item["_id"].ToString());
                }

                return list;
            }
            catch
            {
                return new List<string>();
            }
        }

        public string GetElement(string collectionName, string elementId)
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                var collection = db.GetCollection<BsonDocument>(collectionName);

                // Select _ids
                var list = new List<string>();
                var filterNormalId = Builders<BsonDocument>.Filter.Eq("_id", elementId);
                var filterObjectId = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(elementId));
                var filterFinal = Builders<BsonDocument>.Filter.Or(
                    new List<FilterDefinition<BsonDocument>>
                    {
                    filterNormalId,
                    filterObjectId
                    });

                var result = collection.Find(filterFinal).SingleOrDefault();

                return result.ToJson();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string GetElements(string collectionName)
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                var collection = db.GetCollection<BsonDocument>(collectionName);

                return collection.Find(x => true).ToList().ToJson();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public bool InsertElement(string collectionName, string newElement, out string comments)
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                var collection = db.GetCollection<BsonDocument>(collectionName);

                // Document to insert
                var document = BsonDocument.Parse(newElement);
                // Insert
                collection.InsertOne(document);
                comments = "Document inserted!";

                return true;
            }
            catch (Exception e)
            {
                comments = e.ToString();
                return false;
            }
        }

        public string ReplaceElement(string collectionName, string elementId, string elementEdited)
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                var collection = db.GetCollection<BsonDocument>(collectionName);

                // Filter the old document
                var filterNormalId = Builders<BsonDocument>.Filter.Eq("_id", elementId);
                var filterObjectId = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(elementId));
                var filterFinal = Builders<BsonDocument>.Filter.Or(
                    new List<FilterDefinition<BsonDocument>>
                    {
                    filterNormalId,
                    filterObjectId
                    });

                // New ocument to replace
                var document = BsonDocument.Parse(elementEdited);

                // Replace
                var replaceResult = collection.ReplaceOne(filterFinal, document);
                return replaceResult.ToJson();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public bool DeleteElement(string collectionName, string elementId, out string comments)
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                var collection = db.GetCollection<BsonDocument>(collectionName);

                // Filter the document to delete
                var filterNormalId = Builders<BsonDocument>.Filter.Eq("_id", elementId);
                var filterObjectId = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(elementId));
                var filterFinal = Builders<BsonDocument>.Filter.Or(
                    new List<FilterDefinition<BsonDocument>>
                    {
                        filterNormalId,
                        filterObjectId
                    });

                // Delete
                var deleteResult = collection.DeleteOne(filterFinal);
                if (deleteResult.DeletedCount > 0)
                {
                    comments = "Document removed!";
                    return true;
                }
                else
                {
                    comments = deleteResult.ToJson();
                    return false;
                }
            }
            catch (Exception e)
            {
                comments = e.ToString();
                return false;
            }
        }

        #endregion

        #region Execute Query

        public string ExecuteQuery(string query, string collectionName, out string comments)
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                var collection = db.GetCollection<BsonDocument>(collectionName);

                var bsonDoc = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(query);

                var result = collection.Find(bsonDoc).ToList();
                comments = "Query executed!";

                if (result != null)
                {
                    return result.ToJson();
                }
                else
                {
                    return "{}";
                }
            }
            catch (Exception e)
            {
                comments = "ERROR";
                return e.ToString();
            }
        }

        #endregion

        #region Get Json General 

        public string GetJsonGeneral()
        {
            try
            {
                var client = GetClient();
                var db = client.GetDatabase(_dataBaseName);
                var collections = db.ListCollections();

                var jsonDocument = new BsonDocument();
                var jsonElements = new List<BsonElement>();

                foreach (var item in db.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
                {
                    var collection = db.GetCollection<BsonDocument>(item["name"].ToString());
                    var collectionListElements = collection.Find(x => true).ToList();
                    var collectionArray = new BsonArray();
                    foreach (var element in collectionListElements)
                    {
                        collectionArray.Add(element);
                    }
                    jsonElements.Add(new BsonElement(item["name"].ToString(), collectionArray));
                }
                return jsonDocument.AddRange(jsonElements).ToJson();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        #endregion
    }
}
