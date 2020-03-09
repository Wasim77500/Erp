
namespace ERP.File
{
    partial class frmUsers
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.myLabel1 = new ERP.myLabel();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSWID = new ERP.myText();
            this.lstUSER_BRANCH = new ERP.myList();
            this.myLabel2 = new ERP.myLabel();
            this.txtUSER_NOTE = new ERP.myText();
            this.txtUSER_NAME = new ERP.myText();
            this.txtUSER_LOGIN = new ERP.myText();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.btnSearch = new ERP.myBottun();
            this.btnNew = new ERP.myBottun();
            this.btnClose = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.myLabel4 = new ERP.myLabel();
            this.frmFindAccount = new ERP.myBottun();
            this.btnAdd = new ERP.myBottun();
            this.dgUserAccPervented = new ERP.myDataGrid();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lstAccName = new ERP.myList();
            this.lstAccNo = new ERP.myList();
            this.myLabel13 = new ERP.myLabel();
            this.myLabel12 = new ERP.myLabel();
            this.tvTempletTree = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.myLabel5 = new ERP.myLabel();
            this.lstACCESS_TYPE = new ERP.myList();
            this.lstTempBranch = new ERP.myText();
            this.txtNodeName = new ERP.myText();
            this.btnGetNode = new ERP.myBottun();
            this.btnUserAccess = new ERP.myBottun();
            this.lstDept = new ERP.myList();
            this.myLabel8 = new ERP.myLabel();
            this.myLabel7 = new ERP.myLabel();
            this.txtPassword = new ERP.myText();
            this.btnResetPassword = new ERP.myBottun();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_NOTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_LOGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserAccPervented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvTempletTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTempBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(252, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(165, 34);
            // 
            // myLabel1
            // 
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.myLabel1.Location = new System.Drawing.Point(353, 12);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel1.Size = new System.Drawing.Size(75, 20);
            this.myLabel1.TabIndex = 123;
            this.myLabel1.Text = "اسم الدخول";
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(145, 25);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(455, 26);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(28, 25);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 168;
            this.txtSWID.Visible = false;
            this.txtSWID.W_Clear = true;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // lstUSER_BRANCH
            // 
            this.lstUSER_BRANCH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstUSER_BRANCH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstUSER_BRANCH.Font = new System.Drawing.Font("Arial", 10F);
            this.lstUSER_BRANCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstUSER_BRANCH.FormattingEnabled = true;
            this.lstUSER_BRANCH.Location = new System.Drawing.Point(474, 64);
            this.lstUSER_BRANCH.Name = "lstUSER_BRANCH";
            this.lstUSER_BRANCH.Size = new System.Drawing.Size(179, 24);
            this.lstUSER_BRANCH.TabIndex = 161;
            this.lstUSER_BRANCH.W_Clear = true;
            this.lstUSER_BRANCH.W_ColArName = "الفرع الشغال فيه المستخدم";
            this.lstUSER_BRANCH.W_ColEgName = "USER_BRANCH";
            this.lstUSER_BRANCH.W_OldValue = "";
            this.lstUSER_BRANCH.W_TableName = "USERINFO";
            this.lstUSER_BRANCH.w_ValueType = ERP.myList.ValueType.VALUE;
            this.lstUSER_BRANCH.SelectedIndexChanged += new System.EventHandler(this.lstUSER_BRANCH_SelectedIndexChanged);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.DX = 190;
            this.myLabel2.DY = 5;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.LabeledControl = this.lstUSER_BRANCH;
            this.myLabel2.Location = new System.Drawing.Point(407, 69);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(56, 18);
            this.myLabel2.TabIndex = 160;
            this.myLabel2.Text = "الفــرع";
            // 
            // txtUSER_NOTE
            // 
            this.txtUSER_NOTE.BeforeTouchSize = new System.Drawing.Size(145, 25);
            this.txtUSER_NOTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSER_NOTE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUSER_NOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtUSER_NOTE.Location = new System.Drawing.Point(124, 95);
            this.txtUSER_NOTE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUSER_NOTE.Name = "txtUSER_NOTE";
            this.txtUSER_NOTE.Size = new System.Drawing.Size(179, 25);
            this.txtUSER_NOTE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtUSER_NOTE.TabIndex = 159;
            this.txtUSER_NOTE.W_Clear = true;
            this.txtUSER_NOTE.W_ColArName = "ملاحظات";
            this.txtUSER_NOTE.W_ColEgName = "USER_NOTE";
            this.txtUSER_NOTE.W_OldValue = "";
            this.txtUSER_NOTE.W_TableName = "USERINFO";
            // 
            // txtUSER_NAME
            // 
            this.txtUSER_NAME.BeforeTouchSize = new System.Drawing.Size(145, 25);
            this.txtUSER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSER_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUSER_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtUSER_NAME.Location = new System.Drawing.Point(124, 64);
            this.txtUSER_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUSER_NAME.Name = "txtUSER_NAME";
            this.txtUSER_NAME.Size = new System.Drawing.Size(179, 25);
            this.txtUSER_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtUSER_NAME.TabIndex = 158;
            this.txtUSER_NAME.W_Clear = true;
            this.txtUSER_NAME.W_ColArName = "اسم المستخدم";
            this.txtUSER_NAME.W_ColEgName = "USER_NAME";
            this.txtUSER_NAME.W_OldValue = "";
            this.txtUSER_NAME.W_TableName = "USERINFO";
            // 
            // txtUSER_LOGIN
            // 
            this.txtUSER_LOGIN.BeforeTouchSize = new System.Drawing.Size(145, 25);
            this.txtUSER_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSER_LOGIN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUSER_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtUSER_LOGIN.Location = new System.Drawing.Point(124, 33);
            this.txtUSER_LOGIN.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUSER_LOGIN.Name = "txtUSER_LOGIN";
            this.txtUSER_LOGIN.Size = new System.Drawing.Size(179, 25);
            this.txtUSER_LOGIN.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtUSER_LOGIN.TabIndex = 157;
            this.txtUSER_LOGIN.W_Clear = true;
            this.txtUSER_LOGIN.W_ColArName = "اسم دخول المستخدم";
            this.txtUSER_LOGIN.W_ColEgName = "USER_LOGIN";
            this.txtUSER_LOGIN.W_OldValue = "";
            this.txtUSER_LOGIN.W_TableName = "USERINFO";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = false;
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.DX = 190;
            this.myLabel6.DY = 5;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.LabeledControl = this.txtUSER_NOTE;
            this.myLabel6.Location = new System.Drawing.Point(30, 100);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(83, 18);
            this.myLabel6.TabIndex = 156;
            this.myLabel6.Text = "ملاحظات";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = false;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.DX = 190;
            this.myLabel3.DY = 5;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.LabeledControl = this.txtUSER_NAME;
            this.myLabel3.Location = new System.Drawing.Point(30, 69);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(83, 18);
            this.myLabel3.TabIndex = 155;
            this.myLabel3.Text = "اسم المستخدم";
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
            this.btnSearch.Location = new System.Drawing.Point(305, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 169;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnNew.Location = new System.Drawing.Point(421, 504);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 170;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnClose.Location = new System.Drawing.Point(611, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 171;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnClose.w_Type = ERP.myBottun.Btton_type.Close;
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
            this.btnUpdate.Location = new System.Drawing.Point(554, 504);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 172;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnSave.Location = new System.Drawing.Point(497, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 173;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.DX = 190;
            this.myLabel4.DY = 5;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.LabeledControl = this.txtUSER_LOGIN;
            this.myLabel4.Location = new System.Drawing.Point(30, 38);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(83, 18);
            this.myLabel4.TabIndex = 174;
            this.myLabel4.Text = "اسم الدخول";
            // 
            // frmFindAccount
            // 
            this.frmFindAccount.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.frmFindAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmFindAccount.FlatAppearance.BorderSize = 0;
            this.frmFindAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmFindAccount.Image = ((System.Drawing.Image)(resources.GetObject("frmFindAccount.Image")));
            this.frmFindAccount.IsBackStageButton = false;
            this.frmFindAccount.Location = new System.Drawing.Point(628, 175);
            this.frmFindAccount.Name = "frmFindAccount";
            this.frmFindAccount.Size = new System.Drawing.Size(28, 27);
            this.frmFindAccount.TabIndex = 240;
            this.frmFindAccount.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.frmFindAccount.w_Type = ERP.myBottun.Btton_type.Search;
            this.frmFindAccount.Click += new System.EventHandler(this.frmFindAccount_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(36, 25);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.Image = global::ERP.Properties.Resources.Add_h;
            this.btnAdd.IsBackStageButton = false;
            this.btnAdd.Location = new System.Drawing.Point(625, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 25);
            this.btnAdd.TabIndex = 239;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgUserAccPervented
            // 
            this.dgUserAccPervented.AllowUserToAddRows = false;
            this.dgUserAccPervented.AllowUserToDeleteRows = false;
            this.dgUserAccPervented.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUserAccPervented.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUserAccPervented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserAccPervented.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column29,
            this.Column30,
            this.Column31,
            this.Column32,
            this.Column33});
            this.dgUserAccPervented.EnableHeadersVisualStyles = false;
            this.dgUserAccPervented.Location = new System.Drawing.Point(406, 230);
            this.dgUserAccPervented.Name = "dgUserAccPervented";
            this.dgUserAccPervented.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgUserAccPervented.RowHeadersVisible = false;
            this.dgUserAccPervented.Size = new System.Drawing.Size(257, 268);
            this.dgUserAccPervented.TabIndex = 237;
            this.dgUserAccPervented.W_Clear = true;
            this.dgUserAccPervented.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGrid1_CellContentClick);
            // 
            // Column29
            // 
            this.Column29.HeaderText = "swid";
            this.Column29.Name = "Column29";
            this.Column29.Visible = false;
            // 
            // Column30
            // 
            this.Column30.HeaderText = "accid";
            this.Column30.Name = "Column30";
            this.Column30.Visible = false;
            // 
            // Column31
            // 
            this.Column31.HeaderText = "رقم الحساب";
            this.Column31.Name = "Column31";
            this.Column31.ReadOnly = true;
            // 
            // Column32
            // 
            this.Column32.HeaderText = "اسم الحساب";
            this.Column32.Name = "Column32";
            this.Column32.ReadOnly = true;
            // 
            // Column33
            // 
            this.Column33.HeaderText = "حذف";
            this.Column33.Image = global::ERP.Properties.Resources.S43Qy;
            this.Column33.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column33.Name = "Column33";
            this.Column33.Width = 50;
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(503, 204);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstAccName.Size = new System.Drawing.Size(122, 24);
            this.lstAccName.TabIndex = 236;
            this.lstAccName.W_Clear = true;
            this.lstAccName.W_ColArName = "";
            this.lstAccName.W_ColEgName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.W_TableName = "";
            this.lstAccName.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccName.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(503, 177);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstAccNo.Size = new System.Drawing.Size(122, 24);
            this.lstAccNo.TabIndex = 235;
            this.lstAccNo.W_Clear = true;
            this.lstAccNo.W_ColArName = "";
            this.lstAccNo.W_ColEgName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.W_TableName = "";
            this.lstAccNo.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // myLabel13
            // 
            this.myLabel13.BackColor = System.Drawing.Color.Transparent;
            this.myLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel13.ForeColor = System.Drawing.Color.Black;
            this.myLabel13.Location = new System.Drawing.Point(431, 209);
            this.myLabel13.Name = "myLabel13";
            this.myLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel13.Size = new System.Drawing.Size(69, 18);
            this.myLabel13.TabIndex = 234;
            this.myLabel13.Text = "اسم الحساب";
            // 
            // myLabel12
            // 
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(431, 182);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(67, 18);
            this.myLabel12.TabIndex = 233;
            this.myLabel12.Text = "رقم الحساب";
            // 
            // tvTempletTree
            // 
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            treeNodeAdvStyleInfo1.ShowCheckBox = false;
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            this.tvTempletTree.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.tvTempletTree.BeforeTouchSize = new System.Drawing.Size(275, 295);
            this.tvTempletTree.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.tvTempletTree.ForeColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tvTempletTree.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.tvTempletTree.HelpTextControl.Name = "helpText";
            this.tvTempletTree.HelpTextControl.TabIndex = 0;
            this.tvTempletTree.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.tvTempletTree.Location = new System.Drawing.Point(12, 203);
            this.tvTempletTree.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tvTempletTree.Name = "tvTempletTree";
            this.tvTempletTree.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tvTempletTree.Size = new System.Drawing.Size(275, 295);
            this.tvTempletTree.TabIndex = 5;
            // 
            // 
            // 
            this.tvTempletTree.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.tvTempletTree.ToolTipControl.Name = "toolTip";
            this.tvTempletTree.ToolTipControl.TabIndex = 1;
            this.tvTempletTree.AfterCheck += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvEventHandler(this.tvTempletTree_AfterCheck);
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = false;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(353, 123);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(119, 18);
            this.myLabel5.TabIndex = 228;
            this.myLabel5.Text = "الوصول من الاجهزة";
            // 
            // lstACCESS_TYPE
            // 
            this.lstACCESS_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstACCESS_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstACCESS_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstACCESS_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstACCESS_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstACCESS_TYPE.FormattingEnabled = true;
            this.lstACCESS_TYPE.Items.AddRange(new object[] {
            "كل",
            "جزء"});
            this.lstACCESS_TYPE.Location = new System.Drawing.Point(478, 120);
            this.lstACCESS_TYPE.Name = "lstACCESS_TYPE";
            this.lstACCESS_TYPE.Size = new System.Drawing.Size(147, 24);
            this.lstACCESS_TYPE.TabIndex = 229;
            this.lstACCESS_TYPE.W_Clear = true;
            this.lstACCESS_TYPE.W_ColArName = "الوصول من الاجهزة";
            this.lstACCESS_TYPE.W_ColEgName = "ACCESS_TYPE";
            this.lstACCESS_TYPE.W_OldValue = "";
            this.lstACCESS_TYPE.W_TableName = "USERINFO";
            this.lstACCESS_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // lstTempBranch
            // 
            this.lstTempBranch.BeforeTouchSize = new System.Drawing.Size(145, 25);
            this.lstTempBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTempBranch.Font = new System.Drawing.Font("Arial", 10F);
            this.lstTempBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstTempBranch.Location = new System.Drawing.Point(21, 147);
            this.lstTempBranch.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.lstTempBranch.Name = "lstTempBranch";
            this.lstTempBranch.Size = new System.Drawing.Size(70, 23);
            this.lstTempBranch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.lstTempBranch.TabIndex = 244;
            this.lstTempBranch.Visible = false;
            this.lstTempBranch.W_Clear = false;
            this.lstTempBranch.W_ColArName = "";
            this.lstTempBranch.W_ColEgName = "";
            this.lstTempBranch.W_OldValue = "";
            this.lstTempBranch.W_TableName = "";
            // 
            // txtNodeName
            // 
            this.txtNodeName.BeforeTouchSize = new System.Drawing.Size(145, 25);
            this.txtNodeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNodeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtNodeName.Location = new System.Drawing.Point(12, 176);
            this.txtNodeName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(176, 25);
            this.txtNodeName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtNodeName.TabIndex = 245;
            this.txtNodeName.W_Clear = true;
            this.txtNodeName.W_ColArName = "اسم دخول المستخدم";
            this.txtNodeName.W_ColEgName = "USER_LOGIN";
            this.txtNodeName.W_OldValue = "";
            this.txtNodeName.W_TableName = "USERINFO";
            this.txtNodeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNodeName_KeyDown);
            // 
            // btnGetNode
            // 
            this.btnGetNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetNode.BackgroundImage")));
            this.btnGetNode.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetNode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetNode.FlatAppearance.BorderSize = 0;
            this.btnGetNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetNode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetNode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetNode.Image = ((System.Drawing.Image)(resources.GetObject("btnGetNode.Image")));
            this.btnGetNode.IsBackStageButton = false;
            this.btnGetNode.Location = new System.Drawing.Point(194, 173);
            this.btnGetNode.Name = "btnGetNode";
            this.btnGetNode.Size = new System.Drawing.Size(28, 27);
            this.btnGetNode.TabIndex = 246;
            this.btnGetNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetNode.UseVisualStyleBackColor = true;
            this.btnGetNode.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetNode.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetNode.Click += new System.EventHandler(this.btnGetNode_Click);
            // 
            // btnUserAccess
            // 
            this.btnUserAccess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserAccess.BackgroundImage")));
            this.btnUserAccess.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnUserAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUserAccess.FlatAppearance.BorderSize = 0;
            this.btnUserAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAccess.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUserAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUserAccess.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAccess.Image")));
            this.btnUserAccess.IsBackStageButton = false;
            this.btnUserAccess.Location = new System.Drawing.Point(626, 121);
            this.btnUserAccess.Name = "btnUserAccess";
            this.btnUserAccess.Size = new System.Drawing.Size(28, 27);
            this.btnUserAccess.TabIndex = 247;
            this.btnUserAccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserAccess.UseVisualStyleBackColor = true;
            this.btnUserAccess.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnUserAccess.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnUserAccess.Click += new System.EventHandler(this.btnUserAccess_Click);
            // 
            // lstDept
            // 
            this.lstDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstDept.Font = new System.Drawing.Font("Arial", 10F);
            this.lstDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstDept.FormattingEnabled = true;
            this.lstDept.Location = new System.Drawing.Point(474, 93);
            this.lstDept.Name = "lstDept";
            this.lstDept.Size = new System.Drawing.Size(179, 24);
            this.lstDept.TabIndex = 248;
            this.lstDept.W_Clear = true;
            this.lstDept.W_ColArName = "القسم الشغال فيه المستخدم";
            this.lstDept.W_ColEgName = "DEPT_ID";
            this.lstDept.W_OldValue = "";
            this.lstDept.W_TableName = "USERINFO";
            this.lstDept.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = false;
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(407, 95);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel8.Size = new System.Drawing.Size(56, 18);
            this.myLabel8.TabIndex = 249;
            this.myLabel8.Text = "القـسـم";
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = false;
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(35, 134);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(83, 18);
            this.myLabel7.TabIndex = 250;
            this.myLabel7.Text = "كلمة السر";
            // 
            // txtPassword
            // 
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(145, 25);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPassword.Location = new System.Drawing.Point(124, 130);
            this.txtPassword.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(145, 25);
            this.txtPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPassword.TabIndex = 251;
            this.txtPassword.Text = "123";
            this.txtPassword.W_Clear = true;
            this.txtPassword.W_ColArName = "ملاحظات";
            this.txtPassword.W_ColEgName = "USER_NOTE";
            this.txtPassword.W_OldValue = "";
            this.txtPassword.W_TableName = "USERINFO";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.BackgroundImage")));
            this.btnResetPassword.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnResetPassword.Image = global::ERP.Properties.Resources.Update2;
            this.btnResetPassword.IsBackStageButton = false;
            this.btnResetPassword.Location = new System.Drawing.Point(275, 130);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(28, 27);
            this.btnResetPassword.TabIndex = 252;
            this.btnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnResetPassword.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 537);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.myLabel8);
            this.Controls.Add(this.lstDept);
            this.Controls.Add(this.btnUserAccess);
            this.Controls.Add(this.btnGetNode);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.lstTempBranch);
            this.Controls.Add(this.tvTempletTree);
            this.Controls.Add(this.frmFindAccount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstACCESS_TYPE);
            this.Controls.Add(this.dgUserAccPervented);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.myLabel13);
            this.Controls.Add(this.myLabel12);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.lstUSER_BRANCH);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.txtUSER_NOTE);
            this.Controls.Add(this.txtUSER_NAME);
            this.Controls.Add(this.txtUSER_LOGIN);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel3);
            this.Name = "frmUsers";
            this.PriviFile = ERP.glb_function.ProgramType.File;
            this.Text = "المستخدمين والصلاحيات";
            this.Titel = "تعريف المستخدمين للنظام";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.txtUSER_LOGIN, 0);
            this.Controls.SetChildIndex(this.txtUSER_NAME, 0);
            this.Controls.SetChildIndex(this.txtUSER_NOTE, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.lstUSER_BRANCH, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.myLabel13, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.dgUserAccPervented, 0);
            this.Controls.SetChildIndex(this.lstACCESS_TYPE, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.frmFindAccount, 0);
            this.Controls.SetChildIndex(this.tvTempletTree, 0);
            this.Controls.SetChildIndex(this.lstTempBranch, 0);
            this.Controls.SetChildIndex(this.txtNodeName, 0);
            this.Controls.SetChildIndex(this.btnGetNode, 0);
            this.Controls.SetChildIndex(this.btnUserAccess, 0);
            this.Controls.SetChildIndex(this.lstDept, 0);
            this.Controls.SetChildIndex(this.myLabel8, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.btnResetPassword, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_NOTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_LOGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserAccPervented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvTempletTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTempBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errCheck;
        private myLabel myLabel1;
        private myLabel myLabel4;
        private myBottun btnSave;
        private myBottun btnUpdate;
        private myBottun btnClose;
        private myBottun btnNew;
        private myBottun btnSearch;
        private myText txtSWID;
        private myList lstUSER_BRANCH;
        private myLabel myLabel2;
        private myText txtUSER_NOTE;
        private myText txtUSER_NAME;
        private myText txtUSER_LOGIN;
        private myLabel myLabel6;
        private myLabel myLabel3;
        private myList lstACCESS_TYPE;
        private myLabel myLabel5;
        private myDataGrid dgUserAccPervented;
        private myList lstAccName;
        private myList lstAccNo;
        private myLabel myLabel13;
        private myLabel myLabel12;
        private myBottun btnAdd;
        private myBottun frmFindAccount;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv tvTempletTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewImageColumn Column33;
        private myText lstTempBranch;
        private myBottun btnGetNode;
        private myText txtNodeName;
        private myBottun btnUserAccess;
        private myList lstDept;
        private myLabel myLabel8;
        private myBottun btnResetPassword;
        private myText txtPassword;
        private myLabel myLabel7;
    }
}
