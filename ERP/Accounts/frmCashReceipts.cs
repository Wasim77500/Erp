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

namespace ERP.Accounts
{
    public partial class frmCashReceipts : MyForm
    {
      

        string strHash = "";
        string strStat = "";




        decimal dHeaderMaxRate = 0;
        decimal dHeaderMinRate = 0;
        decimal dHeaderExchangeRate = 0;   //سعر الصرف الحالي
        decimal dHeaderOverrideValue;
        string iHeaderCurrSwid;

        int iHeaderCurrDecimal = 0;

        decimal dDetailMaxRate = 0;
        decimal dDetailMinRate = 0;
        decimal dDetailExchangeRate = 0;   //سعر الصرف الحالي
        decimal dDetailOverrideValue;
        string iDetailCurrSwid;

        int iDetailCurrDecimal = 0;



        public string strTempswid = "";

        int iUpdateRow = -1;
        public frmCashReceipts()
        {
            InitializeComponent();
        }

        bool bLoad = true ;
        private void frmCashReceipts_Load(object sender, EventArgs e)
        {
           
            //PrepareForm load from lstTemplet_MorePrivilleges
            
        }
        public override void lstTemplet_MorePrivilleges(object sender, EventArgs e)
        {


            FillCasher();
            FillBenes();
            if (nmbAccBalance.Visible == false)
                lblBalance.Visible = false;
            else
                lblBalance.Visible = true;


            bLoad = true;
            PrepareForm();
            bLoad = false;

        }
        private void PrepareForm()
        {

            FillHeaderCurrency();

            try
            {

                lstCashers.SelectedIndex = -1;
                lstCashers.SelectedIndex = 0;
              
                new glb_function().clearItems(this);

                
                lstCurrencyHeader.SelectedIndex = -1;
                lstCurrencyHeader.SelectedIndex = 0;

                lstAccNo.Text = "";
                lstAccName.Text = "";
                lstAccNo.SelectedIndex = -1;
                lstAccName.SelectedIndex = -1;

                strHash = "";
                strStat = "";


                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnPrint.Enabled = false;
                btnSave.Enabled = true;
                dtpVoch_date.Value = glb_function.dtSysdate;
                lstBeneTypeVoch.Text = "عميل";
                nmbMainValueDetail.Enabled = false;
                nmbValueDetail.Enabled = false;
                lblBalanceType.Visible = false;
              
            }
            catch (Exception ex)
            {
                glb_function.MsgBox("حدث خطأ اثناء تهيئة النموذج .");
                this.Close();
                return;
            }
        }
        private void FillHeaderCurrency()
        {
            ConnectionToDB conn = new ConnectionToDB();
            DataTable MyDataTable;

            MyDataTable = conn.GetDataTable("select swid,curr_name from CURRENCY t  order by swid");

            if (MyDataTable != null)
            {

                lstCurrencyHeader.DataSource = MyDataTable;


                lstCurrencyHeader.DisplayMember = "curr_name";
                lstCurrencyHeader.ValueMember = "SWID";


                // lstCurrency.SelectedIndex = 0;



                //  lstCurrency.SelectedIndex = -1;
            }
        }


        private void FillBenes()
        {
            lstBeneTypeVoch.Items.Clear();
            //lstBeneTypeVoch.Items.Add("عميل");
            //lstBeneTypeVoch.Items.Add("اخر");
            ConnectionToDB cnn = new ConnectionToDB();

            string strMult = lstTempBeneType.Text.Trim();
            string iindexx = "";
            //string strInStat = "";
            while (strMult != "")
            {


                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                lstBeneTypeVoch.Items.Add(iindexx);
                //strInStat = (strInStat == "" ? "'" + iindexx + "'" : strInStat + ",'" + iindexx + "'");


            }


        }

        private void FillCasher()
        {

            lstCashers.DataSource = null;
            ConnectionToDB cnn = new ConnectionToDB();

            string strMult = lstTempCasher.Text.Trim();
            string iindexx = "";
            string strInStat = "";
            while (strMult != "")
            {


                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                // lstBranchHeader.Items.Add(iindexx);
                strInStat = (strInStat == "" ? "'" + iindexx + "'" : strInStat + ",'" + iindexx + "'");


            }

            DataTable dt = cnn.GetDataTable("select swid,c_name,c.c_type,branch_id from casher c " +
                " where c.c_name in (" + strInStat + ") and stat='فعال'");

            lstCashers.DataSource = dt;
            lstCashers.ValueMember = "swid";
            lstCashers.DisplayMember = "c_name";
            lstCashers.SelectedIndex = -1;

        }

        private void dtpVoch_date_ValueChanged(object sender, EventArgs e)
        {
            if (txtExRateDateDefaultValue.Text.Trim() == "نعم")
            {
                dgJOURNAL_DETAILS.Rows.Clear();

            }

        }

        private void lstCurrencyHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCurrencyHeader.SelectedValue == null)
                return;

            if (lstCurrencyHeader.SelectedValue.ToString() != "System.Data.DataRowView" && lstCurrencyHeader.SelectedValue.ToString() != "")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtcurr = new DataTable(); ;
                if (txtExRateDateDefaultValue.Text.Trim() == "نعم")
                    dtcurr = cnn.GetDataTable("select e.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL,e.override_value,e.created_date " +
                                    " from currency c, currency_exchange e " +
                                    " where e.curr_id = c.swid and c.swid = " + lstCurrencyHeader.SelectedValue.ToString() + " " +
                                    " and e.created_date <= to_date('" + dtpVoch_date.Value.ToString("dd/MM/yyyy") + "', 'dd/mm/yyyy') " +
                                    " and e.swid = (select max(e.swid) from currency c, currency_exchange e " +
                                    " where e.curr_id = c.swid and c.swid = " + lstCurrencyHeader.SelectedValue.ToString() + " " +
                                    " and e.created_date <= to_date('" + dtpVoch_date.Value.ToString("dd/MM/yyyy") + "', 'dd/mm/yyyy'))");
                else
                    dtcurr = cnn.GetDataTable("select e.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL,e.override_value from currency c,currency_exchange e " +
                               " where e.curr_id = c.swid and c.swid = " + lstCurrencyHeader.SelectedValue.ToString() + " " +
                     " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

                iHeaderCurrSwid = dtcurr.Rows[0]["swid"].ToString();
                dHeaderMaxRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MAX"].ToString());
                dHeaderMinRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MIN"].ToString());
                dHeaderExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
                iHeaderCurrDecimal = Convert.ToInt16(dtcurr.Rows[0]["CURR_DECIMAL"].ToString());
                dHeaderOverrideValue = Convert.ToDecimal(dtcurr.Rows[0]["override_value"].ToString());

                nmbValueDetail.DecimalPlaces = iHeaderCurrDecimal;
                nmbValueDetail_TextChanged(null, null);
                if (lstCurrIdDetail.SelectedValue == lstCurrencyHeader.SelectedValue)
                {
                    nmbMainValueDetail.Enabled = false;
                }
                else
                {
                    if (HasPrivilege("nmbMainValueDetail"))
                        nmbMainValueDetail.Enabled = true;
                }
                dgJOURNAL_DETAILS.Rows.Clear();
                //lstCurrIdDetail.DataSource = null;




            }
        }

        private void lstBeneTypeVoch_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            ClearDetailData();
            lstBeneNameVoch.DataSource = null;
            lstBeneNameVoch.Enabled = true;
            if (bLoad == true)
            {
                if (lstBeneTypeVoch.Text == "عميل")
                {
                    //fill lstBeneNameVoch with customers
                    FillHeaderCustomers();
                    lstBenDetailType.Items.Clear();
                    lstBenDetailType.Items.Add("عميل");
                    lstBenDetailType.Text = "عميل";
                  

                    lstBenDetailType.Enabled = false;
                    lstBeneDetailName.Enabled = false;
                    btnFindBeneDetail.Enabled = false;
                    lstAccNo.Enabled = false;
                    lstAccName.Enabled = false;
                    btnGetAccount.Enabled = false;

                  



                }
              
                return;
            }

            bLoad = true;

            if (lstBeneTypeVoch.Text == "عميل")
            {
                //fill lstBeneNameVoch with customers
                FillHeaderCustomers();

                lstBenDetailType.Enabled = false;
                lstBeneDetailName.Enabled = false;
                btnFindBeneDetail.Enabled = false;
                lstAccNo.Enabled = false;
                lstAccName.Enabled = false;
                btnGetAccount.Enabled = false;

                lstBenDetailType.Items.Clear();
                lstBenDetailType.Items.Add("عميل");
                lstBenDetailType.Text = "عميل";
               


            }
            else if (lstBeneTypeVoch.Text == "محصل")
            {
                FillCollector();
                btnFindBeneVoch.Enabled = false;
                lstBenDetailType.Items.Clear();
                lstBenDetailType.Items.Add("عميل");
                lstBenDetailType.Items.Add("اخر");
                lstBenDetailType.Text = "عميل";
            }
            else if (lstBeneTypeVoch.Text == "صندوق")
            {
                FillBeneCasher();
              
                
                lstBenDetailType.Enabled = false;
                lstBeneDetailName.Enabled = false;
                btnFindBeneDetail.Enabled = false;
                lstAccNo.Enabled = false;
                lstAccName.Enabled = false;
                btnGetAccount.Enabled = false;
                lstBenDetailType.Items.Clear();
                lstBenDetailType.Items.Add("صندوق");
                lstBenDetailType.Text = "صندوق";
            }
            else if (lstBeneTypeVoch.Text == "مورد")
            {
                //fill lstBeneNameVoch with Vendor
                FillVendors();

                lstBenDetailType.Enabled = false;
                lstBeneDetailName.Enabled = false;
                btnFindBeneDetail.Enabled = false;
                lstAccNo.Enabled = false;
                lstAccName.Enabled = false;
                btnGetAccount.Enabled = false;

                lstBenDetailType.Items.Clear();
                lstBenDetailType.Items.Add("مورد");
                lstBenDetailType.Text = "مورد";



            }
           else if (lstBeneTypeVoch.Text == "اخر")
            {
                lstBeneNameVoch.Enabled = false;
                lstBenDetailType.Items.Clear();
                lstBenDetailType.Items.Add("عميل");
                lstBenDetailType.Items.Add("اخر");
                lstBenDetailType.Text = "عميل";
            }

            bLoad = false ;

        }
        private void FillHeaderCustomers()
        {
           
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtcust = cnn.GetDataTable("select swid,p_name from people p where p.p_type = 'عميل' ");
            lstBeneNameVoch.DataSource = dtcust;
            lstBeneNameVoch.ValueMember = "swid";
            lstBeneNameVoch.DisplayMember = "p_name";

            lstBeneNameVoch.SelectedIndex = -1;
        }
        private void FillDetailCustomers()
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtcust = cnn.GetDataTable("select swid,p_name from people p where p.p_type = 'عميل' ");
            lstBeneDetailName.DataSource = dtcust;
            lstBeneDetailName.ValueMember = "swid";
            lstBeneDetailName.DisplayMember = "p_name";

            lstBeneDetailName.SelectedIndex = -1;
        }
        private void FillCollector()
        {
            if(lstCashers.SelectedIndex ==-1)
            {
                glb_function.MsgBox("الرجاء اختيار الصندوق");
                return;
            }
          
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCollector = cnn.GetDataTable("select coll.swid,coll.collector_name from COLLECTOR_DATA coll where coll.branch_id in ( select branch_id from casher c where c.swid="+lstCashers.SelectedValue.ToString()+")");
            lstBeneNameVoch.DataSource = dtCollector;
            lstBeneNameVoch.ValueMember = "swid";
            lstBeneNameVoch.DisplayMember = "collector_name";

            lstBeneNameVoch.SelectedIndex = -1;
        }
        private void FillVendors()
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtcust = cnn.GetDataTable("select swid,p_name from people p where p.p_type = 'مورد' ");
            lstBeneNameVoch.DataSource = dtcust;
            lstBeneNameVoch.ValueMember = "swid";
            lstBeneNameVoch.DisplayMember = "p_name";

            lstBeneNameVoch.SelectedIndex = -1;
        }

        private void FillBeneCasher()
        {

            if (lstCashers.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الصندوق");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtcust = cnn.GetDataTable("select coll.swid,coll.c_name from casher coll where coll.branch_id in ( select branch_id from casher c where c.swid="+lstCashers.SelectedValue.ToString()+ ") and coll.swid <> " + lstCashers.SelectedValue.ToString() + "");
            lstBeneNameVoch.DataSource = dtcust;
            lstBeneNameVoch.ValueMember = "swid";
            lstBeneNameVoch.DisplayMember = "c_name";

            lstBeneNameVoch.SelectedIndex = -1;
        }


        private void ClearDetailData()
        {
            //dgJOURNAL_DETAILS.Rows.Clear();
            //nmbTotal.Value = 0;

            //txtTotalAlphbet.Text = "";

            new glb_function().clearItems(gbDetail);
            ckbExchange.Checked = false;
            lstBenDetailType.Items.Clear();
            lstAccNo.DataSource = lstAccName.DataSource = null;
            lstBeneDetailName.DataSource = null;
            lstBenDetailType.Enabled = true;
            lstBeneDetailName.Enabled = true;
            btnFindBeneDetail.Enabled = true;
            lstAccNo.Enabled = true;
            lstAccName.Enabled = true;
            btnGetAccount.Enabled = true;
            btnFindBeneVoch.Enabled = true;
        }

        private void lstCasher_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCashers.SelectedValue == null )
                return;

            if (lstCashers.SelectedValue.ToString() != "System.Data.DataRowView" && lstCashers.SelectedValue.ToString() != "")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtCasherInfo = cnn.GetDataTable("select c.swid,c.c_name,c.acc_id,c.branch_id,a.acc_no "+
                     " from casher c "+
                    " join accounts a on (a.swid = c.acc_id) " +
                    " where c.swid=" + lstCashers.SelectedValue.ToString());

                txtBranchId.Text = dtCasherInfo.Rows[0]["branch_id"].ToString();
                txtCasherAccId.Text = dtCasherInfo.Rows[0]["acc_id"].ToString();
                txtCashAccNo.Text = dtCasherInfo.Rows[0]["acc_no"].ToString();


            }

        }

        private void lstBeneNameVoch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bLoad == true)
                return;
            if (lstBeneNameVoch.SelectedValue == null)
                return;

            if (lstBeneNameVoch.SelectedValue.ToString() != "System.Data.DataRowView" && lstBeneNameVoch.SelectedValue.ToString() != "")
            {
                if (lstBeneTypeVoch.Text.Trim() == "عميل" || lstBeneTypeVoch.Text.Trim() == "مورد" || lstBeneTypeVoch.Text.Trim() == "صندوق")
                {
                    dgJOURNAL_DETAILS.Rows.Clear();
                    GeneralList newRow = new GeneralList();
                    newRow.id = lstBeneNameVoch.SelectedValue.ToString();
                    newRow.name = lstBeneNameVoch.Text;
                    List<GeneralList> lstDatasource = new List<GeneralList>();
                    lstDatasource.Add(newRow);
                    lstBeneDetailName.DataSource = lstDatasource;
                    lstBeneDetailName.ValueMember = "id";
                    lstBeneDetailName.DisplayMember = "name";

                    ConnectionToDB cnn = new ConnectionToDB();
                    DataTable dtPeople = new DataTable();
                    if (lstBeneTypeVoch.Text.Trim() == "عميل" || lstBeneTypeVoch.Text.Trim() == "مورد")
                    {

                        dtPeople = cnn.GetDataTable("select p.acc_id,a.acc_no,a.acc_name " +
                            " from people p " +
                           "  join accounts a on (p.acc_id = a.swid) " +
                           "  and p.swid = " + lstBeneNameVoch.SelectedValue.ToString());
                    }
                    else if (lstBeneTypeVoch.Text.Trim() == "صندوق")
                    {

                        dtPeople = cnn.GetDataTable("select c.acc_id,a.acc_no,a.acc_name " +
                            " from casher c " +
                           "  join accounts a on (c.acc_id = a.swid) " +
                           "  and c.swid = " + lstBeneNameVoch.SelectedValue.ToString());
                    }
                    lstAccNo.DataSource = null;
                    lstAccName.DataSource = null;
                    strDataFromDataSource = true;
                    GeneralList glAccNo = new GeneralList();
                    glAccNo.id = dtPeople.Rows[0]["acc_id"].ToString();
                    glAccNo.name = dtPeople.Rows[0]["acc_no"].ToString();
                    List<GeneralList> lstAccNoDS = new List<GeneralList>();
                    
                    lstAccNoDS.Add(glAccNo);
                    lstAccNo.DataSource = lstAccNoDS;
                    lstAccNo.ValueMember = "id";
                    lstAccNo.DisplayMember = "name";


                    GeneralList glAccName = new GeneralList();
                    glAccName.id = dtPeople.Rows[0]["acc_id"].ToString();
                    glAccName.name = dtPeople.Rows[0]["acc_name"].ToString();
                    List<GeneralList> lstAccNameDS = new List<GeneralList>();
                    lstAccNameDS.Add(glAccName);
                    lstAccName.DataSource = lstAccNameDS;
                    lstAccName.ValueMember = "id";
                    lstAccName.DisplayMember = "name";
                    strDataFromDataSource = false ;
                    lstAccNo_SelectedIndexChanged(lstAccNo,null);










                }
                else if (lstBeneTypeVoch.Text.Trim() == "محصل")
                    if (txtForceCollectorBook.Text.Trim() == "نعم")
                    {
                        dgJOURNAL_DETAILS.Rows.Clear();
                    }
            }


               
        }

        private void btnFindBeneVoch_Click(object sender, EventArgs e)
        {
            if (lstBeneTypeVoch.Text.Trim() == "عميل")
            {
                Sales.frmFindCustomer frm = new Sales.frmFindCustomer();

                frm.ShowDialog();

                if (frm.strCustomerID.Trim() != "")
                {
                    lstBeneNameVoch.SelectedValue = frm.strCustomerID;
                }
            }
            else if (lstBeneTypeVoch.Text.Trim() == "مورد")
            {
                Purchases.frmFindVendor frm = new Purchases.frmFindVendor();

                frm.ShowDialog();

                if (frm.strVendorID.Trim() != "")
                {
                    lstBeneNameVoch.SelectedValue = frm.strVendorID;

                }
            }
            else if (lstBeneTypeVoch.Text.Trim() == "اخر")
            {
                File.frmContacts frm = new File.frmContacts();
                frm.ShowDialog();
                if(frm.txtSWID.Text.Trim()!="")
                {
                    //frm.txtSWID.Text;
                    //frm.txtADB_NAME
                    GeneralList newRow = new GeneralList();
                    newRow.id = frm.txtSWID.Text.Trim();
                    newRow.name = frm.txtADB_NAME.Text.Trim();
                    List<GeneralList> lstContact = new List<GeneralList>();
                    lstContact.Add(newRow);

                    lstBeneNameVoch.DataSource = lstContact;
                    lstBeneNameVoch.ValueMember = "id";
                    lstBeneNameVoch.DisplayMember = "name";

                }
               
            }

            }

        class GeneralList
        {
            public string id { get; set; }  
            public string name { get; set; }

        }

        private void ckbExchange_CheckStateChanged(object sender, EventArgs e)
        {
            if(ckbExchange.Checked==true)
            {
                lstAccName.Enabled = false;
                lstAccNo.Enabled = false;
                lstAccNo.SelectedValue = txtCasherAccId.Text.Trim();
                
                btnGetAccount.Enabled = false;
                lstBenDetailType.Text = "صندوق";

                GeneralList newRow = new GeneralList();
                newRow.id = lstCashers.SelectedValue.ToString();
                newRow.name = lstCashers.Text.Trim();
                List<GeneralList> lstContact = new List<GeneralList>();
                lstContact.Add(newRow);
                btnFindBeneDetail.Enabled = false;
                lstBeneDetailName.DataSource = lstContact;
                lstBeneDetailName.ValueMember = "id";
                lstBeneDetailName.DisplayMember = "name";
                lstBeneDetailName.Enabled = false;
                txtRefNoDetail.Enabled = false;


                lstAccNo.DataSource = null;
                lstAccName.DataSource = null;
                strDataFromDataSource = true;
                GeneralList glAccNo = new GeneralList();
                glAccNo.id = txtCasherAccId.Text; ;
                glAccNo.name = lstCashers.Text; 
                List<GeneralList> lstAccNoDS = new List<GeneralList>();
                lstAccNoDS.Add(glAccNo);
                lstAccNo.DataSource = lstAccNoDS;
                lstAccNo.ValueMember = "id";
                lstAccNo.DisplayMember = "name";


                GeneralList glAccName = new GeneralList();
                glAccName.id = txtCasherAccId.Text;
                glAccName.name = lstCashers.Text;
                List<GeneralList> lstAccNameDS = new List<GeneralList>();
                lstAccNameDS.Add(glAccName);
                lstAccName.DataSource = lstAccNameDS;
                lstAccName.ValueMember = "id";
                lstAccName.DisplayMember = "name";
                strDataFromDataSource = false ;

                lstAccNo.SelectedIndex = 0;





                ConnectionToDB conn = new ConnectionToDB();
                DataTable MyDataTable;

                MyDataTable = conn.GetDataTable("select swid,curr_name from CURRENCY t where t.swid <> "+lstCurrencyHeader.SelectedValue.ToString()+"  order by swid");

                if (MyDataTable != null)
                {

                    lstCurrIdDetail.DataSource = MyDataTable;


                    lstCurrIdDetail.DisplayMember = "curr_name";
                    lstCurrIdDetail.ValueMember = "SWID";


                  
                }

            }
           
        }

        private void lstBenDetailType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstBenDetailType.SelectedValue == null || bLoad == true)
                return;

            if (lstBenDetailType.SelectedValue.ToString() != "System.Data.DataRowView" && lstBenDetailType.SelectedValue.ToString() != "")
            {

                if(lstBeneTypeVoch.Text =="محصل" || lstBeneTypeVoch.Text == "اخر")
                {
                    if(lstBenDetailType.Text =="عميل")
                    {
                        FillDetailCustomers();
                        lstAccNo.DataSource = null;
                        lstAccName.DataSource = null;

                    }
                    else if(lstBenDetailType.Text =="اخر")
                    {
                        lstBeneDetailName.Enabled = true;
                        btnFindBeneDetail.Enabled = true;

                        GetAcc();

                    }
                }

            }
        }
        bool strDataFromDataSource = false;
        private void GetAcc()
        {

            strDataFromDataSource = true;
            ConnectionToDB cnn = new ConnectionToDB();
           DataTable dtAccData = new DataTable();

          
            string sql = "select  a.swid,a.acc_no,a.acc_name,a.acc_type,a.acc_subject,a.acc_nature " +
                       " from accounts a " +
                       " left join acc_curr c on (a.swid = c.acc_id) " +
                       " left join acc_branch b on (a.swid = b.acc_id) " +
                       " where a.stat = N'فعال' and acc_class = N'فرعي' " +
                       "  and (system_acc_type is null or system_acc_type='') " +
                       " and a.swid not in (select upa.acc_id from USER_PREVENTED_ACC upa where user_id = " + glb_function.glb_strUserId + ") " +
                        " and a.acc_type <> 'صناديق' ";
            dtAccData = cnn.GetDataTable(sql);
            lstAccNo.DataSource = dtAccData;
            lstAccNo.ValueMember = "swid";
            lstAccNo.DisplayMember = "acc_no";

            lstAccName.DataSource = dtAccData;
            lstAccName.ValueMember = "swid";
            lstAccName.DisplayMember = "acc_name";

            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
            strDataFromDataSource = false ;


        }
        private void lstBeneDetailName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstBeneDetailName.SelectedValue == null || bLoad == true || lstBeneDetailName.Enabled == false)
                return;

            if (lstBeneDetailName.SelectedValue.ToString() != "System.Data.DataRowView" && lstBeneDetailName.SelectedValue.ToString() != "")
            {
                if (lstBeneTypeVoch.Text.Trim() == "عميل" || lstBeneTypeVoch.Text.Trim() == "مورد")
                {
                    ConnectionToDB cnn = new ConnectionToDB();
                    
                    DataTable dtPeople = cnn.GetDataTable("select p.acc_id,a.acc_no,a.acc_name " +
                        " from people p " +
                       "  join accounts a on (p.acc_id = a.swid) " +
                       "  and p.swid = " + lstBeneDetailName.SelectedValue.ToString());

                    lstAccNo.DataSource = null;
                    lstAccName.DataSource = null;
                    GeneralList glAccNo = new GeneralList();
                    glAccNo.id = dtPeople.Rows[0]["acc_id"].ToString();
                    glAccNo.name = dtPeople.Rows[0]["acc_no"].ToString();
                    List<GeneralList> lstAccNoDS = new List<GeneralList>();
                    lstAccNoDS.Add(glAccNo);
                    lstAccNo.DataSource = lstAccNoDS;
                    lstAccNo.ValueMember = "id";
                    lstAccNo.DisplayMember = "name";


                }
            }
        }

        private void txtBranchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTemplet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFindBeneDetail_Click(object sender, EventArgs e)
        {
            if (lstBenDetailType.Text == "عميل")
            {
                Sales.frmFindCustomer frm = new Sales.frmFindCustomer();

                frm.ShowDialog();

                if (frm.strCustomerID.Trim() != "")
                {
                    lstBeneDetailName.SelectedValue = frm.strCustomerID;
                    lstAccNo.DataSource = null;
                    lstAccName.DataSource = null;
                }
            }
            else if (lstBenDetailType.Text.Trim() == "اخر")
            {
                File.frmContacts frm = new File.frmContacts();
                frm.ShowDialog();
                if (frm.txtSWID.Text.Trim() != "")
                {
                    //frm.txtSWID.Text;
                    //frm.txtADB_NAME
                    GeneralList newRow = new GeneralList();
                    newRow.id = frm.txtSWID.Text.Trim();
                    newRow.name = frm.txtADB_NAME.Text.Trim();
                    List<GeneralList> lstContact = new List<GeneralList>();
                    lstContact.Add(newRow);

                    lstBeneDetailName.DataSource = lstContact;
                    lstBeneDetailName.ValueMember = "id";
                    lstBeneDetailName.DisplayMember = "name";

                }

            }
        }

        private void txtRefNoDetail_Leave(object sender, EventArgs e)
        {

            if (txtRefNoDetail.Text.Trim() == "")
                return;

            if(lstBeneTypeVoch.Text =="محصل" && txtForceCollectorBook.Text =="نعم")
            {
                //   1.             select swid from MANUAL_BOOK mb
                //where mb.swid in (select MANUAL_BOOK_ID from RECEIVING_BOOKS rb
                //where rb.stat = 'مسلم'
                //and rb.receiv_id = 1)
                //and decode(mb.BUILT_WITH_NO,1,substr(txt.test, length(mb.book_no)),txt.test) between mb.from_no and mb.to_no)
                //اذا مش موجود خطأ
                //واذا موجود يتم فحص التالي

                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtCollectedData = cnn.GetDataTable("  select swid from MANUAL_BOOK mb "+
              "  where mb.swid in (select MANUAL_BOOK_ID from RECEIVING_BOOKS rb "+
              "      where rb.stat = 'مسلم' "+
              "      and rb.receiv_id = 1) " +
               " and decode(mb.BUILT_WITH_NO,1,substr(" + txtRefNoDetail.Text.Trim() + ", length(mb.book_no))," + txtRefNoDetail.Text.Trim()+") between mb.from_no and mb.to_no");
              if(dtCollectedData is null || dtCollectedData.Rows.Count<=0)
                {
                    glb_function.MsgBox("الرقم غير موجود في دفاتر المحصل");
                    txtRefNoDetail.Focus();
                    return;
                }
                txtMANUAL_BOOK_swid.Text = dtCollectedData.Rows[0]["swid"].ToString();




                //     2.           select h.swid from cash_voch_he h
                //join CASH_VOCH_DE  d on(h.swid= d.header_id)
                //where REFERENCE_NO= text.text
                //and h.stat <> 'ملغي' and d.stat <> 'ملغي'
                //اذا موجود خطا

                dtCollectedData.Clear();
                dtCollectedData = cnn.GetDataTable("select h.swid from cash_voch_he h "+
               " join CASH_VOCH_DE  d on(h.swid = d.header_id) "+
              "  where REFERENCE_NO = "+txtRefNoDetail.Text.Trim()+" "+
               " and h.stat <> 'ملغي' and d.stat <> 'ملغي'");

                if(dtCollectedData.Rows.Count >0)
                {
                    glb_function.MsgBox("الرقم موجود في السندات الملغية");
                    txtMANUAL_BOOK_swid.Text = "";
                    txtRefNoDetail.Focus();
                    return;
                }



                //3.                select* from CANCELED_DOCUMENTS cd
                //where cd.reference_no = text.text

                //اذا موجود خطا

                dtCollectedData.Clear();
                dtCollectedData = cnn.GetDataTable("select* from CANCELED_DOCUMENTS cd " +
                    "where cd.reference_no = "+txtRefNoDetail.Text.Trim()+"");

                if(dtCollectedData.Rows.Count >0)
                {
                    glb_function.MsgBox("الرقم موجود في السندات الورقية الملغية");
                    txtMANUAL_BOOK_swid.Text = "";
                    txtRefNoDetail.Focus();
                    return;
                }



            }
        }

        private void btnGetAccount_Click(object sender, EventArgs e)
        {
            if(lstBenDetailType.Text =="اخر")
            {
                Accounts.frmFindAccount frm = new Accounts.frmFindAccount();
                frm.strSelect  = "select  a.swid,a.acc_no,a.acc_name,a.acc_type,a.acc_subject,a.acc_nature " +
                      " from accounts a " +
                      " left join acc_curr c on (a.swid = c.acc_id) " +
                      " left join acc_branch b on (a.swid = b.acc_id) " +
                      " where a.stat = N'فعال' and acc_class = N'فرعي' " +
                      "  and (system_acc_type is null or system_acc_type='') " +
                      " and a.swid not in (select upa.acc_id from USER_PREVENTED_ACC upa where user_id = " + glb_function.glb_strUserId + ") " +
                       " and a.acc_type <> 'صناديق' ";
               
                frm.strWhere = "";

                frm.ShowDialog();
                if (frm.strAccid != "")
                {
                    lstAccName.SelectedValue = Convert.ToInt16(frm.strAccid);
                }
                else
                {
                    lstAccNo.Text = "";
                    lstAccName.Text = "";
                    lstAccNo.SelectedIndex = -1;
                    lstAccName.SelectedIndex = -1;
                }
            }
        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null || strDataFromDataSource == true)
            {
                if (lstParent.SelectedValue == null)
                  lblBalanceType.Visible = false ;

                return;
            }
                



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;
                ConnectionToDB conn = new ConnectionToDB();
                DataTable MyDataTable;

                MyDataTable = conn.GetDataTable("select swid,curr_name from CURRENCY t where swid in (select curr_id from acc_curr ac where ac.acc_id="+lstAccNo.SelectedValue.ToString()+" )  order by swid");
               // MyDataTable = conn.GetDataTable("select swid,curr_name from CURRENCY t   order by swid");

                if (MyDataTable != null)
                {

                    lstCurrIdDetail.DataSource = MyDataTable;


                    lstCurrIdDetail.DisplayMember = "curr_name";
                    lstCurrIdDetail.ValueMember = "SWID";

                    lstCurrIdDetail.SelectedIndex = -1;
                    lstCurrIdDetail.SelectedIndex = 0;



                    //  
                }




                

                decimal dBalance = glb_function.GetAccBalance((lstCurrIdDetail.SelectedIndex == -1 ? "0" : lstCurrIdDetail.SelectedValue.ToString()), (lstAccNo.SelectedIndex == -1 ? "0" : lstAccNo.SelectedValue.ToString()));

                lblBalanceType.Visible = true;
                if (dBalance >= 0)
                    lblBalanceType.Text = "مدين";
                else
                {
                    lblBalanceType.Text = "دائن";
                    dBalance = dBalance * -1;
                }

                nmbAccBalance.Value = dBalance;


                txtCostCenterId.Text = "";
                txtCostCenterName.Text = "";



            }
            else
                lblBalanceType.Visible = false;
        }

        private void lstCurrIdDetail_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (lstCurrIdDetail.SelectedValue == null)
            {
                bChangeValueAuto = true;
                nmbValueDetail.Value = 0;
                nmbMainValueDetail.Value = 0;
                nmbValueDetail.Enabled = false;
                bChangeValueAuto = false ;
                return;
            }
              

            if (lstCurrIdDetail.SelectedValue.ToString() != "System.Data.DataRowView" && lstCurrIdDetail.SelectedValue.ToString() != "")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtcurr = new DataTable(); ;

                dtcurr = cnn.GetDataTable("select e.swid , c.curr_name,e.curr_price,CURR_SMPL,e.CURR_MIN,e.CURR_MAX,c.CURR_DECIMAL,e.override_value from currency c,currency_exchange e " +
                           " where e.curr_id = c.swid and c.swid = " + lstCurrIdDetail.SelectedValue.ToString() + " " +
                 " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");

                iDetailCurrSwid = dtcurr.Rows[0]["swid"].ToString();
                dDetailMaxRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MAX"].ToString());
                dDetailMinRate = Convert.ToDecimal(dtcurr.Rows[0]["CURR_MIN"].ToString());
                dDetailExchangeRate = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
                iDetailCurrDecimal = Convert.ToInt16(dtcurr.Rows[0]["CURR_DECIMAL"].ToString());
                dDetailOverrideValue = Convert.ToDecimal(dtcurr.Rows[0]["override_value"].ToString());


                nmbMainValueDetail.DecimalPlaces = iDetailCurrDecimal;
                if (lstCurrIdDetail.SelectedValue == lstCurrencyHeader.SelectedValue)
                {
                    nmbMainValueDetail.Enabled = false;
                }
                else
                {
                    if (HasPrivilege("nmbMainValueDetail"))
                        nmbMainValueDetail.Enabled = true;
                }

                nmbValueDetail.Enabled = true ;

                if (nmbValueDetail.Value > 0)
                    nmbValueDetail_TextChanged(null, null);


            }
            else
            {
                bChangeValueAuto = true;
                nmbValueDetail.Value = 0;
                nmbMainValueDetail.Value = 0;
                nmbValueDetail.Enabled = false;
                bChangeValueAuto = false;
            }

        }
        bool bChangeValueAuto = false;
        private void nmbValueDetail_TextChanged(object sender, EventArgs e)
        {

            if (bChangeValueAuto)
                return;

            bChangeValueAuto = true;

            if(nmbValueDetail.Value <=0 || lstCurrencyHeader.SelectedIndex ==-1 || lstCurrIdDetail.SelectedIndex==-1)
            {
                nmbMainValueDetail.Value = 0;
                nmbCURR_PRICE.Value = 0;

                bChangeValueAuto = false ;
                return;
                
            }

            

            if (lstCurrencyHeader.SelectedValue ==lstCurrIdDetail.SelectedValue)
            {
                nmbMainValueDetail.Value = nmbValueDetail.Value;
                nmbCURR_PRICE.Value = Math.Round((nmbValueDetail.Value * dHeaderExchangeRate), glb_function.glbMainDecimalPoint) / nmbMainValueDetail.Value;
                bChangeValueAuto = false;
                return;

            }
            

            if ( Convert.ToInt16( lstCurrIdDetail.SelectedValue )== glb_function.glb_MainCurrencyId)
            {
                if (nmbValueDetail.Value != 0)
                {
                    nmbMainValueDetail.Value = Math.Round(dHeaderExchangeRate / dDetailExchangeRate * nmbValueDetail.Value, iDetailCurrDecimal);
                    nmbCURR_PRICE.Value = 1;
                }
                   
            }
               
            else 
            {
                if(nmbValueDetail.Value!=0)
                {
                    nmbMainValueDetail.Value = Math.Round(dHeaderExchangeRate / dDetailExchangeRate * nmbValueDetail.Value, iDetailCurrDecimal);
                    if(nmbMainValueDetail.Value!=0)
                    nmbCURR_PRICE.Value = Math.Round((nmbValueDetail.Value * dHeaderExchangeRate), glb_function.glbMainDecimalPoint) / nmbMainValueDetail.Value;
                }

               
            }


            bChangeValueAuto = false;

        }

        private void nmbMainValueDetail_TextChanged(object sender, EventArgs e)
        {
            if (bChangeValueAuto)
                return;

            bChangeValueAuto = true;

            if (nmbMainValueDetail .Value <= 0 || lstCurrencyHeader.SelectedIndex == -1 || lstCurrIdDetail.SelectedIndex == -1)
            {
       
                nmbCURR_PRICE.Value = 0;
                nmbValueDetail.Value = 0;

                bChangeValueAuto = false;
                return;
            }

            if (nmbValueDetail.Value >0)
            {
                nmbCURR_PRICE.Value = Math.Round((nmbValueDetail.Value * dHeaderExchangeRate), glb_function.glbMainDecimalPoint) / nmbMainValueDetail.Value;
            }
            else
            {
                if (lstCurrencyHeader.SelectedValue == lstCurrIdDetail.SelectedValue)
                {
                    nmbValueDetail.Value= nmbMainValueDetail.Value ;
                    nmbCURR_PRICE.Value = Math.Round((nmbValueDetail.Value * dHeaderExchangeRate), glb_function.glbMainDecimalPoint) / nmbMainValueDetail.Value;

                    bChangeValueAuto = false;
                    return;

                }
                else
                {
                    nmbValueDetail.Value = Math.Round(dDetailExchangeRate / dHeaderExchangeRate * nmbMainValueDetail.Value, iHeaderCurrDecimal);
                    if (nmbMainValueDetail.Value != 0)
                        nmbCURR_PRICE.Value = Math.Round((nmbValueDetail.Value * dHeaderExchangeRate), glb_function.glbMainDecimalPoint) / nmbMainValueDetail.Value;

                }

            }



            bChangeValueAuto = false;
        }

        private void btnGetCostCenter_Click(object sender, EventArgs e)
        {
            if(lstAccNo.SelectedIndex ==-1)
            {
                glb_function.MsgBox("الرجاء تحديد الحساب اولا");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtAccSub = cnn.GetDataTable("select  a.acc_subject from accounts a where a.swid="+lstAccNo.SelectedValue.ToString());

            if (dtAccSub.Rows[0]["acc_subject"].ToString() == "ارباح وخسائر")
            {
                frmCostCenterBranch frm = new frmCostCenterBranch();


                frm.ShowDialog();
                txtCostCenterId.Text = frm.strCostCenterSwid;
                txtCostCenterName.Text = frm.strCostCenterName;
            }
            else
            {
                glb_function.MsgBox("الرجاء تحديد حساب ارباح وخسائر");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckDetailsEntries())
                return;

            if (iUpdateRow == -1)
            {
                dgJOURNAL_DETAILS.Rows.Add();
                iUpdateRow = dgJOURNAL_DETAILS.Rows.Count - 1;
            }



            dgJOURNAL_DETAILS[clmSwidDetail.Index, iUpdateRow].Value = txtDetailsSWID.Text;
            dgJOURNAL_DETAILS[clmVoucherValue.Index, iUpdateRow].Value = nmbValueDetail.Value.ToString();
            dgJOURNAL_DETAILS[clmCurrIdDetail.Index, iUpdateRow].Value = lstCurrIdDetail.SelectedValue.ToString();
            dgJOURNAL_DETAILS[clmDetailCurrencyName.Index, iUpdateRow].Value = lstCurrIdDetail.Text;
            dgJOURNAL_DETAILS[clmAccValue.Index, iUpdateRow].Value = nmbMainValueDetail.Value.ToString();
            dgJOURNAL_DETAILS[clmAccIdDetail.Index, iUpdateRow].Value = lstAccNo.SelectedValue.ToString();
            dgJOURNAL_DETAILS[clmAccName.Index, iUpdateRow].Value = lstAccName.Text;
            dgJOURNAL_DETAILS[clmBeneId.Index, iUpdateRow].Value = lstBeneDetailName.SelectedValue.ToString();
            dgJOURNAL_DETAILS[clmBeneDetailName.Index, iUpdateRow].Value = lstBeneDetailName.Text;
            dgJOURNAL_DETAILS[clmBeneDetailType.Index, iUpdateRow].Value = lstBenDetailType.Text;
            dgJOURNAL_DETAILS[clmDetailNote.Index, iUpdateRow].Value = txtNoteDetail.Text.Trim();
            dgJOURNAL_DETAILS[clmRefNoDeatil.Index, iUpdateRow].Value = txtRefNoDetail.Text;
            dgJOURNAL_DETAILS[clmRefnoId.Index, iUpdateRow].Value = txtMANUAL_BOOK_swid.Text;
            dgJOURNAL_DETAILS[clmCostIdDetail.Index, iUpdateRow].Value = txtCostCenterId.Text;
            dgJOURNAL_DETAILS[clmCostName.Index, iUpdateRow].Value = txtCostCenterName.Text;
            dgJOURNAL_DETAILS[clmCurrencyRate.Index, iUpdateRow].Value = dDetailExchangeRate.ToString();
            dgJOURNAL_DETAILS[clmCurrentRate.Index, iUpdateRow].Value = nmbCURR_PRICE.Value.ToString();
            dgJOURNAL_DETAILS[clmCURRENCY_EXCHANGE_ID.Index, iUpdateRow].Value = iDetailCurrSwid;
            dgJOURNAL_DETAILS[clmDetailStat.Index, iUpdateRow].Value = "فعال";
            if (ckbExchange.Checked )
            dgJOURNAL_DETAILS[clmDetailRowType.Index, iUpdateRow].Value = "مصارفة";
            else
                dgJOURNAL_DETAILS[clmDetailRowType.Index, iUpdateRow].Value = "جسم";



            GetSum();
           
           
           ClearDetailData();


            iUpdateRow = -1;

        }
        private void GetSum()
        {
            decimal dTotal = 0;
            int iRefNocount = 0;
            for (int i = 0; i < dgJOURNAL_DETAILS.Rows.Count; i++)
            {
                if(dgJOURNAL_DETAILS[clmDetailRowType.Index,i].Value .ToString()!="مصارفة" &&   dgJOURNAL_DETAILS[clmDetailStat.Index, i].Value.ToString() == "فعال")
                 dTotal += Convert.ToDecimal( dgJOURNAL_DETAILS[clmVoucherValue.Index, i].Value.ToString());


                if (dgJOURNAL_DETAILS[clmRefNoDeatil.Index, i].Value.ToString()!="")
                    iRefNocount += 1;

            }
            if (dTotal > 0)
            {
                nmbTotal.Value = Math.Round(dTotal, iHeaderCurrDecimal);
                txtTotalAlphbet.Text = new ConvertNumbersToArabicAlphabet(nmbTotal.Value.ToString()).GetNumberAr();
            }
            else
            {
                nmbTotal.Value = 0;
                txtTotalAlphbet.Text = "";
            }


            nmbCount.Value = iRefNocount;


        }
        private bool CheckDetailsEntries()
        {


            if (nmbValueDetail.Value == 0 || nmbMainValueDetail.Value == 0)
            {
                glb_function.MsgBox("الرجاء ادخال مبلغ السند ومبلغ الحساب.");
                // glb_function.MsgBox("العملية غير محدده ان كانت مدين او دائن؟" + "\n" + "قد يكون السبب ان للمستخدم الصلاحية لعمل قيد بسيط فقط");
                return false;
            }

            int iError = 0;






            if (lstAccNo.SelectedIndex == -1)
            {

                errCheckDetails.SetError(lstAccNo, "يجب ادخال رقم الحساب ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstAccNo, "");
            }

            if (lstAccName.SelectedIndex == -1)
            {

                errCheckDetails.SetError(lstAccName, "يجب ادخال اسم الحساب ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstAccName, "");
            }


           


          
            if (lstCurrIdDetail.SelectedIndex == -1)
            {
                errCheckDetails.SetError(lstCurrIdDetail, "يجب ادخال عملة الحساب ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstCurrIdDetail, "");
            }

            if(lstBeneDetailName.Text.Trim()=="")
            {
                errCheckDetails.SetError(lstBeneDetailName, "يجب ادخال اسم المستفيد ");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(lstBeneDetailName, "");
            }


            //2**********************************************
            //فحص هل اسم الحساب لديه نفس رقم تعريف رقم الحساب
            //فقط للتاكيد
            if (lstAccName.SelectedIndex != -1 && lstAccNo.SelectedIndex != -1)
                if (lstAccNo.SelectedValue.ToString().Trim() != lstAccName.SelectedValue.ToString().Trim())
                {
                    glb_function.MsgBox("الرجاء التاكد ان رقم الحساب يطابقة اسم الحساب");
                    return false;
                }
            //2 End****************************************************

            //1*********************************************
            //
            //التاكد ان الحساب مصروف او ايراد ليتم اجبار المستخدم على ادخال مركز التكلفة
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtAccSub = cnn.GetDataTable("select  a.acc_subject from accounts a where a.swid=" + lstAccNo.SelectedValue.ToString());
            errCheckDetails.SetError(txtCostCenterName, "");
            if (txtCostCenterId.Text.Trim() == "")
            {
                if (dtAccSub.Rows[0]["acc_subject"].ToString() == "ارباح وخسائر")
                {

                    errCheckDetails.SetError(txtCostCenterName, "الرجاء تحديد مركز التكلفة");
                    iError = 1;
                }
                else
                {
                    errCheckDetails.SetError(txtCostCenterName, "");
                }
            }


            //اذا كان بسيط او مركب
            #region DocType  
            if(lstTempVocherType.Text .Trim()=="بسيط")
            {
                for (int i = 0; i < dgJOURNAL_DETAILS.Rows.Count; i++)
                {
                    if(dgJOURNAL_DETAILS[clmDetailRowType.Index,i].Value.ToString()=="جسم")
                    {
                        glb_function.MsgBox("لا يمكن عمل قيد مركب لهذا النموذج");
                        return false;
                    }
                }
            }
            #endregion

            #region CheckRefeNoDetail
            //فحص المستند الورقي
            if (ckbExchange.Enabled == false) //في حالة المصارفة لايتم فحص المستند الورقي
            {
                if (lstBeneTypeVoch.Text.Trim() == "محصل" || txtForceCollectorBook.Text.Trim() == "نعم")
                {
                    if (txtRefNoDetail.Text.Trim() == "")
                    {
                        errCheckDetails.SetError(txtRefNoDetail, "يجب ادخال رقم المستند الورقي ");
                        iError = 1;
                    }
                    else
                    {
                        errCheckDetails.SetError(txtRefNoDetail, "");
                        //check if RefeNoDetail entered before in grid
                        for (int i = 0; i < dgJOURNAL_DETAILS.Rows.Count; i++)
                        {
                            if (txtRefNoDetail.Text.Trim() == dgJOURNAL_DETAILS[clmRefNoDeatil.Index, i].Value.ToString())
                            {
                                glb_function.MsgBox("رقم المستند الورقي مدخل من قبل");
                                return false;
                            }

                        }
                    }
                }
            }
            #endregion





            #region CheckNaturaAcc
            //check account Natur

            if (btnSave.Enabled == true)
            {
                decimal dBalance = 0;
                if (lblBalanceType.Text == "دائن")
                    dBalance = nmbAccBalance.Value * -1;
                else
                    dBalance = nmbAccBalance.Value;

                //if (nmbDept.Value > 0)
                //    dBalance = dBalance + nmbDept.Value;
                //else
                //المبلغ الحساب يكون دائن عند سند القبض 
                    dBalance = dBalance - nmbMainValueDetail.Value;
                 dtAccSub = cnn.GetDataTable("select  a.acc_nature from accounts a where a.swid=" + lstAccNo.SelectedValue.ToString());
                bool bExceededNaturalAcc = false;
                if (dtAccSub.Rows[0]["acc_nature"].ToString() == "مدين" && dBalance < 0)
                    bExceededNaturalAcc = true;
                else if (dtAccSub.Rows[0]["acc_nature"].ToString() == "دائن" && dBalance > 0)
                    bExceededNaturalAcc = true;
                else
                    bExceededNaturalAcc = false;


                if (bExceededNaturalAcc)
                {
                    if (txtAllowExceedNaturalAcc.Text == "نعم")
                    {
                        if (glb_function.MsgBox("تجاوز طبيعة الحساب" + "\n" + "هل تريد الاستمرار؟", "", true) == false)
                            return false;
                    }
                    else
                    {
                        glb_function.MsgBox("تجاوز طبيعة الحساب");
                        return false;
                    }
                }
            }

            #endregion



          

            if (iError == 1)
                return false;

            #region CkeckExceedRate
            // فحص تجاوز في سعر صرف التقييم 


            bool bIsRateExceeded = false;

            if (nmbCURR_PRICE.Value > dDetailMaxRate || nmbCURR_PRICE.Value < dDetailMinRate)
                bIsRateExceeded = true;
            
            if(bIsRateExceeded )
            {
                if (ckbExchange.Checked) //اذا كانت العملية مصارفة
                {
                    if (txtExchangeRateExceeded.Text.Trim() == "نعم")
                    {
                        if (glb_function.MsgBox("سعر الصرف متجاوز عن الحد المسموح" + "\n" + "هل تريد المتابعة", "", true) == false)
                            return false;
                    }
                    else
                    {
                        glb_function.MsgBox("سعر الصرف متجاوز عن الحد المسموح");
                        return false;
                    }
                      

                }
                else // اذا كانت الحركة جسم
                {
                    if (txtExchangeRateExceeded.Text.Trim() == "نعم")
                    {
                        if (glb_function.MsgBox("سعر الصرف متجاوز عن الحد المسموح" + "\n" + "هل تريد المتابعة", "", true) == false)
                            return false;
                    }
                }
            }
           
            #endregion


            return true;


        }

        private void dgJOURNAL_DETAILS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            



            if (e.ColumnIndex == clmDelete.Index)
            {


                if (iUpdateRow != -1)
                {
                    glb_function.MsgBox("لايمكن الحذف العملية قيد التعديل");
                    return;
                }

                if (glb_function.MsgBox("هل انت متاكد من عملية حذف؟", "", true) == false)
                {
                    return;
                }

                //*********************
                //****************

                if (dgJOURNAL_DETAILS[0, e.RowIndex].Value.ToString() == "")
                {
                    dgJOURNAL_DETAILS.Rows.Remove(dgJOURNAL_DETAILS.Rows[e.RowIndex]);

                }
                else
                {
                    if (dgJOURNAL_DETAILS[13, e.RowIndex].Value.ToString() == "فعال")
                    {
                        dgJOURNAL_DETAILS[13, e.RowIndex].Value = "ملغي";
                        for (int y = 0; y < dgJOURNAL_DETAILS.Rows[e.RowIndex].Cells.Count - 1; y++)
                        {
                            dgJOURNAL_DETAILS.Rows[e.RowIndex].Cells[y].Style.BackColor = System.Drawing.Color.MediumVioletRed;
                        }
                    }


                }

                GetSum();


            }
        }

        private void btnClearDetails_Click(object sender, EventArgs e)
        {
            ClearDetailData();


            iUpdateRow = -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PrepareForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            StringBuilder sbGetXml = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(sbGetXml);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("DocumentElement".ToLower());

            xmlWriter.WriteStartElement("CASH_VOCH_HE".ToLower());

            xmlWriter.WriteElementString("SWID".ToLower(), txtSWID.Text);

            xmlWriter.WriteElementString("STAT".ToLower(),  "فعال" );

            xmlWriter.WriteElementString("CREATED_USER".ToLower(), glb_function.glb_strUserId);
            xmlWriter.WriteElementString("YEAR_N".ToLower(), dtpVoch_date.Value.ToString("yyyy"));

            xmlWriter.WriteElementString("ORDERS_ID".ToLower(), "");
            xmlWriter.WriteElementString("REPLACE_VOCH_ID".ToLower(), "");
            xmlWriter.WriteElementString("BRANCH_ID".ToLower(), txtBranchId.Text .Trim());


            xmlWriter.WriteElementString("VOCH_TYPE".ToLower(), "سند قبض نقد");
            xmlWriter.WriteElementString("CASHER_ID".ToLower(), lstCashers.SelectedValue.ToString());


            
            xmlWriter.WriteElementString("VOCH_DATE".ToLower(), dtpVoch_date.Value.ToString("dd/MM/yyyy"));
            xmlWriter.WriteElementString("VOCH_NO".ToLower(), "");
            
            xmlWriter.WriteElementString("CURR_ID".ToLower(), lstCurrencyHeader.SelectedValue.ToString());

            xmlWriter.WriteElementString("PRINT_COUNT".ToLower(), "");
            xmlWriter.WriteElementString("PRINT_COUNT_DETAILS".ToLower(), "");
            

            xmlWriter.WriteElementString("EXCHANGE_IN_DATE".ToLower(),(txtExRateDateDefaultValue.Text =="نعم"?"1":"0"));
            xmlWriter.WriteElementString("CHEQUES_ID".ToLower(), txtCheques_id.Text.Trim());
            xmlWriter.WriteElementString("COMMENT_ORDERS".ToLower(), txtNoteVoch.Text.Trim());
            xmlWriter.WriteElementString("APPENDIX_VOCH_ID".ToLower(), "");

           




            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();
            string strHeader = sbGetXml.ToString();


            //Detail Data
            DataTable dt = new DataTable();
            dt.TableName = "CASH_VOCH_DE".ToLower();
            //Add Columns name 
            dt.Columns.Add("swid".ToLower());
            dt.Columns.Add("STAT".ToLower());
            dt.Columns.Add("CREATED_USER".ToLower());
            dt.Columns.Add("ORDERS_DE_ID".ToLower());
            dt.Columns.Add("CURR_ID".ToLower());
            dt.Columns.Add("CURRENCY_EXCHANGE_ID".ToLower());
            dt.Columns.Add("CURR_PRICE_RATE".ToLower());
            dt.Columns.Add("CURR_PRICE_CALCULAT".ToLower());
            dt.Columns.Add("ACC_ID".ToLower());
            dt.Columns.Add("VOCH_CURR_VALUE".ToLower());
            //dt.Columns.Add("MAIN_VALUE".ToLower());
            dt.Columns.Add("CURR_VALUE".ToLower());
            dt.Columns.Add("DETAILS".ToLower());
            dt.Columns.Add("COST_CENTER_ID".ToLower());
            dt.Columns.Add("MANUAL_BOOK_ID".ToLower());
            dt.Columns.Add("REFERENCE_NO".ToLower());
            dt.Columns.Add("ROW_TYPE".ToLower());
            dt.Columns.Add("JOURNAL_DETAILS_ID".ToLower());
            dt.Columns.Add("BENEFICIARY_TYPE".ToLower());
            dt.Columns.Add("BENEFICIARY_ID".ToLower());
            dt.Columns.Add("BENEFICIARY_NAME".ToLower());
            dt.Columns.Add("LINK_ID".ToLower());
            dt.Columns.Add("LINK_TYPE".ToLower());

           
            for (int i = 0; i < dgJOURNAL_DETAILS.Rows.Count; i++)
            {
                dt.Rows.Add(new Object[] { dgJOURNAL_DETAILS[clmSwidDetail.Index,i].Value.ToString(),
                dgJOURNAL_DETAILS[clmDetailStat.Index,i].Value.ToString(),
                glb_function.glb_strUserId,
                "",
                dgJOURNAL_DETAILS[clmCurrIdDetail.Index,i].Value.ToString(),
                 dgJOURNAL_DETAILS[clmCURRENCY_EXCHANGE_ID.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmCurrencyRate.Index,i].Value.ToString(),
                   dgJOURNAL_DETAILS[clmCurrentRate.Index,i].Value.ToString(),
                   dgJOURNAL_DETAILS[clmAccIdDetail.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmVoucherValue.Index,i].Value.ToString(),
                 // "",
                  dgJOURNAL_DETAILS[clmAccValue.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmDetailNote.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmCostIdDetail.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmRefnoId.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmRefNoDeatil.Index,i].Value.ToString(),
                 dgJOURNAL_DETAILS[clmDetailRowType.Index,i].Value.ToString(),
                  "",
                  dgJOURNAL_DETAILS[clmBeneDetailType.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmBeneId.Index,i].Value.ToString(),
                  dgJOURNAL_DETAILS[clmBeneDetailName.Index,i].Value.ToString(),
                  "",
                  ""

                });
            }

          

            System.IO.StringWriter writer = new System.IO.StringWriter();
            dt.WriteXml(writer);
            string strDetails = writer.ToString().Replace("DocumentElement", "DocumentElement".ToLower());




        }
        private bool CheckEntries()
        {
            return true;
        }
    }
}
