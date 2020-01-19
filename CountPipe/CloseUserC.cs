using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountPipe
{
    public partial class CloseUserC : CountPipe.ParametersControl
    {
       
        public CloseUserC()
        {
         
            InitializeComponent();
        
        }
       
        public String getSize()
        {
            return this.txtSize.Text;
        }

    }
}
