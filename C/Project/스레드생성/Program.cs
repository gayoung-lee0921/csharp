using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 스레드생성
{
    internal class Program
    {
        static void Main(string[] args) // default Thread
        {
            Console.WriteLine("주스레드 시작");
            ThreadStart th = new ThreadStart(ThreadFunction);
            Thread thd = new Thread(th); // 스레드 생성
            thd.Start(); // 스레드 시작
            Console.WriteLine("워커스레드 시작"+thd.ThreadState);
            Console.WriteLine("주 스레드 종료");
            Thread.Sleep(10);
            thd.Join(); //워커스레드가 종료될때까지 애플리케이션 종료를 기다려줌
            //thd.Abort(); 강제종료 하기 때문에 예외가 생기면 catch문이 실행됨
        } // 주스레드가 종료되기 때문에 애플리케이션 종료, 워커스레드는 계속해서 돌고있음
        public static void ThreadFunction()
        {
            try
            {
                int count = 0;
                while (count < 1000)
                {
                    Console.WriteLine("워커 스레드 동작중");
                    count++;
                }
                Console.WriteLine("정상 종료");

            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Abort 예외 발생 : "+e.Message);
            }
            finally 
            {
                Console.WriteLine("무조건 들어옴");
            }
        }
        
    }
}
