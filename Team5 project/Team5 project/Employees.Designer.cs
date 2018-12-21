namespace Team5_project
{
    partial class Employees
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
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Show_Edit_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employees";
            this.label1.UseWaitCursor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Team5_project.Properties.Resources.man_in_office_desk_with_computer;
            this.button4.Location = new System.Drawing.Point(646, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 140);
            this.button4.TabIndex = 10;
            this.button4.Text = "Hours Report";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Show_Edit_Button
            // 
            this.Show_Edit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Show_Edit_Button.FlatAppearance.BorderSize = 0;
            this.Show_Edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Edit_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Edit_Button.ForeColor = System.Drawing.Color.White;
            this.Show_Edit_Button.Image = global::Team5_project.Properties.Resources.searching_a_person;
            this.Show_Edit_Button.Location = new System.Drawing.Point(445, 93);
            this.Show_Edit_Button.Name = "Show_Edit_Button";
            this.Show_Edit_Button.Size = new System.Drawing.Size(195, 140);
            this.Show_Edit_Button.TabIndex = 15;
            this.Show_Edit_Button.Text = "Show and Edit";
            this.Show_Edit_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Show_Edit_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Show_Edit_Button.UseVisualStyleBackColor = true;
            this.Show_Edit_Button.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Team5_project.Properties.Resources.Remove;
            this.button2.Location = new System.Drawing.Point(244, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 140);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remove ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Team5_project.Properties.Resources.add_user_symbol;
            this.button5.Location = new System.Drawing.Point(43, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 140);
            this.button5.TabIndex = 13;
            this.button5.Text = "Add ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Employees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(858, 680);
            this.Controls.Add(this.Show_Edit_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 0);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Show_Edit_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}