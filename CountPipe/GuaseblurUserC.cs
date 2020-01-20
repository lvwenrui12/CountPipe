using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountPipe
{
    public partial class GuaseblurUserC : CountPipe.ParametersControl
    {
        public GuaseblurUserC()
        {
            InitializeComponent();
        }
        public String getSize()
        {
            return this.txtSize.Text;
        }
        public String getSigmaX()
        {
            return this.txtSigmaX.Text;
        }
        public String getSigmaY()
        {
            return this.txtSigmaY.Text;
        }
    }
}
