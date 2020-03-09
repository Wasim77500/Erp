
namespace ERP.File
{
    partial class frmFindUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myLabel1 = new ERP.myLabel();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.btnFind = new ERP.myBottun();
            this.txtUSER_NAME = new ERP.myText();
            this.txtUSER_LOGIN = new ERP.myText();
            this.lstUSER_BRANCH = new ERP.myList();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.dgUser = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new ERP.myBottun();
            this.btnOk = new ERP.myBottun();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel1.ForeColor = System.Drawing.Color.Black;
            this.myLabel1.Location = new System.Drawing.Point(255, 21);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel1.Size = new System.Drawing.Size(65, 18);
            this.myLabel1.TabIndex = 134;
            this.myLabel1.Text = "اسم الدخول";
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Controls.Add(this.txtUSER_NAME);
            this.myGroupBox1.Controls.Add(this.myLabel1);
            this.myGroupBox1.Controls.Add(this.txtUSER_LOGIN);
            this.myGroupBox1.Controls.Add(this.lstUSER_BRANCH);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(87, 32);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(346, 106);
            this.myGroupBox1.TabIndex = 133;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات الموقع";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(27, 69);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 136;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtUSER_NAME
            // 
            this.txtUSER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSER_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUSER_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtUSER_NAME.Location = new System.Drawing.Point(70, 48);
            this.txtUSER_NAME.Name = "txtUSER_NAME";
            this.txtUSER_NAME.Size = new System.Drawing.Size(163, 25);
            this.txtUSER_NAME.TabIndex = 135;
            this.txtUSER_NAME.W_ColArName = "اسم الموقع";
            this.txtUSER_NAME.W_ColEgName = "LOCATION_NAME";
            this.txtUSER_NAME.W_OldValue = "";
            this.txtUSER_NAME.W_TableName = "LOCATION";
            // 
            // txtUSER_LOGIN
            // 
            this.txtUSER_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSER_LOGIN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUSER_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtUSER_LOGIN.Location = new System.Drawing.Point(70, 19);
            this.txtUSER_LOGIN.Name = "txtUSER_LOGIN";
            this.txtUSER_LOGIN.Size = new System.Drawing.Size(163, 25);
            this.txtUSER_LOGIN.TabIndex = 134;
            this.txtUSER_LOGIN.W_ColArName = "اسم الموقع";
            this.txtUSER_LOGIN.W_ColEgName = "LOCATION_NAME";
            this.txtUSER_LOGIN.W_OldValue = "";
            this.txtUSER_LOGIN.W_TableName = "LOCATION";
            // 
            // lstUSER_BRANCH
            // 
            
            this.lstUSER_BRANCH.Font = new System.Drawing.Font("Tahoma", 8F);
          
            this.lstUSER_BRANCH.Location = new System.Drawing.Point(70, 78);
            this.lstUSER_BRANCH.Name = "lstUSER_BRANCH";
            this.lstUSER_BRANCH.Size = new System.Drawing.Size(163, 21);
            this.lstUSER_BRANCH.TabIndex = 133;
            this.lstUSER_BRANCH.W_ColArName = "الموقع الرئيسي";
            this.lstUSER_BRANCH.W_ColEgName = "PARENT_ID";
            this.lstUSER_BRANCH.W_OldValue = "";
            this.lstUSER_BRANCH.W_TableName = "LOCATION";
            this.lstUSER_BRANCH.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(257, 64);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(47, 18);
            this.myLabel3.TabIndex = 131;
            this.myLabel3.Text = "الفــــرع";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(245, 42);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(75, 18);
            this.myLabel2.TabIndex = 130;
            this.myLabel2.Text = "اسم المستخدم";
            // 
            // dgUser
            // 
            this.dgUser.AllowUserToAddRows = false;
            this.dgUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgUser.EnableHeadersVisualStyles = false;
            this.dgUser.Location = new System.Drawing.Point(13, 143);
            this.dgUser.Name = "dgUser";
            this.dgUser.RowHeadersVisible = false;
            this.dgUser.Size = new System.Drawing.Size(436, 238);
            this.dgUser.TabIndex = 130;
            this.dgUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUser_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم الدخول";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم المستخدم";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الفرع";
            this.Column4.Name = "Column4";
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
            this.btnExit.Location = new System.Drawing.Point(369, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 137;
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
            this.btnOk.Location = new System.Drawing.Point(309, 387);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 138;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnOk.w_Type = ERP.myBottun.Btton_type.OK;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmFindUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(461, 439);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.dgUser);
            this.Name = "frmFindUsers";
            this.Text = "البحث عن المستخدمين";
            this.Titel = "";
            this.Load += new System.EventHandler(this.frmFindUsers_Load);
            this.Controls.SetChildIndex(this.dgUser, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private myLabel myLabel1;
        private myGroupBox myGroupBox1;
        private myBottun btnFind;
        private myText txtUSER_NAME;
        private myText txtUSER_LOGIN;
        private myList lstUSER_BRANCH;
        private myLabel myLabel3;
        private myLabel myLabel2;
        private myDataGrid dgUser;
        private myBottun btnExit;
        private myBottun btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
