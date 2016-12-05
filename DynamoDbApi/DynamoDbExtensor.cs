using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamoDbApi
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// DynamoDb Extensor functions to extract json strings.
    /// </summary>
    public static class DynamoDbExtensor
    {
        public static string ToJson(this AttributeValue attribute)
        {
            return (attribute.S == null ? "" : "\"" + attribute.S + "\"") +
                (attribute.N == null ? "" : attribute.N) +
                (!attribute.IsBOOLSet ? "" : attribute.BOOL.ToString()) +
                (!attribute.IsLSet ? "" : attribute.L.Count == 0 ? "" : "[" + string.Join(",", attribute.L.ToArray().Select(x=>x.ToJson()).ToList()) +"]") +
                (!attribute.IsMSet ? "" : attribute.M.ToJson()) +
                (attribute.SS == null || attribute.SS.Count == 0 ? "" : "[\"" + string.Join(",\"", attribute.SS.ToArray()) + "\"]") +
                (attribute.NS == null || attribute.NS.Count == 0 ? "" : "[" + string.Join(",", attribute.NS.ToArray()));

        }

        public static string ToJson(this Dictionary<string, AttributeValue> attributeList)
        {
            return (new List<Dictionary<string, AttributeValue>>
            {
                { attributeList }
            }).ToJson();
        }
            
        public static string ToJson(this List<Dictionary<string, AttributeValue>> attributeList)
        {
            var str = new StringBuilder();
            var nItem = 0;
            var nAttr = 0;

            foreach (var dic in attributeList)
            {
                if (nItem != 0)
                {
                    str.AppendLine(",");
                }
                str.Append("{");

                foreach (var kvp in dic)
                {
                    if (nAttr != 0)
                    {
                        str.AppendLine(",");
                    }
                    var attributeName = kvp.Key;
                    var value = kvp.Value;

                    str.AppendLine();
                    
                    str.AppendFormat("\"{0}\":{1}", attributeName, value.ToJson());
                    nAttr++;
                }
                
                str.AppendLine("}");
                nItem++;
            }


            return str.ToString();
        }

        public static string TablesToJson(this Dictionary<string, string> dicJsones)
        {
            var jsonBuilder = new StringBuilder();
            jsonBuilder.Append("{");

            foreach (var pair in dicJsones)
            {
                jsonBuilder.AppendLine();
                jsonBuilder.AppendFormat("\"{0}\":[{1}]", pair.Key, pair.Value);
            }
            jsonBuilder.AppendLine("}");

            return jsonBuilder.ToString();
        }
    }
}
