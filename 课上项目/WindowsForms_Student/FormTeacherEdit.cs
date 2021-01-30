using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_Student
{
    public partial class FormTeacherEdit : Form
    {
        private int _editflag;//0 新增 ；1 修改；2 详细信息
        private string _tNo;
        //重新定义构造函数
        public FormTeacherEdit(int edit_flag)
        {
            _editflag = edit_flag;//获取参数
            InitializeComponent();
        }

        public string TNO //属性
        {
            get { return _tNo; }
            set { _tNo = value; }
        }

        public FormTeacherEdit(int edit_flag,string tNo)
        {
            _editflag = edit_flag;//获取参数
            _tNo = tNo;//获取工号
            InitializeComponent();
        }

        private void FormTeacherEdit_Load(object sender, EventArgs e)
        {
            //更新窗体标题
            switch (_editflag)
            {
                case 0:
                    this.Text = "新增教师档案信息"; break;
                case 1:
                    this.textBoxTNo.ReadOnly = true;
                    this.Text = "修改教师档案信息";
                    //根据学号查询信息并展示
                    WindowsForms_Student.Model.teacher model = new BLL.teacher().GetModel(_tNo);
                    this.textBoxTNo.Text = model.TNo;//显示学号
                    this.textBoxTName.Text = model.TName;//显示姓名
                    this.textBoxTAge.Text = Convert.ToString(model.TAge);//显示年龄
                    

                    if (model.TSex == "男")                  //显示性别
                        this.radioButtonMan.Checked = true;
                    else
                        this.radioButtonWoman.Checked = true;

                    this.comboBoxDept.SelectedValue = model.DNo;    //显示院系
                    break;
                case 2:
                    this.Text = "教师档案详细信息"; break;
            }

            //初始化院系下拉列表
            try
            {
                WindowsForms_Student.BLL.department bll = new BLL.department();//实例化
                this.comboBoxDept.DataSource = bll.GetAllList().Tables[0].DefaultView;//数据源
                this.comboBoxDept.DisplayMember = "DName";//显示的字段名
                this.comboBoxDept.ValueMember = "DNo";//值的字段名
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "初始化失败！" + ex.Message, "出错了",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

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
            if (this.textBoxTNo.Text.Trim() == "")
                strError += "学号不能为空！\n";
            if (this.textBoxTName.Text.Trim() == "")
                strError += "姓名不能为空！\n";


            int tAge = 0;
            try
            {
                tAge = int.Parse(this.textBoxTAge.Text.Trim());
                if (tAge < 0)
                {
                    strError += "你还没有出生！\n";
                }
                else if (tAge > 150)
                {
                    strError += "已经修炼成精了，可以去火星了！\n";
                }

            }
            catch (Exception)
            {

                strError += "年龄必须是整数！\n";
            }
            if (strError != "")//报异常了                
            {
                MessageBox.Show(this, strError, "出错了", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            //实例化Model
            WindowsForms_Student.Model.teacher model = new Model.teacher();
            model.TNo = this.textBoxTNo.Text.Trim();
            model.TName = this.textBoxTName.Text.Trim();
            model.TSex = this.radioButtonMan.Checked ? "男" : "女";
            
            model.TAge = tAge;
            model.DNo = this.comboBoxDept.SelectedValue.ToString();

            //
            WindowsForms_Student.BLL.teacher bll = new BLL.teacher();
            try
            {
                switch (_editflag)
                {
                    case 0: //新增
                        bll.Add(model);
                        MessageBox.Show(this, "添加成功！", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _tNo = model.TNo;//将学号传给_tNo
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
