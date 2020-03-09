using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmFindVendorItems : ERP.MyForm
    {
        public string strItemID;
        public string strWhere = "";
        public frmFindVendorItems()
        {
            InitializeComponent();
        }

        private void frmFindVendorItems_Load(object sender, EventArgs e)
        {
            strItemID = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgItems.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            strWhere = " and  im.item_no like '%" + txtITEM_NO.Text + "%'";

            strWhere = strWhere + " and im.item_name like '%" + txtITEM_NAME.Text + "%'";
            DataTable dtLocationData = cnn.GetDataTable(" select im.swid,im.item_no,im.item_name,im.item_info from item_supplier im where itemid is null  " +
                                 strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgItems.Rows.Add();
                dgItems[0, dgItems.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgItems[1, dgItems.Rows.Count - 1].Value = dtLocationData.Rows[i]["item_no"].ToString();
                dgItems[2, dgItems.Rows.Count - 1].Value = dtLocationData.Rows[i]["item_name"].ToString();
                dgItems[3, dgItems.Rows.Count - 1].Value = dtLocationData.Rows[i]["item_info"].ToString();

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgItems.CurrentRow.Index >= 0)
            {
                strItemID = dgItems[0, dgItems.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strItemID = "";
        }

        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
