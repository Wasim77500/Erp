namespace ERP.Inventory
{
    partial class frmFindServiceCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindServiceCenter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myBottun2 = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.dgvWarehouse = new ERP.myDataGrid();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.txtSC_Name = new ERP.myText();
            this.myLabel3 = new ERP.myLabel();
            this.txtSC_Type = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.btnFind = new ERP.myBottun();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSC_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSC_Type)).BeginInit();
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
            // myBottun2
            // 
            this.myBottun2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myBottun2.BackgroundImage")));
            this.myBottun2.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.myBottun2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myBottun2.FlatAppearance.BorderSize = 0;
            this.myBottun2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBottun2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.myBottun2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myBottun2.Image = ((System.Drawing.Image)(resources.GetObject("myBottun2.Image")));
            this.myBottun2.IsBackStageButton = false;
            this.myBottun2.Location = new System.Drawing.Point(330, 388);
            this.myBottun2.Name = "myBottun2";
            this.myBottun2.Size = new System.Drawing.Size(57, 28);
            this.myBottun2.TabIndex = 144;
            this.myBottun2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun2.UseVisualStyleBackColor = true;
            this.myBottun2.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun2.w_Type = ERP.myBottun.Btton_type.OK;
            this.myBottun2.Click += new System.EventHandler(this.myBottun2_Click);
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
            this.myBottun1.Location = new System.Drawing.Point(390, 388);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 143;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // dgvWarehouse
            // 
            this.dgvWarehouse.AllowUserToAddRows = false;
            this.dgvWarehouse.AllowUserToDeleteRows = false;
            this.dgvWarehouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvWarehouse.EnableHeadersVisualStyles = false;
            this.dgvWarehouse.Location = new System.Drawing.Point(7, 130);
            this.dgvWarehouse.Name = "dgvWarehouse";
            this.dgvWarehouse.RowHeadersVisible = false;
            this.dgvWarehouse.Size = new System.Drawing.Size(439, 252);
            this.dgvWarehouse.TabIndex = 142;
            this.dgvWarehouse.W_Clear = true;
            this.dgvWarehouse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarehouse_CellDoubleClick);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtSC_Name);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.txtSC_Type);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(57, 34);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(346, 88);
            this.myGroupBox1.TabIndex = 141;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات مركز الخدمة";
            // 
            // txtSC_Name
            // 
            this.txtSC_Name.BeforeTouchSize = new System.Drawing.Size(70, 23);
            this.txtSC_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSC_Name.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSC_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSC_Name.Location = new System.Drawing.Point(78, 24);
            this.txtSC_Name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSC_Name.Name = "txtSC_Name";
            this.txtSC_Name.Size = new System.Drawing.Size(163, 25);
            this.txtSC_Name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSC_Name.TabIndex = 135;
            this.txtSC_Name.W_Clear = true;
            this.txtSC_Name.W_ColArName = "اسم الموقع";
            this.txtSC_Name.W_ColEgName = "LOCATION_NAME";
            this.txtSC_Name.W_OldValue = "";
            this.txtSC_Name.W_TableName = "LOCATION";
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
            this.myLabel3.Size = new System.Drawing.Size(90, 18);
            this.myLabel3.TabIndex = 123;
            this.myLabel3.Text = "اسم مركز الخدمة";
            // 
            // txtSC_Type
            // 
            this.txtSC_Type.BeforeTouchSize = new System.Drawing.Size(70, 23);
            this.txtSC_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSC_Type.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSC_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSC_Type.Location = new System.Drawing.Point(78, 55);
            this.txtSC_Type.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSC_Type.Name = "txtSC_Type";
            this.txtSC_Type.Size = new System.Drawing.Size(163, 25);
            this.txtSC_Type.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSC_Type.TabIndex = 134;
            this.txtSC_Type.W_Clear = true;
            this.txtSC_Type.W_ColArName = "اسم الموقع";
            this.txtSC_Type.W_ColEgName = "LOCATION_NAME";
            this.txtSC_Type.W_OldValue = "";
            this.txtSC_Type.W_TableName = "LOCATION";
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
            this.myLabel2.Size = new System.Drawing.Size(91, 18);
            this.myLabel2.TabIndex = 130;
            this.myLabel2.Text = "نوع مركز الخدمة";
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
            // Column1
            // 
            this.Column1.HeaderText = "swid";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "مركز الخدمة";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "نوع المركز";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الفرع";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الموقع";
            this.Column5.Name = "Column5";
            // 
            // frmFindServiceCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(453, 425);
            this.Controls.Add(this.myBottun2);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgvWarehouse);
            this.Controls.Add(this.myGroupBox1);
            this.Name = "frmFindServiceCenter";
            this.Titel = "البحث عن مركز الخدمات";
            this.Load += new System.EventHandler(this.frmFindServiceCenter_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgvWarehouse, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.myBottun2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSC_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSC_Type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myBottun myBottun2;
        private ERP.myBottun myBottun1;
        private ERP.myDataGrid dgvWarehouse;
        private ERP.myGroupBox myGroupBox1;
        private ERP.myText txtSC_Name;
        private ERP.myLabel myLabel3;
        private ERP.myText txtSC_Type;
        private ERP.myLabel myLabel2;
        private ERP.myBottun btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
