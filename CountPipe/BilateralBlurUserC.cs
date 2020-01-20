using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountPipe
{
    public partial class BilateralBlurUserC : CountPipe.ParametersControl
    {
        public BilateralBlurUserC()
        {
            InitializeComponent();
        }
        public String getDiameter()
        {
            return txtDiameter.Text;
        }
        public String getSigmaColor()
        {
            return txtSigmaColor.Text;

        }
        public String getSigmaSpace()
        {
            return txtSigmaSpace.Text;
        }
    }
}
