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
    public partial class AdminClassUpdate : Form
    {
        DB_Access dba = new DB_Access();
        public AdminClassUpdate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ClassID = txtClassID.Text;
            txtClassID.Text = dba.ReturnData("Course_ID", "Class", ClassID, "Course_ID");
            txtClassNumber.Text = dba.ReturnData("Course_ID", "Class", ClassID, "Course_Number");
            txtSemester.Text = dba.ReturnData("Course_ID", "Class", ClassID, "Semester");
            txtInstructor.Text = dba.ReturnData("Course_ID", "Class", ClassID, "Instructor");
            txtClassID.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dba.update_class(txtClassID.Text, txtClassNumber.Text, txtSemester.Text, txtInstructor.Text);
            MessageBox.Show("Data Succesfully Updated");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminClassUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
