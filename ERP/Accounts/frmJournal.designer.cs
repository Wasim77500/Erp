using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;


namespace ERP.Accounts
{
    partial class frmJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myLabel2 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.dgJOURNAL_DETAILS = new ERP.myDataGrid();
            this.clmDetailSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJOUR_VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmACC_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCURR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNewCurrencyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCOST_CENTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostCenterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJOUR_DETAILS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSTAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrentCurrencyRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMinRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOverrideValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmREFERENCE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmActivity = new System.Windows.Forms.DataGridViewButtonColumn();
            this.myLabel9 = new ERP.myLabel();
            this.gbDetail = new ERP.myGroupBox();
            this.txtRefNo = new ERP.myText();
            this.myLabel22 = new ERP.myLabel();
            this.lblBalanceType = new ERP.myLabel();
            this.nmbjour_valueCredit = new ERP.myNumber();
            this.nmbCURR_PRICE = new System.Windows.Forms.NumericUpDown();
            this.myLabel11 = new ERP.myLabel();
            this.nmbCredit = new ERP.myNumber();
            this.myLabel18 = new ERP.myLabel();
            this.myLabel17 = new ERP.myLabel();
            this.nmbDept = new ERP.myNumber();
            this.myLabel7 = new ERP.myLabel();
            this.txtDetailsSWID = new ERP.myText();
            this.nmbSumOfAccBal = new ERP.myNumber();
            this.lstCurrency = new ERP.myList();
            this.btnClearDetails = new ERP.myBottun();
            this.myLabel10 = new ERP.myLabel();
            this.txtCostCenterId = new ERP.myText();
            this.btnGetCostCenter = new ERP.myBottun();
            this.txtCostCenterName = new ERP.myText();
            this.myLabel15 = new ERP.myLabel();
            this.nmbjour_valueDept = new ERP.myNumber();
            this.txtJOUR_DETAILS = new ERP.myText();
            this.myLabel14 = new ERP.myLabel();
            this.btnAdd = new ERP.myBottun();
            this.btnGetAccount = new ERP.myBottun();
            this.lstAccName = new ERP.myList();
            this.lstAccNo = new ERP.myList();
            this.myLabel13 = new ERP.myLabel();
            this.myLabel12 = new ERP.myLabel();
            this.lstBranchHeader = new ERP.myList();
            this.txtCreditTotal = new ERP.myNumber();
            this.txtDeptTotal = new ERP.myNumber();
            this.txtVOCH_NO = new ERP.myText();
            this.txtIssueId = new ERP.myText();
            this.dtpJOUR_DATE = new ERP.myDate();
            this.txtJOUR_DETAILS_Header = new ERP.myText();
            this.btnNew = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.txtDeptDiff = new ERP.myText();
            this.txtCreditDiff = new ERP.myText();
            this.errCheckDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSWID = new ERP.myText();
            this.btnFind = new ERP.myBottun();
            this.lstTempBranch = new ERP.myText();
            this.btnDelete = new ERP.myBottun();
            this.myLabel8 = new ERP.myLabel();
            this.myLabel16 = new ERP.myLabel();
            this.txtExchangeRateExceeded = new ERP.myText();
            this.dgvJourTemp = new ERP.myDataGrid();
            this.clmTempSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTempVoucherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTempScheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTempBtnSchedual = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmT_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHangs = new ERP.myDataGrid();
            this.clmHangSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIssueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHangNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddJourTemp = new ERP.myBottun();
            this.myLabel19 = new ERP.myLabel();
            this.myLabel20 = new ERP.myLabel();
            this.myLabel21 = new ERP.myLabel();
            this.btnPrint = new ERP.myBottun();
            this.txtForceNote = new ERP.myText();
            this.txtDistributedActivity = new ERP.myText();
            this.txtExRateDateDefaultValue = new ERP.myText();
            this.txtAllowExceedNaturalAcc = new ERP.myText();
            this.txtAllowGeneralVoucher = new ERP.myText();
            this.ckbExRateDate = new ERP.mycheck();
            this.myLabel23 = new ERP.myLabel();
            this.btnHang = new ERP.myBottun();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJOURNAL_DETAILS)).BeginInit();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbjour_valueCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURR_PRICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailsSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSumOfAccBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostCenterId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostCenterName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbjour_valueDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJOUR_DETAILS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVOCH_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssueId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpJOUR_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJOUR_DETAILS_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheckDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTempBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRateExceeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtForceNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistributedActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExRateDateDefaultValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowExceedNaturalAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowGeneralVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbExRateDate)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(434, 34);
            this.lstTemplet.SelectedIndexChanged += new System.EventHandler(this.lstTemplet_SelectedIndexChanged);
            this.lstTemplet.Click += new System.EventHandler(this.lstTemplet_Click);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(347, 34);
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(3, 78);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myLabel2.Size = new System.Drawing.Size(61, 18);
            this.myLabel2.TabIndex = 2;
            this.myLabel2.Text = "رقم الحركة";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(213, 74);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myLabel3.Size = new System.Drawing.Size(81, 18);
            this.myLabel3.TabIndex = 3;
            this.myLabel3.Text = "رقم قيد اليومية";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(223, 103);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myLabel4.Size = new System.Drawing.Size(60, 18);
            this.myLabel4.TabIndex = 4;
            this.myLabel4.Text = "تاريخ القيد";
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(9, 162);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myLabel6.Size = new System.Drawing.Size(36, 18);
            this.myLabel6.TabIndex = 6;
            this.myLabel6.Text = "البيان";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(545, 115);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(67, 18);
            this.myLabel5.TabIndex = 5;
            this.myLabel5.Text = "مركز التكلفة";
            // 
            // dgJOURNAL_DETAILS
            // 
            this.dgJOURNAL_DETAILS.AllowUserToAddRows = false;
            this.dgJOURNAL_DETAILS.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.dgJOURNAL_DETAILS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgJOURNAL_DETAILS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJOURNAL_DETAILS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgJOURNAL_DETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJOURNAL_DETAILS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDetailSwid,
            this.clmcredit,
            this.clmDept,
            this.clmJOUR_VALUE,
            this.clmACC_ID,
            this.clmAccNo,
            this.clmAccName,
            this.clmCURR_ID,
            this.clmCurrName,
            this.clmNewCurrencyRate,
            this.clmCOST_CENTER,
            this.clmCostCenterName,
            this.clmJOUR_DETAILS,
            this.clmSTAT,
            this.clmCurrentCurrencyRateId,
            this.clmMaxRate,
            this.clmMinRate,
            this.clmOverrideValue,
            this.clmREFERENCE_NO,
            this.clmDelete,
            this.clmActivity});
            this.dgJOURNAL_DETAILS.EnableHeadersVisualStyles = false;
            this.dgJOURNAL_DETAILS.Location = new System.Drawing.Point(421, 255);
            this.dgJOURNAL_DETAILS.Name = "dgJOURNAL_DETAILS";
            this.dgJOURNAL_DETAILS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgJOURNAL_DETAILS.RowHeadersVisible = false;
            this.dgJOURNAL_DETAILS.Size = new System.Drawing.Size(611, 231);
            this.dgJOURNAL_DETAILS.TabIndex = 7;
            this.dgJOURNAL_DETAILS.W_Clear = true;
            this.dgJOURNAL_DETAILS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgJOURNAL_DETAILS_CellClick);
            this.dgJOURNAL_DETAILS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgJOURNAL_DETAILS_CellDoubleClick);
            this.dgJOURNAL_DETAILS.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgJOURNAL_DETAILS_ColumnWidthChanged);
            // 
            // clmDetailSwid
            // 
            this.clmDetailSwid.HeaderText = "swid";
            this.clmDetailSwid.Name = "clmDetailSwid";
            this.clmDetailSwid.ReadOnly = true;
            this.clmDetailSwid.ToolTipText = ".";
            this.clmDetailSwid.Visible = false;
            // 
            // clmcredit
            // 
            this.clmcredit.HeaderText = "دائن";
            this.clmcredit.Name = "clmcredit";
            this.clmcredit.ReadOnly = true;
            this.clmcredit.ToolTipText = ".";
            this.clmcredit.Width = 80;
            // 
            // clmDept
            // 
            this.clmDept.HeaderText = "مدين";
            this.clmDept.Name = "clmDept";
            this.clmDept.ReadOnly = true;
            this.clmDept.ToolTipText = ".";
            this.clmDept.Width = 80;
            // 
            // clmJOUR_VALUE
            // 
            this.clmJOUR_VALUE.HeaderText = "المقابل";
            this.clmJOUR_VALUE.Name = "clmJOUR_VALUE";
            this.clmJOUR_VALUE.ReadOnly = true;
            this.clmJOUR_VALUE.ToolTipText = ".";
            this.clmJOUR_VALUE.Width = 80;
            // 
            // clmACC_ID
            // 
            this.clmACC_ID.HeaderText = "acc_id";
            this.clmACC_ID.Name = "clmACC_ID";
            this.clmACC_ID.ReadOnly = true;
            this.clmACC_ID.ToolTipText = ".";
            this.clmACC_ID.Visible = false;
            // 
            // clmAccNo
            // 
            this.clmAccNo.HeaderText = "رقم الحساب";
            this.clmAccNo.Name = "clmAccNo";
            this.clmAccNo.ReadOnly = true;
            // 
            // clmAccName
            // 
            this.clmAccName.HeaderText = "اسم الحساب";
            this.clmAccName.Name = "clmAccName";
            this.clmAccName.ReadOnly = true;
            // 
            // clmCURR_ID
            // 
            this.clmCURR_ID.HeaderText = "currencyId";
            this.clmCURR_ID.Name = "clmCURR_ID";
            this.clmCURR_ID.ReadOnly = true;
            this.clmCURR_ID.ToolTipText = ".";
            this.clmCURR_ID.Visible = false;
            // 
            // clmCurrName
            // 
            this.clmCurrName.HeaderText = "العملة";
            this.clmCurrName.Name = "clmCurrName";
            this.clmCurrName.ReadOnly = true;
            this.clmCurrName.Width = 60;
            // 
            // clmNewCurrencyRate
            // 
            this.clmNewCurrencyRate.HeaderText = "سعر الصرف";
            this.clmNewCurrencyRate.Name = "clmNewCurrencyRate";
            this.clmNewCurrencyRate.ReadOnly = true;
            this.clmNewCurrencyRate.ToolTipText = ".";
            // 
            // clmCOST_CENTER
            // 
            this.clmCOST_CENTER.HeaderText = "costCenterid";
            this.clmCOST_CENTER.Name = "clmCOST_CENTER";
            this.clmCOST_CENTER.ReadOnly = true;
            this.clmCOST_CENTER.ToolTipText = ".";
            this.clmCOST_CENTER.Visible = false;
            // 
            // clmCostCenterName
            // 
            this.clmCostCenterName.HeaderText = "مركز التكلفة";
            this.clmCostCenterName.Name = "clmCostCenterName";
            this.clmCostCenterName.ReadOnly = true;
            // 
            // clmJOUR_DETAILS
            // 
            this.clmJOUR_DETAILS.HeaderText = "ملاحظات";
            this.clmJOUR_DETAILS.Name = "clmJOUR_DETAILS";
            this.clmJOUR_DETAILS.ReadOnly = true;
            this.clmJOUR_DETAILS.ToolTipText = ".";
            // 
            // clmSTAT
            // 
            this.clmSTAT.HeaderText = "الحالة";
            this.clmSTAT.Name = "clmSTAT";
            this.clmSTAT.ReadOnly = true;
            this.clmSTAT.ToolTipText = ".";
            this.clmSTAT.Visible = false;
            // 
            // clmCurrentCurrencyRateId
            // 
            this.clmCurrentCurrencyRateId.HeaderText = "CurrenExchangeRateId";
            this.clmCurrentCurrencyRateId.Name = "clmCurrentCurrencyRateId";
            this.clmCurrentCurrencyRateId.ReadOnly = true;
            this.clmCurrentCurrencyRateId.ToolTipText = ".";
            this.clmCurrentCurrencyRateId.Visible = false;
            // 
            // clmMaxRate
            // 
            this.clmMaxRate.HeaderText = "Max Rate";
            this.clmMaxRate.Name = "clmMaxRate";
            this.clmMaxRate.ReadOnly = true;
            this.clmMaxRate.Visible = false;
            // 
            // clmMinRate
            // 
            this.clmMinRate.HeaderText = "MinRate";
            this.clmMinRate.Name = "clmMinRate";
            this.clmMinRate.ReadOnly = true;
            this.clmMinRate.Visible = false;
            // 
            // clmOverrideValue
            // 
            this.clmOverrideValue.HeaderText = "OverrideValue";
            this.clmOverrideValue.Name = "clmOverrideValue";
            this.clmOverrideValue.ReadOnly = true;
            this.clmOverrideValue.Visible = false;
            // 
            // clmREFERENCE_NO
            // 
            this.clmREFERENCE_NO.HeaderText = "رقم المستند";
            this.clmREFERENCE_NO.Name = "clmREFERENCE_NO";
            this.clmREFERENCE_NO.ReadOnly = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "حذف";
            this.clmDelete.Image = global::ERP.Properties.Resources.S43Qy;
            this.clmDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 40;
            // 
            // clmActivity
            // 
            this.clmActivity.HeaderText = "الانشطة";
            this.clmActivity.Name = "clmActivity";
            this.clmActivity.Width = 53;
            // 
            // myLabel9
            // 
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(9, 107);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myLabel9.Size = new System.Drawing.Size(35, 18);
            this.myLabel9.TabIndex = 12;
            this.myLabel9.Text = "الفرع";
            // 
            // gbDetail
            // 
            this.gbDetail.BackColor = System.Drawing.Color.Transparent;
            this.gbDetail.Controls.Add(this.txtRefNo);
            this.gbDetail.Controls.Add(this.myLabel22);
            this.gbDetail.Controls.Add(this.lblBalanceType);
            this.gbDetail.Controls.Add(this.nmbjour_valueCredit);
            this.gbDetail.Controls.Add(this.nmbCURR_PRICE);
            this.gbDetail.Controls.Add(this.myLabel11);
            this.gbDetail.Controls.Add(this.nmbCredit);
            this.gbDetail.Controls.Add(this.myLabel18);
            this.gbDetail.Controls.Add(this.myLabel17);
            this.gbDetail.Controls.Add(this.nmbDept);
            this.gbDetail.Controls.Add(this.myLabel7);
            this.gbDetail.Controls.Add(this.txtDetailsSWID);
            this.gbDetail.Controls.Add(this.nmbSumOfAccBal);
            this.gbDetail.Controls.Add(this.lstCurrency);
            this.gbDetail.Controls.Add(this.btnClearDetails);
            this.gbDetail.Controls.Add(this.myLabel10);
            this.gbDetail.Controls.Add(this.txtCostCenterId);
            this.gbDetail.Controls.Add(this.btnGetCostCenter);
            this.gbDetail.Controls.Add(this.txtCostCenterName);
            this.gbDetail.Controls.Add(this.myLabel15);
            this.gbDetail.Controls.Add(this.nmbjour_valueDept);
            this.gbDetail.Controls.Add(this.txtJOUR_DETAILS);
            this.gbDetail.Controls.Add(this.myLabel14);
            this.gbDetail.Controls.Add(this.btnAdd);
            this.gbDetail.Controls.Add(this.myLabel5);
            this.gbDetail.Controls.Add(this.btnGetAccount);
            this.gbDetail.Controls.Add(this.lstAccName);
            this.gbDetail.Controls.Add(this.lstAccNo);
            this.gbDetail.Controls.Add(this.myLabel13);
            this.gbDetail.Controls.Add(this.myLabel12);
            this.gbDetail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbDetail.Location = new System.Drawing.Point(421, 68);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(614, 181);
            this.gbDetail.TabIndex = 13;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "بيانات القيد";
            this.gbDetail.Enter += new System.EventHandler(this.myGroupBox1_Enter);
            // 
            // txtRefNo
            // 
            this.txtRefNo.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRefNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtRefNo.Location = new System.Drawing.Point(3, 112);
            this.txtRefNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(177, 23);
            this.txtRefNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtRefNo.TabIndex = 310;
            this.txtRefNo.W_Clear = true;
            this.txtRefNo.W_ColArName = "";
            this.txtRefNo.W_ColEgName = "";
            this.txtRefNo.W_OldValue = "";
            this.txtRefNo.W_TableName = "";
            // 
            // myLabel22
            // 
            this.myLabel22.BackColor = System.Drawing.Color.Transparent;
            this.myLabel22.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel22.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel22.ForeColor = System.Drawing.Color.Black;
            this.myLabel22.Location = new System.Drawing.Point(189, 112);
            this.myLabel22.Name = "myLabel22";
            this.myLabel22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myLabel22.Size = new System.Drawing.Size(64, 18);
            this.myLabel22.TabIndex = 310;
            this.myLabel22.Text = "رقم المستند";
            // 
            // lblBalanceType
            // 
            this.lblBalanceType.BackColor = System.Drawing.Color.Transparent;
            this.lblBalanceType.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBalanceType.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceType.ForeColor = System.Drawing.Color.Black;
            this.lblBalanceType.Location = new System.Drawing.Point(6, 82);
            this.lblBalanceType.Name = "lblBalanceType";
            this.lblBalanceType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBalanceType.Size = new System.Drawing.Size(29, 18);
            this.lblBalanceType.TabIndex = 221;
            this.lblBalanceType.Text = "دائن";
            // 
            // nmbjour_valueCredit
            // 
            this.nmbjour_valueCredit.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbjour_valueCredit.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.nmbjour_valueCredit.DecimalPlaces = 0;
            this.nmbjour_valueCredit.DoubleValue = 0D;
            this.nmbjour_valueCredit.Enabled = false;
            this.nmbjour_valueCredit.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbjour_valueCredit.Location = new System.Drawing.Point(258, 55);
            this.nmbjour_valueCredit.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbjour_valueCredit.MinValue = 0D;
            this.nmbjour_valueCredit.Name = "nmbjour_valueCredit";
            this.nmbjour_valueCredit.NullString = "";
            this.nmbjour_valueCredit.NumberDecimalDigits = 0;
            this.nmbjour_valueCredit.Size = new System.Drawing.Size(105, 23);
            this.nmbjour_valueCredit.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbjour_valueCredit.TabIndex = 20;
            this.nmbjour_valueCredit.Text = "0";
            this.nmbjour_valueCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbjour_valueCredit.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbjour_valueCredit.W_Clear = true;
            this.nmbjour_valueCredit.W_ColArName = "";
            this.nmbjour_valueCredit.W_ColEgName = "";
            this.nmbjour_valueCredit.W_OldValue = "";
            this.nmbjour_valueCredit.W_TableName = "";
            this.nmbjour_valueCredit.Leave += new System.EventHandler(this.nmbjour_valueCredit_TextChanged);
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
            this.nmbCURR_PRICE.Location = new System.Drawing.Point(349, 25);
            this.nmbCURR_PRICE.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nmbCURR_PRICE.Name = "nmbCURR_PRICE";
            this.nmbCURR_PRICE.ReadOnly = true;
            this.nmbCURR_PRICE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nmbCURR_PRICE.Size = new System.Drawing.Size(91, 23);
            this.nmbCURR_PRICE.TabIndex = 2;
            this.nmbCURR_PRICE.ValueChanged += new System.EventHandler(this.nmbCURR_PRICE_ValueChanged_1);
            this.nmbCURR_PRICE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            this.nmbCURR_PRICE.Leave += new System.EventHandler(this.nmbCURR_PRICE_Leave);
            // 
            // myLabel11
            // 
            this.myLabel11.BackColor = System.Drawing.Color.Transparent;
            this.myLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel11.ForeColor = System.Drawing.Color.Black;
            this.myLabel11.Location = new System.Drawing.Point(375, 59);
            this.myLabel11.Name = "myLabel11";
            this.myLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel11.Size = new System.Drawing.Size(67, 18);
            this.myLabel11.TabIndex = 220;
            this.myLabel11.Text = "المقابل دائن";
            // 
            // nmbCredit
            // 
            this.nmbCredit.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbCredit.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.nmbCredit.DecimalPlaces = 0;
            this.nmbCredit.DoubleValue = 0D;
            this.nmbCredit.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbCredit.Location = new System.Drawing.Point(10, 25);
            this.nmbCredit.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbCredit.MinValue = 0D;
            this.nmbCredit.Name = "nmbCredit";
            this.nmbCredit.NullString = "";
            this.nmbCredit.NumberDecimalDigits = 0;
            this.nmbCredit.Size = new System.Drawing.Size(107, 23);
            this.nmbCredit.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbCredit.TabIndex = 10;
            this.nmbCredit.Text = "0";
            this.nmbCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbCredit.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbCredit.W_Clear = true;
            this.nmbCredit.W_ColArName = "";
            this.nmbCredit.W_ColEgName = "";
            this.nmbCredit.W_OldValue = "";
            this.nmbCredit.W_TableName = "";
            this.nmbCredit.Leave += new System.EventHandler(this.nmbCredit_TextChanged);
            // 
            // myLabel18
            // 
            this.myLabel18.BackColor = System.Drawing.Color.Transparent;
            this.myLabel18.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel18.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel18.ForeColor = System.Drawing.Color.Black;
            this.myLabel18.Location = new System.Drawing.Point(142, 27);
            this.myLabel18.Name = "myLabel18";
            this.myLabel18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel18.Size = new System.Drawing.Size(29, 18);
            this.myLabel18.TabIndex = 218;
            this.myLabel18.Text = "دائن";
            // 
            // myLabel17
            // 
            this.myLabel17.BackColor = System.Drawing.Color.Transparent;
            this.myLabel17.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel17.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel17.ForeColor = System.Drawing.Color.Black;
            this.myLabel17.Location = new System.Drawing.Point(295, 28);
            this.myLabel17.Name = "myLabel17";
            this.myLabel17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel17.Size = new System.Drawing.Size(31, 18);
            this.myLabel17.TabIndex = 217;
            this.myLabel17.Text = "مدين";
            // 
            // nmbDept
            // 
            this.nmbDept.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbDept.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.nmbDept.DecimalPlaces = 0;
            this.nmbDept.DoubleValue = 0D;
            this.nmbDept.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbDept.Location = new System.Drawing.Point(189, 25);
            this.nmbDept.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbDept.MinValue = 0D;
            this.nmbDept.Name = "nmbDept";
            this.nmbDept.NullString = "";
            this.nmbDept.NumberDecimalDigits = 0;
            this.nmbDept.Size = new System.Drawing.Size(92, 23);
            this.nmbDept.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbDept.TabIndex = 5;
            this.nmbDept.Text = "0";
            this.nmbDept.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbDept.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbDept.W_Clear = true;
            this.nmbDept.W_ColArName = "";
            this.nmbDept.W_ColEgName = "";
            this.nmbDept.W_OldValue = "";
            this.nmbDept.W_TableName = "";
            this.nmbDept.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            this.nmbDept.Leave += new System.EventHandler(this.nmbDept_TextChanged);
            // 
            // myLabel7
            // 
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(180, 84);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(78, 18);
            this.myLabel7.TabIndex = 215;
            this.myLabel7.Text = "رصيد الحساب";
            // 
            // txtDetailsSWID
            // 
            this.txtDetailsSWID.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtDetailsSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetailsSWID.Enabled = false;
            this.txtDetailsSWID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDetailsSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDetailsSWID.Location = new System.Drawing.Point(561, 25);
            this.txtDetailsSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDetailsSWID.Name = "txtDetailsSWID";
            this.txtDetailsSWID.Size = new System.Drawing.Size(40, 23);
            this.txtDetailsSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDetailsSWID.TabIndex = 214;
            this.txtDetailsSWID.Visible = false;
            this.txtDetailsSWID.W_Clear = true;
            this.txtDetailsSWID.W_ColArName = "";
            this.txtDetailsSWID.W_ColEgName = "";
            this.txtDetailsSWID.W_OldValue = "";
            this.txtDetailsSWID.W_TableName = "";
            // 
            // nmbSumOfAccBal
            // 
            this.nmbSumOfAccBal.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbSumOfAccBal.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.nmbSumOfAccBal.DecimalPlaces = 0;
            this.nmbSumOfAccBal.DoubleValue = 0D;
            this.nmbSumOfAccBal.Enabled = false;
            this.nmbSumOfAccBal.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbSumOfAccBal.Location = new System.Drawing.Point(37, 79);
            this.nmbSumOfAccBal.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbSumOfAccBal.MinValue = 0D;
            this.nmbSumOfAccBal.Name = "nmbSumOfAccBal";
            this.nmbSumOfAccBal.NullString = "";
            this.nmbSumOfAccBal.NumberDecimalDigits = 0;
            this.nmbSumOfAccBal.Size = new System.Drawing.Size(143, 23);
            this.nmbSumOfAccBal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbSumOfAccBal.TabIndex = 213;
            this.nmbSumOfAccBal.TabStop = false;
            this.nmbSumOfAccBal.Text = "0";
            this.nmbSumOfAccBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbSumOfAccBal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbSumOfAccBal.W_Clear = true;
            this.nmbSumOfAccBal.W_ColArName = "";
            this.nmbSumOfAccBal.W_ColEgName = "";
            this.nmbSumOfAccBal.W_OldValue = "";
            this.nmbSumOfAccBal.W_TableName = "";
            // 
            // lstCurrency
            // 
            this.lstCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCurrency.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCurrency.FormattingEnabled = true;
            this.lstCurrency.Location = new System.Drawing.Point(446, 24);
            this.lstCurrency.Name = "lstCurrency";
            this.lstCurrency.Size = new System.Drawing.Size(93, 24);
            this.lstCurrency.TabIndex = 1;
            this.lstCurrency.W_Clear = false;
            this.lstCurrency.W_ColArName = "";
            this.lstCurrency.W_ColEgName = "";
            this.lstCurrency.W_OldValue = "";
            this.lstCurrency.W_TableName = "";
            this.lstCurrency.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstCurrency.SelectedIndexChanged += new System.EventHandler(this.lstCurrency_SelectedIndexChanged);
            this.lstCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ctrl_KeyPress);
            // 
            // btnClearDetails
            // 
            this.btnClearDetails.BeforeTouchSize = new System.Drawing.Size(30, 30);
            this.btnClearDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearDetails.FlatAppearance.BorderSize = 0;
            this.btnClearDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnClearDetails.Image")));
            this.btnClearDetails.IsBackStageButton = false;
            this.btnClearDetails.Location = new System.Drawing.Point(14, 144);
            this.btnClearDetails.Name = "btnClearDetails";
            this.btnClearDetails.Size = new System.Drawing.Size(30, 30);
            this.btnClearDetails.TabIndex = 211;
            this.btnClearDetails.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnClearDetails.w_Type = ERP.myBottun.Btton_type.delterow;
            this.btnClearDetails.Click += new System.EventHandler(this.btnClearDetails_Click);
            // 
            // myLabel10
            // 
            this.myLabel10.BackColor = System.Drawing.Color.Transparent;
            this.myLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel10.ForeColor = System.Drawing.Color.Black;
            this.myLabel10.Location = new System.Drawing.Point(562, 30);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel10.Size = new System.Drawing.Size(37, 18);
            this.myLabel10.TabIndex = 10;
            this.myLabel10.Text = "العملة";
            // 
            // txtCostCenterId
            // 
            this.txtCostCenterId.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtCostCenterId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostCenterId.Enabled = false;
            this.txtCostCenterId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCostCenterId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCostCenterId.Location = new System.Drawing.Point(372, 112);
            this.txtCostCenterId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCostCenterId.Name = "txtCostCenterId";
            this.txtCostCenterId.Size = new System.Drawing.Size(40, 23);
            this.txtCostCenterId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCostCenterId.TabIndex = 210;
            this.txtCostCenterId.Visible = false;
            this.txtCostCenterId.W_Clear = true;
            this.txtCostCenterId.W_ColArName = "";
            this.txtCostCenterId.W_ColEgName = "";
            this.txtCostCenterId.W_OldValue = "";
            this.txtCostCenterId.W_TableName = "";
            // 
            // btnGetCostCenter
            // 
            this.btnGetCostCenter.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetCostCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetCostCenter.FlatAppearance.BorderSize = 0;
            this.btnGetCostCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCostCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnGetCostCenter.Image")));
            this.btnGetCostCenter.IsBackStageButton = false;
            this.btnGetCostCenter.Location = new System.Drawing.Point(258, 108);
            this.btnGetCostCenter.Name = "btnGetCostCenter";
            this.btnGetCostCenter.Size = new System.Drawing.Size(28, 27);
            this.btnGetCostCenter.TabIndex = 100;
            this.btnGetCostCenter.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnGetCostCenter.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetCostCenter.Click += new System.EventHandler(this.btnGetCostCenter_Click);
            // 
            // txtCostCenterName
            // 
            this.txtCostCenterName.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtCostCenterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostCenterName.Enabled = false;
            this.txtCostCenterName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCostCenterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCostCenterName.Location = new System.Drawing.Point(292, 112);
            this.txtCostCenterName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCostCenterName.Name = "txtCostCenterName";
            this.txtCostCenterName.Size = new System.Drawing.Size(247, 23);
            this.txtCostCenterName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCostCenterName.TabIndex = 102;
            this.txtCostCenterName.W_Clear = true;
            this.txtCostCenterName.W_ColArName = "";
            this.txtCostCenterName.W_ColEgName = "";
            this.txtCostCenterName.W_OldValue = "";
            this.txtCostCenterName.W_TableName = "";
            // 
            // myLabel15
            // 
            this.myLabel15.BackColor = System.Drawing.Color.Transparent;
            this.myLabel15.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel15.ForeColor = System.Drawing.Color.Black;
            this.myLabel15.Location = new System.Drawing.Point(545, 59);
            this.myLabel15.Name = "myLabel15";
            this.myLabel15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel15.Size = new System.Drawing.Size(69, 18);
            this.myLabel15.TabIndex = 206;
            this.myLabel15.Text = "المقابل مدين";
            // 
            // nmbjour_valueDept
            // 
            this.nmbjour_valueDept.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbjour_valueDept.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.nmbjour_valueDept.DecimalPlaces = 0;
            this.nmbjour_valueDept.DoubleValue = 0D;
            this.nmbjour_valueDept.Enabled = false;
            this.nmbjour_valueDept.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbjour_valueDept.Location = new System.Drawing.Point(446, 54);
            this.nmbjour_valueDept.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbjour_valueDept.MinValue = 0D;
            this.nmbjour_valueDept.Name = "nmbjour_valueDept";
            this.nmbjour_valueDept.NullString = "";
            this.nmbjour_valueDept.NumberDecimalDigits = 0;
            this.nmbjour_valueDept.Size = new System.Drawing.Size(93, 23);
            this.nmbjour_valueDept.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbjour_valueDept.TabIndex = 15;
            this.nmbjour_valueDept.Text = "0";
            this.nmbjour_valueDept.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbjour_valueDept.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbjour_valueDept.W_Clear = true;
            this.nmbjour_valueDept.W_ColArName = "";
            this.nmbjour_valueDept.W_ColEgName = "";
            this.nmbjour_valueDept.W_OldValue = "";
            this.nmbjour_valueDept.W_TableName = "";
            this.nmbjour_valueDept.Leave += new System.EventHandler(this.nmbjour_valueDept_TextChanged);
            // 
            // txtJOUR_DETAILS
            // 
            this.txtJOUR_DETAILS.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtJOUR_DETAILS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJOUR_DETAILS.Font = new System.Drawing.Font("Arial", 10F);
            this.txtJOUR_DETAILS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtJOUR_DETAILS.Location = new System.Drawing.Point(89, 141);
            this.txtJOUR_DETAILS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJOUR_DETAILS.Multiline = true;
            this.txtJOUR_DETAILS.Name = "txtJOUR_DETAILS";
            this.txtJOUR_DETAILS.Size = new System.Drawing.Size(438, 32);
            this.txtJOUR_DETAILS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJOUR_DETAILS.TabIndex = 35;
            this.txtJOUR_DETAILS.W_Clear = true;
            this.txtJOUR_DETAILS.W_ColArName = "";
            this.txtJOUR_DETAILS.W_ColEgName = "";
            this.txtJOUR_DETAILS.W_OldValue = "";
            this.txtJOUR_DETAILS.W_TableName = "";
            this.txtJOUR_DETAILS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ctrl_KeyPress);
            // 
            // myLabel14
            // 
            this.myLabel14.BackColor = System.Drawing.Color.Transparent;
            this.myLabel14.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel14.ForeColor = System.Drawing.Color.Black;
            this.myLabel14.Location = new System.Drawing.Point(547, 146);
            this.myLabel14.Name = "myLabel14";
            this.myLabel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel14.Size = new System.Drawing.Size(52, 18);
            this.myLabel14.TabIndex = 22;
            this.myLabel14.Text = "ملاحظات";
            // 
            // btnAdd
            // 
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(36, 24);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.Image = global::ERP.Properties.Resources.Add_h;
            this.btnAdd.IsBackStageButton = false;
            this.btnAdd.Location = new System.Drawing.Point(47, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 24);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetAccount
            // 
            this.btnGetAccount.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetAccount.FlatAppearance.BorderSize = 0;
            this.btnGetAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnGetAccount.Image")));
            this.btnGetAccount.IsBackStageButton = false;
            this.btnGetAccount.Location = new System.Drawing.Point(3, 50);
            this.btnGetAccount.Name = "btnGetAccount";
            this.btnGetAccount.Size = new System.Drawing.Size(28, 27);
            this.btnGetAccount.TabIndex = 101;
            this.btnGetAccount.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnGetAccount.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetAccount.Click += new System.EventHandler(this.btnGetAccount_Click);
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(258, 82);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(281, 24);
            this.lstAccName.TabIndex = 30;
            this.lstAccName.W_Clear = true;
            this.lstAccName.W_ColArName = "";
            this.lstAccName.W_ColEgName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.W_TableName = "";
            this.lstAccName.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccName.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            this.lstAccName.SelectedValueChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            this.lstAccName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(37, 53);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(143, 24);
            this.lstAccNo.TabIndex = 25;
            this.lstAccNo.W_Clear = true;
            this.lstAccNo.W_ColArName = "";
            this.lstAccNo.W_ColEgName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.W_TableName = "";
            this.lstAccNo.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            this.lstAccNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            // 
            // myLabel13
            // 
            this.myLabel13.BackColor = System.Drawing.Color.Transparent;
            this.myLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel13.ForeColor = System.Drawing.Color.Black;
            this.myLabel13.Location = new System.Drawing.Point(541, 84);
            this.myLabel13.Name = "myLabel13";
            this.myLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel13.Size = new System.Drawing.Size(69, 18);
            this.myLabel13.TabIndex = 18;
            this.myLabel13.Text = "اسم الحساب";
            // 
            // myLabel12
            // 
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(182, 58);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(67, 18);
            this.myLabel12.TabIndex = 17;
            this.myLabel12.Text = "رقم الحساب";
            // 
            // lstBranchHeader
            // 
            this.lstBranchHeader.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBranchHeader.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBranchHeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBranchHeader.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBranchHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstBranchHeader.FormattingEnabled = true;
            this.lstBranchHeader.Location = new System.Drawing.Point(68, 102);
            this.lstBranchHeader.Name = "lstBranchHeader";
            this.lstBranchHeader.Size = new System.Drawing.Size(130, 24);
            this.lstBranchHeader.TabIndex = 1;
            this.lstBranchHeader.W_Clear = false;
            this.lstBranchHeader.W_ColArName = "";
            this.lstBranchHeader.W_ColEgName = "";
            this.lstBranchHeader.W_OldValue = "";
            this.lstBranchHeader.W_TableName = "";
            this.lstBranchHeader.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstBranchHeader.SelectedIndexChanged += new System.EventHandler(this.lstBranchHeader_SelectedIndexChanged);
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.BackGroundColor = System.Drawing.SystemColors.ControlDark;
            this.txtCreditTotal.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtCreditTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCreditTotal.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtCreditTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreditTotal.DecimalPlaces = 0;
            this.txtCreditTotal.DoubleValue = 0D;
            this.txtCreditTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCreditTotal.Location = new System.Drawing.Point(428, 492);
            this.txtCreditTotal.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCreditTotal.MinValue = 0D;
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.NullString = "";
            this.txtCreditTotal.NumberDecimalDigits = 0;
            this.txtCreditTotal.ReadOnly = true;
            this.txtCreditTotal.Size = new System.Drawing.Size(116, 23);
            this.txtCreditTotal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCreditTotal.TabIndex = 14;
            this.txtCreditTotal.Text = "0";
            this.txtCreditTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCreditTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCreditTotal.W_Clear = true;
            this.txtCreditTotal.W_ColArName = "";
            this.txtCreditTotal.W_ColEgName = "";
            this.txtCreditTotal.W_OldValue = "";
            this.txtCreditTotal.W_TableName = "";
            // 
            // txtDeptTotal
            // 
            this.txtDeptTotal.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtDeptTotal.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtDeptTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDeptTotal.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtDeptTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDeptTotal.DecimalPlaces = 0;
            this.txtDeptTotal.DoubleValue = 0D;
            this.txtDeptTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDeptTotal.Location = new System.Drawing.Point(544, 492);
            this.txtDeptTotal.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDeptTotal.MinValue = 0D;
            this.txtDeptTotal.Name = "txtDeptTotal";
            this.txtDeptTotal.NullString = "";
            this.txtDeptTotal.NumberDecimalDigits = 0;
            this.txtDeptTotal.ReadOnly = true;
            this.txtDeptTotal.Size = new System.Drawing.Size(120, 23);
            this.txtDeptTotal.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDeptTotal.TabIndex = 15;
            this.txtDeptTotal.Text = "0";
            this.txtDeptTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeptTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDeptTotal.W_Clear = true;
            this.txtDeptTotal.W_ColArName = "";
            this.txtDeptTotal.W_ColEgName = "";
            this.txtDeptTotal.W_OldValue = "";
            this.txtDeptTotal.W_TableName = "";
            // 
            // txtVOCH_NO
            // 
            this.txtVOCH_NO.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtVOCH_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVOCH_NO.Enabled = false;
            this.txtVOCH_NO.Font = new System.Drawing.Font("Arial", 10F);
            this.txtVOCH_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtVOCH_NO.Location = new System.Drawing.Point(68, 72);
            this.txtVOCH_NO.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtVOCH_NO.Name = "txtVOCH_NO";
            this.txtVOCH_NO.Size = new System.Drawing.Size(100, 23);
            this.txtVOCH_NO.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtVOCH_NO.TabIndex = 16;
            this.txtVOCH_NO.TabStop = false;
            this.txtVOCH_NO.W_Clear = true;
            this.txtVOCH_NO.W_ColArName = "";
            this.txtVOCH_NO.W_ColEgName = "";
            this.txtVOCH_NO.W_OldValue = "";
            this.txtVOCH_NO.W_TableName = "";
            this.txtVOCH_NO.TextChanged += new System.EventHandler(this.txtJOUR_NUM_TextChanged);
            // 
            // txtIssueId
            // 
            this.txtIssueId.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtIssueId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssueId.Enabled = false;
            this.txtIssueId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtIssueId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtIssueId.Location = new System.Drawing.Point(300, 72);
            this.txtIssueId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtIssueId.Name = "txtIssueId";
            this.txtIssueId.Size = new System.Drawing.Size(107, 23);
            this.txtIssueId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtIssueId.TabIndex = 0;
            this.txtIssueId.W_Clear = true;
            this.txtIssueId.W_ColArName = "";
            this.txtIssueId.W_ColEgName = "";
            this.txtIssueId.W_OldValue = "";
            this.txtIssueId.W_TableName = "";
            // 
            // dtpJOUR_DATE
            // 
            this.dtpJOUR_DATE.BorderColor = System.Drawing.Color.Empty;
            this.dtpJOUR_DATE.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpJOUR_DATE.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpJOUR_DATE.CustomFormat = "dd/MM/yyyy";
            this.dtpJOUR_DATE.DropDownImage = null;
            this.dtpJOUR_DATE.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dtpJOUR_DATE.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpJOUR_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.dtpJOUR_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJOUR_DATE.Location = new System.Drawing.Point(300, 103);
            this.dtpJOUR_DATE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpJOUR_DATE.MinValue = new System.DateTime(((long)(0)));
            this.dtpJOUR_DATE.Name = "dtpJOUR_DATE";
            this.dtpJOUR_DATE.NoneButtonVisible = false;
            this.dtpJOUR_DATE.ShowCheckBox = false;
            this.dtpJOUR_DATE.Size = new System.Drawing.Size(107, 23);
            this.dtpJOUR_DATE.TabIndex = 2;
            this.dtpJOUR_DATE.Value = new System.DateTime(2017, 12, 30, 17, 7, 46, 219);
            this.dtpJOUR_DATE.W_Clear = false;
            this.dtpJOUR_DATE.W_ColArName = "";
            this.dtpJOUR_DATE.W_ColEgName = "";
            this.dtpJOUR_DATE.W_OldValue = "";
            this.dtpJOUR_DATE.W_TableName = "";
            this.dtpJOUR_DATE.CheckBoxCheckedChanged += new System.EventHandler(this.dtpJOUR_DATE_CheckBoxCheckedChanged);
            this.dtpJOUR_DATE.ValueChanged += new System.EventHandler(this.dtpJOUR_DATE_ValueChanged);
            // 
            // txtJOUR_DETAILS_Header
            // 
            this.txtJOUR_DETAILS_Header.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtJOUR_DETAILS_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJOUR_DETAILS_Header.Font = new System.Drawing.Font("Arial", 10F);
            this.txtJOUR_DETAILS_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtJOUR_DETAILS_Header.Location = new System.Drawing.Point(68, 157);
            this.txtJOUR_DETAILS_Header.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJOUR_DETAILS_Header.Multiline = true;
            this.txtJOUR_DETAILS_Header.Name = "txtJOUR_DETAILS_Header";
            this.txtJOUR_DETAILS_Header.Size = new System.Drawing.Size(339, 63);
            this.txtJOUR_DETAILS_Header.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJOUR_DETAILS_Header.TabIndex = 3;
            this.txtJOUR_DETAILS_Header.W_Clear = true;
            this.txtJOUR_DETAILS_Header.W_ColArName = "";
            this.txtJOUR_DETAILS_Header.W_ColEgName = "";
            this.txtJOUR_DETAILS_Header.W_OldValue = "";
            this.txtJOUR_DETAILS_Header.W_TableName = "";
            // 
            // btnNew
            // 
            this.btnNew.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.IsBackStageButton = false;
            this.btnNew.Location = new System.Drawing.Point(685, 501);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 203;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.IsBackStageButton = false;
            this.btnUpdate.Location = new System.Drawing.Point(801, 501);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 202;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.IsBackStageButton = false;
            this.btnExit.Location = new System.Drawing.Point(974, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 201;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // btnSave
            // 
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(743, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 200;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDeptDiff
            // 
            this.txtDeptDiff.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtDeptDiff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDeptDiff.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtDeptDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptDiff.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDeptDiff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDeptDiff.Location = new System.Drawing.Point(544, 518);
            this.txtDeptDiff.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDeptDiff.Name = "txtDeptDiff";
            this.txtDeptDiff.ReadOnly = true;
            this.txtDeptDiff.Size = new System.Drawing.Size(120, 23);
            this.txtDeptDiff.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDeptDiff.TabIndex = 205;
            this.txtDeptDiff.W_Clear = true;
            this.txtDeptDiff.W_ColArName = "";
            this.txtDeptDiff.W_ColEgName = "";
            this.txtDeptDiff.W_OldValue = "";
            this.txtDeptDiff.W_TableName = "";
            // 
            // txtCreditDiff
            // 
            this.txtCreditDiff.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtCreditDiff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCreditDiff.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtCreditDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreditDiff.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCreditDiff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCreditDiff.Location = new System.Drawing.Point(428, 518);
            this.txtCreditDiff.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCreditDiff.Name = "txtCreditDiff";
            this.txtCreditDiff.ReadOnly = true;
            this.txtCreditDiff.Size = new System.Drawing.Size(116, 23);
            this.txtCreditDiff.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCreditDiff.TabIndex = 204;
            this.txtCreditDiff.W_Clear = true;
            this.txtCreditDiff.W_ColArName = "";
            this.txtCreditDiff.W_ColEgName = "";
            this.txtCreditDiff.W_OldValue = "";
            this.txtCreditDiff.W_TableName = "";
            // 
            // errCheckDetails
            // 
            this.errCheckDetails.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheckDetails.ContainerControl = this;
            this.errCheckDetails.RightToLeft = true;
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Enabled = false;
            this.txtSWID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(200, 33);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(40, 23);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 211;
            this.txtSWID.Visible = false;
            this.txtSWID.W_Clear = true;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // btnFind
            // 
            this.btnFind.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.IsBackStageButton = false;
            this.btnFind.Location = new System.Drawing.Point(170, 70);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 213;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstTempBranch
            // 
            this.lstTempBranch.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.lstTempBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTempBranch.Font = new System.Drawing.Font("Arial", 10F);
            this.lstTempBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstTempBranch.Location = new System.Drawing.Point(626, 32);
            this.lstTempBranch.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.lstTempBranch.Name = "lstTempBranch";
            this.lstTempBranch.Size = new System.Drawing.Size(14, 23);
            this.lstTempBranch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.lstTempBranch.TabIndex = 277;
            this.lstTempBranch.Visible = false;
            this.lstTempBranch.W_Clear = false;
            this.lstTempBranch.W_ColArName = "";
            this.lstTempBranch.W_ColEgName = "";
            this.lstTempBranch.W_OldValue = "";
            this.lstTempBranch.W_TableName = "";
            // 
            // btnDelete
            // 
            this.btnDelete.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.IsBackStageButton = false;
            this.btnDelete.Location = new System.Drawing.Point(916, 501);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 28);
            this.btnDelete.TabIndex = 278;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.w_Priv = ERP.myBottun.Btton_Priv.Delete_D;
            this.btnDelete.w_Type = ERP.myBottun.Btton_type.Delete;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = false;
            this.myLabel8.BackColor = System.Drawing.Color.Black;
            this.myLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(4, 63);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myLabel8.Size = new System.Drawing.Size(1034, 2);
            this.myLabel8.TabIndex = 279;
            this.myLabel8.Text = "رقم المستند الورقي ";
            // 
            // myLabel16
            // 
            this.myLabel16.AutoSize = false;
            this.myLabel16.BackColor = System.Drawing.Color.Black;
            this.myLabel16.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel16.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel16.ForeColor = System.Drawing.Color.Black;
            this.myLabel16.Location = new System.Drawing.Point(413, 65);
            this.myLabel16.Name = "myLabel16";
            this.myLabel16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myLabel16.Size = new System.Drawing.Size(2, 475);
            this.myLabel16.TabIndex = 280;
            this.myLabel16.Text = "رقم المستند الورقي ";
            // 
            // txtExchangeRateExceeded
            // 
            this.txtExchangeRateExceeded.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtExchangeRateExceeded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExchangeRateExceeded.Enabled = false;
            this.txtExchangeRateExceeded.Font = new System.Drawing.Font("Arial", 10F);
            this.txtExchangeRateExceeded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtExchangeRateExceeded.Location = new System.Drawing.Point(666, 32);
            this.txtExchangeRateExceeded.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtExchangeRateExceeded.Name = "txtExchangeRateExceeded";
            this.txtExchangeRateExceeded.Size = new System.Drawing.Size(14, 23);
            this.txtExchangeRateExceeded.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtExchangeRateExceeded.TabIndex = 303;
            this.txtExchangeRateExceeded.TabStop = false;
            this.txtExchangeRateExceeded.Visible = false;
            this.txtExchangeRateExceeded.W_Clear = false;
            this.txtExchangeRateExceeded.W_ColArName = "";
            this.txtExchangeRateExceeded.W_ColEgName = "";
            this.txtExchangeRateExceeded.W_OldValue = "";
            this.txtExchangeRateExceeded.W_TableName = "";
            // 
            // dgvJourTemp
            // 
            this.dgvJourTemp.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.dgvJourTemp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvJourTemp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJourTemp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvJourTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJourTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTempSwid,
            this.clmTempVoucherName,
            this.clmTempScheduleDate,
            this.clmTempBtnSchedual,
            this.clmT_type,
            this.clmPeriod,
            this.clmMonth,
            this.clmDay});
            this.dgvJourTemp.EnableHeadersVisualStyles = false;
            this.dgvJourTemp.Location = new System.Drawing.Point(12, 246);
            this.dgvJourTemp.Name = "dgvJourTemp";
            this.dgvJourTemp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvJourTemp.RowHeadersVisible = false;
            this.dgvJourTemp.Size = new System.Drawing.Size(395, 140);
            this.dgvJourTemp.TabIndex = 306;
            this.dgvJourTemp.W_Clear = true;
            this.dgvJourTemp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJourTemp_CellClick);
            // 
            // clmTempSwid
            // 
            this.clmTempSwid.HeaderText = "تعريف الصف";
            this.clmTempSwid.Name = "clmTempSwid";
            this.clmTempSwid.ReadOnly = true;
            this.clmTempSwid.Visible = false;
            // 
            // clmTempVoucherName
            // 
            this.clmTempVoucherName.HeaderText = "اسم القيد";
            this.clmTempVoucherName.Name = "clmTempVoucherName";
            this.clmTempVoucherName.ReadOnly = true;
            // 
            // clmTempScheduleDate
            // 
            this.clmTempScheduleDate.HeaderText = "تاريخ الجدولة";
            this.clmTempScheduleDate.Name = "clmTempScheduleDate";
            this.clmTempScheduleDate.ReadOnly = true;
            // 
            // clmTempBtnSchedual
            // 
            this.clmTempBtnSchedual.HeaderText = "جدولة";
            this.clmTempBtnSchedual.Name = "clmTempBtnSchedual";
            this.clmTempBtnSchedual.ReadOnly = true;
            this.clmTempBtnSchedual.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmTempBtnSchedual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmTempBtnSchedual.Width = 60;
            // 
            // clmT_type
            // 
            this.clmT_type.HeaderText = "النوع";
            this.clmT_type.Name = "clmT_type";
            this.clmT_type.ReadOnly = true;
            this.clmT_type.Visible = false;
            // 
            // clmPeriod
            // 
            this.clmPeriod.HeaderText = "الفترة";
            this.clmPeriod.Name = "clmPeriod";
            this.clmPeriod.ReadOnly = true;
            this.clmPeriod.Visible = false;
            // 
            // clmMonth
            // 
            this.clmMonth.HeaderText = "الشهر";
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.ReadOnly = true;
            this.clmMonth.Visible = false;
            // 
            // clmDay
            // 
            this.clmDay.HeaderText = "اليوم";
            this.clmDay.Name = "clmDay";
            this.clmDay.ReadOnly = true;
            this.clmDay.Visible = false;
            // 
            // dgvHangs
            // 
            this.dgvHangs.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.dgvHangs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHangs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHangs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmHangSwid,
            this.clmIssueId,
            this.clmHangNote});
            this.dgvHangs.EnableHeadersVisualStyles = false;
            this.dgvHangs.Location = new System.Drawing.Point(12, 412);
            this.dgvHangs.Name = "dgvHangs";
            this.dgvHangs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvHangs.RowHeadersVisible = false;
            this.dgvHangs.Size = new System.Drawing.Size(395, 125);
            this.dgvHangs.TabIndex = 307;
            this.dgvHangs.W_Clear = true;
            this.dgvHangs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangs_CellClick);
            // 
            // clmHangSwid
            // 
            this.clmHangSwid.HeaderText = "تعريف الصف";
            this.clmHangSwid.Name = "clmHangSwid";
            this.clmHangSwid.ReadOnly = true;
            this.clmHangSwid.Visible = false;
            // 
            // clmIssueId
            // 
            this.clmIssueId.HeaderText = "رقم القيد";
            this.clmIssueId.Name = "clmIssueId";
            this.clmIssueId.ReadOnly = true;
            this.clmIssueId.Width = 80;
            // 
            // clmHangNote
            // 
            this.clmHangNote.HeaderText = "بيان التعليق";
            this.clmHangNote.Name = "clmHangNote";
            this.clmHangNote.ReadOnly = true;
            this.clmHangNote.Width = 300;
            // 
            // btnAddJourTemp
            // 
            this.btnAddJourTemp.BeforeTouchSize = new System.Drawing.Size(36, 24);
            this.btnAddJourTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddJourTemp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddJourTemp.FlatAppearance.BorderSize = 0;
            this.btnAddJourTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJourTemp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddJourTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddJourTemp.Image = global::ERP.Properties.Resources.Add_h;
            this.btnAddJourTemp.IsBackStageButton = false;
            this.btnAddJourTemp.Location = new System.Drawing.Point(371, 221);
            this.btnAddJourTemp.Name = "btnAddJourTemp";
            this.btnAddJourTemp.Size = new System.Drawing.Size(36, 24);
            this.btnAddJourTemp.TabIndex = 221;
            this.btnAddJourTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddJourTemp.UseVisualStyleBackColor = true;
            this.btnAddJourTemp.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAddJourTemp.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAddJourTemp.Click += new System.EventHandler(this.btnAddJourTemp_Click);
            // 
            // myLabel19
            // 
            this.myLabel19.BackColor = System.Drawing.Color.Transparent;
            this.myLabel19.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel19.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel19.ForeColor = System.Drawing.Color.Black;
            this.myLabel19.Location = new System.Drawing.Point(285, 223);
            this.myLabel19.Name = "myLabel19";
            this.myLabel19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel19.Size = new System.Drawing.Size(89, 18);
            this.myLabel19.TabIndex = 221;
            this.myLabel19.Text = "إنشاء قالب جديد";
            // 
            // myLabel20
            // 
            this.myLabel20.BackColor = System.Drawing.Color.Transparent;
            this.myLabel20.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel20.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel20.ForeColor = System.Drawing.Color.Black;
            this.myLabel20.Location = new System.Drawing.Point(12, 227);
            this.myLabel20.Name = "myLabel20";
            this.myLabel20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel20.Size = new System.Drawing.Size(46, 18);
            this.myLabel20.TabIndex = 308;
            this.myLabel20.Text = "القوالب";
            // 
            // myLabel21
            // 
            this.myLabel21.BackColor = System.Drawing.Color.Transparent;
            this.myLabel21.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel21.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel21.ForeColor = System.Drawing.Color.Black;
            this.myLabel21.Location = new System.Drawing.Point(14, 391);
            this.myLabel21.Name = "myLabel21";
            this.myLabel21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel21.Size = new System.Drawing.Size(50, 18);
            this.myLabel21.TabIndex = 309;
            this.myLabel21.Text = "المعلقات";
            // 
            // btnPrint
            // 
            this.btnPrint.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.IsBackStageButton = false;
            this.btnPrint.Location = new System.Drawing.Point(858, 501);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(57, 28);
            this.btnPrint.TabIndex = 310;
            this.btnPrint.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnPrint.w_Type = ERP.myBottun.Btton_type.Print;
            // 
            // txtForceNote
            // 
            this.txtForceNote.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtForceNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForceNote.Font = new System.Drawing.Font("Arial", 10F);
            this.txtForceNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtForceNote.Location = new System.Drawing.Point(646, 33);
            this.txtForceNote.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtForceNote.Name = "txtForceNote";
            this.txtForceNote.Size = new System.Drawing.Size(14, 23);
            this.txtForceNote.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtForceNote.TabIndex = 311;
            this.txtForceNote.Visible = false;
            this.txtForceNote.W_Clear = false;
            this.txtForceNote.W_ColArName = "";
            this.txtForceNote.W_ColEgName = "";
            this.txtForceNote.W_OldValue = "";
            this.txtForceNote.W_TableName = "";
            // 
            // txtDistributedActivity
            // 
            this.txtDistributedActivity.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtDistributedActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistributedActivity.Enabled = false;
            this.txtDistributedActivity.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDistributedActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDistributedActivity.Location = new System.Drawing.Point(686, 32);
            this.txtDistributedActivity.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDistributedActivity.Name = "txtDistributedActivity";
            this.txtDistributedActivity.Size = new System.Drawing.Size(14, 23);
            this.txtDistributedActivity.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDistributedActivity.TabIndex = 312;
            this.txtDistributedActivity.TabStop = false;
            this.txtDistributedActivity.Visible = false;
            this.txtDistributedActivity.W_Clear = false;
            this.txtDistributedActivity.W_ColArName = "";
            this.txtDistributedActivity.W_ColEgName = "";
            this.txtDistributedActivity.W_OldValue = "";
            this.txtDistributedActivity.W_TableName = "";
            // 
            // txtExRateDateDefaultValue
            // 
            this.txtExRateDateDefaultValue.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtExRateDateDefaultValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExRateDateDefaultValue.Enabled = false;
            this.txtExRateDateDefaultValue.Font = new System.Drawing.Font("Arial", 10F);
            this.txtExRateDateDefaultValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtExRateDateDefaultValue.Location = new System.Drawing.Point(706, 32);
            this.txtExRateDateDefaultValue.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtExRateDateDefaultValue.Name = "txtExRateDateDefaultValue";
            this.txtExRateDateDefaultValue.Size = new System.Drawing.Size(14, 23);
            this.txtExRateDateDefaultValue.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtExRateDateDefaultValue.TabIndex = 313;
            this.txtExRateDateDefaultValue.TabStop = false;
            this.txtExRateDateDefaultValue.Visible = false;
            this.txtExRateDateDefaultValue.W_Clear = false;
            this.txtExRateDateDefaultValue.W_ColArName = "";
            this.txtExRateDateDefaultValue.W_ColEgName = "";
            this.txtExRateDateDefaultValue.W_OldValue = "";
            this.txtExRateDateDefaultValue.W_TableName = "";
            // 
            // txtAllowExceedNaturalAcc
            // 
            this.txtAllowExceedNaturalAcc.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtAllowExceedNaturalAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAllowExceedNaturalAcc.Enabled = false;
            this.txtAllowExceedNaturalAcc.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAllowExceedNaturalAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAllowExceedNaturalAcc.Location = new System.Drawing.Point(729, 33);
            this.txtAllowExceedNaturalAcc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAllowExceedNaturalAcc.Name = "txtAllowExceedNaturalAcc";
            this.txtAllowExceedNaturalAcc.Size = new System.Drawing.Size(14, 23);
            this.txtAllowExceedNaturalAcc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAllowExceedNaturalAcc.TabIndex = 314;
            this.txtAllowExceedNaturalAcc.TabStop = false;
            this.txtAllowExceedNaturalAcc.Visible = false;
            this.txtAllowExceedNaturalAcc.W_Clear = false;
            this.txtAllowExceedNaturalAcc.W_ColArName = "";
            this.txtAllowExceedNaturalAcc.W_ColEgName = "";
            this.txtAllowExceedNaturalAcc.W_OldValue = "";
            this.txtAllowExceedNaturalAcc.W_TableName = "";
            // 
            // txtAllowGeneralVoucher
            // 
            this.txtAllowGeneralVoucher.BeforeTouchSize = new System.Drawing.Size(297, 23);
            this.txtAllowGeneralVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAllowGeneralVoucher.Enabled = false;
            this.txtAllowGeneralVoucher.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAllowGeneralVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAllowGeneralVoucher.Location = new System.Drawing.Point(763, 33);
            this.txtAllowGeneralVoucher.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAllowGeneralVoucher.Name = "txtAllowGeneralVoucher";
            this.txtAllowGeneralVoucher.Size = new System.Drawing.Size(14, 23);
            this.txtAllowGeneralVoucher.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAllowGeneralVoucher.TabIndex = 315;
            this.txtAllowGeneralVoucher.TabStop = false;
            this.txtAllowGeneralVoucher.Visible = false;
            this.txtAllowGeneralVoucher.W_Clear = false;
            this.txtAllowGeneralVoucher.W_ColArName = "";
            this.txtAllowGeneralVoucher.W_ColEgName = "";
            this.txtAllowGeneralVoucher.W_OldValue = "";
            this.txtAllowGeneralVoucher.W_TableName = "";
            // 
            // ckbExRateDate
            // 
            this.ckbExRateDate.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.ckbExRateDate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ckbExRateDate.CheckedImage")));
            this.ckbExRateDate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.ckbExRateDate.ImageCheckBox = true;
            this.ckbExRateDate.IndeterminateImage = ((System.Drawing.Image)(resources.GetObject("ckbExRateDate.IndeterminateImage")));
            this.ckbExRateDate.Location = new System.Drawing.Point(68, 132);
            this.ckbExRateDate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.ckbExRateDate.Name = "ckbExRateDate";
            this.ckbExRateDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbExRateDate.Size = new System.Drawing.Size(150, 21);
            this.ckbExRateDate.TabIndex = 316;
            this.ckbExRateDate.Text = "سعر صرف التاريخ";
            this.ckbExRateDate.ThemesEnabled = false;
            this.ckbExRateDate.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("ckbExRateDate.UncheckedImage")));
            this.ckbExRateDate.W_Clear = false;
            this.ckbExRateDate.W_ColArName = "";
            this.ckbExRateDate.W_ColEgName = "";
            this.ckbExRateDate.W_OldValue = "";
            this.ckbExRateDate.W_TableName = "";
            this.ckbExRateDate.CheckStateChanged += new System.EventHandler(this.ckbExRateDate_CheckStateChanged);
            this.ckbExRateDate.CheckedChanged += new System.EventHandler(this.ckbExRateDate_CheckedChanged);
            // 
            // myLabel23
            // 
            this.myLabel23.BackColor = System.Drawing.Color.Transparent;
            this.myLabel23.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel23.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel23.ForeColor = System.Drawing.Color.Black;
            this.myLabel23.Location = new System.Drawing.Point(288, 389);
            this.myLabel23.Name = "myLabel23";
            this.myLabel23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel23.Size = new System.Drawing.Size(81, 18);
            this.myLabel23.TabIndex = 317;
            this.myLabel23.Text = "مراجعة التعليق";
            // 
            // btnHang
            // 
            this.btnHang.BeforeTouchSize = new System.Drawing.Size(36, 24);
            this.btnHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnHang.FlatAppearance.BorderSize = 0;
            this.btnHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnHang.Image = global::ERP.Properties.Resources.Add_h;
            this.btnHang.IsBackStageButton = false;
            this.btnHang.Location = new System.Drawing.Point(371, 387);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(36, 24);
            this.btnHang.TabIndex = 318;
            this.btnHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHang.UseVisualStyleBackColor = true;
            this.btnHang.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnHang.w_Type = ERP.myBottun.Btton_type.none;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click);
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1037, 541);
            this.Controls.Add(this.btnHang);
            this.Controls.Add(this.myLabel23);
            this.Controls.Add(this.ckbExRateDate);
            this.Controls.Add(this.txtAllowGeneralVoucher);
            this.Controls.Add(this.txtAllowExceedNaturalAcc);
            this.Controls.Add(this.txtExRateDateDefaultValue);
            this.Controls.Add(this.txtDistributedActivity);
            this.Controls.Add(this.txtForceNote);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.myLabel21);
            this.Controls.Add(this.myLabel20);
            this.Controls.Add(this.myLabel19);
            this.Controls.Add(this.btnAddJourTemp);
            this.Controls.Add(this.dgvHangs);
            this.Controls.Add(this.dgvJourTemp);
            this.Controls.Add(this.txtExchangeRateExceeded);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.myLabel16);
            this.Controls.Add(this.myLabel8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstTempBranch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.txtDeptDiff);
            this.Controls.Add(this.txtCreditDiff);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtJOUR_DETAILS_Header);
            this.Controls.Add(this.dtpJOUR_DATE);
            this.Controls.Add(this.txtIssueId);
            this.Controls.Add(this.txtDeptTotal);
            this.Controls.Add(this.txtCreditTotal);
            this.Controls.Add(this.lstBranchHeader);
            this.Controls.Add(this.myLabel9);
            this.Controls.Add(this.dgJOURNAL_DETAILS);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.txtVOCH_NO);
            this.Name = "frmJournal";
            this.PriviFile = ERP.glb_function.ProgramType.Account;
            this.Titel = "القيود اليومية";
            this.Load += new System.EventHandler(this.frmJournal_Load);
            this.Controls.SetChildIndex(this.txtVOCH_NO, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.dgJOURNAL_DETAILS, 0);
            this.Controls.SetChildIndex(this.myLabel9, 0);
            this.Controls.SetChildIndex(this.lstBranchHeader, 0);
            this.Controls.SetChildIndex(this.txtCreditTotal, 0);
            this.Controls.SetChildIndex(this.txtDeptTotal, 0);
            this.Controls.SetChildIndex(this.txtIssueId, 0);
            this.Controls.SetChildIndex(this.dtpJOUR_DATE, 0);
            this.Controls.SetChildIndex(this.txtJOUR_DETAILS_Header, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.txtCreditDiff, 0);
            this.Controls.SetChildIndex(this.txtDeptDiff, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.lstTempBranch, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.myLabel8, 0);
            this.Controls.SetChildIndex(this.myLabel16, 0);
            this.Controls.SetChildIndex(this.gbDetail, 0);
            this.Controls.SetChildIndex(this.txtExchangeRateExceeded, 0);
            this.Controls.SetChildIndex(this.dgvJourTemp, 0);
            this.Controls.SetChildIndex(this.dgvHangs, 0);
            this.Controls.SetChildIndex(this.btnAddJourTemp, 0);
            this.Controls.SetChildIndex(this.myLabel19, 0);
            this.Controls.SetChildIndex(this.myLabel20, 0);
            this.Controls.SetChildIndex(this.myLabel21, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtForceNote, 0);
            this.Controls.SetChildIndex(this.txtDistributedActivity, 0);
            this.Controls.SetChildIndex(this.txtExRateDateDefaultValue, 0);
            this.Controls.SetChildIndex(this.txtAllowExceedNaturalAcc, 0);
            this.Controls.SetChildIndex(this.txtAllowGeneralVoucher, 0);
            this.Controls.SetChildIndex(this.ckbExRateDate, 0);
            this.Controls.SetChildIndex(this.myLabel23, 0);
            this.Controls.SetChildIndex(this.btnHang, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJOURNAL_DETAILS)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbjour_valueCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCURR_PRICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailsSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSumOfAccBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostCenterId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostCenterName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbjour_valueDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJOUR_DETAILS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVOCH_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssueId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpJOUR_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJOUR_DETAILS_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheckDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTempBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRateExceeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtForceNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistributedActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExRateDateDefaultValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowExceedNaturalAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowGeneralVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbExRateDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myLabel myLabel2;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel4;
        private ERP.myLabel myLabel6;
        private ERP.myLabel myLabel5;
        private ERP.myDataGrid dgJOURNAL_DETAILS;
        private ERP.myLabel myLabel9;
        private ERP.myGroupBox gbDetail;
        private ERP.myList lstBranchHeader;
        private ERP.myList lstCurrency;
        private ERP.myLabel myLabel10;
        private ERP.myNumber  txtCreditTotal;
        private ERP.myNumber  txtDeptTotal;
        private ERP.myText txtVOCH_NO;
        private ERP.myText txtIssueId;
        private ERP.myDate dtpJOUR_DATE;
        private ERP.myText txtJOUR_DETAILS_Header;
        private ERP.myBottun btnAdd;
        private ERP.myList lstAccName;
        private ERP.myList lstAccNo;
        private ERP.myLabel myLabel13;
        private ERP.myLabel myLabel12;
        private ERP.myBottun btnNew;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnExit;
        private ERP.myBottun btnSave;
        private ERP.myText txtJOUR_DETAILS;
        private ERP.myLabel myLabel14;
        private ERP.myLabel myLabel15;
        private ERP.myNumber nmbjour_valueDept;
        private ERP.myText txtDeptDiff;
        private ERP.myText txtCreditDiff;
        private System.Windows.Forms.ErrorProvider errCheckDetails;
        private ERP.myBottun btnGetCostCenter;
        private ERP.myText txtCostCenterName;
        private ERP.myText txtCostCenterId;
        private ERP.myBottun btnClearDetails;
        private ERP.myBottun btnGetAccount;
        private ERP.myBottun btnFind;
        private ERP.myNumber nmbSumOfAccBal;
        private ERP.myText txtDetailsSWID;
        private myText lstTempBranch;
        private myLabel myLabel7;
        private myBottun btnDelete;
        private myText txtSWID;
        private myLabel myLabel16;
        private myLabel myLabel8;
        private myNumber nmbCredit;
        private myLabel myLabel18;
        private myLabel myLabel17;
        private myNumber nmbDept;
        private myNumber nmbjour_valueCredit;
        private myLabel myLabel11;
        private System.Windows.Forms.NumericUpDown nmbCURR_PRICE;
        private myText txtExchangeRateExceeded;
        private myLabel myLabel20;
        private myLabel myLabel19;
        private myBottun btnAddJourTemp;
        private myDataGrid dgvHangs;
        private myDataGrid dgvJourTemp;
        private myText txtRefNo;
        private myLabel myLabel22;
        private myLabel lblBalanceType;
        private myLabel myLabel21;
        private myBottun btnPrint;
        private myText txtForceNote;
        private myText txtAllowExceedNaturalAcc;
        private myText txtExRateDateDefaultValue;
        private myText txtDistributedActivity;
        private myText txtAllowGeneralVoucher;
        private mycheck ckbExRateDate;
        private myBottun btnHang;
        private myLabel myLabel23;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHangSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIssueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHangNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetailSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJOUR_VALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmACC_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCURR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNewCurrencyRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCOST_CENTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostCenterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJOUR_DETAILS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrentCurrencyRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMinRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOverrideValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmREFERENCE_NO;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTempSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTempVoucherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTempScheduleDate;
        private System.Windows.Forms.DataGridViewButtonColumn clmTempBtnSchedual;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmT_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
    }
}
