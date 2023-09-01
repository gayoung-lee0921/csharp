using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            ref int b = ref a; // a의 메모리를 b에 공유, 주소값이 넘어감
            b = 34;
            Console.WriteLine(a); // 34 출력, a와 b가 메모리를 공유하게 됐는데 b의 값이 변해서 a도 변함
        }
    }
}
