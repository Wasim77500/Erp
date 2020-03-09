
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Sales
{
    public partial class frmCustomers : MyForm
    {
        int iAccLevel;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            FillADJECTIVE_TYPE();
            FillADJECTIVE();
            FillP_RESPONSIBLE();
            FillCurrency("0");
            FillBranch("0");
            GetAccLevelNo();
            FillParentAcc();
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
           
        }
        private void GetAccLevelNo()
        {
            iAccLevel = 0;
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLevelCount = cnn.GetDataTable("select the_value from DEFAULT_VALUES   where value_name='الرتبة'");

            if (dtLevelCount == null || dtLevelCount.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء تحديد عدد الرتب");
                return;
            }
            iAccLevel = Convert.ToInt16(dtLevelCount.Rows[0][0].ToString());
            //dtAccData = cnn.GetDataTable("select * from accounts where   acc_class='رئيسي' and ACC_TYPE='بنوك' and acc_level=" + (iAccLevel - 1));

        }
        private void FillBranch(string strAccid)
        {
            dgBranches.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBranches = cnn.GetDataTable("select b.swid,b.branch_aname,a.acc_id,a.swid BranchAccid from branches b " +
                                                    " left outer JOIN acc_branch a on(b.swid = a.branch_id and a.acc_id = " + strAccid + ") order by b.swid");

            for (int i = 0; i < dtBranches.Rows.Count; i++)
            {
                dgBranches.Rows.Add();
                dgBranches[0, dgBranches.Rows.Count - 1].Value = dtBranches.Rows[i]["BranchAccid"].ToString();
                dgBranches[1, dgBranches.Rows.Count - 1].Value = (dtBranches.Rows[i]["BranchAccid"].ToString() != "" ? true : false);
                dgBranches[2, dgBranches.Rows.Count - 1].Value = dtBranches.Rows[i]["swid"].ToString();
                dgBranches[3, dgBranches.Rows.Count - 1].Value = dtBranches.Rows[i]["branch_aname"].ToString();
            }
        }
        private void FillCurrency(string strAccId)
        {
            //     select c.swid,c.curr_name,a.b_acc,a.swid currAccid from currency c
            //left outer JOIN ACC_CURR a on(c.swid = a.curr_id and a.acc_id = 0) order by c.swid

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCurr = cnn.GetDataTable("select c.swid,c.curr_name,a.b_acc,a.swid currAccid from currency c " +
                       " left outer JOIN ACC_CURR a on(c.swid = a.curr_id and a.acc_id = " + strAccId + ") order by c.swid");
            dgCurrency.Rows.Clear();
            for (int i = 0; i < dtCurr.Rows.Count; i++)
            {
                dgCurrency.Rows.Add();
                dgCurrency[0, dgCurrency.Rows.Count - 1].Value = dtCurr.Rows[i]["currAccid"].ToString();
                dgCurrency[1, dgCurrency.Rows.Count - 1].Value = (dtCurr.Rows[i]["currAccid"].ToString() == "" ? false : true);
                dgCurrency[2, dgCurrency.Rows.Count - 1].Value = dtCurr.Rows[i]["swid"].ToString();
                dgCurrency[3, dgCurrency.Rows.Count - 1].Value = dtCurr.Rows[i]["curr_name"].ToString();
             

            }


        }
        private void FillADJECTIVE_TYPE()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtFill = cnn.GetDataTable("select distinct adjective_type from people where p_type='عميل'");
            lstADJECTIVE_TYPE.DataSource = dtFill;
            lstADJECTIVE_TYPE.DisplayMember = "adjective_type";


        }
        private void FillP_RESPONSIBLE()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtFill = cnn.GetDataTable("select distinct P_RESPONSIBLE from people where p_type='عميل'");
            lstP_RESPONSIBLE.DataSource = dtFill;
            lstP_RESPONSIBLE.DisplayMember = "P_RESPONSIBLE";
            lstP_RESPONSIBLE.SelectedIndex = -1;

        }
        private void FillADJECTIVE()
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtFill = cnn.GetDataTable("select distinct adjective from people");
            lstADJECTIVE.DataSource = dtFill;
            lstADJECTIVE.DisplayMember = "adjective";


        }

        private void btnAddAddBook_Click(object sender, EventArgs e)
        {
            if (txtSWID.Text.Trim() == "")
            {
                glb_function.MsgBox("لايمكن اضافة دليل عناوين حتى يتم حفظ بيانات المستخدم");
                return;
                
            }


            File.frmContacts frm = new File.frmContacts();
          
            frm.txtADB_NAME.Text = txtP_NAME.Text;
            frm.ShowDialog();

            if (frm.txtSWID.Text.Trim() == "")
            {
                glb_function.MsgBox("لم يتم حفظ العنوان");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt = cnn.GetDataTable("select nvl(max(swid),0)+1 from PEOPLE_ADDRESS");

            int icheck = cnn.TranDataToDB("insert into PEOPLE_ADDRESS values (" + dt.Rows[0][0].ToString() + "," + txtSWID.Text.Trim() + "," + frm.txtSWID.Text.Trim() + ")");
            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ العنوان");
                return;
            }

            cnn.glb_commitTransaction();


            GetAddress();
        }
        private void GetAddress()
        {
            dgAddressBook.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtContact = cnn.GetDataTable("select ab.swid,ab.adb_name,ab.job " +
                    " from address_book ab " +
                   " where  ab.swid in (select ba.ab_id from people_address ba where ba.people_id = " + txtSWID.Text.Trim() + ")");

            for (int i = 0; i < dtContact.Rows.Count; i++)
            {
                dgAddressBook.Rows.Add();
                dgAddressBook[0, dgAddressBook.Rows.Count - 1].Value = dtContact.Rows[i]["swid"].ToString();
                dgAddressBook[1, dgAddressBook.Rows.Count - 1].Value = dtContact.Rows[i]["adb_name"].ToString();
                dgAddressBook[2, dgAddressBook.Rows.Count - 1].Value = dtContact.Rows[i]["job"].ToString();

            }
        }
        private void FillParentAcc()
        {

            iAccLevel = 0;
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtAccData;
            DataTable dtLevelCount = cnn.GetDataTable("select the_value from DEFAULT_VALUES   where value_name='الرتبة'");

            if (dtLevelCount == null || dtLevelCount.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء تحديد عدد الرتب");
                return;
            }
            iAccLevel = Convert.ToInt16(dtLevelCount.Rows[0][0].ToString());


            dtAccData = cnn.GetDataTable("select * from accounts where   acc_class='رئيسي' and ACC_TYPE='عملاء' and acc_level=" + (iAccLevel - 1));
            lstAccNo.DataSource = dtAccData;
            lstAccNo.DisplayMember = "acc_no";
            lstAccNo.ValueMember = "swid";

            lstAccName.DataSource = dtAccData;
            lstAccName.DisplayMember = "acc_name";
            lstAccName.ValueMember = "swid";

            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCasherAcc = cnn.GetDataTable("select the_value from DEFAULT_VALUES t where value_name ='الرتبة" + iAccLevel + "'");

           int iLastLevelValue = Convert.ToInt16(dtCasherAcc.Rows[0][0].ToString());
            if (dtCasherAcc == null || dtCasherAcc.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء تحديد عدد الرتبة الاخيرة للحسابات الفرعية");
                return;
            }

            dtCasherAcc.Rows.Clear();
            //string strAccParentId = "47";
            //string strAccParentNo = "1251";

            string strAccParentId = lstAccNo.SelectedValue .ToString();
            string strAccParentNo = lstAccNo.Text ;


            string strACC_TYPE = "عملاء";
            dtCasherAcc = cnn.GetDataTable("select to_number( substr(acc_no,-" + iLastLevelValue + ")) from accounts " +
                          " where acc_parent = " + strAccParentId + " order by 1");
            txtAcc_No.Text = "";
            int i = 0;
            for (i = 0; i < dtCasherAcc.Rows.Count; i++)
            {
                if ((i + 1) != Convert.ToInt16(dtCasherAcc.Rows[i][0].ToString()))
                {
                    txtAcc_No.Text = (i + 1).ToString();
                    break;
                }

            }

            if (txtAcc_No.Text == "")
                txtAcc_No.Text = (i + 1).ToString();
            // txtAccNo.Text = dtCasherAcc.Rows[0][0].ToString();


            txtAcc_No.Text = strAccParentNo + txtAcc_No.Text.PadLeft(iLastLevelValue, '0');



            DataTable dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from ACCOUNTS");
            txtACC_ID.Text = dtGetId.Rows[0][0].ToString();
            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            glb_function.arrInsertLogs.Add
               ("insert into ACCOUNTS values ((" + txtACC_ID.Text + ")," +
               " sysdate,'فعال','" + txtAcc_No.Text + "','" + strACC_TYPE + "','" +
               txtP_NAME.Text + "'," + iAccLevel + ",'فرعي" +
               "','تم الانشاء من شاشة العملاء',null," + strAccParentId +
               "," + glb_function.glb_strUserId + ",'ميزانية','" +
                "فروع',null,'مدين',null)");

            dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from PEOPLE");
            txtSWID.Text = dtGetId.Rows[0][0].ToString();

            glb_function.arrInsertLogs.Add("insert into PEOPLE values((select nvl(max(swid),0)+1 from PEOPLE),"+
                         "sysdate,"+glb_function.glb_strUserId +",'فعال',"+txtACC_ID.Text +",'"+lstADJECTIVE_TYPE.Text +"','"+lstADJECTIVE.Text +"','"+txtP_NAME.Text.Trim() +"','"+lstP_RESPONSIBLE.Text +"','عميل',"+
                          nmbMAX_CREDIT.Value.ToString() + ",null,'"+txtP_NOTE.Text + "','" + txtP_GUARANTOR.Text + "','" + txtP_GUARANTOR_NOTE.Text + "',null)");


            for (int j = 0; j < dgCurrency.Rows.Count; j++)
            {
                if (dgCurrency[1, j].Value.ToString() == "True")
                {
                    glb_function.arrInsertLogs.Add("insert into ACC_CURR values ((select nvl(max(swid),0)+1 from ACC_CURR),sysdate," + glb_function.glb_strUserId + "," + txtACC_ID.Text + "," + dgCurrency[2, j].Value.ToString() + ",null)");

                }
            }
            i = 0;
            for ( i = 0; i < dgBranches.Rows.Count; i++)
            {
                if (dgBranches[1, i].Value.ToString() == "True")
                {
                    glb_function.arrInsertLogs.Add("insert into ACC_BRANCH values ((select nvl(max(swid),0)+1 from ACC_BRANCH),"+txtACC_ID.Text +"," + dgBranches[2, i].Value.ToString() + ")");

                }
            }





            if (glb_function.MultiTransData ())
                GetData(txtSWID.Text);



        }

        private void GetData(string strPk)
        {
            btnNew_Click(null, null);
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCustomers = cnn.GetDataTable("select p.swid,p.acc_id,a.acc_no,p.adjective_type,p.adjective,p.p_name, "+
                                  " p.p_responsible,p.max_credit,P_TYPE, " +
                                  "  p.p_note, p.p_guarantor, p.p_guarantor_note "+
                                   "  from people p , accounts a "+
                                  "  where p.acc_id = a.swid and  p.swid = " + strPk);

            txtSWID.Text = strPk;

            txtACC_ID.Text = dtCustomers.Rows[0]["acc_id"].ToString();
            txtAcc_No.Text = dtCustomers.Rows[0]["acc_no"].ToString();


            lstADJECTIVE.Text = dtCustomers.Rows[0]["adjective"].ToString();
            lstADJECTIVE.W_OldValue= dtCustomers.Rows[0]["adjective"].ToString();

            txtP_NAME.Text = dtCustomers.Rows[0]["p_name"].ToString();
            txtP_NAME.W_OldValue = dtCustomers.Rows[0]["p_name"].ToString();

            lstADJECTIVE_TYPE.Text = dtCustomers.Rows[0]["adjective_type"].ToString();
            lstADJECTIVE_TYPE.W_OldValue = dtCustomers.Rows[0]["adjective_type"].ToString();

            lstP_RESPONSIBLE.Text = dtCustomers.Rows[0]["p_responsible"].ToString();
            lstP_RESPONSIBLE.W_OldValue = dtCustomers.Rows[0]["p_responsible"].ToString();

            nmbMAX_CREDIT.Value =Convert.ToDecimal( dtCustomers.Rows[0]["max_credit"].ToString());
            nmbMAX_CREDIT.W_OldValue = dtCustomers.Rows[0]["p_responsible"].ToString();

            lstP_TYPE.Text = dtCustomers.Rows[0]["P_TYPE"].ToString();
            lstP_TYPE.W_OldValue = dtCustomers.Rows[0]["P_TYPE"].ToString();

            txtP_GUARANTOR.Text = dtCustomers.Rows[0]["P_GUARANTOR"].ToString();
            txtP_GUARANTOR.W_OldValue = dtCustomers.Rows[0]["P_GUARANTOR"].ToString();

            txtP_GUARANTOR_NOTE.Text = dtCustomers.Rows[0]["P_GUARANTOR_NOTE"].ToString();
            txtP_GUARANTOR_NOTE.W_OldValue = dtCustomers.Rows[0]["P_GUARANTOR_NOTE"].ToString();

            GetAddress();

            FillCurrency(txtACC_ID.Text);
            FillBranch(txtACC_ID.Text);

            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;

            if(txtAcc_No.Text =="")
            {
                if (lstAccNo.SelectedIndex == -1)
                {

                    errCheck.SetError(lstAccNo, "يجب ادخال رقم الحساب ");
                    iError = 1;
                }
                else
                {
                    errCheck.SetError(lstAccNo, "");
                }

                if (lstAccName.SelectedIndex == -1)
                {

                    errCheck.SetError(lstAccName, "يجب ادخال اسم الحساب ");
                    iError = 1;
                }
                else
                {
                    errCheck.SetError(lstAccName, "");
                }
            }
          

           
            if (lstAccName.SelectedIndex != -1 && lstAccNo.SelectedIndex != -1)
                if (lstAccNo.SelectedValue.ToString().Trim() != lstAccName.SelectedValue.ToString().Trim())
                {

                    glb_function.MsgBox("الرجاء التاكد ان رقم الحساب يطابقة اسم الحساب");
                    return false;
                }

            if (txtP_NAME .Text.Trim() == "")
            {

                errCheck.SetError(txtP_NAME, "الرجاء ادخال اسم العميل");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtP_NAME, "");
            }
            //txtC_Name
            if (nmbMAX_CREDIT.Value <= 0)
            {

                errCheck.SetError(nmbMAX_CREDIT, "الرجاء اختيار حد الائتمان");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbMAX_CREDIT, "");
            }

            if (txtP_GUARANTOR.Text.Trim() == "")
            {

                errCheck.SetError(txtP_GUARANTOR, "الرجاء ادخال اسم الضامن");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtP_GUARANTOR, "");
            }

            int iLoop = 0;
            for (int i = 0; i < dgBranches.Rows.Count; i++)
            {
                if (dgBranches[1, i].Value.ToString() == "True")
                {
                    iLoop = 1;
                    break;
                }
                   

              
                    
            }
            if (iLoop == 0)
            {
                glb_function.MsgBox("الرجاء اختيار فرع واحد على الاقل");
                return false;
            }
            iLoop = 0;
            for (int j = 0; j < dgCurrency.Rows.Count; j++)
            {
                if (dgCurrency[1, j].Value.ToString() == "True")
                {
                    iLoop = 1;
                    break;
                }


            }
            if (iLoop == 0)
            {
                glb_function.MsgBox("الرجاء اختيار عملة واحد على الاقل");
                return false;
            }




            if (iError == 1)
                return false;

            return true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            PrepareForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update PEOPLE set ADJECTIVE_TYPE='" + lstADJECTIVE_TYPE.Text + "',ADJECTIVE='" + lstADJECTIVE.Text + "',P_NAME='" + txtP_NAME.Text.Trim() + "',P_RESPONSIBLE='" + lstP_RESPONSIBLE.Text + "'," +
                        "MAX_CREDIT="+ nmbMAX_CREDIT.Value.ToString() + ",p_type='"+ lstP_TYPE.Text +"',P_NOTE='" + txtP_NOTE.Text + "',P_GUARANTOR='" + txtP_GUARANTOR.Text + "',P_GUARANTOR_NOTE='" + txtP_GUARANTOR_NOTE.Text + "' where swid="+txtSWID.Text );


            for (int j = 0; j < dgCurrency.Rows.Count; j++)
            {
                if (dgCurrency[1, j].Value.ToString() == "True")
                {
                    if (dgCurrency[0, j].Value.ToString() == "")
                        glb_function.arrInsertLogs.Add("insert into ACC_CURR values ((select nvl(max(swid),0)+1 from ACC_CURR),sysdate," + glb_function.glb_strUserId + "," + txtACC_ID.Text + "," + dgCurrency[2, j].Value.ToString() + ",null)");

                }
                else
                {
                    if (dgCurrency[0, j].Value.ToString() != "")
                        glb_function.arrInsertLogs.Add("delete from acc_curr where swid="+dgCurrency[0,j].Value .ToString());

                }
            }
           int  i = 0;
            for (i = 0; i < dgBranches.Rows.Count; i++)
            {
                if (dgBranches[1, i].Value.ToString() == "True")
                {
                    if (dgBranches[0, i].Value.ToString() == "")
                        glb_function.arrInsertLogs.Add("insert into ACC_BRANCH values ((select nvl(max(swid),0)+1 from ACC_BRANCH)," + txtACC_ID.Text + "," + dgBranches[2, i].Value.ToString() + ")");

                }
                else
                {
                    if (dgBranches[0, i].Value.ToString() != "")
                        glb_function.arrInsertLogs.Add("delete from ACC_BRANCH where swid=" + dgBranches[0, i].Value.ToString());
                }
            }





            if (glb_function.MultiTransData())
                GetData(txtSWID.Text);

        }

        private void myBottun1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindCustomer frm = new frmFindCustomer();

            frm.ShowDialog();

            if (frm.strCustomerID .Trim() != "")
            {
                txtSWID.Text = frm.strCustomerID;
                GetData(txtSWID.Text);
            }
        }

        private void dgAddressBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            if(e.ColumnIndex==clmJobButton.Index)
            {
                File.frmContacts frm = new File.frmContacts();
                
                frm.txtADB_NAME.Text = txtP_NAME.Text;
                frm.txtSWID.Text = dgAddressBook[0, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }

        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstAccName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
