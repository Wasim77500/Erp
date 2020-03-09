
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmFindCurrency : MyForm
    {
        public string strCurrencyid="";
        public frmFindCurrency()
        {
            InitializeComponent();
        }

        private void frmFindCurrency_Load(object sender, EventArgs e)
        {
            strCurrencyid = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgCurrency.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            // DataTable dtCurrencyData = cnn.GetDataTable("select * from CURRENCY t " +
            //                  " where CURR_NAME like '%" + txtCURR_NAME.Text .Trim() + "%' and CURR_SMPL like '%" +
            //            txtCURR_SMPL .Text + "%'" +
            //               "  ");


            //جملة البحث بواسطة خالد مبارك
            DataTable dtCurrencyData = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,CURR_NOTE from currency c,currency_exchange e" +
                " where e.curr_id = c.swid " +
               " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid) and c.CURR_NAME like '%" + txtCURR_NAME.Text.Trim() + "%' and c.CURR_SMPL like '%" +
                                txtCURR_SMPL.Text + "%'");

            for (int i = 0; i < dtCurrencyData.Rows.Count; i++)
            {
                dgCurrency.Rows.Add();
                dgCurrency[0, dgCurrency.Rows.Count - 1].Value = dtCurrencyData.Rows[i]["swid"].ToString();
                dgCurrency[1, dgCurrency.Rows.Count - 1].Value = dtCurrencyData.Rows[i]["CURR_NAME"].ToString();
                dgCurrency[2, dgCurrency.Rows.Count - 1].Value = dtCurrencyData.Rows[i]["CURR_SMPL"].ToString();
                dgCurrency[3, dgCurrency.Rows.Count - 1].Value = dtCurrencyData.Rows[i]["curr_price"].ToString();
                dgCurrency[4, dgCurrency.Rows.Count - 1].Value = dtCurrencyData.Rows[i]["CURR_NOTE"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgCurrency.CurrentRow.Index >= 0)
            {
                strCurrencyid  = dgCurrency[0, dgCurrency.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strCurrencyid = "";
        }

        private void dgCurrency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void dgCurrency_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
