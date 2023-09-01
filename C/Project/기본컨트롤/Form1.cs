using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 기본컨트롤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼을 클릭했습니다.");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lblResult.Text = "";

            if (chkTang.Checked == true)
            {
                strOrder += chkTang.Text + "\n";
            }
            if (chkBok.Checked == true)
            {   
                strOrder += chkBok.Text + "\n";
            }
            if (chkFri.Checked == true)
            {
                strOrder += chkFri.Text + "\n";
            }
            lblResult.Text = strOrder;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(radioAgree.Checked == true)
            {
                MessageBox.Show("개인정보 동의하셨습니다.");
            }
            else
            {
                MessageBox.Show("개인정보 동의하지 않았습니다.");

            }
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            string strText = "'"+txtReq.Text + "'\n 라고 요구사항이 접수되었습니다";
            MessageBox.Show(strText);

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string strText = cbPay.Text +"(으)로"+ lbArea.Text + "결제방법을 선택하셨습니다.";
            MessageBox.Show(strText);
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbArea.Items.Clear(); // 이전꺼 삭제
            if(cbPay.SelectedIndex == 0)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월 할부");
                lbArea.Items.Add("6개월 할부");
            } else if(cbPay.SelectedIndex == 1)
            {
                lbArea.Items.Add("하나은행");
                lbArea.Items.Add("국민은행");
                lbArea.Items.Add("우리은행");

            } else if (cbPay.SelectedIndex == 2)
            {
                lbArea.Items.Add("N포인트 결제");
                lbArea.Items.Add("toss포인트 결제");
                lbArea.Items.Add("L포인트 결제");

            }
        }
    }
}
