using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace archive
{
    delegate bool ComProg(int nFile);
    class Archive
    {
        public static bool Compress(int nFile, ComProg prog)
        {
            for(int i=0; i < nFile; i++)
            {
                if (prog(i) == false)
                {
                    return false;
                }
                System.Threading.Thread.Sleep(500); // 0.5초씩 딜레이를줌
            }
            return true;
        }
    }
    internal class Program
    {
        // client side rendering
        public static bool Progress(int num)
        {
            Console.WriteLine($"{num + 1}번째 파일을 압축하는 중..");
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki = Console.ReadKey();
                if(cki.Key == ConsoleKey.Q)
                {
                    return false;
                }
            }
            
            return true;
        }
        static void Main(string[] args)
        {
            
            //파일 압축
            // 멤버 함수 앞에 static이 붙으면 호출할 때 사용방법
            // 멤버 함수 앞에 static 없으면 class를 이용해서 객체 만들면 됨
            if(Archive.Compress(10, Progress) == true)
            {
                Console.WriteLine("모든 파일 압축 완료");
            }
            else
            {
                Console.WriteLine("취소되었습니다.");

            }
        }
    }
}
