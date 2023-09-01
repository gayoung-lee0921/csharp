using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // 스레드 사용을 위해 
using System.Diagnostics;

namespace 스레드
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // 현재 실행중인 스레드 가져옴 
            // Thread th = new Thread() 하면 스레드 객체를 생성 할 수 있음
            Thread th = Thread.CurrentThread;
            th.Name = "기본 스레드";

            txtInfo.Text += "스레드 이름: " + th.Name + "\r\n"; // 기본 스레드
            txtInfo.Text += "스레드 해시코드: " + th.GetHashCode() + "\r\n"; // 1
            txtInfo.Text += "스레드 상태: " + th.ThreadState + "\r\n"; // Running
            txtInfo.Text += "스레드 우선순위: " + th.Priority + "\r\n"; // Normal




        }
    }
}
