
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
    public partial class frmWareHouse : MyForm
    {
        private DataTable dtPrepareAccTree;

        public frmWareHouse()
        {
            InitializeComponent();
        }

        private void myLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            //Item Information
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetSwid = cnn.GetDataTable("(select nvl(max(swid),0)+1 from WAREHOUSE)");
            txtSWID.Text = dtGetSwid.Rows[0][0].ToString();

            glb_function.arrInsertLogs.Add("insert into WAREHOUSE values (" + txtSWID.Text + "," +
                glb_function.glb_strUserId + ",sysdate,'فعال'," + lstAccNo.SelectedValue.ToString() + "," + nmbW_NO.Value.ToString() +
                ",'" + txtW_NAME.Text + "','" + txtW_DESCRIPTION.Text + "'," + lstW_LOCATION.SelectedValue.ToString() + ",'" +
                txtW_ADDRESS.Text + "'," + lstW_BRANCH.SelectedValue.ToString() + "," +
                (lstSERVICE_CENTER.SelectedIndex == -1 ? "null" : lstSERVICE_CENTER.SelectedValue.ToString()) + ")");


            for (int i = 0; i < dgvUsers.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add("insert into STOREKEEPER values((select nvl(max(swid),0)+1 from STOREKEEPER)," + glb_function.glb_strUserId + ",sysdate,'فعال',(" + txtSWID.Text + ")," + dgvUsers[1, i].Value.ToString() + ",'" + dgvUsers[3, i].Value.ToString() + "')");
            }

            if (glb_function.MultiTransData())
                GetData(txtSWID.Text);

        }
        private void GetData(string strSwid)
        {
            if (lstW_BRANCH.Enabled == true)
                lstW_BRANCH.SelectedIndex = -1;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtWareHouse = cnn.GetDataTable("select * from WAREHOUSE where swid=" + strSwid);




            txtSWID.Text = strSwid;

            nmbW_NO.Text = dtWareHouse.Rows[0]["W_NO"].ToString();
            nmbW_NO.W_OldValue = dtWareHouse.Rows[0]["W_NO"].ToString();

            txtW_NAME.Text = dtWareHouse.Rows[0]["W_NAME"].ToString();
            txtW_NAME.W_OldValue = dtWareHouse.Rows[0]["W_NAME"].ToString();

            txtW_DESCRIPTION.Text = dtWareHouse.Rows[0]["W_DESCRIPTION"].ToString();
            txtW_DESCRIPTION.W_OldValue = dtWareHouse.Rows[0]["W_DESCRIPTION"].ToString();

            txtW_ADDRESS.Text = dtWareHouse.Rows[0]["W_ADDRESS"].ToString();
            txtW_ADDRESS.W_OldValue = dtWareHouse.Rows[0]["W_ADDRESS"].ToString();



            lstW_BRANCH.SelectedValue = dtWareHouse.Rows[0]["W_BRANCH"].ToString();
            lstW_BRANCH.W_OldValue = dtWareHouse.Rows[0]["W_BRANCH"].ToString();


            lstAccNo.SelectedValue = dtWareHouse.Rows[0]["ACC_ID"].ToString();
            lstAccNo.W_OldValue = dtWareHouse.Rows[0]["ACC_ID"].ToString();





            lstW_LOCATION.SelectedValue = (dtWareHouse.Rows[0]["W_LOCATION"].ToString().Trim() == "" ? -1 : Convert.ToInt16(dtWareHouse.Rows[0]["W_LOCATION"].ToString()));
            lstW_LOCATION.W_OldValue = (dtWareHouse.Rows[0]["W_LOCATION"].ToString());

            lstSERVICE_CENTER.SelectedValue = (dtWareHouse.Rows[0]["SERVICE_CENTER"].ToString().Trim() == "" ? -1 : Convert.ToInt16(dtWareHouse.Rows[0]["SERVICE_CENTER"].ToString()));
            lstSERVICE_CENTER.W_OldValue = (dtWareHouse.Rows[0]["SERVICE_CENTER"].ToString());

            dtWareHouse.Rows.Clear();
            dgvUsers.Rows.Clear();
            dtWareHouse = cnn.GetDataTable("select s.swid,s.user_id,u.user_name,s.job from STOREKEEPER s,userinfo u where u.swid=s.user_id and s.warehouse_id=" + txtSWID.Text);
            for (int i = 0; i < dtWareHouse.Rows.Count; i++)
            {
                dgvUsers.Rows.Add();
                dgvUsers[0, dgvUsers.Rows.Count - 1].Value = dtWareHouse.Rows[i]["swid"].ToString();
                dgvUsers[1, dgvUsers.Rows.Count - 1].Value = dtWareHouse.Rows[i]["user_id"].ToString();
                dgvUsers[2, dgvUsers.Rows.Count - 1].Value = dtWareHouse.Rows[i]["user_name"].ToString();
                dgvUsers[3, dgvUsers.Rows.Count - 1].Value = dtWareHouse.Rows[i]["job"].ToString();
            }


            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            txtLOCTION_NAME.Text = "";
            txtCODE.Text = "";
            txtPARENT_Name.Text = "";
            txtPARENT_ID.Text = "";
            txtFULL_LOCTION_CODE.Text = "";
           // btnNewLoacation.Visible = false;
          //  btnAddLocation.Visible = true;
            FillLocationTree();
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }
        private void SetPrivilleges()
        {
            //Branch Priv
            if (lstTempBranch.Text == "1000")
            {
                lstW_BRANCH.Enabled = true;
                lstW_BRANCH.SelectedIndex = -1;
            }

            else if (lstTempBranch.Text == "2000")
            {
                lstW_BRANCH.SelectedValue = Convert.ToInt16(glb_function.glb_BranchNo);
                lstW_BRANCH.Enabled = false;
            }

            else if (lstTempBranch.Text != "")
            {
                lstW_BRANCH.SelectedValue = Convert.ToInt16(lstTempBranch.Text);
                lstW_BRANCH.Enabled = false;
            }


            else
            {
                glb_function.MsgBox("حدث خطأ اثناء استحضار بيانات الفرع");
                this.Close();
            }



        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;


            if (txtW_NAME.Text.Trim() == "")
            {

                errCheck.SetError(txtW_NAME, "الرجاء ادخال اسم المخزن");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtW_NAME, "");
            }

            if (lstW_LOCATION.SelectedIndex == -1)
            {

                errCheck.SetError(lstW_LOCATION, "الرجاء اختيار الموقع");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstW_LOCATION, "");
            }

            if (lstW_BRANCH.SelectedIndex == -1)
            {

                errCheck.SetError(lstW_BRANCH, "الرجاء اختيار الفرع");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstW_BRANCH, "");
            }


            if (dgvUsers.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال موظفين المخزن");
                iError = 1;
            }
            if (lstAccNo.SelectedIndex == -1)
            {

                errCheck.SetError(lstAccNo, "يجب ادخال رقم الحساب ");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstAccNo, "");
            }

            if (lstAccName.SelectedIndex == -1)
            {

                errCheck.SetError(lstAccName, "يجب ادخال اسم الحساب ");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstAccName, "");
            }

            //2**********************************************
            //فحص هل اسم الحساب لديه نفس رقم تعريف رقم الحساب
            //فقط للتاكيد
            if (lstAccNo.SelectedValue == lstAccName.SelectedValue)
            {
                glb_function.MsgBox("الرجاء التاكد ان رقم الحساب يطابقة اسم الحساب");
                return false;
            }
            //2 End****************************************************

            if (iError == 1)
                return false;

            return true;
        }
        private void frmWareHouse_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            PrepareForm();
        }

        private void PrepareForm()
        {
            btnUpdate.Enabled = false;
            glb_function.FillListWithId(ref lstW_LOCATION, "location", "LOCATION_NAME");
            glb_function.FillListWithId(ref lstW_BRANCH, "branches", "branch_aname");
            glb_function.FillListWithId(ref lstUSER_ID, "userinfo", "user_name");
            SetPrivilleges();
            nmbW_NO.Value = GetLastWareHouseNo();
            GetAcc();
            FillLocationTree ();

        }

        private int GetLastWareHouseNo()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt = cnn.GetDataTable("select nvl( max(W_NO),0)+1 from WAREHOUSE t");
            int iBranchNo = Convert.ToInt16(dt.Rows[0][0].ToString());
            return iBranchNo;
        }

        private void GetAcc()
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtAccData = new DataTable();
       
            //            dtAccData = cnn.GetDataTable("select distinct a.swid,acc_no,acc_name,acc_type from accounts a ,acc_branch b where a.swid=b.acc_id and  a.stat='فعال' and acc_class='فرعي' and (a.acc_management =N'عام' "+strCenteralAcc + " or b.swid in (select branch_id from user_branches u "+
            //" where user_id = 0))");
            string sql = "select swid,acc_no,acc_name from accounts a " +
                         " where a.acc_type = 'مخزون' and acc_class='فرعي' and stat='فعال' ";
            dtAccData = cnn.GetDataTable(sql);
            lstAccNo.DataSource = dtAccData;
            lstAccNo.ValueMember = "swid";
            lstAccNo.DisplayMember = "acc_no";


            lstAccName.DataSource = dtAccData;
            lstAccName.ValueMember = "swid";
            lstAccName.DisplayMember = "acc_name";

            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;

        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;

            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
            nmbW_NO.Value = GetLastWareHouseNo();
            txtLOCTION_NAME.Text = "";
            txtCODE.Text = "";
            txtPARENT_Name.Text = "";
            txtPARENT_ID.Text = "";
            txtFULL_LOCTION_CODE.Text = "";
          //  btnNewLoacation.Visible = false;
          //  btnAddLocation.Visible = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!CheckUsersEntries())
                return;

            dgvUsers.Rows.Add();
            dgvUsers[0, dgvUsers.Rows.Count - 1].Value = "";
            dgvUsers[1, dgvUsers.Rows.Count - 1].Value = lstUSER_ID.SelectedValue.ToString();
            dgvUsers[2, dgvUsers.Rows.Count - 1].Value = lstUSER_ID.Text.Trim();
            dgvUsers[3, dgvUsers.Rows.Count - 1].Value = txtJOB.Text;

        }
        private bool CheckUsersEntries()
        {
            int iError = 0;


            if (lstUSER_ID.SelectedIndex == -1)
            {

                errCheck.SetError(lstUSER_ID, "الرجاء اختيار اسم الموظف");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstUSER_ID, "");
            }
            if (txtJOB.Text.Trim() == "")
            {

                errCheck.SetError(txtJOB, "الرجاء ادخال الوظيفة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtJOB, "");
            }

            if (iError == 1)
                return false;

            return true;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update WAREHOUSE set " +
                " ACC_ID=" + lstAccNo.SelectedValue.ToString() + "," + nmbW_NO.Value.ToString() +
                ",W_NAME='" + txtW_NAME.Text + "',W_DESCRIPTION='" + txtW_DESCRIPTION.Text + "',W_LOCATION=" + lstW_LOCATION.SelectedValue.ToString() + ",W_ADDRESS='" +
                txtW_ADDRESS.Text + "',W_BRANCH=" + lstW_BRANCH.SelectedValue.ToString() + ",SERVICE_CENTER=" +
                (lstSERVICE_CENTER.SelectedIndex == -1 ? "null" : lstSERVICE_CENTER.SelectedValue.ToString()) + "" +
                "  where swid=" + txtSWID.Text);

            new glb_function().InsertToLogs(this, "WAREHOUSE", txtSWID.Text, "");
            //other table 

            for (int i = 0; i < dgvUsers.Rows.Count; i++)
            {
                if (dgvUsers[0, i].Value.ToString().Trim() == "")
                    glb_function.arrInsertLogs.Add("insert into STOREKEEPER values((select nvl(max(swid),0)+1 STOREKEEPER)," + glb_function.glb_strUserId + ",sysdate,'فعال',(select nvl(max(swid),0) from WAREHOUSE)," + dgvUsers[1, i].Value.ToString() + ",'" + dgvUsers[3, i].Value.ToString() + "')");
            }



            if (glb_function.MultiTransData())

                GetData(txtSWID.Text);
        }

        private void myLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (!CheckLocationData())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
               ("insert into WAREHOUSE_LOCTION values ((select nvl(max(swid),0)+1 from WAREHOUSE_LOCTION)," +
               " sysdate," + glb_function.glb_strUserId + ",'فعال','" + txtLOCTION_NAME.Text .Trim() + "'," + txtSWID.Text  + ",'" +
               txtCODE .Text + "'," + ( txtPARENT_ID.Text.Trim()==""?"null":txtPARENT_ID.Text.Trim()) + ",'رئيسي','" + txtFULL_LOCTION_CODE .Text  + "')");

            if (glb_function.MultiTransData())
            {
                 FillLocationTree();
             //   btnNewLoacation.Location = btnAddLocation.Location;

                btnNewLoacation_Click(null, null);
            }

        }
        private void FillLocationTree()
        {
            if (txtSWID.Text.Trim() == "")
                return;

            dtPrepareAccTree = new DataTable();
            ConnectionToDB cnn = new ConnectionToDB();
           
            dtPrepareAccTree.Rows.Clear();

            dtPrepareAccTree = cnn.GetDataTable("select swid, created_date, created_user, stat,"+ 
                          "  loction_name, warehouse_id, code, nvl(parent_id, 0) parent_id, loction_class, full_loction_code "+
                          "  from warehouse_loction where warehouse_id=" + txtSWID.Text +
                                    " order by swid ");

            tvLocation.Nodes.Clear();

            
            PopulateTreeView(0, null);

        }
        private void PopulateTreeView(int parentId, TreeNodeAdv parentNode)

        {


            TreeNodeAdv childNode;


            foreach (DataRow dr in dtPrepareAccTree.Select("[parent_id]=" + parentId))

            {

                TreeNodeAdv t = new TreeNodeAdv();
                t.Text = dr["code"].ToString() + " - " + dr["loction_name"].ToString();
                // t.Name = dr["acc_no"].ToString();

                t.Tag = dtPrepareAccTree.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    tvLocation.Nodes.Add(t);
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




        private bool CheckLocationData()
        {
            int iError = 0;

            if(txtSWID.Text .Trim()=="")
            {
                glb_function.MsgBox("الرجاء اختيار المخزن اولا");
                return false;
            }
            if (txtLOCTION_NAME.Text  == "")
            {

                errCheck.SetError(txtLOCTION_NAME, "الرجاء ادخال وصف الموقع");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtLOCTION_NAME, "");
            }

            if (txtCODE.Text == "")
            {

                errCheck.SetError(txtCODE, "الرجاء ادخال رمز الموقع");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtCODE, "");
            }

            if (txtFULL_LOCTION_CODE.Text == "")
            {

                errCheck.SetError(txtFULL_LOCTION_CODE, "الرجاء ادخال الموقع في المخزن");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtFULL_LOCTION_CODE, "");
            }

            if (iError == 1)
                return false;

            return true;
        }

        private void btnNewLoacation_Click(object sender, EventArgs e)
        {
            txtLOCTION_NAME.Text = "";
            txtCODE.Text = "";
            txtPARENT_Name.Text = "";
            txtPARENT_ID.Text = "";
            txtParentFullCode.Text = "";
            txtFULL_LOCTION_CODE.Text = "";
            //btnNewLoacation.Visible = false;
            //btnAddLocation.Visible = true;
        }

        private void pnlGnrlSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindWarehouse frm = new frmFindWarehouse();

            frm.ShowDialog();

            if (frm.strWarehouseId .Trim() != "")
            {
                txtSWID.Text = frm.strWarehouseId;
                GetData(txtSWID.Text);
            }
        }

        private void txtCODE_Leave(object sender, EventArgs e)
        {
            txtFULL_LOCTION_CODE.Text = (txtParentFullCode.Text .Trim()==""?txtCODE.Text : txtParentFullCode.Text + "-" + txtCODE.Text);
        }

        private void tvLocation_NodeMouseClick(object sender, TreeViewAdvMouseClickEventArgs e)
        {
            txtPARENT_ID.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["swid"].ToString();

            txtPARENT_Name.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["code"].ToString() +"-"+ dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["loction_name"].ToString();

            txtParentFullCode.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["full_loction_code"].ToString();

            txtFULL_LOCTION_CODE.Text = (txtParentFullCode.Text.Trim() == "" ? txtCODE.Text : txtParentFullCode.Text + "-" + txtCODE.Text);


           // btnNewLoacation.Location = btnAddLocation.Location;
            //btnAddLocation.Visible = false;
            //btnNewLoacation.Visible = true;

        }

        private void btnUpdateLoacation_Click(object sender, EventArgs e)
        {

        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
