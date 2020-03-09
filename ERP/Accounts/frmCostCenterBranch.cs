using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmCostCenterBranch : ERP.MyForm
    {
        private DataTable dtPrepareItemTree;
        private DataTable dtTreePrint;
        public string strCostCenterSwid;
        public string strCostCenterName;
        public string strWhere = "";
        public string strType;
        public frmCostCenterBranch()
        {
            InitializeComponent();
        }

        private void frmCostCenterTree_Load(object sender, EventArgs e)
        {
            FillBranchTree();
          
        }
        private void FillBranchTree()
        {
            dtPrepareItemTree = new DataTable();
            ConnectionToDB cnn = new ConnectionToDB();

            dtPrepareItemTree.Rows.Clear();

            dtPrepareItemTree = cnn.GetDataTable("select bc.swid,nvl(DIRECT_BRANCH_COST_CENTER_ID,0) Branch_PARENT_ID,nvl(direct_adminstration_parent_id,0) ADMINI_PARENT_ID, BRANCH_COST_CENTER_NAME,bc.costcenter_type_id,t.branch,t.administration " +
                                               "  from BRANCHES_COSTCENTER bc " +
                                               "  join cost_center_types t on (bc.costcenter_type_id = t.swid) where '1'='1' " + strWhere +
                                                "  order by  bc.swid");

            tvCostCenterTree.Nodes.Clear();
            PopulateTreeView(0, null);

        }
     
        private void PopulateTreeView(int parentId, TreeNodeAdv parentNode)

        {


            TreeNodeAdv childNode;

           // string strColmName = (strType == "Branch" ? "Branch_PARENT_ID" : "ADMINI_PARENT_ID");
            //foreach (DataRow dr in dtPrepareItemTree.Select("["+strColmName+"]=" + parentId))
           foreach (DataRow dr in dtPrepareItemTree.Select("[Branch_PARENT_ID]=" + parentId))
                {

                TreeNodeAdv t = new TreeNodeAdv();
               
                t.Text = dr["BRANCH_COST_CENTER_NAME"].ToString();
              

                t.Tag = dtPrepareItemTree.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    tvCostCenterTree.Nodes.Add(t);
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

       
        private void tvCostCenterTree_NodeMouseDoubleClick(object sender, TreeViewAdvMouseClickEventArgs e)
        {
           
                strCostCenterSwid = dtPrepareItemTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["swid"].ToString();
            strCostCenterName= dtPrepareItemTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["BRANCH_COST_CENTER_NAME"].ToString();
            this.Close();


            
        }
        int icheckFind = 0;
        private void btnGetNode_Click(object sender, EventArgs e)
        {
            tvCostCenterTree.CollapseAll();

            SearchTree(tvCostCenterTree.Nodes, txtNodeName.Text);

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


                    tvCostCenterTree.SelectedNode = node;
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
            if (e.KeyValue == 13)
                btnGetNode_Click(null, null);
        }

        
    }
}
