using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEvent
{
    
    internal class Program
    {
        public delegate void ButtonClick();
        public static event ButtonClick evtClick;

        // 버튼 클릭했을 떄
        public static void onClick()
        {
            evtClick();
        }
        public static void MyHandler()
        {
            Console.WriteLine("버튼 클릭되면 수행되는 이벤트핸들러");
        }
        static void Main(string[] args)
        {
            // 이벤트랑 이벤트핸들러 연결
            evtClick += new ButtonClick(MyHandler);
            onClick();
        }
    }
}
