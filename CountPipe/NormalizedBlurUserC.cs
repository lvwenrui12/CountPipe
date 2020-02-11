using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountPipe
{
    public partial class NormalizedBlurUserC : CountPipe.ParametersControl
    {
        public NormalizedBlurUserC()
        {
            InitializeComponent();
        }

        public String getWidth()
        {
            return txtWidth.Text;
        }
        public String getHeight()
        {
            return txtHeight.Text;
        }
    }
}
