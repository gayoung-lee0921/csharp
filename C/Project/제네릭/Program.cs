using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 제네릭
{
    //class WrapperInt
    //{
    //    private int value;
    //    public WrapperInt() { this.value = 0; }
    //    public WrapperInt(int value) { this.value = value; }
    //    public void OutValue(s)
    //    {
    //        Console.WriteLine(value);
    //    }
    //}
    //class WrapperString
    //{
    //    private string value;
    //    public WrapperString() { this.value = null; }
    //    public WrapperString(string value) { this.value = value; }
    //    public void OutValue()
    //    {
    //        Console.WriteLine(value);
    //    }
    //}
    //제네릭을 사용하여 클래스 정의하기
    class Wrapper<T>
    {
        private T value;
        public Wrapper() { this.value = default(T);}
        public Wrapper(T value) { this.value = value; }
        public void OutValue()
        {
            Console.WriteLine(value);
        }
    }
    internal class Program
    {
        //static void Swap(ref int a, ref int b)
        //{
        //    int t;
        //    t = a;
        //    a = b;
        //    b = t;
        //}
        //static void Swap(ref string a, ref string b)
        //{
        //    string t;
        //    t = a;
        //    a = b;
        //    b = t;
        //}
        static void Swap<T>(ref T a, ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {

            //WrapperInt wrapperint = new WrapperInt(1234);
            //wrapperint.OutValue();
            //WrapperString wrapperstring = new WrapperString("안녕");
            //wrapperstring.OutValue();

            //Wrapper<int> wrapperint = new Wrapper<int>(1234);
            //wrapperint.OutValue();
            //Wrapper<string> wrapperstring = new Wrapper<string>("안녕");
            //wrapperstring.OutValue();

            int x = 3;
            int y = 4;
            Console.WriteLine("x = {0}, y={1}", x, y);
            Swap(ref x, ref y); // ref를 사용하면 메모리를 공유, 즉 주소값을 공유한다.
            Console.WriteLine("x = {0}, y={1}", x, y);

            string sx = "멍멍";
            string sy = "야옹";
            Console.WriteLine("sx = {0}, sy={1}", sx, sy);
            Swap(ref sx, ref sy); // ref를 사용하면 메모리를 공유, 즉 주소값을 공유한다.
            Console.WriteLine("sx = {0}, sy={1}", sx, sy);

        }
    }
}
