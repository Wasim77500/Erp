using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmJournalTemplet : ERP.MyForm
    {
        DataTable dtAccData;
        int iRowAccData;
        public bool bAcceptGeneralTemp;



        public frmJournalTemplet()
        {
            InitializeComponent();
        }

        private void frmJournalTemplet_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            new glb_function().clearItems(this);
            //FillBranches();
            FillHeaderCurrency();
            FillDetailCurrency();
            lstT_TYPE.SelectedIndex = -1;
            nmbDAY.Enabled = false;
            nmbMONTH.Enabled = false;
            nmbPERIOD.Enabled = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            lstHeaderCurrency.SelectedIndex = -1;
            lstHeaderCurrency.SelectedIndex = 0;
            lstCurrency.SelectedIndex = -1;
            lstCurrency.SelectedIndex = 0;
           

            if (bAcceptGeneralTemp)
                lstGENERAL_SPECIAL.Enabled = true;
            else
            {
                lstGENERAL_SPECIAL.Text = "خاص";
                lstGENERAL_SPECIAL.Enabled = false;
            }
        }
       
        private void FillHeaderCurrency()
        {
           
                ConnectionToDB conn = new ConnectionToDB();
                DataTable MyDataTable;
                MyDataTable = conn.GetDataTable("select swid,curr_name from CURRENCY t  order by swid");
                if (MyDataTable != null)
                {


                    lstHeaderCurrency.DataSource = MyDataTable;


                lstHeaderCurrency.DisplayMember = "curr_name";
                lstHeaderCurrency.ValueMember = "SWID";

                  
                }
            

        }

        private void FillDetailCurrency()
        {

            ConnectionToDB conn = new ConnectionToDB();
            DataTable MyDataTable;
            MyDataTable = conn.GetDataTable("select swid,curr_name from CURRENCY t  order by swid");
            if (MyDataTable != null)
            {


                lstCurrency.DataSource = MyDataTable;


                lstCurrency.DisplayMember = "curr_name";
                lstCurrency.ValueMember = "SWID";


            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           
            PrepareForm();
        }

        private void lstCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCurrency.SelectedValue == null)
                return;

            if (lstCurrency.SelectedValue.ToString() != "System.Data.DataRowView" && lstCurrency.SelectedValue.ToString() != "")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtcurr = new DataTable(); ;


                dtcurr = cnn.GetDataTable("select e.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL,e.override_value from currency c,currency_exchange e " +
                           " where e.curr_id = c.swid and c.swid = " + lstCurrency.SelectedValue.ToString() + " " +
                 " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");
               
                GetAcc();

            }
        }
        bool strDataFromDataSource = false;
        private void GetAcc()
        {
            strDataFromDataSource = true;
            ConnectionToDB cnn = new ConnectionToDB();
            dtAccData = new DataTable();

           
            string sql = "select  a.swid,a.acc_no,a.acc_name,a.acc_type,a.acc_subject " +
                       " from accounts a " +
                       " left join acc_curr c on (a.swid = c.acc_id) " +
                       " left join acc_branch b on (a.swid = b.acc_id) " +
                       " where a.stat = N'فعال' and acc_class = N'فرعي' " +
                       "  and system_acc_type is null " +
                        " and b.branch_id = " + lstBranches.SelectedValue.ToString() + " " +
                        " and c.curr_id = " + lstCurrency.SelectedValue.ToString() + " " +
                        " and a.swid not in (select upa.acc_id from USER_PREVENTED_ACC upa where user_id = " + glb_function.glb_strUserId + ")";
            dtAccData = cnn.GetDataTable(sql);
            lstAccNo.DataSource = dtAccData;
            lstAccNo.ValueMember = "swid";
            lstAccNo.DisplayMember = "acc_no";

            lstAccName.DataSource = dtAccData;
            lstAccName.ValueMember = "swid";
            lstAccName.DisplayMember = "acc_name";

            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;


            strDataFromDataSource = false;
        }

        private void btnGetCostCenter_Click(object sender, EventArgs e)
        {
            if (dtAccData.Rows[iRowAccData]["acc_subject"].ToString() == "ارباح وخسائر")
            {
                frmCostCenterBranch frm = new frmCostCenterBranch();


                frm.ShowDialog();
                txtCostCenterId.Text = frm.strCostCenterSwid;
                txtCostCenterName.Text = frm.strCostCenterName;
            }
            else
            {
                glb_function.MsgBox("الرجاء تحديد حساب ارباح وخسائر");

            }
        }
        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {


            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null || strDataFromDataSource == true)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;

             
                txtCostCenterId.Text = "";
                txtCostCenterName.Text = "";

                for (int i = 0; i < dtAccData.Rows.Count; i++)
                {
                    if (dtAccData.Rows[i]["swid"].ToString() == lstParent.SelectedValue.ToString())
                    {
                        iRowAccData = i;
                        return;//use break if you have code after for loop

                    }


                }


            }
        }

        private void lstBranchHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBranches.SelectedValue == null)
                return;

            if (lstBranches.SelectedValue.ToString() != "System.Data.DataRowView" && lstBranches.SelectedValue.ToString() != "")
            {


                PrepareForm();
            }
        }

        private void lstT_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstT_TYPE.Text  == null)
                return;

            if ( lstT_TYPE.Text.ToString() != "")
            {

                if (lstT_TYPE.Text == "فترة بالأيام")
                {
                    nmbPERIOD.Enabled = true;
                    nmbMONTH.Enabled = true;
                    nmbDAY.Enabled = true;
                    nmbPERIOD.Value = 0;
                    nmbPERIOD.MinValue = 0;
                    nmbPERIOD.MaxValue = 100;

                }
                else if(lstT_TYPE.Text == "تاريخ شهري")
                {
                    nmbPERIOD.Enabled = true;
                    nmbMONTH.Enabled = false ;
                    nmbDAY.Enabled = false ;
                    nmbMONTH.Value = DateTime.Now.Month;
                    nmbPERIOD.Value = 0;
                    nmbPERIOD.MinValue = 0;
                   
                    nmbPERIOD.MaxValue = 31;
                }
                else if(lstT_TYPE.Text =="مستمر")
                {
                    nmbPERIOD.Enabled = false ;
                    nmbMONTH.Enabled = false;
                    nmbDAY.Enabled = false;
                    nmbPERIOD.Value = 0;
                    nmbMONTH.Value = 0;
                    nmbDAY.Value = 0;
                }
                    else
                {
                    glb_function.MsgBox("حدث خطأ في تحديد النوع");
                    this.Close();
                }
                
            }
        }
        private bool CheckEntries()
        {
            if(nmbPERIOD.Enabled==true )
            {
                if(nmbPERIOD.Value<=0)
                {
                    glb_function.MsgBox("الرجاء ادخال الفترة");
                    nmbPERIOD.Focus();
                    return false;
                }

            }
            if (nmbMONTH.Enabled ==true )
            {
                if(nmbMONTH.Value <=0)
                {
                    glb_function.MsgBox("الرجاء ادخال الشهر");
                    nmbMONTH.Focus();
                    return false;
                }
            }

            if (nmbDAY.Enabled == true)
            {
                if(nmbDAY.Value <=0)
                {
                    glb_function.MsgBox("الرجاء ادخال اليوم");
                    nmbDAY.Focus();
                    return false;
                }

                int iDayofMonth = DateTime.DaysInMonth(DateTime.Now.Year,(int) nmbMONTH.Value);

                if(nmbDAY.Value >iDayofMonth)
                {
                    glb_function.MsgBox("الرجاء اختيار يوم صحيح بناء على الشهر");
                    nmbDAY.Focus();
                    return false;
                }
            }



            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtPk = cnn.GetDataTable("select nvl(max(swid),0)+1 from JOURNAL_TEMPLATES_HD");

            txtSwid.Text = dtPk.Rows[0][0].ToString().Trim();
            glb_function.arrInsertLogs.Add("insert into JOURNAL_TEMPLATES_HD values ((" + txtSwid.Text + ")," +
               " sysdate,"+glb_function.glb_strUserId+","+lstBranches.SelectedValue.ToString()+
               ",'"+txtTEMPLATES_NAME.Text.Trim()+"','"+lstT_TYPE.Text.Trim()+"','"+lstGENERAL_SPECIAL.Text.Trim()+
               "',"+nmbMONTH.Value.ToString()+","+nmbDAY.Value.ToString()+","+nmbPERIOD.Value.ToString()+
               ","+lstHeaderCurrency.SelectedValue.ToString()+",'"+txtJOUR_DETAILS_Header.Text.Trim()+
               "','"+txtNOTES.Text.Trim()+"')");


            for (int i = 0; i < dgvTempDetail.Rows.Count; i++)
            {
                double dValue = 0;
                if (dgvTempDetail[clmCredit.Index, i].Value.ToString() != "0")
                    dValue = -1 * Convert.ToDouble(dgvTempDetail[clmCredit.Index, i].Value.ToString());
                else
                    dValue = Convert.ToDouble(dgvTempDetail[clmDept.Index, i].Value.ToString());

                glb_function.arrInsertLogs.Add("insert into JOURNAL_TEMPLATES_DE values ((select nvl(max(swid),0)+1 from JOURNAL_TEMPLATES_DE),"+
                    txtSwid.Text.Trim()+","+dValue .ToString()+
                    ","+ dgvTempDetail[clmCurrId.Index, i].Value.ToString() + 
                    ","+ dgvTempDetail[clmAccId.Index, i].Value.ToString() + 
                    ","+ (dgvTempDetail[clmCostCenterId.Index, i].Value.ToString()==""?"null": dgvTempDetail[clmCostCenterId.Index, i].Value.ToString()) + 
                    ",'"+dgvTempDetail[clmJourDetailNote.Index,i].Value.ToString()+"')");
            }


            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);

        }

        private void GetData(string strSwid)
        {
            new glb_function().clearItems(this);

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTemplete = cnn.GetDataTable("select h.swid swidH, h.branch_id, "+
               "  h.templates_name, h.t_type, h.general_special, "+
              "  h.month, h.day, h.period, h.curr_id CurrIdHeader, h.jour_details, h.notes, "+
               " d.swid swidD, d.templates_curr_value, d.curr_id CurrIdDetail, d.accid, " +
              "  d.cost_center_id, (select bc.branch_cost_center_name from branches_costcenter bc where bc.swid = d.cost_center_id) contCenterName, "+
              "   d.jour_details DNote "+
               " from journal_templates_hd h "+
              "  join journal_templates_de d on(h.swid= d.Header_id) where h.swid="+strSwid);



            txtSwid.Text = strSwid;
            txtTEMPLATES_NAME.Text = dtTemplete.Rows[0]["templates_name"].ToString();
            lstGENERAL_SPECIAL.Text = dtTemplete.Rows[0]["general_special"].ToString();
            lstBranches.SelectedValue =dtTemplete.Rows[0]["branch_id"].ToString();
            lstHeaderCurrency.SelectedValue = dtTemplete.Rows[0]["CurrIdHeader"].ToString();
            lstT_TYPE.Text = dtTemplete.Rows[0]["t_type"].ToString();
            nmbPERIOD.Value = Convert.ToInt64(dtTemplete.Rows[0]["period"].ToString());
            nmbMONTH.Value = Convert.ToInt64(dtTemplete.Rows[0]["month"].ToString());
            nmbDAY.Value = Convert.ToInt64(dtTemplete.Rows[0]["day"].ToString());
            lstT_TYPE_SelectedIndexChanged(null, null);//to enable and disable period,month,day controls accourding to rules

            txtJOUR_DETAILS_Header.Text = dtTemplete.Rows[0]["jour_details"].ToString();
            txtNOTES.Text = dtTemplete.Rows[0]["notes"].ToString();

            for (int i = 0; i < dtTemplete.Rows.Count; i++)
            {
                dgvTempDetail.Rows.Add();
                dgvTempDetail[clmSwid.Index, i].Value = dtTemplete.Rows[i]["swidD"].ToString();

                double dValueCredit = 0;
                double dValueDept = 0;
                if (Convert.ToDouble(dtTemplete.Rows[i]["templates_curr_value"].ToString()) > 0)
                {
                    dValueDept = Convert.ToDouble(dtTemplete.Rows[i]["templates_curr_value"].ToString());
                }
                    
                else
                    dValueCredit = -1 * Convert.ToDouble(dtTemplete.Rows[i]["templates_curr_value"].ToString());

                dgvTempDetail[clmDept.Index, i].Value = dValueDept.ToString();
                dgvTempDetail[clmCredit.Index, i].Value = dValueCredit.ToString();

                dgvTempDetail[clmCurrId.Index, i].Value = dtTemplete.Rows[i]["CurrIdDetail"].ToString();
                lstCurrency.SelectedValue = dtTemplete.Rows[i]["CurrIdDetail"].ToString();
                dgvTempDetail[clmCurrName.Index, i].Value = lstCurrency.Text;

                dgvTempDetail[clmAccId.Index, i].Value = dtTemplete.Rows[i]["accid"].ToString();

                lstAccNo.SelectedValue = dtTemplete.Rows[i]["accid"].ToString();

                dgvTempDetail[clmAccNo.Index, i].Value = lstAccNo.Text;
                dgvTempDetail[clmAccName.Index, i].Value = lstAccName.Text;

                dgvTempDetail[clmCostCenterId.Index, i].Value = dtTemplete.Rows[i]["cost_center_id"].ToString();
                dgvTempDetail[clmCostCenterName.Index, i].Value = dtTemplete.Rows[i]["contCenterName"].ToString();
                dgvTempDetail[clmJourDetailNote.Index, i].Value = dtTemplete.Rows[i]["DNote"].ToString();



            }


            ClearDetail();

            GetSum();

            btnSave.Enabled = false;

            //if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
            //if (HasPrivilege("btnDelete"))
            btnDelete.Enabled = true;
        }
        private void GetSum()
        {
            txtCreditTotal.Value = 0;
            txtDeptTotal.Value = 0;
            for (int i = 0; i < dgvTempDetail.Rows.Count; i++)
            {
              
                    txtCreditTotal.Value += Convert.ToDecimal(dgvTempDetail[clmCredit.Index, i].Value);
                    txtDeptTotal.Value += Convert.ToDecimal(dgvTempDetail[clmDept.Index, i].Value);


              

            }

            //if (txtCreditTotal.Value == txtDeptTotal.Value)
            //{
            //    txtDeptTotal.ReadOnlyBackColor = System.Drawing.Color.LightGreen;
            //    txtCreditTotal.ReadOnlyBackColor = System.Drawing.Color.LightGreen;
            //}
            //else
            //{
            //    txtDeptTotal.ReadOnlyBackColor = System.Drawing.Color.IndianRed;
            //    txtCreditTotal.ReadOnlyBackColor = System.Drawing.Color.IndianRed;
            //}

           

        }
        private void ClearDetail()
        {
            nmbCredit.Value = 0;
            nmbDept.Value = 0;
            lstCurrency.SelectedIndex = 0;
            txtCostCenterId.Text = "";
            txtCostCenterName.Text = "";
            txtJOUR_DETAILS.Text = "";
            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
            nmbCredit.Enabled = true;
            nmbDept.Enabled = true;
            nmbCredit.ReadOnly = false;
            nmbDept.ReadOnly = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (glb_function.MsgBox("هل انت متاكد من عملية الحذف؟", "", true) == false)
                return;


            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("delete from JOURNAL_TEMPLATES_DE where swid="+txtSwid.Text.Trim());

            if(icheck<=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                return;
            }

            icheck = cnn.TranDataToDB("delete from JOURNAL_TEMPLATES_HD where swid=" + txtSwid.Text.Trim());
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");


        }

        private void nmbDept_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)            
                SendKeys.Send("{TAB}");
            
        }

        private void nmbCredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                SendKeys.Send("{TAB}");
        }

        private void nmbDept_Leave(object sender, EventArgs e)
        {
            if (nmbDept.Value != 0)
                nmbCredit.ReadOnly = true;
            else
                nmbCredit.ReadOnly = false;

        }

        private void nmbCredit_Leave(object sender, EventArgs e)
        {
            if (nmbCredit.Value != 0)
                nmbDept.ReadOnly = true;
            else
                nmbDept.ReadOnly = false;
        }

        private bool CheckDetailEntries()
        {
            if (nmbDept.Value <= 0 && nmbCredit.Value <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال مبلغ المدين او الدائن.");
                // glb_function.MsgBox("العملية غير محدده ان كانت مدين او دائن؟" + "\n" + "قد يكون السبب ان للمستخدم الصلاحية لعمل قيد بسيط فقط");
                return false;
            }

            if (lstAccNo.SelectedIndex == -1)
            {
                glb_function.MsgBox("يجب ادخال رقم الحساب");
                lstAccNo.Focus();
                return false;
            }
           

            if (lstAccName.SelectedIndex == -1)
            {

                glb_function.MsgBox("يجب ادخال اسم الحساب ");
                lstAccName.Focus();
                return false;
            }
            //فحص هل اسم الحساب لديه نفس رقم تعريف رقم الحساب
            //فقط للتاكيد
            if (lstAccName.SelectedIndex != -1 && lstAccNo.SelectedIndex != -1)
                if (lstAccNo.SelectedValue.ToString().Trim() != lstAccName.SelectedValue.ToString().Trim())
                {
                    glb_function.MsgBox("الرجاء التاكد ان رقم الحساب يطابقة اسم الحساب");
                    return false;
                }

            //التاكد ان الحساب مصروف او ايراد ليتم اجبار المستخدم على ادخال مركز التكلفة
         
            if (txtCostCenterId.Text.Trim() == "")
            {
                if (dtAccData.Rows[iRowAccData]["acc_subject"].ToString() == "ارباح وخسائر")
                {

                   glb_function.MsgBox("الرجاء تحديد مركز التكلفة");
                    return false;
                    
                }
                
            }
            #region Check added value
            for (int i = 0; i < dgvTempDetail.Rows.Count; i++)
            {


                if ((dgvTempDetail[clmCredit.Index, i].Value.ToString() != "0") && nmbCredit.Value > 0 && dgvTempDetail[clmAccId.Index, i].Value.ToString() == lstAccNo.SelectedValue.ToString() && txtCostCenterId.Text == dgvTempDetail[clmCostCenterId.Index, i].Value.ToString() && lstCurrency.SelectedValue.ToString() == dgvTempDetail[clmCurrId.Index, i].Value.ToString())
                   // if (i != iUpdateRow)
                    {
                        if (glb_function.MsgBox("هذا الحساب مدخل من قبل" + "\n" + "هل تريد اضافة المبلغ؟", "", true) == true)
                        {
                           

                            dgvTempDetail[clmCredit.Index, i].Value = (Convert.ToDecimal(dgvTempDetail[clmCredit.Index, i].Value) + nmbCredit.Value).ToString();


                          
                            GetSum();
                            ClearDetail();
                            return false;
                        }





                        return false;
                    }


                if ((dgvTempDetail[clmDept.Index, i].Value.ToString() != "0") && nmbDept.Value > 0 && dgvTempDetail[clmAccId.Index, i].Value.ToString() == lstAccNo.SelectedValue.ToString() && txtCostCenterId.Text == dgvTempDetail[clmCostCenterId.Index, i].Value.ToString() && lstCurrency.SelectedValue.ToString() == dgvTempDetail[clmCurrId.Index, i].Value.ToString())
                   // if (i != iUpdateRow)
                    {
                        if (glb_function.MsgBox("هذا الحساب مدخل من قبل" + "\n" + "هل تريد اضافة المبلغ؟", "", true) == true)
                        {
                           

                            dgvTempDetail[clmDept.Index, i].Value = (Convert.ToDecimal(dgvTempDetail[clmDept.Index, i].Value) + nmbDept.Value).ToString();


                          
                            GetSum();
                            ClearDetail();
                            return false;
                        }





                        return false;
                    }



            }

            #endregion






            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckDetailEntries())
                return;

            dgvTempDetail.Rows.Add();

            dgvTempDetail[clmSwid.Index, dgvTempDetail.Rows.Count - 1].Value = "";
            dgvTempDetail[clmDept.Index, dgvTempDetail.Rows.Count - 1].Value =nmbDept.Value.ToString();
            dgvTempDetail[clmCredit.Index, dgvTempDetail.Rows.Count - 1].Value = nmbCredit.Value.ToString();
            dgvTempDetail[clmCurrId.Index, dgvTempDetail.Rows.Count - 1].Value = lstCurrency.SelectedValue.ToString();
            dgvTempDetail[clmCurrName.Index, dgvTempDetail.Rows.Count - 1].Value = lstCurrency.Text ;
            dgvTempDetail[clmAccId.Index, dgvTempDetail.Rows.Count - 1].Value =lstAccNo.SelectedValue.ToString();
            dgvTempDetail[clmAccNo.Index, dgvTempDetail.Rows.Count - 1].Value = lstAccNo.Text ;
            dgvTempDetail[clmAccName.Index, dgvTempDetail.Rows.Count - 1].Value = lstAccName.Text ;
            dgvTempDetail[clmCostCenterId.Index, dgvTempDetail.Rows.Count - 1].Value = txtCostCenterId.Text ;
            dgvTempDetail[clmCostCenterName.Index, dgvTempDetail.Rows.Count - 1].Value =txtCostCenterName.Text ;
            dgvTempDetail[clmJourDetailNote.Index, dgvTempDetail.Rows.Count - 1].Value = txtJOUR_DETAILS.Text.Trim();

            ClearDetail();
            GetSum();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindJournalTemplet frm = new frmFindJournalTemplet();

            if (bAcceptGeneralTemp)
                frm.strWhere = "";
            else
                frm.strWhere = " and general_special='خاص' ";

            frm.ShowDialog();

            if(frm.strJourTempId!="")
            {
                GetData(frm.strJourTempId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
           

           
            glb_function.arrInsertLogs.Add("update JOURNAL_TEMPLATES_HD set " +
               " TEMPLATES_NAME='" + txtTEMPLATES_NAME.Text.Trim() + "',T_TYPE='" + lstT_TYPE.Text.Trim() + "',GENERAL_SPECIAL='" + lstGENERAL_SPECIAL.Text.Trim() +
               "',MONTH=" + nmbMONTH.Value.ToString() + ",DAY=" + nmbDAY.Value.ToString() + ",PERIOD=" + nmbPERIOD.Value.ToString() +
               ",CURR_ID=" + lstHeaderCurrency.SelectedValue.ToString() + ",JOUR_DETAILS='" + txtJOUR_DETAILS_Header.Text.Trim() +
               "',NOTES='" + txtNOTES.Text.Trim() + "' where swid="+txtSwid.Text.Trim());


            for (int i = 0; i < dgvTempDetail.Rows.Count; i++)
            {

                if(dgvTempDetail[clmSwid.Index,i].Value.ToString()=="")
                {
                    double dValue = 0;
                    if (dgvTempDetail[clmCredit.Index, i].Value.ToString() != "0")
                        dValue = -1 * Convert.ToDouble(dgvTempDetail[clmCredit.Index, i].Value.ToString());
                    else
                        dValue = Convert.ToDouble(dgvTempDetail[clmDept.Index, i].Value.ToString());

                    glb_function.arrInsertLogs.Add("insert into JOURNAL_TEMPLATES_DE values ((select nvl(max(swid),0)+1 from JOURNAL_TEMPLATES_DE)," +
                        txtSwid.Text.Trim() + "," + dValue.ToString() +
                        "," + dgvTempDetail[clmCurrId.Index, i].Value.ToString() +
                        "," + dgvTempDetail[clmAccId.Index, i].Value.ToString() +
                        "," + (dgvTempDetail[clmCostCenterId.Index, i].Value.ToString() == "" ? "null" : dgvTempDetail[clmCostCenterId.Index, i].Value.ToString()) +
                        ",'" + dgvTempDetail[clmJourDetailNote.Index, i].Value.ToString() + "')");
                }
                
            }


            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);
        }

        private void nmbPERIOD_Leave(object sender, EventArgs e)
        {
            if(lstT_TYPE.Text == "تاريخ شهري")
            {
                int iDayInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                if (iDayInMonth >= nmbPERIOD.Value)
                    nmbDAY.Value = nmbPERIOD.Value;
                else
                    nmbDAY.Value = iDayInMonth;
            }
        }

        private void dgvTempDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
           

            if (glb_function.MsgBox("هل انت متاكد من عملية حذف؟", "", true) == false)
            {
                return;
            }

            //*********************
            //****************

            if (dgvTempDetail[clmSwid.Index, e.RowIndex].Value.ToString() == "")
            {
                dgvTempDetail.Rows.Remove(dgvTempDetail.Rows[e.RowIndex]);

            }
            else
            {
                ConnectionToDB cnn = new ConnectionToDB();
                int icheck = cnn.TranDataToDB("delete  from journal_templates_de where swid= "+dgvTempDetail[clmSwid.Index,e.RowIndex].Value .ToString());
                if(icheck<=0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                    return;
                }
                cnn.glb_commitTransaction();

                dgvTempDetail.Rows.Remove(dgvTempDetail.Rows[e.RowIndex]);
            }

            GetSum();


        }

    }
    
}
