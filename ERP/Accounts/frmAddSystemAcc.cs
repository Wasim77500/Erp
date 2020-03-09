
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmAddSystemAcc : MyForm
    {
        int iAccLevel;
        int iLastLevelValue;
        DataTable dtAccData;

        int iRow_Parent;//يستخدم للوصول الى بيانات الاب والتي نحتاجها لاضافة الحساب الى جدول الحسابات
        string[,] acctype;
        public frmAddSystemAcc()
        {
            InitializeComponent();
        }

        private void frmAddSystemAcc_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            try
            { 
                btnUpdate.Enabled = false;
           
          
                acctype = new string[2, 16];

            

                acctype[0 , 0] = "فرق عملة";
                acctype[1, 0] = "مخصصات";

                acctype[0, 1] = "فرق كسر";
                acctype[1, 1] = "مخصصات";

                acctype[0, 2] = "مبيعات";
                acctype[1, 2] = "مبيعات";

                acctype[0, 3] = "تكلفة مبيعات";
                acctype[1, 3] = "تكلفة مبيعات";

                acctype[0, 4] = "اقفال ارباح وخسائر";
                acctype[1, 4] = "ارباح وخسائر";

                acctype[0, 5] = "اوراق قبض";
                acctype[1, 5] = "اوراق مدينة";

                acctype[0, 6] = "اوراق دفع";
                acctype[1, 6] = "اوراق دائنة";

                acctype[0, 7] = "شيكات تحت التحصيل";
                acctype[1, 7] = "اوراق مدينة";

                acctype[0, 8] = "مردود مبيعات";
                acctype[1, 8] = "مردود مبيعات";

                acctype[0, 9] = "مردود مشتريات";
                acctype[1, 9] = "مردود مشتريات";

            

                acctype[0, 10] = "وسيط قبض";
                acctype[1, 10] = "وسيط قبض";

                acctype[0, 11] = "اهلاك";
                acctype[1, 11] = "مخصصات";

                acctype[0, 12] = "اعتمادات";
                acctype[1, 12] = "الاعتمادات والمشتريات";

                acctype[0, 13] = "وارد";
                acctype[1, 13] = "الاعتمادات والمشتريات";

                acctype[0, 14] = "مصاريف مشتريات";
                acctype[1, 14] = "الاعتمادات والمشتريات";

                acctype[0, 15] = "بضاعة في الطريق";
                acctype[1, 15] = "الاعتمادات والمشتريات";

                FillAccType();
            }
            catch (Exception ee)
            {
                glb_function.MsgBox(ee.Message);
            }

        }
        private void FillAccType()
        {
            for (int i = 0; i < acctype.Length/2; i++)
            {
                lstB_ACC_TYPE.Items.Add(acctype[0, i]);
            }
        }

        private void FillParentAcc(string strAccType)
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
            //dtAccData = cnn.GetDataTable("select * from accounts where   acc_class='رئيسي' and ACC_TYPE='بنوك' and acc_level=" + (iAccLevel - 1));

            dtAccData = cnn.GetDataTable("select * from accounts where   acc_class='رئيسي' and ACC_TYPE='"+ strAccType + "' and acc_level=" + (iAccLevel - 1));
            if (dtAccData != null && dtAccData.Rows.Count > 0)

            {


                lstAccNo.DataSource = dtAccData;
                lstAccNo.DisplayMember = "Acc_no";
                lstAccNo.ValueMember = "swid".ToUpper();

                lstAccName.DataSource = dtAccData;

                lstAccName.DisplayMember = "acc_name";
                lstAccName.ValueMember = "swid".ToUpper();

                lstAccNo.SelectedIndex = -1;
                lstAccName.SelectedIndex = -1;
            }
        }

       

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList LstAcc = sender as myList;
            string str = LstAcc.Name;
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
                            " where acc_parent = " + LstAcc.SelectedValue.ToString() + " order by 1");
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
                txtACC_SUBJECT.Text = dtAccData.Rows[iRow_Parent]["ACC_SUBJECT"].ToString();

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

        private void lstB_ACC_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstB_ACC_TYPE.SelectedValue == null)
            //    return;

            if (lstB_ACC_TYPE.Text  != "System.Data.DataRowView" && lstB_ACC_TYPE.Text  != "")
            {
                string strAccType = "";
                for (int i = 0; i < acctype.Length/2 ; i++)
                {
                    if (lstB_ACC_TYPE.Text == acctype[0, i])
                    {
                        strAccType = acctype[1, i];
                        break;
                    }
                }
                FillParentAcc(strAccType);
            }

               
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
            if (txtAcc_NAME.Text == "")
            {

                errCheck.SetError(txtAcc_NAME, "الرجاء ادخال اسم الحساب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtAcc_NAME, "");
            }

            if (lstB_ACC_TYPE.Text == "")
            {

                errCheck.SetError(lstB_ACC_TYPE, "الرجاء اختيار نوع الحساب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstB_ACC_TYPE, "");
            }

            //التاكد ان فرق العملة وفرق الكسر وغيرها من حسابات مدخلة من قبل

            //لان النظام لايقبل الا حساب واحد فقط لكل من الحسابات المذكوره سابقا في قائمة  
            //lstB_ACC_TYPE
            //اما الانواع المذكرة تاليا مثل اهلاك واوراق الدفع واوراق القبض يمكن ان تتعدد

            if (lstB_ACC_TYPE.Text != "اوراق قبض" && lstB_ACC_TYPE.Text != "اوراق دفع" || lstB_ACC_TYPE.Text != "اهلاك")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtDiff = cnn.GetDataTable("select swid from accounts a where a.system_acc_type='"+lstB_ACC_TYPE.Text +"'");
                if (dtDiff != null && dtDiff.Rows.Count >= 1)
                {
                    glb_function.MsgBox("النظام لايقبل الا حساب واحد فقط لـ" + " " + lstB_ACC_TYPE.Text);
                    return false;
                }
            }
               
            //*****************************************************************


            if (iError == 1)
                return false;

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetId = cnn.GetDataTable("select nvl(max(swid),0)+1 from ACCOUNTS");
            txtSWID .Text = dtGetId.Rows[0][0].ToString();
            glb_function.arrInsertLogs.Add
               ("insert into ACCOUNTS values ((" + txtSWID.Text + ")," +
               " sysdate,'فعال','" + txtAccNo.Text + "','" + dtAccData.Rows[iRow_Parent]["ACC_TYPE"].ToString() + "','" +
               txtAcc_NAME.Text + "'," + iAccLevel + ",'فرعي" +
               "','تم الانشاء من شاشة الحسابات الافتراضية',null," + lstAccName.SelectedValue.ToString() +
               "," + glb_function.glb_strUserId + ",'"+txtACC_SUBJECT.Text +"','" +
                "مركزي','"+lstB_ACC_TYPE.Text +"',null,null)");


            if (lstB_ACC_TYPE.Text == "فرق عملة" || lstB_ACC_TYPE.Text == "فرق كسر")
            {
                glb_function.arrInsertLogs.Add("insert into ACC_CURR values ((select nvl(max(swid),0)+1 from ACC_CURR),sysdate," + glb_function.glb_strUserId + "," + txtSWID .Text + "," + glb_function.glb_MainCurrencyId + ",null)");
            }
    

            if (glb_function.MultiTransData ())
                GetData(txtSWID.Text);
        }
        private void GetData(string strSwid)
        {


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select *  from accounts a  " +
                    "  where  a.swid =" + strSwid);


            txtSWID.Text = dtLocation.Rows[0]["swid"].ToString();


            txtAcc_NAME.Text = dtLocation.Rows[0]["Acc_name"].ToString();
            txtAcc_NAME.W_OldValue = dtLocation.Rows[0]["Acc_name"].ToString();



            lstAccName.SelectedValue = Convert.ToInt16(dtLocation.Rows[0]["acc_parent"].ToString());

            txtAccNo.Text = dtLocation.Rows[0]["acc_no"].ToString();

            

            lstB_ACC_TYPE.Text = dtLocation.Rows[0]["SYSTEM_ACC_TYPE"].ToString();

           

            lstAccName.Enabled = false;
            lstAccNo.Enabled = false;
            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

           

            glb_function.arrInsertLogs.Add("update  accounts set " +
               " acc_Name='" + txtAcc_NAME .Text + "'" +
               " where swid=" + txtSWID.Text);

            
            new glb_function().InsertToLogs(this, "Accounts", txtSWID.Text, "");
            //other table 

           if( glb_function.MultiTransData())
            GetData(txtSWID.Text);
        }
    }
}
