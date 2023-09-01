using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 메뉴
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // 초기화
            Application.SetCompatibleTextRenderingDefault(false); // 초기화
            Application.Run(new Form1()); // 실제 실행
        }
    }
}
