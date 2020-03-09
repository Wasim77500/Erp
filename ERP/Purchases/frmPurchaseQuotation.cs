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
    public partial class frmPurchaseQuotation : MyForm
    {
        int iRow = -1;
        public frmPurchaseQuotation()
        {
            InitializeComponent();
        }

        private void frmPurchaseQuotation_Load(object sender, EventArgs e)
        {
            PrepareForm();
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
        private void PrepareForm()
        {
            glb_function.FillListWithId(ref lstCURRENCY_ID, "currency", "curr_name");
        }

        private void btnGetVendor_Click(object sender, EventArgs e)
        {
            Purchases.frmFindVendor frm = new Purchases.frmFindVendor();

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
        bool bItemCheck = false;//take item from supplierItem and take supplierItem from item infinity loop
        private void btnFindItem_Click(object sender, EventArgs e)
        {
            if (txtSUPPLIER_ID.Text == "" && txtSUPPLIER_Name.Text == "")
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
            DataTable dtItems = cnn.GetDataTable("select item_no,item_name,(select s.swid from item_supplier s where s.itemid=i.swid and s.people_id="+txtSUPPLIER_ID.Text +") supplierItem from items i where swid=" + strItemSwid);

            txtItemNo.Text = dtItems.Rows[0]["item_no"].ToString();
            txtItemName.Text = dtItems.Rows[0]["item_name"].ToString();
            if(dtItems.Rows[0]["supplierItem"].ToString().Trim()!="" && bItemCheck == false)
            {
              
                bItemCheck = true;
                GetSuplierItemData(dtItems.Rows[0]["supplierItem"].ToString().Trim());
            }
            bItemCheck = false;



        }

        private void btnGetSupplierItem_Click(object sender, EventArgs e)
        {
            if(txtSUPPLIER_ID.Text =="" && txtSUPPLIER_Name.Text =="")
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
        private void GetSuplierItemData(string strSuplierSwid)
        {
          


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtSupllierItems = cnn.GetDataTable("select swid,item_no,Item_name,itemid From item_supplier where swid=" + strSuplierSwid);

            txtITEM_SUPPLIER_NUMBER.Text = dtSupllierItems.Rows[0]["item_no"].ToString();
            txtITEM_SUPPLIER_NAME.Text = dtSupllierItems.Rows[0]["Item_name"].ToString();
            if (dtSupllierItems.Rows[0]["itemid"].ToString().Trim()!="" && bItemCheck==false )
            {
                

                bItemCheck = true;
                GetItemData(dtSupllierItems.Rows[0]["itemid"].ToString().Trim());
            }
            bItemCheck = false ;
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

        private void btnAddExpenss_Click(object sender, EventArgs e)
        {
           if( txtEXPENSES_ID.Text.Trim()=="" || txtEXPENSES_Name.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء اختيار المصروف اولا");
                btnGetExpenss.Focus();
                return;
            }
           if(nmbExpenssItem.Value<=0)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSUPPLIER_ID.Text.Trim() == "" || txtSUPPLIER_Name.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال المورد");
                btnGetVendor.Focus();
                return;
            }
            if(txtITEM_SUPPLIER_NUMBER.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء ادخال رقم الصنف  عند المورد");
                txtITEM_SUPPLIER_NUMBER.Focus();
                return;
            }
            if(txtITEM_SUPPLIER_NAME.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء ادخال اسم الصنف عند المورد");
                txtITEM_SUPPLIER_NAME.Focus();
                return;
            }

            if(nmbREQUESTED_QTY.Value <=0 && nmbFREE_QTY.Value <=0)
            {
                glb_function.MsgBox("الرجاء ادخال الكمية المطلوبة");
                nmbREQUESTED_QTY.Focus();
                return;
            }
            
          

            if(iRow==-1)
            {
                dgvPurQuotDetail.Rows.Add();
                iRow = dgvPurQuotDetail.Rows.Count - 1;
                dgvPurQuotDetail[0, iRow].Value = "";
            }
           
            dgvPurQuotDetail[1, iRow].Value = txtItemId.Text .Trim();
            dgvPurQuotDetail[2, iRow].Value = txtItemName.Text .Trim();
            dgvPurQuotDetail[3, iRow].Value = txtITEM_SUPPLIER_Id.Text.Trim();
            dgvPurQuotDetail[4, iRow].Value = txtITEM_SUPPLIER_NUMBER.Text.Trim() ;
            dgvPurQuotDetail[5, iRow].Value = txtITEM_SUPPLIER_NAME.Text.Trim() ;
            dgvPurQuotDetail[6, iRow].Value = txtITEM_INFO.Text .Trim();
            dgvPurQuotDetail[7, iRow].Value = txtALTERNATIVE_ITEM_Id.Text .Trim();
            dgvPurQuotDetail[8, iRow].Value = txtALTERNATIVE_ITEM_Name.Text.Trim();
            dgvPurQuotDetail[9, iRow].Value = nmbREQUESTED_QTY.Value.ToString();
            dgvPurQuotDetail[10, iRow].Value = nmbQOUTATION_QTY.Value.ToString();
            dgvPurQuotDetail[11, iRow].Value = nmbFREE_QTY.Value.ToString();
            dgvPurQuotDetail[12, iRow].Value = nmbUNIT_PRICE.Value.ToString();
            dgvPurQuotDetail[13, iRow].Value = nmbCURRENT_STOCK_QTY.Text.ToString();
            dgvPurQuotDetail[14, iRow].Value = "";
            dgvPurQuotDetail[15, iRow].Value = Convert.ToDouble(dgvPurQuotDetail[10, iRow].Value)* Convert.ToDouble(dgvPurQuotDetail[12, iRow].Value);

            iRow = -1;


            SumTotal();

            txtItemId.Text = "";
            txtItemName.Text = "";
            txtITEM_SUPPLIER_Id.Text = "";
            txtITEM_SUPPLIER_NUMBER.Text = "";
            txtITEM_SUPPLIER_NAME.Text = "";
            txtITEM_INFO.Text = "";
            txtALTERNATIVE_ITEM_Id.Text = "";
            txtALTERNATIVE_ITEM_Name.Text = "";
            nmbREQUESTED_QTY.Value = 0;
            nmbQOUTATION_QTY.Value = 0;
            nmbFREE_QTY.Value = 0;
            nmbUNIT_PRICE.Value = 0;
            nmbCURRENT_STOCK_QTY.Text = "0";

        }
        private void SumTotal()
        {
            decimal dSum = 0;
            for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
            {
                dgvPurQuotDetail[clmDetailTotal.Index, i].Value = Convert.ToDecimal(dgvPurQuotDetail[clmDetailQtyQout.Index, i].Value) * Convert.ToDecimal(dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value);
                dSum = dSum +Convert.ToDecimal( dgvPurQuotDetail[clmDetailTotal.Index, i].Value);

            }

            nmbTotal.Value = Math.Round(dSum, nmbTotal.DecimalPlaces);
           
        }
        private void btnGetAlternativeItem_Click(object sender, EventArgs e)
        {
            Inventory.frmFindItem frm = new Inventory.frmFindItem();

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtALTERNATIVE_ITEM_Id.Text = frm.strItemID;
                GetAlternativeItemData(txtALTERNATIVE_ITEM_Id.Text);

            }
        }
        private void GetAlternativeItemData(string strItemSwid)
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems = cnn.GetDataTable("select item_no,item_name from items where swid=" + strItemSwid);

            txtALTERNATIVE_ITEM_No.Text = dtItems.Rows[0]["item_no"].ToString();
            txtALTERNATIVE_ITEM_Name.Text = dtItems.Rows[0]["item_name"].ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            if(txtSwid.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء اختيار عرض سعر او ارسالية للالغاء");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("update PURCHASE_QUOTATIONS_HEADER set stat='ملغي' where swid="+txtSwid.Text );

            if(icheck <=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الالغاء");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الالغاء بنجاح");
            new glb_function().clearItems(this);

        }

        private void btnToRequst_Click(object sender, EventArgs e)
        {
            if (!CheckRequestEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            DataTable dtQuotHeader = new DataTable();


            string strDELIVERY_TIME = (dtpDELIVERY_TIME.Checked == false ? "null" : "to_date('" + dtpDELIVERY_TIME.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')");
            string strQUOTATION_DATE = (dtpQUOTATION_DATE.Checked == false ? "null" : "to_date('" + dtpQUOTATION_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')");
            string strCurrency = (lstCURRENCY_ID.SelectedIndex == -1 ? "null" : lstCURRENCY_ID.SelectedValue.ToString());

            if (txtStat.Text.Trim()=="" || txtStat.Text.Trim() == "عرض سعر")
            {
                //new Request

                dtQuotHeader = cnn.GetDataTable("select nvl(max(swid),0)+1 from PURCHASE_QUOTATIONS_HEADER");
                txtSwid.Text = dtQuotHeader.Rows[0][0].ToString();

                if(txtStat.Text.Trim() == "")
                {
                    dtQuotHeader.Clear();
                    dtQuotHeader = cnn.GetDataTable("select nvl(max(REQUEST_NUMBER),to_number(to_char(sysdate,'yyyy')||'0000'))+1 from PURCHASE_QUOTATIONS_HEADER where to_char(created_date,'yyyy')=to_char(sysdate,'yyyy')");
                    txtREQUEST_NUMBER.Text = dtQuotHeader.Rows[0][0].ToString();

                }

                dtQuotHeader.Clear();
                dtQuotHeader = cnn.GetDataTable("select nvl(max(REQUEST_VERSION_NUMBER),0)+1 from PURCHASE_QUOTATIONS_HEADER where REQUEST_NUMBER="+ txtREQUEST_NUMBER.Text );
                txtREQUEST_VERSION_NUMBER.Text = dtQuotHeader.Rows[0][0].ToString();

                
               
                txtStat.Text = "ارسالية";


                glb_function.arrInsertLogs.Add("insert into PURCHASE_QUOTATIONS_HEADER values("+txtSwid.Text +",sysdate,"+
                    glb_function.glb_strUserId+",'"+txtStat.Text +"',"+txtSUPPLIER_ID.Text + ","+
                     "'"+ txtCONTACT_ADDRESS.Text + "','"+lstSHIPPING_Way.Text +"',"+ txtREQUEST_NUMBER .Text + ","+
                     txtREQUEST_VERSION_NUMBER.Text +",sysdate,"+strDELIVERY_TIME +",'"+txtSUPPLIER_QUOTATION_NUMBER.Text +"',"+
                     ""+strQUOTATION_DATE  +","+ strCurrency + ",'"+ txtPAYMENT_AGREEMENT .Text + "','"+ txtPAYMENT_AGREEMENT_INFO .Text + "',"+( txtTERMS_EXPENSES_ID.Text.Trim()==""?"null": txtTERMS_EXPENSES_ID.Text.Trim()) + ")");


               

                for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
                {


                    if(dgvPurQuotDetail ["clmDetailSuppItmId", i].Value.ToString()=="")
                    {
                        dtQuotHeader.Clear();
                        dtQuotHeader = cnn.GetDataTable("select nvl(max(swid),0)+1 from ITEM_SUPPLIER");
                       dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value = dtQuotHeader.Rows[0][0].ToString();
                        glb_function.arrInsertLogs.Add("insert into ITEM_SUPPLIER values((" + dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value .ToString()+ "),sysdate," +
                   "'فعال',null,'" + dgvPurQuotDetail[clmDetailSuppItmNo.Index, i].Value.ToString() + "','" + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + "'," + txtSUPPLIER_ID.Text .Trim() + "," + glb_function.glb_strUserId + ",'" + dgvPurQuotDetail["clmDetailSuppItmInf", i].Value.ToString() + "')");
                    }

                    glb_function.arrInsertLogs.Add(
                        "insert into PURCHASE_QUOTATIONS_DETAILS values((select nvl(max(swid),0)+1 from PURCHASE_QUOTATIONS_DETAILS),"+
                        "sysdate,"+glb_function.glb_strUserId +",'فعال',"+txtSwid.Text +","+
                        ""  + (dgvPurQuotDetail[clmDetailItemId.Index,i].Value.ToString()==""?"null": dgvPurQuotDetail[clmDetailItemId.Index, i].Value.ToString()) +","+ dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value.ToString()+","+
                        "'" + dgvPurQuotDetail[clmDetailSuppItmNo.Index, i].Value.ToString() + "','" + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + "'," +
                        "'" + dgvPurQuotDetail[clmDetailSuppItmInf.Index, i].Value.ToString() + "'," + (dgvPurQuotDetail[clmDetailAlternItmId.Index, i].Value.ToString()==""?"null": dgvPurQuotDetail[clmDetailAlternItmId.Index, i].Value.ToString()) + "," +
                        "" + dgvPurQuotDetail[clmDetailQtyOrder.Index, i].Value.ToString() + "," + dgvPurQuotDetail[clmDetailQtyQout.Index, i].Value.ToString() + "," +
                        "" + dgvPurQuotDetail[clmDetailFreeQty.Index, i].Value.ToString() + "," + dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString() + "," +
                        "" + (dgvPurQuotDetail[clmDetailCurrntQty.Index, i].Value.ToString()==""?"null": dgvPurQuotDetail[clmDetailCurrntQty.Index, i].Value.ToString()) + ",null)");
                }


                for (int i = 0; i < dgExpenss.Rows.Count; i++)
                {
                    glb_function.arrInsertLogs.Add("insert into PURCHASE_Expenses values((select nvl(max(swid),0)+1 from PURCHASE_Expenses)," +
                        txtSwid.Text + "," + dgExpenss[1, i].Value.ToString() + "," +
                        dgExpenss[3, i].Value.ToString() + ",'فعال'," +
                        "'عرض سعر'" + ")");
                }


            }
            else if(txtStat.Text.Trim()=="ارسالية")
            {
                glb_function.arrInsertLogs = new System.Collections.ArrayList();
                //update Request
                glb_function.arrInsertLogs.Add("delete from PURCHASE_QUOTATIONS_DETAILS where header_id="+txtSwid.Text.Trim() );
                glb_function.arrInsertLogs.Add("delete from PURCHASE_Expenses where header_id=" + txtSwid.Text.Trim());

                glb_function.arrInsertLogs.Add("update PURCHASE_QUOTATIONS_HEADER set stat='" + txtStat.Text + "'," +
                    "SUPPLIER_ID=" + txtSUPPLIER_ID.Text + "," +
                    "CONTACT_ADDRESS='" + txtCONTACT_ADDRESS.Text + "',SHIPPING_Way='" + lstSHIPPING_Way.Text + "',REQUEST_NUMBER=" + txtREQUEST_NUMBER.Text + "," +
                    "REQUEST_VERSION_NUMBER="+txtREQUEST_VERSION_NUMBER.Text + ",DELIVERY_TIME=" + strDELIVERY_TIME + ",SUPPLIER_QUOTATION_NUMBER='" + txtSUPPLIER_QUOTATION_NUMBER.Text + "'," +
                    "QUOTATION_DATE=" + strQUOTATION_DATE + ",CURRENCY_ID=" + strCurrency + ",PAYMENT_AGREEMENT='" + txtPAYMENT_AGREEMENT.Text + "',PAYMENT_AGREEMENT_INFO='" + txtPAYMENT_AGREEMENT_INFO.Text + "',TERMS_EXPENSES_ID=" + (txtTERMS_EXPENSES_ID.Text.Trim() == "" ? "null" : txtTERMS_EXPENSES_ID.Text.Trim()) + " where swid="+txtSwid.Text.Trim() );



                for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
                {
                    if (dgvPurQuotDetail["clmDetailSuppItmId", i].Value.ToString() == "")
                    {
                        dtQuotHeader.Clear();
                        dtQuotHeader = cnn.GetDataTable("select nvl(max(swid),0)+1 from ITEM_SUPPLIER");
                        dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value = dtQuotHeader.Rows[0][0].ToString();
                        glb_function.arrInsertLogs.Add("insert into ITEM_SUPPLIER values((" + dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value.ToString() + "),sysdate," +
                   "'فعال',null,'" + dgvPurQuotDetail[clmDetailSuppItmNo.Index, i].Value.ToString() + "','" + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + "'," + txtSUPPLIER_ID.Text.Trim() + "," + glb_function.glb_strUserId + ",'" + dgvPurQuotDetail["clmDetailSuppItmInf", i].Value.ToString() + "')");
                    }

                    glb_function.arrInsertLogs.Add(
                        "insert into PURCHASE_QUOTATIONS_DETAILS values((select nvl(max(swid),0)+1 from PURCHASE_QUOTATIONS_DETAILS)," +
                        "sysdate," + glb_function.glb_strUserId + ",'فعال'," + txtSwid.Text + "," +
                        "" + (dgvPurQuotDetail[clmDetailItemId.Index, i].Value.ToString() == "" ? "null" : dgvPurQuotDetail[clmDetailItemId.Index, i].Value.ToString()) + "," + dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value.ToString() + "," +
                        "'" + dgvPurQuotDetail[clmDetailSuppItmNo.Index, i].Value.ToString() + "','" + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + "'," +
                        "'" + dgvPurQuotDetail[clmDetailSuppItmInf.Index, i].Value.ToString() + "'," + (dgvPurQuotDetail[clmDetailAlternItmId.Index, i].Value.ToString() == "" ? "null" : dgvPurQuotDetail[clmDetailAlternItmId.Index, i].Value.ToString()) + "," +
                        "" + dgvPurQuotDetail[clmDetailQtyOrder.Index, i].Value.ToString() + "," + dgvPurQuotDetail[clmDetailQtyQout.Index, i].Value.ToString() + "," +
                        "" + dgvPurQuotDetail[clmDetailFreeQty.Index, i].Value.ToString() + "," + dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString() + "," +
                        "" + (dgvPurQuotDetail[clmDetailCurrntQty.Index, i].Value.ToString() == "" ? "null" : dgvPurQuotDetail[clmDetailCurrntQty.Index, i].Value.ToString()) + ",null)");
                }


                for (int i = 0; i < dgExpenss.Rows.Count; i++)
                {
                    glb_function.arrInsertLogs.Add("insert into PURCHASE_Expenses values((select nvl(max(swid),0)+1 from PURCHASE_Expenses)," +
                        txtSwid.Text.Trim() + "," + dgExpenss[1, i].Value.ToString() + "," +
                        dgExpenss[3, i].Value.ToString() + ",'فعال'," +
                        "'عرض سعر'" + ")");
                }

            }
           
            else
            {
                glb_function.MsgBox("حالة الطلب غير معروفة للتحويل");
                return;
            }


            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);


        }
        private void GetData(string strSwid)
        {
            btnNew_Click(null, null);
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtQuotation = cnn.GetDataTable("select swid, stat, supplier_id, "+
                            " contact_address, shipping_way, request_number, request_version_number,"+
                            " request_date, delivery_time, supplier_quotation_number, "+
                            " quotation_date, currency_id, payment_agreement, payment_agreement_info, "+
                            "terms_expenses_id,branch_id from PURCHASE_QUOTATIONS_HEADER where swid= " + strSwid);

           
            txtSwid.Text = dtQuotation.Rows[0]["swid"].ToString();
            txtStat.Text = dtQuotation.Rows[0]["stat"].ToString();
            txtSUPPLIER_ID.Text = dtQuotation.Rows[0]["supplier_id"].ToString();
            GetVendorData(txtSUPPLIER_ID.Text);
            txtCONTACT_ADDRESS.Text = dtQuotation.Rows[0]["contact_address"].ToString();
            lstSHIPPING_Way.Text = dtQuotation.Rows[0]["shipping_way"].ToString();
            txtREQUEST_NUMBER.Text = dtQuotation.Rows[0]["request_number"].ToString();
            txtREQUEST_VERSION_NUMBER.Text= dtQuotation.Rows[0]["request_version_number"].ToString();
            dtpDELIVERY_TIME.Value = Convert.ToDateTime(dtQuotation.Rows[0]["delivery_time"].ToString());

            txtSUPPLIER_QUOTATION_NUMBER.Text = dtQuotation.Rows[0]["supplier_quotation_number"].ToString();
            dtpQUOTATION_DATE.Value = Convert.ToDateTime(dtQuotation.Rows[0]["quotation_date"].ToString());

            lstCURRENCY_ID.SelectedValue = Convert.ToInt16(dtQuotation.Rows[0]["currency_id"].ToString());
            txtPAYMENT_AGREEMENT.Text = dtQuotation.Rows[0]["payment_agreement"].ToString();

            txtPAYMENT_AGREEMENT_INFO.Text = dtQuotation.Rows[0]["payment_agreement_info"].ToString();
            txtTERMS_EXPENSES_ID.Text = dtQuotation.Rows[0]["terms_expenses_id"].ToString();
            GetTermsExpensess(txtTERMS_EXPENSES_ID.Text);
            dtQuotation.Clear();

            dtQuotation = cnn.GetDataTable("select swid, item_id,(select i.item_name from items i where i.swid=d.item_id) item_name, item_supplier_id, item_supplier_number, item_supplier_name," +
                   "  item_info, alternative_item_id,(select a.item_name from items a where a.swid=d.alternative_item_id )alternateive_name, requested_qty, qoutation_qty, free_qty, unit_price, " +
                     "   current_stock_qty, unit " +
                    "    from purchase_quotations_details d " +
                    "    where d.header_id = "+txtSwid.Text );


            for (int i = 0; i < dtQuotation.Rows.Count; i++)
            {
                dgvPurQuotDetail.Rows.Add();
                dgvPurQuotDetail[clmDetailSwid.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["swid"].ToString();
                dgvPurQuotDetail[clmDetailItemId.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["item_id"].ToString();
                dgvPurQuotDetail[clmDetailItemName.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["item_name"].ToString();
                dgvPurQuotDetail[clmDetailSuppItmId.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["item_supplier_id"].ToString();
                dgvPurQuotDetail[clmDetailSuppItmNo.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["item_supplier_number"].ToString();
                dgvPurQuotDetail[clmDetailSuppItmName.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["item_supplier_name"].ToString();
                dgvPurQuotDetail[clmDetailSuppItmInf.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["item_info"].ToString();
                dgvPurQuotDetail[clmDetailAlternItmId.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["alternative_item_id"].ToString();
                dgvPurQuotDetail[clmDetailAlternItmName.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["alternateive_name"].ToString();

                dgvPurQuotDetail[clmDetailQtyOrder.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["requested_qty"].ToString();
                dgvPurQuotDetail[clmDetailQtyQout.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["qoutation_qty"].ToString();
                dgvPurQuotDetail[clmDetailFreeQty.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["free_qty"].ToString();
                dgvPurQuotDetail[clmDetailUnitPrice.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["unit_price"].ToString();
                dgvPurQuotDetail[clmDetailCurrntQty.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["current_stock_qty"].ToString();
                dgvPurQuotDetail[clmDetailUnit.Index, dgvPurQuotDetail.Rows.Count - 1].Value = dtQuotation.Rows[i]["unit"].ToString();
                dgvPurQuotDetail[clmDetailTotal.Index, dgvPurQuotDetail.Rows.Count - 1].Value = Convert.ToDouble(dgvPurQuotDetail[clmDetailQtyQout.Index, dgvPurQuotDetail.Rows.Count - 1].Value) * Convert.ToDouble(dgvPurQuotDetail[clmDetailUnitPrice.Index, dgvPurQuotDetail.Rows.Count - 1].Value);

                


            }

            dtQuotation.Clear();
            dtQuotation = cnn.GetDataTable("select pe.swid,pe.expenses_id,ei.expenses_name,pe.expenses_value from PURCHASE_Expenses pe join EXPENSES_ITEM ei "+
                               " on(pe.expenses_id = ei.swid)"+
                               " where pe.header_id = "+ txtSwid.Text );

            for (int i = 0; i < dtQuotation.Rows.Count; i++)
            {
                dgExpenss.Rows.Add();
                dgExpenss[clmExpSwid.Index, dgExpenss.Rows.Count - 1].Value = dtQuotation.Rows[i]["swid"];
                dgExpenss[clmExpExpenssItemId.Index, dgExpenss.Rows.Count - 1].Value = dtQuotation.Rows[i]["expenses_id"];
                dgExpenss[clmExpName.Index, dgExpenss.Rows.Count - 1].Value = dtQuotation.Rows[i]["expenses_name"];
                dgExpenss[clmExpValue.Index, dgExpenss.Rows.Count - 1].Value = dtQuotation.Rows[i]["expenses_value"];

            }

            SumTotal();
        }
        private bool CheckRequestEntries()
        {
            //if (!glb_function.AcceptTrans)
            //    return false;
            if (glb_function.MsgBox("هل أنت متاكد من اتمام العملية؟", "", true) == false)
                return false;

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

            if (txtStat.Text.Trim() == "عرض سعر")
              if (lstCURRENCY_ID.SelectedIndex ==-1)
            {

                errCheck.SetError(lstCURRENCY_ID, "الرجاء اختيار العملة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstCURRENCY_ID, "");
            }

            if (dgvPurQuotDetail.Rows.Count <=0)
            {
                glb_function.MsgBox("لايوجد بيانات للاصناف");
                return false;
            }

            if(txtStat.Text.Trim()=="عرض سعر")
            {
                for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
                {
                    if(Convert.ToDecimal(dgvPurQuotDetail[clmDetailFreeQty.Index, i].Value.ToString()) > 0)
                    {
                        if (Convert.ToDecimal(dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString()) <= 0 && Convert.ToDecimal(dgvPurQuotDetail[clmDetailQtyQout.Index, i].Value.ToString()) > 0)
                        {
                            glb_function.MsgBox("الصنف " + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + ": " + "ليس مسعرا");
                            return false;
                        }
                        if (Convert.ToDecimal(dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString()) > 0 && Convert.ToDecimal(dgvPurQuotDetail[clmDetailQtyQout.Index, i].Value.ToString()) <= 0)
                        {
                            glb_function.MsgBox("الصنف " + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + ": " + "ليس لديه كمية");
                            return false;
                        }

                    }
                    else
                    {
                        if (Convert.ToDecimal(dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString()) <= 0 )
                        {
                            glb_function.MsgBox("الصنف " + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + ": " + "ليس مسعرا");
                            return false;
                        }
                        if ( Convert.ToDecimal(dgvPurQuotDetail[clmDetailQtyQout.Index, i].Value.ToString()) <= 0)
                        {
                            glb_function.MsgBox("الصنف " + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + ": " + "ليس لديه كمية");
                            return false;
                        }
                    }
                  
                }
               
            }
            for (int i = 0; i < dgExpenss.Rows.Count; i++)
            {
                if(Convert.ToDecimal ( dgExpenss[clmExpValue.Index ,i].Value )<=0)
                {
                    glb_function.MsgBox("يوجد مبلغ غير مدخل في المصاريف");
                    return false ;
                }
            }
            if (iError == 1)
                return false;

            return true;
        }
        private bool CheckQoutationEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

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



            if (iError == 1)
                return false;

            return true;
        }

        private void btnToQuotation_Click(object sender, EventArgs e)
        {

            string strStatTemp = txtStat.Text;
            txtStat.Text = "عرض سعر";
           
            if (!CheckRequestEntries())
            {
                txtStat.Text = strStatTemp;
                return;
            }
                

            txtStat.Text = strStatTemp;

          ConnectionToDB cnn = new ConnectionToDB();
            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            DataTable dtQuotHeader = new DataTable();


            string strDELIVERY_TIME = (dtpDELIVERY_TIME.Checked == false ? "null" : "to_date('" + dtpDELIVERY_TIME.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')");
            string strQUOTATION_DATE = (dtpQUOTATION_DATE.Checked == false ? "null" : "to_date('" + dtpQUOTATION_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')");
            string strCurrency = (lstCURRENCY_ID.SelectedIndex == -1 ? "null" : lstCURRENCY_ID.SelectedValue.ToString());

            if (txtStat.Text.Trim() == "" || txtStat.Text.Trim() == "ارسالية" )
            {
                //new Request

                dtQuotHeader = cnn.GetDataTable("select nvl(max(swid),0)+1 from PURCHASE_QUOTATIONS_HEADER");
                txtSwid.Text = dtQuotHeader.Rows[0][0].ToString();

                if (txtStat.Text.Trim() == "")
                {
                    dtQuotHeader.Clear();
                    dtQuotHeader = cnn.GetDataTable("select nvl(max(REQUEST_NUMBER),to_number(to_char(sysdate,'yyyy')||'0000'))+1 from PURCHASE_QUOTATIONS_HEADER where to_char(created_date,'yyyy')=to_char(sysdate,'yyyy')");
                    txtREQUEST_NUMBER.Text = dtQuotHeader.Rows[0][0].ToString();

                }

                //dtQuotHeader.Clear();
                //dtQuotHeader = cnn.GetDataTable("select nvl(max(REQUEST_VERSION_NUMBER),0)+1 from PURCHASE_QUOTATIONS_HEADER where REQUEST_NUMBER=" + txtREQUEST_NUMBER.Text);
                //txtREQUEST_VERSION_NUMBER.Text = dtQuotHeader.Rows[0][0].ToString();



                txtStat.Text = "عرض سعر";


                glb_function.arrInsertLogs.Add("insert into PURCHASE_QUOTATIONS_HEADER values(" + txtSwid.Text + ",sysdate," +
                    glb_function.glb_strUserId + ",'" + txtStat.Text + "'," + txtSUPPLIER_ID.Text + "," +
                     "'" + txtCONTACT_ADDRESS.Text + "','" + lstSHIPPING_Way.Text + "'," + txtREQUEST_NUMBER.Text + "," +
                    ( txtREQUEST_VERSION_NUMBER.Text.Trim()==""?"null":txtREQUEST_VERSION_NUMBER.Text .Trim())+ ",sysdate," + strDELIVERY_TIME + ",'" + txtSUPPLIER_QUOTATION_NUMBER.Text + "'," +
                     "" + strQUOTATION_DATE + "," + strCurrency + ",'" + txtPAYMENT_AGREEMENT.Text + "','" + txtPAYMENT_AGREEMENT_INFO.Text + "'," + (txtTERMS_EXPENSES_ID.Text.Trim() == "" ? "null" : txtTERMS_EXPENSES_ID.Text.Trim()) + ")");




                for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
                {


                    if (dgvPurQuotDetail["clmDetailSuppItmId", i].Value.ToString() == "")
                    {
                        dtQuotHeader.Clear();
                        dtQuotHeader = cnn.GetDataTable("select nvl(max(swid),0)+1 from ITEM_SUPPLIER");
                        dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value = dtQuotHeader.Rows[0][0].ToString();
                        glb_function.arrInsertLogs.Add("insert into ITEM_SUPPLIER values((" + dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value.ToString() + "),sysdate," +
                   "'فعال',null,'" + dgvPurQuotDetail[clmDetailSuppItmNo.Index, i].Value.ToString() + "','" + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + "'," + txtSUPPLIER_ID.Text.Trim() + "," + glb_function.glb_strUserId + ",'" + dgvPurQuotDetail["clmDetailSuppItmInf", i].Value.ToString() + "')");
                    }

                    glb_function.arrInsertLogs.Add(
                        "insert into PURCHASE_QUOTATIONS_DETAILS values((select nvl(max(swid),0)+1 from PURCHASE_QUOTATIONS_DETAILS)," +
                        "sysdate," + glb_function.glb_strUserId + ",'فعال'," + txtSwid.Text + "," +
                        "" + (dgvPurQuotDetail[clmDetailItemId.Index, i].Value.ToString() == "" ? "null" : dgvPurQuotDetail[clmDetailItemId.Index, i].Value.ToString()) + "," + dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value.ToString() + "," +
                        "'" + dgvPurQuotDetail[clmDetailSuppItmNo.Index, i].Value.ToString() + "','" + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + "'," +
                        "'" + dgvPurQuotDetail[clmDetailSuppItmInf.Index, i].Value.ToString() + "'," + (dgvPurQuotDetail[clmDetailAlternItmId.Index, i].Value.ToString() == "" ? "null" : dgvPurQuotDetail[clmDetailAlternItmId.Index, i].Value.ToString()) + "," +
                        "" + dgvPurQuotDetail[clmDetailQtyOrder.Index, i].Value.ToString() + "," + dgvPurQuotDetail[clmDetailQtyQout.Index, i].Value.ToString() + "," +
                        "" + dgvPurQuotDetail[clmDetailFreeQty.Index, i].Value.ToString() + "," + dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString() + "," +
                        "" + (dgvPurQuotDetail[clmDetailCurrntQty.Index, i].Value.ToString() == "" ? "null" : dgvPurQuotDetail[clmDetailCurrntQty.Index, i].Value.ToString()) + ",null)");
                }


                for (int i = 0; i < dgExpenss.Rows.Count; i++)
                {
                    glb_function.arrInsertLogs.Add("insert into PURCHASE_Expenses values((select nvl(max(swid),0)+1 from PURCHASE_Expenses)," +
                        txtSwid.Text + "," + dgExpenss[1, i].Value.ToString() + "," +
                        dgExpenss[3, i].Value.ToString() + ",'فعال'," +
                        "'عرض سعر'" + ")");
                }


            }
            else if (txtStat.Text.Trim() == "عرض سعر")
            {
                glb_function.arrInsertLogs = new System.Collections.ArrayList();
                //update Request
                glb_function.arrInsertLogs.Add("delete from PURCHASE_QUOTATIONS_DETAILS where header_id=" + txtSwid.Text.Trim());
                glb_function.arrInsertLogs.Add("delete from PURCHASE_Expenses where header_id=" + txtSwid.Text.Trim());

                glb_function.arrInsertLogs.Add("update PURCHASE_QUOTATIONS_HEADER set stat='" + txtStat.Text + "'," +
                    "SUPPLIER_ID=" + txtSUPPLIER_ID.Text + "," +
                    "CONTACT_ADDRESS='" + txtCONTACT_ADDRESS.Text + "',SHIPPING_Way='" + lstSHIPPING_Way.Text + "',REQUEST_NUMBER=" + txtREQUEST_NUMBER.Text + "," +
                     "DELIVERY_TIME=" + strDELIVERY_TIME + ",SUPPLIER_QUOTATION_NUMBER='" + txtSUPPLIER_QUOTATION_NUMBER.Text + "'," +
                    "QUOTATION_DATE=" + strQUOTATION_DATE + ",CURRENCY_ID=" + strCurrency + ",PAYMENT_AGREEMENT='" + txtPAYMENT_AGREEMENT.Text + "',PAYMENT_AGREEMENT_INFO='" + txtPAYMENT_AGREEMENT_INFO.Text + "',TERMS_EXPENSES_ID=" + (txtTERMS_EXPENSES_ID.Text.Trim() == "" ? "null" : txtTERMS_EXPENSES_ID.Text.Trim()) + " where swid=" + txtSwid.Text.Trim());



                for (int i = 0; i < dgvPurQuotDetail.Rows.Count; i++)
                {


                    if (dgvPurQuotDetail["clmDetailSuppItmId", i].Value.ToString() == "")
                    {
                        dtQuotHeader.Clear();
                        dtQuotHeader = cnn.GetDataTable("select nvl(max(swid),0)+1 from ITEM_SUPPLIER");
                        dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value = dtQuotHeader.Rows[0][0].ToString();
                        glb_function.arrInsertLogs.Add("insert into ITEM_SUPPLIER values((" + dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value.ToString() + "),sysdate," +
                   "'فعال',null,'" + dgvPurQuotDetail[clmDetailSuppItmNo.Index, i].Value.ToString() + "','" + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + "'," + txtSUPPLIER_ID.Text.Trim() + "," + glb_function.glb_strUserId + ",'" + dgvPurQuotDetail["clmDetailSuppItmInf", i].Value.ToString() + "')");
                    }

                    glb_function.arrInsertLogs.Add(
                        "insert into PURCHASE_QUOTATIONS_DETAILS values((select nvl(max(swid),0)+1 from PURCHASE_QUOTATIONS_DETAILS)," +
                        "sysdate," + glb_function.glb_strUserId + ",'فعال'," + txtSwid.Text + "," +
                        "" + (dgvPurQuotDetail[clmDetailItemId.Index, i].Value.ToString() == "" ? "null" : dgvPurQuotDetail[clmDetailItemId.Index, i].Value.ToString()) + "," + dgvPurQuotDetail[clmDetailSuppItmId.Index, i].Value.ToString() + "," +
                        "'" + dgvPurQuotDetail[clmDetailSuppItmNo.Index, i].Value.ToString() + "','" + dgvPurQuotDetail[clmDetailSuppItmName.Index, i].Value.ToString() + "'," +
                        "'" + dgvPurQuotDetail[clmDetailSuppItmInf.Index, i].Value.ToString() + "'," + (dgvPurQuotDetail[clmDetailAlternItmId.Index, i].Value.ToString() == "" ? "null" : dgvPurQuotDetail[clmDetailAlternItmId.Index, i].Value.ToString()) + "," +
                        "" + dgvPurQuotDetail[clmDetailQtyOrder.Index, i].Value.ToString() + "," + dgvPurQuotDetail[clmDetailQtyQout.Index, i].Value.ToString() + "," +
                        "" + dgvPurQuotDetail[clmDetailFreeQty.Index, i].Value.ToString() + "," + dgvPurQuotDetail[clmDetailUnitPrice.Index, i].Value.ToString() + "," +
                        "" + (dgvPurQuotDetail[clmDetailCurrntQty.Index, i].Value.ToString() == "" ? "null" : dgvPurQuotDetail[clmDetailCurrntQty.Index, i].Value.ToString()) + ",null)");
                }


                for (int i = 0; i < dgExpenss.Rows.Count; i++)
                {
                    glb_function.arrInsertLogs.Add("insert into PURCHASE_Expenses values((select nvl(max(swid),0)+1 from PURCHASE_Expenses)," +
                        txtSwid.Text.Trim() + "," + dgExpenss[1, i].Value.ToString() + "," +
                        dgExpenss[3, i].Value.ToString() + ",'فعال'," +
                        "'عرض سعر'" + ")");
                }

            }

            else
            {
                glb_function.MsgBox("حالة الطلب غير معروفة للتحويل");
                return;
            }


            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);
            else
                txtStat.Text = strStatTemp;

        }

        private void dgvPurQuotDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex != 10 && e.ColumnIndex != 11 && e.ColumnIndex != 12 && e.ColumnIndex!=16)
                return;
            if (e.ColumnIndex == 16)
                dgvPurQuotDetail.Rows.Remove(dgvPurQuotDetail.Rows[e.RowIndex]);

            dgvPurQuotDetail.RightToLeft = RightToLeft.No;
            DataGridViewCell abc = dgvPurQuotDetail.CurrentCell;
            Rectangle RECT = dgvPurQuotDetail.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex,true  );
           dgvPurQuotDetail.RightToLeft = RightToLeft.Yes;


            nmbEditor.W_ColEgName = e.ColumnIndex.ToString();
            nmbEditor.DecimalPlaces = nmbUNIT_PRICE.DecimalPlaces;
            nmbEditor.Tag = e.RowIndex.ToString();

            if (e.ColumnIndex == 10)
            {
               
                nmbEditor.Value = Convert.ToDecimal(dgvPurQuotDetail[10, e.RowIndex].Value.ToString());
              
               

            }
            else if (e.ColumnIndex == 11)
            {
             
                nmbEditor.Value = Convert.ToDecimal(dgvPurQuotDetail[11, e.RowIndex].Value.ToString());
                
            }
            else if (e.ColumnIndex == 12)
            {
                
                nmbEditor.Value = Convert.ToDecimal(dgvPurQuotDetail[12, e.RowIndex].Value.ToString());
                irowindex = e.RowIndex;
                icolumnindex = e.ColumnIndex;
            }


            CtlLocation(RECT, nmbEditor);
        }

        public int irowindex, icolumnindex;
        private void CtlLocation(Rectangle rect, Control ctrl)
        {

           // ctrl.Location = dgvPurQuotDetail.PointToScreen(dgvPurQuotDetail.GetCellDisplayRectangle(icolumnindex, irowindex, true ).Location);
            ctrl.Top = dgvPurQuotDetail.Location.Y + rect.Y;
            ctrl.Left = dgvPurQuotDetail.Location.X + rect.X;

            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;
            
            ctrl.Focus();


        }

        private void nmbEditor_Leave(object sender, EventArgs e)
        {
            if (nmbEditor.Visible == true)
            {
                nmbEditor.Visible = false;
                
                dgvPurQuotDetail[Convert.ToUInt16(nmbEditor.W_ColEgName), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = nmbEditor.Value.ToString();


                SumTotal();
            }
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
            nmbUNIT_PRICE.DecimalPlaces= Convert.ToInt32(dtCurr.Rows[0]["curr_decimal"].ToString());
            nmbTotal.DecimalPlaces= Convert.ToInt32(dtCurr.Rows[0]["curr_decimal"].ToString()); 
        }

        private void nmbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void dgExpenss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
          

            if(e.ColumnIndex ==4)
              dgExpenss.Rows.Remove(dgExpenss.Rows[e.RowIndex]);
            else if(clmExpValue.Index == e.ColumnIndex)
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
        private void btnGetQuotation_Click(object sender, EventArgs e)
        {
            
            frmGetQuotation frm = new frmGetQuotation();
            frm.strWhere = " and h.stat in (N'عرض سعر'" + ",N'ارسالية') and h.branch_id= "+lstBranchHeader.SelectedValue.ToString();
            frm.ShowDialog();

            txtSwid.Text = frm.strQuotSwid;

            if(txtSwid.Text .Trim()!="")
                GetData(txtSwid.Text); 
        }

        private void btnGetExpenssTerm_Click(object sender, EventArgs e)
        {
            frmFindExpTerms frm = new frmFindExpTerms();

            frm.ShowDialog();

            if (frm.strExpTermID.Trim() != "")
            {
                txtTERMS_EXPENSES_ID.Text = frm.strExpTermID;
               GetTermsExpensess(txtTERMS_EXPENSES_ID.Text) ;
                LoadExpenssessDetail(txtTERMS_EXPENSES_ID.Text);
            }
        }
       private void LoadExpenssessDetail(string strTermHeaderId)
        {
            dgExpenss.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtExpDetail = cnn.GetDataTable("select d.expenses_item_id,ei.expenses_name "+
                                       " from terms_expenses_details d "+
                                       " join expenses_item ei on (d.expenses_item_id = ei.swid) "+
                                       " where d.expenses_header_id = "+strTermHeaderId);

            for (int i = 0; i < dtExpDetail.Rows.Count; i++)
            {
                dgExpenss.Rows.Add();
                dgExpenss[clmExpSwid.Index, dgExpenss.Rows.Count - 1].Value = "";
                dgExpenss[clmExpExpenssItemId.Index, dgExpenss.Rows.Count - 1].Value = dtExpDetail.Rows[i]["expenses_item_id"].ToString();
                dgExpenss[clmExpName.Index, dgExpenss.Rows.Count - 1].Value = dtExpDetail.Rows[i]["expenses_name"].ToString();
                dgExpenss[clmExpValue.Index, dgExpenss.Rows.Count - 1].Value = "0";
            }


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

        private void lstBranchHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBranchHeader.SelectedValue == null)
                return;

            if (lstBranchHeader.SelectedValue.ToString() != "System.Data.DataRowView" && lstBranchHeader.SelectedValue.ToString() != "")
            {


                PrepareForm();
            }
        }

        private void   GetTermsExpensess(string strTermSwid)
        {
            if (strTermSwid == "")
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTerm = cnn.GetDataTable("select  TERMS_NAME from TERMS_EXPENSES_HEADER where swid= " + strTermSwid);
            txtTERMS_EXPENSES_Name.Text = dtTerm.Rows[0][0].ToString();
        }
    }
}
