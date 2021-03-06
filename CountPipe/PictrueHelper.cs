﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Windows.Forms;

using System.IO;

namespace CountPipe
{
    public class PictrueHelper
    {
       public PictureBox pictureBox;
        Mat rawImg;
        public PictrueHelper()
        {
           
        }
        public PictrueHelper(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); //Logging 名字要在 App.config 中能找到

        /// <summary>
        /// 图像变灰
        /// </summary>
        /// <param name="inimg"></param>
        /// <param name="dvalue">灰度值</param>
        /// <param name="imgwindow"></param>
        /// <param name="binimg"></param>
        public void Tobinimg_inv(Mat inimg, double dvalue, out Mat binimg)
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
                 
                    //bin

                    if (dvalue == 0)
                    {
                        dvalue = 10;
                    }
                    binimg = grayimg.Threshold(dvalue, 255, ThresholdTypes.BinaryInv);
                    showPic(binimg);
                  
                    grayimg.Dispose();
                    // binimg.Dispose();
                }
            }
            catch (Exception ex)
            {
                log.Error("Tobinimg_inv error " + ex.Message);
            }
        }
        /// <summary>
        /// 打开图片文件
        /// </summary>
        /// <param name="Defaultpath"></param>
        /// <returns></returns>
        public string OpenfileDlg(string Defaultpath = null)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            //多选
            ofd.Multiselect = true;
            //初始目录
            ofd.InitialDirectory = Defaultpath;
            //设定文件类型
            ofd.Filter = "*.bmp | *.jpg";

            ofd.ShowDialog();

            //获得在打开文件对话框中选择的文件的路径
            string path = ofd.FileName;

            if (path != null && path != "")
            {
                 rawImg = Cv2.ImRead(path);
            }
            return path;
        }





        /// <summary>
        /// 获得轮廓 将结果画出并返回结果
        /// </summary>
        /// <param name="cannyImage"></param>
        /// <param name="contours"></param>

        public void GetContours(Mat cannyImage,  out  Point[][] contours)
        {
            contours = new Point [][]{};
            try
            {
                //获得轮廓
              
                HierarchyIndex[] hierarchly;
                Cv2.FindContours(cannyImage, out contours, out hierarchly, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple, new Point(0, 0));

                //将结果画出并返回结果
                Mat dst_Image = Mat.Zeros(cannyImage.Size(), rawImg.Type());
                Random rnd = new Random();
                for (int i = 0; i < contours.Length; i++)
                {
                    Scalar color = new Scalar(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                    Cv2.DrawContours(dst_Image, contours, i, color, 2, LineTypes.Link8, hierarchly);
                }

                showPic(dst_Image);
            

            }
            catch (Exception ex)
            {

                log.Error("GetEdgeImg fail " + ex.Message);
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

        public System.Drawing.Bitmap MatToBitmap(Mat image)
        {

            System.Drawing.Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
           
            return bitmap;
        }

        public void showPic(Mat mat)
        {
            System.Drawing.Bitmap img = MatToBitmap(mat);
            this.pictureBox.Image = img;
        }



        #region 滤波


        /// <summary>
        /// 
        /// </summary>
        /// <param name="initimg"></param>
        /// <param name="size">大小必须是奇数</param>
        /// <param name="sigamaX">标准差X,调大σ即提高了远处像素对中心像素的影响程度，滤波结果也就越平滑</param>
        /// <param name="sigmaY">标准差Y,调大σ即提高了远处像素对中心像素的影响程度，滤波结果也就越平滑</param>
        /// <param name="guaseImg"></param>

        public void GuaseBlurImg(Mat initimg, int size, double sigamaX, double sigmaY, out Mat guaseImg)
        {
            guaseImg = new Mat();
            try
            {
                Cv2.GaussianBlur(initimg, guaseImg, new Size(size, size), sigamaX, sigmaY);
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }
        /// <summary>
        /// 中值滤波是取卷积计算的中间值，中值滤波的好处是对图像的椒盐噪声有很好的抑制作用，因为图像的椒盐噪点，是图像某一片区域像素的极大值或者极小值，使用中值滤波可以过滤掉这些噪点
        /// </summary>
        /// <param name="initImg"></param>
        /// <param name="size">卷积核大小，大于1的奇数</param>
        /// <param name="blurImage"></param>
        public void MedianBlurImg(Mat initImg, int size, out Mat blurImage)
        {
            blurImage = new Mat();
            try
            {
                if (size % 2 == 0 || size == 1)
                {
                    return;
                }

                Cv2.MedianBlur(initImg, blurImage, size);

            }
            catch (Exception ex)
            {

                log.Error("GetBlurImg fail " + ex.Message);
                throw (ex);
            }


        }

        /// <summary>
        /// 归一化模糊
        /// </summary>
        /// <param name="initImg"></param>
        /// <param name="width">构造工具的宽,奇数</param>
        /// <param name="height">构造工具的高,奇数</param>
        /// <param name="pointX"></param>
        /// <param name="pointY"></param>
        /// <param name="blurImage"></param>

        public void BlurImg(Mat initImg, int width, int height, int pointX, int pointY, out Mat blurImage)
        {
            blurImage = new Mat();
            try
            {
                if (width % 2 == 0 || height % 2 == 0)
                {
                    return;
                }
                Cv2.Blur(initImg, blurImage, new Size(width, height), new Point(pointX, pointY));

            }
            catch (Exception ex)
            {

                log.Error("BlurImg fail " + ex.Message);
                throw (ex);
            }


        }
        /// <summary>
        /// 双边滤波 边缘保留的滤波方法，避免了边缘的信息丢失，保留了图像的原有轮廓不不变
        /// </summary>
        /// <param name="initimg"></param>
        /// <param name="d">计算半径，在半径范围内的像素都会纳入计算，如果输入-1则根据sigmaSpace取值</param>
        /// <param name="sigmaColor">决定多少差值之内的像素会被计算  《值域》</param>
        /// <param name="sigmaSpace">如果 d 的值大于0则无效，否则根据它来计算 d 值</param>
        /// <param name="bilateralImg"></param>

        public void BilateralBlurImg(Mat initimg, int d, double sigmaColor, double sigmaSpace, out Mat bilateralImg)
        {
            bilateralImg = new Mat();
            try
            {
                Cv2.BilateralFilter(initimg, bilateralImg, d, sigmaColor, sigmaSpace);
            }
            catch (Exception ex)
            {

                log.Error("BilateralBlurImg fail " + ex.Message);
                throw (ex);
            }
        }

        #endregion

        #region 形态操作

        /// <summary>
        /// 膨胀
        /// </summary>
        /// <param name="src"></param>
        /// <param name="element">结构元素 ，一定要是奇数</param>
        /// <param name="borderType">图像边缘处理方法。[默认情况下这是BorderType.Constant]</param>
        /// <param name="dilateImg"></param>
        /// <param name="iterations">应用侵蚀的次数。[默认情况下这是1]</param>
        /// <param name="anchor">锚点位置，默认是null</param>
        /// <param name="borderValue">在边界为常数的情况下的边界值。默认值具有特殊意义。[默认情况下这是cvcp . morphologydefaultbordervalue ()]</param>

        public void Dilate(Mat src, InputArray element, out Mat dilateImg,Point? anchor = null, Scalar? borderValue = null, BorderTypes borderType = BorderTypes.Constant, int iterations = 1)
        {
            try
            {
                dilateImg = new Mat();

                Cv2.Dilate(src, dilateImg, element, anchor, iterations, borderType);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// 腐蚀
        /// </summary>
        /// <param name="src"></param>
        /// <param name="element">结构元素 ，一定要是奇数</param>
        /// <param name="borderType">图像边缘处理方法。[默认情况下这是BorderType.Constant]</param>
        /// <param name="dilateImg"></param>
        /// <param name="iterations">应用侵蚀的次数。[默认情况下这是1]</param>
        /// <param name="anchor">锚点位置，默认是null</param>
        /// <param name="borderValue">在边界为常数的情况下的边界值。默认值具有特殊意义。[默认情况下这是cvcp . morphologydefaultbordervalue ()]</param>

        public void Erode(Mat src, InputArray element, out Mat dilateImg, Point? anchor = null, Scalar? borderValue = null, BorderTypes borderType = BorderTypes.Constant, int iterations = 1)
        {
            try
            {
                dilateImg = new Mat();

                Cv2.Erode(src, dilateImg, element, anchor, iterations, borderType);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        /// <summary>
        /// 形态学操作 
        /// 开， 先腐蚀后膨胀，可以去掉小的对象;
        /// 闭，先膨胀后腐蚀，可以填充图像的噪点
        /// 形态学梯度,膨胀减去腐蚀，又称基本梯度,获取轮廓
        /// 形态学顶帽：是原图像与开操作之间的差值图像
        /// 形态学黑帽：闭操作图像与源图像的差值图像
        /// </summary>
        /// <param name="src"></param>
        /// <param name="element">结构元素 ，一定要是奇数</param>
        /// <param name="erodeImg"></param>
        /// <param name="anchor">锚点位置，默认是null</param>
        /// <param name="borderValue"></param>
        /// <param name="borderType"></param>
        /// <param name="iterations">应用侵蚀的次数。[默认情况下这是1]</param>

        public void MorphologyEx(Mat src, InputArray element, MorphTypes type, out Mat erodeImg, Point? anchor = null, Scalar? borderValue = null, BorderTypes borderType = BorderTypes.Constant, int iterations = 1)
        {
            try
            {
                erodeImg = new Mat();

                Cv2.MorphologyEx(src, erodeImg, type, element, anchor, iterations, borderType);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region 边缘检测

        /// <summary>
        /// Canny边缘检测低错误率：意味着只检测存在的边缘。
        ///良好的定位：必须最小化检测到的边缘像素和真实边缘像素之间的距离。
        ///最小响应：每个边缘只有一个检测器响应。
        ///步骤：转灰，模糊，边缘检测
        /// </summary>
        /// <param name="initImg"></param>
        /// <param name="threshold1">阈值</param>
        /// <param name="threshold2">阈值下限阈值的三倍或二倍</param>
        /// <param name="cannyImage"></param>
        public void CannyImg(Mat initImg, double threshold1, double threshold2, out Mat cannyImage)
        {
            cannyImage = new Mat();
            try
            {

                Cv2.Canny(initImg, cannyImage, threshold1, threshold2);
                showPic(cannyImage);


            }
            catch (Exception ex)
            {

                log.Error("GetEdgeImg fail " + ex.Message);
            }


        }


        #region 霍夫变换

        /// <summary>
        /// 霍夫直线检测
        /// </summary>
        /// <param name="initImg">只能输入单通道图像</param>
        /// <param name="rho">累加器的距离分辨率(以像素为单位) 生成极坐标时候的像素扫描步长</param>
        /// <param name="theta">累加器的角度分辨率(以弧度为单位)生成极坐标时候的角度步长，一般取值CV_PI/180 ==1度</param>
        /// <param name="threshold">累加器阈值参数。只有那些足够的行才会返回 投票(>阈值)；设置认为几个像素连载一起</param>
        /// <param name="lineImg"></param>
        /// <param name="minLineLength">最小线长度，设置最小线段是有几个像素组成</param>
        /// <param name="maxLineGap">同一条线上的点之间连接它们的最大允许间隙。(默认情况下是0）：设置你认为像素之间  间隔多少个间隙也能认为是直线* 返回结果出线。每条线由一个4元向量(x1, y1, x2，y2)</param>

        public LineSegmentPoint[] HuofuLine(Mat initImg, double rho, double theta, int threshold,out Mat lineImg, double minLineLength = 0, double maxLineGap = 0)
        {
            try
            {

                lineImg = new Mat(initImg.Size(), MatType.CV_8UC3);
                LineSegmentPoint[] linePiont = Cv2.HoughLinesP(initImg, rho, theta, threshold, minLineLength, maxLineGap);
                return linePiont;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion


        #endregion

    }
}
