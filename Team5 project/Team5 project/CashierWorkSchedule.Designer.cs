﻿namespace Team5_project
{
    partial class CashierWorkSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.RichTextBox();
            this.smtp = new System.Windows.Forms.ComboBox();
            this.Attachment1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(298, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 350);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 30);
            this.label11.TabIndex = 31;
            this.label11.Text = "from";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 30);
            this.label9.TabIndex = 30;
            this.label9.Text = "smtp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 36;
            this.label3.Text = "subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 34);
            this.label2.TabIndex = 43;
            this.label2.Text = "Write your text below:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(613, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 30);
            this.label7.TabIndex = 46;
            this.label7.Text = "Morning shift- 08:00 - 14:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(613, 331);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 30);
            this.label8.TabIndex = 47;
            this.label8.Text = "Lunch shift- 12:00 - 18:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(613, 378);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 30);
            this.label10.TabIndex = 48;
            this.label10.Text = "Evning shift- 16:00 - 22:00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Orange;
            this.label12.Location = new System.Drawing.Point(554, 238);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 30);
            this.label12.TabIndex = 49;
            this.label12.Text = "ceo - ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(613, 238);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(246, 30);
            this.label14.TabIndex = 51;
            this.label14.Text = "asafrdt@gmail.com";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(59, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 29);
            this.button2.TabIndex = 54;
            this.button2.Text = "Attach";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(486, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 56;
            this.button3.Text = "Change Font ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(185, 25);
            this.Username.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(216, 37);
            this.Username.TabIndex = 57;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(185, 74);
            this.to.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(216, 37);
            this.to.TabIndex = 58;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(185, 173);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(216, 37);
            this.Password.TabIndex = 60;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(185, 122);
            this.subject.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(216, 37);
            this.subject.TabIndex = 59;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(488, 42);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(518, 190);
            this.body.TabIndex = 62;
            this.body.Text = "";
            // 
            // smtp
            // 
            this.smtp.FormattingEnabled = true;
            this.smtp.ItemHeight = 30;
            this.smtp.Items.AddRange(new object[] {
            "smtp.gmail.com",
            "smtp.yahoo.com"});
            this.smtp.Location = new System.Drawing.Point(185, 223);
            this.smtp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(216, 38);
            this.smtp.TabIndex = 64;
            // 
            // Attachment1
            // 
            this.Attachment1.Location = new System.Drawing.Point(185, 277);
            this.Attachment1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Attachment1.Name = "Attachment1";
            this.Attachment1.Size = new System.Drawing.Size(216, 37);
            this.Attachment1.TabIndex = 65;
            // 
            // CashierWorkSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1020, 439);
            this.Controls.Add(this.Attachment1);
            this.Controls.Add(this.smtp);
            this.Controls.Add(this.body);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.to);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 255);
            this.Name = "CashierWorkSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CashierWorkSchedule";
            this.Load += new System.EventHandler(this.CashierWorkSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.ComboBox smtp;
        private System.Windows.Forms.TextBox Attachment1;
    }
}