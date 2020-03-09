using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmFindActivity : MyForm
    {

        public string strActid;
        public frmFindActivity()
        {
            InitializeComponent();
        }

        private void frmFindActivity_Load(object sender, EventArgs e)
        {
            strActid = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgBranches.CurrentRow.Index >= 0)
            {
                strActid = dgBranches[0, dgBranches.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strActid = "";
        }

        private void dgBranches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgBranches.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select swid,  act_name,act_type,to_char(act_started_date,'dd/mm/yyyy' ) act_started_date,act_user, act_inf,act_tel   from activities " +
                                " where ACT_NAME like '%" + txtACT_NAME.Text  + "%' and ACT_TYPE like '%" +
                                lstACT_TYPE.Text + "%'" +
                                 "  ");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgBranches.Rows.Add();
                dgBranches[0, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgBranches[1, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["act_name"].ToString();
                dgBranches[2, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["act_type"].ToString();
                dgBranches[3, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["act_started_date"].ToString();
                dgBranches[4, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["act_user"].ToString();
            }
        }
    }
}
