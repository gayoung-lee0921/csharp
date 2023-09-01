using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 고급컨트롤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           if(txtName.Text == "" || txtPhone.Text == "" || txtorg.Text == "")
            {
                MessageBox.Show("입력창을 모두 채워주세요");
            }
            else
            {
                string[] strArry =new string[] { txtName.Text, txtPhone.Text, txtorg.Text };
                ListViewItem lvt = new ListViewItem(strArry); // ListView에 넣을 수 있도록 가공
                listView1.Items.Add(lvt);

                // 등록 버튼을 누르면 기존 정보들을 삭제
                //txtName.Clear();
                //txtPhone.Clear();
                //txtorg.Clear();
            }
              
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIdx = listView1.FocusedItem.Index; //listView1에서 선택한 Index
            listView1.Items.RemoveAt(selectedIdx); //listView1에서 선택된 인덱스 삭제
        }
    }
}
