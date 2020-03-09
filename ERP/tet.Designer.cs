namespace ERP
{
    partial class tet
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
            this.myText1 = new ERP.myText();
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myText1)).BeginInit();
            this.SuspendLayout();
            // 
            // pxClose
            // 
            this.pxClose.Location = new System.Drawing.Point(0, 1);
            // 
            // lstTemplet
            // 
            this.lstTemplet.Location = new System.Drawing.Point(220, 34);
            // 
            // lblTemplet
            // 
            this.lblTemplet.Location = new System.Drawing.Point(133, 34);
            // 
            // myText1
            // 
            this.myText1.BeforeTouchSize = new System.Drawing.Size(100, 20);
            this.myText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myText1.Font = new System.Drawing.Font("Arial", 10F);
            this.myText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.myText1.Location = new System.Drawing.Point(221, 144);
            this.myText1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.myText1.Name = "myText1";
            this.myText1.Size = new System.Drawing.Size(100, 23);
            this.myText1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.myText1.TabIndex = 4;
            this.myText1.Text = "myText1";
            this.myText1.W_Clear = true;
            this.myText1.W_ColArName = "";
            this.myText1.W_ColEgName = "";
            this.myText1.W_OldValue = "";
            this.myText1.W_TableName = "";
            // 
            // tet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(608, 365);
            this.Controls.Add(this.myText1);
            this.Name = "tet";
            this.Load += new System.EventHandler(this.tet_Load);
            this.Controls.SetChildIndex(this.lstTemplet, 0);
            this.Controls.SetChildIndex(this.lblTemplet, 0);
            this.Controls.SetChildIndex(this.myText1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myText1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myText myText1;
    }
}
