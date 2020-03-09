
namespace ERP.File
{
    partial class frmLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocation));
            this.myLabel1 = new ERP.myLabel();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSWID = new ERP.myText();
            this.txtLOC_NOTE = new ERP.myText();
            this.myLabel4 = new ERP.myLabel();
            this.txtLOCATION_NAME = new ERP.myText();
            this.lstPARENT_ID = new ERP.myList();
            this.lstLOCATION_TYPE = new ERP.myList();
            this.myLabel3 = new ERP.myLabel();
            this.myLabel2 = new ERP.myLabel();
            this.btnNew = new ERP.myBottun();
            this.btnClose = new ERP.myBottun();
            this.btnUpdate = new ERP.myBottun();
            this.btnSave = new ERP.myBottun();
            this.btnFind = new ERP.myBottun();
            this.myLabel5 = new ERP.myLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOC_NOTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOCATION_NAME)).BeginInit();
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
            this.myLabel1.Font = new System.Drawing.Font("bader_al gordabia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.myLabel1.Location = new System.Drawing.Point(211, 9);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel1.Size = new System.Drawing.Size(86, 34);
            this.myLabel1.TabIndex = 123;
            this.myLabel1.Text = "اسم الموقع";
            // 
            // errCheck
            // 
            this.errCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errCheck.ContainerControl = this;
            // 
            // txtSWID
            // 
            this.txtSWID.BeforeTouchSize = new System.Drawing.Size(120, 25);
            this.txtSWID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWID.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSWID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtSWID.Location = new System.Drawing.Point(305, 32);
            this.txtSWID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSWID.Name = "txtSWID";
            this.txtSWID.Size = new System.Drawing.Size(25, 25);
            this.txtSWID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSWID.TabIndex = 152;
            this.txtSWID.Visible = false;
            this.txtSWID.W_Clear = true;
            this.txtSWID.W_ColArName = "";
            this.txtSWID.W_ColEgName = "";
            this.txtSWID.W_OldValue = "";
            this.txtSWID.W_TableName = "";
            // 
            // txtLOC_NOTE
            // 
            this.txtLOC_NOTE.BeforeTouchSize = new System.Drawing.Size(120, 25);
            this.txtLOC_NOTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLOC_NOTE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtLOC_NOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtLOC_NOTE.Location = new System.Drawing.Point(128, 128);
            this.txtLOC_NOTE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLOC_NOTE.Name = "txtLOC_NOTE";
            this.txtLOC_NOTE.Size = new System.Drawing.Size(172, 25);
            this.txtLOC_NOTE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLOC_NOTE.TabIndex = 159;
            this.txtLOC_NOTE.W_Clear = true;
            this.txtLOC_NOTE.W_ColArName = "ملاحظات الموقع";
            this.txtLOC_NOTE.W_ColEgName = "LOC_NOTE";
            this.txtLOC_NOTE.W_OldValue = "";
            this.txtLOC_NOTE.W_TableName = "LOCATION";
            // 
            // myLabel4
            // 
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel4.ForeColor = System.Drawing.Color.Black;
            this.myLabel4.Location = new System.Drawing.Point(40, 133);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel4.Size = new System.Drawing.Size(52, 18);
            this.myLabel4.TabIndex = 158;
            this.myLabel4.Text = "ملاحظات";
            // 
            // txtLOCATION_NAME
            // 
            this.txtLOCATION_NAME.BeforeTouchSize = new System.Drawing.Size(120, 25);
            this.txtLOCATION_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLOCATION_NAME.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtLOCATION_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtLOCATION_NAME.Location = new System.Drawing.Point(128, 43);
            this.txtLOCATION_NAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLOCATION_NAME.Name = "txtLOCATION_NAME";
            this.txtLOCATION_NAME.Size = new System.Drawing.Size(120, 25);
            this.txtLOCATION_NAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLOCATION_NAME.TabIndex = 157;
            this.txtLOCATION_NAME.W_Clear = true;
            this.txtLOCATION_NAME.W_ColArName = "اسم الموقع";
            this.txtLOCATION_NAME.W_ColEgName = "LOCATION_NAME";
            this.txtLOCATION_NAME.W_OldValue = "";
            this.txtLOCATION_NAME.W_TableName = "LOCATION";
            // 
            // lstPARENT_ID
            // 
            this.lstPARENT_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstPARENT_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstPARENT_ID.Font = new System.Drawing.Font("Arial", 10F);
            this.lstPARENT_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstPARENT_ID.FormattingEnabled = true;
            this.lstPARENT_ID.Location = new System.Drawing.Point(128, 101);
            this.lstPARENT_ID.Name = "lstPARENT_ID";
            this.lstPARENT_ID.Size = new System.Drawing.Size(172, 24);
            this.lstPARENT_ID.TabIndex = 156;
            this.lstPARENT_ID.W_Clear = true;
            this.lstPARENT_ID.W_ColArName = "الموقع الرئيسي";
            this.lstPARENT_ID.W_ColEgName = "PARENT_ID";
            this.lstPARENT_ID.W_OldValue = "";
            this.lstPARENT_ID.W_TableName = "LOCATION";
            this.lstPARENT_ID.w_ValueType = ERP.myList.ValueType.VALUE;
            // 
            // lstLOCATION_TYPE
            // 
            this.lstLOCATION_TYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstLOCATION_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstLOCATION_TYPE.Font = new System.Drawing.Font("Arial", 10F);
            this.lstLOCATION_TYPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstLOCATION_TYPE.FormattingEnabled = true;
            this.lstLOCATION_TYPE.Location = new System.Drawing.Point(128, 74);
            this.lstLOCATION_TYPE.Name = "lstLOCATION_TYPE";
            this.lstLOCATION_TYPE.Size = new System.Drawing.Size(172, 24);
            this.lstLOCATION_TYPE.TabIndex = 155;
            this.lstLOCATION_TYPE.W_Clear = true;
            this.lstLOCATION_TYPE.W_ColArName = "نوع الموقع";
            this.lstLOCATION_TYPE.W_ColEgName = "LOCATION_TYPE";
            this.lstLOCATION_TYPE.W_OldValue = "";
            this.lstLOCATION_TYPE.W_TableName = "LOCATION";
            this.lstLOCATION_TYPE.w_ValueType = ERP.myList.ValueType.TEXT;
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(17, 100);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(85, 18);
            this.myLabel3.TabIndex = 154;
            this.myLabel3.Text = "الموقع الرئيسي";
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(62, 72);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(33, 18);
            this.myLabel2.TabIndex = 153;
            this.myLabel2.Text = "نوعه";
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.IsBackStageButton = false;
            this.btnNew.Location = new System.Drawing.Point(56, 167);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 28);
            this.btnNew.TabIndex = 160;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnNew.w_Type = ERP.myBottun.Btton_type.Undo;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(246, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 161;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnClose.w_Type = ERP.myBottun.Btton_type.Close;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BeforeTouchSize = new System.Drawing.Size(57, 28);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.IsBackStageButton = false;
            this.btnUpdate.Location = new System.Drawing.Point(187, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 28);
            this.btnUpdate.TabIndex = 162;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.w_Priv = ERP.myBottun.Btton_Priv.Update_D;
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
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(128, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 28);
            this.btnSave.TabIndex = 163;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.w_Priv = ERP.myBottun.Btton_Priv.Save_D;
            this.btnSave.w_Type = ERP.myBottun.Btton_type.Save;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BeforeTouchSize = new System.Drawing.Size(28, 27);
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.IsBackStageButton = false;
            this.btnFind.Location = new System.Drawing.Point(263, 44);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 27);
            this.btnFind.TabIndex = 164;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.w_Priv = ERP.myBottun.Btton_Priv.Select_D;
            this.btnFind.w_Type = ERP.myBottun.Btton_type.Search;
            this.btnFind.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // myLabel5
            // 
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.myLabel5.ForeColor = System.Drawing.Color.Black;
            this.myLabel5.Location = new System.Drawing.Point(50, 45);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel5.Size = new System.Drawing.Size(63, 18);
            this.myLabel5.TabIndex = 165;
            this.myLabel5.Text = "اسم الموقع";
            // 
            // frmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(330, 228);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtSWID);
            this.Controls.Add(this.txtLOC_NOTE);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.txtLOCATION_NAME);
            this.Controls.Add(this.lstPARENT_ID);
            this.Controls.Add(this.lstLOCATION_TYPE);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Name = "frmLocation";
            this.PriviFile = ERP.glb_function.ProgramType.File;
            this.Text = "المناطق ومواقع الفروع";
            this.Titel = "المناطق ومواقع الفروع";
            this.Load += new System.EventHandler(this.frmLocation_Load);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.lstLOCATION_TYPE, 0);
            this.Controls.SetChildIndex(this.lstPARENT_ID, 0);
            this.Controls.SetChildIndex(this.txtLOCATION_NAME, 0);
            this.Controls.SetChildIndex(this.myLabel4, 0);
            this.Controls.SetChildIndex(this.txtLOC_NOTE, 0);
            this.Controls.SetChildIndex(this.txtSWID, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.myLabel5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSWID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOC_NOTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOCATION_NAME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errCheck;
        private myLabel myLabel1;
        private myText txtSWID;
        private myText txtLOC_NOTE;
        private myLabel myLabel4;
        private myText txtLOCATION_NAME;
        private myList lstPARENT_ID;
        private myList lstLOCATION_TYPE;
        private myLabel myLabel3;
        private myLabel myLabel2;
        private myBottun btnFind;
        private myBottun btnSave;
        private myBottun btnUpdate;
        private myBottun btnClose;
        private myBottun btnNew;
        private myLabel myLabel5;
    }
}
