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
    public partial class AdminGradeDelete : Form
    {
        DB_Access dba = new DB_Access();
        public AdminGradeDelete()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Selected Grade?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (dba.DeleteStudent(cmbGradeNames.Text))
                {
                    MessageBox.Show("Student Sucessfully Deleted");
                    FillGradeNameList();
                }
                else
                {
                    MessageBox.Show("Error Deleting the Grade. Please try again");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AdminGradeDelete_Load(object sender, EventArgs e)
        {
            FillGradeNameList();
        }
        public void FillGradeNameList()
        {
            DataTable tb1 = dba.FillGradeList();
            cmbGradeNames.DisplayMember = "Assignment_Name + ',' + Assignment_Grade" ;
            cmbGradeNames.ValueMember = "Assignment_Name";
            cmbGradeNames.DataSource = tb1;
        }
        private void cmbGradeNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
    

