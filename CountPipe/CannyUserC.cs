using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountPipe
{
    public partial class CannyUserC : CountPipe.ParametersControl
    {
        public CannyUserC()
        {
            InitializeComponent();
        }
        public String getThreshold1()
        {
            return txtEdgeThresHoldOne.Text;
        }
        public String getThreshold2()
        {
            return txtEdgeThresHoldTwo.Text;
        }
    }
}
