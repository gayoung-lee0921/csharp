using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotto
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

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] lottonumbers = new int[6];
            for (int i = 0; i < 6; i++) {
                int randomNumber = random.Next(1, 46);
                // 중복체크
                while (Array.IndexOf(lottonumbers, randomNumber) != -1) {
                    randomNumber = random.Next(1, 46);
                }

                lottonumbers[i] = randomNumber;
            }
            Array.Sort(lottonumbers);
            label1.Text = string.Join(",", lottonumbers);
        }
    }
}
