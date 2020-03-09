using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmBranches : MyForm
    {
       
        public frmBranches()
        {
            InitializeComponent();
        }

        private void frmBranches_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            btnUpdate.Enabled = false;
            FillLocation();
            nmbBRANCH_NO.Value = GetLastBranchNo();

        }
       private int GetLastBranchNo()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt = cnn.GetDataTable("select nvl( max(branch_no),0)+1 from BRANCHES t");
            int iBranchNo =Convert.ToInt16( dt.Rows[0][0].ToString());
            return iBranchNo;
        }
        private void FillLocation()
        {
           
                ConnectionToDB myconn = new ConnectionToDB();
                DataTable MyDataTable;
                MyDataTable = myconn.GetDataTable("Select swid, LOCATION_NAME From  location order by LOCATION_NAME");
                if (MyDataTable != null)
                {


                lstBRANCH_LOCATION.DataSource = MyDataTable;


                lstBRANCH_LOCATION.DisplayMember = "LOCATION_NAME";
                lstBRANCH_LOCATION.ValueMember = "swid";

                lstBRANCH_LOCATION.SelectedIndex = -1;
                }
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBranch = cnn.GetDataTable("select nvl(max(swid),0)+1 from BRANCHES");

            txtSWID.Text = dtBranch.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

           

           

            DataTable dtCostCType = cnn.GetDataTable("select value_no,value_name,the_value from default_values " +
                                       " where value_type = 'CostCenter' and value_name='فرع'");


            glb_function.arrInsertLogs.Add("insert into COSTCENTER values((select nvl(max(swid),0)+1 from COSTCENTER)" +  
            " ,sysdate," + glb_function.glb_strUserId + ",'فعال'" +
                ", '" + dtCostCType.Rows[0]["value_no"].ToString()+":"+ GetCostCenterNo() + "','" + txtBRANCH_ANAME.Text + "'" +
                ",'فرع'" +
                ",'" + dtCostCType.Rows[0]["the_value"].ToString() + "'" +
                ",0)");


            DataTable dtCCNOMap = cnn.GetDataTable("select nvl(max(cost_center_no),0)+1 from COSTCENTER_MAP t " +
                                 " where t.cost_center_parent  is null " );

           
            string str = "insert into COSTCENTER_MAP values ((select nvl(max(swid),0)+1 from COSTCENTER_MAP)," +
              " sysdate," + glb_function.glb_strUserId + ",'فعال',(select nvl(max(swid),0) from COSTCENTER),'" + dtCCNOMap.Rows[0][0].ToString().PadLeft(2, '0') + "',null,'رئيسي','" + dtCostCType.Rows[0]["value_no"].ToString() + ":" + GetCostCenterNo() + "')";
            glb_function.arrInsertLogs.Add
               (str);

            glb_function.arrInsertLogs.Add
           ("insert into BRANCHES values(" + txtSWID.Text +
           " ,sysdate,'فعال'," + glb_function.glb_strUserId + "" +
               "," + nmbBRANCH_NO.Value.ToString() + ", '" + txtBRANCH_ANAME.Text + "','" + txtBRANCH_ENAME.Text + "'" +
               "," + (lstBRANCH_LOCATION.SelectedValue == null ? "null" : lstBRANCH_LOCATION.SelectedValue.ToString()) + "" +
               " ,(select nvl(max(swid),0) from COSTCENTER))");



            if (glb_function.MultiTransData ())
            {
                GetData(txtSWID.Text.Trim());

            }
        }

        private string GetCostCenterNo()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCCNo = cnn.GetDataTable("select nvl(max( to_number(substr(cost_center_no,-3))),0)+1 from COSTCENTER t " +
                        " where t.cost_center_type = 'فرع'");

            return dtCCNo.Rows[0][0].ToString().PadLeft(3, '0');
        }
        private void    GetData(string strPk)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select * from BRANCHES where swid=" + strPk);

            nmbBRANCH_NO.Text = dtLocation.Rows[0]["BRANCH_No"].ToString();
            nmbBRANCH_NO.W_OldValue = dtLocation.Rows[0]["BRANCH_No"].ToString();

            txtBRANCH_ANAME.Text = dtLocation.Rows[0]["BRANCH_ANAME"].ToString();
            txtBRANCH_ANAME.W_OldValue = dtLocation.Rows[0]["BRANCH_ANAME"].ToString();

            txtBRANCH_ENAME.Text = dtLocation.Rows[0]["BRANCH_ENAME"].ToString();
            txtBRANCH_ENAME.W_OldValue = dtLocation.Rows[0]["BRANCH_ENAME"].ToString();

          

           


            lstBRANCH_LOCATION.SelectedValue = (dtLocation.Rows[0]["branche_location"].ToString().Trim() == "" ? -1 : Convert.ToInt16(dtLocation.Rows[0]["branche_location"].ToString()));
            lstBRANCH_LOCATION.W_OldValue = (dtLocation.Rows[0]["branche_location"].ToString());




            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }
        private bool CheckEntries()
        {

            if (!glb_function.AcceptTrans  )
                return false;

            int iError = 0;
            if (nmbBRANCH_NO.Value <=0)
            {
                 
                errCheck.SetError(nmbBRANCH_NO, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbBRANCH_NO, "");
            }
            
            if (txtBRANCH_ANAME.Text == "")
            {

                errCheck.SetError(txtBRANCH_ANAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtBRANCH_ANAME, "");
            }

            
          

            if (lstBRANCH_LOCATION.SelectedIndex  ==-1)
            {

                errCheck.SetError(lstBRANCH_LOCATION, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstBRANCH_LOCATION, "");
            }

            if (iError == 1)
                return false;

            return true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
            nmbBRANCH_NO.Value = GetLastBranchNo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!CheckEntries())
                return;
            glb_function.arrInsertLogs  = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update BRANCHES set " +
                " BRANCH_NO=" + nmbBRANCH_NO.Value.ToString() + ", BRANCH_ANAME='" + txtBRANCH_ANAME.Text + "',BRANCH_ENAME='" + txtBRANCH_ENAME.Text + "'" +
                ",BRANCH_LOCATION=" + (lstBRANCH_LOCATION.SelectedValue == null ? "null" : lstBRANCH_LOCATION.SelectedValue.ToString()) + "" +
                "  where swid=" + txtSWID.Text);

            new glb_function().InsertToLogs(this, "BRANCHES", txtSWID.Text,"");
            //other table 

           if( glb_function.MultiTransData ( ))

            GetData(txtSWID.Text);
        }

        private void myBottun1_Click(object sender, EventArgs e)
        {
            frmFindBranch  frm = new frmFindBranch();

            frm.ShowDialog();

            if (frm.strBranchid.Trim() != "")
            {
                txtSWID.Text = frm.strBranchid;
                GetData(txtSWID.Text);
            }
        }

        private void myLabel6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtBRANCHE_TEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBRANCHE_ANAME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
