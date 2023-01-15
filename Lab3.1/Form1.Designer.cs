namespace Lab3._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TALL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAJOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clear = new System.Windows.Forms.Button();
            this.AllStudents = new System.Windows.Forms.TextBox();
            this.MinGrade = new System.Windows.Forms.TextBox();
            this.TopGrade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(330, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(330, 212);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(330, 261);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(248, 27);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(330, 307);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(248, 27);
            this.textBox6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ฟอร์มข้อมูลนักศึกษา";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ชื่อ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "รหัสนักศึกษา :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ปีเกิด :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ส่วนสูง :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "เกรด :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "สาขา :";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(639, 152);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(94, 80);
            this.submit.TabIndex = 13;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.ID,
            this.YEAR,
            this.TALL,
            this.GRADE,
            this.MAJOR});
            this.table.Location = new System.Drawing.Point(32, 383);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 29;
            this.table.Size = new System.Drawing.Size(800, 188);
            this.table.TabIndex = 14;
            // 
            // name
            // 
            this.name.HeaderText = "ชื่อ";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "รหัสนักศึกษา";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // YEAR
            // 
            this.YEAR.HeaderText = "ปีเกิด";
            this.YEAR.MinimumWidth = 6;
            this.YEAR.Name = "YEAR";
            this.YEAR.ReadOnly = true;
            this.YEAR.Width = 125;
            // 
            // TALL
            // 
            this.TALL.HeaderText = "ส่วนสูง";
            this.TALL.MinimumWidth = 6;
            this.TALL.Name = "TALL";
            this.TALL.ReadOnly = true;
            this.TALL.Width = 125;
            // 
            // GRADE
            // 
            this.GRADE.HeaderText = "เกรด";
            this.GRADE.MinimumWidth = 6;
            this.GRADE.Name = "GRADE";
            this.GRADE.ReadOnly = true;
            this.GRADE.Width = 125;
            // 
            // MAJOR
            // 
            this.MAJOR.HeaderText = "สาขา";
            this.MAJOR.MinimumWidth = 6;
            this.MAJOR.Name = "MAJOR";
            this.MAJOR.ReadOnly = true;
            this.MAJOR.Width = 125;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(639, 238);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(94, 36);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // AllStudents
            // 
            this.AllStudents.Location = new System.Drawing.Point(614, 78);
            this.AllStudents.Name = "AllStudents";
            this.AllStudents.ReadOnly = true;
            this.AllStudents.Size = new System.Drawing.Size(248, 27);
            this.AllStudents.TabIndex = 18;
            // 
            // MinGrade
            // 
            this.MinGrade.Location = new System.Drawing.Point(614, 45);
            this.MinGrade.Name = "MinGrade";
            this.MinGrade.ReadOnly = true;
            this.MinGrade.Size = new System.Drawing.Size(248, 27);
            this.MinGrade.TabIndex = 17;
            // 
            // TopGrade
            // 
            this.TopGrade.Location = new System.Drawing.Point(614, 12);
            this.TopGrade.Name = "TopGrade";
            this.TopGrade.ReadOnly = true;
            this.TopGrade.Size = new System.Drawing.Size(248, 27);
            this.TopGrade.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 583);
            this.Controls.Add(this.AllStudents);
            this.Controls.Add(this.MinGrade);
            this.Controls.Add(this.TopGrade);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.table);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button submit;
        private DataGridView table;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn YEAR;
        private DataGridViewTextBoxColumn TALL;
        private DataGridViewTextBoxColumn GRADE;
        private DataGridViewTextBoxColumn MAJOR;
        private Button Clear;
        private TextBox AllStudents;
        private TextBox MinGrade;
        private TextBox TopGrade;
    }
}