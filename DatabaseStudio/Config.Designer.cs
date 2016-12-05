namespace DatabaseStudio
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.cbDatabaseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.pnlJson = new System.Windows.Forms.Panel();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.lblFileJson = new System.Windows.Forms.Label();
            this.lblJson = new System.Windows.Forms.Label();
            this.pnlMongodb = new System.Windows.Forms.Panel();
            this.lblMongodbDatabase = new System.Windows.Forms.Label();
            this.txtMongodbDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMongodbConnectionString = new System.Windows.Forms.TextBox();
            this.lblMongodb = new System.Windows.Forms.Label();
            this.pnlDocumentdb = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumentDbDatabase = new System.Windows.Forms.TextBox();
            this.lblDocumentdbEndpoint = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumentdbAuthKey = new System.Windows.Forms.TextBox();
            this.txtDocumentdbEndPoint = new System.Windows.Forms.TextBox();
            this.lblDocumentdb = new System.Windows.Forms.Label();
            this.pnlDynamoDb = new System.Windows.Forms.Panel();
            this.txtDynamoDbRegion = new System.Windows.Forms.TextBox();
            this.lblDynamoDbRegion = new System.Windows.Forms.Label();
            this.lblDynamoDbAccessKey = new System.Windows.Forms.Label();
            this.lblDynamoDbSecretKey = new System.Windows.Forms.Label();
            this.txtDynamoDbSecretKey = new System.Windows.Forms.TextBox();
            this.txtDynamoDbAccessKey = new System.Windows.Forms.TextBox();
            this.lblDynamoDb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlJson.SuspendLayout();
            this.pnlMongodb.SuspendLayout();
            this.pnlDocumentdb.SuspendLayout();
            this.pnlDynamoDb.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDatabaseType
            // 
            this.cbDatabaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabaseType.FormattingEnabled = true;
            this.cbDatabaseType.Location = new System.Drawing.Point(152, 21);
            this.cbDatabaseType.Name = "cbDatabaseType";
            this.cbDatabaseType.Size = new System.Drawing.Size(206, 21);
            this.cbDatabaseType.TabIndex = 0;
            this.cbDatabaseType.SelectedIndexChanged += new System.EventHandler(this.cbDatabaseType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database type";
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(54, 346);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "Begin!";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // pnlJson
            // 
            this.pnlJson.Controls.Add(this.btnLoadJson);
            this.pnlJson.Controls.Add(this.lblFileJson);
            this.pnlJson.Controls.Add(this.lblJson);
            this.pnlJson.Location = new System.Drawing.Point(54, 67);
            this.pnlJson.Name = "pnlJson";
            this.pnlJson.Size = new System.Drawing.Size(304, 164);
            this.pnlJson.TabIndex = 3;
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(3, 66);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(109, 23);
            this.btnLoadJson.TabIndex = 2;
            this.btnLoadJson.Text = "Load a Json File";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // lblFileJson
            // 
            this.lblFileJson.AutoSize = true;
            this.lblFileJson.Location = new System.Drawing.Point(0, 102);
            this.lblFileJson.Name = "lblFileJson";
            this.lblFileJson.Size = new System.Drawing.Size(68, 13);
            this.lblFileJson.TabIndex = 1;
            this.lblFileJson.Text = "Portugal.json";
            // 
            // lblJson
            // 
            this.lblJson.AutoSize = true;
            this.lblJson.Location = new System.Drawing.Point(0, 17);
            this.lblJson.Name = "lblJson";
            this.lblJson.Size = new System.Drawing.Size(220, 26);
            this.lblJson.TabIndex = 0;
            this.lblJson.Text = "You can use a Json valid file with collections \r\nor use the application json exam" +
    "ple.\r\n";
            // 
            // pnlMongodb
            // 
            this.pnlMongodb.Controls.Add(this.lblMongodbDatabase);
            this.pnlMongodb.Controls.Add(this.txtMongodbDatabase);
            this.pnlMongodb.Controls.Add(this.label2);
            this.pnlMongodb.Controls.Add(this.txtMongodbConnectionString);
            this.pnlMongodb.Controls.Add(this.lblMongodb);
            this.pnlMongodb.Location = new System.Drawing.Point(54, 67);
            this.pnlMongodb.Name = "pnlMongodb";
            this.pnlMongodb.Size = new System.Drawing.Size(309, 164);
            this.pnlMongodb.TabIndex = 4;
            this.pnlMongodb.Visible = false;
            // 
            // lblMongodbDatabase
            // 
            this.lblMongodbDatabase.AutoSize = true;
            this.lblMongodbDatabase.Location = new System.Drawing.Point(17, 102);
            this.lblMongodbDatabase.Name = "lblMongodbDatabase";
            this.lblMongodbDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblMongodbDatabase.TabIndex = 11;
            this.lblMongodbDatabase.Text = "Database";
            // 
            // txtMongodbDatabase
            // 
            this.txtMongodbDatabase.Location = new System.Drawing.Point(118, 99);
            this.txtMongodbDatabase.Name = "txtMongodbDatabase";
            this.txtMongodbDatabase.Size = new System.Drawing.Size(173, 20);
            this.txtMongodbDatabase.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Connection String";
            // 
            // txtMongodbConnectionString
            // 
            this.txtMongodbConnectionString.Location = new System.Drawing.Point(118, 66);
            this.txtMongodbConnectionString.Name = "txtMongodbConnectionString";
            this.txtMongodbConnectionString.Size = new System.Drawing.Size(173, 20);
            this.txtMongodbConnectionString.TabIndex = 4;
            this.txtMongodbConnectionString.Text = "mongodb://localhost:27017";
            // 
            // lblMongodb
            // 
            this.lblMongodb.AutoSize = true;
            this.lblMongodb.Location = new System.Drawing.Point(3, 17);
            this.lblMongodb.Name = "lblMongodb";
            this.lblMongodb.Size = new System.Drawing.Size(180, 26);
            this.lblMongodb.TabIndex = 3;
            this.lblMongodb.Text = "You can use a MongoDB database, \r\ncheck your database configuration!";
            // 
            // pnlDocumentdb
            // 
            this.pnlDocumentdb.Controls.Add(this.label3);
            this.pnlDocumentdb.Controls.Add(this.txtDocumentDbDatabase);
            this.pnlDocumentdb.Controls.Add(this.lblDocumentdbEndpoint);
            this.pnlDocumentdb.Controls.Add(this.label4);
            this.pnlDocumentdb.Controls.Add(this.txtDocumentdbAuthKey);
            this.pnlDocumentdb.Controls.Add(this.txtDocumentdbEndPoint);
            this.pnlDocumentdb.Controls.Add(this.lblDocumentdb);
            this.pnlDocumentdb.Location = new System.Drawing.Point(54, 67);
            this.pnlDocumentdb.Name = "pnlDocumentdb";
            this.pnlDocumentdb.Size = new System.Drawing.Size(309, 164);
            this.pnlDocumentdb.TabIndex = 8;
            this.pnlDocumentdb.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Database";
            // 
            // txtDocumentDbDatabase
            // 
            this.txtDocumentDbDatabase.Location = new System.Drawing.Point(94, 132);
            this.txtDocumentDbDatabase.Name = "txtDocumentDbDatabase";
            this.txtDocumentDbDatabase.Size = new System.Drawing.Size(197, 20);
            this.txtDocumentDbDatabase.TabIndex = 8;
            // 
            // lblDocumentdbEndpoint
            // 
            this.lblDocumentdbEndpoint.AutoSize = true;
            this.lblDocumentdbEndpoint.Location = new System.Drawing.Point(17, 71);
            this.lblDocumentdbEndpoint.Name = "lblDocumentdbEndpoint";
            this.lblDocumentdbEndpoint.Size = new System.Drawing.Size(71, 13);
            this.lblDocumentdbEndpoint.TabIndex = 7;
            this.lblDocumentdbEndpoint.Text = "URI Endpoint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Auth Key";
            // 
            // txtDocumentdbAuthKey
            // 
            this.txtDocumentdbAuthKey.Location = new System.Drawing.Point(94, 99);
            this.txtDocumentdbAuthKey.Name = "txtDocumentdbAuthKey";
            this.txtDocumentdbAuthKey.Size = new System.Drawing.Size(197, 20);
            this.txtDocumentdbAuthKey.TabIndex = 5;
            // 
            // txtDocumentdbEndPoint
            // 
            this.txtDocumentdbEndPoint.Location = new System.Drawing.Point(94, 66);
            this.txtDocumentdbEndPoint.Name = "txtDocumentdbEndPoint";
            this.txtDocumentdbEndPoint.Size = new System.Drawing.Size(197, 20);
            this.txtDocumentdbEndPoint.TabIndex = 4;
            // 
            // lblDocumentdb
            // 
            this.lblDocumentdb.AutoSize = true;
            this.lblDocumentdb.Location = new System.Drawing.Point(3, 17);
            this.lblDocumentdb.Name = "lblDocumentdb";
            this.lblDocumentdb.Size = new System.Drawing.Size(226, 26);
            this.lblDocumentdb.TabIndex = 3;
            this.lblDocumentdb.Text = "You can use a Azure DocumentDB database, \r\ncheck your database configuration!";
            // 
            // pnlDynamoDb
            // 
            this.pnlDynamoDb.Controls.Add(this.txtDynamoDbRegion);
            this.pnlDynamoDb.Controls.Add(this.lblDynamoDbRegion);
            this.pnlDynamoDb.Controls.Add(this.lblDynamoDbAccessKey);
            this.pnlDynamoDb.Controls.Add(this.lblDynamoDbSecretKey);
            this.pnlDynamoDb.Controls.Add(this.txtDynamoDbSecretKey);
            this.pnlDynamoDb.Controls.Add(this.txtDynamoDbAccessKey);
            this.pnlDynamoDb.Controls.Add(this.lblDynamoDb);
            this.pnlDynamoDb.Location = new System.Drawing.Point(54, 67);
            this.pnlDynamoDb.Name = "pnlDynamoDb";
            this.pnlDynamoDb.Size = new System.Drawing.Size(309, 164);
            this.pnlDynamoDb.TabIndex = 10;
            this.pnlDynamoDb.Visible = false;
            // 
            // txtDynamoDbRegion
            // 
            this.txtDynamoDbRegion.Location = new System.Drawing.Point(94, 132);
            this.txtDynamoDbRegion.Name = "txtDynamoDbRegion";
            this.txtDynamoDbRegion.Size = new System.Drawing.Size(197, 20);
            this.txtDynamoDbRegion.TabIndex = 9;
            this.txtDynamoDbRegion.Text = "us-west-2";
            // 
            // lblDynamoDbRegion
            // 
            this.lblDynamoDbRegion.AutoSize = true;
            this.lblDynamoDbRegion.Location = new System.Drawing.Point(17, 135);
            this.lblDynamoDbRegion.Name = "lblDynamoDbRegion";
            this.lblDynamoDbRegion.Size = new System.Drawing.Size(41, 13);
            this.lblDynamoDbRegion.TabIndex = 8;
            this.lblDynamoDbRegion.Text = "Region";
            // 
            // lblDynamoDbAccessKey
            // 
            this.lblDynamoDbAccessKey.AutoSize = true;
            this.lblDynamoDbAccessKey.Location = new System.Drawing.Point(17, 71);
            this.lblDynamoDbAccessKey.Name = "lblDynamoDbAccessKey";
            this.lblDynamoDbAccessKey.Size = new System.Drawing.Size(63, 13);
            this.lblDynamoDbAccessKey.TabIndex = 7;
            this.lblDynamoDbAccessKey.Text = "Access Key";
            // 
            // lblDynamoDbSecretKey
            // 
            this.lblDynamoDbSecretKey.AutoSize = true;
            this.lblDynamoDbSecretKey.Location = new System.Drawing.Point(17, 102);
            this.lblDynamoDbSecretKey.Name = "lblDynamoDbSecretKey";
            this.lblDynamoDbSecretKey.Size = new System.Drawing.Size(59, 13);
            this.lblDynamoDbSecretKey.TabIndex = 6;
            this.lblDynamoDbSecretKey.Text = "Secret Key";
            // 
            // txtDynamoDbSecretKey
            // 
            this.txtDynamoDbSecretKey.Location = new System.Drawing.Point(94, 99);
            this.txtDynamoDbSecretKey.Name = "txtDynamoDbSecretKey";
            this.txtDynamoDbSecretKey.Size = new System.Drawing.Size(197, 20);
            this.txtDynamoDbSecretKey.TabIndex = 5;
            // 
            // txtDynamoDbAccessKey
            // 
            this.txtDynamoDbAccessKey.Location = new System.Drawing.Point(94, 66);
            this.txtDynamoDbAccessKey.Name = "txtDynamoDbAccessKey";
            this.txtDynamoDbAccessKey.Size = new System.Drawing.Size(197, 20);
            this.txtDynamoDbAccessKey.TabIndex = 4;
            // 
            // lblDynamoDb
            // 
            this.lblDynamoDb.AutoSize = true;
            this.lblDynamoDb.Location = new System.Drawing.Point(3, 17);
            this.lblDynamoDb.Name = "lblDynamoDb";
            this.lblDynamoDb.Size = new System.Drawing.Size(227, 26);
            this.lblDynamoDb.TabIndex = 3;
            this.lblDynamoDb.Text = "You can use a Amazon DynamoDB database, \r\ncheck your database configuration!";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(370, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 183);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(592, 75);
            this.label5.TabIndex = 12;
            this.label5.Text = "Please, do not use this program to professional works, \r\nit´s only to study how t" +
    "o connect with some NOSQL\r\ndatabases and use its drivers API´s, as an example.";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDynamoDb);
            this.Controls.Add(this.pnlDocumentdb);
            this.Controls.Add(this.pnlMongodb);
            this.Controls.Add(this.pnlJson);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDatabaseType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.Text = "Database Configuration";
            this.pnlJson.ResumeLayout(false);
            this.pnlJson.PerformLayout();
            this.pnlMongodb.ResumeLayout(false);
            this.pnlMongodb.PerformLayout();
            this.pnlDocumentdb.ResumeLayout(false);
            this.pnlDocumentdb.PerformLayout();
            this.pnlDynamoDb.ResumeLayout(false);
            this.pnlDynamoDb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDatabaseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Panel pnlJson;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.Label lblFileJson;
        private System.Windows.Forms.Label lblJson;
        private System.Windows.Forms.Panel pnlMongodb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMongodbConnectionString;
        private System.Windows.Forms.Label lblMongodb;
        private System.Windows.Forms.Panel pnlDocumentdb;
        private System.Windows.Forms.Label lblDocumentdbEndpoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumentdbAuthKey;
        private System.Windows.Forms.TextBox txtDocumentdbEndPoint;
        private System.Windows.Forms.Label lblDocumentdb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumentDbDatabase;
        private System.Windows.Forms.Label lblMongodbDatabase;
        private System.Windows.Forms.TextBox txtMongodbDatabase;
        private System.Windows.Forms.Panel pnlDynamoDb;
        private System.Windows.Forms.Label lblDynamoDbAccessKey;
        private System.Windows.Forms.Label lblDynamoDbSecretKey;
        private System.Windows.Forms.TextBox txtDynamoDbSecretKey;
        private System.Windows.Forms.TextBox txtDynamoDbAccessKey;
        private System.Windows.Forms.Label lblDynamoDb;
        private System.Windows.Forms.Label lblDynamoDbRegion;
        private System.Windows.Forms.TextBox txtDynamoDbRegion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

