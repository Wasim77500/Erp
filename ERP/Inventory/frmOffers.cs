using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmOffers : MyForm
    {
        public frmOffers()
        {
            InitializeComponent();
        }

        private void btnFindCust_Click(object sender, EventArgs e)
        {
          Sales.  frmFindCustomer frm = new Sales.frmFindCustomer();

            frm.ShowDialog();

            if (frm.strCustomerID.Trim() != "")
            {
                txtPEOPLE_ID.Text = frm.strCustomerID;
                GetCustData(txtPEOPLE_ID.Text);
            }
        }
        private void GetCustData(string strSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dt = cnn.GetDataTable("select p.p_name from people p where p.swid= "+strSwid );

            txtCustName.Text = dt.Rows[0][0].ToString();
        }

        private void frmOffers_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {

            glb_function.FillListWithId(ref lstOFFERS_BRANCH, "BRANCHES", "BRANCH_ANAME");
            dtpOFFERS_START.Value = dtpEXPIRY_DATE_BEFORE.Value = dtpOFFERS_END.Value = DateTime.Now;
            GetOfferData();
            lstPaymentType.Text = "نقد";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into OFFERS values((select nvl(max(swid),0)+1 from OFFERS),sysdate,"+glb_function.glb_strUserId +
                ",'فعال',"+txtPRICEID.Text +",'"+lstOFFER_TYPE.Text +"','"+ lstSPECIAL_CLASS .Text +
                "','"+ lstSPECIFIC_PRICE_TYPE .Text + "','"+txtOFFERS_NAME.Text +
                "',"+nmbQUANTITY.Value.ToString()+
                ",to_date('"+dtpOFFERS_START.Value.ToString("dd/MM/yyyy")+
                "','dd/mm/yy'),to_date('" + dtpOFFERS_END.Value.ToString("dd/MM/yyyy") + "','dd/mm/yy'),to_date('" +
                dtpEXPIRY_DATE_BEFORE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yy'),"+(txtPEOPLE_ID.Text==""?"null":txtPEOPLE_ID.Text ) +","+
                (lstOFFERS_BRANCH.SelectedIndex ==-1?"null":lstOFFERS_BRANCH.SelectedValue) +
                ","+(txtCOUPON_id.Text==""?"null":txtCOUPON_id.Text ) +","+ (txtModelId.Text==""?"null":txtModelId.Text ) +",'"+lstPaymentType.Text +"')");

            if(icheck <=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء اضافة العرض");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت اضافة العرض بنجاح");
            GetOfferData();

          
        }

        private void GetOfferData()
        {
            dgvOffers.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtOffers = cnn.GetDataTable("select f.swid, offer_type, special_class,"+
                        " specific_price_type, offers_name, quantity, "+
                        " offers_start, offers_end, expiry_date_before, people_id,(select p_name from people p where p.swid=people_id) CustName, " +
                         " offers_branch, coupon, offers_model_id,PaymentType from offers f" +
                          " where priceid = "+txtPRICEID.Text );

            for (int i = 0; i < dtOffers.Rows.Count; i++)
            {
                dgvOffers.Rows.Add();
                dgvOffers[0, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["swid"].ToString();
                dgvOffers[1, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["OFFERS_NAME"].ToString(); 
                dgvOffers[2, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["OFFER_TYPE"].ToString(); 
                dgvOffers[3, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["SPECIAL_CLASS"].ToString(); 
                dgvOffers[4, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["SPECIFIC_PRICE_TYPE"].ToString(); 
                dgvOffers[5, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["QUANTITY"].ToString(); 
                dgvOffers[6, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["EXPIRY_DATE_BEFORE"].ToString(); 
                dgvOffers[7, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["OFFERS_START"].ToString(); 
                dgvOffers[8, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["OFFERS_END"].ToString(); 
                dgvOffers[9, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["PEOPLE_ID"].ToString(); 
                dgvOffers[10, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["CustName"].ToString();
                dgvOffers[11, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["OFFERS_BRANCH"].ToString();
                dgvOffers[12, dgvOffers.Rows.Count - 1].Value =( dtOffers.Rows[i]["OFFERS_BRANCH"].ToString()==""?"": GetBranchName(dtOffers.Rows[i]["OFFERS_BRANCH"].ToString()));
                lstOFFERS_BRANCH.SelectedIndex = -1;
                dgvOffers[13, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["COUPON"].ToString();
                dgvOffers[14, dgvOffers.Rows.Count - 1].Value = "";// dtOffers.Rows[i][""].ToString(); //txtCOUPON_Name.Text;
                dgvOffers[15, dgvOffers.Rows.Count - 1].Value = dtOffers.Rows[i]["OFFERS_MODEL_ID"].ToString();
                dgvOffers[16, dgvOffers.Rows.Count - 1].Value = "";// dtOffers.Rows[i][""].ToString(); //txtModelName.Text;
                dgvOffers[17, dgvOffers.Rows.Count - 1].Value = lstPaymentType.Text ;
            }

        }
        private string GetBranchName(string BranchId)
        {
            lstOFFERS_BRANCH.SelectedValue = BranchId;

            return lstOFFERS_BRANCH.Text ;
        }
        private bool CheckEntries()
        {
           

            int iError = 0;
            if (txtOFFERS_NAME.Text.Trim() == "")
            {

                errCheck.SetError(txtOFFERS_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtOFFERS_NAME, "");
            }

            if (lstOFFER_TYPE.Text  == "")
            {

                errCheck.SetError(lstOFFER_TYPE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstOFFER_TYPE, "");
            }

            if (lstSPECIAL_CLASS.Text == "")
            {

                errCheck.SetError(lstSPECIAL_CLASS, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstSPECIAL_CLASS, "");
            }

            if (lstSPECIFIC_PRICE_TYPE.Text == "")
            {

                errCheck.SetError(lstSPECIFIC_PRICE_TYPE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstSPECIFIC_PRICE_TYPE, "");
            }


            if (iError == 1)
                return false;

            return true;
        }

      private bool  CheckEntriesQty()
        {
            int iError = 0;
            if (nmbQTY.Value <=0)
            {

                errCheck.SetError(nmbQTY, "الرجاء ادخال القيمة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbQTY, "");
            }

            if(dgvOffers.CurrentRow.Index<0)
            {
                glb_function.MsgBox("الرجاء تحديد عرض ليتم اضافة الكميات عليه");
                return false;
            }

            for (int i = 0; i < dgvOfferQty.Rows.Count; i++)
            {
                if(nmbQTY.Value.ToString()==dgvOfferQty[1,i].Value.ToString())
                {
                    glb_function.MsgBox("تمت ادخال القيمة من قبل");
                    return false;
                }
            }

            if (iError == 1)
                return false;
            return true;
        }
        private void btnAddQty_Click(object sender, EventArgs e)
        {
            if (!CheckEntriesQty())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into OFFER_QTY values((select nvl(max(swid),0)+1 from OFFER_QTY),sysdate," + glb_function.glb_strUserId +
                ",'فعال',"+nmbQTY.Value .ToString()+","+nmbDISCOUNT.Value.ToString()+","+dgvOffers[0,dgvOffers.CurrentRow.Index].Value.ToString()+")");

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الاضافة");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت الأضافة بنجاح");
            GetOfferQty();
        }
        private void GetOfferQty()
        {
            dgvOfferQty.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtOfferQty = cnn.GetDataTable("select swid,qty,discount from offer_qty t "+
                        " where t.offer_id =  "+ dgvOffers[0, dgvOffers.CurrentRow.Index].Value.ToString());

            for (int i = 0; i < dtOfferQty.Rows.Count; i++)
            {
                dgvOfferQty.Rows.Add();
                dgvOfferQty[0, dgvOfferQty.Rows.Count - 1].Value = dtOfferQty.Rows[i]["swid"].ToString();
                dgvOfferQty[1, dgvOfferQty.Rows.Count - 1].Value = dtOfferQty.Rows[i]["qty"].ToString();
                dgvOfferQty[2, dgvOfferQty.Rows.Count - 1].Value = dtOfferQty.Rows[i]["discount"].ToString();

            }


        }

        private void dgvOffers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                GetOfferQty();

        }
    }
}
