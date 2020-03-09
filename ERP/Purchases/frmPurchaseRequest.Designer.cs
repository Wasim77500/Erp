namespace ERP.Purchases
{
    partial class frmPurchaseRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseRequest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbItems = new ERP.myGroupBox();
            this.txtItemId = new ERP.myText();
            this.txtActivity = new ERP.myText();
            this.myLabel11 = new ERP.myLabel();
            this.myLabel10 = new ERP.myLabel();
            this.txtCatagory = new ERP.myText();
            this.txtItemName = new ERP.myText();
            this.myLabel9 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.txtItemNo = new ERP.myText();
            this.btnFindItem = new ERP.myBottun();
            this.myLabel2 = new ERP.myLabel();
            this.txtCONTACT_ID = new ERP.myText();
            this.btnFindContact = new ERP.myBottun();
            this.txtContactName = new ERP.myText();
            this.myLabel5 = new ERP.myLabel();
            this.txtCUSTOMER_ACCID = new ERP.myText();
            this.btnGetCustomer = new ERP.myBottun();
            this.myLabel7 = new ERP.myLabel();
            this.txtCurrentQty = new ERP.myText();
            this.myLabel8 = new ERP.myLabel();
            this.nmbQty = new ERP.myNumber();
            this.btnAdd = new ERP.myBottun();
            this.dgREQUESTS_PURCHASES = new ERP.myDataGrid();
            this.myLabel12 = new ERP.myLabel();
            this.txtAcceptQty = new ERP.myText();
            this.txtCustomerId = new ERP.myText();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            this.gbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONTACT_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCUSTOMER_ACCID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgREQUESTS_PURCHASES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerId)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(214, 34);
            // 
            // gbItems
            // 
            this.gbItems.BackColor = System.Drawing.Color.Transparent;
            this.gbItems.Controls.Add(this.txtItemId);
            this.gbItems.Controls.Add(this.txtActivity);
            this.gbItems.Controls.Add(this.myLabel11);
            this.gbItems.Controls.Add(this.myLabel10);
            this.gbItems.Controls.Add(this.txtCatagory);
            this.gbItems.Controls.Add(this.txtItemName);
            this.gbItems.Controls.Add(this.myLabel9);
            this.gbItems.Controls.Add(this.myLabel3);
            this.gbItems.Controls.Add(this.txtItemNo);
            this.gbItems.Controls.Add(this.btnFindItem);
            this.gbItems.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbItems.Location = new System.Drawing.Point(67, 85);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(501, 81);
            this.gbItems.TabIndex = 263;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "الأصنـاف";
            // 
            // txtItemId
            // 
            this.txtItemId.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtItemId.Location = new System.Drawing.Point(470, 50);
            this.txtItemId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(25, 23);
            this.txtItemId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtItemId.TabIndex = 278;
            this.txtItemId.Visible = false;
            this.txtItemId.W_Clear = true;
            this.txtItemId.W_ColArName = "";
            this.txtItemId.W_ColEgName = "";
            this.txtItemId.W_OldValue = "";
            this.txtItemId.W_TableName = "";
            // 
            // txtActivity
            // 
            this.txtActivity.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActivity.Enabled = false;
            this.txtActivity.Font = new System.Drawing.Font("Arial", 10F);
            this.txtActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtActivity.Location = new System.Drawing.Point(6, 50);
            this.txtActivity.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(156, 23);
            this.txtActivity.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtActivity.TabIndex = 277;
            this.txtActivity.W_Clear = true;
            this.txtActivity.W_ColArName = "اسم الفرع بالعربي";
            this.txtActivity.W_ColEgName = "BRANCH_ANAME";
            this.txtActivity.W_OldValue = "";
            this.txtActivity.W_TableName = "BRANCHES";
            // 
            // myLabel11
            // 
            this.myLabel11.BackColor = System.Drawing.Color.Transparent;
            this.myLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel11.ForeColor = System.Drawing.Color.Black;
            this.myLabel11.Location = new System.Drawing.Point(183, 55);
            this.myLabel11.Name = "myLabel11";
            this.myLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel11.Size = new System.Drawing.Size(41, 18);
            this.myLabel11.TabIndex = 276;
            this.myLabel11.Text = "النشاط";
            // 
            // myLabel10
            // 
            this.myLabel10.BackColor = System.Drawing.Color.Transparent;
            this.myLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel10.ForeColor = System.Drawing.Color.Black;
            this.myLabel10.Location = new System.Drawing.Point(430, 52);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel10.Size = new System.Drawing.Size(51, 18);
            this.myLabel10.TabIndex = 275;
            this.myLabel10.Text = "التصنيف";
            // 
            // txtCatagory
            // 
            this.txtCatagory.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtCatagory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatagory.Enabled = false;
            this.txtCatagory.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCatagory.Location = new System.Drawing.Point(250, 50);
            this.txtCatagory.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.Size = new System.Drawing.Size(174, 23);
            this.txtCatagory.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCatagory.TabIndex = 274;
            this.txtCatagory.W_Clear = true;
            this.txtCatagory.W_ColArName = "اسم الفرع بالعربي";
            this.txtCatagory.W_ColEgName = "BRANCH_ANAME";
            this.txtCatagory.W_OldValue = "";
            this.txtCatagory.W_TableName = "BRANCHES";
            // 
            // txtItemName
            // 
            this.txtItemName.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Enabled = false;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtItemName.Location = new System.Drawing.Point(6, 22);
            this.txtItemName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(156, 23);
            this.txtItemName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtItemName.TabIndex = 273;
            this.txtItemName.W_Clear = true;
            this.txtItemName.W_ColArName = "اسم الفرع بالعربي";
            this.txtItemName.W_ColEgName = "BRANCH_ANAME";
            this.txtItemName.W_OldValue = "";
            this.txtItemName.W_TableName = "BRANCHES";
            // 
            // myLabel9
            // 
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(173, 24);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel9.Size = new System.Drawing.Size(65, 18);
            this.myLabel9.TabIndex = 248;
            this.myLabel9.Text = "اسم الصنف";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(430, 26);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(63, 18);
            this.myLabel3.TabIndex = 215;
            this.myLabel3.Text = "رقم الصنف";
            // 
            // txtItemNo
            // 
            this.txtItemNo.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtItemNo.Location = new System.Drawing.Point(287, 21);
            this.txtItemNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(137, 23);
            this.txtItemNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtItemNo.TabIndex = 216;
            this.txtItemNo.W_Clear = true;
            this.txtItemNo.W_ColArName = "اسم الفرع بالعربي";
            this.txtItemNo.W_ColEgName = "BRANCH_ANAME";
            this.txtItemNo.W_OldValue = "";
            this.txtItemNo.W_TableName = "BRANCHES";
            // 
            // btnFindItem
            // 
            this.btnFindItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindItem.BackgroundImage")));
            this.btnFindItem.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFindItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindItem.FlatAppearance.BorderSize = 0;
            this.btnFindItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFindItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindItem.Image = ((System.Drawing.Image)(resources.GetObject("btnFindItem.Image")));
            this.btnFindItem.IsBackStageButton = false;
            this.btnFindItem.Location = new System.Drawing.Point(253, 17);
            this.btnFindItem.Name = "btnFindItem";
            this.btnFindItem.Size = new System.Drawing.Size(28, 27);
            this.btnFindItem.TabIndex = 247;
            this.btnFindItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindItem.UseVisualStyleBackColor = true;
            this.btnFindItem.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFindItem.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFindItem.Click += new System.EventHandler(this.btnFindItem_Click);
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(81, 38);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(58, 18);
            this.myLabel2.TabIndex = 264;
            this.myLabel2.Text = "رقم العميل";
            // 
            // txtCONTACT_ID
            // 
            this.txtCONTACT_ID.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtCONTACT_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCONTACT_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCONTACT_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCONTACT_ID.Location = new System.Drawing.Point(68, 60);
            this.txtCONTACT_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCONTACT_ID.Name = "txtCONTACT_ID";
            this.txtCONTACT_ID.Size = new System.Drawing.Size(30, 23);
            this.txtCONTACT_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCONTACT_ID.TabIndex = 287;
            this.txtCONTACT_ID.Visible = false;
            this.txtCONTACT_ID.W_Clear = true;
            this.txtCONTACT_ID.W_ColArName = "";
            this.txtCONTACT_ID.W_ColEgName = "";
            this.txtCONTACT_ID.W_OldValue = "";
            this.txtCONTACT_ID.W_TableName = "";
            // 
            // btnFindContact
            // 
            this.btnFindContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindContact.BackgroundImage")));
            this.btnFindContact.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFindContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindContact.FlatAppearance.BorderSize = 0;
            this.btnFindContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindContact.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFindContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindContact.Image = ((System.Drawing.Image)(resources.GetObject("btnFindContact.Image")));
            this.btnFindContact.IsBackStageButton = false;
            this.btnFindContact.Location = new System.Drawing.Point(537, 59);
            this.btnFindContact.Name = "btnFindContact";
            this.btnFindContact.Size = new System.Drawing.Size(28, 27);
            this.btnFindContact.TabIndex = 286;
            this.btnFindContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindContact.UseVisualStyleBackColor = true;
            this.btnFindContact.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFindContact.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFindContact.Click += new System.EventHandler(this.btnFindContact_Click);
            // 
            // txtContactName
            // 
            this.txtContactName.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactName.Enabled = false;
            this.txtContactName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContactName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtContactName.Location = new System.Drawing.Point(145, 60);
            this.txtContactName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(389, 23);
            this.txtContactName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtContactName.TabIndex = 285;
            this.txtContactName.W_Clear = true;
            this.txtContactName.W_ColArName = "";
            this.txtContactName.W_ColEgName = "";
            this.txtContactName.W_OldValue = "";
            this.txtContactName.W_TableName = "";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(83, 65);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(60, 18);
            this.myLabel5.TabIndex = 284;
            this.myLabel5.Text = "اسم العميل";
            // 
            // txtCUSTOMER_ACCID
            // 
            this.txtCUSTOMER_ACCID.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtCUSTOMER_ACCID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCUSTOMER_ACCID.Enabled = false;
            this.txtCUSTOMER_ACCID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCUSTOMER_ACCID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCUSTOMER_ACCID.Location = new System.Drawing.Point(145, 33);
            this.txtCUSTOMER_ACCID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCUSTOMER_ACCID.Name = "txtCUSTOMER_ACCID";
            this.txtCUSTOMER_ACCID.Size = new System.Drawing.Size(147, 23);
            this.txtCUSTOMER_ACCID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCUSTOMER_ACCID.TabIndex = 279;
            this.txtCUSTOMER_ACCID.W_Clear = true;
            this.txtCUSTOMER_ACCID.W_ColArName = "اسم الفرع بالعربي";
            this.txtCUSTOMER_ACCID.W_ColEgName = "BRANCH_ANAME";
            this.txtCUSTOMER_ACCID.W_OldValue = "";
            this.txtCUSTOMER_ACCID.W_TableName = "BRANCHES";
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetCustomer.BackgroundImage")));
            this.btnGetCustomer.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetCustomer.FlatAppearance.BorderSize = 0;
            this.btnGetCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCustomer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnGetCustomer.Image")));
            this.btnGetCustomer.IsBackStageButton = false;
            this.btnGetCustomer.Location = new System.Drawing.Point(297, 31);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(28, 27);
            this.btnGetCustomer.TabIndex = 288;
            this.btnGetCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetCustomer.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // myLabel7
            // 
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(67, 173);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(75, 18);
            this.myLabel7.TabIndex = 279;
            this.myLabel7.Text = "الكمية الحالية";
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtCurrentQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentQty.Enabled = false;
            this.txtCurrentQty.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCurrentQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCurrentQty.Location = new System.Drawing.Point(144, 169);
            this.txtCurrentQty.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.Size = new System.Drawing.Size(53, 23);
            this.txtCurrentQty.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCurrentQty.TabIndex = 279;
            this.txtCurrentQty.W_Clear = true;
            this.txtCurrentQty.W_ColArName = "اسم الفرع بالعربي";
            this.txtCurrentQty.W_ColEgName = "BRANCH_ANAME";
            this.txtCurrentQty.W_OldValue = "";
            this.txtCurrentQty.W_TableName = "BRANCHES";
            // 
            // myLabel8
            // 
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(341, 174);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel8.Size = new System.Drawing.Size(84, 18);
            this.myLabel8.TabIndex = 293;
            this.myLabel8.Text = "الكمية المطلوبة";
            // 
            // nmbQty
            // 
            this.nmbQty.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbQty.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.nmbQty.DecimalPlaces = 0;
            this.nmbQty.DoubleValue = 0D;
            this.nmbQty.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbQty.Location = new System.Drawing.Point(436, 169);
            this.nmbQty.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbQty.MinValue = 0D;
            this.nmbQty.Name = "nmbQty";
            this.nmbQty.NullString = "";
            this.nmbQty.NumberDecimalDigits = 0;
            this.nmbQty.Size = new System.Drawing.Size(90, 23);
            this.nmbQty.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbQty.TabIndex = 294;
            this.nmbQty.Text = "0";
            this.nmbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbQty.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbQty.W_Clear = true;
            this.nmbQty.W_ColArName = "";
            this.nmbQty.W_ColEgName = "";
            this.nmbQty.W_OldValue = "";
            this.nmbQty.W_TableName = "";
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
            this.btnAdd.Location = new System.Drawing.Point(532, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 23);
            this.btnAdd.TabIndex = 295;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgREQUESTS_PURCHASES
            // 
            this.dgREQUESTS_PURCHASES.AllowUserToAddRows = false;
            this.dgREQUESTS_PURCHASES.AllowUserToDeleteRows = false;
            this.dgREQUESTS_PURCHASES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgREQUESTS_PURCHASES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgREQUESTS_PURCHASES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgREQUESTS_PURCHASES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column7,
            this.Column4,
            this.Column6});
            this.dgREQUESTS_PURCHASES.EnableHeadersVisualStyles = false;
            this.dgREQUESTS_PURCHASES.Location = new System.Drawing.Point(7, 195);
            this.dgREQUESTS_PURCHASES.Name = "dgREQUESTS_PURCHASES";
            this.dgREQUESTS_PURCHASES.RowHeadersVisible = false;
            this.dgREQUESTS_PURCHASES.Size = new System.Drawing.Size(585, 292);
            this.dgREQUESTS_PURCHASES.TabIndex = 298;
            this.dgREQUESTS_PURCHASES.W_Clear = true;
            // 
            // myLabel12
            // 
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(203, 171);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(80, 18);
            this.myLabel12.TabIndex = 304;
            this.myLabel12.Text = "الكمية المعتمدة";
            // 
            // txtAcceptQty
            // 
            this.txtAcceptQty.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtAcceptQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcceptQty.Enabled = false;
            this.txtAcceptQty.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAcceptQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAcceptQty.Location = new System.Drawing.Point(286, 169);
            this.txtAcceptQty.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAcceptQty.Name = "txtAcceptQty";
            this.txtAcceptQty.Size = new System.Drawing.Size(56, 23);
            this.txtAcceptQty.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAcceptQty.TabIndex = 305;
            this.txtAcceptQty.W_Clear = true;
            this.txtAcceptQty.W_ColArName = "اسم الفرع بالعربي";
            this.txtAcceptQty.W_ColEgName = "BRANCH_ANAME";
            this.txtAcceptQty.W_OldValue = "";
            this.txtAcceptQty.W_TableName = "BRANCHES";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BeforeTouchSize = new System.Drawing.Size(30, 23);
            this.txtCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCustomerId.Location = new System.Drawing.Point(109, 32);
            this.txtCustomerId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(30, 23);
            this.txtCustomerId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCustomerId.TabIndex = 320;
            this.txtCustomerId.Visible = false;
            this.txtCustomerId.W_Clear = true;
            this.txtCustomerId.W_ColArName = "";
            this.txtCustomerId.W_ColEgName = "";
            this.txtCustomerId.W_OldValue = "";
            this.txtCustomerId.W_TableName = "";
            // 
            // column1
            // 
            this.column1.HeaderText = "swid";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            this.column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item_id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم الصنف";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "contact_id";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "اسم الزبون";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الكمية المطلوبة";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "حذف";
            this.Column6.Image = ((System.Drawing.Image)(resources.GetObject("Column6.Image")));
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 60;
            // 
            // frmPurchaseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 491);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtAcceptQty);
            this.Controls.Add(this.myLabel12);
            this.Controls.Add(this.dgREQUESTS_PURCHASES);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nmbQty);
            this.Controls.Add(this.myLabel8);
            this.Controls.Add(this.txtCurrentQty);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.btnGetCustomer);
            this.Controls.Add(this.txtCUSTOMER_ACCID);
            this.Controls.Add(this.txtCONTACT_ID);
            this.Controls.Add(this.btnFindContact);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.gbItems);
            this.Name = "frmPurchaseRequest";
            this.Text = "frmPurchaseRequest";
            this.Titel = "طلبات الفرع";
            this.Load += new System.EventHandler(this.frmPurchaseRequest_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.gbItems, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.txtContactName, 0);
            this.Controls.SetChildIndex(this.btnFindContact, 0);
            this.Controls.SetChildIndex(this.txtCONTACT_ID, 0);
            this.Controls.SetChildIndex(this.txtCUSTOMER_ACCID, 0);
            this.Controls.SetChildIndex(this.btnGetCustomer, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.txtCurrentQty, 0);
            this.Controls.SetChildIndex(this.myLabel8, 0);
            this.Controls.SetChildIndex(this.nmbQty, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.dgREQUESTS_PURCHASES, 0);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.txtAcceptQty, 0);
            this.Controls.SetChildIndex(this.txtCustomerId, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONTACT_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCUSTOMER_ACCID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgREQUESTS_PURCHASES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myGroupBox gbItems;
        private myText txtItemId;
        private myText txtActivity;
        private myLabel myLabel11;
        private myLabel myLabel10;
        private myText txtCatagory;
        private myText txtItemName;
        private myLabel myLabel9;
        private myLabel myLabel3;
        private myText txtItemNo;
        private myBottun btnFindItem;
        private myLabel myLabel2;
        private myText txtCONTACT_ID;
        private myBottun btnFindContact;
        private myText txtContactName;
        private myLabel myLabel5;
        private myText txtCUSTOMER_ACCID;
        private myBottun btnGetCustomer;
        private myLabel myLabel7;
        private myText txtCurrentQty;
        private myLabel myLabel8;
        private myNumber nmbQty;
        private myBottun btnAdd;
        private myDataGrid dgREQUESTS_PURCHASES;
        private myLabel myLabel12;
        private myText txtAcceptQty;
        private myText txtCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
    }
}