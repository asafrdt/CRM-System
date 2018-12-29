namespace Team5_project
{
    partial class MyStockControlPage
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.Show_Edit_Button.Location = new System.Drawing.Point(548, 74);
            this.Show_Edit_Button.Name = "Show_Edit_Button";
            this.Show_Edit_Button.Size = new System.Drawing.Size(195, 140);
            this.Show_Edit_Button.TabIndex = 19;
            this.Show_Edit_Button.Text = "Show and Edit";
            this.Show_Edit_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Show_Edit_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Show_Edit_Button.UseVisualStyleBackColor = true;
            this.Show_Edit_Button.Click += new System.EventHandler(this.Show_Edit_Button_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Team5_project.Properties.Resources.Remove;
            this.button2.Location = new System.Drawing.Point(347, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 140);
            this.button2.TabIndex = 18;
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
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Team5_project.Properties.Resources.add_user_symbol;
            this.button5.Location = new System.Drawing.Point(146, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 140);
            this.button5.TabIndex = 17;
            this.button5.Text = "Add ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 62);
            this.label1.TabIndex = 20;
            this.label1.Text = "Stock and Suppliers";
            // 
            // MyStockControlPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(860, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Show_Edit_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 0);
            this.Name = "MyStockControlPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyStockControlPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show_Edit_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}