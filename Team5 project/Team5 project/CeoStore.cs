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
    public partial class CeoStore : Form
    {
        public CeoStore()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CeoAddWorker mm = new CeoAddWorker();
            mm.Show();
        }

        private void DeleteWorker_Click(object sender, EventArgs e)
        {
            this.Hide();
            CeoDeleteWorker mm = new CeoDeleteWorker();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CeoControlPage mm = new CeoControlPage();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellMainPage mm = new SellMainPage();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
            ExpStoreproduct1 ss = new ExpStoreproduct1();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FindProduct ss = new FindProduct();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }

        private void returnCashier_Click(object sender, EventArgs e)
        {
            this.Close();
            Ceo ss = new Ceo();
            ss.Show();
        }
    }
}
