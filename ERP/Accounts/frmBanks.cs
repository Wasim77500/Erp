
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmBanks : MyForm
    {

        int iAccLevel;
        int iLastLevelValue;
        DataTable dtAccData;


        int iRow_Parent;//يستخدم للوصول الى بيانات الاب والتي نحتاجها لاضافة الصندوق الى جدول الحسابات
        bool bFormLoad = false;
        public frmBanks()
        {
            InitializeComponent();
        }

        private void frmBanks_Load(object sender, EventArgs e)
        {

            bFormLoad = true;

            FillParentAcc();
            PrepareForm();
            bFormLoad = false;
        }
        private void PrepareForm()
        {
            glb_function.FillListWithId(ref lstBankName, "banks", "b_name");
            FillCurrency("0");
            FillBranch("0");
          
        }
        private void FillBranch(string strAccid)
        {
            dgBranches.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBranches = cnn.GetDataTable("select b.swid,b.branch_cost_center_name BRANCH_ANAME,a.acc_id,a.swid BranchAccid " +
                                                     " from branches_costcenter b " +
                                                     " join cost_center_types cct on (cct.swid=b.costcenter_type_id)" +
                                                    " left outer JOIN acc_branch a on(b.swid = a.branch_id and a.acc_id = " + strAccid + ") where cct.branch='1' order by b.swid");

            for (int i = 0; i < dtBranches.Rows.Count; i++)
            {
                dgBranches.Rows.Add();
                dgBranches[0, dgBranches.Rows.Count - 1].Value = dtBranches.Rows[i]["BranchAccid"].ToString();
                dgBranches[1, dgBranches.Rows.Count - 1].Value = (dtBranches.Rows[i]["BranchAccid"].ToString() != "" ? true : false);
                dgBranches[2, dgBranches.Rows.Count - 1].Value = dtBranches.Rows[i]["swid"].ToString();
                dgBranches[3, dgBranches.Rows.Count - 1].Value = dtBranches.Rows[i]["BRANCH_ANAME"].ToString();
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
                dgCurrency[4, dgCurrency.Rows.Count - 1].Value = dtCurr.Rows[i]["b_acc"].ToString();
                dgCurrency[5, dgCurrency.Rows.Count - 1].Value = dtCurr.Rows[i]["b_acc"].ToString();

            }


        }
        private void FillParentAcc()
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

            dtAccData = cnn.GetDataTable("select * from accounts where   acc_class='رئيسي' and ACC_TYPE='بنوك' and acc_level=" + (iAccLevel - 1));
            if (dtAccData != null && dtAccData.Rows.Count > 0)

            {


                lstAccNo.DataSource = dtAccData;
                lstAccNo.DisplayMember = "Acc_no";
                lstAccNo.ValueMember = "swid".ToUpper();

                lstAccName.DataSource = dtAccData;

                lstAccName.DisplayMember = "acc_name";
                lstAccName.ValueMember = "swid".ToUpper();



                lstAccNo.SelectedIndex = -1;
                lstAccName.SelectedIndex = -1;
            }
        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList LstAcc = sender as myList;
            string str = LstAcc.Name;
            if (LstAcc.SelectedValue == null)
                return;

            if (LstAcc.SelectedValue.ToString() != "System.Data.DataRowView" && LstAcc.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedIndex = lstAccName.SelectedIndex = LstAcc.SelectedIndex;
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtCasherAcc = cnn.GetDataTable("select the_value from DEFAULT_VALUES t where value_name ='الرتبة" + iAccLevel + "'");

                iLastLevelValue = Convert.ToInt16(dtCasherAcc.Rows[0][0].ToString());
                if (dtCasherAcc == null || dtCasherAcc.Rows.Count <= 0)
                {
                    glb_function.MsgBox("الرجاء تحديد عدد الرتبة الاخيرة للحسابات الفرعية");
                    return;
                }

                dtCasherAcc.Rows.Clear();


                dtCasherAcc = cnn.GetDataTable("select to_number( substr(acc_no,-" + iLastLevelValue + ")) from accounts " +
                            " where acc_parent = " + LstAcc.SelectedValue.ToString() + " order by 1");
                txtAccNo.Text = "";
                int i = 0;
                for (i = 0; i < dtCasherAcc.Rows.Count; i++)
                {
                    if ((i + 1) != Convert.ToInt16(dtCasherAcc.Rows[i][0].ToString()))
                    {
                        txtAccNo.Text = (i + 1).ToString();
                        break;
                    }

                }

                if (txtAccNo.Text == "")
                    txtAccNo.Text = (i + 1).ToString();
                // txtAccNo.Text = dtCasherAcc.Rows[0][0].ToString();


                txtAccNo.Text = lstAccNo.Text + txtAccNo.Text.PadLeft(iLastLevelValue, '0');
                lstAccName.SelectedValue = LstAcc.SelectedValue;
                lstAccNo.SelectedValue = LstAcc.SelectedValue;

                iRow_Parent = GetParentRow(lstAccNo.SelectedValue.ToString());

            }

        }
        private int GetParentRow(string swid)
        {
            for (int i = 0; i < dtAccData.Rows.Count; i++)
            {
                if (dtAccData.Rows[i]["swid"].ToString() == swid)
                    return i;
            }

            return -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            lstAccName.Enabled = true;
            lstAccNo.Enabled = true;
            FillCurrency("0");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!CheckEntries())
            //    return;

            //glb_function.arrInsertLogs = new System.Collections.ArrayList();
            //ConnectionToDB cnn = new ConnectionToDB();

            //DataTable dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from BANKS");
            //txtSWID.Text = dtGetId.Rows[0][0].ToString();


            //glb_function.arrInsertLogs.Add("insert into BANKS values ((select nvl(max(swid),0)+1 from BANKS),sysdate," + glb_function.glb_strUserId + ",'فعال','" + txtB_NAME.Text.Trim() + "')");




            //for (int i = 0; i < dgvBank.Rows.Count; i++)
            //{



            //    dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from ACCOUNTS");
            //    dgvBank[clmACC_ID.Index, i].Value = dtGetId.Rows[0][0].ToString();
            //    dtGetId.Clear();
            //    dtGetId = cnn.GetDataTable("select acc_nature from accounts where swid=" + dgvBank[clmPartnerAccId.Index,i].Value.ToString());
            //    string strAcc_nature = dtGetId.Rows[0][0].ToString();
            //    glb_function.arrInsertLogs.Add
            //       ("insert into ACCOUNTS values ((" + dgvBank[clmACC_ID.Index, i].Value + ")," +
            //       " sysdate,'فعال','" + dgvBank[clmAccNo.Index, i].Value.ToString() + "','" + dtAccData.Rows[iRow_Parent]["ACC_TYPE"].ToString() + "','" +
            //       txtB_NAME.Text +"-"+ dgvBank[clmACCOUNTS_TYPE.Index, i].Value.ToString()+ "-"+ dgvBank[clmACCOUNTS_NUM_Bank.Index, i].Value.ToString()+"'," + iAccLevel + ",'فرعي" +
            //       "','تم الانشاء من شاشة البنوك',null," + dgvBank[clmPartnerAccId .Index, i].Value.ToString() +
            //       "," + glb_function.glb_strUserId + ",'ميزانية','" +
            //        "فروع',null,'" + strAcc_nature + "',null)");

            //    dtGetId.Clear();
            //    dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from BANKS_ACCOUNTS");
            //    dgvBank[clmSwid.Index,i].Value = dtGetId.Rows[0][0].ToString();

            //    glb_function.arrInsertLogs.Add
            //      ("insert into BANKS_ACCOUNTS values (" + dgvBank[clmSwid.Index, i].Value + ",sysdate,"+glb_function.glb_strUserId+",'"+ dgvBank[clmACCOUNTS_TYPE.Index, i].Value + "','"+ dgvBank[clmACCOUNTS_NUM_Bank.Index, i].Value + "',"+dgvBank[clmACC_ID.Index,i].Value.ToString()+","+txtSWID.Text +")");

            //}







            //if (glb_function.MultiTransData ())
            //    GetData(txtSWID.Text);
        }
        private void GetData(string strSwid)
        {

            new glb_function().clearItems(this);
            ConnectionToDB cnn = new ConnectionToDB();

          




            DataTable dtBank = cnn.GetDataTable("select b.*,a.acc_no,a.acc_parent,a.swid AccId " +
                                " from BANKS_ACCOUNTS b " +
                                " join accounts a on (b.acc_id = a.swid)" +
                                " where b.bank_id = " + strSwid);

            for (int i = 0; i < dtBank.Rows.Count; i++)
            {
                dgvBank.Rows.Add();
                dgvBank[clmSwid.Index, dgvBank.Rows.Count - 1].Value = dtBank.Rows[i]["swid"].ToString();
                dgvBank[clmACCOUNTS_TYPE.Index, dgvBank.Rows.Count - 1].Value = dtBank.Rows[i]["accounts_type"].ToString();
                dgvBank[clmACCOUNTS_NUM_Bank.Index, dgvBank.Rows.Count - 1].Value = dtBank.Rows[i]["accounts_num"].ToString();
                dgvBank[clmACC_ID.Index, dgvBank.Rows.Count - 1].Value = dtBank.Rows[i]["AccId"].ToString();
                dgvBank[clmAccNo.Index, dgvBank.Rows.Count - 1].Value = dtBank.Rows[i]["acc_no"].ToString();
                dgvBank[clmPartnerAccId.Index, dgvBank.Rows.Count - 1].Value = dtBank.Rows[i]["acc_parent"].ToString();

            }


            bFormLoad = true;
            FillCurrency("0");
            FillBranch("0");
            GetBankAddress();
            bFormLoad = false ;
            


            // btnSave.Visible = false;
            // btnNew.Location = btnSave.Location;
            // btnNew.Visible = true;
            // if (HasPrivilege("btnUpdate"))
            //     btnUpdate.Enabled = true;

        }

        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;

            //txtC_Name
            //if (txtB_NAME.Text == "")
            //{

            //    errCheck.SetError(txtB_NAME, "الرجاء ادخال اسم للبنك");
            //    iError = 1;
            //}
            //else
            //{
            //    errCheck.SetError(txtB_NAME, "");
            //}


            if (dgvBank.Rows.Count <= 0)
            {
                errCheck.SetError(txtAccNoBank, "الرجاء ادخال حسابات البنك");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtAccNoBank, "");
            }




            if (iError == 1)
                return false;

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // if (!CheckEntries())
            //     return;

            // glb_function.arrInsertLogs = new System.Collections.ArrayList();

            // glb_function.arrInsertLogs.Add("update  Banks set " +
            //     " b_Name='" + txtB_NAME.Text + "'" +
            //     " where swid=" + txtSWID.Text);

            // glb_function.arrInsertLogs.Add("update  accounts set " +
            //    " acc_Name='" + txtB_NAME.Text + "'" +
            //    " where swid=" + txtAccId.Text);
            // for (int i = 0; i < dgCurrency.Rows.Count; i++)
            // {
            //     if (dgCurrency[0, i].Value.ToString() == "" && dgCurrency[1, i].Value.ToString() == "True")
            //         glb_function.arrInsertLogs.Add("insert into ACC_CURR values ((select nvl(max(swid),0)+1 from ACC_CURR),sysdate," + glb_function.glb_strUserId + "," + txtAccId.Text + "," + dgCurrency[2, i].Value.ToString() + ",'" + dgCurrency[4, i].Value.ToString() + "')");
            //     else if (dgCurrency[0, i].Value.ToString() != "" && dgCurrency[1, i].Value.ToString() == "False")
            //         glb_function.arrInsertLogs.Add("delete from ACC_CURR where swid=" + dgCurrency[0, i].Value.ToString());
            //     else if (dgCurrency[0, i].Value.ToString() != "" && dgCurrency[1, i].Value.ToString() == "True")
            //     {
            //         if(dgCurrency[4,i].Value.ToString()!=dgCurrency[5,i].Value .ToString())
            //         {
            //             glb_function.arrInsertLogs.Add("update ACC_CURR set b_acc='"+dgCurrency[4,i].Value.ToString()+"' where swid="+dgCurrency[0,i].Value.ToString());

            //             glb_function.arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
            //                 "," + glb_function.glb_strUserId + ",sysdate," + dgCurrency [0, i].Value.ToString() + ",'ACC_CURR','b_acc','اسم حساب البنك','" + dgCurrency[5, i].Value.ToString() + "','" + dgCurrency[4, i].Value.ToString() + "',null)");
            //         }

            //     }




            // }
            // new glb_function().InsertToLogs(this, "Banks", txtSWID.Text,"");
            // //other table 

            //if( glb_function.MultiTransData ())

            // GetData(txtSWID .Text);
        }



        private void lstAccNo_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckEntriesDetail())
                return;


            //  dgvBank.Rows.Add();
            //  dgvBank[clmSwid.Index, dgvBank.Rows.Count - 1].Value = "";
            //  dgvBank[clmACCOUNTS_TYPE.Index, dgvBank.Rows.Count - 1].Value = lstAccType.Text ;
            //  dgvBank[clmACCOUNTS_NUM_Bank.Index, dgvBank.Rows.Count - 1].Value = txtAccNoBank.Text ;
            ////  dgvBank[clmACC_ID.Index, dgvBank.Rows.Count - 1].Value = txtAccId.Text ;
            //  dgvBank[clmAccNo.Index, dgvBank.Rows.Count - 1].Value = txtAccNo.Text ;
            //  dgvBank[clmPartnerAccId.Index, dgvBank.Rows.Count - 1].Value = lstAccNo.SelectedValue.ToString();


               if(lstBankName.SelectedIndex ==-1 )
            {
                glb_function.MsgBox("الرجاء اختيار البنك اولا");
                lstBankName.Focus();
                return;
            }
            glb_function.arrInsertLogs = new System.Collections.ArrayList();
           
         ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetId;
            

                

                dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from ACCOUNTS");
                string strAccSwid = dtGetId.Rows[0][0].ToString();
               
                string strAcc_nature = dtGetId.Rows[0][0].ToString();
                glb_function.arrInsertLogs.Add
                   ("insert into ACCOUNTS values ((" + strAccSwid + ")," +
                   " sysdate,'فعال','" + txtAccNo.Text.Trim() + "','" + dtAccData.Rows[iRow_Parent]["ACC_TYPE"].ToString() + "','" +
                   lstBankName.Text.Trim() + "-" + lstAccType.Text .Trim() + "-" + txtAccNoBank.Text .Trim() + "'," + iAccLevel + ",'فرعي" +
                   "','تم الانشاء من شاشة البنوك',null," + lstAccNo.SelectedValue.ToString() +
                   "," + glb_function.glb_strUserId + ",'ميزانية'" +
                    ",null,'" + strAcc_nature + "',null)");

                dtGetId.Clear();
                dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from BANKS_ACCOUNTS");
                string strBankAccId = dtGetId.Rows[0][0].ToString();

                glb_function.arrInsertLogs.Add
                  ("insert into BANKS_ACCOUNTS values (" + strBankAccId + ",sysdate," + glb_function.glb_strUserId + ",'" + lstAccType.Text.Trim() + "','" + txtAccNoBank.Text.Trim()+ "'," + strAccSwid + "," + lstBankName.SelectedValue.ToString() + ")");




            //for (int i = 0; i < dgCurrency.Rows.Count; i++)
            //{
            //    if (dgCurrency[0, i].Value.ToString() == "" && dgCurrency[1, i].Value.ToString() == "True")
            //        glb_function.arrInsertLogs.Add("insert into ACC_CURR values ((select nvl(max(swid),0)+1 from ACC_CURR),sysdate," + glb_function.glb_strUserId + ", " + strAccSwid + "," + dgCurrency[2, i].Value.ToString() + ",null)");
            //    else if (dgCurrency[0, i].Value.ToString() != "" && dgCurrency[1, i].Value.ToString() == "False")
            //    {
            //        glb_function.arrInsertLogs.Add("delete from ACC_CURR where swid=" + dgCurrency[0, i].Value.ToString());
            //        glb_function.arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
            //                "," + glb_function.glb_strUserId + ",sysdate," + dgCurrency[0, i].Value.ToString() + ",'ACC_CURR','ACC_ID and CURR_ID',' عملات الحسابات','" + strAccSwid + " : " + dgCurrency[2, i].Value.ToString() + "',null,'حذف صف بالكامل وهو عبارة عن العملات المرتبطة بالحسابات ويتم ادخال رقم العملة ورقم الحساب')");
            //    }

            //}

            //for (int i = 0; i < dgBranches.Rows.Count; i++)
            //{
            //    if (dgBranches[0, i].Value.ToString() == "" && dgBranches[1, i].Value.ToString() == "True")
            //        glb_function.arrInsertLogs.Add("insert into ACC_BRANCH values ((select nvl(max(swid),0)+1 from ACC_BRANCH)," + strAccSwid + "," + dgBranches[2, i].Value.ToString() + ")");
            //    else if (dgBranches[0, i].Value.ToString() != "" && dgBranches[1, i].Value.ToString() == "False")
            //    {
            //        glb_function.arrInsertLogs.Add("delete from ACC_BRANCH where swid=" + dgBranches[0, i].Value.ToString());
            //        glb_function.arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
            //                "," + glb_function.glb_strUserId + ",sysdate," + dgBranches[0, i].Value.ToString() + ",'ACC_BRANCH','ACC_ID and BRANCH_ID',' فروع الحسابات','" + strAccSwid + " : " + dgBranches[2, i].Value.ToString() + "',null,'حذف صف بالكامل وهو عبارة عن الفروع المرتبطة بالحسابات ويتم ادخال رقم الفرع ورقم الحساب')");
            //    }

            //}

            if (glb_function.MultiTransData())
                GetData(lstBankName.SelectedValue.ToString());
        }

       
        private bool CheckEntriesDetail()
        {

            int iError = 0;

            if (lstBankName.SelectedIndex==-1)
            {

                errCheck.SetError(lstBankName, "الرجاء ادخال اسم البنك");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstBankName, "");
            }

            if (lstAccNo.SelectedIndex == -1 || lstAccName.SelectedIndex == -1)
            {

                errCheck.SetError(lstAccName, "الرجاء اختيار حساب الأب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstAccName, "");
            }



            if (txtAccNo.Text == "")
            {

                errCheck.SetError(txtAccNo, "لايوجد رقم حساب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtAccNo, "");
            }
            //txtC_Name
            if (lstAccType.Text == "")
            {

                errCheck.SetError(lstAccType, "الرجاء اختيار نوع الحساب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstAccType, "");
            }

            if (txtAccNoBank.Text == "")
            {

                errCheck.SetError(txtAccNoBank, "الرجاء ادخال رقم الحساب عند البنك");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtAccNoBank, "");
            }






            if (iError == 1)
                return false;

            return true;
        }

        private void myBottun1_Click(object sender, EventArgs e)
        {
            //if (btnUpdate.Visible == false )
            //{
            //    glb_function.MsgBox("الرجاء حفظ او اختيار بيانات البنك اولا");
            //    return;
            //}
            //if(dgvBank.CurrentRow.Index<0)
            //{
            //    glb_function.MsgBox("الرجاء اختيار رقم حساب البنك");
            //    return;
            //}
            //if(dgvBank[clmSwid.Index,dgvBank.CurrentRow.Index].Value.ToString()=="")
            //{
            //    glb_function.MsgBox("الرجاء اختيار رقم حساب البنك");
            //    return;
            //}


            //glb_function.arrInsertLogs = new System.Collections.ArrayList();
            //for (int i = 0; i < dgCurrency.Rows.Count; i++)
            //{
            //    if (dgCurrency[1, i].Value.ToString() == "True")
            //    {
            //        glb_function.arrInsertLogs.Add("insert into ACC_CURR values ((select nvl(max(swid),0)+1 from ACC_CURR),sysdate," + glb_function.glb_strUserId + "," + dgvBank[clmACC_ID.Index,dgvBank.CurrentRow.Index].Value.ToString() + "," + dgCurrency[2, i].Value.ToString() + ",'" + dgCurrency[4, i].Value.ToString() + "')");

            //    }
            //}

            //if (!glb_function.MultiTransData())
            //    glb_function.MsgBox("حدثت مشكلة اثاء حفظ بيانات العملات");
            
        }

        private void dgvBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //ConnectionToDB cnn = new ConnectionToDB();
            //DataTable dtBankCurr = cnn.GetDataTable("select a.swid,a.acc_id,a.curr_id,a.b_acc ,c.curr_name " +
            //                    " from acc_curr a " +
            //                    " join currency c on (c.swid = a.curr_id) "+
            //                  "  where acc_id = "+dgvBank[clmSwid.Index,e.RowIndex].Value.ToString());


            //for (int i = 0; i < dtBankCurr.Rows.Count; i++)
            //{

            //}
            bFormLoad = true;
            FillCurrency(dgvBank[clmACC_ID.Index, e.RowIndex].Value.ToString());
            FillBranch(dgvBank[clmACC_ID.Index, e.RowIndex].Value.ToString());
            bFormLoad = false ;
        }

        private void btnSaveBank_Click(object sender, EventArgs e)
        {
            if (lstBankName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم البنك");
                return;
            }


            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into BANKS values ((select nvl(max(swid),0)+1 from BANKS),sysdate," + glb_function.glb_strUserId + ",'فعال','" + lstBankName.Text.Trim() + "')");

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء حفظ اسم البنك");
                return ;
            }

            cnn.glb_commitTransaction();

            string strBankName = lstBankName.Text.Trim();
            glb_function.FillListWithId(ref lstBankName, "banks", "b_name");

            lstBankName.Text = strBankName;

        }

        private void lstBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bFormLoad == true)
                return;

            if (lstBankName.SelectedValue == null)
            {
                new glb_function().clearItems(this);

                return;
            }
            if (lstBankName.SelectedValue.ToString() != "System.Data.DataRowView" && lstBankName.SelectedValue.ToString() != "")
            {
                GetData(lstBankName.SelectedValue.ToString());
              

            }
        }

        private void dgCurrency_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (bFormLoad == true)
                return;


            
            if (e.RowIndex >= 0 && e.ColumnIndex == clmSelectCurr.Index)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dgCurrency.CurrentCell;
                bool isChecked = (bool)checkbox.EditedFormattedValue;

                ConnectionToDB cnn = new ConnectionToDB();
                int icheck = 0;
                if (isChecked)
                {
                    DataTable dtid = cnn.GetDataTable("select nvl(max(swid),0)+1 from ACC_CURR");
                     icheck = cnn.TranDataToDB("insert into ACC_CURR values (("+ dtid.Rows[0][0].ToString()+ "),sysdate," + glb_function.glb_strUserId + ", " + dgvBank[clmACC_ID.Index ,dgvBank.CurrentRow.Index].Value.ToString() + "," + dgCurrency[2, e.RowIndex].Value.ToString() + ",null)");
                    dgCurrency[0, e.RowIndex].Value = dtid.Rows[0][0].ToString();
                    if (icheck <=0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء التعديل"+"\n" + "لم تتم العملية بنجاح");
                        return;
                    }

                    cnn.glb_commitTransaction();

                }
                else
                {

                    icheck = cnn.TranDataToDB("delete from ACC_CURR where swid=" + dgCurrency[0, e.RowIndex].Value.ToString());
                    
                    if (icheck <= 0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء التعديل" + "\n" + "لم تتم العملية بنجاح");
                        return;
                    }

                    icheck = cnn.TranDataToDB("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                                    "," + glb_function.glb_strUserId + ",sysdate," + dgCurrency[0, e.RowIndex].Value.ToString() + ",'ACC_CURR','ACC_ID and CURR_ID',' عملات الحسابات','" + dgvBank[clmACC_ID.Index ,dgvBank.CurrentRow.Index].Value.ToString() + " : " + dgCurrency[2, e.RowIndex].Value.ToString() + "',null,'حذف صف بالكامل وهو عبارة عن العملات المرتبطة بالحسابات ويتم ادخال رقم العملة ورقم الحساب')");
                    if (icheck <= 0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ اثناء التعديل" + "\n" + "لم تتم العملية بنجاح");
                        return;
                    }
                    dgCurrency[0, e.RowIndex].Value = "";

                    cnn.glb_commitTransaction();

                }

               
            }
        }

        private void dgCurrency_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgCurrency.IsCurrentCellDirty && dgCurrency.CurrentCell.ColumnIndex == clmSelectCurr.Index)
            {
                dgCurrency.EndEdit();
            }
        }

        private void lstTemplet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgBranches_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgBranches.IsCurrentCellDirty && dgBranches.CurrentCell.ColumnIndex == clmSelBranch.Index)
            {
                dgBranches.EndEdit();
            }
        }

        private void dgBranches_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (bFormLoad == true)
                return;


            //    if (dgBranches[0, i].Value.ToString() == "" && dgBranches[1, i].Value.ToString() == "True")
            //        glb_function.arrInsertLogs.Add("insert into ACC_BRANCH values ((select nvl(max(swid),0)+1 from ACC_BRANCH)," + strAccSwid + "," + dgBranches[2, i].Value.ToString() + ")");
            //    else if (dgBranches[0, i].Value.ToString() != "" && dgBranches[1, i].Value.ToString() == "False")
            //    {
            //        glb_function.arrInsertLogs.Add("delete from ACC_BRANCH where swid=" + dgBranches[0, i].Value.ToString());
            //        glb_function.arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
            //                "," + glb_function.glb_strUserId + ",sysdate," + dgBranches[0, i].Value.ToString() + ",'ACC_BRANCH','ACC_ID and BRANCH_ID',' فروع الحسابات','" + strAccSwid + " : " + dgBranches[2, i].Value.ToString() + "',null,'حذف صف بالكامل وهو عبارة عن الفروع المرتبطة بالحسابات ويتم ادخال رقم الفرع ورقم الحساب')");
            //    }



            if (e.RowIndex >= 0 && e.ColumnIndex == clmSelBranch.Index)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dgBranches.CurrentCell;
                bool isChecked = (bool)checkbox.EditedFormattedValue;

                ConnectionToDB cnn = new ConnectionToDB();
                int icheck = 0;
                if (isChecked)
                {
                    DataTable dtid = cnn.GetDataTable("select nvl(max(swid),0)+1 from ACC_BRANCH");
                    icheck = cnn.TranDataToDB("insert into ACC_BRANCH values (("+ dtid.Rows[0][0].ToString()+ ")," + dgvBank[clmACC_ID.Index,dgvBank.CurrentRow.Index].Value.ToString() + "," + dgBranches[2,e.RowIndex].Value.ToString() + ")");
                    dgBranches[0, e.RowIndex].Value=dtid.Rows[0][0].ToString();
                    if (icheck <= 0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء التعديل" + "\n" + "لم تتم العملية بنجاح");
                        return;
                    }

                    cnn.glb_commitTransaction();

                }
                else
                {

                    icheck = cnn.TranDataToDB("delete from ACC_BRANCH where swid=" + dgBranches[0, e.RowIndex].Value.ToString());
                    if (icheck <= 0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء التعديل" + "\n" + "لم تتم العملية بنجاح");
                        return;
                    }

                    icheck = cnn.TranDataToDB("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                            "," + glb_function.glb_strUserId + ",sysdate," + dgBranches[0, e.RowIndex].Value.ToString() + ",'ACC_BRANCH','ACC_ID and BRANCH_ID',' فروع الحسابات','" + dgvBank[clmACC_ID.Index,dgvBank.CurrentRow.Index].Value.ToString() + " : " + dgBranches[2, e.RowIndex].Value.ToString() + "',null,'حذف صف بالكامل وهو عبارة عن الفروع المرتبطة بالحسابات ويتم ادخال رقم الفرع ورقم الحساب')");
                    if (icheck <= 0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ اثناء التعديل" + "\n" + "لم تتم العملية بنجاح");
                        return;
                    }

                    dgBranches[0, e.RowIndex].Value = "";
                    cnn.glb_commitTransaction();

                }
            }
        }

        private void btnAddAddressBook_Click(object sender, EventArgs e)
        {
            if (lstBankName.SelectedIndex == -1)
            {
                glb_function.MsgBox("لايمكن اضافة دليل عناوين حتى يتم حفظ بيانات البنك");
                return;

            }


            File.frmContacts frm = new File.frmContacts();
          
            frm.txtADB_NAME.Text = lstBankName.Text.Trim();
            frm.ShowDialog();
            if(frm.txtSWID.Text.Trim()=="")
            {
                glb_function.MsgBox("لم يتم حفظ العنوان");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt = cnn.GetDataTable("select nvl(max(swid),0)+1 from BANK_ADDRESS");

            int icheck = cnn.TranDataToDB("insert into BANK_ADDRESS values ("+ dt .Rows[0][0].ToString()+ ","+lstBankName.SelectedValue.ToString()+","+frm.txtSWID.Text.Trim()+")");
            if(icheck <=0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ العنوان");
                return;
            }

            cnn.glb_commitTransaction();
            GetBankAddress();

        }
        private void GetBankAddress()
        {
            dgAddressBook.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtContact = cnn.GetDataTable("select ab.swid,ab.adb_name,ab.job " +
                    " from address_book ab " +
                   " where  ab.swid in (select ba.ab_id from bank_address ba where ba.bank_id = " + lstBankName.SelectedValue.ToString()+")");
           
            for (int i = 0; i < dtContact.Rows.Count; i++)
            {
                dgAddressBook.Rows.Add();
                dgAddressBook[0, dgAddressBook.Rows.Count - 1].Value = dtContact.Rows[i]["swid"].ToString();
                dgAddressBook[1, dgAddressBook.Rows.Count - 1].Value = dtContact.Rows[i]["adb_name"].ToString();
                dgAddressBook[2, dgAddressBook.Rows.Count - 1].Value = dtContact.Rows[i]["job"].ToString();

            }
        }

        private void dgAddressBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            if (e.ColumnIndex == clmJobButton.Index)
            {
                File.frmContacts frm = new File.frmContacts();
               
                frm.txtSWID.Text = dgAddressBook[0, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }
        }
    }
}
