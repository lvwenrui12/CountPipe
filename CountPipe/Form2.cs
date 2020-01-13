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
        //原始
       public Mat rawImg;
        //灰度后结果
        public Mat grayImg;
        //滤波后结果
        public Mat blurImg;
        //边缘检测
        public Mat edgeImg;

        public PictrueHelper pictrueHelper;

        public Form2()
        {
            InitializeComponent();
          
            pictrueHelper = new PictrueHelper();
            pictrueHelper.pictureBox = this.pictBox;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var filename = pictrueHelper.OpenfileDlg();
                if (filename != null && filename != "")
                {
                    picRaw.Load(filename);
                   
                    Mat img = Cv2.ImRead(filename);
                     rawImg = img.Clone();
                    pictrueHelper.showPic(img);

                }

            }
            catch (Exception ex)
            {
                log.Error("btnOpen_Click " + ex.Message);

            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                //灰度
                if (rawImg != null)
                {

                    double dvalue = 0;
                    double.TryParse(txtGray.Text, out dvalue);
                    if (dvalue == 0)
                    {
                        dvalue = 10;
                    }

                    pictrueHelper.Tobinimg_inv(rawImg, dvalue, out grayImg);
                }

                //滤波

                //double length = 0;
                //double.TryParse(txtBlurLeng.Text, out length);
                //if (length == 0)
                //{
                //    length = 10;
                //}
                //double width = 0;
                //double.TryParse(txtBlurWidth.Text, out width);
                //if (width == 0)
                //{
                //    width = 10;
                //}

                //OpenCvSharp.Size size = new OpenCvSharp.Size(width, length);
                //if (grayImg != null)
                //{
                //    pictrueHelper.GetBlurImg(grayImg, size, out blurImg);

                //}







            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

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

     

 

        private void btnContours_Click(object sender, EventArgs e)
        {
            OpenCvSharp.Point[][] contours;
            pictrueHelper.GetContours(edgeImg,out contours);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "灰度")
            {
                GrapFrm grapFrm = new GrapFrm(this);
                grapFrm.Show();
                this.Enabled = false;
               
            }

            if (e.Node.Text == "高斯模糊")
            {
                GuaseBlurFrm guaseFrm = new GuaseBlurFrm(this);
                guaseFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "中值模糊")
            {
                MedianBlurFrm guaseFrm = new MedianBlurFrm(this);
                guaseFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "高斯双边滤波")
            {
                BilateralBlurFrm bilateralFrm = new BilateralBlurFrm(this);
                bilateralFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "归一化滤波")
            {
                NormalizedBlurFrm normalizedFrm = new NormalizedBlurFrm(this);
                normalizedFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "膨胀")
            {
                DilateFrm dilateFrm = new DilateFrm(this);
                dilateFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "腐蚀")
            {
                ErodeFrm enrodeFrm = new ErodeFrm(this);
                enrodeFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "开")
            {
                OpenFrm openFrm = new OpenFrm(this);
                openFrm.Show();
                this.Enabled = false;

            }

            if (e.Node.Text == "闭")
            {
                CloseFrm openFrm = new CloseFrm(this);
                openFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "形态学梯度")
            {
                GradientFrm openFrm = new GradientFrm(this);
                openFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "顶帽")
            {
                TopHatFrm topHatFrm = new TopHatFrm(this);
                topHatFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "黑帽")
            {
                BlackHatFrm blackHatFrm = new BlackHatFrm(this);
                blackHatFrm.Show();
                this.Enabled = false;

            }
            if (e.Node.Text == "Canny")
            {
                CannyFrm blackHatFrm = new CannyFrm(this);
                blackHatFrm.Show();
                this.Enabled = false;

            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }



}
