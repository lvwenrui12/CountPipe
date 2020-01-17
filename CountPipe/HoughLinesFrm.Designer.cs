﻿namespace CountPipe
{
    partial class HoughLinesFrm
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
            this.txtRho = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinLineLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxLineGap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "累加器的距离分辨率(以像素为单位)";
            // 
            // txtRho
            // 
            this.txtRho.Location = new System.Drawing.Point(272, 52);
            this.txtRho.Name = "txtRho";
            this.txtRho.Size = new System.Drawing.Size(88, 21);
            this.txtRho.TabIndex = 8;
            this.txtRho.Text = "1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(340, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(442, 341);
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
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "累加器的角度分辨率(以弧度为单位)";
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(272, 94);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.Size = new System.Drawing.Size(88, 21);
            this.txtTheta.TabIndex = 13;
            this.txtTheta.Text = "1";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(272, 131);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(88, 21);
            this.txtThreshold.TabIndex = 15;
            this.txtThreshold.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "累加器阈值";
            // 
            // txtMinLineLength
            // 
            this.txtMinLineLength.Location = new System.Drawing.Point(272, 167);
            this.txtMinLineLength.Name = "txtMinLineLength";
            this.txtMinLineLength.Size = new System.Drawing.Size(88, 21);
            this.txtMinLineLength.TabIndex = 17;
            this.txtMinLineLength.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "最小线段是有几个像素组成";
            // 
            // txtMaxLineGap
            // 
            this.txtMaxLineGap.Location = new System.Drawing.Point(272, 208);
            this.txtMaxLineGap.Name = "txtMaxLineGap";
            this.txtMaxLineGap.Size = new System.Drawing.Size(88, 21);
            this.txtMaxLineGap.TabIndex = 19;
            this.txtMaxLineGap.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "同一条线上的点之间连接它们的最大允许间隙";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "线条颜色";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(272, 252);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(88, 25);
            this.btnColor.TabIndex = 22;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // HoughLinesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 430);
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
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRho);
            this.Name = "HoughLinesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "霍夫直线检测参数设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenFrm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRho;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinLineLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxLineGap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnColor;
    }
}