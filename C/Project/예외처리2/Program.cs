using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예외처리2
{
    internal class Program
    {
        static void AddKim(string kim)
        {
            if (kim[0] != '김')
            {
                // catch문으로 ex에 문장을 던진다.
                throw new FormatException("김가만 등록할 수 있다.");
            }
            Console.WriteLine(kim + "등록완료");
        }
        static void Main(string[] args)
        {
            try
            {
                AddKim("김서방");
                AddKim("오서방");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
