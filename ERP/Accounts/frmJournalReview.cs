
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmJournalReview : MyForm
    {
        bool bEndLoadForm = false;
        public frmJournalReview()
        {
            InitializeComponent();
        }

        private void frmJournalReview_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            PrepareForm();

        }
        private void PrepareForm()
        {
            glb_function.FillListWithId(ref lstBranchHeader, "BRANCHES", "BRANCH_ANAME");
            //   lstBranchHeader.SelectedValue = glb_function.glb_BranchNo;
            lstBranchHeader.Enabled = false;
            if (lstTempBranch.Text == "1000")
            {
                lstBranchHeader.SelectedValue = glb_function.glb_BranchNo;
                lstBranchHeader.Enabled = true ;

            }
            else if (lstTempBranch.Text == "2000")
                
                lstBranchHeader.SelectedValue =  glb_function.glb_BranchNo;
            else if (lstTempBranch.Text != "")
                lstBranchHeader.SelectedValue =  lstTempBranch.Text;
            else
            {
               // glb_function.MsgBox("النموذج غير مرتبط بالفرع." + "\n" + "ستظهر البيانات بناء على فرع المستخدم");
                lstBranchHeader.SelectedValue = glb_function.glb_strUserId;
            }
            FillJournalHeader();

        }
        private void FillJournalHeader()
        {
            bEndLoadForm = false;
            dgJourHeader.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtJourHeader = cnn.GetDataTable("select swid,JOUR_NUM,to_char(JOUR_DATE,'dd/mm/yyyy') JOUR_DATE,VOCH_TYPE,VOCH_NO,stat from journal_header h" +
                " where h.stat in ('فعال' ,'غير فعال') and  h.branch_no=" + lstBranchHeader.SelectedValue.ToString()+ "order by swid");
            for (int i=0;i< dtJourHeader.Rows.Count; i++)
            {
                dgJourHeader.Rows.Add();
                
                dgJourHeader[0, dgJourHeader.Rows.Count - 1].Value = false;
                dgJourHeader[1, dgJourHeader.Rows.Count - 1].Value = dtJourHeader.Rows[i]["swid"].ToString();
                dgJourHeader[2, dgJourHeader.Rows.Count - 1].Value = dtJourHeader.Rows[i]["JOUR_NUM"].ToString();
                dgJourHeader[3, dgJourHeader.Rows.Count - 1].Value = dtJourHeader.Rows[i]["JOUR_DATE"].ToString();
                dgJourHeader[4, dgJourHeader.Rows.Count - 1].Value = dtJourHeader.Rows[i]["VOCH_TYPE"].ToString();
                dgJourHeader[5, dgJourHeader.Rows.Count - 1].Value = dtJourHeader.Rows[i]["VOCH_NO"].ToString();
                dgJourHeader[6, dgJourHeader.Rows.Count - 1].Value = dtJourHeader.Rows[i]["stat"].ToString();
            }

            bEndLoadForm = true ;
        }

        private void dgJourHeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            new glb_function().clearItems(gbHeader);
            dgJOURNAL_DETAILS.Rows.Clear();
            dgJourHistory.Rows.Clear();

            
            GetJournalHeaderData();
            FillJournalDetails();
            FillLogs();
        }
        private void FillLogs()
        {

            dgJourHistory.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtHistory=cnn.GetDataTable ("select l.col_name_ar,l.old_value,l.new_value,to_char(l.created_date,'dd/mm/yyyy') created_date,"+
                           " (select u.user_name  from userinfo u where swid = l.created_user) created_user from logs l" +
                           " where table_name = ('journal_header')"+
                           " and rid = "+ dgJourHeader[1, dgJourHeader.CurrentRow.Index].Value.ToString());

            for (int i = 0; i < dtHistory.Rows.Count; i++)
            {
                dgJourHistory.Rows.Add();
                dgJourHistory[0, dgJourHistory.Rows.Count - 1].Value = dtHistory.Rows[i]["col_name_ar"].ToString();
                dgJourHistory[1, dgJourHistory.Rows.Count - 1].Value = dtHistory.Rows[i]["old_value"].ToString();
                dgJourHistory[2, dgJourHistory.Rows.Count - 1].Value = dtHistory.Rows[i]["new_value"].ToString();
                dgJourHistory[3, dgJourHistory.Rows.Count - 1].Value = dtHistory.Rows[i]["created_date"].ToString();
                dgJourHistory[4, dgJourHistory.Rows.Count - 1].Value = dtHistory.Rows[i]["created_user"].ToString();
            }
        }
        private void GetJournalHeaderData()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtJourHeader = cnn.GetDataTable("select swid, to_char(created_date,'dd/mm/yyyy') created_date," +
      " created_user, stat, " +
      " jour_num, voch_type, " +
     "  voch_no, voch_no_m, " +
      " to_char(jour_date,'dd/mm/yyyy') jour_date, jour_details, " +
     "  branch_no, model_no, " +
    "   jour_value,(select FORM_NAME from TEMPLET_HEADER where swid=h.MODEL_NO) Model_name," +
    " (select BRANCH_ANAME from branches where swid=h.BRANCH_NO) BranchName," +
    " (select user_name from userinfo where swid=h.Created_User) UserName" +
  " from journal_header h where swid= " +dgJourHeader [1, dgJourHeader.CurrentRow.Index].Value.ToString());


            txtJOUR_NUM.Text = dtJourHeader.Rows[0]["jour_num"].ToString();
            txtVOCH_TYPE.Text = dtJourHeader.Rows[0]["VOCH_TYPE"].ToString();
            txtVOCH_NO.Text = dtJourHeader.Rows[0]["voch_no"].ToString();
            dtpJOUR_DATE.Value = glb_function.StringToDate(dtJourHeader.Rows[0]["JOUR_DATE"].ToString());
            txtVOCH_NO_M.Text = dtJourHeader.Rows[0]["voch_no_m"].ToString();
            txtMODEL_NO.Text = dtJourHeader.Rows[0]["Model_name"].ToString();
            txtBranchName.Text = dtJourHeader.Rows[0]["BranchName"].ToString();
            txtStat.Text = dtJourHeader.Rows[0]["stat"].ToString();
            dtpCREATED_DATE.Value = glb_function.StringToDate(dtJourHeader.Rows[0]["CREATED_DATE"].ToString());
            txtCreated_User.Text = dtJourHeader.Rows[0]["UserName"].ToString();
            txtJOUR_DETAILS_Header.Text = dtJourHeader.Rows[0]["jour_details"].ToString();


        }
        private void FillJournalDetails()
        {
            dgJOURNAL_DETAILS.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtJournal = cnn.GetDataTable("select "+
      " d.swid, CASE  when(d.jour_value > 0) then d.jour_value else 0 end  as \"مدين\" ,  "+
       "CASE when(d.jour_value < 0) then d.jour_value * -1 else 0 end as  \" دائن\", " +
      " CASE when(d.jour_main_value > 0) then d.jour_main_value else  jour_main_value * -1 end as \"المقابل\", " +

      " a.acc_no as \"رقم الحساب\", " +
     "  a.acc_name as  \"اسم الحساب\", " +

      " (select c.curr_name from currency c where c.swid = d.curr_id) as \" العملة\", " +
      " d.curr_price as \"سعر الصرف\", " +
     
     "  (select cc.cost_center_name"+
        "  from costcenter cc"+
        "  where cc.swid = d.cost_center) as  \"مركز الربحية\", " +
      " d.jour_details as  \"ملاحظات\", " +
       "d.stat,to_char(d.created_date,'dd/mm/yyyy') as \" تاريخ الانشاء\", (select user_name from userinfo where swid=d.created_user) as \" المستخدم\"" +
       " from journal_details d, accounts a where   d.acc_id = a.swid and d.stat = N'فعال'  and d.jour_id = " + dgJourHeader[1, dgJourHeader.CurrentRow.Index].Value.ToString());


            DataTable dtJournalHistory = cnn.GetDataTable("select " +
    " CASE  when(d.jour_value > 0) then d.jour_value else 0 end as \" مدين\", " +
     "CASE when(d.jour_value < 0) then d.jour_value * -1 else 0 end as \" دائن\", " +
    " CASE when(d.jour_main_value > 0) then d.jour_value else  jour_main_value * -1 end as \" المقابل\", " +

    " a.acc_no as \" رقم الحساب\", " +
   "  a.acc_name as \" اسم الحساب\", " +

    " (select c.curr_name from currency c where c.swid = d.curr_id) as \" العملة\" , " +
    " d.curr_price as \" سعر الصرف\", " +
    
   "  (select cc.cost_center_name" +
      "  from costcenter cc" +
      "  where cc.swid = d.cost_center) as \" مركز الربحية\", " +
    " d.jour_details as \" ملاحظات\" " +
     ",to_char(d.created_date,'dd/mm/yyyy') as \" تاريخ الانشاء\", (select user_name from userinfo where swid=d.created_user) as  \"المستخدم\",d.JOURNAL_DETAILS_ID" +
     " from JOURNAL_DETAILS_HISTORY d, accounts a where   d.acc_id = a.swid    and d.jour_id = " + dgJourHeader[1, dgJourHeader.CurrentRow.Index].Value.ToString());


            DataSet dsDataset = new DataSet();
            //Add two DataTables  in Dataset   

            dsDataset.Tables.Add(dtJournal);
            dsDataset.Tables.Add(dtJournalHistory);


             DataRelation Datatablerelation = new DataRelation("DetailsMarks", dsDataset.Tables[0].Columns[0], dsDataset.Tables[1].Columns[11], true);
            dsDataset.Relations.Add(Datatablerelation);



            dgJOURNAL_DETAIL.DataSource = dsDataset.Tables[0];

            dgJOURNAL_DETAILS.Columns[0].Visible = false;
            dgJOURNAL_DETAIL.ShowRowHeaders = false;
            dgJOURNAL_DETAIL.ShowRelationFields = Syncfusion.Grouping.ShowRelationFields.Hide;
            dgJOURNAL_DETAIL.TableDescriptor.VisibleColumns.Remove("SWID");

           
            GridTableModel tableModel = this.dgJOURNAL_DETAIL.GetTableModel("dtJournalHistory");
            
            //dgJOURNAL_DETAILS.Rows.Clear();


            //for (int i = 0; i < dtJournal.Rows.Count; i++)
            //{
            //    dgJOURNAL_DETAILS.Rows.Add();
            //    dgJOURNAL_DETAILS[0, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["swid"].ToString();
            //    dgJOURNAL_DETAILS[1, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["credit"].ToString();
            //    dgJOURNAL_DETAILS[2, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["dept"].ToString();
            //    dgJOURNAL_DETAILS[3, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["jour_main_value"].ToString();
            //    dgJOURNAL_DETAILS[4, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["acc_id"].ToString();
            //    dgJOURNAL_DETAILS[5, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["acc_no"].ToString();
            //    dgJOURNAL_DETAILS[6, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["acc_name"].ToString();
            //    dgJOURNAL_DETAILS[7, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["curr_id"].ToString();
            //    dgJOURNAL_DETAILS[8, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["curr_name"].ToString();
            //    dgJOURNAL_DETAILS[9, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["curr_price"].ToString();
            //    dgJOURNAL_DETAILS[10, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["cost_center"].ToString();
            //    dgJOURNAL_DETAILS[11, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["costcenter_name"].ToString();
            //    dgJOURNAL_DETAILS[12, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["jour_details"].ToString();
            //    dgJOURNAL_DETAILS[13, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["stat"].ToString();
            //    dgJOURNAL_DETAILS[14, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["created_date"].ToString();
            //    dgJOURNAL_DETAILS[15, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["created_user"].ToString();

            //}

        }

        private void lstBranchHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBranchHeader.SelectedValue == null)
                return;

            if (lstBranchHeader.SelectedValue.ToString() != "System.Data.DataRowView" && lstBranchHeader.SelectedValue.ToString() != "")
            {
                new glb_function().clearItems(this);
                FillJournalHeader ();
            }

        }

        private void chkShowDeletedRows_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            if (txtHANG_DEATELS.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال سبب تعليق القيد");
                txtHANG_DEATELS.Focus();
                return;
            }
            if(dgJourHeader.CurrentRow.Index==-1)
            {

                glb_function.MsgBox("الرجاء اختيار قيد للتعليق");
                return;
            }
            dgHang.Rows.Add();
            dgHang[0, dgHang.Rows.Count - 1].Value = dgJourHeader[1, dgJourHeader.CurrentRow.Index].Value.ToString();
            dgHang[1, dgHang.Rows.Count - 1].Value = dgJourHeader[2, dgJourHeader.CurrentRow.Index].Value.ToString();
            dgHang[2, dgHang.Rows.Count - 1].Value = txtHANG_DEATELS.Text;
            dgHang[3, dgHang.Rows.Count - 1].Value = dgJourHeader[6, dgJourHeader.CurrentRow.Index].Value.ToString();

            dgJourHeader.Rows.Remove(dgJourHeader.Rows[dgJourHeader.CurrentRow.Index]);
            new glb_function().clearItems(gbHeader);
            dgJOURNAL_DETAILS.Rows.Clear();
            dgJourHistory.Rows.Clear();
        }

        private void chkUnactiveVocher_CheckStateChanged(object sender, EventArgs e)
        {
           
        }

        private void gbHeader_Enter(object sender, EventArgs e)
        {

        }

        private void dgJourHeader_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (bEndLoadForm == false)
                return;

            if (e.ColumnIndex == 0 && e.RowIndex >=0)
            {
                if (dgJourHeader[ 6,e.RowIndex ].Value .ToString() == "غير فعال" && dgJourHeader[0, e.RowIndex].Value.ToString()=="False")

                    chkUnactiveVocher.Checked  = false;
            }
        }

        private void dgJourHeader_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgJourHeader.IsCurrentCellDirty && (dgJourHeader.CurrentCell.ColumnIndex ==0))
            {
                dgJourHeader.EndEdit();
            }
        }

        private void frmJournalReview_Activated(object sender, EventArgs e)
        {
            bEndLoadForm = true;
        }

        private void chkUnactiveVocher_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnactiveVocher.Checked == true)

                for (int i = 0; i < dgJourHeader.Rows.Count; i++)
                {
                    if (dgJourHeader[6, i].Value.ToString() == "غير فعال")
                        dgJourHeader[0, i].Value = true;

                }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();
           glb_function.arrInsertLogs  = new System.Collections.ArrayList();
            for (int i = 0; i < dgHang.Rows.Count; i++)
            {
                if(dgHang[3,i].Value .ToString()=="فعال")
                     glb_function.arrInsertLogs.Add("update journal_header set stat='معلق',HANG_BY="+glb_function.glb_strUserId+" ,HANG_DATE=sysdate,HANG_DEATELS='"+ dgHang[2, i].Value.ToString() + "' where swid=" + dgHang[0,i].Value .ToString() );
                else
                    glb_function.arrInsertLogs.Add("update journal_header set stat='غير فعال معلق',HANG_BY=" + glb_function.glb_strUserId + " ,HANG_DATE=sysdate,HANG_DEATELS='" + dgHang[2, i].Value.ToString() + "' where swid=" + dgHang[0, i].Value.ToString());
                
            }

            for (int i = 0; i < dgJourHeader.Rows.Count ; i++)
            {
               if( dgJourHeader[0, i].Value.ToString() == "True")
                {
                    if (dgJourHeader[6, i].Value.ToString() == "فعال")
                        glb_function.arrInsertLogs.Add("update journal_header set stat='روجع',REVIEWED_BY=" + glb_function.glb_strUserId + " ,REVIEWED_DATE=sysdate where swid=" + dgJourHeader[1, i].Value.ToString());
                    else
                        glb_function.arrInsertLogs.Add("update journal_header set stat='غير فعال روجع',REVIEWED_BY=" + glb_function.glb_strUserId + " ,REVIEWED_DATE=sysdate where swid=" + dgJourHeader[1, i].Value.ToString());
                }
               
            }
            glb_function.MultiTransData();

            PrepareForm();

           
        }

        private void btnOpenVoucher_Click(object sender, EventArgs e)
        {
            if (dgJourHeader.CurrentRow.Index<0 )
            {
                glb_function.MsgBox("الرجاء تحديد سند");
                return;
            }
            if(dgJourHeader[4, dgJourHeader.CurrentRow.Index ].Value.ToString()=="قيد")
            {
                frmJournal frm = new frmJournal();
                frm.strTempswid  =(dgJourHeader[1, dgJourHeader.CurrentRow.Index].Value.ToString());
                frm.ShowDialog();
            }
            else if (dgJourHeader[4, dgJourHeader.CurrentRow.Index].Value.ToString() == "سند صرف")
            {
                //frmReceipts  frm = new frmReceipts();
                //frm.strTempswid = (dgJourHeader[1, dgJourHeader.CurrentRow.Index].Value.ToString());
                //frm.ShowDialog();
            }
            else if (dgJourHeader[4, dgJourHeader.CurrentRow.Index].Value.ToString() == "سند قبض")
            {
                //frmCatchReceipt frm = new frmCatchReceipt();
                //frm.strTempswid = (dgJourHeader[1, dgJourHeader.CurrentRow.Index].Value.ToString());
                //frm.ShowDialog();
            }
        }

        private void dgJOURNAL_DETAIL_TableControlCellClick(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs e)
        {

        }
    }
}
