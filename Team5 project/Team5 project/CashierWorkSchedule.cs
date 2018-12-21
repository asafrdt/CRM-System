using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Web;
using System.Net.Mail;


namespace Team5_project
{
    public partial class CashierWorkSchedule : Form
    {
        public CashierWorkSchedule()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || to.Text == "" || body.Text == "")
            {
                if (Username.Text == "")
                    MessageBox.Show("from could not be empty field!");
                else if (to.Text == "")
                    MessageBox.Show("to could not be empty field!");
                else if (body.Text == "")
                    MessageBox.Show(" !לא הוכנסו אילוצים");
            }
            else
            {

                MailMessage mail = new MailMessage(Username.Text, to.Text, subject.Text, body.Text);

                if (Attachment1.Text != "")
                {
                    mail.Attachments.Add(new Attachment(Attachment1.Text));
                }
                SmtpClient client = new SmtpClient(smtp.Text);
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(Username.Text, Password.Text);
                client.EnableSsl = true;
                try
                {
                    client.Send(mail);
                    this.timer1.Start();
                    MessageBox.Show("Mail Sent!", "Success", MessageBoxButtons.OK);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("wrong password!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Debug.WriteLine("Exception Message: " + ex.Message);
                    if (ex.InnerException != null)
                        System.Diagnostics.Debug.WriteLine("Exception Inner:   " + ex.InnerException);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Attachment1.Text != null)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                //dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string picPath = dlg.FileName.ToString();
                    //textBox_inage_path.Text = picPath;
                    Attachment1.Text = picPath;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(15);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shishiB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void returnCashierStore_Click(object sender, EventArgs e)
        {
        }

        private void CashierWorkSchedule_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void body_TextChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialogl = new FontDialog();
            fontDialogl.ShowColor = true;
            if (fontDialogl.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(body.Text))
            {
                body.SelectionFont = fontDialogl.Font;
                body.SelectionColor = fontDialogl.Color;
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
