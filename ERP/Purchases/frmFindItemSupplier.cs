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
    public partial class frmFindItemSupplier : MyForm
    {
        public string strItemSupplier_id;

        public frmFindItemSupplier()
        {
            InitializeComponent();
        }

        private void frmFindItemSupplier_Load(object sender, EventArgs e)
        {
            strItemSupplier_id = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvItemSuplier.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            string strWhere = " and item_no like '%" + txtitem_no.Text + "%'";

            strWhere = strWhere + " and item_name like '%" + txtitem_name.Text + "%'";
            DataTable dtLocationData = cnn.GetDataTable("select swid,item_no,item_name " +
                            " from item_supplier where people_id= " + txtPeopleId.Text +
                                 strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvItemSuplier.Rows.Add();
                dgvItemSuplier[0, dgvItemSuplier.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvItemSuplier[1, dgvItemSuplier.Rows.Count - 1].Value = dtLocationData.Rows[i]["item_no"].ToString();
                dgvItemSuplier[2, dgvItemSuplier.Rows.Count - 1].Value = dtLocationData.Rows[i]["item_name"].ToString();
               
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvItemSuplier.CurrentRow.Index >= 0)
            {
                strItemSupplier_id = dgvItemSuplier[0, dgvItemSuplier.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strItemSupplier_id = "";
        }

        private void dgvItemSuplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
