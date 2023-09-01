using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 로또번호
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLotto_Click(object sender, EventArgs e)
        {
            int[] lottoArr = new int[6];

            for (int i = 0; i < lottoArr.Length; i++)
            {
                Random num = new Random();
                int selected = num.Next(1, 46);
                lottoArr[i] = selected;
                lblResult.Text += lottoArr[i];
            }
            

            

        }
    }
}
