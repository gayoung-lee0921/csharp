using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예외처리
{
    internal class Program
    {
        static int[] arr = { 1, 2, 3, 4, 5 };
        static int idx = 8;
        static public void method1()
        {
            method2();
        }
        static public void method2()
        {
            Console.WriteLine(arr[idx]); // 메소드 안에서 예외가 발생하더라도 뚫고 catch문으로 들어감
        }
        static void Main(string[] args)
        {
            try
            {
                method1();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);

            }




            //int a = 100;
            //int b = 0;

            //if (a !=0 && b !=0)
            //{
            //    Console.WriteLine("두 수의 나누기 : {0}", a / b);
            //}
            //else
            //{
            //    Console.WriteLine("0 이외의 수를 입력하세요");
            //}

            // try ~ catch 문으로 예외 처리
            //try 
            //{
            //    Console.WriteLine("두 수의 나누기 : {0}", a / b);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine("0 이외의 수를 입력하세요");
            //}
            //finally
            //{
            //    Console.WriteLine("무조건 실행");
            //}

        }
    }
}
