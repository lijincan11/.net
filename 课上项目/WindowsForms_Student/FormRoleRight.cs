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
    public partial class FormRoleRight : Form
    {
        private string _roleID;//角色编号
        public FormRoleRight(string roleID)
        {
            _roleID = roleID;//获取参数值

            InitializeComponent();
        }

        private void FormRoleRight_Load(object sender, EventArgs e)
        {
            //清空所有节点
            treeView1.Nodes.Clear();
            //获取角色_roleID所拥有的权限和系统的所有权限
            DataTable tableRight = new BLL.Core().GetListRoleRight(_roleID).Tables[0];
            //遍历所有行,显示系统所有权限以及该角色所拥有的权限
            foreach (DataRow row in tableRight.Rows)
            {
                TreeNode node = new TreeNode();
                node.Text = row["FunctionName"].ToString();//权限名称
                node.Tag = row["FunctionID"].ToString();//权限编号

                node.Checked = row["have"].ToString() != "";
                this.treeView1.Nodes.Add(node);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"您确实要提交权限设置吗?","确认提交",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                Model.S_R_F model = new Model.S_R_F();
                BLL.S_R_F bll = new BLL.S_R_F();
                foreach (TreeNode node in this.treeView1.Nodes)
                {
                    if (node.Checked)
                    {
                        if (bll.Exists(_roleID,node.Tag.ToString()))
                        {
                            continue;
                        }
                        else
                        {
                            model.RoleID = _roleID;
                            model.FunctionID = node.Tag.ToString();
                            try
                            {
                                bll.Add(model);
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        }
                    }
                    else
                    {
                        if (bll.Exists(_roleID,node.Tag.ToString()))
                        {
                            try
                            {
                                bll.Delete(_roleID, node.Tag.ToString());
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        }
                    }
                }
                this.Close();
            }//end if
        }
    }
}
