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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpStoreproduct1));
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
            this.returnCashier = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // Serialnumbox
            // 
            this.Serialnumbox.Location = new System.Drawing.Point(246, 111);
            this.Serialnumbox.Name = "Serialnumbox";
            this.Serialnumbox.Size = new System.Drawing.Size(570, 22);
            this.Serialnumbox.TabIndex = 17;
            this.Serialnumbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "serial number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Productdescbox
            // 
            this.Productdescbox.Location = new System.Drawing.Point(246, 210);
            this.Productdescbox.Name = "Productdescbox";
            this.Productdescbox.Size = new System.Drawing.Size(570, 22);
            this.Productdescbox.TabIndex = 15;
            this.Productdescbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Productnamebox
            // 
            this.Productnamebox.Location = new System.Drawing.Point(246, 159);
            this.Productnamebox.Name = "Productnamebox";
            this.Productnamebox.Size = new System.Drawing.Size(570, 22);
            this.Productnamebox.TabIndex = 14;
            this.Productnamebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "product description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "product name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // quntitybox
            // 
            this.quntitybox.Location = new System.Drawing.Point(246, 260);
            this.quntitybox.Name = "quntitybox";
            this.quntitybox.Size = new System.Drawing.Size(570, 22);
            this.quntitybox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "quntity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(246, 305);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(187, 22);
            this.PriceBox.TabIndex = 23;
            this.PriceBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // returnCashier
            // 
            this.returnCashier.Cursor = System.Windows.Forms.Cursors.Help;
            this.returnCashier.Image = ((System.Drawing.Image)(resources.GetObject("returnCashier.Image")));
            this.returnCashier.Location = new System.Drawing.Point(129, 27);
            this.returnCashier.Name = "returnCashier";
            this.returnCashier.Size = new System.Drawing.Size(42, 38);
            this.returnCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnCashier.TabIndex = 44;
            this.returnCashier.TabStop = false;
            this.returnCashier.Click += new System.EventHandler(this.returnCashier_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 39);
            this.button6.TabIndex = 43;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ExpStoreproduct1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.returnCashier);
            this.Controls.Add(this.button6);
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
            this.Name = "ExpStoreproduct1";
            this.Text = "Exp Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).EndInit();
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
        private System.Windows.Forms.PictureBox returnCashier;
        private System.Windows.Forms.Button button6;
    }
}