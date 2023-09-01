using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 팩토리얼
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtInsert.Text);
            int sum = 1;
            for(int i = num; i >= 1; i--)
            {
                sum = sum * i;
            }
            lblResult.Text = num+"!="+sum.ToString();

        }
    }
}
