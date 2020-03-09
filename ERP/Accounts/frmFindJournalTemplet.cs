using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmFindJournalTemplet : ERP.MyForm
    {
        public string strJourTempId;
        public string strWhere="";
        public frmFindJournalTemplet()
        {
            InitializeComponent();
        }

        private void frmFindJournalTemplet_Load(object sender, EventArgs e)
        {
            strJourTempId = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgBranches.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

             strWhere = " and   h.templates_name like '%" + txtTempName.Text + "%'";


            strWhere = strWhere + " and h.t_type like '%" + txtAccNo.Text + "%'";
            DataTable dtLocationData = cnn.GetDataTable("select h.swid,h.templates_name,h.t_type,h.general_special from journal_templates_hd h  where 1=1 " +
                                 strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgBranches.Rows.Add();
                dgBranches[0, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgBranches[1, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["templates_name"].ToString();
                dgBranches[2, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["t_type"].ToString();

                dgBranches[3, dgBranches.Rows.Count - 1].Value = dtLocationData.Rows[i]["general_special"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgBranches.CurrentRow.Index >= 0)
            {
                strJourTempId = dgBranches[0, dgBranches.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strJourTempId = "";
        }

        private void dgBranches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
