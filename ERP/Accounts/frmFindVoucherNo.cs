
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmFindVoucherNo : MyForm
    {
        public string strJourId;
        public string strWhere;
        public frmFindVoucherNo()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgVouchers.Rows.Clear();
           ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetVoucher = cnn.GetDataTable("select h.swid, h.stat, h.created_user, "+
                                        " branch_id, year_n, "+
                                       "  stir_no, jour_no, to_char(jour_date,'dd/mm/yyyy') jour_date , "+
                                       " exchange_in_date, jour_details, "+
                                       "  issued_id, issued_type, u.user_name,b.branch_cost_center_name " +
                                      "  from journal_header h "+
                                     "   join userinfo u on (u.swid = h.created_user)" +
                                     " join  branches_costcenter b on (b.swid=h.branch_id)" +
                                     "   where " +                                    
                                     "     h.stir_no like '%" + txtStir_no.Text.Trim() + "%'" +
                                     "   and h.issued_id like '%" + txtIssueId.Text.Trim() + "%'" +
                                     "   and h.branch_id " + (lstbranch_id.SelectedIndex == -1 ? "like '%%'" : "=" + lstbranch_id.SelectedValue.ToString())+
                                    (ckbEnableDate.Checked ==true ? "   and jour_date between to_date('"+dtpFrom.Value.ToString("dd/MM/yyyy")+"', 'dd/mm/yyyy') and to_date('"+dtpTo.Value.AddDays(1) .ToString("dd/MM/yyyy")+"', 'dd/mm/yyyy')" :"") +
                                    " and u.user_name like '%"+txtUserName.Text.Trim()+"%'" +
                                     strWhere +" order by h.swid");


            for (int i = 0; i < dtGetVoucher.Rows.Count; i++)
            {
                dgVouchers.Rows.Add();
                dgVouchers[0, dgVouchers.Rows.Count - 1].Value = dtGetVoucher.Rows[i]["swid"].ToString();
                dgVouchers[1, dgVouchers.Rows.Count - 1].Value = dtGetVoucher.Rows[i]["stir_no"].ToString();

                dgVouchers[2, dgVouchers.Rows.Count - 1].Value = dtGetVoucher.Rows[i]["issued_id"].ToString();

                int  strCurrBranch = lstbranch_id.SelectedIndex;
                lstbranch_id.SelectedValue = dtGetVoucher.Rows[i]["branch_id"].ToString();
                
                dgVouchers[3, dgVouchers.Rows.Count - 1].Value = lstbranch_id.Text;
                lstbranch_id.SelectedIndex = strCurrBranch;
                dgVouchers[4, dgVouchers.Rows.Count - 1].Value = dtGetVoucher.Rows[i]["jour_date"].ToString();
                dgVouchers[5, dgVouchers.Rows.Count - 1].Value = dtGetVoucher.Rows[i]["jour_details"].ToString();
             
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgVouchers.CurrentRow.Index >= 0)
            {
                strJourId = dgVouchers[0, dgVouchers.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strJourId = "";
        }

        private void frmFindVoucherNo_Load(object sender, EventArgs e)
        {
            strJourId = "";
            FillBranches();
        }

        private void dgVouchers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
        private void FillBranches()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBranch = cnn.GetDataTable("select b.swid,b.branch_cost_center_name Branch_name " +
                  "  from cost_center_types t " +
                  "  join branches_costcenter b on (t.swid = b.costcenter_type_id) " +
                  "  where t.branch = '1'order by b.swid");

            lstbranch_id.DataSource = dtBranch;
            lstbranch_id.ValueMember = "swid";
            lstbranch_id.DisplayMember = "Branch_name";

            lstbranch_id.SelectedIndex = -1;

        }

        private void ckbEnableDate_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbEnableDate.Checked )
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
            else
            {
                dtpFrom.Enabled = false ;
                dtpTo.Enabled = false ;
            }
        }

        private void myText1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
