using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmFindBranch : MyForm
    {
       public  string strBranchid="";
        public frmFindBranch()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            dgBranches.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
           
            DataTable dtLocationData = cnn.GetDataTable("select b.swid, b.branch_no,b.branch_aname,b.branch_ename,b.branche_location from BRANCHES b " +
                                " where branch_no like '%" + txtBranchNo.Text .Trim() + "%' and branch_aname like '%" +
                                txtBRANCHE_ANAME.Text + "%'" +
                                 "  " );

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgBranches.Rows.Add();
                dgBranches[0, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgBranches[1, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["branch_no"].ToString();
                dgBranches[2, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["branch_aname"].ToString();
                dgBranches[3, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["branch_ename"].ToString();
                dgBranches[4, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["branche_location"].ToString();
            }
        }

        private void frmFindBranch_Load(object sender, EventArgs e)
        {
             strBranchid = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (dgBranches.CurrentRow.Index >= 0)
            {
                strBranchid = dgBranches[0, dgBranches.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strBranchid = "";
        }

        private void dgBranches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
