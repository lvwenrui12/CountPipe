
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Windows.Forms;

namespace CountPipe
{
    public class PictrueHelper
    {
        SharpWindows imgwindow;
        Mat rawImg;
        public PictrueHelper(SharpWindows imgwindow)
        {
            this.imgwindow = imgwindow;
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
                    imgwindow.Showimg(grayimg);
                    //bin

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
        /// 滤波
        /// </summary>
        /// <param name="initImg">输入的图像</param>
        /// <param name="size">工具的长宽</param>
        /// <param name="blurImg">输出</param>
        public void GetBlurImg(Mat initImg, Size size, out Mat blurImg)
        {
            blurImg = new Mat();
            try
            {

                Cv2.Blur(initImg, blurImg, size);
                imgwindow.Showimg(blurImg);
               
            }
            catch (Exception ex)
            {

                log.Error("GetBlurImg " + ex.Message);
            }


        }
        /// <summary>
        /// 边缘检测
        /// </summary>
        /// <param name="initImg"></param>
        /// <param name="threshold1">阈值</param>
        /// <param name="threshold2">阈值</param>
        /// <param name="cannyImage"></param>
        public void GetEdgeImg(Mat initImg, double threshold1, double threshold2, out Mat cannyImage)
        {
             cannyImage = new Mat();
            try
            {

                Cv2.Canny(initImg, cannyImage, threshold1, threshold2);
                imgwindow.Showimg(cannyImage);

            }
            catch (Exception ex)
            {

                log.Error("GetEdgeImg fail " + ex.Message);
            }


        }

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

               
                imgwindow.Showimg(dst_Image);

            }
            catch (Exception ex)
            {

                log.Error("GetEdgeImg fail " + ex.Message);
            }


        }
    }
}
