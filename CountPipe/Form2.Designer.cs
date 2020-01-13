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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("滤波", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("腐蚀");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("膨胀");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("开");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("闭");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("形态", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("candy");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("边缘检测", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBlurLeng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBlurWidth = new System.Windows.Forms.TextBox();
            this.txtEdgeThresHoldTwo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdgeDete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdgeThresHoldOne = new System.Windows.Forms.TextBox();
            this.btnContours = new System.Windows.Forms.Button();
            this.picRaw = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGray = new System.Windows.Forms.TextBox();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.btnCount.Location = new System.Drawing.Point(427, 437);
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
            // btnBlur
            // 
            this.btnBlur.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBlur.Location = new System.Drawing.Point(427, 504);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(75, 23);
            this.btnBlur.TabIndex = 11;
            this.btnBlur.Text = "滤波";
            this.btnBlur.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "长";
            // 
            // txtBlurLeng
            // 
            this.txtBlurLeng.Location = new System.Drawing.Point(211, 506);
            this.txtBlurLeng.Name = "txtBlurLeng";
            this.txtBlurLeng.Size = new System.Drawing.Size(73, 21);
            this.txtBlurLeng.TabIndex = 9;
            this.txtBlurLeng.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "宽";
            // 
            // txtBlurWidth
            // 
            this.txtBlurWidth.Location = new System.Drawing.Point(337, 506);
            this.txtBlurWidth.Name = "txtBlurWidth";
            this.txtBlurWidth.Size = new System.Drawing.Size(73, 21);
            this.txtBlurWidth.TabIndex = 13;
            this.txtBlurWidth.Text = "3";
            // 
            // txtEdgeThresHoldTwo
            // 
            this.txtEdgeThresHoldTwo.Location = new System.Drawing.Point(337, 555);
            this.txtEdgeThresHoldTwo.Name = "txtEdgeThresHoldTwo";
            this.txtEdgeThresHoldTwo.Size = new System.Drawing.Size(73, 21);
            this.txtEdgeThresHoldTwo.TabIndex = 18;
            this.txtEdgeThresHoldTwo.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "阈值二";
            // 
            // btnEdgeDete
            // 
            this.btnEdgeDete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEdgeDete.Location = new System.Drawing.Point(427, 553);
            this.btnEdgeDete.Name = "btnEdgeDete";
            this.btnEdgeDete.Size = new System.Drawing.Size(75, 23);
            this.btnEdgeDete.TabIndex = 16;
            this.btnEdgeDete.Text = "边缘检测";
            this.btnEdgeDete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEdgeDete.UseVisualStyleBackColor = true;
            this.btnEdgeDete.Click += new System.EventHandler(this.btnEdgeDete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "阈值一";
            // 
            // txtEdgeThresHoldOne
            // 
            this.txtEdgeThresHoldOne.Location = new System.Drawing.Point(211, 555);
            this.txtEdgeThresHoldOne.Name = "txtEdgeThresHoldOne";
            this.txtEdgeThresHoldOne.Size = new System.Drawing.Size(73, 21);
            this.txtEdgeThresHoldOne.TabIndex = 14;
            this.txtEdgeThresHoldOne.Text = "100";
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
            treeNode4.Name = "节点1";
            treeNode4.Text = "滤波";
            treeNode5.Name = "节点5";
            treeNode5.Text = "腐蚀";
            treeNode6.Name = "节点6";
            treeNode6.Text = "膨胀";
            treeNode7.Name = "节点7";
            treeNode7.Text = "开";
            treeNode8.Name = "节点8";
            treeNode8.Text = "闭";
            treeNode9.Name = "节点3";
            treeNode9.Text = "形态";
            treeNode10.Name = "节点10";
            treeNode10.Text = "candy";
            treeNode11.Name = "节点9";
            treeNode11.Text = "边缘检测";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode9,
            treeNode11});
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
            this.Controls.Add(this.txtEdgeThresHoldTwo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEdgeDete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEdgeThresHoldOne);
            this.Controls.Add(this.txtBlurWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBlur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBlurLeng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGray);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form2";
            this.Text = "Form2";
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
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBlurLeng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBlurWidth;
        private System.Windows.Forms.TextBox txtEdgeThresHoldTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdgeDete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdgeThresHoldOne;
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