﻿namespace Team5_project
{
    partial class CeoAddWorker
    {
       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CeoAddWorker));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.FirstnameBox = new System.Windows.Forms.TextBox();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.returnCashier = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add Worker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(311, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Submit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "UserName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Phone";
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(141, 210);
            this.GenderBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(125, 24);
            this.GenderBox.TabIndex = 25;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Admin",
            "Expert",
            "Cashier"});
            this.TypeBox.Location = new System.Drawing.Point(500, 219);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(119, 24);
            this.TypeBox.TabIndex = 26;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // FirstnameBox
            // 
            this.FirstnameBox.Location = new System.Drawing.Point(141, 89);
            this.FirstnameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstnameBox.Name = "FirstnameBox";
            this.FirstnameBox.Size = new System.Drawing.Size(125, 22);
            this.FirstnameBox.TabIndex = 27;
            this.FirstnameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LastnameBox
            // 
            this.LastnameBox.Location = new System.Drawing.Point(141, 130);
            this.LastnameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(125, 22);
            this.LastnameBox.TabIndex = 28;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(141, 170);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(125, 22);
            this.PhoneBox.TabIndex = 29;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(500, 84);
            this.IDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(119, 22);
            this.IDBox.TabIndex = 30;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(500, 130);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(119, 22);
            this.UsernameBox.TabIndex = 31;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(500, 170);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(119, 22);
            this.PasswordBox.TabIndex = 32;
            // 
            // returnCashier
            // 
            this.returnCashier.Cursor = System.Windows.Forms.Cursors.Help;
            this.returnCashier.Image = ((System.Drawing.Image)(resources.GetObject("returnCashier.Image")));
            this.returnCashier.Location = new System.Drawing.Point(123, 13);
            this.returnCashier.Name = "returnCashier";
            this.returnCashier.Size = new System.Drawing.Size(42, 38);
            this.returnCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnCashier.TabIndex = 34;
            this.returnCashier.TabStop = false;
            this.returnCashier.Click += new System.EventHandler(this.returnCashier_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 39);
            this.button5.TabIndex = 33;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CeoAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.returnCashier);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.FirstnameBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CeoAddWorker";
            this.Text = "CeoAddWorker";
            this.Load += new System.EventHandler(this.CeoAddWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox textBox2;
        //private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox FirstnameBox;
        private System.Windows.Forms.TextBox LastnameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.PictureBox returnCashier;
        private System.Windows.Forms.Button button5;
    }
}