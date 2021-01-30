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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //判断用户名和密码是否为空
            if (this.textBoxUserID.Text.Trim() == ""||this.textBoxUserPwd.Text.Trim() == "")
            {
                MessageBox.Show(this, "用户名或密码不能为空！\n", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            //获取用户名和密码
            string userID = this.textBoxUserID.Text.Trim();
            string userPWD = this.textBoxUserPwd.Text.Trim();

            //实例化BLL层并调用方法ExistUser校验用户是否存在
            BLL.Core bll = new BLL.Core();
            //获取数据库的连接
            bll.getDBConnectionString();
            if (bll.ExistUser(userID,userPWD))//用户合法
            {
                //预留权限控制
                bll.GetUserRight(userID);//获取登陆用户的所有权限


                this.DialogResult = DialogResult.OK;//设置窗体返回
                
            }
            else//用户非法
            {
                MessageBox.Show(this, "用户名或者密码错误!", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

    }
}
