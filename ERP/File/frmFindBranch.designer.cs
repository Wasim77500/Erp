
namespace ERP.File
{
    partial class frmFindBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindBranch));
            this.myLabel1 = new ERP.myLabel();
            this.dgBranches = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.myLabel3 = new ERP.myLabel();
            this.txtBRANCHE_ANAME = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.btnFind = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.myBottun2 = new ERP.myBottun();
            this.txtBranchNo = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBRANCHE_ANAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchNo)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // myLabel1
            // 
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.myLabel1.Location = new System.Drawing.Point(300, 57);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel1.Size = new System.Drawing.Size(66, 20);
            this.myLabel1.TabIndex = 134;
            this.myLabel1.Text = "رقم الفرع";
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
            this.Column4,
            this.Column5});
            this.dgBranches.EnableHeadersVisualStyles = false;
            this.dgBranches.Location = new System.Drawing.Point(13, 128);
            this.dgBranches.Name = "dgBranches";
            this.dgBranches.RowHeadersVisible = false;
            this.dgBranches.Size = new System.Drawing.Size(439, 252);
            this.dgBranches.TabIndex = 131;
            this.dgBranches.W_Clear = true;
            this.dgBranches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBranches_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم الفرع";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم الفرع";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "العنوان";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "رقم التلفون";
            this.Column5.Name = "Column5";
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtBranchNo);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.txtBRANCHE_ANAME);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(63, 32);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(346, 88);
            this.myGroupBox1.TabIndex = 130;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات الفــرع";
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
            this.myLabel3.Size = new System.Drawing.Size(55, 18);
            this.myLabel3.TabIndex = 123;
            this.myLabel3.Text = "رقم الفرع";
            // 
            // txtBRANCHE_ANAME
            // 
            this.txtBRANCHE_ANAME.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtBRANCHE_ANAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBRANCHE_ANAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBRANCHE_ANAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtBRANCHE_ANAME.Location = new System.Drawing.Point(78, 55);
            this.txtBRANCHE_ANAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBRANCHE_ANAME.Name = "txtBRANCHE_ANAME";
            this.txtBRANCHE_ANAME.Size = new System.Drawing.Size(163, 25);
            this.txtBRANCHE_ANAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBRANCHE_ANAME.TabIndex = 134;
            this.txtBRANCHE_ANAME.W_Clear = true;
            this.txtBRANCHE_ANAME.W_ColArName = "اسم الموقع";
            this.txtBRANCHE_ANAME.W_ColEgName = "LOCATION_NAME";
            this.txtBRANCHE_ANAME.W_OldValue = "";
            this.txtBRANCHE_ANAME.W_TableName = "LOCATION";
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
            this.myLabel2.Size = new System.Drawing.Size(57, 18);
            this.myLabel2.TabIndex = 130;
            this.myLabel2.Text = "اسم الفرع";
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
            this.myBottun1.Location = new System.Drawing.Point(396, 386);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 135;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
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
            this.myBottun2.Location = new System.Drawing.Point(336, 386);
            this.myBottun2.Name = "myBottun2";
            this.myBottun2.Size = new System.Drawing.Size(57, 28);
            this.myBottun2.TabIndex = 136;
            this.myBottun2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun2.UseVisualStyleBackColor = true;
            this.myBottun2.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun2.w_Type = ERP.myBottun.Btton_type.OK;
            this.myBottun2.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtBranchNo
            // 
            this.txtBranchNo.BeforeTouchSize = new System.Drawing.Size(163, 25);
            this.txtBranchNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchNo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBranchNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtBranchNo.Location = new System.Drawing.Point(78, 24);
            this.txtBranchNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBranchNo.Name = "txtBranchNo";
            this.txtBranchNo.Size = new System.Drawing.Size(163, 25);
            this.txtBranchNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBranchNo.TabIndex = 135;
            this.txtBranchNo.W_Clear = true;
            this.txtBranchNo.W_ColArName = "اسم الموقع";
            this.txtBranchNo.W_ColEgName = "LOCATION_NAME";
            this.txtBranchNo.W_OldValue = "";
            this.txtBranchNo.W_TableName = "LOCATION";
            // 
            // frmFindBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(465, 425);
            this.Controls.Add(this.myBottun2);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.dgBranches);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.myLabel1);
            this.Name = "frmFindBranch";
            this.Text = "البحث عن الفرع";
            this.Titel = "";
            this.Load += new System.EventHandler(this.frmFindBranch_Load);
            this.Controls.SetChildIndex(this.myLabel1, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgBranches, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.myBottun2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBRANCHE_ANAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myLabel myLabel1;
        private myDataGrid dgBranches;
        private myGroupBox myGroupBox1;
        private myText txtBRANCHE_ANAME;
        private myLabel myLabel2;
        private myBottun btnFind;
        private myBottun myBottun1;
        private myBottun myBottun2;
        private myLabel myLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private myText txtBranchNo;
    }
}
