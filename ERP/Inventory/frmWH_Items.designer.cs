namespace ERP.Inventory
{
    partial class frmWH_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWH_Items));
            this.txtWareouseNo = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.txtItemNo = new ERP.myText();
            this.btnFindItem = new ERP.myBottun();
            this.btnFindWarehouse = new ERP.myBottun();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.nmbHIGHEST_QTY = new ERP.myNumber();
            this.nmbMINIMAL_QTY = new ERP.myNumber();
            this.btnNew = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.txtSwid = new ERP.myText();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.txtWarehouseId = new ERP.myText();
            this.myLabel8 = new ERP.myLabel();
            this.txtW_Branch = new ERP.myText();
            this.txtW_Descreption = new ERP.myText();
            this.myLabel7 = new ERP.myLabel();
            this.txtW_NAME = new ERP.myText();
            this.myLabel6 = new ERP.myLabel();
            this.myGroupBox2 = new ERP.myGroupBox();
            this.txtItemId = new ERP.myText();
            this.txtActivity = new ERP.myText();
            this.myLabel11 = new ERP.myLabel();
            this.myLabel10 = new ERP.myLabel();
            this.txtCatagory = new ERP.myText();
            this.txtItemName = new ERP.myText();
            this.myLabel9 = new ERP.myLabel();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareouseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbHIGHEST_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMINIMAL_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW_Branch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW_Descreption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW_NAME)).BeginInit();
            this.myGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(175, 33);
            // 
            // txtWareouseNo
            // 
            this.txtWareouseNo.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.txtWareouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWareouseNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtWareouseNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtWareouseNo.Location = new System.Drawing.Point(277, 26);
            this.txtWareouseNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtWareouseNo.Name = "txtWareouseNo";
            this.txtWareouseNo.Size = new System.Drawing.Size(147, 23);
            this.txtWareouseNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtWareouseNo.TabIndex = 214;
            this.txtWareouseNo.W_Clear = true;
            this.txtWareouseNo.W_ColArName = "اسم الفرع بالعربي";
            this.txtWareouseNo.W_ColEgName = "BRANCH_ANAME";
            this.txtWareouseNo.W_OldValue = "";
            this.txtWareouseNo.W_TableName = "BRANCHES";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(430, 26);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(64, 18);
            this.myLabel2.TabIndex = 213;
            this.myLabel2.Text = "رقم المخزن";
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
            this.txtItemNo.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtItemNo.Location = new System.Drawing.Point(277, 21);
            this.txtItemNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(147, 23);
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
            this.btnFindItem.Location = new System.Drawing.Point(244, 17);
            this.btnFindItem.Name = "btnFindItem";
            this.btnFindItem.Size = new System.Drawing.Size(28, 27);
            this.btnFindItem.TabIndex = 247;
            this.btnFindItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindItem.UseVisualStyleBackColor = true;
            this.btnFindItem.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFindItem.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFindItem.Click += new System.EventHandler(this.btnFindItem_Click);
            // 
            // btnFindWarehouse
            // 
            this.btnFindWarehouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindWarehouse.BackgroundImage")));
            this.btnFindWarehouse.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFindWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindWarehouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindWarehouse.FlatAppearance.BorderSize = 0;
            this.btnFindWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindWarehouse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFindWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFindWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("btnFindWarehouse.Image")));
            this.btnFindWarehouse.IsBackStageButton = false;
            this.btnFindWarehouse.Location = new System.Drawing.Point(243, 26);
            this.btnFindWarehouse.Name = "btnFindWarehouse";
            this.btnFindWarehouse.Size = new System.Drawing.Size(28, 27);
            this.btnFindWarehouse.TabIndex = 248;
            this.btnFindWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindWarehouse.UseVisualStyleBackColor = true;
            this.btnFindWarehouse.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFindWarehouse.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFindWarehouse.Click += new System.EventHandler(this.myBottun1_Click);
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(13, 213);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(57, 18);
            this.myLabel4.TabIndex = 249;
            this.myLabel4.Text = "اعلى كمية";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(282, 215);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(49, 18);
            this.myLabel5.TabIndex = 250;
            this.myLabel5.Text = "اقل كمية";
            // 
            // nmbHIGHEST_QTY
            // 
            this.nmbHIGHEST_QTY.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbHIGHEST_QTY.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.nmbHIGHEST_QTY.DecimalPlaces = 0;
            this.nmbHIGHEST_QTY.DoubleValue = 0D;
            this.nmbHIGHEST_QTY.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbHIGHEST_QTY.Location = new System.Drawing.Point(81, 210);
            this.nmbHIGHEST_QTY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbHIGHEST_QTY.MinValue = 0D;
            this.nmbHIGHEST_QTY.Name = "nmbHIGHEST_QTY";
            this.nmbHIGHEST_QTY.NullString = "";
            this.nmbHIGHEST_QTY.NumberDecimalDigits = 0;
            this.nmbHIGHEST_QTY.Size = new System.Drawing.Size(181, 23);
            this.nmbHIGHEST_QTY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbHIGHEST_QTY.TabIndex = 251;
            this.nmbHIGHEST_QTY.Text = "0";
            this.nmbHIGHEST_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbHIGHEST_QTY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbHIGHEST_QTY.W_Clear = true;
            this.nmbHIGHEST_QTY.W_ColArName = "رقم الفرع";
            this.nmbHIGHEST_QTY.W_ColEgName = "BRANCH_No";
            this.nmbHIGHEST_QTY.W_OldValue = "";
            this.nmbHIGHEST_QTY.W_TableName = "BRANCHES";
            // 
            // nmbMINIMAL_QTY
            // 
            this.nmbMINIMAL_QTY.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbMINIMAL_QTY.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.nmbMINIMAL_QTY.DecimalPlaces = 0;
            this.nmbMINIMAL_QTY.DoubleValue = 0D;
            this.nmbMINIMAL_QTY.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbMINIMAL_QTY.Location = new System.Drawing.Point(344, 211);
            this.nmbMINIMAL_QTY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbMINIMAL_QTY.MinValue = 0D;
            this.nmbMINIMAL_QTY.Name = "nmbMINIMAL_QTY";
            this.nmbMINIMAL_QTY.NullString = "";
            this.nmbMINIMAL_QTY.NumberDecimalDigits = 0;
            this.nmbMINIMAL_QTY.Size = new System.Drawing.Size(156, 23);
            this.nmbMINIMAL_QTY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbMINIMAL_QTY.TabIndex = 252;
            this.nmbMINIMAL_QTY.Text = "0";
            this.nmbMINIMAL_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbMINIMAL_QTY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbMINIMAL_QTY.W_Clear = true;
            this.nmbMINIMAL_QTY.W_ColArName = "رقم الفرع";
            this.nmbMINIMAL_QTY.W_ColEgName = "BRANCH_No";
            this.nmbMINIMAL_QTY.W_OldValue = "";
            this.nmbMINIMAL_QTY.W_TableName = "BRANCHES";
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
            this.btnNew.Location = new System.Drawing.Point(145, 240);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 259;
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
            this.btnUpdate.Location = new System.Drawing.Point(266, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 258;
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
            this.btnExit.Location = new System.Drawing.Point(324, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 257;
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
            this.btnSave.Location = new System.Drawing.Point(208, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 256;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSwid
            // 
            this.txtSwid.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.txtSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSwid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSwid.Location = new System.Drawing.Point(438, 240);
            this.txtSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSwid.Name = "txtSwid";
            this.txtSwid.Size = new System.Drawing.Size(25, 23);
            this.txtSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSwid.TabIndex = 260;
            this.txtSwid.Visible = false;
            this.txtSwid.W_Clear = true;
            this.txtSwid.W_ColArName = "";
            this.txtSwid.W_ColEgName = "";
            this.txtSwid.W_OldValue = "";
            this.txtSwid.W_TableName = "";
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtWarehouseId);
            this.myGroupBox1.Controls.Add(this.myLabel8);
            this.myGroupBox1.Controls.Add(this.txtW_Branch);
            this.myGroupBox1.Controls.Add(this.txtW_Descreption);
            this.myGroupBox1.Controls.Add(this.myLabel7);
            this.myGroupBox1.Controls.Add(this.txtW_NAME);
            this.myGroupBox1.Controls.Add(this.myLabel6);
            this.myGroupBox1.Controls.Add(this.txtWareouseNo);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Controls.Add(this.btnFindWarehouse);
            this.myGroupBox1.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(5, 28);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(501, 89);
            this.myGroupBox1.TabIndex = 261;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "المخازن";
            // 
            // txtWarehouseId
            // 
            this.txtWarehouseId.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.txtWarehouseId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarehouseId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtWarehouseId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtWarehouseId.Location = new System.Drawing.Point(469, 31);
            this.txtWarehouseId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtWarehouseId.Name = "txtWarehouseId";
            this.txtWarehouseId.Size = new System.Drawing.Size(25, 23);
            this.txtWarehouseId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtWarehouseId.TabIndex = 274;
            this.txtWarehouseId.Visible = false;
            this.txtWarehouseId.W_Clear = true;
            this.txtWarehouseId.W_ColArName = "";
            this.txtWarehouseId.W_ColEgName = "";
            this.txtWarehouseId.W_OldValue = "";
            this.txtWarehouseId.W_TableName = "";
            // 
            // myLabel8
            // 
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(173, 60);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel8.Size = new System.Drawing.Size(41, 18);
            this.myLabel8.TabIndex = 273;
            this.myLabel8.Text = "الفــرع";
            // 
            // txtW_Branch
            // 
            this.txtW_Branch.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.txtW_Branch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtW_Branch.Font = new System.Drawing.Font("Arial", 10F);
            this.txtW_Branch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtW_Branch.Location = new System.Drawing.Point(6, 57);
            this.txtW_Branch.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtW_Branch.Name = "txtW_Branch";
            this.txtW_Branch.Size = new System.Drawing.Size(156, 23);
            this.txtW_Branch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtW_Branch.TabIndex = 272;
            this.txtW_Branch.W_Clear = true;
            this.txtW_Branch.W_ColArName = "اسم الفرع بالعربي";
            this.txtW_Branch.W_ColEgName = "BRANCH_ANAME";
            this.txtW_Branch.W_OldValue = "";
            this.txtW_Branch.W_TableName = "BRANCHES";
            // 
            // txtW_Descreption
            // 
            this.txtW_Descreption.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.txtW_Descreption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtW_Descreption.Font = new System.Drawing.Font("Arial", 10F);
            this.txtW_Descreption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtW_Descreption.Location = new System.Drawing.Point(243, 55);
            this.txtW_Descreption.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtW_Descreption.Name = "txtW_Descreption";
            this.txtW_Descreption.Size = new System.Drawing.Size(181, 23);
            this.txtW_Descreption.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtW_Descreption.TabIndex = 271;
            this.txtW_Descreption.W_Clear = true;
            this.txtW_Descreption.W_ColArName = "اسم الفرع بالعربي";
            this.txtW_Descreption.W_ColEgName = "BRANCH_ANAME";
            this.txtW_Descreption.W_OldValue = "";
            this.txtW_Descreption.W_TableName = "BRANCHES";
            // 
            // myLabel7
            // 
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(433, 57);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(46, 18);
            this.myLabel7.TabIndex = 270;
            this.myLabel7.Text = "الوصف";
            // 
            // txtW_NAME
            // 
            this.txtW_NAME.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.txtW_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtW_NAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtW_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtW_NAME.Location = new System.Drawing.Point(6, 26);
            this.txtW_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtW_NAME.Name = "txtW_NAME";
            this.txtW_NAME.Size = new System.Drawing.Size(156, 23);
            this.txtW_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtW_NAME.TabIndex = 269;
            this.txtW_NAME.W_Clear = true;
            this.txtW_NAME.W_ColArName = "اسم المخزن";
            this.txtW_NAME.W_ColEgName = "W_NAME";
            this.txtW_NAME.W_OldValue = "";
            this.txtW_NAME.W_TableName = "WAREHOUSE";
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(168, 29);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(66, 18);
            this.myLabel6.TabIndex = 268;
            this.myLabel6.Text = "اسم المخزن";
            // 
            // myGroupBox2
            // 
            this.myGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox2.Controls.Add(this.txtItemId);
            this.myGroupBox2.Controls.Add(this.txtActivity);
            this.myGroupBox2.Controls.Add(this.myLabel11);
            this.myGroupBox2.Controls.Add(this.myLabel10);
            this.myGroupBox2.Controls.Add(this.txtCatagory);
            this.myGroupBox2.Controls.Add(this.txtItemName);
            this.myGroupBox2.Controls.Add(this.myLabel9);
            this.myGroupBox2.Controls.Add(this.myLabel3);
            this.myGroupBox2.Controls.Add(this.txtItemNo);
            this.myGroupBox2.Controls.Add(this.btnFindItem);
            this.myGroupBox2.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox2.Location = new System.Drawing.Point(5, 123);
            this.myGroupBox2.Name = "myGroupBox2";
            this.myGroupBox2.Size = new System.Drawing.Size(501, 81);
            this.myGroupBox2.TabIndex = 262;
            this.myGroupBox2.TabStop = false;
            this.myGroupBox2.Text = "الأصنـاف";
            // 
            // txtItemId
            // 
            this.txtItemId.BeforeTouchSize = new System.Drawing.Size(156, 23);
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
            this.txtActivity.BeforeTouchSize = new System.Drawing.Size(156, 23);
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
            this.txtCatagory.BeforeTouchSize = new System.Drawing.Size(156, 23);
            this.txtCatagory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatagory.Enabled = false;
            this.txtCatagory.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCatagory.Location = new System.Drawing.Point(243, 50);
            this.txtCatagory.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.Size = new System.Drawing.Size(181, 23);
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
            this.txtItemName.BeforeTouchSize = new System.Drawing.Size(156, 23);
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
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // frmWH_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(518, 277);
            this.Controls.Add(this.myGroupBox2);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.txtSwid);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nmbMINIMAL_QTY);
            this.Controls.Add(this.nmbHIGHEST_QTY);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel4);
            this.Name = "frmWH_Items";
            this.Titel = "تعريف المخزون";
            this.Load += new System.EventHandler(this.frmWH_Items_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.nmbHIGHEST_QTY, 0);
            this.Controls.SetChildIndex(this.nmbMINIMAL_QTY, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.txtSwid, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.myGroupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareouseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbHIGHEST_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMINIMAL_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwid)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW_Branch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW_Descreption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW_NAME)).EndInit();
            this.myGroupBox2.ResumeLayout(false);
            this.myGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myText txtWareouseNo;
        private ERP.myLabel myLabel2;
        private ERP.myLabel myLabel3;
        private ERP.myText txtItemNo;
        private ERP.myBottun btnFindItem;
        private ERP.myBottun btnFindWarehouse;
        private ERP.myLabel myLabel4;
        private ERP.myLabel myLabel5;
        private ERP.myNumber nmbHIGHEST_QTY;
        private ERP.myNumber nmbMINIMAL_QTY;
        private ERP.myBottun btnNew;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnExit;
        private ERP.myBottun btnSave;
        private ERP.myText txtSwid;
        private ERP.myGroupBox myGroupBox1;
        private ERP.myText txtW_NAME;
        private ERP.myLabel myLabel6;
        private ERP.myLabel myLabel8;
        private ERP.myText txtW_Branch;
        private ERP.myText txtW_Descreption;
        private ERP.myLabel myLabel7;
        private ERP.myGroupBox myGroupBox2;
        private ERP.myLabel myLabel10;
        private ERP.myText txtCatagory;
        private ERP.myText txtItemName;
        private ERP.myLabel myLabel9;
        private ERP.myText txtActivity;
        private ERP.myLabel myLabel11;
        private ERP.myText txtWarehouseId;
        private ERP.myText txtItemId;
        private System.Windows.Forms.ErrorProvider errCheck;
    }
}
