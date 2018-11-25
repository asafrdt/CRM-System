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
    public partial class Placingacostumer : Form
    {
        public Placingacostumer()
        {
            InitializeComponent();
        }

        private void Placingacostumer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCostumer mm = new NewCostumer();
            mm.Show();
        }
    }
}
