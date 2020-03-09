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
    public partial class frmGetQuotation : MyForm
    {
        public string strQuotSwid;
        public string strWhere = "";
        public frmGetQuotation()
        {
            InitializeComponent();
        }

        private void frmGetQuotation_Load(object sender, EventArgs e)
        {
            strQuotSwid = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvExpensses.CurrentRow.Index >= 0)
            {
                strQuotSwid = dgvExpensses[0, dgvExpensses.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strQuotSwid = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvExpensses.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
           
            if (txtRequestNo.Text.Trim()!="")
                strWhere = strWhere+ " and request_number = " + txtRequestNo.Text + "";

            strWhere = strWhere + " and p_name like '%" + txtVendorName.Text + "%'";
            DataTable dtLocationData = cnn.GetDataTable("select h.swid,h.request_number,p.p_name,h.request_version_number " +
                            "  from PURCHASE_QUOTATIONS_HEADER h join people p on( h.supplier_id = p.swid) "+
                            "   " +
                            "where   h.swid not in (select nvl(o.purchase_quotations_id,0) from purchases_order_header o ) and  h.swid in (select max(swid) from PURCHASE_QUOTATIONS_HEADER h2 group by h2.request_number) " +
                                 strWhere + " order by swid" );

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvExpensses.Rows.Add();
                dgvExpensses[0, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvExpensses[1, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["p_name"].ToString();
                dgvExpensses[2, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["request_number"].ToString();
                dgvExpensses[3, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["request_version_number"].ToString();

            }
        }

        private void dgvExpensses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
