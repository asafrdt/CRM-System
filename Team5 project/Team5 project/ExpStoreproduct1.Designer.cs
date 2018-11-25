namespace Team5_project
{
    partial class ExpStoreproduct1
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
            this.Serialnumbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Productdescbox = new System.Windows.Forms.TextBox();
            this.Productnamebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quntitybox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Serialnumbox
            // 
            this.Serialnumbox.Location = new System.Drawing.Point(277, 107);
            this.Serialnumbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Serialnumbox.Name = "Serialnumbox";
            this.Serialnumbox.Size = new System.Drawing.Size(641, 26);
            this.Serialnumbox.TabIndex = 17;
            this.Serialnumbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "serial number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Productdescbox
            // 
            this.Productdescbox.Location = new System.Drawing.Point(277, 205);
            this.Productdescbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Productdescbox.Name = "Productdescbox";
            this.Productdescbox.Size = new System.Drawing.Size(641, 26);
            this.Productdescbox.TabIndex = 15;
            this.Productdescbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Productnamebox
            // 
            this.Productnamebox.Location = new System.Drawing.Point(277, 157);
            this.Productnamebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Productnamebox.Name = "Productnamebox";
            this.Productnamebox.Size = new System.Drawing.Size(641, 26);
            this.Productnamebox.TabIndex = 14;
            this.Productnamebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "product description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "product name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // quntitybox
            // 
            this.quntitybox.Location = new System.Drawing.Point(277, 252);
            this.quntitybox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quntitybox.Name = "quntitybox";
            this.quntitybox.Size = new System.Drawing.Size(641, 26);
            this.quntitybox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "quntity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 56);
            this.button1.TabIndex = 21;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(277, 292);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(210, 26);
            this.PriceBox.TabIndex = 23;
            this.PriceBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // ExpStoreproduct1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 562);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quntitybox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Serialnumbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Productdescbox);
            this.Controls.Add(this.Productnamebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExpStoreproduct1";
            this.Text = "Exp Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Serialnumbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Productdescbox;
        private System.Windows.Forms.TextBox Productnamebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quntitybox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label5;
    }
}