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
    public partial class AdminClassAdd : Form
    {
        DB_Access access = new DB_Access();

        public AdminClassAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCID.Text = "";
            txtCNumber.Text = "";
            txtSemester.Text = "";
            txtInstructor.Text = "";
        }

        private void AdminAddClass_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            access.add_class(txtCID.Text, txtCNumber.Text, txtSemester.Text, txtInstructor.Text);
            MessageBox.Show("Data Successfully Added");
        }
    }
}
