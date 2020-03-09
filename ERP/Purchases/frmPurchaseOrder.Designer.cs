namespace ERP.Purchases
{
    partial class frmPurchaseOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.lstBranchHeader = new ERP.myList();
            this.myLabel29 = new ERP.myLabel();
            this.btnAddExpeness = new ERP.myBottun();
            this.myLabel23 = new ERP.myLabel();
            this.lstCURRENCY_ID = new ERP.myList();
            this.lstSHIPPING_Way = new ERP.myList();
            this.txtPORT_OF_LOADING = new ERP.myText();
            this.txtPORT_OF_DELIVERY = new ERP.myText();
            this.txtPAYMENT_AGREEMENT = new ERP.myText();
            this.txtPROFORMA_INVOICE_NUM = new ERP.myText();
            this.dtpPURCHASE_ORDER_DATE = new ERP.myDate();
            this.dtpPROFORMA_INVOICE_DATE = new ERP.myDate();
            this.txtPURCHASE_ORDER_NUM = new ERP.myText();
            this.btnGetPurchaseOrder = new ERP.myBottun();
            this.txtPURCHASE_QUOTATIONS_ID = new ERP.myText();
            this.txtPURCHASE_QUOTATIONS_No = new ERP.myText();
            this.btnGetQuotation = new ERP.myBottun();
            this.nmbCURRENCY_EXCHANGE = new ERP.myNumber();
            this.txtTERMS_EXPENSES_ID = new ERP.myText();
            this.txtTERMS_OF_EXPENSES_name = new ERP.myText();
            this.btnGetExpenssTerm = new ERP.myBottun();
            this.myLabel15 = new ERP.myLabel();
            this.myLabel14 = new ERP.myLabel();
            this.myLabel12 = new ERP.myLabel();
            this.myLabel11 = new ERP.myLabel();
            this.myLabel10 = new ERP.myLabel();
            this.myLabel9 = new ERP.myLabel();
            this.myLabel7 = new ERP.myLabel();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.txtSUPPLIER_ID = new ERP.myText();
            this.myLabel8 = new ERP.myLabel();
            this.txtSwid = new ERP.myText();
            this.txtSUPPLIER_Name = new ERP.myText();
            this.btnGetVendor = new ERP.myBottun();
            this.gbItems = new ERP.myGroupBox();
            this.nmbCURRENT_STOCK_QTY = new ERP.myNumber();
            this.txtItemId = new ERP.myText();
            this.txtItemName = new ERP.myText();
            this.myLabel17 = new ERP.myLabel();
            this.myLabel20 = new ERP.myLabel();
            this.txtItemNo = new ERP.myText();
            this.btnFindItem = new ERP.myBottun();
            this.myGroupBox2 = new ERP.myGroupBox();
            this.btnGetSupplierItem = new ERP.myBottun();
            this.txtITEM_SUPPLIER_Id = new ERP.myText();
            this.txtITEM_INFO = new ERP.myText();
            this.myLabel22 = new ERP.myLabel();
            this.txtITEM_SUPPLIER_NAME = new ERP.myText();
            this.myLabel13 = new ERP.myLabel();
            this.myLabel16 = new ERP.myLabel();
            this.txtITEM_SUPPLIER_NUMBER = new ERP.myText();
            this.nmbUNIT_PRICE = new ERP.myNumber();
            this.myLabel25 = new ERP.myLabel();
            this.nmbFREE_QTY = new ERP.myNumber();
            this.myLabel24 = new ERP.myLabel();
            this.nmbREQUESTED_QTY = new ERP.myNumber();
            this.myLabel19 = new ERP.myLabel();
            this.myLabel18 = new ERP.myLabel();
            this.btnAdd = new ERP.myBottun();
            this.btnGetExpenss = new ERP.myBottun();
            this.myBottun6 = new ERP.myBottun();
            this.nmbExpenssItem = new ERP.myNumber();
            this.myLabel26 = new ERP.myLabel();
            this.txtEXPENSES_Name = new ERP.myText();
            this.myLabel27 = new ERP.myLabel();
            this.btnNew = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.txtEXPENSES_ID = new ERP.myText();
            this.nmbTotal = new ERP.myNumber();
            this.dgvPurQuotDetail = new ERP.myDataGrid();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetailSuppItmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetailQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetailFreeQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetailUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetailTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewImageColumn();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.nmbExpEditor = new ERP.myNumber();
            this.dgExpenss = new ERP.myDataGrid();
            this.clmExpSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpExpenssItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpDeleteBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.lstTempBranch = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPORT_OF_LOADING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPORT_OF_DELIVERY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPAYMENT_AGREEMENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPROFORMA_INVOICE_NUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPURCHASE_ORDER_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPROFORMA_INVOICE_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPURCHASE_ORDER_NUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPURCHASE_QUOTATIONS_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPURCHASE_QUOTATIONS_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURRENCY_EXCHANGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTERMS_EXPENSES_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTERMS_OF_EXPENSES_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUPPLIER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUPPLIER_Name)).BeginInit();
            this.gbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURRENT_STOCK_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemNo)).BeginInit();
            this.myGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_SUPPLIER_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_INFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_SUPPLIER_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_SUPPLIER_NUMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUNIT_PRICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbFREE_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbREQUESTED_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpenssItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurQuotDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTempBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(365, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(278, 34);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.lstBranchHeader);
            this.myGroupBox1.Controls.Add(this.myLabel29);
            this.myGroupBox1.Controls.Add(this.btnAddExpeness);
            this.myGroupBox1.Controls.Add(this.myLabel23);
            this.myGroupBox1.Controls.Add(this.lstCURRENCY_ID);
            this.myGroupBox1.Controls.Add(this.lstSHIPPING_Way);
            this.myGroupBox1.Controls.Add(this.txtPORT_OF_LOADING);
            this.myGroupBox1.Controls.Add(this.txtPORT_OF_DELIVERY);
            this.myGroupBox1.Controls.Add(this.txtPAYMENT_AGREEMENT);
            this.myGroupBox1.Controls.Add(this.txtPROFORMA_INVOICE_NUM);
            this.myGroupBox1.Controls.Add(this.dtpPURCHASE_ORDER_DATE);
            this.myGroupBox1.Controls.Add(this.dtpPROFORMA_INVOICE_DATE);
            this.myGroupBox1.Controls.Add(this.txtPURCHASE_ORDER_NUM);
            this.myGroupBox1.Controls.Add(this.btnGetPurchaseOrder);
            this.myGroupBox1.Controls.Add(this.txtPURCHASE_QUOTATIONS_ID);
            this.myGroupBox1.Controls.Add(this.txtPURCHASE_QUOTATIONS_No);
            this.myGroupBox1.Controls.Add(this.btnGetQuotation);
            this.myGroupBox1.Controls.Add(this.nmbCURRENCY_EXCHANGE);
            this.myGroupBox1.Controls.Add(this.txtTERMS_EXPENSES_ID);
            this.myGroupBox1.Controls.Add(this.txtTERMS_OF_EXPENSES_name);
            this.myGroupBox1.Controls.Add(this.btnGetExpenssTerm);
            this.myGroupBox1.Controls.Add(this.myLabel15);
            this.myGroupBox1.Controls.Add(this.myLabel14);
            this.myGroupBox1.Controls.Add(this.myLabel12);
            this.myGroupBox1.Controls.Add(this.myLabel11);
            this.myGroupBox1.Controls.Add(this.myLabel10);
            this.myGroupBox1.Controls.Add(this.myLabel9);
            this.myGroupBox1.Controls.Add(this.myLabel7);
            this.myGroupBox1.Controls.Add(this.myLabel6);
            this.myGroupBox1.Controls.Add(this.myLabel5);
            this.myGroupBox1.Controls.Add(this.myLabel4);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Controls.Add(this.txtSUPPLIER_ID);
            this.myGroupBox1.Controls.Add(this.myLabel8);
            this.myGroupBox1.Controls.Add(this.txtSwid);
            this.myGroupBox1.Controls.Add(this.txtSUPPLIER_Name);
            this.myGroupBox1.Controls.Add(this.btnGetVendor);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(12, 34);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(874, 142);
            this.myGroupBox1.TabIndex = 4;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "معلومات امر الشراء";
            // 
            // lstBranchHeader
            // 
            this.lstBranchHeader.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBranchHeader.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBranchHeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBranchHeader.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBranchHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstBranchHeader.FormattingEnabled = true;
            this.lstBranchHeader.Location = new System.Drawing.Point(32, 84);
            this.lstBranchHeader.Name = "lstBranchHeader";
            this.lstBranchHeader.Size = new System.Drawing.Size(116, 24);
            this.lstBranchHeader.TabIndex = 415;
            this.lstBranchHeader.W_Clear = false;
            this.lstBranchHeader.W_ColArName = "";
            this.lstBranchHeader.W_ColEgName = "";
            this.lstBranchHeader.W_OldValue = "";
            this.lstBranchHeader.W_TableName = "";
            this.lstBranchHeader.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstBranchHeader.SelectedIndexChanged += new System.EventHandler(this.lstBranchHeader_SelectedIndexChanged);
            // 
            // myLabel29
            // 
            this.myLabel29.AutoSize = false;
            this.myLabel29.BackColor = System.Drawing.Color.Transparent;
            this.myLabel29.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel29.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel29.ForeColor = System.Drawing.Color.Black;
            this.myLabel29.Location = new System.Drawing.Point(156, 87);
            this.myLabel29.Name = "myLabel29";
            this.myLabel29.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel29.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel29.Size = new System.Drawing.Size(44, 18);
            this.myLabel29.TabIndex = 414;
            this.myLabel29.Text = "الفـرع";
            // 
            // btnAddExpeness
            // 
            this.btnAddExpeness.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnAddExpeness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddExpeness.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddExpeness.FlatAppearance.BorderSize = 0;
            this.btnAddExpeness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpeness.IsBackStageButton = false;
            this.btnAddExpeness.Location = new System.Drawing.Point(6, 109);
            this.btnAddExpeness.Name = "btnAddExpeness";
            this.btnAddExpeness.Size = new System.Drawing.Size(56, 28);
            this.btnAddExpeness.TabIndex = 413;
            this.btnAddExpeness.Text = "فتح";
            this.btnAddExpeness.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAddExpeness.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAddExpeness.Click += new System.EventHandler(this.btnAddExpeness_Click);
            // 
            // myLabel23
            // 
            this.myLabel23.BackColor = System.Drawing.Color.Transparent;
            this.myLabel23.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel23.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel23.ForeColor = System.Drawing.Color.Black;
            this.myLabel23.Location = new System.Drawing.Point(64, 114);
            this.myLabel23.Name = "myLabel23";
            this.myLabel23.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel23.Size = new System.Drawing.Size(155, 18);
            this.myLabel23.TabIndex = 412;
            this.myLabel23.Text = "إضافة مصاريف أوامر الشراء";
            // 
            // lstCURRENCY_ID
            // 
            this.lstCURRENCY_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCURRENCY_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCURRENCY_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCURRENCY_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCURRENCY_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCURRENCY_ID.FormattingEnabled = true;
            this.lstCURRENCY_ID.Location = new System.Drawing.Point(228, 53);
            this.lstCURRENCY_ID.Name = "lstCURRENCY_ID";
            this.lstCURRENCY_ID.Size = new System.Drawing.Size(105, 24);
            this.lstCURRENCY_ID.TabIndex = 411;
            this.lstCURRENCY_ID.W_Clear = true;
            this.lstCURRENCY_ID.W_ColArName = "";
            this.lstCURRENCY_ID.W_ColEgName = "";
            this.lstCURRENCY_ID.W_OldValue = "";
            this.lstCURRENCY_ID.W_TableName = "";
            this.lstCURRENCY_ID.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstCURRENCY_ID.SelectedIndexChanged += new System.EventHandler(this.lstCURRENCY_ID_SelectedIndexChanged);
            // 
            // lstSHIPPING_Way
            // 
            this.lstSHIPPING_Way.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstSHIPPING_Way.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstSHIPPING_Way.Font = new System.Drawing.Font("Arial", 10F);
            this.lstSHIPPING_Way.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstSHIPPING_Way.FormattingEnabled = true;
            this.lstSHIPPING_Way.Items.AddRange(new object[] {
            "جو",
            "بحر",
            "بر"});
            this.lstSHIPPING_Way.Location = new System.Drawing.Point(656, 82);
            this.lstSHIPPING_Way.Name = "lstSHIPPING_Way";
            this.lstSHIPPING_Way.Size = new System.Drawing.Size(144, 24);
            this.lstSHIPPING_Way.TabIndex = 410;
            this.lstSHIPPING_Way.W_Clear = true;
            this.lstSHIPPING_Way.W_ColArName = "";
            this.lstSHIPPING_Way.W_ColEgName = "";
            this.lstSHIPPING_Way.W_OldValue = "";
            this.lstSHIPPING_Way.W_TableName = "";
            this.lstSHIPPING_Way.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // txtPORT_OF_LOADING
            // 
            this.txtPORT_OF_LOADING.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtPORT_OF_LOADING.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPORT_OF_LOADING.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPORT_OF_LOADING.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPORT_OF_LOADING.Location = new System.Drawing.Point(405, 83);
            this.txtPORT_OF_LOADING.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPORT_OF_LOADING.Name = "txtPORT_OF_LOADING";
            this.txtPORT_OF_LOADING.Size = new System.Drawing.Size(144, 23);
            this.txtPORT_OF_LOADING.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPORT_OF_LOADING.TabIndex = 409;
            this.txtPORT_OF_LOADING.W_Clear = true;
            this.txtPORT_OF_LOADING.W_ColArName = "الباركود";
            this.txtPORT_OF_LOADING.W_ColEgName = "BARCODE";
            this.txtPORT_OF_LOADING.W_OldValue = "";
            this.txtPORT_OF_LOADING.W_TableName = "BENEFICIARY";
            // 
            // txtPORT_OF_DELIVERY
            // 
            this.txtPORT_OF_DELIVERY.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtPORT_OF_DELIVERY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPORT_OF_DELIVERY.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPORT_OF_DELIVERY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPORT_OF_DELIVERY.Location = new System.Drawing.Point(228, 83);
            this.txtPORT_OF_DELIVERY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPORT_OF_DELIVERY.Name = "txtPORT_OF_DELIVERY";
            this.txtPORT_OF_DELIVERY.Size = new System.Drawing.Size(105, 23);
            this.txtPORT_OF_DELIVERY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPORT_OF_DELIVERY.TabIndex = 408;
            this.txtPORT_OF_DELIVERY.W_Clear = true;
            this.txtPORT_OF_DELIVERY.W_ColArName = "الباركود";
            this.txtPORT_OF_DELIVERY.W_ColEgName = "BARCODE";
            this.txtPORT_OF_DELIVERY.W_OldValue = "";
            this.txtPORT_OF_DELIVERY.W_TableName = "BENEFICIARY";
            // 
            // txtPAYMENT_AGREEMENT
            // 
            this.txtPAYMENT_AGREEMENT.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtPAYMENT_AGREEMENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPAYMENT_AGREEMENT.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPAYMENT_AGREEMENT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPAYMENT_AGREEMENT.Location = new System.Drawing.Point(656, 109);
            this.txtPAYMENT_AGREEMENT.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPAYMENT_AGREEMENT.Name = "txtPAYMENT_AGREEMENT";
            this.txtPAYMENT_AGREEMENT.Size = new System.Drawing.Size(144, 23);
            this.txtPAYMENT_AGREEMENT.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPAYMENT_AGREEMENT.TabIndex = 407;
            this.txtPAYMENT_AGREEMENT.W_Clear = true;
            this.txtPAYMENT_AGREEMENT.W_ColArName = "الباركود";
            this.txtPAYMENT_AGREEMENT.W_ColEgName = "BARCODE";
            this.txtPAYMENT_AGREEMENT.W_OldValue = "";
            this.txtPAYMENT_AGREEMENT.W_TableName = "BENEFICIARY";
            // 
            // txtPROFORMA_INVOICE_NUM
            // 
            this.txtPROFORMA_INVOICE_NUM.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtPROFORMA_INVOICE_NUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPROFORMA_INVOICE_NUM.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPROFORMA_INVOICE_NUM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPROFORMA_INVOICE_NUM.Location = new System.Drawing.Point(656, 55);
            this.txtPROFORMA_INVOICE_NUM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPROFORMA_INVOICE_NUM.Name = "txtPROFORMA_INVOICE_NUM";
            this.txtPROFORMA_INVOICE_NUM.Size = new System.Drawing.Size(144, 23);
            this.txtPROFORMA_INVOICE_NUM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPROFORMA_INVOICE_NUM.TabIndex = 406;
            this.txtPROFORMA_INVOICE_NUM.W_Clear = true;
            this.txtPROFORMA_INVOICE_NUM.W_ColArName = "الباركود";
            this.txtPROFORMA_INVOICE_NUM.W_ColEgName = "BARCODE";
            this.txtPROFORMA_INVOICE_NUM.W_OldValue = "";
            this.txtPROFORMA_INVOICE_NUM.W_TableName = "BENEFICIARY";
            // 
            // dtpPURCHASE_ORDER_DATE
            // 
            this.dtpPURCHASE_ORDER_DATE.BorderColor = System.Drawing.Color.Empty;
            this.dtpPURCHASE_ORDER_DATE.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpPURCHASE_ORDER_DATE.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpPURCHASE_ORDER_DATE.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpPURCHASE_ORDER_DATE.CustomFormat = "dd/MM/yyyy";
            this.dtpPURCHASE_ORDER_DATE.DropDownImage = null;
            this.dtpPURCHASE_ORDER_DATE.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dtpPURCHASE_ORDER_DATE.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpPURCHASE_ORDER_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.dtpPURCHASE_ORDER_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPURCHASE_ORDER_DATE.Location = new System.Drawing.Point(228, 28);
            this.dtpPURCHASE_ORDER_DATE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpPURCHASE_ORDER_DATE.MinValue = new System.DateTime(((long)(0)));
            this.dtpPURCHASE_ORDER_DATE.Name = "dtpPURCHASE_ORDER_DATE";
            this.dtpPURCHASE_ORDER_DATE.NoneButtonVisible = false;
            this.dtpPURCHASE_ORDER_DATE.ShowCheckBox = false;
            this.dtpPURCHASE_ORDER_DATE.Size = new System.Drawing.Size(105, 20);
            this.dtpPURCHASE_ORDER_DATE.TabIndex = 405;
            this.dtpPURCHASE_ORDER_DATE.Value = new System.DateTime(2018, 7, 24, 18, 36, 49, 60);
            this.dtpPURCHASE_ORDER_DATE.W_Clear = true;
            this.dtpPURCHASE_ORDER_DATE.W_ColArName = "";
            this.dtpPURCHASE_ORDER_DATE.W_ColEgName = "";
            this.dtpPURCHASE_ORDER_DATE.W_OldValue = "";
            this.dtpPURCHASE_ORDER_DATE.W_TableName = "";
            // 
            // dtpPROFORMA_INVOICE_DATE
            // 
            this.dtpPROFORMA_INVOICE_DATE.BorderColor = System.Drawing.Color.Empty;
            this.dtpPROFORMA_INVOICE_DATE.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpPROFORMA_INVOICE_DATE.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpPROFORMA_INVOICE_DATE.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpPROFORMA_INVOICE_DATE.CustomFormat = "dd/MM/yyyy";
            this.dtpPROFORMA_INVOICE_DATE.DropDownImage = null;
            this.dtpPROFORMA_INVOICE_DATE.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dtpPROFORMA_INVOICE_DATE.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpPROFORMA_INVOICE_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.dtpPROFORMA_INVOICE_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPROFORMA_INVOICE_DATE.Location = new System.Drawing.Point(444, 58);
            this.dtpPROFORMA_INVOICE_DATE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpPROFORMA_INVOICE_DATE.MinValue = new System.DateTime(((long)(0)));
            this.dtpPROFORMA_INVOICE_DATE.Name = "dtpPROFORMA_INVOICE_DATE";
            this.dtpPROFORMA_INVOICE_DATE.NoneButtonVisible = false;
            this.dtpPROFORMA_INVOICE_DATE.ShowCheckBox = false;
            this.dtpPROFORMA_INVOICE_DATE.Size = new System.Drawing.Size(105, 20);
            this.dtpPROFORMA_INVOICE_DATE.TabIndex = 404;
            this.dtpPROFORMA_INVOICE_DATE.Value = new System.DateTime(2018, 7, 24, 18, 36, 49, 60);
            this.dtpPROFORMA_INVOICE_DATE.W_Clear = true;
            this.dtpPROFORMA_INVOICE_DATE.W_ColArName = "";
            this.dtpPROFORMA_INVOICE_DATE.W_ColEgName = "";
            this.dtpPROFORMA_INVOICE_DATE.W_OldValue = "";
            this.dtpPROFORMA_INVOICE_DATE.W_TableName = "";
            // 
            // txtPURCHASE_ORDER_NUM
            // 
            this.txtPURCHASE_ORDER_NUM.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtPURCHASE_ORDER_NUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPURCHASE_ORDER_NUM.Enabled = false;
            this.txtPURCHASE_ORDER_NUM.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPURCHASE_ORDER_NUM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPURCHASE_ORDER_NUM.Location = new System.Drawing.Point(433, 26);
            this.txtPURCHASE_ORDER_NUM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPURCHASE_ORDER_NUM.Name = "txtPURCHASE_ORDER_NUM";
            this.txtPURCHASE_ORDER_NUM.Size = new System.Drawing.Size(116, 23);
            this.txtPURCHASE_ORDER_NUM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPURCHASE_ORDER_NUM.TabIndex = 402;
            this.txtPURCHASE_ORDER_NUM.W_Clear = true;
            this.txtPURCHASE_ORDER_NUM.W_ColArName = "الباركود";
            this.txtPURCHASE_ORDER_NUM.W_ColEgName = "BARCODE";
            this.txtPURCHASE_ORDER_NUM.W_OldValue = "";
            this.txtPURCHASE_ORDER_NUM.W_TableName = "BENEFICIARY";
            // 
            // btnGetPurchaseOrder
            // 
            this.btnGetPurchaseOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetPurchaseOrder.BackgroundImage")));
            this.btnGetPurchaseOrder.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetPurchaseOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetPurchaseOrder.FlatAppearance.BorderSize = 0;
            this.btnGetPurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPurchaseOrder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetPurchaseOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetPurchaseOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnGetPurchaseOrder.Image")));
            this.btnGetPurchaseOrder.IsBackStageButton = false;
            this.btnGetPurchaseOrder.Location = new System.Drawing.Point(405, 23);
            this.btnGetPurchaseOrder.Name = "btnGetPurchaseOrder";
            this.btnGetPurchaseOrder.Size = new System.Drawing.Size(28, 27);
            this.btnGetPurchaseOrder.TabIndex = 401;
            this.btnGetPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnGetPurchaseOrder.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetPurchaseOrder.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetPurchaseOrder.Click += new System.EventHandler(this.btnGetPurchaseOrder_Click);
            // 
            // txtPURCHASE_QUOTATIONS_ID
            // 
            this.txtPURCHASE_QUOTATIONS_ID.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtPURCHASE_QUOTATIONS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPURCHASE_QUOTATIONS_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPURCHASE_QUOTATIONS_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPURCHASE_QUOTATIONS_ID.Location = new System.Drawing.Point(32, 24);
            this.txtPURCHASE_QUOTATIONS_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPURCHASE_QUOTATIONS_ID.Name = "txtPURCHASE_QUOTATIONS_ID";
            this.txtPURCHASE_QUOTATIONS_ID.Size = new System.Drawing.Size(38, 23);
            this.txtPURCHASE_QUOTATIONS_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPURCHASE_QUOTATIONS_ID.TabIndex = 400;
            this.txtPURCHASE_QUOTATIONS_ID.Visible = false;
            this.txtPURCHASE_QUOTATIONS_ID.W_Clear = true;
            this.txtPURCHASE_QUOTATIONS_ID.W_ColArName = "";
            this.txtPURCHASE_QUOTATIONS_ID.W_ColEgName = "";
            this.txtPURCHASE_QUOTATIONS_ID.W_OldValue = "";
            this.txtPURCHASE_QUOTATIONS_ID.W_TableName = "";
            // 
            // txtPURCHASE_QUOTATIONS_No
            // 
            this.txtPURCHASE_QUOTATIONS_No.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtPURCHASE_QUOTATIONS_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPURCHASE_QUOTATIONS_No.Enabled = false;
            this.txtPURCHASE_QUOTATIONS_No.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPURCHASE_QUOTATIONS_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPURCHASE_QUOTATIONS_No.Location = new System.Drawing.Point(32, 24);
            this.txtPURCHASE_QUOTATIONS_No.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPURCHASE_QUOTATIONS_No.Name = "txtPURCHASE_QUOTATIONS_No";
            this.txtPURCHASE_QUOTATIONS_No.Size = new System.Drawing.Size(116, 23);
            this.txtPURCHASE_QUOTATIONS_No.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPURCHASE_QUOTATIONS_No.TabIndex = 399;
            this.txtPURCHASE_QUOTATIONS_No.W_Clear = true;
            this.txtPURCHASE_QUOTATIONS_No.W_ColArName = "";
            this.txtPURCHASE_QUOTATIONS_No.W_ColEgName = "";
            this.txtPURCHASE_QUOTATIONS_No.W_OldValue = "";
            this.txtPURCHASE_QUOTATIONS_No.W_TableName = "";
            // 
            // btnGetQuotation
            // 
            this.btnGetQuotation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetQuotation.BackgroundImage")));
            this.btnGetQuotation.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetQuotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetQuotation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetQuotation.FlatAppearance.BorderSize = 0;
            this.btnGetQuotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetQuotation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetQuotation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetQuotation.Image = ((System.Drawing.Image)(resources.GetObject("btnGetQuotation.Image")));
            this.btnGetQuotation.IsBackStageButton = false;
            this.btnGetQuotation.Location = new System.Drawing.Point(4, 21);
            this.btnGetQuotation.Name = "btnGetQuotation";
            this.btnGetQuotation.Size = new System.Drawing.Size(28, 27);
            this.btnGetQuotation.TabIndex = 398;
            this.btnGetQuotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetQuotation.UseVisualStyleBackColor = true;
            this.btnGetQuotation.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetQuotation.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetQuotation.Click += new System.EventHandler(this.btnGetQuotation_Click);
            // 
            // nmbCURRENCY_EXCHANGE
            // 
            this.nmbCURRENCY_EXCHANGE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbCURRENCY_EXCHANGE.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.nmbCURRENCY_EXCHANGE.DecimalPlaces = 0;
            this.nmbCURRENCY_EXCHANGE.DoubleValue = 0D;
            this.nmbCURRENCY_EXCHANGE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCURRENCY_EXCHANGE.Location = new System.Drawing.Point(32, 55);
            this.nmbCURRENCY_EXCHANGE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbCURRENCY_EXCHANGE.MinValue = 0D;
            this.nmbCURRENCY_EXCHANGE.Name = "nmbCURRENCY_EXCHANGE";
            this.nmbCURRENCY_EXCHANGE.NullString = "";
            this.nmbCURRENCY_EXCHANGE.NumberDecimalDigits = 0;
            this.nmbCURRENCY_EXCHANGE.Size = new System.Drawing.Size(116, 23);
            this.nmbCURRENCY_EXCHANGE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbCURRENCY_EXCHANGE.TabIndex = 397;
            this.nmbCURRENCY_EXCHANGE.Text = "0";
            this.nmbCURRENCY_EXCHANGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbCURRENCY_EXCHANGE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCURRENCY_EXCHANGE.W_Clear = true;
            this.nmbCURRENCY_EXCHANGE.W_ColArName = "";
            this.nmbCURRENCY_EXCHANGE.W_ColEgName = "";
            this.nmbCURRENCY_EXCHANGE.W_OldValue = "";
            this.nmbCURRENCY_EXCHANGE.W_TableName = "";
            // 
            // txtTERMS_EXPENSES_ID
            // 
            this.txtTERMS_EXPENSES_ID.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtTERMS_EXPENSES_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTERMS_EXPENSES_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTERMS_EXPENSES_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtTERMS_EXPENSES_ID.Location = new System.Drawing.Point(433, 111);
            this.txtTERMS_EXPENSES_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTERMS_EXPENSES_ID.Name = "txtTERMS_EXPENSES_ID";
            this.txtTERMS_EXPENSES_ID.Size = new System.Drawing.Size(38, 23);
            this.txtTERMS_EXPENSES_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTERMS_EXPENSES_ID.TabIndex = 393;
            this.txtTERMS_EXPENSES_ID.Visible = false;
            this.txtTERMS_EXPENSES_ID.W_Clear = true;
            this.txtTERMS_EXPENSES_ID.W_ColArName = "";
            this.txtTERMS_EXPENSES_ID.W_ColEgName = "";
            this.txtTERMS_EXPENSES_ID.W_OldValue = "";
            this.txtTERMS_EXPENSES_ID.W_TableName = "";
            // 
            // txtTERMS_OF_EXPENSES_name
            // 
            this.txtTERMS_OF_EXPENSES_name.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtTERMS_OF_EXPENSES_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTERMS_OF_EXPENSES_name.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTERMS_OF_EXPENSES_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtTERMS_OF_EXPENSES_name.Location = new System.Drawing.Point(433, 111);
            this.txtTERMS_OF_EXPENSES_name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTERMS_OF_EXPENSES_name.Name = "txtTERMS_OF_EXPENSES_name";
            this.txtTERMS_OF_EXPENSES_name.Size = new System.Drawing.Size(116, 23);
            this.txtTERMS_OF_EXPENSES_name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTERMS_OF_EXPENSES_name.TabIndex = 392;
            this.txtTERMS_OF_EXPENSES_name.W_Clear = true;
            this.txtTERMS_OF_EXPENSES_name.W_ColArName = "الباركود";
            this.txtTERMS_OF_EXPENSES_name.W_ColEgName = "BARCODE";
            this.txtTERMS_OF_EXPENSES_name.W_OldValue = "";
            this.txtTERMS_OF_EXPENSES_name.W_TableName = "BENEFICIARY";
            // 
            // btnGetExpenssTerm
            // 
            this.btnGetExpenssTerm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetExpenssTerm.BackgroundImage")));
            this.btnGetExpenssTerm.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetExpenssTerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetExpenssTerm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetExpenssTerm.FlatAppearance.BorderSize = 0;
            this.btnGetExpenssTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetExpenssTerm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetExpenssTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetExpenssTerm.Image = ((System.Drawing.Image)(resources.GetObject("btnGetExpenssTerm.Image")));
            this.btnGetExpenssTerm.IsBackStageButton = false;
            this.btnGetExpenssTerm.Location = new System.Drawing.Point(405, 108);
            this.btnGetExpenssTerm.Name = "btnGetExpenssTerm";
            this.btnGetExpenssTerm.Size = new System.Drawing.Size(28, 27);
            this.btnGetExpenssTerm.TabIndex = 391;
            this.btnGetExpenssTerm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetExpenssTerm.UseVisualStyleBackColor = true;
            this.btnGetExpenssTerm.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetExpenssTerm.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetExpenssTerm.Click += new System.EventHandler(this.btnGetExpenssTerm_Click);
            // 
            // myLabel15
            // 
            this.myLabel15.AutoSize = false;
            this.myLabel15.BackColor = System.Drawing.Color.Transparent;
            this.myLabel15.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel15.ForeColor = System.Drawing.Color.Black;
            this.myLabel15.Location = new System.Drawing.Point(555, 116);
            this.myLabel15.Name = "myLabel15";
            this.myLabel15.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel15.Size = new System.Drawing.Size(95, 18);
            this.myLabel15.TabIndex = 390;
            this.myLabel15.Text = "اتفاقية المصاريف";
            // 
            // myLabel14
            // 
            this.myLabel14.AutoSize = false;
            this.myLabel14.BackColor = System.Drawing.Color.Transparent;
            this.myLabel14.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel14.ForeColor = System.Drawing.Color.Black;
            this.myLabel14.Location = new System.Drawing.Point(785, 116);
            this.myLabel14.Name = "myLabel14";
            this.myLabel14.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel14.Size = new System.Drawing.Size(82, 18);
            this.myLabel14.TabIndex = 389;
            this.myLabel14.Text = "اتفاقية الدفع";
            // 
            // myLabel12
            // 
            this.myLabel12.AutoSize = false;
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(328, 88);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(78, 18);
            this.myLabel12.TabIndex = 387;
            this.myLabel12.Text = "ميناء التسليم";
            // 
            // myLabel11
            // 
            this.myLabel11.AutoSize = false;
            this.myLabel11.BackColor = System.Drawing.Color.Transparent;
            this.myLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel11.ForeColor = System.Drawing.Color.Black;
            this.myLabel11.Location = new System.Drawing.Point(566, 88);
            this.myLabel11.Name = "myLabel11";
            this.myLabel11.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel11.Size = new System.Drawing.Size(84, 18);
            this.myLabel11.TabIndex = 386;
            this.myLabel11.Text = "ميناء الشحن";
            // 
            // myLabel10
            // 
            this.myLabel10.AutoSize = false;
            this.myLabel10.BackColor = System.Drawing.Color.Transparent;
            this.myLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel10.ForeColor = System.Drawing.Color.Black;
            this.myLabel10.Location = new System.Drawing.Point(795, 84);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel10.Size = new System.Drawing.Size(79, 18);
            this.myLabel10.TabIndex = 385;
            this.myLabel10.Text = "طريقة الشحن";
            // 
            // myLabel9
            // 
            this.myLabel9.AutoSize = false;
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(145, 60);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel9.Size = new System.Drawing.Size(77, 18);
            this.myLabel9.TabIndex = 384;
            this.myLabel9.Text = "سعر الصرف";
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = false;
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(566, 60);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(84, 18);
            this.myLabel7.TabIndex = 383;
            this.myLabel7.Text = "تاريخ الفاتورة";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = false;
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(328, 60);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(78, 18);
            this.myLabel6.TabIndex = 382;
            this.myLabel6.Text = "العملة";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = false;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(800, 60);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(67, 18);
            this.myLabel5.TabIndex = 381;
            this.myLabel5.Text = "رقم الفاتورة";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(145, 30);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(77, 18);
            this.myLabel4.TabIndex = 380;
            this.myLabel4.Text = "عرض السعر";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = false;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(339, 27);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(67, 18);
            this.myLabel3.TabIndex = 379;
            this.myLabel3.Text = "تاريخ الامر";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(555, 28);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(95, 18);
            this.myLabel2.TabIndex = 378;
            this.myLabel2.Text = "رقم امر الشراء";
            // 
            // txtSUPPLIER_ID
            // 
            this.txtSUPPLIER_ID.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtSUPPLIER_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSUPPLIER_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSUPPLIER_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSUPPLIER_ID.Location = new System.Drawing.Point(684, 24);
            this.txtSUPPLIER_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSUPPLIER_ID.Name = "txtSUPPLIER_ID";
            this.txtSUPPLIER_ID.Size = new System.Drawing.Size(38, 23);
            this.txtSUPPLIER_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSUPPLIER_ID.TabIndex = 377;
            this.txtSUPPLIER_ID.Visible = false;
            this.txtSUPPLIER_ID.W_Clear = true;
            this.txtSUPPLIER_ID.W_ColArName = "";
            this.txtSUPPLIER_ID.W_ColEgName = "";
            this.txtSUPPLIER_ID.W_OldValue = "";
            this.txtSUPPLIER_ID.W_TableName = "";
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = false;
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(800, 26);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel8.Size = new System.Drawing.Size(67, 18);
            this.myLabel8.TabIndex = 376;
            this.myLabel8.Text = "اسم المورد";
            // 
            // txtSwid
            // 
            this.txtSwid.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSwid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSwid.Location = new System.Drawing.Point(848, -6);
            this.txtSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSwid.Name = "txtSwid";
            this.txtSwid.Size = new System.Drawing.Size(38, 23);
            this.txtSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSwid.TabIndex = 375;
            this.txtSwid.Visible = false;
            this.txtSwid.W_Clear = true;
            this.txtSwid.W_ColArName = "";
            this.txtSwid.W_ColEgName = "";
            this.txtSwid.W_OldValue = "";
            this.txtSwid.W_TableName = "";
            // 
            // txtSUPPLIER_Name
            // 
            this.txtSUPPLIER_Name.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtSUPPLIER_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSUPPLIER_Name.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSUPPLIER_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSUPPLIER_Name.Location = new System.Drawing.Point(684, 24);
            this.txtSUPPLIER_Name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSUPPLIER_Name.Name = "txtSUPPLIER_Name";
            this.txtSUPPLIER_Name.Size = new System.Drawing.Size(116, 23);
            this.txtSUPPLIER_Name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSUPPLIER_Name.TabIndex = 374;
            this.txtSUPPLIER_Name.W_Clear = true;
            this.txtSUPPLIER_Name.W_ColArName = "الباركود";
            this.txtSUPPLIER_Name.W_ColEgName = "BARCODE";
            this.txtSUPPLIER_Name.W_OldValue = "";
            this.txtSUPPLIER_Name.W_TableName = "BENEFICIARY";
            // 
            // btnGetVendor
            // 
            this.btnGetVendor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetVendor.BackgroundImage")));
            this.btnGetVendor.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetVendor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetVendor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetVendor.FlatAppearance.BorderSize = 0;
            this.btnGetVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetVendor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetVendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetVendor.Image = ((System.Drawing.Image)(resources.GetObject("btnGetVendor.Image")));
            this.btnGetVendor.IsBackStageButton = false;
            this.btnGetVendor.Location = new System.Drawing.Point(656, 21);
            this.btnGetVendor.Name = "btnGetVendor";
            this.btnGetVendor.Size = new System.Drawing.Size(28, 27);
            this.btnGetVendor.TabIndex = 373;
            this.btnGetVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetVendor.UseVisualStyleBackColor = true;
            this.btnGetVendor.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetVendor.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetVendor.Click += new System.EventHandler(this.btnGetVendor_Click);
            // 
            // gbItems
            // 
            this.gbItems.BackColor = System.Drawing.Color.Transparent;
            this.gbItems.Controls.Add(this.nmbCURRENT_STOCK_QTY);
            this.gbItems.Controls.Add(this.txtItemId);
            this.gbItems.Controls.Add(this.txtItemName);
            this.gbItems.Controls.Add(this.myLabel17);
            this.gbItems.Controls.Add(this.myLabel20);
            this.gbItems.Controls.Add(this.txtItemNo);
            this.gbItems.Controls.Add(this.btnFindItem);
            this.gbItems.Controls.Add(this.myGroupBox2);
            this.gbItems.Controls.Add(this.nmbUNIT_PRICE);
            this.gbItems.Controls.Add(this.myLabel25);
            this.gbItems.Controls.Add(this.nmbFREE_QTY);
            this.gbItems.Controls.Add(this.myLabel24);
            this.gbItems.Controls.Add(this.nmbREQUESTED_QTY);
            this.gbItems.Controls.Add(this.myLabel19);
            this.gbItems.Controls.Add(this.myLabel18);
            this.gbItems.Controls.Add(this.btnAdd);
            this.gbItems.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbItems.Location = new System.Drawing.Point(12, 182);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(501, 181);
            this.gbItems.TabIndex = 391;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "الأصنـاف";
            // 
            // nmbCURRENT_STOCK_QTY
            // 
            this.nmbCURRENT_STOCK_QTY.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbCURRENT_STOCK_QTY.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.nmbCURRENT_STOCK_QTY.DecimalPlaces = 0;
            this.nmbCURRENT_STOCK_QTY.DoubleValue = 0D;
            this.nmbCURRENT_STOCK_QTY.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCURRENT_STOCK_QTY.Location = new System.Drawing.Point(324, 125);
            this.nmbCURRENT_STOCK_QTY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbCURRENT_STOCK_QTY.MinValue = 0D;
            this.nmbCURRENT_STOCK_QTY.Name = "nmbCURRENT_STOCK_QTY";
            this.nmbCURRENT_STOCK_QTY.NullString = "";
            this.nmbCURRENT_STOCK_QTY.NumberDecimalDigits = 0;
            this.nmbCURRENT_STOCK_QTY.Size = new System.Drawing.Size(80, 23);
            this.nmbCURRENT_STOCK_QTY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbCURRENT_STOCK_QTY.TabIndex = 312;
            this.nmbCURRENT_STOCK_QTY.Text = "0";
            this.nmbCURRENT_STOCK_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbCURRENT_STOCK_QTY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCURRENT_STOCK_QTY.W_Clear = true;
            this.nmbCURRENT_STOCK_QTY.W_ColArName = "";
            this.nmbCURRENT_STOCK_QTY.W_ColEgName = "";
            this.nmbCURRENT_STOCK_QTY.W_OldValue = "";
            this.nmbCURRENT_STOCK_QTY.W_TableName = "";
            // 
            // txtItemId
            // 
            this.txtItemId.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtItemId.Location = new System.Drawing.Point(445, 22);
            this.txtItemId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(25, 23);
            this.txtItemId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtItemId.TabIndex = 311;
            this.txtItemId.Visible = false;
            this.txtItemId.W_Clear = true;
            this.txtItemId.W_ColArName = "";
            this.txtItemId.W_ColEgName = "";
            this.txtItemId.W_OldValue = "";
            this.txtItemId.W_TableName = "";
            // 
            // txtItemName
            // 
            this.txtItemName.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Enabled = false;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtItemName.Location = new System.Drawing.Point(12, 21);
            this.txtItemName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(150, 23);
            this.txtItemName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtItemName.TabIndex = 310;
            this.txtItemName.W_Clear = true;
            this.txtItemName.W_ColArName = "اسم الفرع بالعربي";
            this.txtItemName.W_ColEgName = "BRANCH_ANAME";
            this.txtItemName.W_OldValue = "";
            this.txtItemName.W_TableName = "BRANCHES";
            // 
            // myLabel17
            // 
            this.myLabel17.BackColor = System.Drawing.Color.Transparent;
            this.myLabel17.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel17.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel17.ForeColor = System.Drawing.Color.Black;
            this.myLabel17.Location = new System.Drawing.Point(174, 23);
            this.myLabel17.Name = "myLabel17";
            this.myLabel17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel17.Size = new System.Drawing.Size(65, 18);
            this.myLabel17.TabIndex = 309;
            this.myLabel17.Text = "اسم الصنف";
            // 
            // myLabel20
            // 
            this.myLabel20.BackColor = System.Drawing.Color.Transparent;
            this.myLabel20.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel20.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel20.ForeColor = System.Drawing.Color.Black;
            this.myLabel20.Location = new System.Drawing.Point(417, 25);
            this.myLabel20.Name = "myLabel20";
            this.myLabel20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel20.Size = new System.Drawing.Size(63, 18);
            this.myLabel20.TabIndex = 306;
            this.myLabel20.Text = "رقم الصنف";
            // 
            // txtItemNo
            // 
            this.txtItemNo.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Enabled = false;
            this.txtItemNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtItemNo.Location = new System.Drawing.Point(270, 21);
            this.txtItemNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(125, 23);
            this.txtItemNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtItemNo.TabIndex = 307;
            this.txtItemNo.W_Clear = true;
            this.txtItemNo.W_ColArName = "اسم الفرع بالعربي";
            this.txtItemNo.W_ColEgName = "BRANCH_ANAME";
            this.txtItemNo.W_OldValue = "";
            this.txtItemNo.W_TableName = "BRANCHES";
            // 
            // btnFindItem
            // 
            this.btnFindItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindItem.BackgroundImage")));
            this.btnFindItem.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFindItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindItem.FlatAppearance.BorderSize = 0;
            this.btnFindItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFindItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindItem.Image = ((System.Drawing.Image)(resources.GetObject("btnFindItem.Image")));
            this.btnFindItem.IsBackStageButton = false;
            this.btnFindItem.Location = new System.Drawing.Point(241, 16);
            this.btnFindItem.Name = "btnFindItem";
            this.btnFindItem.Size = new System.Drawing.Size(28, 27);
            this.btnFindItem.TabIndex = 308;
            this.btnFindItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindItem.UseVisualStyleBackColor = true;
            this.btnFindItem.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFindItem.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFindItem.Click += new System.EventHandler(this.btnFindItem_Click);
            // 
            // myGroupBox2
            // 
            this.myGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox2.Controls.Add(this.btnGetSupplierItem);
            this.myGroupBox2.Controls.Add(this.txtITEM_SUPPLIER_Id);
            this.myGroupBox2.Controls.Add(this.txtITEM_INFO);
            this.myGroupBox2.Controls.Add(this.myLabel22);
            this.myGroupBox2.Controls.Add(this.txtITEM_SUPPLIER_NAME);
            this.myGroupBox2.Controls.Add(this.myLabel13);
            this.myGroupBox2.Controls.Add(this.myLabel16);
            this.myGroupBox2.Controls.Add(this.txtITEM_SUPPLIER_NUMBER);
            this.myGroupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox2.Location = new System.Drawing.Point(6, 50);
            this.myGroupBox2.Name = "myGroupBox2";
            this.myGroupBox2.Size = new System.Drawing.Size(489, 73);
            this.myGroupBox2.TabIndex = 305;
            this.myGroupBox2.TabStop = false;
            this.myGroupBox2.Text = "اصناف المورد";
            // 
            // btnGetSupplierItem
            // 
            this.btnGetSupplierItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetSupplierItem.BackgroundImage")));
            this.btnGetSupplierItem.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetSupplierItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetSupplierItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetSupplierItem.FlatAppearance.BorderSize = 0;
            this.btnGetSupplierItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSupplierItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetSupplierItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetSupplierItem.Image = ((System.Drawing.Image)(resources.GetObject("btnGetSupplierItem.Image")));
            this.btnGetSupplierItem.IsBackStageButton = false;
            this.btnGetSupplierItem.Location = new System.Drawing.Point(235, 15);
            this.btnGetSupplierItem.Name = "btnGetSupplierItem";
            this.btnGetSupplierItem.Size = new System.Drawing.Size(28, 27);
            this.btnGetSupplierItem.TabIndex = 280;
            this.btnGetSupplierItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetSupplierItem.UseVisualStyleBackColor = true;
            this.btnGetSupplierItem.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetSupplierItem.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetSupplierItem.Click += new System.EventHandler(this.btnGetSupplierItem_Click);
            // 
            // txtITEM_SUPPLIER_Id
            // 
            this.txtITEM_SUPPLIER_Id.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtITEM_SUPPLIER_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtITEM_SUPPLIER_Id.Font = new System.Drawing.Font("Arial", 10F);
            this.txtITEM_SUPPLIER_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtITEM_SUPPLIER_Id.Location = new System.Drawing.Point(451, 19);
            this.txtITEM_SUPPLIER_Id.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtITEM_SUPPLIER_Id.Name = "txtITEM_SUPPLIER_Id";
            this.txtITEM_SUPPLIER_Id.Size = new System.Drawing.Size(25, 23);
            this.txtITEM_SUPPLIER_Id.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtITEM_SUPPLIER_Id.TabIndex = 279;
            this.txtITEM_SUPPLIER_Id.Visible = false;
            this.txtITEM_SUPPLIER_Id.W_Clear = true;
            this.txtITEM_SUPPLIER_Id.W_ColArName = "";
            this.txtITEM_SUPPLIER_Id.W_ColEgName = "";
            this.txtITEM_SUPPLIER_Id.W_OldValue = "";
            this.txtITEM_SUPPLIER_Id.W_TableName = "";
            // 
            // txtITEM_INFO
            // 
            this.txtITEM_INFO.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtITEM_INFO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtITEM_INFO.Font = new System.Drawing.Font("Arial", 10F);
            this.txtITEM_INFO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtITEM_INFO.Location = new System.Drawing.Point(6, 44);
            this.txtITEM_INFO.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtITEM_INFO.Name = "txtITEM_INFO";
            this.txtITEM_INFO.Size = new System.Drawing.Size(383, 23);
            this.txtITEM_INFO.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtITEM_INFO.TabIndex = 277;
            this.txtITEM_INFO.W_Clear = true;
            this.txtITEM_INFO.W_ColArName = "اسم الفرع بالعربي";
            this.txtITEM_INFO.W_ColEgName = "BRANCH_ANAME";
            this.txtITEM_INFO.W_OldValue = "";
            this.txtITEM_INFO.W_TableName = "BRANCHES";
            // 
            // myLabel22
            // 
            this.myLabel22.BackColor = System.Drawing.Color.Transparent;
            this.myLabel22.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel22.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel22.ForeColor = System.Drawing.Color.Black;
            this.myLabel22.Location = new System.Drawing.Point(394, 44);
            this.myLabel22.Name = "myLabel22";
            this.myLabel22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel22.Size = new System.Drawing.Size(89, 18);
            this.myLabel22.TabIndex = 276;
            this.myLabel22.Text = "معلومات الصنف";
            // 
            // txtITEM_SUPPLIER_NAME
            // 
            this.txtITEM_SUPPLIER_NAME.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtITEM_SUPPLIER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtITEM_SUPPLIER_NAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtITEM_SUPPLIER_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtITEM_SUPPLIER_NAME.Location = new System.Drawing.Point(6, 19);
            this.txtITEM_SUPPLIER_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtITEM_SUPPLIER_NAME.Name = "txtITEM_SUPPLIER_NAME";
            this.txtITEM_SUPPLIER_NAME.Size = new System.Drawing.Size(156, 23);
            this.txtITEM_SUPPLIER_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtITEM_SUPPLIER_NAME.TabIndex = 275;
            this.txtITEM_SUPPLIER_NAME.W_Clear = true;
            this.txtITEM_SUPPLIER_NAME.W_ColArName = "اسم الفرع بالعربي";
            this.txtITEM_SUPPLIER_NAME.W_ColEgName = "BRANCH_ANAME";
            this.txtITEM_SUPPLIER_NAME.W_OldValue = "";
            this.txtITEM_SUPPLIER_NAME.W_TableName = "BRANCHES";
            // 
            // myLabel13
            // 
            this.myLabel13.BackColor = System.Drawing.Color.Transparent;
            this.myLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel13.ForeColor = System.Drawing.Color.Black;
            this.myLabel13.Location = new System.Drawing.Point(171, 21);
            this.myLabel13.Name = "myLabel13";
            this.myLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel13.Size = new System.Drawing.Size(65, 18);
            this.myLabel13.TabIndex = 274;
            this.myLabel13.Text = "اسم الصنف";
            // 
            // myLabel16
            // 
            this.myLabel16.BackColor = System.Drawing.Color.Transparent;
            this.myLabel16.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel16.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel16.ForeColor = System.Drawing.Color.Black;
            this.myLabel16.Location = new System.Drawing.Point(413, 24);
            this.myLabel16.Name = "myLabel16";
            this.myLabel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel16.Size = new System.Drawing.Size(63, 18);
            this.myLabel16.TabIndex = 217;
            this.myLabel16.Text = "رقم الصنف";
            // 
            // txtITEM_SUPPLIER_NUMBER
            // 
            this.txtITEM_SUPPLIER_NUMBER.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtITEM_SUPPLIER_NUMBER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtITEM_SUPPLIER_NUMBER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtITEM_SUPPLIER_NUMBER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtITEM_SUPPLIER_NUMBER.Location = new System.Drawing.Point(264, 19);
            this.txtITEM_SUPPLIER_NUMBER.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtITEM_SUPPLIER_NUMBER.Name = "txtITEM_SUPPLIER_NUMBER";
            this.txtITEM_SUPPLIER_NUMBER.Size = new System.Drawing.Size(125, 23);
            this.txtITEM_SUPPLIER_NUMBER.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtITEM_SUPPLIER_NUMBER.TabIndex = 218;
            this.txtITEM_SUPPLIER_NUMBER.W_Clear = true;
            this.txtITEM_SUPPLIER_NUMBER.W_ColArName = "اسم الفرع بالعربي";
            this.txtITEM_SUPPLIER_NUMBER.W_ColEgName = "BRANCH_ANAME";
            this.txtITEM_SUPPLIER_NUMBER.W_OldValue = "";
            this.txtITEM_SUPPLIER_NUMBER.W_TableName = "BRANCHES";
            // 
            // nmbUNIT_PRICE
            // 
            this.nmbUNIT_PRICE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbUNIT_PRICE.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.nmbUNIT_PRICE.DecimalPlaces = 0;
            this.nmbUNIT_PRICE.DoubleValue = 0D;
            this.nmbUNIT_PRICE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbUNIT_PRICE.Location = new System.Drawing.Point(182, 126);
            this.nmbUNIT_PRICE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbUNIT_PRICE.MinValue = 0D;
            this.nmbUNIT_PRICE.Name = "nmbUNIT_PRICE";
            this.nmbUNIT_PRICE.NullString = "";
            this.nmbUNIT_PRICE.NumberDecimalDigits = 0;
            this.nmbUNIT_PRICE.Size = new System.Drawing.Size(65, 23);
            this.nmbUNIT_PRICE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbUNIT_PRICE.TabIndex = 304;
            this.nmbUNIT_PRICE.Text = "0";
            this.nmbUNIT_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbUNIT_PRICE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbUNIT_PRICE.W_Clear = true;
            this.nmbUNIT_PRICE.W_ColArName = "";
            this.nmbUNIT_PRICE.W_ColEgName = "";
            this.nmbUNIT_PRICE.W_OldValue = "";
            this.nmbUNIT_PRICE.W_TableName = "";
            // 
            // myLabel25
            // 
            this.myLabel25.BackColor = System.Drawing.Color.Transparent;
            this.myLabel25.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel25.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel25.ForeColor = System.Drawing.Color.Black;
            this.myLabel25.Location = new System.Drawing.Point(253, 128);
            this.myLabel25.Name = "myLabel25";
            this.myLabel25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel25.Size = new System.Drawing.Size(65, 18);
            this.myLabel25.TabIndex = 303;
            this.myLabel25.Text = "سعر الوحدة";
            // 
            // nmbFREE_QTY
            // 
            this.nmbFREE_QTY.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbFREE_QTY.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.nmbFREE_QTY.DecimalPlaces = 0;
            this.nmbFREE_QTY.DoubleValue = 0D;
            this.nmbFREE_QTY.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbFREE_QTY.Location = new System.Drawing.Point(182, 154);
            this.nmbFREE_QTY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbFREE_QTY.MinValue = 0D;
            this.nmbFREE_QTY.Name = "nmbFREE_QTY";
            this.nmbFREE_QTY.NullString = "";
            this.nmbFREE_QTY.NumberDecimalDigits = 0;
            this.nmbFREE_QTY.Size = new System.Drawing.Size(65, 23);
            this.nmbFREE_QTY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbFREE_QTY.TabIndex = 302;
            this.nmbFREE_QTY.Text = "0";
            this.nmbFREE_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbFREE_QTY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbFREE_QTY.W_Clear = true;
            this.nmbFREE_QTY.W_ColArName = "";
            this.nmbFREE_QTY.W_ColEgName = "";
            this.nmbFREE_QTY.W_OldValue = "";
            this.nmbFREE_QTY.W_TableName = "";
            // 
            // myLabel24
            // 
            this.myLabel24.BackColor = System.Drawing.Color.Transparent;
            this.myLabel24.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel24.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel24.ForeColor = System.Drawing.Color.Black;
            this.myLabel24.Location = new System.Drawing.Point(253, 156);
            this.myLabel24.Name = "myLabel24";
            this.myLabel24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel24.Size = new System.Drawing.Size(65, 18);
            this.myLabel24.TabIndex = 300;
            this.myLabel24.Text = "كمية مجانية";
            // 
            // nmbREQUESTED_QTY
            // 
            this.nmbREQUESTED_QTY.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbREQUESTED_QTY.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.nmbREQUESTED_QTY.DecimalPlaces = 0;
            this.nmbREQUESTED_QTY.DoubleValue = 0D;
            this.nmbREQUESTED_QTY.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbREQUESTED_QTY.Location = new System.Drawing.Point(324, 154);
            this.nmbREQUESTED_QTY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbREQUESTED_QTY.MinValue = 0D;
            this.nmbREQUESTED_QTY.Name = "nmbREQUESTED_QTY";
            this.nmbREQUESTED_QTY.NullString = "";
            this.nmbREQUESTED_QTY.NumberDecimalDigits = 0;
            this.nmbREQUESTED_QTY.Size = new System.Drawing.Size(80, 23);
            this.nmbREQUESTED_QTY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbREQUESTED_QTY.TabIndex = 297;
            this.nmbREQUESTED_QTY.Text = "0";
            this.nmbREQUESTED_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbREQUESTED_QTY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbREQUESTED_QTY.W_Clear = true;
            this.nmbREQUESTED_QTY.W_ColArName = "";
            this.nmbREQUESTED_QTY.W_ColEgName = "";
            this.nmbREQUESTED_QTY.W_OldValue = "";
            this.nmbREQUESTED_QTY.W_TableName = "";
            // 
            // myLabel19
            // 
            this.myLabel19.BackColor = System.Drawing.Color.Transparent;
            this.myLabel19.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel19.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel19.ForeColor = System.Drawing.Color.Black;
            this.myLabel19.Location = new System.Drawing.Point(410, 159);
            this.myLabel19.Name = "myLabel19";
            this.myLabel19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel19.Size = new System.Drawing.Size(84, 18);
            this.myLabel19.TabIndex = 296;
            this.myLabel19.Text = "الكمية المطلوبة";
            // 
            // myLabel18
            // 
            this.myLabel18.BackColor = System.Drawing.Color.Transparent;
            this.myLabel18.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel18.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel18.ForeColor = System.Drawing.Color.Black;
            this.myLabel18.Location = new System.Drawing.Point(415, 131);
            this.myLabel18.Name = "myLabel18";
            this.myLabel18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel18.Size = new System.Drawing.Size(75, 18);
            this.myLabel18.TabIndex = 279;
            this.myLabel18.Text = "الكمية الحالية";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(33, 23);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.Image = global::ERP.Properties.Resources.Add_h;
            this.btnAdd.IsBackStageButton = false;
            this.btnAdd.Location = new System.Drawing.Point(129, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 23);
            this.btnAdd.TabIndex = 296;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetExpenss
            // 
            this.btnGetExpenss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetExpenss.BackgroundImage")));
            this.btnGetExpenss.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetExpenss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetExpenss.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetExpenss.FlatAppearance.BorderSize = 0;
            this.btnGetExpenss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetExpenss.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetExpenss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetExpenss.Image = ((System.Drawing.Image)(resources.GetObject("btnGetExpenss.Image")));
            this.btnGetExpenss.IsBackStageButton = false;
            this.btnGetExpenss.Location = new System.Drawing.Point(694, 179);
            this.btnGetExpenss.Name = "btnGetExpenss";
            this.btnGetExpenss.Size = new System.Drawing.Size(28, 27);
            this.btnGetExpenss.TabIndex = 395;
            this.btnGetExpenss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetExpenss.UseVisualStyleBackColor = true;
            this.btnGetExpenss.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetExpenss.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetExpenss.Click += new System.EventHandler(this.btnGetExpenss_Click);
            // 
            // myBottun6
            // 
            this.myBottun6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myBottun6.BackgroundImage")));
            this.myBottun6.BeforeTouchSize = new System.Drawing.Size(33, 23);
            this.myBottun6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myBottun6.FlatAppearance.BorderSize = 0;
            this.myBottun6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBottun6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.myBottun6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myBottun6.Image = global::ERP.Properties.Resources.Add_h;
            this.myBottun6.IsBackStageButton = false;
            this.myBottun6.Location = new System.Drawing.Point(862, 182);
            this.myBottun6.Name = "myBottun6";
            this.myBottun6.Size = new System.Drawing.Size(33, 23);
            this.myBottun6.TabIndex = 401;
            this.myBottun6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun6.UseVisualStyleBackColor = true;
            this.myBottun6.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun6.w_Type = ERP.myBottun.Btton_type.none;
            this.myBottun6.Click += new System.EventHandler(this.myBottun6_Click);
            // 
            // nmbExpenssItem
            // 
            this.nmbExpenssItem.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbExpenssItem.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.nmbExpenssItem.DecimalPlaces = 0;
            this.nmbExpenssItem.DoubleValue = 0D;
            this.nmbExpenssItem.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbExpenssItem.Location = new System.Drawing.Point(761, 182);
            this.nmbExpenssItem.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbExpenssItem.MinValue = 0D;
            this.nmbExpenssItem.Name = "nmbExpenssItem";
            this.nmbExpenssItem.NullString = "";
            this.nmbExpenssItem.NumberDecimalDigits = 0;
            this.nmbExpenssItem.Size = new System.Drawing.Size(100, 23);
            this.nmbExpenssItem.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbExpenssItem.TabIndex = 396;
            this.nmbExpenssItem.Text = "0";
            this.nmbExpenssItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbExpenssItem.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbExpenssItem.W_Clear = true;
            this.nmbExpenssItem.W_ColArName = "";
            this.nmbExpenssItem.W_ColEgName = "";
            this.nmbExpenssItem.W_OldValue = "";
            this.nmbExpenssItem.W_TableName = "";
            // 
            // myLabel26
            // 
            this.myLabel26.AutoSize = false;
            this.myLabel26.BackColor = System.Drawing.Color.Transparent;
            this.myLabel26.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel26.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel26.ForeColor = System.Drawing.Color.Black;
            this.myLabel26.Location = new System.Drawing.Point(722, 184);
            this.myLabel26.Name = "myLabel26";
            this.myLabel26.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel26.Size = new System.Drawing.Size(44, 18);
            this.myLabel26.TabIndex = 400;
            this.myLabel26.Text = "المبلغ";
            // 
            // txtEXPENSES_Name
            // 
            this.txtEXPENSES_Name.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtEXPENSES_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEXPENSES_Name.Enabled = false;
            this.txtEXPENSES_Name.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEXPENSES_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtEXPENSES_Name.Location = new System.Drawing.Point(577, 182);
            this.txtEXPENSES_Name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEXPENSES_Name.Name = "txtEXPENSES_Name";
            this.txtEXPENSES_Name.Size = new System.Drawing.Size(115, 23);
            this.txtEXPENSES_Name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEXPENSES_Name.TabIndex = 399;
            this.txtEXPENSES_Name.W_Clear = true;
            this.txtEXPENSES_Name.W_ColArName = "الباركود";
            this.txtEXPENSES_Name.W_ColEgName = "BARCODE";
            this.txtEXPENSES_Name.W_OldValue = "";
            this.txtEXPENSES_Name.W_TableName = "BENEFICIARY";
            // 
            // myLabel27
            // 
            this.myLabel27.AutoSize = false;
            this.myLabel27.BackColor = System.Drawing.Color.Transparent;
            this.myLabel27.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel27.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel27.ForeColor = System.Drawing.Color.Black;
            this.myLabel27.Location = new System.Drawing.Point(517, 185);
            this.myLabel27.Name = "myLabel27";
            this.myLabel27.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel27.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel27.Size = new System.Drawing.Size(67, 18);
            this.myLabel27.TabIndex = 398;
            this.myLabel27.Text = "المصروف";
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.IsBackStageButton = false;
            this.btnNew.Location = new System.Drawing.Point(305, 631);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 406;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.IsBackStageButton = false;
            this.btnUpdate.Location = new System.Drawing.Point(62, 631);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 405;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.IsBackStageButton = false;
            this.btnExit.Location = new System.Drawing.Point(119, 631);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 404;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(5, 631);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 403;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEXPENSES_ID
            // 
            this.txtEXPENSES_ID.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtEXPENSES_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEXPENSES_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEXPENSES_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtEXPENSES_ID.Location = new System.Drawing.Point(604, 179);
            this.txtEXPENSES_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEXPENSES_ID.Name = "txtEXPENSES_ID";
            this.txtEXPENSES_ID.Size = new System.Drawing.Size(38, 23);
            this.txtEXPENSES_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEXPENSES_ID.TabIndex = 412;
            this.txtEXPENSES_ID.Visible = false;
            this.txtEXPENSES_ID.W_Clear = true;
            this.txtEXPENSES_ID.W_ColArName = "";
            this.txtEXPENSES_ID.W_ColEgName = "";
            this.txtEXPENSES_ID.W_OldValue = "";
            this.txtEXPENSES_ID.W_TableName = "";
            // 
            // nmbTotal
            // 
            this.nmbTotal.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbTotal.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.nmbTotal.DecimalPlaces = 0;
            this.nmbTotal.DoubleValue = 0D;
            this.nmbTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbTotal.Location = new System.Drawing.Point(795, 636);
            this.nmbTotal.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbTotal.MinValue = 0D;
            this.nmbTotal.Name = "nmbTotal";
            this.nmbTotal.NullString = "";
            this.nmbTotal.NumberDecimalDigits = 0;
            this.nmbTotal.Size = new System.Drawing.Size(100, 23);
            this.nmbTotal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbTotal.TabIndex = 413;
            this.nmbTotal.Text = "0";
            this.nmbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbTotal.W_Clear = true;
            this.nmbTotal.W_ColArName = "";
            this.nmbTotal.W_ColEgName = "";
            this.nmbTotal.W_OldValue = "";
            this.nmbTotal.W_TableName = "";
            // 
            // dgvPurQuotDetail
            // 
            this.dgvPurQuotDetail.AllowUserToAddRows = false;
            this.dgvPurQuotDetail.AllowUserToDeleteRows = false;
            this.dgvPurQuotDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurQuotDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurQuotDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurQuotDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.clmItemSwid,
            this.clmItemName,
            this.Column19,
            this.Column8,
            this.clmDetailSuppItmName,
            this.Column10,
            this.clmDetailQty,
            this.clmDetailFreeQty,
            this.clmDetailUnitPrice,
            this.clmCurrQty,
            this.clmDetailTotal,
            this.Column22});
            this.dgvPurQuotDetail.EnableHeadersVisualStyles = false;
            this.dgvPurQuotDetail.Location = new System.Drawing.Point(6, 369);
            this.dgvPurQuotDetail.Name = "dgvPurQuotDetail";
            this.dgvPurQuotDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPurQuotDetail.RowHeadersVisible = false;
            this.dgvPurQuotDetail.Size = new System.Drawing.Size(888, 256);
            this.dgvPurQuotDetail.TabIndex = 414;
            this.dgvPurQuotDetail.W_Clear = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SWID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // clmItemSwid
            // 
            this.clmItemSwid.HeaderText = "ITEM_ID";
            this.clmItemSwid.Name = "clmItemSwid";
            this.clmItemSwid.ReadOnly = true;
            this.clmItemSwid.Visible = false;
            // 
            // clmItemName
            // 
            this.clmItemName.HeaderText = "اسم الصنف";
            this.clmItemName.Name = "clmItemName";
            this.clmItemName.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Item_supplier_id";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "رقم الصنف م";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // clmDetailSuppItmName
            // 
            this.clmDetailSuppItmName.HeaderText = "اسم الصنف م";
            this.clmDetailSuppItmName.Name = "clmDetailSuppItmName";
            this.clmDetailSuppItmName.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "معلومات الصنف";
            this.Column10.Name = "Column10";
            // 
            // clmDetailQty
            // 
            this.clmDetailQty.HeaderText = "الكمية المطلوبة";
            this.clmDetailQty.Name = "clmDetailQty";
            this.clmDetailQty.ReadOnly = true;
            // 
            // clmDetailFreeQty
            // 
            this.clmDetailFreeQty.HeaderText = "كمية مجانية";
            this.clmDetailFreeQty.Name = "clmDetailFreeQty";
            this.clmDetailFreeQty.ReadOnly = true;
            // 
            // clmDetailUnitPrice
            // 
            this.clmDetailUnitPrice.HeaderText = "سعر الوحدة";
            this.clmDetailUnitPrice.Name = "clmDetailUnitPrice";
            this.clmDetailUnitPrice.ReadOnly = true;
            // 
            // clmCurrQty
            // 
            this.clmCurrQty.HeaderText = "الكمية الحالية";
            this.clmCurrQty.Name = "clmCurrQty";
            this.clmCurrQty.ReadOnly = true;
            this.clmCurrQty.Visible = false;
            // 
            // clmDetailTotal
            // 
            this.clmDetailTotal.HeaderText = "المجموع";
            this.clmDetailTotal.Name = "clmDetailTotal";
            this.clmDetailTotal.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "حذف";
            this.Column22.Image = global::ERP.Properties.Resources.GridDelete;
            this.Column22.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Width = 40;
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // nmbExpEditor
            // 
            this.nmbExpEditor.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbExpEditor.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.nmbExpEditor.DecimalPlaces = 0;
            this.nmbExpEditor.DoubleValue = 0D;
            this.nmbExpEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbExpEditor.Location = new System.Drawing.Point(636, 272);
            this.nmbExpEditor.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbExpEditor.MinValue = 0D;
            this.nmbExpEditor.Name = "nmbExpEditor";
            this.nmbExpEditor.NullString = "";
            this.nmbExpEditor.NumberDecimalDigits = 0;
            this.nmbExpEditor.Size = new System.Drawing.Size(121, 23);
            this.nmbExpEditor.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbExpEditor.TabIndex = 416;
            this.nmbExpEditor.Text = "0";
            this.nmbExpEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbExpEditor.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbExpEditor.Visible = false;
            this.nmbExpEditor.W_Clear = true;
            this.nmbExpEditor.W_ColArName = "";
            this.nmbExpEditor.W_ColEgName = "";
            this.nmbExpEditor.W_OldValue = "";
            this.nmbExpEditor.W_TableName = "";
            this.nmbExpEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbExpEditor_KeyDown);
            this.nmbExpEditor.Leave += new System.EventHandler(this.nmbExpEditor_Leave);
            // 
            // dgExpenss
            // 
            this.dgExpenss.AllowUserToAddRows = false;
            this.dgExpenss.AllowUserToDeleteRows = false;
            this.dgExpenss.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgExpenss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgExpenss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExpenss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmExpSwid,
            this.clmExpExpenssItemId,
            this.clmExpName,
            this.clmExpValue,
            this.clmExpDeleteBtn});
            this.dgExpenss.EnableHeadersVisualStyles = false;
            this.dgExpenss.Location = new System.Drawing.Point(517, 209);
            this.dgExpenss.Name = "dgExpenss";
            this.dgExpenss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgExpenss.RowHeadersVisible = false;
            this.dgExpenss.Size = new System.Drawing.Size(377, 155);
            this.dgExpenss.TabIndex = 415;
            this.dgExpenss.W_Clear = true;
            this.dgExpenss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExpenss_CellClick);
            // 
            // clmExpSwid
            // 
            this.clmExpSwid.HeaderText = "swid";
            this.clmExpSwid.Name = "clmExpSwid";
            this.clmExpSwid.ReadOnly = true;
            this.clmExpSwid.Visible = false;
            // 
            // clmExpExpenssItemId
            // 
            this.clmExpExpenssItemId.HeaderText = "EXPENSES_ID";
            this.clmExpExpenssItemId.Name = "clmExpExpenssItemId";
            this.clmExpExpenssItemId.ReadOnly = true;
            this.clmExpExpenssItemId.Visible = false;
            // 
            // clmExpName
            // 
            this.clmExpName.HeaderText = "اسم المصروف";
            this.clmExpName.Name = "clmExpName";
            this.clmExpName.ReadOnly = true;
            this.clmExpName.Width = 200;
            // 
            // clmExpValue
            // 
            this.clmExpValue.HeaderText = "المبلغ";
            this.clmExpValue.Name = "clmExpValue";
            this.clmExpValue.ReadOnly = true;
            // 
            // clmExpDeleteBtn
            // 
            this.clmExpDeleteBtn.HeaderText = "حذف";
            this.clmExpDeleteBtn.Image = global::ERP.Properties.Resources.S43Qy;
            this.clmExpDeleteBtn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmExpDeleteBtn.Name = "clmExpDeleteBtn";
            this.clmExpDeleteBtn.Width = 40;
            // 
            // lstTempBranch
            // 
            this.lstTempBranch.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.lstTempBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTempBranch.Font = new System.Drawing.Font("Arial", 10F);
            this.lstTempBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstTempBranch.Location = new System.Drawing.Point(493, 636);
            this.lstTempBranch.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.lstTempBranch.Name = "lstTempBranch";
            this.lstTempBranch.Size = new System.Drawing.Size(14, 23);
            this.lstTempBranch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.lstTempBranch.TabIndex = 417;
            this.lstTempBranch.Visible = false;
            this.lstTempBranch.W_Clear = false;
            this.lstTempBranch.W_ColArName = "";
            this.lstTempBranch.W_ColEgName = "";
            this.lstTempBranch.W_OldValue = "";
            this.lstTempBranch.W_TableName = "";
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 669);
            this.Controls.Add(this.lstTempBranch);
            this.Controls.Add(this.nmbExpEditor);
            this.Controls.Add(this.dgExpenss);
            this.Controls.Add(this.dgvPurQuotDetail);
            this.Controls.Add(this.nmbTotal);
            this.Controls.Add(this.txtEXPENSES_ID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGetExpenss);
            this.Controls.Add(this.myBottun6);
            this.Controls.Add(this.nmbExpenssItem);
            this.Controls.Add(this.myLabel26);
            this.Controls.Add(this.txtEXPENSES_Name);
            this.Controls.Add(this.myLabel27);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.myGroupBox1);
            this.Name = "frmPurchaseOrder";
            this.Text = "frmPurchaseOrder";
            this.Titel = "أوامر الشراء";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.gbItems, 0);
            this.Controls.SetChildIndex(this.myLabel27, 0);
            this.Controls.SetChildIndex(this.txtEXPENSES_Name, 0);
            this.Controls.SetChildIndex(this.myLabel26, 0);
            this.Controls.SetChildIndex(this.nmbExpenssItem, 0);
            this.Controls.SetChildIndex(this.myBottun6, 0);
            this.Controls.SetChildIndex(this.btnGetExpenss, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.txtEXPENSES_ID, 0);
            this.Controls.SetChildIndex(this.nmbTotal, 0);
            this.Controls.SetChildIndex(this.dgvPurQuotDetail, 0);
            this.Controls.SetChildIndex(this.dgExpenss, 0);
            this.Controls.SetChildIndex(this.nmbExpEditor, 0);
            this.Controls.SetChildIndex(this.lstTempBranch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPORT_OF_LOADING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPORT_OF_DELIVERY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPAYMENT_AGREEMENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPROFORMA_INVOICE_NUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPURCHASE_ORDER_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPROFORMA_INVOICE_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPURCHASE_ORDER_NUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPURCHASE_QUOTATIONS_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPURCHASE_QUOTATIONS_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURRENCY_EXCHANGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTERMS_EXPENSES_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTERMS_OF_EXPENSES_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUPPLIER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUPPLIER_Name)).EndInit();
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURRENT_STOCK_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemNo)).EndInit();
            this.myGroupBox2.ResumeLayout(false);
            this.myGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_SUPPLIER_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_INFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_SUPPLIER_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_SUPPLIER_NUMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUNIT_PRICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbFREE_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbREQUESTED_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpenssItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurQuotDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTempBranch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myGroupBox myGroupBox1;
        private myText txtSwid;
        private myText txtSUPPLIER_Name;
        private myBottun btnGetVendor;
        private myLabel myLabel8;
        private myText txtSUPPLIER_ID;
        private myLabel myLabel9;
        private myLabel myLabel7;
        private myLabel myLabel6;
        private myLabel myLabel5;
        private myLabel myLabel4;
        private myLabel myLabel3;
        private myLabel myLabel2;
        private myLabel myLabel15;
        private myLabel myLabel14;
        private myLabel myLabel12;
        private myLabel myLabel11;
        private myLabel myLabel10;
        private myText txtTERMS_EXPENSES_ID;
        private myText txtTERMS_OF_EXPENSES_name;
        private myBottun btnGetExpenssTerm;
        private myText txtPURCHASE_ORDER_NUM;
        private myBottun btnGetPurchaseOrder;
        private myText txtPURCHASE_QUOTATIONS_ID;
        private myText txtPURCHASE_QUOTATIONS_No;
        private myBottun btnGetQuotation;
        private myNumber nmbCURRENCY_EXCHANGE;
        private myDate dtpPURCHASE_ORDER_DATE;
        private myDate dtpPROFORMA_INVOICE_DATE;
        private myText txtPORT_OF_LOADING;
        private myText txtPORT_OF_DELIVERY;
        private myText txtPAYMENT_AGREEMENT;
        private myText txtPROFORMA_INVOICE_NUM;
        private myList lstCURRENCY_ID;
        private myList lstSHIPPING_Way;
        private myGroupBox gbItems;
        private myNumber nmbUNIT_PRICE;
        private myLabel myLabel25;
        private myNumber nmbFREE_QTY;
        private myLabel myLabel24;
        private myNumber nmbREQUESTED_QTY;
        private myLabel myLabel19;
        private myLabel myLabel18;
        private myBottun btnAdd;
        private myBottun btnGetExpenss;
        private myBottun myBottun6;
        private myNumber nmbExpenssItem;
        private myLabel myLabel26;
        private myText txtEXPENSES_Name;
        private myLabel myLabel27;
        private myBottun btnNew;
        private myBottun btnUpdate;
        private myBottun btnExit;
        private myBottun btnSave;
        private myGroupBox myGroupBox2;
        private myBottun btnGetSupplierItem;
        private myText txtITEM_SUPPLIER_Id;
        private myText txtITEM_INFO;
        private myLabel myLabel22;
        private myText txtITEM_SUPPLIER_NAME;
        private myLabel myLabel13;
        private myLabel myLabel16;
        private myText txtITEM_SUPPLIER_NUMBER;
        private myText txtItemId;
        private myText txtItemName;
        private myLabel myLabel17;
        private myLabel myLabel20;
        private myText txtItemNo;
        private myBottun btnFindItem;
        private myText txtEXPENSES_ID;
        private myNumber nmbTotal;
        private myDataGrid dgvPurQuotDetail;
        private System.Windows.Forms.ErrorProvider errCheck;
        private myBottun btnAddExpeness;
        private myLabel myLabel23;
        private myNumber nmbExpEditor;
        private myDataGrid dgExpenss;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpExpenssItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpValue;
        private System.Windows.Forms.DataGridViewImageColumn clmExpDeleteBtn;
        private myNumber nmbCURRENT_STOCK_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetailSuppItmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetailQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetailFreeQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetailUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetailTotal;
        private System.Windows.Forms.DataGridViewImageColumn Column22;
        private myList lstBranchHeader;
        private myLabel myLabel29;
        private myText lstTempBranch;
    }
}