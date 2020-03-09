
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmExpensesAcc : MyForm
    {
        int iAccLevel;
        int iLastLevelValue;
        DataTable dtAccData;

        int iRow_Parent;//يستخدم للوصول الى بيانات الاب والتي نحتاجها لاضافة المصاريف الى جدول الحسابات

        public frmExpensesAcc()
        {
            InitializeComponent();
        }

        private void frmExpensesAcc_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            btnUpdate.Enabled = false;
            FillParentAcc();
        }
        private void FillParentAcc()
        {

            iAccLevel = 0;
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtLevelCount = cnn.GetDataTable("select the_value from DEFAULT_VALUES   where value_name='الرتبة'");

            if (dtLevelCount == null || dtLevelCount.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء تحديد عدد الرتب");
                return;
            }
            iAccLevel = Convert.ToInt16(dtLevelCount.Rows[0][0].ToString());


            dtAccData = cnn.GetDataTable("select * from accounts where   acc_class='رئيسي' and ACC_TYPE='مصاريف' and acc_level=" + (iAccLevel - 1));
            lstAccNo.DataSource = dtAccData;
            lstAccNo.DisplayMember = "acc_no";
            lstAccNo.ValueMember = "swid";

            lstAccName.DataSource = dtAccData;
            lstAccName.DisplayMember = "acc_name";
            lstAccName.ValueMember = "swid";

            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
        }


        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            myList LstAcc = sender as myList;
            if (LstAcc.SelectedValue == null)
                return;

            if (LstAcc.SelectedValue.ToString() != "System.Data.DataRowView" && LstAcc.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedIndex = lstAccName.SelectedIndex = LstAcc.SelectedIndex;
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtCasherAcc = cnn.GetDataTable("select the_value from DEFAULT_VALUES t where value_name ='الرتبة" + iAccLevel + "'");

                iLastLevelValue = Convert.ToInt16(dtCasherAcc.Rows[0][0].ToString());
                if (dtCasherAcc == null || dtCasherAcc.Rows.Count <= 0)
                {
                    glb_function.MsgBox("الرجاء تحديد عدد الرتبة الاخيرة للحسابات الفرعية");
                    return;
                }

                dtCasherAcc.Rows.Clear();


                dtCasherAcc = cnn.GetDataTable("select to_number( substr(acc_no,-" + iLastLevelValue + ")) from accounts " +
                            " where acc_parent = " + LstAcc.SelectedValue.ToString() + " ");
                txtAccNo.Text = "";
                int i = 0;
                for (i = 0; i < dtCasherAcc.Rows.Count; i++)
                {
                    if ((i + 1) != Convert.ToInt16(dtCasherAcc.Rows[i][0].ToString()))
                    {
                        txtAccNo.Text = (i + 1).ToString();
                        break;
                    }

                }

                if (txtAccNo.Text == "")
                    txtAccNo.Text = (i + 1).ToString();
                // txtAccNo.Text = dtCasherAcc.Rows[0][0].ToString();


                txtAccNo.Text = lstAccNo.Text + txtAccNo.Text.PadLeft(iLastLevelValue, '0');
                lstAccName.SelectedValue = LstAcc.SelectedValue;
                lstAccNo.SelectedValue = LstAcc.SelectedValue;

                iRow_Parent = GetParentRow(lstAccNo.SelectedValue.ToString());

            }
        }

        private int GetParentRow(string swid)
        {
            for (int i = 0; i < dtAccData.Rows.Count; i++)
            {
                if (dtAccData.Rows[i]["swid"].ToString() == swid)
                    return i;
            }

            return -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
            lstAccName.Enabled = true;
            lstAccNo.Enabled = true;
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (lstAccNo.SelectedIndex == -1 || lstAccName.SelectedIndex == -1)
            {

                errCheck.SetError(lstAccName, "الرجاء اختيار حساب الأب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstAccName, "");
            }



            if (txtAccNo.Text == "")
            {

                errCheck.SetError(txtAccNo, "لايوجد رقم حساب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtAccNo, "");
            }
            //txtC_Name
            if (txtExp_Name .Text == "")
            {

                errCheck.SetError(txtExp_Name, "الرجاء ادخال اسم للصندوق");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtExp_Name, "");
            }

          

           

           


            if (iError == 1)
                return false;

            return true;
        }
        private void GetData(string strSwid)
        {


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select * from accounts a " +
                    " where swid =" + strSwid);

            txtExp_Name.Text = dtLocation.Rows[0]["acc_name"].ToString();
            txtExp_Name.W_OldValue = dtLocation.Rows[0]["acc_name"].ToString();


           
            lstAccName.SelectedValue = Convert.ToInt16(dtLocation.Rows[0]["acc_parent"].ToString());

            txtAccNo.Text = dtLocation.Rows[0]["acc_no"].ToString();

           

           

            lstAccName.Enabled = false;
            lstAccNo.Enabled = false;
            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from ACCOUNTS");
            txtSWId .Text = dtGetId.Rows[0][0].ToString();
            glb_function.arrInsertLogs.Add
               ("insert into ACCOUNTS values ((" + txtSWId.Text + ")," +
               " sysdate,'فعال','" + txtAccNo.Text + "','" + dtAccData.Rows[iRow_Parent]["ACC_TYPE"].ToString() + "','" +
               txtExp_Name.Text + "'," + iAccLevel + ",'فرعي" +
               "','تم الانشاء من شاشة المصاريف',null," + lstAccName.SelectedValue.ToString() +
               "," + glb_function.glb_strUserId + ",'ارباح وخسائر','" +
                "عام',null)");

            dtGetId.Rows.Clear();
            dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from CASHER");
            txtSWId.Text = dtGetId.Rows[0][0].ToString();


           // glb_function.arrInsertLogs.Add("insert into CASHER values ((select nvl(max(swid),0)+1 from CASHER),sysdate," + glb_function.glb_strUserId + ",'فعال'," + txtAccId.Text + ",'" + txtC_Name.Text.Trim() + "','" + lstC_type.Text.Trim() + "','" + (ckbACCEPT_MINUS.Checked == true ? "1" : "0") + "'," + lstCashier.SelectedValue.ToString() + "," + lstBranches.SelectedValue.ToString() + ")");

            if (glb_function.MultiTransData ())
                GetData(txtSWId.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

           

            glb_function.arrInsertLogs.Add("update  accounts set " +
               " acc_Name='" + txtExp_Name.Text + "'" +
               " where swid=" + txtSWId.Text);

            new glb_function().InsertToLogs(this, "accounts", txtSWId.Text, "");
            //other table 

           if( glb_function.MultiTransData ())

            GetData(txtSWId.Text);

        }
    }
}
