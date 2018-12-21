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
    public partial class Employees_control_page : Form
    {
        public Employees_control_page()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            CeoEditWorker mm = new CeoEditWorker();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
