namespace ERP.Inventory
{
    partial class frmProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProperties));
            this.myLabel2 = new ERP.myLabel();
            this.btnUpdate = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.lstProperty_name = new ERP.myList();
            this.btnNew = new ERP.myBottun();
            this.txtSWID = new ERP.myText();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstPROPERTY_TYPE = new ERP.myList();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel4 = new ERP.myLabel();
            this.txtPROPERTY_NAME_EN = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPROPERTY_NAME_EN)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(70, 34);
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(28, 50);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(72, 18);
            this.myLabel2.TabIndex = 4;
            this.myLabel2.Text = "اسم الخاصية";
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
            this.btnUpdate.Location = new System.Drawing.Point(159, 132);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnSave.Location = new System.Drawing.Point(102, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 16;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnExit.Location = new System.Drawing.Point(216, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // lstProperty_name
            // 
            this.lstProperty_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstProperty_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstProperty_name.Font = new System.Drawing.Font("Arial", 10F);
            this.lstProperty_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstProperty_name.FormattingEnabled = true;
            this.lstProperty_name.Location = new System.Drawing.Point(106, 47);
            this.lstProperty_name.Name = "lstProperty_name";
            this.lstProperty_name.Size = new System.Drawing.Size(176, 24);
            this.lstProperty_name.TabIndex = 19;
            this.lstProperty_name.W_Clear = true;
            this.lstProperty_name.W_ColArName = "اسم الخاصية";
            this.lstProperty_name.W_ColEgName = "property_name";
            this.lstProperty_name.W_OldValue = "";
            this.lstProperty_name.W_TableName = "properties";
            this.lstProperty_name.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstProperty_name.SelectedIndexChanged += new System.EventHandler(this.lstProperty_name_SelectedIndexChanged);
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
            this.btnNew.Location = new System.Drawing.Point(34, 132);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 20;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(176, 23);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(279, 137);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(55, 23);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 21;
            this.txtSWID.Visible = false;
            this.txtSWID.W_Clear = true;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // lstPROPERTY_TYPE
            // 
            this.lstPROPERTY_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstPROPERTY_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstPROPERTY_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPROPERTY_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstPROPERTY_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstPROPERTY_TYPE.FormattingEnabled = true;
            this.lstPROPERTY_TYPE.Items.AddRange(new object[] {
            "عام",
            "وحيد للكل",
            "وحيد للتصنيف",
            "ضمانة بالوقت",
            "ضمانة عداد"});
            this.lstPROPERTY_TYPE.Location = new System.Drawing.Point(106, 102);
            this.lstPROPERTY_TYPE.Name = "lstPROPERTY_TYPE";
            this.lstPROPERTY_TYPE.Size = new System.Drawing.Size(176, 24);
            this.lstPROPERTY_TYPE.TabIndex = 22;
            this.lstPROPERTY_TYPE.W_Clear = true;
            this.lstPROPERTY_TYPE.W_ColArName = "اسم الخاصية";
            this.lstPROPERTY_TYPE.W_ColEgName = "property_name";
            this.lstPROPERTY_TYPE.W_OldValue = "";
            this.lstPROPERTY_TYPE.W_TableName = "properties";
            this.lstPROPERTY_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(28, 105);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(73, 18);
            this.myLabel3.TabIndex = 23;
            this.myLabel3.Text = "نوع الخاصية";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(15, 77);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(85, 18);
            this.myLabel4.TabIndex = 24;
            this.myLabel4.Text = "الاسم بالنجليزي";
            // 
            // txtPROPERTY_NAME_EN
            // 
            this.txtPROPERTY_NAME_EN.BeforeTouchSize = new System.Drawing.Size(176, 23);
            this.txtPROPERTY_NAME_EN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPROPERTY_NAME_EN.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPROPERTY_NAME_EN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPROPERTY_NAME_EN.Location = new System.Drawing.Point(106, 75);
            this.txtPROPERTY_NAME_EN.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPROPERTY_NAME_EN.Name = "txtPROPERTY_NAME_EN";
            this.txtPROPERTY_NAME_EN.Size = new System.Drawing.Size(176, 23);
            this.txtPROPERTY_NAME_EN.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPROPERTY_NAME_EN.TabIndex = 25;
            this.txtPROPERTY_NAME_EN.W_Clear = true;
            this.txtPROPERTY_NAME_EN.W_ColArName = "";
            this.txtPROPERTY_NAME_EN.W_ColEgName = "";
            this.txtPROPERTY_NAME_EN.W_OldValue = "";
            this.txtPROPERTY_NAME_EN.W_TableName = "";
            // 
            // frmProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(308, 172);
            this.Controls.Add(this.txtPROPERTY_NAME_EN);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.lstPROPERTY_TYPE);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstProperty_name);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.myLabel2);
            this.Name = "frmProperties";
            this.Titel = "تعريف الخصائص";
            this.Load += new System.EventHandler(this.frmProperties_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.lstProperty_name, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.lstPROPERTY_TYPE, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtPROPERTY_NAME_EN, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPROPERTY_NAME_EN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myLabel myLabel2;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnSave;
        private ERP.myBottun btnExit;
        private ERP.myList lstProperty_name;
        private ERP.myBottun btnNew;
        private ERP.myText txtSWID;
        private System.Windows.Forms.ErrorProvider errCheck;
        private ERP.myLabel myLabel3;
        private ERP.myList lstPROPERTY_TYPE;
        private myLabel myLabel4;
        private myText txtPROPERTY_NAME_EN;
    }
}
