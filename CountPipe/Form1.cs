using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace CountPipe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            //选择图片
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            string imgName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgName = openFileDialog.FileName;
            }
            Console.WriteLine("文件名为" + imgName);

            //读取并进行边缘检测
            Mat srcImg = new Mat(imgName, ImreadModes.Color);
            Cv2.ImShow("input", srcImg);
            //Mat dstImg = new Mat(srcImg, new Rect(x, y, width, height));
            Mat dstImg = new Mat();//一个图片容器
            Cv2.Canny(srcImg, dstImg, 50, 200);
            Cv2.ImShow("output", dstImg);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {

        }

        private void pictBox_Click(object sender, EventArgs e)
        {

        }
    }
}
