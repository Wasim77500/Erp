using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmPurchaseOrder : MyForm
    {
        private int iRow;

        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            //PrepareForm work from FillBranch which call from lstTemplet_MorePrivilleges
            //PrepareForm();
            iRow = -1;
        }


        public override void lstTemplet_MorePrivilleges(object sender, EventArgs e)
        {


            FillBranch();




        }
        private void FillBranch()
        {

            lstBranchHeader.DataSource = null;
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

            lstBranchHeader.DataSource = dt;
            lstBranchHeader.ValueMember = "swid";
            lstBranchHeader.DisplayMember = "branch_cost_center_name";


        }
        private void btnGetVendor_Click(object sender, EventArgs e)
        {
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
        private void PrepareForm()
        {
           
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
           
            glb_function.FillListWithId(ref lstCURRENCY_ID, "currency", "curr_name");
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

        private void lstCURRENCY_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCURRENCY_ID.SelectedValue == null)
                return;

            if (lstCURRENCY_ID.SelectedValue.ToString() != "System.Data.DataRowView" && lstCURRENCY_ID.SelectedValue.ToString() != "")
            {
                ChangeNumberCtrlDecimalPlace(lstCURRENCY_ID.SelectedValue.ToString());
            }
        }
        private void ChangeNumberCtrlDecimalPlace(string strCurrSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCurr = cnn.GetDataTable("select curr_decimal from currency where swid=" + strCurrSwid);

            nmbExpenssItem.DecimalPlaces = Convert.ToInt32(dtCurr.Rows[0]["curr_decimal"].ToString());
            nmbUNIT_PRICE.DecimalPlaces = Convert.ToInt32(dtCurr.Rows[0]["curr_decimal"].ToString());
            nmbTotal.DecimalPlaces = Convert.ToInt32(dtCurr.Rows[0]["curr_decimal"].ToString());
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            if(txtSUPPLIER_ID.Text.Trim() =="")
            {
                glb_function.MsgBox("الرجاء اختيار المورد");
                return;
            }

            Inventory.frmFindItem frm = new Inventory.frmFindItem();

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtITEM_SUPPLIER_Id.Text = "";
                txtITEM_SUPPLIER_NUMBER.Text = "";
                txtITEM_SUPPLIER_NAME.Text = "";
                txtITEM_INFO.Text = "";
                txtItemId.Text = frm.strItemID;
                GetItemData(txtItemId.Text);

            }
        }
        private void GetItemData(string strItemSwid)
        {
           

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems = cnn.GetDataTable("select item_no,item_name,(select s.swid from item_supplier s where s.itemid=i.swid and s.people_id=" + txtSUPPLIER_ID.Text + ") supplierItem from items i where swid=" + strItemSwid);

            txtItemNo.Text = dtItems.Rows[0]["item_no"].ToString();
            txtItemName.Text = dtItems.Rows[0]["item_name"].ToString();
            if (dtItems.Rows[0]["supplierItem"].ToString().Trim() != "" )
            {
                

                if (bItemCheck == false)
                {
                    bItemCheck = true;
                    GetSuplierItemData(dtItems.Rows[0]["supplierItem"].ToString().Trim());
                }
                
            }
            bItemCheck = false;
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

                txtItemId.Text = "";
                txtItemNo.Text = "";
                txtItemName.Text = "";
                txtITEM_SUPPLIER_Id.Text = frm.strItemSupplier_id;
                GetSuplierItemData(txtITEM_SUPPLIER_Id.Text);

            }
        }
        bool bItemCheck = false;//take item from supplierItem and take supplierItem from item infinity loop
        private void GetSuplierItemData(string strSuplierSwid)
        {
           
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtSupllierItems = cnn.GetDataTable("select swid,item_no,Item_name,itemid From item_supplier where swid=" + strSuplierSwid);

            txtITEM_SUPPLIER_NUMBER.Text = dtSupllierItems.Rows[0]["item_no"].ToString();
            txtITEM_SUPPLIER_NAME.Text = dtSupllierItems.Rows[0]["Item_name"].ToString();
            if (dtSupllierItems.Rows[0]["itemid"].ToString().Trim() != "" )
            {

                if (bItemCheck == false)
                {
                    bItemCheck = true;
                    GetItemData(dtSupllierItems.Rows[0]["itemid"].ToString().Trim());
                }
              
            }
            bItemCheck = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtITEM_SUPPLIER_NUMBER.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم الصنف  عند المورد");
                txtITEM_SUPPLIER_NUMBER.Focus();
                return;
            }
            if (txtITEM_SUPPLIER_NAME.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم الصنف عند المورد");
                txtITEM_SUPPLIER_NAME.Focus();
                return;
            }

            if(txtItemId.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء ادخال الصنف ");
                btnFindItem.Focus();
                return;
            }

            if (nmbREQUESTED_QTY.Value <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال الكمية المطلوبة");
                nmbREQUESTED_QTY.Focus();
                return;
            }

            if (txtItemId.Text.Trim() == "" || txtItemNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار القطعة المطلوبة");
                btnFindItem.Focus();
                return;
            }
            for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
            {
                if(txtItemId.Text .Trim()== dgvPurQuotDetail[1, i].Value.ToString())
                {
                    glb_function.MsgBox("الصنف مدخل من قبل");
                    return;
                }
            }
            if (iRow == -1)
            {
                dgvPurQuotDetail.Rows.Add();
                iRow = dgvPurQuotDetail.Rows.Count - 1;
                dgvPurQuotDetail[0, iRow].Value = "";
            }

            dgvPurQuotDetail[1, iRow].Value = txtItemId.Text.Trim();
            dgvPurQuotDetail[2, iRow].Value = txtItemName.Text.Trim();
            dgvPurQuotDetail[3, iRow].Value = txtITEM_SUPPLIER_Id.Text.Trim();
            dgvPurQuotDetail[4, iRow].Value = txtITEM_SUPPLIER_NUMBER.Text.Trim();
            dgvPurQuotDetail[5, iRow].Value = txtITEM_SUPPLIER_NAME.Text.Trim();
            dgvPurQuotDetail[6, iRow].Value = txtITEM_INFO.Text.Trim();
            dgvPurQuotDetail[7, iRow].Value = nmbREQUESTED_QTY.Value.ToString();
            dgvPurQuotDetail[8, iRow].Value = nmbFREE_QTY.Value.ToString();
            dgvPurQuotDetail[9, iRow].Value = nmbUNIT_PRICE.Value.ToString();
            dgvPurQuotDetail[10, iRow].Value = nmbCURRENT_STOCK_QTY.Value.ToString();
            dgvPurQuotDetail[11, iRow].Value = Convert.ToDouble(dgvPurQuotDetail[7, iRow].Value) * Convert.ToDouble(dgvPurQuotDetail[9, iRow].Value);


            iRow = -1;
            SumTotal();
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;
            bool  bcheckItem = true  ;
            for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
            {
                if(dgvPurQuotDetail[clmItemSwid.Index,i].Value.ToString().Trim()=="")
                {
                    //
                    for (int j = 0; j < dgvPurQuotDetail.Columns.Count; j++)
                    {
                        dgvPurQuotDetail.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Red;
                    }
                    bcheckItem = false;
                }

               

            }

            if (bcheckItem == false )
            {
                glb_function.MsgBox("توجد اصناف غير مضافة الى المخزون ");
                return false;
            }
               


            int iError = 0;
            if (txtSUPPLIER_ID.Text.Trim() == "")
            {

                errCheck.SetError(txtSUPPLIER_ID, "الرجاء اختيار المورد");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtSUPPLIER_ID, "");
            }

            if (lstCURRENCY_ID.SelectedIndex ==-1)
            {

                errCheck.SetError(lstCURRENCY_ID, "الرجاء اختيار العملة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstCURRENCY_ID, "");
            }

            if(txtPURCHASE_ORDER_NUM.Text.Trim()=="")
            {
                errCheck.SetError(txtPURCHASE_ORDER_NUM, "الرجاء ادخال رقم الطلب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtPURCHASE_ORDER_NUM, "");
            }
            for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dgvPurQuotDetail[clmDetailFreeQty.Index, i].Value.ToString()) > 0)
                {
                    if (Convert.ToDecimal(dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString()) <= 0 && Convert.ToDecimal(dgvPurQuotDetail[clmDetailQty.Index, i].Value.ToString()) > 0)
                    {
                        glb_function.MsgBox("الصنف " + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + ": " + "ليس مسعرا");
                        return false;
                    }
                    if (Convert.ToDecimal(dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString()) > 0 && Convert.ToDecimal(dgvPurQuotDetail[clmDetailQty.Index, i].Value.ToString()) <= 0)
                    {
                        glb_function.MsgBox("الصنف " + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + ": " + "ليس لديه كمية");
                        return false;
                    }

                }
                else
                {
                    if (Convert.ToDecimal(dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString()) <= 0)
                    {
                        glb_function.MsgBox("الصنف " + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + ": " + "ليس مسعرا");
                        return false;
                    }
                    if (Convert.ToDecimal(dgvPurQuotDetail[clmDetailQty.Index, i].Value.ToString()) <= 0)
                    {
                        glb_function.MsgBox("الصنف " + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + ": " + "ليس لديه كمية");
                        return false;
                    }
                }

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
        private void btnSave_Click(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtQuotHeader = cnn.GetDataTable("select nvl(max(purchase_order_num),to_number(to_char(sysdate,'yyyy')||'0000'))+1 from PURCHASES_ORDER_HEADER where to_char(created_date,'yyyy')=to_char(sysdate,'yyyy')");
            txtPURCHASE_ORDER_NUM.Text = dtQuotHeader.Rows[0][0].ToString();

            if (!CheckEntries())
                return;

         

            string strPURCHASE_ORDER_DATE = (dtpPURCHASE_ORDER_DATE.Checked == false ? "null" : "to_date('" + dtpPURCHASE_ORDER_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')");
            string strPROFORMA_INVOICE = (dtpPROFORMA_INVOICE_DATE.Checked == false ? "null" : "to_date('" + dtpPROFORMA_INVOICE_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')");
          


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

             dtQuotHeader = cnn.GetDataTable("select nvl(max(swid),0)+1 from PURCHASES_ORDER_HEADER");

            txtSwid.Text = dtQuotHeader.Rows[0][0].ToString();

            

            glb_function.arrInsertLogs.Add("insert into PURCHASES_ORDER_HEADER values(" + txtSwid.Text + ",sysdate," +
                glb_function.glb_strUserId + ",'فعال'," + txtSUPPLIER_ID.Text + "," +
                 "'" + txtPURCHASE_ORDER_NUM.Text + "','" + lstSHIPPING_Way.Text + "','" + txtPROFORMA_INVOICE_NUM.Text + "'," +
                 strPROFORMA_INVOICE + "," + strPURCHASE_ORDER_DATE + "," +
                 "" + lstCURRENCY_ID.SelectedValue.ToString() + "," + nmbCURRENCY_EXCHANGE.Value.ToString() + ",'" + txtPAYMENT_AGREEMENT.Text + "'," + (txtTERMS_EXPENSES_ID.Text.Trim() == "" ? "null" : txtTERMS_EXPENSES_ID.Text.Trim()) + "," +
                 "'" + txtPORT_OF_LOADING.Text.Trim() + "','" + txtPORT_OF_DELIVERY.Text.Trim() + "',null," +( txtPURCHASE_QUOTATIONS_ID.Text.Trim()==""?"null": txtPURCHASE_QUOTATIONS_ID.Text.Trim())+")");




            for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add(
                    "insert into PURCHASES_ORDER_DETAILS values((select nvl(max(swid),0)+1 from PURCHASES_ORDER_DETAILS)," +
                    "sysdate," + glb_function.glb_strUserId + ",'فعال'," + txtSwid.Text + "," +
                    "" + dgvPurQuotDetail[1, i].Value.ToString() + "," + dgvPurQuotDetail[7, i].Value.ToString() + "," +
                    "'" + dgvPurQuotDetail[9, i].Value.ToString() + "','" + dgvPurQuotDetail[8, i].Value.ToString() + "'," +
                    "'" + dgvPurQuotDetail[3, i].Value.ToString() + "'," + (dgvPurQuotDetail[10, i].Value.ToString() == ""?"0":dgvPurQuotDetail[10, i].Value.ToString()) + " )");
            }


            for (int i = 0; i < dgExpenss.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add("insert into PURCHASE_Expenses values((select nvl(max(swid),0)+1 from PURCHASE_Expenses)," +
                    txtSwid.Text + "," + dgExpenss[1, i].Value.ToString() + "," +
                    dgExpenss[3, i].Value.ToString() + ",'فعال'," +
                    "'امر الشراء'" + ")");
            }

            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);

        }
        private void GetData(string strSwid)
        {
            btnNew_Click(null, null);

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtQuotation = cnn.GetDataTable("select h.swid, h.supplier_id, "+
                          "   h.purchase_order_num, h.shipping_way, proforma_invoice_num, "+
                             "    pROFORMA_INVOICE_DATE, purchase_order_date, h.currency_id, " +
                            "     currency_exchange, h.payment_agreement, h.terms_expenses_id, " +
                            "     port_of_loading, port_of_delivery, letter_credit_id, " +
                            "      purchase_quotations_id, q.request_number from purchases_order_header h" +
                           "     left outer join purchase_quotations_header q on (q.swid = h.purchase_quotations_id) where h.swid=" + strSwid);


            txtSwid.Text = strSwid;

            txtPURCHASE_ORDER_NUM.Text = dtQuotation.Rows[0]["purchase_order_num"].ToString();
            dtpPURCHASE_ORDER_DATE.Value =Convert.ToDateTime( dtQuotation.Rows[0]["purchase_order_date"].ToString());
            txtPROFORMA_INVOICE_NUM.Text = dtQuotation.Rows[0]["proforma_invoice_num"].ToString();
            dtpPROFORMA_INVOICE_DATE.Value = Convert.ToDateTime(dtQuotation.Rows[0]["pROFORMA_INVOICE_DATE"].ToString());

            txtPURCHASE_QUOTATIONS_ID.Text = dtQuotation.Rows[0]["purchase_quotations_id"].ToString();
            txtPURCHASE_QUOTATIONS_No.Text = dtQuotation.Rows[0]["request_number"].ToString();

            txtSUPPLIER_ID.Text = dtQuotation.Rows[0]["supplier_id"].ToString();
            GetVendorData(txtSUPPLIER_ID.Text);

            lstSHIPPING_Way.Text = dtQuotation.Rows[0]["shipping_way"].ToString();
            lstCURRENCY_ID.SelectedValue = Convert.ToInt32(dtQuotation.Rows[0]["currency_id"].ToString());

            txtPAYMENT_AGREEMENT.Text = dtQuotation.Rows[0]["payment_agreement"].ToString();

            txtTERMS_EXPENSES_ID.Text = dtQuotation.Rows[0]["terms_expenses_id"].ToString();

            if(txtTERMS_EXPENSES_ID.Text !="")
            GetTermsExpensess(txtTERMS_EXPENSES_ID.Text);

            txtPORT_OF_LOADING.Text = dtQuotation.Rows[0]["PORT_OF_LOADING"].ToString();
            txtPORT_OF_DELIVERY.Text = dtQuotation.Rows[0]["PORT_OF_DELIVERY"].ToString();
            dtQuotation.Clear();

            dtQuotation = cnn.GetDataTable("select d.swid,d.item_id,i.item_name,d.item_supplier_id,item_sup.item_no," +
                                    " item_sup.item_name item_supplier_name,item_sup.item_info," +
                                   "   d.qty, d.free_qty, d.unit_price, d.total_stock" +
                                  "    from purchases_order_details d" +
                                   "    join items i on (d.item_id = i.swid)" +
                                   "    join item_supplier item_sup on (d.item_supplier_id = item_sup.swid)" +
                                    " and  d.header_id = " + strSwid);

            for (int i = 0; i < dtQuotation.Rows.Count; i++)
            {

                dgvPurQuotDetail.Rows.Add();

                dgvPurQuotDetail[0, i].Value = dtQuotation.Rows[i]["swid"].ToString();
                dgvPurQuotDetail[1, i].Value = dtQuotation.Rows[i]["item_id"].ToString();
                dgvPurQuotDetail[2, i].Value = dtQuotation.Rows[i]["item_name"].ToString();
                dgvPurQuotDetail[3, i].Value = dtQuotation.Rows[i]["item_supplier_id"].ToString();
                dgvPurQuotDetail[4, i].Value = dtQuotation.Rows[i]["item_no"].ToString();
                dgvPurQuotDetail[5, i].Value = dtQuotation.Rows[i]["item_supplier_name"].ToString();
                dgvPurQuotDetail[6, i].Value = dtQuotation.Rows[i]["item_info"].ToString();
                dgvPurQuotDetail[7, i].Value = dtQuotation.Rows[i]["qty"].ToString();
                dgvPurQuotDetail[8, i].Value = dtQuotation.Rows[i]["free_qty"].ToString();
                dgvPurQuotDetail[9, i].Value = dtQuotation.Rows[i]["unit_price"].ToString();
                dgvPurQuotDetail[10, i].Value = dtQuotation.Rows[i]["total_stock"].ToString();
                dgvPurQuotDetail[11, i].Value = Convert.ToDouble(dgvPurQuotDetail[7, i].Value) * Convert.ToDouble(dgvPurQuotDetail[9, i].Value);



            }



            dtQuotation.Clear();
            dtQuotation = cnn.GetDataTable("select ex.swid,ex.expenses_id,ex.expenses_value,itmEx.Expenses_Name " +
                " from PURCHASE_Expenses ex,EXPENSES_ITEM itmEx " +
                           " where ex.expenses_id = itmEx.Swid and  ex.expensess_type = 'امر الشراء' " +
                           " and ex.header_id = "+ strSwid);


            for (int i = 0; i < dtQuotation.Rows.Count; i++)
            {
                dgExpenss.Rows.Add();
                dgExpenss[0, i].Value = dtQuotation.Rows[i]["swid"].ToString();
                dgExpenss[1, i].Value = dtQuotation.Rows[i]["expenses_id"].ToString();
                dgExpenss[2, i].Value = dtQuotation.Rows[i]["Expenses_Name"].ToString();
                dgExpenss[3, i].Value = dtQuotation.Rows[i]["expenses_value"].ToString();
            }

            SumTotal();


            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!CheckEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();

            string strPURCHASE_ORDER_DATE = (dtpPURCHASE_ORDER_DATE.Checked == false ? "null" : "to_date('" + dtpPURCHASE_ORDER_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')");
            string strPROFORMA_INVOICE = (dtpPROFORMA_INVOICE_DATE.Checked == false ? "null" : "to_date('" + dtpPROFORMA_INVOICE_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')");
          


            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            //update Request
            glb_function.arrInsertLogs.Add("delete from PURCHASES_ORDER_DETAILS where header_id=" + txtSwid.Text.Trim());
            glb_function.arrInsertLogs.Add("delete from PURCHASE_Expenses where header_id=" + txtSwid.Text.Trim());

            glb_function.arrInsertLogs.Add("update PURCHASES_ORDER_HEADER set " +
            " SUPPLIER_ID=" + txtSUPPLIER_ID.Text + "," +
              "PURCHASE_ORDER_NUM='" + txtPURCHASE_ORDER_NUM.Text + "',SHIPPING_Way='" + lstSHIPPING_Way.Text + "',PROFORMA_INVOICE_NUM='" + txtPROFORMA_INVOICE_NUM.Text + "'," +
              "PROFORMA_INVOICE_date =" + strPROFORMA_INVOICE + ",PURCHASE_ORDER_DATE= " + strPURCHASE_ORDER_DATE + "," +
              "CURRENCY_ID=" + lstCURRENCY_ID.SelectedValue.ToString() + ",CURRENCY_EXCHANGE=" + nmbCURRENCY_EXCHANGE.Value.ToString() + ",PAYMENT_AGREEMENT='" + txtPAYMENT_AGREEMENT.Text + "',TERMS_EXPENSES_ID=" + (txtTERMS_EXPENSES_ID.Text.Trim() == "" ? "null" : txtTERMS_EXPENSES_ID.Text.Trim()) + "," +
              "PORT_OF_LOADING='" + txtPORT_OF_LOADING.Text.Trim() + "',PORT_OF_DELIVERY='" + txtPORT_OF_DELIVERY.Text.Trim() + "' where swid="+txtSwid.Text .Trim());




            for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add(
                    "insert into PURCHASES_ORDER_DETAILS values((select nvl(max(swid),0)+1 from PURCHASES_ORDER_DETAILS)," +
                    "sysdate," + glb_function.glb_strUserId + ",'فعال'," + txtSwid.Text + "," +
                    "" + dgvPurQuotDetail[1, i].Value.ToString() + "," + dgvPurQuotDetail[7, i].Value.ToString() + "," +
                    "'" + dgvPurQuotDetail[9, i].Value.ToString() + "','" + dgvPurQuotDetail[8, i].Value.ToString() + "'," +
                    "'" + dgvPurQuotDetail[3, i].Value.ToString() + "'," + dgvPurQuotDetail[10, i].Value.ToString() + " )");
            }


            for (int i = 0; i < dgExpenss.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add("insert into PURCHASE_Expenses values((select nvl(max(swid),0)+1 from PURCHASE_Expenses)," +
                    txtSwid.Text + "," + dgExpenss[1, i].Value.ToString() + "," +
                    dgExpenss[3, i].Value.ToString() + ",'فعال'," +
                    "'امر الشراء'" + ")");
            }

            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);


        }

        private void btnGetQuotation_Click(object sender, EventArgs e)
        {
            frmGetQuotation frm = new frmGetQuotation();
            frm.strWhere = " and h.stat='عرض سعر'";
            frm.ShowDialog();

            txtPURCHASE_QUOTATIONS_ID.Text = frm.strQuotSwid;

            if (txtPURCHASE_QUOTATIONS_ID.Text.Trim() != "")
                GetDataFromQuotation(txtPURCHASE_QUOTATIONS_ID.Text.Trim());
        }
        private void GetDataFromQuotation(string strQuotSwid)
        {
            btnNew_Click(null, null);

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtQuotation = cnn.GetDataTable("select h.swid,h.request_number,h.supplier_id,h.shipping_way,h.currency_id,h.payment_agreement, "+
                    "  h.terms_expenses_id from PURCHASE_QUOTATIONS_HEADER h where swid="+strQuotSwid);


            txtPURCHASE_QUOTATIONS_ID.Text = strQuotSwid;
            txtPURCHASE_QUOTATIONS_No.Text = dtQuotation.Rows[0]["request_number"].ToString();

            txtSUPPLIER_ID.Text = dtQuotation.Rows[0]["supplier_id"].ToString();
            GetVendorData(txtSUPPLIER_ID.Text);

            lstSHIPPING_Way.Text = dtQuotation.Rows[0]["shipping_way"].ToString();
            lstCURRENCY_ID.SelectedValue = Convert.ToInt32(dtQuotation.Rows[0]["currency_id"].ToString());

            txtPAYMENT_AGREEMENT.Text = dtQuotation.Rows[0]["payment_agreement"].ToString();

            txtTERMS_EXPENSES_ID.Text = dtQuotation.Rows[0]["terms_expenses_id"].ToString();


            dtQuotation.Clear();

            dtQuotation = cnn.GetDataTable("select d.swid,d.item_id,i.item_name,d.item_supplier_id,d.item_supplier_number, "+
                                            "  d.item_supplier_name, d.item_info, d.qoutation_qty, d.free_qty, d.unit_price, d.current_stock_qty, " +
                                            "  im.itemid, i2.item_name itemName, i2.item_no itemno " +
                                            "  from Purchase_Quotations_Details d " +
                                            "  left outer join items i  on(d.item_id = i.swid) " +
                                            "  join item_supplier im on(im.swid = d.item_supplier_id) " +
                                            " left join items i2 on(i2.swid = im.itemid) " +
                                            " where    d.header_id = " +strQuotSwid);

            for (int i = 0; i < dtQuotation.Rows.Count; i++)
            {
                
                    dgvPurQuotDetail.Rows.Add();
                   
                dgvPurQuotDetail[0, i].Value = "";
                if(dtQuotation.Rows[i]["item_id"].ToString().Trim()!="")
                {
                    dgvPurQuotDetail[1, i].Value = dtQuotation.Rows[i]["item_id"].ToString();
                    dgvPurQuotDetail[2, i].Value = dtQuotation.Rows[i]["item_name"].ToString();
                }
                else
                {
                    dgvPurQuotDetail[1, i].Value = dtQuotation.Rows[i]["itemid"].ToString();
                    dgvPurQuotDetail[2, i].Value = dtQuotation.Rows[i]["itemname"].ToString();
                }
               


                dgvPurQuotDetail[3, i].Value = dtQuotation.Rows[i]["item_supplier_id"].ToString();
                dgvPurQuotDetail[4, i].Value = dtQuotation.Rows[i]["item_supplier_number"].ToString();
                dgvPurQuotDetail[5, i].Value = dtQuotation.Rows[i]["item_supplier_name"].ToString();
                dgvPurQuotDetail[6, i].Value = dtQuotation.Rows[i]["item_info"].ToString();
                dgvPurQuotDetail[7, i].Value = dtQuotation.Rows[i]["qoutation_qty"].ToString();
                dgvPurQuotDetail[8, i].Value = dtQuotation.Rows[i]["free_qty"].ToString();
                dgvPurQuotDetail[9, i].Value = dtQuotation.Rows[i]["unit_price"].ToString();
                dgvPurQuotDetail[10, i].Value = dtQuotation.Rows[i]["current_stock_qty"].ToString();
                dgvPurQuotDetail[11, i].Value = Convert.ToDouble(dgvPurQuotDetail[7, i].Value) * Convert.ToDouble(dgvPurQuotDetail[9, i].Value);


               
            }



            dtQuotation.Clear();
            dtQuotation = cnn.GetDataTable("select ex.expenses_id,ex.expenses_value,itmEx.Expenses_Name from PURCHASE_Expenses ex,EXPENSES_ITEM itmEx "+
                           " where ex.expenses_id = itmEx.Swid and  ex.expensess_type = 'عرض سعر' "+
                           " and ex.header_id = "+ strQuotSwid);


            for (int i = 0; i < dtQuotation.Rows.Count; i++)
            {
                dgExpenss.Rows.Add();
                dgExpenss[0, i].Value = "";
                dgExpenss[1, i].Value = dtQuotation.Rows[i]["expenses_id"].ToString();
                dgExpenss[2, i].Value = dtQuotation.Rows[i]["Expenses_Name"].ToString();
                dgExpenss[3, i].Value = dtQuotation.Rows[i]["expenses_value"].ToString();
            }

            SumTotal();

        }
        private void SumTotal()
        {
            decimal dSum = 0;
            for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
            {
                dgvPurQuotDetail[clmDetailTotal.Index, i].Value = Convert.ToDecimal(dgvPurQuotDetail[clmDetailQty.Index, i].Value) * Convert.ToDecimal(dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value);
                dSum = dSum + Convert.ToDecimal(dgvPurQuotDetail[clmDetailTotal.Index, i].Value);

            }

            nmbTotal.Value = Math.Round(dSum, nmbTotal.DecimalPlaces);

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            PrepareForm();
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
            DataTable dtExpDetail = cnn.GetDataTable("select d.expenses_item_id,ei.expenses_name " +
                                       " from terms_expenses_details d " +
                                       " join expenses_item ei on (d.expenses_item_id = ei.swid) " +
                                       " where d.expenses_header_id = " + strTermHeaderId);

            for (int i = 0; i < dtExpDetail.Rows.Count; i++)
            {
                dgExpenss.Rows.Add();
                dgExpenss[clmExpSwid.Index, dgExpenss.Rows.Count - 1].Value = "";
                dgExpenss[clmExpExpenssItemId.Index, dgExpenss.Rows.Count - 1].Value = dtExpDetail.Rows[i]["expenses_item_id"].ToString();
                dgExpenss[clmExpName.Index, dgExpenss.Rows.Count - 1].Value = dtExpDetail.Rows[i]["expenses_name"].ToString();
                dgExpenss[clmExpValue.Index, dgExpenss.Rows.Count - 1].Value = "0";
            }


        }

        private void GetTermsExpensess(string strTermSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTerm = cnn.GetDataTable("select  TERMS_NAME from TERMS_EXPENSES_HEADER where swid= " + strTermSwid);
            txtTERMS_OF_EXPENSES_name.Text = dtTerm.Rows[0][0].ToString();
        }
        private void btnGetPurchaseOrder_Click(object sender, EventArgs e)
        {
            frmGetPurchaseOrder frm = new frmGetPurchaseOrder();
           frm.strWhere = " and h.stat in ('فعال') and h.branch_id= "+lstBranchHeader.SelectedValue.ToString();
            frm.ShowDialog();

            txtSwid.Text = frm.strOrderSwid;

            if (txtSwid.Text.Trim() != "")
                GetData(txtSwid.Text);
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

        private void btnAddExpeness_Click(object sender, EventArgs e)
        {
            if (txtSwid.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار امر الشراء");
                return;
            }

            Purchases.frmPrecurementExpensess frm = new Purchases.frmPrecurementExpensess();
            frm.txtISSUED_ID.Text = txtSwid.Text;
            frm.txtISSUED_TYPE.Text = "امر الشراء";
            frm.txtTempletId.Text = lstTemplet.SelectedValue.ToString();
           
            frm.ShowDialog();
        }

        private void nmbExpEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void dgExpenss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            if (e.ColumnIndex == 4)
                dgExpenss.Rows.Remove(dgExpenss.Rows[e.RowIndex]);
            else if (clmExpValue.Index == e.ColumnIndex)
            {


                dgExpenss.RightToLeft = RightToLeft.No;
                DataGridViewCell abc = dgExpenss.CurrentCell;
                Rectangle RECT = dgExpenss.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
                dgExpenss.RightToLeft = RightToLeft.Yes;


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

        private void nmbExpEditor_Leave(object sender, EventArgs e)
        {
            if (nmbExpEditor.Visible == true)
            {
                nmbExpEditor.Visible = false;

                dgExpenss[clmExpValue.Index, dgExpenss.CurrentRow.Index].Value = nmbExpEditor.Value.ToString();


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
    }
}
