namespace ERP.Purchases
{
    partial class frmFindExpTerms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindExpTerms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new ERP.myBottun();
            this.btnOk = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.dgvTermExp = new ERP.myDataGrid();
            this.txtTermCode = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.txtTermName = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.clmSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTermsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTermsCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTermCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTermName)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(101, 34);
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
            this.btnSearch.Location = new System.Drawing.Point(310, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 333;
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
            this.btnOk.Location = new System.Drawing.Point(247, 376);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 332;
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
            this.myBottun1.Location = new System.Drawing.Point(307, 376);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 331;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // dgvTermExp
            // 
            this.dgvTermExp.AllowUserToAddRows = false;
            this.dgvTermExp.AllowUserToDeleteRows = false;
            this.dgvTermExp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTermExp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTermExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSwid,
            this.clmTermsName,
            this.clmTermsCode});
            this.dgvTermExp.EnableHeadersVisualStyles = false;
            this.dgvTermExp.Location = new System.Drawing.Point(12, 95);
            this.dgvTermExp.Name = "dgvTermExp";
            this.dgvTermExp.RowHeadersVisible = false;
            this.dgvTermExp.Size = new System.Drawing.Size(350, 275);
            this.dgvTermExp.TabIndex = 330;
            this.dgvTermExp.W_Clear = true;
            this.dgvTermExp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // txtTermCode
            // 
            this.txtTermCode.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtTermCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTermCode.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTermCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtTermCode.Location = new System.Drawing.Point(125, 64);
            this.txtTermCode.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTermCode.Name = "txtTermCode";
            this.txtTermCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTermCode.Size = new System.Drawing.Size(179, 25);
            this.txtTermCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTermCode.TabIndex = 329;
            this.txtTermCode.W_Clear = true;
            this.txtTermCode.W_ColArName = "اسم دخول المستخدم";
            this.txtTermCode.W_ColEgName = "USER_LOGIN";
            this.txtTermCode.W_OldValue = "";
            this.txtTermCode.W_TableName = "USERINFO";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(52, 71);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(67, 18);
            this.myLabel2.TabIndex = 328;
            this.myLabel2.Text = "الكود";
            // 
            // txtTermName
            // 
            this.txtTermName.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtTermName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTermName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTermName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtTermName.Location = new System.Drawing.Point(125, 36);
            this.txtTermName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTermName.Name = "txtTermName";
            this.txtTermName.Size = new System.Drawing.Size(179, 25);
            this.txtTermName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTermName.TabIndex = 327;
            this.txtTermName.W_Clear = true;
            this.txtTermName.W_ColArName = "اسم دخول المستخدم";
            this.txtTermName.W_ColEgName = "USER_LOGIN";
            this.txtTermName.W_OldValue = "";
            this.txtTermName.W_TableName = "USERINFO";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(37, 43);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(82, 18);
            this.myLabel4.TabIndex = 326;
            this.myLabel4.Text = "اسم الاتفاقية";
            // 
            // clmSwid
            // 
            this.clmSwid.HeaderText = "Column1";
            this.clmSwid.Name = "clmSwid";
            this.clmSwid.Visible = false;
            // 
            // clmTermsName
            // 
            this.clmTermsName.HeaderText = "اسم الاتفاقية";
            this.clmTermsName.Name = "clmTermsName";
            this.clmTermsName.Width = 120;
            // 
            // clmTermsCode
            // 
            this.clmTermsCode.HeaderText = "الكود";
            this.clmTermsCode.Name = "clmTermsCode";
            // 
            // frmFindExpTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 410);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgvTermExp);
            this.Controls.Add(this.txtTermCode);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.txtTermName);
            this.Controls.Add(this.myLabel4);
            this.Name = "frmFindExpTerms";
            this.Text = "frmFindExpTerms";
            this.Titel = "البحث عن اتفاقية المصاريف";
            this.Load += new System.EventHandler(this.frmFindExpTerms_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtTermName, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtTermCode, 0);
            this.Controls.SetChildIndex(this.dgvTermExp, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTermCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTermName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myBottun btnSearch;
        private myBottun btnOk;
        private myBottun myBottun1;
        private myDataGrid dgvTermExp;
        private myText txtTermCode;
        private myLabel myLabel2;
        private myText txtTermName;
        private myLabel myLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTermsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTermsCode;
    }
}