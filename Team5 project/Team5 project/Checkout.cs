﻿using System;
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
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (label4.Text == "" && label6.Text == "") MessageBox.Show("You didn't place a costumer and Product!");
            else if (label4.Text == "") MessageBox.Show("You didn't place a costumer!");
            else if (label6.Text == "") MessageBox.Show("You didn't place a Product!");
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("select Price from Inventory where Product_id ='" + FindProduct.Product + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string New_price = dt.Rows[0]["Price"].ToString();
                SqlCommand sda2 = new SqlCommand("INSERT INTO Orders (Product_id,Order_price,Quantity,Order_date,Employee_full_name,Customer_full_name,Year,Month) VALUES ('" + FindProduct.Product + "','" + FindProduct.int_Product_price + "','" + FindProduct.Quantity + "','" + Login.date + "','" + Login.UserID + "','" + ExitingCoustumer.Customer + "','" + Login.date1.Year + "','" + Login.date1.Month +  "')", conn);
                SqlDataAdapter da = new SqlDataAdapter(sda2);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                try
                {
                    SqlCommand sda4 = new SqlCommand(" update Inventory set Quantity = '" + FindProduct.int_Update_quaintity + " ' where Product_id  ='" + FindProduct.Product + "'", conn);
                    SqlDataAdapter da4 = new SqlDataAdapter(sda4);
                    DataTable dt4 = new DataTable();
                    da4.Fill(dt4);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (MessageBox.Show("Greetings, the product was successfully sold.Would you like to choose another product?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FindProduct.Product = "";
                    FindProduct.Product_name = "";
                    FindProduct.Quantity = "";
                    this.Close();
                    FindProduct mm = new FindProduct();
                    mm.Show();
                }
                else
                {
                    FindProduct.Product = "";
                    FindProduct.Product_name = "";
                    FindProduct.Quantity = "";
                    ExitingCoustumer.Customer = "";
                    label4.Text = "";
                    this.Close();
                    Checkout mm = new Checkout();
                    mm.label4.Text = "";
                    mm.label9.Text = "";
                    mm.label6.Text = "";
                    mm.label3.Text = "";
                    mm.label11.Text = "";
                    mm.Show();
                    
                }
            }


        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
