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
    public partial class SellMainPage : Form
    {
        public SellMainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Placingacostumer mm = new Placingacostumer();
            mm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }
    }
}
