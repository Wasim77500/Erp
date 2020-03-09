
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ERP.Accounts
{

   
    public partial class frmJournal : MyForm
    {
        DataTable dtAccData; int iRowAccData;

        string strHash = "";
        string strStat = "";
       

        

        decimal dMaxRate = 0;
        decimal dMinRate = 0;
        decimal dExchangeRate = 0;   //سعر الصرف الحالي
        decimal dOverrideValue;
        string iCurrSwid;

        int iCurrDecimal = 0;
      
        public string strTempswid="";

        int iUpdateRow = -1;

       
        public frmJournal()
        {
            InitializeComponent();
        }
        private void ClearAllData()
        {
            dgJOURNAL_DETAILS.Rows.Clear();
            txtCreditTotal.Value = 0;
            txtDeptTotal.Value = 0;
            txtCreditDiff.Text = "0";
            txtDeptDiff.Text = "0";
            //rbCredit.Enabled = true;
            //rbDept.Enabled = true;
            txtSWID.Text = "";
            txtVOCH_NO.Text = "";
            txtIssueId.Text = "";
            dtpJOUR_DATE.Value = DateTime.Now;
            txtJOUR_DETAILS_Header.Text = "";


            txtDeptTotal.DoubleValue = 0;
            txtCreditTotal.DoubleValue = 0;
            ClearDetailData();
        }
        private void ClearDetailData()
        {

            //nmbJOUR_VALUE.Value = 0;
            nmbDept.Value = 0;
            nmbCredit.Value = 0;

            nmbjour_valueDept.Value = 0;
            nmbjour_valueCredit.Value = 0;
            nmbCURR_PRICE.Value = 0;
            lstCurrency.SelectedIndex = (lstCurrency.Items.Count <= 0 ? -1 : 0);
            lstCurrency_SelectedIndexChanged(null, null);

            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
            lstAccNo.Text = "";
            lstAccName.Text = "";
            nmbSumOfAccBal.Value = 0;
            lblBalanceType.Visible = false ;
            iUpdateRow = -1;


            txtDetailsSWID.Text = "";
            txtCostCenterId.Text = "";
            txtCostCenterName.Text = "";
            txtJOUR_DETAILS.Text = "";
           
           
        }
        private void frmJournal_Load(object sender, EventArgs e)
        {

            //if (dtPri.Rows.Count <= 0)
            //    return;
            FillCurrency();
            PrepareForm();
            //if (strTempswid != "")
            //    GetData(strTempswid);
        }

        public override void lstTemplet_MorePrivilleges(object sender, EventArgs e)
        {


            FillBranch();

            if (nmbSumOfAccBal.Visible == false)
                lblBalanceType.Visible = false;

            else if (nmbSumOfAccBal.Visible == true)
                if (nmbSumOfAccBal.Value == 0)
                {
                    lblBalanceType.Visible = false;
                }
                else
                    lblBalanceType.Visible = true;


        }



        private  void  FillHangs()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtHangs;
            
            if(txtExchangeRateExceeded.Text =="نعم")
            dtHangs = cnn.GetDataTable("select h.swid swidJourH,h.branch_id ,hg.hang_deatels,h.issued_id  " +
                   " from journal_header h "+
                   " join hang_journal_hd hg on (h.swid = hg.jour_id) "+
                   " where h.stat = 'معلق' and hg.stat='فعال' and h.branch_id = " +lstBranchHeader.SelectedValue.ToString());
            else
                dtHangs = cnn.GetDataTable("select h.swid swidJourH,h.branch_id ,hg.hang_deatels,h.issued_id " +
                   " from journal_header h " +
                   " join hang_journal_hd hg on (h.swid = hg.jour_id) " +
                   " where h.stat = 'معلق' and hg.stat='فعال' and hg.adoption_exchange='0' and h.branch_id = " + lstBranchHeader.SelectedValue.ToString()) ;

            for (int i = 0; i < dtHangs.Rows.Count; i++)
            {
                dgvHangs.Rows.Add();
                dgvHangs[clmHangSwid.Index, i].Value = dtHangs.Rows[i]["swidJourH"].ToString();
                dgvHangs[clmIssueId.Index, i].Value = dtHangs.Rows[i]["issued_id"].ToString();

                dgvHangs[clmHangNote.Index, i].Value = dtHangs.Rows[i]["hang_deatels"].ToString();
            }
            
        }
        private void PrepareForm()
        {
            try
            {
                
                new glb_function().clearItems(this);
               
               

                FillHangs();

                FillJournaTemp();

                lstCurrency.SelectedIndex = -1;
                lstCurrency.SelectedIndex = 0;


                lstAccNo.Text = "";
                lstAccName.Text = "";
                lstAccNo.SelectedIndex = -1;
                lstAccName.SelectedIndex = -1;
                nmbCredit.DecimalPlaces = glb_function.glbMainDecimalPoint;
                nmbDept.DecimalPlaces = glb_function.glbMainDecimalPoint;
                strHash = "";
                strStat = "";
               
                lblBalanceType.Visible = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnPrint.Enabled = false;
                btnSave.Enabled = true;
               
               
                dtpJOUR_DATE.Value = glb_function.dtSysdate;

                if (dtpJOUR_DATE.Enabled == true)
                    ckbExRateDate.Enabled = true;
                else
                    ckbExRateDate.Enabled = false;

                if (HasPrivilege("btnSave"))
                {
                    dgvJourTemp.Enabled = true ;
                    btnAddJourTemp.Enabled = true;
                }
                else
                {
                    dgvJourTemp.Enabled = false ;
                    btnAddJourTemp.Enabled = false ;
                }

                if (HasPrivilege("btnUpdate"))
                {
                    dgvHangs.Enabled = true;
                  
                }
                else
                {
                    dgvHangs.Enabled = false;
                    
                }
                btnHang.Enabled = false;


            }
            catch (Exception exc)
            {
                //glb_function.MsgBox(exc.Message);
            }
        }
        private void FillBranch()
        {
            
            lstBranchHeader.DataSource = null;
            ConnectionToDB cnn = new ConnectionToDB();
           
           
          
            
            string strInStat = glb_function.GetListFromMultList(lstTempBranch.Text.Trim());

            DataTable dt = cnn.GetDataTable("select swid,b.branch_cost_center_name " +
                " from branches_costcenter b " +
                " where b.branch_cost_center_name in ("+ strInStat + ") order by swid");

            lstBranchHeader.DataSource = dt;
            lstBranchHeader.ValueMember = "swid";
            lstBranchHeader.DisplayMember = "branch_cost_center_name";

           
        }

        


        private void FillJournaTemp()
        {
            dgvJourTemp.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtJourTem = cnn.GetDataTable("select swid, templates_name, t_type, general_special, month, day ,h.period OrginalPeriod , to_char(( to_date( h.day || '/' ||h.month || '/' || to_char(sysdate,'yyyy'),'dd/mm/yyyy'))+ h.period,'dd/mm/yyyy') Period, " +
            " to_char((to_date(h.day || '/' || h.month || '/' || to_char(sysdate, 'yyyy'), 'dd/mm/yyyy')), 'dd/mm/yyyy') Monthdate "+
            " from journal_templates_hd h "+
            " where ((branch_id = "+lstBranchHeader.SelectedValue.ToString()+" and general_special = 'عام') "+
            " or(branch_id = " + lstBranchHeader.SelectedValue.ToString() + " and h.general_special = 'خاص' and h.created_user = "+glb_function.glb_strUserId+")) " +
            " and(h.t_type = 'مستمر' or(h.t_type = 'فترة بالأيام' and sysdate >= to_date(to_char((to_date(h.day || '/' || h.month || '/' || to_char(sysdate, 'yyyy'), 'dd/mm/yyyy')) + h.period, 'dd/mm/yyyy'), 'dd/mm/yyyy')) "+
             "                     or(h.t_type = 'تاريخ شهري' and sysdate >= to_date(to_char((to_date(h.day || '/' || h.month || '/' || to_char(sysdate, 'yyyy'), 'dd/mm/yyyy')), 'dd/mm/yyyy'), 'dd/mm/yyyy'))) ");



            for (int i = 0; i < dtJourTem.Rows.Count; i++)
            {
                dgvJourTemp.Rows.Add();
                dgvJourTemp[clmTempSwid.Index, i].Value = dtJourTem.Rows[i]["swid"].ToString();
                dgvJourTemp[clmTempVoucherName.Index, i].Value = dtJourTem.Rows[i]["templates_name"].ToString();
                dgvJourTemp[clmT_type.Index, i].Value = dtJourTem.Rows[i]["t_type"].ToString();
                dgvJourTemp[clmPeriod.Index, i].Value = dtJourTem.Rows[i]["OrginalPeriod"].ToString();
                dgvJourTemp[clmDay.Index, i].Value = dtJourTem.Rows[i]["day"].ToString();
                dgvJourTemp[clmMonth.Index, i].Value = dtJourTem.Rows[i]["month"].ToString();

                if (dtJourTem.Rows[i]["t_type"].ToString() == "مستمر")
                    dgvJourTemp[clmTempScheduleDate.Index, i].Value = "";
                else if (dtJourTem.Rows[i]["t_type"].ToString() == "فترة بالأيام")
                    dgvJourTemp[clmTempScheduleDate.Index, i].Value = dtJourTem.Rows[i]["Period"].ToString();
                else if (dtJourTem.Rows[i]["t_type"].ToString() == "تاريخ شهري")
                    dgvJourTemp[clmTempScheduleDate.Index, i].Value = dtJourTem.Rows[i]["Monthdate"].ToString(); 
            }

        }


        bool  strDataFromDataSource = false ;
        private string strStutas="";
      

        private void GetAcc()
        {
            strDataFromDataSource = true;

            ConnectionToDB cnn = new ConnectionToDB();
            dtAccData = new DataTable();
         
            //            dtAccData = cnn.GetDataTable("select distinct a.swid,acc_no,acc_name,acc_type from accounts a ,acc_branch b where a.swid=b.acc_id and  a.stat='فعال' and acc_class='فرعي' and (a.acc_management =N'عام' "+strCenteralAcc + " or b.swid in (select branch_id from user_branches u "+
            //" where user_id = 0))");
            //string sql = " select distinct a.swid,a.acc_no,a.acc_name,a.acc_type " +
            //                  "  from accounts a   ,acc_curr c" +
            //                   "  where a.swid = c.acc_id(+) and a.stat = N'فعال' and acc_class = N'فرعي' and system_acc_type is null" +
            //                   " and(a.acc_management = N'عام' "+ strCenteralAcc + "   or(a.acc_management = N'فروع' and exists(select branch_id from user_branches u" +
            //                   " where user_id = " + glb_function.glb_strUserId + " ))) and not exists(select aa.acc_no from USER_PREVENTED_ACC tt inner" +
            //                    "                                                      join accounts aa" +
            //                   " on aa.swid = tt.acc_id and tt.user_id = " + glb_function.glb_strUserId + " where a.acc_no like  aa.acc_no || '%')" +
            //                 (chkIgnorAccCurrency.Checked ==false  ? "  and (c.curr_id = " + lstCurrency.SelectedValue.ToString() + " or curr_id is null)":"");
            string sql = "select  a.swid,a.acc_no,a.acc_name,a.acc_type,a.acc_subject,a.acc_nature " +
                       " from accounts a " +
                       " left join acc_curr c on (a.swid = c.acc_id) " +
                       " left join acc_branch b on (a.swid = b.acc_id) " +
                       " where a.stat = N'فعال' and acc_class = N'فرعي' " +
                       "  and system_acc_type is null " +
                        " and b.branch_id = "+lstBranchHeader.SelectedValue.ToString()+" " +
                        " and c.curr_id = "+ lstCurrency.SelectedValue.ToString() + " " +
                        " and a.swid not in (select upa.acc_id from USER_PREVENTED_ACC upa where user_id = "+glb_function.glb_strUserId+")";
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
        private void FillCurrency()
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
        

       
     
     
      

        private void dgJOURNAL_DETAILS_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Index == 1)
            {



                txtCreditTotal.Width = e.Column.Width;
                txtCreditDiff.Width = txtCreditTotal.Width;
                txtDeptTotal.Left = txtCreditTotal.Width + txtCreditTotal.Left;
                txtDeptDiff.Left = txtDeptTotal.Left;
            }
            else if (e.Column.Index == 2)
            {

                txtDeptTotal.Width = e.Column.Width;
                txtDeptDiff.Width = txtDeptTotal.Width;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckDetailsEntries())
                return;



            if(iUpdateRow==-1)
            {
                dgJOURNAL_DETAILS.Rows.Add();
                iUpdateRow = dgJOURNAL_DETAILS.Rows.Count - 1;
            }
            

            dgJOURNAL_DETAILS[clmDetailSwid.Index, iUpdateRow].Value = txtDetailsSWID.Text ;
           

            dgJOURNAL_DETAILS[clmcredit.Index, iUpdateRow].Value = nmbCredit.Value.ToString();
            dgJOURNAL_DETAILS[clmDept.Index, iUpdateRow].Value = nmbDept.Value.ToString();
           

            if(nmbCredit.Value==0 )
            dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, iUpdateRow].Value = nmbjour_valueDept.Value.ToString();
            else
                dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, iUpdateRow].Value = nmbjour_valueCredit.Value.ToString();

           

            dgJOURNAL_DETAILS[clmNewCurrencyRate.Index, iUpdateRow].Value = nmbCURR_PRICE.Value.ToString();
            dgJOURNAL_DETAILS[clmCURR_ID.Index, iUpdateRow].Value = lstCurrency.SelectedValue.ToString();
            dgJOURNAL_DETAILS[clmCurrName.Index, iUpdateRow].Value = lstCurrency.Text;

            dgJOURNAL_DETAILS[clmACC_ID.Index, iUpdateRow].Value = lstAccNo.SelectedValue.ToString();
            dgJOURNAL_DETAILS[clmAccNo.Index, iUpdateRow].Value = lstAccNo.Text;
            dgJOURNAL_DETAILS[clmAccName.Index, iUpdateRow].Value = lstAccName.Text;


            dgJOURNAL_DETAILS[clmCOST_CENTER.Index, iUpdateRow].Value = txtCostCenterId.Text;
            dgJOURNAL_DETAILS[clmCostCenterName.Index, iUpdateRow].Value = txtCostCenterName.Text;
            dgJOURNAL_DETAILS[clmJOUR_DETAILS.Index, iUpdateRow].Value = txtJOUR_DETAILS.Text.Trim();
             dgJOURNAL_DETAILS[clmSTAT.Index, iUpdateRow].Value = "فعال";

            dgJOURNAL_DETAILS[clmCurrentCurrencyRateId.Index, iUpdateRow].Value = iCurrSwid;
            dgJOURNAL_DETAILS[clmMaxRate.Index, iUpdateRow].Value = dMaxRate;
            dgJOURNAL_DETAILS[clmMinRate.Index, iUpdateRow].Value = dMinRate;
            dgJOURNAL_DETAILS[clmOverrideValue.Index, iUpdateRow].Value = dOverrideValue;

            dgJOURNAL_DETAILS[clmREFERENCE_NO.Index, iUpdateRow].Value = txtRefNo.Text.Trim();





            GetSum();
            ClearDetailData();
            
           
            iUpdateRow = -1;
        }
        private void GetSum()
        {
            txtCreditTotal.Value = 0;
            txtDeptTotal.Value = 0;
            for (int i = 0; i < dgJOURNAL_DETAILS.Rows.Count; i++)
            {
                if(dgJOURNAL_DETAILS[13,i].Value .ToString()=="فعال")
                {
                    //txtCreditTotal.Value += (Convert.ToDecimal(dgJOURNAL_DETAILS[1, i].Value)>0? Convert.ToDecimal(dgJOURNAL_DETAILS[3, i].Value):0);
                    //txtDeptTotal.Value += (Convert.ToDecimal(dgJOURNAL_DETAILS[2, i].Value)>0? Convert.ToDecimal(dgJOURNAL_DETAILS[3, i].Value):0);

                    txtCreditTotal.Value += Convert.ToDecimal(dgJOURNAL_DETAILS[1, i].Value) ;
                    txtDeptTotal.Value += Convert.ToDecimal(dgJOURNAL_DETAILS[2, i].Value) ;


                }

            }
          
            if (txtCreditTotal.Value == txtDeptTotal.Value)
            {
                txtDeptTotal.ReadOnlyBackColor = System.Drawing.Color.LightGreen;
                txtCreditTotal.ReadOnlyBackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                txtDeptTotal.ReadOnlyBackColor = System.Drawing.Color.IndianRed;
                txtCreditTotal.ReadOnlyBackColor = System.Drawing.Color.IndianRed;
            }

            if (txtDeptTotal.Value >= txtCreditTotal.Value)
            {
                txtDeptDiff.Text = (txtDeptTotal.Value - txtCreditTotal.Value).ToString();
                txtCreditDiff.Text = "0";

            }
            else
            {
                txtCreditDiff.Text = (txtCreditTotal.Value - txtDeptTotal.Value).ToString();
                txtDeptDiff.Text = "0";
            }

        }
       

      

     
        private bool CheckDetailsEntries()
        {

          
            if (nmbDept.Value<=0 && nmbCredit.Value<=0)
            {
                glb_function.MsgBox("الرجاء ادخال مبلغ المدين او الدائن.");
               // glb_function.MsgBox("العملية غير محدده ان كانت مدين او دائن؟" + "\n" + "قد يكون السبب ان للمستخدم الصلاحية لعمل قيد بسيط فقط");
                return false;
            }

            int iError = 0;
            


            

            
            if (lstAccNo.SelectedIndex  ==-1)
            {

                errCheckDetails.SetError(lstAccNo, "يجب ادخال رقم الحساب ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstAccNo, "");
            }

            if (lstAccName.SelectedIndex == -1)
            {

                errCheckDetails.SetError(lstAccName, "يجب ادخال اسم الحساب ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstAccName, "");
            }


            if(txtForceNote.Text.Trim()=="نعم")
            {
                if (txtJOUR_DETAILS.Text.Trim()=="")
                {

                    errCheckDetails.SetError(txtJOUR_DETAILS, "الرجاء ادخال البيان ");
                    iError = 1;
                }
                else
                {
                    errCheckDetails.SetError(txtJOUR_DETAILS, "");
                }
            }



          


            //2**********************************************
            //فحص هل اسم الحساب لديه نفس رقم تعريف رقم الحساب
            //فقط للتاكيد
            if (lstAccName.SelectedIndex != -1 && lstAccNo.SelectedIndex != -1)
                if (lstAccNo.SelectedValue.ToString().Trim() != lstAccName.SelectedValue.ToString().Trim())
                {
                    glb_function.MsgBox("الرجاء التاكد ان رقم الحساب يطابقة اسم الحساب");
                    return false ;
                }
            //2 End****************************************************

            //1*********************************************
            //
            //التاكد ان الحساب مصروف او ايراد ليتم اجبار المستخدم على ادخال مركز التكلفة
            errCheckDetails.SetError(txtCostCenterName, "");
            if (txtCostCenterId.Text.Trim()=="")
            {
                if (dtAccData.Rows[iRowAccData]["acc_subject"].ToString() == "ارباح وخسائر")
                {

                    errCheckDetails.SetError(txtCostCenterName, "الرجاء تحديد مركز التكلفة");
                    iError = 1;
                }
                else
                {
                    errCheckDetails.SetError(txtCostCenterName, "");
                }
            }
            

            #region CheckNaturaAcc
            //check account Natur

            if(btnSave.Enabled==true )
            {
                decimal dBalance = 0;
                if (lblBalanceType.Text == "دائن")
                    dBalance = nmbSumOfAccBal.Value * -1;
                else
                    dBalance = nmbSumOfAccBal.Value;

                if (nmbDept.Value > 0)
                    dBalance = dBalance + nmbDept.Value;
                else
                    dBalance = dBalance - nmbCredit.Value;

                bool bExceededNaturalAcc = false;
                if (dtAccData.Rows[iRowAccData]["acc_nature"].ToString() == "مدين" && dBalance < 0)
                    bExceededNaturalAcc = true;
                else if (dtAccData.Rows[iRowAccData]["acc_nature"].ToString() == "دائن" && dBalance > 0)
                    bExceededNaturalAcc = true;
                else
                    bExceededNaturalAcc = false;


                if (bExceededNaturalAcc)
                {
                    if (txtAllowExceedNaturalAcc.Text == "نعم")
                    {
                        if (glb_function.MsgBox("تجاوز طبيعة الحساب" + "\n" + "هل تريد الاستمرار؟", "", true) == false)
                            return false;
                    }
                    else
                    {
                        glb_function.MsgBox("تجاوز طبيعة الحساب");
                        return false;
                    }
                }
            }
           
            #endregion



            if (iError == 1)
                return false;
            //1 ************************
            #region Check added value
            for (int i = 0; i < dgJOURNAL_DETAILS.Rows.Count; i++)
            {

                string strdd = dgJOURNAL_DETAILS[10, i].Value.ToString();
                string strtt = txtCostCenterId.Text;
                if ((dgJOURNAL_DETAILS[clmcredit.Index, i].Value.ToString() != "0") && nmbCredit.Value > 0 && dgJOURNAL_DETAILS[clmACC_ID.Index, i].Value.ToString() == lstAccNo.SelectedValue.ToString() && txtCostCenterId.Text == dgJOURNAL_DETAILS[clmCOST_CENTER.Index, i].Value.ToString() && lstCurrency.SelectedValue.ToString() == dgJOURNAL_DETAILS[clmCURR_ID.Index, i].Value.ToString())
                    if (i != iUpdateRow)
                    {
                        if (glb_function.MsgBox("هذا الحساب مدخل من قبل" + "\n" + "هل تريد اضافة المبلغ؟", "", true) == true)
                        {
                            dgJOURNAL_DETAILS[clmSTAT.Index, i].Value = "فعال";
                            for (int y = 0; y < dgJOURNAL_DETAILS.Rows[i].Cells.Count - 1; y++)
                            {
                                dgJOURNAL_DETAILS.Rows[i].Cells[y].Style.BackColor = System.Drawing.Color.White;
                            }

                            dgJOURNAL_DETAILS[clmcredit.Index, i].Value = (Convert.ToDecimal(dgJOURNAL_DETAILS[clmcredit.Index, i].Value) + nmbCredit.Value).ToString();


                            dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, i].Value = (Convert.ToDecimal(dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, i].Value) + nmbjour_valueCredit.Value).ToString();
                            dgJOURNAL_DETAILS[clmNewCurrencyRate.Index, i].Value = (Convert.ToDecimal(dgJOURNAL_DETAILS[clmcredit.Index, i].Value) / Convert.ToDecimal(dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, i].Value)).ToString();
                            GetSum();
                            ClearDetailData();
                            return false;
                        }





                        return false;
                    }


                if ((dgJOURNAL_DETAILS[clmDept.Index, i].Value.ToString() != "0") && nmbDept.Value > 0 && dgJOURNAL_DETAILS[clmACC_ID.Index, i].Value.ToString() == lstAccNo.SelectedValue.ToString() && txtCostCenterId.Text == dgJOURNAL_DETAILS[clmCOST_CENTER.Index, i].Value.ToString() && lstCurrency.SelectedValue.ToString() == dgJOURNAL_DETAILS[clmCURR_ID.Index, i].Value.ToString())
                    if (i != iUpdateRow)
                    {
                        if (glb_function.MsgBox("هذا الحساب مدخل من قبل" + "\n" + "هل تريد اضافة المبلغ؟", "", true) == true)
                        {
                            dgJOURNAL_DETAILS[clmSTAT.Index, i].Value = "فعال";
                            for (int y = 0; y < dgJOURNAL_DETAILS.Rows[i].Cells.Count - 1; y++)
                            {
                                dgJOURNAL_DETAILS.Rows[i].Cells[y].Style.BackColor = System.Drawing.Color.White;
                            }

                            dgJOURNAL_DETAILS[clmDept.Index, i].Value = (Convert.ToDecimal(dgJOURNAL_DETAILS[clmDept.Index, i].Value) + nmbDept.Value).ToString();


                            dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, i].Value = (Convert.ToDecimal(dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, i].Value) + nmbjour_valueDept.Value).ToString();
                            dgJOURNAL_DETAILS[clmNewCurrencyRate.Index, i].Value = (Convert.ToDecimal(dgJOURNAL_DETAILS[clmDept.Index, i].Value) / Convert.ToDecimal(dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, i].Value)).ToString();
                            GetSum();
                            ClearDetailData();
                            return false;
                        }





                        return false;
                    }



            }
            //***************************
            #endregion





            return true;

           
        }

        private void lstCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCurrency.SelectedValue == null)
                return;

            if (lstCurrency.SelectedValue.ToString() != "System.Data.DataRowView" && lstCurrency.SelectedValue.ToString() != "")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtcurr = new DataTable(); ;
                if(ckbExRateDate.Checked==false )
                dtcurr=cnn.GetDataTable("select e.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL,e.override_value,e.created_date " +
                                " from currency c, currency_exchange e " +
                                " where e.curr_id = c.swid and c.swid = "+ lstCurrency.SelectedValue.ToString() + " " +
                                " and e.created_date <= to_date('" + dtpJOUR_DATE.Value.ToString("dd/MM/yyyy") + "', 'dd/mm/yyyy') " +
                                " and e.swid = (select max(e.swid) from currency c, currency_exchange e " +
                                " where e.curr_id = c.swid and c.swid = "+ lstCurrency.SelectedValue.ToString() + " " +
                                " and e.created_date <= to_date('"+dtpJOUR_DATE.Value.ToString("dd/MM/yyyy")+"', 'dd/mm/yyyy'))");
                else
                    dtcurr = cnn.GetDataTable("select e.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL,e.override_value from currency c,currency_exchange e " +
                               " where e.curr_id = c.swid and c.swid = " + lstCurrency.SelectedValue.ToString() + " " +
                     " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

                iCurrSwid = dtcurr.Rows[0]["swid"].ToString();
                dMaxRate =Convert.ToDecimal ( dtcurr.Rows[0]["CURR_MAX"].ToString());
                dMinRate  = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MIN"].ToString());
                dExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
                iCurrDecimal = Convert.ToInt16 (dtcurr.Rows[0]["CURR_DECIMAL"].ToString());
                dOverrideValue = Convert.ToDecimal(dtcurr.Rows[0]["override_value"].ToString());


                nmbDept.Value = 0;
                nmbCredit.Value = 0;
                nmbjour_valueCredit.Value = 0;
                nmbjour_valueDept.Value = 0;
                nmbjour_valueCredit.DecimalPlaces = iCurrDecimal;
                nmbjour_valueDept.DecimalPlaces = iCurrDecimal;
                nmbSumOfAccBal.DecimalPlaces = iCurrDecimal;
                nmbDept.ReadOnly = false ;
                nmbCredit.ReadOnly = false ;

                if (lstCurrency.SelectedValue.ToString()!=glb_function.glb_MainCurrencyId.ToString())
                {
                    nmbjour_valueCredit.Enabled = true;
                    nmbjour_valueDept.Enabled = true;
                    

                   
                }
                else
                {
                    nmbjour_valueCredit.Enabled = false;
                    nmbjour_valueDept.Enabled = false;
                }

                nmbCURR_PRICE.Value  = dExchangeRate;
              

                //ليتم تحميل الحسابات بناء على فروع المستخدم
                GetAcc();

                nmbSumOfAccBal.Value = glb_function.GetAccBalance((lstCurrency.SelectedIndex == -1 ? "0" : lstCurrency.SelectedValue.ToString()), (lstAccNo.SelectedIndex == -1 ? "0" : lstAccNo.SelectedValue.ToString()));

              

            }
        }

        private void nmbCURR_PRICE_ValueChanged(object sender, EventArgs e)
        {
          //  if (iDicimalChangge)
             //   return;

            if (nmbCURR_PRICE.Value >= dMinRate && nmbCURR_PRICE.Value <= dMaxRate)
            {
               // nmbJOUR_MAIN_VALUE.Value = nmbCURR_PRICE.Value * nmbJOUR_VALUE.Value;
            }
            else
            {
                glb_function.MsgBox("المبلغ المدخل ليس في المجال المسموح به لسعر الصرف");
                nmbCURR_PRICE.Value = dExchangeRate;
            }

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

      
     
        private decimal PFrictionDiff(ref decimal CURR_PRICE, ref decimal JOUR_MAIN_VALUE, ref decimal JOUR_VALUE, string cu)
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
                            " where e.curr_id = c.swid and c.swid = " + cu + " " +
                  " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

            dMaxRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MAX"].ToString());
            dMinRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MIN"].ToString());
            dExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
            iCurrDecimal = Convert.ToInt16(dtcurr.Rows[0]["CURR_DECIMAL"].ToString());

            decimal d = 0;
            if (CURR_PRICE >= dMinRate && CURR_PRICE <= dMaxRate)
            {
                JOUR_MAIN_VALUE = Math.Truncate(CURR_PRICE * JOUR_VALUE);

            }
            else if (CURR_PRICE < dMinRate)
            {

                if (((JOUR_MAIN_VALUE * dMinRate) - (JOUR_MAIN_VALUE * CURR_PRICE)) < 1 && ((JOUR_MAIN_VALUE * dMinRate) - (JOUR_MAIN_VALUE * CURR_PRICE)) > 0)
                {
                    //  nmbJOUR_MAIN_VALUE.Value = nmbCURR_PRICE.Value * nmbJOUR_VALUE.Value;
                    //d = ((nmbJOUR_MAIN_VALUE.Value * dMinRate) - (nmbJOUR_MAIN_VALUE.Value * nmbCURR_PRICE.Value));
                    CURR_PRICE = dMinRate;
                }
                else
                {
                    CURR_PRICE = dMinRate;
                    JOUR_MAIN_VALUE = Math.Truncate(CURR_PRICE * JOUR_VALUE);
                }

            }
            else if (CURR_PRICE > dMaxRate)
            {

                if (((JOUR_MAIN_VALUE * dMaxRate) - (JOUR_MAIN_VALUE * CURR_PRICE)) > -1 && ((JOUR_MAIN_VALUE * CURR_PRICE)) < 0)
                {
                    // nmbJOUR_MAIN_VALUE.Value = nmbCURR_PRICE.Value * nmbJOUR_VALUE.Value;
                    // d = ((nmbJOUR_MAIN_VALUE.Value * dMaxRate) - (nmbJOUR_MAIN_VALUE.Value * nmbCURR_PRICE.Value));
                    CURR_PRICE = dMaxRate;
                }
                else
                {
                    CURR_PRICE = dMaxRate;
                    JOUR_MAIN_VALUE = Math.Truncate(CURR_PRICE * JOUR_VALUE);
                }

            }
            else
            {
                glb_function.MsgBox("المبلغ المدخل ليس في المجال المسموح به لسعر الصرف");
                CURR_PRICE = dExchangeRate;
                // nmbJOUR_MAIN_VALUE.Value = nmbCURR_PRICE.Value * nmbJOUR_VALUE.Value;
                JOUR_MAIN_VALUE = Math.Truncate(CURR_PRICE * JOUR_VALUE);
            }

            //mydecimal = nmbCURR_PRICE.Value * nmbJOUR_VALUE.Value;
            //mydecimal = Math.Round(   nmbJOUR_MAIN_VALUE.Value - mydecimal, 7);
            //txtFrictionDiff.Text=mydecimal.ToString();
            if (JOUR_MAIN_VALUE != CURR_PRICE * JOUR_VALUE)
                d = (JOUR_MAIN_VALUE - (CURR_PRICE * JOUR_VALUE));


            return d;
        }


        private void btnClearDetails_Click(object sender, EventArgs e)
        {
            ClearDetailData();
        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null || strDataFromDataSource == true)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;

                decimal dBalance = glb_function.GetAccBalance((lstCurrency.SelectedIndex == -1 ? "0" : lstCurrency.SelectedValue.ToString()), (lstAccNo.SelectedIndex == -1 ? "0" : lstAccNo.SelectedValue.ToString()));

                lblBalanceType.Visible = true;
                if (dBalance >= 0)
                    lblBalanceType.Text = "مدين";
                else
                {
                    lblBalanceType.Text = "دائن";
                    dBalance = dBalance * -1;
                }

                nmbSumOfAccBal.Value = dBalance;


                txtCostCenterId.Text = "";
                txtCostCenterName.Text = "";

                for (int i = 0; i < dtAccData.Rows.Count; i++)
                {
                    if (dtAccData.Rows[i]["swid"].ToString() == lstParent.SelectedValue.ToString())
                    {
                        iRowAccData = i;
                        return ;//use break if you have code after for loop

                    }
                 
                        
                }

              
            }
            }
        //private decimal GetAvgCurrRate()
        //{
        //    ConnectionToDB cnn = new ConnectionToDB();
        //    DataTable dtGetAvg = cnn.GetDataTable("select nvl( sum(t.jour_value),0),nvl(sum(t.jour_main_value),0) "+
        //                           " from journal_header h, JOURNAL_DETAILS t  where "+
        //                           " h.swid = t.jour_id and curr_id = "+lstCurrency.SelectedValue .ToString()+
        //                           " and acc_id =" + lstAccNo.SelectedValue .ToString()+
        //                           " and h.stat = N'مرحل'");

        //    decimal jour_value = Convert.ToDecimal(dtGetAvg.Rows[0][0].ToString());
        //    decimal jour_main_value = Convert.ToDecimal(dtGetAvg.Rows[0][1].ToString());
        //    decimal AvgCurrRate = 0;
        //    if (jour_value !=0)
        //           AvgCurrRate = jour_main_value / jour_value;
        //    return Math.Round(   AvgCurrRate,7);
        //}
       
       
        private void btnGetAccount_Click(object sender, EventArgs e)
        {
            Accounts.frmFindAccount frm = new Accounts.frmFindAccount();
            
            frm.strSelect = "select  a.swid,a.acc_no,a.acc_name,a.acc_type,a.acc_subject,a.acc_nature,acc_class " +
                       " from accounts a " +
                       " left join acc_curr c on (a.swid = c.acc_id) " +
                       " left join acc_branch b on (a.swid = b.acc_id) " +
                       " where a.stat = N'فعال' and acc_class = N'فرعي' " +
                       "  and system_acc_type is null " +
                        " and b.branch_id = " + lstBranchHeader.SelectedValue.ToString() + " " +
                        " and c.curr_id = " + lstCurrency.SelectedValue.ToString() + " " +
                        " and a.swid not in (select upa.acc_id from USER_PREVENTED_ACC upa where user_id = " + glb_function.glb_strUserId + ")";
            // = "select distinct a.swid,acc_no,acc_name,acc_type,a.acc_management,a.acc_class from accounts a ,acc_branch b ";
            frm.strWhere = "";
           
            frm.ShowDialog();
            if (frm.strAccid != "")
            {
                lstAccName.SelectedValue = Convert.ToInt16(frm.strAccid);
            }
            else
            {
                lstAccNo.Text = "";
                lstAccName.Text = "";
                lstAccNo.SelectedIndex = -1;
                lstAccName.SelectedIndex = -1;
            }
               
        }
        private bool CheckEntries()
        {

            strStutas = "";
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
          
            if (txtDeptTotal.Value != txtCreditTotal.Value)
            {
                glb_function.MsgBox("المدين والدائن لا يتطابقان");
                return false;
            }
            if (txtDeptTotal.Value==0)
            {
                glb_function.MsgBox("لايمكن ان تكون قيمة المدين والدائن بصفر");
                return false;
            }
            if (dgJOURNAL_DETAILS.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال بيانات القيد");
                return false;
            }

            //for (int i = 0; i < dgJOURNAL_DETAILS.Rows.Count; i++)
            //{
            //    if (Convert.ToDecimal(dgJOURNAL_DETAILS[clmNewCurrencyRate.Index, i].Value.ToString()) > Convert.ToDecimal(dgJOURNAL_DETAILS[clmMaxRate.Index, i].Value.ToString()) || Convert.ToDecimal(dgJOURNAL_DETAILS[clmNewCurrencyRate.Index, i].Value.ToString()) < Convert.ToDecimal(dgJOURNAL_DETAILS[clmMinRate.Index, i].Value.ToString()))
            //        strStutas = "معلق";
            //}

            return true;
        }
            private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUpdateJournal();


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindVoucherNo frm = new frmFindVoucherNo();
            //  frm.strWhere = " and voch_type = 'قيد' and  h.stat in (" + glb_function.GetListFromMultList(lstTempStat.Text.Trim()) + ")  and d.stat='فعال'";
            frm.strWhere = " and issued_type = 'قيد' and  h.stat='فعال' and b.branch_cost_center_name in (" + glb_function.GetListFromMultList(lstTempBranch.Text.Trim()) +")";
            frm.ShowDialog();
            if (frm.strJourId != "")
            {
                txtSWID.Text = frm.strJourId;
                GetData(txtSWID.Text);

            }
        }
       
        private   void GetData(string strJour_id)
        {
            gbDetail.Visible = false;

            new glb_function().clearItems(this);



            PrepareForm();



           
            

            ConnectionToDB cnn = new ConnectionToDB();
             strStat = "select h.swid, h.created_date, h.created_user, h.stat, h.issued_type,h.issued_id, "+
             "   h.stir_no,to_char(h.jour_date, 'dd/mm/yyyy') jour_date, h.jour_details, h.branch_id, h.year_n,h.exchange_in_date, " +
                " d.swid swid_D, "+
                 "  CASE when(d.jour_main_value > 0) then d.jour_main_value else 0 end dept, " +
                  "   CASE when(d.jour_main_value < 0) then d.jour_main_value * -1 else 0 end credit, " +
                   " CASE when(d.jour_value > 0) then d.jour_value else jour_value * -1 end jour_value, "+
                   "   d.acc_id, "+
                    "   d.curr_id, "+
                     "  d.curr_price, "+
                      "  d.cost_center_id,(select cc.cost_center_name from costcenter cc where cc.swid = d.cost_center_id) costcenter_name, "+
                     "   d.jour_details jour_details_note, d.stat stat_d,d.reference_no " +
                     "  from journal_header h "+
                     "  join journal_details d on (h.swid = d.jour_id) "+
                     "  where d.stat = 'فعال'  and h.swid =  " + strJour_id;
            
           

             DataTable dtJournal = cnn.GetDataTable(strStat );
            if (dtJournal.Rows[0]["stat"].ToString()=="معلق")
            {
                PrepareForm();
                return;
            }



                strHash = glb_function.GetSelectHash(strStat);

           
            txtSWID.Text = strJour_id;


            
             
            txtIssueId.Text = dtJournal.Rows[0]["issued_id"].ToString();
            lstBranchHeader.SelectedValue = Convert.ToInt16(dtJournal.Rows[0]["branch_id"].ToString().Trim());
            dtpJOUR_DATE.Value = DateTime.ParseExact (dtJournal.Rows[0]["JOUR_DATE"].ToString(),"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
            txtJOUR_DETAILS_Header.Text = dtJournal.Rows[0]["jour_details"].ToString();
            
            txtVOCH_NO.Text = dtJournal.Rows[0]["stir_no"].ToString();
            if (dtJournal.Rows[0]["exchange_in_date"].ToString() == "1")
                ckbExRateDate.Checked = true;
            else
                ckbExRateDate.Checked = false;

            //Get Detail data

            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {
                dgJOURNAL_DETAILS.Rows.Add();
                dgJOURNAL_DETAILS[clmDetailSwid.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["swid_D"].ToString();
                dgJOURNAL_DETAILS[clmcredit.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["credit"].ToString();
                dgJOURNAL_DETAILS[clmDept.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["dept"].ToString();
                dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["jour_value"].ToString();
                dgJOURNAL_DETAILS[clmACC_ID.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["acc_id"].ToString();
                dgJOURNAL_DETAILS[clmCURR_ID.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["curr_id"].ToString();
                lstCurrency.SelectedValue = dtJournal.Rows[i]["curr_id"].ToString();
                dgJOURNAL_DETAILS[clmCurrName.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = lstCurrency.Text ;
                lstAccNo.SelectedValue = dtJournal.Rows[i]["acc_id"].ToString();


                dgJOURNAL_DETAILS[clmAccNo.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = lstAccNo.Text;
                dgJOURNAL_DETAILS[clmAccName.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = lstAccName.Text;
              
              
                dgJOURNAL_DETAILS[clmNewCurrencyRate.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["curr_price"].ToString();


                dgJOURNAL_DETAILS[clmCOST_CENTER.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["cost_center_id"].ToString();
                dgJOURNAL_DETAILS[clmCostCenterName.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["costcenter_name"].ToString();
                dgJOURNAL_DETAILS[clmJOUR_DETAILS.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["jour_details_note"].ToString();
                dgJOURNAL_DETAILS[clmSTAT.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["stat_d"].ToString();

                dgJOURNAL_DETAILS[clmREFERENCE_NO.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dtJournal.Rows[i]["reference_no"].ToString();





                dgJOURNAL_DETAILS[clmCurrentCurrencyRateId.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = iCurrSwid;
                dgJOURNAL_DETAILS[clmMaxRate.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dMaxRate;
                dgJOURNAL_DETAILS[clmMinRate.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dMinRate;
                dgJOURNAL_DETAILS[clmOverrideValue.Index, dgJOURNAL_DETAILS.Rows.Count - 1].Value = dOverrideValue;

            }
            GetSum();
            ClearDetailData();
            btnSave.Enabled = false;
            ckbExRateDate.Enabled = false;

            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

            if (HasPrivilege("btnDelete"))
                btnDelete .Enabled = true;

            if (HasPrivilege("btnPrint"))
                btnPrint.Enabled = true;

            gbDetail.Visible = true;

        }

        private void dgJOURNAL_DETAILS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
                if (e.RowIndex == -1 )
                    return;

            //if (dgJOURNAL_DETAILS[clmSTAT.Index, e.RowIndex].Value.ToString() == "ملغي")
            //{
            //    dgJOURNAL_DETAILS[clmSTAT.Index, e.RowIndex].Value = "فعال";
            //    for (int y = 0; y < dgJOURNAL_DETAILS.Rows[e.RowIndex].Cells.Count - 1; y++)
            //    {
            //        dgJOURNAL_DETAILS.Rows[e.RowIndex].Cells[y].Style.BackColor = System.Drawing.Color.White;
            //    }
            //    return;
            //}
               


            if (e.ColumnIndex ==clmDelete.Index)
            {

                
                if(iUpdateRow!=-1)
                {
                    glb_function.MsgBox("لايمكن الحذف العملية قيد التعديل");
                    return;
                }
             
                if(glb_function.MsgBox("هل انت متاكد من عملية حذف؟","",true )==false )
                {
                    return;
                }

                //*********************
                //****************

                if (dgJOURNAL_DETAILS[0, e.RowIndex].Value.ToString()=="")
                {
                    dgJOURNAL_DETAILS.Rows.Remove(dgJOURNAL_DETAILS.Rows [e.RowIndex]);
                   
                }
                else
                {
                    if (dgJOURNAL_DETAILS[13, e.RowIndex].Value.ToString() == "فعال")
                    {
                        dgJOURNAL_DETAILS[13, e.RowIndex].Value = "ملغي";
                        for (int y = 0; y < dgJOURNAL_DETAILS.Rows[e.RowIndex].Cells.Count - 1; y++)
                        {
                            dgJOURNAL_DETAILS.Rows[e.RowIndex].Cells[y].Style.BackColor = System.Drawing.Color.MediumVioletRed;
                        }
                    }
                    
                   
                }

                GetSum();

               
            }
        }

        private void dgJOURNAL_DETAILS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgJOURNAL_DETAILS[13, e.RowIndex].Value.ToString() == "ملغي")
                return;
            if (clmActivity.Index == e.ColumnIndex || clmDelete.Index == e.ColumnIndex)
                return;

            ClearDetailData();
           
            iUpdateRow = e.RowIndex;
           txtDetailsSWID.Text = dgJOURNAL_DETAILS[clmDetailSwid.Index, iUpdateRow].Value.ToString ();
          
            lstCurrency.SelectedValue = dgJOURNAL_DETAILS[clmCURR_ID.Index, iUpdateRow].Value.ToString();
            //lstCurrency.Text = dgJOURNAL_DETAILS[8, iUpdateRow].Value.ToString();

           
           

            
            lstAccNo.SelectedValue= dgJOURNAL_DETAILS[clmACC_ID.Index, iUpdateRow].Value.ToString();
            //lstAccNo.Text= dgJOURNAL_DETAILS[5, iUpdateRow].Value.ToString();
            //lstAccName.Text= dgJOURNAL_DETAILS[6, iUpdateRow].Value.ToString();
          
            nmbCURR_PRICE.Text= dgJOURNAL_DETAILS[clmNewCurrencyRate.Index, iUpdateRow].Value.ToString();
            txtCostCenterId.Text=dgJOURNAL_DETAILS[clmCOST_CENTER.Index, iUpdateRow].Value.ToString();
            txtCostCenterName.Text= dgJOURNAL_DETAILS[clmCostCenterName.Index, iUpdateRow].Value.ToString();
            txtJOUR_DETAILS.Text= dgJOURNAL_DETAILS[clmJOUR_DETAILS.Index, iUpdateRow].Value.ToString();
            txtRefNo.Text = dgJOURNAL_DETAILS[clmREFERENCE_NO.Index, iUpdateRow].Value.ToString();

            if (dgJOURNAL_DETAILS[clmcredit.Index, iUpdateRow].Value.ToString() == "0")
            {
                nmbDept.Value = Convert.ToDecimal(dgJOURNAL_DETAILS[clmDept.Index, iUpdateRow].Value);
                nmbjour_valueDept.Value = Convert.ToDecimal(dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, iUpdateRow].Value);
                nmbjour_valueCredit.Value = 0;
            }
            else
            {
                nmbCredit.Value = Convert.ToDecimal(dgJOURNAL_DETAILS[clmcredit.Index, iUpdateRow].Value);
                nmbjour_valueCredit.Value = Convert.ToDecimal(dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, iUpdateRow].Value);
                nmbjour_valueDept.Value = 0;
            }
               
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            PrepareForm();

            //try
            //{
               
            //    //GetMainCurrency();
               

               
            //    //lstTemplet.SelectedIndex = -1;
            //    //lstTemplet.SelectedIndex = 0;
            //    //lstBranchHeader.SelectedValue = glb_function.glb_BranchNo;
            //    //lstCurrency.SelectedIndex = -1;
            //    //lstCurrency.SelectedIndex = 0;
            //    //nmbjour_valueDept.DecimalPlaces = iMainCurrDecimal;

            //    //lstAccNo.Text = "";
            //    //lstAccName.Text = "";
            //    //lstAccNo.SelectedIndex = -1;
            //    //lstAccName.SelectedIndex = -1;

            //    //strHash = "";
            //    //strStat = "";
            //    //btnUpdate.Enabled = false;
            //    //btnDelete .Enabled = false;
            //    //btnNew.Visible = false;
            //    //btnSave.Visible = true;

            //}
            //catch (Exception exc)
            //{
            //    glb_function.MsgBox(exc.Message);
            //}

            
        }
        private void SaveUpdateJournal()
        {
            if (!CheckEntries())
                return;


            StringBuilder sbGetXml = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(sbGetXml);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("DocumentElement".ToLower());

            xmlWriter.WriteStartElement("journal_header".ToLower());

            xmlWriter.WriteElementString("SWID".ToLower(), txtSWID.Text);

            xmlWriter.WriteElementString("STAT".ToLower(), (strStutas == "" ? "فعال" : strStutas));

            xmlWriter.WriteElementString("CREATED_USER".ToLower(), glb_function.glb_strUserId);

            xmlWriter.WriteElementString("branch_id".ToLower(), lstBranchHeader.SelectedValue.ToString());

            xmlWriter.WriteElementString("year_n".ToLower(), dtpJOUR_DATE.Value.ToString("yyyy"));
            xmlWriter.WriteElementString("JOUR_DATE".ToLower(), dtpJOUR_DATE.Value.ToString("dd/MM/yyyy"));

            string strExhangeInDate = "";
            if (ckbExRateDate.Checked)
                strExhangeInDate = "1";
            else
                strExhangeInDate = "0";

            xmlWriter.WriteElementString("exchange_in_date".ToLower(), strExhangeInDate);
            xmlWriter.WriteElementString("jour_details".ToLower(), txtJOUR_DETAILS_Header.Text);

           

            if(btnSave.Enabled==true)
            {
                ConnectionToDB conn = new ConnectionToDB();
                DataTable dtVochMax = conn.GetDataTable("select nvl( max(issued_id),0)+1 from journal_header where  issued_type='قيد' and branch_id=" + lstBranchHeader.SelectedValue.ToString() + " and year_n=" + dtpJOUR_DATE.Value.ToString("yyyy"));
                string strIssueId = dtVochMax.Rows[0][0].ToString();
                xmlWriter.WriteElementString("issued_id".ToLower(), strIssueId);

               
            }
               else
            {
                xmlWriter.WriteElementString("issued_id".ToLower(), txtIssueId.Text.Trim());
            }

            xmlWriter.WriteElementString("issued_type".ToLower(), "قيد");




            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();
            string strHeader = sbGetXml.ToString();


            //DataTable dt = new DataTable();
            //dt.TableName = "sqlsttab";
            // dt = (DataTable)(dgJOURNAL_DETAILS.DataSource);
            DataTable dt = new DataTable();
            dt.TableName = "JOURNAL_DETAILS".ToLower();
            //Add Columns name 
            dt.Columns.Add("swid");
            dt.Columns.Add("credit");
            dt.Columns.Add("dept");
            dt.Columns.Add("jour_value".ToLower());
            dt.Columns.Add("ACC_ID".ToLower());
            dt.Columns.Add("CURR_ID".ToLower());
            dt.Columns.Add("currency_exchange_id".ToLower());
            dt.Columns.Add("CURR_PRICE".ToLower());
            dt.Columns.Add("REFERENCE_NO".ToLower());
            dt.Columns.Add("JOUR_DETAILS".ToLower());
            dt.Columns.Add("COST_CENTER".ToLower());          
            dt.Columns.Add("STAT".ToLower());
          
         
            //foreach (DataGridViewColumn col in dgJOURNAL_DETAILS.Columns)
            //{
            //    if (col.ToolTipText == ".")
            //        dt.Columns.Add(col.Name.ToLower());
            //}
            for (int i = 0; i < dgJOURNAL_DETAILS.Rows.Count; i++)
            {
                dt.Rows.Add(new Object[] { dgJOURNAL_DETAILS[clmDetailSwid.Index,i].Value.ToString(),
                dgJOURNAL_DETAILS[clmcredit.Index,i].Value.ToString(),
                dgJOURNAL_DETAILS[clmDept.Index,i].Value.ToString(),
                dgJOURNAL_DETAILS[clmJOUR_VALUE.Index,i].Value.ToString(),
                dgJOURNAL_DETAILS[clmACC_ID.Index,i].Value.ToString(),
                 dgJOURNAL_DETAILS[clmCURR_ID.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmCurrentCurrencyRateId.Index,i].Value.ToString(),
                   dgJOURNAL_DETAILS[clmNewCurrencyRate.Index,i].Value.ToString(),
                   dgJOURNAL_DETAILS[clmREFERENCE_NO.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmJOUR_DETAILS.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmCOST_CENTER.Index,i].Value.ToString(),
                   dgJOURNAL_DETAILS[clmSTAT.Index,i].Value.ToString()

                });
            }

            string icheckNaturalAcc = "0";
            if (txtAllowExceedNaturalAcc.Text.Trim() == "نعم")
                icheckNaturalAcc = "1";

            string strExceededRate = "0";
            if (txtExchangeRateExceeded.Text.Trim() == "نعم")
                strExceededRate = "1";

            System.IO.StringWriter writer = new System.IO.StringWriter();
            dt.WriteXml(writer);
            string strDetails = writer.ToString().Replace("DocumentElement", "DocumentElement".ToLower());
            
            ConnectionToDB cnn = new ConnectionToDB();
            ConnectionToDB.objCmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
            ConnectionToDB.objCmd.Parameters.Add("xml_journal_header", Oracle.ManagedDataAccess.Client.OracleDbType.Clob).Value = strHeader;
            ConnectionToDB.objCmd.Parameters.Add("xml_journal_details", Oracle.ManagedDataAccess.Client.OracleDbType.Clob).Value = strDetails;
            ConnectionToDB.objCmd.Parameters.Add("sqlStat", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2 ).Value = strStat ;
            ConnectionToDB.objCmd.Parameters.Add("strHash", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2 ).Value = strHash ;
            ConnectionToDB.objCmd.Parameters.Add("icheckNaturalAcc", Oracle.ManagedDataAccess.Client.OracleDbType.Char).Value = icheckNaturalAcc;
            ConnectionToDB.objCmd.Parameters.Add("ExceedRate", Oracle.ManagedDataAccess.Client.OracleDbType.Char).Value = strExceededRate;
            ConnectionToDB.objCmd.Parameters.Add("swid", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
            ConnectionToDB.objCmd.Parameters.Add("Result", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
            string strResult = cnn.ExecutePro("AccountsPack.journal_inser_update", "Result");
            txtSWID.Text = ConnectionToDB.objCmd.Parameters["swid"].Value.ToString();
            if (strResult.ToUpper() == "SUCCEED")
            {


                //re Schedual Templete

                if(strTempswid != "")
                {
                    if (dgvJourTemp[clmT_type.Index, dgvJourTemp.CurrentRow.Index].Value.ToString() == "فترة بالأيام")
                    {
                       
                        DateTime dtpCalc = new DateTime(DateTime.Now.Year, Convert.ToInt16(dgvJourTemp[clmMonth.Index, dgvJourTemp.CurrentRow.Index].Value), Convert.ToInt16(dgvJourTemp[clmDay.Index, dgvJourTemp.CurrentRow.Index].Value));
                        dtpCalc = dtpCalc.AddDays(Convert.ToInt16(dgvJourTemp[clmPeriod.Index, dgvJourTemp.CurrentRow.Index].Value));
                        int icheck = cnn.TranDataToDB("update journal_templates_hd h set h.day=" + dtpCalc.ToString("dd") + "  ,h.month = " + dtpCalc.ToString("MM") + " where h.swid=" + strTempswid);

                        if (icheck <= 0)
                        {
                            cnn.glb_RollbackTransaction();
                            glb_function.MsgBox("حدث خطأ اثناء الجدولة");
                            return;
                        }
                    }
                    else if (dgvJourTemp[clmT_type.Index, dgvJourTemp.CurrentRow.Index].Value.ToString() == "تاريخ شهري")
                    {
                       
                        int month = (dgvJourTemp[clmMonth.Index, dgvJourTemp.CurrentRow.Index].Value.ToString() == "12" ? 1 : Convert.ToInt16(dgvJourTemp[clmMonth.Index, dgvJourTemp.CurrentRow.Index].Value) + 1);
                        int iday = 0;
                        int iDayInMonth = DateTime.DaysInMonth(DateTime.Now.Year, month);
                        if (iDayInMonth >= Convert.ToInt16(dgvJourTemp[clmPeriod.Index, dgvJourTemp.CurrentRow.Index].Value.ToString()))
                            iday = Convert.ToInt16(dgvJourTemp[clmPeriod.Index, dgvJourTemp.CurrentRow.Index].Value.ToString());
                        else
                            iday = iDayInMonth;

                        int icheck = cnn.TranDataToDB("update journal_templates_hd h set h.day=" + iday + "  ,h.month = " + month + " where h.swid=" + strTempswid);

                        if (icheck <= 0)
                        {
                            cnn.glb_RollbackTransaction();
                            glb_function.MsgBox("حدث خطأ اثناء الجدولة");
                            return;
                        }
                    }
                }

                cnn.glb_commitTransaction();
                glb_function.MsgBox("تمت العملية بنجاح");

                GetData(txtSWID.Text);
            }

            else
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء تنفيذ العملية" + "\n" + strResult);

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SaveUpdateJournal();
        }

     

        

        private void myGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("update journal_header h set h.stat='ملغي' where h.swid="+txtSWID.Text );
            if(icheck <=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الغاء القيد");
                return;
            }

            icheck = cnn.TranDataToDB("update  hang_journal_hd h where stat='معالج' where jour_id=" + txtSWID.Text);
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية الغاء القيد");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الغاء القيد بنجاح");
            btnNew_Click(null, null);

        }

        private void txtJOUR_NUM_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTemplet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCurrency.Items.Count >0)
               lstCurrency.SelectedIndex = 0;
        }

        private void myLabel11_Click(object sender, EventArgs e)
        {

        }

        private void nmbDept_TextChanged(object sender, EventArgs e)
        {
            if (nmbDept.ReadOnly)
                return;

          //  nmbCURR_PRICE.Value = dExchangeRate;
            
            if (nmbDept.Value==0)
            {
                nmbCredit.ReadOnly = false;
                nmbDept.ReadOnly = false;
                nmbjour_valueDept.Value = 0;
                if (lstCurrency.SelectedValue.ToString() != glb_function.glb_MainCurrencyId.ToString())
                {
                    nmbjour_valueCredit.Enabled = true;

                    nmbjour_valueDept.Enabled = true;
                    nmbjour_valueCredit.Value = 0;
                    nmbjour_valueDept.Value = 0;
                }


              
            }
            else
            {
                if(nmbjour_valueDept.Value==0)
                nmbjour_valueDept.Value = nmbDept.Value / nmbCURR_PRICE.Value;
                else
                {
                    nmbCURR_PRICE.Value = nmbDept.Value / nmbjour_valueDept.Value;

                }
                nmbCredit.ReadOnly = true ;
                nmbCredit.Value = 0;
                if (lstCurrency.SelectedValue.ToString() != glb_function.glb_MainCurrencyId.ToString())
                {
                    nmbjour_valueCredit.Enabled = false;
                    nmbjour_valueCredit.Value = 0;
                    nmbjour_valueDept.Enabled = true;
                }

                nmbjour_valueDept_TextChanged(null, null);
            }
        }

        private void nmbCredit_TextChanged(object sender, EventArgs e)
        {
            if (nmbCredit.ReadOnly)
                return;


           // nmbCURR_PRICE.Value = dExchangeRate;

            if (nmbCredit.Value ==0)
            {
                nmbDept.ReadOnly = false ;
                nmbCredit.ReadOnly = false ;
                nmbjour_valueCredit.Value = 0;
                if (lstCurrency.SelectedValue.ToString() != glb_function.glb_MainCurrencyId.ToString())
                {
                    nmbjour_valueCredit.Enabled = true;

                    nmbjour_valueDept.Enabled = true;
                    nmbjour_valueCredit.Value = 0;
                    nmbjour_valueDept.Value = 0;
                }
            }
            else
            {

               
                if (nmbjour_valueCredit.Value == 0)
                    nmbjour_valueCredit.Value = nmbCredit.Value / nmbCURR_PRICE.Value;
                else
                {
                    nmbCURR_PRICE.Value = nmbCredit.Value / nmbjour_valueCredit.Value;

                }



                nmbDept.ReadOnly = true ;
                nmbDept.Value = 0;

                if (lstCurrency.SelectedValue.ToString() != glb_function.glb_MainCurrencyId.ToString())
                {
                    nmbjour_valueCredit.Enabled = true;
                    nmbjour_valueDept.Value = 0;
                    nmbjour_valueDept.Enabled = false;
                }

                nmbjour_valueCredit_TextChanged(null, null);
            }
        }

        private void nmbjour_valueDept_TextChanged(object sender, EventArgs e)
        {
            if(nmbjour_valueDept.Value == 0)
            {
                nmbCURR_PRICE.Value = dExchangeRate;
                nmbDept.Value = 0;

                nmbCredit.ReadOnly = false ;

                if (lstCurrency.SelectedValue.ToString() != glb_function.glb_MainCurrencyId.ToString())
                {
                    nmbjour_valueCredit.Enabled = true;
                }

                lstAccNo.Focus();
              
            }
            else
            {
                nmbCredit.ReadOnly = true  ;
                nmbjour_valueCredit.Enabled = false ;

                if (nmbDept.Value ==0)
                {
                    nmbCURR_PRICE.Value = dExchangeRate;
                    nmbDept.Value = nmbjour_valueDept.Value * dExchangeRate;
                    nmbDept_TextChanged(null, null);
                }
                else
                {
                    nmbCURR_PRICE.Value = nmbDept.Value / nmbjour_valueDept.Value;
                   
                }
                lstAccNo.Focus();
            }
        }

        private void nmbjour_valueCredit_TextChanged(object sender, EventArgs e)
        {
            if (nmbjour_valueCredit .Value ==0)
            {
                nmbCURR_PRICE.Value = dExchangeRate;
                nmbCredit.Value = 0;

                nmbDept.ReadOnly = false ;
                if (lstCurrency.SelectedValue.ToString() != glb_function.glb_MainCurrencyId.ToString())
                {
                    nmbjour_valueDept.Enabled = true;
                }
            }
            else
            {
                nmbDept.ReadOnly = true ;
                nmbjour_valueDept.Enabled = false;

                if (nmbCredit.Value == 0)
                {
                    nmbCURR_PRICE.Value = dExchangeRate;
                    nmbCredit.Value = nmbjour_valueCredit.Value * dExchangeRate;
                    nmbCredit_TextChanged(null, null);
                }
                else
                {
                    nmbCURR_PRICE.Value = nmbCredit.Value / nmbjour_valueCredit.Value;

                }
            }
        }

        //private void Ctrl_KeyPress(object sender, KeyPressEventArgs e)
            private void Ctrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }
       
        private void Ctrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
              
                   SendKeys.Send("{TAB}");
                //SendKeys.Send(Keys.Tab.ToString());
            }
        }
       
        private void lstBranchHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            


                if (lstBranchHeader.SelectedValue == null)
                return;

            if (lstBranchHeader.SelectedValue.ToString() != "System.Data.DataRowView" && lstBranchHeader.SelectedValue.ToString() != "")
            {
               

                PrepareForm();
            }
        }

        private void nmbCURR_PRICE_Leave(object sender, EventArgs e)
        {
            //nmbjour_valueDept.Value = nmbDept.Value / nmbCURR_PRICE.Value;
        }

        private void nmbCURR_PRICE_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void dtpJOUR_DATE_CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (dtpJOUR_DATE.Checked == false)
                dtpJOUR_DATE.Value = DateTime.Now;
        }

        private void lstTemplet_Click(object sender, EventArgs e)
        {
            
        }
        
        private void ckbExRateDate_CheckedChanged(object sender, EventArgs e)
        {

            dgJOURNAL_DETAILS.Rows.Clear();
            txtCreditTotal.Value = 0;
            txtDeptTotal.Value = 0;
            txtCreditDiff.Text  = "0";
            txtDeptDiff.Text = "0";
            new glb_function().clearItems(gbDetail);
            lstCurrency.SelectedIndex = 0;
        }

        private void ckbExRateDate_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void dtpJOUR_DATE_ValueChanged(object sender, EventArgs e)
        {
            dgJOURNAL_DETAILS.Rows.Clear();
            txtCreditTotal.Value = 0;
            txtDeptTotal.Value = 0;
            txtCreditDiff.Text = "0";
            txtDeptDiff.Text = "0";
            new glb_function().clearItems(gbDetail);
            lstCurrency.SelectedIndex = 0;
        }

        private void btnAddJourTemp_Click(object sender, EventArgs e)
        {

            
            frmJournalTemplet frm = new frmJournalTemplet();

            if (txtAllowGeneralVoucher.Text == "نعم")
                frm.bAcceptGeneralTemp = true;
            else
                frm.bAcceptGeneralTemp = false;

            #region FillTempletBranches
            ConnectionToDB cnn = new ConnectionToDB();

            string strMult = lstTempBranch.Text.Trim();
            string iindexx = "";
            string strInStat = "";
            while (strMult != "")
            {


                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                // lstBranchHeader.Items.Add(iindexx);
                strInStat = (strInStat == "" ? "'" + iindexx + "'" : strInStat + ",'" + iindexx + "'");


            }

            DataTable dt = cnn.GetDataTable("select swid,b.branch_cost_center_name " +
                " from branches_costcenter b " +
                " where b.branch_cost_center_name in (" + strInStat + ")");

            frm.lstBranches.DataSource = dt;
            frm.lstBranches.ValueMember = "swid";
            frm.lstBranches.DisplayMember = "branch_cost_center_name";
            #endregion

            frm.lstBranches.SelectedValue = lstBranchHeader.SelectedValue;

           frm.ShowDialog();

            FillJournaTemp();
        }

        private void dgvJourTemp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

          if(clmTempBtnSchedual.Index==e.ColumnIndex)
            {
                if (dgvJourTemp[clmT_type.Index, e.RowIndex].Value.ToString() == "فترة بالأيام")
                {
                    ConnectionToDB cnn = new ConnectionToDB();
                    DateTime dtpCalc = new DateTime(DateTime.Now.Year, Convert.ToInt16(dgvJourTemp[clmMonth.Index, e.RowIndex].Value), Convert.ToInt16(dgvJourTemp[clmDay.Index, e.RowIndex].Value));
                    dtpCalc = dtpCalc.AddDays(Convert.ToInt16(dgvJourTemp[clmPeriod.Index, e.RowIndex].Value));
                    int icheck = cnn.TranDataToDB("update journal_templates_hd h set h.day=" + dtpCalc.ToString("dd") + "  ,h.month = " + dtpCalc.ToString("MM") + " where h.swid=" + dgvJourTemp[clmTempSwid.Index, e.RowIndex].Value.ToString());

                    if (icheck <= 0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء الجدولة");
                        return;
                    }
                    cnn.glb_commitTransaction();
                   
                }
                else if (dgvJourTemp[clmT_type.Index, e.RowIndex].Value.ToString() == "تاريخ شهري")
                {
                    ConnectionToDB cnn = new ConnectionToDB();
                    int month = (dgvJourTemp[clmMonth.Index, e.RowIndex].Value.ToString() == "12" ? 1 : Convert.ToInt16(dgvJourTemp[clmMonth.Index, e.RowIndex].Value) + 1);
                    int iday = 0;
                    int iDayInMonth = DateTime.DaysInMonth(DateTime.Now.Year, month);
                    if (iDayInMonth >= Convert.ToInt16(dgvJourTemp[clmPeriod.Index, e.RowIndex].Value.ToString()))
                        iday = Convert.ToInt16(dgvJourTemp[clmPeriod.Index, e.RowIndex].Value.ToString());
                    else
                        iday = iDayInMonth;

                    int icheck = cnn.TranDataToDB("update journal_templates_hd h set h.day=" + iday + "  ,h.month = " + month + " where h.swid=" + dgvJourTemp[clmTempSwid.Index, e.RowIndex].Value.ToString());

                    if (icheck <= 0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء الجدولة");
                        return;
                    }
                    cnn.glb_commitTransaction();
                }
                else
                    return;


                glb_function.MsgBox("تمت العملية بنجاح");
                GetTempData();

            }
          else
            {
                strTempswid = dgvJourTemp[clmTempSwid.Index, e.RowIndex].Value.ToString();

                GetTempData();
            }

            


           //else if (dtJourTem.Rows[i]["t_type"].ToString() == "فترة بالأيام")
           //     dgvJourTemp[clmTempScheduleDate.Index, i].Value = dtJourTem.Rows[i]["Period"].ToString();
           // else if (dtJourTem.Rows[i]["t_type"].ToString() == "تاريخ شهري")
           //     dgvJourTemp[clmTempScheduleDate.Index, i].Value = dtJourTem.Rows[i]["Monthdate"].ToString();
        }
        private void GetTempData()
        {
            dgJOURNAL_DETAILS.Rows.Clear();
            txtCreditTotal.Value = 0;
            txtDeptTotal.Value = 0;
            txtCreditDiff.Text = "0";
            txtDeptDiff.Text = "0";
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTemp = cnn.GetDataTable("select h.swid swidHeader, h.templates_name, h.t_type, h.general_special, "+
                   "  h.month, h.day, h.period, h.curr_id CurrHeadId, h.jour_details Header_Note, "+
                    " d.swid swidDetail," +
                    " d.templates_curr_value, " +
                    "d.curr_id currDetailId, d.accid, d.cost_center_id,(select c.branch_cost_center_name from branches_costcenter c where c.swid=d.cost_center_id) CostCentName, d.jour_details detail_note " +
                    " from journal_templates_hd h "+
                    " join journal_templates_de d on (h.swid = d.header_id) "+
                    " where h.swid = "+ strTempswid );



            txtJOUR_DETAILS_Header.Text = dtTemp.Rows[0]["Header_Note"].ToString();

            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                dgJOURNAL_DETAILS.Rows.Add();
                dgJOURNAL_DETAILS[clmDetailSwid.Index, i].Value = "";
                decimal dValue = 0;
                if (Convert.ToDecimal(dtTemp.Rows[i]["templates_curr_value"].ToString()) > 0)
                    dValue = Convert.ToDecimal(dtTemp.Rows[i]["templates_curr_value"].ToString());
                else
                    dValue =  Convert.ToDecimal(dtTemp.Rows[i]["templates_curr_value"].ToString()) * -1;


             

                dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, i].Value = dValue.ToString();

                dgJOURNAL_DETAILS[clmCURR_ID.Index, i].Value = dtTemp.Rows[i]["currDetailId"].ToString();
                lstCurrency.SelectedValue= dtTemp.Rows[0]["currDetailId"].ToString();
                dgJOURNAL_DETAILS[clmCurrName.Index, i].Value = lstCurrency.Text;

                dgJOURNAL_DETAILS[clmCurrentCurrencyRateId.Index, i].Value = iCurrSwid;
                dgJOURNAL_DETAILS[clmMaxRate.Index, i].Value = dMaxRate;
                dgJOURNAL_DETAILS[clmMinRate.Index, i].Value = dMinRate;
                dgJOURNAL_DETAILS[clmOverrideValue.Index, i].Value = dOverrideValue;
               


                decimal dMainValue = Math.Round( dExchangeRate * dValue ,glb_function.glbMainDecimalPoint);
                dExchangeRate = dMainValue / dValue;
                dgJOURNAL_DETAILS[clmNewCurrencyRate.Index, i].Value = dExchangeRate;
                if (Convert.ToDecimal(dtTemp.Rows[i]["templates_curr_value"].ToString()) > 0)
                {
                    dgJOURNAL_DETAILS[clmDept.Index, i].Value = dMainValue.ToString();
                    dgJOURNAL_DETAILS[clmcredit.Index, i].Value = "0";
                }
                   
                else
                {
                    dgJOURNAL_DETAILS[clmcredit.Index, i].Value = dMainValue.ToString();
                    dgJOURNAL_DETAILS[clmDept.Index, i].Value = "0";
                }
                 


                dgJOURNAL_DETAILS[clmACC_ID.Index, i].Value = dtTemp.Rows[i]["accid"].ToString();

                lstAccNo.SelectedValue = dtTemp.Rows[i]["accid"].ToString();
                lstAccName.SelectedValue = dtTemp.Rows[i]["accid"].ToString();

                dgJOURNAL_DETAILS[clmAccNo.Index, i].Value = lstAccNo.Text;
                dgJOURNAL_DETAILS[clmAccName.Index, i].Value = lstAccName.Text;


                dgJOURNAL_DETAILS[clmCOST_CENTER.Index, i].Value = dtTemp.Rows[i]["cost_center_id"].ToString();
                dgJOURNAL_DETAILS[clmCostCenterName.Index, i].Value = dtTemp.Rows[i]["CostCentName"].ToString();
                dgJOURNAL_DETAILS[clmSTAT.Index, i].Value = "فعال";
                dgJOURNAL_DETAILS[clmREFERENCE_NO.Index, i].Value = "";
                dgJOURNAL_DETAILS[clmJOUR_DETAILS.Index, i].Value = dtTemp.Rows[i]["detail_note"].ToString();

            }

            ClearDetailData();
            GetSum();

        }

        private void dgvHangs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            btnHang.Enabled = true;

            GetHangData(dgvHangs[clmHangSwid.Index,e.RowIndex].Value.ToString());
        }

        private void GetHangData(string strJourSwid)
        {
            dgJOURNAL_DETAILS.Rows.Clear();
            strTempswid = "";
            txtCreditTotal.Value = 0;
            txtDeptTotal.Value = 0;
            txtCreditDiff.Text = "0";
            txtDeptDiff.Text = "0";
            ConnectionToDB cnn = new ConnectionToDB();
           strStat= "select h.swid swidJourH,h.branch_id ,h.issued_id,h.stir_no,to_char(h.jour_date,'dd/mm/yyyy') jour_date, " +
               " h.exchange_in_date, h.jour_details, " +
                     "       hd.swid hangDswid, hd.jour_id,nvl( hd.curr_id,d.curr_id) hangCurrId, nvl(hd.acc_id,d.acc_id) hangAccId, nvl(hd.jour_main_value,d.jour_main_value) hangMainValue,nvl( hd.jour_value,d.jour_value) HangJourValue,nvl( hd.curr_price,d.curr_price) HangCurrPrice, " +
                      "     nvl( hd.hang_deatels,d.jour_details) hang_deatels , nvl( hd.cost_center_id,d.cost_center_id) hangCostCenter,(select c.branch_cost_center_name from branches_costcenter c where c.swid= nvl( hd.cost_center_id,d.cost_center_id)) CostCentName, " +
                       "     d.swid jourDswid,d.stat dstat, d.curr_id CurridD, d.currency_exchange_id, d.acc_id accidD, d.curr_price currPriceD, " +
                       "     d.jour_main_value mainValueD, d.jour_value jour_valueD, d.reference_no refnoD, d.jour_details noteD, d.cost_center_id costcenteridD " +
                       "     from journal_header h " +
                       "     join journal_details d on (h.swid = d.jour_id) " +
                       "     join hang_journal_hd hg on (h.swid = hg.jour_id) " +
                        "  left " +
                        "    join hang_journal_de hd on (hg.swid = hd.header_id) and(d.swid = hd.jour_id) " +
                         "   where d.stat!='ملغي' and hg.stat='فعال' and h.swid = " + strJourSwid;
            DataTable dtHang = cnn.GetDataTable(strStat);


           
            txtSWID.Text = dtHang.Rows[0]["swidJourH"].ToString();
            strHash = glb_function.GetSelectHash(strStat);
            txtVOCH_NO.Text = dtHang.Rows[0]["stir_no"].ToString();
            txtIssueId.Text = dtHang.Rows[0]["issued_id"].ToString();
            dtpJOUR_DATE.Value = DateTime.ParseExact(dtHang.Rows[0]["JOUR_DATE"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            if (dtHang.Rows[0]["issued_id"].ToString() == "1")
                ckbExRateDate.Checked = true;
            else
                ckbExRateDate.Checked = false ;

            txtJOUR_DETAILS_Header.Text = dtHang.Rows[0]["jour_details"].ToString();

            for (int i = 0; i < dtHang.Rows.Count; i++)
            {
                dgJOURNAL_DETAILS.Rows.Add();

                if (dtHang.Rows[i]["hangDswid"].ToString()!="")
                {
                    for (int y = 0; y < dgJOURNAL_DETAILS.Rows[i].Cells.Count - 1; y++)
                    {
                        dgJOURNAL_DETAILS.Rows[i].Cells[y].Style.BackColor = System.Drawing.Color.LawnGreen;
                    }
                }
                dgJOURNAL_DETAILS[clmDetailSwid.Index, i].Value = dtHang.Rows[i]["jourDswid"].ToString();
                decimal dJourValue = 0;
                if(Convert.ToDecimal (dtHang.Rows[i]["hangMainValue"].ToString())>0)
                {
                    dgJOURNAL_DETAILS[clmDept.Index, i].Value = dtHang.Rows[i]["hangMainValue"].ToString();
                    dgJOURNAL_DETAILS[clmcredit.Index, i].Value = "0";
                    dJourValue= Convert.ToDecimal( dtHang.Rows[i]["HangJourValue"].ToString());


                }
                
                else
                {
                    dgJOURNAL_DETAILS[clmcredit.Index, i].Value = Convert.ToDecimal(dtHang.Rows[i]["hangMainValue"].ToString())* -1;
                    dgJOURNAL_DETAILS[clmDept.Index, i].Value = "0";
                    dJourValue = Convert.ToDecimal(dtHang.Rows[i]["HangJourValue"].ToString()) * -1 ;
                }

                dgJOURNAL_DETAILS[clmJOUR_VALUE.Index, i].Value = dJourValue.ToString();

                dgJOURNAL_DETAILS[clmCURR_ID.Index, i].Value = dtHang.Rows[i]["hangCurrId"].ToString();

                lstCurrency.SelectedValue = dtHang.Rows[i]["hangCurrId"].ToString();
                dgJOURNAL_DETAILS[clmCurrName.Index, i].Value = lstCurrency.Text;

                dgJOURNAL_DETAILS[clmACC_ID.Index, i].Value = dtHang.Rows[i]["hangAccId"].ToString();
                lstAccNo.SelectedValue= dtHang.Rows[i]["hangAccId"].ToString();

                dgJOURNAL_DETAILS[clmAccNo.Index, i].Value = lstAccNo.Text;
                dgJOURNAL_DETAILS[clmAccName.Index, i].Value = lstAccName.Text;
                
                dgJOURNAL_DETAILS[clmNewCurrencyRate.Index, i].Value = dtHang.Rows[i]["HangCurrPrice"].ToString();
                
                dgJOURNAL_DETAILS[clmCOST_CENTER.Index, i].Value = dtHang.Rows[i]["hangCostCenter"].ToString();
                dgJOURNAL_DETAILS[clmCostCenterName.Index, i].Value = dtHang.Rows[i]["CostCentName"].ToString();
                dgJOURNAL_DETAILS[clmJOUR_DETAILS.Index, i].Value = dtHang.Rows[i]["hang_deatels"].ToString();
                dgJOURNAL_DETAILS[clmREFERENCE_NO.Index, i].Value = dtHang.Rows[i]["refnoD"].ToString();

                dgJOURNAL_DETAILS[clmSTAT.Index, i].Value = dtHang.Rows[i]["dstat"].ToString();
                dgJOURNAL_DETAILS[clmCurrentCurrencyRateId.Index, i].Value = iCurrSwid;
                dgJOURNAL_DETAILS[clmMaxRate.Index, i].Value = dMaxRate;
                dgJOURNAL_DETAILS[clmMinRate.Index, i].Value = dMinRate;
                dgJOURNAL_DETAILS[clmOverrideValue.Index, i].Value = dOverrideValue;


            }

            GetSum();
            ClearDetailData();
            btnSave.Enabled = false;
            ckbExRateDate.Enabled = false;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

            if (HasPrivilege("btnDelete"))
                btnDelete.Enabled = true;
            if (HasPrivilege("btnPrint"))
                btnPrint.Enabled = true;

        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            frmHangDetail frm = new frmHangDetail();
            if(dgvHangs.CurrentRow.Index<0)
            {
                glb_function.MsgBox("الرجاء تحديد قيد معلق");
                return;
            }
            frm.strJourSwid = dgvHangs[clmHangSwid.Index,dgvHangs.CurrentRow.Index].Value.ToString();
            frm.ShowDialog();
        }
    }
}
