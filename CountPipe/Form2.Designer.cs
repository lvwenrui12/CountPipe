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
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.textBox_ThreshValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGray = new System.Windows.Forms.Button();
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
            // textBox_ThreshValue
            // 
            this.textBox_ThreshValue.Location = new System.Drawing.Point(601, 160);
            this.textBox_ThreshValue.Name = "textBox_ThreshValue";
            this.textBox_ThreshValue.Size = new System.Drawing.Size(88, 21);
            this.textBox_ThreshValue.TabIndex = 6;
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
            this.btnGray.Location = new System.Drawing.Point(707, 158);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 8;
            this.btnGray.Text = "灰度";
            this.btnGray.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 433);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ThreshValue);
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
        private System.Windows.Forms.TextBox textBox_ThreshValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGray;
    }
}