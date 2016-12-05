using MongoDB.Driver;

namespace MongoDbApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// MongoDb checker connection.
    /// </summary>
    public static class MongoDbConnection
    {
        /// <summary>
        /// Validate the connection to MongoDB.
        /// </summary>
        /// <param name="connectionString">ConnectionString</param>
        /// <param name="useDefaultConnection">Default connection value</param>
        /// <returns>The check value</returns>
        public static bool CheckConnection(string connectionString, bool useDefaultConnection)
        {
            try
            {
                var client = useDefaultConnection ? 
                    new MongoClient() : new MongoClient(connectionString);
                return client != null;
            }
            catch
            {
                return false;
            }
        }
    }
}
