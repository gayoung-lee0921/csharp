using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 람다식
{
    internal class Program
    {
        delegate int CalcDele(int x, int y);
        static void Main(string[] args)
        {
            CalcDele d = (int x, int y) => x +y+ 1;
                        
            int k = d(3,4);
            Console.WriteLine(k);
        }
    }
}
