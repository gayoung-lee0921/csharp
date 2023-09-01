using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 비트맵클래스
{
    public partial class Form1 : Form
    {
        private Image oriImage;
        private Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            oriImage = pictureBox1.Image.Clone() as Image;
        }
        private Bitmap ImageApply()
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Image = oriImage.Clone() as Image;
            bmp = pictureBox1.Image as Bitmap;
            return bmp;
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            bmp = ImageApply();
            int width = bmp.Width;
            int height = bmp.Height;

            Color colorData;
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    colorData = bmp.GetPixel(i, j);
                    // rgb의 중간값
                    int res = (colorData.R + colorData.G + colorData.B) / 3;
                    colorData=Color.FromArgb(res, res,res);
                    bmp.SetPixel(i, j, colorData);
                }
            }
        }
    }
}
