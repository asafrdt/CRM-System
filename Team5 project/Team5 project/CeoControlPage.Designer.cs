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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowRecoedsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteRecordsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShowRecoedsButton
            // 
            this.ShowRecoedsButton.Location = new System.Drawing.Point(460, 376);
            this.ShowRecoedsButton.Name = "ShowRecoedsButton";
            this.ShowRecoedsButton.Size = new System.Drawing.Size(223, 57);
            this.ShowRecoedsButton.TabIndex = 1;
            this.ShowRecoedsButton.Text = "Show Records";
            this.ShowRecoedsButton.UseVisualStyleBackColor = true;
            this.ShowRecoedsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update Rrcords";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteRecordsButton
            // 
            this.DeleteRecordsButton.Location = new System.Drawing.Point(751, 376);
            this.DeleteRecordsButton.Name = "DeleteRecordsButton";
            this.DeleteRecordsButton.Size = new System.Drawing.Size(263, 57);
            this.DeleteRecordsButton.TabIndex = 3;
            this.DeleteRecordsButton.Text = "Delete Records";
            this.DeleteRecordsButton.UseVisualStyleBackColor = true;
            this.DeleteRecordsButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CeoControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 638);
            this.Controls.Add(this.DeleteRecordsButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ShowRecoedsButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CeoControlPage";
            this.Text = "CeoControPage";
            this.Load += new System.EventHandler(this.CeoControlPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowRecoedsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DeleteRecordsButton;
    }
}