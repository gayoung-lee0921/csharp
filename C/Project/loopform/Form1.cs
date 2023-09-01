using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //while (i < 5)
            //{
            //    label1.Text += "Programming"+ "\r\n";
            //    i++;
            //}
            label1.Text = "";
            int dan = Convert.ToInt32(textDan.Text);
            for (int i = 1; i < 10; i++) {
                // 정수를 문자열로 변환하기 위해 ToString()을 사용한다
                label1.Text+=dan.ToString()+"X"+i.ToString()+"="+(dan * i).ToString()+"\r\n";
            }


        }
    }
}
