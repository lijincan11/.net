using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Student
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void MenuItem_Click4(object sender, EventArgs e)
        {
            //实例化
            FormStudent formStudent = new FormStudent();
            formStudent.MdiParent = this;//设置父窗体
            formStudent.Show();//显示窗体
        }

        private void MenuItem1_Click2(object sender, EventArgs e)
        {
            this.Close();//关闭窗体

        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            //实例化
            FormTeacher formTeacher = new FormTeacher();
            formTeacher.MdiParent = this;//设置父窗体
            formTeacher.Show();//显示窗体
        }

        private void 树结构ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化
            FormTree formTree = new FormTree();
            formTree.MdiParent = this;//设置父窗体
            formTree.Show();//显示窗体
        }

        private void 学生选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化
            FormS_C formS_C = new FormS_C();
            formS_C.MdiParent = this;//设置父窗体
            formS_C.Show();//显示窗体
        }

        private void 教师分课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化
            FormT_C formT_C = new FormT_C();
            formT_C.MdiParent = this;//设置父窗体
            formT_C.Show();//显示窗体
        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化
            FormCourse formCourse = new FormCourse();
            formCourse.MdiParent = this;//设置父窗体
            formCourse.Show();//显示窗体
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化
            FormS_CScore formS_CScore = new FormS_CScore();
            formS_CScore.MdiParent = this;//设置父窗体
            formS_CScore.Show();//显示窗体
        }


        /// <summary>
        /// 重新登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StripMenuItemReLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            //关闭所有子窗体
            foreach (Form item in this.MdiChildren)
            {
                try
                {
                    item.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            FormLogin login = new FormLogin();
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                this.Close();
            }




           
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化
            FormUser formUser = new FormUser();
            formUser.MdiParent = this;//设置父窗体
            formUser.Show();//显示窗体
        }

        private void 权限设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化
            FormRole formRole = new FormRole();
            formRole.MdiParent = this;//设置父窗体
            formRole.Show();//显示窗体
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化
            FormCourseSelect formCourseSelect = new FormCourseSelect();
            formCourseSelect.MdiParent = this;//设置父窗体
            formCourseSelect.Show();//显示窗体
        }

        private void 统计分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化
            FormScoreAnalysis formScoreAnalysis = new FormScoreAnalysis();
            formScoreAnalysis.MdiParent = this;//设置父窗体
            formScoreAnalysis.Show();//显示窗体
        }
    }
}
