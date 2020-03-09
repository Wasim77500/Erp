using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmFindLocationData : MyForm
    {
        public string strLocationId = "";
        public frmFindLocationData()
        {
            InitializeComponent();
        }

        private void frmFindLocationData_Load(object sender, EventArgs e)
        {
            strLocationId = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgLocation.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            string strParent = "";
            if (lstPARENT_ID.SelectedValue == null || lstPARENT_ID.Text == "")
                strParent = "";
            else
                strParent = " and parent_id=" + lstPARENT_ID.SelectedValue.ToString();

            DataTable dtLocationData = cnn.GetDataTable("select location_name,location_type,parent_id ,t.loc_note,swid from LOCATION t " +
                                " where location_name like '%" + txtLOCATION_NAME.Text.Trim() + "%' and location_type like '%" +
                                lstLOCATION_TYPE.Text + "%'" +
                                 "  " + strParent);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgLocation.Rows.Add();
                dgLocation[0, dgLocation.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgLocation[1, dgLocation.Rows.Count - 1].Value = dtLocationData.Rows[i]["location_name"].ToString();
                dgLocation[2, dgLocation.Rows.Count - 1].Value = dtLocationData.Rows[i]["location_type"].ToString();
                dgLocation[3, dgLocation.Rows.Count - 1].Value = dtLocationData.Rows[i]["parent_id"].ToString();
                dgLocation[4, dgLocation.Rows.Count - 1].Value = dtLocationData.Rows[i]["loc_note"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (dgLocation.CurrentRow.Index >= 0)
            {
                strLocationId  = dgLocation[0, dgLocation.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strLocationId = "";
        }

        private void dgLocation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void txtLOCATION_NAME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
