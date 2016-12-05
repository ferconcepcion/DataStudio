using Microsoft.Azure.Documents.Client;
using System;

namespace DocumentDbApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// DocumentDB checker connection.
    /// </summary>
    public static class DocumentDbConnexion
    {
        /// <summary>
        /// Create a client and check the connection parameters.
        /// </summary>
        /// <param name="serviceEndpoint">Endpoint</param>
        /// <param name="authKey">Auth Key</param>
        /// <returns>Check value connection</returns>
        public static bool CheckConnexion(string serviceEndpoint, string authKey)
        {
            try
            {
                var client = new DocumentClient(new Uri(serviceEndpoint), authKey);
                return (client.ServiceEndpoint != null || client.ReadEndpoint != null);
            }
            catch
            {
                return false;
            }
        }
    }
}
