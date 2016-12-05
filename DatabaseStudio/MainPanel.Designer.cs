namespace DatabaseStudio
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.lblCollections = new System.Windows.Forms.Label();
            this.pnlCollections = new System.Windows.Forms.ListBox();
            this.pnlElements = new System.Windows.Forms.ListBox();
            this.lblElements = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconfigureDatabaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.insertElementDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteElementDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.executeQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutDataStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNewElement = new System.Windows.Forms.Button();
            this.btnDeleteElement = new System.Windows.Forms.Button();
            this.btnDeleteCollection = new System.Windows.Forms.Button();
            this.txtNewCollection = new System.Windows.Forms.TextBox();
            this.btnNewCollection = new System.Windows.Forms.Button();
            this.lblQuery = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCollections
            // 
            this.lblCollections.AutoSize = true;
            this.lblCollections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollections.Location = new System.Drawing.Point(30, 34);
            this.lblCollections.Name = "lblCollections";
            this.lblCollections.Size = new System.Drawing.Size(69, 13);
            this.lblCollections.TabIndex = 0;
            this.lblCollections.Text = "Collections";
            // 
            // pnlCollections
            // 
            this.pnlCollections.FormattingEnabled = true;
            this.pnlCollections.Location = new System.Drawing.Point(33, 70);
            this.pnlCollections.Name = "pnlCollections";
            this.pnlCollections.Size = new System.Drawing.Size(216, 82);
            this.pnlCollections.TabIndex = 1;
            this.pnlCollections.SelectedIndexChanged += new System.EventHandler(this.pnlCollections_SelectedIndexChanged);
            // 
            // pnlElements
            // 
            this.pnlElements.FormattingEnabled = true;
            this.pnlElements.Location = new System.Drawing.Point(33, 240);
            this.pnlElements.Name = "pnlElements";
            this.pnlElements.Size = new System.Drawing.Size(216, 199);
            this.pnlElements.TabIndex = 3;
            this.pnlElements.SelectedIndexChanged += new System.EventHandler(this.pnlElements_SelectedIndexChanged);
            // 
            // lblElements
            // 
            this.lblElements.AutoSize = true;
            this.lblElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElements.Location = new System.Drawing.Point(30, 207);
            this.lblElements.Name = "lblElements";
            this.lblElements.Size = new System.Drawing.Size(70, 13);
            this.lblElements.TabIndex = 2;
            this.lblElements.Text = "Documents";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(433, 70);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(474, 503);
            this.txtResult.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconfigureDatabaseConnectionToolStripMenuItem,
            this.saveChangesToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reconfigureDatabaseConnectionToolStripMenuItem
            // 
            this.reconfigureDatabaseConnectionToolStripMenuItem.Name = "reconfigureDatabaseConnectionToolStripMenuItem";
            this.reconfigureDatabaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.reconfigureDatabaseConnectionToolStripMenuItem.Text = "Configure database connection";
            this.reconfigureDatabaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.reconfigureDatabaseConnectionToolStripMenuItem_Click);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.saveChangesToolStripMenuItem.Text = "Extract to Json File";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertCollectionToolStripMenuItem,
            this.deleteCollectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.insertElementDocumentToolStripMenuItem,
            this.deleteElementDocumentToolStripMenuItem,
            this.toolStripSeparator4,
            this.executeQueryToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationToolStripMenuItem.Text = "Operations";
            // 
            // insertCollectionToolStripMenuItem
            // 
            this.insertCollectionToolStripMenuItem.Name = "insertCollectionToolStripMenuItem";
            this.insertCollectionToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.insertCollectionToolStripMenuItem.Text = "Insert Collection / Table";
            this.insertCollectionToolStripMenuItem.Click += new System.EventHandler(this.insertCollectionToolStripMenuItem_Click);
            // 
            // deleteCollectionToolStripMenuItem
            // 
            this.deleteCollectionToolStripMenuItem.Name = "deleteCollectionToolStripMenuItem";
            this.deleteCollectionToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.deleteCollectionToolStripMenuItem.Text = "Delete Collection / Table";
            this.deleteCollectionToolStripMenuItem.Click += new System.EventHandler(this.deleteCollectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // insertElementDocumentToolStripMenuItem
            // 
            this.insertElementDocumentToolStripMenuItem.Name = "insertElementDocumentToolStripMenuItem";
            this.insertElementDocumentToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.insertElementDocumentToolStripMenuItem.Text = "Insert Document / Register";
            this.insertElementDocumentToolStripMenuItem.Click += new System.EventHandler(this.insertElementDocumentToolStripMenuItem_Click);
            // 
            // deleteElementDocumentToolStripMenuItem
            // 
            this.deleteElementDocumentToolStripMenuItem.Name = "deleteElementDocumentToolStripMenuItem";
            this.deleteElementDocumentToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.deleteElementDocumentToolStripMenuItem.Text = "Delete Document / Register";
            this.deleteElementDocumentToolStripMenuItem.Click += new System.EventHandler(this.deleteElementDocumentToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(216, 6);
            // 
            // executeQueryToolStripMenuItem
            // 
            this.executeQueryToolStripMenuItem.Name = "executeQueryToolStripMenuItem";
            this.executeQueryToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.executeQueryToolStripMenuItem.Text = "Execute Query";
            this.executeQueryToolStripMenuItem.Click += new System.EventHandler(this.executeQueryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findHelpToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutDataStudioToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // findHelpToolStripMenuItem
            // 
            this.findHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.officialDocumentationToolStripMenuItem,
            this.GitHubToolStripMenuItem});
            this.findHelpToolStripMenuItem.Name = "findHelpToolStripMenuItem";
            this.findHelpToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.findHelpToolStripMenuItem.Text = "Find Help";
            // 
            // officialDocumentationToolStripMenuItem
            // 
            this.officialDocumentationToolStripMenuItem.Name = "officialDocumentationToolStripMenuItem";
            this.officialDocumentationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.officialDocumentationToolStripMenuItem.Text = "Official Documentation...";
            this.officialDocumentationToolStripMenuItem.Click += new System.EventHandler(this.officialDocumentationToolStripMenuItem_Click);
            // 
            // GitHubToolStripMenuItem
            // 
            this.GitHubToolStripMenuItem.Name = "GitHubToolStripMenuItem";
            this.GitHubToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.GitHubToolStripMenuItem.Text = "GitHub Information";
            this.GitHubToolStripMenuItem.Click += new System.EventHandler(this.GitHubToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // aboutDataStudioToolStripMenuItem
            // 
            this.aboutDataStudioToolStripMenuItem.Name = "aboutDataStudioToolStripMenuItem";
            this.aboutDataStudioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutDataStudioToolStripMenuItem.Text = "About Data Studio";
            this.aboutDataStudioToolStripMenuItem.Click += new System.EventHandler(this.aboutDataStudioToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(433, 579);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Element";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewElement
            // 
            this.btnNewElement.Location = new System.Drawing.Point(272, 240);
            this.btnNewElement.Name = "btnNewElement";
            this.btnNewElement.Size = new System.Drawing.Size(141, 23);
            this.btnNewElement.TabIndex = 7;
            this.btnNewElement.Text = "New document -->";
            this.btnNewElement.UseVisualStyleBackColor = true;
            this.btnNewElement.Click += new System.EventHandler(this.btnNewElement_Click);
            // 
            // btnDeleteElement
            // 
            this.btnDeleteElement.Location = new System.Drawing.Point(33, 446);
            this.btnDeleteElement.Name = "btnDeleteElement";
            this.btnDeleteElement.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteElement.TabIndex = 8;
            this.btnDeleteElement.Text = "Delete Element";
            this.btnDeleteElement.UseVisualStyleBackColor = true;
            this.btnDeleteElement.Click += new System.EventHandler(this.btnDeleteElement_Click);
            // 
            // btnDeleteCollection
            // 
            this.btnDeleteCollection.Location = new System.Drawing.Point(33, 158);
            this.btnDeleteCollection.Name = "btnDeleteCollection";
            this.btnDeleteCollection.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCollection.TabIndex = 9;
            this.btnDeleteCollection.Text = "Delete";
            this.btnDeleteCollection.UseVisualStyleBackColor = true;
            this.btnDeleteCollection.Click += new System.EventHandler(this.btnDeleteCollection_Click);
            // 
            // txtNewCollection
            // 
            this.txtNewCollection.Location = new System.Drawing.Point(130, 160);
            this.txtNewCollection.Name = "txtNewCollection";
            this.txtNewCollection.Size = new System.Drawing.Size(119, 20);
            this.txtNewCollection.TabIndex = 10;
            // 
            // btnNewCollection
            // 
            this.btnNewCollection.Location = new System.Drawing.Point(272, 158);
            this.btnNewCollection.Name = "btnNewCollection";
            this.btnNewCollection.Size = new System.Drawing.Size(141, 23);
            this.btnNewCollection.TabIndex = 11;
            this.btnNewCollection.Text = "New collection -->";
            this.btnNewCollection.UseVisualStyleBackColor = true;
            this.btnNewCollection.Click += new System.EventHandler(this.btnNewCollection_Click);
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuery.Location = new System.Drawing.Point(30, 487);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(40, 13);
            this.lblQuery.TabIndex = 12;
            this.lblQuery.Text = "Query";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(33, 514);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(216, 58);
            this.txtQuery.TabIndex = 13;
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Location = new System.Drawing.Point(33, 579);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(106, 23);
            this.btnExecuteQuery.TabIndex = 14;
            this.btnExecuteQuery.Text = "Execute Query";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 657);
            this.Controls.Add(this.btnExecuteQuery);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.btnNewCollection);
            this.Controls.Add(this.txtNewCollection);
            this.Controls.Add(this.btnDeleteCollection);
            this.Controls.Add(this.btnDeleteElement);
            this.Controls.Add(this.btnNewElement);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.pnlElements);
            this.Controls.Add(this.lblElements);
            this.Controls.Add(this.pnlCollections);
            this.Controls.Add(this.lblCollections);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Studio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCollections;
        private System.Windows.Forms.ListBox pnlCollections;
        private System.Windows.Forms.ListBox pnlElements;
        private System.Windows.Forms.Label lblElements;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconfigureDatabaseConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertElementDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteElementDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officialDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDataStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNewElement;
        private System.Windows.Forms.Button btnDeleteElement;
        private System.Windows.Forms.Button btnDeleteCollection;
        private System.Windows.Forms.TextBox txtNewCollection;
        private System.Windows.Forms.Button btnNewCollection;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem executeQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}