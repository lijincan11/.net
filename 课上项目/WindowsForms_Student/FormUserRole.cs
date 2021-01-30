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
    public partial class FormUserRole : Form
    {
        string _userId;//用户名

        public FormUserRole(string userId)
        {
            _userId = userId;//获取参数值
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void FormUserRole_Load(object sender, EventArgs e)
        {
            //获取用户_userid所拥有的角色,并保存到字符串strRole里
            string strRole = ",";
            DataTable tableRole = new BLL.Core().GetListUserRole(_userId).Tables[0];

            foreach (DataRow row in tableRole.Rows)
            {
                strRole += row["RoleId"].ToString() + ",";
            }
            //获取系统所有的角色
            DataTable tableRoleAll = new BLL.S_Role().GetAllList().Tables[0];
            this.treeView1.Nodes.Clear();//清空所有节点
            foreach (DataRow row in tableRoleAll.Rows)
            {
                TreeNode node = new TreeNode();
                node.Text = row["RoleName"].ToString();//角色名称
                node.Tag = row["RoleID"].ToString();//角色编号

                if (strRole.Contains(","+node.Tag.ToString()+",") )
                {
                    node.Checked = true;
                }
                this.treeView1.Nodes.Add(node);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"您确实要提交角色设置信息吗？","提交确认",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {
                //先清空UserID的所有角色
                try
                {
                    new BLL.Core().DeleteUserRole(_userId);
                }
                catch (Exception)
                {
                    throw;
                }
                //遍历所有角色并插入被选中的角色信息
                foreach(TreeNode node in this.treeView1.Nodes)
                {
                    if (!node.Checked)
                    {
                        continue;
                    }
                    Model.S_U_R model = new Model.S_U_R();
                    model.UserID = _userId;
                    model.RoleID = node.Tag.ToString();
                    try
                    {
                        new BLL.S_U_R().Add(model);
                    }
                    catch { }
                }
                this.Close();
            }//end if
        }
    }
}
