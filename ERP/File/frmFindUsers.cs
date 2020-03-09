using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmFindUsers : MyForm
    {
        public string strUserId = "";
        public string strWhere="";
        public frmFindUsers()
        {
            InitializeComponent();
        }

        private void frmFindUsers_Load(object sender, EventArgs e)
        {
            strUserId = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            dgUser.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            string strParent = "";
            if (lstUSER_BRANCH .SelectedValue == null || lstUSER_BRANCH.Text == "")
                strParent = "";
            else
                strParent = " and USER_BRANCH=" + lstUSER_BRANCH.SelectedValue.ToString();

            DataTable dtLocationData = cnn.GetDataTable("select USER_LOGIN,USER_NAME,USER_BRANCH ,t.USER_NOTE,swid from USERINFO t " +
                                " where USER_LOGIN like '%" + txtUSER_LOGIN.Text.Trim() + "%' and USER_NAME like '%" +
                                txtUSER_NAME.Text + "%'" +
                                 "  " + strParent + strWhere );

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgUser.Rows.Add();
                dgUser[0, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgUser[1, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["USER_LOGIN"].ToString();
                dgUser[2, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["USER_NAME"].ToString();
                dgUser[3, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["USER_BRANCH"].ToString();
                dgUser[4, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["USER_NOTE"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (dgUser.CurrentRow.Index >= 0)
            {
                strUserId = dgUser[0, dgUser.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strUserId = "";
        }

        private void dgUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
