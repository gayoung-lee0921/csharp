using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 메시지알람
{
    public partial class Form1 : Form
    {
        private msgForm msg;
        // 화면 하단 오른쪽에 띄우기 위해 변수 설정
        private int x;
        private int y;
        private int height;
        public Form1() // 생성자 - 초기화 하는 부분
        {
            InitializeComponent();
            x = 0;
            y = 0;
            height = 0;
        }
       
        private void btnMsg_Click(object sender, EventArgs e)
        {

            x = Screen.PrimaryScreen.Bounds.Width-287;
            y = Screen.PrimaryScreen.Bounds.Height;
            msg = new msgForm();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (height > 200)
            {
                height = 0;
                timer1.Stop();
                Thread.Sleep(1000);
                msg.Close();
            }
            else
            {
                msg.Location = new Point(x, y - height);
                msg.Show();
                height += 10;
            }
        }
    }
}
