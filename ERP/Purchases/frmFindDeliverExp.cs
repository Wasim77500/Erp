using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmFindDeliverExp : ERP.MyForm
    {
        public string strImportID;
      
        public string strWhere = "";
        public frmFindDeliverExp()
        {
            InitializeComponent();
        }

        private void frmFindDeliverExp_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvImports.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select c.swid, c.imports_id,c.container,c.notes,i.import_no from calculate_costs_header c "+
                          "  join imports i on(i.swid = c.imports_id) "+
                          "  where imports_id like '%"+txtImportNo.Text.Trim() + "%' and container like '%"+ txtContainer.Text + "%' "  + strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvImports.Rows.Add();
                dgvImports[0, dgvImports.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvImports[1, dgvImports.Rows.Count - 1].Value = dtLocationData.Rows[i]["import_no"].ToString();
                dgvImports[2, dgvImports.Rows.Count - 1].Value = dtLocationData.Rows[i]["container"].ToString();
                dgvImports[3, dgvImports.Rows.Count - 1].Value = dtLocationData.Rows[i]["notes"].ToString();

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvImports.CurrentRow.Index >= 0)
            {
                strImportID = dgvImports[0, dgvImports.CurrentRow.Index].Value.ToString();
              
                this.Close();
            }
            else
                strImportID = "";
        }

        private void dgvImports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
