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
    public partial class AdminStudentViewData : Form
    {
        DB_Access dba = new DB_Access();
        public AdminStudentViewData()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminViewData_Load(object sender, EventArgs e)
        {
            DataSet ds = dba.FillDataGrid("SELECT * FROM Student", "student");
            dgvStudentData.DataSource = ds.Tables["student"].DefaultView;

        }
    }
}
