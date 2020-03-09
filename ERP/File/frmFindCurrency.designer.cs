namespace ERP.File
{
    partial class frmFindCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindCurrency));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOk = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.dgCurrency = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.txtCURR_NAME = new ERP.myText();
            this.myLabel3 = new ERP.myLabel();
            this.txtCURR_SMPL = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.btnFind = new ERP.myBottun();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrency)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(308, 386);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 140;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnOk.w_Type = ERP.myBottun.Btton_type.OK;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(367, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 139;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // dgCurrency
            // 
            this.dgCurrency.AllowUserToAddRows = false;
            this.dgCurrency.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCurrency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgCurrency.EnableHeadersVisualStyles = false;
            this.dgCurrency.Location = new System.Drawing.Point(12, 128);
            this.dgCurrency.Name = "dgCurrency";
            this.dgCurrency.RowHeadersVisible = false;
            this.dgCurrency.Size = new System.Drawing.Size(439, 252);
            this.dgCurrency.TabIndex = 138;
            this.dgCurrency.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCurrency_CellClick);
            this.dgCurrency.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCurrency_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم العملة";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الرمز";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "سعر الصرف";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ملاحظات";
            this.Column5.Name = "Column5";
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtCURR_NAME);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.txtCURR_SMPL);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(62, 32);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(346, 88);
            this.myGroupBox1.TabIndex = 137;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات الموقع";
            // 
            // txtCURR_NAME
            // 
            this.txtCURR_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCURR_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCURR_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCURR_NAME.Location = new System.Drawing.Point(78, 24);
            this.txtCURR_NAME.Name = "txtCURR_NAME";
            this.txtCURR_NAME.Size = new System.Drawing.Size(163, 25);
            this.txtCURR_NAME.TabIndex = 135;
            this.txtCURR_NAME.W_ColArName = "اسم الموقع";
            this.txtCURR_NAME.W_ColEgName = "LOCATION_NAME";
            this.txtCURR_NAME.W_OldValue = "";
            this.txtCURR_NAME.W_TableName = "LOCATION";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(247, 27);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(59, 18);
            this.myLabel3.TabIndex = 123;
            this.myLabel3.Text = "اسم العملة";
            // 
            // txtCURR_SMPL
            // 
            this.txtCURR_SMPL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCURR_SMPL.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCURR_SMPL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtCURR_SMPL.Location = new System.Drawing.Point(78, 55);
            this.txtCURR_SMPL.Name = "txtCURR_SMPL";
            this.txtCURR_SMPL.Size = new System.Drawing.Size(163, 25);
            this.txtCURR_SMPL.TabIndex = 134;
            this.txtCURR_SMPL.W_ColArName = "اسم الموقع";
            this.txtCURR_SMPL.W_ColEgName = "LOCATION_NAME";
            this.txtCURR_SMPL.W_OldValue = "";
            this.txtCURR_SMPL.W_TableName = "LOCATION";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(246, 58);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(59, 18);
            this.myLabel2.TabIndex = 130;
            this.myLabel2.Text = "رمز العملة";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(39, 56);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 1;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // frmFindCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(465, 446);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgCurrency);
            this.Controls.Add(this.myGroupBox1);
            this.Name = "frmFindCurrency";
            this.Titel = "البحث عن العملات";
            this.Load += new System.EventHandler(this.frmFindCurrency_Load);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgCurrency, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrency)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ERP.myBottun btnOk;
        private ERP.myBottun btnExit;
        private ERP.myDataGrid dgCurrency;
        private ERP.myGroupBox myGroupBox1;
        private ERP.myLabel myLabel3;
        private ERP.myText txtCURR_SMPL;
        private ERP.myLabel myLabel2;
        private ERP.myBottun btnFind;
        private ERP.myText txtCURR_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
