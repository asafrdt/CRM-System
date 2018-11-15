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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DeleteIDBox = new System.Windows.Forms.TextBox();
            this.SubmitBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Delete Worker";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(528, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Please enter the ID of the worker that you want to delete from the system";
            // 
            // DeleteIDBox
            // 
            this.DeleteIDBox.Location = new System.Drawing.Point(299, 146);
            this.DeleteIDBox.Name = "DeleteIDBox";
            this.DeleteIDBox.Size = new System.Drawing.Size(177, 26);
            this.DeleteIDBox.TabIndex = 2;
            // 
            // SubmitBox
            // 
            this.SubmitBox.Location = new System.Drawing.Point(329, 204);
            this.SubmitBox.Name = "SubmitBox";
            this.SubmitBox.Size = new System.Drawing.Size(75, 30);
            this.SubmitBox.TabIndex = 4;
            this.SubmitBox.Text = "Submit";
            this.SubmitBox.UseVisualStyleBackColor = true;
            this.SubmitBox.Click += new System.EventHandler(this.SubmitBox_Click);
            // 
            // CeoDeleteWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitBox);
            this.Controls.Add(this.DeleteIDBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "CeoDeleteWorker";
            this.Text = "CeoDeleteWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox DeleteIDBox;
        private System.Windows.Forms.Button SubmitBox;
    }
}