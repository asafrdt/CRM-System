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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea" || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
                    || f.Name == "CeoDeleteWorker" || f.Name == "CeoEditWorker" || f.Name == "CeoPrivatearea" || f.Name == "Change_password"
                    || f.Name == "Costumer_Order" || f.Name == "Employees_control_page" || f.Name == "ExitingCoustumer" || f.Name == "FindProduct"
                    || f.Name == "GeneralPrivateArea" || f.Name == "GeneralWorkHours" || f.Name == "MyStockControlPage"
                    || f.Name == "MySuplliersControlPage" || f.Name == "NewCostumer" || f.Name == "Orders_report" || f.Name == "Placingacostumer"
                    || f.Name == "Remove_Customer" || f.Name == "Remove_Stock" || f.Name == "Remove_Supllier" || f.Name == "Show_Edit_Customer"
                    || f.Name == "Show_Edit_Employees" || f.Name == "Show_Edit_Stock" || f.Name == "Show_edit_Supllier"
                    || f.Name == "Stock_Suppliers" || f.Name == "Work_Hours")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            CeoAddWorker mm = new CeoAddWorker();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea" || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
                    || f.Name == "CeoDeleteWorker" || f.Name == "CeoEditWorker" || f.Name == "CeoPrivatearea" || f.Name == "Change_password"
                    || f.Name == "Costumer_Order" || f.Name == "Employees_control_page" || f.Name == "ExitingCoustumer" || f.Name == "FindProduct"
                    || f.Name == "GeneralPrivateArea" || f.Name == "GeneralWorkHours" || f.Name == "MyStockControlPage"
                    || f.Name == "MySuplliersControlPage" || f.Name == "NewCostumer" || f.Name == "Orders_report" || f.Name == "Placingacostumer"
                    || f.Name == "Remove_Customer" || f.Name == "Remove_Stock" || f.Name == "Remove_Supllier" || f.Name == "Show_Edit_Customer"
                    || f.Name == "Show_Edit_Employees" || f.Name == "Show_Edit_Stock" || f.Name == "Show_edit_Supllier"
                    || f.Name == "Stock_Suppliers" || f.Name == "Work_Hours")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            CeoDeleteWorker mm = new CeoDeleteWorker();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea" || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
                    || f.Name == "CeoDeleteWorker" || f.Name == "CeoEditWorker" || f.Name == "CeoPrivatearea" || f.Name == "Change_password"
                    || f.Name == "Costumer_Order" || f.Name == "Employees_control_page" || f.Name == "ExitingCoustumer" || f.Name == "FindProduct"
                    || f.Name == "GeneralPrivateArea" || f.Name == "GeneralWorkHours" || f.Name == "MyStockControlPage"
                    || f.Name == "MySuplliersControlPage" || f.Name == "NewCostumer" || f.Name == "Orders_report" || f.Name == "Placingacostumer"
                    || f.Name == "Remove_Customer" || f.Name == "Remove_Stock" || f.Name == "Remove_Supllier" || f.Name == "Show_Edit_Customer"
                    || f.Name == "Show_Edit_Employees" || f.Name == "Show_Edit_Stock" || f.Name == "Show_edit_Supllier"
                    || f.Name == "Stock_Suppliers" || f.Name == "Work_Hours")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            Employees_control_page mm = new Employees_control_page();
            mm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea" || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
                    || f.Name == "CeoDeleteWorker" || f.Name == "CeoEditWorker" || f.Name == "CeoPrivatearea" || f.Name == "Change_password"
                    || f.Name == "Costumer_Order" || f.Name == "Employees_control_page" || f.Name == "ExitingCoustumer" || f.Name == "FindProduct"
                    || f.Name == "GeneralPrivateArea" || f.Name == "GeneralWorkHours" || f.Name == "MyStockControlPage"
                    || f.Name == "MySuplliersControlPage" || f.Name == "NewCostumer" || f.Name == "Orders_report" || f.Name == "Placingacostumer"
                    || f.Name == "Remove_Customer" || f.Name == "Remove_Stock" || f.Name == "Remove_Supllier" || f.Name == "Show_Edit_Customer"
                    || f.Name == "Show_Edit_Employees" || f.Name == "Show_Edit_Stock" || f.Name == "Show_edit_Supllier"
                    || f.Name == "Stock_Suppliers" || f.Name == "Work_Hours"|| f.Name == "Add_Supllier"||f.Name == "AddStock")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            CeoAddWorker mm = new CeoAddWorker();
            mm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea" || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
                    || f.Name == "CeoDeleteWorker" || f.Name == "CeoEditWorker" || f.Name == "CeoPrivatearea" || f.Name == "Change_password"
                    || f.Name == "Costumer_Order" || f.Name == "Employees_control_page" || f.Name == "ExitingCoustumer" || f.Name == "FindProduct"
                    || f.Name == "GeneralPrivateArea" || f.Name == "GeneralWorkHours" || f.Name == "MyStockControlPage"
                    || f.Name == "MySuplliersControlPage" || f.Name == "NewCostumer" || f.Name == "Orders_report" || f.Name == "Placingacostumer"
                    || f.Name == "Remove_Customer" || f.Name == "Remove_Stock" || f.Name == "Remove_Supllier" || f.Name == "Show_Edit_Customer"
                    || f.Name == "Show_Edit_Employees" || f.Name == "Show_Edit_Stock" || f.Name == "Show_edit_Supllier"
                    || f.Name == "Stock_Suppliers" || f.Name == "Work_Hours" || f.Name == "AddStock" || f.Name == "AddStock")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            CeoDeleteWorker mm = new CeoDeleteWorker();
            mm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea" || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
                    || f.Name == "CeoDeleteWorker" || f.Name == "CeoEditWorker" || f.Name == "CeoPrivatearea" || f.Name == "Change_password"
                    || f.Name == "Costumer_Order" || f.Name == "Employees_control_page" || f.Name == "ExitingCoustumer" || f.Name == "FindProduct"
                    || f.Name == "GeneralPrivateArea" || f.Name == "GeneralWorkHours" || f.Name == "MyStockControlPage"
                    || f.Name == "MySuplliersControlPage" || f.Name == "NewCostumer" || f.Name == "Orders_report" || f.Name == "Placingacostumer"
                    || f.Name == "Remove_Customer" || f.Name == "Remove_Stock" || f.Name == "Remove_Supllier" || f.Name == "Show_Edit_Customer"
                    || f.Name == "Show_Edit_Employees" || f.Name == "Show_Edit_Stock" || f.Name == "Show_edit_Supllier"
                    || f.Name == "Stock_Suppliers" || f.Name == "Work_Hours" || f.Name=="AddStock" || f.Name == "Add_Supllier")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            Show_Edit_Employees mm = new Show_Edit_Employees();
            mm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea"  || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
                    || f.Name == "CeoDeleteWorker" || f.Name == "CeoEditWorker" || f.Name == "CeoPrivatearea" || f.Name == "Change_password"
                    || f.Name == "Costumer_Order" || f.Name == "Employees_control_page" || f.Name == "ExitingCoustumer" || f.Name == "FindProduct"
                    || f.Name == "GeneralPrivateArea" || f.Name == "GeneralWorkHours" || f.Name == "MyStockControlPage"
                    || f.Name == "MySuplliersControlPage" || f.Name == "NewCostumer" || f.Name == "Orders_report" || f.Name == "Placingacostumer"
                    || f.Name == "Remove_Customer" || f.Name == "Remove_Stock" || f.Name == "Remove_Supllier" || f.Name == "Show_Edit_Customer"
                    || f.Name == "Show_Edit_Employees" || f.Name == "Show_Edit_Stock" || f.Name == "Show_edit_Supllier"
                    || f.Name == "Stock_Suppliers" || f.Name == "Work_Hours" || f.Name == "AddStock" || f.Name == "Add_Supllier")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();

            Work_Hours mm = new Work_Hours();
            mm.Show();
        }
    }
}
