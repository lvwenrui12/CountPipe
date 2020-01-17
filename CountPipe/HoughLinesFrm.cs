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
    public partial class HoughLinesFrm : Form
    {
       

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); 
        Form2 parentForm;
        private PictrueHelper pictrueHelper=new PictrueHelper();
        public HoughLinesFrm(Form2 form)
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
                    double rho = 0;
                 
                    double.TryParse(txtRho.Text, out rho);

                    double theta = 1;

                    double.TryParse(txtTheta.Text, out theta);
                    int threshold = 1;

                    int.TryParse(txtThreshold.Text, out threshold);

                    double minLineLength = 1;

                    double.TryParse(txtMinLineLength.Text, out minLineLength);

                    double maxLineGap = 10;

                    double.TryParse(txtMaxLineGap.Text, out maxLineGap);

                    Mat gray = new Mat();
                    Cv2.CvtColor(parentForm.rawImg, gray, ColorConversionCodes.BGR2GRAY);

                    Mat stElem = Cv2.GetStructuringElement(MorphShapes.Rect, new
               OpenCvSharp.Size(7, 7));
                    Cv2.MorphologyEx(gray, gray, MorphTypes.Open, stElem, new OpenCvSharp.Point(-1, -1), 1);//来三次次开操作把无关点滤掉
                    Mat canny = new Mat();
                    Cv2.Threshold(gray, canny, 100, 150, ThresholdTypes.Binary);//二值化
                 
                  

                   
                   
                

                    Cv2.Canny(canny, canny, 60, 200, 3, false);







                    Mat huofuLineImg;
                    LineSegmentPoint[] linePiont= pictrueHelper.HuofuLine(canny, rho, theta, threshold, out huofuLineImg,minLineLength, maxLineGap);
                
                    Scalar color = new Scalar(btnColor.BackColor.R, btnColor.BackColor.G, btnColor.BackColor.B);
                    for (int i = 0; i < linePiont.Count(); i++)
                    {
                        OpenCvSharp.Point p1 = linePiont[i].P1;
                        OpenCvSharp.Point p2 = linePiont[i].P2;
                        Cv2.Line(huofuLineImg, p1, p2, color, 1, LineTypes.Link8);
                    }
                  
                    parentForm.pictrueHelper.showPic(huofuLineImg);

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

      

        private void OpenFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

     


        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDia = new ColorDialog();

            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Color colorChoosed = colorDia.Color;
                //改变panel的背景色
                btnColor.BackColor = colorChoosed;

            }
        }
    }
}
