using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmFindServices : MyForm
    {
        public string strServiceID;
        public frmFindServices()
        {
            InitializeComponent();
        }

        private void frmFindServices_Load(object sender, EventArgs e)
        {
            strServiceID = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvServices.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select swid,service_no,service_name,price_type,price " +
                " from services " +
                " where  service_no like '%" + txtServicesNo.Text + "%' and service_name like '%" + txtServiceName.Text + "%'");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvServices.Rows.Add();
                dgvServices[0, dgvServices.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvServices[1, dgvServices.Rows.Count - 1].Value = dtLocationData.Rows[i]["service_no"].ToString();
                dgvServices[2, dgvServices.Rows.Count - 1].Value = dtLocationData.Rows[i]["service_name"].ToString();
                dgvServices[3, dgvServices.Rows.Count - 1].Value = dtLocationData.Rows[i]["price_type"].ToString();
                dgvServices[4, dgvServices.Rows.Count - 1].Value = dtLocationData.Rows[i]["price"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow.Index >= 0)
            {
                strServiceID = dgvServices[0, dgvServices.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strServiceID = "";
        }

        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
