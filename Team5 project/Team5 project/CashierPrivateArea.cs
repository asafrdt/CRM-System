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
    public partial class CashierPrivateArea : Form
    {
        public CashierPrivateArea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashierWorkSchedule mm = new CashierWorkSchedule();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void returnCashier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier mm = new Cashier();
            mm.Show();
        }
    }
}
