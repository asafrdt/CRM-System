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

    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();


        }

        private void CashRegister_Click(object sender, EventArgs e)
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

            Placingacostumer mm = new Placingacostumer();
            mm.Show();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Employees" || f.Name == "Stock_Suppliers" || f.Name == "Costumers_Orders"
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

            FindProduct mm = new FindProduct();
            mm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            label4.Text = ExitingCoustumer.Customer;
            label6.Text = FindProduct.Product;
            label11.Text = FindProduct.Product_name;
            label3.Text = FindProduct.Quantity;
            if (FindProduct.int_Product_price !=0) 
            label9.Text = FindProduct.int_Product_price.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label4.Text == "" && label6.Text == "") MessageBox.Show("You didn't place a costumer and Product!");
            else if (label4.Text == "") MessageBox.Show("You didn't place a costumer!");
            else if (label6.Text == "") MessageBox.Show("You didn't place a Product!");
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("select Price from Inventory where Serialnumber ='" + FindProduct.Product + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string New_price = dt.Rows[0]["Price"].ToString();
                SqlCommand sda2 = new SqlCommand("INSERT INTO Orders (Product_Serial,Price,Quantity,Date,Seller_name,Buyer_Id) VALUES ('" + FindProduct.Product + "','" + FindProduct.int_Product_price + "','" + FindProduct.Quantity + "','" + Login.date + "','" + Login.UserID + "','" + ExitingCoustumer.Customer + "')", conn);
                SqlDataAdapter da = new SqlDataAdapter(sda2);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                if (MessageBox.Show("Greetings, the product was successfully sold\nWould you like to choose another product?","Success", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FindProduct.Product="";
                    FindProduct.Product_name="";
                    FindProduct.Quantity="";
                    this.Close();
                    FindProduct mm = new FindProduct();
                    mm.Show();
                }
                else
                {
                    this.Close();
                }
            }


        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
