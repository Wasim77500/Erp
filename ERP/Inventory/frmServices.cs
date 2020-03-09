
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmServices : MyForm
    {
        public frmServices()
        {
            InitializeComponent();
        }

        private void frmServices_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            btnUpdate.Enabled = false;
            glb_function.FillListWithId(ref lstCURRENCY, "currency", "curr_name");
            glb_function.FillList(ref lstPRICE_TYPE, "services", "price_type");
            glb_function.FillListWithId(ref lstACTIVITY_ID, "activities", "act_name");


            GetAcc();
           
        }
        private void GetAcc()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtAccData = new DataTable();
           
            //            dtAccData = cnn.GetDataTable("select distinct a.swid,acc_no,acc_name,acc_type from accounts a ,acc_branch b where a.swid=b.acc_id and  a.stat='فعال' and acc_class='فرعي' and (a.acc_management =N'عام' "+strCenteralAcc + " or b.swid in (select branch_id from user_branches u "+
            //" where user_id = 0))");
            string sql = "select swid,acc_no,acc_name from accounts a where stat='فعال' and acc_class='فرعي'";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            //Item Information
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetSwid = cnn.GetDataTable("(select nvl(max(swid),0)+1 from SERVICES)");
            txtSwid.Text = dtGetSwid.Rows[0][0].ToString();

            glb_function.arrInsertLogs.Add("insert into SERVICES values (" + txtSwid.Text + ",sysdate," +
                glb_function.glb_strUserId + ",'فعال','"+ txtSERVICE_NO .Text + "','"+ txtSERVICE_NAME.Text + "',"+
                lstCURRENCY.SelectedValue.ToString()+
                ",'"+lstPRICE_TYPE.Text +"',"+ nmbPRICE .Value .ToString()+ ","+ nmbCOST .Value.ToString()+
                ",'"+txtUNIT.Text +"','"+(ckbAPPEAR_IN_SALES.Checked ?"1":"0")+"','"+txtS_NOTES.Text +"',"+
                lstAccNo.SelectedValue.ToString()+","+lstACTIVITY_ID.SelectedValue.ToString()+")");


          

            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;


            if (txtSERVICE_NO.Text.Trim() == "")
            {

                errCheck.SetError(txtSERVICE_NO, "الرجاء ادخال رقم الخدمة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtSERVICE_NO, "");
            }


            if (txtSERVICE_NAME.Text.Trim() == "")
            {

                errCheck.SetError(txtSERVICE_NAME, "الرجاء ادخال اسم الخدمة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtSERVICE_NAME, "");
            }
            if (lstACTIVITY_ID .SelectedIndex == -1)
            {

                errCheck.SetError(lstACTIVITY_ID, "الرجاء اختيار النشاط");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstACTIVITY_ID, "");
            }



            if (lstCURRENCY.SelectedIndex == -1)
            {

                errCheck.SetError(lstCURRENCY, "الرجاء اختيار العملة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstCURRENCY, "");
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

            if (lstACTIVITY_ID.SelectedIndex == -1)
            {

                errCheck.SetError(lstACTIVITY_ID, "يجب ادخال النشاط ");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstACTIVITY_ID, "");
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

            if (nmbPRICE.Value <= 0)
            {
                errCheck.SetError(nmbPRICE, "الرجاء ادخال سعر الخدمة");
                iError = 1;
            }
            else
                errCheck.SetError(nmbPRICE, "");

            if (iError == 1)
                return false;

            return true;
        }
        private void GetData(string strSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtWareHouse = cnn.GetDataTable("select * from SERVICES where swid=" + strSwid);




            txtSwid.Text = strSwid;

            txtSERVICE_NO.Text = dtWareHouse.Rows[0]["SERVICE_NO"].ToString();
            txtSERVICE_NO.W_OldValue = dtWareHouse.Rows[0]["SERVICE_NO"].ToString();

            txtSERVICE_NAME.Text = dtWareHouse.Rows[0]["SERVICE_NAME"].ToString();
            txtSERVICE_NAME.W_OldValue = dtWareHouse.Rows[0]["SERVICE_NAME"].ToString();

            lstCURRENCY.SelectedValue  = dtWareHouse.Rows[0]["CURRENCY"].ToString();
            lstCURRENCY.W_OldValue = dtWareHouse.Rows[0]["CURRENCY"].ToString();

            lstPRICE_TYPE.Text = dtWareHouse.Rows[0]["PRICE_TYPE"].ToString();
            lstPRICE_TYPE.W_OldValue = dtWareHouse.Rows[0]["PRICE_TYPE"].ToString();



            nmbPRICE.Value  =Convert.ToDecimal( dtWareHouse.Rows[0]["PRICE"].ToString());
            nmbPRICE.W_OldValue = dtWareHouse.Rows[0]["PRICE"].ToString();


            nmbCOST.Value  = Convert.ToDecimal(dtWareHouse.Rows[0]["COST"].ToString());
            nmbCOST.W_OldValue = dtWareHouse.Rows[0]["COST"].ToString();





            txtUNIT.Text = dtWareHouse.Rows[0]["UNIT"].ToString().Trim() ;
            txtUNIT.W_OldValue = (dtWareHouse.Rows[0]["UNIT"].ToString());

            ckbAPPEAR_IN_SALES.Checked = (dtWareHouse.Rows[0]["APPEAR_IN_SALES"].ToString().Trim() == "1" ? true  :false );
            ckbAPPEAR_IN_SALES.W_OldValue = (dtWareHouse.Rows[0]["APPEAR_IN_SALES"].ToString().Trim() == "1" ? "1" : "0");


            txtS_NOTES.Text = dtWareHouse.Rows[0]["S_NOTES"].ToString().Trim();
            txtS_NOTES.W_OldValue = (dtWareHouse.Rows[0]["S_NOTES"].ToString());

            lstAccNo.SelectedValue =   dtWareHouse.Rows[0]["ACC_ID"].ToString().Trim();
            lstAccNo.W_OldValue = (dtWareHouse.Rows[0]["ACC_ID"].ToString());

            lstACTIVITY_ID.SelectedValue = dtWareHouse.Rows[0]["ACTIVITY_ID"].ToString().Trim();
            lstACTIVITY_ID.W_OldValue = (dtWareHouse.Rows[0]["ACTIVITY_ID"].ToString());

            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
           
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

          
           
          

            glb_function.arrInsertLogs.Add("update SERVICES set SERVICE_NO='" + txtSERVICE_NO.Text + "',SERVICE_NAME='" + txtSERVICE_NAME.Text + "',CURRENCY=" +
                lstCURRENCY.SelectedValue.ToString() +
                ",PRICE_TYPE='" + lstPRICE_TYPE.Text + "',PRICE=" + nmbPRICE.Value.ToString() + ",COST=" + nmbCOST.Value.ToString() +
                ",UNIT='" + txtUNIT.Text + "',APPEAR_IN_SALES='" + (ckbAPPEAR_IN_SALES.Checked ? "1" : "0") + "',S_NOTES='" + txtS_NOTES.Text + "',AccNo=" +
                lstAccNo.SelectedValue.ToString() + ",ACTIVITY_ID=" + lstACTIVITY_ID.SelectedValue.ToString()+" where swid="+txtSwid.Text );


            new glb_function().InsertToLogs(this, "SERVICES", txtSwid.Text, "");

            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindServices frm = new frmFindServices();

            frm.ShowDialog();

            if (frm.strServiceID.Trim() != "")
            {
                txtSwid.Text = frm.strServiceID;
                GetData(txtSwid.Text);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);


            PrepareForm();

            btnNew.Visible = false;
            btnSave.Visible = true;
        }
    }
}
