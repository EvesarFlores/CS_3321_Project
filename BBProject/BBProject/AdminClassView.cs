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
    public partial class AdminClassView : Form
    {
        DB_Access dba = new DB_Access();
        public AdminClassView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void AdminViewClass_Load(object sender, EventArgs e)
        //{
        //    DataSet ds = dba.FillDataGrid("SELECT * FROM Class", "class");
        //    dataGridView1.DataSource = ds.Tables["class"].DefaultView;
        //}

        private void AdminClassView_Load(object sender, EventArgs e)
        {
            DataSet ds = dba.FillDataGrid("Select * FROM Class", "class");
            dataGridView1.DataSource = ds.Tables["class"].DefaultView;
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
