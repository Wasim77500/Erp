namespace ERP.Accounts
{
    partial class frmExpensesAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpensesAcc));
            this.btnFin = new ERP.myBottun();
            this.lstAccNo = new ERP.myList();
            this.txtSWId = new ERP.myText();
            this.lstAccName = new ERP.myList();
            this.myLabel6 = new ERP.myLabel();
            this.btnNew = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.txtExp_Name = new ERP.myText();
            this.myLabel2 = new ERP.myLabel();
            this.txtAccNo = new ERP.myText();
            this.myLabel12 = new ERP.myLabel();
            this.lstExp_type = new ERP.myList();
            this.myLabel3 = new ERP.myLabel();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExp_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(120, 34);
            // 
            // btnFin
            // 
            this.btnFin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFin.BackgroundImage")));
            this.btnFin.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFin.FlatAppearance.BorderSize = 0;
            this.btnFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFin.Image = ((System.Drawing.Image)(resources.GetObject("btnFin.Image")));
            this.btnFin.IsBackStageButton = false;
            this.btnFin.Location = new System.Drawing.Point(368, 85);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(28, 27);
            this.btnFin.TabIndex = 233;
            this.btnFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFin.w_Type = ERP.myBottun.Btton_type.Search;
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(115, 33);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(116, 24);
            this.lstAccNo.TabIndex = 232;
            this.lstAccNo.W_Clear = true;
            this.lstAccNo.W_ColArName = "";
            this.lstAccNo.W_ColEgName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.W_TableName = "";
            this.lstAccNo.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // txtSWId
            // 
            this.txtSWId.BeforeTouchSize = new System.Drawing.Size(280, 23);
            this.txtSWId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSWId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWId.Location = new System.Drawing.Point(6, 35);
            this.txtSWId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWId.Name = "txtSWId";
            this.txtSWId.Size = new System.Drawing.Size(41, 23);
            this.txtSWId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWId.TabIndex = 231;
            this.txtSWId.Visible = false;
            this.txtSWId.W_Clear = true;
            this.txtSWId.W_ColArName = "";
            this.txtSWId.W_ColEgName = "";
            this.txtSWId.W_OldValue = "";
            this.txtSWId.W_TableName = "";
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(233, 33);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(162, 24);
            this.lstAccName.TabIndex = 230;
            this.lstAccName.W_Clear = true;
            this.lstAccName.W_ColArName = "";
            this.lstAccName.W_ColEgName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.W_TableName = "";
            this.lstAccName.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(42, 40);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(64, 18);
            this.myLabel6.TabIndex = 229;
            this.myLabel6.Text = "حساب الاب";
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.IsBackStageButton = false;
            this.btnNew.Location = new System.Drawing.Point(58, 145);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 228;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.IsBackStageButton = false;
            this.btnUpdate.Location = new System.Drawing.Point(198, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 227;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.IsBackStageButton = false;
            this.btnExit.Location = new System.Drawing.Point(261, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 226;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(137, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 225;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtExp_Name
            // 
            this.txtExp_Name.BeforeTouchSize = new System.Drawing.Size(280, 23);
            this.txtExp_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExp_Name.Font = new System.Drawing.Font("Arial", 10F);
            this.txtExp_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtExp_Name.Location = new System.Drawing.Point(115, 88);
            this.txtExp_Name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtExp_Name.Name = "txtExp_Name";
            this.txtExp_Name.Size = new System.Drawing.Size(238, 23);
            this.txtExp_Name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtExp_Name.TabIndex = 217;
            this.txtExp_Name.W_Clear = true;
            this.txtExp_Name.W_ColArName = "اسم حساب المصروف";
            this.txtExp_Name.W_ColEgName = "acc_name";
            this.txtExp_Name.W_OldValue = "";
            this.txtExp_Name.W_TableName = "accounts";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(34, 91);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(80, 18);
            this.myLabel2.TabIndex = 216;
            this.myLabel2.Text = "اسم المصروف";
            // 
            // txtAccNo
            // 
            this.txtAccNo.BeforeTouchSize = new System.Drawing.Size(280, 23);
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtAccNo.Location = new System.Drawing.Point(115, 62);
            this.txtAccNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(280, 23);
            this.txtAccNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAccNo.TabIndex = 215;
            this.txtAccNo.W_Clear = true;
            this.txtAccNo.W_ColArName = "";
            this.txtAccNo.W_ColEgName = "";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.W_TableName = "";
            // 
            // myLabel12
            // 
            this.myLabel12.BackColor = System.Drawing.Color.Transparent;
            this.myLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel12.ForeColor = System.Drawing.Color.Black;
            this.myLabel12.Location = new System.Drawing.Point(42, 69);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel12.Size = new System.Drawing.Size(67, 18);
            this.myLabel12.TabIndex = 214;
            this.myLabel12.Text = "رقم الحساب";
            // 
            // lstExp_type
            // 
            this.lstExp_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstExp_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstExp_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstExp_type.Font = new System.Drawing.Font("Arial", 10F);
            this.lstExp_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstExp_type.FormattingEnabled = true;
            this.lstExp_type.Items.AddRange(new object[] {
            "عهدة",
            "مبيعات",
            "صرف و قبض"});
            this.lstExp_type.Location = new System.Drawing.Point(115, 115);
            this.lstExp_type.Name = "lstExp_type";
            this.lstExp_type.Size = new System.Drawing.Size(280, 24);
            this.lstExp_type.TabIndex = 218;
            this.lstExp_type.W_Clear = true;
            this.lstExp_type.W_ColArName = "";
            this.lstExp_type.W_ColEgName = "";
            this.lstExp_type.W_OldValue = "";
            this.lstExp_type.W_TableName = "";
            this.lstExp_type.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(34, 117);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(81, 18);
            this.myLabel3.TabIndex = 219;
            this.myLabel3.Text = "نوع المصروف";
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // frmExpensesAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(409, 192);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.txtSWId);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.lstExp_type);
            this.Controls.Add(this.txtExp_Name);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.myLabel12);
            this.Name = "frmExpensesAcc";
            this.Titel = "تعريف المصاريف";
            this.Load += new System.EventHandler(this.frmExpensesAcc_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel12, 0);
            this.Controls.SetChildIndex(this.txtAccNo, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.txtExp_Name, 0);
            this.Controls.SetChildIndex(this.lstExp_type, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.txtSWId, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.btnFin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExp_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ERP.myBottun btnFin;
        private ERP.myList lstAccNo;
        private ERP.myText txtSWId;
        private ERP.myList lstAccName;
        private ERP.myLabel myLabel6;
        private ERP.myBottun btnNew;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnExit;
        private ERP.myBottun btnSave;
        private ERP.myText txtExp_Name;
        private ERP.myLabel myLabel2;
        private ERP.myText txtAccNo;
        private ERP.myLabel myLabel12;
        private ERP.myList lstExp_type;
        private ERP.myLabel myLabel3;
        private System.Windows.Forms.ErrorProvider errCheck;
    }
}
