using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackMethod
{
    internal class Program
    {
        // 이벤트 발생
        static void eventMethod(int x, int y, CalDelegate dele)
        {
            dele(x, y);
        }
        delegate void CalDelegate(int x, int y);
        static void Plus(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Minus(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Multiple(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        static void Main(string[] args)
        {
            CalDelegate plus = Plus; // plus 객체 생성
            CalDelegate minus = Minus;
            CalDelegate multiple = Multiple;
            CalDelegate divide = Divide;

            // 이벤트 발생
            eventMethod(20, 10, plus);
            eventMethod(20, 10, minus);
            eventMethod(20, 10, multiple);



        }
    }
}
