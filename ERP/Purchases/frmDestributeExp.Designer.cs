namespace ERP.Purchases
{
    partial class frmDestributeExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDestributeExp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtImportId = new ERP.myText();
            this.btnSearch = new ERP.myBottun();
            this.txtImport_no = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.lstImpContainer = new ERP.myList();
            this.myLabel3 = new ERP.myLabel();
            this.txtNote = new ERP.myText();
            this.dgvImpExp = new ERP.myDataGrid();
            this.clmSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmISSUED_Swid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmISSUED_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmISSUED_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEXPENSES_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEXPENSES_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMAIN_EXPENSES_VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSTOCK_EXPENSES_VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMETHOD_OF_CALCULATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmISSUED_EXPENSES_Helper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbEditor = new ERP.myNumber();
            this.lstEditor = new ERP.myList();
            this.btnSave = new ERP.myBottun();
            this.btnClose = new ERP.myBottun();
            this.txtSwid = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImport_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(318, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(231, 34);
            // 
            // txtImportId
            // 
            this.txtImportId.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtImportId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImportId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtImportId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtImportId.Location = new System.Drawing.Point(451, 65);
            this.txtImportId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtImportId.Name = "txtImportId";
            this.txtImportId.Size = new System.Drawing.Size(37, 23);
            this.txtImportId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtImportId.TabIndex = 449;
            this.txtImportId.Visible = false;
            this.txtImportId.W_Clear = true;
            this.txtImportId.W_ColArName = "";
            this.txtImportId.W_ColEgName = "";
            this.txtImportId.W_OldValue = "";
            this.txtImportId.W_TableName = "";
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
            this.btnSearch.Location = new System.Drawing.Point(364, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 448;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtImport_no
            // 
            this.txtImport_no.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtImport_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImport_no.Font = new System.Drawing.Font("Arial", 10F);
            this.txtImport_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtImport_no.Location = new System.Drawing.Point(398, 65);
            this.txtImport_no.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtImport_no.Name = "txtImport_no";
            this.txtImport_no.Size = new System.Drawing.Size(107, 23);
            this.txtImport_no.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtImport_no.TabIndex = 447;
            this.txtImport_no.W_Clear = true;
            this.txtImport_no.W_ColArName = "الباركود";
            this.txtImport_no.W_ColEgName = "BARCODE";
            this.txtImport_no.W_OldValue = "";
            this.txtImport_no.W_TableName = "BENEFICIARY";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(301, 70);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(45, 18);
            this.myLabel4.TabIndex = 446;
            this.myLabel4.Text = "الحاوية";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(523, 69);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(38, 18);
            this.myLabel2.TabIndex = 444;
            this.myLabel2.Text = "الوارد";
            // 
            // lstImpContainer
            // 
            this.lstImpContainer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstImpContainer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstImpContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstImpContainer.Font = new System.Drawing.Font("Arial", 10F);
            this.lstImpContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstImpContainer.FormattingEnabled = true;
            this.lstImpContainer.Items.AddRange(new object[] {
            "جو",
            "بحر",
            "بر"});
            this.lstImpContainer.Location = new System.Drawing.Point(154, 64);
            this.lstImpContainer.Name = "lstImpContainer";
            this.lstImpContainer.Size = new System.Drawing.Size(140, 24);
            this.lstImpContainer.TabIndex = 450;
            this.lstImpContainer.W_Clear = true;
            this.lstImpContainer.W_ColArName = "";
            this.lstImpContainer.W_ColEgName = "";
            this.lstImpContainer.W_OldValue = "";
            this.lstImpContainer.W_TableName = "";
            this.lstImpContainer.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstImpContainer.SelectedIndexChanged += new System.EventHandler(this.lstImpContainer_SelectedIndexChanged);
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(515, 95);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(52, 18);
            this.myLabel3.TabIndex = 451;
            this.myLabel3.Text = "ملاحظات";
            // 
            // txtNote
            // 
            this.txtNote.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtNote.Location = new System.Drawing.Point(154, 92);
            this.txtNote.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(351, 23);
            this.txtNote.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtNote.TabIndex = 452;
            this.txtNote.W_Clear = true;
            this.txtNote.W_ColArName = "الباركود";
            this.txtNote.W_ColEgName = "BARCODE";
            this.txtNote.W_OldValue = "";
            this.txtNote.W_TableName = "BENEFICIARY";
            // 
            // dgvImpExp
            // 
            this.dgvImpExp.AllowUserToAddRows = false;
            this.dgvImpExp.AllowUserToDeleteRows = false;
            this.dgvImpExp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpExp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImpExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSwid,
            this.clmISSUED_Swid,
            this.clmISSUED_TYPE,
            this.clmISSUED_NO,
            this.clmEXPENSES_ID,
            this.clmEXPENSES_Name,
            this.clmMAIN_EXPENSES_VALUE,
            this.clmSTOCK_EXPENSES_VALUE,
            this.clmMETHOD_OF_CALCULATION,
            this.clmNote,
            this.clmISSUED_EXPENSES_Helper});
            this.dgvImpExp.EnableHeadersVisualStyles = false;
            this.dgvImpExp.Location = new System.Drawing.Point(3, 121);
            this.dgvImpExp.Name = "dgvImpExp";
            this.dgvImpExp.ReadOnly = true;
            this.dgvImpExp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvImpExp.RowHeadersVisible = false;
            this.dgvImpExp.Size = new System.Drawing.Size(799, 390);
            this.dgvImpExp.TabIndex = 453;
            this.dgvImpExp.W_Clear = true;
            this.dgvImpExp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpExp_CellClick);
            // 
            // clmSwid
            // 
            this.clmSwid.HeaderText = "swid";
            this.clmSwid.Name = "clmSwid";
            this.clmSwid.ReadOnly = true;
            this.clmSwid.Visible = false;
            // 
            // clmISSUED_Swid
            // 
            this.clmISSUED_Swid.HeaderText = "issue_swid";
            this.clmISSUED_Swid.Name = "clmISSUED_Swid";
            this.clmISSUED_Swid.ReadOnly = true;
            this.clmISSUED_Swid.Visible = false;
            // 
            // clmISSUED_TYPE
            // 
            this.clmISSUED_TYPE.HeaderText = "نوع العملية";
            this.clmISSUED_TYPE.Name = "clmISSUED_TYPE";
            this.clmISSUED_TYPE.ReadOnly = true;
            this.clmISSUED_TYPE.Width = 90;
            // 
            // clmISSUED_NO
            // 
            this.clmISSUED_NO.HeaderText = "رقم العملية";
            this.clmISSUED_NO.Name = "clmISSUED_NO";
            this.clmISSUED_NO.ReadOnly = true;
            this.clmISSUED_NO.Width = 90;
            // 
            // clmEXPENSES_ID
            // 
            this.clmEXPENSES_ID.HeaderText = "ExpensessSwid";
            this.clmEXPENSES_ID.Name = "clmEXPENSES_ID";
            this.clmEXPENSES_ID.ReadOnly = true;
            this.clmEXPENSES_ID.Visible = false;
            // 
            // clmEXPENSES_Name
            // 
            this.clmEXPENSES_Name.HeaderText = "اسم المصروف";
            this.clmEXPENSES_Name.Name = "clmEXPENSES_Name";
            this.clmEXPENSES_Name.ReadOnly = true;
            // 
            // clmMAIN_EXPENSES_VALUE
            // 
            this.clmMAIN_EXPENSES_VALUE.HeaderText = "المبلغ بالعملة الرئيسية";
            this.clmMAIN_EXPENSES_VALUE.Name = "clmMAIN_EXPENSES_VALUE";
            this.clmMAIN_EXPENSES_VALUE.ReadOnly = true;
            this.clmMAIN_EXPENSES_VALUE.Width = 120;
            // 
            // clmSTOCK_EXPENSES_VALUE
            // 
            this.clmSTOCK_EXPENSES_VALUE.HeaderText = "المبلغ بعملة المخزون";
            this.clmSTOCK_EXPENSES_VALUE.Name = "clmSTOCK_EXPENSES_VALUE";
            this.clmSTOCK_EXPENSES_VALUE.ReadOnly = true;
            this.clmSTOCK_EXPENSES_VALUE.Width = 120;
            // 
            // clmMETHOD_OF_CALCULATION
            // 
            this.clmMETHOD_OF_CALCULATION.HeaderText = "طريقة الحساب";
            this.clmMETHOD_OF_CALCULATION.Name = "clmMETHOD_OF_CALCULATION";
            this.clmMETHOD_OF_CALCULATION.ReadOnly = true;
            // 
            // clmNote
            // 
            this.clmNote.HeaderText = "ملاحظات";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            this.clmNote.Width = 150;
            // 
            // clmISSUED_EXPENSES_Helper
            // 
            this.clmISSUED_EXPENSES_Helper.HeaderText = "مبلغ المصروف المتبقي كامل";
            this.clmISSUED_EXPENSES_Helper.Name = "clmISSUED_EXPENSES_Helper";
            this.clmISSUED_EXPENSES_Helper.ReadOnly = true;
            this.clmISSUED_EXPENSES_Helper.Visible = false;
            // 
            // nmbEditor
            // 
            this.nmbEditor.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbEditor.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.nmbEditor.DecimalPlaces = 0;
            this.nmbEditor.DoubleValue = 0D;
            this.nmbEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbEditor.Location = new System.Drawing.Point(343, 276);
            this.nmbEditor.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbEditor.MinValue = 0D;
            this.nmbEditor.Name = "nmbEditor";
            this.nmbEditor.NullString = "";
            this.nmbEditor.NumberDecimalDigits = 0;
            this.nmbEditor.Size = new System.Drawing.Size(121, 23);
            this.nmbEditor.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbEditor.TabIndex = 455;
            this.nmbEditor.Text = "0";
            this.nmbEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbEditor.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbEditor.Visible = false;
            this.nmbEditor.W_Clear = true;
            this.nmbEditor.W_ColArName = "";
            this.nmbEditor.W_ColEgName = "";
            this.nmbEditor.W_OldValue = "";
            this.nmbEditor.W_TableName = "";
            this.nmbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEditor_KeyDown);
            this.nmbEditor.Leave += new System.EventHandler(this.nmbEditor_Leave);
            // 
            // lstEditor
            // 
            this.lstEditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstEditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstEditor.FormattingEnabled = true;
            this.lstEditor.Items.AddRange(new object[] {
            "قيمة",
            "وزن"});
            this.lstEditor.Location = new System.Drawing.Point(343, 246);
            this.lstEditor.Name = "lstEditor";
            this.lstEditor.Size = new System.Drawing.Size(121, 24);
            this.lstEditor.TabIndex = 454;
            this.lstEditor.Visible = false;
            this.lstEditor.W_Clear = false;
            this.lstEditor.W_ColArName = "";
            this.lstEditor.W_ColEgName = "";
            this.lstEditor.W_OldValue = "";
            this.lstEditor.W_TableName = "";
            this.lstEditor.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEditor_KeyDown);
            this.lstEditor.Leave += new System.EventHandler(this.lstEditor_Leave);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(61, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 456;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(3, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 457;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnClose.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // txtSwid
            // 
            this.txtSwid.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSwid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSwid.Location = new System.Drawing.Point(715, 64);
            this.txtSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSwid.Name = "txtSwid";
            this.txtSwid.Size = new System.Drawing.Size(37, 23);
            this.txtSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSwid.TabIndex = 458;
            this.txtSwid.Visible = false;
            this.txtSwid.W_Clear = true;
            this.txtSwid.W_ColArName = "";
            this.txtSwid.W_ColEgName = "";
            this.txtSwid.W_OldValue = "";
            this.txtSwid.W_TableName = "";
            // 
            // frmDestributeExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(805, 545);
            this.Controls.Add(this.txtSwid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nmbEditor);
            this.Controls.Add(this.lstEditor);
            this.Controls.Add(this.dgvImpExp);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.lstImpContainer);
            this.Controls.Add(this.txtImportId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtImport_no);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel2);
            this.Name = "frmDestributeExp";
            this.RightToLeftLayout = false;
            this.Titel = "توزيع المصاريف على الحاويات";
            this.Load += new System.EventHandler(this.frmDestributeExp_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtImport_no, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.txtImportId, 0);
            this.Controls.SetChildIndex(this.lstImpContainer, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.dgvImpExp, 0);
            this.Controls.SetChildIndex(this.lstEditor, 0);
            this.Controls.SetChildIndex(this.nmbEditor, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.txtSwid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImport_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myText txtImportId;
        private myBottun btnSearch;
        private myText txtImport_no;
        private myLabel myLabel4;
        private myLabel myLabel2;
        private myList lstImpContainer;
        private myLabel myLabel3;
        private myText txtNote;
        private myDataGrid dgvImpExp;
        private myNumber nmbEditor;
        private myList lstEditor;
        private myBottun btnSave;
        private myBottun btnClose;
        private myText txtSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmISSUED_Swid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmISSUED_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmISSUED_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEXPENSES_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEXPENSES_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMAIN_EXPENSES_VALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTOCK_EXPENSES_VALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMETHOD_OF_CALCULATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmISSUED_EXPENSES_Helper;
    }
}
