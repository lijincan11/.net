namespace WindowsForms_Student
{
    partial class FormS_C
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewS_C = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUnSel = new System.Windows.Forms.Button();
            this.buttonSelCourse = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewS_C)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ViewS_C);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 563);
            this.panel1.TabIndex = 0;
            // 
            // ViewS_C
            // 
            this.ViewS_C.AllowUserToAddRows = false;
            this.ViewS_C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewS_C.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.SName,
            this.SSex,
            this.DNo,
            this.SAge,
            this.SBirthday,
            this.DName});
            this.ViewS_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewS_C.Location = new System.Drawing.Point(0, 67);
            this.ViewS_C.MultiSelect = false;
            this.ViewS_C.Name = "ViewS_C";
            this.ViewS_C.ReadOnly = true;
            this.ViewS_C.RowHeadersWidth = 51;
            this.ViewS_C.RowTemplate.Height = 27;
            this.ViewS_C.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewS_C.Size = new System.Drawing.Size(577, 492);
            this.ViewS_C.TabIndex = 1;
            this.ViewS_C.SelectionChanged += new System.EventHandler(this.ViewS_C_SelectionChanged);
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "学号";
            this.SNo.MinimumWidth = 6;
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 80;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "姓名";
            this.SName.MinimumWidth = 6;
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 80;
            // 
            // SSex
            // 
            this.SSex.DataPropertyName = "SSex";
            this.SSex.HeaderText = "性别";
            this.SSex.MinimumWidth = 6;
            this.SSex.Name = "SSex";
            this.SSex.ReadOnly = true;
            this.SSex.Width = 50;
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
            // SAge
            // 
            this.SAge.DataPropertyName = "SAge";
            this.SAge.HeaderText = "年龄";
            this.SAge.MinimumWidth = 6;
            this.SAge.Name = "SAge";
            this.SAge.ReadOnly = true;
            this.SAge.Width = 50;
            // 
            // SBirthday
            // 
            this.SBirthday.DataPropertyName = "SBirthday";
            this.SBirthday.HeaderText = "出生日期";
            this.SBirthday.MinimumWidth = 6;
            this.SBirthday.Name = "SBirthday";
            this.SBirthday.ReadOnly = true;
            this.SBirthday.Width = 125;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSelect);
            this.panel2.Controls.Add(this.textBoxSName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxSNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 67);
            this.panel2.TabIndex = 0;
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
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(244, 18);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(94, 25);
            this.textBoxSName.TabIndex = 1;
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
            // textBoxSNo
            // 
            this.textBoxSNo.Location = new System.Drawing.Point(67, 15);
            this.textBoxSNo.Name = "textBoxSNo";
            this.textBoxSNo.Size = new System.Drawing.Size(93, 25);
            this.textBoxSNo.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(581, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(433, 140);
            this.dataGridView1.TabIndex = 2;
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
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "课程名称";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 125;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUnSel);
            this.groupBox2.Controls.Add(this.buttonSelCourse);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(581, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
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
            this.buttonSelCourse.Text = "选    课";
            this.buttonSelCourse.UseVisualStyleBackColor = true;
            this.buttonSelCourse.Click += new System.EventHandler(this.buttonSelCourse_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(581, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 310);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "可选课程";
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
            this.dataGridView2.Size = new System.Drawing.Size(433, 286);
            this.dataGridView2.TabIndex = 3;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CName";
            this.dataGridViewTextBoxColumn2.HeaderText = "课程名称";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
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
            // FormS_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormS_C";
            this.Text = "学生选课";
            this.Load += new System.EventHandler(this.FormS_C_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewS_C)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSNo;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.DataGridView ViewS_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSelCourse;
        private System.Windows.Forms.Button buttonUnSel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}