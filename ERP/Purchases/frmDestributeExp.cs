using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmDestributeExp : ERP.MyForm
    {
        public frmDestributeExp()
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

                lstImpContainer.Items.Clear();

                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtInvoice = cnn.GetDataTable("select distinct l.container from packing_list l "+
                                        " where l.import_id =  " + txtImportId.Text);

                lstImpContainer.DataSource = dtInvoice;

                lstImpContainer.DisplayMember = "container";

                lstImpContainer.SelectedIndex = -1;

                LoadExp();
            }

        }
        private void LoadExp()
        {

            dgvImpExp.Rows.Clear();

            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtExp = new DataTable();

            //dtExp = cnn.GetDataTable("select cstock.swid from currency cstock where cstock.is_stock_curr = 1 ");
            //if (dtExp == null || dtExp.Rows.Count <= 0)
            //{
            //    glb_function.MsgBox("لايوجد عملة للمخزون" + "\n" + "سيتم اقفال الشاشة");
            //    this.Close();
            //}

            //int dStockCurrId =  Convert.ToInt16(dtExp.Rows[0]["swid"].ToString());


            //Import**********************
          
            dtExp = cnn.GetDataTable("select issued_type, " +
                        "    issued_id, expenses_item_id, "+
                         "   (select expenses_name from expenses_item ei where ei.swid = d.expenses_item_id) exp_name, "+
                         "   nvl(sum(main_value), 0) main_value,nvl(sum(stock_value),0) stock_value, " +
                          "  (select nvl(sum(MAIN_EXPENSES_VALUE), 0)  " +
                          "         from CALCULATE_COSTS_DE c " +
                          "         where c.issued_type = N'وارد' "+
                           "       and c.issued_no = "+txtImportId.Text + " and c.expenses_id=d.expenses_item_id) taken_value " +
                          "    from procurement_expenses d "+
                          "    where d.issued_type = N'وارد' "+
                          "   and d.issued_id = " + txtImportId.Text + " " +
                          "   and add_to_cost = 'نعم' "+
                          "   group by expenses_item_id,issued_type,issued_id ");


            for (int i = 0; i < dtExp.Rows.Count; i++)
            {

                string strValue = (Convert.ToDecimal( dtExp.Rows[i]["main_value"].ToString()) - Convert.ToDecimal(dtExp.Rows[i]["taken_value"].ToString())).ToString();
                decimal exchangeRate = Convert.ToDecimal(dtExp.Rows[i]["main_value"].ToString()) / Convert.ToDecimal(dtExp.Rows[i]["stock_value"].ToString());
                if (Convert.ToDecimal (strValue)>0)
                {
                    dgvImpExp.Rows.Add();
                    dgvImpExp[clmISSUED_Swid.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["issued_id"].ToString();
                    dgvImpExp[clmISSUED_TYPE.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["issued_type"].ToString();
                    dgvImpExp[clmISSUED_NO.Index, dgvImpExp.Rows.Count - 1].Value = GetIssueNo(dtExp.Rows[i]["issued_id"].ToString(),"وارد");
                    dgvImpExp[clmEXPENSES_ID.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["expenses_item_id"].ToString();
                    dgvImpExp[clmEXPENSES_Name.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["exp_name"].ToString();
                 
                    dgvImpExp[clmISSUED_EXPENSES_Helper.Index, dgvImpExp.Rows.Count - 1].Value = strValue;
                    dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value = strValue ;

                    dgvImpExp[clmSTOCK_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value =(Convert.ToDecimal( strValue)/ exchangeRate) ;


                    dgvImpExp[clmNote.Index, dgvImpExp.Rows.Count - 1].Value = "";
                    dgvImpExp[clmMETHOD_OF_CALCULATION.Index, dgvImpExp.Rows.Count - 1].Value = "";
                }
                

            }


            //Purchase bill ******************************
            dtExp.Clear();
            dtExp = cnn.GetDataTable("select issued_type, " +
                        "    issued_id, expenses_item_id, " +
                         "   (select expenses_name from expenses_item ei where ei.swid = d.expenses_item_id) exp_name, " +
                         "   nvl(sum(main_value), 0) main_value,nvl(sum(stock_value),0) stock_value, " +
                          "  (select nvl(sum(MAIN_EXPENSES_VALUE), 0)  " +
                          "         from CALCULATE_COSTS_DE c " +
                          "         where c.issued_type = N'فاتورة' " +
                           "       and c.issued_no in (select swid from purchases_bill pb where pb.imports_id= " + txtImportId.Text + ") and c.expenses_id=d.expenses_item_id) taken_value " +
                          "    from procurement_expenses d " +
                          "    where d.issued_type = N'فاتورة' " +
                          "   and d.issued_id in  (select swid from purchases_bill pb where pb.imports_id= " + txtImportId.Text + " )" +
                          "   and add_to_cost = 'نعم' " +
                          "   group by expenses_item_id,issued_type,issued_id  ");


            for (int i = 0; i < dtExp.Rows.Count; i++)
            {

                string strValue = (Convert.ToDecimal(dtExp.Rows[i]["main_value"].ToString()) - Convert.ToDecimal(dtExp.Rows[i]["taken_value"].ToString())).ToString();
                decimal exchangeRate = Convert.ToDecimal(dtExp.Rows[i]["main_value"].ToString()) / Convert.ToDecimal(dtExp.Rows[i]["stock_value"].ToString());
                if (Convert.ToDecimal(strValue) > 0)
                {
                    dgvImpExp.Rows.Add();
                    dgvImpExp[clmISSUED_Swid.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["issued_id"].ToString();
                    dgvImpExp[clmISSUED_TYPE.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["issued_type"].ToString();
                    dgvImpExp[clmISSUED_NO.Index, dgvImpExp.Rows.Count - 1].Value = GetIssueNo(dtExp.Rows[i]["issued_id"].ToString(), "فاتورة");
                    dgvImpExp[clmEXPENSES_ID.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["expenses_item_id"].ToString();
                    dgvImpExp[clmEXPENSES_Name.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["exp_name"].ToString();
                   
                    dgvImpExp[clmISSUED_EXPENSES_Helper.Index, dgvImpExp.Rows.Count - 1].Value = strValue;
                    dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value = strValue;

                    dgvImpExp[clmSTOCK_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value = (Convert.ToDecimal(strValue) / exchangeRate);


                    dgvImpExp[clmNote.Index, dgvImpExp.Rows.Count - 1].Value = "";
                    dgvImpExp[clmMETHOD_OF_CALCULATION.Index, dgvImpExp.Rows.Count - 1].Value = "";
                }


            }




            //Purchase Order ******************************************
            dtExp.Clear();
            dtExp = cnn.GetDataTable("select issued_type, " +
                        "    issued_id, expenses_item_id, " +
                         "   (select expenses_name from expenses_item ei where ei.swid = d.expenses_item_id) exp_name, " +
                         "   nvl(sum(main_value), 0) main_value,nvl(sum(stock_value),0) stock_value,  " +
                          "  (select nvl(sum(MAIN_EXPENSES_VALUE), 0)  " +
                          "         from CALCULATE_COSTS_DE c " +
                          "         where c.issued_type = N'امر الشراء' " +
                           "       and c.issued_no in (select d.order_purchases_de_id from purchases_bill h join purchases_bill_details d on (h.swid=d.header_id) where  order_purchases_de_id is not null  and  h.imports_id=  " + txtImportId.Text + ") and c.expenses_id=d.expenses_item_id) taken_value " +
                          "    from procurement_expenses d " +
                          "    where d.issued_type = N'امر الشراء' " +
                          "   and d.issued_id in  (select d.order_purchases_de_id from purchases_bill h join purchases_bill_details d on (h.swid=d.header_id) where  order_purchases_de_id is not null  and  h.imports_id= " + txtImportId.Text + ") " +
                          "   and add_to_cost = 'نعم' " +
                          "   group by expenses_item_id,issued_type,issued_id ");


            for (int i = 0; i < dtExp.Rows.Count; i++)
            {

                string strValue = (Convert.ToDecimal(dtExp.Rows[i]["main_value"].ToString()) - Convert.ToDecimal(dtExp.Rows[i]["taken_value"].ToString())).ToString();
                decimal exchangeRate = Convert.ToDecimal(dtExp.Rows[i]["main_value"].ToString()) / Convert.ToDecimal(dtExp.Rows[i]["stock_value"].ToString());
                if (Convert.ToDecimal(strValue) > 0)
                {
                    dgvImpExp.Rows.Add();
                    dgvImpExp[clmISSUED_Swid.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["issued_id"].ToString();
                    dgvImpExp[clmISSUED_TYPE.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["issued_type"].ToString();
                    dgvImpExp[clmISSUED_NO.Index, dgvImpExp.Rows.Count - 1].Value = GetIssueNo(dtExp.Rows[i]["issued_id"].ToString(), "امر الشراء");
                    dgvImpExp[clmEXPENSES_ID.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["expenses_item_id"].ToString();
                    dgvImpExp[clmEXPENSES_Name.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["exp_name"].ToString();

                    dgvImpExp[clmISSUED_EXPENSES_Helper.Index, dgvImpExp.Rows.Count - 1].Value = strValue;
                    dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value = strValue;

                    dgvImpExp[clmSTOCK_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value = (Convert.ToDecimal(strValue) / exchangeRate);


                    dgvImpExp[clmNote.Index, dgvImpExp.Rows.Count - 1].Value = "";
                    dgvImpExp[clmMETHOD_OF_CALCULATION.Index, dgvImpExp.Rows.Count - 1].Value = "";
                }


            }

            //LC ***************************************

            dtExp.Clear();
            dtExp = cnn.GetDataTable("select issued_type, " +
                        "    issued_id, expenses_item_id, " +
                         "   (select expenses_name from expenses_item ei where ei.swid = d.expenses_item_id) exp_name, " +
                         "   nvl(sum(main_value), 0) main_value,nvl(sum(stock_value),0) stock_value,  " +
                          "  (select nvl(sum(MAIN_EXPENSES_VALUE), 0)  " +
                          "         from CALCULATE_COSTS_DE c " +
                          "         where c.issued_type = N'اعتماد' " +
                           "       and c.issued_no in (select lc.header_id from  purchases_bill h join lc_rollover lc on (h.lc_rollover_id=lc.swid) where   h.imports_id=  " + txtImportId.Text + ") and c.expenses_id=d.expenses_item_id) taken_value " +
                          "    from procurement_expenses d " +
                          "    where d.issued_type = N'اعتماد' " +
                          "   and d.issued_id in  (  select lc.header_id from  purchases_bill h join lc_rollover lc on (h.lc_rollover_id=lc.swid) where   h.imports_id= " + txtImportId.Text + ") " +
                          "   and add_to_cost = 'نعم' " +
                          "   group by expenses_item_id,issued_type,issued_id   ");


            for (int i = 0; i < dtExp.Rows.Count; i++)
            {

                string strValue = (Convert.ToDecimal(dtExp.Rows[i]["main_value"].ToString()) - Convert.ToDecimal(dtExp.Rows[i]["taken_value"].ToString())).ToString();
                decimal exchangeRate = Convert.ToDecimal(dtExp.Rows[i]["main_value"].ToString()) / Convert.ToDecimal(dtExp.Rows[i]["stock_value"].ToString());
                if (Convert.ToDecimal(strValue) > 0)
                {
                    dgvImpExp.Rows.Add();
                    dgvImpExp[clmISSUED_Swid.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["issued_id"].ToString();
                    dgvImpExp[clmISSUED_TYPE.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["issued_type"].ToString();
                    dgvImpExp[clmISSUED_NO.Index, dgvImpExp.Rows.Count - 1].Value = GetIssueNo(dtExp.Rows[i]["issued_id"].ToString(), "اعتماد");
                    dgvImpExp[clmEXPENSES_ID.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["expenses_item_id"].ToString();
                    dgvImpExp[clmEXPENSES_Name.Index, dgvImpExp.Rows.Count - 1].Value = dtExp.Rows[i]["exp_name"].ToString();

                    dgvImpExp[clmISSUED_EXPENSES_Helper.Index, dgvImpExp.Rows.Count - 1].Value = strValue;
                    dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value = strValue;

                    dgvImpExp[clmSTOCK_EXPENSES_VALUE.Index, dgvImpExp.Rows.Count - 1].Value = (Convert.ToDecimal(strValue) / exchangeRate);


                    dgvImpExp[clmNote.Index, dgvImpExp.Rows.Count - 1].Value = "";
                    dgvImpExp[clmMETHOD_OF_CALCULATION.Index, dgvImpExp.Rows.Count - 1].Value = "";
                }


            }



        }

        private string GetIssueNo(string strSwid,string strIssueType)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetIssuNO=new DataTable();
            switch (strIssueType)
            {
                case "وارد":
                    dtGetIssuNO = cnn.GetDataTable("select i.import_no from imports i where swid="+strSwid);
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

        decimal dAvgExhangeRate = 0;
        private void dgvImpExp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;



            DataGridViewCell abc = dgvImpExp.CurrentCell;

            Rectangle RECT = dgvImpExp.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);

            if (e.ColumnIndex == clmMAIN_EXPENSES_VALUE.Index)
            {
                dAvgExhangeRate = Convert.ToDecimal(dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, e.RowIndex].Value.ToString()) / Convert.ToDecimal(dgvImpExp[clmSTOCK_EXPENSES_VALUE.Index, e.RowIndex].Value.ToString());
                nmbEditor.Value = Convert.ToDecimal(dgvImpExp[e.ColumnIndex, e.RowIndex].Value.ToString());
                nmbEditor.Tag = e.RowIndex.ToString();
                nmbEditor.W_ColEgName = e.ColumnIndex.ToString();
                CtlLocation(RECT, nmbEditor);
            }
            else if(e.ColumnIndex==clmMETHOD_OF_CALCULATION.Index)
            {
                lstEditor.Text = dgvImpExp[e.ColumnIndex, e.RowIndex].Value.ToString();
                lstEditor.Tag = e.RowIndex.ToString();
                lstEditor.W_ColEgName = e.ColumnIndex.ToString();
                CtlLocation(RECT, lstEditor);
            }

           
                


        }
        private void CtlLocation(Rectangle rect, Control ctrl)
        {


            ctrl.Top = dgvImpExp.Location.Y + rect.Y;
            ctrl.Left = dgvImpExp.Location.X + rect.X;
            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;
            ctrl.Focus();


        }

        private void lstEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void lstEditor_Leave(object sender, EventArgs e)
        {
            if (lstEditor.Visible == true)
            {
                lstEditor.Visible = false;

                dgvImpExp[clmMETHOD_OF_CALCULATION.Index , Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.Text;
               

            }
        }

        private void nmbEditor_Leave(object sender, EventArgs e)
        {
            if (nmbEditor.Visible == true)
            {
                nmbEditor.Visible = false;

                if (nmbEditor.Value > Convert.ToDecimal(dgvImpExp[clmISSUED_EXPENSES_Helper.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value))
                    dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = dgvImpExp[clmISSUED_EXPENSES_Helper.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value.ToString();
                else
                    dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = nmbEditor.Value.ToString();



                dgvImpExp[clmSTOCK_EXPENSES_VALUE.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value =( Convert.ToDecimal(dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value) / dAvgExhangeRate).ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtImportId.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار الوارد");
                return;
            }
            if (lstImpContainer.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار الحاوية");
                return;
            }


           
            int icheck = 0;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtSwid = cnn.GetDataTable("select nvl(max(swid),0)+1 from CALCULATE_COSTS_Header");
            txtSwid.Text = dtSwid.Rows[0][0].ToString();

            glb_function.arrInsertLogs.Add("insert into CALCULATE_COSTS_Header values("+txtSwid.Text +",sysdate,"+glb_function.glb_strUserId+",'فعال','"+txtNote.Text+"',"+txtImportId.Text +",'"+ lstImpContainer .Text + "')");

            for (int i = 0; i < dgvImpExp.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dgvImpExp[clmMAIN_EXPENSES_VALUE.Index,i].Value.ToString()) <= 0)
                {
                   // glb_function.MsgBox("الرجاء ادخال القمية");
                    continue ;
                }
                if (dgvImpExp[clmMETHOD_OF_CALCULATION.Index, i].Value.ToString() == "")
                {
                   // glb_function.MsgBox("الرجاء تحديد طريقة التوزيع");
                    continue;
                }



                glb_function.arrInsertLogs.Add("insert into CALCULATE_COSTS_DE " +
                    "values((select nvl(max(swid),0)+1 from CALCULATE_COSTS_DE),sysdate,"+
                    glb_function.glb_strUserId+",'"+dgvImpExp[clmISSUED_TYPE.Index,i].Value.ToString()+ "'," +
                    dgvImpExp[clmISSUED_Swid.Index, i].Value.ToString() + "," + 
                    dgvImpExp[clmMAIN_EXPENSES_VALUE.Index, i].Value.ToString() + "," + 
                    dgvImpExp[clmSTOCK_EXPENSES_VALUE.Index, i].Value.ToString() + "," +
                  
                    dgvImpExp[clmEXPENSES_ID.Index, i].Value.ToString() + ",'" + 
                    dgvImpExp[clmNote.Index, i].Value.ToString() + "','0',null,"+
                    txtSwid.Text + ",'" + dgvImpExp[clmMETHOD_OF_CALCULATION.Index, i].Value.ToString() + "',null,null)");




            }
            if (glb_function.arrInsertLogs.Count<=1 )
            {
                glb_function.MsgBox("لم يتم تحديد مصاريف للتوزيع");
                return;
            }

            if (glb_function.MultiTransData())
                LoadExp();
           
        }

        private void lstImpContainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDestributeExp_Load(object sender, EventArgs e)
        {
            nmbEditor.DecimalPlaces = glb_function.glbMainDecimalPoint;
        }
    }
}
