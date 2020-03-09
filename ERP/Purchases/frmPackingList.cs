using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmPackingList : ERP.MyForm
    {
        public frmPackingList()
        {
            InitializeComponent();
        }

        private void frmPackingList_Load(object sender, EventArgs e)
        {
            lblTemplet.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Side;

         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindImport frm = new frmFindImport();
            frm.strWhere = " and stat='فعال'";
            frm.ShowDialog();

            if (frm.strImportID != "")
            {
               txtImportId.Text =(frm.strImportID);
                txtImport_no.Text = frm.strImportNo;

                lstImpInvoices.Items.Clear();

                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtInvoice = cnn.GetDataTable("select b.swid,b.bill_number from purchases_bill b "+
                                    " where b.imports_id = "+ txtImportId.Text );

                lstImpInvoices.DataSource = dtInvoice;
                lstImpInvoices.ValueMember = "swid";
                lstImpInvoices.DisplayMember = "bill_number";

                lstImpInvoices.SelectedIndex = -1;
            }


        }

        private void lstImpInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBoxes.Rows.Clear();
            dgvItems.Rows.Clear();
            nmbTotalInvoiceInStockCurr.Value = 0;
            nmbTotalInvoiceInMainCurr.Value = 0;
            nmbTotalInvoiceInInvoiceCurr.Value = 0;
            if (lstImpInvoices.SelectedValue == null)
            {
              

                return;
            }
              

            if (lstImpInvoices.SelectedValue.ToString() != "System.Data.DataRowView" && lstImpInvoices.SelectedValue.ToString() != "")
            {
                GetTotalValues();
                ConnectionToDB cnn = new ConnectionToDB();
             


                DataTable dtInvoiceItemBox = cnn.GetDataTable("select d.swid,d.item_id,i.item_no,i.item_name," +
                    " d.quantity,d.price ,internal_exp,(select nvl( sum(qty),0)  from Packing_list p where p.purchases_bill_de=d.swid and p.item_id=d.item_id and(p.box_no is null or p.box_no = '') ) qtyTaken" +
                    " from purchases_bill_details d " +
                    " join items i on (d.item_id=i.swid) " +
                    " where d.header_id =  "+ lstImpInvoices.SelectedValue.ToString()+
                  "  and(d.box_no is null or d.box_no = '')");
                for (int i = 0; i < dtInvoiceItemBox.Rows.Count; i++)
                {
                    decimal dQtyRemined = Convert.ToDecimal(dtInvoiceItemBox.Rows[i]["quantity"].ToString()) - Convert.ToDecimal(dtInvoiceItemBox.Rows[i]["qtyTaken"].ToString());
                    if (dQtyRemined > 0)
                    {
                        dgvItems.Rows.Add();
                        dgvItems[clmBillDetailId.Index, dgvItems.Rows.Count - 1].Value = dtInvoiceItemBox.Rows[i]["swid"].ToString();
                        dgvItems[clmItemId.Index, dgvItems.Rows.Count - 1].Value = dtInvoiceItemBox.Rows[i]["item_id"].ToString();

                        dgvItems[clmItemNo.Index, dgvItems.Rows.Count - 1].Value = dtInvoiceItemBox.Rows[i]["item_no"].ToString();
                        dgvItems[clmItemName.Index, dgvItems.Rows.Count - 1].Value = dtInvoiceItemBox.Rows[i]["item_name"].ToString();
                        dgvItems[clmQty.Index, dgvItems.Rows.Count - 1].Value = dQtyRemined;
                        dgvItems[clmQtyContainer.Index, dgvItems.Rows.Count - 1].Value = dQtyRemined;
                        dgvItems[clmUnitCostInvoceCurr.Index, dgvItems.Rows.Count - 1].Value = dtInvoiceItemBox.Rows[i]["price"].ToString();
                        dgvItems[clmInternalExpInvoiceCurr.Index, dgvItems.Rows.Count - 1].Value = dtInvoiceItemBox.Rows[i]["internal_exp"].ToString();

                        decimal dCostINMainCurr = Convert.ToDecimal(dgvItems[clmUnitCostInvoceCurr.Index, dgvItems.Rows.Count - 1].Value.ToString()) * (nmbTotalInvoiceInMainCurr.Value/nmbTotalInvoiceInInvoiceCurr.Value );
                        dgvItems[clmCOST_IN_Main_curr.Index, dgvItems.Rows.Count - 1].Value = dCostINMainCurr.ToString();

                        decimal dExpInMainCurr = Convert.ToDecimal(dgvItems[clmInternalExpInvoiceCurr.Index, dgvItems.Rows.Count - 1].Value.ToString()) * (nmbTotalInvoiceInMainCurr.Value / nmbTotalInvoiceInInvoiceCurr.Value);
                        dgvItems[clmInternalExpMainCurr.Index, dgvItems.Rows.Count - 1].Value = dExpInMainCurr.ToString();


                        decimal dCostInStockCurr = dCostINMainCurr / (nmbTotalInvoiceInMainCurr.Value /nmbTotalInvoiceInStockCurr.Value );
                        dgvItems[clmCost_in_Stock_curr.Index, dgvItems.Rows.Count - 1].Value = dCostInStockCurr.ToString();


                        decimal dExpInStockCurr = dExpInMainCurr / (nmbTotalInvoiceInMainCurr.Value / nmbTotalInvoiceInStockCurr.Value);
                        dgvItems[clmInternalExpStockCurr.Index, dgvItems.Rows.Count - 1].Value = dExpInStockCurr.ToString();

                    }
                  
                   

                }


                dtInvoiceItemBox.Clear();

                dtInvoiceItemBox = cnn.GetDataTable("select d.box_no from purchases_bill_details d "+
                              "  where d.header_id =  "+ lstImpInvoices.SelectedValue.ToString() +
                               " and d.box_no != '' and d.box_no not in (select box_no from packing_list plst where plst.import_id=" + txtImportId.Text +")");

                for (int i = 0; i < dtInvoiceItemBox.Rows.Count; i++)
                {
                    dgvBoxes.Rows.Add();
                    dgvBoxes[clmBoxNo.Index, dgvBoxes.Rows.Count - 1].Value = dtInvoiceItemBox.Rows[i]["box_no"].ToString();
                }
            }
            else
            {
                //dgvBoxes.Rows.Clear();
                //dgvItems.Rows.Clear();
            }
         }
     
         private void GetTotalValues()
        {
            ConnectionToDB cnn = new ConnectionToDB();
        

           DataTable 
            dtTotalValues = cnn.GetDataTable("select t.TOTAL_VALUE_IN_STOCK_CURR,TOTAL_VALUE_IN_BILL_CURR,TOTAL_VALUE_IN_MAIN_CURR from PURCHASES_BILL t where t.swid=" + lstImpInvoices.SelectedValue.ToString());

            nmbTotalInvoiceInStockCurr.Value = Convert.ToDecimal(dtTotalValues.Rows[0]["TOTAL_VALUE_IN_STOCK_CURR"].ToString());
            nmbTotalInvoiceInInvoiceCurr.Value = Convert.ToDecimal(dtTotalValues.Rows[0]["TOTAL_VALUE_IN_BILL_CURR"].ToString());
            nmbTotalInvoiceInMainCurr.Value = Convert.ToDecimal(dtTotalValues.Rows[0]["TOTAL_VALUE_IN_MAIN_CURR"].ToString());

        }
     
        private void ckbSelectAllItem_CheckedChanged(object sender, EventArgs e)
        {
            bool bCheck;
            if (ckbSelectAllItem.Checked == true)
                bCheck = true;
            else
                bCheck = false;
            
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                dgvItems[clmSelectCheckBox.Index, i].Value = bCheck;
            }
        }

        private void ckbSelectAllBox_CheckedChanged(object sender, EventArgs e)
        {
            bool bCheck;
            if (ckbSelectAllItem.Checked == true)
                bCheck = true;
            else
                bCheck = false;

            for (int i = 0; i < dgvBoxes.Rows.Count; i++)
            {
                dgvItems[clmSelectedBoxCheckBox.Index, i].Value = bCheck;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtImportId.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء اختيار الوارد");
                return;
            }
            if(lstImpInvoices.SelectedIndex ==-1)
            {
                glb_function.MsgBox("الرجاء اختيار الفاتورة");
                return;
            }
            if(txtCONTAINER.Text.ToString() =="")
            {
                glb_function.MsgBox("الرجاء ادخال تمييز للحاوية");
                return;
            }

            

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
          
            int iCountDelivered = 0;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if(dgvItems[clmSelectCheckBox.Index, i].Value !=null && dgvItems[clmSelectCheckBox.Index ,i].Value .ToString()=="True")
                {
                            glb_function.arrInsertLogs.Add
                       ("insert into PACKING_LIST values ((select nvl(max(swid),0)+1 from PACKING_LIST),'فعال',"+
                       dgvItems[clmBillDetailId.Index ,i].Value.ToString()+","+dgvItems[clmQtyContainer.Index ,i].Value .ToString()+
                       ",'"+txtCONTAINER.Text +"',null,"+dgvItems[clmItemId.Index,i].Value.ToString()+","+
                       dgvItems[clmCost_in_Stock_curr.Index ,i].Value.ToString() +","+
                       dgvItems[clmCOST_IN_Main_curr.Index ,i].Value.ToString()+","+
                       dgvItems[clmInternalExpStockCurr.Index,i].Value.ToString()+ "," +
                         dgvItems[clmInternalExpMainCurr.Index, i].Value.ToString() +
                       ",0,0,0,0,0,0,0,0," +txtImportId.Text +")");

                    iCountDelivered++;
                }
            }
            DataTable dtBoxItems;
            for (int i = 0; i < dgvBoxes.Rows.Count; i++)
            {
                
                if (dgvBoxes[clmSelectedBoxCheckBox.Index,i].Value.ToString()=="True")
                {
                    dtBoxItems = cnn.GetDataTable("select d.swid,d.item_id,d.quantity,d.price ,internal_exp   " +
                        " from purchases_bill_details d "+
                         "    where d.header_id =  "+ lstImpInvoices.SelectedValue.ToString()+
                         "    and d.box_no = '"+dgvBoxes[clmBoxNo.Index ,i].Value.ToString()+"'");

                    decimal dCostINMainCurr = Convert.ToDecimal(dtBoxItems.Rows[i]["price"].ToString()) * (nmbTotalInvoiceInMainCurr.Value / nmbTotalInvoiceInInvoiceCurr.Value);
                    

                    decimal dExpInMainCurr = Convert.ToDecimal(dtBoxItems.Rows[i]["internal_exp"].ToString()) * (nmbTotalInvoiceInMainCurr.Value / nmbTotalInvoiceInInvoiceCurr.Value);
                  

                    decimal dCostInStockCurr = dCostINMainCurr / (nmbTotalInvoiceInMainCurr.Value / nmbTotalInvoiceInStockCurr.Value);
                    

                    decimal dExpInStockCurr = dExpInMainCurr / (nmbTotalInvoiceInMainCurr.Value / nmbTotalInvoiceInStockCurr.Value);
                   

                    glb_function.arrInsertLogs.Add
                     ("insert into PACKING_LIST values ((select nvl(max(swid),0)+1 from PACKING_LIST),'فعال'," +
                     dtBoxItems.Rows[0]["swid"].ToString() + ", " + dtBoxItems.Rows[0]["quantity"].ToString() +
                     ",'" + txtCONTAINER.Text + "','"+ dgvBoxes[clmBoxNo.Index, i].Value.ToString() + "'," + dtBoxItems.Rows[0]["item_id"].ToString() + "," +
                     dCostInStockCurr.ToString() + "," +
                     dCostINMainCurr.ToString() + "," +
                     dExpInStockCurr.ToString() +","+
                     dExpInMainCurr.ToString()+
                     ",0,0,0,0,0,0,0,0," + txtImportId.Text + ")");

                }
                 


            }


            if (iCountDelivered > 0)
                glb_function.MultiTransData();
            else
                glb_function.MsgBox("لم يتم تحديد اي صنف او صندوق");


        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            if (e.ColumnIndex != clmQtyContainer.Index)
                return;


           
            DataGridViewCell abc = dgvItems.CurrentCell;
            Rectangle RECT = dgvItems.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
         


            nmbExpEditor.W_ColEgName = e.ColumnIndex.ToString();
            nmbExpEditor.DecimalPlaces = 2;
            nmbExpEditor.Tag = e.RowIndex.ToString();



            nmbExpEditor.Value = Convert.ToDecimal(dgvItems[clmQtyContainer.Index, e.RowIndex].Value.ToString());






            CtlLocationExp(RECT, nmbExpEditor);

        }

        private void CtlLocationExp(Rectangle rect, Control ctrl)
        {

          
            ctrl.Top = dgvItems.Location.Y + rect.Y;
            ctrl.Left = dgvItems.Location.X + rect.X;

            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;

            ctrl.Focus();


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

                if (nmbExpEditor.Value <= 0 || nmbExpEditor.Value> Convert.ToDecimal(dgvItems[clmQty.Index, dgvItems.CurrentRow.Index].Value))
                    nmbExpEditor.Value =Convert.ToDecimal( dgvItems[clmQty.Index, dgvItems.CurrentRow.Index].Value);

                //decimal Totalqty =Convert.ToDecimal( dgvItems[clmQty.Index, dgvItems.CurrentRow.Index].Value);


                dgvItems[clmQtyContainer.Index, dgvItems.CurrentRow.Index].Value = nmbExpEditor.Value.ToString();

                //dgvItems[clmUnitCostInvoceCurr.Index, dgvItems.CurrentRow.Index].Value = ((Convert.ToDecimal(dgvItems[clmUnitCostInvoceCurr.Index, dgvItems.CurrentRow.Index].Value) / Totalqty)*nmbExpEditor.Value );
                //dgvItems[clmCost_in_Stock_curr.Index, dgvItems.CurrentRow.Index].Value = ((Convert.ToDecimal(dgvItems[clmCost_in_Stock_curr.Index, dgvItems.CurrentRow.Index].Value) / Totalqty) * nmbExpEditor.Value);
                //dgvItems[clmCOST_IN_Main_curr.Index, dgvItems.CurrentRow.Index].Value = ((Convert.ToDecimal(dgvItems[clmCOST_IN_Main_curr.Index, dgvItems.CurrentRow.Index].Value) / Totalqty) * nmbExpEditor.Value);

                //dgvItems[clmInternalExpInvoiceCurr.Index, dgvItems.CurrentRow.Index].Value = ((Convert.ToDecimal(dgvItems[clmInternalExpInvoiceCurr.Index, dgvItems.CurrentRow.Index].Value) / Totalqty) * nmbExpEditor.Value);
                //dgvItems[clmInternalExpStockCurr.Index, dgvItems.CurrentRow.Index].Value = ((Convert.ToDecimal(dgvItems[clmInternalExpStockCurr.Index, dgvItems.CurrentRow.Index].Value) / Totalqty) * nmbExpEditor.Value);
                //dgvItems[clmInternalExpMainCurr.Index, dgvItems.CurrentRow.Index].Value = ((Convert.ToDecimal(dgvItems[clmInternalExpMainCurr.Index, dgvItems.CurrentRow.Index].Value) / Totalqty) * nmbExpEditor.Value);







            }
        }
    }
}
