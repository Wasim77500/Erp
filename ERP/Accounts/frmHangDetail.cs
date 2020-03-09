using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmHangDetail : ERP.MyForm
    {
        public string strJourSwid;
        public frmHangDetail()
        {
            InitializeComponent();
        }

     

        private void frmHangDetail_Load(object sender, EventArgs e)
        {
            this.dgJOURNAL_DETAILS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgJOURNAL_DETAILS.ColumnHeadersHeight = this.dgJOURNAL_DETAILS.ColumnHeadersHeight * 2;
            this.dgJOURNAL_DETAILS.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            this.dgJOURNAL_DETAILS.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
            this.dgJOURNAL_DETAILS.Paint += new PaintEventHandler(dataGridView1_Paint);
            this.dgJOURNAL_DETAILS.Scroll += new ScrollEventHandler(dataGridView1_Scroll);
            this.dgJOURNAL_DETAILS.ColumnWidthChanged += new DataGridViewColumnEventHandler(dataGridView1_ColumnWidthChanged);



            dgJOURNAL_DETAILS.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtHang = cnn.GetDataTable("select CASE when(d.jour_value > 0) then d.jour_value else 0 end Ddept," +
                                                " CASE when(hd.jour_value > 0) then hd.jour_value else 0 end Hdept," +
                                                 " CASE when(d.jour_value < 0) then d.jour_value * -1 else 0 end Dcredit, " +
                                                 " CASE when(hd.jour_value < 0) then hd.jour_value * -1 else 0 end Hcredit, " +
                                                 "   CASE when(d.jour_main_value > 0) then d.jour_main_value else d.jour_main_value * -1 end Djour_main_value, " +
                                                  "   CASE when(hd.jour_main_value > 0) then hd.jour_main_value else hd.jour_main_value * -1 end Hjour_main_value, " +
                     "   (select curr_name from currency c where c.swid=d.curr_id )    DCurrid, " +
                     " (select curr_name from currency c1 where c1.swid=hd.curr_id)  HCurrid , " +
                     " (select a.acc_name from Accounts a where a.swid= d.acc_id) Daccid," +
                     " (select a1.acc_name from Accounts a1 where a1.swid=hd.acc_id )  HAccId, " +
                     "d.curr_price DcurrPrice, " + 
                     " hd.curr_price HCurrPrice, " +                     
                       "(select c.branch_cost_center_name from branches_costcenter c where c.swid = nvl(d.cost_center_id,0)) DCostCentName," +
                     "(select c1.branch_cost_center_name from branches_costcenter c1 where c1.swid = nvl(hd.cost_center_id,0)) HCostCentName," +
                     " d.reference_no refnoD,"+
                     "d.jour_details noteD,"+
                      "      hd.hang_deatels noteH "+
                       "     from journal_header h " +
                       "     join journal_details d on (h.swid = d.jour_id) " +
                       "     join hang_journal_hd hg on (h.swid = hg.jour_id) " +
                        "   " +
                        "    join hang_journal_de hd on (hg.swid = hd.header_id) and(d.swid = hd.jour_id) " +
                         "   where hg.stat='فعال'  and h.swid = " + strJourSwid);

            for (int i = 0; i < dtHang.Rows.Count; i++)
            {
                dgJOURNAL_DETAILS.Rows.Add();
                dgJOURNAL_DETAILS[0, i].Value = dtHang.Rows[i]["Ddept"].ToString();
                dgJOURNAL_DETAILS[1, i].Value = dtHang.Rows[i]["Hdept"].ToString();
                dgJOURNAL_DETAILS[2, i].Value = dtHang.Rows[i]["Dcredit"].ToString();
                dgJOURNAL_DETAILS[3, i].Value = dtHang.Rows[i]["Hcredit"].ToString();
                dgJOURNAL_DETAILS[4, i].Value = dtHang.Rows[i]["Djour_main_value"].ToString();
                dgJOURNAL_DETAILS[5, i].Value = dtHang.Rows[i]["Hjour_main_value"].ToString();
                dgJOURNAL_DETAILS[6, i].Value = dtHang.Rows[i]["DCurrid"].ToString();
                dgJOURNAL_DETAILS[7, i].Value = dtHang.Rows[i]["HCurrid"].ToString();
                dgJOURNAL_DETAILS[8, i].Value = dtHang.Rows[i]["DcurrPrice"].ToString();
                dgJOURNAL_DETAILS[9, i].Value = dtHang.Rows[i]["HCurrPrice"].ToString();

                dgJOURNAL_DETAILS[10, i].Value = dtHang.Rows[i]["Daccid"].ToString();
                dgJOURNAL_DETAILS[11, i].Value = dtHang.Rows[i]["HAccId"].ToString();

                dgJOURNAL_DETAILS[12, i].Value = dtHang.Rows[i]["DCostCentName"].ToString();
                dgJOURNAL_DETAILS[13, i].Value = dtHang.Rows[i]["HCostCentName"].ToString();
                dgJOURNAL_DETAILS[14, i].Value = dtHang.Rows[i]["refnoD"].ToString();
                dgJOURNAL_DETAILS[15, i].Value = dtHang.Rows[i]["noteD"].ToString();
                dgJOURNAL_DETAILS[16, i].Value = dtHang.Rows[i]["noteH"].ToString();
            }


        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = this.dgJOURNAL_DETAILS.DisplayRectangle;
            rtHeader.Height = this.dgJOURNAL_DETAILS.ColumnHeadersHeight / 2;
            this.dgJOURNAL_DETAILS.Invalidate(rtHeader);
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = this.dgJOURNAL_DETAILS.DisplayRectangle;
            rtHeader.Height = this.dgJOURNAL_DETAILS.ColumnHeadersHeight / 2;
            this.dgJOURNAL_DETAILS.Invalidate(rtHeader);
        }
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            string[] monthes = { "مدين", "دائن", "المقابل", "العملة","سعر الصرف", "اسم الحساب" ,"مركز التكلفة"};
            for (int j = 0; j < 14;)
            {
                Rectangle r1 = this.dgJOURNAL_DETAILS.GetCellDisplayRectangle(j+1, -1, true);
                int w2 = this.dgJOURNAL_DETAILS.GetCellDisplayRectangle(j + 1, -1, true).Width;
                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + w2 - 2;
                r1.Height = r1.Height / 2 - 2;
                e.Graphics.FillRectangle(new SolidBrush(this.dgJOURNAL_DETAILS.ColumnHeadersDefaultCellStyle.BackColor), r1);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(monthes[j / 2],
                this.dgJOURNAL_DETAILS.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(this.dgJOURNAL_DETAILS.ColumnHeadersDefaultCellStyle.ForeColor),
                r1,
                format);
                j += 2;
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height / 2;
                r2.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;
            }
        }
    }
}
