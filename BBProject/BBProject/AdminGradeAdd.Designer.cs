namespace BBProject
{
    partial class AdminGradeAdd
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
            this.AName = new System.Windows.Forms.Label();
            this.AWeight = new System.Windows.Forms.Label();
            this.AGrade = new System.Windows.Forms.Label();
            this.ADueDate = new System.Windows.Forms.Label();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.txtAWeight = new System.Windows.Forms.TextBox();
            this.txtADueDate = new System.Windows.Forms.TextBox();
            this.txtAGrade = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AName
            // 
            this.AName.AutoSize = true;
            this.AName.Location = new System.Drawing.Point(30, 50);
            this.AName.Name = "AName";
            this.AName.Size = new System.Drawing.Size(92, 13);
            this.AName.TabIndex = 0;
            this.AName.Text = "Assignment Name";
            // 
            // AWeight
            // 
            this.AWeight.AutoSize = true;
            this.AWeight.Location = new System.Drawing.Point(29, 94);
            this.AWeight.Name = "AWeight";
            this.AWeight.Size = new System.Drawing.Size(112, 13);
            this.AWeight.TabIndex = 1;
            this.AWeight.Text = "Assignment Weight(%)";
            // 
            // AGrade
            // 
            this.AGrade.AutoSize = true;
            this.AGrade.Location = new System.Drawing.Point(29, 134);
            this.AGrade.Name = "AGrade";
            this.AGrade.Size = new System.Drawing.Size(93, 13);
            this.AGrade.TabIndex = 2;
            this.AGrade.Text = "Assignment Grade";
            // 
            // ADueDate
            // 
            this.ADueDate.AutoSize = true;
            this.ADueDate.Location = new System.Drawing.Point(30, 176);
            this.ADueDate.Name = "ADueDate";
            this.ADueDate.Size = new System.Drawing.Size(110, 13);
            this.ADueDate.TabIndex = 3;
            this.ADueDate.Text = "Assignment Due Date";
            // 
            // txtAName
            // 
            this.txtAName.Location = new System.Drawing.Point(154, 50);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(168, 20);
            this.txtAName.TabIndex = 4;
            // 
            // txtAWeight
            // 
            this.txtAWeight.Location = new System.Drawing.Point(154, 91);
            this.txtAWeight.Name = "txtAWeight";
            this.txtAWeight.Size = new System.Drawing.Size(168, 20);
            this.txtAWeight.TabIndex = 5;
            // 
            // txtADueDate
            // 
            this.txtADueDate.Location = new System.Drawing.Point(154, 176);
            this.txtADueDate.Name = "txtADueDate";
            this.txtADueDate.Size = new System.Drawing.Size(168, 20);
            this.txtADueDate.TabIndex = 6;
            // 
            // txtAGrade
            // 
            this.txtAGrade.Location = new System.Drawing.Point(154, 131);
            this.txtAGrade.Name = "txtAGrade";
            this.txtAGrade.Size = new System.Drawing.Size(168, 20);
            this.txtAGrade.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(247, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(166, 218);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(85, 218);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // AdminGradeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 255);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAGrade);
            this.Controls.Add(this.txtADueDate);
            this.Controls.Add(this.txtAWeight);
            this.Controls.Add(this.txtAName);
            this.Controls.Add(this.ADueDate);
            this.Controls.Add(this.AGrade);
            this.Controls.Add(this.AWeight);
            this.Controls.Add(this.AName);
            this.Name = "AdminGradeAdd";
            this.Text = "AdminAddGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AName;
        private System.Windows.Forms.Label AWeight;
        private System.Windows.Forms.Label AGrade;
        private System.Windows.Forms.Label ADueDate;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.TextBox txtAWeight;
        private System.Windows.Forms.TextBox txtADueDate;
        private System.Windows.Forms.TextBox txtAGrade;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInsert;
    }
}