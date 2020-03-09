
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmFindWarehouse : MyForm
    {
        public string strWarehouseId;
        public frmFindWarehouse()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvWarehouse .Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select swid,w_no,w_name,w_description,w.w_address from warehouse w " +
                                " where w_no like '%" + txtWarehouseNo.Text.Trim() + "%' and w_name like '%" +
                                txtWarehouseName.Text + "%'" +
                                 "  ");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvWarehouse.Rows.Add();
                dgvWarehouse[0, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvWarehouse[1, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["w_no"].ToString();
                dgvWarehouse[2, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["w_name"].ToString();
                dgvWarehouse[3, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["w_description"].ToString();
                dgvWarehouse[4, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["w_address"].ToString();
            }



        }

        private void frmFindWarehouse_Load(object sender, EventArgs e)
        {

            strWarehouseId = "";
        }

        private void myBottun2_Click(object sender, EventArgs e)
        {
            if (dgvWarehouse .CurrentRow.Index >= 0)
            {
                strWarehouseId = dgvWarehouse[0, dgvWarehouse.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strWarehouseId = "";
        }

        private void dgvWarehouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            myBottun2_Click(null, null);
        }
    }
}
