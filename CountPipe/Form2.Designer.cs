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
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtGray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGray = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBox
            // 
            this.pictBox.Location = new System.Drawing.Point(32, 33);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(495, 336);
            this.pictBox.TabIndex = 5;
            this.pictBox.TabStop = false;
            // 
            // btnCount
            // 
            this.btnCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCount.Location = new System.Drawing.Point(547, 109);
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
            this.btnOpen.Location = new System.Drawing.Point(547, 42);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "打开图片";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtGray
            // 
            this.txtGray.Location = new System.Drawing.Point(601, 160);
            this.txtGray.Name = "txtGray";
            this.txtGray.Size = new System.Drawing.Size(88, 21);
            this.txtGray.TabIndex = 6;
            this.txtGray.Text = "80";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "灰度值";
            // 
            // btnGray
            // 
            this.btnGray.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGray.Location = new System.Drawing.Point(817, 158);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 8;
            this.btnGray.Text = "灰度";
            this.btnGray.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBlur.Location = new System.Drawing.Point(817, 203);
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
            this.label2.Location = new System.Drawing.Point(554, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "长";
            // 
            // txtBlurLeng
            // 
            this.txtBlurLeng.Location = new System.Drawing.Point(601, 205);
            this.txtBlurLeng.Name = "txtBlurLeng";
            this.txtBlurLeng.Size = new System.Drawing.Size(73, 21);
            this.txtBlurLeng.TabIndex = 9;
            this.txtBlurLeng.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "宽";
            // 
            // txtBlurWidth
            // 
            this.txtBlurWidth.Location = new System.Drawing.Point(727, 205);
            this.txtBlurWidth.Name = "txtBlurWidth";
            this.txtBlurWidth.Size = new System.Drawing.Size(73, 21);
            this.txtBlurWidth.TabIndex = 13;
            this.txtBlurWidth.Text = "3";
            // 
            // txtEdgeThresHoldTwo
            // 
            this.txtEdgeThresHoldTwo.Location = new System.Drawing.Point(727, 254);
            this.txtEdgeThresHoldTwo.Name = "txtEdgeThresHoldTwo";
            this.txtEdgeThresHoldTwo.Size = new System.Drawing.Size(73, 21);
            this.txtEdgeThresHoldTwo.TabIndex = 18;
            this.txtEdgeThresHoldTwo.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "阈值二";
            // 
            // btnEdgeDete
            // 
            this.btnEdgeDete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEdgeDete.Location = new System.Drawing.Point(817, 252);
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
            this.label5.Location = new System.Drawing.Point(554, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "阈值一";
            // 
            // txtEdgeThresHoldOne
            // 
            this.txtEdgeThresHoldOne.Location = new System.Drawing.Point(601, 254);
            this.txtEdgeThresHoldOne.Name = "txtEdgeThresHoldOne";
            this.txtEdgeThresHoldOne.Size = new System.Drawing.Size(73, 21);
            this.txtEdgeThresHoldOne.TabIndex = 14;
            this.txtEdgeThresHoldOne.Text = "100";
            // 
            // btnContours
            // 
            this.btnContours.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnContours.Location = new System.Drawing.Point(898, 252);
            this.btnContours.Name = "btnContours";
            this.btnContours.Size = new System.Drawing.Size(75, 23);
            this.btnContours.TabIndex = 19;
            this.btnContours.Text = "获取轮廓";
            this.btnContours.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnContours.UseVisualStyleBackColor = true;
            this.btnContours.Click += new System.EventHandler(this.btnContours_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 449);
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
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGray);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtGray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGray;
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
    }
}