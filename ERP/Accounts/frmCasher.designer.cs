

namespace ERP.Accounts
{
    partial class frmCasher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCasher));
            this.myLabel12 = new ERP.myLabel();
            this.txtAccNo = new ERP.myText();
            this.txtC_Name = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.lstC_type = new ERP.myList();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.lstBranches = new ERP.myList();
            this.btnNew = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.myLabel6 = new ERP.myLabel();
            this.lstAccName = new ERP.myList();
            this.txtSWId = new ERP.myText();
            this.lstAccNo = new ERP.myList();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFind = new ERP.myBottun();
            this.txtAccId = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.lstACC_NATURE = new ERP.myList();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccId)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(119, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(32, 34);
            // 
            // myLabel12
            // 
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(26, 69);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(67, 18);
            this.myLabel12.TabIndex = 22;
            this.myLabel12.Text = "رقم الحساب";
            // 
            // txtAccNo
            // 
            this.txtAccNo.BeforeTouchSize = new System.Drawing.Size(41, 23);
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAccNo.Location = new System.Drawing.Point(99, 62);
            this.txtAccNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(280, 23);
            this.txtAccNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAccNo.TabIndex = 23;
            this.txtAccNo.W_Clear = true;
            this.txtAccNo.W_ColArName = "";
            this.txtAccNo.W_ColEgName = "";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.W_TableName = "";
            // 
            // txtC_Name
            // 
            this.txtC_Name.BeforeTouchSize = new System.Drawing.Size(41, 23);
            this.txtC_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtC_Name.Font = new System.Drawing.Font("Arial", 10F);
            this.txtC_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtC_Name.Location = new System.Drawing.Point(99, 88);
            this.txtC_Name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtC_Name.Name = "txtC_Name";
            this.txtC_Name.Size = new System.Drawing.Size(238, 23);
            this.txtC_Name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtC_Name.TabIndex = 25;
            this.txtC_Name.W_Clear = true;
            this.txtC_Name.W_ColArName = "اسم الصندوق";
            this.txtC_Name.W_ColEgName = "C_Name";
            this.txtC_Name.W_OldValue = "";
            this.txtC_Name.W_TableName = "CASHER";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(18, 91);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(75, 18);
            this.myLabel2.TabIndex = 24;
            this.myLabel2.Text = "اسم الصندوق";
            // 
            // lstC_type
            // 
            this.lstC_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstC_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstC_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstC_type.Font = new System.Drawing.Font("Arial", 10F);
            this.lstC_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstC_type.FormattingEnabled = true;
            this.lstC_type.Items.AddRange(new object[] {
            "عهدة",
            "مبيعات",
            "صرف و قبض"});
            this.lstC_type.Location = new System.Drawing.Point(99, 115);
            this.lstC_type.Name = "lstC_type";
            this.lstC_type.Size = new System.Drawing.Size(280, 24);
            this.lstC_type.TabIndex = 27;
            this.lstC_type.W_Clear = true;
            this.lstC_type.W_ColArName = "";
            this.lstC_type.W_ColEgName = "";
            this.lstC_type.W_OldValue = "";
            this.lstC_type.W_TableName = "";
            this.lstC_type.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstC_type.SelectedIndexChanged += new System.EventHandler(this.lstC_type_SelectedIndexChanged);
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(18, 117);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(76, 18);
            this.myLabel3.TabIndex = 28;
            this.myLabel3.Text = "نوع الصندوق";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(33, 147);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(57, 18);
            this.myLabel5.TabIndex = 31;
            this.myLabel5.Text = "اسم الفرع";
            // 
            // lstBranches
            // 
            this.lstBranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBranches.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBranches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstBranches.FormattingEnabled = true;
            this.lstBranches.Location = new System.Drawing.Point(99, 145);
            this.lstBranches.Name = "lstBranches";
            this.lstBranches.Size = new System.Drawing.Size(280, 24);
            this.lstBranches.TabIndex = 32;
            this.lstBranches.W_Clear = true;
            this.lstBranches.W_ColArName = "";
            this.lstBranches.W_ColEgName = "";
            this.lstBranches.W_OldValue = "";
            this.lstBranches.W_TableName = "";
            this.lstBranches.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstBranches.SelectedIndexChanged += new System.EventHandler(this.lstBranches_SelectedIndexChanged);
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
            this.btnNew.Location = new System.Drawing.Point(322, 175);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 207;
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
            this.btnUpdate.Location = new System.Drawing.Point(160, 211);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 206;
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
            this.btnExit.Location = new System.Drawing.Point(223, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 205;
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
            this.btnSave.Location = new System.Drawing.Point(99, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 204;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(26, 40);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(64, 18);
            this.myLabel6.TabIndex = 208;
            this.myLabel6.Text = "حساب الاب";
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(217, 33);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(162, 24);
            this.lstAccName.TabIndex = 209;
            this.lstAccName.W_Clear = true;
            this.lstAccName.W_ColArName = "";
            this.lstAccName.W_ColEgName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.W_TableName = "";
            this.lstAccName.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccName.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // txtSWId
            // 
            this.txtSWId.BeforeTouchSize = new System.Drawing.Size(41, 23);
            this.txtSWId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSWId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWId.Location = new System.Drawing.Point(-10, 35);
            this.txtSWId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWId.Name = "txtSWId";
            this.txtSWId.Size = new System.Drawing.Size(41, 23);
            this.txtSWId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWId.TabIndex = 210;
            this.txtSWId.Visible = false;
            this.txtSWId.W_Clear = true;
            this.txtSWId.W_ColArName = "";
            this.txtSWId.W_ColEgName = "";
            this.txtSWId.W_OldValue = "";
            this.txtSWId.W_TableName = "";
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(99, 33);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(116, 24);
            this.lstAccNo.TabIndex = 211;
            this.lstAccNo.W_Clear = true;
            this.lstAccNo.W_ColArName = "";
            this.lstAccNo.W_ColEgName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.W_TableName = "";
            this.lstAccNo.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.IsBackStageButton = false;
            this.btnFind.Location = new System.Drawing.Point(352, 85);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 212;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // txtAccId
            // 
            this.txtAccId.BeforeTouchSize = new System.Drawing.Size(41, 23);
            this.txtAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAccId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAccId.Location = new System.Drawing.Point(356, 64);
            this.txtAccId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAccId.Name = "txtAccId";
            this.txtAccId.Size = new System.Drawing.Size(41, 23);
            this.txtAccId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAccId.TabIndex = 213;
            this.txtAccId.Visible = false;
            this.txtAccId.W_Clear = true;
            this.txtAccId.W_ColArName = "";
            this.txtAccId.W_ColEgName = "";
            this.txtAccId.W_OldValue = "";
            this.txtAccId.W_TableName = "";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(18, 180);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(78, 18);
            this.myLabel4.TabIndex = 215;
            this.myLabel4.Text = "طبيعة الحساب";
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
            "مدين/دائن"});
            this.lstACC_NATURE.Location = new System.Drawing.Point(99, 175);
            this.lstACC_NATURE.Name = "lstACC_NATURE";
            this.lstACC_NATURE.Size = new System.Drawing.Size(280, 26);
            this.lstACC_NATURE.TabIndex = 230;
            this.lstACC_NATURE.W_Clear = true;
            this.lstACC_NATURE.W_ColArName = "طبيعة الحساب";
            this.lstACC_NATURE.W_ColEgName = "acc_nature";
            this.lstACC_NATURE.W_OldValue = "";
            this.lstACC_NATURE.W_TableName = "ACCOUNTS";
            this.lstACC_NATURE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // frmCasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(406, 251);
            this.Controls.Add(this.lstACC_NATURE);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.txtAccId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.txtSWId);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstBranches);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.lstC_type);
            this.Controls.Add(this.txtC_Name);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.myLabel12);
            this.Name = "frmCasher";
            this.Titel = "تعريف الصناديق";
            this.Load += new System.EventHandler(this.frmCasher_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.txtAccNo, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtC_Name, 0);
            this.Controls.SetChildIndex(this.lstC_type, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.lstBranches, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.txtSWId, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.txtAccId, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.lstACC_NATURE, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myLabel myLabel12;
        private ERP.myText txtAccNo;
        private ERP.myText txtC_Name;
        private ERP.myLabel myLabel2;
        private ERP.myList lstC_type;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel5;
        private ERP.myList lstBranches;
        private ERP.myBottun btnNew;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnExit;
        private ERP.myBottun btnSave;
        private ERP.myLabel myLabel6;
        private ERP.myList lstAccName;
        private ERP.myText txtSWId;
        private ERP.myList lstAccNo;
        private System.Windows.Forms.ErrorProvider errCheck;
        private ERP.myBottun btnFind;
        private ERP.myText txtAccId;
        private myLabel myLabel4;
        private myList lstACC_NATURE;
    }
}
