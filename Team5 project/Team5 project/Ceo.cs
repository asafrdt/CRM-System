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
    public partial class Ceo : Form
    {
        public Ceo()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //DateTime time = DateTime.Now;
            //String format = "yyyy-MM-dd HH:mm:ss", datatype = "OUT";
            //for (int i = 0; i < 19; i++)
            //{
            //    if (i < 10)
            //        Login.dateOut += time.ToString(format)[i];
            //    else if (i > 10)
            //        Login.timeOut += time.ToString(format)[i];
            //}
            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlCommand sda1 = new SqlCommand("INSERT INTO Work_card (Username,datatype,logdate,logtime,logdatetime) VALUES ('" + Login.UserID + "','"  + datatype + "','" + Login.dateOut + "','" + Login.timeOut + "','" + time.ToString(format) + "')", conn);
            //SqlDataAdapter da = new SqlDataAdapter(sda1);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Checkout mm = new Checkout();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login mm = new Login();
            mm.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //DateTime time = DateTime.Now;
            //String format = "yyyy-MM-dd HH:mm:ss", datatype = "OUT";
            //for (int i = 0; i < 19; i++)
            //{
            //    if (i < 10)
            //        Login.dateOut += time.ToString(format)[i];
            //    else if (i > 10)
            //        Login.timeOut += time.ToString(format)[i];
            //}
            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");

            //SqlCommand sda1 = new SqlCommand("INSERT INTO Work_card (Username,datatype,logdate,logtime,logdatetime) VALUES ('" + Login.UserID + "','" + datatype + "','" + Login.dateOut + "','" + Login.timeOut + "','" + time.ToString(format) + "')", conn);
            //SqlDataAdapter da = new SqlDataAdapter(sda1);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            CeoPrivatearea mm = new CeoPrivatearea();
            mm.Show();
        }

        private void Store_button_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Employees" || f.Name== "Checkout" || f.Name=="Stock_Suppliers" || f.Name=="Costumers_Orders")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();
            Employees mm = new Employees();
            mm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
         
            Checkout mm = new Checkout();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Stock_Suppliers")
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
                if (f.Name == "Costumers_Orders")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();
            Costumers_Orders mm = new Costumers_Orders();
            mm.Show();
        }

        private void Ceo_Load(object sender, EventArgs e)
        {
            
        }

       

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
