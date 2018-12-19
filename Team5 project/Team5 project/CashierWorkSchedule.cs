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
            this.timer1.Start();
            MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
            SmtpClient client = new SmtpClient(smtp.Text);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(Username.Text, Password.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail Sent!", "Success", MessageBoxButtons.OK);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);

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
            this.Hide();
            CashierPrivateArea mm = new CashierPrivateArea();
            mm.Show();
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
    }
}
