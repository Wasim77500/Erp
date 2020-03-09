namespace ERP.Inventory
{
    partial class frmFindVendorItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindVendorItems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new ERP.myBottun();
            this.btnOk = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.dgItems = new ERP.myDataGrid();
            this.txtITEM_NAME = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.txtITEM_NO = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_NO)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(188, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(101, 34);
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
            this.btnSearch.Location = new System.Drawing.Point(406, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 309;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnOk.Location = new System.Drawing.Point(425, 404);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 308;
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
            this.myBottun1.Location = new System.Drawing.Point(485, 404);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 307;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgItems.EnableHeadersVisualStyles = false;
            this.dgItems.Location = new System.Drawing.Point(9, 123);
            this.dgItems.Name = "dgItems";
            this.dgItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.Size = new System.Drawing.Size(531, 275);
            this.dgItems.TabIndex = 306;
            this.dgItems.W_Clear = true;
            this.dgItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellDoubleClick);
            // 
            // txtITEM_NAME
            // 
            this.txtITEM_NAME.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtITEM_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtITEM_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtITEM_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtITEM_NAME.Location = new System.Drawing.Point(221, 92);
            this.txtITEM_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtITEM_NAME.Name = "txtITEM_NAME";
            this.txtITEM_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtITEM_NAME.Size = new System.Drawing.Size(179, 25);
            this.txtITEM_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtITEM_NAME.TabIndex = 305;
            this.txtITEM_NAME.W_Clear = true;
            this.txtITEM_NAME.W_ColArName = "اسم دخول المستخدم";
            this.txtITEM_NAME.W_ColEgName = "USER_LOGIN";
            this.txtITEM_NAME.W_OldValue = "";
            this.txtITEM_NAME.W_TableName = "USERINFO";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(148, 99);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(67, 18);
            this.myLabel2.TabIndex = 304;
            this.myLabel2.Text = "اسم القطعة";
            // 
            // txtITEM_NO
            // 
            this.txtITEM_NO.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtITEM_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtITEM_NO.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtITEM_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtITEM_NO.Location = new System.Drawing.Point(221, 64);
            this.txtITEM_NO.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtITEM_NO.Name = "txtITEM_NO";
            this.txtITEM_NO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtITEM_NO.Size = new System.Drawing.Size(179, 25);
            this.txtITEM_NO.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtITEM_NO.TabIndex = 303;
            this.txtITEM_NO.W_Clear = true;
            this.txtITEM_NO.W_ColArName = "اسم دخول المستخدم";
            this.txtITEM_NO.W_ColEgName = "USER_LOGIN";
            this.txtITEM_NO.W_OldValue = "";
            this.txtITEM_NO.W_TableName = "USERINFO";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(148, 71);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(67, 18);
            this.myLabel4.TabIndex = 302;
            this.myLabel4.Text = "رقم القطعة";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم الصنف";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم الصنف";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "بيانات الصنف";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // frmFindVendorItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(545, 447);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.txtITEM_NAME);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.txtITEM_NO);
            this.Controls.Add(this.myLabel4);
            this.Name = "frmFindVendorItems";
            this.Titel = "البحث عن الاصناف الغير مرتبطة بالمخزون";
            this.Load += new System.EventHandler(this.frmFindVendorItems_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtITEM_NO, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtITEM_NAME, 0);
            this.Controls.SetChildIndex(this.dgItems, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITEM_NO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myBottun btnSearch;
        private myBottun btnOk;
        private myBottun myBottun1;
        private myDataGrid dgItems;
        private myText txtITEM_NAME;
        private myLabel myLabel2;
        private myText txtITEM_NO;
        private myLabel myLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
