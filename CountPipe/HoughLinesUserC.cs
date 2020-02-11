using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountPipe
{
    public partial class HoughLinesUserC : CountPipe.ParametersControl
    {
        public HoughLinesUserC()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDia = new ColorDialog();

            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Color colorChoosed = colorDia.Color;
                //改变panel的背景色
                btnColor.BackColor = colorChoosed;

            }
        }

        public String getRho()
        {
            return this.txtRho.Text;
        }
        public String getTheta()
        {
            return this.txtTheta.Text;
        }

        public String getThreshold()
        {
            return this.txtThreshold.Text;
        }

        public String getMinLineLength()
        {
            return this.txtMinLineLength.Text;
        }

        public String getMaxLineGap()
        {
            return this.txtMaxLineGap.Text;
        }

        public Color getColor()
        {
            return btnColor.BackColor;
        }


    }
}
