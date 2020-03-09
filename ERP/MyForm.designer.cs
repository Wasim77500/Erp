namespace ERP
{
    partial class MyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pxHelp = new System.Windows.Forms.PictureBox();
            this.pxClose = new System.Windows.Forms.PictureBox();
            this.myLabel1 = new ERP.myLabel();
            this.pnlHeadLine = new System.Windows.Forms.Panel();
            this.lblTemplet = new ERP.myLabel();
            this.lstTemplet = new ERP.myList();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pxHelp);
            this.panel1.Controls.Add(this.pxClose);
            this.panel1.Controls.Add(this.myLabel1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pxHelp
            // 
            this.pxHelp.Image = global::ERP.Properties.Resources.Help;
            this.pxHelp.Location = new System.Drawing.Point(130, 1);
            this.pxHelp.Name = "pxHelp";
            this.pxHelp.Size = new System.Drawing.Size(23, 24);
            this.pxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxHelp.TabIndex = 124;
            this.pxHelp.TabStop = false;
            this.pxHelp.Click += new System.EventHandler(this.pxHelp_Click);
            this.pxHelp.MouseHover += new System.EventHandler(this.pxHelp_MouseHover);
            // 
            // pxClose
            // 
            this.pxClose.Image = global::ERP.Properties.Resources.CloseForm;
            this.pxClose.Location = new System.Drawing.Point(3, 1);
            this.pxClose.Name = "pxClose";
            this.pxClose.Size = new System.Drawing.Size(23, 24);
            this.pxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxClose.TabIndex = 2;
            this.pxClose.TabStop = false;
            this.pxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pxClose.MouseHover += new System.EventHandler(this.pxClose_MouseHover);
            // 
            // myLabel1
            // 
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.myLabel1.ForeColor = System.Drawing.Color.Black;
            this.myLabel1.Location = new System.Drawing.Point(166, 4);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myLabel1.Size = new System.Drawing.Size(91, 21);
            this.myLabel1.TabIndex = 123;
            this.myLabel1.Text = "عنوان الشاشة";
            this.myLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myLabel1_MouseDown);
            this.myLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myLabel1_MouseMove);
            this.myLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myLabel1_MouseUp);
            // 
            // pnlHeadLine
            // 
            this.pnlHeadLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.pnlHeadLine.Location = new System.Drawing.Point(12, 34);
            this.pnlHeadLine.Name = "pnlHeadLine";
            this.pnlHeadLine.Size = new System.Drawing.Size(189, 1);
            this.pnlHeadLine.TabIndex = 1;
            // 
            // lblTemplet
            // 
            this.lblTemplet.BackColor = System.Drawing.Color.Transparent;
            this.lblTemplet.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTemplet.DX = 172;
            this.lblTemplet.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemplet.ForeColor = System.Drawing.Color.Black;
            this.lblTemplet.LabeledControl = this.lstTemplet;
            this.lblTemplet.Location = new System.Drawing.Point(45, 34);
            this.lblTemplet.Name = "lblTemplet";
            this.lblTemplet.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.lblTemplet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTemplet.Size = new System.Drawing.Size(84, 18);
            this.lblTemplet.TabIndex = 3;
            this.lblTemplet.Text = "النماذج المتاحة";
            this.lblTemplet.Visible = false;
            // 
            // lstTemplet
            // 
            this.lstTemplet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstTemplet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstTemplet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTemplet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lstTemplet.Font = new System.Drawing.Font("Arial", 10F);
            this.lstTemplet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.lstTemplet.FormattingEnabled = true;
            this.lstTemplet.Location = new System.Drawing.Point(132, 34);
            this.lstTemplet.Name = "lstTemplet";
            this.lstTemplet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstTemplet.Size = new System.Drawing.Size(169, 24);
            this.lstTemplet.TabIndex = 2;
            this.lstTemplet.Visible = false;
            this.lstTemplet.W_Clear = false;
            this.lstTemplet.W_ColArName = "";
            this.lstTemplet.W_ColEgName = "";
            this.lstTemplet.W_OldValue = "";
            this.lstTemplet.W_TableName = "";
            this.lstTemplet.w_ValueType = ERP.myList.ValueType.TEXT;
            this.lstTemplet.SelectedIndexChanged += new System.EventHandler(this.lstTemplet_SelectedIndexChanged);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(569, 343);
            this.ControlBox = false;
            this.Controls.Add(this.lblTemplet);
            this.Controls.Add(this.lstTemplet);
            this.Controls.Add(this.pnlHeadLine);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyForm_FormClosed);
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyForm_Paint);
            this.Resize += new System.EventHandler(this.MyForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private myLabel myLabel1;
        private System.Windows.Forms.Panel pnlHeadLine;
        private System.Windows.Forms.PictureBox pxHelp;
        public System.Windows.Forms.PictureBox pxClose;
        public myList lstTemplet;
        public myLabel lblTemplet;
    }


}