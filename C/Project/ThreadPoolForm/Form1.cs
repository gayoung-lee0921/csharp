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

namespace ThreadPoolForm
{
    public partial class Form1 : Form
    {
        string thdCode = null;
        // 주스레드에 있는 요소를 워커스레드가 사용하면 오류가 생기니 만듦
        delegate void CrossCall();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThreadPool_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "스레드 풀 시작" + "\r\n";
            for(int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadFunction), i);
            }
            textBox1.Text += "스레드 풀 종료" + "\r\n";
        }
        private void ThreadFunction(object obj)
        {
            // 
            textBox1.Invoke(new CrossCall(ThreadState));
            thdCode = "스레드 식별 : " + Thread.CurrentThread.GetHashCode().ToString() 
                + "스레드 상태 : " + Thread.CurrentThread.ThreadState.ToString() + "\r\n";
                Thread.Sleep(1000);

        }
        private void ThreadState()
        {
            textBox1.Text += thdCode;
        }
    }
}
