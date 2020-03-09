namespace ERP.Accounts
{
    partial class FrmCurrencyExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCurrencyExchange));
            this.numFrictionDiffDebt = new ERP.myNumber();
            this.txtCASHER_id = new ERP.myText();
            this.lblFrictionDiff = new ERP.myLabel();
            this.numFrictionDiffCredit = new ERP.myNumber();
            this.txtJournalDetailDebtSwid = new ERP.myText();
            this.txtJournalDetailCreditSwid = new ERP.myText();
            this.btnFindReciept = new ERP.myBottun();
            this.txtRECEIPT_ORDER_ID = new ERP.myText();
            this.btnNew = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.txtDOC_NO = new ERP.myText();
            this.myLabel12 = new ERP.myLabel();
            this.txtCASHER = new ERP.myText();
            this.myLabel11 = new ERP.myLabel();
            this.dtpRECEIPT_DATE = new ERP.myDate();
            this.myLabel10 = new ERP.myLabel();
            this.myLabel9 = new ERP.myLabel();
            this.txtRECEIPT_NOTE = new ERP.myText();
            this.myLabel6 = new ERP.myLabel();
            this.myText4 = new ERP.myText();
            this.nmbCASHBACK_EXCHANGE_VALUE = new ERP.myNumber();
            this.nmbCASHBACK_MAIN_VALUE = new ERP.myNumber();
            this.lstCASHBACK_CURR_ID = new ERP.myList();
            this.nmbCASHBACK_VALUE = new ERP.myNumber();
            this.myLabel7 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.myText1 = new ERP.myText();
            this.txtRECEIPT_NO = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.nmbCASHER_EXCHANGE_VALUE = new ERP.myNumber();
            this.lstCASHER_CURR_ID = new ERP.myList();
            this.nmbCASHER_VALUE = new ERP.myNumber();
            this.myLabel2 = new ERP.myLabel();
            this.myList1 = new ERP.myList();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrictionDiffDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCASHER_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrictionDiffCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalDetailDebtSwid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalDetailCreditSwid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRECEIPT_ORDER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOC_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCASHER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRECEIPT_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRECEIPT_NOTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHBACK_EXCHANGE_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHBACK_MAIN_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHBACK_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRECEIPT_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHER_EXCHANGE_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHER_VALUE)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(177, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(90, 34);
            // 
            // numFrictionDiffDebt
            // 
            this.numFrictionDiffDebt.BackGroundColor = System.Drawing.SystemColors.Window;
            this.numFrictionDiffDebt.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.numFrictionDiffDebt.DecimalPlaces = 7;
            this.numFrictionDiffDebt.DoubleValue = 0D;
            this.numFrictionDiffDebt.Font = new System.Drawing.Font("Arial", 10F);
            this.numFrictionDiffDebt.Location = new System.Drawing.Point(288, 367);
            this.numFrictionDiffDebt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numFrictionDiffDebt.MinValue = 0D;
            this.numFrictionDiffDebt.Name = "numFrictionDiffDebt";
            this.numFrictionDiffDebt.NullString = "";
            this.numFrictionDiffDebt.NumberDecimalDigits = 7;
            this.numFrictionDiffDebt.ReadOnly = true;
            this.numFrictionDiffDebt.Size = new System.Drawing.Size(172, 23);
            this.numFrictionDiffDebt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.numFrictionDiffDebt.TabIndex = 349;
            this.numFrictionDiffDebt.Text = "0.0000000";
            this.numFrictionDiffDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFrictionDiffDebt.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numFrictionDiffDebt.Visible = false;
            this.numFrictionDiffDebt.W_Clear = true;
            this.numFrictionDiffDebt.W_ColArName = "";
            this.numFrictionDiffDebt.W_ColEgName = "";
            this.numFrictionDiffDebt.W_OldValue = "";
            this.numFrictionDiffDebt.W_TableName = "";
            // 
            // txtCASHER_id
            // 
            this.txtCASHER_id.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.txtCASHER_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCASHER_id.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCASHER_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCASHER_id.Location = new System.Drawing.Point(74, 148);
            this.txtCASHER_id.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCASHER_id.Name = "txtCASHER_id";
            this.txtCASHER_id.Size = new System.Drawing.Size(30, 23);
            this.txtCASHER_id.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCASHER_id.TabIndex = 348;
            this.txtCASHER_id.Visible = false;
            this.txtCASHER_id.W_Clear = true;
            this.txtCASHER_id.W_ColArName = "";
            this.txtCASHER_id.W_ColEgName = "";
            this.txtCASHER_id.W_OldValue = "";
            this.txtCASHER_id.W_TableName = "";
            // 
            // lblFrictionDiff
            // 
            this.lblFrictionDiff.BackColor = System.Drawing.Color.Transparent;
            this.lblFrictionDiff.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFrictionDiff.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrictionDiff.ForeColor = System.Drawing.Color.Black;
            this.lblFrictionDiff.Location = new System.Drawing.Point(22, 370);
            this.lblFrictionDiff.Name = "lblFrictionDiff";
            this.lblFrictionDiff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFrictionDiff.Size = new System.Drawing.Size(60, 18);
            this.lblFrictionDiff.TabIndex = 347;
            this.lblFrictionDiff.Text = "فرق الكسر";
            this.lblFrictionDiff.Visible = false;
            // 
            // numFrictionDiffCredit
            // 
            this.numFrictionDiffCredit.BackGroundColor = System.Drawing.SystemColors.Window;
            this.numFrictionDiffCredit.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.numFrictionDiffCredit.DecimalPlaces = 7;
            this.numFrictionDiffCredit.DoubleValue = 0D;
            this.numFrictionDiffCredit.Font = new System.Drawing.Font("Arial", 10F);
            this.numFrictionDiffCredit.Location = new System.Drawing.Point(110, 367);
            this.numFrictionDiffCredit.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numFrictionDiffCredit.MinValue = 0D;
            this.numFrictionDiffCredit.Name = "numFrictionDiffCredit";
            this.numFrictionDiffCredit.NullString = "";
            this.numFrictionDiffCredit.NumberDecimalDigits = 7;
            this.numFrictionDiffCredit.ReadOnly = true;
            this.numFrictionDiffCredit.Size = new System.Drawing.Size(172, 23);
            this.numFrictionDiffCredit.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.numFrictionDiffCredit.TabIndex = 346;
            this.numFrictionDiffCredit.Text = "0.0000000";
            this.numFrictionDiffCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFrictionDiffCredit.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numFrictionDiffCredit.Visible = false;
            this.numFrictionDiffCredit.W_Clear = true;
            this.numFrictionDiffCredit.W_ColArName = "";
            this.numFrictionDiffCredit.W_ColEgName = "";
            this.numFrictionDiffCredit.W_OldValue = "";
            this.numFrictionDiffCredit.W_TableName = "";
            // 
            // txtJournalDetailDebtSwid
            // 
            this.txtJournalDetailDebtSwid.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.txtJournalDetailDebtSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJournalDetailDebtSwid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtJournalDetailDebtSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtJournalDetailDebtSwid.Location = new System.Drawing.Point(469, 73);
            this.txtJournalDetailDebtSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJournalDetailDebtSwid.Name = "txtJournalDetailDebtSwid";
            this.txtJournalDetailDebtSwid.Size = new System.Drawing.Size(30, 23);
            this.txtJournalDetailDebtSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJournalDetailDebtSwid.TabIndex = 345;
            this.txtJournalDetailDebtSwid.Visible = false;
            this.txtJournalDetailDebtSwid.W_Clear = true;
            this.txtJournalDetailDebtSwid.W_ColArName = "";
            this.txtJournalDetailDebtSwid.W_ColEgName = "";
            this.txtJournalDetailDebtSwid.W_OldValue = "";
            this.txtJournalDetailDebtSwid.W_TableName = "";
            // 
            // txtJournalDetailCreditSwid
            // 
            this.txtJournalDetailCreditSwid.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.txtJournalDetailCreditSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJournalDetailCreditSwid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtJournalDetailCreditSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtJournalDetailCreditSwid.Location = new System.Drawing.Point(469, 44);
            this.txtJournalDetailCreditSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJournalDetailCreditSwid.Name = "txtJournalDetailCreditSwid";
            this.txtJournalDetailCreditSwid.Size = new System.Drawing.Size(30, 23);
            this.txtJournalDetailCreditSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJournalDetailCreditSwid.TabIndex = 344;
            this.txtJournalDetailCreditSwid.Visible = false;
            this.txtJournalDetailCreditSwid.W_Clear = true;
            this.txtJournalDetailCreditSwid.W_ColArName = "";
            this.txtJournalDetailCreditSwid.W_ColEgName = "";
            this.txtJournalDetailCreditSwid.W_OldValue = "";
            this.txtJournalDetailCreditSwid.W_TableName = "";
            // 
            // btnFindReciept
            // 
            this.btnFindReciept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindReciept.BackgroundImage")));
            this.btnFindReciept.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFindReciept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindReciept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindReciept.FlatAppearance.BorderSize = 0;
            this.btnFindReciept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindReciept.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFindReciept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindReciept.Image = ((System.Drawing.Image)(resources.GetObject("btnFindReciept.Image")));
            this.btnFindReciept.IsBackStageButton = false;
            this.btnFindReciept.Location = new System.Drawing.Point(326, 91);
            this.btnFindReciept.Name = "btnFindReciept";
            this.btnFindReciept.Size = new System.Drawing.Size(28, 27);
            this.btnFindReciept.TabIndex = 336;
            this.btnFindReciept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindReciept.UseVisualStyleBackColor = true;
            this.btnFindReciept.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFindReciept.w_Type = ERP.myBottun.Btton_type.Search;
            // 
            // txtRECEIPT_ORDER_ID
            // 
            this.txtRECEIPT_ORDER_ID.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.txtRECEIPT_ORDER_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRECEIPT_ORDER_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRECEIPT_ORDER_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtRECEIPT_ORDER_ID.Location = new System.Drawing.Point(469, 103);
            this.txtRECEIPT_ORDER_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtRECEIPT_ORDER_ID.Name = "txtRECEIPT_ORDER_ID";
            this.txtRECEIPT_ORDER_ID.Size = new System.Drawing.Size(30, 23);
            this.txtRECEIPT_ORDER_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtRECEIPT_ORDER_ID.TabIndex = 335;
            this.txtRECEIPT_ORDER_ID.Visible = false;
            this.txtRECEIPT_ORDER_ID.W_Clear = true;
            this.txtRECEIPT_ORDER_ID.W_ColArName = "";
            this.txtRECEIPT_ORDER_ID.W_ColEgName = "";
            this.txtRECEIPT_ORDER_ID.W_OldValue = "";
            this.txtRECEIPT_ORDER_ID.W_TableName = "";
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
            this.btnNew.Location = new System.Drawing.Point(275, 396);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 332;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
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
            this.btnUpdate.Location = new System.Drawing.Point(396, 396);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 331;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
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
            this.btnExit.Location = new System.Drawing.Point(454, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 330;
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
            this.btnSave.Location = new System.Drawing.Point(338, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 329;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDOC_NO
            // 
            this.txtDOC_NO.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.txtDOC_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOC_NO.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDOC_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDOC_NO.Location = new System.Drawing.Point(448, 145);
            this.txtDOC_NO.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDOC_NO.Name = "txtDOC_NO";
            this.txtDOC_NO.Size = new System.Drawing.Size(51, 23);
            this.txtDOC_NO.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDOC_NO.TabIndex = 326;
            this.txtDOC_NO.W_Clear = true;
            this.txtDOC_NO.W_ColArName = "";
            this.txtDOC_NO.W_ColEgName = "";
            this.txtDOC_NO.W_OldValue = "";
            this.txtDOC_NO.W_TableName = "";
            // 
            // myLabel12
            // 
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(381, 148);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(68, 18);
            this.myLabel12.TabIndex = 325;
            this.myLabel12.Text = "رقم المستند ";
            // 
            // txtCASHER
            // 
            this.txtCASHER.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.txtCASHER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCASHER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCASHER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCASHER.Location = new System.Drawing.Point(110, 146);
            this.txtCASHER.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCASHER.Name = "txtCASHER";
            this.txtCASHER.ReadOnly = true;
            this.txtCASHER.Size = new System.Drawing.Size(265, 23);
            this.txtCASHER.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCASHER.TabIndex = 324;
            this.txtCASHER.W_Clear = true;
            this.txtCASHER.W_ColArName = "";
            this.txtCASHER.W_ColEgName = "";
            this.txtCASHER.W_OldValue = "";
            this.txtCASHER.W_TableName = "";
            // 
            // myLabel11
            // 
            this.myLabel11.BackColor = System.Drawing.Color.Transparent;
            this.myLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel11.ForeColor = System.Drawing.Color.Black;
            this.myLabel11.Location = new System.Drawing.Point(26, 148);
            this.myLabel11.Name = "myLabel11";
            this.myLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel11.Size = new System.Drawing.Size(53, 18);
            this.myLabel11.TabIndex = 323;
            this.myLabel11.Text = "الصندوق";
            // 
            // dtpRECEIPT_DATE
            // 
            this.dtpRECEIPT_DATE.BorderColor = System.Drawing.Color.Empty;
            this.dtpRECEIPT_DATE.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpRECEIPT_DATE.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpRECEIPT_DATE.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpRECEIPT_DATE.CustomFormat = "dd/MM/yyyy";
            this.dtpRECEIPT_DATE.DropDownImage = null;
            this.dtpRECEIPT_DATE.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dtpRECEIPT_DATE.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpRECEIPT_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.dtpRECEIPT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRECEIPT_DATE.Location = new System.Drawing.Point(110, 119);
            this.dtpRECEIPT_DATE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpRECEIPT_DATE.MinValue = new System.DateTime(((long)(0)));
            this.dtpRECEIPT_DATE.Name = "dtpRECEIPT_DATE";
            this.dtpRECEIPT_DATE.NoneButtonVisible = false;
            this.dtpRECEIPT_DATE.ShowCheckBox = false;
            this.dtpRECEIPT_DATE.Size = new System.Drawing.Size(208, 21);
            this.dtpRECEIPT_DATE.TabIndex = 322;
            this.dtpRECEIPT_DATE.Value = new System.DateTime(2017, 9, 30, 10, 47, 28, 445);
            this.dtpRECEIPT_DATE.W_Clear = true;
            this.dtpRECEIPT_DATE.W_ColArName = "";
            this.dtpRECEIPT_DATE.W_ColEgName = "";
            this.dtpRECEIPT_DATE.W_OldValue = "";
            this.dtpRECEIPT_DATE.W_TableName = "";
            // 
            // myLabel10
            // 
            this.myLabel10.BackColor = System.Drawing.Color.Transparent;
            this.myLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel10.ForeColor = System.Drawing.Color.Black;
            this.myLabel10.Location = new System.Drawing.Point(46, 122);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel10.Size = new System.Drawing.Size(42, 18);
            this.myLabel10.TabIndex = 321;
            this.myLabel10.Text = "التاريخ";
            // 
            // myLabel9
            // 
            this.myLabel9.AutoSize = false;
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(6, 335);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel9.Size = new System.Drawing.Size(88, 37);
            this.myLabel9.TabIndex = 320;
            this.myLabel9.Text = "وذلك مقابل ";
            this.myLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRECEIPT_NOTE
            // 
            this.txtRECEIPT_NOTE.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.txtRECEIPT_NOTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRECEIPT_NOTE.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRECEIPT_NOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtRECEIPT_NOTE.Location = new System.Drawing.Point(110, 328);
            this.txtRECEIPT_NOTE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtRECEIPT_NOTE.Multiline = true;
            this.txtRECEIPT_NOTE.Name = "txtRECEIPT_NOTE";
            this.txtRECEIPT_NOTE.Size = new System.Drawing.Size(389, 33);
            this.txtRECEIPT_NOTE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtRECEIPT_NOTE.TabIndex = 319;
            this.txtRECEIPT_NOTE.W_Clear = true;
            this.txtRECEIPT_NOTE.W_ColArName = "";
            this.txtRECEIPT_NOTE.W_ColEgName = "";
            this.txtRECEIPT_NOTE.W_OldValue = "";
            this.txtRECEIPT_NOTE.W_TableName = "";
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(22, 245);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(64, 18);
            this.myLabel6.TabIndex = 318;
            this.myLabel6.Text = "المبلغ كتابة";
            // 
            // myText4
            // 
            this.myText4.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.myText4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myText4.Font = new System.Drawing.Font("Arial", 10F);
            this.myText4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.myText4.Location = new System.Drawing.Point(110, 240);
            this.myText4.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.myText4.Name = "myText4";
            this.myText4.ReadOnly = true;
            this.myText4.Size = new System.Drawing.Size(389, 23);
            this.myText4.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.myText4.TabIndex = 317;
            this.myText4.W_Clear = true;
            this.myText4.W_ColArName = "";
            this.myText4.W_ColEgName = "";
            this.myText4.W_OldValue = "";
            this.myText4.W_TableName = "";
            // 
            // nmbCASHBACK_EXCHANGE_VALUE
            // 
            this.nmbCASHBACK_EXCHANGE_VALUE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbCASHBACK_EXCHANGE_VALUE.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.nmbCASHBACK_EXCHANGE_VALUE.DecimalPlaces = 7;
            this.nmbCASHBACK_EXCHANGE_VALUE.DoubleValue = 0D;
            this.nmbCASHBACK_EXCHANGE_VALUE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCASHBACK_EXCHANGE_VALUE.Location = new System.Drawing.Point(321, 270);
            this.nmbCASHBACK_EXCHANGE_VALUE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbCASHBACK_EXCHANGE_VALUE.MinValue = 0D;
            this.nmbCASHBACK_EXCHANGE_VALUE.Name = "nmbCASHBACK_EXCHANGE_VALUE";
            this.nmbCASHBACK_EXCHANGE_VALUE.NullString = "";
            this.nmbCASHBACK_EXCHANGE_VALUE.NumberDecimalDigits = 7;
            this.nmbCASHBACK_EXCHANGE_VALUE.Size = new System.Drawing.Size(79, 23);
            this.nmbCASHBACK_EXCHANGE_VALUE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbCASHBACK_EXCHANGE_VALUE.TabIndex = 316;
            this.nmbCASHBACK_EXCHANGE_VALUE.Text = "0.0000000";
            this.nmbCASHBACK_EXCHANGE_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbCASHBACK_EXCHANGE_VALUE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCASHBACK_EXCHANGE_VALUE.W_Clear = true;
            this.nmbCASHBACK_EXCHANGE_VALUE.W_ColArName = "";
            this.nmbCASHBACK_EXCHANGE_VALUE.W_ColEgName = "";
            this.nmbCASHBACK_EXCHANGE_VALUE.W_OldValue = "";
            this.nmbCASHBACK_EXCHANGE_VALUE.W_TableName = "";
            // 
            // nmbCASHBACK_MAIN_VALUE
            // 
            this.nmbCASHBACK_MAIN_VALUE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbCASHBACK_MAIN_VALUE.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.nmbCASHBACK_MAIN_VALUE.DecimalPlaces = 0;
            this.nmbCASHBACK_MAIN_VALUE.DoubleValue = 0D;
            this.nmbCASHBACK_MAIN_VALUE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCASHBACK_MAIN_VALUE.Location = new System.Drawing.Point(401, 270);
            this.nmbCASHBACK_MAIN_VALUE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbCASHBACK_MAIN_VALUE.MinValue = 0D;
            this.nmbCASHBACK_MAIN_VALUE.Name = "nmbCASHBACK_MAIN_VALUE";
            this.nmbCASHBACK_MAIN_VALUE.NullString = "";
            this.nmbCASHBACK_MAIN_VALUE.NumberDecimalDigits = 0;
            this.nmbCASHBACK_MAIN_VALUE.Size = new System.Drawing.Size(98, 23);
            this.nmbCASHBACK_MAIN_VALUE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbCASHBACK_MAIN_VALUE.TabIndex = 315;
            this.nmbCASHBACK_MAIN_VALUE.Text = "0";
            this.nmbCASHBACK_MAIN_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbCASHBACK_MAIN_VALUE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCASHBACK_MAIN_VALUE.W_Clear = true;
            this.nmbCASHBACK_MAIN_VALUE.W_ColArName = "";
            this.nmbCASHBACK_MAIN_VALUE.W_ColEgName = "";
            this.nmbCASHBACK_MAIN_VALUE.W_OldValue = "";
            this.nmbCASHBACK_MAIN_VALUE.W_TableName = "";
            // 
            // lstCASHBACK_CURR_ID
            // 
            this.lstCASHBACK_CURR_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCASHBACK_CURR_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCASHBACK_CURR_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCASHBACK_CURR_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCASHBACK_CURR_ID.FormattingEnabled = true;
            this.lstCASHBACK_CURR_ID.Location = new System.Drawing.Point(110, 269);
            this.lstCASHBACK_CURR_ID.Name = "lstCASHBACK_CURR_ID";
            this.lstCASHBACK_CURR_ID.Size = new System.Drawing.Size(111, 24);
            this.lstCASHBACK_CURR_ID.TabIndex = 314;
            this.lstCASHBACK_CURR_ID.W_Clear = true;
            this.lstCASHBACK_CURR_ID.W_ColArName = "";
            this.lstCASHBACK_CURR_ID.W_ColEgName = "";
            this.lstCASHBACK_CURR_ID.W_OldValue = "";
            this.lstCASHBACK_CURR_ID.W_TableName = "";
            this.lstCASHBACK_CURR_ID.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // nmbCASHBACK_VALUE
            // 
            this.nmbCASHBACK_VALUE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbCASHBACK_VALUE.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.nmbCASHBACK_VALUE.DecimalPlaces = 0;
            this.nmbCASHBACK_VALUE.DoubleValue = 0D;
            this.nmbCASHBACK_VALUE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCASHBACK_VALUE.Location = new System.Drawing.Point(224, 270);
            this.nmbCASHBACK_VALUE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbCASHBACK_VALUE.MinValue = 0D;
            this.nmbCASHBACK_VALUE.Name = "nmbCASHBACK_VALUE";
            this.nmbCASHBACK_VALUE.NullString = "";
            this.nmbCASHBACK_VALUE.NumberDecimalDigits = 0;
            this.nmbCASHBACK_VALUE.Size = new System.Drawing.Size(94, 23);
            this.nmbCASHBACK_VALUE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbCASHBACK_VALUE.TabIndex = 313;
            this.nmbCASHBACK_VALUE.Text = "0";
            this.nmbCASHBACK_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbCASHBACK_VALUE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCASHBACK_VALUE.W_Clear = true;
            this.nmbCASHBACK_VALUE.W_ColArName = "";
            this.nmbCASHBACK_VALUE.W_ColEgName = "";
            this.nmbCASHBACK_VALUE.W_OldValue = "";
            this.nmbCASHBACK_VALUE.W_TableName = "";
            // 
            // myLabel7
            // 
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(38, 270);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(51, 18);
            this.myLabel7.TabIndex = 312;
            this.myLabel7.Text = "بما يعادل";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(22, 304);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(64, 18);
            this.myLabel5.TabIndex = 309;
            this.myLabel5.Text = "المبلغ كتابة";
            // 
            // myText1
            // 
            this.myText1.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.myText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myText1.Font = new System.Drawing.Font("Arial", 10F);
            this.myText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.myText1.Location = new System.Drawing.Point(110, 299);
            this.myText1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.myText1.Name = "myText1";
            this.myText1.ReadOnly = true;
            this.myText1.Size = new System.Drawing.Size(389, 23);
            this.myText1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.myText1.TabIndex = 308;
            this.myText1.W_Clear = true;
            this.myText1.W_ColArName = "";
            this.myText1.W_ColEgName = "";
            this.myText1.W_OldValue = "";
            this.myText1.W_TableName = "";
            // 
            // txtRECEIPT_NO
            // 
            this.txtRECEIPT_NO.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.txtRECEIPT_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRECEIPT_NO.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRECEIPT_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtRECEIPT_NO.Location = new System.Drawing.Point(110, 91);
            this.txtRECEIPT_NO.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtRECEIPT_NO.Name = "txtRECEIPT_NO";
            this.txtRECEIPT_NO.ReadOnly = true;
            this.txtRECEIPT_NO.Size = new System.Drawing.Size(208, 23);
            this.txtRECEIPT_NO.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtRECEIPT_NO.TabIndex = 307;
            this.txtRECEIPT_NO.W_Clear = true;
            this.txtRECEIPT_NO.W_ColArName = "";
            this.txtRECEIPT_NO.W_ColEgName = "";
            this.txtRECEIPT_NO.W_OldValue = "";
            this.txtRECEIPT_NO.W_TableName = "";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(56, 96);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(32, 18);
            this.myLabel4.TabIndex = 306;
            this.myLabel4.Text = "الرقم";
            // 
            // nmbCASHER_EXCHANGE_VALUE
            // 
            this.nmbCASHER_EXCHANGE_VALUE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbCASHER_EXCHANGE_VALUE.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.nmbCASHER_EXCHANGE_VALUE.DecimalPlaces = 7;
            this.nmbCASHER_EXCHANGE_VALUE.DoubleValue = 0D;
            this.nmbCASHER_EXCHANGE_VALUE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCASHER_EXCHANGE_VALUE.Location = new System.Drawing.Point(384, 211);
            this.nmbCASHER_EXCHANGE_VALUE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbCASHER_EXCHANGE_VALUE.MinValue = 0D;
            this.nmbCASHER_EXCHANGE_VALUE.Name = "nmbCASHER_EXCHANGE_VALUE";
            this.nmbCASHER_EXCHANGE_VALUE.NullString = "";
            this.nmbCASHER_EXCHANGE_VALUE.NumberDecimalDigits = 7;
            this.nmbCASHER_EXCHANGE_VALUE.Size = new System.Drawing.Size(118, 23);
            this.nmbCASHER_EXCHANGE_VALUE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbCASHER_EXCHANGE_VALUE.TabIndex = 305;
            this.nmbCASHER_EXCHANGE_VALUE.Text = "0.0000000";
            this.nmbCASHER_EXCHANGE_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbCASHER_EXCHANGE_VALUE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCASHER_EXCHANGE_VALUE.W_Clear = true;
            this.nmbCASHER_EXCHANGE_VALUE.W_ColArName = "";
            this.nmbCASHER_EXCHANGE_VALUE.W_ColEgName = "";
            this.nmbCASHER_EXCHANGE_VALUE.W_OldValue = "";
            this.nmbCASHER_EXCHANGE_VALUE.W_TableName = "";
            // 
            // lstCASHER_CURR_ID
            // 
            this.lstCASHER_CURR_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCASHER_CURR_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCASHER_CURR_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCASHER_CURR_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCASHER_CURR_ID.FormattingEnabled = true;
            this.lstCASHER_CURR_ID.Location = new System.Drawing.Point(110, 210);
            this.lstCASHER_CURR_ID.Name = "lstCASHER_CURR_ID";
            this.lstCASHER_CURR_ID.Size = new System.Drawing.Size(111, 24);
            this.lstCASHER_CURR_ID.TabIndex = 304;
            this.lstCASHER_CURR_ID.W_Clear = true;
            this.lstCASHER_CURR_ID.W_ColArName = "";
            this.lstCASHER_CURR_ID.W_ColEgName = "";
            this.lstCASHER_CURR_ID.W_OldValue = "";
            this.lstCASHER_CURR_ID.W_TableName = "";
            this.lstCASHER_CURR_ID.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // nmbCASHER_VALUE
            // 
            this.nmbCASHER_VALUE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbCASHER_VALUE.BeforeTouchSize = new System.Drawing.Size(155, 23);
            this.nmbCASHER_VALUE.DecimalPlaces = 0;
            this.nmbCASHER_VALUE.DoubleValue = 0D;
            this.nmbCASHER_VALUE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCASHER_VALUE.Location = new System.Drawing.Point(227, 211);
            this.nmbCASHER_VALUE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbCASHER_VALUE.MinValue = 0D;
            this.nmbCASHER_VALUE.Name = "nmbCASHER_VALUE";
            this.nmbCASHER_VALUE.NullString = "";
            this.nmbCASHER_VALUE.NumberDecimalDigits = 0;
            this.nmbCASHER_VALUE.Size = new System.Drawing.Size(155, 23);
            this.nmbCASHER_VALUE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbCASHER_VALUE.TabIndex = 303;
            this.nmbCASHER_VALUE.Text = "0";
            this.nmbCASHER_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbCASHER_VALUE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCASHER_VALUE.W_Clear = true;
            this.nmbCASHER_VALUE.W_ColArName = "";
            this.nmbCASHER_VALUE.W_ColEgName = "";
            this.nmbCASHER_VALUE.W_OldValue = "";
            this.nmbCASHER_VALUE.W_TableName = "";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.DX = 160;
            this.myLabel2.DY = 4;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Gap = 0;
            this.myLabel2.LabeledControl = this.myList1;
            this.myLabel2.Location = new System.Drawing.Point(32, 179);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(73, 18);
            this.myLabel2.TabIndex = 362;
            this.myLabel2.Text = "الوسيط";
            // 
            // myList1
            // 
            this.myList1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.myList1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.myList1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.myList1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.myList1.FormattingEnabled = true;
            this.myList1.Location = new System.Drawing.Point(110, 175);
            this.myList1.Name = "myList1";
            this.myList1.Size = new System.Drawing.Size(155, 26);
            this.myList1.TabIndex = 361;
            this.myList1.W_Clear = true;
            this.myList1.W_ColArName = "";
            this.myList1.W_ColEgName = "";
            this.myList1.W_OldValue = "";
            this.myList1.W_TableName = "";
            this.myList1.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // FrmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(523, 431);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myList1);
            this.Controls.Add(this.numFrictionDiffDebt);
            this.Controls.Add(this.txtCASHER_id);
            this.Controls.Add(this.lblFrictionDiff);
            this.Controls.Add(this.numFrictionDiffCredit);
            this.Controls.Add(this.txtJournalDetailDebtSwid);
            this.Controls.Add(this.txtJournalDetailCreditSwid);
            this.Controls.Add(this.btnFindReciept);
            this.Controls.Add(this.txtRECEIPT_ORDER_ID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDOC_NO);
            this.Controls.Add(this.myLabel12);
            this.Controls.Add(this.txtCASHER);
            this.Controls.Add(this.myLabel11);
            this.Controls.Add(this.dtpRECEIPT_DATE);
            this.Controls.Add(this.myLabel10);
            this.Controls.Add(this.myLabel9);
            this.Controls.Add(this.txtRECEIPT_NOTE);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myText4);
            this.Controls.Add(this.nmbCASHBACK_EXCHANGE_VALUE);
            this.Controls.Add(this.nmbCASHBACK_MAIN_VALUE);
            this.Controls.Add(this.lstCASHBACK_CURR_ID);
            this.Controls.Add(this.nmbCASHBACK_VALUE);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myText1);
            this.Controls.Add(this.txtRECEIPT_NO);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.nmbCASHER_EXCHANGE_VALUE);
            this.Controls.Add(this.lstCASHER_CURR_ID);
            this.Controls.Add(this.nmbCASHER_VALUE);
            this.Name = "FrmCurrencyExchange";
            this.Titel = "شرا وبيع العملات";
            this.Load += new System.EventHandler(this.FrmCurrencyExchange_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.nmbCASHER_VALUE, 0);
            this.Controls.SetChildIndex(this.lstCASHER_CURR_ID, 0);
            this.Controls.SetChildIndex(this.nmbCASHER_EXCHANGE_VALUE, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtRECEIPT_NO, 0);
            this.Controls.SetChildIndex(this.myText1, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.nmbCASHBACK_VALUE, 0);
            this.Controls.SetChildIndex(this.lstCASHBACK_CURR_ID, 0);
            this.Controls.SetChildIndex(this.nmbCASHBACK_MAIN_VALUE, 0);
            this.Controls.SetChildIndex(this.nmbCASHBACK_EXCHANGE_VALUE, 0);
            this.Controls.SetChildIndex(this.myText4, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.txtRECEIPT_NOTE, 0);
            this.Controls.SetChildIndex(this.myLabel9, 0);
            this.Controls.SetChildIndex(this.myLabel10, 0);
            this.Controls.SetChildIndex(this.dtpRECEIPT_DATE, 0);
            this.Controls.SetChildIndex(this.myLabel11, 0);
            this.Controls.SetChildIndex(this.txtCASHER, 0);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.txtDOC_NO, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.txtRECEIPT_ORDER_ID, 0);
            this.Controls.SetChildIndex(this.btnFindReciept, 0);
            this.Controls.SetChildIndex(this.txtJournalDetailCreditSwid, 0);
            this.Controls.SetChildIndex(this.txtJournalDetailDebtSwid, 0);
            this.Controls.SetChildIndex(this.numFrictionDiffCredit, 0);
            this.Controls.SetChildIndex(this.lblFrictionDiff, 0);
            this.Controls.SetChildIndex(this.txtCASHER_id, 0);
            this.Controls.SetChildIndex(this.numFrictionDiffDebt, 0);
            this.Controls.SetChildIndex(this.myList1, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrictionDiffDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCASHER_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrictionDiffCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalDetailDebtSwid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalDetailCreditSwid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRECEIPT_ORDER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOC_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCASHER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRECEIPT_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRECEIPT_NOTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHBACK_EXCHANGE_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHBACK_MAIN_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHBACK_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRECEIPT_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHER_EXCHANGE_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCASHER_VALUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myNumber numFrictionDiffDebt;
        private ERP.myText txtCASHER_id;
        private ERP.myLabel lblFrictionDiff;
        private ERP.myNumber numFrictionDiffCredit;
        private ERP.myText txtJournalDetailDebtSwid;
        private ERP.myText txtJournalDetailCreditSwid;
        private ERP.myBottun btnFindReciept;
        private ERP.myText txtRECEIPT_ORDER_ID;
        private ERP.myBottun btnNew;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnExit;
        private ERP.myBottun btnSave;
        private ERP.myList lstTemplet;
        private ERP.myText txtDOC_NO;
        private ERP.myLabel myLabel12;
        private ERP.myText txtCASHER;
        private ERP.myLabel myLabel11;
        private ERP.myDate dtpRECEIPT_DATE;
        private ERP.myLabel myLabel10;
        private ERP.myLabel myLabel9;
        private ERP.myText txtRECEIPT_NOTE;
        private ERP.myLabel myLabel6;
        private ERP.myText myText4;
        private ERP.myNumber nmbCASHBACK_EXCHANGE_VALUE;
        private ERP.myNumber nmbCASHBACK_MAIN_VALUE;
        private ERP.myList lstCASHBACK_CURR_ID;
        private ERP.myNumber nmbCASHBACK_VALUE;
        private ERP.myLabel myLabel7;
        private ERP.myLabel myLabel5;
        private ERP.myText myText1;
        private ERP.myText txtRECEIPT_NO;
        private ERP.myLabel myLabel4;
        private ERP.myNumber nmbCASHER_EXCHANGE_VALUE;
        private ERP.myList lstCASHER_CURR_ID;
        private ERP.myNumber nmbCASHER_VALUE;
        private ERP.myLabel myLabel2;
        private ERP.myList myList1;
    }
}
