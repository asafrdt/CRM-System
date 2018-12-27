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
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Employees" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea" || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
                    || f.Name == "CeoDeleteWorker" || f.Name == "CeoEditWorker" || f.Name == "CeoPrivatearea" || f.Name == "Change_password"
                    || f.Name == "Costumer_Order" || f.Name == "Employees_control_page" || f.Name == "ExitingCoustumer" || f.Name == "FindProduct"
                    || f.Name == "GeneralPrivateArea" || f.Name == "GeneralWorkHours" || f.Name == "MyStockControlPage"
                    || f.Name == "MySuplliersControlPage" || f.Name == "NewCostumer" || f.Name == "Orders_report" || f.Name == "Placingacostumer"
                    || f.Name == "Remove_Customer" || f.Name == "Remove_Stock" || f.Name == "Remove_Supllier" || f.Name == "Show_Edit_Customer"
                    || f.Name == "Show_Edit_Employees" || f.Name == "Show_Edit_Stock" || f.Name == "Show_edit_Supllier"
                    || f.Name == "Stock_Suppliers" || f.Name == "Work_Hours" || f.Name == "Add_Supllier" || f.Name == "AddStock")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            MyStockControlPage mm = new MyStockControlPage();

            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Employees" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea" || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
                    || f.Name == "CeoDeleteWorker" || f.Name == "CeoEditWorker" || f.Name == "CeoPrivatearea" || f.Name == "Change_password"
                    || f.Name == "Costumer_Order" || f.Name == "Employees_control_page" || f.Name == "ExitingCoustumer" || f.Name == "FindProduct"
                    || f.Name == "GeneralPrivateArea" || f.Name == "GeneralWorkHours" || f.Name == "MyStockControlPage"
                    || f.Name == "MySuplliersControlPage" || f.Name == "NewCostumer" || f.Name == "Orders_report" || f.Name == "Placingacostumer"
                    || f.Name == "Remove_Customer" || f.Name == "Remove_Stock" || f.Name == "Remove_Supllier" || f.Name == "Show_Edit_Customer"
                    || f.Name == "Show_Edit_Employees" || f.Name == "Show_Edit_Stock" || f.Name == "Show_edit_Supllier"
                    || f.Name == "Stock_Suppliers" || f.Name == "Work_Hours" || f.Name == "Add_Supllier" || f.Name == "AddStock")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            MySuplliersControlPage mm = new MySuplliersControlPage();
            mm.Show();
        }
    }
}
