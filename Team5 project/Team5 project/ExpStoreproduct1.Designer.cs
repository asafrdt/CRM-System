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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(246, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(570, 22);
            this.textBox3.TabIndex = 17;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "serial number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(570, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(570, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "product description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "product name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(246, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(570, 22);
            this.textBox4.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "quntity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpStoreproduct1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExpStoreproduct1";
            this.Text = "Exp Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}