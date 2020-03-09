namespace ERP
{
    partial class frmMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMsg));
            this.myPanal1 = new ERP.myPanal();
            this.gbBut = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.myPanal1.SuspendLayout();
            this.gbBut.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPanal1
            // 
            this.myPanal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.myPanal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myPanal1.Controls.Add(this.gbBut);
            this.myPanal1.Controls.Add(this.lblMsg);
            this.myPanal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanal1.Location = new System.Drawing.Point(0, 0);
            this.myPanal1.Name = "myPanal1";
            this.myPanal1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myPanal1.Size = new System.Drawing.Size(387, 224);
            this.myPanal1.TabIndex = 2;
            this.myPanal1.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanal1_Paint);
            // 
            // gbBut
            // 
            this.gbBut.BackColor = System.Drawing.Color.Transparent;
            this.gbBut.Controls.Add(this.btnOk);
            this.gbBut.Controls.Add(this.btnYes);
            this.gbBut.Controls.Add(this.btnNO);
            this.gbBut.Location = new System.Drawing.Point(127, 86);
            this.gbBut.Name = "gbBut";
            this.gbBut.Size = new System.Drawing.Size(147, 52);
            this.gbBut.TabIndex = 5;
            this.gbBut.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = global::ERP.Properties.Resources.MainBG;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnOk.Image = global::ERP.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(40, 13);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 28);
            this.btnOk.TabIndex = 3;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnYes.Image = global::ERP.Properties.Resources.Ok;
            this.btnYes.Location = new System.Drawing.Point(76, 13);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(57, 28);
            this.btnYes.TabIndex = 2;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNO
            // 
            this.btnNO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNO.BackgroundImage")));
            this.btnNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNO.FlatAppearance.BorderSize = 0;
            this.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNO.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnNO.Image = global::ERP.Properties.Resources.Exit;
            this.btnNO.Location = new System.Drawing.Point(6, 13);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(57, 28);
            this.btnNO.TabIndex = 3;
            this.btnNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Visible = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(36, 39);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(34, 24);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "....";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 224);
            this.ControlBox = false;
            this.Controls.Add(this.myPanal1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMsg";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMsg_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMsg_Paint);
            this.Resize += new System.EventHandler(this.frmMsg_Resize);
            this.myPanal1.ResumeLayout(false);
            this.myPanal1.PerformLayout();
            this.gbBut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private myPanal myPanal1;
        private System.Windows.Forms.GroupBox gbBut;
        public System.Windows.Forms.Button btnNO;
        public System.Windows.Forms.Button btnYes;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.Label lblMsg;
    }
}