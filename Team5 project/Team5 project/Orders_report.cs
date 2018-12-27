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
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using System.IO;

namespace Team5_project
{
    public partial class Orders_report : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        public Orders_report()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            sda = new SqlDataAdapter(@"select EId,Product_Serial,Price, Quantity, Date, Seller_name, Buyer_Id FROM Orders", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Orders_report_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dbdataset = new DataTable();
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                sda.Fill(dbdataset);
                ds.Tables.Add(dbdataset);
                ExcelLibrary.DataSetHelper.CreateWorkbook("Order_Report.xls", ds);
                MessageBox.Show("The file has succesfully been created!!!\nThe excel report had been created in folder:\n D:/Project/Team5/Team5/Team5 project/Team5 project/bin/Debug", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
