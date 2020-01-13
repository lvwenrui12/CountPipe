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
    public partial class MedianBlurFrm : Form
    {
       

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); 
        Form2 parentForm;
        private PictrueHelper pictrueHelper=new PictrueHelper();
        public MedianBlurFrm(Form2 form)
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
                 
                    int.TryParse(txtSize.Text, out size);

                    if (size % 2 == 0 || size == 1)
                    {
                        MessageBox.Show("请输入大于1的奇数");
                        return;
                    }
                    if (size == 0)
                    {
                        size = 5;
                    }
                    
                    Mat blurImg;
                    pictrueHelper.MedianBlurImg(parentForm.rawImg, size, out blurImg);
                    parentForm.pictrueHelper.showPic(blurImg);
                   
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error("gray fail " + ex.Message);
                
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
