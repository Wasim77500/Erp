using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmFindAccount : MyForm
    {
        public string strAccid;
        public string strWhere="";
        public string strSelect = "";
        public frmFindAccount()
        {
            InitializeComponent();
        }

        private void frmFindAccount_Load(object sender, EventArgs e)
        {
            strAccid = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (dgAccData.CurrentRow.Index >= 0)
            {
                strAccid = dgAccData[0, dgAccData.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strAccid = "";
        }

        private void dgAccData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgAccData .Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtAccountData = cnn.GetDataTable(strSelect  +
               strWhere + "  and acc_no like '%" + txtACC_NO.Text +"%' and acc_name like '%"+txtACC_NAME.Text +"%' and acc_type like '%"+lstACC_TYPE.Text +"%'" );

            for (int i = 0; i < dtAccountData.Rows.Count; i++)
            {
                dgAccData.Rows.Add();
                dgAccData[0, dgAccData.Rows.Count - 1].Value = dtAccountData.Rows[i]["swid"].ToString();
                dgAccData[1, dgAccData.Rows.Count - 1].Value = dtAccountData.Rows[i]["acc_no"].ToString();
                dgAccData[2, dgAccData.Rows.Count - 1].Value = dtAccountData.Rows[i]["acc_name"].ToString();
                dgAccData[3, dgAccData.Rows.Count - 1].Value = dtAccountData.Rows[i]["acc_class"].ToString();
                dgAccData[4, dgAccData.Rows.Count - 1].Value = dtAccountData.Rows[i]["acc_subject"].ToString();
            }
        }
    }
}
