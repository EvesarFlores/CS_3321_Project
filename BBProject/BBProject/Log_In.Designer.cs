namespace BBProject
{
    partial class Log_In
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
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LnkLblAdmin = new System.Windows.Forms.LinkLabel();
            this.LnkLblFaculty = new System.Windows.Forms.LinkLabel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(164, 60);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(55, 13);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(164, 129);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            this.LblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(167, 90);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(151, 20);
            this.TxtUsername.TabIndex = 2;
            this.TxtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(167, 156);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(151, 20);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(167, 199);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Log In";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LnkLblAdmin
            // 
            this.LnkLblAdmin.AutoSize = true;
            this.LnkLblAdmin.Location = new System.Drawing.Point(186, 243);
            this.LnkLblAdmin.Name = "LnkLblAdmin";
            this.LnkLblAdmin.Size = new System.Drawing.Size(69, 13);
            this.LnkLblAdmin.TabIndex = 5;
            this.LnkLblAdmin.TabStop = true;
            this.LnkLblAdmin.Text = "Admin Log In";
            this.LnkLblAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblAdmin_LinkClicked);
            // 
            // LnkLblFaculty
            // 
            this.LnkLblFaculty.AutoSize = true;
            this.LnkLblFaculty.Location = new System.Drawing.Point(187, 279);
            this.LnkLblFaculty.Name = "LnkLblFaculty";
            this.LnkLblFaculty.Size = new System.Drawing.Size(0, 13);
            this.LnkLblFaculty.TabIndex = 6;
            //this.LnkLblFaculty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblFaculty_LinkClicked);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(265, 199);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 281);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LnkLblFaculty);
            this.Controls.Add(this.LnkLblAdmin);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserName);
            this.Name = "Log_In";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Log_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel LnkLblAdmin;
        private System.Windows.Forms.LinkLabel LnkLblFaculty;
        private System.Windows.Forms.Button BtnExit;
    }
}

