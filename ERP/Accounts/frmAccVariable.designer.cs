

namespace ERP.Accounts
{
    partial class frmAccVariable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccVariable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nmbValue = new ERP.myNumber();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pnlGnrlSetting = new System.Windows.Forms.Panel();
            this.btnSave = new ERP.myBottun();
            this.btnAdd = new ERP.myBottun();
            this.dgLevels = new ERP.myDataGrid();
            this.COL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbTHE_VALUE = new ERP.myNumber();
            this.myLabel2 = new ERP.myLabel();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.myLabel4 = new ERP.myLabel();
            this.ckbAdministation = new System.Windows.Forms.CheckBox();
            this.ckbBranch = new System.Windows.Forms.CheckBox();
            this.myLabel3 = new ERP.myLabel();
            this.txtCostCenterName = new ERP.myText();
            this.txtCostCenterNote = new ERP.myText();
            this.dgvCostCenter = new ERP.myDataGrid();
            this.clmCostCenterSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBranch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmAdministration = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmCostNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCostCenter = new ERP.myBottun();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.pnlGnrlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTHE_VALUE)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostCenterName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostCenterNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(109, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(22, 34);
            // 
            // nmbValue
            // 
            this.nmbValue.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbValue.BeforeTouchSize = new System.Drawing.Size(111, 23);
            this.nmbValue.DecimalPlaces = 0;
            this.nmbValue.DoubleValue = 0D;
            this.nmbValue.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbValue.Location = new System.Drawing.Point(260, 215);
            this.nmbValue.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbValue.MinValue = 0D;
            this.nmbValue.Name = "nmbValue";
            this.nmbValue.NullString = "";
            this.nmbValue.NumberDecimalDigits = 0;
            this.nmbValue.Size = new System.Drawing.Size(100, 23);
            this.nmbValue.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbValue.TabIndex = 7;
            this.nmbValue.Text = "0";
            this.nmbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbValue.Visible = false;
            this.nmbValue.W_Clear = true;
            this.nmbValue.W_ColArName = "";
            this.nmbValue.W_ColEgName = "";
            this.nmbValue.W_OldValue = "";
            this.nmbValue.W_TableName = "";
            this.nmbValue.DoubleValueChanged += new System.EventHandler(this.nmbValue_ValueChanged);
            this.nmbValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmbValue_KeyDown);
            this.nmbValue.Leave += new System.EventHandler(this.nmbValue_Leave);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.White;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(387, 291);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.BorderVisible = true;
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlAdv1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 29);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(387, 291);
            this.tabControlAdv1.TabIndex = 227;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererWorkbookMode);
            this.tabControlAdv1.SelectedIndexChanged += new System.EventHandler(this.tabControlAdv1_SelectedIndexChanged);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.pnlGnrlSetting);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(5, 34);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(377, 252);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "الــرتــب";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // pnlGnrlSetting
            // 
            this.pnlGnrlSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGnrlSetting.Controls.Add(this.btnSave);
            this.pnlGnrlSetting.Controls.Add(this.nmbValue);
            this.pnlGnrlSetting.Controls.Add(this.btnAdd);
            this.pnlGnrlSetting.Controls.Add(this.dgLevels);
            this.pnlGnrlSetting.Controls.Add(this.nmbTHE_VALUE);
            this.pnlGnrlSetting.Controls.Add(this.myLabel2);
            this.pnlGnrlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGnrlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlGnrlSetting.Name = "pnlGnrlSetting";
            this.pnlGnrlSetting.Size = new System.Drawing.Size(377, 252);
            this.pnlGnrlSetting.TabIndex = 183;
            this.pnlGnrlSetting.Tag = "TAB";
            this.pnlGnrlSetting.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGnrlSetting_Paint);
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
            this.btnSave.Location = new System.Drawing.Point(3, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.none;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(140, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgLevels
            // 
            this.dgLevels.AllowUserToAddRows = false;
            this.dgLevels.AllowUserToDeleteRows = false;
            this.dgLevels.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLevels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL1,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgLevels.EnableHeadersVisualStyles = false;
            this.dgLevels.Location = new System.Drawing.Point(2, 39);
            this.dgLevels.Name = "dgLevels";
            this.dgLevels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgLevels.RowHeadersVisible = false;
            this.dgLevels.Size = new System.Drawing.Size(358, 170);
            this.dgLevels.TabIndex = 2;
            this.dgLevels.W_Clear = true;
            this.dgLevels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLevels_CellContentClick);
            this.dgLevels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLevels_CellContentClick);
            // 
            // COL1
            // 
            this.COL1.HeaderText = "الاسم ";
            this.COL1.Name = "COL1";
            this.COL1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "القيمة";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "swid";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الوصف";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // nmbTHE_VALUE
            // 
            this.nmbTHE_VALUE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbTHE_VALUE.BeforeTouchSize = new System.Drawing.Size(111, 23);
            this.nmbTHE_VALUE.DecimalPlaces = 0;
            this.nmbTHE_VALUE.DoubleValue = 0D;
            this.nmbTHE_VALUE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbTHE_VALUE.Location = new System.Drawing.Point(175, 10);
            this.nmbTHE_VALUE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbTHE_VALUE.MinValue = 0D;
            this.nmbTHE_VALUE.Name = "nmbTHE_VALUE";
            this.nmbTHE_VALUE.NullString = "";
            this.nmbTHE_VALUE.NumberDecimalDigits = 0;
            this.nmbTHE_VALUE.Size = new System.Drawing.Size(100, 23);
            this.nmbTHE_VALUE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbTHE_VALUE.TabIndex = 1;
            this.nmbTHE_VALUE.Text = "0";
            this.nmbTHE_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbTHE_VALUE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbTHE_VALUE.W_Clear = true;
            this.nmbTHE_VALUE.W_ColArName = "";
            this.nmbTHE_VALUE.W_ColEgName = "";
            this.nmbTHE_VALUE.W_OldValue = "";
            this.nmbTHE_VALUE.W_TableName = "";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(281, 10);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(58, 18);
            this.myLabel2.TabIndex = 0;
            this.myLabel2.Text = "عدد الرتب";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.pnlAccount);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(5, 34);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(377, 252);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "انواع مراكز التكلفة";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // pnlAccount
            // 
            this.pnlAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccount.Controls.Add(this.btnAddCostCenter);
            this.pnlAccount.Controls.Add(this.txtCostCenterNote);
            this.pnlAccount.Controls.Add(this.txtCostCenterName);
            this.pnlAccount.Controls.Add(this.myLabel4);
            this.pnlAccount.Controls.Add(this.ckbAdministation);
            this.pnlAccount.Controls.Add(this.ckbBranch);
            this.pnlAccount.Controls.Add(this.myLabel3);
            this.pnlAccount.Controls.Add(this.dgvCostCenter);
            this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(377, 252);
            this.pnlAccount.TabIndex = 181;
            this.pnlAccount.Tag = "TAB";
            this.pnlAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAccount_Paint);
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(160, 7);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(52, 18);
            this.myLabel4.TabIndex = 3;
            this.myLabel4.Text = "ملاحظات";
            // 
            // ckbAdministation
            // 
            this.ckbAdministation.AutoSize = true;
            this.ckbAdministation.Location = new System.Drawing.Point(99, 55);
            this.ckbAdministation.Name = "ckbAdministation";
            this.ckbAdministation.Size = new System.Drawing.Size(59, 26);
            this.ckbAdministation.TabIndex = 2;
            this.ckbAdministation.Text = "إدارة";
            this.ckbAdministation.UseVisualStyleBackColor = true;
            // 
            // ckbBranch
            // 
            this.ckbBranch.AutoSize = true;
            this.ckbBranch.Location = new System.Drawing.Point(275, 55);
            this.ckbBranch.Name = "ckbBranch";
            this.ckbBranch.Size = new System.Drawing.Size(53, 26);
            this.ckbBranch.TabIndex = 1;
            this.ckbBranch.Text = "فرع";
            this.ckbBranch.UseVisualStyleBackColor = true;
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(334, 8);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(33, 18);
            this.myLabel3.TabIndex = 0;
            this.myLabel3.Text = "الاسم";
            // 
            // txtCostCenterName
            // 
            this.txtCostCenterName.BeforeTouchSize = new System.Drawing.Size(111, 23);
            this.txtCostCenterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostCenterName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCostCenterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCostCenterName.Location = new System.Drawing.Point(217, 3);
            this.txtCostCenterName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCostCenterName.Name = "txtCostCenterName";
            this.txtCostCenterName.Size = new System.Drawing.Size(111, 23);
            this.txtCostCenterName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCostCenterName.TabIndex = 4;
            this.txtCostCenterName.W_Clear = true;
            this.txtCostCenterName.W_ColArName = "";
            this.txtCostCenterName.W_ColEgName = "";
            this.txtCostCenterName.W_OldValue = "";
            this.txtCostCenterName.W_TableName = "";
            // 
            // txtCostCenterNote
            // 
            this.txtCostCenterNote.BeforeTouchSize = new System.Drawing.Size(111, 23);
            this.txtCostCenterNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostCenterNote.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCostCenterNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCostCenterNote.Location = new System.Drawing.Point(6, 3);
            this.txtCostCenterNote.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCostCenterNote.Multiline = true;
            this.txtCostCenterNote.Name = "txtCostCenterNote";
            this.txtCostCenterNote.Size = new System.Drawing.Size(152, 46);
            this.txtCostCenterNote.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCostCenterNote.TabIndex = 5;
            this.txtCostCenterNote.W_Clear = true;
            this.txtCostCenterNote.W_ColArName = "";
            this.txtCostCenterNote.W_ColEgName = "";
            this.txtCostCenterNote.W_OldValue = "";
            this.txtCostCenterNote.W_TableName = "";
            // 
            // dgvCostCenter
            // 
            this.dgvCostCenter.AllowUserToAddRows = false;
            this.dgvCostCenter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCostCenter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCostCenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostCenter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCostCenterSwid,
            this.clmCostName,
            this.clmBranch,
            this.clmAdministration,
            this.clmCostNote});
            this.dgvCostCenter.EnableHeadersVisualStyles = false;
            this.dgvCostCenter.Location = new System.Drawing.Point(2, 87);
            this.dgvCostCenter.Name = "dgvCostCenter";
            this.dgvCostCenter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCostCenter.RowHeadersVisible = false;
            this.dgvCostCenter.Size = new System.Drawing.Size(371, 157);
            this.dgvCostCenter.TabIndex = 6;
            this.dgvCostCenter.W_Clear = true;
            // 
            // clmCostCenterSwid
            // 
            this.clmCostCenterSwid.HeaderText = "swid";
            this.clmCostCenterSwid.Name = "clmCostCenterSwid";
            this.clmCostCenterSwid.ReadOnly = true;
            this.clmCostCenterSwid.Visible = false;
            // 
            // clmCostName
            // 
            this.clmCostName.HeaderText = "الاسم";
            this.clmCostName.Name = "clmCostName";
            this.clmCostName.ReadOnly = true;
            // 
            // clmBranch
            // 
            this.clmBranch.HeaderText = "فرع";
            this.clmBranch.Name = "clmBranch";
            this.clmBranch.ReadOnly = true;
            this.clmBranch.Width = 50;
            // 
            // clmAdministration
            // 
            this.clmAdministration.HeaderText = "ادارة";
            this.clmAdministration.Name = "clmAdministration";
            this.clmAdministration.ReadOnly = true;
            this.clmAdministration.Width = 50;
            // 
            // clmCostNote
            // 
            this.clmCostNote.HeaderText = "ملاحظات";
            this.clmCostNote.Name = "clmCostNote";
            this.clmCostNote.ReadOnly = true;
            this.clmCostNote.Width = 150;
            // 
            // btnAddCostCenter
            // 
            this.btnAddCostCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCostCenter.BackgroundImage")));
            this.btnAddCostCenter.BeforeTouchSize = new System.Drawing.Size(33, 23);
            this.btnAddCostCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCostCenter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddCostCenter.FlatAppearance.BorderSize = 0;
            this.btnAddCostCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCostCenter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddCostCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddCostCenter.Image = global::ERP.Properties.Resources.Add_h;
            this.btnAddCostCenter.IsBackStageButton = false;
            this.btnAddCostCenter.Location = new System.Drawing.Point(60, 55);
            this.btnAddCostCenter.Name = "btnAddCostCenter";
            this.btnAddCostCenter.Size = new System.Drawing.Size(33, 23);
            this.btnAddCostCenter.TabIndex = 7;
            this.btnAddCostCenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCostCenter.UseVisualStyleBackColor = true;
            this.btnAddCostCenter.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAddCostCenter.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAddCostCenter.Click += new System.EventHandler(this.btnAddCostCenter_Click);
            // 
            // frmAccVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(387, 320);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "frmAccVariable";
            this.Titel = "متغيرات النظام";
            this.Load += new System.EventHandler(this.frmAccVariable_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.tabControlAdv1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.pnlGnrlSetting.ResumeLayout(false);
            this.pnlGnrlSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTHE_VALUE)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostCenterName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostCenterNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ERP.myNumber nmbValue;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private System.Windows.Forms.Panel pnlGnrlSetting;
        private ERP.myBottun btnSave;
        private ERP.myBottun btnAdd;
        private ERP.myDataGrid dgLevels;
        private ERP.myNumber nmbTHE_VALUE;
        private ERP.myLabel myLabel2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private myLabel myLabel4;
        private System.Windows.Forms.CheckBox ckbAdministation;
        private System.Windows.Forms.CheckBox ckbBranch;
        private myLabel myLabel3;
        private myText txtCostCenterNote;
        private myText txtCostCenterName;
        private myDataGrid dgvCostCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostCenterSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmBranch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAdministration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostNote;
        private myBottun btnAddCostCenter;
    }
}
