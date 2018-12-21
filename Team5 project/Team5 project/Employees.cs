using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_project
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CeoAddWorker mm = new CeoAddWorker();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CeoDeleteWorker mm = new CeoDeleteWorker();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employees_control_page mm = new Employees_control_page();
            mm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            CeoAddWorker mm = new CeoAddWorker();
            mm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CeoDeleteWorker mm = new CeoDeleteWorker();
            mm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Show_Edit_Employees mm = new Show_Edit_Employees();
            mm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Work_Hours mm = new Work_Hours();
            mm.Show();
        }
    }
}
