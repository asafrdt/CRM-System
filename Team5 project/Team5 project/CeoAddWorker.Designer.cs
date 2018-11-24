namespace Team5_project
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(450, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Submit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "UserName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 30);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 30);
            this.label11.TabIndex = 24;
            this.label11.Text = "Phone";
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(250, 174);
            this.GenderBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(216, 38);
            this.GenderBox.TabIndex = 25;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Admin",
            "Expert",
            "Cashier"});
            this.TypeBox.Location = new System.Drawing.Point(654, 173);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(216, 38);
            this.TypeBox.TabIndex = 26;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // FirstnameBox
            // 
            this.FirstnameBox.Location = new System.Drawing.Point(250, 12);
            this.FirstnameBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.FirstnameBox.Name = "FirstnameBox";
            this.FirstnameBox.Size = new System.Drawing.Size(216, 37);
            this.FirstnameBox.TabIndex = 27;
            this.FirstnameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LastnameBox
            // 
            this.LastnameBox.Location = new System.Drawing.Point(250, 66);
            this.LastnameBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(216, 37);
            this.LastnameBox.TabIndex = 28;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(250, 121);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(216, 37);
            this.PhoneBox.TabIndex = 29;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(654, 12);
            this.IDBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(216, 37);
            this.IDBox.TabIndex = 30;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(654, 68);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(216, 37);
            this.UsernameBox.TabIndex = 31;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(654, 122);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(216, 37);
            this.PasswordBox.TabIndex = 32;
            // 
            // CeoAddWorker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1020, 445);
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
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 230);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "CeoAddWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CeoAddWorker";
            this.Load += new System.EventHandler(this.CeoAddWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox textBox2;
        //private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
    }
}