namespace ERP
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myDataGrid1 = new ERP.myDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbEditor = new ERP.myNumber();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.myGroupBox1 = new ERP.myGroupBox();
            this.txtItemNo = new ERP.myText();
            this.myBottun1 = new ERP.myBottun();
            this.txtItemSwid = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemSwid)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(253, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(166, 34);
            // 
            // myDataGrid1
            // 
            this.myDataGrid1.AllowUserToAddRows = false;
            this.myDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.myDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.myDataGrid1.EnableHeadersVisualStyles = false;
            this.myDataGrid1.Location = new System.Drawing.Point(39, 64);
            this.myDataGrid1.Name = "myDataGrid1";
            this.myDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myDataGrid1.RowHeadersVisible = false;
            this.myDataGrid1.Size = new System.Drawing.Size(582, 150);
            this.myDataGrid1.TabIndex = 4;
            this.myDataGrid1.W_Clear = true;
            this.myDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGrid1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // nmbEditor
            // 
            this.nmbEditor.BackGroundColor = System.Drawing.SystemColors.Window;
            this.nmbEditor.BeforeTouchSize = new System.Drawing.Size(60, 23);
            this.nmbEditor.DecimalPlaces = 0;
            this.nmbEditor.DoubleValue = 0D;
            this.nmbEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbEditor.Location = new System.Drawing.Point(282, 234);
            this.nmbEditor.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nmbEditor.MinValue = 0D;
            this.nmbEditor.Name = "nmbEditor";
            this.nmbEditor.NullString = "";
            this.nmbEditor.NumberDecimalDigits = 0;
            this.nmbEditor.Size = new System.Drawing.Size(121, 23);
            this.nmbEditor.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.nmbEditor.TabIndex = 433;
            this.nmbEditor.Text = "0";
            this.nmbEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbEditor.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmbEditor.Visible = false;
            this.nmbEditor.W_Clear = true;
            this.nmbEditor.W_ColArName = "";
            this.nmbEditor.W_ColEgName = "";
            this.nmbEditor.W_OldValue = "";
            this.nmbEditor.W_TableName = "";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(282, 308);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 20);
            this.txtSearch.TabIndex = 434;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 435;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 436;
            this.button2.Text = "execute bat file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtItemSwid);
            this.myGroupBox1.Controls.Add(this.myBottun1);
            this.myGroupBox1.Controls.Add(this.txtItemNo);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.Location = new System.Drawing.Point(12, 273);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(246, 111);
            this.myGroupBox1.TabIndex = 437;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "حذف القطع";
            // 
            // txtItemNo
            // 
            this.txtItemNo.BeforeTouchSize = new System.Drawing.Size(60, 23);
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtItemNo.Location = new System.Drawing.Point(45, 28);
            this.txtItemNo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(100, 23);
            this.txtItemNo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtItemNo.TabIndex = 0;
            this.txtItemNo.W_Clear = true;
            this.txtItemNo.W_ColArName = "";
            this.txtItemNo.W_ColEgName = "";
            this.txtItemNo.W_OldValue = "";
            this.txtItemNo.W_TableName = "";
            // 
            // myBottun1
            // 
            this.myBottun1.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.myBottun1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun1.FlatAppearance.BorderSize = 0;
            this.myBottun1.IsBackStageButton = false;
            this.myBottun1.Location = new System.Drawing.Point(67, 57);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(56, 28);
            this.myBottun1.TabIndex = 1;
            this.myBottun1.Text = "حذف";
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.none;
            this.myBottun1.Click += new System.EventHandler(this.myBottun1_Click);
            // 
            // txtItemSwid
            // 
            this.txtItemSwid.BeforeTouchSize = new System.Drawing.Size(60, 23);
            this.txtItemSwid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSwid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemSwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtItemSwid.Location = new System.Drawing.Point(154, 62);
            this.txtItemSwid.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtItemSwid.Name = "txtItemSwid";
            this.txtItemSwid.Size = new System.Drawing.Size(60, 23);
            this.txtItemSwid.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtItemSwid.TabIndex = 2;
            this.txtItemSwid.W_Clear = true;
            this.txtItemSwid.W_ColArName = "";
            this.txtItemSwid.W_ColEgName = "";
            this.txtItemSwid.W_OldValue = "";
            this.txtItemSwid.W_TableName = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(675, 413);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.nmbEditor);
            this.Controls.Add(this.myDataGrid1);
            this.Name = "Form1";
            this.RightToLeftLayout = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myDataGrid1, 0);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.nmbEditor, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemSwid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataGrid myDataGrid1;
        private myNumber nmbEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private myGroupBox myGroupBox1;
        private myBottun myBottun1;
        private myText txtItemNo;
        private myText txtItemSwid;
    }
}