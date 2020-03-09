using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmDepartements : MyForm
    {
       
        public frmDepartements()
        {
            InitializeComponent();
        }

        private void frmBranches_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            btnUpdate.Enabled = false;
            FillBranches();
            nmbDept_No.Value = 1;



        }
       private int GetLastDeptNo()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt = cnn.GetDataTable("select nvl( max(DEPT_NO),0)+1 from DEPARTEMENTS t where branch_id="+lstBRANCH_Id.SelectedValue .ToString());
            int iBranchNo =Convert.ToInt16( dt.Rows[0][0].ToString());
            return iBranchNo;
        }
        private void FillBranches()
        {
           
                ConnectionToDB myconn = new ConnectionToDB();
                DataTable MyDataTable;
                MyDataTable = myconn.GetDataTable("Select swid, BRANCH_ANAME From  BRANCHES order by 2");
                if (MyDataTable != null)
                {


                lstBRANCH_Id.DataSource = MyDataTable;


                lstBRANCH_Id.DisplayMember = "BRANCH_ANAME";
                lstBRANCH_Id.ValueMember = "swid";

                lstBRANCH_Id.SelectedIndex = -1;
                }
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBranch = cnn.GetDataTable("select nvl(max(swid),0)+1 from DEPARTEMENTS");

            txtSWID.Text = dtBranch.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

           

           




         

           
           
          

            glb_function.arrInsertLogs.Add
           ("insert into DEPARTEMENTS values(" + txtSWID.Text +
           " ,sysdate,'ACTIVE'," + glb_function.glb_strUserId + "" +
               "," + nmbDept_No.Value.ToString() + ", '" + txtDept_ANAME.Text + "','" + txtDept_ENAME.Text + "'" +
               ", '" + txtDept_AADDRESS.Text + "','" + txtDept_EADDRESS.Text + "'" +
               ",'" + txtDept_TEL.Text + "','" + txtDept_FAX.Text + "'" +
               ",'" + txtDept_EMAIL.Text + "'" +
               "," + (lstBRANCH_Id.SelectedValue == null ? "null" : lstBRANCH_Id.SelectedValue.ToString()) + "" +
               " )");



            if (glb_function.MultiTransData ())
            {
                GetData(txtSWID.Text.Trim());

            }
        }

       
        private void    GetData(string strPk)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select * from DEPARTEMENTS where swid=" + strPk);

            nmbDept_No.Text = dtLocation.Rows[0]["Dept_no"].ToString();
            nmbDept_No.W_OldValue = dtLocation.Rows[0]["DEPT_no"].ToString();

            txtDept_ANAME.Text = dtLocation.Rows[0]["DEPT_ANAME"].ToString();
            txtDept_ANAME.W_OldValue = dtLocation.Rows[0]["DEPT_ANAME"].ToString();

            txtDept_ENAME.Text = dtLocation.Rows[0]["DEPT_ENAME"].ToString();
            txtDept_ENAME.W_OldValue = dtLocation.Rows[0]["DEPT_ENAME"].ToString();

            txtDept_AADDRESS.Text = dtLocation.Rows[0]["DEPT_AADDRESS"].ToString();
            txtDept_AADDRESS.W_OldValue = dtLocation.Rows[0]["DEPT_AADDRESS"].ToString();

            txtDept_EADDRESS.Text = dtLocation.Rows[0]["DEPT_EADDRESS"].ToString();
            txtDept_EADDRESS.W_OldValue = dtLocation.Rows[0]["DEPT_EADDRESS"].ToString();

            txtDept_TEL.Text = dtLocation.Rows[0]["DEPT_TEL"].ToString();
            txtDept_TEL.W_OldValue = dtLocation.Rows[0]["DEPT_TEL"].ToString();

            txtDept_FAX.Text = dtLocation.Rows[0]["DEPT_FAX"].ToString();
            txtDept_FAX.W_OldValue = dtLocation.Rows[0]["DEPT_FAX"].ToString();

            txtDept_EMAIL.Text = dtLocation.Rows[0]["DEPT_EMAIL"].ToString();
            txtDept_EMAIL.W_OldValue = dtLocation.Rows[0]["DEPT_EMAIL"].ToString();

           


            lstBRANCH_Id.SelectedValue = (dtLocation.Rows[0]["BRANCH_ID"].ToString().Trim() == "" ? -1 : Convert.ToInt16(dtLocation.Rows[0]["BRANCH_ID"].ToString()));
            lstBRANCH_Id.W_OldValue = (dtLocation.Rows[0]["BRANCH_ID"].ToString());




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
            if (nmbDept_No.Value <=0)
            {
                 
                errCheck.SetError(nmbDept_No, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbDept_No, "");
            }
            
            if (txtDept_ANAME.Text == "")
            {

                errCheck.SetError(txtDept_ANAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtDept_ANAME, "");
            }

            
            if (txtDept_AADDRESS.Text == "")
            {

                errCheck.SetError(txtDept_AADDRESS, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtDept_AADDRESS, "");
            }

            if (txtDept_TEL.Text == "")
            {

                errCheck.SetError(txtDept_TEL, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtDept_TEL, "");
            }

            if (lstBRANCH_Id.SelectedIndex  ==-1)
            {

                errCheck.SetError(lstBRANCH_Id, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstBRANCH_Id, "");
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
            nmbDept_No.Value = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           glb_function.arrInsertLogs  = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update DEPARTEMENTS set " +
                " DEPT_no=" + nmbDept_No.Value.ToString() + ", DEPT_ANAME='" + txtDept_ANAME.Text + "',DEPT_ENAME='" + txtDept_ENAME.Text + "'" +
                ", DEPT_AADDRESS='" + txtDept_AADDRESS.Text + "',DEPT_EADDRESS='" + txtDept_EADDRESS.Text + "'" +
                ",DEPT_TEL='" + txtDept_TEL.Text + "',DEPT_FAX='" + txtDept_FAX.Text + "'" +
                ",DEPT_EMAIL='" + txtDept_EMAIL.Text + "'" +
                ",DEPT_LOCATION=" + (lstBRANCH_Id.SelectedValue == null ? "null" : lstBRANCH_Id.SelectedValue.ToString()) + "" +
                "  where swid=" + txtSWID.Text);

            new glb_function().InsertToLogs(this, "DEPARTEMENTS", txtSWID.Text,"");
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

        private void lstBRANCH_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBRANCH_Id.SelectedValue == null)
                return;



            if (lstBRANCH_Id.SelectedValue.ToString() != "System.Data.DataRowView" && lstBRANCH_Id.SelectedValue.ToString() != "")
            {

                nmbDept_No.Value = GetLastDeptNo();
            }
        }
    }
}
