namespace ERP.Inventory
{
    partial class frmItemTree
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemTree));
            this.tvItemsTree = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.myLabel8 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.txtCATEGORY_NAME = new ERP.myText();
            this.lstCATEGORY_CLASS = new ERP.myList();
            this.myLabel3 = new ERP.myLabel();
            this.lstPARENT_ID = new ERP.myList();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.lstPROPERTY_ID = new ERP.myList();
            this.lstCAT_PRO_VALUE_TYPE = new ERP.myList();
            this.dgvProperties = new ERP.myDataGrid();
            this.btnAddCategory = new ERP.myBottun();
            this.btnAddProp = new ERP.myBottun();
            this.lblCurrentCategoryId = new ERP.myLabel();
            this.myBottun1 = new ERP.myBottun();
            this.myLabel6 = new ERP.myLabel();
            this.txtCode = new ERP.myText();
            this.btnDelete = new ERP.myBottun();
            this.myLabel7 = new ERP.myLabel();
            this.nmbSORT_INDEX = new ERP.myNumber();
            this.nmbEditor = new ERP.myNumber();
            this.clmPropSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvItemsTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCATEGORY_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSORT_INDEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(276, 34);
            // 
            // tvItemsTree
            // 
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            treeNodeAdvStyleInfo1.ShowCheckBox = false;
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            this.tvItemsTree.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.tvItemsTree.BeforeTouchSize = new System.Drawing.Size(312, 314);
            this.tvItemsTree.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.tvItemsTree.ForeColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tvItemsTree.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.tvItemsTree.HelpTextControl.Name = "helpText";
            this.tvItemsTree.HelpTextControl.TabIndex = 0;
            this.tvItemsTree.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.tvItemsTree.Location = new System.Drawing.Point(8, 152);
            this.tvItemsTree.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tvItemsTree.Name = "tvItemsTree";
            this.tvItemsTree.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tvItemsTree.Size = new System.Drawing.Size(312, 314);
            this.tvItemsTree.TabIndex = 6;
            // 
            // 
            // 
            this.tvItemsTree.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.tvItemsTree.ToolTipControl.Name = "toolTip";
            this.tvItemsTree.ToolTipControl.TabIndex = 1;
            this.tvItemsTree.NodeMouseClick += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvMouseClickArgs(this.tvItemsTree_NodeMouseClick);
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = false;
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(19, 47);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel8.Size = new System.Drawing.Size(75, 18);
            this.myLabel8.TabIndex = 250;
            this.myLabel8.Text = "اسم التصنيف";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(8, 70);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(91, 18);
            this.myLabel2.TabIndex = 251;
            this.myLabel2.Text = "مستوى التصنيف";
            // 
            // txtCATEGORY_NAME
            // 
            this.txtCATEGORY_NAME.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.txtCATEGORY_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCATEGORY_NAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCATEGORY_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCATEGORY_NAME.Location = new System.Drawing.Point(100, 42);
            this.txtCATEGORY_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCATEGORY_NAME.Name = "txtCATEGORY_NAME";
            this.txtCATEGORY_NAME.Size = new System.Drawing.Size(168, 23);
            this.txtCATEGORY_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCATEGORY_NAME.TabIndex = 252;
            this.txtCATEGORY_NAME.W_Clear = true;
            this.txtCATEGORY_NAME.W_ColArName = "";
            this.txtCATEGORY_NAME.W_ColEgName = "";
            this.txtCATEGORY_NAME.W_OldValue = "";
            this.txtCATEGORY_NAME.W_TableName = "";
            // 
            // lstCATEGORY_CLASS
            // 
            this.lstCATEGORY_CLASS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCATEGORY_CLASS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCATEGORY_CLASS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCATEGORY_CLASS.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCATEGORY_CLASS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCATEGORY_CLASS.FormattingEnabled = true;
            this.lstCATEGORY_CLASS.Items.AddRange(new object[] {
            "رئيسي",
            "فرعي"});
            this.lstCATEGORY_CLASS.Location = new System.Drawing.Point(100, 70);
            this.lstCATEGORY_CLASS.Name = "lstCATEGORY_CLASS";
            this.lstCATEGORY_CLASS.Size = new System.Drawing.Size(168, 24);
            this.lstCATEGORY_CLASS.TabIndex = 253;
            this.lstCATEGORY_CLASS.W_Clear = true;
            this.lstCATEGORY_CLASS.W_ColArName = "";
            this.lstCATEGORY_CLASS.W_ColEgName = "";
            this.lstCATEGORY_CLASS.W_OldValue = "";
            this.lstCATEGORY_CLASS.W_TableName = "";
            this.lstCATEGORY_CLASS.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstCATEGORY_CLASS.SelectedIndexChanged += new System.EventHandler(this.lstCATEGORY_CLASS_SelectedIndexChanged);
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = false;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(43, 101);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(42, 18);
            this.myLabel3.TabIndex = 254;
            this.myLabel3.Text = "الأب";
            // 
            // lstPARENT_ID
            // 
            this.lstPARENT_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstPARENT_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstPARENT_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstPARENT_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstPARENT_ID.FormattingEnabled = true;
            this.lstPARENT_ID.Location = new System.Drawing.Point(100, 100);
            this.lstPARENT_ID.Name = "lstPARENT_ID";
            this.lstPARENT_ID.Size = new System.Drawing.Size(168, 24);
            this.lstPARENT_ID.TabIndex = 255;
            this.lstPARENT_ID.W_Clear = true;
            this.lstPARENT_ID.W_ColArName = "";
            this.lstPARENT_ID.W_ColEgName = "";
            this.lstPARENT_ID.W_OldValue = "";
            this.lstPARENT_ID.W_TableName = "";
            this.lstPARENT_ID.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(433, 46);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(60, 18);
            this.myLabel4.TabIndex = 256;
            this.myLabel4.Text = "الخاصية";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = false;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(413, 76);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(80, 18);
            this.myLabel5.TabIndex = 257;
            this.myLabel5.Text = "نوع الخاصية";
            // 
            // lstPROPERTY_ID
            // 
            this.lstPROPERTY_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstPROPERTY_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstPROPERTY_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstPROPERTY_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstPROPERTY_ID.FormattingEnabled = true;
            this.lstPROPERTY_ID.Location = new System.Drawing.Point(491, 41);
            this.lstPROPERTY_ID.Name = "lstPROPERTY_ID";
            this.lstPROPERTY_ID.Size = new System.Drawing.Size(131, 24);
            this.lstPROPERTY_ID.TabIndex = 258;
            this.lstPROPERTY_ID.W_Clear = true;
            this.lstPROPERTY_ID.W_ColArName = "";
            this.lstPROPERTY_ID.W_ColEgName = "";
            this.lstPROPERTY_ID.W_OldValue = "";
            this.lstPROPERTY_ID.W_TableName = "";
            this.lstPROPERTY_ID.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // lstCAT_PRO_VALUE_TYPE
            // 
            this.lstCAT_PRO_VALUE_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCAT_PRO_VALUE_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCAT_PRO_VALUE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCAT_PRO_VALUE_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstCAT_PRO_VALUE_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstCAT_PRO_VALUE_TYPE.FormattingEnabled = true;
            this.lstCAT_PRO_VALUE_TYPE.Items.AddRange(new object[] {
            "قيمة نصية",
            "قائمة",
            "رقم",
            "تاريخ"});
            this.lstCAT_PRO_VALUE_TYPE.Location = new System.Drawing.Point(491, 70);
            this.lstCAT_PRO_VALUE_TYPE.Name = "lstCAT_PRO_VALUE_TYPE";
            this.lstCAT_PRO_VALUE_TYPE.Size = new System.Drawing.Size(131, 24);
            this.lstCAT_PRO_VALUE_TYPE.TabIndex = 259;
            this.lstCAT_PRO_VALUE_TYPE.W_Clear = true;
            this.lstCAT_PRO_VALUE_TYPE.W_ColArName = "";
            this.lstCAT_PRO_VALUE_TYPE.W_ColEgName = "";
            this.lstCAT_PRO_VALUE_TYPE.W_OldValue = "";
            this.lstCAT_PRO_VALUE_TYPE.W_TableName = "";
            this.lstCAT_PRO_VALUE_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // dgvProperties
            // 
            this.dgvProperties.AllowUserToAddRows = false;
            this.dgvProperties.AllowUserToDeleteRows = false;
            this.dgvProperties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProperties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPropSwid,
            this.Column1,
            this.Column2,
            this.clmOrder,
            this.Column4,
            this.clmDelete});
            this.dgvProperties.EnableHeadersVisualStyles = false;
            this.dgvProperties.Location = new System.Drawing.Point(322, 152);
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProperties.RowHeadersVisible = false;
            this.dgvProperties.Size = new System.Drawing.Size(395, 314);
            this.dgvProperties.TabIndex = 260;
            this.dgvProperties.W_Clear = true;
            this.dgvProperties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProperties_CellClick);
            this.dgvProperties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProperties_CellContentClick);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
            this.btnAddCategory.BeforeTouchSize = new System.Drawing.Size(36, 25);
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.IsBackStageButton = false;
            this.btnAddCategory.Location = new System.Drawing.Point(237, 126);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(36, 25);
            this.btnAddCategory.TabIndex = 261;
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAddCategory.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddProp
            // 
            this.btnAddProp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProp.BackgroundImage")));
            this.btnAddProp.BeforeTouchSize = new System.Drawing.Size(36, 25);
            this.btnAddProp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddProp.FlatAppearance.BorderSize = 0;
            this.btnAddProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddProp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAddProp.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProp.Image")));
            this.btnAddProp.IsBackStageButton = false;
            this.btnAddProp.Location = new System.Drawing.Point(623, 96);
            this.btnAddProp.Name = "btnAddProp";
            this.btnAddProp.Size = new System.Drawing.Size(36, 25);
            this.btnAddProp.TabIndex = 262;
            this.btnAddProp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProp.UseVisualStyleBackColor = true;
            this.btnAddProp.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAddProp.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAddProp.Click += new System.EventHandler(this.btnAddProp_Click);
            // 
            // lblCurrentCategoryId
            // 
            this.lblCurrentCategoryId.AutoSize = false;
            this.lblCurrentCategoryId.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentCategoryId.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCurrentCategoryId.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentCategoryId.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentCategoryId.Location = new System.Drawing.Point(413, 106);
            this.lblCurrentCategoryId.Name = "lblCurrentCategoryId";
            this.lblCurrentCategoryId.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.lblCurrentCategoryId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentCategoryId.Size = new System.Drawing.Size(209, 18);
            this.lblCurrentCategoryId.TabIndex = 263;
            this.lblCurrentCategoryId.Visible = false;
            this.lblCurrentCategoryId.Click += new System.EventHandler(this.lblCurrentCategoryId_Click);
            // 
            // myBottun1
            // 
            this.myBottun1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myBottun1.BackgroundImage")));
            this.myBottun1.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.myBottun1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myBottun1.FlatAppearance.BorderSize = 0;
            this.myBottun1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBottun1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.myBottun1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myBottun1.Image = ((System.Drawing.Image)(resources.GetObject("myBottun1.Image")));
            this.myBottun1.IsBackStageButton = false;
            this.myBottun1.Location = new System.Drawing.Point(626, 41);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(28, 27);
            this.myBottun1.TabIndex = 292;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Search;
            this.myBottun1.Click += new System.EventHandler(this.myBottun1_Click);
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = false;
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(43, 124);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(42, 18);
            this.myLabel6.TabIndex = 293;
            this.myLabel6.Text = "الكود";
            // 
            // txtCode
            // 
            this.txtCode.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCode.Location = new System.Drawing.Point(100, 128);
            this.txtCode.MaxLength = 3;
            this.txtCode.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(126, 23);
            this.txtCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCode.TabIndex = 294;
            this.txtCode.W_Clear = true;
            this.txtCode.W_ColArName = "";
            this.txtCode.W_ColEgName = "";
            this.txtCode.W_OldValue = "";
            this.txtCode.W_TableName = "";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ERP.Properties.Resources.S43Qy;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BeforeTouchSize = new System.Drawing.Size(36, 25);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnDelete.IsBackStageButton = false;
            this.btnDelete.Location = new System.Drawing.Point(274, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 25);
            this.btnDelete.TabIndex = 295;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnDelete.w_Type = ERP.myBottun.Btton_type.none;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = false;
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(413, 100);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(80, 18);
            this.myLabel7.TabIndex = 296;
            this.myLabel7.Text = "ترتيب التسمية";
            // 
            // nmbSORT_INDEX
            // 
            this.nmbSORT_INDEX.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbSORT_INDEX.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.nmbSORT_INDEX.DecimalPlaces = 0;
            this.nmbSORT_INDEX.DoubleValue = 0D;
            this.nmbSORT_INDEX.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbSORT_INDEX.Location = new System.Drawing.Point(491, 97);
            this.nmbSORT_INDEX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbSORT_INDEX.MinValue = 0D;
            this.nmbSORT_INDEX.Name = "nmbSORT_INDEX";
            this.nmbSORT_INDEX.NullString = "";
            this.nmbSORT_INDEX.NumberDecimalDigits = 0;
            this.nmbSORT_INDEX.Size = new System.Drawing.Size(131, 23);
            this.nmbSORT_INDEX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbSORT_INDEX.TabIndex = 297;
            this.nmbSORT_INDEX.Text = "0";
            this.nmbSORT_INDEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbSORT_INDEX.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbSORT_INDEX.W_Clear = true;
            this.nmbSORT_INDEX.W_ColArName = "";
            this.nmbSORT_INDEX.W_ColEgName = "";
            this.nmbSORT_INDEX.W_OldValue = "";
            this.nmbSORT_INDEX.W_TableName = "";
            // 
            // nmbEditor
            // 
            this.nmbEditor.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbEditor.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.nmbEditor.DecimalPlaces = 0;
            this.nmbEditor.DoubleValue = 0D;
            this.nmbEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbEditor.Location = new System.Drawing.Point(433, 223);
            this.nmbEditor.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbEditor.MinValue = 0D;
            this.nmbEditor.Name = "nmbEditor";
            this.nmbEditor.NullString = "";
            this.nmbEditor.NumberDecimalDigits = 0;
            this.nmbEditor.Size = new System.Drawing.Size(121, 23);
            this.nmbEditor.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbEditor.TabIndex = 433;
            this.nmbEditor.Text = "0";
            this.nmbEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbEditor.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbEditor.Visible = false;
            this.nmbEditor.W_Clear = true;
            this.nmbEditor.W_ColArName = "";
            this.nmbEditor.W_ColEgName = "";
            this.nmbEditor.W_OldValue = "";
            this.nmbEditor.W_TableName = "";
            this.nmbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbEditor_KeyDown);
            this.nmbEditor.Leave += new System.EventHandler(this.nmbEditor_Leave);
            this.nmbEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nmbEditor_MouseDown);
            // 
            // clmPropSwid
            // 
            this.clmPropSwid.HeaderText = "swid";
            this.clmPropSwid.Name = "clmPropSwid";
            this.clmPropSwid.ReadOnly = true;
            this.clmPropSwid.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الخاصية";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "نوع الخاصية";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // clmOrder
            // 
            this.clmOrder.HeaderText = "الترتيب";
            this.clmOrder.Name = "clmOrder";
            this.clmOrder.ReadOnly = true;
            this.clmOrder.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "عرض";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "حذف";
            this.clmDelete.Image = global::ERP.Properties.Resources.GridDelete;
            this.clmDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDelete.Width = 50;
            // 
            // frmItemTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(721, 478);
            this.Controls.Add(this.nmbEditor);
            this.Controls.Add(this.nmbSORT_INDEX);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.lblCurrentCategoryId);
            this.Controls.Add(this.btnAddProp);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dgvProperties);
            this.Controls.Add(this.lstCAT_PRO_VALUE_TYPE);
            this.Controls.Add(this.lstPROPERTY_ID);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.lstPARENT_ID);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.lstCATEGORY_CLASS);
            this.Controls.Add(this.txtCATEGORY_NAME);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel8);
            this.Controls.Add(this.tvItemsTree);
            this.Name = "frmItemTree";
            this.Titel = "شجرة الاصناف";
            this.Load += new System.EventHandler(this.frmItemTree_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.tvItemsTree, 0);
            this.Controls.SetChildIndex(this.myLabel8, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtCATEGORY_NAME, 0);
            this.Controls.SetChildIndex(this.lstCATEGORY_CLASS, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.lstPARENT_ID, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.lstPROPERTY_ID, 0);
            this.Controls.SetChildIndex(this.lstCAT_PRO_VALUE_TYPE, 0);
            this.Controls.SetChildIndex(this.dgvProperties, 0);
            this.Controls.SetChildIndex(this.btnAddCategory, 0);
            this.Controls.SetChildIndex(this.btnAddProp, 0);
            this.Controls.SetChildIndex(this.lblCurrentCategoryId, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.nmbSORT_INDEX, 0);
            this.Controls.SetChildIndex(this.nmbEditor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvItemsTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCATEGORY_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSORT_INDEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TreeViewAdv tvItemsTree;
        private ERP.myLabel myLabel8;
        private ERP.myLabel myLabel2;
        private ERP.myText txtCATEGORY_NAME;
        private ERP.myList lstCATEGORY_CLASS;
        private ERP.myLabel myLabel3;
        private ERP.myList lstPARENT_ID;
        private ERP.myLabel myLabel4;
        private ERP.myLabel myLabel5;
        private ERP.myList lstPROPERTY_ID;
        private ERP.myList lstCAT_PRO_VALUE_TYPE;
        private ERP.myDataGrid dgvProperties;
        private ERP.myBottun btnAddCategory;
        private ERP.myBottun btnAddProp;
        private ERP.myLabel lblCurrentCategoryId;
        private ERP.myBottun myBottun1;
        private myLabel myLabel6;
        private myText txtCode;
        private myBottun btnDelete;
        private myLabel myLabel7;
        private myNumber nmbSORT_INDEX;
        private myNumber nmbEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPropSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrder;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}
