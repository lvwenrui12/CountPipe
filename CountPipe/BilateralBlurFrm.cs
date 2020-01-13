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
    public partial class BilateralBlurFrm: Form
    {
       

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); 
        Form2 parentForm;
        private PictrueHelper pictrueHelper=new PictrueHelper();
        public BilateralBlurFrm(Form2 form)
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

                   
                    int d;
                    double sigmaColor;
                    double sigmaSpace;
                
                    int.TryParse(txtDiameter.Text, out d);
                    double.TryParse(txtSigmaColor.Text, out sigmaColor);
                    double.TryParse(txtSigmaSpace.Text, out sigmaSpace);
                   
                    Mat bilateralBlurImg;
                    pictrueHelper.BilateralBlurImg(parentForm.rawImg, d, sigmaColor, sigmaSpace, out bilateralBlurImg);
                    parentForm.pictrueHelper.showPic(bilateralBlurImg);
                   
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error("BilateralBlurImg fail " + ex.Message);
               
            }

        }

        private void GrapFrm_Load(object sender, EventArgs e)
        {

        }

        private void GuaseBlurFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
