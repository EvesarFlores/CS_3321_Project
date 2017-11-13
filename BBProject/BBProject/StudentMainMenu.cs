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
    public partial class StudentMainMenu : Form
    {
        DB_Access access = new DB_Access();
        public StudentMainMenu()
        {
            InitializeComponent();
        }

        private void Student_Show_Load(object sender, EventArgs e)
        {

        }
    }
}
