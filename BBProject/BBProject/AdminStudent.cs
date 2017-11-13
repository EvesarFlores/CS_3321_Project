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
    public partial class AdminStudent : Form
    {
        public AdminStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AdminStudentNew newstd = new AdminStudentNew();
            newstd.Show();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            AdminStudentViewData view = new AdminStudentViewData();
            view.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            AdminStudentDelete del = new AdminStudentDelete();
            del.Show();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            AdminStudentUpdate up = new AdminStudentUpdate();
            up.Show();
        }

        private void AdminMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
