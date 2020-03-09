namespace ERP.Inventory
{
    partial class frmFindWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindWarehouse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myBottun2 = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.dgvWarehouse = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.txtWarehouseNo = new ERP.myText();
            this.myLabel3 = new ERP.myLabel();
            this.txtWarehouseName = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.btnFind = new ERP.myBottun();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseName)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(146, 34);
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
            this.myBottun2.Location = new System.Drawing.Point(338, 397);
            this.myBottun2.Name = "myBottun2";
            this.myBottun2.Size = new System.Drawing.Size(57, 28);
            this.myBottun2.TabIndex = 140;
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
            this.myBottun1.Location = new System.Drawing.Point(398, 397);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 139;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvWarehouse.EnableHeadersVisualStyles = false;
            this.dgvWarehouse.Location = new System.Drawing.Point(15, 139);
            this.dgvWarehouse.Name = "dgvWarehouse";
            this.dgvWarehouse.RowHeadersVisible = false;
            this.dgvWarehouse.Size = new System.Drawing.Size(439, 252);
            this.dgvWarehouse.TabIndex = 138;
            this.dgvWarehouse.W_Clear = true;
            this.dgvWarehouse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarehouse_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "swid";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم المخزن";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم المخزن";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الوصف";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "العنوان";
            this.Column5.Name = "Column5";
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtWarehouseNo);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.txtWarehouseName);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(65, 43);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(346, 88);
            this.myGroupBox1.TabIndex = 137;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات المخزن";
            // 
            // txtWarehouseNo
            // 
            this.txtWarehouseNo.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtWarehouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarehouseNo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtWarehouseNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtWarehouseNo.Location = new System.Drawing.Point(78, 24);
            this.txtWarehouseNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtWarehouseNo.Name = "txtWarehouseNo";
            this.txtWarehouseNo.Size = new System.Drawing.Size(163, 25);
            this.txtWarehouseNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtWarehouseNo.TabIndex = 135;
            this.txtWarehouseNo.W_Clear = true;
            this.txtWarehouseNo.W_ColArName = "اسم الموقع";
            this.txtWarehouseNo.W_ColEgName = "LOCATION_NAME";
            this.txtWarehouseNo.W_OldValue = "";
            this.txtWarehouseNo.W_TableName = "LOCATION";
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
            this.myLabel3.Size = new System.Drawing.Size(64, 18);
            this.myLabel3.TabIndex = 123;
            this.myLabel3.Text = "رقم المخزن";
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtWarehouseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarehouseName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtWarehouseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtWarehouseName.Location = new System.Drawing.Point(78, 55);
            this.txtWarehouseName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(163, 25);
            this.txtWarehouseName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtWarehouseName.TabIndex = 134;
            this.txtWarehouseName.W_Clear = true;
            this.txtWarehouseName.W_ColArName = "اسم الموقع";
            this.txtWarehouseName.W_ColEgName = "LOCATION_NAME";
            this.txtWarehouseName.W_OldValue = "";
            this.txtWarehouseName.W_TableName = "LOCATION";
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
            this.myLabel2.Size = new System.Drawing.Size(66, 18);
            this.myLabel2.TabIndex = 130;
            this.myLabel2.Text = "اسم المخزن";
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
            // frmFindWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(460, 430);
            this.Controls.Add(this.myBottun2);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgvWarehouse);
            this.Controls.Add(this.myGroupBox1);
            this.Name = "frmFindWarehouse";
            this.Titel = "البحث عن مخزن";
            this.Load += new System.EventHandler(this.frmFindWarehouse_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgvWarehouse, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.myBottun2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myBottun myBottun2;
        private ERP.myBottun myBottun1;
        private ERP.myDataGrid dgvWarehouse;
        private ERP.myGroupBox myGroupBox1;
        private ERP.myText txtWarehouseNo;
        private ERP.myLabel myLabel3;
        private ERP.myText txtWarehouseName;
        private ERP.myLabel myLabel2;
        private ERP.myBottun btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
