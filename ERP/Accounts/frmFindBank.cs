
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmFindBank : MyForm
    {
        public string strBankId;
        public frmFindBank()
        {
            InitializeComponent();
        }

        private void frmFindBank_Load(object sender, EventArgs e)
        {
            strBankId = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgBanks .CurrentRow.Index >= 0)
            {
                strBankId = dgBanks[0, dgBanks.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strBankId = "";
        }

        private void dgBanks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgBanks .Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            string strWhere = "and   b.b_name like '%" + txtB_Name.Text + "%'";

           

           
            DataTable dtLocationData = cnn.GetDataTable("select b.swid,b.b_name  from Banks b  where 1=1  " +
                                 strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgBanks.Rows.Add();
                dgBanks[0, dgBanks.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgBanks[1, dgBanks.Rows.Count - 1].Value = dtLocationData.Rows[i]["b_name"].ToString();
              
               
               
            }
        }
    }
}
