
namespace ERP.File
{
    partial class frmDepartements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartements));
            this.myLabel1 = new ERP.myLabel();
            this.txtSWID = new ERP.myText();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.nmbDept_No = new ERP.myNumber();
            this.lstBRANCH_Id = new ERP.myList();
            this.txtDept_EMAIL = new ERP.myText();
            this.txtDept_TEL = new ERP.myText();
            this.txtDept_FAX = new ERP.myText();
            this.txtDept_EADDRESS = new ERP.myText();
            this.txtDept_AADDRESS = new ERP.myText();
            this.txtDept_ENAME = new ERP.myText();
            this.myLabel9 = new ERP.myLabel();
            this.myLabel8 = new ERP.myLabel();
            this.myLabel7 = new ERP.myLabel();
            this.txtDept_ANAME = new ERP.myText();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.btnSearch = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.btnExit = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnNew = new ERP.myBottun();
            this.myLabel10 = new ERP.myLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDept_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_EMAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_TEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_FAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_EADDRESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_AADDRESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_ENAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_ANAME)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(149, 34);
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
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(221, 23);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(0, 0);
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
            // nmbDept_No
            // 
            this.nmbDept_No.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbDept_No.BeforeTouchSize = new System.Drawing.Size(221, 23);
            this.nmbDept_No.DecimalPlaces = 0;
            this.nmbDept_No.DoubleValue = 0D;
            this.nmbDept_No.Enabled = false;
            this.nmbDept_No.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbDept_No.Location = new System.Drawing.Point(192, 82);
            this.nmbDept_No.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbDept_No.MinValue = 0D;
            this.nmbDept_No.Name = "nmbDept_No";
            this.nmbDept_No.NullString = "";
            this.nmbDept_No.NumberDecimalDigits = 0;
            this.nmbDept_No.Size = new System.Drawing.Size(176, 23);
            this.nmbDept_No.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbDept_No.TabIndex = 191;
            this.nmbDept_No.Text = "0";
            this.nmbDept_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbDept_No.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbDept_No.W_Clear = true;
            this.nmbDept_No.W_ColArName = "رقم الفرع";
            this.nmbDept_No.W_ColEgName = "BRANCHE_ID";
            this.nmbDept_No.W_OldValue = "";
            this.nmbDept_No.W_TableName = "DEPARTEMENTS";
            // 
            // lstBRANCH_Id
            // 
            this.lstBRANCH_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBRANCH_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBRANCH_Id.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBRANCH_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstBRANCH_Id.FormattingEnabled = true;
            this.lstBRANCH_Id.Location = new System.Drawing.Point(192, 52);
            this.lstBRANCH_Id.Name = "lstBRANCH_Id";
            this.lstBRANCH_Id.Size = new System.Drawing.Size(221, 24);
            this.lstBRANCH_Id.TabIndex = 190;
            this.lstBRANCH_Id.W_Clear = true;
            this.lstBRANCH_Id.W_ColArName = "الفرع";
            this.lstBRANCH_Id.W_ColEgName = "BRANCH_ID";
            this.lstBRANCH_Id.W_OldValue = "";
            this.lstBRANCH_Id.W_TableName = "DEPARTEMENTS";
            this.lstBRANCH_Id.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstBRANCH_Id.SelectedIndexChanged += new System.EventHandler(this.lstBRANCH_Id_SelectedIndexChanged);
            // 
            // txtDept_EMAIL
            // 
            this.txtDept_EMAIL.BeforeTouchSize = new System.Drawing.Size(221, 23);
            this.txtDept_EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDept_EMAIL.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDept_EMAIL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDept_EMAIL.Location = new System.Drawing.Point(192, 277);
            this.txtDept_EMAIL.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDept_EMAIL.Name = "txtDept_EMAIL";
            this.txtDept_EMAIL.Size = new System.Drawing.Size(221, 23);
            this.txtDept_EMAIL.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDept_EMAIL.TabIndex = 189;
            this.txtDept_EMAIL.W_Clear = true;
            this.txtDept_EMAIL.W_ColArName = "البريد الالكتروني";
            this.txtDept_EMAIL.W_ColEgName = "BRANCHE_EMAIL";
            this.txtDept_EMAIL.W_OldValue = "";
            this.txtDept_EMAIL.W_TableName = "DEPARTEMENTS";
            // 
            // txtDept_TEL
            // 
            this.txtDept_TEL.BeforeTouchSize = new System.Drawing.Size(221, 23);
            this.txtDept_TEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDept_TEL.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDept_TEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDept_TEL.Location = new System.Drawing.Point(192, 221);
            this.txtDept_TEL.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDept_TEL.Name = "txtDept_TEL";
            this.txtDept_TEL.Size = new System.Drawing.Size(221, 23);
            this.txtDept_TEL.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDept_TEL.TabIndex = 188;
            this.txtDept_TEL.W_Clear = true;
            this.txtDept_TEL.W_ColArName = "رقم التلفون";
            this.txtDept_TEL.W_ColEgName = "BRANCHE_TEL";
            this.txtDept_TEL.W_OldValue = "";
            this.txtDept_TEL.W_TableName = "DEPARTEMENTS";
            this.txtDept_TEL.TextChanged += new System.EventHandler(this.txtBRANCHE_TEL_TextChanged);
            // 
            // txtDept_FAX
            // 
            this.txtDept_FAX.BeforeTouchSize = new System.Drawing.Size(221, 23);
            this.txtDept_FAX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDept_FAX.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDept_FAX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDept_FAX.Location = new System.Drawing.Point(192, 249);
            this.txtDept_FAX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDept_FAX.Name = "txtDept_FAX";
            this.txtDept_FAX.Size = new System.Drawing.Size(221, 23);
            this.txtDept_FAX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDept_FAX.TabIndex = 187;
            this.txtDept_FAX.W_Clear = true;
            this.txtDept_FAX.W_ColArName = "رقم الفاكس";
            this.txtDept_FAX.W_ColEgName = "BRANCHE_FAX";
            this.txtDept_FAX.W_OldValue = "";
            this.txtDept_FAX.W_TableName = "DEPARTEMENTS";
            // 
            // txtDept_EADDRESS
            // 
            this.txtDept_EADDRESS.BeforeTouchSize = new System.Drawing.Size(221, 23);
            this.txtDept_EADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDept_EADDRESS.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDept_EADDRESS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDept_EADDRESS.Location = new System.Drawing.Point(192, 193);
            this.txtDept_EADDRESS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDept_EADDRESS.Name = "txtDept_EADDRESS";
            this.txtDept_EADDRESS.Size = new System.Drawing.Size(221, 23);
            this.txtDept_EADDRESS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDept_EADDRESS.TabIndex = 186;
            this.txtDept_EADDRESS.W_Clear = true;
            this.txtDept_EADDRESS.W_ColArName = "عنوان الفرع بالانجليزي";
            this.txtDept_EADDRESS.W_ColEgName = "BRANCHE_EADDRESS";
            this.txtDept_EADDRESS.W_OldValue = "";
            this.txtDept_EADDRESS.W_TableName = "DEPARTEMENTS";
            // 
            // txtDept_AADDRESS
            // 
            this.txtDept_AADDRESS.BeforeTouchSize = new System.Drawing.Size(221, 23);
            this.txtDept_AADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDept_AADDRESS.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDept_AADDRESS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDept_AADDRESS.Location = new System.Drawing.Point(192, 165);
            this.txtDept_AADDRESS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDept_AADDRESS.Name = "txtDept_AADDRESS";
            this.txtDept_AADDRESS.Size = new System.Drawing.Size(221, 23);
            this.txtDept_AADDRESS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDept_AADDRESS.TabIndex = 185;
            this.txtDept_AADDRESS.W_Clear = true;
            this.txtDept_AADDRESS.W_ColArName = "عنوان الفرع بالعربي";
            this.txtDept_AADDRESS.W_ColEgName = "BRANCHE_AADDRESS";
            this.txtDept_AADDRESS.W_OldValue = "";
            this.txtDept_AADDRESS.W_TableName = "DEPARTEMENTS";
            // 
            // txtDept_ENAME
            // 
            this.txtDept_ENAME.BeforeTouchSize = new System.Drawing.Size(221, 23);
            this.txtDept_ENAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDept_ENAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDept_ENAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDept_ENAME.Location = new System.Drawing.Point(192, 137);
            this.txtDept_ENAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDept_ENAME.Name = "txtDept_ENAME";
            this.txtDept_ENAME.Size = new System.Drawing.Size(221, 23);
            this.txtDept_ENAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDept_ENAME.TabIndex = 184;
            this.txtDept_ENAME.W_Clear = true;
            this.txtDept_ENAME.W_ColArName = "اسم الفرع بالانجليزي";
            this.txtDept_ENAME.W_ColEgName = "BRANCHE_ENAME";
            this.txtDept_ENAME.W_OldValue = "";
            this.txtDept_ENAME.W_TableName = "DEPARTEMENTS";
            // 
            // myLabel9
            // 
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(102, 58);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel9.Size = new System.Drawing.Size(47, 18);
            this.myLabel9.TabIndex = 183;
            this.myLabel9.Text = "الفــــرع";
            // 
            // myLabel8
            // 
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(96, 284);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel8.Size = new System.Drawing.Size(74, 18);
            this.myLabel8.TabIndex = 182;
            this.myLabel8.Text = "بريد الكتروني";
            // 
            // myLabel7
            // 
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(102, 198);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(64, 18);
            this.myLabel7.TabIndex = 181;
            this.myLabel7.Text = "العنوان(E)";
            // 
            // txtDept_ANAME
            // 
            this.txtDept_ANAME.BeforeTouchSize = new System.Drawing.Size(221, 23);
            this.txtDept_ANAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDept_ANAME.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDept_ANAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtDept_ANAME.Location = new System.Drawing.Point(192, 109);
            this.txtDept_ANAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDept_ANAME.Name = "txtDept_ANAME";
            this.txtDept_ANAME.Size = new System.Drawing.Size(221, 23);
            this.txtDept_ANAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDept_ANAME.TabIndex = 180;
            this.txtDept_ANAME.W_Clear = true;
            this.txtDept_ANAME.W_ColArName = "اسم الفرع بالعربي";
            this.txtDept_ANAME.W_ColEgName = "BRANCHE_ANAME";
            this.txtDept_ANAME.W_OldValue = "";
            this.txtDept_ANAME.W_TableName = "DEPARTEMENTS";
            this.txtDept_ANAME.TextChanged += new System.EventHandler(this.txtBRANCHE_ANAME_TextChanged);
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(90, 146);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(77, 18);
            this.myLabel6.TabIndex = 179;
            this.myLabel6.Text = "اسم القسم(E)";
            this.myLabel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myLabel6_MouseClick);
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(94, 117);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(75, 18);
            this.myLabel5.TabIndex = 178;
            this.myLabel5.Text = "اسم القسم(ع)";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(98, 256);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(63, 18);
            this.myLabel4.TabIndex = 177;
            this.myLabel4.Text = "رقم الفاكس";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(104, 172);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(62, 18);
            this.myLabel3.TabIndex = 176;
            this.myLabel3.Text = "العنوان(ع)";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(100, 228);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(62, 18);
            this.myLabel2.TabIndex = 175;
            this.myLabel2.Text = "رقم الهاتف";
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
            this.btnSearch.Location = new System.Drawing.Point(371, 79);
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
            this.btnSave.Location = new System.Drawing.Point(168, 304);
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
            this.btnExit.Location = new System.Drawing.Point(292, 304);
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
            this.btnUpdate.Location = new System.Drawing.Point(229, 304);
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
            this.btnNew.Location = new System.Drawing.Point(74, 305);
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
            this.myLabel10.Location = new System.Drawing.Point(103, 86);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel10.Size = new System.Drawing.Size(55, 18);
            this.myLabel10.TabIndex = 200;
            this.myLabel10.Text = "رقم القسم";
            // 
            // frmDepartements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(467, 343);
            this.Controls.Add(this.myLabel10);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.nmbDept_No);
            this.Controls.Add(this.lstBRANCH_Id);
            this.Controls.Add(this.txtDept_EMAIL);
            this.Controls.Add(this.txtDept_TEL);
            this.Controls.Add(this.txtDept_FAX);
            this.Controls.Add(this.txtDept_EADDRESS);
            this.Controls.Add(this.txtDept_AADDRESS);
            this.Controls.Add(this.txtDept_ENAME);
            this.Controls.Add(this.myLabel9);
            this.Controls.Add(this.myLabel8);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.txtDept_ANAME);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.txtSWID);
            this.Name = "frmDepartements";
            this.PriviFile = ERP.glb_function.ProgramType.File;
            this.Text = "تعريف الاقسام";
            this.Titel = "تعريف الاقسام";
            this.Load += new System.EventHandler(this.frmBranches_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.txtDept_ANAME, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.myLabel8, 0);
            this.Controls.SetChildIndex(this.myLabel9, 0);
            this.Controls.SetChildIndex(this.txtDept_ENAME, 0);
            this.Controls.SetChildIndex(this.txtDept_AADDRESS, 0);
            this.Controls.SetChildIndex(this.txtDept_EADDRESS, 0);
            this.Controls.SetChildIndex(this.txtDept_FAX, 0);
            this.Controls.SetChildIndex(this.txtDept_TEL, 0);
            this.Controls.SetChildIndex(this.txtDept_EMAIL, 0);
            this.Controls.SetChildIndex(this.lstBRANCH_Id, 0);
            this.Controls.SetChildIndex(this.nmbDept_No, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.myLabel10, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDept_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_EMAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_TEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_FAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_EADDRESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_AADDRESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_ENAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept_ANAME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private myText txtSWID;
        private System.Windows.Forms.ErrorProvider errCheck;
        private myLabel myLabel1;
        private myNumber nmbDept_No;
        private myList lstBRANCH_Id;
        private myText txtDept_EMAIL;
        private myText txtDept_TEL;
        private myText txtDept_FAX;
        private myText txtDept_EADDRESS;
        private myText txtDept_AADDRESS;
        private myText txtDept_ENAME;
        private myLabel myLabel9;
        private myLabel myLabel8;
        private myLabel myLabel7;
        private myText txtDept_ANAME;
        private myLabel myLabel6;
        private myLabel myLabel5;
        private myLabel myLabel4;
        private myLabel myLabel3;
        private myLabel myLabel2;
        private myBottun btnNew;
        private myBottun btnUpdate;
        private myBottun btnExit;
        private myBottun btnSave;
        private myBottun btnSearch;
        private myLabel myLabel10;
    }
}
