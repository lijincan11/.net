namespace WindowsForms_Student
{
    partial class FormStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DN0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStripStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuStripStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Controls.Add(this.textBoxSName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 82);
            this.panel1.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(491, 22);
            this.Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(77, 21);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "查询";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.ButtonQuery_Click);
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(286, 22);
            this.textBoxSName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(110, 21);
            this.textBoxSName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            // 
            // textBoxSNo
            // 
            this.textBoxSNo.Location = new System.Drawing.Point(76, 20);
            this.textBoxSNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSNo.Name = "textBoxSNo";
            this.textBoxSNo.Size = new System.Drawing.Size(110, 21);
            this.textBoxSNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 278);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.SName,
            this.SSex,
            this.SAge,
            this.DN0,
            this.SBirthday});
            this.dataGridView1.ContextMenuStrip = this.MenuStripStudent;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "学号";
            this.SNo.MinimumWidth = 6;
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 125;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "姓名";
            this.SName.MinimumWidth = 6;
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 125;
            // 
            // SSex
            // 
            this.SSex.DataPropertyName = "SSex";
            this.SSex.HeaderText = "性别";
            this.SSex.MinimumWidth = 6;
            this.SSex.Name = "SSex";
            this.SSex.ReadOnly = true;
            this.SSex.Width = 125;
            // 
            // SAge
            // 
            this.SAge.DataPropertyName = "SAge";
            this.SAge.HeaderText = "年龄";
            this.SAge.MinimumWidth = 6;
            this.SAge.Name = "SAge";
            this.SAge.ReadOnly = true;
            this.SAge.Width = 125;
            // 
            // DN0
            // 
            this.DN0.DataPropertyName = "DName";
            this.DN0.HeaderText = "院系";
            this.DN0.MinimumWidth = 6;
            this.DN0.Name = "DN0";
            this.DN0.ReadOnly = true;
            this.DN0.Width = 125;
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
            // MenuStripStudent
            // 
            this.MenuStripStudent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemDel,
            this.MenuItemModify});
            this.MenuStripStudent.Name = "MenuStripStudent";
            this.MenuStripStudent.Size = new System.Drawing.Size(101, 70);
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(180, 22);
            this.MenuItemAdd.Text = "新增";
            this.MenuItemAdd.Visible = false;
            this.MenuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemDel
            // 
            this.MenuItemDel.Name = "MenuItemDel";
            this.MenuItemDel.Size = new System.Drawing.Size(180, 22);
            this.MenuItemDel.Text = "删除";
            this.MenuItemDel.Visible = false;
            this.MenuItemDel.Click += new System.EventHandler(this.MenuItemDel_Click);
            // 
            // MenuItemModify
            // 
            this.MenuItemModify.Name = "MenuItemModify";
            this.MenuItemModify.Size = new System.Drawing.Size(180, 22);
            this.MenuItemModify.Text = "修改";
            this.MenuItemModify.Visible = false;
            this.MenuItemModify.Click += new System.EventHandler(this.MenuItemModify_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStudent";
            this.Text = "学生档案";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuStripStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip MenuStripStudent;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DN0;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBirthday;
    }
}