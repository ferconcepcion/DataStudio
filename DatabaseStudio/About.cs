using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DatabaseStudio
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// Abput Panel class.
    /// </summary>
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.fconcepcion.com/"));
        }

        private void linkWebProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.fconcepcion.com/Projects/Project/1"));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/ferconcepcion/DataStudio"));
        }
    }
}
