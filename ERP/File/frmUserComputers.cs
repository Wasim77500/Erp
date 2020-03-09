
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmUserComputers : MyForm
    {
        public frmUserComputers()
        {
            InitializeComponent();
        }
        private bool CheckEntries()
        {

           

            int iError = 0;
           

            if (txtDEVICE_NAME.Text == "")
            {

                errCheck.SetError(txtDEVICE_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtDEVICE_NAME, "");
            }


            if (txtDEVICE_USERNAME.Text == "")
            {

                errCheck.SetError(txtDEVICE_USERNAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtDEVICE_USERNAME, "");
            }

            if (txtDEVICE_CODE.Text == "")
            {

                errCheck.SetError(txtDEVICE_CODE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtDEVICE_CODE, "");
            }

           

            if (iError == 1)
                return false;

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

           ConnectionToDB cnn = new ConnectionToDB();
           

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
            ("insert into user_computers values((select nvl(max(swid),0)+1 from user_computers),"+txtSWID.Text +" ,'"+txtDEVICE_NAME.Text +"','"+txtDEVICE_USERNAME.Text +"','"+txtDEVICE_CODE.Text  +"',sysdate,"+glb_function.glb_strUserId +",'فعال')");

            

            if (glb_function.MultiTransData ())
            {
                GetData();

            }
        }
        private void GetData()
        {
            dgUserComp.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtComp = cnn.GetDataTable("select swid,  device_name, device_username, device_code from user_computers where stat ='فعال' and userid="+txtSWID.Text );
            for (int i = 0; i < dtComp.Rows.Count; i++)
            {
                dgUserComp.Rows.Add();
                dgUserComp[0, dgUserComp.Rows.Count - 1].Value = dtComp.Rows[i]["swid"].ToString();
                dgUserComp[1, dgUserComp.Rows.Count - 1].Value = dtComp.Rows[i]["device_name"].ToString();
                dgUserComp[2, dgUserComp.Rows.Count - 1].Value = dtComp.Rows[i]["device_username"].ToString();
                dgUserComp[3, dgUserComp.Rows.Count - 1].Value = dtComp.Rows[i]["device_code"].ToString();

            }
        }

        private void frmUserComputers_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
