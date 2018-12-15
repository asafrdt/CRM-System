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
            this.DeleteIDBox = new System.Windows.Forms.TextBox();
            this.SubmitBox = new System.Windows.Forms.Button();
            this.label1234 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteIDBox
            // 
            this.DeleteIDBox.Location = new System.Drawing.Point(426, 23);
            this.DeleteIDBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DeleteIDBox.Name = "DeleteIDBox";
            this.DeleteIDBox.Size = new System.Drawing.Size(173, 37);
            this.DeleteIDBox.TabIndex = 2;
            this.DeleteIDBox.TextChanged += new System.EventHandler(this.DeleteIDBox_TextChanged);
            // 
            // SubmitBox
            // 
            this.SubmitBox.Location = new System.Drawing.Point(341, 78);
            this.SubmitBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SubmitBox.Name = "SubmitBox";
            this.SubmitBox.Size = new System.Drawing.Size(117, 45);
            this.SubmitBox.TabIndex = 4;
            this.SubmitBox.Text = "Submit";
            this.SubmitBox.UseVisualStyleBackColor = true;
            this.SubmitBox.Click += new System.EventHandler(this.SubmitBox_Click);
            // 
            // label1234
            // 
            this.label1234.AutoSize = true;
            this.label1234.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1234.Location = new System.Drawing.Point(187, 28);
            this.label1234.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1234.Name = "label1234";
            this.label1234.Size = new System.Drawing.Size(229, 28);
            this.label1234.TabIndex = 5;
            this.label1234.Text = "Enter Employee ID:";
            // 
            // CeoDeleteWorker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(912, 144);
            this.Controls.Add(this.label1234);
            this.Controls.Add(this.SubmitBox);
            this.Controls.Add(this.DeleteIDBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "CeoDeleteWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CeoDeleteWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DeleteIDBox;
        private System.Windows.Forms.Button SubmitBox;
        private System.Windows.Forms.Label label1234;
    }
}