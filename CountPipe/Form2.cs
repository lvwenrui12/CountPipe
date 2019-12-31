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
    public partial class Form2 : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); //Logging 名
        Mat rawimg;

        SharpWindows imgwindow;

      


        public Form2()
        {
            InitializeComponent();
            imgwindow = new SharpWindows(this.pictBox, "MainUIwindow");
        }

   

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var filename = PictrueHelper.OpenfileDlg();
                if (filename != null && filename != "")
                {
                    Mat img = Cv2.ImRead(filename);
                    imgwindow.Showimg(img);
                    rawimg = img.Clone();
                    img.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (rawimg != null)
                {
                    Mat binimg;
                    Tobinimg_inv(rawimg, out binimg);
                    ////转灰度
                    //Mat grayimg;
                    //if (rawimg.Channels() == 3)
                    //{
                    //    grayimg = rawimg.CvtColor(ColorConversionCodes.BGR2GRAY);

                    //}
                    //else
                    //{
                    //    grayimg = rawimg.Clone();
                    //}
                    //imgwindow.Showimg(grayimg);
                    ////bin
                    //double dvalue = 0;
                    //double.TryParse(textBox_ThreshValue.Text, out dvalue);
                    //if (dvalue == 0)
                    //{
                    //    dvalue = 10;
                    //}

                    // binimg = grayimg.Threshold(dvalue, 255, ThresholdTypes.Binary);


                    //imgwindow.Showimg(binimg);
                    //grayimg.Dispose();
                    //binimg.Dispose();

                }

                //if (onecontours.Count == 1)
                //{
                //    Point2f cp;
                //    float r;
                //    Cv2.MinEnclosingCircle(onecontours[0], out cp, out r);
                //    //
                //    Mat backimg = img.Clone();
                //    Cv2.Circle(backimg, new OpenCvSharp.Point(cp.X, cp.Y), (int)r, Scalar.Red);
                //    Imgwindow.Showimg(backimg);
                //    backimg.Dispose();
                //}

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        private void Tobinimg_inv(Mat inimg, out Mat binimg)
        {
            binimg = new Mat();
            try
            {

                if (inimg != null)
                {
                    //转灰度
                    Mat grayimg;
                    if (inimg.Channels() == 3)
                    {
                        grayimg = inimg.CvtColor(ColorConversionCodes.BGR2GRAY);

                    }
                    else
                    {
                        grayimg = inimg.Clone();
                    }
                    imgwindow.Showimg(grayimg);
                    //bin
                    double dvalue = 0;
                    double.TryParse(textBox_ThreshValue.Text, out dvalue);
                    if (dvalue == 0)
                    {
                        dvalue = 10;
                    }

                    binimg = grayimg.Threshold(dvalue, 255, ThresholdTypes.BinaryInv);
                    imgwindow.Showimg(binimg);
                    grayimg.Dispose();
                    // binimg.Dispose();

                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 通过矩形选择contours
        /// </summary>
        /// <param name="contours"></param>
        /// <param name="Minvaluelow"></param>
        /// <param name="Minvalueup"></param>
        /// <param name="Maxvaluelow"></param>
        /// <param name="Maxvalueup"></param>
        /// <returns></returns>
        public List<OpenCvSharp.Point[]> SelectContoursByRect(Mat binimg, double Minvaluelow, double Minvalueup, double Maxvaluelow, double Maxvalueup)
        {
            OpenCvSharp.Point[][] contours;
            HierarchyIndex[] hierarchy;
            Cv2.FindContours(binimg, out contours, out hierarchy, RetrievalModes.CComp, ContourApproximationModes.ApproxSimple);
            List<OpenCvSharp.Point[]> Resultcontours = new List<OpenCvSharp.Point[]>();
            int L = contours.Length;
            for (int i = 0; i < L; i++)
            {
                Rect recttemp = Cv2.BoundingRect(contours[i]);
                double Hmin, Wmax;
                Hmin = Math.Min(recttemp.Width, recttemp.Height);
                Wmax = Math.Max(recttemp.Width, recttemp.Height);
                if (Hmin > Minvaluelow && Hmin < Minvalueup && Wmax > Maxvaluelow && Wmax < Maxvalueup)
                {
                    //满足指定要求的contours
                    Resultcontours.Add(contours[i]);
                }
            }
            return Resultcontours;
        }

        private List<OpenCvSharp.Point[]> SelectContoursByRectPos(List<OpenCvSharp.Point[]> inputcontours, int pos)
        {
            List<OpenCvSharp.Point[]> resultpoints = new List<OpenCvSharp.Point[]>();
            try
            {

                List<float> colposition = new List<float>();
                for (int i = 0; i < inputcontours.Count; i++)
                {
                    Point2f cp;
                    float r;
                    Cv2.MinEnclosingCircle(inputcontours[i], out cp, out r);

                    colposition.Add(cp.X);
                }
                int Right = colposition.IndexOf(colposition.Max());
                int Left = colposition.IndexOf(colposition.Min());
                int Middle = 3 - Right - Left;
                switch (pos)
                {
                    case 0:
                        //左侧
                        resultpoints.Add(inputcontours[Left]);
                        break;
                    case 1:
                        resultpoints.Add(inputcontours[Middle]);
                        //中间
                        break;
                    case 2:
                        resultpoints.Add(inputcontours[Right]);
                        //右侧
                        break;
                    default:
                        break;

                }
                return resultpoints;
            }
            catch (Exception ex)
            {
                return resultpoints;
                throw (ex);

            }

        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            try
            {
                if (rawimg != null)
                {
                    Mat binimg;
                    double dvalue = 0;
                    double.TryParse(textBox_ThreshValue.Text, out dvalue);
                    if (dvalue == 0)
                    {
                        dvalue = 10;
                    }

                    PictrueHelper.Tobinimg_inv(rawimg, dvalue, out binimg);
                }
            }
            catch (Exception ex)
            {
                log.Error("gray fail "+ex.Message);
                throw (ex);
            }
        }
    }


   
}
