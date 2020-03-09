namespace ERP.Purchases
{
    partial class frmPrecurementExpensess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrecurementExpensess));
            this.txtISSUED_ID = new ERP.myText();
            this.txtISSUED_TYPE = new ERP.myText();
            this.dgvPrecuremenExp = new ERP.myDataGrid();
            this.clmSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeopleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeopleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpensessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpensessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpCurrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDoc_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddToCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetPeople = new ERP.myBottun();
            this.txtPeopleName = new ERP.myText();
            this.myLabel9 = new ERP.myLabel();
            this.txtEXPENSES_ID = new ERP.myText();
            this.btnGetExpenss = new ERP.myBottun();
            this.nmbExpenssItem = new ERP.myNumber();
            this.myLabel26 = new ERP.myLabel();
            this.txtEXPENSES_Name = new ERP.myText();
            this.myLabel27 = new ERP.myLabel();
            this.txtPEOPLE_ID = new ERP.myText();
            this.txtNotes = new ERP.myText();
            this.txtDOCUMENT_No = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.myLabel25 = new ERP.myLabel();
            this.btnAddOperation = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.btnClose = new ERP.myBottun();
            this.lstAccName = new ERP.myList();
            this.lstAccNo = new ERP.myList();
            this.myLabel13 = new ERP.myLabel();
            this.myLabel12 = new ERP.myLabel();
            this.ckbADD_TO_COST = new ERP.mycheck();
            this.lstCURRENCY_ID = new ERP.myList();
            this.myLabel5 = new ERP.myLabel();
            this.nmbCURR_PRICE = new System.Windows.Forms.NumericUpDown();
            this.nmbCASHER_MAIN_VALUE = new ERP.myNumber();
            this.txtExpAccId = new ERP.myText();
            this.txtTempletId = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISSUED_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISSUED_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecuremenExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeopleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpenssItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPEOPLE_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOCUMENT_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbADD_TO_COST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURR_PRICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHER_MAIN_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpAccId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempletId)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(179, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(92, 34);
            // 
            // txtISSUED_ID
            // 
            this.txtISSUED_ID.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtISSUED_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISSUED_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtISSUED_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtISSUED_ID.Location = new System.Drawing.Point(377, 34);
            this.txtISSUED_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtISSUED_ID.Name = "txtISSUED_ID";
            this.txtISSUED_ID.Size = new System.Drawing.Size(100, 23);
            this.txtISSUED_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtISSUED_ID.TabIndex = 4;
            this.txtISSUED_ID.Visible = false;
            this.txtISSUED_ID.W_Clear = false;
            this.txtISSUED_ID.W_ColArName = "";
            this.txtISSUED_ID.W_ColEgName = "";
            this.txtISSUED_ID.W_OldValue = "";
            this.txtISSUED_ID.W_TableName = "";
            // 
            // txtISSUED_TYPE
            // 
            this.txtISSUED_TYPE.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtISSUED_TYPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISSUED_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.txtISSUED_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtISSUED_TYPE.Location = new System.Drawing.Point(271, 34);
            this.txtISSUED_TYPE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtISSUED_TYPE.Name = "txtISSUED_TYPE";
            this.txtISSUED_TYPE.Size = new System.Drawing.Size(100, 23);
            this.txtISSUED_TYPE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtISSUED_TYPE.TabIndex = 5;
            this.txtISSUED_TYPE.Visible = false;
            this.txtISSUED_TYPE.W_Clear = false;
            this.txtISSUED_TYPE.W_ColArName = "";
            this.txtISSUED_TYPE.W_ColEgName = "";
            this.txtISSUED_TYPE.W_OldValue = "";
            this.txtISSUED_TYPE.W_TableName = "";
            // 
            // dgvPrecuremenExp
            // 
            this.dgvPrecuremenExp.AllowUserToAddRows = false;
            this.dgvPrecuremenExp.AllowUserToDeleteRows = false;
            this.dgvPrecuremenExp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrecuremenExp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrecuremenExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecuremenExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSwid,
            this.clmPeopleId,
            this.clmPeopleName,
            this.clmExpensessId,
            this.clmExpensessName,
            this.clmExpValue,
            this.clmExpCurrId,
            this.clmExpCurrency,
            this.clmDoc_no,
            this.clmAddToCost,
            this.clmNote,
            this.clmExchangeRate,
            this.clmMainValue,
            this.clmStockValue,
            this.clmAccId});
            this.dgvPrecuremenExp.EnableHeadersVisualStyles = false;
            this.dgvPrecuremenExp.Location = new System.Drawing.Point(0, 176);
            this.dgvPrecuremenExp.Name = "dgvPrecuremenExp";
            this.dgvPrecuremenExp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPrecuremenExp.RowHeadersVisible = false;
            this.dgvPrecuremenExp.Size = new System.Drawing.Size(516, 238);
            this.dgvPrecuremenExp.TabIndex = 339;
            this.dgvPrecuremenExp.W_Clear = true;
            // 
            // clmSwid
            // 
            this.clmSwid.HeaderText = "SWID";
            this.clmSwid.Name = "clmSwid";
            this.clmSwid.ReadOnly = true;
            this.clmSwid.Visible = false;
            // 
            // clmPeopleId
            // 
            this.clmPeopleId.HeaderText = "PeopleId";
            this.clmPeopleId.Name = "clmPeopleId";
            this.clmPeopleId.ReadOnly = true;
            this.clmPeopleId.Visible = false;
            // 
            // clmPeopleName
            // 
            this.clmPeopleName.HeaderText = "المستفيد";
            this.clmPeopleName.Name = "clmPeopleName";
            this.clmPeopleName.ReadOnly = true;
            this.clmPeopleName.Visible = false;
            // 
            // clmExpensessId
            // 
            this.clmExpensessId.HeaderText = "ExpensessId";
            this.clmExpensessId.Name = "clmExpensessId";
            this.clmExpensessId.ReadOnly = true;
            this.clmExpensessId.Visible = false;
            // 
            // clmExpensessName
            // 
            this.clmExpensessName.HeaderText = "المصروف";
            this.clmExpensessName.Name = "clmExpensessName";
            this.clmExpensessName.ReadOnly = true;
            // 
            // clmExpValue
            // 
            this.clmExpValue.HeaderText = "مبلغ المصروف";
            this.clmExpValue.Name = "clmExpValue";
            this.clmExpValue.ReadOnly = true;
            // 
            // clmExpCurrId
            // 
            this.clmExpCurrId.HeaderText = "ExpCurr swid";
            this.clmExpCurrId.Name = "clmExpCurrId";
            this.clmExpCurrId.Visible = false;
            // 
            // clmExpCurrency
            // 
            this.clmExpCurrency.HeaderText = "عملة المصروف";
            this.clmExpCurrency.Name = "clmExpCurrency";
            // 
            // clmDoc_no
            // 
            this.clmDoc_no.HeaderText = "رقم المستند";
            this.clmDoc_no.Name = "clmDoc_no";
            this.clmDoc_no.ReadOnly = true;
            // 
            // clmAddToCost
            // 
            this.clmAddToCost.HeaderText = "مضافة الى التكلفة";
            this.clmAddToCost.Name = "clmAddToCost";
            this.clmAddToCost.Width = 120;
            // 
            // clmNote
            // 
            this.clmNote.HeaderText = "ملاحظات";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            // 
            // clmExchangeRate
            // 
            this.clmExchangeRate.HeaderText = "سعر الصرف";
            this.clmExchangeRate.Name = "clmExchangeRate";
            this.clmExchangeRate.ReadOnly = true;
            this.clmExchangeRate.Visible = false;
            // 
            // clmMainValue
            // 
            this.clmMainValue.HeaderText = "المبلغ بالعملة الاساسية";
            this.clmMainValue.Name = "clmMainValue";
            this.clmMainValue.ReadOnly = true;
            this.clmMainValue.Visible = false;
            // 
            // clmStockValue
            // 
            this.clmStockValue.HeaderText = "المبلغ بالدولار";
            this.clmStockValue.Name = "clmStockValue";
            this.clmStockValue.Visible = false;
            // 
            // clmAccId
            // 
            this.clmAccId.HeaderText = "acc_id";
            this.clmAccId.Name = "clmAccId";
            this.clmAccId.ReadOnly = true;
            this.clmAccId.Visible = false;
            // 
            // btnGetPeople
            // 
            this.btnGetPeople.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetPeople.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetPeople.FlatAppearance.BorderSize = 0;
            this.btnGetPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPeople.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetPeople.Image = ((System.Drawing.Image)(resources.GetObject("btnGetPeople.Image")));
            this.btnGetPeople.IsBackStageButton = false;
            this.btnGetPeople.Location = new System.Drawing.Point(487, 83);
            this.btnGetPeople.Name = "btnGetPeople";
            this.btnGetPeople.Size = new System.Drawing.Size(28, 27);
            this.btnGetPeople.TabIndex = 342;
            this.btnGetPeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetPeople.UseVisualStyleBackColor = true;
            this.btnGetPeople.Visible = false;
            this.btnGetPeople.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetPeople.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetPeople.Click += new System.EventHandler(this.btnGetPeople_Click);
            // 
            // txtPeopleName
            // 
            this.txtPeopleName.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtPeopleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeopleName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPeopleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPeopleName.Location = new System.Drawing.Point(353, 86);
            this.txtPeopleName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPeopleName.Name = "txtPeopleName";
            this.txtPeopleName.Size = new System.Drawing.Size(129, 23);
            this.txtPeopleName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPeopleName.TabIndex = 341;
            this.txtPeopleName.Visible = false;
            this.txtPeopleName.W_Clear = true;
            this.txtPeopleName.W_ColArName = "";
            this.txtPeopleName.W_ColEgName = "";
            this.txtPeopleName.W_OldValue = "";
            this.txtPeopleName.W_TableName = "";
            // 
            // myLabel9
            // 
            this.myLabel9.AutoSize = false;
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(285, 90);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel9.Size = new System.Drawing.Size(66, 18);
            this.myLabel9.TabIndex = 340;
            this.myLabel9.Text = "المستفيد";
            this.myLabel9.Visible = false;
            // 
            // txtEXPENSES_ID
            // 
            this.txtEXPENSES_ID.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtEXPENSES_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEXPENSES_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEXPENSES_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtEXPENSES_ID.Location = new System.Drawing.Point(110, 119);
            this.txtEXPENSES_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEXPENSES_ID.Name = "txtEXPENSES_ID";
            this.txtEXPENSES_ID.Size = new System.Drawing.Size(38, 23);
            this.txtEXPENSES_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEXPENSES_ID.TabIndex = 418;
            this.txtEXPENSES_ID.Visible = false;
            this.txtEXPENSES_ID.W_Clear = true;
            this.txtEXPENSES_ID.W_ColArName = "";
            this.txtEXPENSES_ID.W_ColEgName = "";
            this.txtEXPENSES_ID.W_OldValue = "";
            this.txtEXPENSES_ID.W_TableName = "";
            // 
            // btnGetExpenss
            // 
            this.btnGetExpenss.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetExpenss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetExpenss.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetExpenss.FlatAppearance.BorderSize = 0;
            this.btnGetExpenss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetExpenss.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetExpenss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetExpenss.Image = ((System.Drawing.Image)(resources.GetObject("btnGetExpenss.Image")));
            this.btnGetExpenss.IsBackStageButton = false;
            this.btnGetExpenss.Location = new System.Drawing.Point(213, 115);
            this.btnGetExpenss.Name = "btnGetExpenss";
            this.btnGetExpenss.Size = new System.Drawing.Size(28, 27);
            this.btnGetExpenss.TabIndex = 413;
            this.btnGetExpenss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetExpenss.UseVisualStyleBackColor = true;
            this.btnGetExpenss.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetExpenss.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetExpenss.Click += new System.EventHandler(this.btnGetExpenss_Click);
            // 
            // nmbExpenssItem
            // 
            this.nmbExpenssItem.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbExpenssItem.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.nmbExpenssItem.DecimalPlaces = 0;
            this.nmbExpenssItem.DoubleValue = 0D;
            this.nmbExpenssItem.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbExpenssItem.Location = new System.Drawing.Point(353, 115);
            this.nmbExpenssItem.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbExpenssItem.MinValue = 0D;
            this.nmbExpenssItem.Name = "nmbExpenssItem";
            this.nmbExpenssItem.NullString = "";
            this.nmbExpenssItem.NumberDecimalDigits = 0;
            this.nmbExpenssItem.Size = new System.Drawing.Size(124, 23);
            this.nmbExpenssItem.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbExpenssItem.TabIndex = 414;
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
            this.nmbExpenssItem.Leave += new System.EventHandler(this.nmbExpenssItem_Leave);
            // 
            // myLabel26
            // 
            this.myLabel26.AutoSize = false;
            this.myLabel26.BackColor = System.Drawing.Color.Transparent;
            this.myLabel26.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel26.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel26.ForeColor = System.Drawing.Color.Black;
            this.myLabel26.Location = new System.Drawing.Point(292, 118);
            this.myLabel26.Name = "myLabel26";
            this.myLabel26.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel26.Size = new System.Drawing.Size(44, 18);
            this.myLabel26.TabIndex = 417;
            this.myLabel26.Text = "المبلغ";
            // 
            // txtEXPENSES_Name
            // 
            this.txtEXPENSES_Name.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtEXPENSES_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEXPENSES_Name.Enabled = false;
            this.txtEXPENSES_Name.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEXPENSES_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtEXPENSES_Name.Location = new System.Drawing.Point(79, 119);
            this.txtEXPENSES_Name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEXPENSES_Name.Name = "txtEXPENSES_Name";
            this.txtEXPENSES_Name.Size = new System.Drawing.Size(129, 23);
            this.txtEXPENSES_Name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEXPENSES_Name.TabIndex = 416;
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
            this.myLabel27.Location = new System.Drawing.Point(5, 121);
            this.myLabel27.Name = "myLabel27";
            this.myLabel27.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel27.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel27.Size = new System.Drawing.Size(67, 18);
            this.myLabel27.TabIndex = 415;
            this.myLabel27.Text = "المصروف";
            // 
            // txtPEOPLE_ID
            // 
            this.txtPEOPLE_ID.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtPEOPLE_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPEOPLE_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPEOPLE_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPEOPLE_ID.Location = new System.Drawing.Point(408, 86);
            this.txtPEOPLE_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPEOPLE_ID.Name = "txtPEOPLE_ID";
            this.txtPEOPLE_ID.Size = new System.Drawing.Size(38, 23);
            this.txtPEOPLE_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPEOPLE_ID.TabIndex = 419;
            this.txtPEOPLE_ID.Visible = false;
            this.txtPEOPLE_ID.W_Clear = true;
            this.txtPEOPLE_ID.W_ColArName = "";
            this.txtPEOPLE_ID.W_ColEgName = "";
            this.txtPEOPLE_ID.W_OldValue = "";
            this.txtPEOPLE_ID.W_TableName = "";
            // 
            // txtNotes
            // 
            this.txtNotes.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtNotes.Location = new System.Drawing.Point(79, 146);
            this.txtNotes.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(270, 23);
            this.txtNotes.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtNotes.TabIndex = 423;
            this.txtNotes.W_Clear = true;
            this.txtNotes.W_ColArName = "";
            this.txtNotes.W_ColEgName = "";
            this.txtNotes.W_OldValue = "";
            this.txtNotes.W_TableName = "";
            // 
            // txtDOCUMENT_No
            // 
            this.txtDOCUMENT_No.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtDOCUMENT_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOCUMENT_No.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDOCUMENT_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDOCUMENT_No.Location = new System.Drawing.Point(79, 90);
            this.txtDOCUMENT_No.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDOCUMENT_No.Name = "txtDOCUMENT_No";
            this.txtDOCUMENT_No.Size = new System.Drawing.Size(162, 23);
            this.txtDOCUMENT_No.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDOCUMENT_No.TabIndex = 420;
            this.txtDOCUMENT_No.W_Clear = true;
            this.txtDOCUMENT_No.W_ColArName = "";
            this.txtDOCUMENT_No.W_ColEgName = "";
            this.txtDOCUMENT_No.W_OldValue = "";
            this.txtDOCUMENT_No.W_TableName = "";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(10, 150);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(52, 18);
            this.myLabel2.TabIndex = 422;
            this.myLabel2.Text = "ملاحظات";
            // 
            // myLabel25
            // 
            this.myLabel25.BackColor = System.Drawing.Color.Transparent;
            this.myLabel25.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel25.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel25.ForeColor = System.Drawing.Color.Black;
            this.myLabel25.Location = new System.Drawing.Point(6, 92);
            this.myLabel25.Name = "myLabel25";
            this.myLabel25.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel25.Size = new System.Drawing.Size(64, 18);
            this.myLabel25.TabIndex = 421;
            this.myLabel25.Text = "رقم المستند";
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.BackgroundImage = global::ERP.Properties.Resources.Add_h;
            this.btnAddOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddOperation.BeforeTouchSize = new System.Drawing.Size(22, 22);
            this.btnAddOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOperation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddOperation.FlatAppearance.BorderSize = 0;
            this.btnAddOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOperation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddOperation.IsBackStageButton = false;
            this.btnAddOperation.Location = new System.Drawing.Point(467, 146);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(22, 22);
            this.btnAddOperation.TabIndex = 425;
            this.btnAddOperation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAddOperation.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // btnSave
            // 
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(409, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 427;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(467, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 426;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnClose.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(353, 59);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(124, 24);
            this.lstAccName.TabIndex = 431;
            this.lstAccName.W_Clear = true;
            this.lstAccName.W_ColArName = "";
            this.lstAccName.W_ColEgName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.W_TableName = "";
            this.lstAccName.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccName.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(79, 61);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(162, 24);
            this.lstAccNo.TabIndex = 430;
            this.lstAccNo.W_Clear = true;
            this.lstAccNo.W_ColArName = "";
            this.lstAccNo.W_ColEgName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.W_TableName = "";
            this.lstAccNo.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // myLabel13
            // 
            this.myLabel13.BackColor = System.Drawing.Color.Transparent;
            this.myLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel13.ForeColor = System.Drawing.Color.Black;
            this.myLabel13.Location = new System.Drawing.Point(267, 63);
            this.myLabel13.Name = "myLabel13";
            this.myLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel13.Size = new System.Drawing.Size(69, 18);
            this.myLabel13.TabIndex = 429;
            this.myLabel13.Text = "اسم الحساب";
            // 
            // myLabel12
            // 
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(7, 63);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(67, 18);
            this.myLabel12.TabIndex = 428;
            this.myLabel12.Text = "رقم الحساب";
            // 
            // ckbADD_TO_COST
            // 
            this.ckbADD_TO_COST.BeforeTouchSize = new System.Drawing.Size(112, 21);
            this.ckbADD_TO_COST.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ckbADD_TO_COST.CheckedImage")));
            this.ckbADD_TO_COST.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.ckbADD_TO_COST.ImageCheckBox = true;
            this.ckbADD_TO_COST.IndeterminateImage = ((System.Drawing.Image)(resources.GetObject("ckbADD_TO_COST.IndeterminateImage")));
            this.ckbADD_TO_COST.Location = new System.Drawing.Point(353, 148);
            this.ckbADD_TO_COST.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.ckbADD_TO_COST.Name = "ckbADD_TO_COST";
            this.ckbADD_TO_COST.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbADD_TO_COST.Size = new System.Drawing.Size(112, 21);
            this.ckbADD_TO_COST.TabIndex = 432;
            this.ckbADD_TO_COST.Text = "مضاف الى التكلفة";
            this.ckbADD_TO_COST.ThemesEnabled = false;
            this.ckbADD_TO_COST.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("ckbADD_TO_COST.UncheckedImage")));
            this.ckbADD_TO_COST.W_Clear = true;
            this.ckbADD_TO_COST.W_ColArName = "";
            this.ckbADD_TO_COST.W_ColEgName = "";
            this.ckbADD_TO_COST.W_OldValue = "";
            this.ckbADD_TO_COST.W_TableName = "";
            // 
            // lstCURRENCY_ID
            // 
            this.lstCURRENCY_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCURRENCY_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCURRENCY_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCURRENCY_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCURRENCY_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCURRENCY_ID.FormattingEnabled = true;
            this.lstCURRENCY_ID.Location = new System.Drawing.Point(79, 33);
            this.lstCURRENCY_ID.Name = "lstCURRENCY_ID";
            this.lstCURRENCY_ID.Size = new System.Drawing.Size(162, 24);
            this.lstCURRENCY_ID.TabIndex = 434;
            this.lstCURRENCY_ID.W_Clear = false;
            this.lstCURRENCY_ID.W_ColArName = "";
            this.lstCURRENCY_ID.W_ColEgName = "";
            this.lstCURRENCY_ID.W_OldValue = "";
            this.lstCURRENCY_ID.W_TableName = "";
            this.lstCURRENCY_ID.w_ValueType = ERP.myList.ValueType.VALUE;
            this.lstCURRENCY_ID.SelectedIndexChanged += new System.EventHandler(this.lstCURRENCY_ID_SelectedIndexChanged);
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = false;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(18, 37);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(50, 18);
            this.myLabel5.TabIndex = 433;
            this.myLabel5.Text = "العملة";
            // 
            // nmbCURR_PRICE
            // 
            this.nmbCURR_PRICE.DecimalPlaces = 30;
            this.nmbCURR_PRICE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCURR_PRICE.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCURR_PRICE.Location = new System.Drawing.Point(256, 145);
            this.nmbCURR_PRICE.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nmbCURR_PRICE.Name = "nmbCURR_PRICE";
            this.nmbCURR_PRICE.ReadOnly = true;
            this.nmbCURR_PRICE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmbCURR_PRICE.Size = new System.Drawing.Size(91, 23);
            this.nmbCURR_PRICE.TabIndex = 436;
            this.nmbCURR_PRICE.Visible = false;
            // 
            // nmbCASHER_MAIN_VALUE
            // 
            this.nmbCASHER_MAIN_VALUE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbCASHER_MAIN_VALUE.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.nmbCASHER_MAIN_VALUE.DecimalPlaces = 0;
            this.nmbCASHER_MAIN_VALUE.DoubleValue = 0D;
            this.nmbCASHER_MAIN_VALUE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCASHER_MAIN_VALUE.Location = new System.Drawing.Point(247, 85);
            this.nmbCASHER_MAIN_VALUE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbCASHER_MAIN_VALUE.MinValue = 0D;
            this.nmbCASHER_MAIN_VALUE.Name = "nmbCASHER_MAIN_VALUE";
            this.nmbCASHER_MAIN_VALUE.NullString = "";
            this.nmbCASHER_MAIN_VALUE.NumberDecimalDigits = 0;
            this.nmbCASHER_MAIN_VALUE.Size = new System.Drawing.Size(98, 23);
            this.nmbCASHER_MAIN_VALUE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbCASHER_MAIN_VALUE.TabIndex = 437;
            this.nmbCASHER_MAIN_VALUE.Text = "0";
            this.nmbCASHER_MAIN_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbCASHER_MAIN_VALUE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCASHER_MAIN_VALUE.Visible = false;
            this.nmbCASHER_MAIN_VALUE.W_Clear = true;
            this.nmbCASHER_MAIN_VALUE.W_ColArName = "";
            this.nmbCASHER_MAIN_VALUE.W_ColEgName = "";
            this.nmbCASHER_MAIN_VALUE.W_OldValue = "";
            this.nmbCASHER_MAIN_VALUE.W_TableName = "";
            // 
            // txtExpAccId
            // 
            this.txtExpAccId.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtExpAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpAccId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtExpAccId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtExpAccId.Location = new System.Drawing.Point(233, 119);
            this.txtExpAccId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtExpAccId.Name = "txtExpAccId";
            this.txtExpAccId.Size = new System.Drawing.Size(38, 23);
            this.txtExpAccId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtExpAccId.TabIndex = 438;
            this.txtExpAccId.Visible = false;
            this.txtExpAccId.W_Clear = true;
            this.txtExpAccId.W_ColArName = "";
            this.txtExpAccId.W_ColEgName = "";
            this.txtExpAccId.W_OldValue = "";
            this.txtExpAccId.W_TableName = "";
            // 
            // txtTempletId
            // 
            this.txtTempletId.BeforeTouchSize = new System.Drawing.Size(141, 23);
            this.txtTempletId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTempletId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTempletId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtTempletId.Location = new System.Drawing.Point(479, 37);
            this.txtTempletId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTempletId.Name = "txtTempletId";
            this.txtTempletId.Size = new System.Drawing.Size(44, 23);
            this.txtTempletId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTempletId.TabIndex = 439;
            this.txtTempletId.Visible = false;
            this.txtTempletId.W_Clear = false;
            this.txtTempletId.W_ColArName = "";
            this.txtTempletId.W_ColEgName = "";
            this.txtTempletId.W_OldValue = "";
            this.txtTempletId.W_TableName = "";
            // 
            // frmPrecurementExpensess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(527, 452);
            this.Controls.Add(this.btnAddOperation);
            this.Controls.Add(this.txtTempletId);
            this.Controls.Add(this.txtExpAccId);
            this.Controls.Add(this.nmbCASHER_MAIN_VALUE);
            this.Controls.Add(this.nmbCURR_PRICE);
            this.Controls.Add(this.lstCURRENCY_ID);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.ckbADD_TO_COST);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.myLabel13);
            this.Controls.Add(this.myLabel12);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtDOCUMENT_No);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel25);
            this.Controls.Add(this.txtPEOPLE_ID);
            this.Controls.Add(this.txtEXPENSES_ID);
            this.Controls.Add(this.btnGetExpenss);
            this.Controls.Add(this.nmbExpenssItem);
            this.Controls.Add(this.myLabel26);
            this.Controls.Add(this.txtEXPENSES_Name);
            this.Controls.Add(this.myLabel27);
            this.Controls.Add(this.btnGetPeople);
            this.Controls.Add(this.txtPeopleName);
            this.Controls.Add(this.myLabel9);
            this.Controls.Add(this.dgvPrecuremenExp);
            this.Controls.Add(this.txtISSUED_TYPE);
            this.Controls.Add(this.txtISSUED_ID);
            this.Name = "frmPrecurementExpensess";
            this.Titel = "ادخال مصاريف";
            this.Load += new System.EventHandler(this.frmPrecurementExpensess_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.txtISSUED_ID, 0);
            this.Controls.SetChildIndex(this.txtISSUED_TYPE, 0);
            this.Controls.SetChildIndex(this.dgvPrecuremenExp, 0);
            this.Controls.SetChildIndex(this.myLabel9, 0);
            this.Controls.SetChildIndex(this.txtPeopleName, 0);
            this.Controls.SetChildIndex(this.btnGetPeople, 0);
            this.Controls.SetChildIndex(this.myLabel27, 0);
            this.Controls.SetChildIndex(this.txtEXPENSES_Name, 0);
            this.Controls.SetChildIndex(this.myLabel26, 0);
            this.Controls.SetChildIndex(this.nmbExpenssItem, 0);
            this.Controls.SetChildIndex(this.btnGetExpenss, 0);
            this.Controls.SetChildIndex(this.txtEXPENSES_ID, 0);
            this.Controls.SetChildIndex(this.txtPEOPLE_ID, 0);
            this.Controls.SetChildIndex(this.myLabel25, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtDOCUMENT_No, 0);
            this.Controls.SetChildIndex(this.txtNotes, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.myLabel13, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.ckbADD_TO_COST, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.lstCURRENCY_ID, 0);
            this.Controls.SetChildIndex(this.nmbCURR_PRICE, 0);
            this.Controls.SetChildIndex(this.nmbCASHER_MAIN_VALUE, 0);
            this.Controls.SetChildIndex(this.txtExpAccId, 0);
            this.Controls.SetChildIndex(this.txtTempletId, 0);
            this.Controls.SetChildIndex(this.btnAddOperation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISSUED_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISSUED_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecuremenExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeopleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpenssItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPEOPLE_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOCUMENT_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbADD_TO_COST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURR_PRICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHER_MAIN_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpAccId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempletId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private myDataGrid dgvPrecuremenExp;
        private myBottun btnGetPeople;
        private myText txtPeopleName;
        private myLabel myLabel9;
        private myText txtEXPENSES_ID;
        private myBottun btnGetExpenss;
        private myNumber nmbExpenssItem;
        private myLabel myLabel26;
        private myText txtEXPENSES_Name;
        private myLabel myLabel27;
        private myText txtPEOPLE_ID;
        private myText txtNotes;
        private myText txtDOCUMENT_No;
        private myLabel myLabel2;
        private myLabel myLabel25;
        private myBottun btnAddOperation;
        private myBottun btnSave;
        private myBottun btnClose;
        public myText txtISSUED_ID;
        public myText txtISSUED_TYPE;
        private myList lstAccName;
        private myList lstAccNo;
        private myLabel myLabel13;
        private myLabel myLabel12;
        private mycheck ckbADD_TO_COST;
        private myList lstCURRENCY_ID;
        private myLabel myLabel5;
        private System.Windows.Forms.NumericUpDown nmbCURR_PRICE;
        private myNumber nmbCASHER_MAIN_VALUE;
        private myText txtExpAccId;
        public myText txtTempletId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeopleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeopleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpensessId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpensessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpCurrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDoc_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddToCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccId;
    }
}
