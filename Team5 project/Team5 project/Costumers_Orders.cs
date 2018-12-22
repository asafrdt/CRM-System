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
    public partial class Costumers_Orders : Form
    {
        public Costumers_Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCostumer mm = new NewCostumer();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove_Customer mm = new Remove_Customer();
            mm.Show();
        }

        private void Costumers_Orders_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show_Edit_Customer mm = new Show_Edit_Customer();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Orders_report mm = new Orders_report();
            mm.Show();
        }
    }
}
