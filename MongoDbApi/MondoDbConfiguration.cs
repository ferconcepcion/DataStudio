using System;
using Utils;

namespace MongoDbApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// MongoDb Configuration.
    /// </summary>
    public class MondoDbConfiguration : IConfiguration
    {
        #region Private members

        private string _connectionString;
        private string _databaseName;
        private bool _useDefaultConnection;

        #endregion

        #region Constructor

        public MondoDbConfiguration(string databaseName)
        {
            _databaseName = databaseName;
            _connectionString = string.Empty;
            _useDefaultConnection = true;
        }

        public MondoDbConfiguration(string connectionString, string databaseName)
        {
            _databaseName = databaseName;
            _connectionString = connectionString;
            _useDefaultConnection = false;
        }

        #endregion

        public string ExampleQuery
        {
            get
            {
                return "{\"student_id\": 0, \"type\":\"homework\"}";
            }
        }

        public string TestButtonNewElement
        {
            get
            {
                return "New Document -->";
            }
        }

        public string TextButtonNewCollection
        {
            get
            {
                return "New Collection -->";
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
                return "Delete Document";
            }
        }

        public string TextExecuteQuery
        {
            get
            {
                return "Execute MondoDb Query";
            }
        }

        public string TextInsertCollection
        {
            get
            {
                return "Insert Collection";
            }
        }

        public string TextInsertElement
        {
            get
            {
                return "Insert Document";
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

        public string TextNameDatabase { get; set; }

        public string TextNameQuery
        {
            get
            {
                return "Example query";
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
                return DatabaseType.MongoDb;
            }
        }

        public bool CheckConection()
        {
            return _useDefaultConnection ? 
                MongoDbConnection.CheckConnection(string.Empty, true) :
                MongoDbConnection.CheckConnection(_connectionString, false);
        }

        public IRepository GetRepository()
        {
            return _useDefaultConnection ? new MongoDbRepository(_databaseName) : new MongoDbRepository(_connectionString, _databaseName);
        }
    }
}
