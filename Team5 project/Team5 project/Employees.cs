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

        private void button3_Click(object sender, EventArgs e)
        {
            CeoControlPage mm = new CeoControlPage();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
