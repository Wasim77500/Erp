using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmCatagoriesTree : ERP.MyForm
    {
        private DataTable dtPrepareItemTree;
        public string strCatSwid;
        public frmCatagoriesTree()
        {
            InitializeComponent();
        }

        private void frmCatagoriesTree_Load(object sender, EventArgs e)
        {
            FillItemTree();
        }
        private void FillItemTree()
        {
            dtPrepareItemTree = new DataTable();
            ConnectionToDB cnn = new ConnectionToDB();

            dtPrepareItemTree.Rows.Clear();

            dtPrepareItemTree = cnn.GetDataTable("select swid,nvl(PARENT_ID,0) PARENT_ID,CATEGORY_NAME,CATEGORY_CLASS from CATEGORIES order by swid");

            tvItemsTree.Nodes.Clear();
            PopulateTreeView(0, null);

        }

        private void PopulateTreeView(int parentId, TreeNodeAdv parentNode)

        {


            TreeNodeAdv childNode;


            foreach (DataRow dr in dtPrepareItemTree.Select("[PARENT_ID]=" + parentId))

            {

                TreeNodeAdv t = new TreeNodeAdv();
                t.Text = dr["CATEGORY_NAME"].ToString();


                t.Tag = dtPrepareItemTree.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    tvItemsTree.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView(Convert.ToInt32(dr["swid"].ToString()), childNode);

            }

        }

        private void tvItemsTree_NodeMouseDoubleClick(object sender, TreeViewAdvMouseClickEventArgs e)
        {
            if (dtPrepareItemTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["CATEGORY_CLASS"].ToString() == "فرعي")
            {
                 strCatSwid= dtPrepareItemTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["swid"].ToString();
                this.Close();
                
             
            }
        }

        int icheckFind = 0;
        private void btnGetNode_Click(object sender, EventArgs e)
        {
            tvItemsTree.CollapseAll();

            SearchTree(tvItemsTree.Nodes, txtNodeName.Text);

            if (icheckFind == 0)
                glb_function.MsgBox("لم يتم العثور على اسم مطابق");


            icheckFind = 0;
        }
        private TreeNodeAdv SearchTree(TreeNodeAdvCollection nodes, string searchtext)
        {
            foreach (TreeNodeAdv node in nodes)
            {

                //if (node.Text == searchtext)
                if (node.Text.Contains(searchtext))
                {


                    node.TextColor = System.Drawing.Color.Red;


                    tvItemsTree.SelectedNode = node;
                    icheckFind++;

                    // return node;

                }
                else
                    node.TextColor = System.Drawing.Color.Black;
                SearchTree(node.Nodes, searchtext);
            }

            return null;
        }

        private void txtNodeName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
                btnGetNode_Click(null, null);
        }
    }
}
