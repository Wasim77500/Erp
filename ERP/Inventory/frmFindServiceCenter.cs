using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmFindServiceCenter : MyForm
    {
        public string strServiceCenterId;
        public frmFindServiceCenter()
        {
            InitializeComponent();
        }

        private void frmFindServiceCenter_Load(object sender, EventArgs e)
        {
            strServiceCenterId = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvWarehouse.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select sc.swid,sc.sc_name,sc.sc_type,b.branch_aname,l.location_name "+
                                                  "   from service_center sc, branches b, location l"+
                                                 "   where sc.branch_id = b.swid"+
                                                 "   and sc.sc_loction = l.swid"+
                                                 "   and sc.sc_name like '%"+txtSC_Name.Text .Trim()+"%'"+
                                                  "  and sc.sc_type like '%"+txtSC_Type.Text .Trim()+"%'"+
                                                  "  ");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvWarehouse.Rows.Add();
                dgvWarehouse[0, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvWarehouse[1, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["sc_name"].ToString();
                dgvWarehouse[2, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["sc_type"].ToString();
                dgvWarehouse[3, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["branch_aname"].ToString();
                dgvWarehouse[4, dgvWarehouse.Rows.Count - 1].Value = dtLocationData.Rows[i]["location_name"].ToString();
            }
        }

        private void myBottun2_Click(object sender, EventArgs e)
        {
            if (dgvWarehouse.CurrentRow.Index >= 0)
            {
                strServiceCenterId = dgvWarehouse[0, dgvWarehouse.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strServiceCenterId = "";
        }

        private void dgvWarehouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            myBottun2_Click(null, null);
        }
    }
}
