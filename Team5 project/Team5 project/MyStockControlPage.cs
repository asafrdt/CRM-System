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
    public partial class MyStockControlPage : Form
    {
        public MyStockControlPage()
        {
            InitializeComponent();
        }

        private void ShowRecoedsButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddStock mm = new AddStock();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove_Stock mm = new Remove_Stock();
            mm.Show();
        }

        private void Show_Edit_Button_Click(object sender, EventArgs e)
        {
            Show_Edit_Stock mm = new Show_Edit_Stock();
            mm.Show();
        }
    }
}
