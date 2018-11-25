namespace Team5_project
{
    partial class CeoStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CeoStore));
            this.button3 = new System.Windows.Forms.Button();
            this.DeleteWorker = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.returnCashier = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 130);
            this.button3.TabIndex = 12;
            this.button3.Text = "הוספת עובד ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteWorker
            // 
            this.DeleteWorker.Location = new System.Drawing.Point(91, 229);
            this.DeleteWorker.Name = "DeleteWorker";
            this.DeleteWorker.Size = new System.Drawing.Size(231, 130);
            this.DeleteWorker.TabIndex = 13;
            this.DeleteWorker.Text = "מחיקת עובד";
            this.DeleteWorker.UseVisualStyleBackColor = true;
            this.DeleteWorker.Click += new System.EventHandler(this.DeleteWorker_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 81);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 130);
            this.button1.TabIndex = 14;
            this.button1.Text = "CeoControlPage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 130);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sell";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(603, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 130);
            this.button4.TabIndex = 17;
            this.button4.Text = "הכנסת מוצר";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(603, 229);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 129);
            this.button5.TabIndex = 16;
            this.button5.Text = "חיפוש מוצר";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // returnCashier
            // 
            this.returnCashier.Cursor = System.Windows.Forms.Cursors.Help;
            this.returnCashier.Image = ((System.Drawing.Image)(resources.GetObject("returnCashier.Image")));
            this.returnCashier.Location = new System.Drawing.Point(132, 13);
            this.returnCashier.Name = "returnCashier";
            this.returnCashier.Size = new System.Drawing.Size(42, 38);
            this.returnCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnCashier.TabIndex = 40;
            this.returnCashier.TabStop = false;
            this.returnCashier.Click += new System.EventHandler(this.returnCashier_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 39);
            this.button6.TabIndex = 39;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CeoStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 382);
            this.Controls.Add(this.returnCashier);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteWorker);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CeoStore";
            this.Text = "CeoStore";
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DeleteWorker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox returnCashier;
        private System.Windows.Forms.Button button6;
    }
}