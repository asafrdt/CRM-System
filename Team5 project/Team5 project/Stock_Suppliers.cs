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
    public partial class Stock_Suppliers : Form
    {
        public Stock_Suppliers()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyStockControlPage mm = new MyStockControlPage();
            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            MySuplliersControlPage mm = new MySuplliersControlPage();
            mm.Show();


        }
    }
}
