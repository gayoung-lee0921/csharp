using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    struct Book
    {
        public string Name;
        public int Price;
        // 생성자는 new 연산자를 선언하자마자 실행됨
        public Book(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book a = new Book("C#프로그래밍의 정석",25000); // new 연산자를 사용했기 때문에 힙 메모리가 생성됨
            //a.Name = "C#프로그래밍의 정석";
            //a.Price = 25000;
            Console.WriteLine("제목 : {0}, 가격 : {1}", a.Name, a.Price);
        }
    }
}
