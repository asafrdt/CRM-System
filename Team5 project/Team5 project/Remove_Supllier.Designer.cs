﻿namespace Team5_project
{
    partial class Remove_Supllier
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
            this.DeleteSerialNumberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1234
            // 
            this.label1234.AutoSize = true;
            this.label1234.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1234.Location = new System.Drawing.Point(288, 16);
            this.label1234.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1234.Name = "label1234";
            this.label1234.Size = new System.Drawing.Size(172, 28);
            this.label1234.TabIndex = 11;
            this.label1234.Text = "Serial number";
            // 
            // SubmitBox
            // 
            this.SubmitBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBox.ForeColor = System.Drawing.Color.Black;
            this.SubmitBox.Location = new System.Drawing.Point(360, 55);
            this.SubmitBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SubmitBox.Name = "SubmitBox";
            this.SubmitBox.Size = new System.Drawing.Size(117, 43);
            this.SubmitBox.TabIndex = 10;
            this.SubmitBox.Text = "Submit";
            this.SubmitBox.UseVisualStyleBackColor = true;
            this.SubmitBox.Click += new System.EventHandler(this.SubmitBox_Click);
            // 
            // DeleteSerialNumberBox
            // 
            this.DeleteSerialNumberBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSerialNumberBox.Location = new System.Drawing.Point(410, 12);
            this.DeleteSerialNumberBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DeleteSerialNumberBox.MaximumSize = new System.Drawing.Size(500, 500);
            this.DeleteSerialNumberBox.Name = "DeleteSerialNumberBox";
            this.DeleteSerialNumberBox.Size = new System.Drawing.Size(116, 37);
            this.DeleteSerialNumberBox.TabIndex = 9;
            this.DeleteSerialNumberBox.TextChanged += new System.EventHandler(this.DeleteSerialNumberBox_TextChanged);
            // 
            // Remove_Supllier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(778, 394);
            this.Controls.Add(this.label1234);
            this.Controls.Add(this.SubmitBox);
            this.Controls.Add(this.DeleteSerialNumberBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 250);
            this.Name = "Remove_Supllier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Remove_Supllier";
            this.Load += new System.EventHandler(this.Remove_Supllier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1234;
        private System.Windows.Forms.Button SubmitBox;
        private System.Windows.Forms.TextBox DeleteSerialNumberBox;
    }
}