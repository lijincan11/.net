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
    public partial class FormS_C : Form
    {
        public FormS_C()
        {
            InitializeComponent();
        }

        private bool rightQuery, rightAdd, rightDel;//保存权限

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            WindowsForms_Student.BLL.Core core = new BLL.Core();

            //获取参数
            string sNo = this.textBoxSNo.Text.Trim();
            string sName = this.textBoxSName.Text.Trim();

            this.ViewS_C.DataSource = core.GetListStudent(sNo, sName).Tables[0].DefaultView;
        }

        private void ViewS_C_SelectionChanged(object sender, EventArgs e)
        {
            if (this.ViewS_C.SelectedRows.Count > 0)
            {
                //获取被选择的记录的SNo
                string sNo = this.ViewS_C.SelectedRows[0].Cells["SNo"].Value.ToString();

                //实例化BLL并调用方法getListSc()和getListSCNot()
                BLL.Core bll = new BLL.Core();
                //已选课程
                this.dataGridView1.DataSource = bll.GetListS_C(sNo).Tables[0].DefaultView;
                //可选课程
                this.dataGridView2.DataSource = bll.GetListS_CNot(sNo).Tables[0].DefaultView;

                //刷新按钮的可用性
                this.buttonSelCourse.Enabled = this.dataGridView2.SelectedRows.Count > 0;
                this.buttonUnSel.Enabled = this.dataGridView1.SelectedRows.Count > 0;
            }
            else
            {
                
            }
        }

        private void FormS_C_Load(object sender, EventArgs e)
        {
            rightAdd = BLL.Core.IsHaveRight("f14");
            rightDel = BLL.Core.IsHaveRight("f15");
           
            rightQuery = BLL.Core.IsHaveRight("f13");

            this.buttonSelCourse.Visible = rightAdd;
            this.buttonSelect.Visible = rightQuery;
            this.buttonUnSel.Visible = rightDel;
        }

        private void buttonSelCourse_Click(object sender, EventArgs e)
        {
            //获取学号和未选课程的课程编号
            string sNo = this.ViewS_C.SelectedRows[0].Cells["SNo"].Value.ToString();
            String CNo = this.dataGridView2.SelectedRows[0].Cells["CNo2"].Value.ToString();

            //实例化Model并给给个属性赋值
            Model.Student_Course model = new Model.Student_Course();
            model.SNo = sNo;
            model.CNo = CNo;
            //实例化BLL并调用方法
            BLL.Student_Course bll = new BLL.Student_Course();
            try
            {
                bll.Add(model);
                this.ViewS_C_SelectionChanged(this.ViewS_C, e);//刷新显示


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
            string sNo = this.ViewS_C.SelectedRows[0].Cells["SNo"].Value.ToString();
            String CNo = this.dataGridView1.SelectedRows[0].Cells["CNo"].Value.ToString();

           
            //实例化BLL并调用方法
            BLL.Student_Course bll = new BLL.Student_Course();
            try
            {
                bll.Delete(sNo,CNo);
                this.ViewS_C_SelectionChanged(this.ViewS_C, e);//刷新显示


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
