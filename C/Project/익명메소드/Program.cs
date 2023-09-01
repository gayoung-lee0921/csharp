using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 익명메소드
{
    internal class Program
    {
        class Human
        {
            //private string Name;
            //private int Age;
            // 프로퍼티 기법
            public string Name { get; set; } 
            public int Age { get; set; }

            public Human(){}
            public Human(string name, int age)
            {
                Name = name;
                Age = age;
            }
           
            //public void setName(string aName) {
            //    Name = aName;
            //}
            //public string getName() {
            //    return Name;
            //}
            //public void setAge(int aAge)
            //{
            //    Age = aAge;
            //}
            //public int getAge()
            //{
            //    return Age;
            //}

        }
        delegate int CalcDelegate(int x, int y);
        static void Main(string[] args)
        {
            //Human lee = new Human("이가영", 27);
            //Console.WriteLine("이름:"+lee.getName());
            //Console.WriteLine("나이:" + lee.getAge());
            //lee.setName("엌가영");
            //Console.WriteLine("이름:" + lee.getName());

            // 프로퍼티 기법으로 작성했을 때 호출방법
            //var lee = new { Name = "이가영", Age = 27 };
            //Console.WriteLine("이름:" + lee.Name);
            //Console.WriteLine("나이:" + lee.Age);
            //lee.Name = "엌카경";
            //Console.WriteLine("이름:" + lee.Name);
            CalcDelegate del1;
            del1 = delegate (int x, int y)
            {
                return x + y;
            };
            int result = del1(10, 20);
            Console.WriteLine(result);
        }
    }
}
