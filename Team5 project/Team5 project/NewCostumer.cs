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
    public partial class NewCostumer : Form
    {
        public NewCostumer()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select Id from Costumers where Id ='" + IDBox.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("The ID allready exists in the system, go to 'Exiting Costumer page'", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand sda1 = new SqlCommand("INSERT INTO Costumers (Id,First_name,Last_name, Mobile, Adress) VALUES ('" + IDBox.Text + "','" + FirstnameBox.Text + "','" + LastnameBox.Text + "','" + PhoneBox.Text + "','" + AdressBox.Text + "')", conn);
                //SqlCommand sda3 = new SqlCommand("INSERT INTO UserKey (UserId,UserName) VALUES ('" + UsernameBox.Text + "','" + IDBox.Text + "')", conn);

                SqlDataAdapter da = new SqlDataAdapter(sda1);
                // SqlDataAdapter da2 = new SqlDataAdapter(sda3);

                DataSet ds = new DataSet();
                da.Fill(ds);
              
                // DataSet ds2 = new DataSet();
                // da1.Fill(ds2);
                MessageBox.Show("TUDO BOM", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

