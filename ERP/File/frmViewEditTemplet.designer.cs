namespace ERP.File
{
    partial class frmViewEditTemplet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTempHeader = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myLabel2 = new ERP.myLabel();
            this.txtFormName = new ERP.myText();
            this.dgvTempDetails = new ERP.myDataGrid();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFormEnName = new ERP.myText();
            this.dgProperities = new ERP.myDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtFormId = new ERP.myText();
            this.lstEditor = new ERP.myList();
            this.txtForm_type = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormEnName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtForm_type)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(238, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(151, 34);
            // 
            // dgvTempHeader
            // 
            this.dgvTempHeader.AllowUserToAddRows = false;
            this.dgvTempHeader.AllowUserToDeleteRows = false;
            this.dgvTempHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTempHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTempHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTempHeader.EnableHeadersVisualStyles = false;
            this.dgvTempHeader.Location = new System.Drawing.Point(121, 57);
            this.dgvTempHeader.Name = "dgvTempHeader";
            this.dgvTempHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTempHeader.RowHeadersVisible = false;
            this.dgvTempHeader.Size = new System.Drawing.Size(344, 139);
            this.dgvTempHeader.TabIndex = 269;
            this.dgvTempHeader.W_Clear = true;
            this.dgvTempHeader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTempHeader_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "swid";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم النموذج";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(148, 36);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(66, 18);
            this.myLabel2.TabIndex = 270;
            this.myLabel2.Text = "اسم الشاشة";
            this.myLabel2.Click += new System.EventHandler(this.myLabel2_Click);
            // 
            // txtFormName
            // 
            this.txtFormName.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtFormName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtFormName.Location = new System.Drawing.Point(220, 33);
            this.txtFormName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(211, 23);
            this.txtFormName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFormName.TabIndex = 271;
            this.txtFormName.W_Clear = true;
            this.txtFormName.W_ColArName = "";
            this.txtFormName.W_ColEgName = "";
            this.txtFormName.W_OldValue = "";
            this.txtFormName.W_TableName = "";
            // 
            // dgvTempDetails
            // 
            this.dgvTempDetails.AllowUserToAddRows = false;
            this.dgvTempDetails.AllowUserToDeleteRows = false;
            this.dgvTempDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTempDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTempDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column12,
            this.Column13});
            this.dgvTempDetails.EnableHeadersVisualStyles = false;
            this.dgvTempDetails.Location = new System.Drawing.Point(339, 202);
            this.dgvTempDetails.Name = "dgvTempDetails";
            this.dgvTempDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTempDetails.RowHeadersVisible = false;
            this.dgvTempDetails.Size = new System.Drawing.Size(302, 220);
            this.dgvTempDetails.TabIndex = 279;
            this.dgvTempDetails.W_Clear = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "swid";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 5;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "اسم الخاصية";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "القيــمــة";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "control_type";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "en_name";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "القيمة الفعلية";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // txtFormEnName
            // 
            this.txtFormEnName.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtFormEnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormEnName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFormEnName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtFormEnName.Location = new System.Drawing.Point(478, 36);
            this.txtFormEnName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFormEnName.Name = "txtFormEnName";
            this.txtFormEnName.Size = new System.Drawing.Size(84, 23);
            this.txtFormEnName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFormEnName.TabIndex = 280;
            this.txtFormEnName.Visible = false;
            this.txtFormEnName.W_Clear = true;
            this.txtFormEnName.W_ColArName = "";
            this.txtFormEnName.W_ColEgName = "";
            this.txtFormEnName.W_OldValue = "";
            this.txtFormEnName.W_TableName = "";
            // 
            // dgProperities
            // 
            this.dgProperities.AllowUserToAddRows = false;
            this.dgProperities.AllowUserToDeleteRows = false;
            this.dgProperities.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProperities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProperities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProperities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column10,
            this.Column11,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column3});
            this.dgProperities.EnableHeadersVisualStyles = false;
            this.dgProperities.Location = new System.Drawing.Point(8, 202);
            this.dgProperities.Name = "dgProperities";
            this.dgProperities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgProperities.RowHeadersVisible = false;
            this.dgProperities.Size = new System.Drawing.Size(328, 220);
            this.dgProperities.TabIndex = 281;
            this.dgProperities.W_Clear = true;
            this.dgProperities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProperities_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "swid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم الخاصية";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "القيــمــة";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "control_type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "list_id";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "free_list_name";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "en_name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "القيمة الفعلية";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "تعديل";
            this.Column3.Image = global::ERP.Properties.Resources.Previous;
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // txtFormId
            // 
            this.txtFormId.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtFormId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFormId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtFormId.Location = new System.Drawing.Point(521, 80);
            this.txtFormId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFormId.Name = "txtFormId";
            this.txtFormId.Size = new System.Drawing.Size(84, 23);
            this.txtFormId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFormId.TabIndex = 282;
            this.txtFormId.Visible = false;
            this.txtFormId.W_Clear = true;
            this.txtFormId.W_ColArName = "";
            this.txtFormId.W_ColEgName = "";
            this.txtFormId.W_OldValue = "";
            this.txtFormId.W_TableName = "";
            // 
            // lstEditor
            // 
            this.lstEditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstEditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstEditor.FormattingEnabled = true;
            this.lstEditor.Location = new System.Drawing.Point(-6, 153);
            this.lstEditor.Name = "lstEditor";
            this.lstEditor.Size = new System.Drawing.Size(121, 24);
            this.lstEditor.TabIndex = 286;
            this.lstEditor.Visible = false;
            this.lstEditor.W_Clear = true;
            this.lstEditor.W_ColArName = "";
            this.lstEditor.W_ColEgName = "";
            this.lstEditor.W_OldValue = "";
            this.lstEditor.W_TableName = "";
            this.lstEditor.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEditor_KeyDown);
            this.lstEditor.Leave += new System.EventHandler(this.lstEditor_Leave);
            // 
            // txtForm_type
            // 
            this.txtForm_type.BeforeTouchSize = new System.Drawing.Size(14, 23);
            this.txtForm_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForm_type.Font = new System.Drawing.Font("Arial", 10F);
            this.txtForm_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtForm_type.Location = new System.Drawing.Point(521, 127);
            this.txtForm_type.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtForm_type.Name = "txtForm_type";
            this.txtForm_type.Size = new System.Drawing.Size(84, 23);
            this.txtForm_type.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtForm_type.TabIndex = 287;
            this.txtForm_type.Visible = false;
            this.txtForm_type.W_Clear = true;
            this.txtForm_type.W_ColArName = "";
            this.txtForm_type.W_ColEgName = "";
            this.txtForm_type.W_OldValue = "";
            this.txtForm_type.W_TableName = "";
            // 
            // frmViewEditTemplet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(644, 425);
            this.Controls.Add(this.txtForm_type);
            this.Controls.Add(this.lstEditor);
            this.Controls.Add(this.txtFormId);
            this.Controls.Add(this.dgProperities);
            this.Controls.Add(this.txtFormEnName);
            this.Controls.Add(this.dgvTempDetails);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.dgvTempHeader);
            this.Name = "frmViewEditTemplet";
            this.Titel = "عرض صلاحيات النماذج";
            this.Load += new System.EventHandler(this.frmViewEditTemplet_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.dgvTempHeader, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtFormName, 0);
            this.Controls.SetChildIndex(this.dgvTempDetails, 0);
            this.Controls.SetChildIndex(this.txtFormEnName, 0);
            this.Controls.SetChildIndex(this.dgProperities, 0);
            this.Controls.SetChildIndex(this.txtFormId, 0);
            this.Controls.SetChildIndex(this.lstEditor, 0);
            this.Controls.SetChildIndex(this.txtForm_type, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormEnName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtForm_type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myDataGrid dgvTempHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private ERP.myLabel myLabel2;
        private ERP.myDataGrid dgvTempDetails;
        public ERP.myText txtFormName;
        public ERP.myText txtFormEnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private ERP.myDataGrid dgProperities;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        public ERP.myText txtFormId;
        private ERP.myList lstEditor;
        public ERP.myText txtForm_type;
    }
}
