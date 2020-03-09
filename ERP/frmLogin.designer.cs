namespace ERP
{
    partial class frmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbxUserLogin = new System.Windows.Forms.PictureBox();
            this.lstYear = new ERP.myList();
            this.myBottun1 = new ERP.myBottun();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(105, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(18, 34);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ERP.Properties.Resources.Password;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(275, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 26);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::ERP.Properties.Resources.UserName;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(275, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 26);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPassword.Location = new System.Drawing.Point(69, 252);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(229, 35);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Text = "كلمة السر";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUserid
            // 
            this.txtUserid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txtUserid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserid.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserid.ForeColor = System.Drawing.Color.Silver;
            this.txtUserid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUserid.Location = new System.Drawing.Point(69, 215);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserid.Size = new System.Drawing.Size(229, 35);
            this.txtUserid.TabIndex = 0;
            this.txtUserid.Text = "اسم المستخدم";
            this.txtUserid.TextChanged += new System.EventHandler(this.txtUserid_TextChanged);
            this.txtUserid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserid_KeyDown);
            this.txtUserid.Leave += new System.EventHandler(this.txtUserid_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(69, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(229, 41);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbxUserLogin
            // 
            this.pbxUserLogin.BackgroundImage = global::ERP.Properties.Resources.ssm_01;
            this.pbxUserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUserLogin.Location = new System.Drawing.Point(134, 65);
            this.pbxUserLogin.Name = "pbxUserLogin";
            this.pbxUserLogin.Size = new System.Drawing.Size(89, 102);
            this.pbxUserLogin.TabIndex = 19;
            this.pbxUserLogin.TabStop = false;
            // 
            // lstYear
            // 
            this.lstYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstYear.Font = new System.Drawing.Font("Arial", 10F);
            this.lstYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstYear.FormattingEnabled = true;
            this.lstYear.Items.AddRange(new object[] {
            "2017"});
            this.lstYear.Location = new System.Drawing.Point(69, 185);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(229, 24);
            this.lstYear.TabIndex = 20;
            this.lstYear.W_Clear = true;
            this.lstYear.W_ColArName = "";
            this.lstYear.W_ColEgName = "";
            this.lstYear.W_OldValue = "";
            this.lstYear.W_TableName = "";
            this.lstYear.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // myBottun1
            // 
            this.myBottun1.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.myBottun1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun1.FlatAppearance.BorderSize = 0;
            this.myBottun1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBottun1.IsBackStageButton = false;
            this.myBottun1.Location = new System.Drawing.Point(4, 119);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(56, 28);
            this.myBottun1.TabIndex = 21;
            this.myBottun1.Text = "myBottun1";
            this.myBottun1.Visible = false;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.none;
            this.myBottun1.Click += new System.EventHandler(this.myBottun1_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 354);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.pbxUserLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserid);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Titel = "تسجيل الدخول";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.txtUserid, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pbxUserLogin, 0);
            this.Controls.SetChildIndex(this.lstYear, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbxUserLogin;
        private ERP.myList lstYear;
        private myBottun myBottun1;
    }
}