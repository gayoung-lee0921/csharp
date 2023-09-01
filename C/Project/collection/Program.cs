using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arr = new ArrayList(10);
            //// 동적으로 입력, 모두 다른 타입의 데이터 추가
            //arr.Add(1);
            //arr.Add(2);
            //arr.Add(3);
            //arr.Add(3.14);
            //arr.Add("수고하셈");
            //arr.Add(new DateTime(2023, 8, 21));
            //arr.Insert(1, 1234);

            //for (int i = 0; i < 10; i++) 
            //{
            //    arr.Add(i);
            //}
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    Console.WriteLine(arr[i].ToString());
            //}
            //// 반복자 사용_foreach(메모리의 주소값을 읽어옴)
            ////foreach(object o in arr)
            ////{
            ////    Console.WriteLine(o.ToString());
            ////}
            //Console.WriteLine("개수 : " + arr.Count);            
            //Console.WriteLine("용량 : " + arr.Capacity);

            //ArrayList ar = new ArrayList(10); // 자리를 10개 만듦
            //ar.Add("이가영");
            //ar.Add("홍다현");
            //ar.Add("김효원");
            //ar.Add("이승은");
            //ar.Add("이진영");
            //ar.Add("박세녕");
            //ar.Add("전희선");
            //ar.Add("권남희");
            //ar.Add("유혜린");
            //ar.Add("고수민");

            //foreach(object o in ar)
            //{
            //    Console.Write(o + ",");
            //}
            //Console.WriteLine();
            //ar.Sort(); // 오름차순으로 정렬
            //foreach(object o in ar)
            //{
            //    Console.Write(o + ",");
            //}
            //ar.Reverse();
            //foreach(object o in ar)
            //{
            //    Console.Write(o + "," );
            //}

            // hashtable 예제
            //Hashtable ht = new Hashtable();
            //ht.Add("boy","소년");
            //ht.Add("girl", "소녀");
            //ht.Add("school", "학교");
            //Console.WriteLine(ht["boy"]);

            // 스택, 큐 : 자료를 관리하는 컨테이너
            // 스택 예제
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push("test");

            //Console.WriteLine(stack.Pop()); 먼저 들어간게 나중에 나옴
            //Console.WriteLine(stack.Pop());

            // 큐 예제
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //queue.Dequeue(); //먼저 들어간게 먼저 나옴
            //foreach (object o in queue)
            //{
            //    Console.WriteLine(o.ToString()); 

            //}

            //DateTime
            //DateTime a = new DateTime(2023,8,21);
            //DateTime b = new DateTime(2022, 8, 21);
            //TimeSpan c = a - b;
            //Console.WriteLine(c.ToString());

            //c = new TimeSpan(100,0,0,0);
            //b = a + c;
            //Console.WriteLine("100일 되는 날 : "+b.ToString());

            //Random
            //Random rnd = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.CursorLeft = rnd.Next(80); // 0 ~ 80 까지의 수 랜덤하게 생성
            //    Console.CursorTop = rnd.Next(24);
            //    Console.Write("*");
            //}
            // 복권
            Random lotto = new Random();
            int count = 0;
            int[] lottoNumarr = new int[6];
            Console.WriteLine("로또번호랜덤생성");
            while (count < 6)
            {
                int lottoNum = lotto.Next(1, 46);
                if (!lottoNumarr.Contains(lottoNum))
                {
                    lottoNumarr[count] = lottoNum;
                    Console.Write(lottoNumarr[count]+",");
                    count++;
                }
            }
            
                

        }
    }
}
