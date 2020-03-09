namespace ERP.Inventory
{
    partial class frmServiceCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceCenter));
            this.myLabel2 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.myLabel6 = new ERP.myLabel();
            this.txtSC_NAME = new ERP.myText();
            this.txtCOST_CENTER = new ERP.myText();
            this.lstSC_LOCTION = new ERP.myList();
            this.lstBRANCH_ID = new ERP.myList();
            this.lstSC_TYPE = new ERP.myList();
            this.btnGetCostCenter = new ERP.myBottun();
            this.txtCOST_CENTER_ID = new ERP.myText();
            this.txtSWID = new ERP.myText();
            this.btnSelect = new ERP.myBottun();
            this.btnNew = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.lstTempBranch = new ERP.myText();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSC_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOST_CENTER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOST_CENTER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTempBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(200, 34);
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(12, 37);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(90, 18);
            this.myLabel2.TabIndex = 214;
            this.myLabel2.Text = "اسم مركز الخدمة";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(297, 37);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(91, 18);
            this.myLabel3.TabIndex = 215;
            this.myLabel3.Text = "نوع مركز الخدمة";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(40, 66);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(35, 18);
            this.myLabel4.TabIndex = 216;
            this.myLabel4.Text = "الفرع";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(329, 66);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(41, 18);
            this.myLabel5.TabIndex = 217;
            this.myLabel5.Text = "الموقع";
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(23, 102);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(67, 18);
            this.myLabel6.TabIndex = 218;
            this.myLabel6.Text = "مركز التكلفة";
            // 
            // txtSC_NAME
            // 
            this.txtSC_NAME.BeforeTouchSize = new System.Drawing.Size(70, 23);
            this.txtSC_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSC_NAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSC_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSC_NAME.Location = new System.Drawing.Point(110, 35);
            this.txtSC_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSC_NAME.Name = "txtSC_NAME";
            this.txtSC_NAME.Size = new System.Drawing.Size(147, 23);
            this.txtSC_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSC_NAME.TabIndex = 272;
            this.txtSC_NAME.W_Clear = true;
            this.txtSC_NAME.W_ColArName = "اسم مركز الخدمة";
            this.txtSC_NAME.W_ColEgName = "SC_NAME";
            this.txtSC_NAME.W_OldValue = "";
            this.txtSC_NAME.W_TableName = "SERVICE_CENTER";
            // 
            // txtCOST_CENTER
            // 
            this.txtCOST_CENTER.BeforeTouchSize = new System.Drawing.Size(70, 23);
            this.txtCOST_CENTER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCOST_CENTER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCOST_CENTER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCOST_CENTER.Location = new System.Drawing.Point(110, 99);
            this.txtCOST_CENTER.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCOST_CENTER.Name = "txtCOST_CENTER";
            this.txtCOST_CENTER.Size = new System.Drawing.Size(147, 23);
            this.txtCOST_CENTER.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCOST_CENTER.TabIndex = 273;
            this.txtCOST_CENTER.W_Clear = true;
            this.txtCOST_CENTER.W_ColArName = "";
            this.txtCOST_CENTER.W_ColEgName = "";
            this.txtCOST_CENTER.W_OldValue = "";
            this.txtCOST_CENTER.W_TableName = "";
            // 
            // lstSC_LOCTION
            // 
            this.lstSC_LOCTION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstSC_LOCTION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstSC_LOCTION.Font = new System.Drawing.Font("Arial", 10F);
            this.lstSC_LOCTION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstSC_LOCTION.FormattingEnabled = true;
            this.lstSC_LOCTION.Location = new System.Drawing.Point(408, 66);
            this.lstSC_LOCTION.Name = "lstSC_LOCTION";
            this.lstSC_LOCTION.Size = new System.Drawing.Size(150, 24);
            this.lstSC_LOCTION.TabIndex = 274;
            this.lstSC_LOCTION.W_Clear = true;
            this.lstSC_LOCTION.W_ColArName = "موقع المركز";
            this.lstSC_LOCTION.W_ColEgName = "SC_LOCTION";
            this.lstSC_LOCTION.W_OldValue = "";
            this.lstSC_LOCTION.W_TableName = "SERVICE_CENTER";
            this.lstSC_LOCTION.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // lstBRANCH_ID
            // 
            this.lstBRANCH_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBRANCH_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBRANCH_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBRANCH_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstBRANCH_ID.FormattingEnabled = true;
            this.lstBRANCH_ID.Location = new System.Drawing.Point(110, 66);
            this.lstBRANCH_ID.Name = "lstBRANCH_ID";
            this.lstBRANCH_ID.Size = new System.Drawing.Size(181, 24);
            this.lstBRANCH_ID.TabIndex = 275;
            this.lstBRANCH_ID.W_Clear = true;
            this.lstBRANCH_ID.W_ColArName = "الفرع";
            this.lstBRANCH_ID.W_ColEgName = "BRANCH_ID";
            this.lstBRANCH_ID.W_OldValue = "";
            this.lstBRANCH_ID.W_TableName = "SERVICE_CENTER";
            this.lstBRANCH_ID.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // lstSC_TYPE
            // 
            this.lstSC_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstSC_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstSC_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstSC_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstSC_TYPE.FormattingEnabled = true;
            this.lstSC_TYPE.Location = new System.Drawing.Point(408, 35);
            this.lstSC_TYPE.Name = "lstSC_TYPE";
            this.lstSC_TYPE.Size = new System.Drawing.Size(150, 24);
            this.lstSC_TYPE.TabIndex = 276;
            this.lstSC_TYPE.W_Clear = true;
            this.lstSC_TYPE.W_ColArName = "نوع مركز الخدمة";
            this.lstSC_TYPE.W_ColEgName = "SC_TYPE";
            this.lstSC_TYPE.W_OldValue = "";
            this.lstSC_TYPE.W_TableName = "SERVICE_CENTER";
            this.lstSC_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // btnGetCostCenter
            // 
            this.btnGetCostCenter.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetCostCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetCostCenter.FlatAppearance.BorderSize = 0;
            this.btnGetCostCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCostCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnGetCostCenter.Image")));
            this.btnGetCostCenter.IsBackStageButton = false;
            this.btnGetCostCenter.Location = new System.Drawing.Point(263, 96);
            this.btnGetCostCenter.Name = "btnGetCostCenter";
            this.btnGetCostCenter.Size = new System.Drawing.Size(28, 27);
            this.btnGetCostCenter.TabIndex = 277;
            this.btnGetCostCenter.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnGetCostCenter.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetCostCenter.Click += new System.EventHandler(this.btnGetCostCenter_Click);
            // 
            // txtCOST_CENTER_ID
            // 
            this.txtCOST_CENTER_ID.BeforeTouchSize = new System.Drawing.Size(70, 23);
            this.txtCOST_CENTER_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCOST_CENTER_ID.Enabled = false;
            this.txtCOST_CENTER_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCOST_CENTER_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCOST_CENTER_ID.Location = new System.Drawing.Point(297, 102);
            this.txtCOST_CENTER_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCOST_CENTER_ID.Name = "txtCOST_CENTER_ID";
            this.txtCOST_CENTER_ID.Size = new System.Drawing.Size(40, 23);
            this.txtCOST_CENTER_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCOST_CENTER_ID.TabIndex = 278;
            this.txtCOST_CENTER_ID.Visible = false;
            this.txtCOST_CENTER_ID.W_Clear = true;
            this.txtCOST_CENTER_ID.W_ColArName = "مركز التكلفة";
            this.txtCOST_CENTER_ID.W_ColEgName = "COST_CENTER_ID";
            this.txtCOST_CENTER_ID.W_OldValue = "";
            this.txtCOST_CENTER_ID.W_TableName = "SERVICE_CENTER";
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(70, 23);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Enabled = false;
            this.txtSWID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(0, 32);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(40, 23);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 279;
            this.txtSWID.Visible = false;
            this.txtSWID.W_Clear = true;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // btnSelect
            // 
            this.btnSelect.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.IsBackStageButton = false;
            this.btnSelect.Location = new System.Drawing.Point(263, 33);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(28, 27);
            this.btnSelect.TabIndex = 280;
            this.btnSelect.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnSelect.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
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
            this.btnNew.Location = new System.Drawing.Point(417, 131);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 284;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(256, 131);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 283;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnExit.Location = new System.Drawing.Point(313, 131);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 282;
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
            this.btnSave.Location = new System.Drawing.Point(199, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 281;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstTempBranch
            // 
            this.lstTempBranch.BeforeTouchSize = new System.Drawing.Size(70, 23);
            this.lstTempBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTempBranch.Font = new System.Drawing.Font("Arial", 10F);
            this.lstTempBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstTempBranch.Location = new System.Drawing.Point(5, 139);
            this.lstTempBranch.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.lstTempBranch.Name = "lstTempBranch";
            this.lstTempBranch.Size = new System.Drawing.Size(70, 23);
            this.lstTempBranch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.lstTempBranch.TabIndex = 285;
            this.lstTempBranch.Visible = false;
            this.lstTempBranch.W_Clear = false;
            this.lstTempBranch.W_ColArName = "";
            this.lstTempBranch.W_ColEgName = "";
            this.lstTempBranch.W_OldValue = "";
            this.lstTempBranch.W_TableName = "";
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // frmServiceCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(569, 174);
            this.Controls.Add(this.lstTempBranch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.txtCOST_CENTER_ID);
            this.Controls.Add(this.btnGetCostCenter);
            this.Controls.Add(this.lstSC_TYPE);
            this.Controls.Add(this.lstBRANCH_ID);
            this.Controls.Add(this.lstSC_LOCTION);
            this.Controls.Add(this.txtCOST_CENTER);
            this.Controls.Add(this.txtSC_NAME);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Name = "frmServiceCenter";
            this.Titel = "تعريف مراكز الخدمات";
            this.Load += new System.EventHandler(this.frmServiceCenter_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.txtSC_NAME, 0);
            this.Controls.SetChildIndex(this.txtCOST_CENTER, 0);
            this.Controls.SetChildIndex(this.lstSC_LOCTION, 0);
            this.Controls.SetChildIndex(this.lstBRANCH_ID, 0);
            this.Controls.SetChildIndex(this.lstSC_TYPE, 0);
            this.Controls.SetChildIndex(this.btnGetCostCenter, 0);
            this.Controls.SetChildIndex(this.txtCOST_CENTER_ID, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.btnSelect, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.lstTempBranch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSC_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOST_CENTER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOST_CENTER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTempBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myLabel myLabel2;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel4;
        private ERP.myLabel myLabel5;
        private ERP.myLabel myLabel6;
        private ERP.myText txtSC_NAME;
        private ERP.myText txtCOST_CENTER;
        private ERP.myList lstSC_LOCTION;
        private ERP.myList lstBRANCH_ID;
        private ERP.myList lstSC_TYPE;
        private ERP.myBottun btnGetCostCenter;
        private ERP.myText txtCOST_CENTER_ID;
        private ERP.myText txtSWID;
        private ERP.myBottun btnSelect;
        private ERP.myBottun btnNew;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnExit;
        private ERP.myBottun btnSave;
        private ERP.myText lstTempBranch;
        private System.Windows.Forms.ErrorProvider errCheck;
    }
}
