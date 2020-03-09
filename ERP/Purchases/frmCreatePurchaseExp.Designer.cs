namespace ERP.Purchases
{
    partial class frmCreatePurchaseExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreatePurchaseExp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstAccName = new ERP.myList();
            this.lstAccNo = new ERP.myList();
            this.myLabel11 = new ERP.myLabel();
            this.myLabel10 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.btnSearch = new ERP.myBottun();
            this.txtEXPENSES_NAME = new ERP.myText();
            this.myLabel3 = new ERP.myLabel();
            this.lstEXPENSES_TYPE = new ERP.myList();
            this.myLabel4 = new ERP.myLabel();
            this.lstEXPENSESVALUE_OR_SIZE = new ERP.myList();
            this.txtEXPENSES_ItemSwid = new ERP.myText();
            this.btnSave = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnClose = new ERP.myBottun();
            this.btnNew = new ERP.myBottun();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pnlExpItem = new System.Windows.Forms.Panel();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pnlExpAgreement = new System.Windows.Forms.Panel();
            this.txtTermExpSwid = new ERP.myText();
            this.btnFindTermExp = new ERP.myBottun();
            this.btnUpdateTermExp = new ERP.myBottun();
            this.btnCloseTerm = new ERP.myBottun();
            this.btnSaveTermExp = new ERP.myBottun();
            this.btnNewTermExp = new ERP.myBottun();
            this.dgvExpAgreement = new ERP.myDataGrid();
            this.clmSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmExpItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalcMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTERMS_COD = new ERP.myText();
            this.txtTERMS_NAME = new ERP.myText();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_ItemSwid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.pnlExpItem.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.pnlExpAgreement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTermExpSwid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpAgreement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTERMS_COD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTERMS_NAME)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(107, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(20, 34);
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(110, 135);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(150, 24);
            this.lstAccName.TabIndex = 310;
            this.lstAccName.W_Clear = true;
            this.lstAccName.W_ColArName = "";
            this.lstAccName.W_ColEgName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.W_TableName = "";
            this.lstAccName.w_ValueType = ERP.myList.ValueType.VALUE;
            this.lstAccName.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(110, 105);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(150, 24);
            this.lstAccNo.TabIndex = 309;
            this.lstAccNo.W_Clear = true;
            this.lstAccNo.W_ColArName = "رقم الحساب";
            this.lstAccNo.W_ColEgName = "ACC_ID";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.W_TableName = "EXPENSES_ITEM";
            this.lstAccNo.w_ValueType = ERP.myList.ValueType.VALUE;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // myLabel11
            // 
            this.myLabel11.AutoSize = false;
            this.myLabel11.BackColor = System.Drawing.Color.Transparent;
            this.myLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel11.ForeColor = System.Drawing.Color.Black;
            this.myLabel11.Location = new System.Drawing.Point(269, 133);
            this.myLabel11.Name = "myLabel11";
            this.myLabel11.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel11.Size = new System.Drawing.Size(78, 18);
            this.myLabel11.TabIndex = 308;
            this.myLabel11.Text = "اسم الحساب";
            // 
            // myLabel10
            // 
            this.myLabel10.AutoSize = false;
            this.myLabel10.BackColor = System.Drawing.Color.Transparent;
            this.myLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel10.ForeColor = System.Drawing.Color.Black;
            this.myLabel10.Location = new System.Drawing.Point(277, 105);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel10.Size = new System.Drawing.Size(70, 18);
            this.myLabel10.TabIndex = 307;
            this.myLabel10.Text = "رقم الحساب";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(266, 14);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(84, 18);
            this.myLabel2.TabIndex = 311;
            this.myLabel2.Text = "اسم المصروف";
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
            this.btnSearch.Location = new System.Drawing.Point(72, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 316;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEXPENSES_NAME
            // 
            this.txtEXPENSES_NAME.BeforeTouchSize = new System.Drawing.Size(150, 25);
            this.txtEXPENSES_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEXPENSES_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEXPENSES_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtEXPENSES_NAME.Location = new System.Drawing.Point(110, 14);
            this.txtEXPENSES_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEXPENSES_NAME.Name = "txtEXPENSES_NAME";
            this.txtEXPENSES_NAME.Size = new System.Drawing.Size(150, 25);
            this.txtEXPENSES_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEXPENSES_NAME.TabIndex = 315;
            this.txtEXPENSES_NAME.W_Clear = true;
            this.txtEXPENSES_NAME.W_ColArName = "اسم المصروف";
            this.txtEXPENSES_NAME.W_ColEgName = "EXPENSES_NAME";
            this.txtEXPENSES_NAME.W_OldValue = "";
            this.txtEXPENSES_NAME.W_TableName = "EXPENSES_ITEM";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = false;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(266, 42);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(84, 18);
            this.myLabel3.TabIndex = 317;
            this.myLabel3.Text = "نوع المصروف";
            // 
            // lstEXPENSES_TYPE
            // 
            this.lstEXPENSES_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstEXPENSES_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstEXPENSES_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEXPENSES_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstEXPENSES_TYPE.FormattingEnabled = true;
            this.lstEXPENSES_TYPE.Items.AddRange(new object[] {
            "شراء",
            "تحاويل مخزنية",
            "بيع",
            "مصاريف مقدرة أخرى"});
            this.lstEXPENSES_TYPE.Location = new System.Drawing.Point(110, 45);
            this.lstEXPENSES_TYPE.Name = "lstEXPENSES_TYPE";
            this.lstEXPENSES_TYPE.Size = new System.Drawing.Size(150, 24);
            this.lstEXPENSES_TYPE.TabIndex = 318;
            this.lstEXPENSES_TYPE.W_Clear = true;
            this.lstEXPENSES_TYPE.W_ColArName = "نوع المصروف";
            this.lstEXPENSES_TYPE.W_ColEgName = "EXPENSES_TYPE";
            this.lstEXPENSES_TYPE.W_OldValue = "";
            this.lstEXPENSES_TYPE.W_TableName = "EXPENSES_ITEM";
            this.lstEXPENSES_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstEXPENSES_TYPE.SelectedIndexChanged += new System.EventHandler(this.lstEXPENSES_TYPE_SelectedIndexChanged);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(266, 73);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(81, 18);
            this.myLabel4.TabIndex = 319;
            this.myLabel4.Text = "طريقة الحساب";
            // 
            // lstEXPENSESVALUE_OR_SIZE
            // 
            this.lstEXPENSESVALUE_OR_SIZE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstEXPENSESVALUE_OR_SIZE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstEXPENSESVALUE_OR_SIZE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEXPENSESVALUE_OR_SIZE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstEXPENSESVALUE_OR_SIZE.FormattingEnabled = true;
            this.lstEXPENSESVALUE_OR_SIZE.Items.AddRange(new object[] {
            "قيمة",
            "حجم"});
            this.lstEXPENSESVALUE_OR_SIZE.Location = new System.Drawing.Point(110, 75);
            this.lstEXPENSESVALUE_OR_SIZE.Name = "lstEXPENSESVALUE_OR_SIZE";
            this.lstEXPENSESVALUE_OR_SIZE.Size = new System.Drawing.Size(150, 24);
            this.lstEXPENSESVALUE_OR_SIZE.TabIndex = 320;
            this.lstEXPENSESVALUE_OR_SIZE.W_Clear = true;
            this.lstEXPENSESVALUE_OR_SIZE.W_ColArName = "طريقة الحساب";
            this.lstEXPENSESVALUE_OR_SIZE.W_ColEgName = "EXPENSESVALUE_OR_SIZE";
            this.lstEXPENSESVALUE_OR_SIZE.W_OldValue = "";
            this.lstEXPENSESVALUE_OR_SIZE.W_TableName = "EXPENSES_ITEM";
            this.lstEXPENSESVALUE_OR_SIZE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // txtEXPENSES_ItemSwid
            // 
            this.txtEXPENSES_ItemSwid.BeforeTouchSize = new System.Drawing.Size(150, 25);
            this.txtEXPENSES_ItemSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEXPENSES_ItemSwid.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEXPENSES_ItemSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtEXPENSES_ItemSwid.Location = new System.Drawing.Point(24, 16);
            this.txtEXPENSES_ItemSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEXPENSES_ItemSwid.Name = "txtEXPENSES_ItemSwid";
            this.txtEXPENSES_ItemSwid.Size = new System.Drawing.Size(42, 25);
            this.txtEXPENSES_ItemSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEXPENSES_ItemSwid.TabIndex = 325;
            this.txtEXPENSES_ItemSwid.Visible = false;
            this.txtEXPENSES_ItemSwid.W_Clear = true;
            this.txtEXPENSES_ItemSwid.W_ColArName = "اسم دخول المستخدم";
            this.txtEXPENSES_ItemSwid.W_ColEgName = "USER_LOGIN";
            this.txtEXPENSES_ItemSwid.W_OldValue = "";
            this.txtEXPENSES_ItemSwid.W_TableName = "USERINFO";
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
            this.btnSave.Location = new System.Drawing.Point(204, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 324;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.IsBackStageButton = false;
            this.btnUpdate.Location = new System.Drawing.Point(146, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 323;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnClose.Location = new System.Drawing.Point(92, 165);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 322;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnClose.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.IsBackStageButton = false;
            this.btnNew.Location = new System.Drawing.Point(278, 156);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 321;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.White;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(377, 344);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.BorderVisible = true;
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 29);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(377, 344);
            this.tabControlAdv1.TabIndex = 326;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererWorkbookMode);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.pnlExpItem);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(5, 34);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(367, 305);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "مصاريف الاصناف";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // pnlExpItem
            // 
            this.pnlExpItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpItem.Controls.Add(this.txtEXPENSES_ItemSwid);
            this.pnlExpItem.Controls.Add(this.btnSearch);
            this.pnlExpItem.Controls.Add(this.btnUpdate);
            this.pnlExpItem.Controls.Add(this.btnClose);
            this.pnlExpItem.Controls.Add(this.btnSave);
            this.pnlExpItem.Controls.Add(this.btnNew);
            this.pnlExpItem.Controls.Add(this.myLabel2);
            this.pnlExpItem.Controls.Add(this.myLabel10);
            this.pnlExpItem.Controls.Add(this.lstEXPENSESVALUE_OR_SIZE);
            this.pnlExpItem.Controls.Add(this.myLabel11);
            this.pnlExpItem.Controls.Add(this.lstEXPENSES_TYPE);
            this.pnlExpItem.Controls.Add(this.myLabel4);
            this.pnlExpItem.Controls.Add(this.myLabel3);
            this.pnlExpItem.Controls.Add(this.txtEXPENSES_NAME);
            this.pnlExpItem.Controls.Add(this.lstAccName);
            this.pnlExpItem.Controls.Add(this.lstAccNo);
            this.pnlExpItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExpItem.Location = new System.Drawing.Point(0, 0);
            this.pnlExpItem.Name = "pnlExpItem";
            this.pnlExpItem.Size = new System.Drawing.Size(367, 305);
            this.pnlExpItem.TabIndex = 183;
            this.pnlExpItem.Tag = "TAB";
            this.pnlExpItem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGnrlSetting_Paint);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.pnlExpAgreement);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(5, 34);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(367, 305);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "اتفاقية المصاريف";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // pnlExpAgreement
            // 
            this.pnlExpAgreement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpAgreement.Controls.Add(this.txtTermExpSwid);
            this.pnlExpAgreement.Controls.Add(this.btnFindTermExp);
            this.pnlExpAgreement.Controls.Add(this.btnUpdateTermExp);
            this.pnlExpAgreement.Controls.Add(this.btnCloseTerm);
            this.pnlExpAgreement.Controls.Add(this.btnSaveTermExp);
            this.pnlExpAgreement.Controls.Add(this.btnNewTermExp);
            this.pnlExpAgreement.Controls.Add(this.dgvExpAgreement);
            this.pnlExpAgreement.Controls.Add(this.txtTERMS_COD);
            this.pnlExpAgreement.Controls.Add(this.txtTERMS_NAME);
            this.pnlExpAgreement.Controls.Add(this.myLabel6);
            this.pnlExpAgreement.Controls.Add(this.myLabel5);
            this.pnlExpAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExpAgreement.Location = new System.Drawing.Point(0, 0);
            this.pnlExpAgreement.Name = "pnlExpAgreement";
            this.pnlExpAgreement.Size = new System.Drawing.Size(367, 305);
            this.pnlExpAgreement.TabIndex = 181;
            this.pnlExpAgreement.Tag = "TAB";
            this.pnlExpAgreement.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAccount_Paint);
            // 
            // txtTermExpSwid
            // 
            this.txtTermExpSwid.BeforeTouchSize = new System.Drawing.Size(150, 25);
            this.txtTermExpSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTermExpSwid.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTermExpSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtTermExpSwid.Location = new System.Drawing.Point(36, 36);
            this.txtTermExpSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTermExpSwid.Name = "txtTermExpSwid";
            this.txtTermExpSwid.Size = new System.Drawing.Size(42, 25);
            this.txtTermExpSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTermExpSwid.TabIndex = 330;
            this.txtTermExpSwid.Visible = false;
            this.txtTermExpSwid.W_Clear = true;
            this.txtTermExpSwid.W_ColArName = "اسم دخول المستخدم";
            this.txtTermExpSwid.W_ColEgName = "USER_LOGIN";
            this.txtTermExpSwid.W_OldValue = "";
            this.txtTermExpSwid.W_TableName = "USERINFO";
            // 
            // btnFindTermExp
            // 
            this.btnFindTermExp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindTermExp.BackgroundImage")));
            this.btnFindTermExp.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFindTermExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindTermExp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindTermExp.FlatAppearance.BorderSize = 0;
            this.btnFindTermExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindTermExp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFindTermExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindTermExp.Image = ((System.Drawing.Image)(resources.GetObject("btnFindTermExp.Image")));
            this.btnFindTermExp.IsBackStageButton = false;
            this.btnFindTermExp.Location = new System.Drawing.Point(108, 10);
            this.btnFindTermExp.Name = "btnFindTermExp";
            this.btnFindTermExp.Size = new System.Drawing.Size(28, 27);
            this.btnFindTermExp.TabIndex = 329;
            this.btnFindTermExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindTermExp.UseVisualStyleBackColor = true;
            this.btnFindTermExp.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFindTermExp.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFindTermExp.Click += new System.EventHandler(this.btnFindTermExp_Click);
            // 
            // btnUpdateTermExp
            // 
            this.btnUpdateTermExp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateTermExp.BackgroundImage")));
            this.btnUpdateTermExp.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnUpdateTermExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateTermExp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdateTermExp.FlatAppearance.BorderSize = 0;
            this.btnUpdateTermExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTermExp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdateTermExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdateTermExp.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTermExp.Image")));
            this.btnUpdateTermExp.IsBackStageButton = false;
            this.btnUpdateTermExp.Location = new System.Drawing.Point(58, 271);
            this.btnUpdateTermExp.Name = "btnUpdateTermExp";
            this.btnUpdateTermExp.Size = new System.Drawing.Size(57, 28);
            this.btnUpdateTermExp.TabIndex = 327;
            this.btnUpdateTermExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateTermExp.UseVisualStyleBackColor = true;
            this.btnUpdateTermExp.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdateTermExp.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdateTermExp.Click += new System.EventHandler(this.btnUpdateTermExp_Click);
            // 
            // btnCloseTerm
            // 
            this.btnCloseTerm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseTerm.BackgroundImage")));
            this.btnCloseTerm.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnCloseTerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseTerm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnCloseTerm.FlatAppearance.BorderSize = 0;
            this.btnCloseTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTerm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCloseTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnCloseTerm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseTerm.Image")));
            this.btnCloseTerm.IsBackStageButton = false;
            this.btnCloseTerm.Location = new System.Drawing.Point(4, 271);
            this.btnCloseTerm.Name = "btnCloseTerm";
            this.btnCloseTerm.Size = new System.Drawing.Size(57, 28);
            this.btnCloseTerm.TabIndex = 326;
            this.btnCloseTerm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseTerm.UseVisualStyleBackColor = true;
            this.btnCloseTerm.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnCloseTerm.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // btnSaveTermExp
            // 
            this.btnSaveTermExp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveTermExp.BackgroundImage")));
            this.btnSaveTermExp.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnSaveTermExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTermExp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSaveTermExp.FlatAppearance.BorderSize = 0;
            this.btnSaveTermExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTermExp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveTermExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSaveTermExp.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveTermExp.Image")));
            this.btnSaveTermExp.IsBackStageButton = false;
            this.btnSaveTermExp.Location = new System.Drawing.Point(116, 271);
            this.btnSaveTermExp.Name = "btnSaveTermExp";
            this.btnSaveTermExp.Size = new System.Drawing.Size(57, 28);
            this.btnSaveTermExp.TabIndex = 328;
            this.btnSaveTermExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTermExp.UseVisualStyleBackColor = true;
            this.btnSaveTermExp.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSaveTermExp.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSaveTermExp.Click += new System.EventHandler(this.btnSaveTermExp_Click);
            // 
            // btnNewTermExp
            // 
            this.btnNewTermExp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewTermExp.BackgroundImage")));
            this.btnNewTermExp.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnNewTermExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTermExp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNewTermExp.FlatAppearance.BorderSize = 0;
            this.btnNewTermExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTermExp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewTermExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNewTermExp.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTermExp.Image")));
            this.btnNewTermExp.IsBackStageButton = false;
            this.btnNewTermExp.Location = new System.Drawing.Point(192, 271);
            this.btnNewTermExp.Name = "btnNewTermExp";
            this.btnNewTermExp.Size = new System.Drawing.Size(57, 28);
            this.btnNewTermExp.TabIndex = 325;
            this.btnNewTermExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewTermExp.UseVisualStyleBackColor = true;
            this.btnNewTermExp.Visible = false;
            this.btnNewTermExp.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNewTermExp.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNewTermExp.Click += new System.EventHandler(this.btnNewTermExp_Click);
            // 
            // dgvExpAgreement
            // 
            this.dgvExpAgreement.AllowUserToAddRows = false;
            this.dgvExpAgreement.AllowUserToDeleteRows = false;
            this.dgvExpAgreement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpAgreement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpAgreement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpAgreement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSwid,
            this.clmSelect,
            this.clmExpItemId,
            this.clmExpName,
            this.clmCalcMethod});
            this.dgvExpAgreement.EnableHeadersVisualStyles = false;
            this.dgvExpAgreement.Location = new System.Drawing.Point(4, 72);
            this.dgvExpAgreement.Name = "dgvExpAgreement";
            this.dgvExpAgreement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvExpAgreement.RowHeadersVisible = false;
            this.dgvExpAgreement.Size = new System.Drawing.Size(358, 193);
            this.dgvExpAgreement.TabIndex = 318;
            this.dgvExpAgreement.W_Clear = true;
            // 
            // clmSwid
            // 
            this.clmSwid.HeaderText = "swid";
            this.clmSwid.Name = "clmSwid";
            this.clmSwid.ReadOnly = true;
            this.clmSwid.Visible = false;
            // 
            // clmSelect
            // 
            this.clmSelect.HeaderText = "تحديد";
            this.clmSelect.Name = "clmSelect";
            this.clmSelect.Width = 50;
            // 
            // clmExpItemId
            // 
            this.clmExpItemId.HeaderText = "Expeness_item_id";
            this.clmExpItemId.Name = "clmExpItemId";
            this.clmExpItemId.ReadOnly = true;
            this.clmExpItemId.Visible = false;
            // 
            // clmExpName
            // 
            this.clmExpName.HeaderText = "اسم المصروف";
            this.clmExpName.Name = "clmExpName";
            this.clmExpName.ReadOnly = true;
            this.clmExpName.Width = 150;
            // 
            // clmCalcMethod
            // 
            this.clmCalcMethod.HeaderText = "طريقة الحساب";
            this.clmCalcMethod.Name = "clmCalcMethod";
            this.clmCalcMethod.ReadOnly = true;
            this.clmCalcMethod.Width = 150;
            // 
            // txtTERMS_COD
            // 
            this.txtTERMS_COD.BeforeTouchSize = new System.Drawing.Size(150, 25);
            this.txtTERMS_COD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTERMS_COD.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTERMS_COD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtTERMS_COD.Location = new System.Drawing.Point(142, 41);
            this.txtTERMS_COD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTERMS_COD.Name = "txtTERMS_COD";
            this.txtTERMS_COD.Size = new System.Drawing.Size(150, 25);
            this.txtTERMS_COD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTERMS_COD.TabIndex = 317;
            this.txtTERMS_COD.W_Clear = true;
            this.txtTERMS_COD.W_ColArName = "اسم المصروف";
            this.txtTERMS_COD.W_ColEgName = "EXPENSES_NAME";
            this.txtTERMS_COD.W_OldValue = "";
            this.txtTERMS_COD.W_TableName = "EXPENSES_ITEM";
            // 
            // txtTERMS_NAME
            // 
            this.txtTERMS_NAME.BeforeTouchSize = new System.Drawing.Size(150, 25);
            this.txtTERMS_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTERMS_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTERMS_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtTERMS_NAME.Location = new System.Drawing.Point(142, 10);
            this.txtTERMS_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTERMS_NAME.Name = "txtTERMS_NAME";
            this.txtTERMS_NAME.Size = new System.Drawing.Size(150, 25);
            this.txtTERMS_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTERMS_NAME.TabIndex = 316;
            this.txtTERMS_NAME.W_Clear = true;
            this.txtTERMS_NAME.W_ColArName = "اسم المصروف";
            this.txtTERMS_NAME.W_ColEgName = "EXPENSES_NAME";
            this.txtTERMS_NAME.W_OldValue = "";
            this.txtTERMS_NAME.W_TableName = "EXPENSES_ITEM";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = false;
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(298, 43);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(58, 18);
            this.myLabel6.TabIndex = 313;
            this.myLabel6.Text = "الكود";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = false;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(285, 15);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(77, 18);
            this.myLabel5.TabIndex = 312;
            this.myLabel5.Text = "اسم الاتفاق";
            // 
            // frmCreatePurchaseExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 372);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "frmCreatePurchaseExp";
            this.Text = "frmCreatePurchaseExp";
            this.Titel = "بنود المصاريف";
            this.Load += new System.EventHandler(this.frmCreatePurchaseExp_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.tabControlAdv1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEXPENSES_ItemSwid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.pnlExpItem.ResumeLayout(false);
            this.pnlExpItem.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            this.pnlExpAgreement.ResumeLayout(false);
            this.pnlExpAgreement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTermExpSwid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpAgreement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTERMS_COD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTERMS_NAME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myList lstAccName;
        private myList lstAccNo;
        private myLabel myLabel11;
        private myLabel myLabel10;
        private myLabel myLabel2;
        private myBottun btnSearch;
        private myText txtEXPENSES_NAME;
        private myLabel myLabel3;
        private myList lstEXPENSES_TYPE;
        private myLabel myLabel4;
        private myList lstEXPENSESVALUE_OR_SIZE;
        private myText txtEXPENSES_ItemSwid;
        private myBottun btnSave;
        private myBottun btnUpdate;
        private myBottun btnClose;
        private myBottun btnNew;
        private System.Windows.Forms.ErrorProvider errCheck;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private System.Windows.Forms.Panel pnlExpItem;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private System.Windows.Forms.Panel pnlExpAgreement;
        private myLabel myLabel6;
        private myLabel myLabel5;
        private myText txtTERMS_COD;
        private myText txtTERMS_NAME;
        private myBottun btnUpdateTermExp;
        private myBottun btnCloseTerm;
        private myBottun btnSaveTermExp;
        private myBottun btnNewTermExp;
        private myDataGrid dgvExpAgreement;
        private myText txtTermExpSwid;
        private myBottun btnFindTermExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSwid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCalcMethod;
    }
}