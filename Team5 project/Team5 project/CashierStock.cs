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
    public partial class CashierStock : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        public CashierStock()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            sda = new SqlDataAdapter(@"select Product_id as 'Serial number',Product_name as 'Name', Quantity, Price, Suppllier_full_name as 'Suppllier full name'  FROM Inventory", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CashierStock_Load(object sender, EventArgs e)
        {

        }
    }
}
