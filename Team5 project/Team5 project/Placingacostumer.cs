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
        private void ExitingCostumerButton_Click(object sender, EventArgs e)
        {
            ExitingCoustumer mm = new ExitingCoustumer();
            mm.Show();
        }

        private void AddnewCostumerbutton_Click(object sender, EventArgs e)
        {
       
        }

        private void CashRegister_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "NewCostumer")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            ExitingCoustumer mm = new ExitingCoustumer();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "ExitingCoustumer")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();
            NewCostumer mm = new NewCostumer();
            mm.Show();
        }
    }
}
