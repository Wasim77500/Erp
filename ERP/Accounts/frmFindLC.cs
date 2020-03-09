using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmFindLC : ERP.MyForm
    {
        public string strLcId;
        public string strWhere;
        public frmFindLC()
        {
            InitializeComponent();
        }

        private void frmFindLC_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgCollectors.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select lc.swid,lc.LC_ROLLOVER,lc.lc_no,lc.lc_type,lc.lc_class from lc  " +
                                " where lc_no like '%" + txtLC_no.Text + "%' and lc_type like '%" +
                                txtLcType.Text + "%' and LC_ROLLOVER like '%" + txtLC_RollOver.Text + "%' " + strWhere +
                                 "  ");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgCollectors.Rows.Add();
                dgCollectors[0, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgCollectors[1, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["lc_no"].ToString();
                dgCollectors[2, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["lc_type"].ToString();
                dgCollectors[3, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["LC_ROLLOVER"].ToString();
                dgCollectors[4, dgCollectors.Rows.Count - 1].Value = dtLocationData.Rows[i]["lc_class"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgCollectors.CurrentRow.Index >= 0)
            {
                strLcId = dgCollectors[0, dgCollectors.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strLcId = "";
        }

        private void dgCollectors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
