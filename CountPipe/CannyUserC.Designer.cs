namespace CountPipe
{
    partial class CannyUserC
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
            this.txtEdgeThresHoldTwo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdgeThresHoldOne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEdgeThresHoldTwo
            // 
            this.txtEdgeThresHoldTwo.Location = new System.Drawing.Point(217, 87);
            this.txtEdgeThresHoldTwo.Name = "txtEdgeThresHoldTwo";
            this.txtEdgeThresHoldTwo.Size = new System.Drawing.Size(73, 21);
            this.txtEdgeThresHoldTwo.TabIndex = 26;
            this.txtEdgeThresHoldTwo.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "阈值二（下限阈值的三倍或二倍）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "阈值一";
            // 
            // txtEdgeThresHoldOne
            // 
            this.txtEdgeThresHoldOne.Location = new System.Drawing.Point(217, 51);
            this.txtEdgeThresHoldOne.Name = "txtEdgeThresHoldOne";
            this.txtEdgeThresHoldOne.Size = new System.Drawing.Size(73, 21);
            this.txtEdgeThresHoldOne.TabIndex = 23;
            this.txtEdgeThresHoldOne.Text = "100";
            // 
            // CannyUserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.txtEdgeThresHoldTwo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEdgeThresHoldOne);
            this.Name = "CannyUserC";
            this.Size = new System.Drawing.Size(304, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEdgeThresHoldTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdgeThresHoldOne;
    }
}
