

namespace ERP.File
{
    partial class frmContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacts));
            this.myLabel2 = new ERP.myLabel();
            this.myLabel4 = new ERP.myLabel();
            this.dgCotactData = new ERP.myDataGrid();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lstCONT_TITLE = new ERP.myList();
            this.txtCONT_VALUE = new ERP.myText();
            this.btnAddPhone = new ERP.myBottun();
            this.txtADB_NAME = new ERP.myText();
            this.txtSWID = new ERP.myText();
            this.lstADB_LOCATION = new ERP.myList();
            this.lstADB_DESCRIBE = new ERP.myList();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.lstCONT_TYPE = new ERP.myList();
            this.btnSearch = new ERP.myBottun();
            this.myLabel3 = new ERP.myLabel();
            this.lstJOB = new ERP.myList();
            this.btnNew = new ERP.myBottun();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCotactData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONT_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtADB_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(131, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(44, 34);
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(12, 35);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(71, 18);
            this.myLabel2.TabIndex = 2;
            this.myLabel2.Text = "اسم الشخص";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(222, 61);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(41, 18);
            this.myLabel4.TabIndex = 4;
            this.myLabel4.Text = "الموقع";
            // 
            // dgCotactData
            // 
            this.dgCotactData.AllowUserToAddRows = false;
            this.dgCotactData.AllowUserToDeleteRows = false;
            this.dgCotactData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgCotactData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCotactData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCotactData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCotactData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCotactData.ColumnHeadersVisible = false;
            this.dgCotactData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.CONT_TYPE,
            this.Column2,
            this.Column5,
            this.Column3});
            this.dgCotactData.EnableHeadersVisualStyles = false;
            this.dgCotactData.Location = new System.Drawing.Point(12, 113);
            this.dgCotactData.Name = "dgCotactData";
            this.dgCotactData.ReadOnly = true;
            this.dgCotactData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCotactData.RowHeadersVisible = false;
            this.dgCotactData.Size = new System.Drawing.Size(411, 154);
            this.dgCotactData.TabIndex = 5;
            this.dgCotactData.W_Clear = true;
            this.dgCotactData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCotactData_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "swid";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // CONT_TYPE
            // 
            this.CONT_TYPE.HeaderText = "CONT_TYPE";
            this.CONT_TYPE.Name = "CONT_TYPE";
            this.CONT_TYPE.ReadOnly = true;
            this.CONT_TYPE.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CONT_TITLE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CONT_VALUE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Image = global::ERP.Properties.Resources.S43Qy;
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // lstCONT_TITLE
            // 
            this.lstCONT_TITLE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCONT_TITLE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCONT_TITLE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCONT_TITLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCONT_TITLE.FormattingEnabled = true;
            this.lstCONT_TITLE.Location = new System.Drawing.Point(129, 86);
            this.lstCONT_TITLE.Name = "lstCONT_TITLE";
            this.lstCONT_TITLE.Size = new System.Drawing.Size(50, 24);
            this.lstCONT_TITLE.TabIndex = 6;
            this.lstCONT_TITLE.W_Clear = true;
            this.lstCONT_TITLE.W_ColArName = "";
            this.lstCONT_TITLE.W_ColEgName = "";
            this.lstCONT_TITLE.W_OldValue = "";
            this.lstCONT_TITLE.W_TableName = "";
            this.lstCONT_TITLE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // txtCONT_VALUE
            // 
            this.txtCONT_VALUE.BeforeTouchSize = new System.Drawing.Size(43, 23);
            this.txtCONT_VALUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCONT_VALUE.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCONT_VALUE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCONT_VALUE.Location = new System.Drawing.Point(185, 87);
            this.txtCONT_VALUE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCONT_VALUE.Name = "txtCONT_VALUE";
            this.txtCONT_VALUE.Size = new System.Drawing.Size(188, 23);
            this.txtCONT_VALUE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCONT_VALUE.TabIndex = 7;
            this.txtCONT_VALUE.W_Clear = true;
            this.txtCONT_VALUE.W_ColArName = "";
            this.txtCONT_VALUE.W_ColEgName = "";
            this.txtCONT_VALUE.W_OldValue = "";
            this.txtCONT_VALUE.W_TableName = "";
            this.txtCONT_VALUE.TextChanged += new System.EventHandler(this.myText1_TextChanged);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPhone.BackgroundImage")));
            this.btnAddPhone.BeforeTouchSize = new System.Drawing.Size(33, 23);
            this.btnAddPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddPhone.FlatAppearance.BorderSize = 0;
            this.btnAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPhone.Image")));
            this.btnAddPhone.IsBackStageButton = false;
            this.btnAddPhone.Location = new System.Drawing.Point(390, 87);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(33, 23);
            this.btnAddPhone.TabIndex = 25;
            this.btnAddPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAddPhone.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // txtADB_NAME
            // 
            this.txtADB_NAME.BeforeTouchSize = new System.Drawing.Size(43, 23);
            this.txtADB_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtADB_NAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtADB_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtADB_NAME.Location = new System.Drawing.Point(141, 31);
            this.txtADB_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtADB_NAME.Name = "txtADB_NAME";
            this.txtADB_NAME.Size = new System.Drawing.Size(246, 23);
            this.txtADB_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtADB_NAME.TabIndex = 30;
            this.txtADB_NAME.W_Clear = true;
            this.txtADB_NAME.W_ColArName = "";
            this.txtADB_NAME.W_ColEgName = "";
            this.txtADB_NAME.W_OldValue = "";
            this.txtADB_NAME.W_TableName = "";
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(43, 23);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(70, 276);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(43, 23);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 31;
            this.txtSWID.Visible = false;
            this.txtSWID.W_Clear = true;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // lstADB_LOCATION
            // 
            this.lstADB_LOCATION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstADB_LOCATION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstADB_LOCATION.Font = new System.Drawing.Font("Arial", 10F);
            this.lstADB_LOCATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstADB_LOCATION.FormattingEnabled = true;
            this.lstADB_LOCATION.Location = new System.Drawing.Point(283, 57);
            this.lstADB_LOCATION.Name = "lstADB_LOCATION";
            this.lstADB_LOCATION.Size = new System.Drawing.Size(138, 24);
            this.lstADB_LOCATION.TabIndex = 32;
            this.lstADB_LOCATION.W_Clear = true;
            this.lstADB_LOCATION.W_ColArName = "";
            this.lstADB_LOCATION.W_ColEgName = "";
            this.lstADB_LOCATION.W_OldValue = "";
            this.lstADB_LOCATION.W_TableName = "";
            this.lstADB_LOCATION.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // lstADB_DESCRIBE
            // 
            this.lstADB_DESCRIBE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstADB_DESCRIBE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstADB_DESCRIBE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstADB_DESCRIBE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstADB_DESCRIBE.FormattingEnabled = true;
            this.lstADB_DESCRIBE.Location = new System.Drawing.Point(90, 31);
            this.lstADB_DESCRIBE.Name = "lstADB_DESCRIBE";
            this.lstADB_DESCRIBE.Size = new System.Drawing.Size(51, 24);
            this.lstADB_DESCRIBE.TabIndex = 33;
            this.lstADB_DESCRIBE.W_Clear = true;
            this.lstADB_DESCRIBE.W_ColArName = "";
            this.lstADB_DESCRIBE.W_ColEgName = "";
            this.lstADB_DESCRIBE.W_OldValue = "";
            this.lstADB_DESCRIBE.W_TableName = "";
            this.lstADB_DESCRIBE.w_ValueType = ERP.myList.ValueType.TEXT;
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
            this.btnExit.Location = new System.Drawing.Point(366, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 203;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnSave.Location = new System.Drawing.Point(248, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 202;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstCONT_TYPE
            // 
            this.lstCONT_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCONT_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCONT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCONT_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCONT_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCONT_TYPE.FormattingEnabled = true;
            this.lstCONT_TYPE.Items.AddRange(new object[] {
            "هاتف",
            "فاكس",
            "بريد الكتروني",
            "عنوان",
            "موقع الكتروني",
            "أخرى"});
            this.lstCONT_TYPE.Location = new System.Drawing.Point(12, 85);
            this.lstCONT_TYPE.Name = "lstCONT_TYPE";
            this.lstCONT_TYPE.Size = new System.Drawing.Size(111, 24);
            this.lstCONT_TYPE.TabIndex = 205;
            this.lstCONT_TYPE.W_Clear = true;
            this.lstCONT_TYPE.W_ColArName = "";
            this.lstCONT_TYPE.W_ColEgName = "";
            this.lstCONT_TYPE.W_OldValue = "";
            this.lstCONT_TYPE.W_TableName = "";
            this.lstCONT_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
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
            this.btnSearch.Location = new System.Drawing.Point(393, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 219;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(28, 61);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(46, 18);
            this.myLabel3.TabIndex = 220;
            this.myLabel3.Text = "الوظيفة";
            // 
            // lstJOB
            // 
            this.lstJOB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstJOB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstJOB.Font = new System.Drawing.Font("Arial", 10F);
            this.lstJOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstJOB.FormattingEnabled = true;
            this.lstJOB.Location = new System.Drawing.Point(90, 57);
            this.lstJOB.Name = "lstJOB";
            this.lstJOB.Size = new System.Drawing.Size(126, 24);
            this.lstJOB.TabIndex = 221;
            this.lstJOB.W_Clear = true;
            this.lstJOB.W_ColArName = "";
            this.lstJOB.W_ColEgName = "";
            this.lstJOB.W_OldValue = "";
            this.lstJOB.W_TableName = "";
            this.lstJOB.w_ValueType = ERP.myList.ValueType.TEXT;
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
            this.btnNew.Location = new System.Drawing.Point(307, 271);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 222;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(430, 308);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstJOB);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstCONT_TYPE);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstADB_DESCRIBE);
            this.Controls.Add(this.lstADB_LOCATION);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.txtADB_NAME);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.txtCONT_VALUE);
            this.Controls.Add(this.lstCONT_TITLE);
            this.Controls.Add(this.dgCotactData);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel2);
            this.Name = "frmContacts";
            this.PriviFile = ERP.glb_function.ProgramType.File;
            this.Titel = "دليل العناوين";
            this.Load += new System.EventHandler(this.frmContacts_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.dgCotactData, 0);
            this.Controls.SetChildIndex(this.lstCONT_TITLE, 0);
            this.Controls.SetChildIndex(this.txtCONT_VALUE, 0);
            this.Controls.SetChildIndex(this.btnAddPhone, 0);
            this.Controls.SetChildIndex(this.txtADB_NAME, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.lstADB_LOCATION, 0);
            this.Controls.SetChildIndex(this.lstADB_DESCRIBE, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.lstCONT_TYPE, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.lstJOB, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCotactData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONT_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtADB_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myLabel myLabel2;
        private myLabel myLabel4;
        private myDataGrid dgCotactData;
        private myList lstCONT_TITLE;
        private myText txtCONT_VALUE;
        private myBottun btnAddPhone;
        private myList lstADB_LOCATION;
        private myBottun btnExit;
        private myBottun btnSave;
        private myList lstCONT_TYPE;
        private myBottun btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        public myText txtADB_NAME;
        public myList lstADB_DESCRIBE;
        private myLabel myLabel3;
        private myList lstJOB;
        private myBottun btnNew;
        public myText txtSWID;
    }
}
