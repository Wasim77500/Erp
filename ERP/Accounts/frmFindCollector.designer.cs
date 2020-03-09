namespace ERP.Accounts
{
    partial class frmFindCollector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindCollector));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOk = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.dgCollectors = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.txtIDENTIFICATION_ID = new ERP.myText();
            this.txtCOLLECTOR_NAME = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.txtCOLLECTOR_NO = new ERP.myText();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.btnFind = new ERP.myBottun();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCollectors)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDENTIFICATION_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOLLECTOR_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOLLECTOR_NO)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(144, 34);
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
            this.btnOk.Location = new System.Drawing.Point(333, 426);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 144;
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
            this.myBottun1.Location = new System.Drawing.Point(393, 426);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 143;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // dgCollectors
            // 
            this.dgCollectors.AllowUserToAddRows = false;
            this.dgCollectors.AllowUserToDeleteRows = false;
            this.dgCollectors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCollectors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCollectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCollectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgCollectors.EnableHeadersVisualStyles = false;
            this.dgCollectors.Location = new System.Drawing.Point(11, 150);
            this.dgCollectors.Name = "dgCollectors";
            this.dgCollectors.RowHeadersVisible = false;
            this.dgCollectors.Size = new System.Drawing.Size(439, 270);
            this.dgCollectors.TabIndex = 142;
            this.dgCollectors.W_Clear = true;
            this.dgCollectors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCollectors_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم النشاط";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم النشاط";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "تاريخ البدء";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "رقم الهوية";
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtIDENTIFICATION_ID);
            this.myGroupBox1.Controls.Add(this.txtCOLLECTOR_NAME);
            this.myGroupBox1.Controls.Add(this.myLabel4);
            this.myGroupBox1.Controls.Add(this.txtCOLLECTOR_NO);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(62, 31);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(346, 113);
            this.myGroupBox1.TabIndex = 141;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات المحصل";
            // 
            // txtIDENTIFICATION_ID
            // 
            this.txtIDENTIFICATION_ID.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtIDENTIFICATION_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDENTIFICATION_ID.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtIDENTIFICATION_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtIDENTIFICATION_ID.Location = new System.Drawing.Point(78, 80);
            this.txtIDENTIFICATION_ID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtIDENTIFICATION_ID.Name = "txtIDENTIFICATION_ID";
            this.txtIDENTIFICATION_ID.Size = new System.Drawing.Size(163, 25);
            this.txtIDENTIFICATION_ID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtIDENTIFICATION_ID.TabIndex = 227;
            this.txtIDENTIFICATION_ID.W_Clear = true;
            this.txtIDENTIFICATION_ID.W_ColArName = "اسم الموقع";
            this.txtIDENTIFICATION_ID.W_ColEgName = "LOCATION_NAME";
            this.txtIDENTIFICATION_ID.W_OldValue = "";
            this.txtIDENTIFICATION_ID.W_TableName = "LOCATION";
            // 
            // txtCOLLECTOR_NAME
            // 
            this.txtCOLLECTOR_NAME.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtCOLLECTOR_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCOLLECTOR_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCOLLECTOR_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCOLLECTOR_NAME.Location = new System.Drawing.Point(78, 51);
            this.txtCOLLECTOR_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCOLLECTOR_NAME.Name = "txtCOLLECTOR_NAME";
            this.txtCOLLECTOR_NAME.Size = new System.Drawing.Size(163, 25);
            this.txtCOLLECTOR_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCOLLECTOR_NAME.TabIndex = 226;
            this.txtCOLLECTOR_NAME.W_Clear = true;
            this.txtCOLLECTOR_NAME.W_ColArName = "اسم الموقع";
            this.txtCOLLECTOR_NAME.W_ColEgName = "LOCATION_NAME";
            this.txtCOLLECTOR_NAME.W_OldValue = "";
            this.txtCOLLECTOR_NAME.W_TableName = "LOCATION";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(247, 87);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(60, 18);
            this.myLabel4.TabIndex = 225;
            this.myLabel4.Text = "رقم الهوية";
            // 
            // txtCOLLECTOR_NO
            // 
            this.txtCOLLECTOR_NO.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtCOLLECTOR_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCOLLECTOR_NO.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCOLLECTOR_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCOLLECTOR_NO.Location = new System.Drawing.Point(78, 20);
            this.txtCOLLECTOR_NO.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCOLLECTOR_NO.Name = "txtCOLLECTOR_NO";
            this.txtCOLLECTOR_NO.Size = new System.Drawing.Size(163, 25);
            this.txtCOLLECTOR_NO.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCOLLECTOR_NO.TabIndex = 135;
            this.txtCOLLECTOR_NO.W_Clear = true;
            this.txtCOLLECTOR_NO.W_ColArName = "اسم الموقع";
            this.txtCOLLECTOR_NO.W_ColEgName = "LOCATION_NAME";
            this.txtCOLLECTOR_NO.W_OldValue = "";
            this.txtCOLLECTOR_NO.W_TableName = "LOCATION";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(247, 27);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(69, 18);
            this.myLabel3.TabIndex = 123;
            this.myLabel3.Text = "رقم المحصل";
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
            this.myLabel2.Size = new System.Drawing.Size(71, 18);
            this.myLabel2.TabIndex = 130;
            this.myLabel2.Text = "اسم المحصل";
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
            this.btnFind.Location = new System.Drawing.Point(44, 78);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 1;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // frmFindCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(456, 459);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgCollectors);
            this.Controls.Add(this.myGroupBox1);
            this.Name = "frmFindCollector";
            this.Titel = "البحث عن محصل";
            this.Load += new System.EventHandler(this.frmFindCollector_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgCollectors, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCollectors)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDENTIFICATION_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOLLECTOR_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOLLECTOR_NO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myBottun btnOk;
        private ERP.myBottun myBottun1;
        private ERP.myDataGrid dgCollectors;
        private ERP.myGroupBox myGroupBox1;
        private ERP.myText txtCOLLECTOR_NO;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel2;
        private ERP.myBottun btnFind;
        private ERP.myText txtIDENTIFICATION_ID;
        private ERP.myText txtCOLLECTOR_NAME;
        private ERP.myLabel myLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
