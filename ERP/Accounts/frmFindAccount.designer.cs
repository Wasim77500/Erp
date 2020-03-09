namespace ERP.Accounts
{
    partial class frmFindAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFind = new ERP.myBottun();
            this.txtACC_NAME = new ERP.myText();
            this.lstACC_TYPE = new ERP.myList();
            this.txtACC_NO = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.dgAccData = new ERP.myDataGrid();
            this.btnOk = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccData)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(134, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(47, 34);
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
            this.btnFind.Location = new System.Drawing.Point(348, 93);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 225;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtACC_NAME
            // 
            this.txtACC_NAME.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_NAME.Location = new System.Drawing.Point(111, 63);
            this.txtACC_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_NAME.Name = "txtACC_NAME";
            this.txtACC_NAME.Size = new System.Drawing.Size(231, 25);
            this.txtACC_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_NAME.TabIndex = 231;
            this.txtACC_NAME.W_Clear = true;
            this.txtACC_NAME.W_ColArName = "اسم الحساب";
            this.txtACC_NAME.W_ColEgName = "ACC_NAME";
            this.txtACC_NAME.W_OldValue = "";
            this.txtACC_NAME.W_TableName = "ACCOUNTS";
            // 
            // lstACC_TYPE
            // 
            this.lstACC_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstACC_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstACC_TYPE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstACC_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstACC_TYPE.FormattingEnabled = true;
            this.lstACC_TYPE.Items.AddRange(new object[] {
            "أصول ثابته",
            "ايرادات",
            "بنوك",
            "دائنون أخرون",
            "شركاء",
            "صناديق",
            "عملاء",
            "مدينون أخرون",
            "مصاريف",
            "موردين",
            "موظفين"});
            this.lstACC_TYPE.Location = new System.Drawing.Point(111, 93);
            this.lstACC_TYPE.Name = "lstACC_TYPE";
            this.lstACC_TYPE.Size = new System.Drawing.Size(231, 26);
            this.lstACC_TYPE.Sorted = true;
            this.lstACC_TYPE.TabIndex = 230;
            this.lstACC_TYPE.W_Clear = true;
            this.lstACC_TYPE.W_ColArName = "نوع الحساب";
            this.lstACC_TYPE.W_ColEgName = "ACC_TYPE";
            this.lstACC_TYPE.W_OldValue = "";
            this.lstACC_TYPE.W_TableName = "ACCOUNTS";
            this.lstACC_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // txtACC_NO
            // 
            this.txtACC_NO.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_NO.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_NO.Location = new System.Drawing.Point(111, 33);
            this.txtACC_NO.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_NO.Name = "txtACC_NO";
            this.txtACC_NO.Size = new System.Drawing.Size(231, 25);
            this.txtACC_NO.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_NO.TabIndex = 229;
            this.txtACC_NO.W_Clear = true;
            this.txtACC_NO.W_ColArName = "غير مسموح بتغييره";
            this.txtACC_NO.W_ColEgName = "غير مسموح بتغييره";
            this.txtACC_NO.W_OldValue = "";
            this.txtACC_NO.W_TableName = "";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(7, 63);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(69, 18);
            this.myLabel4.TabIndex = 228;
            this.myLabel4.Text = "اسم الحساب";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(13, 93);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(70, 18);
            this.myLabel3.TabIndex = 227;
            this.myLabel3.Text = "نوع الحساب";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(16, 36);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(67, 18);
            this.myLabel2.TabIndex = 226;
            this.myLabel2.Text = "رقم الحساب";
            // 
            // dgAccData
            // 
            this.dgAccData.AllowUserToAddRows = false;
            this.dgAccData.AllowUserToDeleteRows = false;
            this.dgAccData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAccData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgAccData.EnableHeadersVisualStyles = false;
            this.dgAccData.Location = new System.Drawing.Point(6, 125);
            this.dgAccData.Name = "dgAccData";
            this.dgAccData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgAccData.RowHeadersVisible = false;
            this.dgAccData.Size = new System.Drawing.Size(426, 201);
            this.dgAccData.TabIndex = 232;
            this.dgAccData.W_Clear = true;
            this.dgAccData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccData_CellDoubleClick);
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
            this.btnOk.Location = new System.Drawing.Point(315, 332);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 234;
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
            this.myBottun1.Location = new System.Drawing.Point(375, 332);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 233;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم الحساب";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم الحساب";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "نوع الحساب";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "التابعية";
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // frmFindAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(436, 379);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgAccData);
            this.Controls.Add(this.txtACC_NAME);
            this.Controls.Add(this.lstACC_TYPE);
            this.Controls.Add(this.txtACC_NO);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.btnFind);
            this.Name = "frmFindAccount";
            this.Load += new System.EventHandler(this.frmFindAccount_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtACC_NO, 0);
            this.Controls.SetChildIndex(this.lstACC_TYPE, 0);
            this.Controls.SetChildIndex(this.txtACC_NAME, 0);
            this.Controls.SetChildIndex(this.dgAccData, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myBottun btnFind;
        private ERP.myText txtACC_NAME;
        private ERP.myList lstACC_TYPE;
        private ERP.myText txtACC_NO;
        private ERP.myLabel myLabel4;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel2;
        private ERP.myDataGrid dgAccData;
        private ERP.myBottun btnOk;
        private ERP.myBottun myBottun1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
