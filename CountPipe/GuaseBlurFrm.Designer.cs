namespace CountPipe
{
    partial class GuaseBlurFrm
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
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigmaX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigmaY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "卷积核(奇数)";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(150, 77);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(88, 21);
            this.txtSize.TabIndex = 8;
            this.txtSize.Text = "3";
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
            this.label2.Location = new System.Drawing.Point(79, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "标准差X";
            // 
            // txtSigmaX
            // 
            this.txtSigmaX.Location = new System.Drawing.Point(150, 115);
            this.txtSigmaX.Name = "txtSigmaX";
            this.txtSigmaX.Size = new System.Drawing.Size(88, 21);
            this.txtSigmaX.TabIndex = 12;
            this.txtSigmaX.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "标准差Y";
            // 
            // txtSigmaY
            // 
            this.txtSigmaY.Location = new System.Drawing.Point(150, 147);
            this.txtSigmaY.Name = "txtSigmaY";
            this.txtSigmaY.Size = new System.Drawing.Size(88, 21);
            this.txtSigmaY.TabIndex = 14;
            this.txtSigmaY.Text = "3";
            // 
            // GuaseBlurFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSigmaY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSigmaX);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSize);
            this.Name = "GuaseBlurFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高斯模糊参数设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuaseBlurFrm_FormClosed);
            this.Load += new System.EventHandler(this.GrapFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSigmaX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSigmaY;
    }
}