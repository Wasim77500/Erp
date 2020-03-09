namespace ERP.File
{
    partial class frmTempletManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTempletManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFind = new ERP.myBottun();
            this.lstFORM_TYPE = new ERP.myList();
            this.txtAR_NAME = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.dgForms = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myLabel7 = new ERP.myLabel();
            this.dgProperities = new ERP.myDataGrid();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.myLabel2 = new ERP.myLabel();
            this.txtFormName = new ERP.myText();
            this.lstEditor = new ERP.myList();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSWID = new ERP.myText();
            this.lstMultiEditor = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAR_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(334, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(247, 34);
            // 
            // btnFind
            // 
            this.btnFind.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.IsBackStageButton = false;
            this.btnFind.Location = new System.Drawing.Point(436, 33);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 275;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstFORM_TYPE
            // 
            this.lstFORM_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstFORM_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstFORM_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstFORM_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstFORM_TYPE.FormattingEnabled = true;
            this.lstFORM_TYPE.Location = new System.Drawing.Point(324, 33);
            this.lstFORM_TYPE.Name = "lstFORM_TYPE";
            this.lstFORM_TYPE.Size = new System.Drawing.Size(107, 24);
            this.lstFORM_TYPE.TabIndex = 274;
            this.lstFORM_TYPE.W_Clear = false;
            this.lstFORM_TYPE.W_ColArName = "";
            this.lstFORM_TYPE.W_ColEgName = "";
            this.lstFORM_TYPE.W_OldValue = "";
            this.lstFORM_TYPE.W_TableName = "";
            this.lstFORM_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // txtAR_NAME
            // 
            this.txtAR_NAME.BeforeTouchSize = new System.Drawing.Size(39, 25);
            this.txtAR_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAR_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAR_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAR_NAME.Location = new System.Drawing.Point(119, 33);
            this.txtAR_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAR_NAME.Name = "txtAR_NAME";
            this.txtAR_NAME.Size = new System.Drawing.Size(107, 25);
            this.txtAR_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAR_NAME.TabIndex = 272;
            this.txtAR_NAME.W_Clear = true;
            this.txtAR_NAME.W_ColArName = "";
            this.txtAR_NAME.W_ColEgName = "";
            this.txtAR_NAME.W_OldValue = "";
            this.txtAR_NAME.W_TableName = "";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Gap = 0;
            this.myLabel4.Location = new System.Drawing.Point(234, 36);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(84, 18);
            this.myLabel4.TabIndex = 271;
            this.myLabel4.Text = "نوع البرنامج";
            // 
            // dgForms
            // 
            this.dgForms.AllowUserToAddRows = false;
            this.dgForms.AllowUserToDeleteRows = false;
            this.dgForms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgForms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column14,
            this.Column15});
            this.dgForms.EnableHeadersVisualStyles = false;
            this.dgForms.Location = new System.Drawing.Point(10, 87);
            this.dgForms.Name = "dgForms";
            this.dgForms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgForms.RowHeadersVisible = false;
            this.dgForms.Size = new System.Drawing.Size(456, 398);
            this.dgForms.TabIndex = 268;
            this.dgForms.W_Clear = true;
            this.dgForms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgForms_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "swid";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم الشاشة";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الشاشة في البرنامج";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "نوع البرنامج";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "البرنامج الفرعي";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "النماذج";
            this.Column14.Name = "Column14";
            this.Column14.Width = 70;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "MULTI_FORM_FOR_USER";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = false;
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Gap = 0;
            this.myLabel7.Location = new System.Drawing.Point(5, 33);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(108, 18);
            this.myLabel7.TabIndex = 277;
            this.myLabel7.Text = "اسم الشاشة(عربي)";
            // 
            // dgProperities
            // 
            this.dgProperities.AllowUserToAddRows = false;
            this.dgProperities.AllowUserToDeleteRows = false;
            this.dgProperities.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProperities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProperities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProperities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgProperities.EnableHeadersVisualStyles = false;
            this.dgProperities.Location = new System.Drawing.Point(472, 87);
            this.dgProperities.Name = "dgProperities";
            this.dgProperities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgProperities.RowHeadersVisible = false;
            this.dgProperities.Size = new System.Drawing.Size(352, 351);
            this.dgProperities.TabIndex = 278;
            this.dgProperities.W_Clear = true;
            this.dgProperities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProperities_CellClick);
            this.dgProperities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProperities_CellClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "swid";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 5;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "اسم الخاصية";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "القيــمــة";
            this.Column8.Name = "Column8";
            this.Column8.Width = 180;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "control_type";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "list_id";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "free_list_name";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "en_name";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "القيمة الفعلية";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
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
            this.btnExit.Location = new System.Drawing.Point(767, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 280;
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
            this.btnSave.Location = new System.Drawing.Point(709, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 279;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Gap = 0;
            this.myLabel2.Location = new System.Drawing.Point(485, 38);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(108, 18);
            this.myLabel2.TabIndex = 283;
            this.myLabel2.Text = "اسم النموذج";
            // 
            // txtFormName
            // 
            this.txtFormName.BeforeTouchSize = new System.Drawing.Size(39, 25);
            this.txtFormName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtFormName.Location = new System.Drawing.Point(593, 36);
            this.txtFormName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(185, 25);
            this.txtFormName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFormName.TabIndex = 284;
            this.txtFormName.W_Clear = true;
            this.txtFormName.W_ColArName = "";
            this.txtFormName.W_ColEgName = "";
            this.txtFormName.W_OldValue = "";
            this.txtFormName.W_TableName = "";
            // 
            // lstEditor
            // 
            this.lstEditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstEditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstEditor.FormattingEnabled = true;
            this.lstEditor.Location = new System.Drawing.Point(96, 445);
            this.lstEditor.Name = "lstEditor";
            this.lstEditor.Size = new System.Drawing.Size(121, 24);
            this.lstEditor.TabIndex = 285;
            this.lstEditor.Visible = false;
            this.lstEditor.W_Clear = true;
            this.lstEditor.W_ColArName = "";
            this.lstEditor.W_ColEgName = "";
            this.lstEditor.W_OldValue = "";
            this.lstEditor.W_TableName = "";
            this.lstEditor.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEditor_KeyDown);
            this.lstEditor.Leave += new System.EventHandler(this.lstEditor_Leave);
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(39, 25);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(784, 36);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(39, 25);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 286;
            this.txtSWID.Visible = false;
            this.txtSWID.W_Clear = true;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // lstMultiEditor
            // 
            this.lstMultiEditor.BackColor = System.Drawing.SystemColors.Window;
            this.lstMultiEditor.CheckOnClick = true;
            this.lstMultiEditor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstMultiEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstMultiEditor.Location = new System.Drawing.Point(269, 384);
            this.lstMultiEditor.Name = "lstMultiEditor";
            this.lstMultiEditor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstMultiEditor.Size = new System.Drawing.Size(104, 94);
            this.lstMultiEditor.TabIndex = 287;
            this.lstMultiEditor.ThreeDCheckBoxes = true;
            this.lstMultiEditor.Visible = false;
            this.lstMultiEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMultiEditor_KeyDown);
            this.lstMultiEditor.Leave += new System.EventHandler(this.lstMultiEditor_Leave);
            // 
            // frmTempletManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(836, 490);
            this.Controls.Add(this.lstMultiEditor);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.lstEditor);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgProperities);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lstFORM_TYPE);
            this.Controls.Add(this.txtAR_NAME);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.dgForms);
            this.Name = "frmTempletManagement";
            this.Titel = "إدارة النماذج";
            this.Load += new System.EventHandler(this.frmTempletManagement_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.dgForms, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtAR_NAME, 0);
            this.Controls.SetChildIndex(this.lstFORM_TYPE, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.dgProperities, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtFormName, 0);
            this.Controls.SetChildIndex(this.lstEditor, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.lstMultiEditor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAR_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ERP.myBottun btnFind;
        private ERP.myList lstFORM_TYPE;
        private ERP.myText txtAR_NAME;
        private ERP.myLabel myLabel4;
        private ERP.myDataGrid dgForms;
        private ERP.myLabel myLabel7;
        private ERP.myDataGrid dgProperities;
        private ERP.myBottun btnExit;
        private ERP.myBottun btnSave;
        private ERP.myLabel myLabel2;
        private ERP.myText txtFormName;
        private ERP.myList lstEditor;
        private System.Windows.Forms.ErrorProvider errCheck;
        private ERP.myText txtSWID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.CheckedListBox lstMultiEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}
