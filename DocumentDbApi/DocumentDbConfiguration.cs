using System;
using Utils;

namespace DocumentDbApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// DocumentDb Configuration.
    /// </summary>
    public class DocumentDbConfiguration : IConfiguration
    {
        private string _databaseName;
        private string _authKey;
        private string _serviceEndpoint;

        public DocumentDbConfiguration(string serviceEndpoint, string authKey,
            string databaseName)
        {
            _authKey = authKey;
            _serviceEndpoint = serviceEndpoint;
            _databaseName = databaseName;
        }

        public string ExampleQuery
        {
            get
            {
                return "SELECT * FROM c";
            }
        }

        public string TextDeleteCollection
        {
            get
            {
                return "Delete collection";
            }
        }

        public string TextDeleteElement
        {
            get
            {
                return "Delete document";
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
                return "Create collection";
            }
        }

        public string TextInsertElement
        {
            get
            {
                return "Create document";
            }
        }

        public string TextLabelCollections
        {
            get
            {
                return "Collections";
            }
        }

        public string TextLabelElements
        {
            get
            {
                return "Documents";
            }
        }

        public string TextNameDatabase
        {
            get
            {
                return _databaseName;
            }

            set
            {
                _databaseName = value;
            }
        }

        public string TextNameQuery
        {
            get
            {
                return "Documentdb Query";
            }
        }

        public string TextUpdateElement
        {
            get
            {
                return "Replace document";
            }
        }

        public DatabaseType Type
        {
            get
            {
                return DatabaseType.DocumentDb;
            }
        }

        public string TextButtonNewCollection
        {
            get
            {
                return "New Collection -->";
            }
        }

        public string TestButtonNewElement
        {
            get
            {
                return "New Document -->";
            }
        }

        public IRepository GetRepository()
        {
            return new DocumentDbRepository(_serviceEndpoint, _authKey, _databaseName);
        }

        public bool CheckConection()
        {
            return DocumentDbConnexion.CheckConnexion(_serviceEndpoint, _authKey);
        }
    }
}
