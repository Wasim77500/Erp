namespace ERP.Inventory
{
    partial class frmUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnits));
            this.myLabel33 = new ERP.myLabel();
            this.myLabel31 = new ERP.myLabel();
            this.myLabel29 = new ERP.myLabel();
            this.myLabel32 = new ERP.myLabel();
            this.myLabel30 = new ERP.myLabel();
            this.lstSTANDARD_UNIT_ID = new ERP.myList();
            this.txtUNIT_NAME = new ERP.myText();
            this.txtARABIC_CODE = new ERP.myText();
            this.txtEN_CODE = new ERP.myText();
            this.btnNew = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.btnAddStandardUnit = new ERP.myBottun();
            this.ckbIS_MAIN = new ERP.mycheck();
            this.btnSearch = new ERP.myBottun();
            this.txtSwid = new ERP.myText();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.nmbUNIT_VALUE = new ERP.myNumber();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUNIT_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtARABIC_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEN_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbIS_MAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUNIT_VALUE)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(187, 34);
            // 
            // myLabel33
            // 
            this.myLabel33.AutoSize = false;
            this.myLabel33.BackColor = System.Drawing.Color.Transparent;
            this.myLabel33.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel33.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel33.ForeColor = System.Drawing.Color.Black;
            this.myLabel33.Location = new System.Drawing.Point(284, 69);
            this.myLabel33.Name = "myLabel33";
            this.myLabel33.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel33.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel33.Size = new System.Drawing.Size(70, 18);
            this.myLabel33.TabIndex = 306;
            this.myLabel33.Text = "قيمة الوحدة";
            // 
            // myLabel31
            // 
            this.myLabel31.AutoSize = false;
            this.myLabel31.BackColor = System.Drawing.Color.Transparent;
            this.myLabel31.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel31.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel31.ForeColor = System.Drawing.Color.Black;
            this.myLabel31.Location = new System.Drawing.Point(12, 94);
            this.myLabel31.Name = "myLabel31";
            this.myLabel31.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel31.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel31.Size = new System.Drawing.Size(76, 18);
            this.myLabel31.TabIndex = 305;
            this.myLabel31.Text = "الكود بالعربي";
            // 
            // myLabel29
            // 
            this.myLabel29.AutoSize = false;
            this.myLabel29.BackColor = System.Drawing.Color.Transparent;
            this.myLabel29.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel29.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel29.ForeColor = System.Drawing.Color.Black;
            this.myLabel29.Location = new System.Drawing.Point(63, 36);
            this.myLabel29.Name = "myLabel29";
            this.myLabel29.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel29.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel29.Size = new System.Drawing.Size(115, 18);
            this.myLabel29.TabIndex = 304;
            this.myLabel29.Text = "اسم الوحدة القياسية";
            // 
            // myLabel32
            // 
            this.myLabel32.AutoSize = false;
            this.myLabel32.BackColor = System.Drawing.Color.Transparent;
            this.myLabel32.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel32.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel32.ForeColor = System.Drawing.Color.Black;
            this.myLabel32.Location = new System.Drawing.Point(268, 98);
            this.myLabel32.Name = "myLabel32";
            this.myLabel32.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel32.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel32.Size = new System.Drawing.Size(88, 18);
            this.myLabel32.TabIndex = 308;
            this.myLabel32.Text = "الكود بالانجليزي";
            // 
            // myLabel30
            // 
            this.myLabel30.AutoSize = false;
            this.myLabel30.BackColor = System.Drawing.Color.Transparent;
            this.myLabel30.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel30.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel30.ForeColor = System.Drawing.Color.Black;
            this.myLabel30.Location = new System.Drawing.Point(12, 67);
            this.myLabel30.Name = "myLabel30";
            this.myLabel30.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel30.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel30.Size = new System.Drawing.Size(76, 18);
            this.myLabel30.TabIndex = 307;
            this.myLabel30.Text = "اسم الوحدة";
            // 
            // lstSTANDARD_UNIT_ID
            // 
            this.lstSTANDARD_UNIT_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstSTANDARD_UNIT_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstSTANDARD_UNIT_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstSTANDARD_UNIT_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstSTANDARD_UNIT_ID.FormattingEnabled = true;
            this.lstSTANDARD_UNIT_ID.Location = new System.Drawing.Point(184, 34);
            this.lstSTANDARD_UNIT_ID.Name = "lstSTANDARD_UNIT_ID";
            this.lstSTANDARD_UNIT_ID.Size = new System.Drawing.Size(170, 24);
            this.lstSTANDARD_UNIT_ID.TabIndex = 309;
            this.lstSTANDARD_UNIT_ID.W_Clear = true;
            this.lstSTANDARD_UNIT_ID.W_ColArName = "رقم الوحدة القياسية";
            this.lstSTANDARD_UNIT_ID.W_ColEgName = "STANDARD_UNIT_ID";
            this.lstSTANDARD_UNIT_ID.W_OldValue = "";
            this.lstSTANDARD_UNIT_ID.W_TableName = "UNITS";
            this.lstSTANDARD_UNIT_ID.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // txtUNIT_NAME
            // 
            this.txtUNIT_NAME.BeforeTouchSize = new System.Drawing.Size(147, 23);
            this.txtUNIT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUNIT_NAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtUNIT_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtUNIT_NAME.Location = new System.Drawing.Point(91, 64);
            this.txtUNIT_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUNIT_NAME.Name = "txtUNIT_NAME";
            this.txtUNIT_NAME.Size = new System.Drawing.Size(147, 23);
            this.txtUNIT_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtUNIT_NAME.TabIndex = 311;
            this.txtUNIT_NAME.W_Clear = true;
            this.txtUNIT_NAME.W_ColArName = "اسم الوحدة";
            this.txtUNIT_NAME.W_ColEgName = "UNIT_NAME";
            this.txtUNIT_NAME.W_OldValue = "";
            this.txtUNIT_NAME.W_TableName = "UNITS";
            // 
            // txtARABIC_CODE
            // 
            this.txtARABIC_CODE.BeforeTouchSize = new System.Drawing.Size(147, 23);
            this.txtARABIC_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtARABIC_CODE.Font = new System.Drawing.Font("Arial", 10F);
            this.txtARABIC_CODE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtARABIC_CODE.Location = new System.Drawing.Point(91, 93);
            this.txtARABIC_CODE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtARABIC_CODE.Name = "txtARABIC_CODE";
            this.txtARABIC_CODE.Size = new System.Drawing.Size(147, 23);
            this.txtARABIC_CODE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtARABIC_CODE.TabIndex = 312;
            this.txtARABIC_CODE.W_Clear = true;
            this.txtARABIC_CODE.W_ColArName = "الكود بالعربي";
            this.txtARABIC_CODE.W_ColEgName = "ARABIC_CODE";
            this.txtARABIC_CODE.W_OldValue = "";
            this.txtARABIC_CODE.W_TableName = "UNITS";
            // 
            // txtEN_CODE
            // 
            this.txtEN_CODE.BeforeTouchSize = new System.Drawing.Size(147, 23);
            this.txtEN_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEN_CODE.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEN_CODE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtEN_CODE.Location = new System.Drawing.Point(363, 93);
            this.txtEN_CODE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEN_CODE.Name = "txtEN_CODE";
            this.txtEN_CODE.Size = new System.Drawing.Size(147, 23);
            this.txtEN_CODE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEN_CODE.TabIndex = 314;
            this.txtEN_CODE.W_Clear = true;
            this.txtEN_CODE.W_ColArName = "الكود بالانجليزي";
            this.txtEN_CODE.W_ColEgName = "EN_CODE";
            this.txtEN_CODE.W_OldValue = "";
            this.txtEN_CODE.W_TableName = "UNITS";
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
            this.btnNew.Location = new System.Drawing.Point(119, 149);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 318;
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
            this.btnUpdate.Location = new System.Drawing.Point(279, 148);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 317;
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
            this.btnExit.Location = new System.Drawing.Point(337, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 316;
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
            this.btnSave.Location = new System.Drawing.Point(221, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 315;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddStandardUnit
            // 
            this.btnAddStandardUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStandardUnit.BackgroundImage")));
            this.btnAddStandardUnit.BeforeTouchSize = new System.Drawing.Size(36, 25);
            this.btnAddStandardUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStandardUnit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddStandardUnit.FlatAppearance.BorderSize = 0;
            this.btnAddStandardUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStandardUnit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddStandardUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddStandardUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStandardUnit.Image")));
            this.btnAddStandardUnit.IsBackStageButton = false;
            this.btnAddStandardUnit.Location = new System.Drawing.Point(351, 33);
            this.btnAddStandardUnit.Name = "btnAddStandardUnit";
            this.btnAddStandardUnit.Size = new System.Drawing.Size(36, 25);
            this.btnAddStandardUnit.TabIndex = 319;
            this.btnAddStandardUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStandardUnit.UseVisualStyleBackColor = true;
            this.btnAddStandardUnit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAddStandardUnit.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAddStandardUnit.Click += new System.EventHandler(this.btnAddStandardUnit_Click);
            // 
            // ckbIS_MAIN
            // 
            this.ckbIS_MAIN.BeforeTouchSize = new System.Drawing.Size(147, 21);
            this.ckbIS_MAIN.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ckbIS_MAIN.CheckedImage")));
            this.ckbIS_MAIN.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.ckbIS_MAIN.ImageCheckBox = true;
            this.ckbIS_MAIN.IndeterminateImage = ((System.Drawing.Image)(resources.GetObject("ckbIS_MAIN.IndeterminateImage")));
            this.ckbIS_MAIN.Location = new System.Drawing.Point(91, 122);
            this.ckbIS_MAIN.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.ckbIS_MAIN.Name = "ckbIS_MAIN";
            this.ckbIS_MAIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbIS_MAIN.Size = new System.Drawing.Size(147, 21);
            this.ckbIS_MAIN.TabIndex = 320;
            this.ckbIS_MAIN.Text = "الوحدة الرئيسية";
            this.ckbIS_MAIN.ThemesEnabled = false;
            this.ckbIS_MAIN.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("ckbIS_MAIN.UncheckedImage")));
            this.ckbIS_MAIN.W_Clear = true;
            this.ckbIS_MAIN.W_ColArName = "هل هي وحدة رئيسية";
            this.ckbIS_MAIN.W_ColEgName = "IS_MAIN";
            this.ckbIS_MAIN.W_OldValue = "";
            this.ckbIS_MAIN.W_TableName = "UNITS";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.IsBackStageButton = false;
            this.btnSearch.Location = new System.Drawing.Point(240, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 321;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            // 
            // txtSwid
            // 
            this.txtSwid.BeforeTouchSize = new System.Drawing.Size(147, 23);
            this.txtSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSwid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSwid.Location = new System.Drawing.Point(430, 132);
            this.txtSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSwid.Name = "txtSwid";
            this.txtSwid.Size = new System.Drawing.Size(68, 23);
            this.txtSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSwid.TabIndex = 322;
            this.txtSwid.Visible = false;
            this.txtSwid.W_Clear = true;
            this.txtSwid.W_ColArName = "";
            this.txtSwid.W_ColEgName = "";
            this.txtSwid.W_OldValue = "";
            this.txtSwid.W_TableName = "";
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // nmbUNIT_VALUE
            // 
            this.nmbUNIT_VALUE.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbUNIT_VALUE.BeforeTouchSize = new System.Drawing.Size(147, 23);
            this.nmbUNIT_VALUE.DecimalPlaces = 3;
            this.nmbUNIT_VALUE.DoubleValue = 0D;
            this.nmbUNIT_VALUE.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbUNIT_VALUE.Location = new System.Drawing.Point(363, 61);
            this.nmbUNIT_VALUE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbUNIT_VALUE.MinValue = 0D;
            this.nmbUNIT_VALUE.Name = "nmbUNIT_VALUE";
            this.nmbUNIT_VALUE.NullString = "";
            this.nmbUNIT_VALUE.NumberDecimalDigits = 3;
            this.nmbUNIT_VALUE.Size = new System.Drawing.Size(147, 23);
            this.nmbUNIT_VALUE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbUNIT_VALUE.TabIndex = 323;
            this.nmbUNIT_VALUE.Text = "0.000";
            this.nmbUNIT_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbUNIT_VALUE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbUNIT_VALUE.W_Clear = true;
            this.nmbUNIT_VALUE.W_ColArName = "قيمة الوحدة";
            this.nmbUNIT_VALUE.W_ColEgName = "UNIT_VALUE";
            this.nmbUNIT_VALUE.W_OldValue = "";
            this.nmbUNIT_VALUE.W_TableName = "UNITS";
            // 
            // frmUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(542, 188);
            this.Controls.Add(this.nmbUNIT_VALUE);
            this.Controls.Add(this.txtSwid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ckbIS_MAIN);
            this.Controls.Add(this.btnAddStandardUnit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEN_CODE);
            this.Controls.Add(this.txtARABIC_CODE);
            this.Controls.Add(this.txtUNIT_NAME);
            this.Controls.Add(this.lstSTANDARD_UNIT_ID);
            this.Controls.Add(this.myLabel32);
            this.Controls.Add(this.myLabel30);
            this.Controls.Add(this.myLabel33);
            this.Controls.Add(this.myLabel31);
            this.Controls.Add(this.myLabel29);
            this.Name = "frmUnits";
            this.Titel = "إنشاء وتعريف الوحدات";
            this.Load += new System.EventHandler(this.frmUnits_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel29, 0);
            this.Controls.SetChildIndex(this.myLabel31, 0);
            this.Controls.SetChildIndex(this.myLabel33, 0);
            this.Controls.SetChildIndex(this.myLabel30, 0);
            this.Controls.SetChildIndex(this.myLabel32, 0);
            this.Controls.SetChildIndex(this.lstSTANDARD_UNIT_ID, 0);
            this.Controls.SetChildIndex(this.txtUNIT_NAME, 0);
            this.Controls.SetChildIndex(this.txtARABIC_CODE, 0);
            this.Controls.SetChildIndex(this.txtEN_CODE, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnAddStandardUnit, 0);
            this.Controls.SetChildIndex(this.ckbIS_MAIN, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.txtSwid, 0);
            this.Controls.SetChildIndex(this.nmbUNIT_VALUE, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUNIT_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtARABIC_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEN_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbIS_MAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUNIT_VALUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myLabel myLabel33;
        private ERP.myLabel myLabel31;
        private ERP.myLabel myLabel29;
        private ERP.myLabel myLabel32;
        private ERP.myLabel myLabel30;
        private ERP.myList lstSTANDARD_UNIT_ID;
        private ERP.myText txtUNIT_NAME;
        private ERP.myText txtARABIC_CODE;
        private ERP.myText txtEN_CODE;
        private ERP.myBottun btnNew;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnExit;
        private ERP.myBottun btnSave;
        private ERP.myBottun btnAddStandardUnit;
        private ERP.mycheck ckbIS_MAIN;
        private ERP.myBottun btnSearch;
        private ERP.myText txtSwid;
        private System.Windows.Forms.ErrorProvider errCheck;
        private ERP.myNumber nmbUNIT_VALUE;
    }
}
