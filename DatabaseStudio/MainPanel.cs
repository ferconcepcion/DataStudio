using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Utils;

namespace DatabaseStudio
{
    /// <summary>
    /// Database Studio
    /// Author: Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// 
    /// Main Panel interface to externally use
    /// </summary>
    public interface IMainPanel
    {
        void SetConfiguration(IConfiguration configuration);
    }

    /// <summary>
    /// Main Panel class
    /// </summary>
    public partial class MainPanel : Form, IMainPanel
    {
        #region Constants and private members

        private const string _confirmationTitleMessage = "Done";
        private const string _errorTitleMessage = "Error";
        private const string _confirmationContentMessage = "Operation completed!";
        private const string _insertText = "Insert element";
        private const string _updateText = "Update element";
        private const string _collectionNameError = "Invalid collection name!";
        private const string _queryError = "Invalid query!";

        private IConfiguration _configuration;
        private IRepository _repository;

        #endregion

        #region Constructor and Initialize methods

        /// <summary>
        /// Main Panel Constructor.
        /// Enable the Configuration Panel to configure a new database connection.
        /// Disable the buttons.
        /// </summary>
        public MainPanel()
        {
            InitializeComponent();

            SetEnabledConfiguration(false);

            var configPanel = new Config(this);
            configPanel.Show(this);
        }

        /// <summary>
        /// Main Panel Constructor with a database configuration
        /// Get the database configuration choosen, enable the buttons and options.
        /// Show the collections or tables.
        /// </summary>
        /// <param name="configuration">Database configuration</param>
        public MainPanel(IConfiguration configuration)
        {
            InitializeComponent();
            _configuration = configuration;
            _repository = _configuration.GetRepository();

            SetEnabledConfiguration(true);

            ShowConfiguration();
            ShowCollections();
        }

        /// <summary>
        /// Show the text and buttons texts.
        /// </summary>
        private void ShowConfiguration()
        {
            lblCollections.Text = _configuration.TextLabelCollections;
            lblElements.Text = _configuration.TextLabelElements;
            lblQuery.Text = _configuration.TextNameQuery;
            executeQueryToolStripMenuItem.Text = _configuration.TextExecuteQuery;
            btnExecuteQuery.Text = _configuration.TextExecuteQuery;
            txtQuery.Text = _configuration.ExampleQuery;
            deleteElementDocumentToolStripMenuItem.Text = _configuration.TextDeleteElement;
            btnDeleteElement.Text = _configuration.TextDeleteElement;
            deleteCollectionToolStripMenuItem.Text = _configuration.TextDeleteCollection;
            btnDeleteCollection.Text = _configuration.TextDeleteCollection;
            insertCollectionToolStripMenuItem.Text = _configuration.TextInsertCollection;
            insertElementDocumentToolStripMenuItem.Text = _configuration.TextInsertElement;
            btnNewCollection.Text = _configuration.TextButtonNewCollection;
            btnNewElement.Text = _configuration.TestButtonNewElement;
        }

        /// <summary>
        /// Enable or disable buttons and options.
        /// </summary>
        /// <param name="enabled">Enable/disable option</param>
        private void SetEnabledConfiguration(bool enabled)
        {
            btnDeleteCollection.Enabled = enabled;
            btnDeleteElement.Enabled = enabled;
            btnExecuteQuery.Enabled = enabled;
            btnNewCollection.Enabled = enabled;
            btnNewElement.Enabled = enabled;
            btnUpdate.Enabled = enabled;

            deleteElementDocumentToolStripMenuItem.Enabled = enabled;
            deleteCollectionToolStripMenuItem.Enabled = enabled;
            executeQueryToolStripMenuItem.Enabled = enabled;
            insertCollectionToolStripMenuItem.Enabled = enabled;
            insertElementDocumentToolStripMenuItem.Enabled = enabled;
            saveChangesToolStripMenuItem.Enabled = enabled;
        }

        /// <summary>
        /// Set the configuration and extract the database repository object.
        /// Enable configuration and show the collections.
        /// </summary>
        /// <param name="configuration">Database configuration</param>
        public void SetConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
            _repository = _configuration.GetRepository();

            SetEnabledConfiguration(true);

            ShowConfiguration();
            ShowCollections();
        }

        #endregion

        #region Collections methods

        /// <summary>
        /// Show collections or tables from the database repository.
        /// </summary>
        private void ShowCollections()
        {
            pnlCollections.DataSource = _repository.GetCollections();

            if (pnlCollections.Items.Count == 0)
            {
                pnlElements.DataSource = null;
                pnlElements.Items.Clear();
                txtResult.Clear();
                btnUpdate.Visible = false;
                insertElementDocumentToolStripMenuItem.Enabled = false;
                btnNewElement.Enabled = false;
            }
        }

        /// <summary>
        /// Get elements/documents/items from a selected collection or table
        /// </summary>
        private void SelectCollection()
        {
            txtResult.Text = _repository.GetElements((string)pnlCollections.SelectedValue).Pretty();
        }

        /// <summary>
        /// Try to insert a collection or a table and show the result.
        /// </summary>
        private void InsertCollection()
        {
            string comments;

            if (string.IsNullOrWhiteSpace(txtNewCollection.Text))
            {
                MessageBox.Show(_collectionNameError,
                    _errorTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_repository.InsertCollection(txtNewCollection.Text, out comments))
            {
                ShowCollections();
                MessageBox.Show(string.IsNullOrWhiteSpace(comments) ? _confirmationContentMessage : comments,
                    _confirmationTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(comments,
                    _errorTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Try to delete a collection or a table and show the result.
        /// </summary>
        private void DeleteCollection()
        {
            string comments;
            if (_repository.DeleteCollection((string)pnlCollections.SelectedValue, out comments))
            {
                ShowCollections();
                MessageBox.Show(string.IsNullOrWhiteSpace(comments) ? _confirmationContentMessage : comments,
                    _confirmationTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(comments,
                    _errorTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Elements methods

        /// <summary>
        /// Show the Json element/document/item selected.
        /// </summary>
        private void SelectElement()
        {
            txtResult.Text = _repository.GetElement((string)pnlCollections.SelectedValue,
                    (string)pnlElements.SelectedValue).Pretty();
        }

        /// <summary>
        /// Try to insert a new element/document/item from the json panel and show the result.
        /// </summary>
        private void InsertElement()
        {
            string comments;
            if (_repository.InsertElement((string)pnlCollections.SelectedValue,
                txtResult.Text, out comments))
            {
                ShowCollections();
                MessageBox.Show(string.IsNullOrWhiteSpace(comments) ? _confirmationContentMessage : comments,
                    _confirmationTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(comments,
                    _errorTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Try to delete the selected element/document/item and show the result.
        /// </summary>
        private void DeleteElement()
        {
            string comments;
            if (_repository.DeleteElement((string)pnlCollections.SelectedValue,
                (string)pnlElements.SelectedValue, out comments))
            {
                ShowCollections();
                MessageBox.Show(string.IsNullOrWhiteSpace(comments) ? _confirmationContentMessage : comments,
                    _confirmationTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(comments,
                    _errorTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Try to update the selected element/document/item from the json panel and show the result.
        /// </summary>
        private void UpdateElement()
        {
            _repository.ReplaceElement((string)pnlCollections.SelectedValue,
                (string)pnlElements.SelectedValue,
                txtResult.Text);
            ShowCollections();
            MessageBox.Show(_confirmationContentMessage,
                    _confirmationTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Execute Query methods

        /// <summary>
        /// Try to execute a query from a query panel using the selected table or collection.
        /// Show the result.
        /// </summary>
        private void ExecuteQuery()
        {
            if (!string.IsNullOrWhiteSpace(txtQuery.Text))
            {
                string comments;
                var result = _repository.ExecuteQuery(txtQuery.Text, 
                    (string)pnlCollections.SelectedValue, out comments).Pretty();
                if (!string.IsNullOrWhiteSpace(result))
                {
                    txtResult.Text = result;
                }
                else
                {
                    MessageBox.Show(comments,
                        _errorTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(_queryError,
                    _errorTitleMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Panels Events Methods

        private void btnNewCollection_Click(object sender, EventArgs e)
        {
            InsertCollection();
        }

        private void pnlCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlCollections.SelectedIndices.Count > 0)
            {
                pnlElements.DataSource = _repository.GetElementsIds((string)pnlCollections.SelectedValue);

                SelectCollection();

                pnlElements.ClearSelected();
                pnlElements.SelectionMode = SelectionMode.One;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                insertElementDocumentToolStripMenuItem.Enabled = false;
                btnNewCollection.Enabled = true;
            }
            else
            {
                txtResult.Clear();
            }
        }

        private void pnlElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlElements.SelectedIndices.Count > 0)
            {
                SelectElement();

                btnUpdate.Enabled = true;
                btnUpdate.Text = _updateText;
                btnUpdate.Visible = true;
                insertElementDocumentToolStripMenuItem.Enabled = true;
                insertElementDocumentToolStripMenuItem.Text = _updateText;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                insertElementDocumentToolStripMenuItem.Enabled = false;
            }
        }

        #endregion

        #region Buttons events
        
        private void btnDeleteCollection_Click(object sender, EventArgs e)
        {
            DeleteCollection();
        }

        private void btnNewElement_Click(object sender, EventArgs e)
        {
            pnlElements.ClearSelected();
            pnlElements.SelectionMode = SelectionMode.One;
            txtResult.Clear();

            pnlElements.ClearSelected();
            pnlElements.SelectionMode = SelectionMode.One;

            btnUpdate.Enabled = true;
            btnUpdate.Text = _insertText;
            btnUpdate.Visible = true;
            insertElementDocumentToolStripMenuItem.Enabled = true;
            insertElementDocumentToolStripMenuItem.Text = _insertText;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (pnlElements.SelectedIndex >= 0)
            {
                UpdateElement();
            }
            else
            {
                InsertElement();
            }
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            DeleteElement();
        }
        
        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            ExecuteQuery();

            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            insertElementDocumentToolStripMenuItem.Enabled = false;
        }

        #endregion

        #region ToolStrip Menu events

        #region File

        private void reconfigureDatabaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configPanel = new Config(this);
            configPanel.Show(this);
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSon File|*.json";
            saveFileDialog1.Title = "Save an json File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (!string.IsNullOrWhiteSpace(saveFileDialog1.FileName))
            {
                var json = _repository.GetJsonGeneral();

                using (var file = new StreamWriter(saveFileDialog1.FileName))
                {
                    file.Write(json);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Operations

        private void insertCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNewCollection_Click(sender, e);
        }

        private void deleteCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteCollection_Click(sender, e);
        }

        private void insertElementDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNewElement_Click(sender, e);
        }

        private void deleteElementDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteElement_Click(sender, e);
        }

        private void executeQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExecuteQuery_Click(sender, e);
        }

        #endregion

        #region Help

        private void aboutDataStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutPanel = new About();
            aboutPanel.Show(this);
        }

        private void officialDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.fconcepcion.com/"));
        }

        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/ferconcepcion/DataStudio"));
        }

        #endregion

        #endregion
    }
        
}
