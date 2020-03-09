using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;

namespace ERP
{
    public partial class frmMain : Form
    {
        DataTable dtUserForm;
       
        public frmMain()
        {
            InitializeComponent();
        }

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            try
            {
                InitialLogin();
            }
            catch (Exception ex)
            {
                glb_function.MsgBox("حدث خطأ اثناء تحميل النظام"+"\n"+ex.Message);
                Application.Exit();
            }

                
                          

            
           
           
            

        }
        private void RemoveUserToolIcons()
        {
           // var list = (from object item in pnlMid.Controls where item is Button || item is ComboBox select item as Control).ToList();

          //  list.ForEach(x => pnlMid.Controls.Remove(x));

        }
        private void InitialLogin()
        {
            ConnectionToDB myconn = new ConnectionToDB();
            DataTable MyDataTable;
            MyDataTable = myconn.GetDataTable("select Instance_name From sys.V_$INSTANCE");

            this.Text = this.Text + " @ " + MyDataTable.Rows[0][0].ToString();

            foreach (RibbonTab ribonTab in sowaidribbon.Tabs)
            {




                ribonTab.Visible = false;
              


            }
            
            //***************888

            Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
            rect.Location = new Point(0, 0);
            this.MaximizedBounds = rect;
            this.WindowState = FormWindowState.Maximized;
            Theme.ColorTable = new sowaidRibbonRendererColorTableBlack();
            //***********
            //pnlToolBar.Width = splitContainer2.Width / 3 * 2;
            //pnlToolBar.Left = splitContainer2.Width - pnlToolBar.Width;
            //pnlToolBar.Height = splitContainer2.Panel1.Height;
            //pnlToolBar.Top = 0;
            splitContainer2.SplitterWidth = 1;
            splitContainer2.SplitterDistance = sowaidribbon.Height;
           

           // pbxSowaidLogo.Height = splitContainer2.Panel1.Height + 10;
            pbxLogo.Left = 0;
            pbxLogo.Top = 27;
        

            //tmrCurrentTime.Start();
           // lblUserLable.Text = "اسم المستخدم : .....";
            //glb_function.glb_strUserName = "";
           // lblUserLable.Left = pnlRight.Width / 2 - lblUserLable.Width / 2;
            RemoveUserToolIcons();



            
             frmLogin myform = new frmLogin();

            myform.ShowDialog(this);



            //if (glb_function.glb_strUserName == "")
            //{
            //    this.Close();
            //    return;
            //}

            lblUserLable.Text = "     " + glb_function.glb_strUserName;
            // lblUserLable.Left = pbxLogout.Left + lblUserLable.Width -50;
            //lblUserLable.Top = pbxLogout.Top;


            ConnectionToDB cnn = new ConnectionToDB();
             //dtUserForm = cnn.GetDataTable("select p.swid,m.form_name,m.form_type from models_file m " +
             //      "   join privilege_file p on(m.swid = p.model_no and user_no = " + glb_function.glb_strUserId + ")" +
             //         "   union all" +
             //          "  select p.swid, m.form_name, m.form_type from models_account m" +
             //           " join privilege_account p on (m.swid = p.model_no and user_no = " + glb_function.glb_strUserId + ")" +
             //            "   union all" +
             //            " select p.swid,m.form_name,m.form_type from MODELS_CHARITIES m " +
             //      "   join PRIVILEGE_CHARITIES p on(m.swid = p.model_no and user_no = " + glb_function.glb_strUserId + ")" +
             //           "");

            dtUserForm = cnn.GetDataTable("select u.swid,m.form_name,m.form_eng_name,m.form_type from templet_header m,user_templet u " +
                                            " where m.swid = u.templet_id and u.user_id= " + glb_function.glb_strUserId);
            CreateToolIcons(this);

          
        }
       

       

        private void mnuLogout_Click(object sender, EventArgs e)

        {

           lblUserLable.Text = "";
            InitialLogin();
        }

     
       

       
      

       

       
       

      

        private void mnuExit_Click(object sender, EventArgs e)

        {
            Application.Exit();
            //glb_function.SendMessage("<log off user >" + glb_function.glb_strUserLogin, System.Net.IPAddress.Parse(glb_function.GetLocalIPAddress()));

            //  glb_SysFun.MyAppExit();
        }
        private bool IsUserHasThisForm(string strFormName,string strTab)
        {
            for (int i = 0; i < dtUserForm.Rows.Count; i++)
            {
                if (dtUserForm.Rows[i]["form_eng_name"].ToString() == strFormName && dtUserForm.Rows[i]["form_type"].ToString()==strTab )
                    return true;
            }
            return false ;
        }
        private void CreateToolIcons(Control myControl)
        {

            Ribbon rpt = new Ribbon();
            RibbonTab rr = new RibbonTab();
            //rr.Panels[0].Items[1].Tag 
          int  iCheckCount = 0;
            foreach (RibbonTab  ribonTab in sowaidribbon.Tabs  )
            {


                foreach (RibbonPanel panl in ribonTab.Panels)
                {
                    iCheckCount = 0;
                    for (int i = 0; i < panl.Items.Count; i++)
                    {
                        if (panl.Items[i].Tag == null)
                            panl.Items[i].Tag = "";
                        if (panl.Items[i].Tag.ToString() == "")
                            panl.Items[i].Visible = true;
                        else if (IsUserHasThisForm(panl.Items[i].Tag.ToString(),ribonTab.Tag.ToString() ) == true )
                            panl.Items[i].Visible = true;
                        else
                        {
                            panl.Items[i].Visible = false;
                            iCheckCount = iCheckCount + 1;
                        }

                    }
                    if (panl.Items.Count == iCheckCount)
                    {
                        panl.Visible = false;
                        ribonTab.Visible = false;
                    }
                    else
                    {
                        panl.Visible = true ;
                        ribonTab.Visible = true;
                    }

                      

            }
            }
           

        }


      
        private Button CreateButton()
        {
            Button btnNew = new Button();
            btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnNew.FlatAppearance.BorderSize = 2;
            btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;


            btnNew.Size = new System.Drawing.Size(70, 70);
            btnNew.UseVisualStyleBackColor = true;

            return btnNew;
        }


      
       

        private void GeneralClick(object sender, EventArgs e)
        {
            //Assembly.GetExecutingAssembly().CreateInstance();
            string strForm = ((Button)sender).Tag.ToString();
            Form frm = (Form)Assembly.GetExecutingAssembly().CreateInstance(strForm);
            frm.ShowDialog();
        }

      

        private void mnuAccVariables_Click(object sender, EventArgs e)
        {
            MyForm f = new MyForm();
            f = (MyForm)Application.OpenForms["frmAccVariable"];
            if (f != null)
                f.BringToFront();
            else
            {
             Accounts.   frmAccVariable f1 = new Accounts.frmAccVariable();
                f1.Show(this);
            }
            // new Account.frmAccVariable().Show(this);
        }

        private void mnuAccountTree_Click(object sender, EventArgs e)
        {

            Accounts.frmAccountTree frm = new Accounts.frmAccountTree();
            glb_function.OpenForm(this, frm, false);


            
        }

      
      

    

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxLogout_Click(object sender, EventArgs e)
        {
            mnuLogout_Click(null, null);
        }

        

      
        private void RChangePassword_Click(object sender, EventArgs e)
        {
            




           File. frmChangePassword frm = new File. frmChangePassword();
            glb_function.OpenForm(this, frm, false);


            
        }

        private void rbuser_Click(object sender, EventArgs e)
        {
            File.frmUsers frm = new File.frmUsers();
            glb_function.OpenForm(this, frm, false);
            //new frmUsers().Show(this);
        }

        private void rbLocation_Click(object sender, EventArgs e)
        {
            File.frmLocation frm = new File.frmLocation();
            glb_function.OpenForm(this, frm, false);
            //new frmLocation().Show(this);
        }

        private void rbbranch_Click(object sender, EventArgs e)
        {
            File.frmBranches frm = new File.frmBranches();
            glb_function.OpenForm(this, frm, false);
           // new frmBranches().Show(this);
        }

        private void rbcurrncy_Click(object sender, EventArgs e)
        {
            File.frmCurrency frm = new File.frmCurrency();
            glb_function.OpenForm(this, frm, false);
            //new frmCurrency().Show(this);
        }

        private void rblogout_Click(object sender, EventArgs e)
        {
            lblUserLable.Text = "";

            ConnectionToDB cnn = new ConnectionToDB();
            int icheck=cnn.TranDataToDB("update USER_LOGS set USER_LOGS.logoff_date=sysdate"+
                                " where USER_LOGS.user_id = " +glb_function.glb_strUserId +
                                " and USER_LOGS.logoff_date is null   ");
            cnn.glb_commitTransaction();
            glb_function.glb_strUserName = "";
            InitialLogin();
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtDifFir = cnn.GetDataTable("select swid,acc_no,acc_name from accounts where system_acc_type='فرق كسر'");

            if (dtDifFir == null || dtDifFir.Rows.Count <= 0)
            {
                glb_function.MsgBox("لايوجد حساب لفرق الكسر");

            }
            else
            {
                Accounts.frmJournal frm = new Accounts.frmJournal();
                glb_function.OpenForm(this, frm, false);
                // new Account.frmJournal().Show(this);
            }
        }

        private void btnDefineForms_Click(object sender, EventArgs e)
        {

            

            File.frmTempletManagement frm = new File.frmTempletManagement();
            glb_function.OpenForm(this, frm, false);
          
        }

      
       

       

        private void btnCasher_Click(object sender, EventArgs e)
        {
            Accounts.frmCasher frm = new Accounts.frmCasher();
            glb_function.OpenForm(this, frm, false);
            
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            Accounts.frmBanks  frm = new Accounts.frmBanks();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            Accounts.frmActivities  frm = new Accounts.frmActivities();
            glb_function.OpenForm(this, frm,false );
        }

        private void btnCostCenter_Click(object sender, EventArgs e)
        {
            Accounts.frmCostCenter frm = new Accounts.frmCostCenter();
            glb_function.OpenForm(this, frm, false);
        }

        private void pbxSmallLogo_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSystemAcc_Click(object sender, EventArgs e)
        {
            Accounts.frmAddSystemAcc frm = new Accounts.frmAddSystemAcc();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnAddressBook_Click(object sender, EventArgs e)
        {
            File.frmContacts  frm = new File.frmContacts();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Sales.frmCustomers frm = new Sales.frmCustomers();
            glb_function.OpenForm(this, frm, false);
        }

        

      

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            Accounts.frmCollector frm = new Accounts.frmCollector();
            glb_function.OpenForm(this, frm, false);
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            //Accounts.frmReceipts frm = new Accounts.frmReceipts();
            //glb_function.OpenForm(this, frm, false);
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            Accounts.frmCashReceipts frm = new Accounts.frmCashReceipts();
            glb_function.OpenForm(this, frm, false);
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
           
        }

        private void ribbonButton2_Click_1(object sender, EventArgs e)
        {
            Accounts.frmJournalReview frm = new Accounts.frmJournalReview();
            glb_function.OpenForm(this, frm, false);
        }

       

    
     
        private void ribbonButton4_DoubleClick(object sender, EventArgs e)
        {

        }

      

     
      

        private void btnDefineTemplet_Click(object sender, EventArgs e)
        {
          File.  frmDefineTemplet frm = new File.frmDefineTemplet ();
            glb_function.OpenForm(this, frm, false);
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            //Accounts.frmReversVocher frm = new Accounts.frmReversVocher();
            //glb_function.OpenForm(this, frm, false);
        }

        private void btnJournalPosted_Click(object sender, EventArgs e)
        {
            Accounts.frmJournalPosted  frm = new Accounts.frmJournalPosted();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnDepartements_Click(object sender, EventArgs e)
        {
            File.frmDepartements  frm = new File.frmDepartements();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnProperities_Click(object sender, EventArgs e)
        {
            Inventory.frmProperties  frm = new Inventory.frmProperties();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnInvSetting_Click(object sender, EventArgs e)
        {
            Inventory.frmInvSetting  frm = new Inventory.frmInvSetting();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnItemTree_Click(object sender, EventArgs e)
        {
            Inventory.frmItemTree  frm = new Inventory.frmItemTree();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Inventory.frmItems frm = new Inventory.frmItems();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {

            Inventory.frmWareHouse frm = new Inventory.frmWareHouse();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnWH_Items_Click(object sender, EventArgs e)
        {
            Inventory.frmWH_Items frm = new Inventory.frmWH_Items();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            Inventory.frmUnits frm = new Inventory.frmUnits();
            glb_function.OpenForm(this, frm, false);

        }

        private void btnServicesCenter_Click(object sender, EventArgs e)
        {
            Inventory.frmServiceCenter frm = new Inventory.frmServiceCenter();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            Inventory.frmServices frm = new Inventory.frmServices();
            glb_function.OpenForm(this, frm, false);
        }

        private void btnSevicesAttachments_Click(object sender, EventArgs e)
        {
            Inventory.frmSevicesAttachments frm = new Inventory.frmSevicesAttachments();
            glb_function.OpenForm(this, frm, false);
        }

        private void rbVendors_Click(object sender, EventArgs e)
        {
            Purchases.frmVendors frm = new Purchases.frmVendors();
            glb_function.OpenForm(this, frm, false);
        }

      
        private void btnBeginingVocher_Click(object sender, EventArgs e)
        {
            //Accounts.frmBeginingVocher frm = new Accounts.frmBeginingVocher();
            //glb_function.OpenForm(this, frm, false);
        }

        private void rbRequirementRequest_Click(object sender, EventArgs e)
        {
            Purchases.frmRequirementRequest  frm = new Purchases.frmRequirementRequest();
            glb_function.OpenForm(this, frm, false);
        }

        private void rbPurchaseRequest_Click(object sender, EventArgs e)
        {
            Purchases.frmPurchaseRequest frm = new Purchases.frmPurchaseRequest();
            glb_function.OpenForm(this, frm, false);
        }

        private void rbCreatePurchaseExp_Click(object sender, EventArgs e)
        {
            Purchases.frmCreatePurchaseExp frm = new Purchases.frmCreatePurchaseExp();
            glb_function.OpenForm(this, frm, false);
        }

        private void rbPurchaseQuotation_Click(object sender, EventArgs e)
        {
            Purchases.frmPurchaseQuotation frm = new Purchases.frmPurchaseQuotation();
            glb_function.OpenForm(this, frm, false);
        }

        private void rbPurchaseOrder_Click(object sender, EventArgs e)
        {
            Purchases.frmPurchaseOrder frm = new Purchases.frmPurchaseOrder();
            glb_function.OpenForm(this, frm, false);
        }

        private void rbLetterCredit_Click(object sender, EventArgs e)
        {
            Accounts.frmLetterCredit frm = new Accounts.frmLetterCredit();
            frm.strLC_NATURE = "مشتريات";
            glb_function.OpenForm(this, frm, false);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rbImports_Click(object sender, EventArgs e)
        {
            Purchases.frmImports frm = new Purchases.frmImports();
            
            glb_function.OpenForm(this, frm, false);
        }

        private void rbPurchaseBill_Click(object sender, EventArgs e)
        {
            Purchases.frmPurchasesBill frm = new Purchases.frmPurchasesBill();
            frm.strImportNo = "";
            frm.strThisFormFromWhere = "Main";
            glb_function.OpenForm(this, frm, false);
        }

        private void rbPurchBillVoucher_Click(object sender, EventArgs e)
        {
            Purchases.frmPurchaseBillVoucher frm = new Purchases.frmPurchaseBillVoucher();
            
            glb_function.OpenForm(this, frm, false);
        }

        private void rbPackingList_Click(object sender, EventArgs e)
        {
            Purchases.frmPackingList frm = new Purchases.frmPackingList();

            glb_function.OpenForm(this, frm, false);
        }

        private void rbDestributeExp_Click(object sender, EventArgs e)
        {
            Purchases.frmDestributeExp frm = new Purchases.frmDestributeExp();

            glb_function.OpenForm(this, frm, false);
        }

        private void rbCalculatCost_Click(object sender, EventArgs e)
        {
            Purchases.frmCalculatCost frm = new Purchases.frmCalculatCost();

            glb_function.OpenForm(this, frm, false);
        }
    }
}
