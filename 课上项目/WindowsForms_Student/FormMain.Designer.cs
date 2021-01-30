namespace WindowsForms_Student
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemReLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.档案管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师分课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.成绩录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.权限设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.档案管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItemReLogin,
            this.toolStripSeparator1,
            this.MenuItem2});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // StripMenuItemReLogin
            // 
            this.StripMenuItemReLogin.Name = "StripMenuItemReLogin";
            this.StripMenuItemReLogin.Size = new System.Drawing.Size(152, 26);
            this.StripMenuItemReLogin.Text = "重新登陆";
            this.StripMenuItemReLogin.Click += new System.EventHandler(this.StripMenuItemReLogin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(152, 26);
            this.MenuItem2.Text = "安全退出";
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem1_Click2);
            // 
            // 档案管理ToolStripMenuItem
            // 
            this.档案管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem3,
            this.toolStripSeparator2,
            this.MenuItem4,
            this.toolStripSeparator6,
            this.TreeToolStripMenuItem});
            this.档案管理ToolStripMenuItem.Name = "档案管理ToolStripMenuItem";
            this.档案管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.档案管理ToolStripMenuItem.Text = "档案管理";
            // 
            // MenuItem3
            // 
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(152, 26);
            this.MenuItem3.Text = "教工档案";
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItem4
            // 
            this.MenuItem4.Name = "MenuItem4";
            this.MenuItem4.Size = new System.Drawing.Size(152, 26);
            this.MenuItem4.Text = "学生档案";
            this.MenuItem4.Click += new System.EventHandler(this.MenuItem_Click4);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // TreeToolStripMenuItem
            // 
            this.TreeToolStripMenuItem.Name = "TreeToolStripMenuItem";
            this.TreeToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.TreeToolStripMenuItem.Text = "树结构";
            this.TreeToolStripMenuItem.Click += new System.EventHandler(this.树结构ToolStripMenuItem_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            this.课程管理ToolStripMenuItem.Click += new System.EventHandler(this.课程管理ToolStripMenuItem_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生选课ToolStripMenuItem,
            this.教师分课ToolStripMenuItem,
            this.toolStripSeparator3,
            this.成绩录入ToolStripMenuItem,
            this.toolStripSeparator4,
            this.成绩查询ToolStripMenuItem,
            this.统计分析ToolStripMenuItem});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // 学生选课ToolStripMenuItem
            // 
            this.学生选课ToolStripMenuItem.Name = "学生选课ToolStripMenuItem";
            this.学生选课ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.学生选课ToolStripMenuItem.Text = "学生选课";
            this.学生选课ToolStripMenuItem.Click += new System.EventHandler(this.学生选课ToolStripMenuItem_Click);
            // 
            // 教师分课ToolStripMenuItem
            // 
            this.教师分课ToolStripMenuItem.Name = "教师分课ToolStripMenuItem";
            this.教师分课ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.教师分课ToolStripMenuItem.Text = "教师分课";
            this.教师分课ToolStripMenuItem.Click += new System.EventHandler(this.教师分课ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // 成绩录入ToolStripMenuItem
            // 
            this.成绩录入ToolStripMenuItem.Name = "成绩录入ToolStripMenuItem";
            this.成绩录入ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.成绩录入ToolStripMenuItem.Text = "成绩录入";
            this.成绩录入ToolStripMenuItem.Click += new System.EventHandler(this.成绩录入ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            this.成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.成绩查询ToolStripMenuItem_Click);
            // 
            // 统计分析ToolStripMenuItem
            // 
            this.统计分析ToolStripMenuItem.Name = "统计分析ToolStripMenuItem";
            this.统计分析ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.统计分析ToolStripMenuItem.Text = "统计分析";
            this.统计分析ToolStripMenuItem.Click += new System.EventHandler(this.统计分析ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户信息ToolStripMenuItem,
            this.toolStripSeparator5,
            this.权限设置ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.用户信息ToolStripMenuItem.Text = "用户信息";
            this.用户信息ToolStripMenuItem.Click += new System.EventHandler(this.用户信息ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // 权限设置ToolStripMenuItem
            // 
            this.权限设置ToolStripMenuItem.Name = "权限设置ToolStripMenuItem";
            this.权限设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.权限设置ToolStripMenuItem.Text = "权限设置";
            this.权限设置ToolStripMenuItem.Click += new System.EventHandler(this.权限设置ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "学生成绩管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 档案管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师分课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemReLogin;
        private System.Windows.Forms.ToolStripMenuItem MenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
    }
}

