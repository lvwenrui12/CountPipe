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
    public partial class CannyFrm : Form
    {
       

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); 
        Form2 parentForm;
        private PictrueHelper pictrueHelper=new PictrueHelper();
        public CannyFrm(Form2 form)
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
                    double thresHold1 = 0;
                    double.TryParse(txtEdgeThresHoldOne.Text, out thresHold1);
                    if (thresHold1 == 0)
                    {
                        thresHold1 = 10;
                    }
                    double thresHold2 = 0;
                    double.TryParse(txtEdgeThresHoldTwo.Text, out thresHold2);
                    if (thresHold2 == 0)
                    {
                        thresHold2 = 10;
                    }

                    Mat cannyImg;
                    pictrueHelper.CannyImg(parentForm.rawImg, thresHold1, thresHold2, out cannyImg);
                    parentForm.pictrueHelper.showPic(cannyImg);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error("CannyImg fail " + ex.Message);
                MessageBox.Show(ex.Message);
                
            }

        }

    

        private void DilateFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

      

        private void OpenFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

   
    }
}
