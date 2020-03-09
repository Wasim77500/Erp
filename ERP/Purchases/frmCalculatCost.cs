using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmCalculatCost : ERP.MyForm
    {
        public frmCalculatCost()
        {
            InitializeComponent();
        }

        private void frmCalculatCost_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindDeliverExp frm = new frmFindDeliverExp();
            frm.ShowDialog();
            txtSwid.Text = frm.strImportID;

            if (txtSwid.Text.Trim() != "")
                GetData(txtSwid.Text );
        }

        private void  GetData(string strSwid)
        {
            new glb_function().clearItems(this);

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCalcExp = cnn.GetDataTable("select swid,  notes, imports_id, container,(select import_no from imports i where i.swid=c.imports_id) imports_no from calculate_costs_header c where swid= "+strSwid);

            txtSwid.Text = dtCalcExp.Rows[0]["swid"].ToString();
            txtImportId.Text = dtCalcExp.Rows[0]["imports_id"].ToString();
            txtImport_no.Text = dtCalcExp.Rows[0]["imports_no"].ToString();
            txtContainer.Text = dtCalcExp.Rows[0]["container"].ToString();
            txtNote.Text = dtCalcExp.Rows[0]["notes"].ToString();

            dtCalcExp.Clear();

            dtCalcExp = cnn.GetDataTable("select swid,  issued_type, issued_no, "+
                           "  main_expenses_value, stock_expenses_value, "+
                            " c.expenses_id,(select expenses_name from expenses_item ei where ei.swid = c.expenses_id) exp_name, notes, is_convert_expense, convert_accid, header_id, " +
                           "   method_of_calculation, price_type, non_class_weight_value "+
                           "  from calculate_costs_de c where Header_id="+strSwid );

            for (int i = 0; i < dtCalcExp.Rows.Count; i++)
            {
                dgvImpExp.Rows.Add();
                dgvImpExp[clmISSUED_Swid.Index, dgvImpExp.Rows.Count - 1].Value = dtCalcExp.Rows[i]["issued_no"].ToString();
                dgvImpExp[clmISSUED_TYPE.Index, dgvImpExp.Rows.Count - 1].Value = dtCalcExp.Rows[i]["issued_type"].ToString();
                dgvImpExp[clmISSUED_NO.Index, dgvImpExp.Rows.Count - 1].Value = GetIssueNo(dtCalcExp.Rows[i]["issued_no"].ToString(), dtCalcExp.Rows[i]["issued_type"].ToString());
                dgvImpExp[clmEXPENSES_ID.Index, dgvImpExp.Rows.Count - 1].Value = dtCalcExp.Rows[i]["expenses_id"].ToString();
                dgvImpExp[clmEXPENSES_Name.Index, dgvImpExp.Rows.Count - 1].Value = dtCalcExp.Rows[i]["exp_name"].ToString();


                dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value = dtCalcExp.Rows[i]["main_expenses_value"].ToString();

                dgvImpExp[clmSTOCK_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value = dtCalcExp.Rows[i]["stock_expenses_value"].ToString();


                dgvImpExp[clmNote.Index, dgvImpExp.Rows.Count - 1].Value =  dtCalcExp.Rows[i]["notes"].ToString();
                dgvImpExp[clmMETHOD_OF_CALCULATION.Index, dgvImpExp.Rows.Count - 1].Value = dtCalcExp.Rows[i]["method_of_calculation"].ToString();
            }


            dtCalcExp.Clear();
            dtCalcExp = cnn.GetDataTable("select sum(p.cost_in_stock_curr * qty) txtCostInMainCurr,sum(p.cost_in_main_curr * qty) txtCostInStockCurr from packing_list p " +
                " where p.import_id = "+txtSwid.Text +" and p.container = '"+ txtContainer.Text +"'");


            txtCostInMainCurr.Text = dtCalcExp.Rows[0]["txtCostInMainCurr"].ToString();
            txtCostInStockCurr.Text = dtCalcExp.Rows[0]["txtCostInStockCurr"].ToString();

        }
        private string GetIssueNo(string strSwid, string strIssueType)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetIssuNO = new DataTable();
            switch (strIssueType)
            {
                case "وارد":
                    dtGetIssuNO = cnn.GetDataTable("select i.import_no from imports i where swid=" + strSwid);
                    break;
                case "فاتورة":
                    dtGetIssuNO = cnn.GetDataTable("select pb.bill_number from purchases_bill pb where pb.swid=" + strSwid);
                    break;
                case "امر الشراء":
                    dtGetIssuNO = cnn.GetDataTable("select po.purchase_order_num from purchases_order_header po where po.swid=" + strSwid);
                    break;
                case "اعتماد":
                    dtGetIssuNO = cnn.GetDataTable("select lc.lc_no from lc  where lc.swid=" + strSwid);
                    break;
                default:
                    break;
            }


            return dtGetIssuNO.Rows[0][0].ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItemInPL = cnn.GetDataTable("select swid,(p.cost_in_stock_curr),(p.cost_in_main_curr),qty from packing_list p " +
                        " where p.import_id = "+txtImportId.Text +" and p.container = '"+ txtContainer.Text +"' ");

            int icheck = 0;
            string strOperationExpInStockCurr = "";
           string strOperationExpInMainCurr = "";

            for (int i = 0; i < dgvImpExp.Rows.Count; i++)
            {
                switch (dgvImpExp[clmISSUED_TYPE.Index, i].Value.ToString())
                {
                    case "وارد":
                        strOperationExpInStockCurr = "IMPORT_EXP_IN_STOCK_CURR";
                        strOperationExpInMainCurr = "IMPORT_EXP_IN_MAIN_CURR";
                        break;
                    case "فاتورة":
                        strOperationExpInStockCurr = "INVOICE_EXP_IN_STOCK_CURR";
                        strOperationExpInMainCurr = "INVOICE_EXP_IN_MAIN_CURR";
                        break;
                    case "امر الشراء":
                        strOperationExpInStockCurr = "PO_EXP_IN_STOCK_CURR";
                        strOperationExpInMainCurr = "PO_EXP_IN_MAIN_CURR";
                        break;
                    case "اعتماد":
                        strOperationExpInStockCurr = "LC_EXP_IN_STOCK_CURR";
                        strOperationExpInMainCurr = "LC_EXP_IN_MAIN_CURR";
                        break;
                    default:
                        break;

                }

                for (int j = 0; j < dtItemInPL.Rows.Count; j++)
                {
                    decimal dExpCalStockCurr = 0;
                    decimal dExpCalMainCurr = 0; 


                    if (dgvImpExp[clmMETHOD_OF_CALCULATION.Index,i].Value.ToString()== "قيمة")
                    {
                        dExpCalStockCurr= (((Convert.ToDecimal(dtItemInPL.Rows[j]["cost_in_stock_curr"].ToString()) * Convert.ToDecimal(dtItemInPL.Rows[j]["qty"].ToString())) / Convert.ToDecimal(txtCostInStockCurr.Text) * 100) * Convert.ToDecimal(dgvImpExp[clmSTOCK_EXPENSES_VALUE.Index, i].Value.ToString()) / 100) / Convert.ToDecimal(dtItemInPL.Rows[j]["qty"].ToString());
                        dExpCalMainCurr= (((Convert.ToDecimal(dtItemInPL.Rows[j]["cost_in_main_curr"].ToString()) * Convert.ToDecimal(dtItemInPL.Rows[j]["qty"].ToString())) / Convert.ToDecimal(txtCostInMainCurr.Text) * 100) * Convert.ToDecimal(dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, i].Value.ToString()) / 100) / Convert.ToDecimal(dtItemInPL.Rows[j]["qty"].ToString());



                    }
                    else if (dgvImpExp[clmMETHOD_OF_CALCULATION.Index, i].Value.ToString() == "وزن")
                    {

                    }

                    icheck = cnn.TranDataToDB("update packing_list p set "+ strOperationExpInStockCurr + "="+ strOperationExpInStockCurr + "+"+ dExpCalStockCurr +","+ strOperationExpInMainCurr+"="+ strOperationExpInMainCurr+"+"+ dExpCalMainCurr +" where swid="+ dtItemInPL.Rows[j]["swid"].ToString());

                    if(icheck <=0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ اثناء عملية التكليف");
                        return;
                    }

                }
            }


            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية التكليف بنجاح");
            new glb_function().clearItems(this);
        }

        private void lstImpContainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
