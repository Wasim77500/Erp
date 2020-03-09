using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmFindItem : MyForm
    {

        public string strItemID;
        public string strWhere = "";
        public frmFindItem()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgItems.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

             strWhere = " and  i.item_no like '%" + txtITEM_NO.Text + "%'";
            
            strWhere = strWhere + " and i.item_name like '%" + txtITEM_NAME.Text + "%'";
            DataTable dtLocationData = cnn.GetDataTable("select i.swid,i.item_no,i.item_name,c.category_name,i.item_type" +
                " from items i left outer join categories c on ( i.category_id = c.swid) where 1=1 " +
                                 strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgItems.Rows.Add();
                dgItems[0, dgItems.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgItems[1, dgItems.Rows.Count - 1].Value = dtLocationData.Rows[i]["item_no"].ToString();
                dgItems[2, dgItems.Rows.Count - 1].Value = dtLocationData.Rows[i]["item_name"].ToString();
                dgItems[3, dgItems.Rows.Count - 1].Value = dtLocationData.Rows[i]["category_name"].ToString();
                dgItems[4, dgItems.Rows.Count - 1].Value = dtLocationData.Rows[i]["item_type"].ToString();
            }
        }

        private void frmFindItem_Load(object sender, EventArgs e)
        {
            strItemID = "";
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

        private void dgBranches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
