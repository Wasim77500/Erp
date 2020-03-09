using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmChangePassword : MyForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToDB conn = new ConnectionToDB();
            DataTable dtLogin = conn.GetDataTable("select swid,STAT,USER_LOGIN,USER_NAME from USERINFO " +
                " where USER_LOGIN='" + glb_function.glb_strUserLogin.Replace("'", "").Trim() + "' and USER_PASSWORD='" + new glb_SysFun().Encrypt(txtOldPassword.Text.Trim(), true) + "'");

            if (dtLogin != null && dtLogin.Rows.Count != 0)
            {

                if (txtPassword.Text.Trim() != txtConfirmPass.Text.Trim())
                {
                    glb_function.MsgBox("كلمة السر غير متطابقة");
                    return;
                }
               
                int icheck = conn.TranDataToDB("update USERINFO set USER_PASSWORD='" + new glb_SysFun().Encrypt(txtPassword.Text.Trim(), true) + "' where SWID=" + glb_function.glb_strUserId);
                if (icheck <= 0)
                {

                    conn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ عند تغير كلمة السر");
                    return;
                }

                conn.glb_commitTransaction();
                glb_function.MsgBox("تمت عملية تغير كلمة السر بنجاح" + "\n" + "الرجاء تسجيل الدخول للتاكد");

                this.Close();
            }
            else
            {
                glb_function.MsgBox("الرجاء التاكد من كلمة السر السابقة", "رسالة نظام");
                return;
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
           
            //  base.LoadConf();
        }
    }
}
