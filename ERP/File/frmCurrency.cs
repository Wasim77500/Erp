using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ERP.File
{

    
    public partial class frmCurrency : MyForm
    {
      
        public frmCurrency()
        {
            try { InitializeComponent(); }

            catch (Exception ee)
            {
                glb_function.MsgBox(ee.Message);
            }
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;

                btnUpdate.Enabled = false;
                CheckDefaultCurrency();
                GetExchangeData();
                FillCurrencyName();
           
        }
        private void FillCurrencyName()
        {
            ConnectionToDB myconn = new ConnectionToDB();
            DataTable MyDataTable;
            MyDataTable = myconn.GetDataTable("Select SWID, CURR_NAME test From CURRENCY order by SWID");
            if (MyDataTable != null && MyDataTable.Rows.Count >0)
               
            {
               
                lstCurr_name.DataSource = MyDataTable;
                lstCurr_name.DisplayMember = "test".ToUpper();
                lstCurr_name.ValueMember = "SWID";

                lstCurr_name.SelectedIndex = -1;
            }
        }
        private void GetExchangeData()
        {
            dgCurr_Exchange.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCurrEx = cnn.GetDataTable("select c.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL,OVERRIDE_VALUE from currency c,currency_exchange e" +
                " where e.curr_id = c.swid " +
               " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid) and c.IS_MAIN_CURR!=1");

            for (int i = 0; i < dtCurrEx.Rows.Count ; i++)
            {
                dgCurr_Exchange.Rows.Add();
                dgCurr_Exchange[0, dgCurr_Exchange.Rows.Count - 1].Value = dtCurrEx.Rows[i]["curr_name"].ToString();
                dgCurr_Exchange[1, dgCurr_Exchange.Rows.Count - 1].Value = dtCurrEx.Rows[i]["curr_price"].ToString();
                dgCurr_Exchange[2, dgCurr_Exchange.Rows.Count - 1].Value = dtCurrEx.Rows[i]["CURR_MIN"].ToString();
                dgCurr_Exchange[3, dgCurr_Exchange.Rows.Count - 1].Value = dtCurrEx.Rows[i]["CURR_MAX"].ToString();
                dgCurr_Exchange[4, dgCurr_Exchange.Rows.Count - 1].Value = dtCurrEx.Rows[i]["CURR_DECIMAL"].ToString();
                dgCurr_Exchange[5, dgCurr_Exchange.Rows.Count - 1].Value = dtCurrEx.Rows[i]["swid"].ToString();
                dgCurr_Exchange[clmOverride_value.Index, dgCurr_Exchange.Rows.Count - 1].Value = dtCurrEx.Rows[i]["OVERRIDE_VALUE"].ToString();
            }
        }
       private void CheckDefaultCurrency()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCurr = cnn.GetDataTable("select IS_MAIN_CURR from CURRENCY where IS_MAIN_CURR='1'");
            if (dtCurr != null && dtCurr.Rows.Count > 0)
                ckbIS_MAIN_CURR.Enabled = false;

            dtCurr.Rows.Clear();
            cnn.GetDataTable("select IS_STOCK_CURR from CURRENCY where IS_STOCK_CURR='1'");
            if (dtCurr != null && dtCurr.Rows.Count > 0)
                ckbIS_STOCK_CURR.Enabled = false;


        }
       

        private void nmbCURR_DECIMAL_ValueChanged(object sender, EventArgs e)
        {
          //  nmbCurrExchange.DecimalPlaces =Convert.ToInt16( nmbCURR_DECIMAL.Value) ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select nvl(max(swid),0)+1 from CURRENCY");

            txtSWID.Text = dtLocation.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
            ("insert into CURRENCY values(" + txtSWID.Text +
                ",sysdate,"+glb_function.glb_strUserId +",'ACTIVE', '" +
                txtCURR_NAME.Text + "','" + txtCURR_SMPL.Text + "'," +               
                " "+ nmbCURR_DECIMAL.Value.ToString() + ",'"+ txtCURR_NOTE.Text  + "','" + ( ckbIS_MAIN_CURR.Checked ==true ?"1":"0") + 
                "','"+ txtCURR_CHANGE .Text + "','" + (ckbIS_STOCK_CURR.Checked == true ? "1" : "0") + "')");


            glb_function.arrInsertLogs.Add
           ("insert into CURRENCY_EXCHANGE values(" + "(select nvl(max(swid),0)+1 from CURRENCY_EXCHANGE)" +
               ",sysdate," + glb_function.glb_strUserId + ",'" + txtSWID.Text + "', " + nmbCurrExchange.Value.ToString() +
               ","+ nmbCurrExchange.Value.ToString() + ","+ nmbCurrExchange.Value.ToString() + ")");


            if (glb_function.MultiTransData ())
            {
                if (ckbIS_MAIN_CURR.Checked == true)
                {
                    glb_function.glb_MainCurrencyId =Convert.ToInt16( txtSWID.Text);
                    glb_function.glbMainCurrencyName = txtCURR_NAME.Text;
                }
                    

                GetData(txtSWID.Text.Trim());
                GetExchangeData();
                
                //btnSave.Visible  = false;
                //btnNew.Location = btnSave.Location;
                //btnNew.Visible = true;
                //btnUpdate.Enabled = true;
            }


        }
        private void GetData(string strPK)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCurrency = cnn.GetDataTable("select * from currency where swid="+strPK);

            txtCURR_NAME.Text = dtCurrency.Rows[0]["CURR_NAME"].ToString();
            txtCURR_NAME.W_OldValue = dtCurrency.Rows[0]["CURR_NAME"].ToString();

            txtCURR_SMPL.Text = dtCurrency.Rows[0]["CURR_SMPL"].ToString();
            txtCURR_SMPL.W_OldValue = dtCurrency.Rows[0]["CURR_SMPL"].ToString();


            nmbCURR_DECIMAL.Value  =Convert.ToInt32( dtCurrency.Rows[0]["CURR_DECIMAL"].ToString());
            nmbCURR_DECIMAL.W_OldValue = dtCurrency.Rows[0]["CURR_DECIMAL"].ToString();

            txtCURR_NOTE.Text = dtCurrency.Rows[0]["CURR_NOTE"].ToString();
            txtCURR_NOTE.W_OldValue = dtCurrency.Rows[0]["CURR_NOTE"].ToString();

            txtCURR_CHANGE.Text = dtCurrency.Rows[0]["CURR_CHANGE"].ToString();
            txtCURR_CHANGE.W_OldValue = dtCurrency.Rows[0]["CURR_CHANGE"].ToString();

            ckbIS_MAIN_CURR.Checked = (dtCurrency.Rows[0]["IS_MAIN_CURR"].ToString() == "1" ? true : false);
            ckbIS_STOCK_CURR .Checked = (dtCurrency.Rows[0]["IS_STOCK_CURR"].ToString() == "1" ? true : false);



            dtCurrency.Rows.Clear();
            dtCurrency = cnn.GetDataTable("select e.curr_price from CURRENCY_EXCHANGE e "+
                          "  where e.created_date = "+
                           " (select max(created_date) from CURRENCY_EXCHANGE t"+
                                             "         where curr_id = "+strPK +")");

            if (dtCurrency == null || dtCurrency.Rows.Count < 0)
                nmbCurrExchange.Value = 0;
            else
                nmbCurrExchange.Value =Convert.ToUInt32( dtCurrency.Rows[0][0].ToString());
            

            // GetExchangeLog();
            lstCurr_name.SelectedValue = txtSWID.Text;

            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            ckbIS_MAIN_CURR.Enabled = false;
            ckbIS_STOCK_CURR.Enabled = false;
            nmbCurrExchange.Enabled = false;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }
        private void GetExchangeLog()
        {
            dgExhangeLog.Rows.Clear();

              ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtExLog = cnn.GetDataTable("select CURR_ID,CURR_PRICE,CURR_MIN,CURR_MAX,to_char(CREATED_DATE,'dd/mm/yyyy') CREATED_DATE from CURRENCY_EXCHANGE" +
                                " where curr_id="+lstCurr_name.SelectedValue.ToString() + "order by swid desc" );
            for (int i = 0; i < dtExLog.Rows.Count ; i++)
            {
                dgExhangeLog.Rows.Add();
                dgExhangeLog[0, dgExhangeLog.Rows.Count - 1].Value = dtExLog.Rows[i]["CURR_PRICE"].ToString();
                dgExhangeLog[1, dgExhangeLog.Rows.Count - 1].Value = dtExLog.Rows[i]["CURR_MIN"].ToString();
                dgExhangeLog[2, dgExhangeLog.Rows.Count - 1].Value = dtExLog.Rows[i]["CURR_MAX"].ToString();
                dgExhangeLog[3, dgExhangeLog.Rows.Count - 1].Value = dtExLog.Rows[i]["CREATED_DATE"].ToString();
            }


        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;


            int iError = 0;
            if (txtCURR_NAME.Text == "")
            {

                errCheck.SetError(txtCURR_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtCURR_NAME, "");
            }

            if (txtCURR_SMPL.Text == "")
            {

                errCheck.SetError(txtCURR_SMPL, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtCURR_SMPL, "");
            }

           


            if (nmbCurrExchange.Value <= 0)
            {

                errCheck.SetError(nmbCurrExchange, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbCurrExchange, "");
            }
            //nmbCurrExchange

            if (iError == 1)
                return false;

            return true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
            ckbIS_STOCK_CURR.Enabled = true;
            ckbIS_MAIN_CURR .Enabled = true;
            nmbCurrExchange.Enabled = true ;
            CheckDefaultCurrency();
            GetExchangeData();
            
            FillCurrencyName();
            dgExhangeLog.Rows.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
               ("update CURRENCY set "  +
                " CURR_NAME='" + txtCURR_NAME.Text + "',CURR_SMPL='" + txtCURR_SMPL.Text + "'," +
                " CURR_DECIMAL=" + nmbCURR_DECIMAL.Value.ToString() + ""+
                ",CURR_NOTE='" + txtCURR_NOTE.Text + "' where swid="+txtSWID.Text );


            new glb_function().InsertToLogs(this, "CURRENCY", txtSWID.Text,"");
            //other table 

            if(glb_function.MultiTransData())

            GetData(txtSWID.Text);
        }

        private void pnlCurrency_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindCurrency frm = new frmFindCurrency();

            frm.ShowDialog();

            if (frm.strCurrencyid != "")
            {
                txtSWID.Text = frm.strCurrencyid;
                GetData(txtSWID.Text);
            }
        }

        private void dgCurr_Exchange_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtExCURR_NAME.Text = dgCurr_Exchange[0, e.RowIndex].Value.ToString();

                nmbCURR_PRICE.DecimalPlaces = nmbCURR_MIN.DecimalPlaces = nmbCURR_MAX.DecimalPlaces = Convert.ToInt16(dgCurr_Exchange[4, e.RowIndex].Value.ToString());
                nmbCURR_PRICE.Value = Convert.ToDecimal(dgCurr_Exchange[1, e.RowIndex].Value.ToString());
                nmbCURR_PRICE.W_OldValue = dgCurr_Exchange[1, e.RowIndex].Value.ToString();
                nmbCURR_MIN.Value = Convert.ToDecimal(dgCurr_Exchange[2, e.RowIndex].Value.ToString());
                nmbCURR_MIN.W_OldValue = dgCurr_Exchange[2, e.RowIndex].Value.ToString();
                nmbCURR_MAX.Value = Convert.ToDecimal(dgCurr_Exchange[3, e.RowIndex].Value.ToString());
                nmbCURR_MAX.W_OldValue = dgCurr_Exchange[3, e.RowIndex].Value.ToString();


                txtCURR_ID.Text = dgCurr_Exchange[5, e.RowIndex].Value.ToString();



            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
           

            if (!CheckExEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
          


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
            ("insert into CURRENCY_EXCHANGE values((select nvl(max(swid),0)+1 from CURRENCY_EXCHANGE)" +
            " ,sysdate," + glb_function.glb_strUserId + "" +
                "," + txtCURR_ID.Text  + ", " + nmbCURR_PRICE.Value.ToString() + "," + nmbCURR_MIN.Value.ToString() + "" +
                ", " + nmbCURR_MAX.Value.ToString() + ","+nmbOverrideValue.Value.ToString()+")");

            if (glb_function.MultiTransData ())
            {
                ClearExData();
                GetExchangeData();

            }


           
        }
        private void ClearExData()
        {
            txtCURR_ID.Text = "";
            txtExCURR_NAME.Text = "";
            nmbCURR_PRICE.DecimalPlaces = nmbCURR_MIN.DecimalPlaces = nmbCURR_MAX.DecimalPlaces = 0;
            nmbCURR_PRICE.Value = 0;
            nmbCURR_MIN.Value = 0;
            nmbCURR_MAX.Value = 0;
            nmbOverrideValue.Value = 0;


        }
        private bool CheckExEntries()
        {

            if (nmbCURR_PRICE.Value == Convert.ToDecimal(nmbCURR_PRICE.W_OldValue) && nmbCURR_MAX.Value == Convert.ToDecimal(nmbCURR_MAX .W_OldValue) && nmbCURR_MIN.Value == Convert.ToDecimal(nmbCURR_MIN.W_OldValue))
            {
                glb_function.MsgBox("لم يتم تعديل سعر الصرف القديم");
                return false ;
            }

            int iError = 0;
            if (txtExCURR_NAME.Text == "")
            {

                errCheck.SetError(txtExCURR_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtExCURR_NAME, "");
            }

            if (nmbCURR_PRICE.Value <=0)
            {

                errCheck.SetError(nmbCURR_PRICE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbCURR_PRICE, "");
            }




            if (nmbCURR_MIN.Value > nmbCURR_PRICE.Value )
            {

                errCheck.SetError(nmbCURR_MIN, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbCURR_MIN, "");
            }


            if (nmbCURR_MAX.Value < nmbCURR_PRICE.Value)
            {

                errCheck.SetError(nmbCURR_MAX, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbCURR_MAX, "");
            }

            if (iError == 1)
                return false;

            return true;
        }

        private void btnUpdate_EnabledChanged(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled == true)
                pnlCurrExchange .Enabled = true;
            else
                pnlCurrExchange.Enabled = false;
        }

        private void lstCurr_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstCurr_name.SelectedValue == null)
                return;

            if (lstCurr_name.SelectedValue.ToString() != "System.Data.DataRowView" && lstCurr_name.SelectedValue.ToString() != "")
            {
                GetExchangeLog();
            }
        }

        private void btnSearch_EnabledChanged(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled == true)
                lstCurr_name.Enabled = true;
            else
                lstCurr_name.Enabled = false;
        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void frmCurrency_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void ckbIS_MAIN_CURR_CheckStateChanged(object sender, EventArgs e)
        {
            if(ckbIS_MAIN_CURR.Checked ==true)
            {
                nmbCurrExchange.Value = 1;
                nmbCurrExchange.Enabled = false;
            }
        }
    }
}
