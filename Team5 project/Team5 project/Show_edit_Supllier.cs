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
    public partial class Show_edit_Supllier : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Show_edit_Supllier()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            sda = new SqlDataAdapter(@"select Suppllier_id as 'Suppllier id', Suppllier_full_name as 'Full name', Suppllier_Mobile as 'Phone number' FROM Suppllier", con);
          
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
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
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        hoja_trabajo.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                hoja_trabajo.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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

        private void Show_edit_Supllier_Load(object sender, EventArgs e)
        {

        }
    }
}
