﻿namespace BBProject
{
    partial class AdminClassDelete
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbDeleteGrade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbDeleteGrade
            // 
            this.cmbDeleteGrade.FormattingEnabled = true;
            this.cmbDeleteGrade.Location = new System.Drawing.Point(24, 81);
            this.cmbDeleteGrade.Name = "cmbDeleteGrade";
            this.cmbDeleteGrade.Size = new System.Drawing.Size(351, 21);
            this.cmbDeleteGrade.TabIndex = 3;
            this.cmbDeleteGrade.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteGrade_SelectedIndexChanged);
            // 
            // AdminClassDelete
            // 
            this.ClientSize = new System.Drawing.Size(387, 405);
            this.Controls.Add(this.cmbDeleteGrade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminClassDelete";
            this.Load += new System.EventHandler(this.AdminClassDelete_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbClassNames;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbDeleteGrade;
    }
}