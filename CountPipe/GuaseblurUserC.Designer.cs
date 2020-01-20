namespace CountPipe
{
    partial class GuaseblurUserC
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigmaY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigmaX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "标准差Y";
            // 
            // txtSigmaY
            // 
            this.txtSigmaY.Location = new System.Drawing.Point(147, 103);
            this.txtSigmaY.Name = "txtSigmaY";
            this.txtSigmaY.Size = new System.Drawing.Size(88, 21);
            this.txtSigmaY.TabIndex = 20;
            this.txtSigmaY.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "标准差X";
            // 
            // txtSigmaX
            // 
            this.txtSigmaX.Location = new System.Drawing.Point(147, 71);
            this.txtSigmaX.Name = "txtSigmaX";
            this.txtSigmaX.Size = new System.Drawing.Size(88, 21);
            this.txtSigmaX.TabIndex = 18;
            this.txtSigmaX.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "卷积核(奇数)";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(147, 33);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(88, 21);
            this.txtSize.TabIndex = 16;
            this.txtSize.Text = "3";
            // 
            // GuaseblurUserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSigmaY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSigmaX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSize);
            this.Name = "GuaseblurUserC";
            this.Size = new System.Drawing.Size(293, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSigmaY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSigmaX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSize;
    }
}
