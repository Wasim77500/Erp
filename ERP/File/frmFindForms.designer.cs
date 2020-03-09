namespace ERP.File
{
    partial class frmFindForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindForms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new ERP.myBottun();
            this.btnOk = new ERP.myBottun();
            this.dgUser = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstSUB_FORM = new ERP.myList();
            this.btnFind = new ERP.myBottun();
            this.lstFORM_TYPE = new ERP.myList();
            this.txtEN_NAME = new ERP.myText();
            this.txtAR_NAME = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.myLabel7 = new ERP.myLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEN_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAR_NAME)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.IsBackStageButton = false;
            this.btnExit.Location = new System.Drawing.Point(484, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 140;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
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
            this.btnOk.Location = new System.Drawing.Point(424, 333);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 141;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnOk.w_Type = ERP.myBottun.Btton_type.OK;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // dgUser
            // 
            this.dgUser.AllowUserToAddRows = false;
            this.dgUser.AllowUserToDeleteRows = false;
            this.dgUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgUser.EnableHeadersVisualStyles = false;
            this.dgUser.Location = new System.Drawing.Point(19, 89);
            this.dgUser.Name = "dgUser";
            this.dgUser.RowHeadersVisible = false;
            this.dgUser.Size = new System.Drawing.Size(522, 238);
            this.dgUser.TabIndex = 142;
            this.dgUser.W_Clear = true;
            this.dgUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUser_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "swid";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم الشاشة";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الشاشة في البرنامج";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "نوع البرنامج";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "البرنامج الفرعي";
            this.Column5.Name = "Column5";
            // 
            // lstSUB_FORM
            // 
            this.lstSUB_FORM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstSUB_FORM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstSUB_FORM.Font = new System.Drawing.Font("Arial", 10F);
            this.lstSUB_FORM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstSUB_FORM.FormattingEnabled = true;
            this.lstSUB_FORM.Location = new System.Drawing.Point(369, 59);
            this.lstSUB_FORM.Name = "lstSUB_FORM";
            this.lstSUB_FORM.Size = new System.Drawing.Size(146, 24);
            this.lstSUB_FORM.TabIndex = 267;
            this.lstSUB_FORM.W_Clear = true;
            this.lstSUB_FORM.W_ColArName = "";
            this.lstSUB_FORM.W_ColEgName = "";
            this.lstSUB_FORM.W_OldValue = "";
            this.lstSUB_FORM.W_TableName = "";
            this.lstSUB_FORM.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstSUB_FORM.SelectedIndexChanged += new System.EventHandler(this.lstSUB_FORM_SelectedIndexChanged);
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
            this.btnFind.Location = new System.Drawing.Point(519, 33);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 266;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstFORM_TYPE
            // 
            this.lstFORM_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstFORM_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstFORM_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstFORM_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstFORM_TYPE.FormattingEnabled = true;
            this.lstFORM_TYPE.Location = new System.Drawing.Point(121, 59);
            this.lstFORM_TYPE.Name = "lstFORM_TYPE";
            this.lstFORM_TYPE.Size = new System.Drawing.Size(128, 24);
            this.lstFORM_TYPE.TabIndex = 265;
            this.lstFORM_TYPE.W_Clear = false;
            this.lstFORM_TYPE.W_ColArName = "";
            this.lstFORM_TYPE.W_ColEgName = "";
            this.lstFORM_TYPE.W_OldValue = "";
            this.lstFORM_TYPE.W_TableName = "";
            this.lstFORM_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstFORM_TYPE.SelectedIndexChanged += new System.EventHandler(this.lstFORM_TYPE_SelectedIndexChanged);
            // 
            // txtEN_NAME
            // 
            this.txtEN_NAME.BeforeTouchSize = new System.Drawing.Size(128, 25);
            this.txtEN_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEN_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEN_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtEN_NAME.Location = new System.Drawing.Point(369, 33);
            this.txtEN_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEN_NAME.Name = "txtEN_NAME";
            this.txtEN_NAME.Size = new System.Drawing.Size(146, 25);
            this.txtEN_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEN_NAME.TabIndex = 264;
            this.txtEN_NAME.W_Clear = true;
            this.txtEN_NAME.W_ColArName = "";
            this.txtEN_NAME.W_ColEgName = "";
            this.txtEN_NAME.W_OldValue = "";
            this.txtEN_NAME.W_TableName = "";
            // 
            // txtAR_NAME
            // 
            this.txtAR_NAME.BeforeTouchSize = new System.Drawing.Size(128, 25);
            this.txtAR_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAR_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAR_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAR_NAME.Location = new System.Drawing.Point(121, 33);
            this.txtAR_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAR_NAME.Name = "txtAR_NAME";
            this.txtAR_NAME.Size = new System.Drawing.Size(128, 25);
            this.txtAR_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAR_NAME.TabIndex = 263;
            this.txtAR_NAME.W_Clear = true;
            this.txtAR_NAME.W_ColArName = "";
            this.txtAR_NAME.W_ColEgName = "";
            this.txtAR_NAME.W_OldValue = "";
            this.txtAR_NAME.W_TableName = "";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Gap = 0;
            this.myLabel4.Location = new System.Drawing.Point(30, 63);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(84, 18);
            this.myLabel4.TabIndex = 262;
            this.myLabel4.Text = "نوع البرنامج";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = false;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Gap = 0;
            this.myLabel3.Location = new System.Drawing.Point(266, 63);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(97, 18);
            this.myLabel3.TabIndex = 261;
            this.myLabel3.Text = "البرنامج الفرعي";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Gap = 0;
            this.myLabel2.Location = new System.Drawing.Point(255, 40);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(108, 18);
            this.myLabel2.TabIndex = 260;
            this.myLabel2.Text = "الشاشة في البرنامج";
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = false;
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Gap = 0;
            this.myLabel7.Location = new System.Drawing.Point(5, 36);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(108, 18);
            this.myLabel7.TabIndex = 259;
            this.myLabel7.Text = "اسم الشاشة(عربي)";
            // 
            // frmFindForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 379);
            this.Controls.Add(this.lstSUB_FORM);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lstFORM_TYPE);
            this.Controls.Add(this.txtEN_NAME);
            this.Controls.Add(this.txtAR_NAME);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.dgUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Name = "frmFindForms";
            this.Titel = "البحث عن نموذج";
            this.Load += new System.EventHandler(this.frmFindForms_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.dgUser, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtAR_NAME, 0);
            this.Controls.SetChildIndex(this.txtEN_NAME, 0);
            this.Controls.SetChildIndex(this.lstFORM_TYPE, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.lstSUB_FORM, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEN_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAR_NAME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myBottun btnExit;
        private ERP.myBottun btnOk;
        private ERP.myDataGrid dgUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private ERP.myList lstSUB_FORM;
        private ERP.myBottun btnFind;
        private ERP.myList lstFORM_TYPE;
        private ERP.myText txtEN_NAME;
        private ERP.myText txtAR_NAME;
        private ERP.myLabel myLabel4;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel2;
        private ERP.myLabel myLabel7;
    }
}
