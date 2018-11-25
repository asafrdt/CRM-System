namespace Team5_project
{
    partial class ExitingCoustumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitingCoustumer));
            this.CostumerSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.returnCashier = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // CostumerSearch
            // 
            this.CostumerSearch.Location = new System.Drawing.Point(343, 133);
            this.CostumerSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CostumerSearch.Name = "CostumerSearch";
            this.CostumerSearch.Size = new System.Drawing.Size(136, 22);
            this.CostumerSearch.TabIndex = 0;
            this.CostumerSearch.TextChanged += new System.EventHandler(this.CostumerSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Costumer ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(810, 60);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // returnCashier
            // 
            this.returnCashier.Cursor = System.Windows.Forms.Cursors.Help;
            this.returnCashier.Image = ((System.Drawing.Image)(resources.GetObject("returnCashier.Image")));
            this.returnCashier.Location = new System.Drawing.Point(123, 25);
            this.returnCashier.Name = "returnCashier";
            this.returnCashier.Size = new System.Drawing.Size(42, 38);
            this.returnCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnCashier.TabIndex = 42;
            this.returnCashier.TabStop = false;
            this.returnCashier.Click += new System.EventHandler(this.returnCashier_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 39);
            this.button6.TabIndex = 41;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ExitingCoustumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 360);
            this.Controls.Add(this.returnCashier);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CostumerSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExitingCoustumer";
            this.Text = "ExitingCoustumer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CostumerSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox returnCashier;
        private System.Windows.Forms.Button button6;
    }
}