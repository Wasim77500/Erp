using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmFindCollector : MyForm
    {
        public string strCollId;
        public frmFindCollector()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgCollectors.CurrentRow.Index >= 0)
            {
                strCollId = dgCollectors[0, dgCollectors.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strCollId = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgCollectors.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select swid,COLLECTOR_NO,COLLECTOR_NAME,IDENTIFICATION_ID,to_char(STARTED_DATE,'dd/mm/yyyy') STARTED_DATE  from COLLECTOR_DATA " +
                                " where COLLECTOR_NO like '%" + txtCOLLECTOR_NO.Text + "%' and COLLECTOR_NAME like '%" +
                                txtCOLLECTOR_NAME.Text + "%' and nvl(IDENTIFICATION_ID,' ') like '%"+txtIDENTIFICATION_ID.Text +"%'" +
                                 "  ");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgCollectors.Rows.Add();
                dgCollectors[0, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgCollectors[1, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["COLLECTOR_NO"].ToString();
                dgCollectors[2, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["COLLECTOR_NAME"].ToString();
                dgCollectors[3, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["STARTED_DATE"].ToString();
                dgCollectors[4, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["IDENTIFICATION_ID"].ToString();
            }
        }

        private void dgCollectors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void frmFindCollector_Load(object sender, EventArgs e)
        {

        }
    }
}
