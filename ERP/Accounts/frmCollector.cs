
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmCollector : MyForm
    {
        public frmCollector()
        {
            InitializeComponent();
        }

        private void tabPageAdv3_Click(object sender, EventArgs e)
        {

        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCollector_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            PrepareCollecotrForm();
        }
      
        private void PrepareCollecotrForm()
        {

            lstStat.Text = "فعال";
            btnUpdate.Enabled = false;
            glb_function.FillListWithId (ref lstBRANCH_ID, "BRANCHES", "BRANCH_ANAME");
            glb_function.FillList(ref lstIDENTIFICATION_TYPE, "COLLECTOR_DATA", "IDENTIFICATION_TYPE");
            glb_function.FillList(ref lstCONT_TITLE, "CONTACT_DATA", "CONT_TITLE");
            glb_function.FillListWithId(ref lstCollectorId, "collector_data", "collector_name");
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (txtCONT_VALUE.Text == "")
            {
                glb_function.MsgBox("الرجاء ادخال القيمة");
                txtCONT_VALUE.Focus();
                return;
            }

            for (int i = 0; i < dgCotactData.Rows.Count; i++)
            {
                if (txtCONT_VALUE.Text.Trim() == dgCotactData[3, i].Value.ToString().Trim())
                {
                    glb_function.MsgBox("القيمة مدخله من قبل");
                    return;
                }
            }
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtContactValue = cnn.GetDataTable("select cont_title,cont_value,a.adb_name from contact_data c,address_book a  " +
                    " where a.swid = c.adb_id and cont_value='" + txtCONT_VALUE.Text.Trim() + "'");
            if (dtContactValue != null && dtContactValue.Rows.Count > 0)
            {
                glb_function.MsgBox("هذا " + lstCONT_TYPE.Text + " مسجل باسم " + dtContactValue.Rows[0]["adb_name"].ToString() + "\n" + "لايمكن اتمام العملية ");
                return;
            }

            dgCotactData.Rows.Add();
            dgCotactData[0, dgCotactData.Rows.Count - 1].Value = "";
            dgCotactData[1, dgCotactData.Rows.Count - 1].Value = lstCONT_TYPE.Text;
            dgCotactData[2, dgCotactData.Rows.Count - 1].Value = lstCONT_TITLE.Text;
            dgCotactData[3, dgCotactData.Rows.Count - 1].Value = txtCONT_VALUE.Text;

            this.dgCotactData.Sort(this.dgCotactData.Columns["CONT_TYPE"], ListSortDirection.Ascending);
        }
        private bool CheckCollectorEntries()
        {


            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;

            //if (txtCOLLECTOR_NO.Text == "")
            //{

            //    errCheckCollData.SetError(txtCOLLECTOR_NO, "الرجاء ادخال رقم المحصل");
            //    iError = 1;
            //}
            //else
            //{
            //    errCheckCollData.SetError(txtCOLLECTOR_NO, "");
            //}

            if (txtCOLLECTOR_NAME.Text == "")
            {

                errCheckCollData.SetError(txtCOLLECTOR_NAME, "الرجاء ادخال اسم المحصل");
                iError = 1;
            }
            else
            {
                errCheckCollData.SetError(txtCOLLECTOR_NAME, "");
            }


            if (lstBRANCH_ID.SelectedIndex == -1)
            {

                errCheckCollData .SetError(lstBRANCH_ID, "الرجاء اختيار الفرع");
                iError = 1;
            }
            else
            {
                errCheckCollData.SetError(lstBRANCH_ID, "");
            }
          
           

            if (iError == 1)
                return false;

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckCollectorEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCollData = cnn.GetDataTable("select nvl(max(swid),0)+1 from COLLECTOR_DATA");

            txtCollectorSWID.Text = dtCollData.Rows[0][0].ToString();

            dtCollData.Clear();
            dtCollData = cnn.GetDataTable("select nvl(max(COLLECTOR_NO),0)+1 from COLLECTOR_DATA");
            txtCOLLECTOR_NO.Text = dtCollData.Rows[0][0].ToString();
            glb_function.arrInsertLogs = new System.Collections.ArrayList();


            string str;
          
                DataTable dtBranch = cnn.GetDataTable("select nvl(max(swid),0)+1 from address_book");

            txtContactId.Text  = dtBranch.Rows[0][0].ToString();
          
            
                str = "insert into address_book values (" + txtContactId.Text + ",sysdate," + glb_function.glb_strUserId + ",'فعال','" + txtCOLLECTOR_NAME.Text + "','',null,null,'محصل')";

            
            glb_function.arrInsertLogs.Add
                 (str);
            for (int i = 0; i < dgCotactData.Rows.Count; i++)
            {
                if (dgCotactData[0, i].Value.ToString() == "")
                    glb_function.arrInsertLogs.Add("insert into CONTACT_DATA values((select nvl(max(swid),0)+1 from CONTACT_DATA),sysdate," + glb_function.glb_strUserId + "," + txtContactId.Text + ",'" + dgCotactData[2, i].Value.ToString() + "','" + dgCotactData[1, i].Value.ToString() + "','" + dgCotactData[3, i].Value.ToString() + "')");
            }



            glb_function.arrInsertLogs.Add
           ("insert into COLLECTOR_DATA values(" + txtCollectorSWID.Text +
           " ," + glb_function.glb_strUserId + ", sysdate,'"+lstStat.Text +"'" + 
               ",'" + txtCOLLECTOR_NAME .Text .Trim () + "', '" + txtIDENTIFICATION_ID.Text + "','" + lstIDENTIFICATION_TYPE .Text + "'" +
               ", " + txtContactId.Text + ",'" + txtGARENTEE_NAME .Text + "'" +
               ","+(txtCONTACT_GARENTEE_ID.Text.Trim()==""?"null": txtCONTACT_GARENTEE_ID .Text )+ ",'" + txtGARENTEE_NOTE.Text + "'" +
               ",to_date('" + dtpSTARTED_DATE.Value .ToString ("dd/MM/yyyy") + "','dd/mm/yyyy')" +
               ",'" + txtCOLLECTOR_NO.Text  + "'" +
               " ,"+lstBRANCH_ID.SelectedValue.ToString()+")");



            if (glb_function.MultiTransData ())
            {
                GetData(txtCollectorSWID.Text.Trim());

            }
        }
        private void GetData(string strCollSwid)
        {
            new glb_function().clearItems(this);
            PrepareCollecotrForm();

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCollData = cnn.GetDataTable("select swid, stat, collector_name, identification_id, identification_type, contact_id, garentee_name, contact_garentee_id, garentee_note,to_char( started_date,'dd/mm/yyyy') started_date, collector_no, branch_id from COLLECTOR_DATA  " +
                    "  where swid =" + strCollSwid);

            txtCollectorSWID.Text = strCollSwid;

            txtCOLLECTOR_NO.Text = dtCollData.Rows[0]["COLLECTOR_NO"].ToString();
            txtCOLLECTOR_NO.W_OldValue = dtCollData.Rows[0]["COLLECTOR_NO"].ToString();


            txtCOLLECTOR_NAME.Text = dtCollData.Rows[0]["COLLECTOR_NAME"].ToString();
            txtCOLLECTOR_NAME.W_OldValue = dtCollData.Rows[0]["COLLECTOR_NAME"].ToString();

            lstIDENTIFICATION_TYPE .Text = dtCollData.Rows[0]["IDENTIFICATION_TYPE"].ToString();
            lstIDENTIFICATION_TYPE.W_OldValue = dtCollData.Rows[0]["IDENTIFICATION_TYPE"].ToString();

            txtIDENTIFICATION_ID.Text = dtCollData.Rows[0]["IDENTIFICATION_ID"].ToString();
            txtIDENTIFICATION_ID.W_OldValue = dtCollData.Rows[0]["IDENTIFICATION_ID"].ToString();

            lstBRANCH_ID.SelectedValue =Convert.ToInt16( dtCollData.Rows[0]["BRANCH_ID"].ToString());
            lstBRANCH_ID.W_OldValue = dtCollData.Rows[0]["BRANCH_ID"].ToString();

            dtpSTARTED_DATE.Value = glb_function.StringToDate (dtCollData.Rows[0]["STARTED_DATE"].ToString());
            dtpSTARTED_DATE.W_OldValue = (dtCollData.Rows[0]["STARTED_DATE"].ToString());

            lstStat.Text = dtCollData.Rows[0]["Stat"].ToString();
            lstStat.W_OldValue = dtCollData.Rows[0]["Stat"].ToString();

            txtContactId.Text = dtCollData.Rows[0]["contact_id"].ToString();
            txtContactId.W_OldValue = dtCollData.Rows[0]["contact_id"].ToString();

            txtGARENTEE_NAME.Text = dtCollData.Rows[0]["GARENTEE_NAME"].ToString();
            txtGARENTEE_NAME.W_OldValue = dtCollData.Rows[0]["GARENTEE_NAME"].ToString();

            txtCONTACT_GARENTEE_ID.Text = dtCollData.Rows[0]["CONTACT_GARENTEE_ID"].ToString();
            txtCONTACT_GARENTEE_ID.W_OldValue = dtCollData.Rows[0]["CONTACT_GARENTEE_ID"].ToString();

            txtGARENTEE_NOTE.Text = dtCollData.Rows[0]["GARENTEE_NOTE"].ToString();
            txtGARENTEE_NOTE.W_OldValue = dtCollData.Rows[0]["GARENTEE_NOTE"].ToString();

            dtCollData = cnn.GetDataTable("select * from CONTACT_DATA where ADB_ID= " + txtContactId.Text);
            dgCotactData.Rows.Clear();
            for (int i = 0; i < dtCollData.Rows.Count; i++)
            {
                dgCotactData.Rows.Add();
                dgCotactData[0, dgCotactData.Rows.Count - 1].Value = dtCollData.Rows[i]["SWID"].ToString();
                dgCotactData[1, dgCotactData.Rows.Count - 1].Value = dtCollData.Rows[i]["CONT_TYPE"].ToString();
                dgCotactData[2, dgCotactData.Rows.Count - 1].Value = dtCollData.Rows[i]["CONT_TITLE"].ToString();
                dgCotactData[3, dgCotactData.Rows.Count - 1].Value = dtCollData.Rows[i]["CONT_VALUE"].ToString();
            }


            this.dgCotactData.Sort(this.dgCotactData.Columns["CONT_TYPE"], ListSortDirection.Ascending);



            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckCollectorEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCollData = cnn.GetDataTable("select nvl(max(swid),0)+1 from COLLECTOR_DATA");

            txtCollectorSWID.Text = dtCollData.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();


            string str;
            if (txtCollectorSWID.Text.Trim() != "")
            {
                str = "update address_book set ADB_NAME=" + txtCOLLECTOR_NAME.Text + "' where swid=" + txtCollectorSWID.Text.Trim();

            }
            else
            {
                DataTable dtBranch = cnn.GetDataTable("select nvl(max(swid),0)+1 from address_book");

                txtContactId.Text = dtBranch.Rows[0][0].ToString();


                str = "insert into address_book values (" + txtContactId.Text + ",sysdate," + glb_function.glb_strUserId + ",'فعال','" + txtCOLLECTOR_NAME.Text + "','',null,null,'محصل')";

            }
            glb_function.arrInsertLogs.Add
                 (str);
            for (int i = 0; i < dgCotactData.Rows.Count; i++)
            {
                if (dgCotactData[0, i].Value.ToString() == "")
                    glb_function.arrInsertLogs.Add("insert into CONTACT_DATA values((select nvl(max(swid),0)+1 from CONTACT_DATA),sysdate," + glb_function.glb_strUserId + "," + txtContactId.Text + ",'" + dgCotactData[2, i].Value.ToString() + "','" + dgCotactData[1, i].Value.ToString() + "','" + dgCotactData[3, i].Value.ToString() + "')");
            }



            glb_function.arrInsertLogs.Add
           ("udpate COLLECTOR_DATA set " +
               ",COLLECTOR_NAME='" + txtCOLLECTOR_NAME.Text.Trim() + "', IDENTIFICATION_ID='" + txtIDENTIFICATION_ID.Text + "',IDENTIFICATION_TYPE='" + lstIDENTIFICATION_TYPE.Text + "'" +
               ", Contact_Id=" + (txtContactId.Text .Trim() ==""?"null":txtContactId.Text) + ",GARENTEE_NAME='" + txtGARENTEE_NAME.Text + "'" +
               ",CONTACT_GARENTEE_ID=" + txtCONTACT_GARENTEE_ID.Text + ",GARENTEE_NOTE='" + txtGARENTEE_NOTE.Text + "'" +
               ",STARTED_DATE=to_date('" + dtpSTARTED_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')" +
               ",COLLECTOR_NO='" + txtCOLLECTOR_NO.Text + "'" +
               " ,BRANCH_ID=" + lstBRANCH_ID.SelectedValue.ToString() + " where swid="+ txtCollectorSWID.Text);



            if (glb_function.MultiTransData ())
            {
                GetData(txtCollectorSWID.Text.Trim());

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PrepareCollecotrForm ();
        }

        private void tabPageAdv1_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
          frmFindCollector  frm = new frmFindCollector();

            frm.ShowDialog();

            if (frm.strCollId  != "")
            {
                txtCollectorSWID.Text = frm.strCollId;
                GetData(txtCollectorSWID.Text);
            }
        }

        private void btnAddRecieptBook_Click(object sender, EventArgs e)
        {
            if(lstCollectorId.SelectedIndex ==-1)
            {
                glb_function.MsgBox("الرجاء اختيار المحصل");
                lstCollectorId.Focus();
                return;
            }

            if(nmbBOOK_NO.Value <=0)
            {
                glb_function.MsgBox("الرجاء ادخال رقم الدفتر ");
                nmbBOOK_NO.Focus();
                return;
            }

            if(nmbFROM_NO.Value <=0)
            {
                glb_function.MsgBox("الرجاء ادخال عدد المستند بشكل صحيح ");
                nmbFROM_NO.Focus();
                return;
            }
            if (nmbTO_NO.Value <=nmbFROM_NO.Value )
            {
                glb_function.MsgBox("الرجاء ادخال عدد المستند بشكل صحيح ");
                nmbTO_NO.Focus();
                return;
            }

            ConnectionToDB cnn = new ConnectionToDB();
           


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
            ("insert into RECEIPT_BOOK values((select nvl(max(swid),0)+1 from RECEIPT_BOOK)" +
                ", " + glb_function.glb_strUserId + ",sysdate,'فعال'," + nmbBOOK_NO.Value + ","+
                nmbFROM_NO.Value +","+nmbTO_NO.Value +
                ",to_date('"+dtpRECEIVED_DATE.Value.ToString("dd/MM/yyyy")+"','dd/mm/yyyy')"+
                " ,"+lstCollectorId.SelectedValue.ToString()+",null,null,0,0)");

            if (glb_function.MultiTransData ())
            {
                GetCollectorBookData();
            }


            
        }

        private void lstCollectorId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCollectorId.SelectedValue == null)
                return;



            if (lstCollectorId.SelectedValue.ToString() != "System.Data.DataRowView" && lstCollectorId.SelectedValue.ToString() != "")
            {
                GetCollectorBookData();
            }

            }

        private void GetCollectorBookData()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCollBook = cnn.GetDataTable("select swid," +
                      " stat," +
                      " book_no," +
                     "  from_no," +
                     "  to_no," +
                     "  to_char(received_date,'dd/mm/yyyy') received_date," +

                      " to_char(pull_date,'dd/mm/yyyy') pull_date," +
                     "  PULL_NOTE," +
                      " count_used_receipt," +
                      "Canceled_count" +
                 " from receipt_book" +
                 " where collector_id =  " + lstCollectorId.SelectedValue.ToString());
            dgActive.Rows.Clear();
            dgUnactive.Rows.Clear();
            dgExpired.Rows.Clear();
            for (int i = 0; i < dtCollBook.Rows.Count; i++)
            {
                if (dtCollBook.Rows[i]["stat"].ToString() == "فعال")
                {
                    dgActive.Rows.Add();
                    dgActive[0, dgActive.Rows.Count - 1].Value = dtCollBook.Rows[i]["swid"].ToString();
                    dgActive[1, dgActive.Rows.Count - 1].Value = dtCollBook.Rows[i]["book_no"].ToString();
                    dgActive[2, dgActive.Rows.Count - 1].Value = dtCollBook.Rows[i]["from_no"].ToString();
                    dgActive[3, dgActive.Rows.Count - 1].Value = dtCollBook.Rows[i]["to_no"].ToString();
                    dgActive[4, dgActive.Rows.Count - 1].Value = dtCollBook.Rows[i]["received_date"].ToString();
                    dgActive[5, dgActive.Rows.Count - 1].Value = (Convert.ToInt16(dtCollBook.Rows[i]["to_no"].ToString()) - Convert.ToInt16(dtCollBook.Rows[i]["from_no"].ToString())).ToString();
                    dgActive[6, dgActive.Rows.Count - 1].Value = dtCollBook.Rows[i]["count_used_receipt"].ToString();
                    dgActive[7, dgActive.Rows.Count - 1].Value = dtCollBook.Rows[i]["Canceled_count"].ToString();

                }
                else if (dtCollBook.Rows[i]["stat"].ToString() == "غير فعال")
                {
                    dgUnactive.Rows.Add();
                    dgUnactive[0, dgUnactive.Rows.Count - 1].Value = dtCollBook.Rows[i]["swid"].ToString();
                    dgUnactive[1, dgUnactive.Rows.Count - 1].Value = dtCollBook.Rows[i]["book_no"].ToString();
                    dgUnactive[2, dgUnactive.Rows.Count - 1].Value = dtCollBook.Rows[i]["pull_date"].ToString();
                    dgUnactive[3, dgUnactive.Rows.Count - 1].Value = dtCollBook.Rows[i]["PULL_NOTE"].ToString();


                }
                else
                {
                    dgExpired.Rows.Add();
                    dgExpired[0, dgExpired.Rows.Count - 1].Value = dtCollBook.Rows[i]["swid"].ToString();
                    dgExpired[1, dgExpired.Rows.Count - 1].Value = dtCollBook.Rows[i]["book_no"].ToString();


                }
            }
        }

        private void myBottun1_Click(object sender, EventArgs e)
        {

        }
    }
}
