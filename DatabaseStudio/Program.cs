using System;
using System.Windows.Forms;

namespace DatabaseStudio
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// Program main.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPanel());
        }
    }
}
