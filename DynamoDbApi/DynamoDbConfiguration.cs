using System;
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
    public class DynamoDbConfiguration : IConfiguration
    {
        private string _accessKey;
        private string _secretKey;
        private string _regionEndpoint;

        public DynamoDbConfiguration(string accessKey, string secretKey, string regionEndpoint)
        {
            _accessKey = accessKey;
            _secretKey = secretKey;
            _regionEndpoint = regionEndpoint;
        }

        public string ExampleQuery
        {
            get
            {
                return "Id = Parameter";
            }
        }

        public string TextDeleteCollection
        {
            get
            {
                return "Delete table";
            }
        }

        public string TextDeleteElement
        {
            get
            {
                return "Delete item";
            }
        }

        public string TextExecuteQuery
        {
            get
            {
                return "Execute query";
            }
        }

        public string TextInsertCollection
        {
            get
            {
                return "Insert table";
            }
        }

        public string TextInsertElement
        {
            get
            {
                return "Insert item";
            }
        }

        public string TextLabelCollections
        {
            get
            {
                return "Tables";
            }
        }

        public string TextLabelElements
        {
            get
            {
                return "Items";
            }
        }

        public string TextNameDatabase
        {
            get
            {
                return "";
            }

            set
            {
                ;
            }
        }

        public string TextNameQuery
        {
            get
            {
                return "DynamoDb Filter Expression";
            }
        }

        public string TextUpdateElement
        {
            get
            {
                return "Update item";
            }
        }

        public DatabaseType Type
        {
            get
            {
                return DatabaseType.DynamoDb;
            }
        }

        public string TextButtonNewCollection
        {
            get
            {
                return "New Table -->";
            }
        }

        public string TestButtonNewElement
        {
            get
            {
                return "New Item -->";
            }
        }

        public IRepository GetRepository()
        {
            return new DynamoDbRepository(_accessKey, _secretKey, _regionEndpoint);
        }

        public bool CheckConection()
        {
            return DynamoDbConnection.CheckConnexion(_accessKey, _secretKey, _regionEndpoint);
        }
    }
}
