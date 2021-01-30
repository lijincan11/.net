namespace WindowsForms_Student
{
    partial class FormT_C
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
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUnSel = new System.Windows.Forms.Button();
            this.buttonSelCourse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxTName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTNo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewT_C = new System.Windows.Forms.DataGridView();
            this.TNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewT_C)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CScore";
            this.dataGridViewTextBoxColumn3.HeaderText = "学分";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // CNo2
            // 
            this.CNo2.DataPropertyName = "CNo";
            this.CNo2.HeaderText = "课程编号";
            this.CNo2.MinimumWidth = 6;
            this.CNo2.Name = "CNo2";
            this.CNo2.ReadOnly = true;
            this.CNo2.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNo2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(506, 306);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CName";
            this.dataGridViewTextBoxColumn2.HeaderText = "课程名称";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(581, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 330);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "可选课程";
            // 
            // buttonUnSel
            // 
            this.buttonUnSel.Enabled = false;
            this.buttonUnSel.Location = new System.Drawing.Point(266, 24);
            this.buttonUnSel.Name = "buttonUnSel";
            this.buttonUnSel.Size = new System.Drawing.Size(100, 48);
            this.buttonUnSel.TabIndex = 1;
            this.buttonUnSel.Text = "退    选";
            this.buttonUnSel.UseVisualStyleBackColor = true;
            this.buttonUnSel.Click += new System.EventHandler(this.buttonUnSel_Click);
            // 
            // buttonSelCourse
            // 
            this.buttonSelCourse.Enabled = false;
            this.buttonSelCourse.Location = new System.Drawing.Point(34, 24);
            this.buttonSelCourse.Name = "buttonSelCourse";
            this.buttonSelCourse.Size = new System.Drawing.Size(100, 48);
            this.buttonSelCourse.TabIndex = 0;
            this.buttonSelCourse.Text = "分    课";
            this.buttonSelCourse.UseVisualStyleBackColor = true;
            this.buttonSelCourse.Click += new System.EventHandler(this.buttonSelCourse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUnSel);
            this.groupBox2.Controls.Add(this.buttonSelCourse);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(581, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // CScore
            // 
            this.CScore.DataPropertyName = "CScore";
            this.CScore.HeaderText = "学分";
            this.CScore.MinimumWidth = 6;
            this.CScore.Name = "CScore";
            this.CScore.ReadOnly = true;
            this.CScore.Width = 125;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "课程名称";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 125;
            // 
            // CNo
            // 
            this.CNo.DataPropertyName = "CNo";
            this.CNo.HeaderText = "课程编号";
            this.CNo.MinimumWidth = 6;
            this.CNo.Name = "CNo";
            this.CNo.ReadOnly = true;
            this.CNo.Width = 125;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(414, 15);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(122, 40);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "查    询";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxTName
            // 
            this.textBoxTName.Location = new System.Drawing.Point(244, 18);
            this.textBoxTName.Name = "textBoxTName";
            this.textBoxTName.Size = new System.Drawing.Size(94, 25);
            this.textBoxTName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNo,
            this.CName,
            this.CScore});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(506, 140);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(581, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // textBoxTNo
            // 
            this.textBoxTNo.Location = new System.Drawing.Point(67, 15);
            this.textBoxTNo.Name = "textBoxTNo";
            this.textBoxTNo.Size = new System.Drawing.Size(93, 25);
            this.textBoxTNo.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSelect);
            this.panel2.Controls.Add(this.textBoxTName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxTNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 67);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // ViewT_C
            // 
            this.ViewT_C.AllowUserToAddRows = false;
            this.ViewT_C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewT_C.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TNo,
            this.TName,
            this.TSex,
            this.DNo,
            this.TAge,
            this.DName});
            this.ViewT_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewT_C.Location = new System.Drawing.Point(0, 67);
            this.ViewT_C.MultiSelect = false;
            this.ViewT_C.Name = "ViewT_C";
            this.ViewT_C.ReadOnly = true;
            this.ViewT_C.RowHeadersWidth = 51;
            this.ViewT_C.RowTemplate.Height = 27;
            this.ViewT_C.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewT_C.Size = new System.Drawing.Size(577, 512);
            this.ViewT_C.TabIndex = 1;
            this.ViewT_C.SelectionChanged += new System.EventHandler(this.ViewT_C_SelectionChanged);
            // 
            // TNo
            // 
            this.TNo.DataPropertyName = "TNo";
            this.TNo.HeaderText = "工号";
            this.TNo.MinimumWidth = 6;
            this.TNo.Name = "TNo";
            this.TNo.ReadOnly = true;
            this.TNo.Width = 80;
            // 
            // TName
            // 
            this.TName.DataPropertyName = "TName";
            this.TName.HeaderText = "姓名";
            this.TName.MinimumWidth = 6;
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Width = 80;
            // 
            // TSex
            // 
            this.TSex.DataPropertyName = "TSex";
            this.TSex.HeaderText = "性别";
            this.TSex.MinimumWidth = 6;
            this.TSex.Name = "TSex";
            this.TSex.ReadOnly = true;
            this.TSex.Width = 50;
            // 
            // DNo
            // 
            this.DNo.DataPropertyName = "DNo";
            this.DNo.HeaderText = "院系编号";
            this.DNo.MinimumWidth = 6;
            this.DNo.Name = "DNo";
            this.DNo.ReadOnly = true;
            this.DNo.Visible = false;
            this.DNo.Width = 125;
            // 
            // TAge
            // 
            this.TAge.DataPropertyName = "TAge";
            this.TAge.HeaderText = "年龄";
            this.TAge.MinimumWidth = 6;
            this.TAge.Name = "TAge";
            this.TAge.ReadOnly = true;
            this.TAge.Width = 50;
            // 
            // DName
            // 
            this.DName.DataPropertyName = "DName";
            this.DName.HeaderText = "院系名称";
            this.DName.MinimumWidth = 6;
            this.DName.Name = "DName";
            this.DName.ReadOnly = true;
            this.DName.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ViewT_C);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 583);
            this.panel1.TabIndex = 4;
            // 
            // FormT_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 583);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormT_C";
            this.Text = "FormT_C";
            this.Load += new System.EventHandler(this.FormT_C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewT_C)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNo2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonUnSel;
        private System.Windows.Forms.Button buttonSelCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNo;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxTName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ViewT_C;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
    }
}