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
    public partial class AdminStudentDelete : Form
    {
        DB_Access dba = new DB_Access();
    
        public AdminStudentDelete()
        {
            InitializeComponent();
        }

        private void cmbStudentNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Delete Selected Student?" , "Confirm!", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                if(dba.DeleteStudent(cmbStudentNames.Text))
                {
                    MessageBox.Show("Student Successfully Deleted");
                    FillStudentNameList();
                }
                else
                {
                    MessageBox.Show("Error deleting the student. Please try again");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDelete_Load(object sender, EventArgs e)
        {
            FillStudentNameList();
        }
        public void FillStudentNameList()
        {
            DataTable tb1 = dba.FillStudentList();
            cmbStudentNames.DisplayMember = "Student_ID + ',' + Student_First_Name + ',' + Student_Last_Name";
            cmbStudentNames.ValueMember = "Student_ID";
            cmbStudentNames.DataSource = tb1;
        }
    }
}
