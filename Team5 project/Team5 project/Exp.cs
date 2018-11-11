using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team5_project
{
    public partial class Exp : Form
    {
        public Exp()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ExpPrivateArea ss = new ExpPrivateArea();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ExpStore ss = new ExpStore();
            ss.Show();
        }
    }
}
