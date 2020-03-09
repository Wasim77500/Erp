using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Sales
{
    public partial class frmFindCustomer : MyForm
    {
        public string strCustomerID;
        public frmFindCustomer()
        {
            InitializeComponent();
        }

        private void frmFindCustomer_Load(object sender, EventArgs e)
        {
            strCustomerID = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCustomers.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLocationData = cnn.GetDataTable("select p.swid,a.acc_no,p.p_name,p.adjective_type,p.p_responsible " +
                "from people p,accounts a " +
                "  where p.acc_id=a.swid and  p.p_type='عميل' and  a.acc_no like '%" + txtCustNo.Text + "%' and p.p_name like '%" + txtCustName.Text + "%'");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvCustomers.Rows.Add();
                dgvCustomers[0, dgvCustomers.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvCustomers[1, dgvCustomers.Rows.Count - 1].Value = dtLocationData.Rows[i]["acc_no"].ToString();
                dgvCustomers[2, dgvCustomers.Rows.Count - 1].Value = dtLocationData.Rows[i]["p_name"].ToString();
                dgvCustomers[3, dgvCustomers.Rows.Count - 1].Value = dtLocationData.Rows[i]["adjective_type"].ToString();
                dgvCustomers[4, dgvCustomers.Rows.Count - 1].Value = dtLocationData.Rows[i]["p_responsible"].ToString();
            }


           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow.Index >= 0)
            {
                strCustomerID = dgvCustomers[0, dgvCustomers.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strCustomerID = "";
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void myLabel4_Click(object sender, EventArgs e)
        {

        }

        private void myBottun2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
