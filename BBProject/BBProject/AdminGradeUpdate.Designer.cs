namespace BBProject
{
    partial class AdminGradeUpdate
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
            this.txtAssignmentGrade = new System.Windows.Forms.TextBox();
            this.txtAssignmentDueDate = new System.Windows.Forms.TextBox();
            this.txtAssignmentWeight = new System.Windows.Forms.TextBox();
            this.txtAssignmentName = new System.Windows.Forms.TextBox();
            this.ADueDate = new System.Windows.Forms.Label();
            this.AGrade = new System.Windows.Forms.Label();
            this.AWeight = new System.Windows.Forms.Label();
            this.AName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAGrade
            // 
            this.txtAssignmentGrade.Location = new System.Drawing.Point(148, 131);
            this.txtAssignmentGrade.Name = "txtAGrade";
            this.txtAssignmentGrade.Size = new System.Drawing.Size(168, 20);
            this.txtAssignmentGrade.TabIndex = 15;
            // 
            // txtADueDate
            // 
            this.txtAssignmentDueDate.Location = new System.Drawing.Point(148, 176);
            this.txtAssignmentDueDate.Name = "txtADueDate";
            this.txtAssignmentDueDate.Size = new System.Drawing.Size(168, 20);
            this.txtAssignmentDueDate.TabIndex = 14;
            // 
            // txtAWeight
            // 
            this.txtAssignmentWeight.Location = new System.Drawing.Point(148, 91);
            this.txtAssignmentWeight.Name = "txtAWeight";
            this.txtAssignmentWeight.Size = new System.Drawing.Size(168, 20);
            this.txtAssignmentWeight.TabIndex = 13;
            // 
            // txtAName
            // 
            this.txtAssignmentName.Location = new System.Drawing.Point(148, 50);
            this.txtAssignmentName.Name = "txtAName";
            this.txtAssignmentName.Size = new System.Drawing.Size(168, 20);
            this.txtAssignmentName.TabIndex = 12;
            // 
            // ADueDate
            // 
            this.ADueDate.AutoSize = true;
            this.ADueDate.Location = new System.Drawing.Point(24, 176);
            this.ADueDate.Name = "ADueDate";
            this.ADueDate.Size = new System.Drawing.Size(110, 13);
            this.ADueDate.TabIndex = 11;
            this.ADueDate.Text = "Assignment Due Date";
            // 
            // AGrade
            // 
            this.AGrade.AutoSize = true;
            this.AGrade.Location = new System.Drawing.Point(23, 134);
            this.AGrade.Name = "AGrade";
            this.AGrade.Size = new System.Drawing.Size(93, 13);
            this.AGrade.TabIndex = 10;
            this.AGrade.Text = "Assignment Grade";
            // 
            // AWeight
            // 
            this.AWeight.AutoSize = true;
            this.AWeight.Location = new System.Drawing.Point(23, 94);
            this.AWeight.Name = "AWeight";
            this.AWeight.Size = new System.Drawing.Size(112, 13);
            this.AWeight.TabIndex = 9;
            this.AWeight.Text = "Assignment Weight(%)";
            // 
            // AName
            // 
            this.AName.AutoSize = true;
            this.AName.Location = new System.Drawing.Point(24, 50);
            this.AName.Name = "AName";
            this.AName.Size = new System.Drawing.Size(92, 13);
            this.AName.TabIndex = 8;
            this.AName.Text = "Assignment Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(241, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(36, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AdminGradeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 248);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAssignmentGrade);
            this.Controls.Add(this.txtAssignmentDueDate);
            this.Controls.Add(this.txtAssignmentWeight);
            this.Controls.Add(this.txtAssignmentName);
            this.Controls.Add(this.ADueDate);
            this.Controls.Add(this.AGrade);
            this.Controls.Add(this.AWeight);
            this.Controls.Add(this.AName);
            this.Name = "AdminGradeUpdate";
            this.Text = "AdminGradeUpdate";
            this.Load += new System.EventHandler(this.AdminGradeUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssignmentGrade;
        private System.Windows.Forms.TextBox txtAssignmentDueDate;
        private System.Windows.Forms.TextBox txtAssignmentWeight;
        private System.Windows.Forms.TextBox txtAssignmentName;
        private System.Windows.Forms.Label ADueDate;
        private System.Windows.Forms.Label AGrade;
        private System.Windows.Forms.Label AWeight;
        private System.Windows.Forms.Label AName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
    }
}