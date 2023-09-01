using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 문자열테스트
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str = textBox1.Text;
            //label1.Text= str.Length.ToString();

            // IndexOf() 예제
            //string str = textBox1.Text; 

            //int pos = str.IndexOf("-");
            //if(pos >=0)
            //{
            //    label1.Text = (pos+1).ToString() + "번째 포함";
            //}

            //Substring() 예제
            //string str = textBox1.Text;
            //970921-2..
            //string subStr = str.Substring(7, 1);

            //if (subStr == "1" )
            //{
            //    label1.Text = "남자입니다";
            //} else if(subStr == "2")
            //{
            //    label1.Text = "여자입니다";

            //}

            // CompareTo() 예제
            //string str = textBox1.Text;

            //if (str.CompareTo("800101") >= 0)
            //{
            //    label1.Text = "형님입니다";
            //}
            //else
            //{
            //    label1.Text = "내가 니 형이다.";

            //}
            //Replace() 예제
            //string str = textBox1.Text;
            //string newstr = str.Replace("ㅈㅈㅈ","www");
            //label1.Text = newstr;

            //split
            string str = textBox1.Text;
            label1.Text = "";
            string[] strArr = str.Split(new char[] { ',' });
            // strArr은 배열 객체
            foreach(string arr in strArr)
            {
                label1.Text += " "+arr;
            }

        }
    }
}
