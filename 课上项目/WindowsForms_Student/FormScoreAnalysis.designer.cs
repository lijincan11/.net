namespace WindowsForms_Student
{
    partial class FormScoreAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3.2D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 12D);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbAvg = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(17, 12);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "节点0";
            treeNode7.Text = "节点0";
            treeNode8.Name = "节点1";
            treeNode8.Text = "节点1";
            treeNode9.Name = "节点2";
            treeNode9.Text = "节点2";
            treeNode10.Name = "节点3";
            treeNode10.Text = "节点3";
            treeNode11.Name = "节点4";
            treeNode11.Text = "节点4";
            treeNode12.Name = "节点5";
            treeNode12.Text = "节点5";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(121, 353);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(180, 93);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "比例";
            series2.Name = "1";
            dataPoint3.IsVisibleInLegend = true;
            dataPoint3.LegendText = "a";
            dataPoint4.LegendText = "2";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(545, 272);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "分段统计";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("宋体", 14F);
            this.lbNum.Location = new System.Drawing.Point(176, 38);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(96, 19);
            this.lbNum.TabIndex = 2;
            this.lbNum.Text = "总人数:43";
            // 
            // lbAvg
            // 
            this.lbAvg.AutoSize = true;
            this.lbAvg.Font = new System.Drawing.Font("宋体", 14F);
            this.lbAvg.Location = new System.Drawing.Point(549, 38);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(96, 19);
            this.lbAvg.TabIndex = 3;
            this.lbAvg.Text = "平均分:43";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("宋体", 14F);
            this.lbMin.Location = new System.Drawing.Point(430, 38);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(96, 19);
            this.lbMin.TabIndex = 4;
            this.lbMin.Text = "最低分:43";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("宋体", 14F);
            this.lbMax.Location = new System.Drawing.Point(299, 38);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(96, 19);
            this.lbMax.TabIndex = 5;
            this.lbMax.Text = "最高分:43";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("宋体", 14F);
            this.lbPass.Location = new System.Drawing.Point(678, 38);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(96, 19);
            this.lbPass.TabIndex = 6;
            this.lbPass.Text = "挂科率:43";
            // 
            // FormScoreAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 414);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbAvg);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.chart1);
            this.Name = "FormScoreAnalysis";
            this.Text = "统计分析";
            this.Load += new System.EventHandler(this.FormScoreAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbAvg;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbPass;
    }
}