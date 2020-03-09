
namespace ERP.File
{
    partial class frmFindLocationData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindLocationData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myLabel1 = new ERP.myLabel();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.btnSearch = new ERP.myBottun();
            this.txtLOCATION_NAME = new ERP.myText();
            this.lstPARENT_ID = new ERP.myList();
            this.lstLOCATION_TYPE = new ERP.myList();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.dgLocation = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new ERP.myBottun();
            this.btnOk = new ERP.myBottun();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel1.ForeColor = System.Drawing.Color.Black;
            this.myLabel1.Location = new System.Drawing.Point(254, 37);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel1.Size = new System.Drawing.Size(63, 18);
            this.myLabel1.TabIndex = 134;
            this.myLabel1.Text = "اسم الموقع";
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.btnSearch);
            this.myGroupBox1.Controls.Add(this.txtLOCATION_NAME);
            this.myGroupBox1.Controls.Add(this.myLabel1);
            this.myGroupBox1.Controls.Add(this.lstPARENT_ID);
            this.myGroupBox1.Controls.Add(this.lstLOCATION_TYPE);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(29, 32);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(346, 128);
            this.myGroupBox1.TabIndex = 133;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات الموقع";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(24, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 135;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtLOCATION_NAME
            // 
            this.txtLOCATION_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLOCATION_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtLOCATION_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtLOCATION_NAME.Location = new System.Drawing.Point(70, 34);
            this.txtLOCATION_NAME.Name = "txtLOCATION_NAME";
            this.txtLOCATION_NAME.Size = new System.Drawing.Size(163, 25);
            this.txtLOCATION_NAME.TabIndex = 134;
            this.txtLOCATION_NAME.W_ColArName = "اسم الموقع";
            this.txtLOCATION_NAME.W_ColEgName = "LOCATION_NAME";
            this.txtLOCATION_NAME.W_OldValue = "";
            this.txtLOCATION_NAME.W_TableName = "LOCATION";
            this.txtLOCATION_NAME.TextChanged += new System.EventHandler(this.txtLOCATION_NAME_TextChanged);
            // 
            // lstPARENT_ID
            // 
          
            this.lstPARENT_ID.Font = new System.Drawing.Font("Tahoma", 8F);
          
            this.lstPARENT_ID.Location = new System.Drawing.Point(70, 90);
            this.lstPARENT_ID.Name = "lstPARENT_ID";
            this.lstPARENT_ID.Size = new System.Drawing.Size(163, 21);
            this.lstPARENT_ID.TabIndex = 133;
            this.lstPARENT_ID.W_ColArName = "الموقع الرئيسي";
            this.lstPARENT_ID.W_ColEgName = "PARENT_ID";
            this.lstPARENT_ID.W_OldValue = "";
            this.lstPARENT_ID.W_TableName = "LOCATION";
            this.lstPARENT_ID.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // lstLOCATION_TYPE
            // 
           
            this.lstLOCATION_TYPE.Font = new System.Drawing.Font("Tahoma", 8F);
      
            this.lstLOCATION_TYPE.Location = new System.Drawing.Point(70, 65);
            this.lstLOCATION_TYPE.Name = "lstLOCATION_TYPE";
            this.lstLOCATION_TYPE.Size = new System.Drawing.Size(163, 21);
            this.lstLOCATION_TYPE.TabIndex = 132;
            this.lstLOCATION_TYPE.W_ColArName = "نوع الموقع";
            this.lstLOCATION_TYPE.W_ColEgName = "LOCATION_TYPE";
            this.lstLOCATION_TYPE.W_OldValue = "";
            this.lstLOCATION_TYPE.W_TableName = "LOCATION";
            this.lstLOCATION_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(239, 87);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(85, 18);
            this.myLabel3.TabIndex = 131;
            this.myLabel3.Text = "الموقع الرئيسي";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(270, 59);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(35, 18);
            this.myLabel2.TabIndex = 130;
            this.myLabel2.Text = "النوع";
            // 
            // dgLocation
            // 
            this.dgLocation.AllowUserToAddRows = false;
            this.dgLocation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgLocation.EnableHeadersVisualStyles = false;
            this.dgLocation.Location = new System.Drawing.Point(12, 166);
            this.dgLocation.Name = "dgLocation";
            this.dgLocation.RowHeadersVisible = false;
            this.dgLocation.Size = new System.Drawing.Size(411, 241);
            this.dgLocation.TabIndex = 130;
            this.dgLocation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLocation_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم الموقع";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "النوع";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الموقع الرئيسي";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ملاحظات";
            this.Column5.Name = "Column5";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(339, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 136;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
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
            this.btnOk.Location = new System.Drawing.Point(280, 413);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 137;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnOk.w_Type = ERP.myBottun.Btton_type.OK;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmFindLocationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(439, 463);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.dgLocation);
            this.Name = "frmFindLocationData";
            this.Text = "البحث عن بيانات الموقع";
            this.Titel = "";
            this.Load += new System.EventHandler(this.frmFindLocationData_Load);
            this.Controls.SetChildIndex(this.dgLocation, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private myLabel myLabel1;
        private myGroupBox myGroupBox1;
        private myText txtLOCATION_NAME;
        private myList lstPARENT_ID;
        private myList lstLOCATION_TYPE;
        private myLabel myLabel3;
        private myLabel myLabel2;
        private myDataGrid dgLocation;
        private myBottun btnSearch;
        private myBottun btnExit;
        private myBottun btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
