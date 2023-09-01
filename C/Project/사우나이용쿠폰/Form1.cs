using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 사우나이용쿠폰
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int coupon = 10;
        private void btnCoupon_Click(object sender, EventArgs e)
        {
            coupon--;
            
            if(coupon<10 && coupon>0)
            {
                lblResult.Text += coupon.ToString() +"회 남았습니다" + "\r\n";
            }
            else
            {
                lblResult.Text += "모든 이용 쿠폰을 소진하였습니다\r\n";
            }

        }
    }
}
