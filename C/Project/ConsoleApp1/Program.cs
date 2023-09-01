using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "하나";
            switch (s)
            {
                case "제로":
                    Console.WriteLine("제로");
                    break;
                case "하나":
                    Console.WriteLine("하나");
                    break;
                case "둘":
                    Console.WriteLine("둘");
                    break;
                case "셋":
                    Console.WriteLine("셋");
                    break;
                default:
                    Console.WriteLine("그 외");
                    break;
            }
        }
    }
}
