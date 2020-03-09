using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmFindContacts : MyForm
    {
        public string strADBid;
        public frmFindContacts()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgContactData.CurrentRow.Index >= 0)
            {
                strADBid = dgContactData[0, dgContactData.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strADBid = "";
        }

        private void frmFindContacts_Load(object sender, EventArgs e)
        {
            strADBid = "";
        }

        private void dgContactData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgContactData.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select ab.swid,adb_name,ab.adb_describe,cont_type,cont_value from  address_book ab,contact_data cd"+
                            " where ab.swid = cd.adb_id"+
                            " and adb_name like '%"+txtAdb_name.Text +"%'"+
                            " and cont_value like '%"+txtCont_type.Text +"%'" +
                             (lstCONT_TYPE.SelectedIndex ==-1?"":lstCONT_TYPE.Text ));

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgContactData.Rows.Add();
                dgContactData[0, dgContactData.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgContactData[1, dgContactData.Rows.Count - 1].Value = dtLocationData.Rows[i]["adb_name"].ToString();
                dgContactData[2, dgContactData.Rows.Count - 1].Value = dtLocationData.Rows[i]["adb_describe"].ToString();
                dgContactData[3, dgContactData.Rows.Count - 1].Value = dtLocationData.Rows[i]["cont_type"].ToString();
                dgContactData[4, dgContactData.Rows.Count - 1].Value = dtLocationData.Rows[i]["cont_value"].ToString();
            }
        }
    }
}
