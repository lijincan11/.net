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
    public partial class FormTree : Form
    {
        //保存所有树结构的数据
        DataTable dt_tree = new DataTable();

        public FormTree()
        {
            InitializeComponent();
        }

        private void FormTree_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();//清空所有结点
            //添加根节点
            TreeNode root = new TreeNode();
            root.Text = "武汉纺织大学";
            root.Tag = "0";
            this.treeView1.Nodes.Add(root);

            //获取所有的树结构
            dt_tree = new WindowsForms_Student.BLL.Tree().GetAllList().Tables[0];

            this.build_tree(root);//创建子节点

            this.treeView1.ExpandAll();//展开所有子节点
        }

        //创建子节点
        private void build_tree(TreeNode parenetNode)
        {
            //获取父节点为ParenetNode的所有的数据集
            DataRow[] dataRow = dt_tree.Select("TNOParent='" + parenetNode.Tag.ToString() + "'");
            
            //把每一条记录作为ParentNode的一个子节点新增到树结构中
            foreach (DataRow row in dataRow)
            {
                //实例化结点并给属性赋值
                TreeNode node = new TreeNode();
                node.Text = row["TName"].ToString();
                node.Tag = row["TNO"].ToString();

                //作为ParentNode的子节点新增到树结构中
                parenetNode.Nodes.Add(node);
                //递归
                this.build_tree(node);
            }
            
            
            
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            //获取鼠标所在的位置的节点
            TreeNode node = this.treeView1.GetNodeAt(e.X, e.Y);

            if (node != null)
            {
                this.treeView1.SelectedNode = node;
            }

        }

        private void MenuItemDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"你确定要删除你所选中的记录吗？","确认删除",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                if (this.treeView1.SelectedNode.Nodes.Count > 0 )//有子节点
                {
                    MessageBox.Show(this, "你还有子节点未删除，请先删除子节点！", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }
                else//叶子 结点
                {
                    //或者被选中的节点的TNO
                    string tNo = this.treeView1.SelectedNode.Tag.ToString();
                    //调用Delete方法从数据库删除该节点
                    try
                    {
                        new BLL.Tree().Delete(tNo);
                        this.treeView1.SelectedNode.Remove();//界面刷新
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "删除失败\n" + ex.Message, "出错了",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                        throw;
                    }
                    
                }
            }
        }

        private void MenuItemAddChild_Click(object sender, EventArgs e)
        {
            //获取被选中的记录的TNO
            string tNo = this.treeView1.SelectedNode.Tag.ToString();
            FormTreeEdit temp = new FormTreeEdit(1, tNo);
            temp.ShowDialog();
            if (temp.DialogResult == DialogResult.OK)
            {
                //刷新显示
                TreeNode node = new TreeNode();
                node.Text = temp.TName;
                node.Tag = temp.TNO;

                this.treeView1.SelectedNode.Nodes.Add(node);
            }
        }

        private void MenuItemModify_Click(object sender, EventArgs e)
        {
            //获取被选中的记录的TNO
            string tNo = this.treeView1.SelectedNode.Tag.ToString();
            FormTreeEdit temp = new FormTreeEdit(2, tNo);
            temp.ShowDialog();
            if (temp.DialogResult == DialogResult.OK)//刷新显示
            {

                this.treeView1.SelectedNode.Tag = temp.TNO;
                this.treeView1.SelectedNode.Text = temp.TName;

               
            }
        }

        private void MenuItemAddBrother_Click(object sender, EventArgs e)
        {
            //获取被选中的记录的TNO
            string tNo = this.treeView1.SelectedNode.Tag.ToString();
            FormTreeEdit temp = new FormTreeEdit(0, tNo);
            temp.ShowDialog();
            if (temp.DialogResult == DialogResult.OK)
            {
                //刷新显示
                TreeNode node = new TreeNode();
                node.Text = temp.TName;
                node.Tag = temp.TNO;

                this.treeView1.SelectedNode.Nodes.Add(node);
            }
        }
    }
}
