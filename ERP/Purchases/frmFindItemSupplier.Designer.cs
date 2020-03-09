namespace ERP.Purchases
{
    partial class frmFindItemSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindItemSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOk = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.dgvItemSuplier = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new ERP.myBottun();
            this.txtitem_name = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.txtitem_no = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.txtVendorName = new ERP.myText();
            this.txtPeopleId = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemSuplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtitem_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtitem_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeopleId)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(142, 34);
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
            this.btnOk.Location = new System.Drawing.Point(333, 411);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 317;
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
            this.myBottun1.Location = new System.Drawing.Point(393, 411);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 316;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // dgvItemSuplier
            // 
            this.dgvItemSuplier.AllowUserToAddRows = false;
            this.dgvItemSuplier.AllowUserToDeleteRows = false;
            this.dgvItemSuplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemSuplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemSuplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemSuplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvItemSuplier.EnableHeadersVisualStyles = false;
            this.dgvItemSuplier.Location = new System.Drawing.Point(12, 130);
            this.dgvItemSuplier.Name = "dgvItemSuplier";
            this.dgvItemSuplier.RowHeadersVisible = false;
            this.dgvItemSuplier.Size = new System.Drawing.Size(437, 275);
            this.dgvItemSuplier.TabIndex = 315;
            this.dgvItemSuplier.W_Clear = true;
            this.dgvItemSuplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemSuplier_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "swid";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم الصنف";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم الصنف";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
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
            this.btnSearch.Location = new System.Drawing.Point(294, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 314;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtitem_name
            // 
            this.txtitem_name.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtitem_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtitem_name.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtitem_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtitem_name.Location = new System.Drawing.Point(109, 102);
            this.txtitem_name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtitem_name.Name = "txtitem_name";
            this.txtitem_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtitem_name.Size = new System.Drawing.Size(179, 25);
            this.txtitem_name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtitem_name.TabIndex = 313;
            this.txtitem_name.W_Clear = true;
            this.txtitem_name.W_ColArName = "اسم دخول المستخدم";
            this.txtitem_name.W_ColEgName = "USER_LOGIN";
            this.txtitem_name.W_OldValue = "";
            this.txtitem_name.W_TableName = "USERINFO";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(20, 109);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(83, 18);
            this.myLabel2.TabIndex = 312;
            this.myLabel2.Text = "اسم الصنف";
            // 
            // txtitem_no
            // 
            this.txtitem_no.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtitem_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtitem_no.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtitem_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtitem_no.Location = new System.Drawing.Point(109, 74);
            this.txtitem_no.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtitem_no.Name = "txtitem_no";
            this.txtitem_no.Size = new System.Drawing.Size(179, 25);
            this.txtitem_no.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtitem_no.TabIndex = 311;
            this.txtitem_no.W_Clear = true;
            this.txtitem_no.W_ColArName = "اسم دخول المستخدم";
            this.txtitem_no.W_ColEgName = "USER_LOGIN";
            this.txtitem_no.W_OldValue = "";
            this.txtitem_no.W_TableName = "USERINFO";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(20, 81);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(83, 18);
            this.myLabel4.TabIndex = 310;
            this.myLabel4.Text = "رقم الصنف";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = false;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(20, 51);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(83, 18);
            this.myLabel3.TabIndex = 318;
            this.myLabel3.Text = "اسم المورد";
            // 
            // txtVendorName
            // 
            this.txtVendorName.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtVendorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtVendorName.Location = new System.Drawing.Point(109, 47);
            this.txtVendorName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(179, 25);
            this.txtVendorName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtVendorName.TabIndex = 319;
            this.txtVendorName.W_Clear = true;
            this.txtVendorName.W_ColArName = "اسم دخول المستخدم";
            this.txtVendorName.W_ColEgName = "USER_LOGIN";
            this.txtVendorName.W_OldValue = "";
            this.txtVendorName.W_TableName = "USERINFO";
            // 
            // txtPeopleId
            // 
            this.txtPeopleId.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtPeopleId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeopleId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPeopleId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPeopleId.Location = new System.Drawing.Point(378, 51);
            this.txtPeopleId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPeopleId.Name = "txtPeopleId";
            this.txtPeopleId.Size = new System.Drawing.Size(36, 25);
            this.txtPeopleId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPeopleId.TabIndex = 320;
            this.txtPeopleId.Visible = false;
            this.txtPeopleId.W_Clear = true;
            this.txtPeopleId.W_ColArName = "";
            this.txtPeopleId.W_ColEgName = "";
            this.txtPeopleId.W_OldValue = "";
            this.txtPeopleId.W_TableName = "";
            // 
            // frmFindItemSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 442);
            this.Controls.Add(this.txtPeopleId);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgvItemSuplier);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtitem_name);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.txtitem_no);
            this.Controls.Add(this.myLabel4);
            this.Name = "frmFindItemSupplier";
            this.Text = "frmFindItemSupplier";
            this.Titel = "البحث عن اصناف المورد";
            this.Load += new System.EventHandler(this.frmFindItemSupplier_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtitem_no, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtitem_name, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.dgvItemSuplier, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.txtVendorName, 0);
            this.Controls.SetChildIndex(this.txtPeopleId, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemSuplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtitem_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtitem_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeopleId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myBottun btnOk;
        private myBottun myBottun1;
        private myDataGrid dgvItemSuplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private myBottun btnSearch;
        private myText txtitem_name;
        private myLabel myLabel2;
        private myText txtitem_no;
        private myLabel myLabel4;
        private myLabel myLabel3;
        public myText txtVendorName;
        public myText txtPeopleId;
    }
}