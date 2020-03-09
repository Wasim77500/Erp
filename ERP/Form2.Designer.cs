namespace ERP
{
    partial class Form2
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
            this.myText1 = new ERP.myText();
            this.myBottun1 = new ERP.myBottun();
            this.myBottun2 = new ERP.myBottun();
            this.txtFrom = new ERP.myText();
            this.txtTo = new ERP.myText();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo)).BeginInit();
            this.SuspendLayout();
            // 
            // myText1
            // 
            this.myText1.BeforeTouchSize = new System.Drawing.Size(340, 290);
            this.myText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myText1.Font = new System.Drawing.Font("Arial", 10F);
            this.myText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.myText1.Location = new System.Drawing.Point(183, 105);
            this.myText1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.myText1.Multiline = true;
            this.myText1.Name = "myText1";
            this.myText1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.myText1.Size = new System.Drawing.Size(340, 290);
            this.myText1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.myText1.TabIndex = 1;
            this.myText1.W_Clear = true;
            this.myText1.W_ColArName = "";
            this.myText1.W_ColEgName = "";
            this.myText1.W_OldValue = "";
            this.myText1.W_TableName = "";
            // 
            // myBottun1
            // 
            this.myBottun1.BeforeTouchSize = new System.Drawing.Size(75, 28);
            this.myBottun1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun1.FlatAppearance.BorderSize = 0;
            this.myBottun1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBottun1.IsBackStageButton = false;
            this.myBottun1.Location = new System.Drawing.Point(12, 12);
            this.myBottun1.Name = "myBottun1";
            this.myBottun1.Size = new System.Drawing.Size(75, 28);
            this.myBottun1.TabIndex = 0;
            this.myBottun1.Text = "source";
            this.myBottun1.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun1.w_Type = ERP.myBottun.Btton_type.none;
            this.myBottun1.Click += new System.EventHandler(this.myBottun1_Click);
            // 
            // myBottun2
            // 
            this.myBottun2.BeforeTouchSize = new System.Drawing.Size(110, 28);
            this.myBottun2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBottun2.FlatAppearance.BorderSize = 0;
            this.myBottun2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBottun2.IsBackStageButton = false;
            this.myBottun2.Location = new System.Drawing.Point(270, 17);
            this.myBottun2.Name = "myBottun2";
            this.myBottun2.Size = new System.Drawing.Size(110, 28);
            this.myBottun2.TabIndex = 2;
            this.myBottun2.Text = "Distination";
            this.myBottun2.w_Priv = ERP.myBottun.Btton_Priv.none;
            this.myBottun2.w_Type = ERP.myBottun.Btton_type.none;
            this.myBottun2.Click += new System.EventHandler(this.myBottun2_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.BeforeTouchSize = new System.Drawing.Size(340, 290);
            this.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrom.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtFrom.Location = new System.Drawing.Point(84, 17);
            this.txtFrom.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(191, 23);
            this.txtFrom.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFrom.TabIndex = 3;
            this.txtFrom.W_Clear = true;
            this.txtFrom.W_ColArName = "";
            this.txtFrom.W_ColEgName = "";
            this.txtFrom.W_OldValue = "";
            this.txtFrom.W_TableName = "";
            // 
            // txtTo
            // 
            this.txtTo.BeforeTouchSize = new System.Drawing.Size(340, 290);
            this.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.txtTo.Location = new System.Drawing.Point(400, 22);
            this.txtTo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(367, 23);
            this.txtTo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTo.TabIndex = 4;
            this.txtTo.W_Clear = true;
            this.txtTo.W_ColArName = "";
            this.txtTo.W_ColEgName = "";
            this.txtTo.W_OldValue = "";
            this.txtTo.W_TableName = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.myBottun2);
            this.Controls.Add(this.myText1);
            this.Controls.Add(this.myBottun1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.myText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myBottun myBottun1;
        private myText myText1;
        private myBottun myBottun2;
        private myText txtFrom;
        private myText txtTo;
        private System.Windows.Forms.Button button1;
    }
}