using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmFindImport : ERP.MyForm
    {
        public string strImportID;
        public string strImportNo;
        public string strWhere="";
        public frmFindImport()
        {
            InitializeComponent();
        }

        private void frmFindImport_Load(object sender, EventArgs e)
        {
            strImportID = "";
            strImportNo = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvImports.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable(" select swid,import_no,import_date,import_nature,operation_type from imports where   import_no like '%" + txtImportNo.Text + "%' and import_nature like '%" + txtImportNature.Text + "%'" + strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvImports.Rows.Add();
                dgvImports[0, dgvImports.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvImports[1, dgvImports.Rows.Count - 1].Value = dtLocationData.Rows[i]["import_no"].ToString();
                dgvImports[2, dgvImports.Rows.Count - 1].Value = dtLocationData.Rows[i]["import_date"].ToString();
                dgvImports[3, dgvImports.Rows.Count - 1].Value = dtLocationData.Rows[i]["import_nature"].ToString();
                dgvImports[4, dgvImports.Rows.Count - 1].Value = dtLocationData.Rows[i]["operation_type"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvImports.CurrentRow.Index >= 0)
            {
                strImportID = dgvImports[0, dgvImports.CurrentRow.Index].Value.ToString();
                strImportNo= dgvImports[1, dgvImports.CurrentRow.Index].Value.ToString();
                this.Close();
            }
            else
                strImportID = "";
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
