using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_Student.BLL;

namespace WindowsForms_Student
{
    public partial class FormT_C : Form
    {
        public FormT_C()
        {
            InitializeComponent();
        }
        private bool rightQuery, rightAdd, rightDel;//保存权限

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            WindowsForms_Student.BLL.Core core = new BLL.Core();

            //获取参数
            string tNo = this.textBoxTNo.Text.Trim();
            string tName = this.textBoxTName.Text.Trim();

            this.ViewT_C.DataSource = core.GetListTeacher(tNo, tName).Tables[0].DefaultView;
        }
        private void ViewT_C_SelectionChanged(object sender, EventArgs e)
        {
            if (this.ViewT_C.SelectedRows.Count > 0)
            {
                //获取被选择的记录的SNo
                string tNo = this.ViewT_C.SelectedRows[0].Cells["TNo"].Value.ToString();

                //实例化BLL并调用方法getListSc()和getListSCNot()
                BLL.Core bll = new BLL.Core();
                //已选课程
                this.dataGridView1.DataSource = bll.GetListT_C(tNo).Tables[0].DefaultView;
                //可选课程
                this.dataGridView2.DataSource = bll.GetListT_CNot(tNo).Tables[0].DefaultView;

                //刷新按钮的可用性
                this.buttonSelCourse.Enabled = this.dataGridView2.SelectedRows.Count > 0;
                this.buttonUnSel.Enabled = this.dataGridView1.SelectedRows.Count > 0;
            }
            else
            {

            }
        }

        private void FormT_C_Load(object sender, EventArgs e)
        {
            rightAdd = BLL.Core.IsHaveRight("f17");
            rightDel = BLL.Core.IsHaveRight("f18");

            rightQuery = BLL.Core.IsHaveRight("f16");

            this.buttonSelCourse.Visible = rightAdd;
            this.buttonSelect.Visible = rightQuery;
            this.buttonUnSel.Visible = rightDel;
        }

        private void buttonSelCourse_Click(object sender, EventArgs e)
        {
            //获取学号和未选课程的课程编号
            string tNo = this.ViewT_C.SelectedRows[0].Cells["TNo"].Value.ToString();
            String CNo = this.dataGridView2.SelectedRows[0].Cells["CNo2"].Value.ToString();

            //实例化Model并给给个属性赋值
            Model.Teacher_Course model = new Model.Teacher_Course();
            model.TNo = tNo;
            model.CNo = CNo;
            //实例化BLL并调用方法
            BLL.Teacher_Course bll = new BLL.Teacher_Course();
            try
            {
                bll.Add(model);
                this.ViewT_C_SelectionChanged(this.ViewT_C, e);//刷新显示


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "选课失败!\n" + ex.Message,
                    "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void buttonUnSel_Click(object sender, EventArgs e)
        {
            //获取学号和未选课程的课程编号
            string tNo = this.ViewT_C.SelectedRows[0].Cells["TNo"].Value.ToString();
            String CNo = this.dataGridView1.SelectedRows[0].Cells["CNo"].Value.ToString();


            //实例化BLL并调用方法
            BLL.Teacher_Course bll = new BLL.Teacher_Course();
            try
            {
                bll.Delete(tNo, CNo);
                this.ViewT_C_SelectionChanged(this.ViewT_C, e);//刷新显示


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "退课失败!\n" + ex.Message,
                    "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

       
    }
}
