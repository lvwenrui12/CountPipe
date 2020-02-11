namespace CountPipe
{
    partial class HoughLinesUserC
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxLineGap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinLineLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(272, 159);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(88, 25);
            this.btnColor.TabIndex = 34;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "线条颜色";
            // 
            // txtMaxLineGap
            // 
            this.txtMaxLineGap.Location = new System.Drawing.Point(272, 129);
            this.txtMaxLineGap.Name = "txtMaxLineGap";
            this.txtMaxLineGap.Size = new System.Drawing.Size(88, 21);
            this.txtMaxLineGap.TabIndex = 32;
            this.txtMaxLineGap.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "同一条线上的点之间连接它们的最大允许间隙";
            // 
            // txtMinLineLength
            // 
            this.txtMinLineLength.Location = new System.Drawing.Point(272, 98);
            this.txtMinLineLength.Name = "txtMinLineLength";
            this.txtMinLineLength.Size = new System.Drawing.Size(88, 21);
            this.txtMinLineLength.TabIndex = 30;
            this.txtMinLineLength.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "最小线段是有几个像素组成";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(272, 69);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(88, 21);
            this.txtThreshold.TabIndex = 28;
            this.txtThreshold.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "累加器阈值";
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(272, 38);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.Size = new System.Drawing.Size(88, 21);
            this.txtTheta.TabIndex = 26;
            this.txtTheta.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "累加器的角度分辨率(以弧度为单位)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "累加器的距离分辨率(以像素为单位)";
            // 
            // txtRho
            // 
            this.txtRho.Location = new System.Drawing.Point(272, 10);
            this.txtRho.Name = "txtRho";
            this.txtRho.Size = new System.Drawing.Size(88, 21);
            this.txtRho.TabIndex = 23;
            this.txtRho.Text = "1";
            // 
            // HoughLinesUserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxLineGap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMinLineLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThreshold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTheta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRho);
            this.Name = "HoughLinesUserC";
            this.Size = new System.Drawing.Size(384, 192);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxLineGap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinLineLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRho;
    }
}
