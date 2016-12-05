using Newtonsoft.Json.Linq;

namespace JsonExampleApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// Json checker connection.
    /// </summary>
    public static class JsonConnection
    {
        /// <summary>
        /// Validate the json content.
        /// </summary>
        /// <param name="jsonContent">Json content string</param>
        /// <returns>The check value</returns>
        public static bool CheckConnexion(string jsonContent)
        {
            try
            {
                var jObj = JObject.Parse(jsonContent);
                return (!string.IsNullOrWhiteSpace(jObj.ToString()));
            }
            catch
            {
                return false;
            }
        }
    }
}
