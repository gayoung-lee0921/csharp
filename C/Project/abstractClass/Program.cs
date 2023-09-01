using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    abstract class SmartPhone // 추상클래스 => 표준이 됨(원형)
    {
        public abstract void wifi(); // 추상메소드
        public abstract void call(); // 추상메소드
        public abstract void sms(); // 추상메소드
        public abstract void camera(); // 추상메소드
    }
    class Samsung : SmartPhone // 상속을 받음 => 구현
    {
        public override void wifi()
        {
            Console.WriteLine("삼성 와이파이");
        }
        public override void call()
        {
            Console.WriteLine("삼성 전화");

        }
        public override void sms()
        {
            Console.WriteLine("삼성 문자");

        }
        public override void camera()
        {
            Console.WriteLine("삼성 카메라");

        }
    }
    class Apple : SmartPhone // 상속 받음 => 구현
    {
        public override void wifi()
        {
            Console.WriteLine("애플 와이파이");

        }
        public override void call()
        {
            Console.WriteLine("애플 전화");

        }
        public override void sms()
        {
            Console.WriteLine("애플 문자");
        }
        public override void camera()
        {
            Console.WriteLine("애플 카메라");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Samsung phone = new Samsung(); 
            //phone.camera();
            //phone.sms();
            //phone.wifi();

            //Apple iphone = new Apple(); 
            //iphone.camera();
            //iphone.sms();
            //iphone.wifi();

            // 부모는 자식 객체를 받을 수 있음
            // Samsung()의 자리만 변경됨 => 객체지향의 다형성
            SmartPhone sphone = new Samsung(); // 플러그인 방식(규격이 맞아야 갈아 끼울 수 있음)
            sphone.camera();
            sphone.sms();
            sphone.wifi();
        }
    }
}
