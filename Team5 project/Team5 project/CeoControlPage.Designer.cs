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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ShowRecoedsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.Location = new System.Drawing.Point(178, 48);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(803, 291);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ShowRecoedsButton
            // 
            this.ShowRecoedsButton.FlatAppearance.BorderSize = 0;
            this.ShowRecoedsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowRecoedsButton.Location = new System.Drawing.Point(303, 345);
            this.ShowRecoedsButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ShowRecoedsButton.Name = "ShowRecoedsButton";
            this.ShowRecoedsButton.Size = new System.Drawing.Size(126, 51);
            this.ShowRecoedsButton.TabIndex = 1;
            this.ShowRecoedsButton.Text = "Show";
            this.ShowRecoedsButton.UseVisualStyleBackColor = true;
            this.ShowRecoedsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(465, 345);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CeoControlPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1020, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ShowRecoedsButton);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 230);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "CeoControlPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CeoControPage";
            this.Load += new System.EventHandler(this.CeoControlPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ShowRecoedsButton;
        private System.Windows.Forms.Button button2;
    }
}