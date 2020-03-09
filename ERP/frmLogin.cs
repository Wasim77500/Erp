using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ERP
{
    public partial class frmLogin : MyForm
    {
        private bool fromDownKey = false;
        Form frm = Application.OpenForms["frmMain"];
        public frmLogin()
        {
            InitializeComponent();
        }

     

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                txtUserid.Focus();
                lstYear.SelectedIndex = 0;
                
            }
            catch (Exception ex)
            {

                glb_function.MsgBox(ex.Message);
            }
            
        }
     
        private void txtUserid_KeyDown(object sender, KeyEventArgs e)
        {


            if (txtUserid.Text.ToLower() == "اسم المستخدم")
            {
                fromDownKey = true;
                txtUserid.Text = "";

            }

            fromDownKey = false;

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtUserid_Leave(object sender, EventArgs e)
        {
            if (txtUserid.Text.Trim() == "")
            {
                txtUserid.ForeColor = System.Drawing.Color.Silver;
                txtUserid.Text = "اسم المستخدم";

            }
        }

        private void txtUserid_TextChanged(object sender, EventArgs e)
        {
            if (txtUserid.Text.Trim() == "" && fromDownKey == false)
            {

                txtUserid.Text = "اسم المستخدم";
                txtUserid.ForeColor = System.Drawing.Color.Silver;
            }
            else
                txtUserid.ForeColor = System.Drawing.Color.Black;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" && fromDownKey == false)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "كلمة السر";
                txtPassword.ForeColor = System.Drawing.Color.Silver;

            }
            else
                txtPassword.ForeColor = System.Drawing.Color.Black;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


           // CnnDB  cnn = new CnnDB();
           ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLogin = cnn.GetDataTable("select swid,STAT,USER_LOGIN,USER_NAME,USER_BRANCH,(select branch_aname from  branches where swid=nvl(USER_BRANCH,0)) BranchName,access_type,dept_id,(select d.dept_aname from departements d where d.swid=dept_id) dept_name,to_char(sysdate,'dd/mm/yyyy')  TodayDate from USERINFO " +
                " where USER_LOGIN=N'" + txtUserid.Text.Trim().Replace("'", "").Trim() + "' and USER_PASSWORD='" + new glb_SysFun().Encrypt(txtPassword.Text.Trim(), true)+"'");

            if (dtLogin != null && dtLogin.Rows.Count != 0)
            {
                #region test
               // frmMain f = (frmMain)Application.OpenForms["frmMain"];
              //new glb_function(). LoginMethod(txtUserid.Text);
                #endregion


                if (dtLogin.Rows[0]["stat"].ToString() == "غير فعال")
                {
                    glb_function.MsgBox("المستخدم غير فعال", "رسالة نظام");
                    return;
                }
                string userip=glb_function. GetLocalIPAddress();
                DataTable dtUserAcc = new DataTable() ;
                // 1التاكد من ان المستخدم لديه الحق في الدخول من هذا الجهاز 
                string str = dtLogin.Rows[0]["access_type"].ToString();
                if (dtLogin.Rows[0]["access_type"].ToString() !="كل")
                {
                    
                    dtUserAcc = cnn.GetDataTable("select swid from USER_COMPUTERS t "+
                        " where t.userid ="+ dtLogin.Rows[0]["swid"].ToString() + " and (device_code = '"+glb_function.GetProcessorId() + "' or '"+userip +"' like t.device_code || '%' ) ");

                    if (dtUserAcc == null || dtUserAcc.Rows.Count <= 0)
                    {
                        glb_function.MsgBox("ليس لديك صلاحية للدخول من هذا الجهاز");
                        return;
                    }
                }



                //1*******************************************************

                //2التاكد ان المستخدم داخل من جهاز ثاني 
                dtUserAcc.Rows.Clear();

                dtUserAcc = cnn.GetDataTable("select swid,ip from USER_LOGS where user_id="+ dtLogin.Rows[0]["swid"].ToString() + " and (logoff_date ='' or logoff_date is null)");
                if (dtUserAcc.Rows.Count >= 1)
                {

                   
                        IPAddress ip = IPAddress.Parse(dtUserAcc.Rows[0]["ip"].ToString());
                    if (dtUserAcc.Rows[0]["ip"].ToString() != glb_function.GetLocalIPAddress())
                        if (glb_function.MsgBox("هذا المستخدم مسجل بجهاز اخر هل تريد الخروج منه والتسجيل من هذا الجهاز", "", true))
                    {


                       // glb_function.  SendMessage("<log off user >" +txtUserid.Text.Trim(), ip);
                    }
                    else
                        return;
                    int icheck1 = cnn.TranDataToDB("update USER_LOGS set logoff_date= sysdate where user_id=" + dtLogin.Rows[0]["swid"].ToString() + " and (logoff_date ='' or logoff_date is null)");
                        if (icheck1 <= 0)
                        {
                            glb_function.MsgBox("حدث خطأ ");
                            return;
                        }
                        cnn.glb_commitTransaction();
                   
                }
                //2********************************

                //3 فحص هل المستخدم تغير ام لا
                if (glb_function.glb_strUserLogin  != txtUserid.Text)
                {
                    //OpenForms f = new Application.OpenForms();
                  
                    for (int i = Application.OpenForms.Count-1; i >=0 ; i--)
                    {
                        if (((Form)(Application.OpenForms[i])).Name != "frmMain" && Application.OpenForms[i].Name != "frmLogin")
                            Application.OpenForms[i].Close();
                    }
                  
                }


                //3***************************
                //4 إنشاء بيانات الدخول وفتح جلسة للمستخدم

                int icheck = cnn.TranDataToDB("insert into USER_LOGS values((select nvl(max(swid),0)+1 from USER_LOGS),"+ dtLogin.Rows[0]["swid"].ToString() + ",sys_context('USERENV','SID'),sys_context('USERENV','HOST'),sysdate,null,'" + userip + "')");
                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء تسجيل بيانات الدخول");
                    return;
                }
                cnn.glb_commitTransaction();
                //4***************************************
                glb_function.glb_strUserId = dtLogin.Rows[0]["swid"].ToString();
                glb_function .glb_strUserLogin= dtLogin.Rows[0]["USER_LOGIN"].ToString();
                glb_function.glb_strUserName = dtLogin.Rows[0]["USER_NAME"].ToString();
                glb_function.glb_BranchNo =Convert.ToInt16( dtLogin.Rows[0]["USER_BRANCH"].ToString());
                glb_function.glb_BranchName= dtLogin.Rows[0]["BranchName"].ToString();
                glb_function.glb_deptId= Convert.ToInt16(dtLogin.Rows[0]["dept_id"].ToString());
                glb_function.glb_DeptName = dtLogin.Rows[0]["dept_name"].ToString();
                glb_function.dtSysdate = DateTime.ParseExact(dtLogin.Rows[0]["TodayDate"].ToString(),"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);

                //***************
                DataTable dtMainCurr = cnn.GetDataTable("select swid,curr_name,curr_decimal from currency c where c.is_main_curr = '1'");

                if (dtMainCurr == null || dtMainCurr.Rows.Count <= 0)
                {
                    glb_function.MsgBox("لايوجد عملة رئيسية للنظام");
                 //   SOWAID.frmCurrency frm = new frmCurrency();
                    //frm.FormClosed += Frm_FormClosed;
                    //frm.ShowDialog();
                    
                }
                else
                {
                    glb_function.glb_MainCurrencyId = Convert.ToInt16(dtMainCurr.Rows[0]["swid"].ToString());
                    glb_function.glbMainCurrencyName = dtMainCurr.Rows[0]["curr_name"].ToString();
                   glb_function. glbMainDecimalPoint=Convert.ToInt16( dtMainCurr.Rows[0]["curr_decimal"].ToString());
                }
                    
            //*****************
            }
            else
            {
                glb_function.MsgBox("كلمة السر او اسم المستخدم غير صحيحة","تنبية");
                return;
            }

           

            //DataTable dtSession = cnn.GetDataTable("select sys_context('USERENV', 'SID') from dual ");
            //MessageBox.Show(dtSession.Rows[0][0].ToString());

            
            this.Close();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (glb_function.glbMainCurrencyName == "")
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    //  if (((Form)(Application.OpenForms[i])).Name != "frmMain" && Application.OpenForms[i].Name != "frmLogin")
                    Application.OpenForms[i].Close();
                }
            else
                btnLogin_Click(null, null);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPassword.Text.ToLower() == "كلمة السر")
            {
                fromDownKey = true;
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }

            fromDownKey = false;
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(null, null);
        }

       
        
      
       
       
         
        public override void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           

           // glb_SysFun.MyAppExit();
            

        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string strip = glb_function.GetLocalIPAddress();
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

           
            //Account.CrystalReport1 rep = new Account.CrystalReport1();
           //SharedForms.frmRepContainer  frm = new SharedForms.frmRepContainer();
           // ConnectionToDB cnnRep = new ConnectionToDB();
           // DataTable dtReport;

           // dtReport = cnnRep.GetDataTable("select * from branches");

           // rep.SetDataSource(dtReport);
            //frm.crvViewReports .ReportSource = rep;
           
            //frm.ShowDialog();
        }

        private void myBottun1_Click(object sender, EventArgs e)
        {
           
            string strBarcod = "";
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtChar = cnn.GetDataTable("select barcode from beneficiary where swid=1827 ");
            string str = dtChar.Rows[0][0].ToString();
            str = str.Substring(str.Length - 1);
            int icheck = 0;
            dtChar.Clear();
            dtChar = cnn.GetDataTable("select swid, barcode from beneficiary");
            try
            {
                for (int i = 0; i < dtChar.Rows.Count; i++)
                {
                   
                    if(dtChar.Rows[i]["barcode"].ToString()!="")
                    if (dtChar.Rows[i]["barcode"].ToString().Substring(dtChar.Rows[i]["barcode"].ToString().Length - 1) == str)
                        {
                            icheck = cnn.TranDataToDB("update beneficiary set barcode='" + dtChar.Rows[i]["barcode"].ToString().Replace(str, "") + "' where swid=" + dtChar.Rows[i]["swid"].ToString());
                        }
                      
                }
            }
            catch (Exception)
            {

                string   strtes = strBarcod;
            }
            
            cnn.glb_commitTransaction();
        }

        private void myBottun1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            return;
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
