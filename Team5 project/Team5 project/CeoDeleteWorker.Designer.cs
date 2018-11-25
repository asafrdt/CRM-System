namespace Team5_project
{
    partial class CeoDeleteWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CeoDeleteWorker));
            this.DeleteIDBox = new System.Windows.Forms.TextBox();
            this.SubmitBox = new System.Windows.Forms.Button();
            this.label1234 = new System.Windows.Forms.Label();
            this.label2423 = new System.Windows.Forms.Label();
            this.returnCashier = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteIDBox
            // 
            this.DeleteIDBox.Location = new System.Drawing.Point(266, 244);
            this.DeleteIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteIDBox.Name = "DeleteIDBox";
            this.DeleteIDBox.Size = new System.Drawing.Size(158, 22);
            this.DeleteIDBox.TabIndex = 2;
            // 
            // SubmitBox
            // 
            this.SubmitBox.Location = new System.Drawing.Point(304, 284);
            this.SubmitBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitBox.Name = "SubmitBox";
            this.SubmitBox.Size = new System.Drawing.Size(67, 24);
            this.SubmitBox.TabIndex = 4;
            this.SubmitBox.Text = "Submit";
            this.SubmitBox.UseVisualStyleBackColor = true;
            this.SubmitBox.Click += new System.EventHandler(this.SubmitBox_Click);
            // 
            // label1234
            // 
            this.label1234.AutoSize = true;
            this.label1234.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1234.Location = new System.Drawing.Point(32, 202);
            this.label1234.Name = "label1234";
            this.label1234.Size = new System.Drawing.Size(618, 16);
            this.label1234.TabIndex = 5;
            this.label1234.Text = "Please enter the ID of the worker that you want to delete from the system";
            // 
            // label2423
            // 
            this.label2423.AutoSize = true;
            this.label2423.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2423.Location = new System.Drawing.Point(272, 167);
            this.label2423.Name = "label2423";
            this.label2423.Size = new System.Drawing.Size(128, 16);
            this.label2423.TabIndex = 6;
            this.label2423.Text = "Delete Worker";
            // 
            // returnCashier
            // 
            this.returnCashier.Cursor = System.Windows.Forms.Cursors.Help;
            this.returnCashier.Image = ((System.Drawing.Image)(resources.GetObject("returnCashier.Image")));
            this.returnCashier.Location = new System.Drawing.Point(146, 26);
            this.returnCashier.Name = "returnCashier";
            this.returnCashier.Size = new System.Drawing.Size(42, 38);
            this.returnCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnCashier.TabIndex = 38;
            this.returnCashier.TabStop = false;
            this.returnCashier.Click += new System.EventHandler(this.returnCashier_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(35, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 39);
            this.button5.TabIndex = 37;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CeoDeleteWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.returnCashier);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2423);
            this.Controls.Add(this.label1234);
            this.Controls.Add(this.SubmitBox);
            this.Controls.Add(this.DeleteIDBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CeoDeleteWorker";
            this.Text = "CeoDeleteWorker";
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DeleteIDBox;
        private System.Windows.Forms.Button SubmitBox;
        private System.Windows.Forms.Label label1234;
        private System.Windows.Forms.Label label2423;
        private System.Windows.Forms.PictureBox returnCashier;
        private System.Windows.Forms.Button button5;
    }
}