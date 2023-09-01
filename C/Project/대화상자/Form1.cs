using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 대화상자
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            ModalForm modal = new ModalForm();
            modal.ShowDialog();
        }

        private void btnModalless_Click(object sender, EventArgs e)
        {
            ModallessForm modalless = new ModallessForm();
            modalless.str = textBox1.Text;
            modalless.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // openFileDialog1은 openFileDialog의 인스턴스
            // ShowDialog() 파일 대화상자를 여는 메소드 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName+"파일을 엽니다";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   // 파일 형식을 넣어주는 코드
            saveFileDialog1.Filter = "All file(*.*)|(*.*)";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName + "파일을 저장합니다";

            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {   // 내가 선택한 폰트를 적용 시켜라
                 textBox2.Font=fontDialog1.Font;
            }          
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.ForeColor = colorDialog1.Color;
            }
        }
    }
}
