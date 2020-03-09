using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmCreatePurchaseExp : MyForm
    {
        public frmCreatePurchaseExp()
        {
            InitializeComponent();
        }

        private void frmCreatePurchaseExp_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            btnUpdate.Enabled = false;

            FillExpAgreement("0");

            

        }
        private void FillExpAgreement(string strExpHeaderId)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtAgreement = cnn.GetDataTable("select d.swid,ei.swid exp_item_id ,ei.expenses_name,ei.expensesvalue_or_size "+
                 "    from expenses_item ei " +
                  "   left outer JOIN TERMS_EXPENSES_DETAILS d on(ei.swid = d.expenses_item_id and d.expenses_header_id = "+strExpHeaderId+") " +
                 "     order by d.swid");

            dgvExpAgreement.Rows.Clear();
            for (int i = 0; i < dtAgreement.Rows.Count; i++)
            {
                dgvExpAgreement.Rows.Add();
                dgvExpAgreement["clmSwid", dgvExpAgreement.Rows.Count - 1].Value = dtAgreement.Rows[i]["swid"].ToString();
                dgvExpAgreement["clmSelect", dgvExpAgreement.Rows.Count - 1].Value = (dtAgreement.Rows[i]["swid"].ToString() == "" ? false : true);
                dgvExpAgreement["clmExpItemId", dgvExpAgreement.Rows.Count - 1].Value = dtAgreement.Rows[i]["exp_item_id"].ToString() ;
                dgvExpAgreement["clmExpName", dgvExpAgreement.Rows.Count - 1].Value = dtAgreement.Rows[i]["expenses_name"].ToString();
                dgvExpAgreement["clmCalcMethod", dgvExpAgreement.Rows.Count - 1].Value = dtAgreement.Rows[i]["expensesvalue_or_size"].ToString();


            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetSwid = cnn.GetDataTable("(select nvl(max(swid),0)+1 from EXPENSES_ITEM)");
            txtEXPENSES_ItemSwid.Text = dtGetSwid.Rows[0][0].ToString();

            glb_function.arrInsertLogs.Add("insert into EXPENSES_ITEM values (" + txtEXPENSES_ItemSwid.Text + ","+
                                "'"+txtEXPENSES_NAME.Text +"','"+lstEXPENSES_TYPE.Text +"','"+lstEXPENSESVALUE_OR_SIZE.Text +"',sysdate,"+glb_function.glb_strUserId +",'فعال',"+lstAccNo.SelectedValue.ToString()+")");




            if (glb_function.MultiTransData())
                GetData(txtEXPENSES_ItemSwid.Text);
        }

        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;


            if (txtEXPENSES_NAME.Text.Trim() == "")
            {

                errCheck.SetError(txtEXPENSES_NAME, "الرجاء ادخال اسم المصروف");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtEXPENSES_NAME, "");
            }


            if (lstEXPENSES_TYPE.Text.Trim() == "")
            {

                errCheck.SetError(lstEXPENSES_TYPE, "الرجاء اختيار نوع المصروف");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstEXPENSES_TYPE, "");
            }
            
                if (lstEXPENSESVALUE_OR_SIZE.Text.Trim() == "")
            {

                errCheck.SetError(lstEXPENSESVALUE_OR_SIZE, "الرجاء اختيار طريقة الحساب ");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstEXPENSESVALUE_OR_SIZE, "");
            }




            if (lstAccNo.SelectedIndex == -1)
            {

                errCheck.SetError(lstAccNo, "يجب ادخال رقم الحساب ");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstAccNo, "");
            }

            if (lstAccName.SelectedIndex == -1)
            {

                errCheck.SetError(lstAccName, "يجب ادخال اسم الحساب ");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstAccName, "");
            }



            //2**********************************************
            //فحص هل اسم الحساب لديه نفس رقم تعريف رقم الحساب
            //فقط للتاكيد
            if (lstAccNo.SelectedValue == lstAccName.SelectedValue)
            {
                glb_function.MsgBox("الرجاء التاكد ان رقم الحساب يطابقة اسم الحساب");
                return false;
            }
            //2 End****************************************************

          

            if (iError == 1)
                return false;

            return true;
        }
        private void GetData(string strSwid)
        {
            btnNew_Click(null, null);
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtWareHouse = cnn.GetDataTable("select * from EXPENSES_ITEM where swid=" + strSwid);




            txtEXPENSES_ItemSwid.Text = strSwid;

            txtEXPENSES_NAME.Text = dtWareHouse.Rows[0]["EXPENSES_NAME"].ToString();
            txtEXPENSES_NAME.W_OldValue = dtWareHouse.Rows[0]["EXPENSES_NAME"].ToString();

            lstEXPENSES_TYPE.Text = dtWareHouse.Rows[0]["EXPENSES_TYPE"].ToString();
            lstEXPENSES_TYPE.W_OldValue = dtWareHouse.Rows[0]["EXPENSES_TYPE"].ToString();

            lstEXPENSESVALUE_OR_SIZE.Text = dtWareHouse.Rows[0]["EXPENSESVALUE_OR_SIZE"].ToString();
            lstEXPENSESVALUE_OR_SIZE.W_OldValue = dtWareHouse.Rows[0]["EXPENSESVALUE_OR_SIZE"].ToString();

            lstAccNo.SelectedValue = dtWareHouse.Rows[0]["ACC_ID"].ToString().Trim();
            lstAccNo.W_OldValue = (dtWareHouse.Rows[0]["ACC_ID"].ToString());





         


            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;

            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;

            }
        }
        private void GetAcc(string strAccType)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtAccData = new DataTable();
           
          
            string sql = "select swid,acc_no,acc_name from accounts a where acc_class='فرعي' and stat='فعال' "+strAccType;
            dtAccData = cnn.GetDataTable(sql);
            lstAccNo.DataSource = dtAccData;
            lstAccNo.ValueMember = "swid";
            lstAccNo.DisplayMember = "acc_no";


            lstAccName.DataSource = dtAccData;
            lstAccName.ValueMember = "swid";
            lstAccName.DisplayMember = "acc_name";

            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(pnlExpItem);


            PrepareForm();

            btnNew.Visible = false;
            btnSave.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            glb_function.arrInsertLogs = new System.Collections.ArrayList();
          
          
            

            glb_function.arrInsertLogs.Add("update EXPENSES_ITEM set "+
                                "EXPENSES_NAME='" + txtEXPENSES_NAME.Text + "',EXPENSES_TYPE='" + lstEXPENSES_TYPE.Text + "',EXPENSESVALUE_OR_SIZE='" + lstEXPENSESVALUE_OR_SIZE.Text + "',ACC_ID=" + lstAccNo.SelectedValue.ToString() + " where swid="+txtEXPENSES_ItemSwid.Text );




            if (glb_function.MultiTransData())
                GetData(txtEXPENSES_ItemSwid.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmGetExpensses frm = new frmGetExpensses();

            frm.ShowDialog();

            if (frm.strExpensses_id.Trim() != "")
            {
                txtEXPENSES_ItemSwid.Text = frm.strExpensses_id;
                GetData(txtEXPENSES_ItemSwid.Text);
            }
        }

        private void lstEXPENSES_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (lstEXPENSES_TYPE.Text == "شراء")
           //     GetAcc(" and system_acc_type like 'مصاريف مشتريات' ");
           //// else if(lstEXPENSES_TYPE.Text == "بيع")
           //else if(lstEXPENSES_TYPE.Text == "تحاويل مخزنية")
           //     GetAcc("and acc_type like 'مصاريف'");
           // else
                GetAcc(" and acc_type like 'مصاريف'");
        }

        private void pnlGnrlSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveTermExp_Click(object sender, EventArgs e)
        {
            if (!CheckExpAgreementEntries())
                return;
            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetSwid = cnn.GetDataTable("(select nvl(max(swid),0)+1 from TERMS_EXPENSES_HEADER)");
            txtTermExpSwid.Text = dtGetSwid.Rows[0][0].ToString();

            glb_function.arrInsertLogs.Add("insert into TERMS_EXPENSES_HEADER values (" + txtTermExpSwid.Text + ",sysdate," + glb_function.glb_strUserId + ",'فعال'," +
                                "'" + txtTERMS_NAME.Text  + "','" + txtTERMS_COD.Text  + "')");


            for (int i = 0; i < dgvExpAgreement.Rows.Count; i++)
            {
                if (dgvExpAgreement["clmSelect", i].Value.ToString() == "True")
                    glb_function.arrInsertLogs.Add("insert into TERMS_EXPENSES_DETAILS values ((select nvl(max(swid),0)+1 from TERMS_EXPENSES_DETAILS),"+ txtTermExpSwid.Text +","+dgvExpAgreement["clmExpItemId", i].Value.ToString()+")");
            }

            if (glb_function.MultiTransData())
                GetAgreementData(txtTermExpSwid.Text);

        }
        private void GetAgreementData(string strSwid)
        {
            btnNewTermExp_Click(null, null);
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTermsExp = cnn.GetDataTable("select TERMS_NAME,TERMS_CODE from TERMS_EXPENSES_HEADER where swid=" + strSwid);




            txtTermExpSwid.Text = strSwid;

            txtTERMS_NAME.Text = dtTermsExp.Rows[0]["TERMS_NAME"].ToString();
            txtTERMS_NAME.W_OldValue = dtTermsExp.Rows[0]["TERMS_NAME"].ToString();

            txtTERMS_COD.Text = dtTermsExp.Rows[0]["TERMS_CODE"].ToString();
            txtTERMS_COD.W_OldValue = dtTermsExp.Rows[0]["TERMS_CODE"].ToString();


            dtTermsExp.Clear();
            FillExpAgreement(txtTermExpSwid.Text);
            
            btnSaveTermExp.Visible = false;
            btnNewTermExp.Location = btnSaveTermExp.Location;
            btnNewTermExp.Visible = true;

            if (HasPrivilege("btnUpdateTermExp"))
                btnUpdateTermExp.Enabled = true;
        }
        private void btnNewTermExp_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(pnlExpAgreement);


            //  PrepareForm();
            FillExpAgreement("0");
            btnNewTermExp.Visible = false;
            btnSaveTermExp.Visible = true;
        }
        private bool CheckExpAgreementEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;


            if (txtTERMS_NAME.Text.Trim() == "")
            {

                errCheck.SetError(txtTERMS_NAME, "الرجاء ادخال اسم الاتفاق");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtTERMS_NAME, "");
            }

            int icheck = 0;
            for (int i = 0; i < dgvExpAgreement.Rows.Count; i++)
            {
                if (dgvExpAgreement[1, i].Value.ToString() == "True")
                {
                    icheck = 1;
                }
            }

            if(icheck==0)
            {
                glb_function.MsgBox("لم يتم تحديد اي مصروف");
                return false ;
            }

          



            if (iError == 1)
                return false;

            return true;
        }

        private void btnFindTermExp_Click(object sender, EventArgs e)
        {
            frmFindExpTerms frm = new frmFindExpTerms();

            frm.ShowDialog();

            if (frm.strExpTermID.Trim() != "")
            {
                txtTermExpSwid.Text = frm.strExpTermID;
                GetAgreementData(txtTermExpSwid.Text);
            }
        }

        private void btnUpdateTermExp_Click(object sender, EventArgs e)
        {
            if (!CheckExpAgreementEntries())
                return;
            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
           

            glb_function.arrInsertLogs.Add("update TERMS_EXPENSES_HEADER set  TERMS_NAME='" + txtTERMS_NAME.Text + "',TERMS_CODE='" + txtTERMS_COD.Text + "' where swid="+ txtTermExpSwid.Text);
            glb_function.arrInsertLogs.Add("delete from TERMS_EXPENSES_DETAILS where EXPENSES_HEADER_ID=" + txtTermExpSwid.Text);

            for (int i = 0; i < dgvExpAgreement.Rows.Count; i++)
            {
                if (dgvExpAgreement["clmSelect", i].Value.ToString() == "True")
                    glb_function.arrInsertLogs.Add("insert into TERMS_EXPENSES_DETAILS values ((select nvl(max(swid),0)+1 from TERMS_EXPENSES_DETAILS)," + txtTermExpSwid.Text + "," + dgvExpAgreement["clmExpItemId", i].Value.ToString() + ")");
            }

            if (glb_function.MultiTransData())
                GetAgreementData(txtTermExpSwid.Text);
        }
    }
}
