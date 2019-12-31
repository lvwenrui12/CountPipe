using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;//添加系统动态链接库

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace CountPipe
{
    public partial class Emgu : Form
    {
        public Emgu()
        {
            InitializeComponent();
        }

        private void Emgu_Load(object sender, EventArgs e)
        {
            String win1 = "Test Window";
            //新建窗口
            CvInvoke.NamedWindow(win1);
            //新建图像
            Mat img = new Mat(200, 500, DepthType.Cv8U, 3);
            //设置图像颜色
            img.SetTo(new Bgr(255, 0, 0).MCvScalar);
            //绘制文字
            CvInvoke.PutText(img, "Hello, world", new System.Drawing.Point(0, 80), FontFace.HersheyComplex, 2.0, new Bgr(0, 255, 255).MCvScalar, 4);
            //显示
            CvInvoke.Imshow(win1, img);
            CvInvoke.WaitKey(0);
            CvInvoke.DestroyWindow(win1);

        }
    }
}
