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
    public partial class FormRole : Form
    {
        public FormRole()
        {
            InitializeComponent();
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            //获取所有的角色信息
            dataGridView1.DataSource = new BLL.S_Role().GetAllList().Tables[0].DefaultView;
        }

        private void MenuItemRoleSet_Click(object sender, EventArgs e)
        {
            //获取被选中的权限设置
            string roleID = dataGridView1.SelectedRows[0].Cells["RoleID"].Value.ToString();

            FormRoleRight temp = new FormRoleRight(roleID);
            temp.ShowDialog();
        }
    }
}
