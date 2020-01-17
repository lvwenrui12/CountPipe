namespace CountPipe
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("灰度");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("高斯模糊");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("中值模糊");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("高斯双边滤波");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("归一化滤波");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("滤波", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("腐蚀");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("膨胀");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("开");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("闭");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("形态学梯度");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("顶帽");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("黑帽");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("形态", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Canny");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("边缘检测", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("霍夫直线检测");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("霍夫圆检测");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("霍夫", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
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
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOperatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBox
            // 
            this.pictBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictBox.Location = new System.Drawing.Point(157, 33);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(495, 336);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox.TabIndex = 5;
            this.pictBox.TabStop = false;
            // 
            // btnCount
            // 
            this.btnCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCount.Location = new System.Drawing.Point(416, 392);
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
            this.btnOpen.Location = new System.Drawing.Point(166, 390);
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
            this.btnContours.Location = new System.Drawing.Point(508, 553);
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
            this.picRaw.Location = new System.Drawing.Point(683, 33);
            this.picRaw.Name = "picRaw";
            this.picRaw.Size = new System.Drawing.Size(495, 336);
            this.picRaw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRaw.TabIndex = 20;
            this.picRaw.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 33);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "灰度";
            treeNode2.Name = "节点2";
            treeNode2.Text = "高斯模糊";
            treeNode3.Name = "节点4";
            treeNode3.Text = "中值模糊";
            treeNode4.Name = "节点0";
            treeNode4.Text = "高斯双边滤波";
            treeNode5.Name = "节点1";
            treeNode5.Text = "归一化滤波";
            treeNode6.Name = "节点1";
            treeNode6.Text = "滤波";
            treeNode7.Name = "节点5";
            treeNode7.Text = "腐蚀";
            treeNode8.Name = "节点6";
            treeNode8.Text = "膨胀";
            treeNode9.Name = "节点7";
            treeNode9.Text = "开";
            treeNode10.Name = "节点8";
            treeNode10.Text = "闭";
            treeNode11.Name = "节点2";
            treeNode11.Text = "形态学梯度";
            treeNode12.Name = "节点3";
            treeNode12.Text = "顶帽";
            treeNode13.Name = "节点4";
            treeNode13.Text = "黑帽";
            treeNode14.Name = "节点3";
            treeNode14.Text = "形态";
            treeNode15.Name = "节点10";
            treeNode15.Text = "Canny";
            treeNode16.Name = "节点9";
            treeNode16.Text = "边缘检测";
            treeNode17.Name = "节点1";
            treeNode17.Text = "霍夫直线检测";
            treeNode18.Name = "节点2";
            treeNode18.Text = "霍夫圆检测";
            treeNode19.Name = "节点0";
            treeNode19.Text = "霍夫";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode14,
            treeNode16,
            treeNode19});
            this.treeView1.Size = new System.Drawing.Size(126, 543);
            this.treeView1.TabIndex = 21;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "灰度值";
            // 
            // txtGray
            // 
            this.txtGray.Location = new System.Drawing.Point(268, 392);
            this.txtGray.Name = "txtGray";
            this.txtGray.Size = new System.Drawing.Size(88, 21);
            this.txtGray.TabIndex = 6;
            this.txtGray.Text = "80";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "处理后";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(695, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "原图像";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 661);
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
    }
}