namespace Team5_project
{
    partial class Change_password
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
            this.label1234 = new System.Windows.Forms.Label();
            this.SubmitBox = new System.Windows.Forms.Button();
            this.UpdatePassword1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdatePassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1234
            // 
            this.label1234.AutoSize = true;
            this.label1234.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1234.Location = new System.Drawing.Point(163, 56);
            this.label1234.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1234.Name = "label1234";
            this.label1234.Size = new System.Drawing.Size(279, 28);
            this.label1234.TabIndex = 8;
            this.label1234.Text = "Enter a new password :";
            // 
            // SubmitBox
            // 
            this.SubmitBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitBox.ForeColor = System.Drawing.Color.Black;
            this.SubmitBox.Location = new System.Drawing.Point(380, 156);
            this.SubmitBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SubmitBox.Name = "SubmitBox";
            this.SubmitBox.Size = new System.Drawing.Size(117, 45);
            this.SubmitBox.TabIndex = 3;
            this.SubmitBox.Text = "Update";
            this.SubmitBox.UseVisualStyleBackColor = true;
            this.SubmitBox.Click += new System.EventHandler(this.SubmitBox_Click);
            // 
            // UpdatePassword1
            // 
            this.UpdatePassword1.Location = new System.Drawing.Point(498, 53);
            this.UpdatePassword1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.UpdatePassword1.Name = "UpdatePassword1";
            this.UpdatePassword1.Size = new System.Drawing.Size(173, 37);
            this.UpdatePassword1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter a new password again : ";
            // 
            // UpdatePassword2
            // 
            this.UpdatePassword2.Location = new System.Drawing.Point(498, 96);
            this.UpdatePassword2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.UpdatePassword2.Name = "UpdatePassword2";
            this.UpdatePassword2.Size = new System.Drawing.Size(173, 37);
            this.UpdatePassword2.TabIndex = 2;
            // 
            // Change_password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1020, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdatePassword2);
            this.Controls.Add(this.label1234);
            this.Controls.Add(this.SubmitBox);
            this.Controls.Add(this.UpdatePassword1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 255);
            this.Name = "Change_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Change_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1234;
        private System.Windows.Forms.Button SubmitBox;
        private System.Windows.Forms.TextBox UpdatePassword1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpdatePassword2;
    }
}