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

namespace 스레드상태
{
    public partial class Form1 : Form
    {
        private Thread thd;
        private string strState;
        delegate void CrossCall();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            thd = new Thread(new ThreadStart(ThreadFunction));
            textBox1.Text += "스레드 상태:" + thd.ThreadState +"\r\n"; //Unstarted
            thd.Start();
            textBox1.Text += "스레드 상태:" + thd.ThreadState + "\r\n"; //Running

        }
        private void ThreadFunction()
        {
            int count = 0;
            while (count++ < 100)
            {
                CrossCall cross = new CrossCall(ThreadState);
                textBox1.Invoke(cross);
                Thread.Sleep(1000);

            }
        }
        private void ThreadState()
        {
            textBox1.Text += "스레드 상태:" + thd.ThreadState + "\r\n";

        }
        private void btnSuspend_Click(object sender, EventArgs e)
        {

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            
        }
    }
}
