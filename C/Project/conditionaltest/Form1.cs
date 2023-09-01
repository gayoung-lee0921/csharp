using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conditionaltest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox1.Text);
            if(age <=15 || age >= 65)
            {
                lblResult.Text = "할인대상입니다.";
            } else if(age<0 || age > 120)
            {
                lblResult.Text = "유효하지 않은 값입니다.";

            }
            else
            {
                lblResult.Text = "할인대상이 아닙니다.";

            }
        }
    }
}
