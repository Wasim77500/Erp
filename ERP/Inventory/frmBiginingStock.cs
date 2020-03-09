using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ERP.Inventory
{
    public partial class frmBiginingStock : MyForm
    {
        double dRate;
        private string strJournalSWid;
        private string strDetails;
        private string strHeader;

        public frmBiginingStock()
        {
            InitializeComponent();
        }

        private void frmBiginingStock_Load(object sender, EventArgs e)
        {
            PrepareForm();

        }
        private void PrepareForm()
        {
            glb_function.FillListWithId(ref lstWarehouse, "warehouse", "w_name");
            GetRate();
        }
        private void GetRate()
        {
            
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtRate = cnn.GetDataTable("select max(cex.curr_price ),max((select k.curr_decimal from currency k  where k.is_stock_curr = 1)) curr_dec " +
                                               " from currency_exchange cex where cex.curr_id = (" +
                                               " select swid from currency c " +
                                               " where c.is_stock_curr = 1)");
            nmbRate.DecimalPlaces = Convert.ToInt16(dtRate.Rows[0][1].ToString());
            nmbRate.Value  =Convert.ToDecimal ( dtRate.Rows[0][0].ToString());

        }
        private void btnFindItem_Click(object sender, EventArgs e)
        {
            if(lstWarehouse.SelectedIndex ==-1)
            {
                glb_function.MsgBox("الرجاء اختيار المخزن اولا");
                lstWarehouse.Focus();
                return;
            }
            frmFindItem frm = new frmFindItem();

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtItemId.Text = frm.strItemID;
                GetItemData(txtItemId.Text);
                
            }
        }
        private void GetItemData(string strSwid)
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems = cnn.GetDataTable("select i.swid,item_no,item_name,c.category_name,a.act_name "+
                               "  from items i, CATEGORIES c, activities a, warehouse_items wi " +
                              "  where c.swid = i.category_id " +
                               " and a.swid = i.activity_id and i.swid = wi.item_id and i.swid = " + strSwid + " and wi.warehouse_id="+lstWarehouse.SelectedValue.ToString());

            if(dtItems is null || dtItems.Rows.Count <0)
            {
                glb_function.MsgBox("الصنف غير موجود في المخزن المحدد");
                return;
            }
            txtItemNo.Text = dtItems.Rows[0]["item_no"].ToString();
            txtItemName.Text = dtItems.Rows[0]["item_name"].ToString();
            txtCatagory.Text = dtItems.Rows[0]["category_name"].ToString();
            txtActivity.Text = dtItems.Rows[0]["act_name"].ToString();

            GetItemLocation();


        }
        private void GetItemLocation()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select ml.swid,wl.full_loction_code from warehouse_loction wl,move_items_location ml"+
                       " where wl.swid = ml.warehouse_location_id "+
                       " and ml.item_id = "+ txtItemId.Text);

            lstWAREHOUSE_LOCTION.DataSource = dtLocation;
            lstWAREHOUSE_LOCTION.ValueMember = "swid";
            lstWAREHOUSE_LOCTION.DisplayMember = "full_loction_code";

        }
        private void lstWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWarehouse.SelectedValue == null)
                return;



            if (lstWarehouse.SelectedValue.ToString() != "System.Data.DataRowView" && lstWarehouse.SelectedValue.ToString() != "")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtWarehouseAcc = cnn.GetDataTable("select acc_id from warehouse w where swid="+lstWarehouse.SelectedValue.ToString());

                txtAcc_id.Text = dtWarehouseAcc.Rows[0][0].ToString();

            }
        }

        private void nmbQUANTITY_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nmbCOST_TextChanged(object sender, EventArgs e)
        {
            nmbCOST_LOCAL.Value = nmbCOST.Value * nmbRate.Value;
        }
        private bool CheckDetailsData()
        {
            int iError = 0;
            if (txtItemId.Text == "")
            {

                errCheck.SetError(txtItemNo, "الرجاء ادخال رقم القطعة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtItemNo, "");
            }

            if (nmbQUANTITY.Value  <=0)
            {

                errCheck.SetError(nmbQUANTITY, "الرجاء ادخال الكمية");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbQUANTITY, "");
            }

            if (nmbCOST.Value <= 0)
            {

                errCheck.SetError(nmbCOST, "الرجاء ادخال التكلفة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbCOST, "");
            }

            if (lstWAREHOUSE_LOCTION.SelectedIndex  == -1)
            {

                errCheck.SetError(lstWAREHOUSE_LOCTION, "الرجاء اختيار الموقع");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstWAREHOUSE_LOCTION, "");
            }



            if (iError == 1)
                return false;


            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!CheckDetailsData())
                return;

            dgvItems.Rows.Add();
            dgvItems[0, dgvItems.Rows.Count - 1].Value = "";
            dgvItems[1, dgvItems.Rows.Count - 1].Value =txtItemId.Text ;
            dgvItems[2, dgvItems.Rows.Count - 1].Value = txtItemNo.Text ;
            dgvItems[3, dgvItems.Rows.Count - 1].Value =txtItemName.Text ;
            dgvItems[4, dgvItems.Rows.Count - 1].Value = nmbQUANTITY.Value.ToString();
            dgvItems[5, dgvItems.Rows.Count - 1].Value = dtpEXPIRY_DATE.Value.ToString("dd/MM/yyyy");
            dgvItems[6, dgvItems.Rows.Count - 1].Value = nmbCOST.Value .ToString();
            dgvItems[7, dgvItems.Rows.Count - 1].Value = nmbCOST_LOCAL.Value.ToString();
            dgvItems[8, dgvItems.Rows.Count - 1].Value = (nmbCOST.Value * nmbQUANTITY.Value ).ToString();
            dgvItems[9, dgvItems.Rows.Count - 1].Value = (nmbCOST_LOCAL.Value * nmbQUANTITY.Value).ToString();
            dgvItems[10, dgvItems.Rows.Count - 1].Value = lstWAREHOUSE_LOCTION.SelectedValue.ToString();
            dgvItems[11, dgvItems.Rows.Count - 1].Value = lstWAREHOUSE_LOCTION.Text ;
            GetSum();
            
        }
        private void ClearDetailData()
        {
            txtItemId.Text = "";
            txtItemNo.Text = "";
            txtItemName.Text = "";
            txtCatagory.Text = "";
            txtActivity.Text = "";
            nmbQUANTITY.Value = 0;
            dtpEXPIRY_DATE.Value = DateTime.Now;
            nmbCOST.Value = 0;
            lstWAREHOUSE_LOCTION.SelectedIndex = -1;
            lstWAREHOUSE_LOCTION.Text = "";
        }
        private void GetSum()
        {
            decimal dTotalCost = 0;
            decimal dTotalLocalCost = 0;
            for (int i = 0; i < dgvItems.Rows.Count ; i++)
            {
                dTotalCost += Convert.ToDecimal (dgvItems[8, i].Value.ToString());
                dTotalLocalCost += Convert.ToDecimal(dgvItems[9, i].Value.ToString());
            }
            nmbCOST_Total.Value = dTotalCost;
            nmbCOST_LOCAL_Total.Value = dTotalLocalCost;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

        }
        private string GetMainCurrency()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtMainCurr = cnn.GetDataTable("select swid from currency  c where c.is_main_curr=1");
            return dtMainCurr.Rows[0][0].ToString();
        }
        private void SaveUpdateJournal()
        {
            //if (!CheckEntries())
            //    return;


            StringBuilder sbGetXml = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(sbGetXml);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("DocumentElement".ToLower());

            xmlWriter.WriteStartElement("journal_header".ToLower());

            xmlWriter.WriteElementString("SWID".ToLower(), strJournalSWid);

            xmlWriter.WriteElementString("CREATED_USER".ToLower(), glb_function.glb_strUserId);

            xmlWriter.WriteElementString("STAT".ToLower(), "فعال");

            xmlWriter.WriteElementString("JOUR_NUM".ToLower(),"");

            xmlWriter.WriteElementString("VOCH_TYPE".ToLower(), "قيد افتتاحي");

            xmlWriter.WriteElementString("VOCH_NO".ToLower(), "");

            xmlWriter.WriteElementString("VOCH_NO_M".ToLower(), "");

            xmlWriter.WriteElementString("JOUR_DATE".ToLower(), dtpMOVE_DATE.Value.ToString("dd/MM/yyyy"));

            xmlWriter.WriteElementString("JOUR_DETAILS_Header".ToLower(), "");

            xmlWriter.WriteElementString("BranchHeader".ToLower(), "1");

            xmlWriter.WriteElementString("MODEL_NO".ToLower(), lstTemplet.SelectedValue.ToString());

            xmlWriter.WriteElementString("JOUR_VALUE".ToLower(), nmbCOST_LOCAL_Total.Value.ToString());
            xmlWriter.WriteElementString("ORDER_ID".ToLower(), "");
            xmlWriter.WriteElementString("CONTACT_ID".ToLower(), "");
            xmlWriter.WriteElementString("NOTE_NO".ToLower(), "");
            xmlWriter.WriteElementString("COLLECTOR_ID".ToLower(), "");
            xmlWriter.WriteElementString("CONTACT_NAME".ToLower(), "");
            xmlWriter.WriteElementString("REVERSE_VOCHER_ID".ToLower(), "");

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();
             strHeader = sbGetXml.ToString();


            //DataTable dt = new DataTable();
            //dt.TableName = "sqlsttab";
            // dt = (DataTable)(dgJOURNAL_DETAILS.DataSource);
            DataTable dt = new DataTable();
            dt.TableName = "JOURNAL_DETAILS".ToLower();
            foreach (DataGridViewColumn col in dgJOURNAL_DETAILS.Columns)
            {
                if (col.ToolTipText == ".")
                    dt.Columns.Add(col.Name.ToLower());
            }
           
                dt.Rows.Add(new Object[] { "",
               0,
                nmbCOST_LOCAL_Total.Value.ToString(),
                nmbCOST_LOCAL_Total.Value.ToString(),
                 txtAcc_id.Text ,
                 GetMainCurrency(),
                  1,
                  "",
                   "",
                  "فعال"

                });
            


            System.IO.StringWriter writer = new System.IO.StringWriter();
            dt.WriteXml(writer);
             strDetails = writer.ToString();

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count <= 0)
            {

                glb_function.MsgBox("الرجاء ادخال صنف واحد على الاقل");
                return;
            }
            string strStat = "";
            string strHash = "";
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBigningVocher = cnn.GetDataTable("select swid,stat from journal_header h " +
                        "where h.voch_type = 'قيد افتتاحي'");

            if (dtBigningVocher == null || dtBigningVocher.Rows.Count <= 0)
            {
                //create new bigining vocher

                SaveUpdateJournal();
                ConnectionToDB.objCmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
                ConnectionToDB.objCmd.Parameters.Add("xml_journal_header", Oracle.ManagedDataAccess.Client.OracleDbType.XmlType).Value = strHeader;
                ConnectionToDB.objCmd.Parameters.Add("xml_journal_details", Oracle.ManagedDataAccess.Client.OracleDbType.XmlType).Value = strDetails.Replace("DocumentElement", "DocumentElement".ToLower());
                ConnectionToDB.objCmd.Parameters.Add("sqlStat", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = strStat;
                ConnectionToDB.objCmd.Parameters.Add("strHash", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = strHash;
                ConnectionToDB.objCmd.Parameters.Add("icheck", Oracle.ManagedDataAccess.Client.OracleDbType.Int16).Value = 0;
                ConnectionToDB.objCmd.Parameters.Add("swid", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
                ConnectionToDB.objCmd.Parameters.Add("Result", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
                string strResult = cnn.ExecutePro("AccountsPack.journal_inser_update", "Result");
                strJournalSWid = ConnectionToDB.objCmd.Parameters["swid"].Value.ToString();
                if (strResult.ToUpper() == "SUCCEED")
                {



                }

                else
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء تنفيذ العملية" + "\n" + strResult);
                    return;
                }
            }
            else
            {
                if (dtBigningVocher.Rows[0]["stat"].ToString() != "فعال")
                {
                    glb_function.MsgBox("لايمكن اضافة مخزون افتتاحي " + "\n" + "تم اعتماد القيد الافتتاحي");
                    return;
                }
                else
                {
                    //create data detail
                    SaveUpdateJournal();
                    ConnectionToDB.objCmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
                    ConnectionToDB.objCmd.Parameters.Add("xml_journal_header", Oracle.ManagedDataAccess.Client.OracleDbType.XmlType).Value = strHeader;
                    ConnectionToDB.objCmd.Parameters.Add("xml_journal_details", Oracle.ManagedDataAccess.Client.OracleDbType.XmlType).Value = strDetails.Replace("DocumentElement", "DocumentElement".ToLower());
                    ConnectionToDB.objCmd.Parameters.Add("sqlStat", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = strStat;
                    ConnectionToDB.objCmd.Parameters.Add("strHash", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = strHash;
                    ConnectionToDB.objCmd.Parameters.Add("icheck", Oracle.ManagedDataAccess.Client.OracleDbType.Int16).Value = 0;
                    ConnectionToDB.objCmd.Parameters.Add("swid", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
                    ConnectionToDB.objCmd.Parameters.Add("Result", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
                    string strResult = cnn.ExecutePro("AccountsPack.journal_inser_update", "Result");
                    strJournalSWid = ConnectionToDB.objCmd.Parameters["swid"].Value.ToString();
                    if (strResult.ToUpper() == "SUCCEED")
                    {



                    }

                    else
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ اثناء تنفيذ العملية" + "\n" + strResult);
                        return;
                    }



                }
            }

            //create inventory move data
        }
    }
}
