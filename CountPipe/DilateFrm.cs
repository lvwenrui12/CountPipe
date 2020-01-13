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
    public partial class DilateFrm : Form
    {
       

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); 
        Form2 parentForm;
        private PictrueHelper pictrueHelper=new PictrueHelper();
        public DilateFrm(Form2 form)
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
                    if (size % 2 == 0)
                    {
                        MessageBox.Show("请输入奇数");
                        return;
                    }

                    InputArray element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(size, size), new OpenCvSharp.Point(-1, -1));



                    Mat dilateImg;
                    pictrueHelper.Dilate(parentForm.rawImg, element,out dilateImg);
                    parentForm.pictrueHelper.showPic(dilateImg);
                   
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error("dilateImg fail " + ex.Message);
                MessageBox.Show(ex.Message);
                
            }

        }

    

        private void DilateFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
