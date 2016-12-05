using DocumentDbApi;
using DynamoDbApi;
using JsonExampleApi;
using MongoDbApi;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Utils;

namespace DatabaseStudio
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// Config Panel class.
    /// This panel is to select a NOSQL database and configurate the client.
    /// </summary>
    public partial class Config : Form
    {
        private IMainPanel _homePanel;

        private string _jsonFileContent;

        /// <summary>
        /// Configuration panel with the Main Panel.
        /// </summary>
        /// <param name="homePanel">Main Panel interface</param>
        public Config(IMainPanel homePanel)
        {
            InitializeComponent();

            _homePanel = homePanel;
            _jsonFileContent = string.Empty;
            
            cbDatabaseType.DataSource = Constants.DatabaseTypeStrings.Values.ToList();
        }

        /// <summary>
        /// Check if is it complete the entries of database configuration.
        /// </summary>
        /// <returns>The check result</returns>
        private bool CheckConfiguration()
        {
            if (Constants.DatabaseTypeStrings[(int)DatabaseType.JsonExample] == cbDatabaseType.Text)
            {
                return true;
            }
            else if (Constants.DatabaseTypeStrings[(int)DatabaseType.MongoDb] == cbDatabaseType.Text)
            {
                return (!string.IsNullOrWhiteSpace(txtMongodbDatabase.Text)
                    && !string.IsNullOrWhiteSpace(txtMongodbConnectionString.Text));
            }
            else if (Constants.DatabaseTypeStrings[(int)DatabaseType.DocumentDb] == cbDatabaseType.Text)
            {
                return (!string.IsNullOrWhiteSpace(txtDocumentdbAuthKey.Text)
                    && !string.IsNullOrWhiteSpace(txtDocumentDbDatabase.Text)
                    && !string.IsNullOrWhiteSpace(txtDocumentdbEndPoint.Text));
            }
            else if (Constants.DatabaseTypeStrings[(int)DatabaseType.DynamoDb] == cbDatabaseType.Text)
            {
                return (!string.IsNullOrWhiteSpace(txtDynamoDbAccessKey.Text)
                    && !string.IsNullOrWhiteSpace(txtDynamoDbSecretKey.Text)
                    && !string.IsNullOrWhiteSpace(txtDynamoDbRegion.Text));
            }
            else return false;
        }

        /// <summary>
        /// Get the Configuration of a selected database with the selected parameters.
        /// </summary>
        /// <returns></returns>
        private IConfiguration GetConfiguration()
        {
            IConfiguration extractConf;
            if (Constants.DatabaseTypeStrings[(int)DatabaseType.JsonExample] == cbDatabaseType.Text)
            {
                if (string.IsNullOrWhiteSpace(_jsonFileContent))
                {
                    extractConf = new JsonConfiguration();
                }
                else
                {
                    extractConf = new JsonConfiguration(_jsonFileContent);
                }
            }
            else if (Constants.DatabaseTypeStrings[(int)DatabaseType.MongoDb] == cbDatabaseType.Text)
            {
                extractConf = new MondoDbConfiguration(txtMongodbConnectionString.Text, 
                    txtMongodbDatabase.Text);
            }
            else if (Constants.DatabaseTypeStrings[(int)DatabaseType.DocumentDb] == cbDatabaseType.Text)
            {
                extractConf = new DocumentDbConfiguration(txtDocumentdbEndPoint.Text,
                    txtDocumentdbAuthKey.Text,
                    txtDocumentDbDatabase.Text);
            }
            else if (Constants.DatabaseTypeStrings[(int)DatabaseType.DynamoDb] == cbDatabaseType.Text)
            {
                extractConf = new DynamoDbConfiguration(txtDynamoDbAccessKey.Text,
                    txtDynamoDbSecretKey.Text, txtDynamoDbRegion.Text);
            }
            else
            {
                MessageBox.Show("Invalid selected database",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                extractConf = null;
            }

            return extractConf;
        }

        private void cbDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlJson.Visible = (Constants.DatabaseTypeStrings[(int)DatabaseType.JsonExample] == cbDatabaseType.Text);
            pnlMongodb.Visible = (Constants.DatabaseTypeStrings[(int)DatabaseType.MongoDb] == cbDatabaseType.Text);
            pnlDocumentdb.Visible = (Constants.DatabaseTypeStrings[(int)DatabaseType.DocumentDb] == cbDatabaseType.Text);
            pnlDynamoDb.Visible = (Constants.DatabaseTypeStrings[(int)DatabaseType.DynamoDb] == cbDatabaseType.Text);
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (CheckConfiguration())
            {
                var configurationDatabase = GetConfiguration();
                if (!configurationDatabase.CheckConection())
                {
                    MessageBox.Show("Not valid connection, check your params",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _homePanel.SetConfiguration(GetConfiguration());
                    this.Close();
                }

            }
        }

        #region JSON

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JSon File|*.json";
            openFileDialog1.Title = "Load a json File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(openFileDialog1.FileName))
                {
                    _jsonFileContent = reader.ReadToEnd();
                    reader.Close();
                    lblFileJson.Text = openFileDialog1.FileName;
                }
            }
        }

        #endregion
    }
}
