namespace WindowsForms_Student
{
    partial class FormTree
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MenuStripStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddBrother = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddChild = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.MenuStripStudent;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(540, 571);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // MenuStripStudent
            // 
            this.MenuStripStudent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.toolStripSeparator1,
            this.MenuItemDel,
            this.toolStripSeparator2,
            this.MenuItemModify});
            this.MenuStripStudent.Name = "MenuStripStudent";
            this.MenuStripStudent.Size = new System.Drawing.Size(211, 116);
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddBrother,
            this.MenuItemAddChild});
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(210, 24);
            this.MenuItemAdd.Text = "新增";
            // 
            // MenuItemAddBrother
            // 
            this.MenuItemAddBrother.Name = "MenuItemAddBrother";
            this.MenuItemAddBrother.Size = new System.Drawing.Size(224, 26);
            this.MenuItemAddBrother.Text = "兄弟结点";
            this.MenuItemAddBrother.Click += new System.EventHandler(this.MenuItemAddBrother_Click);
            // 
            // MenuItemAddChild
            // 
            this.MenuItemAddChild.Name = "MenuItemAddChild";
            this.MenuItemAddChild.Size = new System.Drawing.Size(152, 26);
            this.MenuItemAddChild.Text = "子节点";
            this.MenuItemAddChild.Click += new System.EventHandler(this.MenuItemAddChild_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // MenuItemDel
            // 
            this.MenuItemDel.Name = "MenuItemDel";
            this.MenuItemDel.Size = new System.Drawing.Size(210, 24);
            this.MenuItemDel.Text = "删除";
            this.MenuItemDel.Click += new System.EventHandler(this.MenuItemDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // MenuItemModify
            // 
            this.MenuItemModify.Name = "MenuItemModify";
            this.MenuItemModify.Size = new System.Drawing.Size(210, 24);
            this.MenuItemModify.Text = "修改";
            this.MenuItemModify.Click += new System.EventHandler(this.MenuItemModify_Click);
            // 
            // FormTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 571);
            this.Controls.Add(this.treeView1);
            this.Name = "FormTree";
            this.Text = "树结构";
            this.Load += new System.EventHandler(this.FormTree_Load);
            this.MenuStripStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip MenuStripStudent;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemModify;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddBrother;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddChild;
    }
}