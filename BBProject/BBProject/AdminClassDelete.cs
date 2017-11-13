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
    public partial class AdminClassDelete : Form
    {
        DB_Access dba = new DB_Access();
        public AdminClassDelete()
        {
            InitializeComponent();
        }
        private void AdminClassDelete_Load_1(object sender, EventArgs e)
        {
            FillClassNameList();
        }
        public void FillClassNameList()
        {
            DataTable tb1 = dba.FillClassList();
            cmbDeleteGrade.DisplayMember = "Course_ID + ',' + Course_Number";
            cmbDeleteGrade.ValueMember = "Course_ID";
            cmbDeleteGrade.DataSource = tb1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Selected Class?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (dba.DeleteStudent(cmbDeleteGrade.Text))
                {
                    MessageBox.Show("Class Sucessfully Deleted");
                    FillClassNameList();
                }
                else
                {
                    MessageBox.Show("Error Deleting the Class. Please try again");
                }
            }
        }
        private void cmbDeleteGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
