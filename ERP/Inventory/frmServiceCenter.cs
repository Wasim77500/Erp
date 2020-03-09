
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmServiceCenter : MyForm
    {
        public frmServiceCenter()
        {
            InitializeComponent();
        }

        private void frmServiceCenter_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            PrepareForm();
        }
        private void PrepareForm()
        {
            btnUpdate.Enabled = false;
            glb_function.FillListWithId(ref lstSC_LOCTION, "location", "LOCATION_NAME");
            glb_function.FillListWithId(ref lstBRANCH_ID, "branches", "branch_aname");
            glb_function.FillList(ref lstSC_TYPE, "SERVICE_CENTER", "SC_TYPE");
            SetPrivilleges();
          
            

        }
        private void SetPrivilleges()
        {
            //Branch Priv
            if (lstTempBranch.Text == "1000")
            {
                lstBRANCH_ID.Enabled = true;
                lstBRANCH_ID.SelectedIndex = -1;
            }

            else if (lstTempBranch.Text == "2000")
            {
                lstBRANCH_ID.SelectedValue = Convert.ToInt16(glb_function.glb_BranchNo);
                lstBRANCH_ID.Enabled = false;
            }

            else if (lstTempBranch.Text != "")
            {
                lstBRANCH_ID.SelectedValue = Convert.ToInt16(lstTempBranch.Text);
                lstBRANCH_ID.Enabled = false;
            }


            else
            {
                glb_function.MsgBox("حدث خطأ اثناء استحضار بيانات الفرع");
                this.Close();
            }



        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            //Item Information
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetSwid = cnn.GetDataTable("(select nvl(max(swid),0)+1 from SERVICE_CENTER)");
            txtSWID.Text = dtGetSwid.Rows[0][0].ToString();

            glb_function.arrInsertLogs.Add("insert into SERVICE_CENTER values (" + txtSWID.Text + "," +
                glb_function.glb_strUserId + ",sysdate,'فعال','"+ txtSC_NAME .Text + "','"+ lstSC_TYPE .Text + "',"+ lstSC_LOCTION .SelectedValue.ToString()+ ","+ lstBRANCH_ID .SelectedValue.ToString()+ ","+ txtCOST_CENTER_ID .Text + ")");


           

            if (glb_function.MultiTransData())
                GetData(txtSWID.Text);
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;


            if (txtSC_NAME.Text.Trim() == "")
            {

                errCheck.SetError(txtSC_NAME, "الرجاء ادخال اسم مركز الخدمة ");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtSC_NAME, "");
            }

            if (lstSC_LOCTION.SelectedIndex == -1)
            {

                errCheck.SetError(lstSC_LOCTION, "الرجاء اختيار الموقع");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstSC_LOCTION, "");
            }

            if (lstBRANCH_ID.SelectedIndex == -1)
            {

                errCheck.SetError(lstBRANCH_ID, "الرجاء اختيار الفرع");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstBRANCH_ID, "");
            }


           
          

   

            if (iError == 1)
                return false;

            return true;
        }
        private void GetData(string strSwid)
        {
            if (lstBRANCH_ID.Enabled == true)
                lstBRANCH_ID.SelectedIndex = -1;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtWareHouse = cnn.GetDataTable("select * from SERVICE_CENTER where swid=" + strSwid);




            txtSWID.Text = strSwid;

            txtSC_NAME.Text = dtWareHouse.Rows[0]["SC_NAME"].ToString();
            txtSC_NAME.W_OldValue = dtWareHouse.Rows[0]["SC_NAME"].ToString();

            lstSC_TYPE.Text = dtWareHouse.Rows[0]["SC_TYPE"].ToString();
            lstSC_TYPE.W_OldValue = dtWareHouse.Rows[0]["SC_TYPE"].ToString();

            lstBRANCH_ID.Text = dtWareHouse.Rows[0]["BRANCH_ID"].ToString();
            lstBRANCH_ID.W_OldValue = dtWareHouse.Rows[0]["BRANCH_ID"].ToString();

         

            lstSC_LOCTION.Text = dtWareHouse.Rows[0]["SC_LOCTION"].ToString();
            lstSC_LOCTION.W_OldValue = dtWareHouse.Rows[0]["SC_LOCTION"].ToString();

            txtCOST_CENTER_ID.Text = dtWareHouse.Rows[0]["COST_CENTER_ID"].ToString();
            txtCOST_CENTER_ID.W_OldValue = dtWareHouse.Rows[0]["COST_CENTER_ID"].ToString();

            if(txtCOST_CENTER_ID.Text.Trim()!="")
            {
                dtWareHouse.Rows.Clear();
                dtWareHouse = cnn.GetDataTable("select m.cost_center_no,c.cost_center_name from costcenter_map m,costcenter c " +
                             "   where c.swid = m.cost_center_id " +
                              "  and m.swid = "+ txtCOST_CENTER_ID.Text.Trim());

                txtCOST_CENTER.Text = dtWareHouse.Rows[0][0].ToString();

            }
          



            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
           
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;


        }

        private void btnGetCostCenter_Click(object sender, EventArgs e)
        {
           // if(lstBRANCH_ID.SelectedIndex ==-1)
           // {
           //     glb_function.MsgBox("الرجاء اختيار الفرع اولا");
           //     lstBRANCH_ID.Focus();
           //     return;

           // }

           //Accounts. frmGetCostCenter frm = new Accounts.frmGetCostCenter();
           // frm.Branch = lstBRANCH_ID.SelectedValue .ToString();

           // frm.ShowDialog();
           // txtCOST_CENTER_ID.Text = frm.txtMapSWID.Text;
           // txtCOST_CENTER.Text = frm.txtCOST_CENTER_NoMap.Text + "-" + frm.lstCOST_CENTER_TYPEMap.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update SERVICE_CENTER set " +
                " SC_NAME='" + txtSC_NAME.Text + "',SC_TYPE='" + lstSC_TYPE.Text + "',SC_LOCTION=" + lstSC_LOCTION.SelectedValue.ToString() +
                ",BRANCH_ID=" + lstBRANCH_ID.SelectedValue.ToString() + ",COST_CENTER_ID=" + txtCOST_CENTER_ID.Text + 
                "  where swid=" + txtSWID.Text);

            new glb_function().InsertToLogs(this, "SERVICE_CENTER", txtSWID.Text, "");
          



            if (glb_function.MultiTransData())

                GetData(txtSWID.Text);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           frmFindServiceCenter frm = new frmFindServiceCenter();

            frm.ShowDialog();

            if (frm.strServiceCenterId .Trim() != "")
            {
                txtSWID.Text = frm.strServiceCenterId;
                GetData(txtSWID.Text);
            }
        }
    }
}
