using System;
using System.Collections.Generic;
using Utils;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;

namespace DocumentDbApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// DocumentDb Repository.
    /// </summary>
    public class DocumentDbRepository : IRepository
    {
        #region Private members

        private string _serviceEndpoint;
        private string _authKey;
        private string _databaseName;

        #endregion

        #region Constructor

        public DocumentDbRepository(string serviceEndpoint, string authKey, string databaseName)
        {
            _serviceEndpoint = serviceEndpoint;
            _authKey = authKey;
            _databaseName = databaseName;
        }

        #endregion

        #region Private methods

        private DocumentClient GetDocumentClient()
        {
            return new DocumentClient(new Uri(_serviceEndpoint), _authKey);
        }

        private DocumentClient GetDocumentClientAsync()
        {
            var client = new DocumentClient(new Uri(_serviceEndpoint), _authKey);
            client.OpenAsync();
            return client;
        }

        private Database GetDatabase(IDocumentClient client)
        {
            return client.ReadDatabaseAsync(
                    UriFactory.CreateDatabaseUri(_databaseName))
                    .Result.Resource;
        }
        
        #endregion

        #region Collections

        public IList<string> GetCollections()
        {
            using (var client = GetDocumentClientAsync())
            {
                try
                {
                    var database = GetDatabase(client);

                    var collections = client.CreateDocumentCollectionQuery(
                        database.SelfLink).ToList();
                    return collections.Select(x => x.Id).ToList();
                }
                catch
                {
                    return new List<string>();
                }
            }
        }

        public bool InsertCollection(string newCollectionName, out string comments)
        {
            using (var client = GetDocumentClientAsync())
            {
                try
                {
                    var collection = new DocumentCollection { Id = newCollectionName };
                    var database = GetDatabase(client);

                    var result = client.CreateDocumentCollectionAsync(
                        database.SelfLink, collection).Result;

                    comments = result.StatusCode.ToString();

                    return result.StatusCode == HttpStatusCode.Created;
                }
                catch (Exception e)
                {
                    comments = e.ToString();
                    return false;
                }
            }
        }

        public bool DeleteCollection(string collectionName, out string comments)
        {
            using (var client = GetDocumentClientAsync())
            {
                try
                {
                    var result = client.DeleteDocumentCollectionAsync(
                        UriFactory.CreateDocumentCollectionUri(_databaseName, collectionName))
                            .Result;

                    comments = result.StatusCode.ToString();

                    return result.StatusCode == HttpStatusCode.NoContent;
                }
                catch (Exception e)
                {
                    comments = e.ToString();
                    return false;
                }
            }
        }

        #endregion

        #region Documents

        public string GetElement(string collectionName, string elementId)
        {
            var urlDocument = UriFactory.CreateDocumentUri(_databaseName, collectionName, elementId);
            using (var client = GetDocumentClientAsync())
            {
                try
                {
                    var doc = client.ReadDocumentAsync(urlDocument).Result;
                    return doc.Resource.ToString();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }

        public string GetElements(string collectionName)
        {
            var urlDocument = UriFactory.CreateDocumentCollectionUri(_databaseName, collectionName);
            using (var client = GetDocumentClientAsync())
            {
                try
                {
                    var doc = client.ReadDocumentCollectionAsync(urlDocument).Result;
                    return doc.Resource.ToString();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }
        
        public IList<string> GetElementsIds(string collectionName)
        {
            var urlDocument = UriFactory.CreateDocumentCollectionUri(_databaseName, collectionName);
            using (var client = GetDocumentClientAsync())
            {
                try
                {
                    return client.CreateDocumentQuery(urlDocument).ToList()
                        .Select(x => x.Id).ToList();
                }
                catch
                {
                    return new List<string>();
                }
            }
        }

        public bool InsertElement(string collectionName, string newElement, out string comments)
        {
            var urlDocument = UriFactory.CreateDocumentCollectionUri(_databaseName, collectionName);
            var documentToAdd = (Document)JsonConvert.DeserializeObject<Document>(newElement);

            using (var client = GetDocumentClientAsync())
            {
                try
                {
                    var task = Task.Run(() =>
                        client.CreateDocumentAsync(urlDocument, documentToAdd)).Result;
                    
                    comments = task.StatusCode.ToString();
                    return task.StatusCode == HttpStatusCode.Created;
                }
                catch (Exception e)
                {
                    comments = e.ToString();
                    return false;
                }
            }
        }
        
        public string ReplaceElement(string collectionName, string elementId, string elementEdited)
        {
            var urlDocument = UriFactory.CreateDocumentUri(_databaseName, collectionName, elementId);
            var documentToEdited = (Document)JsonConvert.DeserializeObject<Document>(elementEdited);

            using (var client = GetDocumentClientAsync())
            {
                try
                { 
                    var task = Task.Run(() =>
                        client.ReplaceDocumentAsync(urlDocument, documentToEdited)).Result;

                    return task.StatusCode.ToString();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }
        
        public bool DeleteElement(string collectionName, string elementId, out string comments)
        {
            var urlDocument = UriFactory.CreateDocumentUri(_databaseName, collectionName, elementId);
            using (var client = GetDocumentClientAsync())
            {
                try
                { 
                    var doc = client.DeleteDocumentAsync(urlDocument).Result;
                    comments = doc.StatusCode.ToString();
                    return doc.StatusCode == HttpStatusCode.NoContent;
                }
                catch (Exception e)
                {
                    comments = e.ToString();
                    return false;
                }
            }
        }

        #endregion

        public string ExecuteQuery(string query, string collectionName, out string comments)
        {
            var urlDocument = UriFactory.CreateDocumentCollectionUri(_databaseName, collectionName);
            using (var client = GetDocumentClientAsync())
            {
                try
                {
                    var taskQuery = Task.Run(
                        () => client.CreateDocumentQuery(urlDocument, query,
                        new FeedOptions
                        {
                            MaxItemCount = 10,
                            EnableCrossPartitionQuery = false,
                            MaxBufferedItemCount = 100,
                            MaxDegreeOfParallelism = 1
                        }).ToList());
                    var querydb = taskQuery.Result;

                    comments = taskQuery.Status.ToString();
                    return GetJsonQuery(querydb.ToList());
                }
                catch (Exception e)
                {
                    comments = e.ToString();
                    return "ERROR";
                }
            }
        }
        
        public string GetJsonGeneral()
        {
            var jsonObject = new JObject();
            var auxQuery = "SELECT * FROM c";

            using (var client = GetDocumentClientAsync())
            {
                try
                { 
                    var database = GetDatabase(client);

                    var collections = client.CreateDocumentCollectionQuery(
                        database.SelfLink).ToList();
                    var collectionsNameList = collections.Select(x => x.Id).ToList();

                    foreach (var collectionName in collectionsNameList)
                    {
                        var urlDocument = UriFactory.CreateDocumentCollectionUri(_databaseName, collectionName);

                        var taskQuery = Task.Run(
                            () => client.CreateDocumentQuery(urlDocument, auxQuery,
                            new FeedOptions
                            {
                                MaxItemCount = 10,
                                EnableCrossPartitionQuery = false,
                                MaxBufferedItemCount = 100,
                                MaxDegreeOfParallelism = 1
                            }).ToList());
                        var querydb = taskQuery.Result;
                    
                        jsonObject.Add(collectionName, JToken.Parse(GetJsonQuery(querydb.ToList())));
                    }
                    return jsonObject.ToString();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }

            }

        }

        private string GetJsonQuery(IList<dynamic> results)
        {
            string jsonarray = "[";
            int index = 0;
            foreach (var d in results)
            {
                index++;
                jsonarray += d.ToString();

                if (index == results.Count())
                {
                    jsonarray += "]";
                }
                else
                {
                    jsonarray += ",\r\n";
                }
            }
            return jsonarray;
        }

    }
}
