namespace Team5_project
{
    partial class Placingacostumer
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
            this.button1 = new System.Windows.Forms.Button();
            this.CashRegister = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(520, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placing a costumer";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Team5_project.Properties.Resources.new_user;
            this.button1.Location = new System.Drawing.Point(489, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 124);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add new costumer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashRegister
            // 
            this.CashRegister.FlatAppearance.BorderSize = 0;
            this.CashRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashRegister.ForeColor = System.Drawing.Color.White;
            this.CashRegister.Image = global::Team5_project.Properties.Resources.searching_a_person1;
            this.CashRegister.Location = new System.Drawing.Point(125, 86);
            this.CashRegister.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CashRegister.Name = "CashRegister";
            this.CashRegister.Size = new System.Drawing.Size(283, 124);
            this.CashRegister.TabIndex = 1;
            this.CashRegister.Text = "Exiting costumer";
            this.CashRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CashRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CashRegister.UseVisualStyleBackColor = true;
            this.CashRegister.Click += new System.EventHandler(this.CashRegister_Click);
            // 
            // Placingacostumer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(860, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CashRegister);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Placingacostumer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Placingacostumer";
            this.Load += new System.EventHandler(this.Placingacostumer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CashRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}