namespace ERP.File
{
    partial class frmUserComputers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserComputers));
            this.myLabel4 = new ERP.myLabel();
            this.txtUSER_LOGIN = new ERP.myText();
            this.txtSWID = new ERP.myText();
            this.txtUSER_NAME = new ERP.myText();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.txtDEVICE_USERNAME = new ERP.myText();
            this.dgUserComp = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new ERP.myBottun();
            this.txtDEVICE_CODE = new ERP.myText();
            this.txtDEVICE_NAME = new ERP.myText();
            this.myLabel5 = new ERP.myLabel();
            this.myLabel6 = new ERP.myLabel();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_LOGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEVICE_USERNAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEVICE_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEVICE_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = false;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.DX = 190;
            this.myLabel4.DY = 5;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.LabeledControl = this.txtUSER_LOGIN;
            this.myLabel4.Location = new System.Drawing.Point(8, 36);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(83, 18);
            this.myLabel4.TabIndex = 179;
            this.myLabel4.Text = "اسم الدخول";
            // 
            // txtUSER_LOGIN
            // 
            this.txtUSER_LOGIN.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtUSER_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSER_LOGIN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUSER_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtUSER_LOGIN.Location = new System.Drawing.Point(102, 31);
            this.txtUSER_LOGIN.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUSER_LOGIN.Name = "txtUSER_LOGIN";
            this.txtUSER_LOGIN.Size = new System.Drawing.Size(179, 25);
            this.txtUSER_LOGIN.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtUSER_LOGIN.TabIndex = 176;
            this.txtUSER_LOGIN.W_ColArName = "اسم دخول المستخدم";
            this.txtUSER_LOGIN.W_ColEgName = "USER_LOGIN";
            this.txtUSER_LOGIN.W_OldValue = "";
            this.txtUSER_LOGIN.W_TableName = "USERINFO";
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(310, 36);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(28, 25);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 178;
            this.txtSWID.Visible = false;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // txtUSER_NAME
            // 
            this.txtUSER_NAME.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtUSER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSER_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUSER_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtUSER_NAME.Location = new System.Drawing.Point(102, 62);
            this.txtUSER_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUSER_NAME.Name = "txtUSER_NAME";
            this.txtUSER_NAME.Size = new System.Drawing.Size(179, 25);
            this.txtUSER_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtUSER_NAME.TabIndex = 177;
            this.txtUSER_NAME.W_ColArName = "اسم المستخدم";
            this.txtUSER_NAME.W_ColEgName = "USER_NAME";
            this.txtUSER_NAME.W_OldValue = "";
            this.txtUSER_NAME.W_TableName = "USERINFO";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = false;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.DX = 190;
            this.myLabel3.DY = 5;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.LabeledControl = this.txtUSER_NAME;
            this.myLabel3.Location = new System.Drawing.Point(8, 67);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(83, 18);
            this.myLabel3.TabIndex = 175;
            this.myLabel3.Text = "اسم المستخدم";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = false;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(7, 175);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(93, 18);
            this.myLabel2.TabIndex = 180;
            this.myLabel2.Text = "رقم تفعيل الجهاز";
            // 
            // txtDEVICE_USERNAME
            // 
            this.txtDEVICE_USERNAME.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtDEVICE_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDEVICE_USERNAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDEVICE_USERNAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDEVICE_USERNAME.Location = new System.Drawing.Point(102, 140);
            this.txtDEVICE_USERNAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDEVICE_USERNAME.Name = "txtDEVICE_USERNAME";
            this.txtDEVICE_USERNAME.Size = new System.Drawing.Size(179, 25);
            this.txtDEVICE_USERNAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDEVICE_USERNAME.TabIndex = 181;
            this.txtDEVICE_USERNAME.W_ColArName = "اسم المستخدم";
            this.txtDEVICE_USERNAME.W_ColEgName = "USER_NAME";
            this.txtDEVICE_USERNAME.W_OldValue = "";
            this.txtDEVICE_USERNAME.W_TableName = "USERINFO";
            // 
            // dgUserComp
            // 
            this.dgUserComp.AllowUserToAddRows = false;
            this.dgUserComp.AllowUserToDeleteRows = false;
            this.dgUserComp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUserComp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUserComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgUserComp.EnableHeadersVisualStyles = false;
            this.dgUserComp.Location = new System.Drawing.Point(8, 202);
            this.dgUserComp.Name = "dgUserComp";
            this.dgUserComp.RowHeadersVisible = false;
            this.dgUserComp.Size = new System.Drawing.Size(348, 193);
            this.dgUserComp.TabIndex = 182;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم الجهاز";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "مستخدم الجهاز";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "رمز التفعيل";
            this.Column4.Name = "Column4";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.Image = global::ERP.Properties.Resources.Add_h;
            this.btnAdd.Location = new System.Drawing.Point(310, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 25);
            this.btnAdd.TabIndex = 183;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDEVICE_CODE
            // 
            this.txtDEVICE_CODE.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtDEVICE_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDEVICE_CODE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDEVICE_CODE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDEVICE_CODE.Location = new System.Drawing.Point(102, 171);
            this.txtDEVICE_CODE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDEVICE_CODE.Name = "txtDEVICE_CODE";
            this.txtDEVICE_CODE.Size = new System.Drawing.Size(179, 25);
            this.txtDEVICE_CODE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDEVICE_CODE.TabIndex = 184;
            this.txtDEVICE_CODE.W_ColArName = "اسم المستخدم";
            this.txtDEVICE_CODE.W_ColEgName = "USER_NAME";
            this.txtDEVICE_CODE.W_OldValue = "";
            this.txtDEVICE_CODE.W_TableName = "USERINFO";
            // 
            // txtDEVICE_NAME
            // 
            this.txtDEVICE_NAME.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.txtDEVICE_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDEVICE_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDEVICE_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDEVICE_NAME.Location = new System.Drawing.Point(102, 109);
            this.txtDEVICE_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDEVICE_NAME.Name = "txtDEVICE_NAME";
            this.txtDEVICE_NAME.Size = new System.Drawing.Size(179, 25);
            this.txtDEVICE_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDEVICE_NAME.TabIndex = 185;
            this.txtDEVICE_NAME.W_ColArName = "اسم المستخدم";
            this.txtDEVICE_NAME.W_ColEgName = "USER_NAME";
            this.txtDEVICE_NAME.W_OldValue = "";
            this.txtDEVICE_NAME.W_TableName = "USERINFO";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = false;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(17, 114);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(79, 18);
            this.myLabel5.TabIndex = 186;
            this.myLabel5.Text = "اسم الجهاز";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = false;
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(12, 147);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(84, 18);
            this.myLabel6.TabIndex = 187;
            this.myLabel6.Text = "مستخدم الجهاز";
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // frmUserComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(363, 401);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.txtDEVICE_NAME);
            this.Controls.Add(this.txtDEVICE_CODE);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgUserComp);
            this.Controls.Add(this.txtDEVICE_USERNAME);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.txtUSER_NAME);
            this.Controls.Add(this.txtUSER_LOGIN);
            this.Controls.Add(this.myLabel3);
            this.Name = "frmUserComputers";
            this.Load += new System.EventHandler(this.frmUserComputers_Load);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.txtUSER_LOGIN, 0);
            this.Controls.SetChildIndex(this.txtUSER_NAME, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtDEVICE_USERNAME, 0);
            this.Controls.SetChildIndex(this.dgUserComp, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.txtDEVICE_CODE, 0);
            this.Controls.SetChildIndex(this.txtDEVICE_NAME, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_LOGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEVICE_USERNAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEVICE_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEVICE_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myLabel myLabel4;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel2;
        private ERP.myText txtDEVICE_USERNAME;
        private ERP.myDataGrid dgUserComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private ERP.myBottun btnAdd;
        private ERP.myText txtDEVICE_CODE;
        private ERP.myText txtDEVICE_NAME;
        private ERP.myLabel myLabel5;
        private ERP.myLabel myLabel6;
        public ERP.myText txtUSER_LOGIN;
        public ERP.myText txtSWID;
        public ERP.myText txtUSER_NAME;
        private System.Windows.Forms.ErrorProvider errCheck;
    }
}
