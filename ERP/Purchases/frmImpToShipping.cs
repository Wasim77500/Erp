using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmImpToShipping : ERP.MyForm
    {
        public frmImpToShipping()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindImport frm = new frmFindImport();
            frm.strWhere = " and stat='فعال'";
            frm.ShowDialog();

            if (frm.strImportID != "")
            {
                txtImportId.Text = (frm.strImportID);
                txtImport_no.Text = frm.strImportNo;


                GetImportItems();


            }
        }
        private void GetImportItems()
        {
            dgvItems.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtInvoice = cnn.GetDataTable("select p.swid,p.item_id,to_char(i.item_no),i.item_name,p.container,p.box_no,p.qty,p.taken_qty,(p.qty-p.taken_qty) Reminder_Qty, "+
                                  "  COST_IN_STOCK_CURR + (INTERNAL_EXP_IN_STOCK_CURR + IMPORT_EXP_IN_STOCK_CURR + INVOICE_EXP_IN_STOCK_CURR + LC_EXP_IN_STOCK_CURR + PO_EXP_IN_STOCK_CURR) FULLCOST_Stock_Curr " +
                                   " , COST_IN_MAIN_CURR COST_Main_curr, INTERNAL_EXP_IN_MAIN_CURR + IMPORT_EXP_IN_MAIN_CURR + INVOICE_EXP_IN_MAIN_CURR + LC_EXP_IN_MAIN_CURR + PO_EXP_IN_MAIN_CURR EXPENSES_VALUE_main_Curr " +
                                   " from packing_list p " +
                                   " join items i on (i.swid = p.item_id) " +
                                  "  where (p.qty - p.taken_qty) > 0 " +
                                   " and p.import_id =  " + txtImportId.Text);


            for (int i = 0; i < dtInvoice.Rows.Count; i++)
            {
                dgvItems.Rows.Add();
                dgvItems[clmPackingListSwid.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["swid"].ToString();
                dgvItems[clmITEM_id.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["item_id"].ToString();
                dgvItems[clmItemNo.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["item_no"].ToString();
                dgvItems[clmItemName.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["item_name"].ToString();
                dgvItems[clmCONTAINER.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["container"].ToString();
                dgvItems[clmBOX_NO.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["box_no"].ToString();
                dgvItems[clmPackingListQty.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["qty"].ToString();
                dgvItems[clmTakenQty.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["taken_qty"].ToString();
                dgvItems[clmQUANTITY_sent.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["Reminder_Qty"].ToString();
                dgvItems[clmFULLCOST_Stock_CurrAllQty.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["FULLCOST_Stock_Curr"].ToString();
                dgvItems[clmFULLCOST_Stock_Curr.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["FULLCOST_Stock_Curr"].ToString();
                dgvItems[clmCOST_Main_currAllQty.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["COST_Main_curr"].ToString();
                dgvItems[clmCOST_Main_curr.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["COST_Main_curr"].ToString();
                dgvItems[clmEXPENSES_VALUE_main_CurrAllQty.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["EXPENSES_VALUE_main_Curr"].ToString();
                dgvItems[clmEXPENSES_VALUE_main_Curr.Index, dgvItems.Rows.Count - 1].Value = dtInvoice.Rows[i]["EXPENSES_VALUE_main_Curr"].ToString();
                dgvItems[clmEXPIRY_DATE.Index, dgvItems.Rows.Count - 1].Value = "";
                

            }

            TotalCost();

        }

        private void TotalCost()
        {
            decimal dTotalExp = 0;
            decimal dTotalCost = 0;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                dTotalCost += Convert.ToDecimal( dgvItems[clmCOST_Main_curr.Index, i].Value)    ;
                dTotalExp += Convert.ToDecimal(dgvItems[clmEXPENSES_VALUE_main_Curr.Index ,i].Value );

            }
        }
        private void frmImpToShipping_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            glb_function.FillListWithId(ref lstBranch_SENT_ID, "branches", "branch_aname");
            btnSave.Enabled = true;
            btnAddExpensses.Enabled = false;
            dtpARRIVE_DATE.Value = DateTime.Now;
        }

        private void btnFindPeople_Click(object sender, EventArgs e)
        {
            frmFindVendor frm = new frmFindVendor();

            frm.ShowDialog();

            if (frm.strVendorID.Trim() != "")
            {
                txtCONVEYOR_ID.Text = frm.strVendorID;
                GetVendorData(txtCONVEYOR_ID.Text);
            }
        }
        private void GetVendorData(string strVendorId)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtVendor = cnn.GetDataTable("select p_name from people where swid=" + strVendorId);

            txtCONVEYOR_Name.Text = dtVendor.Rows[0]["p_name"].ToString();

        }

        private void btnFindAddress_Click(object sender, EventArgs e)
        {
            File.frmContacts frm = new File.frmContacts();
            frm.ShowDialog();
    
            txtVehicle_ADDRESS_ID.Text = frm.txtSWID.Text;
            txtVehicle_ADDRESS_name.Text = frm.txtADB_NAME.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            PrepareForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtPk = cnn.GetDataTable("select nvl(max(swid),0)+1 from shipping_LIST ");
            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            txtSwid.Text = dtPk.Rows[0][0].ToString();
            dtPk = cnn.GetDataTable("select swid from accounts where acc_class='فرعي' and stat='فعال'  and  system_acc_type='بضاعة في الطريق'");
            if (dtPk == null || dtPk.Rows.Count <= 0)
            {
                glb_function.MsgBox("لايوجد حساب لبضاعة في الطريق" + "\n" + "سيتم اقفال الشاشة");
                this.Close();
            }
            string strGoodInWayAccid = dtPk.Rows[0][0].ToString();


          


            string sql = "select swid,acc_no,acc_name from accounts a where acc_class='فرعي' and stat='فعال'  and system_acc_type like 'مصاريف مشتريات' ";
            dtPk = cnn.GetDataTable(sql);
            if (dtPk == null || dtPk.Rows.Count <= 0)
            {
                glb_function.MsgBox("لايوجد حساب لمصروف المشتريات" + "\n" + "سيتم اقفال الشاشة");
                this.Close();
            }
            string strExpAccId = dtPk.Rows[0][0].ToString();

             sql = "select swid,acc_no,acc_name from accounts a where acc_class='فرعي' and stat='فعال'  and system_acc_type like 'مصاريف تحاويل' ";
            dtPk = cnn.GetDataTable(sql);
            if (dtPk == null || dtPk.Rows.Count <= 0)
            {
                glb_function.MsgBox("لايوجد حساب لمصروف التحاويل" + "\n" + "سيتم اقفال الشاشة");
                this.Close();
            }
            string strExpAddAccId = dtPk.Rows[0][0].ToString();

             dtPk = cnn.GetDataTable("select nvl(max( to_number(substr(shipping_list_no,instr(shipping_list_no, '-')+1))),0)+1 from shipping_LIST where Branch_SENT_ID= "+glb_function.glb_BranchNo);
            txtShipping_LIST_NO.Text  =GetBranchNo()+"-"+ dtPk.Rows[0][0].ToString();

            glb_function.arrInsertLogs.Add("insert into shipping_LIST values(" + txtSwid.Text + ",'فعال'," +
                    glb_function.glb_strUserId+",sysdate,"+ strGoodInWayAccid+","+nmbGoods_in_way_VALUE.Value.ToString()+
                    ","+strExpAccId + ","+nmbEXPENSES_VALUE.Value.ToString()+ ","
                    + strExpAddAccId+","+nmbEXPENSES_ADD_VALUE.Value.ToString()+
                    ",0,'"+txtShipping_LIST_NO.Text +"',"+glb_function.glb_BranchNo+","+
                    lstBranch_SENT_ID.SelectedValue.ToString()+",'مشتريات',"+ txtImportId.Text + ",'"+
                    txtNote .Text + "',"+ (txtCONVEYOR_ID.Text.Trim()==""?"null": txtCONVEYOR_ID.Text.Trim() ) +
                    ","+ (txtVehicle_ADDRESS_ID.Text.Trim() == "" ? "null" : txtVehicle_ADDRESS_ID.Text.Trim())+
                    "'"+txtVehicle_TYPE.Text.Trim() +"','"+txtVehicle_NUM.Text.Trim() +"',null,null," +
                    "null,to_date('"+dtpARRIVE_DATE.Value.ToString("dd/MM/yyyy'")+"',dd/mm/yyyy')");




            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                
                if (dgvItems[clmSelectCheckBox.Index,i].Value.ToString ()=="True")
                {
                     dtPk = cnn.GetDataTable("select nvl(max(swid),0)+1 from shipping_ITEM  ");
                    
                    int iPk =Convert.ToInt32( dtPk.Rows[0][0].ToString());

                    string strExpireDate =  (dgvItems[clmEXPIRY_DATE.Index, i].Value.ToString()== "" ?"null": "to_date('" + Convert.ToDateTime(dgvItems[clmEXPIRY_DATE.Index, i].Value.ToString()).ToString("dd/MM/yyyy") + "', 'dd/mm/yyyy')"); 
                    glb_function.arrInsertLogs.Add("insert into shipping_LIST values("+(iPk + i).ToString()+","+glb_function.glb_strUserId +
                        ",sysdate,'فعال',"+dgvItems[clmITEM_id.Index ,i].Value.ToString()+","+strExpireDate+",'"+
                        dgvItems[clmCONTAINER.Index, i].Value.ToString() + "','" + 
                        dgvItems[clmBOX_NO.Index, i].Value.ToString() + "'," + dgvItems[clmQUANTITY_sent.Index, i].Value.ToString() + "," + 
                        dgvItems[clmCOST_Main_curr.Index, i].Value.ToString() + "," + 
                        dgvItems[clmEXPENSES_VALUE_main_Curr.Index, i].Value.ToString() + ",0," + 
                        dgvItems[clmFULLCOST_Stock_Curr.Index, i].Value.ToString() + ","+ txtSwid.Text + ")");
                }
            }

            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);

        }
        private void GetData(string strSwid)
        {
            btnNew_Click(null, null);
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtShippingList = cnn.GetDataTable("select swid,  goods_in_way_accid, "+
                          "  goods_in_way_value, expenses_accid, expenses_value, "+
                           " expenses_add_value_accid, expenses_add_value, suspend_value, "+
                           "  shipping_list_no, branch_sent_id, branch_receved_id, issued_type, "+
                            " issued_id,(select i.import_no from imports i where i.swid=sl.issued_id ) issued_no, " +
                            " note, conveyor_id, vehicle_address_id," +
                            " (select adb_name from address_book where swid=vehicle_address_id) vehicle_address_Name, " +
                            " vehicle_type, vehicle_num, " +
                            "  warehouse_id, inventory_date, accept_date, arrive_date "+
                            " from shipping_list sl "+
                           "  where swid = "+strSwid);

            //  txtImportId.Text = dtShippingList.Rows[0][""].ToString();
            txtSwid.Text = strSwid;
            txtShipping_LIST_NO.Text = dtShippingList.Rows[0]["shipping_list_no"].ToString();
            txtImportId.Text = dtShippingList.Rows[0]["issued_id"].ToString();
            txtImport_no.Text = dtShippingList.Rows[0]["issued_no"].ToString();
            lstBranch_SENT_ID.SelectedValue = Convert.ToInt16(dtShippingList.Rows[0]["branch_receved_id"].ToString());
            txtCONVEYOR_ID.Text = dtShippingList.Rows[0]["conveyor_id"].ToString();
            if (txtCONVEYOR_ID.Text.Trim() != "")
            {
                txtCONVEYOR_ID.Text = txtCONVEYOR_ID.Text.Trim();
                GetVendorData(txtCONVEYOR_ID.Text);
            }

            txtVehicle_ADDRESS_ID.Text = dtShippingList.Rows[0]["vehicle_address_id"].ToString();
            txtVehicle_ADDRESS_name.Text = dtShippingList.Rows[0]["vehicle_address_Name"].ToString();
            txtVehicle_TYPE.Text = dtShippingList.Rows[0]["vehicle_type"].ToString();
            txtVehicle_NUM.Text = dtShippingList.Rows[0]["vehicle_num"].ToString();
            dtpARRIVE_DATE.Value = Convert.ToDateTime(dtShippingList.Rows[0]["arrive_date"].ToString());
            txtNote.Text = dtShippingList.Rows[0]["note"].ToString();


            dtShippingList.Clear();

            dtShippingList = cnn.GetDataTable("select shi.swid, item_id,i.item_no,i.item_name, expiry_date, " +
                               "  container, box_no, quantity_sent, cost_main_curr, "+
                                "  expenses_value_main_curr, expenses_add_value_main_curr, "+
                                "  fullcost_stock_curr, header_id "+
                                "  from shipping_item shi "+
                                " join items i on (i.swid = shi.item_id) " +
                                 " where shi.header_id = " + txtSwid.Text );

            for (int i = 0; i < dtShippingList.Rows.Count; i++)
            {
                dgvItems.Rows.Add();
                dgvItems[clmSwid.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["swid"].ToString();
                dgvItems[clmITEM_id.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["item_id"].ToString();
                dgvItems[clmItemNo.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["item_no"].ToString();
                dgvItems[clmItemName.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["item_name"].ToString();
                dgvItems[clmEXPIRY_DATE.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["expiry_date"].ToString();
                dgvItems[clmBOX_NO.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["box_no"].ToString();
                dgvItems[clmCONTAINER.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["container"].ToString();
                dgvItems[clmQUANTITY_sent.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["quantity_sent"].ToString();
                dgvItems[clmCOST_Main_curr.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["cost_main_curr"].ToString();
                dgvItems[clmEXPENSES_VALUE_main_Curr.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["expenses_value_main_curr"].ToString();
                dgvItems[clmTakenQty.Index, dgvItems.Rows.Count - 1].Value = dtShippingList.Rows[i]["quantity_sent"].ToString();
                dgvItems[clmPackingListQty.Index, dgvItems.Rows.Count - 1].Value = "";

            }

            TotalCost();


            btnSave.Enabled  = false;

            //btnAddExpensses.Enabled  = true;
            if (HasPrivilege("btnAddExpensses"))
                btnAddExpensses.Enabled = true;

        }
        private string  GetBranchNo()
        {

            string strBranchNo = "";

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt = cnn.GetDataTable("select branch_no from branches where swid= "+glb_function.glb_BranchNo);


            return strBranchNo;
        }

        private void btnFindListShippingId_Click(object sender, EventArgs e)
        {
            frmFindShippingList frm = new frmFindShippingList();
            frm.strWhere = " and stat='فعال' and branch_sent_id="+glb_function.glb_BranchNo+"";
            frm.ShowDialog();

            if (frm.strShippingListID != "")
                GetData(frm.strShippingListID);
        }

        private void btnAddExpensses_Click(object sender, EventArgs e)
        {
            frmPrecurementExpensess frm = new frmPrecurementExpensess();
            frm.txtISSUED_ID.Text = txtSwid.Text;
            frm.txtISSUED_TYPE.Text = "تحاويل مخزنية";
            frm.txtTempletId.Text = lstTemplet.SelectedValue.ToString();

            frm.ShowDialog();
        }
    }
}
