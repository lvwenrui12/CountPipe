using MaterialSkin;
using MaterialSkin.Controls;
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

        System.Drawing.Point paramPoint;

        private String seleNodeName;

        private OperaEnum curentOpera;



        public Form2()
        {
            InitializeComponent();



            pictrueHelper = new PictrueHelper(this.pictBox);

            paramPoint = this.parametersControl1.Location;



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




        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "灰度")
            {
                curentOpera = OperaEnum.Gray;
                changeParaControl(new GrayUserC(), e);
            }

            if (e.Node.Text == "高斯模糊")
            {
                curentOpera = OperaEnum.GuaseBlur;
                changeParaControl(new GuaseblurUserC(), e);

            }
            if (e.Node.Text == "中值模糊")
            {
                curentOpera = OperaEnum.Erode;
                changeParaControl(new CloseUserC(), e);

            }
            if (e.Node.Text == "高斯双边滤波")
            {
                curentOpera = OperaEnum.BilateraBlur;

                changeParaControl(new BilateralBlurUserC(), e);
            }
            if (e.Node.Text == "归一化滤波")
            {
                curentOpera = OperaEnum.NormalizedBlur;
                changeParaControl(new NormalizedBlurUserC(), e);

            }
            if (e.Node.Text == "膨胀")
            {
                curentOpera = OperaEnum.Dilate;
                changeParaControl(new CloseUserC(), e);

            }
            if (e.Node.Text == "腐蚀")
            {
                curentOpera = OperaEnum.Erode;
                changeParaControl(new CloseUserC(), e);

            }
            if (e.Node.Text == "开")
            {
                curentOpera = OperaEnum.Open;
                changeParaControl(new CloseUserC(), e);

            }

            if (e.Node.Text == "闭")
            {
                curentOpera = OperaEnum.Close;
                changeParaControl(new CloseUserC(), e);

            }
            if (e.Node.Text == "形态学梯度")
            {
                curentOpera = OperaEnum.Gradient;
                changeParaControl(new CloseUserC(), e);

            }
            if (e.Node.Text == "顶帽")
            {
                curentOpera = OperaEnum.TopHat;
                changeParaControl(new CloseUserC(), e);
            }
            if (e.Node.Text == "黑帽")
            {
                curentOpera = OperaEnum.BlackHat;
                changeParaControl(new CloseUserC(), e);

            }
            if (e.Node.Text == "Canny")
            {
                curentOpera = OperaEnum.Canny;
                changeParaControl(new CannyUserC(), e);

            }

            if (e.Node.Text == "霍夫直线检测")
            {
                curentOpera = OperaEnum.HoughLines;
                changeParaControl(new HoughLinesUserC(), e);
            }


        }

        private void changeParaControl(ParametersControl changeControl, TreeNodeMouseClickEventArgs e)
        {
            seleNodeName = e.Node.Text;

            this.groupBoxPara.Controls.Remove(parametersControl1);
            parametersControl1 = changeControl;
            parametersControl1.Location = paramPoint;

            groupBoxPara.Controls.Add(parametersControl1);
            groupBoxPara.SendToBack();
            parametersControl1.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Controls.Remove(this.parametersControl1);
            parametersControl1 = new CloseUserC();
            parametersControl1.Location = paramPoint;
            groupBoxPara.Controls.Add(parametersControl1);
            groupBoxPara.SendToBack();
            parametersControl1.BringToFront();
            this.treeView1.ExpandAll();

        }

        private void btnOpera_Click(object sender, EventArgs e)
        {
            if (curentOpera == OperaEnum.Close)
            {
                CloseUserC closeC = (CloseUserC)parametersControl1;

                morphologyOpera(closeC.getSize(), MorphTypes.Close);

            }
            if (curentOpera == OperaEnum.Open)
            {
                CloseUserC closeC = (CloseUserC)parametersControl1;
                morphologyOpera(closeC.getSize(), MorphTypes.Open);
            }
            if (curentOpera == OperaEnum.BlackHat)
            {
                CloseUserC closeC = (CloseUserC)parametersControl1;
                morphologyOpera(closeC.getSize(), MorphTypes.BlackHat);

            }
            if (curentOpera == OperaEnum.Gradient)
            {
                CloseUserC closeC = (CloseUserC)parametersControl1;
                morphologyOpera(closeC.getSize(), MorphTypes.Gradient);

            }
            if (curentOpera == OperaEnum.BilateraBlur)
            {
                try
                {
                    if (rawImg != null)
                    {
                        int d;
                        double sigmaColor;
                        double sigmaSpace;
                        BilateralBlurUserC bilateralBlurUserC = (BilateralBlurUserC)parametersControl1;

                        int.TryParse(bilateralBlurUserC.getDiameter(), out d);
                        double.TryParse(bilateralBlurUserC.getSigmaColor(), out sigmaColor);
                        double.TryParse(bilateralBlurUserC.getSigmaSpace(), out sigmaSpace);

                        Mat bilateralBlurImg;
                        pictrueHelper.BilateralBlurImg(rawImg, d, sigmaColor, sigmaSpace, out bilateralBlurImg);
                        pictrueHelper.showPic(bilateralBlurImg);


                    }
                }
                catch (Exception ex)
                {
                    log.Error("BilateralBlurImg fail " + ex.Message);

                }
            }

            if (curentOpera == OperaEnum.Canny)
            {
                CannyUserC cannyUserC = (CannyUserC)parametersControl1;


                try
                {
                    if (rawImg != null)
                    {
                        double thresHold1 = 0;
                        double.TryParse(cannyUserC.getThreshold1(), out thresHold1);
                        if (thresHold1 == 0)
                        {
                            thresHold1 = 10;
                        }
                        double thresHold2 = 0;
                        double.TryParse(cannyUserC.getThreshold2(), out thresHold2);
                        if (thresHold2 == 0)
                        {
                            thresHold2 = 10;
                        }
                        Mat cannyImg;
                        pictrueHelper.CannyImg(rawImg, thresHold1, thresHold2, out cannyImg);
                        pictrueHelper.showPic(cannyImg);

                    }
                }
                catch (Exception ex)
                {
                    log.Error("CannyImg fail " + ex.Message);
                    MessageBox.Show(ex.Message);

                }

            }

            if (curentOpera == OperaEnum.Gray)
            {
                try
                {
                    if (rawImg != null)
                    {
                        GrayUserC grayC = (GrayUserC)parametersControl1;
                        double dvalue = 0;
                        double.TryParse(grayC.getGrayThreshold(), out dvalue);
                        if (dvalue == 0)
                        {
                            dvalue = 10;
                        }
                        Mat grayImg;
                        pictrueHelper.Tobinimg_inv(rawImg, dvalue, out grayImg);
                        pictrueHelper.showPic(grayImg);



                    }
                }
                catch (Exception ex)
                {
                    log.Error("gray fail " + ex.Message);
                    throw (ex);
                }
            }

            if (curentOpera == OperaEnum.GuaseBlur)
            {
                try
                {
                    if (rawImg != null)
                    {
                        GuaseblurUserC guaseblurUserC = (GuaseblurUserC)parametersControl1;
                        int size = 0;
                        double sigmaX = 0;
                        double sigmaY = 0;
                        int.TryParse(guaseblurUserC.getSize(), out size);
                        double.TryParse(guaseblurUserC.getSigmaX(), out sigmaX);
                        double.TryParse(guaseblurUserC.getSigmaY(), out sigmaY);
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
                        pictrueHelper.GuaseBlurImg(rawImg, size, sigmaX, sigmaY, out guaseImg);
                        pictrueHelper.showPic(guaseImg);

                    }
                }
                catch (Exception ex)
                {
                    log.Error("gray fail " + ex.Message);
                    throw (ex);
                }
            }
            if (curentOpera == OperaEnum.HoughLines)
            {
                try
                {

                    HoughLinesUserC guaseblurUserC = (HoughLinesUserC)parametersControl1;
                    double rho = 0;

                    double.TryParse(guaseblurUserC.getRho(), out rho);

                    double theta = 1;

                    double.TryParse(guaseblurUserC.getTheta(), out theta);
                    int threshold = 1;

                    int.TryParse(guaseblurUserC.getThreshold(), out threshold);

                    double minLineLength = 1;

                    double.TryParse(guaseblurUserC.getMinLineLength(), out minLineLength);

                    double maxLineGap = 10;

                    double.TryParse(guaseblurUserC.getMinLineLength(), out maxLineGap);

                    Mat gray = new Mat();
                    Cv2.CvtColor(rawImg, gray, ColorConversionCodes.BGR2GRAY);

                    Mat stElem = Cv2.GetStructuringElement(MorphShapes.Rect, new
               OpenCvSharp.Size(7, 7));
                    Cv2.MorphologyEx(gray, gray, MorphTypes.Open, stElem, new OpenCvSharp.Point(-1, -1), 1);//来三次次开操作把无关点滤掉
                    Mat canny = new Mat();
                    Cv2.Threshold(gray, canny, 100, 150, ThresholdTypes.Binary);//二值化
                    Cv2.Canny(canny, canny, 60, 200, 3, false);

                    Mat huofuLineImg;
                    LineSegmentPoint[] linePiont = pictrueHelper.HuofuLine(canny, rho, theta, threshold, out huofuLineImg, minLineLength, maxLineGap);

                    Scalar color = new Scalar(guaseblurUserC.getColor().R, guaseblurUserC.getColor().G, guaseblurUserC.getColor().B);
                    for (int i = 0; i < linePiont.Count(); i++)
                    {
                        OpenCvSharp.Point p1 = linePiont[i].P1;
                        OpenCvSharp.Point p2 = linePiont[i].P2;
                        Cv2.Line(huofuLineImg, p1, p2, color, 1, LineTypes.Link8);
                    }

                    pictrueHelper.showPic(huofuLineImg);


                }
                catch (Exception ex)
                {
                    log.Error("HoughLines fail " + ex.Message);
                    throw ex;
                }
            }

            if (curentOpera == OperaEnum.MedianBlur)
            {
                try
                {
                    if (rawImg != null)
                    {
                        CloseUserC closeC = (CloseUserC)parametersControl1;
                        int size = 0;

                        int.TryParse(closeC.getSize(), out size);

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
                        pictrueHelper.MedianBlurImg(rawImg, size, out blurImg);
                        pictrueHelper.showPic(blurImg);
                    }
                }
                catch (Exception ex)
                {
                    log.Error("gray fail " + ex.Message);

                }

            }

            if (curentOpera == OperaEnum.NormalizedBlur)
            {
                try
                {
                    if (rawImg != null)
                    {
                        NormalizedBlurUserC normalizedBlurUser = (NormalizedBlurUserC)parametersControl1;
                        int width = 0;
                        int.TryParse(normalizedBlurUser.getWidth(), out width);
                        int height;
                        int.TryParse(normalizedBlurUser.getHeight(), out height);

                        Mat blurImg;
                        pictrueHelper.BlurImg(rawImg, width, height, -1, -1, out blurImg);
                        pictrueHelper.showPic(blurImg);

                    }
                }
                catch (Exception ex)
                {
                    log.Error("BlurImg fail " + ex.Message);
                    MessageBox.Show(ex.Message);

                }

            }

        }

        /// <summary>
        ///  形态学操作
        /// </summary>
        /// <param name="sizeStr">卷积核</param>
        /// <param name="morphTypes"></param>
        private void morphologyOpera(string sizeStr, MorphTypes morphTypes)
        {
            try
            {
                if (rawImg != null)
                {
                    CloseUserC closeC = (CloseUserC)parametersControl1;

                    int size = 0;

                    int.TryParse(sizeStr, out size);
                    if (size % 2 == 0)
                    {
                        MessageBox.Show("请输入奇数");
                        return;
                    }
                    InputArray element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(size, size), new OpenCvSharp.Point(-1, -1));
                    Mat dilateImg;
                    pictrueHelper.MorphologyEx(rawImg, element, morphTypes, out dilateImg);
                    pictrueHelper.showPic(dilateImg);
                }
            }
            catch (Exception ex)
            {
                log.Error("MorphShapes fail :" + morphTypes + ex.Message);
                MessageBox.Show(ex.Message);

            }
        }
    }



}
