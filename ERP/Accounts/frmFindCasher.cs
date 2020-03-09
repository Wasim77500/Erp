
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmFindCasher : MyForm
    {
        public string strCasherId;
        public frmFindCasher()
        {
            InitializeComponent();
        }

        private void frmFindCasher_Load(object sender, EventArgs e)
        {
            strCasherId = "";
           
        }
      

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgBranches.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            string strWhere= "and   c.c_name like '%"+txtC_Name.Text  +"%'";

           
            strWhere = strWhere + " and a.acc_no like '%"+txtAccNo.Text +"%'";
            DataTable dtLocationData = cnn.GetDataTable("select c.swid,c.c_name,a.acc_name,c.c_type,a.acc_no  from casher c,accounts a where c.acc_id=a.swid " +
                                 strWhere );

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgBranches.Rows.Add();
                dgBranches[0, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgBranches[1, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["c_name"].ToString();
                dgBranches[2, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["acc_no"].ToString();
               
                dgBranches[3, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["c_type"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgBranches.CurrentRow.Index >= 0)
            {
                strCasherId = dgBranches[0, dgBranches.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strCasherId = "";
        }

        private void dgBranches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
