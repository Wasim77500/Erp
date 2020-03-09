namespace ERP
{
    partial class frmRepContainer
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
            this.crvViewReports = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvViewReports
            // 
            this.crvViewReports.ActiveViewIndex = -1;
            this.crvViewReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvViewReports.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvViewReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvViewReports.Location = new System.Drawing.Point(0, 0);
            this.crvViewReports.Name = "crvViewReports";
            this.crvViewReports.ShowGroupTreeButton = false;
            this.crvViewReports.ShowLogo = false;
            this.crvViewReports.Size = new System.Drawing.Size(911, 419);
            this.crvViewReports.TabIndex = 0;
            this.crvViewReports.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRepContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 419);
            this.Controls.Add(this.crvViewReports);
            this.Name = "frmRepContainer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "التقارير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRepContainer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvViewReports;
    }
}