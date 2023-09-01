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

namespace ThreadLock
{
    public partial class Form1 : Form
    {
        private string thdCode;
        private delegate void CrossCall();

        private int money;
        private object lockObject;

        private static Mutex mutex = new Mutex(false, "mtxObj");



        public Form1()
        {
            InitializeComponent();
            lockObject = new object();
            thdCode = null;
            money = 10000;
        }

        private void btnThreadLock_Click(object sender, EventArgs e)
        {
            txtThreadState.Clear();
            ThreadStart ts1 = new ThreadStart(ThreadTeller);
            ThreadStart ts2 = new ThreadStart(ThreadTeller);
            ThreadStart ts3 = new ThreadStart(ThreadTeller);
            Thread internetBanking = new Thread(ts1); // 스레드 진짜 생성
            Thread mobileBanking = new Thread(ts2);
            Thread teleBanking = new Thread(ts3);
            internetBanking.Start();
            mobileBanking.Start();
            teleBanking.Start();


        }
        // 스레드 함수는 무한루프를 돈다.
        private void ThreadTeller()
        {
            int task = 0;
            //lock (lockObject)
            //Monitor.Enter(lockObject);
            mutex.WaitOne(); // Mutex 락을 걸어줌
                while (task < 10)
                {
                    money = money + 1000;
                    txtThreadState.Invoke(new CrossCall(ThreadState));
                    thdCode = "뱅킹고유번호" + Thread.CurrentThread.GetHashCode()
                        + ", 입금잔액 : " + money + "원" + "\r\n";
                    Thread.Sleep(1000);
                    task++;
                }
            mutex.ReleaseMutex(); // Mutex 락을 풀어줌
            //Monitor.Exit(lockObject);  기존에 선점했던 스레드가 종료되고 다른 스레드가 진입함

        }
        private void ThreadState()
        {
            txtThreadState.Text += thdCode;
        }
    }
}
