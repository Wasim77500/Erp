namespace ERP.Inventory
{
    partial class frmPropertyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropertyList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPropertyValue = new ERP.myText();
            this.myLabel3 = new ERP.myLabel();
            this.btnAdd = new ERP.myBottun();
            this.dgvPropertyList = new ERP.myDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myLabel2 = new ERP.myLabel();
            this.txtLIST_VALUE_EN = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPropertyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLIST_VALUE_EN)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(72, 34);
            // 
            // txtPropertyValue
            // 
            this.txtPropertyValue.BeforeTouchSize = new System.Drawing.Size(175, 23);
            this.txtPropertyValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPropertyValue.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPropertyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtPropertyValue.Location = new System.Drawing.Point(99, 61);
            this.txtPropertyValue.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPropertyValue.Name = "txtPropertyValue";
            this.txtPropertyValue.Size = new System.Drawing.Size(175, 23);
            this.txtPropertyValue.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPropertyValue.TabIndex = 8;
            this.txtPropertyValue.W_Clear = true;
            this.txtPropertyValue.W_ColArName = "";
            this.txtPropertyValue.W_ColEgName = "";
            this.txtPropertyValue.W_OldValue = "";
            this.txtPropertyValue.W_TableName = "";
            // 
            // myLabel3
            // 
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.Black;
            this.myLabel3.Location = new System.Drawing.Point(4, 64);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel3.Size = new System.Drawing.Size(92, 18);
            this.myLabel3.TabIndex = 7;
            this.myLabel3.Text = "القيمة في القائمة";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(33, 23);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.IsBackStageButton = false;
            this.btnAdd.Location = new System.Drawing.Point(275, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 23);
            this.btnAdd.TabIndex = 267;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.btnAdd.w_Type = ERP.myBottun.Btton_type.none;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPropertyList
            // 
            this.dgvPropertyList.AllowUserToAddRows = false;
            this.dgvPropertyList.AllowUserToDeleteRows = false;
            this.dgvPropertyList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPropertyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPropertyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1});
            this.dgvPropertyList.EnableHeadersVisualStyles = false;
            this.dgvPropertyList.Location = new System.Drawing.Point(6, 115);
            this.dgvPropertyList.Name = "dgvPropertyList";
            this.dgvPropertyList.RowHeadersVisible = false;
            this.dgvPropertyList.Size = new System.Drawing.Size(302, 336);
            this.dgvPropertyList.TabIndex = 268;
            this.dgvPropertyList.W_Clear = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "القيمة في القائمة";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "القيمة بالانجليزي";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // myLabel2
            // 
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.Black;
            this.myLabel2.Location = new System.Drawing.Point(4, 90);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel2.Size = new System.Drawing.Size(92, 18);
            this.myLabel2.TabIndex = 269;
            this.myLabel2.Text = "القيمة بالانجليزي";
            // 
            // txtLIST_VALUE_EN
            // 
            this.txtLIST_VALUE_EN.BeforeTouchSize = new System.Drawing.Size(175, 23);
            this.txtLIST_VALUE_EN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLIST_VALUE_EN.Font = new System.Drawing.Font("Arial", 10F);
            this.txtLIST_VALUE_EN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtLIST_VALUE_EN.Location = new System.Drawing.Point(99, 88);
            this.txtLIST_VALUE_EN.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLIST_VALUE_EN.Name = "txtLIST_VALUE_EN";
            this.txtLIST_VALUE_EN.Size = new System.Drawing.Size(175, 23);
            this.txtLIST_VALUE_EN.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLIST_VALUE_EN.TabIndex = 270;
            this.txtLIST_VALUE_EN.W_Clear = true;
            this.txtLIST_VALUE_EN.W_ColArName = "";
            this.txtLIST_VALUE_EN.W_ColEgName = "";
            this.txtLIST_VALUE_EN.W_OldValue = "";
            this.txtLIST_VALUE_EN.W_TableName = "";
            // 
            // frmPropertyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(313, 454);
            this.Controls.Add(this.txtLIST_VALUE_EN);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.dgvPropertyList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPropertyValue);
            this.Controls.Add(this.myLabel3);
            this.Name = "frmPropertyList";
            this.Titel = "متغيرات القائمة";
            this.Load += new System.EventHandler(this.frmPropertyList_Load);
            this.Controls.SetChildIndex(this.myLabel3, 0);
            this.Controls.SetChildIndex(this.txtPropertyValue, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.dgvPropertyList, 0);
            this.Controls.SetChildIndex(this.myLabel2, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.txtLIST_VALUE_EN, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPropertyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLIST_VALUE_EN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERP.myText txtPropertyValue;
        private ERP.myLabel myLabel3;
        private ERP.myBottun btnAdd;
        private ERP.myDataGrid dgvPropertyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private myLabel myLabel2;
        private myText txtLIST_VALUE_EN;
    }
}
