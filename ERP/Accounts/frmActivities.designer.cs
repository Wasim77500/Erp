

namespace ERP.Accounts
{
    partial class frmActivities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivities));
            this.btnNew = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.btnSearch = new ERP.myBottun();
            this.txtACT_TEL = new ERP.myText();
            this.txtACT_USER = new ERP.myText();
            this.myLabel7 = new ERP.myLabel();
            this.txtACT_NAME = new ERP.myText();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.lstACT_TYPE = new ERP.myList();
            this.dtpACT_STARTED_DATE = new ERP.myDate();
            this.lblnoteact = new ERP.myLabel();
            this.txtACT_INF = new ERP.myText();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSWID = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACT_TEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACT_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACT_NAME)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.lstACT_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpACT_STARTED_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACT_INF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
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
            this.btnNew.Location = new System.Drawing.Point(31, 198);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 222;
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
            this.btnUpdate.Location = new System.Drawing.Point(169, 211);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 221;
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
            this.btnExit.Location = new System.Drawing.Point(227, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 220;
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
            this.btnSave.Location = new System.Drawing.Point(111, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 219;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(324, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 218;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtACT_TEL
            // 
            this.txtACT_TEL.BeforeTouchSize = new System.Drawing.Size(188, 23);
            this.txtACT_TEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACT_TEL.Font = new System.Drawing.Font("Arial", 10F);
            this.txtACT_TEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACT_TEL.Location = new System.Drawing.Point(133, 145);
            this.txtACT_TEL.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACT_TEL.Name = "txtACT_TEL";
            this.txtACT_TEL.Size = new System.Drawing.Size(221, 23);
            this.txtACT_TEL.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACT_TEL.TabIndex = 214;
            this.txtACT_TEL.W_ColArName = "رقم التلفون";
            this.txtACT_TEL.W_ColEgName = "ACT_TEL";
            this.txtACT_TEL.W_OldValue = "";
            this.txtACT_TEL.W_TableName = "ACTIVITIES";
            // 
            // txtACT_USER
            // 
            this.txtACT_USER.BeforeTouchSize = new System.Drawing.Size(188, 23);
            this.txtACT_USER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACT_USER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtACT_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACT_USER.Location = new System.Drawing.Point(133, 117);
            this.txtACT_USER.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACT_USER.Name = "txtACT_USER";
            this.txtACT_USER.Size = new System.Drawing.Size(221, 23);
            this.txtACT_USER.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACT_USER.TabIndex = 212;
            this.txtACT_USER.W_ColArName = "مسؤول النشاط";
            this.txtACT_USER.W_ColEgName = "ACT_USER";
            this.txtACT_USER.W_OldValue = "";
            this.txtACT_USER.W_TableName = "ACTIVITIES";
            // 
            // myLabel7
            // 
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(43, 122);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(81, 18);
            this.myLabel7.TabIndex = 207;
            this.myLabel7.Text = "مسؤول النشاط";
            // 
            // txtACT_NAME
            // 
            this.txtACT_NAME.BeforeTouchSize = new System.Drawing.Size(188, 23);
            this.txtACT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACT_NAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtACT_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACT_NAME.Location = new System.Drawing.Point(133, 33);
            this.txtACT_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACT_NAME.Name = "txtACT_NAME";
            this.txtACT_NAME.Size = new System.Drawing.Size(173, 23);
            this.txtACT_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACT_NAME.TabIndex = 206;
            this.txtACT_NAME.W_ColArName = "اسم النشاط";
            this.txtACT_NAME.W_ColEgName = "ACT_NAME";
            this.txtACT_NAME.W_OldValue = "";
            this.txtACT_NAME.W_TableName = "ACTIVITIES";
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(31, 70);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(64, 18);
            this.myLabel6.TabIndex = 205;
            this.myLabel6.Text = "نوع النشاط";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(35, 41);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(63, 18);
            this.myLabel5.TabIndex = 204;
            this.myLabel5.Text = "اسم النشاط";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(29, 94);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(98, 18);
            this.myLabel3.TabIndex = 202;
            this.myLabel3.Text = "تاريخ بداية النشاط";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(56, 149);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(62, 18);
            this.myLabel2.TabIndex = 201;
            this.myLabel2.Text = "رقم الهاتف";
            // 
            // lstACT_TYPE
            // 
            
            this.lstACT_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstACT_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstACT_TYPE.Location = new System.Drawing.Point(133, 62);
            this.lstACT_TYPE.Name = "lstACT_TYPE";
            this.lstACT_TYPE.Size = new System.Drawing.Size(221, 24);
            this.lstACT_TYPE.TabIndex = 223;
            this.lstACT_TYPE.W_ColArName = "نوع النشاط";
            this.lstACT_TYPE.W_ColEgName = "ACT_TYPE";
            this.lstACT_TYPE.W_OldValue = "";
            this.lstACT_TYPE.W_TableName = "ACTIVITIES";
            this.lstACT_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // dtpACT_STARTED_DATE
            // 
            this.dtpACT_STARTED_DATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpACT_STARTED_DATE.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpACT_STARTED_DATE.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpACT_STARTED_DATE.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpACT_STARTED_DATE.CustomFormat = "dd/MM/yyyy";
            this.dtpACT_STARTED_DATE.DropDownImage = null;
            this.dtpACT_STARTED_DATE.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpACT_STARTED_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.dtpACT_STARTED_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpACT_STARTED_DATE.Location = new System.Drawing.Point(133, 90);
            this.dtpACT_STARTED_DATE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpACT_STARTED_DATE.MinValue = new System.DateTime(((long)(0)));
            this.dtpACT_STARTED_DATE.Name = "dtpACT_STARTED_DATE";
            this.dtpACT_STARTED_DATE.NoneButtonVisible = false;
            this.dtpACT_STARTED_DATE.ShowCheckBox = false;
            this.dtpACT_STARTED_DATE.Size = new System.Drawing.Size(221, 23);
            this.dtpACT_STARTED_DATE.TabIndex = 224;
            this.dtpACT_STARTED_DATE.Value = new System.DateTime(2017, 9, 11, 17, 24, 2, 208);
            this.dtpACT_STARTED_DATE.W_ColArName = "تاريخ بداية النشاط";
            this.dtpACT_STARTED_DATE.W_ColEgName = "ACT_STARTED_DATE";
            this.dtpACT_STARTED_DATE.W_OldValue = "";
            this.dtpACT_STARTED_DATE.W_TableName = "ACTIVITIES";
            // 
            // lblnoteact
            // 
            this.lblnoteact.BackColor = System.Drawing.Color.Transparent;
            this.lblnoteact.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblnoteact.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblnoteact.ForeColor = System.Drawing.Color.Black;
            this.lblnoteact.Location = new System.Drawing.Point(39, 177);
            this.lblnoteact.Name = "lblnoteact";
            this.lblnoteact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblnoteact.Size = new System.Drawing.Size(87, 18);
            this.lblnoteact.TabIndex = 203;
            this.lblnoteact.Text = "معلومات النشاط";
            // 
            // txtACT_INF
            // 
            this.txtACT_INF.BeforeTouchSize = new System.Drawing.Size(188, 23);
            this.txtACT_INF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACT_INF.Font = new System.Drawing.Font("Arial", 10F);
            this.txtACT_INF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACT_INF.Location = new System.Drawing.Point(133, 172);
            this.txtACT_INF.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACT_INF.Name = "txtACT_INF";
            this.txtACT_INF.Size = new System.Drawing.Size(221, 23);
            this.txtACT_INF.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACT_INF.TabIndex = 213;
            this.txtACT_INF.W_ColArName = "معلومات النشاط";
            this.txtACT_INF.W_ColEgName = "ACT_INF";
            this.txtACT_INF.W_OldValue = "";
            this.txtACT_INF.W_TableName = "ACTIVITIES";
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(188, 23);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(322, 211);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(30, 23);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 225;
            this.txtSWID.Visible = false;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // frmActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(379, 252);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.dtpACT_STARTED_DATE);
            this.Controls.Add(this.lstACT_TYPE);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtACT_TEL);
            this.Controls.Add(this.txtACT_INF);
            this.Controls.Add(this.txtACT_USER);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.txtACT_NAME);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.lblnoteact);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Name = "frmActivities";
            this.PriviFile = glb_function.ProgramType.Account;
            this.Titel = "الأنشطة";
            this.Load += new System.EventHandler(this.frmActivities_Load);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.lblnoteact, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.txtACT_NAME, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.txtACT_USER, 0);
            this.Controls.SetChildIndex(this.txtACT_INF, 0);
            this.Controls.SetChildIndex(this.txtACT_TEL, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.lstACT_TYPE, 0);
            this.Controls.SetChildIndex(this.dtpACT_STARTED_DATE, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACT_TEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACT_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACT_NAME)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.lstACT_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpACT_STARTED_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACT_INF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ERP.myBottun btnNew;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnExit;
        private ERP.myBottun btnSave;
        private ERP.myBottun btnSearch;
        private ERP.myText txtACT_TEL;
        private ERP.myText txtACT_USER;
        private ERP.myLabel myLabel7;
        private ERP.myText txtACT_NAME;
        private ERP.myLabel myLabel6;
        private ERP.myLabel myLabel5;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel2;
        private ERP.myList lstACT_TYPE;
        private ERP.myDate dtpACT_STARTED_DATE;
        private ERP.myLabel lblnoteact;
        private ERP.myText txtACT_INF;
        private System.Windows.Forms.ErrorProvider errCheck;
        private ERP.myText txtSWID;
    }
}
