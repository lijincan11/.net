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
    public partial class FormCourseSelect : Form
    {
        public FormCourseSelect()
        {
            InitializeComponent();
        }

        private void FormCourseSelect_Load(object sender, EventArgs e)
        {
            try
            {
                BLL.Core bll = new BLL.Core();
                this.dataGridView1.DataSource = bll.GetListStudentScore("", "").Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错了", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            //获取学生姓名
            string sname = textSName.Text.Trim();
            //获取被选中的课程名称
            string cname = textBoxCName.Text.Trim();

            //实例化bll调用GetListSCScore方法获取学生选课信息
            BLL.Core bll = new BLL.Core();
            this.dataGridView1.DataSource = bll.GetListStudentScore(cname, sname).Tables[0].DefaultView;
        }
    }
}
