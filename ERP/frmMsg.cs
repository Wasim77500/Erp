using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmMsg : Form
    {
        public frmMsg()
        {
            InitializeComponent();
        }

        private void frmMsg_Load(object sender, EventArgs e)
        {


            this.Size = new System.Drawing.Size(lblMsg.Width + 26, lblMsg.Height + gbBut.Height + 60);


            lblMsg.Left = (this.ClientSize.Width - lblMsg.Width) / 2;
            gbBut.Top = lblMsg.Location.Y + lblMsg.Size.Height + 10;
            gbBut.Left = (this.ClientSize.Width - gbBut.Width) / 2;
            // lblMsg.Top = (this.ClientSize.Height - lblMsg.Height) / 2;
            this.CenterToParent();
            //myLabel1.Left = this.Size.Width - myLabel1.Width;
           


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            glb_function.blMsg = false;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            glb_function.blMsg = true;
            this.Close();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click_1(object sender, EventArgs e)
        {

        }

        private void myPanal1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMsg_Resize(object sender, EventArgs e)
        {
            //  pnlBotom.Width = this.Width;
            //pnlBotom.Left = 0;
            //pnlBotom.Top = this.Height - pnlBotom.Height;

            //pnlLeft.Height = this.Height  ;
            //pnlLeft.Left = 0;
            //pnlLeft.Top = 0 ;

            //pnlRight.Height = this.Height  ;
            //pnlRight.Left = this.Width-7;
            //pnlRight.Top = 0;

            //pnlTop.Width = this.Width;
            //pnlTop.Left = 0;
            //pnlTop.Top = 0;
            //pnlBotom.BringToFront();
            //pnlLeft.BringToFront();
            //pnlRight.BringToFront();
            //pnlTop.BringToFront();

        }

        private void frmMsg_Paint(object sender, PaintEventArgs e)
        {
            Color border = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            e.Graphics.DrawRectangle(new Pen(border, 3), this.DisplayRectangle);
        }
    }
}
