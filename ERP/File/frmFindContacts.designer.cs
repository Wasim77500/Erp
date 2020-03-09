namespace ERP.File
{
    partial class frmFindContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindContacts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.txtAdb_name = new ERP.myText();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.btnFind = new ERP.myBottun();
            this.myLabel4 = new ERP.myLabel();
            this.txtCont_type = new ERP.myText();
            this.dgContactData = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.lstCONT_TYPE = new ERP.myList();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdb_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCont_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactData)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.lstCONT_TYPE);
            this.myGroupBox1.Controls.Add(this.txtCont_type);
            this.myGroupBox1.Controls.Add(this.myLabel4);
            this.myGroupBox1.Controls.Add(this.txtAdb_name);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(54, 27);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(346, 117);
            this.myGroupBox1.TabIndex = 138;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات التواصل";
            // 
            // txtAdb_name
            // 
            this.txtAdb_name.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtAdb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdb_name.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAdb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAdb_name.Location = new System.Drawing.Point(78, 20);
            this.txtAdb_name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAdb_name.Name = "txtAdb_name";
            this.txtAdb_name.Size = new System.Drawing.Size(163, 25);
            this.txtAdb_name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAdb_name.TabIndex = 135;
            this.txtAdb_name.W_ColArName = "اسم الموقع";
            this.txtAdb_name.W_ColEgName = "LOCATION_NAME";
            this.txtAdb_name.W_OldValue = "";
            this.txtAdb_name.W_TableName = "LOCATION";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(265, 26);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(33, 18);
            this.myLabel3.TabIndex = 123;
            this.myLabel3.Text = "الاسم";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(246, 58);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(73, 18);
            this.myLabel2.TabIndex = 130;
            this.myLabel2.Text = "نوع التواصل";
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
            this.btnFind.Location = new System.Drawing.Point(44, 76);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 1;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(261, 85);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(37, 18);
            this.myLabel4.TabIndex = 225;
            this.myLabel4.Text = "القيمة";
            // 
            // txtCont_type
            // 
            this.txtCont_type.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtCont_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCont_type.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCont_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCont_type.Location = new System.Drawing.Point(78, 78);
            this.txtCont_type.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCont_type.Name = "txtCont_type";
            this.txtCont_type.Size = new System.Drawing.Size(163, 25);
            this.txtCont_type.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCont_type.TabIndex = 226;
            this.txtCont_type.W_ColArName = "اسم الموقع";
            this.txtCont_type.W_ColEgName = "LOCATION_NAME";
            this.txtCont_type.W_OldValue = "";
            this.txtCont_type.W_TableName = "LOCATION";
            // 
            // dgContactData
            // 
            this.dgContactData.AllowUserToAddRows = false;
            this.dgContactData.AllowUserToDeleteRows = false;
            this.dgContactData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgContactData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgContactData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContactData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgContactData.EnableHeadersVisualStyles = false;
            this.dgContactData.Location = new System.Drawing.Point(8, 150);
            this.dgContactData.Name = "dgContactData";
            this.dgContactData.RowHeadersVisible = false;
            this.dgContactData.Size = new System.Drawing.Size(414, 218);
            this.dgContactData.TabIndex = 139;
            this.dgContactData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContactData_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "swid";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "الاســـم";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "وصف التواصل";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "نوع التواصل";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "القيمة";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.IsBackStageButton = false;
            this.btnOk.Location = new System.Drawing.Point(304, 376);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 142;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnOk.w_Type = ERP.myBottun.Btton_type.OK;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // myBottun1
            // 
            this.myBottun1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myBottun1.BackgroundImage")));
            this.myBottun1.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.myBottun1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myBottun1.FlatAppearance.BorderSize = 0;
            this.myBottun1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBottun1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.myBottun1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myBottun1.Image = ((System.Drawing.Image)(resources.GetObject("myBottun1.Image")));
            this.myBottun1.IsBackStageButton = false;
            this.myBottun1.Location = new System.Drawing.Point(364, 376);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 141;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
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
            this.lstCONT_TYPE.Location = new System.Drawing.Point(78, 50);
            this.lstCONT_TYPE.Name = "lstCONT_TYPE";
            this.lstCONT_TYPE.Size = new System.Drawing.Size(163, 24);
            this.lstCONT_TYPE.TabIndex = 227;
            this.lstCONT_TYPE.W_ColArName = "";
            this.lstCONT_TYPE.W_ColEgName = "";
            this.lstCONT_TYPE.W_OldValue = "";
            this.lstCONT_TYPE.W_TableName = "";
            this.lstCONT_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // frmFindContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(426, 411);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgContactData);
            this.Controls.Add(this.myGroupBox1);
            this.Name = "frmFindContacts";
            this.Titel = "البحث عن العناوين وبيانات التواصل";
            this.Load += new System.EventHandler(this.frmFindContacts_Load);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgContactData, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdb_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCont_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ERP.myGroupBox myGroupBox1;
        private ERP.myText txtCont_type;
        private ERP.myLabel myLabel4;
        private ERP.myText txtAdb_name;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel2;
        private ERP.myBottun btnFind;
        private ERP.myDataGrid dgContactData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private ERP.myBottun btnOk;
        private ERP.myBottun myBottun1;
        private ERP.myList lstCONT_TYPE;
    }
}
