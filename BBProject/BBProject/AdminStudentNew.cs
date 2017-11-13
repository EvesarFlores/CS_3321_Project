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
    public partial class AdminStudentNew : Form
    {
        DB_Access access = new DB_Access();
        public AdminStudentNew()
        {
            InitializeComponent();
        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRegNo.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtPhone.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            access.add_student(txtRegNo.Text, txtFName.Text, txtLName.Text, txtPhone.Text);
            MessageBox.Show("Data Successfully Added");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
