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
    public partial class FormTreeEdit : Form
    {

        private int _editFlag;//编辑标记  0表示新增兄弟节点，1表示新增子节点，2表示编辑
        private string _tNo;//节点编号
        private string _tNoParent;//父节点编号
        private string _tName;//节点名称

        public string TNO//节点编号
        {
            get { return _tNo; }
            set { _tNo = value; }
        }

        public string TName//节点名称
        {
            get { return _tName; }
            set { _tName = value; }
        }


        public FormTreeEdit(int editFlag, string tNo)
        {
            _editFlag = editFlag;
            _tNo = tNo;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
        private void FormTreeEdit_Load(object sender, EventArgs e)
        {
            if (_editFlag == 0)
                this.Text = "新增兄弟节点";
            else if (_editFlag == 1)
            {
                this.Text = "新增子节点";
                _tNoParent = _tNo;//获取即将新增的节点的父节点编号TNOParent
            }
            else
            {
                this.Text = "修改节点";
                this.textBoxTNo.ReadOnly = true;//TNO不可修改
                //根据TNO获取该结点的相关信息
                WindowsForms_Student.Model.Tree model = new BLL.Tree().GetModel(_tNo);
                this.textBoxTNo.Text = model.TNO;
                this.textBoxTName.Text = model.TName;
                _tNoParent = model.TNOParent;
            }

        }




        private void buttonOK_Click(object sender, EventArgs e)
        {
            string strError = "";
            if (this.textBoxTNo.Text.Trim() == "")
                strError += "节点编号不能为空！\n";
            if (this.textBoxTName.Text.Trim() == "")
                strError += "节点名称不能为空！]n";
            if (strError != "")
            {
                MessageBox.Show(this, strError, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //实例化model并给model各属性赋值
            WindowsForms_Student.Model.Tree model = new Model.Tree();
            model.TNO = this.textBoxTNo.Text.Trim();//节点编号
            model.TName = this.textBoxTName.Text.Trim();//节点名称
            model.TNOParent = _tNoParent;//父节点编号

            WindowsForms_Student.BLL.Tree bll = new BLL.Tree();//实例化BLL层
            try
            {
                if (_editFlag == 0 || _editFlag == 1)
                    bll.Add(model);
                else if (_editFlag == 2)
                    bll.Update(model);

                //更新属性值
                _tNo = model.TNO;
                _tName = model.TName;
                //设置窗体返回值
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "更新失败！\n" + ex.Message, "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

       
    }
}
