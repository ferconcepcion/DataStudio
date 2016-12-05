using System.Collections.Generic;

namespace Utils
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// This is a interface to use in the project Database Studio with any repository classes.
    /// of NOSQL databases.
    /// This repository includes the most important operations with a NOSQL Database.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Get the table/collection names
        /// </summary>
        /// <returns>Names IList</returns>
        IList<string> GetCollections();

        /// <summary>
        /// Get the Documents/Elements/Items Ids of a table/collection
        /// </summary>
        /// <param name="collectionName">Collection/Table name</param>
        /// <returns>Ids IList</returns>
        IList<string> GetElementsIds(string collectionName);

        /// <summary>
        /// Get the Json collection Elements/Documents/Items of a table/collection
        /// </summary>
        /// <param name="collectionName">Collection/Table name</param>
        /// <returns>Json string</returns>
        string GetElements(string collectionName);

        /// <summary>
        /// Insert a new collection or table
        /// </summary>
        /// <param name="newCollectionName">Name of the table or collection to insert</param>
        /// <param name="comments">String with comments of the operation</param>
        /// <returns>Operation result</returns>
        bool InsertCollection(string newCollectionName, out string comments);

        /// <summary>
        /// Delete a collection or table
        /// </summary>
        /// <param name="collectionName">Name of the table or collection to delete</param>
        /// <param name="comments">String with comments of the operation</param>
        /// <returns>Operation result</returns>
        bool DeleteCollection(string collectionName, out string comments);

        /// <summary>
        /// Get the json Element/Document/Item
        /// </summary>
        /// <param name="collectionName">Name of collection or table</param>
        /// <param name="elementId">Element/Document/Item Id to get</param>
        /// <returns>Json string</returns>
        string GetElement(string collectionName, string elementId);

        /// <summary>
        /// Insert a new element/document/item in a table or collection
        /// </summary>
        /// <param name="collectionName">The name of the collection or table</param>
        /// <param name="newElement">The Json new element/document/item to insert</param>
        /// <param name="comments">Comments of the operation</param>
        /// <returns>Operation result</returns>
        bool InsertElement(string collectionName, string newElement, out string comments);

        /// <summary>
        /// Insert a existing element/document/item in a table or collection
        /// </summary>
        /// <param name="collectionName">The name of the collection or table</param>
        /// <param name="elementId">The element/item/document id</param>
        /// <param name="elementEdited">The Json element/document/item to update</param>
        /// <returns>The operation result comments</returns>
        string ReplaceElement(string collectionName, string elementId, string elementEdited);

        /// <summary>
        /// Delete a existing element/document/item in a table or collection
        /// </summary>
        /// <param name="collectionName">The name of the collection or table</param>
        /// <param name="elementId">The element/item/document id</param>
        /// <param name="comments">Comments of the operation</param>
        /// <returns>The operation result</returns>
        bool DeleteElement(string collectionName, string elementId, out string comments);

        /// <summary>
        /// Execute a query in a table or collection context
        /// </summary>
        /// <param name="query">String query</param>
        /// <param name="collectionName">Table or collection name</param>
        /// <param name="comments">Comments of the execution query</param>
        /// <returns>Query results</returns>
        string ExecuteQuery(string query, string collectionName, out string comments);

        /// <summary>
        /// Get a json string of all database.
        /// </summary>
        /// <returns>Json string</returns>
        string GetJsonGeneral();

    }
}
