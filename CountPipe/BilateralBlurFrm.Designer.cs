namespace CountPipe
{
    partial class BilateralBlurFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigmaColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigmaSpace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "半径";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(150, 77);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(88, 21);
            this.txtDiameter.TabIndex = 8;
            this.txtDiameter.Text = "3";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(322, 193);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "像素颜色差值";
            // 
            // txtSigmaColor
            // 
            this.txtSigmaColor.Location = new System.Drawing.Point(150, 115);
            this.txtSigmaColor.Name = "txtSigmaColor";
            this.txtSigmaColor.Size = new System.Drawing.Size(88, 21);
            this.txtSigmaColor.TabIndex = 12;
            this.txtSigmaColor.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "像素空间";
            // 
            // txtSigmaSpace
            // 
            this.txtSigmaSpace.Location = new System.Drawing.Point(150, 147);
            this.txtSigmaSpace.Name = "txtSigmaSpace";
            this.txtSigmaSpace.Size = new System.Drawing.Size(88, 21);
            this.txtSigmaSpace.TabIndex = 14;
            this.txtSigmaSpace.Text = "3";
            // 
            // BilateralBlurFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSigmaSpace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSigmaColor);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiameter);
            this.Name = "BilateralBlurFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高斯双边滤波参数设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BilateralBlurFrm_FormClosed);
            this.Load += new System.EventHandler(this.BilateralBlurFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSigmaColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSigmaSpace;
    }
}