using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Team5_project
{
    public partial class Expert : Form
    {
        public Expert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Employees" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea"  || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
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

            Checkout mm = new Checkout();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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

            Stock_Suppliers mm = new Stock_Suppliers();
            mm.Show();
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
            Costumers_Orders mm = new Costumers_Orders();
            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Checkout" || f.Name == "Employees" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
                    || f.Name == "CeoPrivatearea"  || f.Name == "CashierWorkSchedule" || f.Name == "CeoAddWorker"
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

            GeneralPrivateArea mm = new GeneralPrivateArea();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.timeLogout = DateTime.Now;
            Login.timeOut = Login.timeLogout.TimeOfDay;
            TimeSpan diff = Login.timeLogout.Subtract(Login.timeLogin);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");

            SqlCommand sda1 = new SqlCommand("INSERT INTO Work_card (Username,shift_date,logtimeIn,logtimeOut,CalculateHours,Year,Month) VALUES ('" + Login.UserID + "','" + Login.date + "','" + Login.timeLogin.Hour + ":" + Login.timeLogin.Minute + ":" + Login.timeLogin.Second + "','" + Login.timeLogout.Hour + ":" + Login.timeLogout.Minute + ":" + Login.timeLogout.Second + "','" + diff.Hours + ":" + diff.Minutes + ":" + diff.Seconds + "','" + Login.date1.Year + "','" + Login.date1.Month + "')", conn);
            SqlDataAdapter da = new SqlDataAdapter(sda1);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Application.Exit();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Login.timeLogout = DateTime.Now;
            Login.timeOut = Login.timeLogout.TimeOfDay;
            TimeSpan diff = Login.timeLogout.Subtract(Login.timeLogin);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");

            SqlCommand sda1 = new SqlCommand("INSERT INTO Work_card (Username,shift_date,logtimeIn,logtimeOut,CalculateHours,Year,Month) VALUES ('" + Login.UserID + "','" + Login.date + "','" + Login.timeLogin.Hour + ":" + Login.timeLogin.Minute + ":" + Login.timeLogin.Second + "','" + Login.timeLogout.Hour + ":" + Login.timeLogout.Minute + ":" + Login.timeLogout.Second + "','" + diff.Hours + ":" + diff.Minutes + ":" + diff.Seconds + "','" + Login.date1.Year + "','" + Login.date1.Month + "')", conn);
            SqlDataAdapter da = new SqlDataAdapter(sda1);
            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Login")
                    f.Close();
            }
            Login mm = new Login();
            mm.Show();
        }
    }
}
