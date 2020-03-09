using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmGetExpensses : MyForm
    {
        public string strExpensses_id;
        public frmGetExpensses()
        {
            InitializeComponent();
        }

        private void frmGetExpensses_Load(object sender, EventArgs e)
        {
            strExpensses_id = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvExpensses.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();

            string strWhere = " and expenses_name like '%" + txtExpenss_name.Text + "%'";

            strWhere = strWhere + " and expenses_type like '%" + txtExpenss_type.Text + "%'";
            DataTable dtLocationData = cnn.GetDataTable("select swid, expenses_name, expenses_type, expensesvalue_or_size "+
                            "from expenses_item where 1=1 " +
                                 strWhere);

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvExpensses.Rows.Add();
                dgvExpensses[0, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgvExpensses[1, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["expenses_name"].ToString();
                dgvExpensses[2, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["expenses_type"].ToString();
                dgvExpensses[3, dgvExpensses.Rows.Count - 1].Value = dtLocationData.Rows[i]["expensesvalue_or_size"].ToString();
                
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvExpensses.CurrentRow.Index >= 0)
            {
                strExpensses_id = dgvExpensses[0, dgvExpensses.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strExpensses_id = "";
        }

        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
