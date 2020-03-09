using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmGetPurchaseBill : ERP.MyForm
    {
        public string strBillSwid;

        public string strWhere = "";
        public frmGetPurchaseBill()
        {
            InitializeComponent();
        }

        private void frmGetPurchaseBill_Load(object sender, EventArgs e)
        {
            strBillSwid = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvExpensses.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            if (txtRequestNo.Text.Trim() != "")
                strWhere = strWhere + " and purchase_order_num = " + txtRequestNo.Text + "";

            strWhere = strWhere + " and p_name like '%" + txtVendorName.Text + "%'";
            DataTable dtLocationData = cnn.GetDataTable("select h.swid,p.p_name,h.bill_number,to_char(h.bill_date,'dd/mm/yyyy') bill_date " +
                           "  from purchases_bill h" +
                           " join people p on (p.swid = h.supplier_id) " +
                                 strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvExpensses.Rows.Add();
                dgvExpensses[0, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvExpensses[1, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["p_name"].ToString();
                dgvExpensses[2, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["bill_number"].ToString();
                dgvExpensses[3, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["bill_date"].ToString();

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvExpensses.CurrentRow.Index >= 0)
            {
                strBillSwid = dgvExpensses[0, dgvExpensses.CurrentRow.Index].Value.ToString();
              
                this.Close();
            }
            else
            {
                strBillSwid = "";
              
            }
        }

        private void dgvExpensses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
