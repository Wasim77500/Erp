
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
    public partial class frmCostCenter : MyForm
    {
        //private string strtemp;
        //DataTable dtPrepareCCTree;
        private DataTable dtPrepareItemTree;
        bool bLoad = false;
        public frmCostCenter()
        {
            InitializeComponent();
        }

        private void frmCostCenter_Load(object sender, EventArgs e)
        {
            bLoad = true;
            PrepareForm();
            bLoad = false;
        }
        private void PrepareForm()
        {

            FillCostType();
            FillItemTree();
        }
        private void FillItemTree()
        {
            dtPrepareItemTree = new DataTable();
            ConnectionToDB cnn = new ConnectionToDB();

            dtPrepareItemTree.Rows.Clear();

            dtPrepareItemTree = cnn.GetDataTable("select bc.swid,nvl(DIRECT_BRANCH_COST_CENTER_ID,0) Branch_PARENT_ID,nvl(direct_adminstration_parent_id,0) ADMINI_PARENT_ID, BRANCH_COST_CENTER_NAME||' ('|| type_name || ')' NameWithType,  BRANCH_COST_CENTER_NAME,bc.costcenter_type_id,t.branch,t.administration " +
                                               "  from BRANCHES_COSTCENTER bc " +
                                               "  join cost_center_types t on (bc.costcenter_type_id = t.swid) where 1=1 " +
                                                "  order by  bc.swid");

            tvCostCenterTree.Nodes.Clear();
            PopulateTreeView(0, null);

        }
        private void PopulateTreeView(int parentId, TreeNodeAdv parentNode)

        {


            TreeNodeAdv childNode;

            foreach (DataRow dr in dtPrepareItemTree.Select("[Branch_PARENT_ID]=" + parentId))

            {

                TreeNodeAdv t = new TreeNodeAdv();

                t.Text = dr["NameWithType"].ToString();


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

        private void FillCostType()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCostType = cnn.GetDataTable("select swid,type_name from COST_CENTER_TYPES");


            lstCOSTCENTER_TYPE_ID.DataSource = dtCostType;
            lstCOSTCENTER_TYPE_ID.ValueMember = "swid";
            lstCOSTCENTER_TYPE_ID.DisplayMember = "type_name";

            lstCOSTCENTER_TYPE_ID.SelectedIndex = -1;
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;

            if (lstCOSTCENTER_TYPE_ID.SelectedIndex ==-1)
            {

                errCheck.SetError(lstCOSTCENTER_TYPE_ID, "الرجاء اختيار النوع");
                lstCOSTCENTER_TYPE_ID.Focus();
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstCOSTCENTER_TYPE_ID, "");
            }

           



            if (txtCostCenterName.Text == "")
            {

                errCheck.SetError(txtCostCenterName, "الرجاء ادخال الاسم");
                txtCostCenterName.Focus();
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtCostCenterName, "");
            }

            if(txtBranch.Text.Trim()=="1")
            {
                if (txtNo.Text == "")
                {

                    errCheck.SetError(txtNo, "الرجاء ادخال الرقم");
                    txtCostCenterName.Focus();
                    iError = 1;
                }
                else
                {
                    errCheck.SetError(txtNo, "");

                    ConnectionToDB cnn = new ConnectionToDB();
                    DataTable dtCheckBranch = cnn.GetDataTable("select b.branch_cost_center_name, b.branch_cost_center_no ,t.branch " +
                                        " from BRANCHES_COSTCENTER b " +
                                       "  join cost_center_types t on (b.costcenter_type_id = t.swid) " +
                                       "  where branch = 1 " +
                                      "   and b.branch_cost_center_no = "+txtNo.Text.Trim());

                    if(dtCheckBranch.Rows.Count >0)
                    {
                        glb_function.MsgBox("رقم الفرع مكرر");
                        return false;
                    }
                }
            }

            if(txtMainBranchId.Text .Trim()!="")
            {
                if (txtDirectBranchId.Text.Trim() == "")
                {

                    errCheck.SetError(txtDirectBranchName, "الرجاء اختيار الاب المباشر");
                    lstCOSTCENTER_TYPE_ID.Focus();
                    iError = 1;
                }
                else
                {
                    errCheck.SetError(txtDirectBranchName, "");
                }



                if (txtDirectAdministrationId.Text.Trim() == "")
                {

                    errCheck.SetError(txtDirectAdministration, "الرجاء اختيار الادارة المباشر");
                    lstCOSTCENTER_TYPE_ID.Focus();
                    iError = 1;
                }
                else
                {
                    errCheck.SetError(txtDirectAdministration, "");
                }

            }
            else
            {
                if (txtBranch.Text.Trim() == "1" && txtAdministration.Text.Trim() == "1")
                {
                   
                }
                   
                else
                {
                    glb_function.MsgBox("لايمكن اضافة قائمة اساسية من هذا النوع");
                    return false;
                }
            }
            if (txtBranch.Text.Trim() == "1")
            {
             string strBranch=   GetBranchParentById(txtDirectBranchId.Text);
                if(strBranch =="0")
                {
                    glb_function.MsgBox("لايمكن اضافة النوع الى هذا الفرع");
                    return false;
                }
            }
 

            if (iError == 1)
                return false;

            return true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;
            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into BRANCHES_COSTCENTER values" +
                "((select nvl(max(swid),0)+1 from BRANCHES_COSTCENTER),"+glb_function.glb_strUserId+",sysdate,'فعال',"+
                lstCOSTCENTER_TYPE_ID.SelectedValue.ToString()+","+
                 (txtDirectBranchId.Text.Trim() == "" ? "null" : txtDirectBranchId.Text.Trim()) +
               
                "," +
                (txtDirectAdministrationId.Text.Trim() == "" ? "null" : txtDirectAdministrationId.Text.Trim()) +
                "," +
                (txtMainBranchId.Text.Trim() == "" ? "null" : txtMainBranchId.Text.Trim()) +
                ",'" +
                txtCostCenterName.Text .Trim()+"',"+(txtContactId.Text.Trim()==""?"null": txtContactId.Text.Trim())+",'"+txtNote.Text.Trim()+"','"+txtNo.Text.Trim()+"')");

            if(icheck<=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الحفظ");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الاضافة بنجاح");

            new glb_function().clearItems(this);
            PrepareForm();
        }

        private void btnMainBranch_Click(object sender, EventArgs e)
        {
           
               
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            File.frmContacts frm = new File.frmContacts();
            frm.ShowDialog();

            txtContactId.Text = frm.txtSWID.Text;
            txtContactName.Text = frm.txtADB_NAME.Text;
        }

        private string  GetCostNameById(string strCostCenterid)
        {
            string strCostCenterName = "";

            for (int i = 0; i < dtPrepareItemTree.Rows.Count; i++)
            {
                if (dtPrepareItemTree.Rows[i]["swid"].ToString() == strCostCenterid)
                {

                    strCostCenterName= dtPrepareItemTree.Rows[i]["BRANCH_COST_CENTER_NAME"].ToString();
                    return strCostCenterName;


                }

            }
            return strCostCenterName;

        }
        private string GetBranchParentById(string strCostCenterid)
        {
            string strCostCenterBranch = "";

            for (int i = 0; i < dtPrepareItemTree.Rows.Count; i++)
            {
                if (dtPrepareItemTree.Rows[i]["swid"].ToString() == strCostCenterid)
                {

                    strCostCenterBranch = dtPrepareItemTree.Rows[i]["branch"].ToString();
                    return strCostCenterBranch;


                }

            }
            return strCostCenterBranch;

        }
        private string GetCostParentById(string strCostCenterid)
        {
            string strCostCenterParent = "";

           
            return strCostCenterParent;

        }

        private void btnDirectAdministration_Click(object sender, EventArgs e)
        {
          
            frmCostCenterTree frm = new frmCostCenterTree();
          
            frm.ShowDialog();
            if (frm.strCostCenterSwid != "")
            {
                txtDirectAdministrationId.Text = frm.strCostCenterSwid;
                txtDirectAdministration.Text = frm.strCostCenterName;
            }



        }

        private void tvCostCenterTree_NodeMouseClick(object sender, TreeViewAdvMouseClickEventArgs e)
        {
            txtDirectBranchId.Text = dtPrepareItemTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["swid"].ToString();
            txtDirectBranchName.Text = GetCostNameById(txtDirectBranchId.Text);

            txtMainBranchId.Text = GetNearestBranch(dtPrepareItemTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["swid"].ToString());
            txtMainBranchName.Text = GetCostNameById(txtMainBranchId.Text);
        }
        private string GetNearestBranch(string strSwid)
        {
            string strFoundId = "";
            if (strSwid == "")
                return "";

            for (int i = 0; i < dtPrepareItemTree.Rows.Count; i++)
            {
                if (dtPrepareItemTree.Rows[i]["swid"].ToString() == strSwid)
                {
                    if (dtPrepareItemTree.Rows[i]["branch"].ToString() == "1")
                    {
                       
                        return dtPrepareItemTree.Rows[i]["swid"].ToString();
                    }
                       
                    else
                    {

                        strFoundId= GetNearestBranch(dtPrepareItemTree.Rows[i]["Branch_PARENT_ID"].ToString());
                        
                    }
                        





                }

            }
            return strFoundId;
        }
        private void lstCOSTCENTER_TYPE_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bLoad ==true || lstCOSTCENTER_TYPE_ID.SelectedValue == null  )
            {
                txtBranch.Text = "";
                txtAdministration.Text = "";
                return;
            }


            if (lstCOSTCENTER_TYPE_ID.SelectedValue.ToString() != "System.Data.DataRowView" && lstCOSTCENTER_TYPE_ID.SelectedValue.ToString() != "")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtCostCentType = cnn.GetDataTable("select t.branch,t.administration from COST_CENTER_TYPES t where t.swid= "+lstCOSTCENTER_TYPE_ID.SelectedValue.ToString());

                txtBranch.Text = dtCostCentType.Rows[0]["branch"].ToString();
                txtAdministration.Text = dtCostCentType.Rows[0]["administration"].ToString();

            }

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //  tvCostCenterTree.ExpandAll();


            ////  tvCostCenterTree.PrintPreview();

            //Image img=  tvCostCenterTree.ToImage();

            //  img.Save(@"C:\images\test.png", System.Drawing.Imaging.ImageFormat.Png);

            int itemp = tvCostCenterTree.Width;
            tvCostCenterTree.Visible = false;
            tvCostCenterTree.Width = 600;
            tvCostCenterTree.ExpandAll();



            tvCostCenterTree.PrintDocument.HeaderText = "الهيكل التنظيمي للشركة";
            tvCostCenterTree.PrintDocument.HeaderAlignment = TextAlignment.Right;

            tvCostCenterTree.PrintDocument.ShowPageNumber = true;

            tvCostCenterTree.PrintDocument.PrintPreview();

            tvCostCenterTree.CollapseAll();
            tvCostCenterTree.Width = itemp;
            tvCostCenterTree.Visible = true;
        }
    }
}
