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
    public partial class FormScoreAnalysis : Form
    {
        public FormScoreAnalysis()
        {
            InitializeComponent();
        }

        private void FormScoreAnalysis_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            BLL.Course bll = new BLL.Course();
            BLL.Student_Course scbll = new BLL.Student_Course();

            //将数据库的表添加节点
            List<Model.Course> list= bll.GetModelList("");
            for(int i = 0; i < list.Count; i++)
            {
                TreeNode node = new TreeNode();
                node.Tag = list[i].CNo;
                node.Text = list[i].CName;
                if (scbll.GetModelList("CNO='" + list[i].CNo + "'").Count == 0)//课程没人选
                {
                    node.Text += "(无记录)";
                }
                treeView1.Nodes.Add(node);
            }
            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //求值
            if (treeView1.SelectedNode.Text.Contains("无记录"))
            {
                MessageBox.Show("当前课程无人选");
            }
            else
            {

                //求每个分数段的人数
                string cno = treeView1.SelectedNode.Tag.ToString();
                BLL.Core bll = new BLL.Core();
                DataTable table = bll.GetListS_CScore(cno).Tables[0];
                List<double> scores = new List<double>();
                double sum = 0;//总分
                int passNum = 0;//不及格人数
                int A = 0;  //得A的人数
                int B = 0;  //得B的人数
                int C = 0;  //得C的人数
                int D = 0;  //得D的人数
                foreach (DataRow row in table.Rows)
                {
                    double score = 0;
                    try
                    {
                        score = double.Parse(row["Score"].ToString());
                        scores.Add(score);
                        if (score >= 90 && score <= 100)
                        {
                            A++;
                        }
                        else if (score >= 80 && score < 90)
                        {
                            B++;
                        }
                        else if (score >= 70 && score < 80)
                        {
                            C++;
                        }
                        else if (score >= 60 && score < 70)
                        {
                            D++;
                        }
                        else
                        {
                            passNum++;
                        }

                        sum += score;
                    }
                    catch
                    {
                        passNum++;
                    }

                }

                //给标签的text赋值
                scores.Sort();
                double cnt = table.Rows.Count * 1.0;
                lbAvg.Text = "平均分" + (sum / cnt).ToString("0.00");
                lbMax.Text = "最高分:" + scores[scores.Count - 1];
                lbMin.Text = "最低分:" + scores[0];
                lbNum.Text = "总人数:" + table.Rows.Count;
                lbPass.Text = "挂科率:" + ((passNum / cnt) * 100).ToString("0.00") + "%";

                //添加条形图
                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.AddXY("90~100", A);
                chart1.Series[0].Points.AddXY("80~90", B);
                chart1.Series[0].Points.AddXY("70~80", C);
                chart1.Series[0].Points.AddXY("60~70", D);
                chart1.Series[0].Points.AddXY("0~60", passNum);

               
                //在条形图的label赋值
                chart1.Series[0].Points[0].Label = "优秀" + ((A / cnt) * 100).ToString("0.00") + "%";
                chart1.Series[0].Points[1].Label = "良好" + ((B / cnt) * 100).ToString("0.00") + "%";
                chart1.Series[0].Points[2].Label = "中等" + ((C / cnt) * 100).ToString("0.00") + "%";
                chart1.Series[0].Points[3].Label = "及格" + ((D / cnt) * 100).ToString("0.00") + "%";
                chart1.Series[0].Points[4].Label = "挂科" + ((passNum / cnt) * 100).ToString("0.00") + "%";
            }
        }
       
    }
}
