namespace ERP.Purchases
{
    partial class frmCalculatCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculatCost));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new ERP.myBottun();
            this.dgvImpExp = new ERP.myDataGrid();
            this.txtNote = new ERP.myText();
            this.myLabel3 = new ERP.myLabel();
            this.txtImportId = new ERP.myText();
            this.btnSearch = new ERP.myBottun();
            this.txtImport_no = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.txtSwid = new ERP.myText();
            this.btnConfirm = new ERP.myBottun();
            this.myLabel5 = new ERP.myLabel();
            this.txtCostInMainCurr = new ERP.myText();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.txtCostInStockCurr = new ERP.myText();
            this.myLabel6 = new ERP.myLabel();
            this.txtContainer = new ERP.myText();
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
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImport_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostInMainCurr)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostInStockCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(320, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(233, 34);
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
            this.btnClose.Location = new System.Drawing.Point(3, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 468;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnClose.w_Type = ERP.myBottun.Btton_type.Close;
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
            this.dgvImpExp.Location = new System.Drawing.Point(4, 117);
            this.dgvImpExp.Name = "dgvImpExp";
            this.dgvImpExp.ReadOnly = true;
            this.dgvImpExp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvImpExp.RowHeadersVisible = false;
            this.dgvImpExp.Size = new System.Drawing.Size(799, 344);
            this.dgvImpExp.TabIndex = 466;
            this.dgvImpExp.W_Clear = true;
            // 
            // txtNote
            // 
            this.txtNote.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtNote.Location = new System.Drawing.Point(365, 92);
            this.txtNote.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(351, 23);
            this.txtNote.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtNote.TabIndex = 465;
            this.txtNote.W_Clear = true;
            this.txtNote.W_ColArName = "الباركود";
            this.txtNote.W_ColEgName = "BARCODE";
            this.txtNote.W_OldValue = "";
            this.txtNote.W_TableName = "BENEFICIARY";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(726, 95);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(52, 18);
            this.myLabel3.TabIndex = 464;
            this.myLabel3.Text = "ملاحظات";
            // 
            // txtImportId
            // 
            this.txtImportId.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtImportId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImportId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtImportId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtImportId.Location = new System.Drawing.Point(662, 64);
            this.txtImportId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtImportId.Name = "txtImportId";
            this.txtImportId.Size = new System.Drawing.Size(37, 23);
            this.txtImportId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtImportId.TabIndex = 462;
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
            this.btnSearch.Location = new System.Drawing.Point(575, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 461;
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
            this.txtImport_no.Enabled = false;
            this.txtImport_no.Font = new System.Drawing.Font("Arial", 10F);
            this.txtImport_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtImport_no.Location = new System.Drawing.Point(609, 65);
            this.txtImport_no.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtImport_no.Name = "txtImport_no";
            this.txtImport_no.Size = new System.Drawing.Size(107, 23);
            this.txtImport_no.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtImport_no.TabIndex = 460;
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
            this.myLabel4.Location = new System.Drawing.Point(512, 70);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(45, 18);
            this.myLabel4.TabIndex = 459;
            this.myLabel4.Text = "الحاوية";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(734, 69);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(38, 18);
            this.myLabel2.TabIndex = 458;
            this.myLabel2.Text = "الوارد";
            // 
            // txtSwid
            // 
            this.txtSwid.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSwid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSwid.Location = new System.Drawing.Point(656, 26);
            this.txtSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSwid.Name = "txtSwid";
            this.txtSwid.Size = new System.Drawing.Size(37, 23);
            this.txtSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSwid.TabIndex = 469;
            this.txtSwid.Visible = false;
            this.txtSwid.W_Clear = true;
            this.txtSwid.W_ColArName = "";
            this.txtSwid.W_ColEgName = "";
            this.txtSwid.W_OldValue = "";
            this.txtSwid.W_TableName = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.IsBackStageButton = false;
            this.btnConfirm.Location = new System.Drawing.Point(60, 463);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(57, 28);
            this.btnConfirm.TabIndex = 470;
            this.btnConfirm.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnConfirm.w_Type = ERP.myBottun.Btton_type.OK;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(161, 27);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(121, 18);
            this.myLabel5.TabIndex = 471;
            this.myLabel5.Text = "المبلغ بالعملة الاساسية";
            // 
            // txtCostInMainCurr
            // 
            this.txtCostInMainCurr.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtCostInMainCurr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostInMainCurr.Enabled = false;
            this.txtCostInMainCurr.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCostInMainCurr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCostInMainCurr.Location = new System.Drawing.Point(6, 23);
            this.txtCostInMainCurr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCostInMainCurr.Name = "txtCostInMainCurr";
            this.txtCostInMainCurr.Size = new System.Drawing.Size(149, 23);
            this.txtCostInMainCurr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCostInMainCurr.TabIndex = 472;
            this.txtCostInMainCurr.W_Clear = true;
            this.txtCostInMainCurr.W_ColArName = "الباركود";
            this.txtCostInMainCurr.W_ColEgName = "BARCODE";
            this.txtCostInMainCurr.W_OldValue = "";
            this.txtCostInMainCurr.W_TableName = "BENEFICIARY";
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtCostInStockCurr);
            this.myGroupBox1.Controls.Add(this.myLabel6);
            this.myGroupBox1.Controls.Add(this.txtCostInMainCurr);
            this.myGroupBox1.Controls.Add(this.myLabel5);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(25, 34);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(288, 81);
            this.myGroupBox1.TabIndex = 473;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "مبلغ الحاوية الاجمالي";
            // 
            // txtCostInStockCurr
            // 
            this.txtCostInStockCurr.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtCostInStockCurr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostInStockCurr.Enabled = false;
            this.txtCostInStockCurr.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCostInStockCurr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCostInStockCurr.Location = new System.Drawing.Point(6, 48);
            this.txtCostInStockCurr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCostInStockCurr.Name = "txtCostInStockCurr";
            this.txtCostInStockCurr.Size = new System.Drawing.Size(149, 23);
            this.txtCostInStockCurr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCostInStockCurr.TabIndex = 474;
            this.txtCostInStockCurr.W_Clear = true;
            this.txtCostInStockCurr.W_ColArName = "الباركود";
            this.txtCostInStockCurr.W_ColEgName = "BARCODE";
            this.txtCostInStockCurr.W_OldValue = "";
            this.txtCostInStockCurr.W_TableName = "BENEFICIARY";
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(161, 51);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(113, 18);
            this.myLabel6.TabIndex = 473;
            this.myLabel6.Text = "المبلغ بعملة المخزون";
            // 
            // txtContainer
            // 
            this.txtContainer.BeforeTouchSize = new System.Drawing.Size(37, 23);
            this.txtContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContainer.Enabled = false;
            this.txtContainer.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtContainer.Location = new System.Drawing.Point(365, 65);
            this.txtContainer.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(141, 23);
            this.txtContainer.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtContainer.TabIndex = 474;
            this.txtContainer.W_Clear = true;
            this.txtContainer.W_ColArName = "الباركود";
            this.txtContainer.W_ColEgName = "BARCODE";
            this.txtContainer.W_OldValue = "";
            this.txtContainer.W_TableName = "BENEFICIARY";
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
            // frmCalculatCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(808, 495);
            this.Controls.Add(this.txtContainer);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtSwid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvImpExp);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.txtImportId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtImport_no);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel2);
            this.Name = "frmCalculatCost";
            this.RightToLeftLayout = false;
            this.Titel = "تكلفة الاصناف";
            this.Load += new System.EventHandler(this.frmCalculatCost_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtImport_no, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.txtImportId, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.dgvImpExp, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.txtSwid, 0);
            this.Controls.SetChildIndex(this.btnConfirm, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.txtContainer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImport_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostInMainCurr)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostInStockCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myBottun btnClose;
        private myDataGrid dgvImpExp;
        private myText txtNote;
        private myLabel myLabel3;
        private myText txtImportId;
        private myBottun btnSearch;
        private myText txtImport_no;
        private myLabel myLabel4;
        private myLabel myLabel2;
        private myText txtSwid;
        private myBottun btnConfirm;
        private myLabel myLabel5;
        private myText txtCostInMainCurr;
        private myGroupBox myGroupBox1;
        private myText txtCostInStockCurr;
        private myLabel myLabel6;
        private myText txtContainer;
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
