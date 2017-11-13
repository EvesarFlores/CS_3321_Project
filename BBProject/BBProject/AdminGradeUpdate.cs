using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBProject
{
    public partial class AdminGradeUpdate : Form
    {
        DB_Access dba = new DB_Access();
        public AdminGradeUpdate()
        {
            InitializeComponent();
        }

        private void AdminGradeUpdate_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string AssignmentName = txtAssignmentName.Text;
            txtAssignmentName.Text = dba.ReturnData("Assignment_Name", "Grade", AssignmentName, "Assignment_Name");
            txtAssignmentWeight.Text = dba.ReturnData("Assignment_Name", "Grade", AssignmentName, "Assignment_Weight");
            txtAssignmentGrade.Text = dba.ReturnData("Assignment_Name", "Grade", AssignmentName, "Assignment_Grade");
            txtAssignmentDueDate.Text = dba.ReturnData("Assignment_Name", "Grade", AssignmentName, "Assignment_Due_Date");
            txtAssignmentName.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dba.update_grade(txtAssignmentName.Text, txtAssignmentWeight.Text, txtAssignmentGrade.Text, txtAssignmentDueDate.Text);
            MessageBox.Show("Data Successfully Updated");
        }
    }
}
