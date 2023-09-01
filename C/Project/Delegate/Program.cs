using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        // 함수포인터
        delegate void Calc(int x, int y); 

        static void Plus(int x,int y)
        {
            Console.WriteLine( x + y);
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
            // Calc del1 = new Calc(Plus) new 연산자는 생략 가능
            Calc del1 =Plus;
            Calc del2 = Minus;
            Calc del3 = Multiple;
            Calc del4 = Divide;

            del1 += del2;
            del1 += del3;

            del1(20, 10); // Plus, Minus, Multiple 함수 누적

            del1 -= del2; // Minus 함수 빼기
            del1(20, 10); // Plus, Multiple 함수만 누적
        }
    }
}
