using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Net;
using Utils;

namespace DynamoDbApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// DynamoDb Configuration.
    /// </summary>
    public class DynamoDbRepository : IRepository
    {
        private AWSCredentials _credentials;
        private RegionEndpoint _region;

        public DynamoDbRepository(string accessKey, string secretKey, string region)
        {
            _credentials = new BasicAWSCredentials(accessKey, secretKey);
            _region = RegionEndpoint.GetBySystemName(region);
        }

        private AmazonDynamoDBClient GetClient()
        {
            return new AmazonDynamoDBClient(_credentials, _region);
        }

        #region Collections

        public IList<string> GetCollections()
        {
            using (var client = GetClient())
            {
                try
                {
                    var listing = new List<string>();
                    var request = client.ListTables();
                    foreach (var table in request.TableNames)
                    {
                        try
                        {
                            var statusTable = client.DescribeTable(new DescribeTableRequest
                            {
                                TableName = table
                            }).Table.TableStatus.Value;
                            if (statusTable == TableStatus.ACTIVE)
                            {
                                listing.Add(table);
                            }
                        }
                        catch { }
                    }
                    return listing;
                }
                catch
                {
                    return new List<string>();
                }
            }
        }

        public bool InsertCollection(string newCollectionName, out string comments)
        {
            using (var client = GetClient())
            {
                try
                {
                    var request = client.CreateTable(new CreateTableRequest
                    {
                        TableName = newCollectionName,
                        AttributeDefinitions = new List<AttributeDefinition>()
                    {
                        new AttributeDefinition
                        {
                          AttributeName = "Id",
                          AttributeType = "N"
                        }
                    },
                        KeySchema = new List<KeySchemaElement>()
                    {
                        new KeySchemaElement
                        {
                            AttributeName = "Id",
                            KeyType = "HASH"  //Partition key
                        }
                    },
                        ProvisionedThroughput = new ProvisionedThroughput
                        {
                            ReadCapacityUnits = 10,
                            WriteCapacityUnits = 5
                        }
                    });

                    comments = request.TableDescription.TableStatus.Value;
                    return true;
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
            using (var client = GetClient())
            {
                try
                {
                    var request = client.DeleteTable(new DeleteTableRequest
                    {
                        TableName = collectionName
                    });
                    
                    comments = request.HttpStatusCode.ToString();
                    return true;
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
            using (var client = GetClient())
            {
                try
                {
                    var table = Table.LoadTable(client, collectionName);
                    var item = table.GetItem(new Primitive(elementId, true));

                    return item.ToJson();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }

        public string GetElements(string collectionName)
        {
            using (var client = GetClient())
            {
                try
                {
                    var scan = client.Scan(new ScanRequest
                    {
                        TableName = collectionName
                    });

                    return scan.Items.ToJson();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }

        public IList<string> GetElementsIds(string collectionName)
        {
            using (var client = GetClient())
            {
                try
                {
                    var scan = client.Scan(collectionName, new List<string> { "Id" });
                    var listingSelect = new List<string>();

                    foreach (var x in scan.Items)
                    {
                        listingSelect.Add(x["Id"].N);
                    }
                    return listingSelect;
                }
                catch
                {
                    return new List<string>();
                }
            }
        }

        public bool InsertElement(string collectionName, string newElement, out string comments)
        {
            var item = Document.FromJson(newElement);
            using (var client = GetClient())
            {
                try
                {
                    var table = Table.LoadTable(client, collectionName);
                    table.PutItem(item);
                    comments = "Inserted succesfully!";
                    return true;
                }
                catch (Exception ex)
                {
                    comments = ex.ToString();
                    return false;
                }
            }
        }

        public string ReplaceElement(string collectionName, string elementId, string elementEdited)
        {
            var item = Document.FromJson(elementEdited);
            using (var client = GetClient())
            {
                try
                {
                    var table = Table.LoadTable(client, collectionName);
                    table.UpdateItem(item);

                    return "Replaced succesfully!";
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }

        public bool DeleteElement(string collectionName, string elementId, out string comments)
        {
            using (var client = GetClient())
            {
                try
                {
                    var delete = client.DeleteItem(new DeleteItemRequest
                    {
                        TableName = collectionName,
                        Key = new Dictionary<string, AttributeValue>() {
                        { "Id", new AttributeValue { N = elementId } }
                    }
                    });

                    comments = delete.HttpStatusCode.ToString();
                    return delete.HttpStatusCode == HttpStatusCode.OK;
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
            using (var client = GetClient())
            {
                try
                {
                    var scan = client.Scan(new ScanRequest
                    {
                        TableName = collectionName,
                        FilterExpression = query
                    });

                    comments = "Executed query!";
                    return scan.Items.ToJson();
                }
                catch (Exception e)
                {
                    comments = "Error";
                    return e.ToString();
                }
            }
        }

        public string GetJsonGeneral()
        {
            using (var client = GetClient())
            {
                try
                {
                    var listing = new List<string>();
                    var request = client.ListTables();
                    var dicJsones = new Dictionary<string, string>();

                    foreach (var table in request.TableNames)
                    {
                        try
                        {
                            var statusTable = client.DescribeTable(new DescribeTableRequest
                            {
                                TableName = table
                            }).Table.TableStatus.Value;
                            if (statusTable == TableStatus.ACTIVE)
                            {
                                listing.Add(table);
                            }
                        }
                        catch { }
                    }
                    
                    foreach (var table in listing)
                    {
                        var scan = client.Scan(new ScanRequest
                        {
                            TableName = table
                        });

                        dicJsones.Add(table, scan.Items.ToJson());
                    }
                    return dicJsones.TablesToJson();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }

    }
}

