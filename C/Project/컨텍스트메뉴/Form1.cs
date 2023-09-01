using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 컨텍스트메뉴
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "복사완료";
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "붙여넣기";

        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "잘라내기";

        }
    }
}
