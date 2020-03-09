namespace ERP.Accounts
{
    partial class frmFindCasher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindCasher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOk = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.dgBranches = new ERP.myDataGrid();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.txtAccNo = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.txtC_Name = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.btnFind = new ERP.myBottun();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_Name)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(161, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(74, 34);
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
            this.btnOk.Location = new System.Drawing.Point(342, 402);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 140;
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
            this.myBottun1.Location = new System.Drawing.Point(402, 402);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 139;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // dgBranches
            // 
            this.dgBranches.AllowUserToAddRows = false;
            this.dgBranches.AllowUserToDeleteRows = false;
            this.dgBranches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBranches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgBranches.EnableHeadersVisualStyles = false;
            this.dgBranches.Location = new System.Drawing.Point(7, 127);
            this.dgBranches.Name = "dgBranches";
            this.dgBranches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgBranches.RowHeadersVisible = false;
            this.dgBranches.Size = new System.Drawing.Size(479, 269);
            this.dgBranches.TabIndex = 138;
            this.dgBranches.W_Clear = true;
            this.dgBranches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBranches_CellDoubleClick);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtAccNo);
            this.myGroupBox1.Controls.Add(this.myLabel4);
            this.myGroupBox1.Controls.Add(this.txtC_Name);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(83, 33);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(293, 88);
            this.myGroupBox1.TabIndex = 137;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات الصندوق";
            // 
            // txtAccNo
            // 
            this.txtAccNo.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAccNo.Location = new System.Drawing.Point(44, 52);
            this.txtAccNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(163, 25);
            this.txtAccNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAccNo.TabIndex = 138;
            this.txtAccNo.W_Clear = true;
            this.txtAccNo.W_ColArName = "اسم الموقع";
            this.txtAccNo.W_ColEgName = "LOCATION_NAME";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.W_TableName = "LOCATION";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(213, 56);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(67, 18);
            this.myLabel4.TabIndex = 137;
            this.myLabel4.Text = "رقم الحساب";
            // 
            // txtC_Name
            // 
            this.txtC_Name.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtC_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtC_Name.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtC_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtC_Name.Location = new System.Drawing.Point(44, 24);
            this.txtC_Name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtC_Name.Name = "txtC_Name";
            this.txtC_Name.Size = new System.Drawing.Size(163, 25);
            this.txtC_Name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtC_Name.TabIndex = 134;
            this.txtC_Name.W_Clear = true;
            this.txtC_Name.W_ColArName = "اسم الموقع";
            this.txtC_Name.W_ColEgName = "LOCATION_NAME";
            this.txtC_Name.W_OldValue = "";
            this.txtC_Name.W_TableName = "LOCATION";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(212, 27);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(75, 18);
            this.myLabel2.TabIndex = 130;
            this.myLabel2.Text = "اسم الصندوق";
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
            this.btnFind.Location = new System.Drawing.Point(14, 51);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 1;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم الصندوق";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "رقم الحساب";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "نوع الصندوق";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // frmFindCasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(491, 437);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgBranches);
            this.Controls.Add(this.myGroupBox1);
            this.Name = "frmFindCasher";
            this.Titel = "البحث عن صندوق";
            this.Load += new System.EventHandler(this.frmFindCasher_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgBranches, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_Name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myBottun btnOk;
        private ERP.myBottun myBottun1;
        private ERP.myDataGrid dgBranches;
        private ERP.myGroupBox myGroupBox1;
        private ERP.myText txtC_Name;
        private ERP.myLabel myLabel2;
        private ERP.myBottun btnFind;
        private ERP.myText txtAccNo;
        private ERP.myLabel myLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
