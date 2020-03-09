namespace ERP.File
{
    partial class frmFreeList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFreeList));
            this.dgFreeList = new ERP.myDataGrid();
            this.myLabel2 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.txtDISPLAY_MEMBER = new ERP.myText();
            this.txtVALUE_MEMBER = new ERP.myText();
            this.btnAdd = new ERP.myBottun();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.lstLIST_NAME = new ERP.myList();
            this.txtSWid = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDISPLAY_MEMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVALUE_MEMBER)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWid)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(69, 34);
            // 
            // dgFreeList
            // 
            this.dgFreeList.AllowUserToAddRows = false;
            this.dgFreeList.AllowUserToDeleteRows = false;
            this.dgFreeList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFreeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFreeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFreeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgFreeList.EnableHeadersVisualStyles = false;
            this.dgFreeList.Location = new System.Drawing.Point(0, 139);
            this.dgFreeList.Name = "dgFreeList";
            this.dgFreeList.RowHeadersVisible = false;
            this.dgFreeList.Size = new System.Drawing.Size(306, 343);
            this.dgFreeList.TabIndex = 2;
            this.dgFreeList.W_Clear = true;
            this.dgFreeList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgFreeList_RowsAdded);
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(26, 88);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(58, 18);
            this.myLabel2.TabIndex = 3;
            this.myLabel2.Text = "رقم تعريف";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(7, 115);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(92, 18);
            this.myLabel3.TabIndex = 4;
            this.myLabel3.Text = "القيمة في القائمة";
            // 
            // txtDISPLAY_MEMBER
            // 
            this.txtDISPLAY_MEMBER.BeforeTouchSize = new System.Drawing.Size(43, 23);
            this.txtDISPLAY_MEMBER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDISPLAY_MEMBER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDISPLAY_MEMBER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDISPLAY_MEMBER.Location = new System.Drawing.Point(101, 110);
            this.txtDISPLAY_MEMBER.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDISPLAY_MEMBER.Name = "txtDISPLAY_MEMBER";
            this.txtDISPLAY_MEMBER.Size = new System.Drawing.Size(143, 23);
            this.txtDISPLAY_MEMBER.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDISPLAY_MEMBER.TabIndex = 5;
            this.txtDISPLAY_MEMBER.W_Clear = true;
            this.txtDISPLAY_MEMBER.W_ColArName = "";
            this.txtDISPLAY_MEMBER.W_ColEgName = "";
            this.txtDISPLAY_MEMBER.W_OldValue = "";
            this.txtDISPLAY_MEMBER.W_TableName = "";
            // 
            // txtVALUE_MEMBER
            // 
            this.txtVALUE_MEMBER.BeforeTouchSize = new System.Drawing.Size(43, 23);
            this.txtVALUE_MEMBER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVALUE_MEMBER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtVALUE_MEMBER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtVALUE_MEMBER.Location = new System.Drawing.Point(101, 83);
            this.txtVALUE_MEMBER.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtVALUE_MEMBER.Name = "txtVALUE_MEMBER";
            this.txtVALUE_MEMBER.Size = new System.Drawing.Size(143, 23);
            this.txtVALUE_MEMBER.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtVALUE_MEMBER.TabIndex = 6;
            this.txtVALUE_MEMBER.W_Clear = true;
            this.txtVALUE_MEMBER.W_ColArName = "";
            this.txtVALUE_MEMBER.W_ColEgName = "";
            this.txtVALUE_MEMBER.W_OldValue = "";
            this.txtVALUE_MEMBER.W_TableName = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(33, 23);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.Image = global::ERP.Properties.Resources.Add_h;
            this.btnAdd.IsBackStageButton = false;
            this.btnAdd.Location = new System.Drawing.Point(250, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 23);
            this.btnAdd.TabIndex = 266;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.lstLIST_NAME);
            this.myGroupBox1.Controls.Add(this.txtSWid);
            this.myGroupBox1.Controls.Add(this.myLabel4);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(7, 33);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(287, 44);
            this.myGroupBox1.TabIndex = 267;
            this.myGroupBox1.TabStop = false;
            // 
            // lstLIST_NAME
            // 
            this.lstLIST_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstLIST_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstLIST_NAME.Font = new System.Drawing.Font("Arial", 10F);
            this.lstLIST_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstLIST_NAME.FormattingEnabled = true;
            this.lstLIST_NAME.Location = new System.Drawing.Point(6, 14);
            this.lstLIST_NAME.Name = "lstLIST_NAME";
            this.lstLIST_NAME.Size = new System.Drawing.Size(196, 24);
            this.lstLIST_NAME.TabIndex = 270;
            this.lstLIST_NAME.W_Clear = false;
            this.lstLIST_NAME.W_ColArName = "";
            this.lstLIST_NAME.W_ColEgName = "";
            this.lstLIST_NAME.W_OldValue = "";
            this.lstLIST_NAME.W_TableName = "";
            this.lstLIST_NAME.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstLIST_NAME.SelectedIndexChanged += new System.EventHandler(this.lstLIST_NAME_SelectedIndexChanged);
            this.lstLIST_NAME.TextChanged += new System.EventHandler(this.lstLIST_NAME_TextChanged);
            // 
            // txtSWid
            // 
            this.txtSWid.BeforeTouchSize = new System.Drawing.Size(43, 23);
            this.txtSWid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSWid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWid.Location = new System.Drawing.Point(0, -4);
            this.txtSWid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWid.Name = "txtSWid";
            this.txtSWid.Size = new System.Drawing.Size(43, 23);
            this.txtSWid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWid.TabIndex = 269;
            this.txtSWid.Visible = false;
            this.txtSWid.W_Clear = true;
            this.txtSWid.W_ColArName = "";
            this.txtSWid.W_ColEgName = "";
            this.txtSWid.W_OldValue = "";
            this.txtSWid.W_TableName = "";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(208, 17);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(63, 18);
            this.myLabel4.TabIndex = 4;
            this.myLabel4.Text = "اسم القائمة";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "swid";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم التعريف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "القيمة في القائمة";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // frmFreeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(306, 483);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtVALUE_MEMBER);
            this.Controls.Add(this.txtDISPLAY_MEMBER);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.dgFreeList);
            this.Name = "frmFreeList";
            this.Titel = "تعريف قائمة حرة";
            this.Load += new System.EventHandler(this.frmFreeList_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.dgFreeList, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.txtDISPLAY_MEMBER, 0);
            this.Controls.SetChildIndex(this.txtVALUE_MEMBER, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDISPLAY_MEMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVALUE_MEMBER)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myDataGrid dgFreeList;
        private ERP.myLabel myLabel2;
        private ERP.myLabel myLabel3;
        private ERP.myText txtDISPLAY_MEMBER;
        private ERP.myText txtVALUE_MEMBER;
        private ERP.myBottun btnAdd;
        private ERP.myGroupBox myGroupBox1;
        private ERP.myText txtSWid;
        private ERP.myLabel myLabel4;
        private ERP.myList lstLIST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
