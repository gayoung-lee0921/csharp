using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textinput1.Text);
            int num2 = int.Parse(textinput2.Text);
            int num3 = num1 + num2;
            lblResult.Text = num3.ToString();

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textinput1.Text);
            int num2 = int.Parse(textinput2.Text);
            int num3 = num1 - num2;
            lblResult.Text = num3.ToString();


        }

        private void btnString_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textinput1.Text);
            int num2 = int.Parse(textinput2.Text);
            int num3 = num1 * num2;
            lblResult.Text = num3.ToString();


        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textinput1.Text);
            int num2 = int.Parse(textinput2.Text);
            int num3 = num1 / num2;
            lblResult.Text = num3.ToString();


        }
    }
}
