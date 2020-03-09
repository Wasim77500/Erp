
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmActivities : MyForm
    {
        public frmActivities()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
        }

        private void frmActivities_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            btnUpdate.Enabled = false;
        }
        private bool CheckEntries()
        {

            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
           
            if (txtACT_NAME.Text == "")
            {

                errCheck.SetError(txtACT_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtACT_NAME, "");
            }


            if (lstACT_TYPE.Text == "")
            {

                errCheck.SetError(lstACT_TYPE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstACT_TYPE, "");
            }

            if (txtACT_USER.Text == "")
            {

                errCheck.SetError(txtACT_USER, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtACT_USER, "");
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
            DataTable dtBranch = cnn.GetDataTable("select nvl(max(swid),0)+1 from ACTIVITIES");

            txtSWID.Text = dtBranch.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            //DataTable dtCostCType = cnn.GetDataTable("select value_no,value_name,the_value from default_values " +
            //                           " where value_type = 'CostCenter' and value_name='نشاط'");
            //string str = dtCostCType.Rows[0]["value_no"].ToString();
            //str = dtCostCType.Rows[0]["the_value"].ToString();

            //glb_function.arrInsertLogs.Add("insert into COSTCENTER values((select nvl(max(swid),0)+1 from COSTCENTER)" +
            //" ,sysdate," + glb_function.glb_strUserId + ",'فعال'" +
            //    ", '" + dtCostCType.Rows[0]["value_no"].ToString() + ":" + GetCostCenterNo() + "','" + txtACT_NAME.Text + "'" +
            //    ",'نشاط'" +
            //    ",'" + dtCostCType.Rows[0]["the_value"].ToString() + "'" +
            //    ",0)");


            glb_function.arrInsertLogs.Add
            ("insert into ACTIVITIES values(" + txtSWID.Text +
            " ,sysdate," + glb_function.glb_strUserId + ",'فعال'" +
                ", '" + txtACT_NAME.Text + "','" + lstACT_TYPE.Text + "'" +
                ",to_date( '" + dtpACT_STARTED_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy'),'" + txtACT_USER.Text + "'" +
                ",(select nvl(max(swid),0) from COSTCENTER),'" + txtACT_INF.Text + "'" +
                ",'" + txtACT_TEL.Text + "')");

            if (glb_function.MultiTransData ())
            {

                GetData(txtSWID.Text.Trim());

            }
        }
        //private string GetCostCenterNo()
        //{
        //    ConnectionToDB cnn = new ConnectionToDB();
        //    DataTable dtCCNo = cnn.GetDataTable("select nvl(max( to_number(substr(cost_center_no,-3))),0)+1 from COSTCENTER t " +
        //                " where t.cost_center_type = 'نشاط'");

        //    return dtCCNo.Rows[0][0].ToString().PadLeft(3, '0');
        //}
        private void GetData(string strPk)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select swid, created_date, created_user, sata, act_name, act_type,to_char( act_started_date,'dd/mm/yyyy') act_started_date, act_user, cost_center, act_inf, act_tel from ACTIVITIES where swid=" + strPk);

           
            txtACT_NAME.Text = dtLocation.Rows[0]["ACT_NAME"].ToString();
            txtACT_NAME.W_OldValue = dtLocation.Rows[0]["ACT_NAME"].ToString();

            lstACT_TYPE.Text = dtLocation.Rows[0]["ACT_TYPE"].ToString();
            lstACT_TYPE.W_OldValue = dtLocation.Rows[0]["ACT_TYPE"].ToString();

            dtpACT_STARTED_DATE.Value  =DateTime.ParseExact( dtLocation.Rows[0]["ACT_STARTED_DATE"].ToString(),"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
            dtpACT_STARTED_DATE.W_OldValue = DateTime.ParseExact(dtLocation.Rows[0]["ACT_STARTED_DATE"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");

            txtACT_USER.Text = dtLocation.Rows[0]["ACT_USER"].ToString();
            txtACT_USER.W_OldValue = dtLocation.Rows[0]["ACT_USER"].ToString();

            txtACT_TEL.Text = dtLocation.Rows[0]["ACT_TEL"].ToString();
            txtACT_TEL.W_OldValue = dtLocation.Rows[0]["ACT_TEL"].ToString();

            txtACT_INF.Text = dtLocation.Rows[0]["ACT_INF"].ToString();
            txtACT_INF.W_OldValue = dtLocation.Rows[0]["ACT_INF"].ToString();

          

         



            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update ACTIVITIES set " +
                "  ACT_NAME='" + txtACT_NAME.Text + "',ACT_TYPE='" + lstACT_TYPE.Text + "'" +
                ",ACT_STARTED_DATE=to_date( '" + dtpACT_STARTED_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy'),ACT_USER='" + txtACT_USER.Text + "'" +
                ",ACT_INF='" + txtACT_INF.Text + "'" +
                ",ACT_TEL='" + txtACT_TEL.Text + "'"+
                "  where swid=" + txtSWID.Text);

            new glb_function().InsertToLogs(this, "ACTIVITIES", txtSWID.Text,"");
            //other table 

            if(glb_function.MultiTransData ())

            GetData(txtSWID.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindActivity frm = new frmFindActivity();

            frm.ShowDialog();

            if (frm.strActid != "")
            {
                txtSWID.Text = frm.strActid;
                GetData(txtSWID.Text);
            }
        }
    }
}
