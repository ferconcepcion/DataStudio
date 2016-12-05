using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Runtime;

namespace DynamoDbApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// DynamoDB checker connection.
    /// </summary>
    public static class DynamoDbConnection
    {
        /// <summary>
        /// Create a client and check the connection parameters.
        /// </summary>
        /// <param name="accessKey">Access key service</param>
        /// <param name="secretKey">Secret Key service</param>
        /// <param name="region">System region</param>
        /// <returns>Check value connection</returns>
        public static bool CheckConnexion(string accessKey, string secretKey, string region)
        {
            try
            {
                var credentials = new BasicAWSCredentials(accessKey, secretKey);
                var regionEndpoint = RegionEndpoint.GetBySystemName(region);

                var client = new AmazonDynamoDBClient(credentials, regionEndpoint);
                return client.Config.UserAgent != null;
            }
            catch
            {
                return false;
            }
        }
    }
}
