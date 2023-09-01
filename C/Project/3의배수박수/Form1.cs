using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3의배수박수
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    lblResult.Text += "박수\n";
                }
                else
                {
                    lblResult.Text += i.ToString()+"\n";
                }

            }
        }
    }
}
