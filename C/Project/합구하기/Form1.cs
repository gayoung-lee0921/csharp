using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 합구하기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);
            int sum = 0;
            int plusCount = 0;
            for(int i=1; i<= input; i++)
            {
                sum += i;
                plusCount++;
            }
            //label1.Text = "1부터" + input.ToString() + "까지의 합 : "+ sum.ToString();
            //label2.Text = "수행한 횟수 : " + (plusCount-1).ToString() + "번";
            label1.Text = string.Format("1부터 {0}까지의 합 : {1}", input, sum);
            label2.Text = string.Format("수행한 횟수 : {0}번", plusCount - 1);
        }
    }
}
