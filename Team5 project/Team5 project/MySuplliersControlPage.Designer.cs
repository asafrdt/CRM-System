namespace Team5_project
{
    partial class MySuplliersControlPage
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
            this.Show_Edit_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Show_Edit_Button
            // 
            this.Show_Edit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Show_Edit_Button.FlatAppearance.BorderSize = 0;
            this.Show_Edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Edit_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Edit_Button.ForeColor = System.Drawing.Color.White;
            this.Show_Edit_Button.Image = global::Team5_project.Properties.Resources.searching_a_person;
            this.Show_Edit_Button.Location = new System.Drawing.Point(596, 12);
            this.Show_Edit_Button.Name = "Show_Edit_Button";
            this.Show_Edit_Button.Size = new System.Drawing.Size(195, 140);
            this.Show_Edit_Button.TabIndex = 22;
            this.Show_Edit_Button.Text = "Show and Edit";
            this.Show_Edit_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Show_Edit_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Show_Edit_Button.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Team5_project.Properties.Resources.Remove;
            this.button2.Location = new System.Drawing.Point(395, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 140);
            this.button2.TabIndex = 21;
            this.button2.Text = "Remove ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Team5_project.Properties.Resources.add_user_symbol;
            this.button5.Location = new System.Drawing.Point(194, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 140);
            this.button5.TabIndex = 20;
            this.button5.Text = "Add ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MySuplliersControlPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1020, 445);
            this.Controls.Add(this.Show_Edit_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 230);
            this.Name = "MySuplliersControlPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MySuplliersControlPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Show_Edit_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}