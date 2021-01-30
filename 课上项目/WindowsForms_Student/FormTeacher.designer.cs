namespace WindowsForms_Student
{
    partial class FormTeacher
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStripTeacher = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuStripTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Button1);
            this.panel2.Controls.Add(this.textBoxSName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxSNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 82);
            this.panel2.TabIndex = 1;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(491, 22);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBoxSName.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBoxSNo.Margin = new System.Windows.Forms.Padding(2);
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
            this.label1.Text = "工号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TNo,
            this.TName,
            this.TSex,
            this.TAge,
            this.TDept});
            this.dataGridView1.ContextMenuStrip = this.MenuStripTeacher;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 278);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // TNo
            // 
            this.TNo.DataPropertyName = "TNo";
            this.TNo.HeaderText = "工号";
            this.TNo.MinimumWidth = 6;
            this.TNo.Name = "TNo";
            this.TNo.ReadOnly = true;
            this.TNo.Width = 125;
            // 
            // TName
            // 
            this.TName.DataPropertyName = "TName";
            this.TName.HeaderText = "姓名";
            this.TName.MinimumWidth = 6;
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Width = 125;
            // 
            // TSex
            // 
            this.TSex.DataPropertyName = "TSex";
            this.TSex.HeaderText = "性别";
            this.TSex.MinimumWidth = 6;
            this.TSex.Name = "TSex";
            this.TSex.ReadOnly = true;
            this.TSex.Width = 125;
            // 
            // TAge
            // 
            this.TAge.DataPropertyName = "TAge";
            this.TAge.HeaderText = "年龄";
            this.TAge.MinimumWidth = 6;
            this.TAge.Name = "TAge";
            this.TAge.ReadOnly = true;
            this.TAge.Width = 125;
            // 
            // TDept
            // 
            this.TDept.DataPropertyName = "DName";
            this.TDept.HeaderText = "院系";
            this.TDept.MinimumWidth = 6;
            this.TDept.Name = "TDept";
            this.TDept.ReadOnly = true;
            this.TDept.Width = 125;
            // 
            // MenuStripTeacher
            // 
            this.MenuStripTeacher.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripTeacher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemDel,
            this.MenuItemModify});
            this.MenuStripTeacher.Name = "contextMenuStrip1";
            this.MenuStripTeacher.Size = new System.Drawing.Size(181, 92);
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(180, 22);
            this.MenuItemAdd.Text = "新增";
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
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTeacher";
            this.Text = "教工档案";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuStripTeacher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip MenuStripTeacher;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDept;
    }
}