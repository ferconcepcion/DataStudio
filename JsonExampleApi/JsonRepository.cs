using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Utils;

namespace JsonExampleApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// Json Repository.
    /// </summary>
    public class JsonRepository : IRepository
    {
        #region Constants and private members

        private const string _jsonExampleAssemblyFileName = "Json.Portugal.json";
        private const string _messageModifyElements = "Operation completed, but this is a test json database, changes will lose when you exit...";

        private JObject _json;
        
        #endregion

        #region Constructor

        public JsonRepository()
        {
            var str = GetStreamFromJson();

            // Assign the JObject
            GetJsonsCollections(str);
        }

        public JsonRepository(string jsonContent)
        {
            // Parse to JObject
            _json = JObject.Parse(jsonContent);
        }

        #endregion

        #region Select

        public IList<string> GetCollections()
        {
            try
            {
                return _json.Properties().Select(x => x.Name).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }

        public IList<string> GetElementsIds(string collectionName)
        {
            try
            {
                var elementsArray = _json[collectionName].ToArray();

                return elementsArray.Select(x => x.SelectToken("_id").ToString()).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }

        public string GetElements(string collectionName)
        {
            try
            {
                return _json[collectionName].ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string GetElement(string collectionName, string elementId)
        {
            try
            {
                var elementsArray = _json[collectionName].ToArray();

                return elementsArray
                    .SingleOrDefault(x => x.SelectToken("_id").ToString() == elementId)
                    .ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        #endregion

        #region Insert
        
        public bool InsertCollection(string newCollectionName, out string comments)
        {
            try
            {
                if (_json[newCollectionName] != null)
                {
                    comments = "The collection exists yet!";
                    return false;
                }
                else
                {
                    _json[newCollectionName] = JArray.Parse("[]");
                    comments = _messageModifyElements;
                    return true;
                }
            }
            catch (Exception e)
            {
                comments = e.Message;
                return false;
            }
        }

        public bool InsertElement(string collectionName, string newElement, out string comments)
        {
            try
            {
                if (_json[collectionName] != null)
                {
                    var elements = JArray.Parse(_json[collectionName].ToString());
                    elements.Add(JToken.Parse(newElement));

                    _json[collectionName] = elements;
                    
                    comments = _messageModifyElements;
                    return true;
                }
                else
                {
                    comments = "Invalid collection selected!";
                    return false;
                }
            }
            catch (Exception e)
            {
                comments = e.Message;
                return false;
            }
        }

        #endregion

        #region Update

        public string ReplaceElement(string collectionName, string elementId, string elementEdited)
        {
            try
            {
                var elementsArray = _json[collectionName].ToArray();

                elementsArray
                    .SingleOrDefault(x => x.SelectToken("_id").ToString() == elementId)
                    .Replace(JToken.Parse(elementEdited));
                return elementEdited;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        
        #endregion

        #region Delete

        public bool DeleteCollection(string collectionName, out string comments)
        {
            try
            {
                if (_json[collectionName] != null)
                {
                    _json.Remove(collectionName);
                    comments = _messageModifyElements;
                    return true;
                }
                else
                {
                    comments = "Invalid collection selected!";
                    return false;
                }
            }
            catch (Exception e)
            {
                comments = e.Message;
                return false;
            }
        }

        public bool DeleteElement(string collectionName, string elementId, out string comments)
        {
            try
            {
                if (_json[collectionName] != null)
                {
                    _json[collectionName].ToArray()
                        .SingleOrDefault(x => x.SelectToken("_id").ToString() == elementId)
                        .Remove();
                    comments = _messageModifyElements;
                    return true;
                }
                else
                {
                    comments = "Invalid collection selected!";
                    return false;
                }
            }
            catch (Exception e)
            {
                comments = e.Message;
                return false;
            }
        }

        #endregion

        #region Query

        public string ExecuteQuery(string query, string collectionName, out string comments)
        {
            try
            {
                var result = _json.SelectTokens(
                    string.Format("$.{0}{1}", collectionName, query));

                JArray elements = new JArray();
                foreach (var element in result)
                {
                    elements.Add(element);
                }

                comments = "Correct Query!";

                return elements.ToString();
            }
            catch (Exception e)
            {
                comments = "ERROR";
                return e.ToString();
            }
        }

        public string GetJsonGeneral()
        {
            try
            {
                return _json.ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        #endregion

        #region Private and secundary methods

        private void GetJsonsCollections(Stream str)
        {
            string jsonString;

            // Read the stream
            using (var reader = new StreamReader(str))
            {
                jsonString = reader.ReadToEnd();
            }

            // Parse to JObject
            _json = JObject.Parse(jsonString);
        }

        private Stream GetStreamFromJson()
        {
            string template = typeof(JsonRepository).Namespace + "." + _jsonExampleAssemblyFileName;
            Assembly assem = Assembly.GetExecutingAssembly();
            return assem.GetManifestResourceStream(template);
        }
        
        #endregion
    }
    
}
