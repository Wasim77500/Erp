
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmStandardUnits : MyForm
    {
        private string strtemp;
        public frmStandardUnits()
        {
            InitializeComponent();
        }

        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (lstUNIT_NAME.Text.Trim() == "")
            {

                errCheck.SetError(lstUNIT_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstUNIT_NAME, "");
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
            DataTable dtSwid = cnn.GetDataTable("select nvl(max(swid),0)+1 from STANDARD_UNIT");
            txtSWID.Text = dtSwid.Rows[0][0].ToString();
            int icheck = cnn.TranDataToDB("insert into STANDARD_UNIT values(" + txtSWID.Text + ",'" + lstUNIT_NAME .Text + "')");

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء العملية.");
                return;
            }
            cnn.glb_commitTransaction();

            glb_function.MsgBox("تمت العملية بنجاح");
            string strSwid = txtSWID.Text.Trim();

            FillUnits ();
            GetData(strSwid);

        }

        private void frmStandardUnits_Load(object sender, EventArgs e)
        {
            strtemp = "";
          
            FillUnits();
        }
        private void FillUnits()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBenef = cnn.GetDataTable("select swid,UNIT_NAME from STANDARD_UNIT  order by UNIT_NAME");
            lstUNIT_NAME.DataSource = dtBenef;
            lstUNIT_NAME.ValueMember = "swid";
            lstUNIT_NAME.DisplayMember = "UNIT_NAME";
            lstUNIT_NAME.SelectedIndex = -1;
        }

        private void lstUNIT_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUNIT_NAME.SelectedValue == null)
            {

                lstUNIT_NAME.Text = "";
                txtSWID.Text = "";
                

                btnNew.Visible = false;
                btnSave.Visible = true;
                return;
            }




            if (lstUNIT_NAME.SelectedValue.ToString() != "System.Data.DataRowView" && lstUNIT_NAME.SelectedValue.ToString() != "")
            {
                if (strtemp == "")
                {
                    strtemp = lstUNIT_NAME.SelectedValue.ToString();
                    new glb_function().clearItems(this);
                    txtSWID.Text = strtemp;
                    GetData(txtSWID.Text);
                    strtemp = "";

                }


            }
        }
        private void GetData(string strId)
        {


            lstUNIT_NAME.Text = "";
            txtSWID.Text = "";

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select * from STANDARD_UNIT where swid=" + strId);

            txtSWID.Text = strId;

            lstUNIT_NAME.Text = dtLocation.Rows[0]["UNIT_NAME"].ToString();
            lstUNIT_NAME.W_OldValue = dtLocation.Rows[0]["UNIT_NAME"].ToString();


          

            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            //if (HasPrivilege("btnUpdate"))
            //    btnUpdate.Enabled = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstUNIT_NAME.Text = "";
            txtSWID.Text = "";
            strtemp = "";
           
            FillUnits ();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if(lstUNIT_NAME.SelectedIndex ==-1)
            {
                glb_function.MsgBox("لايمكن عمل تعديل لقيمة غير موجودة في القائمة");
                return;
            }
            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update STANDARD_UNIT set UNIT_NAME='" + lstUNIT_NAME.Text + "' " +
                "  where swid=" + txtSWID.Text);

            new glb_function().InsertToLogs(this, "STANDARD_UNIT", txtSWID.Text, "");
            //other table 

            if (glb_function.MultiTransData())

                GetData(txtSWID.Text);
        }
    }
}
