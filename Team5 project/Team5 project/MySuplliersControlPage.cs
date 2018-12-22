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
    public partial class MySuplliersControlPage : Form
    {
        public MySuplliersControlPage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_Supllier mm = new Add_Supllier();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove_Supllier mm = new Remove_Supllier();
            mm.Show();
        }

        private void Show_Edit_Button_Click(object sender, EventArgs e)
        {
            Show_edit_Supllier mm = new Show_edit_Supllier();
            mm.Show();
        }
    }
}
