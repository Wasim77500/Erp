using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmGetPurchaseOrder : ERP.MyForm
    {
        public string strOrderSwid;
        public string strOrderNum;
        public string strWhere = "";
        public frmGetPurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmGetPurchaseOrder_Load(object sender, EventArgs e)
        {
            strOrderSwid = "";
            strOrderNum = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvExpensses.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            if (txtRequestNo.Text.Trim() != "")
                strWhere = strWhere + " and purchase_order_num = " + txtRequestNo.Text + "";

            strWhere = strWhere + " and p_name like '%" + txtVendorName.Text + "%'";
            DataTable dtLocationData = cnn.GetDataTable("select h.swid,p.p_name,h.purchase_order_num,h.proforma_invoice_num "+
                           "  from purchases_order_header h"+
                           " join people p on (p.swid = h.supplier_id) " +
                                 strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvExpensses.Rows.Add();
                dgvExpensses[0, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvExpensses[1, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["p_name"].ToString();
                dgvExpensses[2, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["purchase_order_num"].ToString();
                dgvExpensses[3, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["proforma_invoice_num"].ToString();

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvExpensses.CurrentRow.Index >= 0)
            {
                strOrderSwid = dgvExpensses[0, dgvExpensses.CurrentRow.Index].Value.ToString();
                strOrderNum = dgvExpensses[2, dgvExpensses.CurrentRow.Index].Value.ToString();
                this.Close();
            }
            else
            {
                strOrderSwid = "";
                strOrderNum = "";
            }
              
        }

        private void dgvExpensses_DoubleClick(object sender, EventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
