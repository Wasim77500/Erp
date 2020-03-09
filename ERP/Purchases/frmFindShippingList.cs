using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmFindShippingList : ERP.MyForm
    {
        public string strShippingListID;

        public string strWhere = "";
        public frmFindShippingList()
        {
            InitializeComponent();
        }

        private void frmFindShippingList_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvShippingList.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select s.swid,s.shipping_list_no,b.branch_aname,to_char(s.created_date,'dd/mm/yyyy') created_date,s.note  "+
                          "  from shipping_list s " +
                          "  join branches b on (b.swid = s.branch_receved_id) " +
                          "  where s.shipping_list_no like '%"+txtShippingListNo.Text.Trim()+"%' and b.branch_aname like '%"+txtBranch_RECEVED_ID.Text.Trim()+"%' " + strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvShippingList.Rows.Add();
                dgvShippingList[0, dgvShippingList.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvShippingList[1, dgvShippingList.Rows.Count - 1].Value = dtLocationData.Rows[i]["shipping_list_no"].ToString();
                dgvShippingList[2, dgvShippingList.Rows.Count - 1].Value = dtLocationData.Rows[i]["branch_aname"].ToString();
                dgvShippingList[3, dgvShippingList.Rows.Count - 1].Value = dtLocationData.Rows[i]["created_date"].ToString();
                dgvShippingList[4, dgvShippingList.Rows.Count - 1].Value = dtLocationData.Rows[i]["note"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvShippingList.CurrentRow.Index >= 0)
            {
                strShippingListID = dgvShippingList[0, dgvShippingList.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strShippingListID = "";
        }

        private void dgvImports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
