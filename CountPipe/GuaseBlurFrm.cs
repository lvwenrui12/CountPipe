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
    public partial class GuaseBlurFrm : Form
    {
       

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); 
        Form2 parentForm;
        private PictrueHelper pictrueHelper=new PictrueHelper();
        public GuaseBlurFrm(Form2 form)
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

                    int size = 0;
                    double sigmaX = 0;
                    double sigmaY = 0;
                    int.TryParse(txtSize.Text, out size);
                    double.TryParse(txtSigmaX.Text, out sigmaX);
                    double.TryParse(txtSigmaY.Text, out sigmaY);
                    if (size == 0)
                    {
                        size = 5;
                    }
                    if (size % 2 == 0)
                    {
                        MessageBox.Show("请输入奇数");
                        return;
                    }
                    Mat guaseImg;
                    pictrueHelper.GuaseBlurImg(parentForm.rawImg, size, sigmaX, sigmaY, out guaseImg);
                    parentForm.pictrueHelper.showPic(guaseImg);
                   
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

        private void GuaseBlurFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
