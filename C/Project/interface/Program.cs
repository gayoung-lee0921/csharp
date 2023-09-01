using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    public interface IUnit
    {
        void 공격();
        void 이동();
    }
    public class Zergling : IUnit
    {
        public void 공격() {
            Console.WriteLine("저글링 공격");
        }
        public void 이동() {
            Console.WriteLine("저글링 이동");
        }

    }
    public class Dragon : IUnit
    {
        public void 공격()
        {
            Console.WriteLine("드라곤 공격");
        }
        public void 이동()
        {
            Console.WriteLine("드라곤 이동");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon = new Dragon();
            dragon.공격();
            dragon.이동();

            Zergling zergling = new Zergling();
            zergling.공격();
            zergling.이동();
        }
    }
}
