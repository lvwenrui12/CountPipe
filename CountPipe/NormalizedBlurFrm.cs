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
    public partial class NormalizedBlurFrm : Form
    {
       

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); 
        Form2 parentForm;
        private PictrueHelper pictrueHelper=new PictrueHelper();
        public NormalizedBlurFrm(Form2 form)
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

                    int width = 0;
                 
                    int.TryParse(txtWidth.Text, out width);

                    int height;
                    int.TryParse(txtHeight.Text, out height);

                    Mat blurImg;
                    pictrueHelper.BlurImg(parentForm.rawImg, width,height,-1,-1, out blurImg);
                    parentForm.pictrueHelper.showPic(blurImg);
                   
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error("BlurImg fail " + ex.Message);
                MessageBox.Show(ex.Message);
                
            }

        }

        
        private void NormalizedBlurFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
