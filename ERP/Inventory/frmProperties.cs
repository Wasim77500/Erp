
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmProperties : MyForm
    {
        private string strtemp;

        public frmProperties()
        {
            InitializeComponent();
        }

        private void frmProperties_Load(object sender, EventArgs e)
        {
            strtemp = "";
            btnUpdate.Enabled = false;
            FillProperties();
        }
        private void FillProperties()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBenef = cnn.GetDataTable("select swid,Property_name from Properties  order by Property_name");
            lstProperty_name.DataSource = dtBenef;
            lstProperty_name.ValueMember = "swid";
            lstProperty_name.DisplayMember = "Property_name";
            lstProperty_name.SelectedIndex = -1;
        }

        private void lstProperty_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProperty_name.SelectedValue == null)
            {

                lstProperty_name.Text = "";
                txtSWID.Text = "";
                btnUpdate.Enabled = false;
              
                btnNew.Visible = false;
                btnSave.Visible = true;
                return;
            }




            if (lstProperty_name.SelectedValue.ToString() != "System.Data.DataRowView" && lstProperty_name.SelectedValue.ToString() != "")
            {
                if (strtemp == "")
                {
                    strtemp = lstProperty_name.SelectedValue.ToString();
                    new glb_function().clearItems(this);
                    txtSWID.Text = strtemp;
                    GetData(txtSWID.Text);
                    strtemp = "";

                }


            }
        }
        private void GetData(string strId)
        {


            lstProperty_name.Text = "";
            txtSWID.Text = "";

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select * from Properties where swid=" + strId);

            txtSWID.Text = strId;

            lstProperty_name.Text = dtLocation.Rows[0]["Property_name"].ToString();
            lstProperty_name.W_OldValue = dtLocation.Rows[0]["Property_name"].ToString();


            lstPROPERTY_TYPE.Text = dtLocation.Rows[0]["PROPERTY_TYPE"].ToString();
            lstPROPERTY_TYPE.W_OldValue = dtLocation.Rows[0]["PROPERTY_TYPE"].ToString();

            txtPROPERTY_NAME_EN.Text = dtLocation.Rows[0]["PROPERTY_NAME_EN"].ToString();
            txtPROPERTY_NAME_EN.W_OldValue = dtLocation.Rows[0]["PROPERTY_NAME_EN"].ToString();


            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtSwid = cnn.GetDataTable("select nvl(max(swid),0)+1 from properties");
            txtSWID.Text = dtSwid.Rows[0][0].ToString();
            int icheck = cnn.TranDataToDB("insert into properties values(" + txtSWID.Text + ",sysdate,"+glb_function.glb_strUserId+",'فعال','"+lstProperty_name.Text.Replace(@"\","-").Replace("/","-") +"','"+lstPROPERTY_TYPE.Text +"','"+ txtPROPERTY_NAME_EN .Text.Trim().Replace(@"\", "-").Replace("/", "-") + "')");

            if(icheck <=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء العملية.");
                return;
            }
            cnn.glb_commitTransaction();

            glb_function.MsgBox("تمت العملية بنجاح");
            string strSwid = txtSWID.Text.Trim();
       
            FillProperties();
            GetData(strSwid);
           

        }
        
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (lstProperty_name .Text.Trim() == "")
            {

                errCheck.SetError(lstProperty_name, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstProperty_name, "");
            }

            if (iError == 1)
                return false;


            return true; 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstProperty_name.Text = "";
            txtSWID.Text = "";
            strtemp = "";
            txtPROPERTY_NAME_EN.Text = "";
            btnUpdate.Enabled = false;
            FillProperties();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update properties set Property_name='" + lstProperty_name.Text.Replace(@"\", "-").Replace("/", "-") + "',PROPERTY_TYPE='"+lstPROPERTY_TYPE.Text + "',PROPERTY_NAME_EN='"+ txtPROPERTY_NAME_EN .Text .Trim().Replace(@"\", "-").Replace("/", "-") + "'" +
                "  where swid=" + txtSWID.Text);

            new glb_function().InsertToLogs(this, "properties", txtSWID.Text, "");
            //other table 

            if (glb_function.MultiTransData())

                GetData(txtSWID.Text);
        }
    }
}
