using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountPipe
{
    public partial class GrapFrm : Form
    {
       

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); 
        Form2 parentForm;
        private PictrueHelper pictrueHelper=new PictrueHelper();
        public GrapFrm(Form2 form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (parentForm.rawImg != null)
                {

                    double dvalue = 0;
                    double.TryParse(txtGray.Text, out dvalue);
                    if (dvalue == 0)
                    {
                        dvalue = 10;
                    }
                    Mat grayImg;
                    pictrueHelper.Tobinimg_inv(parentForm.rawImg, dvalue, out grayImg);
                
                    parentForm.Enabled = true;
                  
                    parentForm.pictrueHelper.showPic(grayImg);
                   
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error("gray fail " + ex.Message);
                throw (ex);
            }

        }

        private void GrapFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
