using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountPipe
{
    public partial class GrayUserC : CountPipe.ParametersControl
    {
        public GrayUserC()
        {
            InitializeComponent();
        }
        public String getGrayThreshold()
        {
            return txtGray.Text;
        }
    }
}
