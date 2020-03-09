using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmFindExpTerms : MyForm
    {
        public string strExpTermID;
        public string strExpTermName;
        public frmFindExpTerms()
        {
            InitializeComponent();
        }

        private void frmFindExpTerms_Load(object sender, EventArgs e)
        {
            strExpTermID = "";
            strExpTermName = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTermExp.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select swid,TERMS_NAME,TERMS_CODE from TERMS_EXPENSES_HEADER where  TERMS_NAME like '%" + txtTermName.Text + "%' and TERMS_CODE like '%" + txtTermCode.Text + "%'");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvTermExp.Rows.Add();
                dgvTermExp["clmSwid", dgvTermExp.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvTermExp["clmTermsName", dgvTermExp.Rows.Count - 1].Value = dtLocationData.Rows[i]["TERMS_NAME"].ToString();
                dgvTermExp["clmTermsCode", dgvTermExp.Rows.Count - 1].Value = dtLocationData.Rows[i]["TERMS_CODE"].ToString();
       
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvTermExp.CurrentRow.Index >= 0)
            {
                strExpTermID = dgvTermExp["clmSwid", dgvTermExp.CurrentRow.Index].Value.ToString();
                strExpTermName = dgvTermExp["clmTermsName", dgvTermExp.CurrentRow.Index].Value.ToString();
                this.Close();
            }
            else
            {
                strExpTermID = "";
                strExpTermName = "";
            }
                
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
