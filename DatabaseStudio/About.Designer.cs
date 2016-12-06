namespace DatabaseStudio
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkWeb = new System.Windows.Forms.LinkLabel();
            this.linkWebProject = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblAboutProgramText = new System.Windows.Forms.Label();
            this.lblAboutMeText = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "About Data Studio...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(502, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "About me...";
            // 
            // linkWeb
            // 
            this.linkWeb.AutoSize = true;
            this.linkWeb.BackColor = System.Drawing.Color.Transparent;
            this.linkWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkWeb.LinkColor = System.Drawing.Color.Olive;
            this.linkWeb.Location = new System.Drawing.Point(504, 282);
            this.linkWeb.Name = "linkWeb";
            this.linkWeb.Size = new System.Drawing.Size(179, 18);
            this.linkWeb.TabIndex = 4;
            this.linkWeb.TabStop = true;
            this.linkWeb.Text = "www.fconcepcion.com";
            this.linkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWeb_LinkClicked);
            // 
            // linkWebProject
            // 
            this.linkWebProject.AutoSize = true;
            this.linkWebProject.BackColor = System.Drawing.Color.Transparent;
            this.linkWebProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkWebProject.LinkColor = System.Drawing.Color.Olive;
            this.linkWebProject.Location = new System.Drawing.Point(67, 282);
            this.linkWebProject.Name = "linkWebProject";
            this.linkWebProject.Size = new System.Drawing.Size(176, 18);
            this.linkWebProject.TabIndex = 5;
            this.linkWebProject.TabStop = true;
            this.linkWebProject.Text = "Data Studio in my web";
            this.linkWebProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebProject_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Olive;
            this.linkLabel1.Location = new System.Drawing.Point(67, 305);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 18);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Data Studio in GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAboutProgramText
            // 
            this.lblAboutProgramText.AutoSize = true;
            this.lblAboutProgramText.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutProgramText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutProgramText.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblAboutProgramText.Location = new System.Drawing.Point(67, 94);
            this.lblAboutProgramText.Name = "lblAboutProgramText";
            this.lblAboutProgramText.Size = new System.Drawing.Size(353, 91);
            this.lblAboutProgramText.TabIndex = 7;
            this.lblAboutProgramText.Text = resources.GetString("lblAboutProgramText.Text");
            // 
            // lblAboutMeText
            // 
            this.lblAboutMeText.AutoSize = true;
            this.lblAboutMeText.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutMeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutMeText.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblAboutMeText.Location = new System.Drawing.Point(504, 94);
            this.lblAboutMeText.Name = "lblAboutMeText";
            this.lblAboutMeText.Size = new System.Drawing.Size(401, 169);
            this.lblAboutMeText.TabIndex = 8;
            this.lblAboutMeText.Text = resources.GetString("lblAboutMeText.Text");
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(795, 282);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(991, 355);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblAboutMeText);
            this.Controls.Add(this.lblAboutProgramText);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkWebProject);
            this.Controls.Add(this.linkWeb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About Data Studio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkWeb;
        private System.Windows.Forms.LinkLabel linkWebProject;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblAboutProgramText;
        private System.Windows.Forms.Label lblAboutMeText;
        private System.Windows.Forms.Button btnOk;
    }
}