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
    public partial class AdminGradeView : Form
    {
        DB_Access dba = new DB_Access();
        public AdminGradeView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminGradeView_Load(object sender, EventArgs e)
        {
            DataSet ds = dba.FillDataGrid("select * from grade", "Grade");
            dataGridView1.DataSource = ds.Tables["Grade"].DefaultView;
        }
    }
}
