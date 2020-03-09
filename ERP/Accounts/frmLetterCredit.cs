using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ERP.Accounts
{
    public partial class frmLetterCredit : MyForm
    {
        //strLc_Nature this value come from where window open
        public string strLC_NATURE = "";
        private decimal dMaxRate;
        private decimal dMinRate;
        private decimal dExchangeRate;
        private short iCurrDecimal;

        public frmLetterCredit()
        {
            InitializeComponent();
        }

        private void frmLetterCredit_Load(object sender, EventArgs e)
        {
            FillCurrency();
            PrepareForm();
        }
        private void PrepareForm()
        {
            new glb_function().clearItems(this);
            lstLC_Currency.SelectedIndex = -1;
            lstLC_Currency.SelectedIndex = 0;

            lstLC_ROLLOVER.Text = "بلا";
            if (strLC_NATURE == "مشتريات")
                lstLC_TYPE.Text = "شراء";

            lstPAYMENT_METHOD.Text = "اطلاع";

            lstBENEFICIARY_TYPE.Text = "مورد";
            lstLC_ROLLOVER.Text = "بلا";
            nmbROLLOVER_COUNT.Enabled = false;


        }
        public override void lstTemplet_MorePrivilleges(object sender, EventArgs e)
        {


            FillBranch();
            FillLC_Type();


            FillPaymentMethod();
            FillRolloverType();
        }

        private void FillCurrency()
        {
            ConnectionToDB conn = new ConnectionToDB();
            DataTable MyDataTable;
            MyDataTable = conn.GetDataTable("select swid,curr_name from CURRENCY t  order by swid");
            if (MyDataTable != null)
            {


                lstLC_Currency.DataSource = MyDataTable;


                lstLC_Currency.DisplayMember = "curr_name";
                lstLC_Currency.ValueMember = "SWID";


            }
        }
        private void FillRolloverType()
        {
            lstROLLOVER_TYPE.Items.Clear();

            ConnectionToDB cnn = new ConnectionToDB();

            string strMult = txtRolloverType.Text.Trim();
            string iindexx = "";

            while (strMult != "")
            {


                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                lstROLLOVER_TYPE.Items.Add(iindexx);


            }


        }
        private void FillPaymentMethod()
        {
            lstPAYMENT_METHOD.Items.Clear();

            ConnectionToDB cnn = new ConnectionToDB();

            string strMult = txtPaymentMethod.Text.Trim();
            string iindexx = "";

            while (strMult != "")
            {


                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                lstPAYMENT_METHOD.Items.Add(iindexx);


            }


        }
        private void FillLC_Type()
        {
            lstLC_TYPE.Items.Clear();
          
            ConnectionToDB cnn = new ConnectionToDB();

            string strMult = txtLC_Type.Text.Trim();
            string iindexx = "";
          
            while (strMult != "")
            {


                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                lstLC_TYPE.Items.Add(iindexx);
                

            }


        }
        private void FillBranch()
        {

            lstBranch.DataSource = null;
            ConnectionToDB cnn = new ConnectionToDB();

         
            string strInStat = glb_function.GetListFromMultList(lstTempBranch.Text.Trim());
           

            DataTable dt = cnn.GetDataTable("select swid,b.branch_cost_center_name " +
                " from branches_costcenter b " +
                " where b.branch_cost_center_name in (" + strInStat + ") order by swid");

            lstBranch.DataSource = dt;
            lstBranch.ValueMember = "swid";
            lstBranch.DisplayMember = "branch_cost_center_name";


        }
        private void FillAcc()
        {

          if(lstLC_Currency.SelectedIndex ==-1  )
            {
                glb_function.MsgBox("الرجاء اختيار العملة اولا");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtAccData;

        
            dtAccData = cnn.GetDataTable("select a.swid,a.acc_no,a.acc_name "+
                          "  from accounts a "+
                          "  join acc_curr c on (c.acc_id = a.swid) "+
                           " where a.acc_class = N'فرعي' and a.ACC_TYPE like N'بنوك' and a.stat = N'فعال' " +
                           "  and c.curr_id =  "+ lstLC_Currency.SelectedValue.ToString());
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLC_Currency.SelectedValue == null)
                return;

            if (lstLC_Currency.SelectedValue.ToString() != "System.Data.DataRowView" && lstLC_Currency.SelectedValue.ToString() != "")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
                                " where e.curr_id = c.swid and c.swid = " + lstLC_Currency.SelectedValue.ToString() + " " +
                      " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

                dMaxRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MAX"].ToString());
                dMinRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MIN"].ToString());
                dExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
                iCurrDecimal = Convert.ToInt16(dtcurr.Rows[0]["CURR_DECIMAL"].ToString());
              
                nmbROLLOVER_VALUE.DecimalPlaces = iCurrDecimal;

                lstBANK_id.DataSource = null;
                lstBeneficiary.DataSource = null;

                //ليتم تحميل الحسابات 
                DataTable dtBanks = new DataTable();

                if (lstPAYMENT_METHOD.Text == "اطلاع")
                {
                    FillBanksWithAcc();

                    FillAllVendors();


                }
                else if (lstPAYMENT_METHOD.Text == "اجل")
                {
                    FillAllBanks();
                    FillVenderWithCurr();
                }
                else if (lstPAYMENT_METHOD.Text == "قبول")
                {
                    FillAllBanks();
                    FillAllVendors();
                }

                //FillAcc();






            }

        }
        private void FillVenderWithCurr()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtVendor = cnn.GetDataTable("select distinct p.swid,p.p_name "+
                       " from people p " +
                       " where p.acc_id in (select a.swid " +
                       "                     from accounts a " +
                        "                    join acc_curr ac on (ac.acc_id = a.swid) " +
                        "                    where " +
                        "                     ac.curr_id =  "+lstLC_Currency.SelectedValue.ToString()+")");

            lstBeneficiary.DataSource = dtVendor;
            lstBeneficiary.ValueMember = "swid";
            lstBeneficiary.DisplayMember = "p_name";
            lstBeneficiary.SelectedIndex = -1;
        }
        private void FillAllVendors()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtVendor = cnn.GetDataTable("select swid,p_name from people p  where p.p_type='مورد' ");
            lstBeneficiary.DataSource = dtVendor;
            lstBeneficiary.ValueMember = "swid";
            lstBeneficiary.DisplayMember = "p_name";
            lstBeneficiary.SelectedIndex = -1;
        }
        bool strDataFromDataSource = false;
        private decimal dMaxRateVocher;
        private decimal dMinRateVocher;
        private decimal dExchangeRateVocher;
        private short iCurrDecimalVocher;

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null || strDataFromDataSource == true)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;



            }
        }

      

      
       
        private string UsedValue()
        {

            double dsum = 0;
            for (int i = 0; i < dgvLC_Operations.Rows.Count; i++)
            {
                dsum = dsum + Convert.ToDouble(dgvLC_Operations[clmVocherValue.Index, i].Value);
            }
            return dsum.ToString();
        }
        private bool CheckDetailsEntries()
        {
            int iError = 0;


            for (int i = 0; i < dgvLC_Rollover.Rows.Count; i++)
            {
                if(dgvLC_Rollover[clmRolloverswid.Index ,i].Value .ToString()=="")
                {
                    glb_function.MsgBox("يوجد مبالغ لم تحفظ بعد في جدول التدوير");
                    return false;
                }
            }

            if (txtPurchaseOrderSwid.Text == "" || txtPURCHASES_ORDER_ID.Text == "")
            {

                errCheckDetails.SetError(txtPURCHASES_ORDER_ID, "الرجاء اختيار امر الشراء ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(txtPURCHASES_ORDER_ID, "");
            }
            //nmbLC_Value
            if (nmbROLLOVER_VALUE.Value <= 0)
            {

                errCheckDetails.SetError(nmbROLLOVER_VALUE, "الرجاء ادخال مبلغ الاعتماد ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(nmbROLLOVER_VALUE, "");
            }
            //nmbPAYment_PERCENTAGE
            if (nmbPAYMENT_PERCENTAGE.Value <= 0)
            {

                errCheckDetails.SetError(nmbPAYMENT_PERCENTAGE, "الرجاء ادخال نسبة الدفع ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(nmbPAYMENT_PERCENTAGE, "");
            }
            //nmbINSURANCE_PERCENTAGE
            if (nmbINSURANCE_PERCENTAGE.Value <= 0)
            {

                errCheckDetails.SetError(nmbINSURANCE_PERCENTAGE, "الرجاء ادخال نسبة الائتمان ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(nmbINSURANCE_PERCENTAGE, "");
            }


            if (lstAccNo.SelectedIndex == -1)
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

            //2**********************************************
            //فحص هل اسم الحساب لديه نفس رقم تعريف رقم الحساب
            //فقط للتاكيد
            if (lstAccName.SelectedIndex != -1 && lstAccNo.SelectedIndex != -1)
                if (lstAccNo.SelectedValue.ToString().Trim() != lstAccName.SelectedValue.ToString().Trim())
                {

                    glb_function.MsgBox("الرجاء التاكد ان رقم الحساب يطابقة اسم الحساب");
                    return false;
                }

            if (iError == 1)
                return false;


            //*********************
            if(dgvLC_Rollover.Rows.Count >=1)
            {
                glb_function.MsgBox("عملية الاضافة موقفة مبدئيا"+"\n"+"الرجاء مراجعة مدير النظام");
                return false;
            }
            //*********************


            return true;
        }

       

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            if (txtSwid.Text.Trim() == "")
                SaveLc();
            else 
                if(txtStat.Text.Trim()=="فعال")
                  UpdateLc();


            GetData(txtSwid.Text.Trim());
        }

        private void SaveLc()
        {
            ConnectionToDB cnn = new ConnectionToDB();

            //glb_function.arrInsertLogs = new System.Collections.ArrayList();


            DataTable dtLC = cnn.GetDataTable("select nvl(max(swid),0)+1 from lc");

            txtSwid.Text = dtLC.Rows[0][0].ToString();


            int icheck = cnn.TranDataToDB("insert into lc values(" + txtSwid.Text.Trim() +
                ",sysdate" +
                "," + glb_function.glb_strUserId +
                ",'فعال'" +
                ",'" + lstLC_TYPE.Text.Trim() + "'" +
                "," + lstBranch.SelectedValue.ToString() +
                ",'" + txtLC_NO.Text.Trim() + "'" +
                ",'" + lstPAYMENT_METHOD.Text.Trim() + "'" +
                "," + lstLC_Currency.SelectedValue.ToString() +
                "," + lstBANK_id.SelectedValue.ToString() +
                ",'" + lstBENEFICIARY_TYPE.Text.Trim() + "'" +
                "," + lstBeneficiary.SelectedValue.ToString() +
                ",'" + lstLC_ROLLOVER.Text.Trim() + "'" +
                "," + nmbROLLOVER_COUNT.Value.ToString() +
                ",to_date('" + dtpLC_END_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')" +
                ")");

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ الاعتماد");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية حفظ الاعتماد بنجاح");
        }

        private void UpdateLc()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLc;
            //glb_function.arrInsertLogs = new System.Collections.ArrayList();

            string strUpdate = "";
            int icheck = 0;
            if (dgvLC_Rollover.Rows.Count <=0)
            {
                if (txtLC_END_DATE.Text.Trim() == "نعم")
                    strUpdate = ",LC_END_DATE=to_date('" + dtpLC_END_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')";

                 icheck = cnn.TranDataToDB(" update lc set " +
               ",LC_NO='" + txtLC_NO.Text.Trim() + "'" +
               ",PAYMENT_METHOD='" + lstPAYMENT_METHOD.Text.Trim() + "'" +
               ",CURRENCY_ID=" + lstLC_Currency.SelectedValue.ToString() +
               ",BANK_ID=" + lstBANK_id.SelectedValue.ToString() +
              
               ",BENEFICIARY_ID=" + lstBeneficiary.SelectedValue.ToString() +
               ",LC_ROLLOVER='" + lstLC_ROLLOVER.Text.Trim() + "'" +
               ",ROLLOVER_COUNT" + nmbROLLOVER_COUNT.Value.ToString() +
               strUpdate +
               " where swid=" + txtSwid.Text.Trim());
            }
            else
            {

                //1.	يعدل تاريخ نهاية الاعتماد إذا كان يملك الصلاحية ويجب ان يكون أكبر من تاريخ نهاية اخر دوره سواء كانت جديده او تعديل 
                if (txtLC_END_DATE.Text.Trim() == "نعم")
                {
                    if (dtpLC_END_DATE.Value > DateTime.ParseExact(dgvLC_Rollover[clmEND_DATE.Index, dgvLC_Rollover.Rows.Count - 1].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                        strUpdate = ",LC_END_DATE=to_date('" + dtpLC_END_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')";
                    else
                    {
                        glb_function.MsgBox("يجب ان يكون تاريخ نهاية الدورة أكبر من تاريخ اخر دورة مدخلة");
                        dtpLC_END_DATE.Focus();
                        return;
                    }




                }

                //3.	لا يمكن تعديل البنك او العملة إذا أضيفت دورة وتم تسجيل أي عملية عليها (قيد تامين – فاتورة)

                dtLc = cnn.GetDataTable("select swid from lc_operations o where o.rollover_id in ( select swid  from lc_rollover r where r.header_id="+txtSwid.Text +")");
                if(dtLc ==null || dtLc.Rows.Count <=0)
                {
                    strUpdate += ",CURRENCY_ID=" + lstLC_Currency.SelectedValue.ToString();
                    strUpdate += ",BANK_ID=" + lstBANK_id.SelectedValue.ToString();
                }

                //4.	لا يمكن تعديل المستفيد إذا أضيفت دورة وتم إضافة فاتورة عليها

                dtLc = cnn.GetDataTable("select swid from lc_operations o where o.rollover_id in ( select swid  from lc_rollover r where r.header_id=" + txtSwid.Text + ") and o.operation_type='فاتورة'");
                if (dtLc == null || dtLc.Rows.Count <= 0)
                {
                    strUpdate += ",BENEFICIARY_ID=" + lstBeneficiary.SelectedValue.ToString();
                    
                }
                //6.	يعدل عدد الدورات إذا كان يملك الصلاحية ونوع التدوير فترة ويجب ان يكون عدد الدورات المعدلة أكبر من او يساوي الدورات الموجودة فعلا لا يحتسب التمديد 
                int iCountRollover = 0;
                if (txtROLLOVER_COUNT.Text.Trim() == "نعم" || lstROLLOVER_TYPE.Text == "تدوير بالفترة")
                {
                    
                    for (int i = 0; i < dgvLC_Rollover.Rows.Count; i++)
                    {
                        if (dgvLC_Rollover[clmROLLOVER_TYPE.Index, i].Value.ToString() != "تمديد")
                            iCountRollover += 1;
                    }

                    if(nmbROLLOVER_COUNT.Value >=iCountRollover )
                    {
                        strUpdate += ",ROLLOVER_COUNT" + nmbROLLOVER_COUNT.Value.ToString();
                    }
                    else
                    {
                        glb_function.MsgBox("يجب ان يكون عدد الدورات المعدلة أكبر من او يساوي الدورات الموجودة فعلا");
                        return;
                    }
                }

                if(lstROLLOVER_TYPE.W_OldValue.Trim()=="بلا")
                {
                    strUpdate += ",LC_ROLLOVER='" + lstLC_ROLLOVER.Text.Trim() + "'";

                }
                else  if (lstROLLOVER_TYPE.W_OldValue.Trim() == "تدوير بالفترة"   )
                {
                   

                }

                    icheck = cnn.TranDataToDB(" update lc set " +
              ",LC_NO='" + txtLC_NO.Text.Trim() + "'" +
             
             
             
             
            
              strUpdate +
              " where swid=" + txtSwid.Text.Trim());




            }



           

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية تعديل الاعتماد");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية تعديل الاعتماد بنجاح");
        }
        private void GetData(string strSwid)
        {
            //btnNew_Click(null, null);
            //ConnectionToDB cnn = new ConnectionToDB();
            //DataTable dtLC = cnn.GetDataTable("select l.swid, l.account_id, l.lc_nature, l.lc_no, l.bank_id, l.close_date, l.people_id,"+
            //                                  "  l.currency_id, l.lc_type, l.lc_class, l.partner_lc_id, "+
            //                                   "  l.lc_rollover, l.auto_rollover, l.period_rollover, "+
            //                                    " l.transferable, l.divisible,l.BANK_CURRENCY,r.swid swid_d, r.rollover_no, " +
            //                                    " r.purchases_order_id,"+
            //                                    " (select p.purchase_order_num from purchases_order_header p where p.swid = r.purchases_order_id) Purchase_no," +
            //                                    " r.rollover_type, r.rollover_value, to_char(r.open_date,'dd/mm/yyyy') open_date, "+
            //                                    "  to_char(r.end_date,'dd/mm/yyyy') end_date, r.payment_account_id , "+
            //                                   " (select a.acc_no from accounts a where a.swid = r.payment_account_id) acc_no, " +
            //                                   " (select a.acc_name from accounts a where a.swid = r.payment_account_id) acc_Name, r.insurance_percentage, " +
            //                                     " r.payment_percentage, r.notes "+
            //                                     " from lc l"+
            //                                     " join lc_rollover r on (l.swid = r.header_id)"+
            //                                     " and l.swid="+strSwid);

            //txtSwid.Text = strSwid;

            //txtLC_NO.Text = dtLC.Rows[0]["lc_no"].ToString();
            //lstLC_TYPE.Text = dtLC.Rows[0]["lc_type"].ToString();
            //txtLcAccId.Text = dtLC.Rows[0]["account_id"].ToString();
            //lstBANK_id.SelectedValue  = dtLC.Rows[0]["bank_id"].ToString();
            //lstLC_Currency.SelectedValue  = dtLC.Rows[0]["currency_id"].ToString();
            //txtBENEFICIARY_ID.Text = dtLC.Rows[0]["people_id"].ToString();
            //GetVendorData(txtBENEFICIARY_ID.Text);

            //lstLC_ROLLOVER.Text = dtLC.Rows[0]["lc_rollover"].ToString();
            //lstLC_CLASS.Text = dtLC.Rows[0]["lc_class"].ToString();
            //nmbROLLOVER_COUNT.Value =Convert.ToUInt32( dtLC.Rows[0]["period_rollover"].ToString());
            //ckbCopyOrder.Checked = (dtLC.Rows[0]["transferable"].ToString() == "1" ? true : false);
            //ckbDivisible.Checked = (dtLC.Rows[0]["divisible"].ToString() == "1" ? true : false);

            //lstVocherCurrency.SelectedValue= Convert.ToUInt32(dtLC.Rows[0]["BANK_CURRENCY"].ToString());

            //for (int i = 0; i < dtLC.Rows.Count; i++)
            //{
                
            //    dgvLC_Rollover.Rows.Add();
            //    dgvLC_Rollover[0, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["swid_d"].ToString();
            //    dgvLC_Rollover[1, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["rollover_no"].ToString();
            //    dgvLC_Rollover[clmROLLOVER_TYPE.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["rollover_type"].ToString();
            //    dgvLC_Rollover[clmPurchaseOrderSwid.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["purchases_order_id"].ToString();
            //    dgvLC_Rollover[clmRPurchaseOrderNo.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["Purchase_no"].ToString();
            //    dgvLC_Rollover[clmLC_Value.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["rollover_value"].ToString();
            //    dgvLC_Rollover[clmOPEN_DATE.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["open_date"].ToString();
            //    dgvLC_Rollover[clmEND_DATE.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["end_date"].ToString();

            //    dgvLC_Rollover[clmRAccId.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["payment_account_id"].ToString();
            //    dgvLC_Rollover[clmRAccNo.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["acc_no"].ToString();
            //    dgvLC_Rollover[clmRAccName.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["acc_Name"].ToString();
            //    dgvLC_Rollover[clmPAYMENT_PERCENTAGE.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["payment_percentage"].ToString();
            //    dgvLC_Rollover[clmINSURANCE_PERCENTAGE.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["insurance_percentage"].ToString();
            //    dgvLC_Rollover[clmRolloverNotes.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtLC.Rows[0]["notes"].ToString();


            //}

            //lstLC_Currency.Enabled =false ;
            //lstVocherCurrency.Enabled = false;
            //btnSave.Visible = false;
            //btnNew.Location = btnSave.Location;
            //btnNew.Visible = true;
            //if (HasPrivilege("btnUpdate"))
            //    btnUpdate.Enabled = true;


        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (lstLC_TYPE.SelectedIndex == -1)
            {

                errCheckDetails.SetError(lstLC_TYPE, "الرجاء اختيار نوع الاعتماد");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstLC_TYPE, "");
            }

            if(txtLC_NO.Text.Trim()=="")
            {

                errCheckDetails.SetError(txtLC_NO, "الرجاء ادخال رقم الاعتماد");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(txtLC_NO, "");
            }

            if (lstLC_Currency.SelectedIndex==-1)
            {

                errCheckDetails.SetError(lstLC_Currency, "الرجاء اختيار العملة");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstLC_Currency, "");
            }

            if (lstBranch.SelectedIndex == -1)
            {

                errCheckDetails.SetError(lstBranch, "الرجاء اختيار الصادر من");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstBranch, "");
            }

            if(lstPAYMENT_METHOD.Text.Trim()=="")
            {

                errCheckDetails.SetError(lstPAYMENT_METHOD, "الرجاء اختيار طريقة الدفع");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstPAYMENT_METHOD, "");
            }

            if (lstBeneficiary.SelectedIndex == -1)
            {

                errCheckDetails.SetError(lstBeneficiary, "الرجاء اختيار المورد");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstBeneficiary, "");
            }

            if (lstBANK_id.SelectedIndex == -1)
            {

                errCheckDetails.SetError(lstBANK_id, "الرجاء اختيار البنك");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstBANK_id, "");
            }

            if(lstLC_ROLLOVER.Text =="")
            {

                errCheckDetails.SetError(lstLC_ROLLOVER, "الرجاء اختيار نوع التدوير");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstLC_ROLLOVER, "");
            }
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLCNo;

            if(txtSwid.Text .Trim()=="")
            {
                dtLCNo = cnn.GetDataTable("select lc_no from lc where lc_no='" + txtLC_NO.Text.Trim() + "'");
                if (dtLCNo.Rows.Count >=1)
                {
                   
                    glb_function.MsgBox("لايمكن تكرار رقم الاعتماد");
                    return false;
                }
            }
            else
            {
                dtLCNo = cnn.GetDataTable("select lc_no from lc where lc_no='" + txtLC_NO.Text.Trim() + "' and swid != "+txtSwid.Text );
                if (dtLCNo.Rows.Count >= 1)
                {

                    glb_function.MsgBox("لايمكن تكرار رقم الاعتماد");
                    return false;
                }
            }

            if (iError == 1)
                return false;

            return true;
        }
        private void btnAddExpeness_Click(object sender, EventArgs e)
        {
            //if(txtSwid.Text.Trim()=="")
            //{
            //    glb_function.MsgBox("الرجاء اختيار الاعتماد");
            //    return;
            //}

            //Purchases.frmPrecurementExpensess frm = new Purchases.frmPrecurementExpensess();
            //frm.txtISSUED_ID.Text = txtSwid.Text;
            //frm.txtISSUED_TYPE.Text = "اعتماد";
            //frm.txtTempletId.Text = lstTemplet.SelectedValue.ToString();
            //frm.strLcAccId = txtLcAccId.Text;
           
          
            //frm.ShowDialog();
        }

        private void myBottun2_Click(object sender, EventArgs e)
        {
            
            Purchases. frmGetPurchaseOrder frm = new Purchases.frmGetPurchaseOrder();
            frm.strWhere = "  and h.stat in ('فعال')";
            frm.ShowDialog();

            txtPurchaseOrderSwid.Text = frm.strOrderSwid;

            txtPURCHASES_ORDER_ID.Text = frm.strOrderNum;
        }
       

        private void btnGetPeople_Click(object sender, EventArgs e)
        {
           Purchases. frmFindVendor frm = new Purchases.frmFindVendor();

            frm.ShowDialog();

            if (frm.strVendorID.Trim() != "")
            {
                //txtBENEFICIARY_ID.Text = frm.strVendorID;
               // GetVendorData(txtBENEFICIARY_ID.Text);
            }
        }
        private void GetVendorData(string strVendorId)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtVendor = cnn.GetDataTable("select p_name from people where swid=" + strVendorId);

           // txtBENEFICIARYName.Text = dtVendor.Rows[0]["p_name"].ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            glb_function.MsgBox("لايمكن تعديل بيانات الاعتماد" +"\n" + "الرجاء مراجعة مدير النظام");
            return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindLC frm = new frmFindLC();
            frm.strWhere = " and lc.stat='فعال' ";
            frm.ShowDialog();

            txtSwid.Text = frm.strLcId;

            if (txtSwid.Text != "")
                GetData(txtSwid.Text);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            PrepareForm();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void nmbPAYMENT_PERCENTAGE_TextChanged(object sender, EventArgs e)
        {
            nmbINSURANCE_PERCENTAGE.Value = 100-nmbPAYMENT_PERCENTAGE.Value;
        }

        private void nmbINSURANCE_PERCENTAGE_TextChanged(object sender, EventArgs e)
        {
            nmbPAYMENT_PERCENTAGE .Value = 100 - nmbINSURANCE_PERCENTAGE.Value;
        }

        private void btnAddLcRollOver_Click(object sender, EventArgs e)
        {
            if (!CheckDetailsEntries())
                return;

          


            dgvLC_Rollover.Rows.Add();
            dgvLC_Rollover[0, dgvLC_Rollover.Rows.Count - 1].Value = "";
            dgvLC_Rollover[1, dgvLC_Rollover.Rows.Count - 1].Value = "";
            dgvLC_Rollover[clmROLLOVER_TYPE.Index, dgvLC_Rollover.Rows.Count - 1].Value = lstROLLOVER_TYPE.Text.Trim();
            dgvLC_Rollover[clmPurchaseOrderSwid.Index, dgvLC_Rollover.Rows.Count - 1].Value = txtPurchaseOrderSwid.Text;
            dgvLC_Rollover[clmRPurchaseOrderNo.Index, dgvLC_Rollover.Rows.Count - 1].Value = txtPURCHASES_ORDER_ID.Text;
            dgvLC_Rollover[clmLC_Value.Index, dgvLC_Rollover.Rows.Count - 1].Value = nmbROLLOVER_VALUE.Value.ToString();
            dgvLC_Rollover[clmOPEN_DATE.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtpOPEN_DATE.Value.ToString("dd/MM/yyyy");
            dgvLC_Rollover[clmEND_DATE.Index, dgvLC_Rollover.Rows.Count - 1].Value = dtpEnd_DATE.Value.ToString("dd/MM/yyyy");

            dgvLC_Rollover[clmRAccId.Index, dgvLC_Rollover.Rows.Count - 1].Value = lstAccName.SelectedValue.ToString();
            dgvLC_Rollover[clmRAccNo.Index, dgvLC_Rollover.Rows.Count - 1].Value = lstAccNo.Text;
            dgvLC_Rollover[clmRAccName.Index, dgvLC_Rollover.Rows.Count - 1].Value = lstAccName.Text;
            dgvLC_Rollover[clmPAYMENT_PERCENTAGE.Index, dgvLC_Rollover.Rows.Count - 1].Value = nmbPAYMENT_PERCENTAGE.Value.ToString();
            dgvLC_Rollover[clmINSURANCE_PERCENTAGE.Index, dgvLC_Rollover.Rows.Count - 1].Value = nmbINSURANCE_PERCENTAGE.Value.ToString();
            dgvLC_Rollover[clmRolloverNotes.Index, dgvLC_Rollover.Rows.Count - 1].Value = txtRolloverNotes.Text;

        }

        private void dgvLC_Rollover_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            nmbTotalPartialLc.Value = 0;
            dgvLC_Operations.Rows.Clear();

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtOperation = cnn.GetDataTable("select swid , journal_id, "+
                  "  purchases_bill_id, operations_value, notes, document_no, vocher_value, "+
                  "   operation_type, op_exchangerate, vocher_exchangerate, "+
                   "  op_mainvalue, vocher_mainvalue,VOCHER_CURRENCY" +
                   "  from lc_operations"+
                   "  where detail_id = "+dgvLC_Rollover[clmRolloverswid.Index ,e.RowIndex].Value.ToString());
            
            for (int i = 0; i < dtOperation.Rows.Count; i++)
            {
                dgvLC_Operations.Rows.Add();
                dgvLC_Operations[clmOperationSwid.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["swid"].ToString();
                dgvLC_Operations[clmOpJournalId.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["journal_id"].ToString();
                dgvLC_Operations[clmOpPurchBillId.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["purchases_bill_id"].ToString();
                dgvLC_Operations[clmPartialLCValue.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["operations_value"].ToString();
                dgvLC_Operations[clmOpNote.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["notes"].ToString();
                dgvLC_Operations[clmOpDoc_no.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["document_no"].ToString();
                dgvLC_Operations[clmVocherValue.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["vocher_value"].ToString();
                dgvLC_Operations[clmOpType.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["operation_type"].ToString();
                dgvLC_Operations[clmLcExchangeRate.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["op_exchangerate"].ToString();
                dgvLC_Operations[clmVocherExchangeRate.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["vocher_exchangerate"].ToString();
                dgvLC_Operations[clmLcMainValue.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["op_mainvalue"].ToString();
                dgvLC_Operations[clmVocherMainValue.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["vocher_mainvalue"].ToString();
                dgvLC_Operations[clmVocherCurr.Index, dgvLC_Operations.Rows.Count - 1].Value = dtOperation.Rows[i]["VOCHER_CURRENCY"].ToString();

                nmbTotalPartialLc.Value = nmbTotalPartialLc.Value + Convert.ToDecimal(dgvLC_Operations[clmPartialLCValue.Index, dgvLC_Operations.Rows.Count - 1].Value);
            }

        }

        private void lstVocherCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstVocherCurrency.SelectedValue == null)
            //    return;

            //if (lstVocherCurrency.SelectedValue.ToString() != "System.Data.DataRowView" && lstVocherCurrency.SelectedValue.ToString() != "")
            //{
            //    ConnectionToDB cnn = new ConnectionToDB();
            //    DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
            //                    " where e.curr_id = c.swid and c.swid = " + lstVocherCurrency.SelectedValue.ToString() + " " +
            //          " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

            //    dMaxRateVocher = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MAX"].ToString());
            //    dMinRateVocher = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MIN"].ToString());
            //    dExchangeRateVocher = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
            //    iCurrDecimalVocher = Convert.ToInt16(dtcurr.Rows[0]["CURR_DECIMAL"].ToString());









            //}
        }

        private void frmLetterCredit_LocationChanged(object sender, EventArgs e)
        {

        }

        private void lstBANK_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBANK_id.SelectedValue == null)
                return;

            if (lstBANK_id.SelectedValue.ToString() != "System.Data.DataRowView" && lstBANK_id.SelectedValue.ToString() != "")
            {

                if(lstPAYMENT_METHOD.Text =="اطلاع")
                {
                    lstAccName.DataSource = null;
                    lstAccNo.DataSource = null;

                    FillAccountsBank();


                }
            }

        }
        private void FillAccountsBank()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtAcc = cnn.GetDataTable("select a.swid,a.acc_name from accounts a  " +
               " join acc_curr ac on(a.swid = ac.acc_id) " +
              "  where ac.curr_id =  " + lstLC_Currency.SelectedValue.ToString() +
               " and a.swid in (select b.acc_id from banks_accounts b where b.bank_id = "+lstBANK_id.SelectedValue.ToString()+")"); ;

            lstAccNo.DataSource = dtAcc;
            lstAccNo.ValueMember = "swid";
            lstAccNo.DisplayMember = "acc_name";
            lstAccName.DataSource = dtAcc;
            lstAccName.ValueMember = "swid";
            lstAccName.DisplayMember = "acc_name";

            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;

        }
        private void dgvLC_Operations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 )
            //    return;

            //if (e.ColumnIndex == clmVocherValue.Index || e.ColumnIndex==clmOpNote.Index || e.ColumnIndex==clmOpDoc_no.Index || e.ColumnIndex == clmPartialLCValue.Index || e.ColumnIndex ==clmBtnVocher.Index)
            //{
            //    if(e.ColumnIndex == clmPartialLCValue.Index)
            //     if (dgvLC_Operations[clmOpType.Index, e.RowIndex].Value.ToString() == "تامين")
            //        return;

            //    if(e.ColumnIndex == clmVocherValue.Index)
            //    {
            //        if(dgvLC_Operations[clmVocherCurr.Index ,e.RowIndex].Value .ToString()==lstVocherCurrency.Text )
            //        {
            //            ConnectionToDB cnn = new ConnectionToDB();
            //            DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
            //                            " where e.curr_id = c.swid and c.swid = " + lstVocherCurrency.SelectedValue.ToString() + " " +
            //                  " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

            //            dMaxRateVocher = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MAX"].ToString());
            //            dMinRateVocher = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MIN"].ToString());
            //            dExchangeRateVocher = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
            //            iCurrDecimalVocher = Convert.ToInt16(dtcurr.Rows[0]["CURR_DECIMAL"].ToString());
            //        }
            //        else if(dgvLC_Operations[clmVocherCurr.Index, e.RowIndex].Value.ToString() == lstLC_Currency.Text)
            //        {
            //            ConnectionToDB cnn = new ConnectionToDB();
            //            DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
            //                            " where e.curr_id = c.swid and c.swid = " + lstLC_Currency.SelectedValue.ToString() + " " +
            //                  " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

            //            dMaxRateVocher = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MAX"].ToString());
            //            dMinRateVocher = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MIN"].ToString());
            //            dExchangeRateVocher = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
            //            iCurrDecimalVocher = Convert.ToInt16(dtcurr.Rows[0]["CURR_DECIMAL"].ToString());
            //        }
            //        else
            //        {
            //            dMaxRateVocher = 0;
            //            dMinRateVocher =0;
            //            dExchangeRateVocher =0;
            //            iCurrDecimalVocher =0;
            //            glb_function.MsgBox("لايمكن تحديد عملة القيد");
            //            return;
            //        }
            //    }
            //}
           
            //else if(e.ColumnIndex==clmLcExchangeRate.Index || e.ColumnIndex==clmVocherExchangeRate.Index)
            //{
            //    if (txtExceedExchangeRate.Text.Trim() != "1")
            //    {
            //        return;
            //    }

            //    if (e.ColumnIndex == clmLcExchangeRate.Index && (dgvLC_Operations[clmPartialLCValue.Index, e.RowIndex].Value.ToString() == "" || dgvLC_Operations[clmPartialLCValue.Index, e.RowIndex].Value.ToString() == "0"))
            //        return;

            //    if (e.ColumnIndex == clmVocherExchangeRate.Index && (dgvLC_Operations[clmVocherValue.Index, e.RowIndex].Value.ToString() == "" || dgvLC_Operations[clmVocherValue.Index, e.RowIndex].Value.ToString() == "0"))
            //        return;



            //}
            //else
            //    return;

            //DataGridViewCell abc = dgvLC_Operations.CurrentCell;

            //Rectangle RECT = dgvLC_Operations.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);


            //if(e.ColumnIndex == clmPartialLCValue.Index || e.ColumnIndex == clmVocherValue.Index)
            //{
            //    nmbEditor.Tag = e.RowIndex.ToString();
            //    nmbEditor.W_ColEgName = dgvLC_Operations.Columns[e.ColumnIndex].Name ;
               
            //    nmbEditor.Value = Convert.ToDecimal((dgvLC_Operations[e.ColumnIndex, e.RowIndex].Value.ToString() == "" ? "0" : dgvLC_Operations[e.ColumnIndex, e.RowIndex].Value.ToString()));

            //    if (e.ColumnIndex == clmPartialLCValue.Index)
            //    {

            //        nmbEditor.DecimalPlaces = iCurrDecimal;


            //    }
            //    else if (e.ColumnIndex == clmVocherValue.Index)
            //    {
            //        nmbEditor.DecimalPlaces = iCurrDecimalVocher;
                  
            //    }
                   

            //    CtlLocation(RECT, nmbEditor);
            //}
            //else if(e.ColumnIndex == clmOpNote.Index || e.ColumnIndex == clmOpDoc_no.Index)
            //{
            //    txtEditor.Tag = e.RowIndex.ToString();
            //    txtEditor.W_ColEgName = dgvLC_Operations.Columns[e.ColumnIndex].Name;

            //    txtEditor.Text  = dgvLC_Operations[e.ColumnIndex, e.RowIndex].Value.ToString() ;
               
            //    CtlLocation(RECT, txtEditor);
            //}
            //else if (e.ColumnIndex == clmLcExchangeRate.Index || e.ColumnIndex == clmVocherExchangeRate.Index)
            //{
            //    nmbEditorRate.Tag = e.RowIndex.ToString();
            //    nmbEditorRate.AccessibleName = dgvLC_Operations.Columns[e.ColumnIndex].Name;

            //    nmbEditorRate.Value = Convert.ToDecimal((dgvLC_Operations[e.ColumnIndex, e.RowIndex].Value.ToString() == "" ? "0" : dgvLC_Operations[e.ColumnIndex, e.RowIndex].Value.ToString()));
            //    CtlLocation(RECT, nmbEditorRate);
            //}
            //else if(e.ColumnIndex == clmBtnVocher.Index )
            //{
            //    if(dgvLC_Operations[clmLcMainValue.Index ,e.RowIndex].Value .ToString() !=dgvLC_Operations[clmVocherMainValue.Index ,e.RowIndex].Value.ToString())
            //    {
            //        glb_function.MsgBox("مبلغ المدين للعملة الرئيسية لا يساوي الدائن");
            //        return;
            //    }

            //    if(dgvLC_Operations[clmOpJournalId.Index ,e.RowIndex].Value .ToString().Trim()!=""  )
            //    {
            //        glb_function.MsgBox("تم عمل قيد لهذه العملية");
            //        return;
            //    }
            //    ConnectionToDB cnn = new ConnectionToDB();
            //   // DataTable dt;
            //    string strJournalId = "";
            //    int icheck = 0;


            //    ConnectionToDB.objCmd = new Oracle.ManagedDataAccess.Client.OracleCommand();

            //    string strHeader = GetJournalHeader(e.RowIndex);
            //    string strDetails = GetJournalDetails(e.RowIndex);

            //    ConnectionToDB.objCmd.Parameters.Add("xml_journal_header", Oracle.ManagedDataAccess.Client.OracleDbType.XmlType).Value = strHeader;
            //    ConnectionToDB.objCmd.Parameters.Add("xml_journal_details", Oracle.ManagedDataAccess.Client.OracleDbType.XmlType).Value = strDetails.Replace("DocumentElement", "DocumentElement".ToLower());
            //    ConnectionToDB.objCmd.Parameters.Add("sqlStat", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = "";
            //    ConnectionToDB.objCmd.Parameters.Add("strHash", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = "";
            //    ConnectionToDB.objCmd.Parameters.Add("icheck", Oracle.ManagedDataAccess.Client.OracleDbType.Int16).Value = 1;
            //    ConnectionToDB.objCmd.Parameters.Add("swid", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
            //    ConnectionToDB.objCmd.Parameters.Add("Result", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;

            //    string strResult = cnn.ExecutePro("AccountsPack.journal_inser_update", "Result");
            //    strJournalId = ConnectionToDB.objCmd.Parameters["swid"].Value.ToString();
            //    if (strResult.ToUpper() != "SUCCEED")
            //    {
            //        cnn.glb_RollbackTransaction();
            //        glb_function.MsgBox("حدث خطأ اثناء عملية الحفظ");
            //        return;
            //    }


               
                 
            //            icheck = cnn.TranDataToDB("update lc_operations  set JOURNAL_ID=" +strJournalId +", " +
            //          "OPERATIONS_VALUE=" + dgvLC_Operations[clmPartialLCValue.Index ,e.RowIndex].Value.ToString() +
            //          ",NOTES='" + dgvLC_Operations[clmOpNote.Index, e.RowIndex].Value.ToString() + "',DOCUMENT_NO='" + 
            //          dgvLC_Operations[clmOpDoc_no.Index, e.RowIndex].Value.ToString() + "',VOCHER_VALUE="+
            //          dgvLC_Operations[clmVocherValue.Index, e.RowIndex].Value.ToString() + ",OP_EXCHANGERATE=" + 
            //          dExchangeRate + ",VOCHER_EXCHANGERATE="+dExchangeRateVocher+",OP_MAINVALUE=" + 
            //          dgvLC_Operations[clmLcMainValue.Index ,e.RowIndex].Value.ToString() + 
            //          ",VOCHER_MAINVALUE="+dgvLC_Operations[clmVocherMainValue.Index ,e.RowIndex].Value.ToString() +
            //          ",VOCHER_CURRENCY='" + dgvLC_Operations[clmVocherCurr.Index ,e.RowIndex].Value.ToString() +
            //          "'  where swid=" + dgvLC_Operations[clmOperationSwid.Index ,e.RowIndex].Value.ToString());

            //            if (icheck <= 0)
            //            {
            //                cnn.glb_RollbackTransaction();
            //                glb_function.MsgBox("حدث خطأ عند عملية الحفظ");
            //                return;
            //            }

            //    //****if invoice
            //    if (dgvLC_Operations[clmOpType.Index, e.RowIndex].Value.ToString().Trim() == "فاتورة")
            //    {
            //        DataTable dtInvoiceDetail = cnn.GetDataTable("select nvl( sum(ex.expenses_value),0) from PURCHASE_Expenses ex,EXPENSES_ITEM itmEx " +
            //               " where ex.expenses_id = itmEx.Swid and  ex.expensess_type = 'فاتورة شراء' " +
            //               " and ex.header_id = " + dgvLC_Operations[clmOpPurchBillId.Index, e.RowIndex].Value.ToString());
            //        decimal dInternalExp =Convert.ToDecimal( dtInvoiceDetail.Rows[0][0].ToString());

            //        if(dInternalExp>0)
            //        { 
            //        dtInvoiceDetail.Clear();
            //         dtInvoiceDetail = cnn.GetDataTable("select swid, " +
            //                         " decode(d.quantity, 0, 0, (((d.quantity * d.price) / (select sum(s.quantity * s.price) from purchases_bill_details s where s.header_id = " + dgvLC_Operations[clmOpPurchBillId.Index, e.RowIndex].Value.ToString() + ") * 100) * " + dInternalExp.ToString() + " / 100)/ d.quantity) internal_exp" +
            //                         " from purchases_bill_details d " +
            //                         " where d.header_id =  " + dgvLC_Operations[clmOpPurchBillId.Index, e.RowIndex].Value.ToString());

            //        for (int i = 0; i < dtInvoiceDetail.Rows.Count; i++)
            //        {
            //            icheck = cnn.TranDataToDB("update purchases_bill_details set internal_exp=" + dtInvoiceDetail.Rows[i]["internal_exp"].ToString() + " where swid=" + dtInvoiceDetail.Rows[i]["swid"].ToString());

            //            if (icheck <= 0)
            //            {
            //                cnn.glb_RollbackTransaction();
            //                glb_function.MsgBox("حدث خطأ عند عملية الحفظ");
            //                return;
            //            }
            //        }

            //        }

            //        //Get stock exchange value and decimal
            //        decimal dMainValue =  Convert.ToDecimal( dgvLC_Operations[clmLcMainValue.Index, e.RowIndex].Value.ToString()) ;
            //        DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
            //                        " where e.curr_id = c.swid and c.swid = (select swid from currency sc where sc.is_stock_curr=1) " +
            //              " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");


            //        decimal dStockExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());


            //        decimal dStockValue = (dMainValue / dStockExchangeRate);

            //        //*******************************

            //        icheck = cnn.TranDataToDB("update  purchases_bill set stat='مقيد' TOTAL_VALUE_IN_STOCK_CURR ="+ dStockValue .ToString()+ ",TOTAL_VALUE_IN_MAIN_CURR="+dMainValue+ ",TOTAL_VALUE_IN_BILL_CURR=" + dgvLC_Operations[clmPartialLCValue.Index, e.RowIndex].Value.ToString() + " where swid=" + dgvLC_Operations[clmOpPurchBillId.Index, e.RowIndex].Value.ToString() + "");
            //        if (icheck <= 0)
            //        {
            //            cnn.glb_RollbackTransaction();
            //            glb_function.MsgBox("حدث خطأ عند عملية الحفظ");
            //            return;
            //        }
            //    }
               
            //    //*************

            //    cnn.glb_commitTransaction();
            //    glb_function.MsgBox("تمت عملية الحفظ بنجاح");
            //}





        }

        private string GetJournalHeader(int iRow)
        {

            StringBuilder sbGetXml = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(sbGetXml);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("DocumentElement".ToLower());

            xmlWriter.WriteStartElement("journal_header".ToLower());

            xmlWriter.WriteElementString("SWID".ToLower(), "");

            xmlWriter.WriteElementString("CREATED_USER".ToLower(), glb_function.glb_strUserId);

            xmlWriter.WriteElementString("STAT".ToLower(), "فعال");

            xmlWriter.WriteElementString("JOUR_NUM".ToLower(), "");




            if (dgvLC_Operations[clmOpType.Index, iRow].Value.ToString().Trim() == "فاتورة")
            {
                xmlWriter.WriteElementString("VOCH_TYPE".ToLower(), "فاتورة شراء");
                xmlWriter.WriteElementString("VOCH_NO".ToLower(), dgvLC_Operations[clmOpPurchBillId.Index, iRow].Value.ToString());
                xmlWriter.WriteElementString("JOUR_DETAILS_Header".ToLower(), "من فاتورة رقم" + " " + GetInvoiceNo(dgvLC_Operations[clmOpPurchBillId.Index, iRow].Value.ToString()) );
            }
            else
            {
                xmlWriter.WriteElementString("VOCH_TYPE".ToLower(), "قيد اعتماد");
                xmlWriter.WriteElementString("VOCH_NO".ToLower(), txtSwid.Text);
                xmlWriter.WriteElementString("JOUR_DETAILS_Header".ToLower(), "من اعتماد رقم" + " " + txtLC_NO.Text);
            }
           

            xmlWriter.WriteElementString("VOCH_NO_M".ToLower(), dgvLC_Operations[clmOpDoc_no.Index , iRow].Value .ToString());
            xmlWriter.WriteElementString("JOUR_DATE".ToLower(), DateTime.Now.ToString("dd/MM/yyyy"));

          

            xmlWriter.WriteElementString("BranchHeader".ToLower(), glb_function.glb_BranchNo.ToString());

         

            xmlWriter.WriteElementString("MODEL_NO".ToLower(), lstTemplet.SelectedValue.ToString());


            xmlWriter.WriteElementString("JOUR_VALUE".ToLower(), dgvLC_Operations[clmLcMainValue.Index,iRow].Value.ToString());
            xmlWriter.WriteElementString("ORDER_ID".ToLower(), "");
            xmlWriter.WriteElementString("CONTACT_ID".ToLower(), "");
            xmlWriter.WriteElementString("NOTE_NO".ToLower(), "1");
            xmlWriter.WriteElementString("COLLECTOR_ID".ToLower(), "");
            xmlWriter.WriteElementString("CONTACT_NAME".ToLower(), "");
            xmlWriter.WriteElementString("REVERSE_VOCHER_ID".ToLower(), "");


            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();
            string strHeader = sbGetXml.ToString();
            return strHeader;
        }
        private string GetInvoiceNo(string strBillId)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt = cnn.GetDataTable("select bill_number from purchases_bill where swid="+strBillId );

            return dt.Rows[0][0].ToString();
        }
        private string GetJournalDetails(int iRow)
        {
            DataTable dt = new DataTable();
            dt.TableName = "JOURNAL_DETAILS".ToLower();
            dt.Columns.Add("swid");
            dt.Columns.Add("credit");
            dt.Columns.Add("dept");
            dt.Columns.Add("JOUR_MAIN_VALUE".ToLower());
            dt.Columns.Add("ACC_ID".ToLower());
            dt.Columns.Add("CURR_ID".ToLower());
            dt.Columns.Add("CURR_PRICE".ToLower());
            dt.Columns.Add("COST_CENTER".ToLower());
            dt.Columns.Add("JOUR_DETAILS".ToLower());
            dt.Columns.Add("STAT".ToLower());
            dt.Columns.Add("CURENT_CURR_PRICE".ToLower());

            string strAccid = "";
            //if invoice get account from بضاعة في الطريق
            if (dgvLC_Operations[clmOpType.Index, iRow].Value.ToString().Trim() == "فاتورة")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtInvoiceAccId = cnn.GetDataTable("select swid from accounts where system_acc_type='بضاعة في الطريق'");
                if (dtInvoiceAccId == null || dtInvoiceAccId.Rows.Count<=0)
                {
                    glb_function.MsgBox("لايوجد حساب لبضاعة في الطريق"+"\n"+"سيتم اقفال الشاشة");
                    this.Close();
                }
                strAccid = dtInvoiceAccId.Rows[0][0].ToString();
                //مدين
                dt.Rows.Add(new Object[] { "",
                        "0",
                         dgvLC_Operations[clmVocherMainValue.Index ,iRow].Value.ToString(),
                       dgvLC_Operations[clmVocherMainValue.Index ,iRow].Value.ToString(),

                      strAccid ,
                        glb_function.glb_MainCurrencyId ,
                          "1",
                          "" ,
                         "",
                          "فعال","1"

                        });
            }
            else
            {
                //strAccid = dgvLC_Rollover[clmRAccId.Index, dgvLC_Rollover.CurrentRow.Index].Value.ToString();
                ////مدين
                //dt.Rows.Add(new Object[] { "",
                //        "0",
                //         dgvLC_Operations[clmVocherMainValue.Index ,iRow].Value.ToString(),
                //      dgvLC_Operations[clmVocherValue.Index ,iRow].Value.ToString(),

                //      strAccid ,
                //        (dgvLC_Operations[clmVocherCurr.Index ,iRow].Value.ToString()==lstLC_Currency.Text ?lstLC_Currency.SelectedValue.ToString():lstVocherCurrency.SelectedValue.ToString()) ,
                //          dgvLC_Operations[clmVocherExchangeRate.Index ,iRow].Value.ToString(),
                //          "" ,
                //         "",
                //          "فعال",dExchangeRateVocher.ToString()

                //        });
            }
          
          


         
            


            

            //دائن
            //dt.Rows.Add(new Object[] { "" ,
            //  dgvLC_Operations[clmLcMainValue.Index ,iRow].Value .ToString(),
            // "0"  ,
            //dgvLC_Operations[clmPartialLCValue.Index ,iRow].Value .ToString() ,
            //   txtLcAccId.Text .ToString() ,
            //    lstLC_Currency.SelectedValue.ToString(),
            //      dgvLC_Operations[clmLcExchangeRate.Index,iRow].Value .ToString(),
            //     "",
            //     "",
            //      "فعال",dExchangeRate.ToString()

            //    });






            System.IO.StringWriter writer = new System.IO.StringWriter();
            dt.WriteXml(writer);
            string strDetails = writer.ToString();




            return strDetails;
        }

        private void CtlLocation(Rectangle rect, Control ctrl)
        {


            ctrl.Top = dgvLC_Operations.Location.Y + rect.Y;
            ctrl.Left = dgvLC_Operations.Location.X + rect.X;
            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;
            ctrl.Focus();


        }

        private void nmbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void nmbEditor_Leave(object sender, EventArgs e)
        {
            if (nmbEditor.Visible == true)
            {
                nmbEditor.Visible = false;
                
                dgvLC_Operations[nmbEditor.W_ColEgName, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = nmbEditor.Value.ToString();
                dgvLC_Operations[(nmbEditor.W_ColEgName== "clmVocherValue" ? clmVocherExchangeRate.Index:clmLcExchangeRate.Index ), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = (nmbEditor.W_ColEgName == "clmVocherValue" ? dExchangeRateVocher : dExchangeRate ) ;
                dgvLC_Operations[(nmbEditor.W_ColEgName == "clmVocherValue" ? clmVocherMainValue.Index : clmLcMainValue.Index), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value =Math.Round( (nmbEditor.W_ColEgName == "clmVocherValue" ? dExchangeRateVocher : dExchangeRate) * nmbEditor.Value,glb_function.glbMainDecimalPoint) ;
                // dgvLC_Operations[clmVocherMainValue.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value =

                if(nmbEditor.Value !=0)
                dgvLC_Operations[(nmbEditor.W_ColEgName == "clmVocherValue" ? clmVocherExchangeRate.Index : clmLcExchangeRate.Index), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = ( Convert.ToDecimal(dgvLC_Operations[(nmbEditor.W_ColEgName == "clmVocherValue" ? clmVocherMainValue.Index : clmLcMainValue.Index), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value) / nmbEditor.Value).ToString();
            }
        }

        private void txtEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtEditor_Leave(object sender, EventArgs e)
        {

            if (txtEditor.Visible == true)
            {
                txtEditor.Visible = false;

                dgvLC_Operations[txtEditor.W_ColEgName, Convert.ToUInt16(txtEditor.Tag.ToString())].Value = txtEditor.Text ;

            }
        }

        private void nmbEditorRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void nmbEditorRate_Leave(object sender, EventArgs e)
        {
            nmbEditorRate.Visible = false;

            dgvLC_Operations[nmbEditorRate.AccessibleName, Convert.ToUInt16(nmbEditorRate.Tag.ToString())].Value = nmbEditorRate.Value.ToString();



           // dgvLC_Operations[(nmbEditorRate.AccessibleName == "clmVocherValue" ? clmVocherExchangeRate.Index : clmLcExchangeRate.Index), Convert.ToUInt16(nmbEditorRate.Tag.ToString())].Value = (nmbEditorRate.AccessibleName == "clmVocherValue" ? dExchangeRateVocher : dExchangeRate);
            dgvLC_Operations[(nmbEditorRate.AccessibleName == "clmVocherExchangeRate" ? clmVocherMainValue.Index : clmLcMainValue.Index), Convert.ToUInt16(nmbEditorRate.Tag.ToString())].Value = Math.Round(Convert.ToDecimal (dgvLC_Operations[(nmbEditorRate.AccessibleName == "clmVocherExchangeRate" ? clmVocherValue.Index : clmPartialLCValue.Index), Convert.ToUInt16(nmbEditorRate.Tag.ToString())].Value) * nmbEditorRate.Value, glb_function.glbMainDecimalPoint);


            dgvLC_Operations[nmbEditorRate.AccessibleName, Convert.ToUInt16(nmbEditorRate.Tag.ToString())].Value = (Convert.ToDecimal(dgvLC_Operations[(nmbEditorRate.AccessibleName == "clmVocherExchangeRate" ? clmVocherMainValue.Index : clmLcMainValue.Index), Convert.ToUInt16(nmbEditorRate.Tag.ToString())].Value) / Convert.ToDecimal(dgvLC_Operations[(nmbEditorRate.AccessibleName == "clmVocherExchangeRate" ? clmVocherValue.Index : clmPartialLCValue.Index), Convert.ToUInt16(nmbEditorRate.Tag.ToString())].Value)).ToString();




        }

        private void lstPAYMENT_METHOD_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstBANK_id.DataSource = null;
            lstBeneficiary.DataSource = null;
            

            if (lstPAYMENT_METHOD.Text .Trim()== "اطلاع")
            {
                nmbINSURANCE_Value.Enabled = true;
                nmbINSURANCE_PERCENTAGE.Enabled = true;
                lstAccNo.Enabled = true;
                lstAccName.Enabled = true;
                FillBanksWithAcc();
            }
            else
            {
                nmbINSURANCE_Value.Enabled = false ;
                nmbINSURANCE_PERCENTAGE.Enabled = false ;
                lstAccNo.Enabled = false ;
                lstAccName.Enabled = false ;
                FillAllBanks();
            }

            
            
        }
        private void FillBanksWithAcc()
        {
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtBanks = cnn.GetDataTable("select distinct b.swid,b.b_name " +
                                               " from banks b " +
                                               " join banks_accounts ba on (ba.bank_id = b.swid) " +
                                               " and ba.acc_id in (select a.swid " +
                                               " from accounts a " +
                                               " join acc_curr ac on (ac.acc_id = a.swid) " +
                                               " where acc_type = 'بنوك' " +
                                               " and acc_class = 'فرعي' " +
                                                " and ac.curr_id = " + lstLC_Currency.SelectedValue.ToString() + ")");

            lstBANK_id.DataSource = dtBanks;
            lstBANK_id.ValueMember = "swid";
            lstBANK_id.DisplayMember = "b_name";
            lstBANK_id.SelectedIndex = -1;


        }
        private void FillAllBanks()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBanks = cnn.GetDataTable("select  b.swid,b.b_name " +
                                " from banks b " +
                               "  order by swid");

            lstBANK_id.DataSource = dtBanks;
            lstBANK_id.ValueMember = "swid";
            lstBANK_id.DisplayMember = "b_name";
            lstBANK_id.SelectedIndex = -1;

        }

        private void lstROLLOVER_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBeneficiary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBeneficiary.SelectedValue == null)
                return;

            if (lstBeneficiary.SelectedValue.ToString() != "System.Data.DataRowView" && lstBeneficiary.SelectedValue.ToString() != "")
            { 
                if(lstPAYMENT_METHOD.Text =="اجل")
                {
                    lstAccNo.DataSource = null;
                    lstAccName.DataSource = null;
                    ConnectionToDB cnn = new ConnectionToDB();
                    DataTable dtVendorAcc = cnn.GetDataTable("select a.swid,a.acc_name from accounts a "+
                        " where a.swid = (select p.acc_id from people p where p.swid = "+ lstBeneficiary.SelectedValue.ToString() + ")");
                    lstAccNo.DataSource = dtVendorAcc;
                    lstAccNo.ValueMember = "swid";
                    lstAccNo.DisplayMember = "acc_name";

                    lstAccName.DataSource = dtVendorAcc;
                    lstAccName.ValueMember = "swid";
                    lstAccName.DisplayMember = "acc_name";


                }
            
            }
        }

        private void lstLC_ROLLOVER_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstLC_ROLLOVER.Text == "تدوير بالفترة")
            {
                nmbROLLOVER_COUNT.Enabled = true;
            }
            else
            {
                nmbROLLOVER_COUNT.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtSwid.Text.Trim()=="")
            {
                glb_function.MsgBox("لا يوجد اعتماد للحذف");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt = cnn.GetDataTable("select t.swid from LC_ROLLOVER t where header_id="+txtSwid.Text );
            int icheck = 0;
            if(dt==null || dt.Rows.Count <=0)
            {
                if (glb_function.MsgBox("هل انت متاكد انك تريد حذف الاعتماد؟", "", true) == false)
                    return;

                icheck = cnn.TranDataToDB("delete from lc where swid="+txtSwid.Text );
                if(icheck <=0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء حذف الاعتماد");
                    return;
                }
                cnn.glb_commitTransaction();

                glb_function.MsgBox("تمت عملية الحذف بنجاح");
            }
            else
            {
                glb_function.MsgBox("لايمكن حذف اعتماد له دورات");
            }
        }
    }
}
