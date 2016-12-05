namespace Utils
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// This is a interface to use as configuration to the Database Studio project.
    /// This configuration includes the names of labels and texts, and the repository
    /// to use.
    /// </summary>
    public interface IConfiguration
    {
        DatabaseType Type { get; }

        string TextLabelCollections { get; }
        string TextLabelElements { get; }
        string TextNameDatabase { get; set; }
        string TextInsertElement { get; }
        string TextUpdateElement { get; }
        string TextDeleteElement { get; }
        string TextInsertCollection { get; }
        string TextDeleteCollection { get; }

        string TextNameQuery { get; }
        string ExampleQuery { get; }
        string TextExecuteQuery { get; }

        string TextButtonNewCollection { get; }
        string TestButtonNewElement { get; }

        IRepository GetRepository();

        bool CheckConection();
    }
}
