using System.Collections.Generic;
using Utils;

namespace DatabaseStudio
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// Constants class.
    /// </summary>
    public static class Constants
    {
        public static readonly IDictionary<int, string> DatabaseTypeStrings = 
            new Dictionary<int, string>
        {
            {(int)DatabaseType.JsonExample, "Json Example"},
            {(int)DatabaseType.MongoDb, "MongoDB"},
            {(int)DatabaseType.DocumentDb, "Azure DocumentDB"},
            {(int)DatabaseType.DynamoDb, "Amazon DynamoDB"},
        };

    }
}
