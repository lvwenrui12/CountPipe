using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountPipe
{
    public class SharpWindows
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Logging"); //Logging 名
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private PictureBox pictureBox;
        private Control Parentform;
        public Window Opencvwin;
        public SharpWindows(PictureBox _pictureBox, string winname)
        {
            pictureBox = _pictureBox;
            Cv2.NamedWindow(winname);
            Opencvwin = new Window(winname, WindowMode.FullScreen);
            Cv2.SetWindowProperty(Opencvwin.Name, WindowProperty.Fullscreen, 1);
            IntPtr Childwin = FindWindow(null, winname);
            SetParent(Childwin, _pictureBox.Handle);
            Parentform = Control.FromHandle(_pictureBox.Handle);

        }
        public void Showimg(Mat img)
        {
            try
            {

                //Mat srcImg = new Mat(imgName, ImreadModes.Color);
                //Cv2.ImShow("input", srcImg);
                ////Mat dstImg = new Mat(srcImg, new Rect(x, y, width, height));
                //Mat dstImg = new Mat();//一个图片容器
                //Cv2.Canny(srcImg, dstImg, 50, 200);
                //Cv2.ImShow("output", dstImg);
                int width = Parentform.Width;
                int height = Parentform.Height;
                Cv2.ResizeWindow(Opencvwin.Name, width, height);
                Cv2.MoveWindow(Opencvwin.Name, Parentform.Left, Parentform.Top);
                Cv2.SetWindowProperty(Opencvwin.Name, WindowProperty.Fullscreen, 1);
                Opencvwin.ShowImage(img);

            }
            catch (Exception ex)
            {
                log.Error("Showimg error" + ex.Message);

            }

        }
    }
}
