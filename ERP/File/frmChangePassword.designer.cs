
namespace ERP.File
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.myBottun1 = new myBottun();
            this.btnSave = new myBottun();
            this.txtOldPassword = new myText();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new myText();
            this._lblFieldLabel_1 = new System.Windows.Forms.Label();
            this.txtPassword = new myText();
            this.SuspendLayout();
            // 
            // myBottun1
            // 
            this.myBottun1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myBottun1.BackgroundImage")));
            this.myBottun1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun1.FlatAppearance.BorderSize = 0;
            this.myBottun1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBottun1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.myBottun1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myBottun1.Image = ((System.Drawing.Image)(resources.GetObject("myBottun1.Image")));
            this.myBottun1.Location = new System.Drawing.Point(166, 141);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 66;
            this.myBottun1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = myBottun.Btton_type.Close;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(103, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 67;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = myBottun.Btton_Priv.none;
            this.btnSave.w_Type = myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtOldPassword.Location = new System.Drawing.Point(145, 46);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(149, 27);
            this.txtOldPassword.TabIndex = 73;
            this.txtOldPassword.W_ColArName = "";
            this.txtOldPassword.W_ColEgName = "";
            this.txtOldPassword.W_OldValue = "";
            this.txtOldPassword.W_TableName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = ":  كلمة السر السابقة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 108);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = ":  تأكد كلمة السر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPass.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(145, 104);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(149, 25);
            this.txtConfirmPass.TabIndex = 70;
            this.txtConfirmPass.W_ColArName = "";
            this.txtConfirmPass.W_ColEgName = "";
            this.txtConfirmPass.W_OldValue = "";
            this.txtConfirmPass.W_TableName = "";
            // 
            // _lblFieldLabel_1
            // 
            this._lblFieldLabel_1.AutoSize = true;
            this._lblFieldLabel_1.BackColor = System.Drawing.Color.Transparent;
            this._lblFieldLabel_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblFieldLabel_1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this._lblFieldLabel_1.ForeColor = System.Drawing.Color.Black;
            this._lblFieldLabel_1.Location = new System.Drawing.Point(58, 80);
            this._lblFieldLabel_1.Name = "_lblFieldLabel_1";
            this._lblFieldLabel_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblFieldLabel_1.Size = new System.Drawing.Size(68, 18);
            this._lblFieldLabel_1.TabIndex = 69;
            this._lblFieldLabel_1.Text = ":  كلمة السر";
            this._lblFieldLabel_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPassword.Location = new System.Drawing.Point(145, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(149, 25);
            this.txtPassword.TabIndex = 68;
            this.txtPassword.W_ColArName = "";
            this.txtPassword.W_ColEgName = "";
            this.txtPassword.W_OldValue = "";
            this.txtPassword.W_TableName = "";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(322, 197);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this._lblFieldLabel_1);
            this.Controls.Add(this.txtPassword);
            this.Name = "frmChangePassword";
            this.PriviFile = glb_function.ProgramType.File;
            this.Titel = "تغيير كلمة السر";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this._lblFieldLabel_1, 0);
            this.Controls.SetChildIndex(this.txtConfirmPass, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtOldPassword, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myBottun myBottun1;
        private myBottun btnSave;
        private myText txtOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private myText txtConfirmPass;
        private System.Windows.Forms.Label _lblFieldLabel_1;
        private myText txtPassword;
    }
}
