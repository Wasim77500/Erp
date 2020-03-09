using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmPurchaseBillVoucher : ERP.MyForm
    {
        private string strImportId;
        private decimal dExchangeRate;
        string  iCurrSwid;
        private short iCurrDecimal;

        public frmPurchaseBillVoucher()
        {
            InitializeComponent();
        }

        private void frmPurchaseBillVoucher_Load(object sender, EventArgs e)
        {
            glb_function.FillListWithId(ref lstCURRENCY_ID, "currency", "curr_name");
            bLoadExp = false ;
        }

        bool bLoadExp = true   ;
        private void btnFindBillPurchase_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            bLoadExp = true;
            frmGetPurchaseBill frm = new frmGetPurchaseBill();
          
                frm.strWhere = " and h.stat='تاكيد' ";

            frm.ShowDialog();

            txtSwid.Text = frm.strBillSwid;

            if (txtSwid.Text != "")
            {
                GetData(txtSwid.Text);
            }
            bLoadExp = false ;
        }

        private void GetData(string strBillSwid)
        {




            txtSwid.Text = strBillSwid;
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBill = cnn.GetDataTable("select h.swid, bill_number, to_char(bill_date,'dd/mm/yyyy') bill_date," +
                " bill_type, bill_supplier_number, " +
                    " supplier_id, terms_of_expenses_id, purchase_agreement, " +
                    "  currency_id, imports_id " +
                     " from purchases_bill h " +
                   " where h.swid = " + txtSwid.Text);


            //clear function in lstCurrency_changeindex event 

            lstBILL_TYPE.Text = dtBill.Rows[0]["bill_type"].ToString();
            txtSUPPLIER_ID.Text = dtBill.Rows[0]["supplier_id"].ToString();
            GetVendorData(txtSUPPLIER_ID.Text);
            lstCURRENCY_ID.SelectedValue = Convert.ToInt16(dtBill.Rows[0]["currency_id"].ToString());
            txtSwid.Text = strBillSwid;

            strImportId = dtBill.Rows[0]["imports_id"].ToString();

           

            txtBILL_NUMBER.Text = dtBill.Rows[0]["bill_number"].ToString();

         

          
      

           

           


            




            dtBill.Clear();

            dtBill = cnn.GetDataTable("select nvl(sum(d.quantity*d.price),0) total from purchases_bill_details d where  d.header_id = " + txtSwid.Text);

            nmbInvoicTotal.Value =Convert.ToDecimal( dtBill.Rows[0][0].ToString());



            dtBill.Clear();
            dtBill = cnn.GetDataTable("select ex.swid, ex.expenses_id,ex.expenses_value,itmEx.Expenses_Name,Acc_Id " +
                "from PURCHASE_Expenses ex,EXPENSES_ITEM itmEx " +
                           " where ex.expenses_id = itmEx.Swid and  ex.expensess_type = 'فاتورة شراء' " +
                           " and ex.header_id = " + txtSwid.Text);


            for (int i = 0; i < dtBill.Rows.Count; i++)
            {
                dgExpenss.Rows.Add();
                dgExpenss[0, i].Value = false;
                dgExpenss[1, i].Value = dtBill.Rows[i]["swid"].ToString();
                dgExpenss[2, i].Value = dtBill.Rows[i]["expenses_id"].ToString();
                dgExpenss[3, i].Value = dtBill.Rows[i]["Expenses_Name"].ToString();
                dgExpenss[4, i].Value = dtBill.Rows[i]["expenses_value"].ToString();
                dgExpenss[5, i].Value = dtBill.Rows[i]["Acc_Id"].ToString();
            }


            SumExpTotal();


            nmbTotalWithExp.Value = nmbInternalExp.Value + nmbInvoicTotal.Value;
            if(lstBILL_TYPE.Text =="نقد")
            {
                lstAccName.Visible = true;
                lstAccNo.Visible = true;
                lblAccName.Visible = true;
                lblAccNo.Visible = true;

            }

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


            dtAccData = cnn.GetDataTable("select a.swid,a.acc_no,a.acc_name " +
                          "  from accounts a " +
                          "  join acc_curr c on (c.acc_id = a.swid) " +
                           " where a.acc_class = N'فرعي' and a.ACC_TYPE like N'%%' and a.stat = N'فعال' " +
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
        private void SumExpTotal()
        {
            decimal dSum = 0;
            for (int i = 0; i < dgExpenss.Rows.Count; i++)
            {
              
                dSum = dSum + Convert.ToDecimal(dgExpenss[4, i].Value);

            }

           nmbInternalExp.Value = Math.Round(dSum, nmbInvoicTotal.DecimalPlaces);

        }
        private void GetVendorData(string strVendorId)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtVendor = cnn.GetDataTable("select p_name,acc_id from people where swid=" + strVendorId);

            txtSUPPLIER_Name.Text = dtVendor.Rows[0]["p_name"].ToString();
            iVendorAcc=Convert.ToInt16( dtVendor.Rows[0]["acc_id"].ToString());

        }

        int iVendorAcc;
        private void lstCURRENCY_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //new glb_function().clearItems(this);
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
                nmbCURRENCY_EXCHANGE.Value = dExchangeRate;
                nmbInvoicTotal.DecimalPlaces = iCurrDecimal;
                nmbTotalExp.DecimalPlaces = iCurrDecimal;
                nmbTotalWithExp.DecimalPlaces = iCurrDecimal;
                lstAccNo.Enabled = true ;
                lstAccName.Enabled = true ;
                FillAcc();

                if(lstBILL_TYPE.Text.Trim()== "اجل")
                {
                    lstAccNo.SelectedValue = iVendorAcc;
                    lstAccNo.Enabled = false;
                    lstAccName.Enabled = false;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(lstBILL_TYPE.Text =="نقد" && lstAccNo.SelectedIndex==-1  )
            {
                glb_function.MsgBox("الرجاء اختيار الحساب");
                return;
            }

            string strJournalId = "";
            int icheck = 0;

            ConnectionToDB cnn = new ConnectionToDB();
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
            //ConnectionToDB.objCmd.Parameters.Add("xml_journal_header", Oracle.ManagedDataAccess.Client.OracleDbType.XmlType).Value = strHeader;
            //ConnectionToDB.objCmd.Parameters.Add("xml_journal_details", Oracle.ManagedDataAccess.Client.OracleDbType.XmlType).Value = strDetails.Replace("DocumentElement", "DocumentElement".ToLower());
            //ConnectionToDB.objCmd.Parameters.Add("sqlStat", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = "";
            //ConnectionToDB.objCmd.Parameters.Add("strHash", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = "";
            //ConnectionToDB.objCmd.Parameters.Add("icheck", Oracle.ManagedDataAccess.Client.OracleDbType.Int16).Value = 1;
            //ConnectionToDB.objCmd.Parameters.Add("swid", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
            //ConnectionToDB.objCmd.Parameters.Add("Result", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;

            string strResult = cnn.ExecutePro("AccountsPack.journal_inser_update", "Result");
            strJournalId = ConnectionToDB.objCmd.Parameters["swid"].Value.ToString();
            if (strResult.ToUpper() != "SUCCEED")
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية الحفظ");
                return;
            }



            if(nmbTotalExp.Value >0)
            {
                for (int i = 0; i < dgExpenss.Rows.Count; i++)
                {
                    if (dgExpenss[clmSelectedExpCkb.Index, i].Value.ToString() == "True")
                    {
                        icheck = cnn.TranDataToDB("insert into PROCUREMENT_EXPENSES values((select nvl(max(swid),0)+1 from PROCUREMENT_EXPENSES),sysdate," + glb_function.glb_strUserId + ",'فعال','" +
                           "وارد" + "'," + strImportId + "," + ("null") +
                            "," + dgExpenss[clmExpExpenssItemId.Index, i].Value.ToString() + "," + dgExpenss[clmExpValue.Index, i].Value.ToString() + "," +
                            "" + strJournalId + ",'" +
                            "مصاريف داخلية لفاتورة رقم:" + txtBILL_NUMBER.Text  + "','" +
                           "" + "','" +
                            "نعم" + "'," + dgExpenss[clmExpValue.Index, i].Value.ToString() + ",'" + lstCURRENCY_ID.SelectedValue.ToString() + "','" + lstCURRENCY_ID.SelectedValue.ToString() + "')");

                        if (icheck <= 0)
                        {
                            cnn.glb_RollbackTransaction();
                            glb_function.MsgBox("حدث خطأ عند عملية الحفظ");
                            return;
                        }
                    }
                }

            }

            if(nmbInternalExp.Value >0)
            {
                DataTable dtInvoiceDetail = cnn.GetDataTable("select swid, " +
                                      " decode(d.quantity, 0, 0, (((d.quantity * d.price) / (select sum(s.quantity * s.price) from purchases_bill_details s where s.header_id = " + txtSwid.Text + ") * 100) * " + nmbInternalExp.Value.ToString() + " / 100)/ d.quantity) internal_exp" +
                                      " from purchases_bill_details d " +
                                      " where d.header_id =  " + txtSwid.Text);

                for (int i = 0; i < dtInvoiceDetail.Rows.Count; i++)
                {
                    icheck = cnn.TranDataToDB("update purchases_bill_details set internal_exp=" + dtInvoiceDetail.Rows[i]["internal_exp"].ToString() + " where swid=" + dtInvoiceDetail.Rows[i]["swid"].ToString());

                    if (icheck <= 0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ عند عملية الحفظ");
                        return;
                    }
                }
              

            }

            //Get stock exchange value and decimal
            decimal dMainValue = Math.Round(nmbTotalWithExp.Value * nmbCURRENCY_EXCHANGE.Value, glb_function.glbMainDecimalPoint);
            DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
                            " where e.curr_id = c.swid and c.swid = (select swid from currency sc where sc.is_stock_curr=1) " +
                  " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");


           decimal dStockExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());


          nmbTotalInvoiceInStockCurr.Value  = (nmbTotalInvoiceInMainCurr.Value / dStockExchangeRate);

            //*******************************


            icheck = cnn.TranDataToDB("update  purchases_bill set stat='مقيد' ,TOTAL_VALUE_IN_STOCK_CURR =" + nmbTotalInvoiceInStockCurr.Value.ToString() + ",TOTAL_VALUE_IN_BILL_CURR="+nmbTotalInvoiceInInvoiceCurr.Value.ToString()+ ",TOTAL_VALUE_IN_MAIN_CURR="+nmbTotalInvoiceInMainCurr.Value.ToString()+"  where swid=" + txtSwid.Text +"");
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ عند عملية الحفظ");
                return;
            }


            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الحفظ بنجاح");
        }

        private string GetJournalHeader()
        {

            StringBuilder sbGetXml = new StringBuilder();
            System.Xml.XmlWriter xmlWriter = System.Xml.XmlWriter.Create(sbGetXml);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("DocumentElement".ToLower());

            xmlWriter.WriteStartElement("journal_header".ToLower());

            xmlWriter.WriteElementString("SWID".ToLower(), "");

            xmlWriter.WriteElementString("STAT".ToLower(), "فعال");

            xmlWriter.WriteElementString("CREATED_USER".ToLower(), glb_function.glb_strUserId);

            xmlWriter.WriteElementString("branch_id".ToLower(), glb_function.glb_BranchNo.ToString());

            xmlWriter.WriteElementString("year_n".ToLower(), DateTime.Now.ToString("yyyy"));
            xmlWriter.WriteElementString("JOUR_DATE".ToLower(), DateTime.Now.ToString("dd/MM/yyyy"));

           

            xmlWriter.WriteElementString("exchange_in_date".ToLower(), "0");
            xmlWriter.WriteElementString("jour_details".ToLower(), "من فاتورة رقم" + " " + txtBILL_NUMBER.Text);



                ConnectionToDB conn = new ConnectionToDB();
                DataTable dtVochMax = conn.GetDataTable("select nvl( max(issued_id),0)+1 from journal_header where  issued_type='فاتورة شراء' and branch_id=" + glb_function.glb_BranchNo + " and year_n=" + DateTime.Now.ToString("yyyy"));
                string strIssueId = dtVochMax.Rows[0][0].ToString();
                xmlWriter.WriteElementString("issued_id".ToLower(), strIssueId);


            

            xmlWriter.WriteElementString("issued_type".ToLower(), "فاتورة شراء");




            //xmlWriter.WriteElementString("SWID".ToLower(), "");

            //xmlWriter.WriteElementString("CREATED_USER".ToLower(), glb_function.glb_strUserId);

            //xmlWriter.WriteElementString("STAT".ToLower(), "فعال");

            //xmlWriter.WriteElementString("JOUR_NUM".ToLower(), "");

            //xmlWriter.WriteElementString("VOCH_TYPE".ToLower(), "فاتورة شراء");




            //xmlWriter.WriteElementString("VOCH_NO".ToLower(), txtSwid.Text );


            //xmlWriter.WriteElementString("VOCH_NO_M".ToLower(), "");
            //xmlWriter.WriteElementString("JOUR_DATE".ToLower(), DateTime.Now.ToString("dd/MM/yyyy"));

            //xmlWriter.WriteElementString("JOUR_DETAILS_Header".ToLower(), "من فاتورة رقم" + " " + txtBILL_NUMBER.Text);

            //xmlWriter.WriteElementString("BranchHeader".ToLower(), glb_function.glb_BranchNo.ToString());



            //xmlWriter.WriteElementString("MODEL_NO".ToLower(), lstTemplet.SelectedValue.ToString());

            //decimal dMainValue = Math.Round(nmbTotalWithExp.Value * nmbCURRENCY_EXCHANGE.Value , glb_function.glbMainDecimalPoint);
            //xmlWriter.WriteElementString("JOUR_VALUE".ToLower(), dMainValue.ToString());
            //xmlWriter.WriteElementString("ORDER_ID".ToLower(), "");
            //xmlWriter.WriteElementString("CONTACT_ID".ToLower(), "");
            //xmlWriter.WriteElementString("NOTE_NO".ToLower(), "1");
            //xmlWriter.WriteElementString("COLLECTOR_ID".ToLower(), "");
            //xmlWriter.WriteElementString("CONTACT_NAME".ToLower(), "");
            //xmlWriter.WriteElementString("REVERSE_VOCHER_ID".ToLower(), "");


            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();
            string strHeader = sbGetXml.ToString();
            return strHeader;
        }
        private string GetJournalDetails()
        {
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

            string strAccid = "";
            //if invoice get account from بضاعة في الطريق
           
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtInvoiceAccId = cnn.GetDataTable("select swid from accounts where system_acc_type='بضاعة في الطريق'");
                if (dtInvoiceAccId == null || dtInvoiceAccId.Rows.Count <= 0)
                {
                    glb_function.MsgBox("لايوجد حساب لبضاعة في الطريق" + "\n" + "سيتم اقفال الشاشة");
                    this.Close();
                }
                strAccid = dtInvoiceAccId.Rows[0][0].ToString();
           


            decimal dMainValue = Math.Round(nmbCURRENCY_EXCHANGE.Value * nmbTotalWithExp.Value, glb_function.glbMainDecimalPoint);


            DataTable dtcurr = cnn.GetDataTable("select e.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL,e.override_value from currency c,currency_exchange e " +
                            " where e.curr_id = c.swid and c.swid = " + glb_function.glb_MainCurrencyId + " " +
                  " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");
            string Main_currency_exchange_id = dtcurr.Rows[0]["swid"].ToString();

            //مدين
            dt.Rows.Add(new Object[] { "",
                        "0",
                         dMainValue.ToString(),
                     dMainValue.ToString(),

                      strAccid ,
                       glb_function.glb_MainCurrencyId ,
                       Main_currency_exchange_id,
                       "1",
                          "" ,
                         "",
                          "",
                          "فعال"

                        });

            //post expensses to to import expensses
            if (nmbTotalExp.Value > 0)
            {
                decimal dMainExp = 0;

                //مدين
                for (int i = 0; i < dgExpenss.Rows.Count; i++)
                {
                    if (dgExpenss[clmSelectedExpCkb.Index, i].Value.ToString() == "True")
                    {
                         dMainExp =Math.Round( Convert.ToDecimal(dgExpenss[clmExpValue.Index, i].Value.ToString()) * nmbCURRENCY_EXCHANGE.Value, glb_function.glbMainDecimalPoint);


                dt.Rows.Add(new Object[] { "",
                        "0",
                         dMainExp,
                      dMainExp,

                      dgExpenss[clmAccId.Index ,i].Value.ToString(),
                         glb_function.glb_MainCurrencyId,
                         Main_currency_exchange_id,
                          "1",
                          "" ,
                         "",
                          "",
                          "فعال"

                        });

                        dMainValue += dMainExp;
                    }

                    

                }




               
            }

            string strCreditId = "";
            //دائن
            if (lstBILL_TYPE.Text =="نقد")
            {
                strCreditId = lstAccNo.SelectedValue.ToString();
            }
            else
            {
                //get vendor accNo from People table


                DataTable dtVendAccId = cnn.GetDataTable("select p.acc_id from people p where p.swid="+txtSUPPLIER_ID.Text );
                if (dtVendAccId == null || dtVendAccId.Rows.Count <= 0)
                {
                    glb_function.MsgBox("لايوجد حساب لهذا المورد" + "\n" + "سيتم اقفال الشاشة");
                    this.Close();
                }
                strCreditId = dtVendAccId.Rows[0][0].ToString();
            }

            nmbTotalInvoiceInInvoiceCurr.Value = nmbTotalWithExp.Value + nmbTotalExp.Value;
            nmbTotalInvoiceInMainCurr.Value = dMainValue;

            dt.Rows.Add(new Object[] { "" ,
             dMainValue.ToString(),
             "0"  ,
           nmbTotalInvoiceInInvoiceCurr.Value.ToString() ,
               strCreditId .ToString() ,
                 lstCURRENCY_ID.SelectedValue .ToString(),
                 iCurrSwid,
                 dExchangeRate.ToString(),
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

        private void dgExpenss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         


            
        }

        private void dgExpenss_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (bLoadExp == true)
                return;

            if (e.RowIndex >= 0 && e.ColumnIndex == clmSelectedExpCkb.Index )
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dgExpenss.CurrentCell;
                bool isChecked = (bool)checkbox.EditedFormattedValue;
                if (isChecked)
                {
                    nmbTotalExp.Value = nmbTotalExp.Value +Convert.ToDecimal( dgExpenss[clmExpValue.Index, e.RowIndex].Value.ToString());
                    nmbInternalExp.Value = nmbInternalExp.Value - Convert.ToDecimal(dgExpenss[clmExpValue.Index, e.RowIndex].Value.ToString());
                    nmbTotalWithExp.Value = nmbInvoicTotal.Value + nmbInternalExp.Value;
                }
                else
                {
                    nmbTotalExp.Value = nmbTotalExp.Value -Convert.ToDecimal(dgExpenss[clmExpValue.Index, e.RowIndex].Value.ToString());
                    nmbInternalExp.Value = nmbInternalExp.Value + Convert.ToDecimal(dgExpenss[clmExpValue.Index, e.RowIndex].Value.ToString());
                    nmbTotalWithExp.Value = nmbInvoicTotal.Value + nmbInternalExp.Value;
                }
            }
        }

        private void dgExpenss_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgExpenss.IsCurrentCellDirty && dgExpenss.CurrentCell.ColumnIndex == clmSelectedExpCkb.Index )
            {
                dgExpenss.EndEdit();
            }
        }

        private void lstBILL_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
