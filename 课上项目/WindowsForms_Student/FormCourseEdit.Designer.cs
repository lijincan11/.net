namespace WindowsForms_Student
{
    partial class FormCourseEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxCScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 80);
            this.panel1.TabIndex = 38;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(251, 19);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取  消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(32, 19);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(86, 35);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "确  定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxCScore
            // 
            this.textBoxCScore.Location = new System.Drawing.Point(120, 136);
            this.textBoxCScore.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCScore.Name = "textBoxCScore";
            this.textBoxCScore.Size = new System.Drawing.Size(185, 21);
            this.textBoxCScore.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "学分";
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(120, 80);
            this.textBoxCName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(185, 21);
            this.textBoxCName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "课程名";
            // 
            // textBoxCNo
            // 
            this.textBoxCNo.Location = new System.Drawing.Point(120, 32);
            this.textBoxCNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCNo.Name = "textBoxCNo";
            this.textBoxCNo.Size = new System.Drawing.Size(185, 21);
            this.textBoxCNo.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "课程号";
            // 
            // FormCourseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxCScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCNo);
            this.Controls.Add(this.label1);
            this.Name = "FormCourseEdit";
            this.Text = "FormCourseEdit";
            this.Load += new System.EventHandler(this.FormCourseEdit_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxCScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCNo;
        private System.Windows.Forms.Label label1;
    }
}