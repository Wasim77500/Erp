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
    public partial class frmPurchaseRequest : MyForm
    {
        public frmPurchaseRequest()
        {
            InitializeComponent();
        }

        private void frmPurchaseRequest_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            
            new glb_function().clearItems(gbItems);
            txtCustomerId.Text = "";
            txtCUSTOMER_ACCID.Text = "";
            txtContactName.Text = "";
            txtCONTACT_ID.Text = "";
           
            txtCurrentQty.Text = "0";
            txtAcceptQty.Text = "0";
            nmbQty.Value = 0;
            FillBranchRequest();
        }
        private void FillBranchRequest()
        {
            dgREQUESTS_PURCHASES.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBranchRequest = cnn.GetDataTable("select rp.swid,"+
                        " item_id, (select item_name from items i where i.swid = rp.item_id) item_name,"+
                        " branch_id,(select branch_aname from branches b where b.swid = rp.branch_id) branch_name,"+
                        " customer_accid,"+
                        " contact_id,(select adb_name from address_book ab where ab.swid = rp.contact_id) contact_name,"+
                        " qty"+
                         " from  requests_purchases rp"+
                         " where rp.stat = 'فعال' and rp.branch_id=" + glb_function.glb_BranchNo +
                         " ");

            for (int i = 0; i < dtBranchRequest.Rows.Count; i++)
            {
                dgREQUESTS_PURCHASES.Rows.Add();
                dgREQUESTS_PURCHASES[0, dgREQUESTS_PURCHASES.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["swid"].ToString();
                dgREQUESTS_PURCHASES[1, dgREQUESTS_PURCHASES.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["item_id"].ToString();
                dgREQUESTS_PURCHASES[2, dgREQUESTS_PURCHASES.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["item_name"].ToString();
                dgREQUESTS_PURCHASES[3, dgREQUESTS_PURCHASES.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["contact_id"].ToString();
                dgREQUESTS_PURCHASES[4, dgREQUESTS_PURCHASES.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["contact_name"].ToString();
                dgREQUESTS_PURCHASES[5, dgREQUESTS_PURCHASES.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["qty"].ToString();
               

            }
             
        }
       

       
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            if (dgREQUESTS_PURCHASES.Rows.Count <= 0)
            {
                glb_function.MsgBox("لاتوجد بيانات للحفظ");
                return false;
            }
                


            return true;
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            Sales.frmFindCustomer frm = new Sales.frmFindCustomer();

            frm.ShowDialog();

            if (frm.strCustomerID.Trim() != "")
            {
                txtCustomerId.Text = frm.strCustomerID;
                GetCustomerData(txtCustomerId.Text);
            }
        }
        private void GetCustomerData(string strId)
        {
          
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtCustomers = cnn.GetDataTable("select p.swid,p.acc_id,a.acc_no,p.p_name, " +
                                      " (select max( swid ) contact_id from address_book ab where ab.people_id=p.swid) contact_id " +
                                       "  from people p , accounts a " +
                                      "  where p.acc_id = a.swid and  p.swid = " + strId);

                txtCustomerId.Text = strId;

               
                txtCUSTOMER_ACCID.Text = dtCustomers.Rows[0]["acc_no"].ToString();
            
                txtContactName.Text = dtCustomers.Rows[0]["p_name"].ToString();

            txtCONTACT_ID .Text = dtCustomers.Rows[0]["contact_id"].ToString();

           
          




            }

        private void btnFindContact_Click(object sender, EventArgs e)
        {
            File.frmContacts frm = new File.frmContacts();
            frm.ShowDialog();
          if(frm.txtSWID.Text.Trim() !="")
            {
                txtCONTACT_ID.Text = frm.txtSWID.Text;
                txtContactName.Text = frm.txtADB_NAME.Text;
                txtCustomerId.Text = "";
                txtCUSTOMER_ACCID.Text = "";
            }
               
            
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
           Inventory. frmFindItem frm = new Inventory.frmFindItem();

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtItemId.Text = frm.strItemID;
                GetItemData(txtItemId.Text);
                GetTotalQty();
            }
        }

        private void GetTotalQty()
        {

        }
        private void GetItemData(string strItemSwid)
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems = cnn.GetDataTable("select i.swid,item_no,item_name,c.category_name,a.act_name " +
                               "  from items i, CATEGORIES c, activities a  " +
                            "    where c.swid = i.category_id  " +
                              "  and a.swid = i.activity_id and i.swid=" + strItemSwid);

            txtItemNo.Text = dtItems.Rows[0]["item_no"].ToString();
            txtItemName.Text = dtItems.Rows[0]["item_name"].ToString();
            txtCatagory.Text = dtItems.Rows[0]["category_name"].ToString();
            txtActivity.Text = dtItems.Rows[0]["act_name"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemId.Text.Trim() == "" || txtItemNo.Text == "")
            {
                glb_function.MsgBox("الرجاء التأكد من بيانات الصنف");
                return;
            }
            if (nmbQty.Value <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال الكمية المطلوبة");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = 0;
            int iRow = GetDuplicated();
            if(iRow !=-2)
            {
                if (glb_function.MsgBox("القطعة مدخلة من قبل بعدد :" + dgREQUESTS_PURCHASES[5, iRow].Value.ToString() + "\n" + "هل تريد إضافة هذه الكمية الى الكمية السابقة؟", "", true) == true)
                {

                    icheck = cnn.TranDataToDB("update REQUESTS_PURCHASES " +
                        " set QTY=qty+" + nmbQty.Value.ToString() +
                        " where swid=" + dgREQUESTS_PURCHASES[0, iRow].Value.ToString());

                    if (icheck <= 0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء عملية تحديث الكمية");
                        return;
                    }

                }
                else
                    return;

            }
            else
            {
                icheck = cnn.TranDataToDB("insert into  REQUESTS_PURCHASES values"+
                    " ((select nvl(max(swid),0)+1 from REQUESTS_PURCHASES),sysdate,"+
                    glb_function.glb_strUserId +",'فعال',"+nmbQty.Value.ToString()+
                    ","+txtItemId.Text +","+glb_function.glb_BranchNo+","+
                    (txtCustomerId.Text.Trim()==""?"null":txtCustomerId.Text.Trim()) +","+(txtCONTACT_ID.Text.Trim()==""?"null": txtCONTACT_ID.Text.Trim()) + ")");




                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ القطعة");

                    return;
                }
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
           
            PrepareForm();


        }
        private int GetDuplicated()
        {
            for (int i = 0; i < dgREQUESTS_PURCHASES.Rows.Count; i++)
            {
                if(txtItemId.Text .Trim()==dgREQUESTS_PURCHASES[1,i].Value.ToString().Trim()    && txtCONTACT_ID.Text .Trim()==dgREQUESTS_PURCHASES[3,i].Value.ToString().Trim()    )
                {
                    return i;
                }
            }
            return -2;
        }
    }
}
