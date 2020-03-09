using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ERP.Inventory
{
    public partial class frmUnits : MyForm
    {
        public frmUnits()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBranch = cnn.GetDataTable("select nvl(max(swid),0)+1 from UNITS");

            txtSwid.Text = dtBranch.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("insert into UNITS values("+txtSwid.Text +",'"+(ckbIS_MAIN.Checked ?"1":"0")+
                "','"+txtUNIT_NAME.Text .Trim()+"','"+txtARABIC_CODE.Text.Trim() +"','"+txtEN_CODE.Text .Trim()+"',"+
               nmbUNIT_VALUE.Value.ToString()  +","+ lstSTANDARD_UNIT_ID.SelectedValue.ToString() + ",sysdate,"+glb_function.glb_strUserId +
                ",'فعال')");

            if (glb_function.MultiTransData())
            {
                GetData(txtSwid.Text.Trim());

            }



        }
        private void GetData(string strPk)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select * from UNITS where swid=" + strPk);
            txtSwid.Text = strPk;

            lstSTANDARD_UNIT_ID.SelectedValue  = dtLocation.Rows[0]["STANDARD_UNIT_ID"].ToString();
            lstSTANDARD_UNIT_ID.W_OldValue = dtLocation.Rows[0]["STANDARD_UNIT_ID"].ToString();


            txtUNIT_NAME.Text  = dtLocation.Rows[0]["UNIT_NAME"].ToString();
            txtUNIT_NAME.W_OldValue = dtLocation.Rows[0]["UNIT_NAME"].ToString();

            txtARABIC_CODE.Text = dtLocation.Rows[0]["ARABIC_CODE"].ToString();
            txtARABIC_CODE.W_OldValue = dtLocation.Rows[0]["ARABIC_CODE"].ToString();

            txtEN_CODE.Text = dtLocation.Rows[0]["EN_CODE"].ToString();
            txtEN_CODE.W_OldValue = dtLocation.Rows[0]["EN_CODE"].ToString();

            nmbUNIT_VALUE.Value  =Convert.ToDecimal( dtLocation.Rows[0]["UNIT_VALUE"].ToString());
            nmbUNIT_VALUE.W_OldValue = dtLocation.Rows[0]["UNIT_VALUE"].ToString();

            ckbIS_MAIN.Checked = (dtLocation.Rows[0]["IS_MAIN"].ToString()=="1"?true :false );
            ckbIS_MAIN.W_OldValue = (dtLocation.Rows[0]["IS_MAIN"].ToString() == "1" ? true : false).ToString();

            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;




            if (lstSTANDARD_UNIT_ID.SelectedIndex  == -1)
            {

                errCheck.SetError(lstSTANDARD_UNIT_ID, "الرجاء اختيار الوحدة القياسية");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstSTANDARD_UNIT_ID, "");
            }
           
           
            if(txtUNIT_NAME.Text .Trim()=="")
            {

                errCheck.SetError(txtUNIT_NAME, "الرجاء ادخال رقم الوحدة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtUNIT_NAME, "");
            }


            if(nmbUNIT_VALUE.Value<=0)
            {

                errCheck.SetError(nmbUNIT_VALUE, "الرجاء ادخال القيمة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbUNIT_VALUE, "");
            }



            if (iError == 1)
                return false;

            return true;
        }
        private void btnAddStandardUnit_Click(object sender, EventArgs e)
        {
            frmStandardUnits frm = new frmStandardUnits();
            frm.ShowDialog();
            glb_function.FillListWithId(ref lstSTANDARD_UNIT_ID, "STANDARD_UNIT", "UNIT_NAME");
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            glb_function.FillListWithId(ref lstSTANDARD_UNIT_ID, "STANDARD_UNIT", "UNIT_NAME");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update UNITS set " +
                " STANDARD_UNIT_ID=" + lstSTANDARD_UNIT_ID.SelectedValue.ToString ()+ ", UNIT_NAME='" + txtUNIT_NAME.Text + "',ARABIC_CODE='" + txtARABIC_CODE.Text + "'" +
                ",EN_CODE='" + txtEN_CODE.Text + "' ,UNIT_VALUE="+nmbUNIT_VALUE.Value.ToString() +
                ",IS_MAIN='"+(ckbIS_MAIN.Checked ?"1":"0")+"'"+
                "  where swid=" + txtSwid.Text);

            new glb_function().InsertToLogs(this, "UNITS", txtSwid.Text, "");
            //other table 

            if (glb_function.MultiTransData())

                GetData(txtSwid.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
            ckbIS_MAIN.Checked = false;
        }
    }
}
