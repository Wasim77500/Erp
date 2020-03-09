namespace ERP.Purchases
{
    partial class frmPackingList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackingList));
            this.dgvBoxes = new ERP.myDataGrid();
            this.clmSelectedBoxCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmBoxNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItems = new ERP.myDataGrid();
            this.myLabel2 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel4 = new ERP.myLabel();
            this.btnSave = new ERP.myBottun();
            this.btnSearch = new ERP.myBottun();
            this.txtImport_no = new ERP.myText();
            this.lstImpInvoices = new ERP.myList();
            this.txtCONTAINER = new ERP.myText();
            this.ckbSelectAllItem = new System.Windows.Forms.CheckBox();
            this.ckbSelectAllBox = new System.Windows.Forms.CheckBox();
            this.txtImportId = new ERP.myText();
            this.nmbExpEditor = new ERP.myNumber();
            this.nmbTotalInvoiceInInvoiceCurr = new System.Windows.Forms.NumericUpDown();
            this.nmbTotalInvoiceInMainCurr = new System.Windows.Forms.NumericUpDown();
            this.nmbTotalInvoiceInStockCurr = new System.Windows.Forms.NumericUpDown();
            this.clmSelectCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmBillDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtyContainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitCostInvoceCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCost_in_Stock_curr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCOST_IN_Main_curr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInternalExpInvoiceCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInternalExpStockCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInternalExpMainCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImport_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONTAINER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInInvoiceCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInMainCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInStockCurr)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(252, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(165, 34);
            // 
            // dgvBoxes
            // 
            this.dgvBoxes.AllowUserToAddRows = false;
            this.dgvBoxes.AllowUserToDeleteRows = false;
            this.dgvBoxes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoxes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBoxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoxes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSelectedBoxCheckBox,
            this.clmBoxNo});
            this.dgvBoxes.EnableHeadersVisualStyles = false;
            this.dgvBoxes.Location = new System.Drawing.Point(5, 109);
            this.dgvBoxes.Name = "dgvBoxes";
            this.dgvBoxes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvBoxes.RowHeadersVisible = false;
            this.dgvBoxes.Size = new System.Drawing.Size(193, 433);
            this.dgvBoxes.TabIndex = 431;
            this.dgvBoxes.W_Clear = true;
            // 
            // clmSelectedBoxCheckBox
            // 
            this.clmSelectedBoxCheckBox.HeaderText = "تحديد";
            this.clmSelectedBoxCheckBox.Name = "clmSelectedBoxCheckBox";
            this.clmSelectedBoxCheckBox.Width = 60;
            // 
            // clmBoxNo
            // 
            this.clmBoxNo.HeaderText = "رقم الصندوق";
            this.clmBoxNo.Name = "clmBoxNo";
            this.clmBoxNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBoxNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmBoxNo.Width = 120;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSelectCheckBox,
            this.clmBillDetailId,
            this.clmItemId,
            this.clmItemNo,
            this.clmItemName,
            this.clmQty,
            this.clmQtyContainer,
            this.clmUnitCostInvoceCurr,
            this.clmCost_in_Stock_curr,
            this.clmCOST_IN_Main_curr,
            this.clmInternalExpInvoiceCurr,
            this.clmInternalExpStockCurr,
            this.clmInternalExpMainCurr});
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Location = new System.Drawing.Point(204, 109);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.Size = new System.Drawing.Size(465, 433);
            this.dgvItems.TabIndex = 432;
            this.dgvItems.W_Clear = true;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(622, 71);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(38, 18);
            this.myLabel2.TabIndex = 433;
            this.myLabel2.Text = "الوارد";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(428, 72);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(46, 18);
            this.myLabel3.TabIndex = 434;
            this.myLabel3.Text = "الفواتير";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(252, 71);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(45, 18);
            this.myLabel4.TabIndex = 435;
            this.myLabel4.Text = "الحاوية";
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
            this.btnSave.Location = new System.Drawing.Point(5, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 436;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.IsBackStageButton = false;
            this.btnSearch.Location = new System.Drawing.Point(480, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 438;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtImport_no
            // 
            this.txtImport_no.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.txtImport_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImport_no.Font = new System.Drawing.Font("Arial", 10F);
            this.txtImport_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtImport_no.Location = new System.Drawing.Point(509, 68);
            this.txtImport_no.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtImport_no.Name = "txtImport_no";
            this.txtImport_no.Size = new System.Drawing.Size(107, 23);
            this.txtImport_no.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtImport_no.TabIndex = 437;
            this.txtImport_no.W_Clear = true;
            this.txtImport_no.W_ColArName = "الباركود";
            this.txtImport_no.W_ColEgName = "BARCODE";
            this.txtImport_no.W_OldValue = "";
            this.txtImport_no.W_TableName = "BENEFICIARY";
            // 
            // lstImpInvoices
            // 
            this.lstImpInvoices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstImpInvoices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstImpInvoices.Font = new System.Drawing.Font("Arial", 10F);
            this.lstImpInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstImpInvoices.FormattingEnabled = true;
            this.lstImpInvoices.Items.AddRange(new object[] {
            "جو",
            "بحر",
            "بر"});
            this.lstImpInvoices.Location = new System.Drawing.Point(303, 67);
            this.lstImpInvoices.Name = "lstImpInvoices";
            this.lstImpInvoices.Size = new System.Drawing.Size(123, 24);
            this.lstImpInvoices.TabIndex = 439;
            this.lstImpInvoices.W_Clear = true;
            this.lstImpInvoices.W_ColArName = "";
            this.lstImpInvoices.W_ColEgName = "";
            this.lstImpInvoices.W_OldValue = "";
            this.lstImpInvoices.W_TableName = "";
            this.lstImpInvoices.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstImpInvoices.SelectedIndexChanged += new System.EventHandler(this.lstImpInvoices_SelectedIndexChanged);
            // 
            // txtCONTAINER
            // 
            this.txtCONTAINER.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.txtCONTAINER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCONTAINER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCONTAINER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCONTAINER.Location = new System.Drawing.Point(105, 68);
            this.txtCONTAINER.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCONTAINER.Name = "txtCONTAINER";
            this.txtCONTAINER.Size = new System.Drawing.Size(144, 23);
            this.txtCONTAINER.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCONTAINER.TabIndex = 440;
            this.txtCONTAINER.W_Clear = true;
            this.txtCONTAINER.W_ColArName = "الباركود";
            this.txtCONTAINER.W_ColEgName = "BARCODE";
            this.txtCONTAINER.W_OldValue = "";
            this.txtCONTAINER.W_TableName = "BENEFICIARY";
            // 
            // ckbSelectAllItem
            // 
            this.ckbSelectAllItem.AutoSize = true;
            this.ckbSelectAllItem.Location = new System.Drawing.Point(586, 92);
            this.ckbSelectAllItem.Name = "ckbSelectAllItem";
            this.ckbSelectAllItem.Size = new System.Drawing.Size(74, 17);
            this.ckbSelectAllItem.TabIndex = 441;
            this.ckbSelectAllItem.Text = "تحديد الكل";
            this.ckbSelectAllItem.UseVisualStyleBackColor = true;
            this.ckbSelectAllItem.CheckedChanged += new System.EventHandler(this.ckbSelectAllItem_CheckedChanged);
            // 
            // ckbSelectAllBox
            // 
            this.ckbSelectAllBox.AutoSize = true;
            this.ckbSelectAllBox.Location = new System.Drawing.Point(105, 92);
            this.ckbSelectAllBox.Name = "ckbSelectAllBox";
            this.ckbSelectAllBox.Size = new System.Drawing.Size(74, 17);
            this.ckbSelectAllBox.TabIndex = 442;
            this.ckbSelectAllBox.Text = "تحديد الكل";
            this.ckbSelectAllBox.UseVisualStyleBackColor = true;
            this.ckbSelectAllBox.CheckedChanged += new System.EventHandler(this.ckbSelectAllBox_CheckedChanged);
            // 
            // txtImportId
            // 
            this.txtImportId.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.txtImportId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImportId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtImportId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtImportId.Location = new System.Drawing.Point(514, 45);
            this.txtImportId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtImportId.Name = "txtImportId";
            this.txtImportId.Size = new System.Drawing.Size(37, 23);
            this.txtImportId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtImportId.TabIndex = 443;
            this.txtImportId.Visible = false;
            this.txtImportId.W_Clear = true;
            this.txtImportId.W_ColArName = "";
            this.txtImportId.W_ColEgName = "";
            this.txtImportId.W_OldValue = "";
            this.txtImportId.W_TableName = "";
            // 
            // nmbExpEditor
            // 
            this.nmbExpEditor.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbExpEditor.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.nmbExpEditor.DecimalPlaces = 0;
            this.nmbExpEditor.DoubleValue = 0D;
            this.nmbExpEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbExpEditor.Location = new System.Drawing.Point(231, 184);
            this.nmbExpEditor.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbExpEditor.MinValue = 0D;
            this.nmbExpEditor.Name = "nmbExpEditor";
            this.nmbExpEditor.NullString = "";
            this.nmbExpEditor.NumberDecimalDigits = 0;
            this.nmbExpEditor.Size = new System.Drawing.Size(121, 23);
            this.nmbExpEditor.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbExpEditor.TabIndex = 444;
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
            // nmbTotalInvoiceInInvoiceCurr
            // 
            this.nmbTotalInvoiceInInvoiceCurr.DecimalPlaces = 30;
            this.nmbTotalInvoiceInInvoiceCurr.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbTotalInvoiceInInvoiceCurr.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbTotalInvoiceInInvoiceCurr.Location = new System.Drawing.Point(525, 184);
            this.nmbTotalInvoiceInInvoiceCurr.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nmbTotalInvoiceInInvoiceCurr.Name = "nmbTotalInvoiceInInvoiceCurr";
            this.nmbTotalInvoiceInInvoiceCurr.ReadOnly = true;
            this.nmbTotalInvoiceInInvoiceCurr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmbTotalInvoiceInInvoiceCurr.Size = new System.Drawing.Size(91, 23);
            this.nmbTotalInvoiceInInvoiceCurr.TabIndex = 448;
            this.nmbTotalInvoiceInInvoiceCurr.Visible = false;
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
            this.nmbTotalInvoiceInMainCurr.Location = new System.Drawing.Point(525, 213);
            this.nmbTotalInvoiceInMainCurr.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nmbTotalInvoiceInMainCurr.Name = "nmbTotalInvoiceInMainCurr";
            this.nmbTotalInvoiceInMainCurr.ReadOnly = true;
            this.nmbTotalInvoiceInMainCurr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmbTotalInvoiceInMainCurr.Size = new System.Drawing.Size(91, 23);
            this.nmbTotalInvoiceInMainCurr.TabIndex = 449;
            this.nmbTotalInvoiceInMainCurr.Visible = false;
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
            this.nmbTotalInvoiceInStockCurr.Location = new System.Drawing.Point(525, 242);
            this.nmbTotalInvoiceInStockCurr.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nmbTotalInvoiceInStockCurr.Name = "nmbTotalInvoiceInStockCurr";
            this.nmbTotalInvoiceInStockCurr.ReadOnly = true;
            this.nmbTotalInvoiceInStockCurr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmbTotalInvoiceInStockCurr.Size = new System.Drawing.Size(91, 23);
            this.nmbTotalInvoiceInStockCurr.TabIndex = 450;
            this.nmbTotalInvoiceInStockCurr.Visible = false;
            // 
            // clmSelectCheckBox
            // 
            this.clmSelectCheckBox.HeaderText = "تحديد";
            this.clmSelectCheckBox.Name = "clmSelectCheckBox";
            this.clmSelectCheckBox.Width = 60;
            // 
            // clmBillDetailId
            // 
            this.clmBillDetailId.HeaderText = "PURCHASES_BILL_DE";
            this.clmBillDetailId.Name = "clmBillDetailId";
            this.clmBillDetailId.ReadOnly = true;
            this.clmBillDetailId.Visible = false;
            // 
            // clmItemId
            // 
            this.clmItemId.HeaderText = "ItemSwid";
            this.clmItemId.Name = "clmItemId";
            this.clmItemId.ReadOnly = true;
            this.clmItemId.Visible = false;
            // 
            // clmItemNo
            // 
            this.clmItemNo.HeaderText = "رقم الصنف";
            this.clmItemNo.Name = "clmItemNo";
            this.clmItemNo.ReadOnly = true;
            // 
            // clmItemName
            // 
            this.clmItemName.HeaderText = "اسم الصنف";
            this.clmItemName.Name = "clmItemName";
            this.clmItemName.ReadOnly = true;
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "الكمية";
            this.clmQty.Name = "clmQty";
            this.clmQty.ReadOnly = true;
            // 
            // clmQtyContainer
            // 
            this.clmQtyContainer.HeaderText = "الكمية الموزعة";
            this.clmQtyContainer.Name = "clmQtyContainer";
            this.clmQtyContainer.ReadOnly = true;
            // 
            // clmUnitCostInvoceCurr
            // 
            this.clmUnitCostInvoceCurr.HeaderText = "التكلفة بعملة الفاتورة";
            this.clmUnitCostInvoceCurr.Name = "clmUnitCostInvoceCurr";
            this.clmUnitCostInvoceCurr.ReadOnly = true;
            // 
            // clmCost_in_Stock_curr
            // 
            this.clmCost_in_Stock_curr.HeaderText = "التكلفة بعملة المخزون";
            this.clmCost_in_Stock_curr.Name = "clmCost_in_Stock_curr";
            this.clmCost_in_Stock_curr.ReadOnly = true;
            // 
            // clmCOST_IN_Main_curr
            // 
            this.clmCOST_IN_Main_curr.HeaderText = "التكلفة بالعملة الرئيسية";
            this.clmCOST_IN_Main_curr.Name = "clmCOST_IN_Main_curr";
            this.clmCOST_IN_Main_curr.ReadOnly = true;
            // 
            // clmInternalExpInvoiceCurr
            // 
            this.clmInternalExpInvoiceCurr.HeaderText = "تكلفة المصاريف الداخلية بعملة الفاتورة";
            this.clmInternalExpInvoiceCurr.Name = "clmInternalExpInvoiceCurr";
            this.clmInternalExpInvoiceCurr.ReadOnly = true;
            // 
            // clmInternalExpStockCurr
            // 
            this.clmInternalExpStockCurr.HeaderText = "تكلفة المصاريف الداخلية بعملة المخزون";
            this.clmInternalExpStockCurr.Name = "clmInternalExpStockCurr";
            this.clmInternalExpStockCurr.ReadOnly = true;
            // 
            // clmInternalExpMainCurr
            // 
            this.clmInternalExpMainCurr.HeaderText = "المصاريف الداخلية بالعملة الرئيسية";
            this.clmInternalExpMainCurr.Name = "clmInternalExpMainCurr";
            this.clmInternalExpMainCurr.ReadOnly = true;
            // 
            // frmPackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(673, 545);
            this.Controls.Add(this.nmbTotalInvoiceInStockCurr);
            this.Controls.Add(this.nmbTotalInvoiceInMainCurr);
            this.Controls.Add(this.nmbTotalInvoiceInInvoiceCurr);
            this.Controls.Add(this.nmbExpEditor);
            this.Controls.Add(this.txtImportId);
            this.Controls.Add(this.ckbSelectAllBox);
            this.Controls.Add(this.ckbSelectAllItem);
            this.Controls.Add(this.txtCONTAINER);
            this.Controls.Add(this.lstImpInvoices);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtImport_no);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.dgvBoxes);
            this.Name = "frmPackingList";
            this.RightToLeftLayout = false;
            this.Titel = "توزيع الوارد على الحاويات";
            this.Load += new System.EventHandler(this.frmPackingList_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.dgvBoxes, 0);
            this.Controls.SetChildIndex(this.dgvItems, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtImport_no, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.lstImpInvoices, 0);
            this.Controls.SetChildIndex(this.txtCONTAINER, 0);
            this.Controls.SetChildIndex(this.ckbSelectAllItem, 0);
            this.Controls.SetChildIndex(this.ckbSelectAllBox, 0);
            this.Controls.SetChildIndex(this.txtImportId, 0);
            this.Controls.SetChildIndex(this.nmbExpEditor, 0);
            this.Controls.SetChildIndex(this.nmbTotalInvoiceInInvoiceCurr, 0);
            this.Controls.SetChildIndex(this.nmbTotalInvoiceInMainCurr, 0);
            this.Controls.SetChildIndex(this.nmbTotalInvoiceInStockCurr, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImport_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONTAINER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInInvoiceCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInMainCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalInvoiceInStockCurr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataGrid dgvBoxes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelectedBoxCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBoxNo;
        private myDataGrid dgvItems;
        private myLabel myLabel2;
        private myLabel myLabel3;
        private myLabel myLabel4;
        private myBottun btnSave;
        private myBottun btnSearch;
        private myText txtImport_no;
        private myList lstImpInvoices;
        private myText txtCONTAINER;
        private System.Windows.Forms.CheckBox ckbSelectAllItem;
        private System.Windows.Forms.CheckBox ckbSelectAllBox;
        private myText txtImportId;
        private myNumber nmbExpEditor;
        private System.Windows.Forms.NumericUpDown nmbTotalInvoiceInInvoiceCurr;
        private System.Windows.Forms.NumericUpDown nmbTotalInvoiceInMainCurr;
        private System.Windows.Forms.NumericUpDown nmbTotalInvoiceInStockCurr;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelectCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBillDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtyContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitCostInvoceCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCost_in_Stock_curr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCOST_IN_Main_curr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInternalExpInvoiceCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInternalExpStockCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInternalExpMainCurr;
    }
}
