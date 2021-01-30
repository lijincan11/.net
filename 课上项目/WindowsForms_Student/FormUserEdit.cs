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
    public partial class FormUserEdit : Form
    {
        private int _editflag;//0 新增 ；1 修改；2 详细信息
        private string _userID;//用户ID

        public string UserID //属性
        {
            get { return _userID; }
            set { _userID = value; }
        }

        //重新定义构造函数
        public FormUserEdit(int editflag)
        {
            _editflag = editflag;
            InitializeComponent();
        }
        //重新定义构造函数
        public FormUserEdit( int editflag, string userID)
        {
            _editflag = editflag;
            _userID = userID;
            InitializeComponent();
        }

        private void FormUserEdit_Load(object sender, EventArgs e)
        {
           
            //更新窗体标题
            switch (_editflag)
            {
                case 0:
                    this.Text = "新增用户信息"; break;
                case 1:
                    this.Text = "修改用户信息";

                    this.textBoxUserID.ReadOnly = true;
                    //根据学号查询信息并展示
                    WindowsForms_Student.Model.S_User model = new BLL.S_User().GetModel(_userID);
                    this.textBoxUserID.Text = model.UserID;//显示用户ID
                    this.textBoxUserPWD.Text = model.UPassWord;//显示密码
                    this.textBoxSID.Text = model.SNO;//显示SNO
                    this.textBoxTID.Text = model.TNO;//显示TNO
                    break;

                case 2:
                    this.Text = "学生档案详细信息"; break;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string strError = "";
            if (this.textBoxUserID.Text.Trim() == "")
                strError += "用户名不能为空！\n";
            if (this.textBoxUserPWD.Text.Trim() == "")
                strError += "密码不能为空！\n";

           
            if (strError != "")//报异常了                
            {
                MessageBox.Show(this, strError, "出错了", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            //实例化Model
            WindowsForms_Student.Model.S_User model = new Model.S_User();
            model.UserID = this.textBoxUserID.Text.Trim();
            model.UPassWord = this.textBoxUserPWD.Text.Trim();
            
            model.SNO = this.textBoxSID.Text.Trim();
            model.TNO = this.textBoxTID.Text.Trim();
         
            //
            WindowsForms_Student.BLL.S_User bll = new BLL.S_User();
            try
            {
                switch (_editflag)
                {
                    case 0: //新增
                        bll.Add(model);
                        MessageBox.Show(this, "添加成功！", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _userID = model.UserID;//将用户ID传给_userID
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
