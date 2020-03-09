using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ERP.Purchases
{
    public partial class frmPrecurementExpensess : ERP.MyForm
    {
       
        public string strTitle="";

        

        public string strLcAccId = "";
       


        private decimal dExchangeRate;
        private short iCurrDecimal;
        private string iCurrSwid;


        public frmPrecurementExpensess()
        {
            InitializeComponent();
        }

        private void frmPrecurementExpensess_Load(object sender, EventArgs e)
        {
            glb_function.FillListWithId(ref lstCURRENCY_ID, "CURRENCY", "curr_name");
           
            GetExpensess();

        }
        private void GetExpensess()
        {
            dgvPrecuremenExp.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtExpDate = cnn.GetDataTable("select  p.swid," +
                                " p.people_id ,(select p_name from people where swid=p.people_id) people_name," +
                                " p.expenses_item_id,(select expenses_name from expenses_item where swid= expenses_item_id) ExpensessName," +
                                " expenses_value,MAIN_VALUE,STOCK_VALUE, " +
                                " journal_id, notes, document_no, add_to_cost," +
                                "(select curr_name from currency c where c.swid=p.EXP_CURRENCY_ID) exp_currency " +
                                " from procurement_expenses p " +
                                " where issued_id= "+txtISSUED_ID.Text +
                                " and issued_type='" + txtISSUED_TYPE.Text + "' ");

            for (int i = 0; i < dtExpDate.Rows.Count; i++)
            {
                dgvPrecuremenExp.Rows.Add();
                dgvPrecuremenExp[clmSwid.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["swid"].ToString();
                dgvPrecuremenExp[clmPeopleId.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["people_id"].ToString();
                dgvPrecuremenExp[clmPeopleName.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["people_name"].ToString();
                dgvPrecuremenExp[clmExpensessId.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["expenses_item_id"].ToString();
                dgvPrecuremenExp[clmExpensessName.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["ExpensessName"].ToString();

                dgvPrecuremenExp[clmMainValue.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["MAIN_VALUE"].ToString();
                dgvPrecuremenExp[clmStockValue.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["STOCK_VALUE"].ToString();

                dgvPrecuremenExp[clmExpValue.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["expenses_value"].ToString();


                dgvPrecuremenExp[clmAddToCost.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["add_to_cost"].ToString();
                dgvPrecuremenExp[clmDoc_no.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["document_no"].ToString();
                dgvPrecuremenExp[clmNote.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["notes"].ToString();
               
                dgvPrecuremenExp[clmExpCurrency.Index, dgvPrecuremenExp.Rows.Count - 1].Value = dtExpDate.Rows[i]["exp_currency"].ToString();

            }


            for (int i = 0; i < dgvPrecuremenExp.Rows.Count; i++)
            {
                if(dgvPrecuremenExp[clmSwid.Index ,i].Value .ToString()!="")
                for (int y = 0; y < dgvPrecuremenExp.Rows[i].Cells.Count; y++)
                    dgvPrecuremenExp.Rows[i].Cells[y].Style.BackColor = System.Drawing.Color.LawnGreen;
            }

        }
        private void btnGetExpenss_Click(object sender, EventArgs e)
        {
            frmGetExpensses frm = new frmGetExpensses();

            frm.ShowDialog();

            if (frm.strExpensses_id.Trim() != "")
            {
                txtEXPENSES_ID.Text = frm.strExpensses_id;
                GetDataExpenses(txtEXPENSES_ID.Text);
            }
        }
        private void GetDataExpenses(string strExpSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtExpenss = cnn.GetDataTable("select swid,expenses_name,acc_id from EXPENSES_ITEM where swid=" + strExpSwid);
            txtEXPENSES_ID.Text = dtExpenss.Rows[0]["swid"].ToString();
            txtEXPENSES_Name.Text = dtExpenss.Rows[0]["expenses_name"].ToString();
            txtExpAccId.Text = dtExpenss.Rows[0]["acc_id"].ToString();
        }

        private void btnGetPeople_Click(object sender, EventArgs e)
        {
            Purchases.frmFindVendor frm = new Purchases.frmFindVendor();

            frm.ShowDialog();

            if (frm.strVendorID.Trim() != "")
            {
                txtPEOPLE_ID.Text = frm.strVendorID;
                GetVendorData(txtPEOPLE_ID.Text);
            }
        }
        private void GetVendorData(string strVendorId)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtVendor = cnn.GetDataTable("select p_name from people where swid=" + strVendorId);

            txtPeopleName.Text = dtVendor.Rows[0]["p_name"].ToString();

        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            if(txtEXPENSES_ID.Text =="")
            {
                glb_function.MsgBox("الرجاء اختيار المصروف");
                return;
            }
            if(lstCURRENCY_ID.SelectedIndex==-1)
            {
                glb_function.MsgBox("الرجاء اختيار العملة");
                return;
            }
            if(nmbExpenssItem.Value <=0)
            {
                glb_function.MsgBox("الرجاء ادخال المبلغ");
                return;
            }
            dgvPrecuremenExp.Rows.Add();
            dgvPrecuremenExp[clmSwid.Index, dgvPrecuremenExp.Rows.Count - 1].Value = "";
            dgvPrecuremenExp[clmPeopleId.Index, dgvPrecuremenExp.Rows.Count - 1].Value = txtPEOPLE_ID.Text ;
            dgvPrecuremenExp[clmPeopleName.Index, dgvPrecuremenExp.Rows.Count - 1].Value =txtPeopleName.Text ;
            dgvPrecuremenExp[clmExpensessId.Index, dgvPrecuremenExp.Rows.Count - 1].Value = txtEXPENSES_ID.Text ;
            dgvPrecuremenExp[clmExpensessName.Index, dgvPrecuremenExp.Rows.Count - 1].Value = txtEXPENSES_Name.Text ;
            dgvPrecuremenExp[clmExpValue.Index, dgvPrecuremenExp.Rows.Count - 1].Value = nmbExpenssItem.Value.ToString();
            
            dgvPrecuremenExp[clmExchangeRate.Index, dgvPrecuremenExp.Rows.Count - 1].Value = nmbCURR_PRICE.Value.ToString();
            dgvPrecuremenExp[clmMainValue.Index, dgvPrecuremenExp.Rows.Count - 1].Value = nmbCASHER_MAIN_VALUE.Value.ToString();


            //Get stock exchange value and decimal
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
                            " where e.curr_id = c.swid and c.swid = (select swid from currency sc where sc.is_stock_curr=1) " +
                  " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");


            decimal dStockExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
           

            dgvPrecuremenExp[clmStockValue.Index, dgvPrecuremenExp.Rows.Count - 1].Value = ( nmbCASHER_MAIN_VALUE.Value * dStockExchangeRate).ToString();

            //*******************************
            dgvPrecuremenExp[clmAddToCost.Index, dgvPrecuremenExp.Rows.Count - 1].Value = (ckbADD_TO_COST.Checked ==true ?"نعم":"لا");
            dgvPrecuremenExp[clmDoc_no.Index, dgvPrecuremenExp.Rows.Count - 1].Value = txtDOCUMENT_No.Text ;
            dgvPrecuremenExp[clmNote.Index, dgvPrecuremenExp.Rows.Count - 1].Value = txtNotes.Text ;

           

            dgvPrecuremenExp[clmAccId.Index, dgvPrecuremenExp.Rows.Count - 1].Value = txtExpAccId.Text ;
            dgvPrecuremenExp[clmExpCurrency.Index, dgvPrecuremenExp.Rows.Count - 1].Value = lstCURRENCY_ID.Text;
            dgvPrecuremenExp[clmExpCurrId.Index, dgvPrecuremenExp.Rows.Count - 1].Value = lstCURRENCY_ID.SelectedValue.ToString();
            for (int i = 0; i < dgvPrecuremenExp.Rows.Count; i++)
            {
                if (dgvPrecuremenExp[clmSwid.Index, i].Value.ToString() != "")
                    for (int y = 0; y < dgvPrecuremenExp.Rows[i].Cells.Count; y++)
                    dgvPrecuremenExp.Rows[i].Cells[y].Style.BackColor = System.Drawing.Color.LawnGreen;
            }



            txtPEOPLE_ID.Text="";
           txtPeopleName.Text="";
           txtEXPENSES_ID.Text="";
           txtEXPENSES_Name.Text="";
            nmbExpenssItem.Value=0;
            ckbADD_TO_COST.Checked = false;

            txtNotes.Text = "";
            nmbCURR_PRICE.Value = 0;
            nmbCASHER_MAIN_VALUE.Value = 0;
          

          

        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            strDeptIssuAccId = "";
            if (lstAccName.SelectedIndex ==-1 || lstAccNo.SelectedIndex ==-1)
            {
                glb_function.MsgBox("الرجاء التاكد من ادخال رقم الحساب");
                return;
            }
            if(lstAccNo.SelectedValue.ToString() !=lstAccName.SelectedValue.ToString())
            {

                glb_function.MsgBox("الرجاء التاكد من ان رقم الحساب يطابق اسم الحساب");
                return;
            }
          
            

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt;
            string strJournalId = "";
            int icheck = 0;

           
            ConnectionToDB.objCmd = new Oracle.ManagedDataAccess.Client.OracleCommand();

            string strHeader = GetJournalHeader();
            string strDetails = GetJournalDetails();
            ConnectionToDB.objCmd.Parameters.Add("xml_journal_header", Oracle.ManagedDataAccess.Client.OracleDbType.Clob).Value = strHeader;
            ConnectionToDB.objCmd.Parameters.Add("xml_journal_details", Oracle.ManagedDataAccess.Client.OracleDbType.Clob).Value = strDetails;
            ConnectionToDB.objCmd.Parameters.Add("sqlStat", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = "";
            ConnectionToDB.objCmd.Parameters.Add("strHash", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = "";
            ConnectionToDB.objCmd.Parameters.Add("icheckNaturalAcc", Oracle.ManagedDataAccess.Client.OracleDbType.Char).Value = "0";
            ConnectionToDB.objCmd.Parameters.Add("ExceedRate", Oracle.ManagedDataAccess.Client.OracleDbType.Char).Value = "0";
            ConnectionToDB.objCmd.Parameters.Add("swid", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
            ConnectionToDB.objCmd.Parameters.Add("Result", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
            string strResult = cnn.ExecutePro("AccountsPack.journal_inser_update", "Result");
            strJournalId = ConnectionToDB.objCmd.Parameters["swid"].Value.ToString();
            

            if (strResult.ToUpper() != "SUCCEED")
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية الحفظ");
                return;
            }


            for (int i = 0; i < dgvPrecuremenExp.Rows.Count; i++)
            {
                if(dgvPrecuremenExp[clmSwid.Index,i].Value.ToString()=="")
                {
                    icheck = cnn.TranDataToDB("insert into PROCUREMENT_EXPENSES values((select nvl(max(swid),0)+1 from PROCUREMENT_EXPENSES),sysdate,"+glb_function.glb_strUserId+",'فعال','"+
                        txtISSUED_TYPE.Text +"',"+txtISSUED_ID.Text +","+ (dgvPrecuremenExp[clmPeopleId.Index, i].Value.ToString()==""?"null": dgvPrecuremenExp[clmPeopleId.Index, i].Value.ToString()) + 
                        ","+ dgvPrecuremenExp[clmExpensessId.Index, i].Value.ToString() + ","+ dgvPrecuremenExp[clmExpValue.Index, i].Value.ToString() + ","+
                        ""+strJournalId+",'"+
                        dgvPrecuremenExp[clmNote.Index,i].Value.ToString()+ "','" +
                        dgvPrecuremenExp[clmDoc_no.Index, i].Value.ToString() + "','" + 
                        dgvPrecuremenExp[clmAddToCost.Index, i].Value.ToString() + "',"+ dgvPrecuremenExp[clmMainValue.Index, i].Value.ToString() + ",'"+ dgvPrecuremenExp[clmStockValue.Index, i].Value.ToString() + "','"+ dgvPrecuremenExp[clmExpCurrId.Index, i].Value.ToString() + "')");

                    if(icheck <=0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ عند عملية الحفظ");
                        return;
                    }

                    if(txtISSUED_TYPE.Text == "تحاويل مخزنية")
                    {
                       if( dgvPrecuremenExp[clmAddToCost.Index, i].Value.ToString()== "نعم")
                        {
                            icheck = cnn.TranDataToDB("update shipping_LIST set EXPENSES_ADD_VALUE_accid="+ strDeptIssuAccId + " ,EXPENSES_ADD_VALUE=EXPENSES_ADD_VALUE+" + dgvPrecuremenExp[clmMainValue.Index, i].Value.ToString() + " where swid="+txtISSUED_ID.Text );

                            if (icheck <= 0)
                            {
                                cnn.glb_RollbackTransaction();
                                glb_function.MsgBox("حدث خطأ عند عملية الحفظ");
                                return;
                            }

                            

                        }
                    }
                }
            }

           
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الحفظ بنجاح");
            GetExpensess();


        }

        private decimal GetTotalVoucherValue()
        {
            decimal dSum = 0;
            for (int i = 0; i < dgvPrecuremenExp.Rows.Count; i++)
            {
                if (dgvPrecuremenExp[clmSwid.Index, i].Value.ToString() == "")
                {
                    dSum = dSum + Convert.ToDecimal(dgvPrecuremenExp[clmExpValue.Index, i].Value.ToString());
                }
            }

            return dSum;
        }
        private string GetJournalHeader()
        {
         

          

            

         

          
            //


            StringBuilder sbGetXml = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(sbGetXml);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("DocumentElement".ToLower());

            xmlWriter.WriteStartElement("journal_header".ToLower());

            xmlWriter.WriteElementString("SWID".ToLower(), "");
            xmlWriter.WriteElementString("STAT".ToLower(), "فعال");

            xmlWriter.WriteElementString("CREATED_USER".ToLower(), glb_function.glb_strUserId);
            xmlWriter.WriteElementString("branch_id".ToLower(),glb_function.glb_BranchNo.ToString());
            xmlWriter.WriteElementString("year_n".ToLower(),DateTime.Now.ToString("yyyy"));
            xmlWriter.WriteElementString("JOUR_DATE".ToLower(), DateTime.Now.ToString("dd/MM/yyyy"));
            xmlWriter.WriteElementString("exchange_in_date".ToLower(), "0");
            xmlWriter.WriteElementString("jour_details".ToLower(), "مصروف مشتريات" + " " + txtISSUED_TYPE.Text);

            ConnectionToDB conn = new ConnectionToDB();
            DataTable dtVochMax = conn.GetDataTable("select nvl( max(issued_id),0)+1 from journal_header where  issued_type='قيد مصروف مشتريات' and branch_id=" + glb_function.glb_BranchNo + " and year_n=" + DateTime.Now.ToString("yyyy"));
            string strIssueId = dtVochMax.Rows[0][0].ToString();
            xmlWriter.WriteElementString("issued_id".ToLower(), strIssueId);


            xmlWriter.WriteElementString("issued_type".ToLower(), "قيد مصروف مشتريات");











           

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();
            string strHeader = sbGetXml.ToString();
            return strHeader;
        }

        
        private decimal GetTotalMainValue()
        {
            decimal sum = 0;
            for (int i = 0; i < dgvPrecuremenExp.Rows.Count; i++)
            {
                if (dgvPrecuremenExp[clmSwid.Index, i].Value.ToString() == "")
                {
                    sum = sum + Convert.ToDecimal(dgvPrecuremenExp[clmMainValue.Index, i].Value.ToString());
                }

            }

            return sum;
        }
        string strDeptIssuAccId = "";
        private string GetJournalDetails()
        {
            DataTable dt = new DataTable();
            dt.TableName = "JOURNAL_DETAILS".ToLower();
            //dt.Columns.Add("swid");
            //dt.Columns.Add("credit");
            //dt.Columns.Add("dept");
            //dt.Columns.Add("JOUR_MAIN_VALUE".ToLower());
            //dt.Columns.Add("ACC_ID".ToLower());
            //dt.Columns.Add("CURR_ID".ToLower());
            //dt.Columns.Add("CURR_PRICE".ToLower());
            //dt.Columns.Add("COST_CENTER".ToLower());
            //dt.Columns.Add("JOUR_DETAILS".ToLower());
            //dt.Columns.Add("STAT".ToLower());
            //dt.Columns.Add("CURENT_CURR_PRICE".ToLower());


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

            //مدين
            ConnectionToDB cnn = new ConnectionToDB();
            if (txtISSUED_TYPE.Text == "تحاويل مخزنية")
            {
               
                DataTable dtInvoiceAccId = cnn.GetDataTable("select swid from accounts where system_acc_type='تحاويل مخزنية'");
                if (dtInvoiceAccId == null || dtInvoiceAccId.Rows.Count <= 0)
                {
                    glb_function.MsgBox("لايوجد حساب للمصاريف المخزنية" + "\n" + "سيتم اقفال الشاشة");
                    this.Close();
                }
                strDeptIssuAccId = dtInvoiceAccId.Rows[0][0].ToString();
            }
            else
            {
                
                DataTable dtInvoiceAccId = cnn.GetDataTable("select swid from accounts where system_acc_type='مصاريف مشتريات'");
                if (dtInvoiceAccId == null || dtInvoiceAccId.Rows.Count <= 0)
                {
                    glb_function.MsgBox("لايوجد حساب لمصاريف مشتريات" + "\n" + "سيتم اقفال الشاشة");
                    this.Close();
                }
                strDeptIssuAccId = dtInvoiceAccId.Rows[0][0].ToString();
            }

          DataTable  dtcurr = cnn.GetDataTable("select e.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL,e.override_value from currency c,currency_exchange e " +
                              " where e.curr_id = c.swid and c.swid = " + glb_function.glb_MainCurrencyId + " " +
                    " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");
            string Main_currency_exchange_id = dtcurr.Rows[0]["swid"].ToString();


            for (int i = 0; i < dgvPrecuremenExp.Rows.Count; i++)
            {
                if (dgvPrecuremenExp[clmSwid.Index, i].Value.ToString() == "")
                {
                    if (dgvPrecuremenExp[clmAddToCost.Index, i].Value.ToString() == "لا")
                    {
                        dt.Rows.Add(new Object[] { "",
                        "0",
                         dgvPrecuremenExp[clmMainValue.Index ,i].Value.ToString(),
                      dgvPrecuremenExp[clmMainValue.Index ,i].Value.ToString(),

                      dgvPrecuremenExp[clmAccId.Index ,i].Value.ToString(),
                         glb_function.glb_MainCurrencyId,
                         Main_currency_exchange_id,
                         "1",//currency price
                         "",//reference No
                           dgvPrecuremenExp[clmExpensessName.Index ,i].Value.ToString() ,
                         "",
                          "فعال"

                        });
                    }
                    else
                    {
                        dt.Rows.Add(new Object[] { "",
                        "0",
                         dgvPrecuremenExp[clmMainValue.Index ,i].Value.ToString(),
                      dgvPrecuremenExp[clmMainValue.Index ,i].Value.ToString(),

                      strDeptIssuAccId,
                         glb_function.glb_MainCurrencyId,
                         Main_currency_exchange_id,
                         "1",//currency price
                         "",//reference No
                           dgvPrecuremenExp[clmExpensessName.Index ,i].Value.ToString() ,
                         "",
                          "فعال"

                        });
                    }
                      
                }
                   
            }
          





           //دائن

            decimal dMainValue = GetTotalMainValue();
            decimal dVocherValue =Math.Round( dMainValue / dExchangeRate,iCurrDecimal);
            decimal dExchangeCredit = dMainValue / dVocherValue;


            dt.Rows.Add(new Object[] { "" ,
              dMainValue.ToString(),
             "0"  ,
            dVocherValue.ToString() ,
               lstAccNo.SelectedValue.ToString() ,
                lstCURRENCY_ID.SelectedValue.ToString(),
                iCurrSwid,
                  dExchangeCredit.ToString(),
                 "",
                 "",
                 "",
                  "فعال"

                });






            System.IO.StringWriter writer = new System.IO.StringWriter();
            dt.WriteXml(writer);
            string strDetails = writer.ToString();




            return strDetails;
        }
        private void FillAcc()
        {

            if (lstCURRENCY_ID.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار العملة اولا");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtAccData;
            string strAddationWhere = "";
            if (txtISSUED_TYPE.Text  == "اعتماد")
                strAddationWhere = "and a.swid != " +strLcAccId;

            dtAccData = cnn.GetDataTable("select a.swid,a.acc_no,a.acc_name " +
                          "  from accounts a " +
                          "  join acc_curr c on (c.acc_id = a.swid) " +
                           " where a.acc_class = N'فرعي' and a.ACC_TYPE like N'%%' and a.stat = N'فعال' " +strAddationWhere +
                           "  and c.curr_id =  " + lstCURRENCY_ID.SelectedValue.ToString());
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
        private void lstCURRENCY_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            if (lstCURRENCY_ID.SelectedValue == null)
                return;

            if (lstCURRENCY_ID.SelectedValue.ToString() != "System.Data.DataRowView" && lstCURRENCY_ID.SelectedValue.ToString() != "")
            {

                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
                                " where e.curr_id = c.swid and c.swid = " + lstCURRENCY_ID.SelectedValue.ToString() + " " +
                      " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

                iCurrSwid = dtcurr.Rows[0]["swid"].ToString();
                dExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
                iCurrDecimal = Convert.ToInt16(dtcurr.Rows[0]["CURR_DECIMAL"].ToString());
                nmbExpenssItem.DecimalPlaces = iCurrDecimal;
                nmbCURR_PRICE.Value = dExchangeRate;
                GetExpensess();
                FillAcc();
            }
        }

        private void nmbExpenssItem_Leave(object sender, EventArgs e)
        {
            if (nmbExpenssItem.Value == 0)
            {
                nmbCURR_PRICE.Value = dExchangeRate;
                nmbCASHER_MAIN_VALUE.Value = 0;

              


            }
            else
            {



               
                nmbCASHER_MAIN_VALUE.Value = nmbExpenssItem.Value * dExchangeRate;

                //to calculate diff Friction 
                nmbCURR_PRICE.Value = nmbCASHER_MAIN_VALUE.Value / nmbExpenssItem.Value;
            }
            }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;

              
                    


            }
        }

       
    }
}
