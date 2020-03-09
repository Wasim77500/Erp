
namespace ERP.File
{
    partial class frmBranches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBranches));
            this.myLabel1 = new ERP.myLabel();
            this.txtSWID = new ERP.myText();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.nmbBRANCH_NO = new ERP.myNumber();
            this.lstBRANCH_LOCATION = new ERP.myList();
            this.txtBRANCH_ENAME = new ERP.myText();
            this.myLabel9 = new ERP.myLabel();
            this.txtBRANCH_ANAME = new ERP.myText();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.btnSearch = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnNew = new ERP.myBottun();
            this.myLabel10 = new ERP.myLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbBRANCH_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBRANCH_ENAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBRANCH_ANAME)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(140, 34);
            // 
            // myLabel1
            // 
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.myLabel1.Location = new System.Drawing.Point(276, 17);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel1.Size = new System.Drawing.Size(66, 20);
            this.myLabel1.TabIndex = 123;
            this.myLabel1.Text = "رقم الفرع";
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(176, 23);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(24, 68);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(28, 25);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 1;
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
            // nmbBRANCH_NO
            // 
            this.nmbBRANCH_NO.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbBRANCH_NO.BeforeTouchSize = new System.Drawing.Size(176, 23);
            this.nmbBRANCH_NO.DecimalPlaces = 0;
            this.nmbBRANCH_NO.DoubleValue = 0D;
            this.nmbBRANCH_NO.Enabled = false;
            this.nmbBRANCH_NO.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbBRANCH_NO.Location = new System.Drawing.Point(192, 43);
            this.nmbBRANCH_NO.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbBRANCH_NO.MinValue = 0D;
            this.nmbBRANCH_NO.Name = "nmbBRANCH_NO";
            this.nmbBRANCH_NO.NullString = "";
            this.nmbBRANCH_NO.NumberDecimalDigits = 0;
            this.nmbBRANCH_NO.Size = new System.Drawing.Size(176, 23);
            this.nmbBRANCH_NO.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbBRANCH_NO.TabIndex = 191;
            this.nmbBRANCH_NO.Text = "0";
            this.nmbBRANCH_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbBRANCH_NO.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbBRANCH_NO.W_Clear = true;
            this.nmbBRANCH_NO.W_ColArName = "رقم الفرع";
            this.nmbBRANCH_NO.W_ColEgName = "BRANCH_No";
            this.nmbBRANCH_NO.W_OldValue = "";
            this.nmbBRANCH_NO.W_TableName = "BRANCHES";
            // 
            // lstBRANCH_LOCATION
            // 
            this.lstBRANCH_LOCATION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBRANCH_LOCATION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBRANCH_LOCATION.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBRANCH_LOCATION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstBRANCH_LOCATION.FormattingEnabled = true;
            this.lstBRANCH_LOCATION.Location = new System.Drawing.Point(192, 127);
            this.lstBRANCH_LOCATION.Name = "lstBRANCH_LOCATION";
            this.lstBRANCH_LOCATION.Size = new System.Drawing.Size(221, 24);
            this.lstBRANCH_LOCATION.TabIndex = 190;
            this.lstBRANCH_LOCATION.W_Clear = true;
            this.lstBRANCH_LOCATION.W_ColArName = "موقع الفرع";
            this.lstBRANCH_LOCATION.W_ColEgName = "BRANCH_LOCATION";
            this.lstBRANCH_LOCATION.W_OldValue = "";
            this.lstBRANCH_LOCATION.W_TableName = "BRANCHES";
            this.lstBRANCH_LOCATION.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // txtBRANCH_ENAME
            // 
            this.txtBRANCH_ENAME.BeforeTouchSize = new System.Drawing.Size(176, 23);
            this.txtBRANCH_ENAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBRANCH_ENAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBRANCH_ENAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtBRANCH_ENAME.Location = new System.Drawing.Point(192, 98);
            this.txtBRANCH_ENAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBRANCH_ENAME.Name = "txtBRANCH_ENAME";
            this.txtBRANCH_ENAME.Size = new System.Drawing.Size(221, 23);
            this.txtBRANCH_ENAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBRANCH_ENAME.TabIndex = 184;
            this.txtBRANCH_ENAME.W_Clear = true;
            this.txtBRANCH_ENAME.W_ColArName = "اسم الفرع بالانجليزي";
            this.txtBRANCH_ENAME.W_ColEgName = "BRANCH_ENAME";
            this.txtBRANCH_ENAME.W_OldValue = "";
            this.txtBRANCH_ENAME.W_TableName = "BRANCHES";
            // 
            // myLabel9
            // 
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(116, 131);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel9.Size = new System.Drawing.Size(41, 18);
            this.myLabel9.TabIndex = 183;
            this.myLabel9.Text = "الموقع";
            // 
            // txtBRANCH_ANAME
            // 
            this.txtBRANCH_ANAME.BeforeTouchSize = new System.Drawing.Size(176, 23);
            this.txtBRANCH_ANAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBRANCH_ANAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBRANCH_ANAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtBRANCH_ANAME.Location = new System.Drawing.Point(192, 70);
            this.txtBRANCH_ANAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBRANCH_ANAME.Name = "txtBRANCH_ANAME";
            this.txtBRANCH_ANAME.Size = new System.Drawing.Size(221, 23);
            this.txtBRANCH_ANAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBRANCH_ANAME.TabIndex = 180;
            this.txtBRANCH_ANAME.W_Clear = true;
            this.txtBRANCH_ANAME.W_ColArName = "اسم الفرع بالعربي";
            this.txtBRANCH_ANAME.W_ColEgName = "BRANCH_ANAME";
            this.txtBRANCH_ANAME.W_OldValue = "";
            this.txtBRANCH_ANAME.W_TableName = "BRANCHES";
            this.txtBRANCH_ANAME.TextChanged += new System.EventHandler(this.txtBRANCHE_ANAME_TextChanged);
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(90, 107);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(77, 18);
            this.myLabel6.TabIndex = 179;
            this.myLabel6.Text = "اسم الفرع(E)";
            this.myLabel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myLabel6_MouseClick);
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(94, 78);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(75, 18);
            this.myLabel5.TabIndex = 178;
            this.myLabel5.Text = "اسم الفرع(ع)";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.IsBackStageButton = false;
            this.btnSearch.Location = new System.Drawing.Point(371, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 27);
            this.btnSearch.TabIndex = 195;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnSearch.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnSearch.Click += new System.EventHandler(this.myBottun1_Click);
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
            this.btnSave.Location = new System.Drawing.Point(168, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 196;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
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
            this.btnExit.Location = new System.Drawing.Point(292, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 197;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnExit.w_Type = ERP.myBottun.Btton_type.Close;
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
            this.btnUpdate.Location = new System.Drawing.Point(229, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 198;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnNew.Location = new System.Drawing.Point(74, 166);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 199;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // myLabel10
            // 
            this.myLabel10.BackColor = System.Drawing.Color.Transparent;
            this.myLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel10.ForeColor = System.Drawing.Color.Black;
            this.myLabel10.Location = new System.Drawing.Point(103, 47);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel10.Size = new System.Drawing.Size(55, 18);
            this.myLabel10.TabIndex = 200;
            this.myLabel10.Text = "رقم الفرع";
            // 
            // frmBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(449, 207);
            this.Controls.Add(this.myLabel10);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.nmbBRANCH_NO);
            this.Controls.Add(this.lstBRANCH_LOCATION);
            this.Controls.Add(this.txtBRANCH_ENAME);
            this.Controls.Add(this.myLabel9);
            this.Controls.Add(this.txtBRANCH_ANAME);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.txtSWID);
            this.Name = "frmBranches";
            this.PriviFile = ERP.glb_function.ProgramType.File;
            this.Text = "تعريف الفروع";
            this.Titel = "تعريف الفروع";
            this.Load += new System.EventHandler(this.frmBranches_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.txtBRANCH_ANAME, 0);
            this.Controls.SetChildIndex(this.myLabel9, 0);
            this.Controls.SetChildIndex(this.txtBRANCH_ENAME, 0);
            this.Controls.SetChildIndex(this.lstBRANCH_LOCATION, 0);
            this.Controls.SetChildIndex(this.nmbBRANCH_NO, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.myLabel10, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbBRANCH_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBRANCH_ENAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBRANCH_ANAME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private myText txtSWID;
        private System.Windows.Forms.ErrorProvider errCheck;
        private myLabel myLabel1;
        private myNumber nmbBRANCH_NO;
        private myList lstBRANCH_LOCATION;
        private myText txtBRANCH_ENAME;
        private myLabel myLabel9;
        private myText txtBRANCH_ANAME;
        private myLabel myLabel6;
        private myLabel myLabel5;
        private myBottun btnNew;
        private myBottun btnUpdate;
        private myBottun btnExit;
        private myBottun btnSave;
        private myBottun btnSearch;
        private myLabel myLabel10;
    }
}
