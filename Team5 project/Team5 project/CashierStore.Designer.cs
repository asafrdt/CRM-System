namespace Team5_project
{
    partial class CashierStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierStore));
            this.returnCashier2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier2)).BeginInit();
            this.SuspendLayout();
            // 
            // returnCashier2
            // 
            this.returnCashier2.Image = ((System.Drawing.Image)(resources.GetObject("returnCashier2.Image")));
            this.returnCashier2.Location = new System.Drawing.Point(135, 24);
            this.returnCashier2.Name = "returnCashier2";
            this.returnCashier2.Size = new System.Drawing.Size(42, 38);
            this.returnCashier2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnCashier2.TabIndex = 16;
            this.returnCashier2.TabStop = false;
            this.returnCashier2.Click += new System.EventHandler(this.returnCashier2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 39);
            this.button5.TabIndex = 15;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 90);
            this.button3.TabIndex = 19;
            this.button3.Text = "מלאי חנות";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 90);
            this.button2.TabIndex = 18;
            this.button2.Text = "הוספת לקוח קיים";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 90);
            this.button1.TabIndex = 17;
            this.button1.Text = "לקוח קיים";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashierStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.returnCashier2);
            this.Controls.Add(this.button5);
            this.Name = "CashierStore";
            this.Text = "CashierStore";
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox returnCashier2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}