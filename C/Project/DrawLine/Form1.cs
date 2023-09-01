using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 화면에 그려주는 이벤트 : Paint
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 선 그리기
            //Graphics g = e.Graphics;  g객체가 GDI
            //Pen p = new Pen(Color.Red,5);  펜의 색깔과 굵기 설정

            //Point start = new Point(50, 50);  펜의 시작점
            //Point end = new Point(250, 250);  펜의 끝점
            //g.DrawLine(p, start, end);  그리기 시작

            //start = new Point(250, 50); 
            //end = new Point(50, 250);
            //g.DrawLine(p, start, end);

            //사각형 그리기
            //Graphics g = e.Graphics; 
            //Pen p = new Pen(Color.Yellow, 10);

            //Rectangle rc1 = new Rectangle(30,20,200,200);
            //g.DrawRectangle(p, rc1);

            //Brush b = new SolidBrush(Color.Orange);
            //Rectangle rc2 = new Rectangle(260, 20, 200, 200);
            //g.FillRectangle(b, rc2);

            // 원 그리기
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Yellow, 10);

            Rectangle rc1 = new Rectangle(30, 20, 200, 200);
            g.DrawEllipse(p, rc1);

            Brush b = new SolidBrush(Color.Orange);
            Rectangle rc2 = new Rectangle(260, 20, 200, 200);
            g.FillEllipse(b, rc2);
        }
    }
}
