using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 메뉴
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "새 파일을 만듭니다";
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "파일을 엽니다";

        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "파일을 저장합니다";

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Form1 소멸
        }
    }
}
