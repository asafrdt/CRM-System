namespace Team5_project
{
    partial class CeoControlPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CeoControlPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowRecoedsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteRecordsButton = new System.Windows.Forms.Button();
            this.returnCashier = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ShowRecoedsButton
            // 
            this.ShowRecoedsButton.Location = new System.Drawing.Point(410, 407);
            this.ShowRecoedsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowRecoedsButton.Name = "ShowRecoedsButton";
            this.ShowRecoedsButton.Size = new System.Drawing.Size(198, 46);
            this.ShowRecoedsButton.TabIndex = 1;
            this.ShowRecoedsButton.Text = "Show Records";
            this.ShowRecoedsButton.UseVisualStyleBackColor = true;
            this.ShowRecoedsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 407);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update Rrcords";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteRecordsButton
            // 
            this.DeleteRecordsButton.Location = new System.Drawing.Point(676, 407);
            this.DeleteRecordsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteRecordsButton.Name = "DeleteRecordsButton";
            this.DeleteRecordsButton.Size = new System.Drawing.Size(234, 46);
            this.DeleteRecordsButton.TabIndex = 3;
            this.DeleteRecordsButton.Text = "Delete Records";
            this.DeleteRecordsButton.UseVisualStyleBackColor = true;
            this.DeleteRecordsButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // returnCashier
            // 
            this.returnCashier.Cursor = System.Windows.Forms.Cursors.Help;
            this.returnCashier.Image = ((System.Drawing.Image)(resources.GetObject("returnCashier.Image")));
            this.returnCashier.Location = new System.Drawing.Point(123, 13);
            this.returnCashier.Name = "returnCashier";
            this.returnCashier.Size = new System.Drawing.Size(42, 38);
            this.returnCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnCashier.TabIndex = 36;
            this.returnCashier.TabStop = false;
            this.returnCashier.Click += new System.EventHandler(this.returnCashier_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 39);
            this.button5.TabIndex = 35;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CeoControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 510);
            this.Controls.Add(this.returnCashier);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DeleteRecordsButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ShowRecoedsButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CeoControlPage";
            this.Text = "CeoControPage";
            this.Load += new System.EventHandler(this.CeoControlPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowRecoedsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DeleteRecordsButton;
        private System.Windows.Forms.PictureBox returnCashier;
        private System.Windows.Forms.Button button5;
    }
}