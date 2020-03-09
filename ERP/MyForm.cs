using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace ERP
{
    
    public partial class MyForm : Form 
    {
       public  DataTable dtPri;
    
        public MyForm()
        {
            InitializeComponent();
        }


        //public  void LoadConf()
        //{


        //}
    



        public string Titel
        {
            get { return this.myLabel1.Text; }
            set { this.myLabel1.Text = value; }

        }
        string strHelpPage="http://www.google.com";
        public string HelpPage
        {
            get { return strHelpPage; }
            set { strHelpPage = value; }

        }

        public glb_function.ProgramType _Type = glb_function.ProgramType.none;

        public glb_function.ProgramType PriviFile
        {
            get { return _Type; }
            set { _Type = value; }

        }
        public virtual void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        public bool HasPrivilege(string strPriv)
        {
            string str = dtPri.Rows.Count.ToString();
            string strss = dtPri.Rows[0]["en_name"].ToString();

            DataRow[] childRows = dtPri.Select("[en_name]='" + strPriv +"'");
            if (childRows[0]["control_type"].ToString() == "Enability")
            {
                if (childRows[0]["real_value"].ToString() == "1")
                    return true;
                else
                    return false;
            }
            if (childRows[0]["control_type"].ToString() == "Visability")
            {
                if (childRows[0]["real_value"].ToString() == "1")
                    return true;
                else
                    return false;
            }

            //for (int i = 0; i < dtPri.Rows.Count; i++)
            //{
            //    if(dtPri.Rows[i]["en_name"].ToString()==strPriv)
            //    {
            //        if(dtPri.Rows[i]["control_type"].ToString() == "Enability")
            //        {
            //            if (dtPri.Rows[i]["real_value"].ToString() == "1")
            //                return true;
            //            else
            //                return false;
            //        }
            //        if (dtPri.Rows[i]["control_type"].ToString() == "Visability")
            //        {
            //            if (dtPri.Rows[i]["real_value"].ToString() == "1")
            //                return true;
            //            else
            //                return false;
            //        }
            //    }


            //}

            return false ;
           
        }
        private void FindButs(Control ctlMain)
        {
            foreach (Control ctrl in ctlMain.Controls)
            {
                if (ctrl.GetType() == typeof(myBottun))
                {
                    if (!HasPrivilege(((myBottun)ctrl).w_Priv.ToString()))
                        ((myBottun)ctrl).Enabled = false;


                }
                else
                {
                    FindButs(ctrl);
                }

            }

        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            //new glb_function().clearItems(this);

            try
            {
                GetPrivForThisForm();

            }
            catch (Exception ex)
            {

                glb_function.MsgBox(ex.Message);
            }


        }
        private void GetPrivForThisForm()
        {
          //if(this.PriviFile==  glb_function.ProgramType.none )
          //          return;
            if (glb_function.glb_strUserName  == "")
                return;


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTemplete = cnn.GetDataTable("select u.templet_id,h.form_name from  templet_header h,user_templet u " +
                        " where h.swid = u.templet_id " +
                        " and h.form_eng_name = '" + this.Name + "' and u.user_id=" + glb_function.glb_strUserId);

            if (dtTemplete == null || dtTemplete.Rows.Count <= 0)
                return;
            lstTemplet.DataSource = dtTemplete;
            lstTemplet.ValueMember  = "templet_id";
            lstTemplet.DisplayMember = "form_name";

            lstTemplet.SelectedIndex = -1;
            lstTemplet.SelectedIndex = 0;

        }
        private bool mouseIsDown = false;
        private Point firstPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                firstPoint = e.Location;
                mouseIsDown = true;


            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown == true)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void MyForm_Resize(object sender, EventArgs e)
        {
            pxClose.Top = panel1.Height / 2 - pxClose.Height / 2;
            pxClose.Left = 0 ;
            pxHelp.Top = panel1.Height / 2 - pxHelp.Height / 2;
           pxHelp.Left = pxClose.Width+3;
            panel1.Width = this.Width;
           
            panel1.Top = 0;
            panel1.Left = 0;
            pnlHeadLine.Width = panel1.Width;
            pnlHeadLine.Left = 0;
            pnlHeadLine.Top = panel1.Height;
            //pnlTop.Width = this.Width;
            //pnlTop.Left = 0;
            //pnlTop.Top = panel1.Height + 5;

            lstTemplet.Left = this.Width / 2 - lstTemplet.Width / 2;
           
           
            myLabel1.Left = this.Width - myLabel1.Width  ;
            //rectangleShape1.Width = this.Width;
            //rectangleShape1.Height = this.Height;
            //rectangleShape1.Top = 0;
            //rectangleShape1.Left = 0;
            ////glb_function.MsgBox("test form");
        }

        private void pxHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.HelpPage );
        }

        private void myLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                firstPoint = e.Location;
                mouseIsDown = true;


            }
        }

        private void myLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown == true)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void myLabel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void MyForm_Paint(object sender, PaintEventArgs e)
        {
            Color border = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152))))); 
            e.Graphics.DrawRectangle(new Pen(border, 3),this.DisplayRectangle);
            //147, 149, 152
        }

        private void pxHelp_MouseHover(object sender, EventArgs e)
        {
            pxHelp.Cursor = Cursors.Hand;
        }

        private void pxClose_MouseHover(object sender, EventArgs e)
        {
            pxClose.Cursor = Cursors.Hand;
        }

        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        public virtual void lstTemplet_MorePrivilleges(object sender,EventArgs e)
        {
           //تستخدم هذه الدالة للتعامل مع الصلاحيات الخاصة للشاشة
        }

        private Control  GetControlByName(Control ctrl ,string Name)
        {
            Control  bReturn = null;
            foreach (Control c in ctrl.Controls)
                if (c.Name == Name)
                {
                     bReturn=c;
                    return bReturn;
                }
                    
                else
                    if(bReturn ==null)
                    bReturn= GetControlByName(c,Name);

            return bReturn;
        }
        private void lstTemplet_SelectedIndexChanged(object sender, EventArgs e)
        {


            new glb_function().clearItems(this);

            if (lstTemplet.SelectedValue == null)
                return;

            if (lstTemplet.SelectedValue.ToString() != "System.Data.DataRowView" && lstTemplet.SelectedValue.ToString() != "")
            {

                string strStat = "select h.swid,h.form_eng_name,h.form_type ,d.control_type,d.en_name,d.real_value,d.ar_name,multi_form_for_user " +
                      " from templet_header h,templet_details d" +
                     "  where h.swid = d.temp_header_id" +
                    "  and h.swid = " + lstTemplet.SelectedValue.ToString();

                ConnectionToDB cnn = new ConnectionToDB();
                dtPri = cnn.GetDataTable(strStat);

                if (dtPri.Rows[0]["multi_form_for_user"].ToString() == "1")
                {
                    lstTemplet.Visible = true;
                    lblTemplet.Visible = true;
                }


                for (int i = 0; i < dtPri.Rows.Count; i++)
                {
                    if (dtPri.Rows[i]["control_type"].ToString() == "Visability")
                    {
                        if (dtPri.Rows[i]["real_value"].ToString() == "1")
                        {
                            Control ctr = GetControlByName(this, dtPri.Rows[i]["en_name"].ToString());
                            if(ctr!=null)
                            ctr.Visible = true;
                        }
                           
                        else
                        {
                            Control ctr = GetControlByName(this, dtPri.Rows[i]["en_name"].ToString());
                            if (ctr != null)
                                ctr.Visible = false ;
                        }
                           
                    }
                    else if (dtPri.Rows[i]["control_type"].ToString() == "Enability")
                    {
                        if (dtPri.Rows[i]["real_value"].ToString() == "1")
                        {

                            Control ctr = GetControlByName(this, dtPri.Rows[i]["en_name"].ToString());
                            if (ctr != null)
                                ctr.Enabled  = true;
                            //string strss = dtPri.Rows[i]["en_name"].ToString();
                            //this.Controls[dtPri.Rows[i]["en_name"].ToString()].Enabled = true;
                        }
                           
                        else
                        {
                            Control ctr = GetControlByName(this, dtPri.Rows[i]["en_name"].ToString());
                            if (ctr != null)
                                ctr.Enabled = false ;
                        }
                           
                    }
                    else if (dtPri.Rows[i]["control_type"].ToString() == "List" || dtPri.Rows[i]["control_type"].ToString() == "Text" || dtPri.Rows[i]["control_type"].ToString() == "MultiChoices" || dtPri.Rows[i]["control_type"].ToString() == "Free MultiChoices" || dtPri.Rows[i]["control_type"].ToString() == "Free List")
                    {
                        //if (dtPri.Rows[i]["ar_name"].ToString() == "الفروع" || dtPri.Rows[i]["ar_name"].ToString() == "الفرع")
                        //{
                        //    // (GetControlByName(this, dtPri.Rows[i]["en_name"].ToString())).Text = dtPri.Rows[i]["real_value"].ToString();
                        //    Control ctr = GetControlByName(this, dtPri.Rows[i]["en_name"].ToString());
                        //    if (ctr != null)
                        //        ctr.Text = dtPri.Rows[i]["real_value"].ToString();
                        //}
                        //else if (dtPri.Rows[i]["ar_name"].ToString() == "الاقسام" || dtPri.Rows[i]["ar_name"].ToString() == "القسم")
                        //{
                        //    // (GetControlByName(this, dtPri.Rows[i]["en_name"].ToString())).Text = dtPri.Rows[i]["real_value"].ToString();
                        Control ctr = GetControlByName(this, dtPri.Rows[i]["en_name"].ToString());
                        if (ctr != null)
                            ctr.Text = dtPri.Rows[i]["real_value"].ToString();
                        //}

                    }
                   


                }



                lstTemplet_MorePrivilleges(sender,e );
            }
        }
    }
}
