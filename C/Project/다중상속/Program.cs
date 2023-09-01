using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static 다중상속.SmartPhone;

namespace 다중상속
{
    public interface ICamera {
        void Camera();
    }
    public interface ICall
    {
        void Call();
    }
    public interface IWifi
    {
        void wifi();
    }
    public interface IBlue 
    {
        void Blue();
    }
    public class SmartPhone : ICamera, IWifi, ICall, IBlue
    {
        virtual public void Camera() {
            Console.WriteLine("카메라");
        }
        virtual public void wifi() {
            Console.WriteLine("와이파이");
        }
        virtual public void Blue()
        {
            Console.WriteLine("블루투스");

        }
        virtual public void Call() {

            Console.WriteLine("전화");
        }

        public class 갤럭시: SmartPhone 
        {
             public override void Camera()
            {
                Console.WriteLine("갤럭시 카메라");
            }
        }
        public class 아이폰 : SmartPhone 
        {
            public override void Camera()
            {
                Console.WriteLine("아이폰 카메라");
            }
            public override void Blue()
            {
                Console.WriteLine("아이폰 블루투스");
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone phone = new 아이폰();
            phone.Camera();
            phone.wifi();
            phone.Call();
            phone.Blue();
        }
    }
}
