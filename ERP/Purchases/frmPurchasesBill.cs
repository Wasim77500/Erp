using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmPurchasesBill : ERP.MyForm
    {
        private decimal dMaxRate;
        private decimal dMinRate;
        private decimal dExchangeRate;
        private short iCurrDecimal;
        public string strImportNo = "";
        public string strThisFormFromWhere="";
        public frmPurchasesBill()
        {
            InitializeComponent();
        }

        private void myGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddExpeness_Click(object sender, EventArgs e)
        {
            if (txtSwid.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار الفاتورة");
                return;
            }
            if (lstCURRENCY_ID.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار العملة");
                return;
            }

            frmPrecurementExpensess frm = new frmPrecurementExpensess();
            frm.txtISSUED_ID.Text = txtSwid.Text;
            frm.txtISSUED_TYPE.Text = "فاتورة";
            frm.txtTempletId.Text = lstTemplet.SelectedValue.ToString();
          
            frm.ShowDialog();
        }

        private void btnGetVendor_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceDetail.Rows.Count > 0 || txtPurchaseOrderHeaderId.Text .Trim()!="")
            {
                if (glb_function.MsgBox("سيتم مسح كافة البيانات السابقة" +"\n"+"هل انت متاكد من اتمام العملية؟", "", true) == false)
                    return;
                new glb_function().clearItems(this);

                PrepareForm();
            }
              


            frmFindVendor frm = new frmFindVendor();

            frm.ShowDialog();

            if (frm.strVendorID.Trim() != "")
            {
                txtSUPPLIER_ID.Text = frm.strVendorID;
                GetVendorData(txtSUPPLIER_ID.Text);
            }

        }
        
        private void GetVendorData(string strVendorId)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtVendor = cnn.GetDataTable("select p_name from people where swid=" + strVendorId);

            txtSUPPLIER_Name.Text = dtVendor.Rows[0]["p_name"].ToString();

        }

        private void frmPurchasesBill_Load(object sender, EventArgs e)
        {
            lblTemplet.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Side;
            PrepareForm();
        }
        private void PrepareForm()
        {
            

            btnUpdate.Enabled = false;
            btnConfirm.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;

            glb_function.FillListWithId(ref lstCURRENCY_ID, "currency", "curr_name");
          
           
        }

        private void lstCURRENCY_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCURRENCY_ID.SelectedValue == null)
                return;

            if (lstCURRENCY_ID.SelectedValue.ToString() != "System.Data.DataRowView" && lstCURRENCY_ID.SelectedValue.ToString() != "")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtcurr = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL from currency c,currency_exchange e " +
                                " where e.curr_id = c.swid and c.swid = " + lstCURRENCY_ID.SelectedValue.ToString() + " " +
                      " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

                dMaxRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MAX"].ToString());
                dMinRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MIN"].ToString());
                dExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
                iCurrDecimal = Convert.ToInt16(dtcurr.Rows[0]["CURR_DECIMAL"].ToString());

              
                nmbExpenssItem.DecimalPlaces = nmbTotal.DecimalPlaces = nmbExpEditor.DecimalPlaces = nmbUNIT_PRICE.DecimalPlaces = nmbFakePrice.DecimalPlaces = iCurrDecimal;


            }
        }

        private void btnGetExpenssTerm_Click(object sender, EventArgs e)
        {
            frmFindExpTerms frm = new frmFindExpTerms();

            frm.ShowDialog();

            if (frm.strExpTermID.Trim() != "")
            {
                txtTERMS_EXPENSES_ID.Text = frm.strExpTermID;
                GetTermsExpensess(txtTERMS_EXPENSES_ID.Text);
                LoadExpenssessDetail(txtTERMS_EXPENSES_ID.Text);
            }
        }
        private void LoadExpenssessDetail(string strTermHeaderId)
        {

           


            dgExpenss.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtExpDetail = cnn.GetDataTable("select ex.swid,ex.expenses_id,ex.expenses_value,itmEx.Expenses_Name " +
               " from PURCHASE_Expenses ex,EXPENSES_ITEM itmEx " +
                          " where ex.expenses_id = itmEx.Swid and  ex.expensess_type = 'امر الشراء' " +
                          " and ex.header_id = " + strTermHeaderId);

            for (int i = 0; i < dtExpDetail.Rows.Count; i++)
            {
                dgExpenss.Rows.Add();
                dgExpenss[0, i].Value = dtExpDetail.Rows[i]["swid"].ToString();
                dgExpenss[1, i].Value = dtExpDetail.Rows[i]["expenses_id"].ToString();
                dgExpenss[2, i].Value = dtExpDetail.Rows[i]["Expenses_Name"].ToString();
                dgExpenss[3, i].Value = dtExpDetail.Rows[i]["expenses_value"].ToString();
            }


        }

        private void GetTermsExpensess(string strTermSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTerm = cnn.GetDataTable("select  TERMS_NAME from TERMS_EXPENSES_HEADER where swid= " + strTermSwid);
            txtTERMS_OF_EXPENSES_name.Text = dtTerm.Rows[0][0].ToString();
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
            DataTable dtExpenss = cnn.GetDataTable("select swid,expenses_name from EXPENSES_ITEM where swid=" + strExpSwid);
            txtEXPENSES_ID.Text = dtExpenss.Rows[0]["swid"].ToString();
            txtEXPENSES_Name.Text = dtExpenss.Rows[0]["expenses_name"].ToString();
        }

        private void myBottun6_Click(object sender, EventArgs e)
        {
            if (txtEXPENSES_ID.Text.Trim() == "" || txtEXPENSES_Name.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار المصروف اولا");
                btnGetExpenss.Focus();
                return;
            }
            if (nmbExpenssItem.Value <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال قيمة للمصروف");
                nmbExpenssItem.Focus();
                return;
            }

            dgExpenss.Rows.Add();
            dgExpenss[0, dgExpenss.Rows.Count - 1].Value = "";
            dgExpenss[1, dgExpenss.Rows.Count - 1].Value = txtEXPENSES_ID.Text.Trim();
            dgExpenss[2, dgExpenss.Rows.Count - 1].Value = txtEXPENSES_Name.Text.Trim();
            dgExpenss[3, dgExpenss.Rows.Count - 1].Value = nmbExpenssItem.Value.ToString();

            txtEXPENSES_ID.Text = "";
            txtEXPENSES_Name.Text = "";
            nmbExpenssItem.Value = 0;
        }

        private void nmbExpEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void nmbExpEditor_Leave(object sender, EventArgs e)
        {
            if (nmbExpEditor.Visible == true)
            {
                nmbExpEditor.Visible = false;

                dgExpenss[clmExpValue.Index, dgExpenss.CurrentRow.Index].Value = nmbExpEditor.Value.ToString();


            }
        }

        private void dgExpenss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            if (e.ColumnIndex == 4)
                dgExpenss.Rows.Remove(dgExpenss.Rows[e.RowIndex]);
            else if (clmExpValue.Index == e.ColumnIndex)
            {


               
                DataGridViewCell abc = dgExpenss.CurrentCell;
                Rectangle RECT = dgExpenss.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
               


                nmbExpEditor.W_ColEgName = e.ColumnIndex.ToString();
                nmbExpEditor.DecimalPlaces = nmbUNIT_PRICE.DecimalPlaces;
                nmbExpEditor.Tag = e.RowIndex.ToString();



                nmbExpEditor.Value = Convert.ToDecimal(dgExpenss[clmExpValue.Index, e.RowIndex].Value.ToString());






                CtlLocationExp(RECT, nmbExpEditor);
            }
        }
        private void CtlLocationExp(Rectangle rect, Control ctrl)
        {

            // ctrl.Location = dgvPurQuotDetail.PointToScreen(dgvPurQuotDetail.GetCellDisplayRectangle(icolumnindex, irowindex, true ).Location);
            ctrl.Top = dgExpenss.Location.Y + rect.Y;
            ctrl.Left = dgExpenss.Location.X + rect.X;

            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;

            ctrl.Focus();


        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            if (txtSUPPLIER_ID.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار المورد");
                return;
            }
            Inventory.frmFindItem frm = new Inventory.frmFindItem();

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtItemId.Text = frm.strItemID;
                GetItemData(txtItemId.Text);

            }
        }
        private void GetItemData(string strItemSwid)
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems = cnn.GetDataTable("select item_no,item_name from items where swid=" + strItemSwid);

            txtItemNo.Text = dtItems.Rows[0]["item_no"].ToString();
            txtItemName.Text = dtItems.Rows[0]["item_name"].ToString();


        }

        private void btnGetSupplierItem_Click(object sender, EventArgs e)
        {
            if (txtSUPPLIER_ID.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار المورد");
                return;
            }
            frmFindItemSupplier frm = new frmFindItemSupplier();
            frm.txtPeopleId.Text = txtSUPPLIER_ID.Text;
            frm.txtVendorName.Text = txtSUPPLIER_Name.Text;
            frm.ShowDialog();

            if (frm.strItemSupplier_id.Trim() != "")
            {
                txtITEM_SUPPLIER_Id.Text = frm.strItemSupplier_id;
                GetSuplierItemData(txtITEM_SUPPLIER_Id.Text);

            }
        }
        private void GetSuplierItemData(string strSuplierSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtSupllierItems = cnn.GetDataTable("select swid,item_no,Item_name From item_supplier where swid=" + strSuplierSwid);

            txtITEM_SUPPLIER_NUMBER.Text = dtSupllierItems.Rows[0]["item_no"].ToString();
            txtITEM_SUPPLIER_NAME.Text = dtSupllierItems.Rows[0]["Item_name"].ToString();
        }

        private void btnGetPurchaseOrderD_Click(object sender, EventArgs e)
        {
            if(txtSUPPLIER_ID.Text .Trim()=="")
            {
                glb_function.MsgBox("الرجاء اختيار المورد");
                return;
            }
            Purchases.frmGetPurchaseOrder frm = new Purchases.frmGetPurchaseOrder();
             frm.strWhere = " and h.stat in ('فعال')  and h.supplier_id= " + txtSUPPLIER_ID.Text ;
            frm.ShowDialog();

            txtPurchaseOrderDetailId.Text = frm.strOrderSwid;
            txtPurchaseOrderNoD.Text = frm.strOrderNum;
        }

        private void btnGetPurchaseOrder_Click(object sender, EventArgs e)
        {
            if (txtSUPPLIER_ID.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار المورد");
                return;
            }
            Purchases.frmGetPurchaseOrder frm = new Purchases.frmGetPurchaseOrder();
            frm.strWhere = " and h.stat in ('فعال')  and h.supplier_id= " + txtSUPPLIER_ID.Text;
            frm.ShowDialog();

            if(frm.strOrderSwid.Trim()!="")
            {
                txtPurchaseOrderHeaderId.Text = frm.strOrderSwid;
                txtPURCHASE_ORDER_NUM.Text = frm.strOrderNum;


                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtPurchaseOrder= cnn.GetDataTable("select swid, " +
                        " supplier_id, purchase_order_num, shipping_way, " +
                        "  proforma_invoice_num, proforma_invoice_date, " +
                        "  purchase_order_date, currency_id, currency_exchange, " +
                       "    payment_agreement, terms_expenses_id, port_of_loading, port_of_delivery, " +
                       "  letter_credit_id, purchase_quotations_id " +
                       "  from purchases_order_header h " +
                       "  where h.swid = " + txtPurchaseOrderHeaderId.Text);

                txtTERMS_EXPENSES_ID.Text = dtPurchaseOrder.Rows[0]["terms_expenses_id"].ToString();
                GetTermsExpensess(txtTERMS_EXPENSES_ID.Text.Trim());
                LoadExpenssessDetail(txtPurchaseOrderHeaderId.Text );
                lstCURRENCY_ID.SelectedValue = dtPurchaseOrder.Rows[0]["currency_id"].ToString();
                lstCURRENCY_ID.Enabled = false;


                LoadOrderItems();
            }
           
          
        }
        private void LoadOrderItems()
        {

            ConnectionToDB cnn = new ConnectionToDB();
           
             DataTable dtInvoiceDetail = cnn.GetDataTable("select d.swid,d.item_id,i.item_name,d.item_supplier_id,item_sup.item_no," +
                                  " item_sup.item_name item_supplier_name,item_sup.item_info," +
                                 "   d.qty, d.free_qty, d.unit_price, d.total_stock,d.qty-(select nvl(sum( oq.quantity),0) from purchases_bill_details oq where oq.order_purchases_de_id=d.swid) reminedQty" +
                                "    from purchases_order_details d" +
                                 "    join items i on (d.item_id = i.swid)" +
                                 "    join item_supplier item_sup on (d.item_supplier_id = item_sup.swid)" +
                                  " and  d.header_id = " + txtPurchaseOrderHeaderId.Text + " and d.qty-(select nvl(sum( oq.quantity),0) from purchases_bill_details oq where oq.order_purchases_de_id=d.swid)>0");
            //*check if order item added 
            bool deleteAll = false ;
            for (int i = 0; i < dgvInvoiceDetail.Rows.Count; i++)
            {
                for (int j = 0; j < dtInvoiceDetail.Rows.Count; j++)
                {
                  if(  dgvInvoiceDetail[clmPurchaseOrderid.Index, i].Value.ToString()== dtInvoiceDetail.Rows[j]["swid"].ToString())
                    {
                        if (deleteAll)
                        {
                            dgvInvoiceDetail.Rows.Remove(dgvInvoiceDetail.Rows[i]);
                            i--;
                            break;
                        }

                        else
                        {
                            if (glb_function.MsgBox("يوجد اصناف مدخلة لهذا الامر من قبل" +"\n"+"هل تريد حذفها؟", "", true) == false)
                                 return;
                            else
                            {
                                dgvInvoiceDetail.Rows.Remove(dgvInvoiceDetail.Rows[i]);
                                deleteAll = true;
                                i--;
                                break;
                            }
                             
                        }
                            
                    }
                }
            }
            //*****************************
            for (int i = 0; i < dtInvoiceDetail.Rows.Count; i++)
            {
               
                dgvInvoiceDetail.Rows.Add();

                dgvInvoiceDetail[clmSwid.Index, dgvInvoiceDetail.Rows.Count -1].Value = "";
                dgvInvoiceDetail[clmPurchaseOrderid.Index , dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["swid"].ToString();
                dgvInvoiceDetail[clmItemId.Index , dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["item_id"].ToString();
                dgvInvoiceDetail[clmItemName.Index , dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["item_name"].ToString();
                dgvInvoiceDetail[clmSupplierItemId.Index , dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["item_supplier_id"].ToString();
                dgvInvoiceDetail[clmSupplierItemNo.Index , dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["item_no"].ToString();
                dgvInvoiceDetail[clmSupplierItemName.Index, dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["item_supplier_name"].ToString();
                dgvInvoiceDetail[clmSupplierItemInf.Index , dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["item_info"].ToString();

                //string strUserQTy = (dtInvoiceDetail.Rows[i]["usedQty"].ToString() == "" ? "0" : dtInvoiceDetail.Rows[i]["usedQty"].ToString() );
                //string strOrderQty= dtInvoiceDetail.Rows[i]["reminedQty"].ToString();
                dgvInvoiceDetail[clmOrderQty.Index, dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["reminedQty"].ToString();

                dgvInvoiceDetail[clmFreeQty.Index , dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["free_qty"].ToString();
                dgvInvoiceDetail[clmDetailUnitPrice.Index , dgvInvoiceDetail.Rows.Count -1].Value = dtInvoiceDetail.Rows[i]["unit_price"].ToString();
                dgvInvoiceDetail[clmInvoiceQty.Index, dgvInvoiceDetail.Rows.Count -1].Value = "0";
                dgvInvoiceDetail[clmFakePrice.Index, dgvInvoiceDetail.Rows.Count -1].Value = "0";
               dgvInvoiceDetail[clmTotalPrice.Index , dgvInvoiceDetail.Rows.Count -1].Value =Math.Round( Convert.ToDouble(dgvInvoiceDetail[clmInvoiceQty.Index, dgvInvoiceDetail.Rows.Count -1].Value) * Convert.ToDouble(dgvInvoiceDetail[clmDetailUnitPrice.Index , dgvInvoiceDetail.Rows.Count -1].Value),iCurrDecimal);
                dgvInvoiceDetail[clmBoxNo.Index, dgvInvoiceDetail.Rows.Count - 1].Value = "";

            }
            SumTotal();
        }
        private void SumTotal()
        {
            decimal dSum = 0;
            for (int i = 0; i < dgvInvoiceDetail.Rows.Count; i++)
            {
                dgvInvoiceDetail[clmTotalPrice.Index, i].Value = Convert.ToDecimal(dgvInvoiceDetail[clmInvoiceQty.Index, i].Value) * Convert.ToDecimal(dgvInvoiceDetail[clmDetailUnitPrice.Index, i].Value);
                dSum = dSum + Convert.ToDecimal(dgvInvoiceDetail[clmTotalPrice.Index, i].Value);

            }

            nmbTotal.Value = Math.Round(dSum, nmbTotal.DecimalPlaces);

        }

        private void btnGetPurchaseBill_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckDetailEntries())
                return;
            dgvInvoiceDetail.Rows.Add();


            //dgvInvoiceDetail[clmPurchaseOrderid.Index, dgvInvoiceDetail.Rows.Count - 1].Value = "";
            //dgvInvoiceDetail[clmOrderQty.Index, dgvInvoiceDetail.Rows.Count - 1].Value = dtInvoiceDetail.Rows[i]["qty"].ToString();

           
            dgvInvoiceDetail[clmSwid.Index, dgvInvoiceDetail.Rows.Count - 1].Value = "";
            dgvInvoiceDetail[clmItemId.Index, dgvInvoiceDetail.Rows.Count - 1].Value = txtItemId.Text ;
            dgvInvoiceDetail[clmItemName.Index, dgvInvoiceDetail.Rows.Count - 1].Value = txtItemName.Text ;
            
            dgvInvoiceDetail[clmSupplierItemId.Index, dgvInvoiceDetail.Rows.Count - 1].Value = txtITEM_SUPPLIER_Id.Text;
            dgvInvoiceDetail[clmSupplierItemNo.Index, dgvInvoiceDetail.Rows.Count - 1].Value = txtITEM_SUPPLIER_NUMBER.Text;
            dgvInvoiceDetail[clmSupplierItemName.Index, dgvInvoiceDetail.Rows.Count - 1].Value = txtITEM_SUPPLIER_NAME.Text;
            dgvInvoiceDetail[clmSupplierItemInf.Index, dgvInvoiceDetail.Rows.Count - 1].Value = txtITEM_INFO.Text;
            dgvInvoiceDetail[clmPurchaseOrderid.Index, dgvInvoiceDetail.Rows.Count - 1].Value = txtPurchaseOrderDetailId.Text;
            dgvInvoiceDetail[clmFreeQty.Index, dgvInvoiceDetail.Rows.Count - 1].Value = nmbFREE_QTY.Value.ToString();
            dgvInvoiceDetail[clmDetailUnitPrice.Index, dgvInvoiceDetail.Rows.Count - 1].Value = nmbUNIT_PRICE.Value.ToString();
            dgvInvoiceDetail[clmInvoiceQty.Index, dgvInvoiceDetail.Rows.Count - 1].Value = nmbInvoiceQty.Value.ToString();
            dgvInvoiceDetail[clmFakePrice.Index, dgvInvoiceDetail.Rows.Count - 1].Value = nmbFakePrice.Value.ToString();
            dgvInvoiceDetail[clmTotalPrice.Index, dgvInvoiceDetail.Rows.Count - 1].Value =Math.Round( Convert.ToDouble(dgvInvoiceDetail[clmInvoiceQty.Index, dgvInvoiceDetail.Rows.Count - 1].Value) * Convert.ToDouble(dgvInvoiceDetail[clmDetailUnitPrice.Index, dgvInvoiceDetail.Rows.Count - 1].Value),iCurrDecimal);
            dgvInvoiceDetail[clmBoxNo.Index, dgvInvoiceDetail.Rows.Count - 1].Value = txtBOX_NO.Text.Trim();

            SumTotal();
            txtItemId.Text = "";
            txtItemName.Text="";
            txtITEM_SUPPLIER_Id.Text = "";
            txtITEM_SUPPLIER_NUMBER.Text = "";
            txtITEM_SUPPLIER_NAME.Text = "";
            txtITEM_INFO.Text = "";
            txtPurchaseOrderDetailId.Text = "";
            nmbFREE_QTY.Value = 0;
            nmbUNIT_PRICE.Value = 0;
            nmbInvoiceQty.Value = 0;
            nmbFakePrice.Value = 0;
            txtBOX_NO.Text = "";
        }
        private bool CheckDetailEntries()
        {
           

            int iError = 0;
            if (lstCURRENCY_ID.SelectedIndex == -1)
            {

                errCheckDetails.SetError(lstCURRENCY_ID, "الرجاء اختيار العملة");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstCURRENCY_ID, "");
            }


            if (txtSUPPLIER_ID.Text == "")
            {

                errCheckDetails.SetError(txtSUPPLIER_Name, "الرجاء اختيار المورد");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(txtSUPPLIER_Name, "");
            }

            if (txtItemId.Text == "")
            {
                errCheckDetails.SetError(txtItemNo, "الرجاء ادخال الصنف ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(txtItemNo, "");
            }


            if (nmbInvoiceQty.Value <=0)
            {

                errCheckDetails.SetError(nmbInvoiceQty, "الرجاء ادخال كمية الفاتورة ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(nmbInvoiceQty, "");
            }
           
            if(nmbUNIT_PRICE.Value <=0)
            {
                errCheckDetails.SetError(nmbUNIT_PRICE, "الرجاء ادخال سعر الوحدة ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(nmbUNIT_PRICE, "");
            }
            
            if (iError == 1)
                return false;

            return true;
        }
        private void btnDelete0_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInvoiceDetail.Rows.Count; i++)
            {
                if(Convert.ToDecimal( dgvInvoiceDetail[clmInvoiceQty.Index ,i].Value.ToString())<=0)
                {
                    dgvInvoiceDetail.Rows.Remove(dgvInvoiceDetail.Rows[i]);
                    i--;
                }
            }
        }

        private void nmbEditor_Leave(object sender, EventArgs e)
        {
            if (nmbEditor.Visible == true)
            {
                nmbEditor.Visible = false;

                dgvInvoiceDetail[nmbEditor.W_ColEgName, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = nmbEditor.Value.ToString();

                dgvInvoiceDetail[clmTotalPrice.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = Convert.ToDecimal( dgvInvoiceDetail[clmDetailUnitPrice.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value) * Convert.ToDecimal( dgvInvoiceDetail[clmInvoiceQty.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value);

                SumTotal();

            }
        }
        Rectangle RECT;
        DataGridViewCell abc;

        private void dgvInvoiceDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == clmInvoiceQty .Index || e.ColumnIndex == clmFreeQty.Index || e.ColumnIndex == clmDetailUnitPrice.Index || e.ColumnIndex == clmFakePrice.Index )
            {

               
                 abc = dgvInvoiceDetail.CurrentCell;

               RECT = dgvInvoiceDetail.GetCellDisplayRectangle( abc.ColumnIndex, abc.RowIndex, true  ) ;
          

                


                nmbEditor.Tag = e.RowIndex.ToString();
                nmbEditor.W_ColEgName = dgvInvoiceDetail.Columns[e.ColumnIndex].Name;

                nmbEditor.Value = Convert.ToDecimal((dgvInvoiceDetail[e.ColumnIndex, e.RowIndex].Value.ToString() == "" ? "0" : dgvInvoiceDetail[e.ColumnIndex, e.RowIndex].Value.ToString()));

                if (e.ColumnIndex == clmFakePrice.Index || e.ColumnIndex ==clmDetailUnitPrice.Index)
                {

                    nmbEditor.DecimalPlaces = iCurrDecimal;


                }
                else
                    nmbEditor.DecimalPlaces = 0;
                


                CtlLocation(RECT, nmbEditor);
            }
        }
        private void CtlLocation(Rectangle rect, Control ctrl)
        {
            //ctrl.Location = rect.Location;
            // ctrl.Size = rect.Size;
            ctrl.Top = dgvInvoiceDetail.Location.Y + rect.Y;
            ctrl.Left =  dgvInvoiceDetail.Location.X + rect.X;
            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;
            ctrl.Focus();


        }

        private void dgvInvoiceDetail_Scroll(object sender, ScrollEventArgs e)
        {

            Control ctrl = null;
          
                ctrl = nmbEditor;

            if (ctrl.Visible == false)
                return;


        
            abc = dgvInvoiceDetail.CurrentCell;

            RECT = dgvInvoiceDetail.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
            
            CtlLocation(RECT, ctrl);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstBILL_TYPE.Text = "";
           new glb_function().clearItems(this);
            PrepareForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToDB cnn = new ConnectionToDB();

            glb_function.arrInsertLogs = new System.Collections.ArrayList();


            DataTable dtBill = cnn.GetDataTable("select nvl(max(swid),0)+1 from PURCHASES_BILL");

            txtSwid.Text = dtBill.Rows[0][0].ToString();

            glb_function.arrInsertLogs.Add("insert into PURCHASES_BILL values(" + txtSwid.Text + ",sysdate," +
               glb_function.glb_strUserId + ",'فعال',null,"+ txtBILL_NUMBER .Text .Trim()+ 
               ",to_date('"+dtpBILL_DATE.Value.ToString("dd/MM/yyyy")+"','dd/mm/yyyy'),'"+
               lstBILL_TYPE.Text +"','"+txtBILL_SUPPLIER_NUMBER.Text +"',"+txtSUPPLIER_ID.Text +
               ","+( txtTERMS_EXPENSES_ID.Text.Trim()==""?"null":txtTERMS_EXPENSES_ID.Text.Trim()) + ",'"+ 
               txtPAYMENT_AGREEMENT .Text + "',"+lstCURRENCY_ID.SelectedValue.ToString()+","+
               (strImportNo==""?"null":strImportNo) +",null,"+(txtLcRollOverId.Text.Trim()==""?"null":txtLcRollOverId.Text.Trim()) +",0,0,0)");




            for (int i = 0; i < dgvInvoiceDetail.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add(
                    "insert into PURCHASES_BILL_DETAILS values((select nvl(max(swid),0)+1 from PURCHASES_BILL_DETAILS)," +
                    "sysdate," + glb_function.glb_strUserId + ",'فعال'," + txtSwid.Text + "," +
                    "" + dgvInvoiceDetail[clmItemId.Index, i].Value.ToString() + "," +
                    dgvInvoiceDetail[clmInvoiceQty.Index, i].Value.ToString() + "," +
                    "'" + dgvInvoiceDetail[clmFreeQty.Index, i].Value.ToString() + "','" + 
                    dgvInvoiceDetail[clmDetailUnitPrice.Index, i].Value.ToString() + "',0," +
                    "'" + dgvInvoiceDetail[clmFakePrice.Index, i].Value.ToString() + "'," + 
                   ( dgvInvoiceDetail[clmPurchaseOrderid.Index, i].Value.ToString()==""?"null": dgvInvoiceDetail[clmPurchaseOrderid.Index, i].Value.ToString()) + " ," +
                     (dgvInvoiceDetail[clmSupplierItemId.Index, i].Value.ToString() == "" ? "null" : dgvInvoiceDetail[clmSupplierItemId.Index, i].Value.ToString()) + " ," +
                   "'"+ dgvInvoiceDetail[clmBoxNo.Index, i].Value.ToString() + "',0)");
            }


            for (int i = 0; i < dgExpenss.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add("insert into PURCHASE_Expenses values((select nvl(max(swid),0)+1 from PURCHASE_Expenses)," +
                    txtSwid.Text + "," + dgExpenss[1, i].Value.ToString() + "," +
                    dgExpenss[3, i].Value.ToString() + ",'فعال'," +
                    "'فاتورة شراء'" + ")");
            }

            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);



        }
        private void GetData(string strBillSwid)
        {
            btnNew_Click(null, null);

            
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBill = cnn.GetDataTable("select h.swid, bill_number, to_char(bill_date,'dd/mm/yyyy') bill_date, bill_type, bill_supplier_number, " +
                    " supplier_id, terms_of_expenses_id, purchase_agreement, " +
                    "  currency_id, imports_id ,LC_ROLLOVER_ID " +
                     " from purchases_bill h " +
                   " where h.swid = "+ strBillSwid);

            lstBILL_TYPE.Text = dtBill.Rows[0]["bill_type"].ToString();
            txtSwid.Text = strBillSwid;
            txtBILL_SUPPLIER_NUMBER.Text = dtBill.Rows[0]["bill_supplier_number"].ToString();

            if (strThisFormFromWhere =="Main")
                strImportNo = dtBill.Rows[0]["imports_id"].ToString();

            txtSUPPLIER_ID.Text = dtBill.Rows[0]["supplier_id"].ToString();
            GetVendorData(txtSUPPLIER_ID.Text);

            txtBILL_NUMBER.Text = dtBill.Rows[0]["bill_number"].ToString();

            dtpBILL_DATE.Value =Convert.ToDateTime( dtBill.Rows[0]["bill_date"].ToString());

          

            lstCURRENCY_ID.SelectedValue = Convert.ToInt16(dtBill.Rows[0]["currency_id"].ToString());

           

            txtPAYMENT_AGREEMENT.Text = dtBill.Rows[0]["purchase_agreement"].ToString();

            txtTERMS_EXPENSES_ID.Text = dtBill.Rows[0]["terms_of_expenses_id"].ToString();
            GetTermsExpensess(txtTERMS_EXPENSES_ID.Text);

            //LC_ROLLOVER_ID
            txtLcRollOverId.Text = dtBill.Rows[0]["LC_ROLLOVER_ID"].ToString();



            dtBill.Clear();

            dtBill = cnn.GetDataTable("select d.swid,d.item_id,i.item_name,d.item_supplier_id,item_sup.item_no," +
                                    " item_sup.item_name item_supplier_name,item_sup.item_info," +
                                   "   d.quantity, d.free_qty,d.price, d.re_evaluation, " +
                                   "     d.fake_price, d.order_purchases_de_id, d.box_no,po.qty, " +
                                   " po.qty-(select nvl(sum( oq.quantity),0) from purchases_bill_details oq where oq.order_purchases_de_id=po.swid and oq.swid<>d.swid) reminedQty " +
                                  "    from purchases_bill_details d" +
                                   "  left outer  join items i on (d.item_id = i.swid)" +
                                   "   left outer  join item_supplier item_sup on (d.item_supplier_id = item_sup.swid)" +
                                   " left outer join purchases_order_details po on (d.order_purchases_de_id=po.swid)" +
                                    " where  d.header_id = " + txtSwid.Text);

            for (int i = 0; i < dtBill.Rows.Count; i++)
            {

                dgvInvoiceDetail.Rows.Add();

                dgvInvoiceDetail[0, i].Value = dtBill.Rows[i]["swid"].ToString();
                dgvInvoiceDetail[clmItemId.Index, i].Value = dtBill.Rows[i]["item_id"].ToString();
                dgvInvoiceDetail[clmItemName.Index , i].Value = dtBill.Rows[i]["item_name"].ToString();
                dgvInvoiceDetail[clmSupplierItemId.Index, i].Value = dtBill.Rows[i]["item_supplier_id"].ToString();
                dgvInvoiceDetail[clmSupplierItemNo.Index , i].Value = dtBill.Rows[i]["item_no"].ToString();
                dgvInvoiceDetail[clmSupplierItemName.Index , i].Value = dtBill.Rows[i]["item_supplier_name"].ToString();
                dgvInvoiceDetail[clmSupplierItemInf.Index, i].Value = dtBill.Rows[i]["item_info"].ToString();
                dgvInvoiceDetail[clmInvoiceQty.Index, i].Value = dtBill.Rows[i]["quantity"].ToString();
                dgvInvoiceDetail[clmFreeQty.Index , i].Value = dtBill.Rows[i]["free_qty"].ToString();
                dgvInvoiceDetail[clmDetailUnitPrice.Index , i].Value = dtBill.Rows[i]["price"].ToString();
                dgvInvoiceDetail[clmPurchaseOrderid.Index, i].Value = dtBill.Rows[i]["order_purchases_de_id"].ToString();
                dgvInvoiceDetail[clmOrderQty.Index , i].Value = dtBill.Rows[i]["reminedQty"].ToString();
                dgvInvoiceDetail[clmFakePrice.Index, i].Value = dtBill.Rows[i]["fake_price"].ToString();
                dgvInvoiceDetail[clmBoxNo.Index, i].Value = dtBill.Rows[i]["box_no"].ToString();
                dgvInvoiceDetail[11, i].Value = Convert.ToDouble(dgvInvoiceDetail[clmInvoiceQty.Index , i].Value) * Convert.ToDouble(dgvInvoiceDetail[clmDetailUnitPrice.Index , i].Value);



            }



            dtBill.Clear();
            dtBill = cnn.GetDataTable("select ex.swid, ex.expenses_id,ex.expenses_value,itmEx.Expenses_Name from PURCHASE_Expenses ex,EXPENSES_ITEM itmEx " +
                           " where ex.expenses_id = itmEx.Swid and  ex.expensess_type = 'فاتورة شراء' " +
                           " and ex.header_id = " + txtSwid.Text);


            for (int i = 0; i < dtBill.Rows.Count; i++)
            {
                dgExpenss.Rows.Add();
                dgExpenss[0, i].Value = dtBill.Rows[i]["swid"].ToString();
                dgExpenss[1, i].Value = dtBill.Rows[i]["expenses_id"].ToString();
                dgExpenss[2, i].Value = dtBill.Rows[i]["Expenses_Name"].ToString();
                dgExpenss[3, i].Value = dtBill.Rows[i]["expenses_value"].ToString();
            }

            SumTotal();


            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
            {
                btnUpdate.Enabled = true;
                btnConfirm.Enabled = true;
            }
                
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (lstBILL_TYPE.Text  == "")
            {

                errCheckDetails.SetError(lstBILL_TYPE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstBILL_TYPE, "");
            }


            if (lstCURRENCY_ID.SelectedIndex == -1)
            {

                errCheckDetails.SetError(lstCURRENCY_ID, "الرجاء اختيار العملة");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstCURRENCY_ID, "");
            }


            if (txtSUPPLIER_ID.Text =="")
            {

                errCheckDetails.SetError(txtSUPPLIER_Name, "الرجاء اختيار المورد");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(txtSUPPLIER_Name, "");
            }

            //txtBILL_NUMBER
            if (txtBILL_NUMBER.Text == "")
            {

                errCheckDetails.SetError(txtBILL_NUMBER, "الرجاء ادخال رقم الفاتورة");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(txtBILL_NUMBER, "");
            }

            if (dgvInvoiceDetail.Rows.Count <=0)
            {
                glb_function.MsgBox("لايوجد اصناف لحفظها");
                return false ;
            }

            for (int i = 0; i < dgExpenss.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dgExpenss[clmExpValue.Index, i].Value) <= 0)
                {
                    glb_function.MsgBox("يوجد مبلغ غير مدخل في المصاريف");
                    return false;
                }
            }

            if (iError == 1)
                return false;

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();

        

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            glb_function.arrInsertLogs.Add("delete from PURCHASES_BILL_DETAILS where header_id=" + txtSwid.Text.Trim());
            glb_function.arrInsertLogs.Add("delete from PURCHASE_Expenses where header_id=" + txtSwid.Text.Trim());


            glb_function.arrInsertLogs.Add("update PURCHASES_BILL set BILL_NUMBER=" + txtBILL_NUMBER.Text.Trim() +
            ",BILL_DATE=to_date('" + dtpBILL_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy'),BILL_TYPE='" +
            lstBILL_TYPE.Text + "',BILL_SUPPLIER_NUMBER='" + txtBILL_SUPPLIER_NUMBER.Text + "'," + 
            "TERMS_OF_EXPENSES_ID=" + txtTERMS_EXPENSES_ID.Text + ",PURCHASE_AGREEMENT='" +
            txtPAYMENT_AGREEMENT.Text + "',imports_id="+strImportNo +" where swid=" + txtSwid.Text );




            for (int i = 0; i < dgvInvoiceDetail.Rows.Count; i++)
            {
               
                    glb_function.arrInsertLogs.Add(
                    "insert into PURCHASES_BILL_DETAILS values((select nvl(max(swid),0)+1 from PURCHASES_BILL_DETAILS)," +
                    "sysdate," + glb_function.glb_strUserId + ",'فعال'," + txtSwid.Text + "," +
                    "" + dgvInvoiceDetail[clmItemId.Index, i].Value.ToString() + "," +
                    dgvInvoiceDetail[clmInvoiceQty.Index, i].Value.ToString() + "," +
                    "'" + dgvInvoiceDetail[clmFreeQty.Index, i].Value.ToString() + "','" +
                    dgvInvoiceDetail[clmDetailUnitPrice.Index, i].Value.ToString() + "',0," +
                    "'" + dgvInvoiceDetail[clmFakePrice.Index, i].Value.ToString() + "'," +
                   (dgvInvoiceDetail[clmPurchaseOrderid.Index, i].Value.ToString() == "" ? "null" : dgvInvoiceDetail[clmPurchaseOrderid.Index, i].Value.ToString()) + " ," +
                     (dgvInvoiceDetail[clmSupplierItemId.Index, i].Value.ToString() == "" ? "null" : dgvInvoiceDetail[clmSupplierItemId.Index, i].Value.ToString()) + " ," +
                   "'" + dgvInvoiceDetail[clmBoxNo.Index, i].Value.ToString() + "',0)");
               
               
            }


            for (int i = 0; i < dgExpenss.Rows.Count; i++)
            {
                
                    glb_function.arrInsertLogs.Add("insert into PURCHASE_Expenses values((select nvl(max(swid),0)+1 from PURCHASE_Expenses)," +
                   txtSwid.Text + "," + dgExpenss[1, i].Value.ToString() + "," +
                   dgExpenss[3, i].Value.ToString() + ",'فعال'," +
                   "'فاتورة شراء'" + ")");
                
               
            }

            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);

        }

        private void btnFindBillPurchase_Click(object sender, EventArgs e)
        {
            frmGetPurchaseBill frm = new frmGetPurchaseBill();
            if(strThisFormFromWhere =="Import")
              frm.strWhere = " and h.stat='فعال' and  imports_id is null";
            else
                frm.strWhere = " and h.stat='فعال' ";

            frm.ShowDialog();

            txtSwid.Text = frm.strBillSwid;

            if(txtSwid.Text !="")
            {
                GetData(txtSwid.Text);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
            if (glb_function.MsgBox("هل تريد اعتماد الفاتورة؟", "", true) == false)
                glb_function.AcceptTrans = false;
            else
                glb_function.AcceptTrans = true;

            if(strImportNo.Trim()=="")
            {

                glb_function.MsgBox("هذه الفاتورة ليس لها وارد"+"\n"+"الرجاء ربط الفاتورة بالوارد");
                return;
            }

            if (!CheckEntries())
                return;


            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = 0;

            if (lstBILL_TYPE.Text .Trim()== "اعتماد")
            {

                decimal dMainValue = Math.Round( nmbTotal.Value * dExchangeRate,glb_function.glbMainDecimalPoint);
               
                decimal currExchange= dMainValue / nmbTotal.Value;

                icheck = 0;
                icheck = cnn.TranDataToDB("insert into LC_OPERATIONS values((select nvl(max(swid),0)+1 from LC_OPERATIONS),sysdate,"+glb_function.glb_strUserId +",'فعال',"+txtLcRollOverId.Text +",null,"+txtSwid.Text +","+ nmbTotal .Value.ToString()+ ",'','',"+ nmbTotal.Value.ToString() + ",'فاتورة',"+ currExchange.ToString()+","+ currExchange.ToString()+","+dMainValue +","+dMainValue+","+dExchangeRate +")");

                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء تاكيد الفاتورة");
                    return;
                }

                icheck = cnn.TranDataToDB("update PURCHASES_BILL set stat='اعتماد' where swid= " + txtSwid.Text);
                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء تاكيد الفاتورة");
                    return;
                }
            }
            else
            {
                icheck = cnn.TranDataToDB("update PURCHASES_BILL set stat='تاكيد' where swid= " + txtSwid.Text);
                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء تاكيد الفاتورة");
                    return;
                }
            }
          
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية التاكيد بنجاح");

            btnNew_Click(null, null);
        }

        private void btnLc_Click(object sender, EventArgs e)
        {
           Accounts. frmFindLC frm = new Accounts. frmFindLC();
            frm.strWhere = " and lc.stat='فعال' ";
            frm.ShowDialog();

            txtLcSwid.Text = frm.strLcId;

            if (txtLcSwid.Text != "")
                GetLcData(txtLcSwid.Text);
        }
        private void GetLcData(string strLcSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLc = cnn.GetDataTable("select swid, "+
                       "   lc_nature, lc_no, people_id," +
                        "  currency_id, lc_type, " +
                        "   lc_rollover" +
                        "   from lc" +
                         "  where swid = "+strLcSwid );


            txtLC_NO.Text = dtLc.Rows[0]["lc_no"].ToString();
            txtSUPPLIER_ID.Text = dtLc.Rows[0]["people_id"].ToString();
            GetVendorData(txtSUPPLIER_ID.Text);

            lstCURRENCY_ID.SelectedValue = Convert.ToInt16(dtLc.Rows[0]["currency_id"].ToString());

            dtLc.Clear();

            dtLc = cnn.GetDataTable("select swid,rollover_no, purchases_order_id,(select h.purchase_order_num from purchases_order_header h where h.swid=purchases_order_id) purchase_order_num," +
                                    " rollover_type, rollover_value from lc_rollover ro "+
                                   " where ro.swid = (select max(m.swid) from lc_rollover m where m.header_id ="+strLcSwid +")");


            txtLcRollOverId.Text = dtLc.Rows[0]["swid"].ToString();

            txtPurchaseOrderHeaderId.Text = dtLc.Rows[0]["purchases_order_id"].ToString();
            txtPURCHASE_ORDER_NUM.Text = dtLc.Rows[0]["purchase_order_num"].ToString();

            //get purchase order header 
            dtLc.Clear();
            dtLc = cnn.GetDataTable("select swid, "+
                        " supplier_id, purchase_order_num, shipping_way, " +
                        "  proforma_invoice_num, proforma_invoice_date, " +
                        "  purchase_order_date, currency_id, currency_exchange, " +
                       "    payment_agreement, terms_expenses_id, port_of_loading, port_of_delivery, " +
                       "  letter_credit_id, purchase_quotations_id " +
                       "  from purchases_order_header h " +
                       "  where h.swid = " + txtPurchaseOrderHeaderId.Text);

            txtTERMS_EXPENSES_ID.Text = dtLc.Rows[0]["terms_expenses_id"].ToString();
            GetTermsExpensess(txtTERMS_EXPENSES_ID.Text.Trim());
            LoadExpenssessDetail(txtTERMS_EXPENSES_ID.Text);
            //get Purchase order detail
            LoadOrderItems();



            dtLc.Clear();
            dtLc = cnn.GetDataTable("select ex.swid,ex.expenses_id,ex.expenses_value,itmEx.Expenses_Name " +
                " from PURCHASE_Expenses ex,EXPENSES_ITEM itmEx " +
                           " where ex.expenses_id = itmEx.Swid and  ex.expensess_type = 'امر الشراء' " +
                           " and ex.header_id = " + txtPurchaseOrderHeaderId.Text);


            for (int i = 0; i < dtLc.Rows.Count; i++)
            {
                dgExpenss.Rows.Add();
                dgExpenss[0, i].Value = dtLc.Rows[i]["swid"].ToString();
                dgExpenss[1, i].Value = dtLc.Rows[i]["expenses_id"].ToString();
                dgExpenss[2, i].Value = dtLc.Rows[i]["Expenses_Name"].ToString();
                dgExpenss[3, i].Value = dtLc.Rows[i]["expenses_value"].ToString();
            }


        }
        private void lstBILL_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            new glb_function().clearItems(this);
            PrepareForm();
            if(lstBILL_TYPE.Text =="اعتماد")
            {
                btnLc.Enabled = true;
                txtLcRollOverId.Text = "";
                txtLcSwid.Text = "";
                txtLC_NO.Text = "";

                btnGetVendor.Enabled = false;
               
                btnGetExpenssTerm.Enabled = false;
                lstCURRENCY_ID.Enabled = false;
                btnGetPurchaseOrderD.Enabled = false;
                btnGetPurchaseOrder.Enabled = false;
                txtPAYMENT_AGREEMENT.Enabled = false;
            }
            else
            {
                btnLc.Enabled = false;
                txtLcRollOverId.Text = "";
                txtLcSwid.Text = "";
                txtLC_NO.Text = "";


                btnGetVendor.Enabled = true ;
                btnGetExpenssTerm.Enabled = true;
                lstCURRENCY_ID.Enabled = true;
                btnGetPurchaseOrderD.Enabled = true;
                btnGetPurchaseOrder.Enabled = true;
                txtPAYMENT_AGREEMENT.Enabled = true;

            }
              
        }
    }
}
