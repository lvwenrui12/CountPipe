
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
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); //Logging 名字要在 App.config 中能找到

     
        public static void Tobinimg_inv(Mat inimg, double dvalue, SharpWindows imgwindow, out Mat binimg)
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
                log.Error("Tobinimg_inv error "+ex.Message);
            }
        }

        public static string OpenfileDlg(string Defaultpath = null)
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
            return path;
        }
    }
}
