using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEvent
{
    public class FormEvent : Form
    {
        
        public FormEvent()
        {
            // this는 FormEvent 의미
            this.Click += new EventHandler(나만의메소드);
        }
        public void 나만의메소드(object sender, EventArgs e)
        {
            MessageBox.Show("마우스 클릭 이벤트 발생 처리");
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new FormEvent());
        }
    }
}
