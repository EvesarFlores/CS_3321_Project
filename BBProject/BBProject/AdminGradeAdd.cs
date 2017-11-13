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
    public partial class AdminGradeAdd : Form
    {
        DB_Access access = new DB_Access();
        public AdminGradeAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtADueDate.Text = "";
            txtAGrade.Text = "";
            txtAName.Text = "";
            txtAWeight.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            access.add_grade(txtAName.Text, txtAGrade.Text, txtAWeight.Text, txtADueDate.Text);
            MessageBox.Show("Data Successfully Added");
        }
    }
}
