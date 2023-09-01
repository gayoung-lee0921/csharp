using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 트리뷰
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 문자열을 트리뷰에 넣을 수 있도록 가공해주는 객체
            TreeNode node1 = new TreeNode(txtNode.Text);
            // 선택한 노드가 있다면 선택한 노드에 추가
            if(treeView1.SelectedNode != null && treeView1.SelectedNode.IsSelected)
            {
                treeView1.SelectedNode.Nodes.Add(node1);
            }
            else
            // 선택한 노드가 없다면 동일 선상에 추가됨
            {
                treeView1.Nodes.Add(node1);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.IsSelected) 
            { 
                treeView1.SelectedNode.Remove();
            }

        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
