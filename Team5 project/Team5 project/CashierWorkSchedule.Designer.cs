namespace Team5_project
{
    partial class CashierWorkSchedule
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rishonB = new System.Windows.Forms.CheckBox();
            this.shishiB = new System.Windows.Forms.CheckBox();
            this.hamishiB = new System.Windows.Forms.CheckBox();
            this.reveyB = new System.Windows.Forms.CheckBox();
            this.shlishiB = new System.Windows.Forms.CheckBox();
            this.sheniB = new System.Windows.Forms.CheckBox();
            this.rishonTZ = new System.Windows.Forms.CheckBox();
            this.rishonERV = new System.Windows.Forms.CheckBox();
            this.sheniERV = new System.Windows.Forms.CheckBox();
            this.sheniTZ = new System.Windows.Forms.CheckBox();
            this.shishiTZ = new System.Windows.Forms.CheckBox();
            this.hamishiTZ = new System.Windows.Forms.CheckBox();
            this.reveyERV = new System.Windows.Forms.CheckBox();
            this.reveyTZ = new System.Windows.Forms.CheckBox();
            this.shlishiERV = new System.Windows.Forms.CheckBox();
            this.shlishiTZ = new System.Windows.Forms.CheckBox();
            this.shishiERV = new System.Windows.Forms.CheckBox();
            this.hamishiERV = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "שלח טופס";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(278, 359);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reveyERV, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.rishonB, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.sheniB, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.shlishiB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.reveyB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.hamishiB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.shishiB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rishonTZ, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.rishonERV, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.sheniTZ, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.sheniERV, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.shlishiTZ, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.shlishiERV, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.reveyTZ, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.hamishiTZ, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.shishiTZ, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.hamishiERV, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.shishiERV, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(108, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.44555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.55445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 167);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // rishonB
            // 
            this.rishonB.AutoSize = true;
            this.rishonB.Location = new System.Drawing.Point(470, 56);
            this.rishonB.Name = "rishonB";
            this.rishonB.Size = new System.Drawing.Size(57, 21);
            this.rishonB.TabIndex = 0;
            this.rishonB.Text = "בוקר";
            this.rishonB.UseVisualStyleBackColor = true;
            // 
            // shishiB
            // 
            this.shishiB.AutoSize = true;
            this.shishiB.Location = new System.Drawing.Point(3, 56);
            this.shishiB.Name = "shishiB";
            this.shishiB.Size = new System.Drawing.Size(57, 21);
            this.shishiB.TabIndex = 1;
            this.shishiB.Text = "בוקר";
            this.shishiB.UseVisualStyleBackColor = true;
            this.shishiB.CheckedChanged += new System.EventHandler(this.shishiB_CheckedChanged);
            // 
            // hamishiB
            // 
            this.hamishiB.AutoSize = true;
            this.hamishiB.Location = new System.Drawing.Point(98, 56);
            this.hamishiB.Name = "hamishiB";
            this.hamishiB.Size = new System.Drawing.Size(57, 21);
            this.hamishiB.TabIndex = 2;
            this.hamishiB.Text = "בוקר";
            this.hamishiB.UseVisualStyleBackColor = true;
            // 
            // reveyB
            // 
            this.reveyB.AutoSize = true;
            this.reveyB.Location = new System.Drawing.Point(188, 56);
            this.reveyB.Name = "reveyB";
            this.reveyB.Size = new System.Drawing.Size(57, 21);
            this.reveyB.TabIndex = 3;
            this.reveyB.Text = "בוקר";
            this.reveyB.UseVisualStyleBackColor = true;
            // 
            // shlishiB
            // 
            this.shlishiB.AutoSize = true;
            this.shlishiB.Location = new System.Drawing.Point(281, 56);
            this.shlishiB.Name = "shlishiB";
            this.shlishiB.Size = new System.Drawing.Size(57, 21);
            this.shlishiB.TabIndex = 4;
            this.shlishiB.Text = "בוקר";
            this.shlishiB.UseVisualStyleBackColor = true;
            // 
            // sheniB
            // 
            this.sheniB.AutoSize = true;
            this.sheniB.Location = new System.Drawing.Point(376, 56);
            this.sheniB.Name = "sheniB";
            this.sheniB.Size = new System.Drawing.Size(57, 21);
            this.sheniB.TabIndex = 5;
            this.sheniB.Text = "בוקר";
            this.sheniB.UseVisualStyleBackColor = true;
            // 
            // rishonTZ
            // 
            this.rishonTZ.AutoSize = true;
            this.rishonTZ.Location = new System.Drawing.Point(470, 98);
            this.rishonTZ.Name = "rishonTZ";
            this.rishonTZ.Size = new System.Drawing.Size(69, 21);
            this.rishonTZ.TabIndex = 6;
            this.rishonTZ.Text = "צהריים";
            this.rishonTZ.UseVisualStyleBackColor = true;
            // 
            // rishonERV
            // 
            this.rishonERV.AutoSize = true;
            this.rishonERV.Location = new System.Drawing.Point(470, 135);
            this.rishonERV.Name = "rishonERV";
            this.rishonERV.Size = new System.Drawing.Size(53, 21);
            this.rishonERV.TabIndex = 7;
            this.rishonERV.Text = "ערב";
            this.rishonERV.UseVisualStyleBackColor = true;
            // 
            // sheniERV
            // 
            this.sheniERV.AutoSize = true;
            this.sheniERV.Location = new System.Drawing.Point(376, 135);
            this.sheniERV.Name = "sheniERV";
            this.sheniERV.Size = new System.Drawing.Size(53, 21);
            this.sheniERV.TabIndex = 8;
            this.sheniERV.Text = "ערב";
            this.sheniERV.UseVisualStyleBackColor = true;
            // 
            // sheniTZ
            // 
            this.sheniTZ.AutoSize = true;
            this.sheniTZ.Location = new System.Drawing.Point(376, 98);
            this.sheniTZ.Name = "sheniTZ";
            this.sheniTZ.Size = new System.Drawing.Size(69, 21);
            this.sheniTZ.TabIndex = 9;
            this.sheniTZ.Text = "צהריים";
            this.sheniTZ.UseVisualStyleBackColor = true;
            // 
            // shishiTZ
            // 
            this.shishiTZ.AutoSize = true;
            this.shishiTZ.Location = new System.Drawing.Point(3, 98);
            this.shishiTZ.Name = "shishiTZ";
            this.shishiTZ.Size = new System.Drawing.Size(69, 21);
            this.shishiTZ.TabIndex = 10;
            this.shishiTZ.Text = "צהריים";
            this.shishiTZ.UseVisualStyleBackColor = true;
            // 
            // hamishiTZ
            // 
            this.hamishiTZ.AutoSize = true;
            this.hamishiTZ.Location = new System.Drawing.Point(98, 98);
            this.hamishiTZ.Name = "hamishiTZ";
            this.hamishiTZ.Size = new System.Drawing.Size(69, 21);
            this.hamishiTZ.TabIndex = 11;
            this.hamishiTZ.Text = "צהריים";
            this.hamishiTZ.UseVisualStyleBackColor = true;
            // 
            // reveyERV
            // 
            this.reveyERV.AutoSize = true;
            this.reveyERV.Location = new System.Drawing.Point(188, 135);
            this.reveyERV.Name = "reveyERV";
            this.reveyERV.Size = new System.Drawing.Size(53, 21);
            this.reveyERV.TabIndex = 12;
            this.reveyERV.Text = "ערב";
            this.reveyERV.UseVisualStyleBackColor = true;
            // 
            // reveyTZ
            // 
            this.reveyTZ.AutoSize = true;
            this.reveyTZ.Location = new System.Drawing.Point(188, 98);
            this.reveyTZ.Name = "reveyTZ";
            this.reveyTZ.Size = new System.Drawing.Size(69, 21);
            this.reveyTZ.TabIndex = 13;
            this.reveyTZ.Text = "צהריים";
            this.reveyTZ.UseVisualStyleBackColor = true;
            // 
            // shlishiERV
            // 
            this.shlishiERV.AutoSize = true;
            this.shlishiERV.Location = new System.Drawing.Point(281, 135);
            this.shlishiERV.Name = "shlishiERV";
            this.shlishiERV.Size = new System.Drawing.Size(53, 21);
            this.shlishiERV.TabIndex = 14;
            this.shlishiERV.Text = "ערב";
            this.shlishiERV.UseVisualStyleBackColor = true;
            // 
            // shlishiTZ
            // 
            this.shlishiTZ.AutoSize = true;
            this.shlishiTZ.Location = new System.Drawing.Point(281, 98);
            this.shlishiTZ.Name = "shlishiTZ";
            this.shlishiTZ.Size = new System.Drawing.Size(69, 21);
            this.shlishiTZ.TabIndex = 15;
            this.shlishiTZ.Text = "צהריים";
            this.shlishiTZ.UseVisualStyleBackColor = true;
            // 
            // shishiERV
            // 
            this.shishiERV.AutoSize = true;
            this.shishiERV.Location = new System.Drawing.Point(3, 135);
            this.shishiERV.Name = "shishiERV";
            this.shishiERV.Size = new System.Drawing.Size(53, 21);
            this.shishiERV.TabIndex = 16;
            this.shishiERV.Text = "ערב";
            this.shishiERV.UseVisualStyleBackColor = true;
            // 
            // hamishiERV
            // 
            this.hamishiERV.AutoSize = true;
            this.hamishiERV.Location = new System.Drawing.Point(98, 135);
            this.hamishiERV.Name = "hamishiERV";
            this.hamishiERV.Size = new System.Drawing.Size(53, 21);
            this.hamishiERV.TabIndex = 17;
            this.hamishiERV.Text = "ערב";
            this.hamishiERV.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.Location = new System.Drawing.Point(470, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "ראשון";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "שישי";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 47);
            this.button4.TabIndex = 20;
            this.button4.Text = "חמישי";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(188, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 47);
            this.button5.TabIndex = 21;
            this.button5.Text = "רביעי";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(281, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 47);
            this.button6.TabIndex = 22;
            this.button6.Text = "שלישי";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(376, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 47);
            this.button7.TabIndex = 23;
            this.button7.Text = "שני";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // CashierWorkSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Name = "CashierWorkSchedule";
            this.Text = "CashierWorkSchedule";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox reveyERV;
        private System.Windows.Forms.CheckBox rishonB;
        private System.Windows.Forms.CheckBox sheniB;
        private System.Windows.Forms.CheckBox shlishiB;
        private System.Windows.Forms.CheckBox reveyB;
        private System.Windows.Forms.CheckBox hamishiB;
        private System.Windows.Forms.CheckBox shishiB;
        private System.Windows.Forms.CheckBox rishonTZ;
        private System.Windows.Forms.CheckBox rishonERV;
        private System.Windows.Forms.CheckBox sheniTZ;
        private System.Windows.Forms.CheckBox sheniERV;
        private System.Windows.Forms.CheckBox shlishiTZ;
        private System.Windows.Forms.CheckBox shlishiERV;
        private System.Windows.Forms.CheckBox reveyTZ;
        private System.Windows.Forms.CheckBox hamishiTZ;
        private System.Windows.Forms.CheckBox shishiTZ;
        private System.Windows.Forms.CheckBox hamishiERV;
        private System.Windows.Forms.CheckBox shishiERV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}