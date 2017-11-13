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
    public partial class AdminStudentUpdate : Form
    {
        DB_Access dba = new DB_Access();
        public AdminStudentUpdate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string StudentID = txtStudentID.Text;
            txtStudentID.Text = dba.ReturnData("Student_ID", "Student", StudentID, "Student_ID");
            txtStudentFirstName.Text = dba.ReturnData("Student_ID", "Student", StudentID, "Student_First_Name");
            txtStudentLastName.Text = dba.ReturnData("Student_ID", "Student", StudentID, "Student_Last_Name");
            txtStudentMobilePhone.Text = dba.ReturnData("Student_ID", "Student", StudentID, "Mobile_Phone");
            txtStudentID.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dba.update_student(txtStudentID.Text, txtStudentFirstName.Text, txtStudentLastName.Text, txtStudentMobilePhone.Text);
            MessageBox.Show("Data Sucessfully Updated");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminStudentUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
