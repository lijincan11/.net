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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private bool rightQuery, rightAdd, rightDel, rightModify,rightSet;//保存权限

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            //实例化
            FormUserEdit temp = new FormUserEdit(0);
            //调用方法ShowDialog以对话框的方式弹出
            temp.ShowDialog();
            if (temp.DialogResult == DialogResult.OK)
            {
                this.buttonQuerry_Click(this.buttonQuerry, e);//调用查询按钮刷新数据
                this.AutoLocation(this.dataGridView1, "UserID", temp.UserID);//自动定位

            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0 && e.Button == MouseButtons.Right
                && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //取消当前行的选中
                this.dataGridView1.CurrentRow.Selected = false;
                //选中鼠标所在的行
                this.dataGridView1.Rows[e.RowIndex].Selected = true;

            }
        }

        private void MenuItemModefy_Click(object sender, EventArgs e)
        {
            //获取被选中行的学号
            string userID = this.dataGridView1.SelectedRows[0].Cells["UserID"].Value.ToString();
            //实例化弹出窗
            WindowsForms_Student.FormUserEdit temp = new FormUserEdit(1, userID);
            temp.ShowDialog();

            if (temp.DialogResult == DialogResult.OK)
            {
                this.buttonQuerry_Click(this.buttonQuerry, e);
                this.AutoLocation(this.dataGridView1, "UserID", temp.UserID);//自动定位
            }
        }
        //自动定位
        private void AutoLocation(DataGridView datagrid, string fielName, string locatevalue)
        {
            int found_row = -1;//找到的行

            //没有记录 或者 定位的字段名为空 或者 定位的值为空则直接退出
            if (datagrid.Rows.Count <= 0 || locatevalue == "" || fielName == "")
            {
                return;
            }

            //遍历所有的记录
            for (int i = 0; i < datagrid.Rows.Count; i++)
            {
                if (datagrid.Rows[i].Cells[fielName].Value.ToString() == locatevalue)
                {
                    found_row = i;//找到
                    break;
                }
            }

            if (found_row >= 0)
            {
                datagrid.CurrentRow.Selected = false;//取消当前被选中的行
                datagrid.Rows[found_row].Selected = true;//选中新增/修改的行

                datagrid.FirstDisplayedScrollingRowIndex = found_row;//自动滚动到当前屏
            }

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //刷新弹出菜单的可用性
            this.MenuItemDel.Visible = rightDel && this.dataGridView1.SelectedRows.Count > 0;
            this.MenuItemModefy.Visible = rightModify && this.dataGridView1.SelectedRows.Count > 0;
            this.MenuItemRole.Visible =rightSet && this.dataGridView1.SelectedRows.Count > 0;
        }

        private void MenuItemDel_Click(object sender, EventArgs e)
        {
            //删除所选的信息
            if (MessageBox.Show(this, "你确定要删除所选记录吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //获取被选中的记录的学号
                string userID = this.dataGridView1.SelectedRows[0].Cells["UserID"].Value.ToString();

                //调用BLL层的方法删除记录
                WindowsForms_Student.BLL.S_User bll = new BLL.S_User();//实例化


                try
                {
                    //删除
                    bll.Delete(userID);

                    MessageBox.Show(this, "删除成功!", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.buttonQuerry_Click(this.buttonQuerry, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "删除失败\n" + ex.Message, "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    throw;
                }

            }
        }

        private void buttonQuerry_Click(object sender, EventArgs e)
        {
            string userID = this.textBoxUserID.Text.Trim();
            //实例化
            BLL.Core bll = new BLL.Core();
            this.dataGridView1.DataSource = bll.GetListUser(userID).Tables[0].DefaultView;
        }

        private void MenuItemRole_Click(object sender, EventArgs e)
        {
            //获取被选中的用户id
            string userID = this.dataGridView1.SelectedRows[0].Cells["userID"].Value.ToString();

            //实例化FormUserRole并以弹出窗的方式显示
            FormUserRole temp = new FormUserRole(userID);
            temp.ShowDialog();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            rightAdd = BLL.Core.IsHaveRight("f20");
            rightDel = BLL.Core.IsHaveRight("f21");
            rightModify = BLL.Core.IsHaveRight("f22");
            rightQuery = BLL.Core.IsHaveRight("f23");
            rightSet = BLL.Core.IsHaveRight("f24");

            this.MenuItemAdd.Visible = rightAdd;
            this.MenuItemDel.Visible = rightDel;
            this.MenuItemModefy.Visible = rightModify;
            this.buttonQuerry.Visible = rightQuery;
            this.MenuItemRole.Visible = rightSet;
        }
    }
}
