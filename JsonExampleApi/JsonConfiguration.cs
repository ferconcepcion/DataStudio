using System;
using Utils;

namespace JsonExampleApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// Json Configuration.
    /// </summary>
    public class JsonConfiguration : IConfiguration
    {
        private string _stringJsonContent;
        private bool _useStreamExample;

        public JsonConfiguration()
        {
            TextNameDatabase = "Portugal";
            _useStreamExample = true;
            _stringJsonContent = string.Empty;
        }

        public JsonConfiguration(string stringJsonContent)
        {
            TextNameDatabase = "Stream";
            _useStreamExample = false;
            _stringJsonContent = stringJsonContent;
        }

        public DatabaseType Type
        {
            get
            {
                return DatabaseType.JsonExample;
            }
        }

        public string TextLabelCollections
        {
            get
            {
                return "Collections";
            }
        }

        public string TextNameDatabase { get; set; }

        public string TextLabelElements
        {
            get
            {
                return "Elements";
            }
        }

        public string TextInsertElement
        {
            get
            {
                return "Insert document";
            }
        }

        public string TextUpdateElement
        {
            get
            {
                return "Update document";
            }
        }

        public string TextDeleteElement
        {
            get
            {
                return "Delete document";
            }
        }

        public string TextInsertCollection
        {
            get
            {
                return "Insert collection";
            }
        }

        public string TextDeleteCollection
        {
            get
            {
                return "Delete collection";
            }
        }

        public string ExampleQuery
        {
            get
            {
                return "[?(@.population > 150000)].description";
            }
        }

        public string TextNameQuery
        {
            get
            {
                return "JSonPath query to execute";
            }
        }

        public string TextExecuteQuery
        {
            get
            {
                return "Execute query";
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
            if (_useStreamExample)
            {
                return new JsonRepository();
            }
            else
            {
                return new JsonRepository(_stringJsonContent);
            }
        }

        public bool CheckConection()
        {
            if (_useStreamExample)
            {
                return true;
            }
            else
            {
                return JsonConnection.CheckConnexion(_stringJsonContent);
            }
        }
    }
}
