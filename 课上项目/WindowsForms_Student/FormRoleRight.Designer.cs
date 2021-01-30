namespace WindowsForms_Student
{
    partial class FormRoleRight
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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("节点6");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Indent = 5;
            this.treeView1.ItemHeight = 25;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "节点0";
            treeNode15.Text = "节点0";
            treeNode16.Name = "节点1";
            treeNode16.Text = "节点1";
            treeNode17.Name = "节点2";
            treeNode17.Text = "节点2";
            treeNode18.Name = "节点3";
            treeNode18.Text = "节点3";
            treeNode19.Name = "节点4";
            treeNode19.Text = "节点4";
            treeNode20.Name = "节点5";
            treeNode20.Text = "节点5";
            treeNode21.Name = "节点6";
            treeNode21.Text = "节点6";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(317, 366);
            this.treeView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 61);
            this.panel1.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(200, 15);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 36);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "取    消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(31, 15);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(86, 36);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "提    交";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormRoleRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 427);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormRoleRight";
            this.Text = "角色权限设置";
            this.Load += new System.EventHandler(this.FormRoleRight_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}