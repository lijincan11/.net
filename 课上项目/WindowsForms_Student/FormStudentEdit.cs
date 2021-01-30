using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForms_Student.BLL;

namespace WindowsForms_Student
{
    public partial class FormStudentEdit : Form
    {
        private int _editflag;//0 新增 ；1 修改；2 详细信息
        private string _sNo;//学号

        public string SNO //属性
        {
            get { return _sNo; }
            set { _sNo = value; }
        }

        //重新定义构造函数
        public FormStudentEdit(int edit_flag)
        {
            _editflag = edit_flag;//获取参数
            InitializeComponent();
        }

        //重新定义构造函数
        public FormStudentEdit(int edit_flag,string sNo)
        {
            _editflag = edit_flag;//获取参数
            _sNo = sNo;//获取学号
            InitializeComponent();
        }

        private void FormStudentEdit_Load(object sender, EventArgs e)
        {
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
            //更新窗体标题
            switch (_editflag)
            {
                case 0:
                    this.Text = "新增学生档案信息";break;
                case 1:
                    this.Text = "修改学生档案信息";

                    this.textBoxSNo.ReadOnly = true;
                    //根据学号查询信息并展示
                    WindowsForms_Student.Model.student model = new BLL.student().GetModel(_sNo);
                    this.textBoxSNo.Text = model.SNo;//显示学号
                    this.textBoxSName.Text = model.SName;//显示姓名
                    this.textBoxAge.Text = Convert.ToString(model.SAge);//显示年龄

                    
                    if (model.SBirthday != "")
                    {
                        this.dateTimeSBirthday.Value = Convert.ToDateTime(model.SBirthday);//显示出生日期
                    }
                   
                    

                    if (model.SSex == "男")                  //显示性别
                        this.radioButtonMan.Checked = true;
                    else
                        this.radioButtonWoman.Checked = true;

                    this.comboBoxDept.SelectedValue = model.DNo;    //显示院系
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
            if (this.textBoxSNo.Text.Trim() == "")
                strError += "学号不能为空！\n";
            if (this.textBoxSName.Text.Trim() == "")
                strError += "姓名不能为空！\n";


            int sAge = 1;
            try
            {
                sAge = int.Parse(this.textBoxAge.Text.Trim());
                if (sAge <= 0 )
                {
                    strError += "你还没有出生！\n";
                }
                else if (sAge > 100)
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
            WindowsForms_Student.Model.student model = new Model.student();
            model.SNo = this.textBoxSNo.Text.Trim();
            model.SName = this.textBoxSName.Text.Trim();
            model.SSex = this.radioButtonMan.Checked ? "男" : "女";
            model.SBirthday = Convert.ToString(this.dateTimeSBirthday.Value);
            model.SAge = sAge;
            model.DNo = this.comboBoxDept.SelectedValue.ToString();

            //
            WindowsForms_Student.BLL.student bll = new BLL.student();
            try
            {
                switch (_editflag)
                {
                    case 0: //新增
                        bll.Add(model);
                        MessageBox.Show(this, "添加成功！", "友情提示", MessageBoxButtons.OK,MessageBoxIcon.Information);

                        _sNo = model.SNo;//将学号传给_sNo
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
