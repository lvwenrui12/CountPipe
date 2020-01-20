namespace CountPipe
{
    partial class BilateralBlurUserC
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
            this.txtSigmaSpace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigmaColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "像素空间";
            // 
            // txtSigmaSpace
            // 
            this.txtSigmaSpace.Location = new System.Drawing.Point(140, 104);
            this.txtSigmaSpace.Name = "txtSigmaSpace";
            this.txtSigmaSpace.Size = new System.Drawing.Size(88, 21);
            this.txtSigmaSpace.TabIndex = 20;
            this.txtSigmaSpace.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "像素颜色差值";
            // 
            // txtSigmaColor
            // 
            this.txtSigmaColor.Location = new System.Drawing.Point(140, 72);
            this.txtSigmaColor.Name = "txtSigmaColor";
            this.txtSigmaColor.Size = new System.Drawing.Size(88, 21);
            this.txtSigmaColor.TabIndex = 18;
            this.txtSigmaColor.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "半径";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(140, 34);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(88, 21);
            this.txtDiameter.TabIndex = 16;
            this.txtDiameter.Text = "3";
            // 
            // BilateralBlurUserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSigmaSpace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSigmaColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiameter);
            this.Name = "BilateralBlurUserC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSigmaSpace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSigmaColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiameter;
    }
}
