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
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;

namespace Team5_project
{
  
    public partial class Work_Hours : Form
    {
        DataTable dt;
        //SqlCommandBuilder scb;
        SqlDataAdapter sda;
        public Work_Hours()
        {
            InitializeComponent();
            Fillcombo();

        }
        void Fillcombo()
        {
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Employees ", conn);
            comboBox1.Items.Clear();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select username from Employees";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["username"].ToString());
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(@"select Username as 'User name', shift_date as 'Shift date', logtimeIn as 'Login time', logtimeOut as 'Logout time',CalculateHours as 'Shift Hours' FROM Work_card WHERE Username='" + comboBox1.Text + "' AND Year = '" + comboBox2.Text + "' AND Month = '" + comboBox3.Text + "'", con);
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please choose an employee ! ","alert", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                else if (comboBox2.Text == "")
                {
                    MessageBox.Show("Please choose an Year ! ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboBox3.Text == "")
                {
                    MessageBox.Show("Please choose an Mobth ! ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Work_Hours_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(@"select Username as 'User name', shift_date as 'Shift date', logtimeIn as 'Login time', logtimeOut as 'Logout time',CalculateHours as 'Shift Hours' FROM Work_card WHERE Year =  '" + comboBox2.Text + "' AND Month = '" + comboBox3.Text + "'", con);
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                try
                {
                    for (int i = 0; i < dataGridView2.Columns.Count; i++)
                    {
                        hoja_trabajo.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value != null)
                            {
                                hoja_trabajo.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                hoja_trabajo.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        hoja_trabajo.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);


                try
                {
                    for (int i = 0; i < dataGridView2.Columns.Count; i++)
                    {
                        hoja_trabajo.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value != null)
                            {
                                hoja_trabajo.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                hoja_trabajo.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        hoja_trabajo.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
    }
    
}
