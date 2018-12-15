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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();

            timer1_Cashier.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashierPrivateArea mm = new CashierPrivateArea();
            mm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Time_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Time_Cashier.Text = dateTime.ToString();
        }

        private void Time_Cashier_Click(object sender, EventArgs e)
        {
            
        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }
    }
}
