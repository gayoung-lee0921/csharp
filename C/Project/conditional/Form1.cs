using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conditional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int kuk = int.Parse(textKuk.Text);
            int eng = int.Parse(textEng.Text);
            int math = int.Parse(textMath.Text);

            int total = kuk + eng + math;
            int avg = total / 3;
            //if (total > 250 && total<=300)
            //{
            //    lblResult.Text = "합격";
            //} else if(total<=250 && total >= 0)
            //{
            //    lblResult.Text = "불합격";
            //}
            //else
            //{
            //    lblResult.Text = "유요하지 않는 점수입니다";
            //}
            //if (avg >= 90 && avg <= 100)
            //{
            //    lblResult.Text = "A";
            //}
            //else if (avg >= 80 && avg<90)
            //{
            //    lblResult.Text = "B";

            //}
            //else if (avg >= 70 && avg<80)
            //{
            //    lblResult.Text = "C";

            //}
            //else if (avg >= 60 && avg<70)
            //{
            //    lblResult.Text = "D";

            //}
            //else if (avg < 60 && avg >= 0)
            //{
            //    lblResult.Text = "F";
            //}
            //else
            //{
            //    lblResult.Text = "유효하지 않은 점수입니다";
            //}
            switch (avg/10)
            {
                case 10:
                case 9:
                    lblResult.Text = "A";
                    break;
                case 8:
                    lblResult.Text = "B";
                    break;
                case 7:
                    lblResult.Text = "C";
                    break;
                case 6:
                    lblResult.Text = "D";
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    lblResult.Text = "F";
                    break;
                default:
                    lblResult.Text = "유효하지 않은 점수입니다.";
                    break;

            }
        }
    }
}
