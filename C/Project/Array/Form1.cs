using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr = new int[] { 0, 0, 0 }; // 배열 초기화

        private void button1_Click(object sender, EventArgs e)
        {
            arr[0] = int.Parse(textBox1.Text);
            arr[1] = int.Parse(textBox2.Text);
            arr[2] = int.Parse(textBox3.Text);

            foreach(int i in arr)
            {
                label1.Text += i.ToString() + ",";

            }

        }
    }
}
