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
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
        }
        private bool rightQuery, rightAdd, rightDel, rightModify;//保存权限


        /// <summary>
        /// 查询所有课程信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            

            WindowsForms_Student.BLL.Core core = new BLL.Core();

            string cNo = this.textBoxCNo.Text.Trim();
            string cName = this.textBoxCName.Text.Trim();
            this.dataGridView1.DataSource = core.GetListCourse(cNo, cName).Tables[0].DefaultView;
        }

        private void MenuItemDel_Click(object sender, EventArgs e)
        {
            //删除所选的信息
            if (MessageBox.Show(this, "你确定要删除所选记录吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //获取被选中的记录的学号
                string cNo = this.dataGridView1.SelectedRows[0].Cells["CNo"].Value.ToString();

                //调用BLL层的方法删除记录
                WindowsForms_Student.BLL.Course bll = new BLL.Course();//实例化


                try
                {
                    //删除
                    bll.Delete(cNo);

                    MessageBox.Show(this, "删除成功!", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Button1_Click(this.Button1, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "删除失败\n" + ex.Message, "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    throw;
                }

            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //刷新弹出菜单的可用性
            this.MenuItemDel.Visible = rightDel&& this.dataGridView1.SelectedRows.Count > 0;
            this.MenuItemModify.Visible = rightModify && this.dataGridView1.SelectedRows.Count > 0;
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

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            //实例化
            FormCourseEdit temp = new FormCourseEdit(0);
            //调用方法ShowDialog以对话框的方式弹出
            temp.ShowDialog();
            if (temp.DialogResult == DialogResult.OK)
            {
                this.Button1_Click(this.Button1, e);//调用查询按钮刷新数据
                this.AutoLocation(this.dataGridView1, "CNo", temp.CNO);//自动定位

            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0 && e.Button == MouseButtons.Right
                && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //取消当前行的选中
                if(this.dataGridView1.CurrentRow !=null)
                    this.dataGridView1.CurrentRow.Selected = false;
                //选中鼠标所在的行
                this.dataGridView1.Rows[e.RowIndex].Selected = true;

            }
        }

        private void MenuItemModify_Click(object sender, EventArgs e)
        {
            //获取被选中行的课程号
            string cNo = this.dataGridView1.SelectedRows[0].Cells["CNo"].Value.ToString();
            //实例化弹出窗
            WindowsForms_Student.FormCourseEdit temp = new FormCourseEdit(1, cNo);
            temp.ShowDialog();

            if (temp.DialogResult == DialogResult.OK)
            {
                this.Button1_Click(this.Button1, e);
                this.AutoLocation(this.dataGridView1, "CNo", temp.CNO);//自动定位
            }
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            rightAdd = BLL.Core.IsHaveRight("f10");
            rightDel = BLL.Core.IsHaveRight("f11");
            rightModify = BLL.Core.IsHaveRight("f09");
            rightQuery = BLL.Core.IsHaveRight("f12");

            this.MenuItemAdd.Visible = rightAdd;
            this.Button1.Visible = rightQuery;
        }
    }
}
