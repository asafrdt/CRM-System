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
    public partial class Ceo : Form
    {
        public Ceo()
        {
         
        }

        private void Main_Load(object sender, EventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CeoPrivatearea ss = new CeoPrivatearea();
            ss.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            this.Close();
            Login ss = new Login();
           ss.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            CeoReports ss = new CeoReports();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            CeoStore ss = new CeoStore();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CeoCashRegister ss = new CeoCashRegister();
            ss.Show();
        }
    }
}
