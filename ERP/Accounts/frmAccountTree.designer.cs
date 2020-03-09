

namespace ERP.Accounts
{
    partial class frmAccountTree
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountTree));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tvAccTree = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.myLabel2 = new ERP.myLabel();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel4 = new ERP.myLabel();
            this.myLabel5 = new ERP.myLabel();
            this.myLabel6 = new ERP.myLabel();
            this.myLabel7 = new ERP.myLabel();
            this.myLabel8 = new ERP.myLabel();
            this.myLabel9 = new ERP.myLabel();
            this.myLabel10 = new ERP.myLabel();
            this.txtACC_NO = new ERP.myText();
            this.txtACC_NAME = new ERP.myText();
            this.txtACC_LEVEL = new ERP.myText();
            this.txtACC_CLASS = new ERP.myText();
            this.txtACC_NOTE = new ERP.myText();
            this.lstACC_SUBJECT = new ERP.myList();
            this.txtACC_PARENT = new ERP.myText();
            this.txtParentName = new ERP.myText();
            this.txtACC_CODE = new ERP.myText();
            this.btnAdd = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rcmPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new ERP.myBottun();
            this.btnPrint = new ERP.myBottun();
            this.myBottun1 = new ERP.myBottun();
            this.btnNew = new ERP.myBottun();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstStat = new ERP.myList();
            this.myLabel11 = new ERP.myLabel();
            this.txtSWID = new ERP.myText();
            this.txtParentId = new ERP.myText();
            this.myLabel13 = new ERP.myLabel();
            this.dgBranches = new ERP.myDataGrid();
            this.clmBranchAccSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSelBranch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmBranchSwid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCurrency = new ERP.myDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myLabel14 = new ERP.myLabel();
            this.lstACC_TYPE = new ERP.myList();
            this.txtACC_LEVEL_Name = new ERP.myText();
            this.myLabel15 = new ERP.myLabel();
            this.lstACC_NATURE = new ERP.myList();
            this.myLabel16 = new ERP.myLabel();
            this.lstACC_REPORT = new ERP.myList();
            this.btnGetNode = new ERP.myBottun();
            this.txtNodeName = new ERP.myText();
            this.tvAccTreeMain = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvAccTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_LEVEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_CLASS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NOTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_PARENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_CODE)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_LEVEL_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodeName)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(371, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(284, 34);
            // 
            // tvAccTree
            // 
            this.tvAccTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            this.tvAccTree.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.tvAccTree.BeforeTouchSize = new System.Drawing.Size(292, 394);
            this.tvAccTree.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.tvAccTree.ForeColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tvAccTree.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.tvAccTree.HelpTextControl.Name = "helpText";
            this.tvAccTree.HelpTextControl.TabIndex = 0;
            this.tvAccTree.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.tvAccTree.Location = new System.Drawing.Point(284, 451);
            this.tvAccTree.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tvAccTree.Name = "tvAccTree";
            this.tvAccTree.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tvAccTree.Size = new System.Drawing.Size(292, 394);
            this.tvAccTree.TabIndex = 4;
            // 
            // 
            // 
            this.tvAccTree.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.tvAccTree.ToolTipControl.Name = "toolTip";
            this.tvAccTree.ToolTipControl.TabIndex = 1;
            this.tvAccTree.Visible = false;
            this.tvAccTree.NodeMouseClick += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvMouseClickArgs(this.tvAccTree_NodeMouseClick);
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(312, 35);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(67, 18);
            this.myLabel2.TabIndex = 5;
            this.myLabel2.Text = "رقم الحساب";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(310, 124);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(70, 18);
            this.myLabel3.TabIndex = 6;
            this.myLabel3.Text = "نوع الحساب";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(311, 62);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(69, 18);
            this.myLabel4.TabIndex = 7;
            this.myLabel4.Text = "اسم الحساب";
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(327, 160);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(36, 18);
            this.myLabel5.TabIndex = 8;
            this.myLabel5.Text = "الرتبة";
            // 
            // myLabel6
            // 
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel6.ForeColor = System.Drawing.Color.Black;
            this.myLabel6.Location = new System.Drawing.Point(302, 193);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel6.Size = new System.Drawing.Size(86, 18);
            this.myLabel6.TabIndex = 9;
            this.myLabel6.Text = "تصنيف الحساب";
            // 
            // myLabel7
            // 
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel7.ForeColor = System.Drawing.Color.Black;
            this.myLabel7.Location = new System.Drawing.Point(319, 344);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel7.Size = new System.Drawing.Size(52, 18);
            this.myLabel7.TabIndex = 10;
            this.myLabel7.Text = "ملاحظات";
            // 
            // myLabel8
            // 
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel8.ForeColor = System.Drawing.Color.Black;
            this.myLabel8.Location = new System.Drawing.Point(329, 256);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel8.Size = new System.Drawing.Size(33, 18);
            this.myLabel8.TabIndex = 11;
            this.myLabel8.Text = "الكود";
            // 
            // myLabel9
            // 
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel9.ForeColor = System.Drawing.Color.Black;
            this.myLabel9.Location = new System.Drawing.Point(331, 287);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel9.Size = new System.Drawing.Size(29, 18);
            this.myLabel9.TabIndex = 12;
            this.myLabel9.Text = "الاب";
            // 
            // myLabel10
            // 
            this.myLabel10.BackColor = System.Drawing.Color.Transparent;
            this.myLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel10.ForeColor = System.Drawing.Color.Black;
            this.myLabel10.Location = new System.Drawing.Point(324, 100);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel10.Size = new System.Drawing.Size(43, 18);
            this.myLabel10.TabIndex = 13;
            this.myLabel10.Text = "التابعية";
            // 
            // txtACC_NO
            // 
            this.txtACC_NO.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_NO.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_NO.Location = new System.Drawing.Point(391, 32);
            this.txtACC_NO.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_NO.Name = "txtACC_NO";
            this.txtACC_NO.Size = new System.Drawing.Size(279, 25);
            this.txtACC_NO.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_NO.TabIndex = 0;
            this.txtACC_NO.W_Clear = true;
            this.txtACC_NO.W_ColArName = "غير مسموح بتغييره";
            this.txtACC_NO.W_ColEgName = "غير مسموح بتغييره";
            this.txtACC_NO.W_OldValue = "";
            this.txtACC_NO.W_TableName = "";
            this.txtACC_NO.Leave += new System.EventHandler(this.txtACC_NO_Leave);
            // 
            // txtACC_NAME
            // 
            this.txtACC_NAME.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_NAME.Location = new System.Drawing.Point(391, 62);
            this.txtACC_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_NAME.Name = "txtACC_NAME";
            this.txtACC_NAME.Size = new System.Drawing.Size(279, 25);
            this.txtACC_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_NAME.TabIndex = 1;
            this.txtACC_NAME.W_Clear = true;
            this.txtACC_NAME.W_ColArName = "اسم الحساب";
            this.txtACC_NAME.W_ColEgName = "ACC_NAME";
            this.txtACC_NAME.W_OldValue = "";
            this.txtACC_NAME.W_TableName = "ACCOUNTS";
            // 
            // txtACC_LEVEL
            // 
            this.txtACC_LEVEL.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_LEVEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_LEVEL.Enabled = false;
            this.txtACC_LEVEL.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_LEVEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_LEVEL.Location = new System.Drawing.Point(391, 156);
            this.txtACC_LEVEL.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_LEVEL.Name = "txtACC_LEVEL";
            this.txtACC_LEVEL.Size = new System.Drawing.Size(67, 25);
            this.txtACC_LEVEL.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_LEVEL.TabIndex = 17;
            this.txtACC_LEVEL.W_Clear = true;
            this.txtACC_LEVEL.W_ColArName = "رتبة الحساب";
            this.txtACC_LEVEL.W_ColEgName = "ACC_LEVEL";
            this.txtACC_LEVEL.W_OldValue = "";
            this.txtACC_LEVEL.W_TableName = "";
            this.txtACC_LEVEL.Leave += new System.EventHandler(this.txtACC_LEVEL_Leave);
            // 
            // txtACC_CLASS
            // 
            this.txtACC_CLASS.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_CLASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_CLASS.Enabled = false;
            this.txtACC_CLASS.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_CLASS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_CLASS.Location = new System.Drawing.Point(391, 186);
            this.txtACC_CLASS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_CLASS.Name = "txtACC_CLASS";
            this.txtACC_CLASS.Size = new System.Drawing.Size(279, 25);
            this.txtACC_CLASS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_CLASS.TabIndex = 18;
            this.txtACC_CLASS.W_Clear = true;
            this.txtACC_CLASS.W_ColArName = "تصنيف الحساب";
            this.txtACC_CLASS.W_ColEgName = "ACC_CLASS";
            this.txtACC_CLASS.W_OldValue = "";
            this.txtACC_CLASS.W_TableName = "";
            // 
            // txtACC_NOTE
            // 
            this.txtACC_NOTE.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_NOTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_NOTE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_NOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_NOTE.Location = new System.Drawing.Point(391, 337);
            this.txtACC_NOTE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_NOTE.Name = "txtACC_NOTE";
            this.txtACC_NOTE.Size = new System.Drawing.Size(279, 25);
            this.txtACC_NOTE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_NOTE.TabIndex = 19;
            this.txtACC_NOTE.W_Clear = true;
            this.txtACC_NOTE.W_ColArName = "ملاحظات";
            this.txtACC_NOTE.W_ColEgName = "ACC_NOTE";
            this.txtACC_NOTE.W_OldValue = "";
            this.txtACC_NOTE.W_TableName = "ACCOUNTS";
            // 
            // lstACC_SUBJECT
            // 
            this.lstACC_SUBJECT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstACC_SUBJECT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstACC_SUBJECT.Enabled = false;
            this.lstACC_SUBJECT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstACC_SUBJECT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstACC_SUBJECT.FormattingEnabled = true;
            this.lstACC_SUBJECT.Items.AddRange(new object[] {
            "ميزانية",
            "ارباح وخسائر"});
            this.lstACC_SUBJECT.Location = new System.Drawing.Point(391, 92);
            this.lstACC_SUBJECT.Name = "lstACC_SUBJECT";
            this.lstACC_SUBJECT.Size = new System.Drawing.Size(279, 26);
            this.lstACC_SUBJECT.TabIndex = 3;
            this.lstACC_SUBJECT.W_Clear = true;
            this.lstACC_SUBJECT.W_ColArName = "التابعية";
            this.lstACC_SUBJECT.W_ColEgName = "ACC_SUBJECT";
            this.lstACC_SUBJECT.W_OldValue = "";
            this.lstACC_SUBJECT.W_TableName = "";
            this.lstACC_SUBJECT.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstACC_SUBJECT.SelectedIndexChanged += new System.EventHandler(this.lstACC_SUBJECT_SelectedIndexChanged);
            // 
            // txtACC_PARENT
            // 
            this.txtACC_PARENT.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_PARENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_PARENT.Enabled = false;
            this.txtACC_PARENT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_PARENT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_PARENT.Location = new System.Drawing.Point(391, 280);
            this.txtACC_PARENT.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_PARENT.Name = "txtACC_PARENT";
            this.txtACC_PARENT.Size = new System.Drawing.Size(77, 25);
            this.txtACC_PARENT.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_PARENT.TabIndex = 21;
            this.txtACC_PARENT.W_Clear = true;
            this.txtACC_PARENT.W_ColArName = "الاب";
            this.txtACC_PARENT.W_ColEgName = "ACC_PARENT";
            this.txtACC_PARENT.W_OldValue = "";
            this.txtACC_PARENT.W_TableName = "";
            // 
            // txtParentName
            // 
            this.txtParentName.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtParentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentName.Enabled = false;
            this.txtParentName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtParentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtParentName.Location = new System.Drawing.Point(474, 280);
            this.txtParentName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(196, 25);
            this.txtParentName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtParentName.TabIndex = 22;
            this.txtParentName.W_Clear = true;
            this.txtParentName.W_ColArName = "";
            this.txtParentName.W_ColEgName = "";
            this.txtParentName.W_OldValue = "";
            this.txtParentName.W_TableName = "";
            // 
            // txtACC_CODE
            // 
            this.txtACC_CODE.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_CODE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_CODE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_CODE.Location = new System.Drawing.Point(391, 249);
            this.txtACC_CODE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_CODE.Name = "txtACC_CODE";
            this.txtACC_CODE.Size = new System.Drawing.Size(279, 25);
            this.txtACC_CODE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_CODE.TabIndex = 23;
            this.txtACC_CODE.W_Clear = true;
            this.txtACC_CODE.W_ColArName = "الكود";
            this.txtACC_CODE.W_ColEgName = "ACC_CODE";
            this.txtACC_CODE.W_OldValue = "";
            this.txtACC_CODE.W_TableName = "ACCOUNTS";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.IsBackStageButton = false;
            this.btnAdd.Location = new System.Drawing.Point(362, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 28);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.Add;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnUpdate.ContextMenuStrip = this.contextMenuStrip1;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.IsBackStageButton = false;
            this.btnUpdate.Location = new System.Drawing.Point(421, 419);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
            this.btnUpdate.w_Type = ERP.myBottun.Btton_type.Update;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.rcmPrint});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.testToolStripMenuItem.Text = "جديد";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // rcmPrint
            // 
            this.rcmPrint.Name = "rcmPrint";
            this.rcmPrint.Size = new System.Drawing.Size(104, 22);
            this.rcmPrint.Text = "طباعة";
            this.rcmPrint.Click += new System.EventHandler(this.rcmPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.IsBackStageButton = false;
            this.btnDelete.Location = new System.Drawing.Point(480, 419);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 28);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.w_Priv = ERP.myBottun.Btton_Priv.Delete_D;
            this.btnDelete.w_Type = ERP.myBottun.Btton_type.Delete;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.IsBackStageButton = false;
            this.btnPrint.Location = new System.Drawing.Point(539, 419);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(57, 28);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnPrint.w_Type = ERP.myBottun.Btton_type.Print;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // myBottun1
            // 
            this.myBottun1.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.myBottun1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun1.FlatAppearance.BorderSize = 0;
            this.myBottun1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBottun1.Image = ((System.Drawing.Image)(resources.GetObject("myBottun1.Image")));
            this.myBottun1.IsBackStageButton = false;
            this.myBottun1.Location = new System.Drawing.Point(598, 419);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(57, 28);
            this.myBottun1.TabIndex = 29;
            this.myBottun1.UseVisualStyleBackColor = true;
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // btnNew
            // 
            this.btnNew.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.IsBackStageButton = false;
            this.btnNew.Location = new System.Drawing.Point(299, 417);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 30;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // lstStat
            // 
            this.lstStat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstStat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstStat.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstStat.FormattingEnabled = true;
            this.lstStat.Items.AddRange(new object[] {
            "فعال",
            "غير فعال"});
            this.lstStat.Location = new System.Drawing.Point(391, 216);
            this.lstStat.Name = "lstStat";
            this.lstStat.Size = new System.Drawing.Size(279, 26);
            this.lstStat.TabIndex = 31;
            this.lstStat.W_Clear = true;
            this.lstStat.W_ColArName = "نوع الحساب";
            this.lstStat.W_ColEgName = "stat";
            this.lstStat.W_OldValue = "";
            this.lstStat.W_TableName = "ACCOUNTS";
            this.lstStat.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // myLabel11
            // 
            this.myLabel11.BackColor = System.Drawing.Color.Transparent;
            this.myLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel11.ForeColor = System.Drawing.Color.Black;
            this.myLabel11.Location = new System.Drawing.Point(309, 220);
            this.myLabel11.Name = "myLabel11";
            this.myLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel11.Size = new System.Drawing.Size(73, 18);
            this.myLabel11.TabIndex = 32;
            this.myLabel11.Text = "حالة الحساب";
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(624, 32);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(100, 23);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 33;
            this.txtSWID.Visible = false;
            this.txtSWID.W_Clear = true;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // txtParentId
            // 
            this.txtParentId.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtParentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtParentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtParentId.Location = new System.Drawing.Point(378, 280);
            this.txtParentId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtParentId.Name = "txtParentId";
            this.txtParentId.Size = new System.Drawing.Size(18, 23);
            this.txtParentId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtParentId.TabIndex = 34;
            this.txtParentId.Visible = false;
            this.txtParentId.W_Clear = true;
            this.txtParentId.W_ColArName = "";
            this.txtParentId.W_ColEgName = "";
            this.txtParentId.W_OldValue = "";
            this.txtParentId.W_TableName = "";
            // 
            // myLabel13
            // 
            this.myLabel13.BackColor = System.Drawing.Color.Transparent;
            this.myLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel13.ForeColor = System.Drawing.Color.Black;
            this.myLabel13.Location = new System.Drawing.Point(756, 39);
            this.myLabel13.Name = "myLabel13";
            this.myLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel13.Size = new System.Drawing.Size(60, 20);
            this.myLabel13.TabIndex = 38;
            this.myLabel13.Text = "الفــــروع ";
            // 
            // dgBranches
            // 
            this.dgBranches.AllowUserToAddRows = false;
            this.dgBranches.AllowUserToDeleteRows = false;
            this.dgBranches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgBranches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBranches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgBranches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBranches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBranchAccSwid,
            this.clmSelBranch,
            this.clmBranchSwid,
            this.clmBranchName});
            this.dgBranches.EnableHeadersVisualStyles = false;
            this.dgBranches.Location = new System.Drawing.Point(686, 62);
            this.dgBranches.Name = "dgBranches";
            this.dgBranches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgBranches.RowHeadersVisible = false;
            this.dgBranches.Size = new System.Drawing.Size(199, 180);
            this.dgBranches.TabIndex = 225;
            this.dgBranches.Visible = false;
            this.dgBranches.W_Clear = true;
            // 
            // clmBranchAccSwid
            // 
            this.clmBranchAccSwid.HeaderText = "swid";
            this.clmBranchAccSwid.Name = "clmBranchAccSwid";
            this.clmBranchAccSwid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBranchAccSwid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmBranchAccSwid.Visible = false;
            // 
            // clmSelBranch
            // 
            this.clmSelBranch.HeaderText = "اختيار";
            this.clmSelBranch.Name = "clmSelBranch";
            this.clmSelBranch.Width = 50;
            // 
            // clmBranchSwid
            // 
            this.clmBranchSwid.HeaderText = "branchId";
            this.clmBranchSwid.Name = "clmBranchSwid";
            this.clmBranchSwid.ReadOnly = true;
            this.clmBranchSwid.Visible = false;
            // 
            // clmBranchName
            // 
            this.clmBranchName.HeaderText = "اسم الفرع";
            this.clmBranchName.Name = "clmBranchName";
            this.clmBranchName.ReadOnly = true;
            this.clmBranchName.Width = 120;
            // 
            // dgCurrency
            // 
            this.dgCurrency.AllowUserToAddRows = false;
            this.dgCurrency.AllowUserToDeleteRows = false;
            this.dgCurrency.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCurrency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgCurrency.EnableHeadersVisualStyles = false;
            this.dgCurrency.Location = new System.Drawing.Point(686, 272);
            this.dgCurrency.Name = "dgCurrency";
            this.dgCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCurrency.RowHeadersVisible = false;
            this.dgCurrency.Size = new System.Drawing.Size(199, 144);
            this.dgCurrency.TabIndex = 226;
            this.dgCurrency.Visible = false;
            this.dgCurrency.W_Clear = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "swid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "اختيار";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "رقم العملة";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "العملة";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // myLabel14
            // 
            this.myLabel14.BackColor = System.Drawing.Color.Transparent;
            this.myLabel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLabel14.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel14.ForeColor = System.Drawing.Color.Black;
            this.myLabel14.Location = new System.Drawing.Point(741, 247);
            this.myLabel14.Name = "myLabel14";
            this.myLabel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel14.Size = new System.Drawing.Size(47, 20);
            this.myLabel14.TabIndex = 227;
            this.myLabel14.Text = "العملات";
            // 
            // lstACC_TYPE
            // 
            this.lstACC_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstACC_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstACC_TYPE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstACC_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstACC_TYPE.FormattingEnabled = true;
            this.lstACC_TYPE.Location = new System.Drawing.Point(391, 124);
            this.lstACC_TYPE.Name = "lstACC_TYPE";
            this.lstACC_TYPE.Size = new System.Drawing.Size(279, 26);
            this.lstACC_TYPE.TabIndex = 4;
            this.lstACC_TYPE.W_Clear = true;
            this.lstACC_TYPE.W_ColArName = "نوع الحساب";
            this.lstACC_TYPE.W_ColEgName = "ACC_TYPE";
            this.lstACC_TYPE.W_OldValue = "";
            this.lstACC_TYPE.W_TableName = "ACCOUNTS";
            this.lstACC_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstACC_TYPE.SelectedIndexChanged += new System.EventHandler(this.lstACC_TYPE_SelectedIndexChanged);
            // 
            // txtACC_LEVEL_Name
            // 
            this.txtACC_LEVEL_Name.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtACC_LEVEL_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACC_LEVEL_Name.Enabled = false;
            this.txtACC_LEVEL_Name.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtACC_LEVEL_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtACC_LEVEL_Name.Location = new System.Drawing.Point(460, 156);
            this.txtACC_LEVEL_Name.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtACC_LEVEL_Name.Name = "txtACC_LEVEL_Name";
            this.txtACC_LEVEL_Name.Size = new System.Drawing.Size(210, 25);
            this.txtACC_LEVEL_Name.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtACC_LEVEL_Name.TabIndex = 228;
            this.txtACC_LEVEL_Name.W_Clear = true;
            this.txtACC_LEVEL_Name.W_ColArName = "رتبة الحساب";
            this.txtACC_LEVEL_Name.W_ColEgName = "ACC_LEVEL";
            this.txtACC_LEVEL_Name.W_OldValue = "";
            this.txtACC_LEVEL_Name.W_TableName = "";
            // 
            // myLabel15
            // 
            this.myLabel15.BackColor = System.Drawing.Color.Transparent;
            this.myLabel15.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel15.ForeColor = System.Drawing.Color.Black;
            this.myLabel15.Location = new System.Drawing.Point(302, 312);
            this.myLabel15.Name = "myLabel15";
            this.myLabel15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel15.Size = new System.Drawing.Size(78, 18);
            this.myLabel15.TabIndex = 230;
            this.myLabel15.Text = "طبيعة الحساب";
            // 
            // lstACC_NATURE
            // 
            this.lstACC_NATURE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstACC_NATURE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstACC_NATURE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstACC_NATURE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstACC_NATURE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstACC_NATURE.FormattingEnabled = true;
            this.lstACC_NATURE.Items.AddRange(new object[] {
            "مدين",
            "دائن",
            "مدين/دائن"});
            this.lstACC_NATURE.Location = new System.Drawing.Point(391, 308);
            this.lstACC_NATURE.Name = "lstACC_NATURE";
            this.lstACC_NATURE.Size = new System.Drawing.Size(279, 26);
            this.lstACC_NATURE.TabIndex = 229;
            this.lstACC_NATURE.W_Clear = true;
            this.lstACC_NATURE.W_ColArName = "طبيعة الحساب";
            this.lstACC_NATURE.W_ColEgName = "acc_nature";
            this.lstACC_NATURE.W_OldValue = "";
            this.lstACC_NATURE.W_TableName = "ACCOUNTS";
            this.lstACC_NATURE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // myLabel16
            // 
            this.myLabel16.BackColor = System.Drawing.Color.Transparent;
            this.myLabel16.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel16.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel16.ForeColor = System.Drawing.Color.Black;
            this.myLabel16.Location = new System.Drawing.Point(309, 372);
            this.myLabel16.Name = "myLabel16";
            this.myLabel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel16.Size = new System.Drawing.Size(74, 18);
            this.myLabel16.TabIndex = 232;
            this.myLabel16.Text = "التدفق المالي";
            // 
            // lstACC_REPORT
            // 
            this.lstACC_REPORT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstACC_REPORT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstACC_REPORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstACC_REPORT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstACC_REPORT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstACC_REPORT.FormattingEnabled = true;
            this.lstACC_REPORT.Items.AddRange(new object[] {
            "تمويلي",
            "استثماري",
            "تشغيلي"});
            this.lstACC_REPORT.Location = new System.Drawing.Point(391, 368);
            this.lstACC_REPORT.Name = "lstACC_REPORT";
            this.lstACC_REPORT.Size = new System.Drawing.Size(279, 26);
            this.lstACC_REPORT.TabIndex = 231;
            this.lstACC_REPORT.W_Clear = true;
            this.lstACC_REPORT.W_ColArName = "التدفق المالي";
            this.lstACC_REPORT.W_ColEgName = "acc_report";
            this.lstACC_REPORT.W_OldValue = "";
            this.lstACC_REPORT.W_TableName = "ACCOUNTS";
            this.lstACC_REPORT.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // btnGetNode
            // 
            this.btnGetNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetNode.BackgroundImage")));
            this.btnGetNode.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnGetNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetNode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetNode.FlatAppearance.BorderSize = 0;
            this.btnGetNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetNode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetNode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnGetNode.Image = ((System.Drawing.Image)(resources.GetObject("btnGetNode.Image")));
            this.btnGetNode.IsBackStageButton = false;
            this.btnGetNode.Location = new System.Drawing.Point(189, 31);
            this.btnGetNode.Name = "btnGetNode";
            this.btnGetNode.Size = new System.Drawing.Size(28, 27);
            this.btnGetNode.TabIndex = 248;
            this.btnGetNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetNode.UseVisualStyleBackColor = true;
            this.btnGetNode.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnGetNode.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnGetNode.Click += new System.EventHandler(this.btnGetNode_Click);
            // 
            // txtNodeName
            // 
            this.txtNodeName.BeforeTouchSize = new System.Drawing.Size(176, 25);
            this.txtNodeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNodeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtNodeName.Location = new System.Drawing.Point(7, 34);
            this.txtNodeName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(176, 25);
            this.txtNodeName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtNodeName.TabIndex = 247;
            this.txtNodeName.W_Clear = true;
            this.txtNodeName.W_ColArName = "اسم دخول المستخدم";
            this.txtNodeName.W_ColEgName = "USER_LOGIN";
            this.txtNodeName.W_OldValue = "";
            this.txtNodeName.W_TableName = "USERINFO";
            // 
            // tvAccTreeMain
            // 
            this.tvAccTreeMain.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.tvAccTreeMain.Location = new System.Drawing.Point(1, 62);
            this.tvAccTreeMain.Name = "tvAccTreeMain";
            this.tvAccTreeMain.RightToLeftLayout = true;
            this.tvAccTreeMain.Size = new System.Drawing.Size(292, 394);
            this.tvAccTreeMain.TabIndex = 250;
            this.tvAccTreeMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.tvAccTreeMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvAccTreeMain_MouseDown);
            // 
            // frmAccountTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(910, 459);
            this.Controls.Add(this.tvAccTree);
            this.Controls.Add(this.tvAccTreeMain);
            this.Controls.Add(this.btnGetNode);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.myLabel16);
            this.Controls.Add(this.lstACC_REPORT);
            this.Controls.Add(this.myLabel15);
            this.Controls.Add(this.lstACC_NATURE);
            this.Controls.Add(this.txtACC_LEVEL_Name);
            this.Controls.Add(this.myLabel14);
            this.Controls.Add(this.dgCurrency);
            this.Controls.Add(this.dgBranches);
            this.Controls.Add(this.myLabel13);
            this.Controls.Add(this.txtParentId);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.myLabel11);
            this.Controls.Add(this.lstStat);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.myBottun1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtACC_CODE);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.txtACC_PARENT);
            this.Controls.Add(this.lstACC_SUBJECT);
            this.Controls.Add(this.txtACC_NOTE);
            this.Controls.Add(this.txtACC_CLASS);
            this.Controls.Add(this.txtACC_LEVEL);
            this.Controls.Add(this.txtACC_NAME);
            this.Controls.Add(this.lstACC_TYPE);
            this.Controls.Add(this.txtACC_NO);
            this.Controls.Add(this.myLabel10);
            this.Controls.Add(this.myLabel9);
            this.Controls.Add(this.myLabel8);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Name = "frmAccountTree";
            this.PriviFile = ERP.glb_function.ProgramType.Account;
            this.Tag = "frmAccountTree";
            this.Titel = "شجرة الحسابات";
            this.Load += new System.EventHandler(this.frmAccountTree_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            this.Controls.SetChildIndex(this.myLabel6, 0);
            this.Controls.SetChildIndex(this.myLabel7, 0);
            this.Controls.SetChildIndex(this.myLabel8, 0);
            this.Controls.SetChildIndex(this.myLabel9, 0);
            this.Controls.SetChildIndex(this.myLabel10, 0);
            this.Controls.SetChildIndex(this.txtACC_NO, 0);
            this.Controls.SetChildIndex(this.lstACC_TYPE, 0);
            this.Controls.SetChildIndex(this.txtACC_NAME, 0);
            this.Controls.SetChildIndex(this.txtACC_LEVEL, 0);
            this.Controls.SetChildIndex(this.txtACC_CLASS, 0);
            this.Controls.SetChildIndex(this.txtACC_NOTE, 0);
            this.Controls.SetChildIndex(this.lstACC_SUBJECT, 0);
            this.Controls.SetChildIndex(this.txtACC_PARENT, 0);
            this.Controls.SetChildIndex(this.txtParentName, 0);
            this.Controls.SetChildIndex(this.txtACC_CODE, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.myBottun1, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.lstStat, 0);
            this.Controls.SetChildIndex(this.myLabel11, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.txtParentId, 0);
            this.Controls.SetChildIndex(this.myLabel13, 0);
            this.Controls.SetChildIndex(this.dgBranches, 0);
            this.Controls.SetChildIndex(this.dgCurrency, 0);
            this.Controls.SetChildIndex(this.myLabel14, 0);
            this.Controls.SetChildIndex(this.txtACC_LEVEL_Name, 0);
            this.Controls.SetChildIndex(this.lstACC_NATURE, 0);
            this.Controls.SetChildIndex(this.myLabel15, 0);
            this.Controls.SetChildIndex(this.lstACC_REPORT, 0);
            this.Controls.SetChildIndex(this.myLabel16, 0);
            this.Controls.SetChildIndex(this.txtNodeName, 0);
            this.Controls.SetChildIndex(this.btnGetNode, 0);
            this.Controls.SetChildIndex(this.tvAccTreeMain, 0);
            this.Controls.SetChildIndex(this.tvAccTree, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvAccTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_LEVEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_CLASS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_NOTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_PARENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_CODE)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtACC_LEVEL_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodeName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TreeViewAdv  tvAccTree;
        private ERP.myLabel myLabel2;
        private ERP.myLabel myLabel3;
        private ERP.myLabel myLabel4;
        private ERP.myLabel myLabel5;
        private ERP.myLabel myLabel6;
        private ERP.myLabel myLabel7;
        private ERP.myLabel myLabel8;
        private ERP.myLabel myLabel9;
        private ERP.myLabel myLabel10;
        private ERP.myText txtACC_NO;
        private ERP.myText txtACC_NAME;
        private ERP.myText txtACC_LEVEL;
        private ERP.myText txtACC_CLASS;
        private ERP.myText txtACC_NOTE;
        private ERP.myList lstACC_SUBJECT;
        private ERP.myText txtACC_PARENT;
        private ERP.myText txtParentName;
        private ERP.myText txtACC_CODE;
        private ERP.myBottun btnAdd;
        private ERP.myBottun btnUpdate;
        private ERP.myBottun btnDelete;
        private ERP.myBottun btnPrint;
        private ERP.myBottun myBottun1;
        private ERP.myBottun btnNew;
        private System.Windows.Forms.ErrorProvider errCheck;
        private ERP.myLabel myLabel11;
        private ERP.myList lstStat;
        private ERP.myText txtSWID;
        private ERP.myText txtParentId;
        private ERP.myLabel myLabel13;
        private ERP.myDataGrid dgBranches;
        private ERP.myDataGrid dgCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ERP.myLabel myLabel14;
        private ERP.myList lstACC_TYPE;
        private ERP.myLabel myLabel16;
        private ERP.myList lstACC_REPORT;
        private ERP.myLabel myLabel15;
        private ERP.myList lstACC_NATURE;
        private ERP.myText txtACC_LEVEL_Name;
        private myBottun btnGetNode;
        private myText txtNodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBranchAccSwid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBranchSwid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBranchName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.TreeView tvAccTreeMain;
        private System.Windows.Forms.ToolStripMenuItem rcmPrint;
    }
}
