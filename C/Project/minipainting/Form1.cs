using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minipainting
{
    public partial class Form1 : Form
    {
        // 클래스의 멤버변수 -> 생성자에서 초기화  필요
        // 하지만 도형에 관련된 변수들은 load가 됐을 때 초기화(늦은 초기화라고 부름)
        // 
        private Graphics g; // 그림 객체 - 그림 그리려면 무조건 해줘야 됨
        private Point ptStart; // 시작 좌표
        private Point ptEnd; // 끝 좌표
        private Rectangle rect;
        private Boolean bPress; // 마우스를 눌렀는지 확인(T/F)
        private int shape; // 모양 변수
        private Pen mypen; // 선 굵기
        private int rtWidth; // 너비
        private int rtHeight; // 높이
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // 매개변수 e로 이벤트 정보를 얻을 수 있음
            bPress = true; // 마우스 누름
            ptStart.X = e.X; // 폼 기반에서 마우스로 딱 눌렀을 떄의 x
            ptEnd.Y = e.Y;
        }
        // 마우스 이동
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(shape == 0) // 직선을 그릴 때
            {
                if (bPress == true)
                {
                    g.Clear(Color.White); // 그림판 지우기
                    ptEnd = new Point(e.X, e.Y); // 이동했을 때의 좌표
                    g.DrawLine(mypen, ptStart, ptEnd);
                }
            } 
            else if(shape == 1) // 사각형 그릴 때
            {
                if (bPress == true)
                {
                    g.Clear(Color.White);
                    // 좌표가 마이너스 값이 될 수 없으므로 절댓값 처리
                    rtWidth=Math.Abs(e.X - ptStart.X); // 현재좌표 - 시작좌표
                    rtHeight = Math.Abs(e.Y - ptEnd.Y);
                    // 사각형 형성
                    rect = new Rectangle(ptStart.X, ptEnd.Y, rtWidth, rtHeight);
                    g.DrawRectangle(mypen, rect); // 사각형 그리기
                }   
            }
            else if (shape == 2) // 원 그릴 때
            {
                if (bPress == true)
                {
                    g.Clear(Color.White);
                    // 원은 사각형을 그리고 난 후에
                    rtWidth = Math.Abs(e.X - ptStart.X); 
                    rtHeight = Math.Abs(e.Y - ptEnd.Y);
                    rect = new Rectangle(ptStart.X, ptEnd.Y, rtWidth, rtHeight);
                    g.DrawArc(mypen, rect,0, 365); 
                }
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape == 0)
            {
                ptEnd = new Point(e.X, e.Y);
                g.DrawLine(mypen, ptStart, ptEnd);
            } 
            else if (shape == 1) {
                rtWidth = Math.Abs(e.X - ptStart.X); 
                rtHeight = Math.Abs(e.Y - ptEnd.Y);
                rect = new Rectangle(ptStart.X, ptEnd.Y, rtWidth, rtHeight);
                g.DrawRectangle(mypen, rect); 

            }
            else if (shape == 2) 
            {
                rtWidth = Math.Abs(e.X - ptStart.X);
                rtHeight = Math.Abs(e.Y - ptEnd.Y);
                rect = new Rectangle(ptStart.X, ptEnd.Y, rtWidth, rtHeight);
                g.DrawArc(mypen, rect, 0, 365);
            }
            bPress = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            shape = 0;  
            ptStart = new Point(0, 0);
            ptEnd = new Point(0, 0);
            mypen = new Pen(Color.Black, 1);
            rtWidth = 0;
            rtHeight = 0;
            bPress = false;
            g = Graphics.FromHwnd(this.Handle); 
        }
        

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripLine_Click(object sender, EventArgs e)
        {
            this.shape = 0;

        }

        private void ToolStripRect_Click(object sender, EventArgs e)
        {
            this.shape = 1;
        }

        private void ToolStripCircle_Click(object sender, EventArgs e)
        {
            this.shape = 2;
        }

        private void ToolStripColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK==this.colorDialog1.ShowDialog())
            {
                this.mypen.Color = this.colorDialog1.Color;
            }
        }

        private void toolStripBtnLine_Click(object sender, EventArgs e)
        {
            this.shape = 0; // 직선
        }

        private void toolStripBtnRect_Click(object sender, EventArgs e)
        {
            this.shape = 1; // 사각형
        }

        private void toolStripBtnCircle_Click(object sender, EventArgs e)
        {
            this.shape = 2; // 원
        }

        private void toolStripBtnBlack_Click(object sender, EventArgs e)
        {
            this.mypen.Color = Color.Black;
        }

        private void toolStripBtnRed_Click(object sender, EventArgs e)
        {
            this.mypen.Color = Color.Red;

        }

        private void toolStripBtnGreen_Click(object sender, EventArgs e)
        {
            this.mypen.Color = Color.Green;
        }

        private void toolStripBtnBlue_Click(object sender, EventArgs e)
        {
            this.mypen.Color = Color.Blue;

        }

        private void toolStripComboThick_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mypen.Width = int.Parse(this.toolStripComboThick.SelectedItem.ToString())*2;


        }
    }
}
