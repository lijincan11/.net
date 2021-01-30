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
    public partial class FormS_CScore : Form
    {
        //创建数据缓存
        Dictionary<string, string> dic = new Dictionary<string, string>();
        bool isFirstLoad = true;//判断是否第一次载入
        string lastCno = "";//更改前的cno

        private bool rightUpdate;//保存权限
        public FormS_CScore()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 判断缓存里面的数据是否改变
        /// </summary>
        /// <returns>返回改变数据的总数</returns>
        public int CheckUpdate()
        {
            int num = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Score"].Value.ToString() != dic[dataGridView1.Rows[i].Cells["SNO"].Value.ToString()].ToString())
                {
                    num++;
                }
            }
            return num;
        }

        /// <summary>
        /// 更新缓存
        /// </summary>
        public void UpdateDic()
        {
            dic = new Dictionary<string, string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dic.Add(dataGridView1.Rows[i].Cells["SNO"].Value.ToString(), dataGridView1.Rows[i].Cells["Score"].Value.ToString());
            }

        }



        private void FormS_CScore_Load(object sender, EventArgs e)
        {
            //初始化下拉列表
            this.comboBoxCourse.DataSource = new BLL.Course().GetAllList().Tables[0].DefaultView;
            this.comboBoxCourse.DisplayMember = "CName";//文本对应的字段名
            this.comboBoxCourse.ValueMember = "CNo";//值对应的字段名
            lastCno = this.comboBoxCourse.SelectedValue.ToString();//选中的Cno设置为更改前的CNo

            rightUpdate = !BLL.Core.IsHaveRight("f19");
           

            this.dataGridView1.ReadOnly = rightUpdate;
            
        }

        private void comboBoxCourse_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!isFirstLoad)
            {
                this.buttonCommit_Click(this.buttonCommit, e);
            }

            if (this.comboBoxCourse.SelectedValue.ToString() == "")
            {
                return;
            }

            //获取被选中的课程编号
            string CNo = this.comboBoxCourse.SelectedValue.ToString();

            //实例化BLL层并调用方法GetListS_CCorse获取该课程的学生成绩列表
            BLL.Core bll = new BLL.Core();
            this.dataGridView1.DataSource = bll.GetListS_CScore(CNo).Tables[0].DefaultView;

            //更新缓存
            UpdateDic();

            isFirstLoad = false;
            lastCno = comboBoxCourse.SelectedValue.ToString();
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            int n = CheckUpdate();
            if (n > 0)
            {
                if (MessageBox.Show(this, "检测到有" + n + "条数据被修改,确认修改吗？", "提交确认", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strErr = "";//记录异常

                    //实例化Model并给model的各个属性赋值
                    Model.Student_Course model = new Model.Student_Course();
                    model.CNo = lastCno;

                    BLL.Student_Course bll = new BLL.Student_Course();
                    //遍历DATaGridView中的记录
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        //获取SNO并赋值给Model

                        model.SNo = dataGridView1.Rows[i].Cells["SNo"].Value.ToString();
                        //获取Score
                        if (dataGridView1.Rows[i].Cells["Score"].Value.ToString() == "")
                        {
                            continue;
                        }
                        try
                        {
                            double score = Convert.ToDouble(dataGridView1.Rows[i].Cells["Score"].Value.ToString());
                            if (score > 100 || score < 0)
                            {
                                strErr += "学号为:" + model.SNo + "的学生的成绩不在合理的范围.\n";
                                continue;
                            }
                            //continue;
                            model.Score = dataGridView1.Rows[i].Cells["Score"].Value.ToString();
                        }
                        catch (Exception)
                        {
                            strErr += "学号为:" + model.SNo + "的学生的成绩有问题.\n";
                            continue;
                        }
                       
                        //提交数据库
                        try
                        {
                            bll.Update(model);
                            
                        }
                        catch (Exception)
                        {
                            strErr += "提交学号为:" + model.SNo + "的学生的成绩出错。\n";
                            continue;
                        }
                    }//end for

                    //更新缓存
                    UpdateDic();

                    if (strErr == "")
                    {
                        MessageBox.Show(this, "修改了" + n.ToString() + "个学生成绩\n" + strErr,
                        "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this,  strErr,
                       "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                   //刷新按钮
                    buttonCommit.Enabled = CheckUpdate() > 0 ? true : false;
                }//end if
            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            buttonCommit.Enabled = CheckUpdate() > 0 ? true : false;
        }
    }
}
