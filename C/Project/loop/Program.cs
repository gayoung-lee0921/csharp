using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //int sum = 0;
            //while (sum<1000)
            //{
            //    sum += i;
            //    i++;
            //} Console.WriteLine("합이 1000을 넘는 최초의 수는 : {0}",i);
            //string snum;
            //int num;
            //do
            //{
            //    Console.WriteLine("숫자를 입력하세요(끝낼때는 0):");
            //    // ReadLine() 값 입력받음
            //    snum = Console.ReadLine();
            //    //num = int.Parse(snum);
            //    num = Convert.ToInt32(snum);
            //    Console.WriteLine("입력한 값은 {0} 입니다.", num);
            //} while (num != 0);

            //int sum = 0;
            //for(int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //} Console.WriteLine("1부터 100까지의 합 : {0}",sum);

            // foreach문
            //int[] ar = { 29, 64, 90, 16, 78 };
            //int max = 0;
            //foreach(int a in ar)
            //{
            //    if (a > max)
            //    {
            //        max = a;
            //    }
            //}
            //Console.WriteLine("가장 큰 값은 : {0}", max);

            // 2차원 배열
            int[,] ar =
            {
                {1,2,3},
                {4,5,6},
                {7,8, 9}
            };
            foreach(int a in ar)
            {
                Console.WriteLine(a);
            }

        }
    }
}
