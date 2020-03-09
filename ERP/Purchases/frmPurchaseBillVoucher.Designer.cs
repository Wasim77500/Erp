namespace ERP.Purchases
{
    partial class frmPurchaseBillVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseBillVoucher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFindBillPurchase = new ERP.myBottun();
            this.txtBILL_NUMBER = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.dgExpenss = new ERP.myDataGrid();
            this.clmSelectedExpCkb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmExpSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpExpenssItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbInvoicTotal = new ERP.myNumber();
            this.myLabel3 = new ERP.myLabel();
            this.lstCURRENCY_ID = new ERP.myList();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel9 = new ERP.myLabel();
            this.lstBILL_TYPE = new ERP.myList();
            this.myLabel4 = new ERP.myLabel();
            this.btnConfirm = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.txtSwid = new ERP.myText();
            this.myLabel5 = new ERP.myLabel();
            this.nmbTotalWithExp = new ERP.myNumber();
            this.myLabel7 = new ERP.myLabel();
            this.txtSUPPLIER_ID = new ERP.myText();
            this.txtSUPPLIER_Name = new ERP.myText();
            this.myText1 = new ERP.myText();
            this.nmbTotalExp = new ERP.myNumber();
            this.myLabel8 = new ERP.myLabel();
            this.lstAccNo = new ERP.myList();
            this.lblAccNo = new ERP.myLabel();
            this.lstAccName = new ERP.myList();
            this.lblAccName = new ERP.myLabel();
            this.myLabel10 = new ERP.myLabel();
            this.nmbCURRENCY_EXCHANGE = new System.Windows.Forms.NumericUpDown();
            this.nmbInternalExp = new ERP.myNumber();
            this.myLabel11 = new ERP.myLabel();
            this.myLabel12 = new ERP.myLabel();
            this.nmbTotalInvoiceInStockCurr = new System.Windows.Forms.NumericUpDown();
            this.nmbTotalInvoiceInMainCurr = new System.Windows.Forms.NumericUpDown();
            this.nmbTotalInvoiceInInvoiceCurr = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBILL_NUMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbInvoicTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalWithExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUPPLIER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUPPLIER_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURRENCY_EXCHANGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbInternalExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInStockCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInMainCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInInvoiceCurr)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(227, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(140, 34);
            // 
            // btnFindBillPurchase
            // 
            this.btnFindBillPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindBillPurchase.BackgroundImage")));
            this.btnFindBillPurchase.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFindBillPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindBillPurchase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindBillPurchase.FlatAppearance.BorderSize = 0;
            this.btnFindBillPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBillPurchase.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFindBillPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindBillPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnFindBillPurchase.Image")));
            this.btnFindBillPurchase.IsBackStageButton = false;
            this.btnFindBillPurchase.Location = new System.Drawing.Point(257, 65);
            this.btnFindBillPurchase.Name = "btnFindBillPurchase";
            this.btnFindBillPurchase.Size = new System.Drawing.Size(28, 27);
            this.btnFindBillPurchase.TabIndex = 426;
            this.btnFindBillPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindBillPurchase.UseVisualStyleBackColor = true;
            this.btnFindBillPurchase.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFindBillPurchase.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFindBillPurchase.Click += new System.EventHandler(this.btnFindBillPurchase_Click);
            // 
            // txtBILL_NUMBER
            // 
            this.txtBILL_NUMBER.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.txtBILL_NUMBER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBILL_NUMBER.Enabled = false;
            this.txtBILL_NUMBER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBILL_NUMBER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtBILL_NUMBER.Location = new System.Drawing.Point(94, 68);
            this.txtBILL_NUMBER.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBILL_NUMBER.Name = "txtBILL_NUMBER";
            this.txtBILL_NUMBER.Size = new System.Drawing.Size(162, 23);
            this.txtBILL_NUMBER.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBILL_NUMBER.TabIndex = 425;
            this.txtBILL_NUMBER.W_Clear = true;
            this.txtBILL_NUMBER.W_ColArName = "الباركود";
            this.txtBILL_NUMBER.W_ColEgName = "BARCODE";
            this.txtBILL_NUMBER.W_OldValue = "";
            this.txtBILL_NUMBER.W_TableName = "BENEFICIARY";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(14, 70);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(67, 18);
            this.myLabel2.TabIndex = 424;
            this.myLabel2.Text = "رقم الفاتورة";
            // 
            // dgExpenss
            // 
            this.dgExpenss.AllowUserToAddRows = false;
            this.dgExpenss.AllowUserToDeleteRows = false;
            this.dgExpenss.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgExpenss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgExpenss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExpenss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSelectedExpCkb,
            this.clmExpSwid,
            this.clmExpExpenssItemId,
            this.clmExpName,
            this.clmExpValue,
            this.clmAccId});
            this.dgExpenss.EnableHeadersVisualStyles = false;
            this.dgExpenss.Location = new System.Drawing.Point(285, 65);
            this.dgExpenss.Name = "dgExpenss";
            this.dgExpenss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgExpenss.RowHeadersVisible = false;
            this.dgExpenss.Size = new System.Drawing.Size(334, 325);
            this.dgExpenss.TabIndex = 431;
            this.dgExpenss.W_Clear = true;
            this.dgExpenss.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExpenss_CellValueChanged);
            this.dgExpenss.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgExpenss_CurrentCellDirtyStateChanged);
            // 
            // clmSelectedExpCkb
            // 
            this.clmSelectedExpCkb.HeaderText = "تحديد";
            this.clmSelectedExpCkb.Name = "clmSelectedExpCkb";
            this.clmSelectedExpCkb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmSelectedExpCkb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmSelectedExpCkb.Width = 50;
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
            this.clmExpName.Width = 180;
            // 
            // clmExpValue
            // 
            this.clmExpValue.HeaderText = "المبلغ";
            this.clmExpValue.Name = "clmExpValue";
            this.clmExpValue.ReadOnly = true;
            this.clmExpValue.Width = 95;
            // 
            // clmAccId
            // 
            this.clmAccId.HeaderText = "acc_id";
            this.clmAccId.Name = "clmAccId";
            this.clmAccId.ReadOnly = true;
            this.clmAccId.Visible = false;
            // 
            // nmbInvoicTotal
            // 
            this.nmbInvoicTotal.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbInvoicTotal.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.nmbInvoicTotal.DecimalPlaces = 0;
            this.nmbInvoicTotal.DoubleValue = 0D;
            this.nmbInvoicTotal.Enabled = false;
            this.nmbInvoicTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbInvoicTotal.Location = new System.Drawing.Point(94, 203);
            this.nmbInvoicTotal.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbInvoicTotal.MinValue = 0D;
            this.nmbInvoicTotal.Name = "nmbInvoicTotal";
            this.nmbInvoicTotal.NullString = "";
            this.nmbInvoicTotal.NumberDecimalDigits = 0;
            this.nmbInvoicTotal.Size = new System.Drawing.Size(185, 23);
            this.nmbInvoicTotal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbInvoicTotal.TabIndex = 432;
            this.nmbInvoicTotal.Text = "0";
            this.nmbInvoicTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbInvoicTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbInvoicTotal.W_Clear = true;
            this.nmbInvoicTotal.W_ColArName = "";
            this.nmbInvoicTotal.W_ColEgName = "";
            this.nmbInvoicTotal.W_OldValue = "";
            this.nmbInvoicTotal.W_TableName = "";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(16, 206);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(72, 18);
            this.myLabel3.TabIndex = 433;
            this.myLabel3.Text = "مبلغ الفاتورة";
            // 
            // lstCURRENCY_ID
            // 
            this.lstCURRENCY_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCURRENCY_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCURRENCY_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCURRENCY_ID.Enabled = false;
            this.lstCURRENCY_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCURRENCY_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCURRENCY_ID.FormattingEnabled = true;
            this.lstCURRENCY_ID.Location = new System.Drawing.Point(94, 121);
            this.lstCURRENCY_ID.Name = "lstCURRENCY_ID";
            this.lstCURRENCY_ID.Size = new System.Drawing.Size(185, 24);
            this.lstCURRENCY_ID.TabIndex = 435;
            this.lstCURRENCY_ID.W_Clear = true;
            this.lstCURRENCY_ID.W_ColArName = "";
            this.lstCURRENCY_ID.W_ColEgName = "";
            this.lstCURRENCY_ID.W_OldValue = "";
            this.lstCURRENCY_ID.W_TableName = "";
            this.lstCURRENCY_ID.w_ValueType = ERP.myList.ValueType.VALUE;
            this.lstCURRENCY_ID.SelectedIndexChanged += new System.EventHandler(this.lstCURRENCY_ID_SelectedIndexChanged);
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(32, 125);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(37, 18);
            this.myLabel6.TabIndex = 434;
            this.myLabel6.Text = "العملة";
            // 
            // myLabel9
            // 
            this.myLabel9.AutoSize = false;
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(9, 150);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel9.Size = new System.Drawing.Size(77, 18);
            this.myLabel9.TabIndex = 436;
            this.myLabel9.Text = "سعر الصرف";
            // 
            // lstBILL_TYPE
            // 
            this.lstBILL_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBILL_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBILL_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBILL_TYPE.Enabled = false;
            this.lstBILL_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBILL_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstBILL_TYPE.FormattingEnabled = true;
            this.lstBILL_TYPE.Items.AddRange(new object[] {
            "نقد",
            "اجل"});
            this.lstBILL_TYPE.Location = new System.Drawing.Point(94, 94);
            this.lstBILL_TYPE.Name = "lstBILL_TYPE";
            this.lstBILL_TYPE.Size = new System.Drawing.Size(185, 24);
            this.lstBILL_TYPE.TabIndex = 439;
            this.lstBILL_TYPE.W_Clear = true;
            this.lstBILL_TYPE.W_ColArName = "";
            this.lstBILL_TYPE.W_ColEgName = "";
            this.lstBILL_TYPE.W_OldValue = "";
            this.lstBILL_TYPE.W_TableName = "";
            this.lstBILL_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstBILL_TYPE.SelectedIndexChanged += new System.EventHandler(this.lstBILL_TYPE_SelectedIndexChanged);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(14, 100);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(77, 18);
            this.myLabel4.TabIndex = 438;
            this.myLabel4.Text = "نوع الفاتورة";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.IsBackStageButton = false;
            this.btnConfirm.Location = new System.Drawing.Point(164, 385);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(57, 28);
            this.btnConfirm.TabIndex = 440;
            this.btnConfirm.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnConfirm.w_Type = ERP.myBottun.Btton_type.OK;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.btnExit.Location = new System.Drawing.Point(222, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 441;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // txtSwid
            // 
            this.txtSwid.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.txtSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSwid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSwid.Location = new System.Drawing.Point(50, 35);
            this.txtSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSwid.Name = "txtSwid";
            this.txtSwid.Size = new System.Drawing.Size(38, 23);
            this.txtSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSwid.TabIndex = 442;
            this.txtSwid.Visible = false;
            this.txtSwid.W_Clear = true;
            this.txtSwid.W_ColArName = "";
            this.txtSwid.W_ColEgName = "";
            this.txtSwid.W_OldValue = "";
            this.txtSwid.W_TableName = "";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(23, 255);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(50, 18);
            this.myLabel5.TabIndex = 443;
            this.myLabel5.Text = "الاجمالي";
            // 
            // nmbTotalWithExp
            // 
            this.nmbTotalWithExp.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbTotalWithExp.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.nmbTotalWithExp.DecimalPlaces = 0;
            this.nmbTotalWithExp.DoubleValue = 0D;
            this.nmbTotalWithExp.Enabled = false;
            this.nmbTotalWithExp.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbTotalWithExp.Location = new System.Drawing.Point(94, 254);
            this.nmbTotalWithExp.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbTotalWithExp.MinValue = 0D;
            this.nmbTotalWithExp.Name = "nmbTotalWithExp";
            this.nmbTotalWithExp.NullString = "";
            this.nmbTotalWithExp.NumberDecimalDigits = 0;
            this.nmbTotalWithExp.Size = new System.Drawing.Size(185, 23);
            this.nmbTotalWithExp.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbTotalWithExp.TabIndex = 444;
            this.nmbTotalWithExp.Text = "0";
            this.nmbTotalWithExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbTotalWithExp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbTotalWithExp.W_Clear = true;
            this.nmbTotalWithExp.W_ColArName = "";
            this.nmbTotalWithExp.W_ColEgName = "";
            this.nmbTotalWithExp.W_OldValue = "";
            this.nmbTotalWithExp.W_TableName = "";
            // 
            // myLabel7
            // 
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(32, 179);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(40, 18);
            this.myLabel7.TabIndex = 445;
            this.myLabel7.Text = "المورد";
            // 
            // txtSUPPLIER_ID
            // 
            this.txtSUPPLIER_ID.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.txtSUPPLIER_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSUPPLIER_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSUPPLIER_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSUPPLIER_ID.Location = new System.Drawing.Point(148, 176);
            this.txtSUPPLIER_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSUPPLIER_ID.Name = "txtSUPPLIER_ID";
            this.txtSUPPLIER_ID.Size = new System.Drawing.Size(38, 23);
            this.txtSUPPLIER_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSUPPLIER_ID.TabIndex = 447;
            this.txtSUPPLIER_ID.Visible = false;
            this.txtSUPPLIER_ID.W_Clear = true;
            this.txtSUPPLIER_ID.W_ColArName = "";
            this.txtSUPPLIER_ID.W_ColEgName = "";
            this.txtSUPPLIER_ID.W_OldValue = "";
            this.txtSUPPLIER_ID.W_TableName = "";
            // 
            // txtSUPPLIER_Name
            // 
            this.txtSUPPLIER_Name.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.txtSUPPLIER_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSUPPLIER_Name.Enabled = false;
            this.txtSUPPLIER_Name.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSUPPLIER_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSUPPLIER_Name.Location = new System.Drawing.Point(94, 176);
            this.txtSUPPLIER_Name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSUPPLIER_Name.Name = "txtSUPPLIER_Name";
            this.txtSUPPLIER_Name.Size = new System.Drawing.Size(185, 23);
            this.txtSUPPLIER_Name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSUPPLIER_Name.TabIndex = 446;
            this.txtSUPPLIER_Name.W_Clear = true;
            this.txtSUPPLIER_Name.W_ColArName = "الباركود";
            this.txtSUPPLIER_Name.W_ColEgName = "BARCODE";
            this.txtSUPPLIER_Name.W_OldValue = "";
            this.txtSUPPLIER_Name.W_TableName = "BENEFICIARY";
            // 
            // myText1
            // 
            this.myText1.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.myText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myText1.Font = new System.Drawing.Font("Arial", 10F);
            this.myText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.myText1.Location = new System.Drawing.Point(94, 281);
            this.myText1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.myText1.Multiline = true;
            this.myText1.Name = "myText1";
            this.myText1.Size = new System.Drawing.Size(185, 45);
            this.myText1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.myText1.TabIndex = 448;
            this.myText1.W_Clear = true;
            this.myText1.W_ColArName = "الباركود";
            this.myText1.W_ColEgName = "BARCODE";
            this.myText1.W_OldValue = "";
            this.myText1.W_TableName = "BENEFICIARY";
            // 
            // nmbTotalExp
            // 
            this.nmbTotalExp.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbTotalExp.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.nmbTotalExp.DecimalPlaces = 0;
            this.nmbTotalExp.DoubleValue = 0D;
            this.nmbTotalExp.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbTotalExp.Location = new System.Drawing.Point(509, 392);
            this.nmbTotalExp.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbTotalExp.MinValue = 0D;
            this.nmbTotalExp.Name = "nmbTotalExp";
            this.nmbTotalExp.NullString = "";
            this.nmbTotalExp.NumberDecimalDigits = 0;
            this.nmbTotalExp.Size = new System.Drawing.Size(110, 23);
            this.nmbTotalExp.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbTotalExp.TabIndex = 449;
            this.nmbTotalExp.Text = "0";
            this.nmbTotalExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbTotalExp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbTotalExp.W_Clear = true;
            this.nmbTotalExp.W_ColArName = "";
            this.nmbTotalExp.W_ColEgName = "";
            this.nmbTotalExp.W_OldValue = "";
            this.nmbTotalExp.W_TableName = "";
            // 
            // myLabel8
            // 
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(21, 285);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel8.Size = new System.Drawing.Size(52, 18);
            this.myLabel8.TabIndex = 450;
            this.myLabel8.Text = "ملاحظات";
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(94, 329);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(185, 24);
            this.lstAccNo.TabIndex = 452;
            this.lstAccNo.W_Clear = true;
            this.lstAccNo.W_ColArName = "رقم الحساب";
            this.lstAccNo.W_ColEgName = "AccNo";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.W_TableName = "SERVICES";
            this.lstAccNo.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // lblAccNo
            // 
            this.lblAccNo.AutoSize = false;
            this.lblAccNo.BackColor = System.Drawing.Color.Transparent;
            this.lblAccNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAccNo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccNo.ForeColor = System.Drawing.Color.Black;
            this.lblAccNo.Location = new System.Drawing.Point(16, 332);
            this.lblAccNo.Name = "lblAccNo";
            this.lblAccNo.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.lblAccNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccNo.Size = new System.Drawing.Size(67, 18);
            this.lblAccNo.TabIndex = 451;
            this.lblAccNo.Text = "رقم الحساب";
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(94, 355);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(185, 24);
            this.lstAccName.TabIndex = 454;
            this.lstAccName.W_Clear = true;
            this.lstAccName.W_ColArName = "";
            this.lstAccName.W_ColEgName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.W_TableName = "";
            this.lstAccName.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = false;
            this.lblAccName.BackColor = System.Drawing.Color.Transparent;
            this.lblAccName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAccName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccName.ForeColor = System.Drawing.Color.Black;
            this.lblAccName.Location = new System.Drawing.Point(14, 359);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.lblAccName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccName.Size = new System.Drawing.Size(78, 18);
            this.lblAccName.TabIndex = 453;
            this.lblAccName.Text = "اسم الحساب";
            // 
            // myLabel10
            // 
            this.myLabel10.BackColor = System.Drawing.Color.Transparent;
            this.myLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel10.ForeColor = System.Drawing.Color.Black;
            this.myLabel10.Location = new System.Drawing.Point(359, 395);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel10.Size = new System.Drawing.Size(146, 18);
            this.myLabel10.TabIndex = 455;
            this.myLabel10.Text = "اجمالي المصاريف الخارجية";
            // 
            // nmbCURRENCY_EXCHANGE
            // 
            this.nmbCURRENCY_EXCHANGE.DecimalPlaces = 30;
            this.nmbCURRENCY_EXCHANGE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCURRENCY_EXCHANGE.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCURRENCY_EXCHANGE.Location = new System.Drawing.Point(94, 149);
            this.nmbCURRENCY_EXCHANGE.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nmbCURRENCY_EXCHANGE.Name = "nmbCURRENCY_EXCHANGE";
            this.nmbCURRENCY_EXCHANGE.ReadOnly = true;
            this.nmbCURRENCY_EXCHANGE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmbCURRENCY_EXCHANGE.Size = new System.Drawing.Size(185, 23);
            this.nmbCURRENCY_EXCHANGE.TabIndex = 456;
            // 
            // nmbInternalExp
            // 
            this.nmbInternalExp.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbInternalExp.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.nmbInternalExp.DecimalPlaces = 0;
            this.nmbInternalExp.DoubleValue = 0D;
            this.nmbInternalExp.Enabled = false;
            this.nmbInternalExp.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbInternalExp.Location = new System.Drawing.Point(94, 228);
            this.nmbInternalExp.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbInternalExp.MinValue = 0D;
            this.nmbInternalExp.Name = "nmbInternalExp";
            this.nmbInternalExp.NullString = "";
            this.nmbInternalExp.NumberDecimalDigits = 0;
            this.nmbInternalExp.Size = new System.Drawing.Size(185, 23);
            this.nmbInternalExp.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbInternalExp.TabIndex = 457;
            this.nmbInternalExp.Text = "0";
            this.nmbInternalExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbInternalExp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbInternalExp.W_Clear = true;
            this.nmbInternalExp.W_ColArName = "";
            this.nmbInternalExp.W_ColEgName = "";
            this.nmbInternalExp.W_OldValue = "";
            this.nmbInternalExp.W_TableName = "";
            // 
            // myLabel11
            // 
            this.myLabel11.BackColor = System.Drawing.Color.Transparent;
            this.myLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel11.ForeColor = System.Drawing.Color.Black;
            this.myLabel11.Location = new System.Drawing.Point(3, 231);
            this.myLabel11.Name = "myLabel11";
            this.myLabel11.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel11.Size = new System.Drawing.Size(86, 18);
            this.myLabel11.TabIndex = 458;
            this.myLabel11.Text = "مصاريف داخلية";
            // 
            // myLabel12
            // 
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(287, 44);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(265, 18);
            this.myLabel12.TabIndex = 459;
            this.myLabel12.Text = "الرجاء تحديد المصاريف المراد اخراجها من الفاتورة";
            // 
            // nmbTotalInvoiceInStockCurr
            // 
            this.nmbTotalInvoiceInStockCurr.DecimalPlaces = 30;
            this.nmbTotalInvoiceInStockCurr.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbTotalInvoiceInStockCurr.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbTotalInvoiceInStockCurr.Location = new System.Drawing.Point(454, 183);
            this.nmbTotalInvoiceInStockCurr.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nmbTotalInvoiceInStockCurr.Name = "nmbTotalInvoiceInStockCurr";
            this.nmbTotalInvoiceInStockCurr.ReadOnly = true;
            this.nmbTotalInvoiceInStockCurr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmbTotalInvoiceInStockCurr.Size = new System.Drawing.Size(91, 23);
            this.nmbTotalInvoiceInStockCurr.TabIndex = 462;
            this.nmbTotalInvoiceInStockCurr.Visible = false;
            // 
            // nmbTotalInvoiceInMainCurr
            // 
            this.nmbTotalInvoiceInMainCurr.DecimalPlaces = 30;
            this.nmbTotalInvoiceInMainCurr.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbTotalInvoiceInMainCurr.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbTotalInvoiceInMainCurr.Location = new System.Drawing.Point(454, 154);
            this.nmbTotalInvoiceInMainCurr.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nmbTotalInvoiceInMainCurr.Name = "nmbTotalInvoiceInMainCurr";
            this.nmbTotalInvoiceInMainCurr.ReadOnly = true;
            this.nmbTotalInvoiceInMainCurr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmbTotalInvoiceInMainCurr.Size = new System.Drawing.Size(91, 23);
            this.nmbTotalInvoiceInMainCurr.TabIndex = 461;
            this.nmbTotalInvoiceInMainCurr.Visible = false;
            // 
            // nmbTotalInvoiceInInvoiceCurr
            // 
            this.nmbTotalInvoiceInInvoiceCurr.DecimalPlaces = 30;
            this.nmbTotalInvoiceInInvoiceCurr.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbTotalInvoiceInInvoiceCurr.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbTotalInvoiceInInvoiceCurr.Location = new System.Drawing.Point(454, 125);
            this.nmbTotalInvoiceInInvoiceCurr.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nmbTotalInvoiceInInvoiceCurr.Name = "nmbTotalInvoiceInInvoiceCurr";
            this.nmbTotalInvoiceInInvoiceCurr.ReadOnly = true;
            this.nmbTotalInvoiceInInvoiceCurr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmbTotalInvoiceInInvoiceCurr.Size = new System.Drawing.Size(91, 23);
            this.nmbTotalInvoiceInInvoiceCurr.TabIndex = 460;
            this.nmbTotalInvoiceInInvoiceCurr.Visible = false;
            // 
            // frmPurchaseBillVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 420);
            this.Controls.Add(this.nmbTotalInvoiceInStockCurr);
            this.Controls.Add(this.nmbTotalInvoiceInMainCurr);
            this.Controls.Add(this.nmbTotalInvoiceInInvoiceCurr);
            this.Controls.Add(this.myLabel12);
            this.Controls.Add(this.myLabel11);
            this.Controls.Add(this.nmbInternalExp);
            this.Controls.Add(this.nmbCURRENCY_EXCHANGE);
            this.Controls.Add(this.myLabel10);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.lblAccNo);
            this.Controls.Add(this.myLabel8);
            this.Controls.Add(this.nmbTotalExp);
            this.Controls.Add(this.myText1);
            this.Controls.Add(this.txtSUPPLIER_ID);
            this.Controls.Add(this.txtSUPPLIER_Name);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.nmbTotalWithExp);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.txtSwid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lstBILL_TYPE);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel9);
            this.Controls.Add(this.lstCURRENCY_ID);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.nmbInvoicTotal);
            this.Controls.Add(this.dgExpenss);
            this.Controls.Add(this.btnFindBillPurchase);
            this.Controls.Add(this.txtBILL_NUMBER);
            this.Controls.Add(this.myLabel2);
            this.Name = "frmPurchaseBillVoucher";
            this.Titel = "قيود فواتير الشراء";
            this.Load += new System.EventHandler(this.frmPurchaseBillVoucher_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtBILL_NUMBER, 0);
            this.Controls.SetChildIndex(this.btnFindBillPurchase, 0);
            this.Controls.SetChildIndex(this.dgExpenss, 0);
            this.Controls.SetChildIndex(this.nmbInvoicTotal, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.lstCURRENCY_ID, 0);
            this.Controls.SetChildIndex(this.myLabel9, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.lstBILL_TYPE, 0);
            this.Controls.SetChildIndex(this.btnConfirm, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtSwid, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.nmbTotalWithExp, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.txtSUPPLIER_Name, 0);
            this.Controls.SetChildIndex(this.txtSUPPLIER_ID, 0);
            this.Controls.SetChildIndex(this.myText1, 0);
            this.Controls.SetChildIndex(this.nmbTotalExp, 0);
            this.Controls.SetChildIndex(this.myLabel8, 0);
            this.Controls.SetChildIndex(this.lblAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lblAccName, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.myLabel10, 0);
            this.Controls.SetChildIndex(this.nmbCURRENCY_EXCHANGE, 0);
            this.Controls.SetChildIndex(this.nmbInternalExp, 0);
            this.Controls.SetChildIndex(this.myLabel11, 0);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.nmbTotalInvoiceInInvoiceCurr, 0);
            this.Controls.SetChildIndex(this.nmbTotalInvoiceInMainCurr, 0);
            this.Controls.SetChildIndex(this.nmbTotalInvoiceInStockCurr, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBILL_NUMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbInvoicTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalWithExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUPPLIER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUPPLIER_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURRENCY_EXCHANGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbInternalExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInStockCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInMainCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInInvoiceCurr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private myText txtBILL_NUMBER;
        private myLabel myLabel2;
        private myDataGrid dgExpenss;
        private myNumber nmbInvoicTotal;
        private myLabel myLabel3;
        private myList lstCURRENCY_ID;
        private myLabel myLabel6;
        private myLabel myLabel9;
        private myList lstBILL_TYPE;
        private myLabel myLabel4;
        private myBottun btnConfirm;
        private myBottun btnExit;
        private myText txtSwid;
        private myLabel myLabel5;
        private myNumber nmbTotalWithExp;
        private myLabel myLabel7;
        private myText txtSUPPLIER_ID;
        private myText txtSUPPLIER_Name;
        private myText myText1;
        private myNumber nmbTotalExp;
        private myLabel myLabel8;
        private myList lstAccNo;
        private myLabel lblAccNo;
        private myList lstAccName;
        private myLabel lblAccName;
        private myLabel myLabel10;
        private System.Windows.Forms.NumericUpDown nmbCURRENCY_EXCHANGE;
        private myBottun btnFindBillPurchase;
        private myNumber nmbInternalExp;
        private myLabel myLabel11;
        private myLabel myLabel12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelectedExpCkb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpExpenssItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccId;
        private System.Windows.Forms.NumericUpDown nmbTotalInvoiceInStockCurr;
        private System.Windows.Forms.NumericUpDown nmbTotalInvoiceInMainCurr;
        private System.Windows.Forms.NumericUpDown nmbTotalInvoiceInInvoiceCurr;
    }
}
