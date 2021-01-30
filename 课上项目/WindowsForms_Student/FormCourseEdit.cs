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
    public partial class FormCourseEdit : Form
    {
        private int _editflag;//0 新增 ；1 修改；2 详细信息
        private string _cNo;//学号

        public string CNO //属性
        {
            get { return _cNo; }
            set { _cNo = value; }
        }

        //重新定义构造函数
        public FormCourseEdit(int edit_flag)
        {
            _editflag = edit_flag;//获取参数
            InitializeComponent();
        }


        //重新定义构造函数
        public FormCourseEdit(int edit_flag, string cNo)
        {
            _editflag = edit_flag;//获取参数
            _cNo = cNo;//获取学号
            InitializeComponent();
        }

        private void FormCourseEdit_Load(object sender, EventArgs e)
        {
            
            //更新窗体标题
            switch (_editflag)
            {
                case 0:
                    this.Text = "新增课程信息"; break;
                case 1:
                    this.Text = "修改课程信息";

                    this.textBoxCNo.ReadOnly = true;
                    //根据学号查询信息并展示
                    WindowsForms_Student.Model.Course model = new BLL.Course().GetModel(_cNo);
                    this.textBoxCNo.Text = model.CNo;//显示课程号
                    this.textBoxCName.Text = model.CName;//显示课程名
                    this.textBoxCScore.Text =model.CScore;//显示学分

                    break;
                case 2:
                    this.Text = "学生档案详细信息"; break;
            }



        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string strError = "";
            if (this.textBoxCNo.Text.Trim() == "")
                strError += "课程号不能为空！\n";
            if (this.textBoxCName.Text.Trim() == "")
                strError += "课程名不能为空！\n";

            float cScore = 0;


            try
            {
                cScore = float.Parse(this.textBoxCScore.Text.Trim());
                if (cScore <= 0)
                {
                    strError += "学分必须大于0！\n";
                }
                else if (cScore > 5)
                {
                    strError += "学分不能大于5！\n";
                }

            }
            catch (Exception)
            {

                strError += "学分设置的有问题！\n";
            }
            if (strError != "")//报异常了                
            {
                MessageBox.Show(this, strError, "出错了", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            //实例化Model
            WindowsForms_Student.Model.Course model = new Model.Course();
            model.CNo = this.textBoxCNo.Text.Trim();
            model.CName = this.textBoxCName.Text.Trim();
            model.CScore = cScore.ToString();
           

            //
            WindowsForms_Student.BLL.Course bll = new BLL.Course();
            try
            {
                switch (_editflag)
                {
                    case 0: //新增
                        bll.Add(model);
                        MessageBox.Show(this, "添加成功！", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _cNo = model.CNo;//将课程号传给_cNo
                        break;

                    case 1://修改
                        bll.Update(model);
                        MessageBox.Show(this, "修改成功！", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;

                }

                //设置弹出窗的返回值
                this.DialogResult = DialogResult.OK;
                //关闭当前窗口
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错了", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;

            }
        }


    }

}
