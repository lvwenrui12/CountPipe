﻿namespace CountPipe
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("灰度");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("高斯模糊");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("中值模糊");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("高斯双边滤波");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("归一化滤波");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("滤波", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("腐蚀");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("膨胀");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("开");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("闭");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("形态学梯度");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("顶帽");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("黑帽");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("形态", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Canny");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("边缘检测", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("霍夫直线检测");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("霍夫圆检测");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("霍夫", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37});
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnContours = new System.Windows.Forms.Button();
            this.picRaw = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGray = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxPara = new System.Windows.Forms.GroupBox();
            this.parametersControl1 = new CountPipe.ParametersControl();
            this.btnOpera = new System.Windows.Forms.Button();
            this.radioContinue = new System.Windows.Forms.RadioButton();
            this.btnRollBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOperatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.groupBoxPara.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBox
            // 
            this.pictBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictBox.Location = new System.Drawing.Point(157, 43);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(495, 336);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox.TabIndex = 5;
            this.pictBox.TabStop = false;
            // 
            // btnCount
            // 
            this.btnCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCount.Location = new System.Drawing.Point(166, 472);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "计数";
            this.btnCount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOpen.Location = new System.Drawing.Point(166, 400);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "打开图片";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnContours
            // 
            this.btnContours.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnContours.Location = new System.Drawing.Point(166, 510);
            this.btnContours.Name = "btnContours";
            this.btnContours.Size = new System.Drawing.Size(75, 23);
            this.btnContours.TabIndex = 19;
            this.btnContours.Text = "获取轮廓";
            this.btnContours.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnContours.UseVisualStyleBackColor = true;
            this.btnContours.Click += new System.EventHandler(this.btnContours_Click);
            // 
            // picRaw
            // 
            this.picRaw.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picRaw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRaw.Location = new System.Drawing.Point(658, 43);
            this.picRaw.Name = "picRaw";
            this.picRaw.Size = new System.Drawing.Size(495, 336);
            this.picRaw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRaw.TabIndex = 20;
            this.picRaw.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 43);
            this.treeView1.Name = "treeView1";
            treeNode20.Name = "节点0";
            treeNode20.Text = "灰度";
            treeNode21.Name = "节点2";
            treeNode21.Text = "高斯模糊";
            treeNode22.Name = "节点4";
            treeNode22.Text = "中值模糊";
            treeNode23.Name = "节点0";
            treeNode23.Text = "高斯双边滤波";
            treeNode24.Name = "节点1";
            treeNode24.Text = "归一化滤波";
            treeNode25.Name = "节点1";
            treeNode25.Text = "滤波";
            treeNode26.Name = "节点5";
            treeNode26.Text = "腐蚀";
            treeNode27.Name = "节点6";
            treeNode27.Text = "膨胀";
            treeNode28.Name = "节点7";
            treeNode28.Text = "开";
            treeNode29.Name = "节点8";
            treeNode29.Text = "闭";
            treeNode30.Name = "节点2";
            treeNode30.Text = "形态学梯度";
            treeNode31.Name = "节点3";
            treeNode31.Text = "顶帽";
            treeNode32.Name = "节点4";
            treeNode32.Text = "黑帽";
            treeNode33.Name = "节点3";
            treeNode33.Text = "形态";
            treeNode34.Name = "节点10";
            treeNode34.Text = "Canny";
            treeNode35.Name = "节点9";
            treeNode35.Text = "边缘检测";
            treeNode36.Name = "节点1";
            treeNode36.Text = "霍夫直线检测";
            treeNode37.Name = "节点2";
            treeNode37.Text = "霍夫圆检测";
            treeNode38.Name = "节点0";
            treeNode38.Text = "霍夫";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode25,
            treeNode33,
            treeNode35,
            treeNode38});
            this.treeView1.Size = new System.Drawing.Size(126, 506);
            this.treeView1.TabIndex = 21;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "灰度值";
            // 
            // txtGray
            // 
            this.txtGray.Location = new System.Drawing.Point(232, 431);
            this.txtGray.Name = "txtGray";
            this.txtGray.Size = new System.Drawing.Size(88, 21);
            this.txtGray.TabIndex = 6;
            this.txtGray.Text = "80";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "处理后";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "原图像";
            // 
            // groupBoxPara
            // 
            this.groupBoxPara.Controls.Add(this.parametersControl1);
            this.groupBoxPara.Location = new System.Drawing.Point(359, 400);
            this.groupBoxPara.Name = "groupBoxPara";
            this.groupBoxPara.Size = new System.Drawing.Size(408, 235);
            this.groupBoxPara.TabIndex = 24;
            this.groupBoxPara.TabStop = false;
            this.groupBoxPara.Text = "参数设置";
            // 
            // parametersControl1
            // 
            this.parametersControl1.Location = new System.Drawing.Point(17, 17);
            this.parametersControl1.Name = "parametersControl1";
            this.parametersControl1.Size = new System.Drawing.Size(376, 203);
            this.parametersControl1.TabIndex = 0;
            // 
            // btnOpera
            // 
            this.btnOpera.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOpera.Location = new System.Drawing.Point(166, 553);
            this.btnOpera.Name = "btnOpera";
            this.btnOpera.Size = new System.Drawing.Size(75, 23);
            this.btnOpera.TabIndex = 25;
            this.btnOpera.Text = "处理";
            this.btnOpera.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOpera.UseVisualStyleBackColor = true;
            this.btnOpera.Click += new System.EventHandler(this.btnOpera_Click);
            // 
            // radioContinue
            // 
            this.radioContinue.AutoSize = true;
            this.radioContinue.Location = new System.Drawing.Point(813, 406);
            this.radioContinue.Name = "radioContinue";
            this.radioContinue.Size = new System.Drawing.Size(71, 16);
            this.radioContinue.TabIndex = 26;
            this.radioContinue.TabStop = true;
            this.radioContinue.Text = "连续处理";
            this.radioContinue.UseVisualStyleBackColor = true;
            this.radioContinue.CheckedChanged += new System.EventHandler(this.radioContinue_CheckedChanged);
            // 
            // btnRollBack
            // 
            this.btnRollBack.Location = new System.Drawing.Point(809, 440);
            this.btnRollBack.Name = "btnRollBack";
            this.btnRollBack.Size = new System.Drawing.Size(75, 23);
            this.btnRollBack.TabIndex = 27;
            this.btnRollBack.Text = "回退";
            this.btnRollBack.UseVisualStyleBackColor = true;
            this.btnRollBack.Click += new System.EventHandler(this.btnRollBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 661);
            this.Controls.Add(this.btnRollBack);
            this.Controls.Add(this.radioContinue);
            this.Controls.Add(this.btnOpera);
            this.Controls.Add(this.groupBoxPara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.picRaw);
            this.Controls.Add(this.btnContours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGray);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOperatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.groupBoxPara.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnContours;
        private System.Windows.Forms.PictureBox picRaw;
        private System.Windows.Forms.BindingSource dataSetOperatorBindingSource;
     
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGray;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxPara;
        private ParametersControl parametersControl1;
        private System.Windows.Forms.Button btnOpera;
        private System.Windows.Forms.RadioButton radioContinue;
        private System.Windows.Forms.Button btnRollBack;
    }
}