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
    public partial class AdminClass : Form
    {
        public AdminClass()
        {
            InitializeComponent();
        }

        private void AdminClass_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminClassAdd aaclass = new AdminClassAdd();
            aaclass.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminClassUpdate acu = new AdminClassUpdate();
            acu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminClassView adcv = new AdminClassView();
            adcv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminClassDelete acd = new AdminClassDelete();
            acd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminGradeAdd aga = new AdminGradeAdd();
            aga.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminGradeUpdate agu = new AdminGradeUpdate();
            agu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminGradeView agv = new AdminGradeView();
            agv.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminGradeDelete agd = new AdminGradeDelete();
            agd.Show();
        }
    }
}
