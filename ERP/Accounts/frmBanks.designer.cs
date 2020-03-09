

namespace ERP.Accounts
{
    partial class frmBanks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanks));
            this.lstAccName = new ERP.myList();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.txtAccNo = new ERP.myText();
            this.myLabel12 = new ERP.myLabel();
            this.dgCurrency = new ERP.myDataGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSelectCurr = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstAccNo = new ERP.myList();
            this.myLabel4 = new ERP.myLabel();
            this.txtAccId = new ERP.myText();
            this.dgvBank = new ERP.myDataGrid();
            this.clmSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmACCOUNTS_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmACCOUNTS_NUM_Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmACC_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPartnerAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.lstAccType = new ERP.myList();
            this.txtAccNoBank = new ERP.myText();
            this.btnAdd = new ERP.myBottun();
            this.lstBankName = new ERP.myList();
            this.dgBranches = new ERP.myDataGrid();
            this.clmBranchAccSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSelBranch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmBranchSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveBank = new ERP.myBottun();
            this.myLabel7 = new ERP.myLabel();
            this.lstACC_NATURE = new ERP.myList();
            this.dgAddressBook = new ERP.myDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJobButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddAddressBook = new ERP.myBottun();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNoBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddressBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(266, 34);
            this.lstTemplet.SelectedIndexChanged += new System.EventHandler(this.lstTemplet_SelectedIndexChanged);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(179, 34);
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(98, 134);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(124, 24);
            this.lstAccName.TabIndex = 216;
            this.lstAccName.W_Clear = true;
            this.lstAccName.W_ColArName = "";
            this.lstAccName.W_ColEgName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.W_TableName = "";
            this.lstAccName.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccName.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(9, 136);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(86, 18);
            this.myLabel6.TabIndex = 215;
            this.myLabel6.Text = "اسم حساب الاب";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(155, 69);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(54, 18);
            this.myLabel2.TabIndex = 213;
            this.myLabel2.Text = "اسم البنك";
            // 
            // txtAccNo
            // 
            this.txtAccNo.BeforeTouchSize = new System.Drawing.Size(44, 23);
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAccNo.Location = new System.Drawing.Point(98, 162);
            this.txtAccNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(124, 23);
            this.txtAccNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAccNo.TabIndex = 212;
            this.txtAccNo.W_Clear = true;
            this.txtAccNo.W_ColArName = "";
            this.txtAccNo.W_ColEgName = "";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.W_TableName = "";
            // 
            // myLabel12
            // 
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(29, 164);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(67, 18);
            this.myLabel12.TabIndex = 211;
            this.myLabel12.Text = "رقم الحساب";
            // 
            // dgCurrency
            // 
            this.dgCurrency.AllowUserToAddRows = false;
            this.dgCurrency.AllowUserToDeleteRows = false;
            this.dgCurrency.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCurrency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.clmSelectCurr,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dgCurrency.EnableHeadersVisualStyles = false;
            this.dgCurrency.Location = new System.Drawing.Point(460, 187);
            this.dgCurrency.Name = "dgCurrency";
            this.dgCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCurrency.RowHeadersVisible = false;
            this.dgCurrency.Size = new System.Drawing.Size(212, 146);
            this.dgCurrency.TabIndex = 224;
            this.dgCurrency.W_Clear = true;
            this.dgCurrency.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCurrency_CellValueChanged);
            this.dgCurrency.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgCurrency_CurrentCellDirtyStateChanged);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "swid";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Visible = false;
            // 
            // clmSelectCurr
            // 
            this.clmSelectCurr.HeaderText = "اختيار";
            this.clmSelectCurr.Name = "clmSelectCurr";
            this.clmSelectCurr.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "رقم العملة";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "العملة";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "رقم حساب البنك";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "رقم حساب البنك القديم";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(97, 104);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(125, 24);
            this.lstAccNo.TabIndex = 226;
            this.lstAccNo.W_Clear = true;
            this.lstAccNo.W_ColArName = "";
            this.lstAccNo.W_ColEgName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.W_TableName = "";
            this.lstAccNo.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            this.lstAccNo.Click += new System.EventHandler(this.lstAccNo_Click);
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(9, 108);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(84, 18);
            this.myLabel4.TabIndex = 225;
            this.myLabel4.Text = "رقم حساب الاب";
            // 
            // txtAccId
            // 
            this.txtAccId.BeforeTouchSize = new System.Drawing.Size(44, 23);
            this.txtAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAccId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAccId.Location = new System.Drawing.Point(179, 162);
            this.txtAccId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAccId.Name = "txtAccId";
            this.txtAccId.Size = new System.Drawing.Size(41, 23);
            this.txtAccId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAccId.TabIndex = 227;
            this.txtAccId.Visible = false;
            this.txtAccId.W_Clear = true;
            this.txtAccId.W_ColArName = "";
            this.txtAccId.W_ColEgName = "";
            this.txtAccId.W_OldValue = "";
            this.txtAccId.W_TableName = "";
            // 
            // dgvBank
            // 
            this.dgvBank.AllowUserToAddRows = false;
            this.dgvBank.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSwid,
            this.clmACCOUNTS_TYPE,
            this.clmACCOUNTS_NUM_Bank,
            this.clmACC_ID,
            this.clmAccNo,
            this.clmPartnerAccId});
            this.dgvBank.EnableHeadersVisualStyles = false;
            this.dgvBank.Location = new System.Drawing.Point(9, 187);
            this.dgvBank.Name = "dgvBank";
            this.dgvBank.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvBank.RowHeadersVisible = false;
            this.dgvBank.Size = new System.Drawing.Size(447, 332);
            this.dgvBank.TabIndex = 229;
            this.dgvBank.W_Clear = true;
            this.dgvBank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBank_CellClick);
            // 
            // clmSwid
            // 
            this.clmSwid.HeaderText = "تعريف الصف";
            this.clmSwid.Name = "clmSwid";
            this.clmSwid.ReadOnly = true;
            this.clmSwid.Visible = false;
            // 
            // clmACCOUNTS_TYPE
            // 
            this.clmACCOUNTS_TYPE.HeaderText = "نوع الحساب";
            this.clmACCOUNTS_TYPE.Name = "clmACCOUNTS_TYPE";
            // 
            // clmACCOUNTS_NUM_Bank
            // 
            this.clmACCOUNTS_NUM_Bank.HeaderText = "رقم الحساب(البنك)";
            this.clmACCOUNTS_NUM_Bank.Name = "clmACCOUNTS_NUM_Bank";
            this.clmACCOUNTS_NUM_Bank.ReadOnly = true;
            this.clmACCOUNTS_NUM_Bank.Width = 120;
            // 
            // clmACC_ID
            // 
            this.clmACC_ID.HeaderText = "تعريف رقم الحساب";
            this.clmACC_ID.Name = "clmACC_ID";
            this.clmACC_ID.ReadOnly = true;
            this.clmACC_ID.Visible = false;
            // 
            // clmAccNo
            // 
            this.clmAccNo.HeaderText = "رقم الحساب";
            this.clmAccNo.Name = "clmAccNo";
            this.clmAccNo.ReadOnly = true;
            // 
            // clmPartnerAccId
            // 
            this.clmPartnerAccId.HeaderText = "رقم حساب الاب";
            this.clmPartnerAccId.Name = "clmPartnerAccId";
            this.clmPartnerAccId.ReadOnly = true;
            this.clmPartnerAccId.Visible = false;
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(230, 104);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(70, 18);
            this.myLabel3.TabIndex = 230;
            this.myLabel3.Text = "نوع الحساب";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(224, 134);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(116, 18);
            this.myLabel5.TabIndex = 231;
            this.myLabel5.Text = "رقم الحساب عند البنك";
            // 
            // lstAccType
            // 
            this.lstAccType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccType.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccType.FormattingEnabled = true;
            this.lstAccType.Items.AddRange(new object[] {
            "وديعة",
            "توفير",
            "جاري"});
            this.lstAccType.Location = new System.Drawing.Point(345, 102);
            this.lstAccType.Name = "lstAccType";
            this.lstAccType.Size = new System.Drawing.Size(111, 24);
            this.lstAccType.TabIndex = 319;
            this.lstAccType.W_Clear = true;
            this.lstAccType.W_ColArName = "";
            this.lstAccType.W_ColEgName = "";
            this.lstAccType.W_OldValue = "";
            this.lstAccType.W_TableName = "";
            this.lstAccType.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // txtAccNoBank
            // 
            this.txtAccNoBank.BeforeTouchSize = new System.Drawing.Size(44, 23);
            this.txtAccNoBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNoBank.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAccNoBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAccNoBank.Location = new System.Drawing.Point(345, 132);
            this.txtAccNoBank.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAccNoBank.Name = "txtAccNoBank";
            this.txtAccNoBank.Size = new System.Drawing.Size(111, 23);
            this.txtAccNoBank.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAccNoBank.TabIndex = 320;
            this.txtAccNoBank.W_Clear = true;
            this.txtAccNoBank.W_ColArName = "";
            this.txtAccNoBank.W_ColEgName = "";
            this.txtAccNoBank.W_OldValue = "";
            this.txtAccNoBank.W_TableName = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(36, 25);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.IsBackStageButton = false;
            this.btnAdd.Location = new System.Drawing.Point(223, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 25);
            this.btnAdd.TabIndex = 428;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBankName
            // 
            this.lstBankName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBankName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBankName.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBankName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstBankName.FormattingEnabled = true;
            this.lstBankName.Location = new System.Drawing.Point(215, 65);
            this.lstBankName.Name = "lstBankName";
            this.lstBankName.Size = new System.Drawing.Size(169, 24);
            this.lstBankName.TabIndex = 429;
            this.lstBankName.W_Clear = false;
            this.lstBankName.W_ColArName = "";
            this.lstBankName.W_ColEgName = "";
            this.lstBankName.W_OldValue = "";
            this.lstBankName.W_TableName = "";
            this.lstBankName.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstBankName.SelectedIndexChanged += new System.EventHandler(this.lstBankName_SelectedIndexChanged);
            // 
            // dgBranches
            // 
            this.dgBranches.AllowUserToAddRows = false;
            this.dgBranches.AllowUserToDeleteRows = false;
            this.dgBranches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgBranches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBranches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBranchAccSwid,
            this.clmSelBranch,
            this.clmBranchSwid,
            this.clmBranchName});
            this.dgBranches.EnableHeadersVisualStyles = false;
            this.dgBranches.Location = new System.Drawing.Point(461, 339);
            this.dgBranches.Name = "dgBranches";
            this.dgBranches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgBranches.RowHeadersVisible = false;
            this.dgBranches.Size = new System.Drawing.Size(212, 180);
            this.dgBranches.TabIndex = 430;
            this.dgBranches.W_Clear = true;
            this.dgBranches.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBranches_CellValueChanged);
            this.dgBranches.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgBranches_CurrentCellDirtyStateChanged);
            // 
            // clmBranchAccSwid
            // 
            this.clmBranchAccSwid.HeaderText = "swid";
            this.clmBranchAccSwid.Name = "clmBranchAccSwid";
            this.clmBranchAccSwid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBranchAccSwid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmBranchAccSwid.Visible = false;
            // 
            // clmSelBranch
            // 
            this.clmSelBranch.HeaderText = "اختيار";
            this.clmSelBranch.Name = "clmSelBranch";
            this.clmSelBranch.Width = 50;
            // 
            // clmBranchSwid
            // 
            this.clmBranchSwid.HeaderText = "branchId";
            this.clmBranchSwid.Name = "clmBranchSwid";
            this.clmBranchSwid.ReadOnly = true;
            this.clmBranchSwid.Visible = false;
            // 
            // clmBranchName
            // 
            this.clmBranchName.HeaderText = "اسم الفرع";
            this.clmBranchName.Name = "clmBranchName";
            this.clmBranchName.ReadOnly = true;
            this.clmBranchName.Width = 120;
            // 
            // btnSaveBank
            // 
            this.btnSaveBank.BeforeTouchSize = new System.Drawing.Size(29, 28);
            this.btnSaveBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBank.FlatAppearance.BorderSize = 0;
            this.btnSaveBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBank.Image = global::ERP.Properties.Resources.sm_05;
            this.btnSaveBank.IsBackStageButton = false;
            this.btnSaveBank.Location = new System.Drawing.Point(390, 64);
            this.btnSaveBank.Name = "btnSaveBank";
            this.btnSaveBank.Size = new System.Drawing.Size(29, 28);
            this.btnSaveBank.TabIndex = 431;
            this.btnSaveBank.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnSaveBank.w_Type = ERP.myBottun.Btton_type.none;
            this.btnSaveBank.Click += new System.EventHandler(this.btnSaveBank_Click);
            // 
            // myLabel7
            // 
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(265, 162);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(78, 18);
            this.myLabel7.TabIndex = 432;
            this.myLabel7.Text = "طبيعة الحساب";
            // 
            // lstACC_NATURE
            // 
            this.lstACC_NATURE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstACC_NATURE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstACC_NATURE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstACC_NATURE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstACC_NATURE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstACC_NATURE.FormattingEnabled = true;
            this.lstACC_NATURE.Items.AddRange(new object[] {
            "مدين",
            "دائن",
            "مدين/دائن"});
            this.lstACC_NATURE.Location = new System.Drawing.Point(345, 157);
            this.lstACC_NATURE.Name = "lstACC_NATURE";
            this.lstACC_NATURE.Size = new System.Drawing.Size(111, 26);
            this.lstACC_NATURE.TabIndex = 433;
            this.lstACC_NATURE.W_Clear = true;
            this.lstACC_NATURE.W_ColArName = "طبيعة الحساب";
            this.lstACC_NATURE.W_ColEgName = "acc_nature";
            this.lstACC_NATURE.W_OldValue = "";
            this.lstACC_NATURE.W_TableName = "ACCOUNTS";
            this.lstACC_NATURE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // dgAddressBook
            // 
            this.dgAddressBook.AllowUserToAddRows = false;
            this.dgAddressBook.AllowUserToDeleteRows = false;
            this.dgAddressBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgAddressBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAddressBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAddressBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddressBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.clmJobButton,
            this.dataGridViewImageColumn1});
            this.dgAddressBook.EnableHeadersVisualStyles = false;
            this.dgAddressBook.Location = new System.Drawing.Point(461, 29);
            this.dgAddressBook.Name = "dgAddressBook";
            this.dgAddressBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgAddressBook.RowHeadersVisible = false;
            this.dgAddressBook.Size = new System.Drawing.Size(237, 153);
            this.dgAddressBook.TabIndex = 435;
            this.dgAddressBook.W_Clear = true;
            this.dgAddressBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAddressBook_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "addId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الاسم";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // clmJobButton
            // 
            this.clmJobButton.HeaderText = "الوظيفة";
            this.clmJobButton.Name = "clmJobButton";
            this.clmJobButton.ReadOnly = true;
            this.clmJobButton.Width = 80;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "حذف";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // btnAddAddressBook
            // 
            this.btnAddAddressBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAddressBook.BackgroundImage")));
            this.btnAddAddressBook.BeforeTouchSize = new System.Drawing.Size(36, 25);
            this.btnAddAddressBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAddressBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddAddressBook.FlatAppearance.BorderSize = 0;
            this.btnAddAddressBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAddressBook.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddAddressBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddAddressBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAddressBook.Image")));
            this.btnAddAddressBook.IsBackStageButton = false;
            this.btnAddAddressBook.Location = new System.Drawing.Point(423, 29);
            this.btnAddAddressBook.Name = "btnAddAddressBook";
            this.btnAddAddressBook.Size = new System.Drawing.Size(36, 25);
            this.btnAddAddressBook.TabIndex = 436;
            this.btnAddAddressBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAddressBook.UseVisualStyleBackColor = true;
            this.btnAddAddressBook.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAddAddressBook.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAddAddressBook.Click += new System.EventHandler(this.btnAddAddressBook_Click);
            // 
            // frmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(700, 527);
            this.Controls.Add(this.btnAddAddressBook);
            this.Controls.Add(this.dgAddressBook);
            this.Controls.Add(this.lstACC_NATURE);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.btnSaveBank);
            this.Controls.Add(this.dgBranches);
            this.Controls.Add(this.lstBankName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAccNoBank);
            this.Controls.Add(this.lstAccType);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.dgvBank);
            this.Controls.Add(this.txtAccId);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.dgCurrency);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.myLabel12);
            this.Name = "frmBanks";
            this.Titel = "تعريف البنوك";
            this.Load += new System.EventHandler(this.frmBanks_Load);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.txtAccNo, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.dgCurrency, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.txtAccId, 0);
            this.Controls.SetChildIndex(this.dgvBank, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.lstAccType, 0);
            this.Controls.SetChildIndex(this.txtAccNoBank, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.lstBankName, 0);
            this.Controls.SetChildIndex(this.dgBranches, 0);
            this.Controls.SetChildIndex(this.btnSaveBank, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.lstACC_NATURE, 0);
            this.Controls.SetChildIndex(this.dgAddressBook, 0);
            this.Controls.SetChildIndex(this.btnAddAddressBook, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNoBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddressBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ERP.myList lstAccName;
        private ERP.myLabel myLabel6;
        private ERP.myLabel myLabel2;
        private ERP.myText txtAccNo;
        private ERP.myLabel myLabel12;
        private ERP.myDataGrid dgCurrency;
        private System.Windows.Forms.ErrorProvider errCheck;
        private ERP.myList lstAccNo;
        private ERP.myLabel myLabel4;
        private ERP.myText txtAccId;
        private myLabel myLabel5;
        private myLabel myLabel3;
        private myDataGrid dgvBank;
        private myText txtAccNoBank;
        private myList lstAccType;
        private myBottun btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmACCOUNTS_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmACCOUNTS_NUM_Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmACC_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPartnerAccId;
        private myList lstBankName;
        private myDataGrid dgBranches;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBranchAccSwid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBranchSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBranchName;
        private myBottun btnSaveBank;
        private myLabel myLabel7;
        private myList lstACC_NATURE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelectCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private myDataGrid dgAddressBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn clmJobButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private myBottun btnAddAddressBook;
    }
}
