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
    public partial class frmRequirementRequest : MyForm
    {
        public frmRequirementRequest()
        {
            InitializeComponent();
        }

        private void frmRequirementRequest_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            new glb_function().clearItems(gbItems);
            FillBranchRequest();
        }
        private void FillBranchRequest()
        {
            dgvPurchaseRequest.Rows.Clear();
            dgvUpdatePurchaseRequest.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();


            //DataTable dtBranchRequest = cnn.GetDataTable("select rp.swid," +
            //         " rp.item_id, (select item_name from items i where i.swid = rp.item_id) item_name," +
            //         " branch_id,(select branch_aname from branches b where b.swid = rp.branch_id) branch_name," +
            //         " customer_accid," +
            //         " contact_id,(select adb_name from address_book ab where ab.swid = rp.contact_id) contact_name," +
            //         " qty," +
            //         "    (select sum(IN_OUT_QTY) from REQUIREMENTS_REQUESTS rr  where  rr.requests_purchases_id=rp.swid group by rp.branch_id,rp.item_id ,rp.contact_id ) accepted_qty" +
            //          " from  requests_purchases rp" +
            //          " where rp.stat = 'فعال' order by rp.swid" +
            //          " ");


            //For new Order (dgPurchaseRequest grid)
            DataTable dtBranchRequest = cnn.GetDataTable("select rp.swid," +
                     " rp.item_id, (select item_name from items i where i.swid = rp.item_id) item_name," +
                     " branch_id,(select branch_aname from branches b where b.swid = rp.branch_id) branch_name," +
                     " customer_accid," +
                     " contact_id,(select adb_name from address_book ab where ab.swid = rp.contact_id) contact_name," +
                     " qty," +
                     "    (select sum(IN_OUT_QTY)" +
                        "  from REQUIREMENTS_REQUESTS rr , requests_purchases rp2" +
                        "  where  rr.requests_purchases_id = rp2.swid" +
                         " and rp.branch_id = rp2.branch_id" +
                       "   and rp.item_id = rp2.item_id" +
                         " and  (nvl(rp.contact_id,0) = nvl(rp2.contact_id ,0) )) accepted_qty" +
                      " from  requests_purchases rp" +
                      " where rp.stat = 'فعال' order by rp.swid" +
                      " ");




            for (int i = 0; i < dtBranchRequest.Rows.Count; i++)
            {
                dgvPurchaseRequest.Rows.Add();
                dgvPurchaseRequest[0, dgvPurchaseRequest.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["swid"].ToString();
                dgvPurchaseRequest[1, dgvPurchaseRequest.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["item_id"].ToString();
                dgvPurchaseRequest[2, dgvPurchaseRequest.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["item_name"].ToString();
                dgvPurchaseRequest[3, dgvPurchaseRequest.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["branch_id"].ToString();
                dgvPurchaseRequest[4, dgvPurchaseRequest.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["branch_name"].ToString();
                dgvPurchaseRequest[5, dgvPurchaseRequest.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["contact_id"].ToString();
                dgvPurchaseRequest[6, dgvPurchaseRequest.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["contact_name"].ToString();
               
                dgvPurchaseRequest[7, dgvPurchaseRequest.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["qty"].ToString();
                dgvPurchaseRequest[8, dgvPurchaseRequest.Rows.Count - 1].Value = dtBranchRequest.Rows[i]["accepted_qty"].ToString();
                dgvPurchaseRequest[9, dgvPurchaseRequest.Rows.Count - 1].Value = "0";

            }


            //for old order (dgvUpdatePurchaseRequest grid)
            DataTable dtUpdateRequest = cnn.GetDataTable("select rr.swid, " +
                              "   rp.item_id, (select item_name from items i where i.swid = rp.item_id) item_name, " +
                               "  branch_id,(select branch_aname from branches b where b.swid = rp.branch_id) branch_name, " +
                                " customer_accid, " +
                               "  contact_id,(select adb_name from address_book ab where ab.swid = rp.contact_id) contact_name, " +
                               "  rp.qty,rr.in_out_qty " +
                               "  from requests_purchases rp, REQUIREMENTS_REQUESTS rr " +
                               "  where rr.requests_purchases_id = rp.swid " +
                               " and rp.stat = 'معتمد'");

            for (int i = 0; i < dtUpdateRequest.Rows.Count; i++)
            {
                dgvUpdatePurchaseRequest.Rows.Add();
                dgvUpdatePurchaseRequest[0, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["swid"].ToString();
                dgvUpdatePurchaseRequest[1, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["item_id"].ToString();
                dgvUpdatePurchaseRequest[2, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["item_name"].ToString();
                dgvUpdatePurchaseRequest[3, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["branch_id"].ToString();
                dgvUpdatePurchaseRequest[4, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["branch_name"].ToString();
                dgvUpdatePurchaseRequest[5, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["contact_id"].ToString();
                dgvUpdatePurchaseRequest[6, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["contact_name"].ToString();

                dgvUpdatePurchaseRequest[7, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["qty"].ToString();
                dgvUpdatePurchaseRequest[8, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["in_out_qty"].ToString();
                dgvUpdatePurchaseRequest[9, dgvUpdatePurchaseRequest.Rows.Count - 1].Value = dtUpdateRequest.Rows[i]["in_out_qty"].ToString();
            }


        }

        private void dgPurchaseRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 9)
            {
              

                    DataGridViewCell abc = dgvPurchaseRequest.CurrentCell;

                Rectangle RECT = dgvPurchaseRequest.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);

                nmbEditorNewReq.Value = Convert.ToDecimal(dgvPurchaseRequest[9, e.RowIndex].Value.ToString());
                nmbEditorNewReq.Tag = e.RowIndex.ToString();
                CtlLocation(RECT, nmbEditorNewReq,ref dgvPurchaseRequest);
            }
        }
        private void CtlLocation(Rectangle rect, Control ctrl,ref myDataGrid dgvEdit)
        {


            ctrl.Top = dgvEdit.Location.Y + rect.Y;
            ctrl.Left = dgvEdit.Location.X + rect.X;
            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;
            ctrl.Focus();


        }

       
        

        private void nmbEditorNewReq_Leave(object sender, EventArgs e)
        {
            if (nmbEditorNewReq.Visible == true)
            {
                nmbEditorNewReq.Visible = false;

                dgvPurchaseRequest[9, Convert.ToUInt16(nmbEditorNewReq.Tag.ToString())].Value = nmbEditorNewReq.Value.ToString();

            }
        }

        private void nmbEditorNewReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.SendWait("{TAB}");
        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceptNewRequest_Click(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtHelp = new DataTable() ;
            int icheck = 0;
            for (int i = 0; i < dgvPurchaseRequest.Rows.Count; i++)
            {
                if(Convert.ToInt32( dgvPurchaseRequest[9,i].Value.ToString())<=0 )
                {
                    icheck = cnn.TranDataToDB("update requests_purchases set stat='ملغي' where swid=" + dgvPurchaseRequest[0, i].Value.ToString());

                    if(icheck <=0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ عند تعديل بيانات الصنف :" + dgvPurchaseRequest[2, i].Value.ToString());

                        return;
                    }

                }
                else
                {
                    string strREQUIREMENTS_LIST_ID;
                    dtHelp.Clear();
                    dtHelp = cnn.GetDataTable("select swid,item_id from REQUIREMENTS_LIST_DE where item_id= " + dgvPurchaseRequest[1, i].Value.ToString());
                    if (dtHelp == null || dtHelp.Rows.Count <= 0)
                        strREQUIREMENTS_LIST_ID = "null";
                    else if(dtHelp.Rows.Count ==1)
                            strREQUIREMENTS_LIST_ID = dtHelp.Rows[0]["swid"].ToString();
                    else
                    {
                        int itcs = dtHelp.Rows.Count;
                        glb_function.MsgBox("عدد الصفوف للصنف مكرر"+"\n"+"الرجاء مراجعة مدير النظام");
                        return;
                    }

                    icheck = cnn.TranDataToDB("update requests_purchases set stat='معتمد' where swid=" + dgvPurchaseRequest[0, i].Value.ToString());

                    if (icheck <= 0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ عند تعديل بيانات الصنف :" + dgvPurchaseRequest[2, i].Value.ToString());

                        return;
                    }
                    if(strREQUIREMENTS_LIST_ID=="null")
                    {
                        dtHelp.Rows.Clear();
                        dtHelp = cnn.GetDataTable("select nvl(max(swid),0)+1 from REQUIREMENTS_LIST_DE");
                        strREQUIREMENTS_LIST_ID = dtHelp.Rows[0][0].ToString();
                        icheck = cnn.TranDataToDB("insert into REQUIREMENTS_LIST_DE values(("+ strREQUIREMENTS_LIST_ID + "),sysdate," + glb_function.glb_strUserId + ",'فعال'," + dgvPurchaseRequest[1, i].Value.ToString() + ")");

                        if (icheck <= 0)
                        {
                            cnn.glb_RollbackTransaction();
                            glb_function.MsgBox("حدث خطأ عند الموافقة على بيانات الصنف :" + dgvPurchaseRequest[2, i].Value.ToString());

                            return;
                        }
                    }
                   

                    icheck = cnn.TranDataToDB("insert into REQUIREMENTS_REQUESTS values((select nvl(max(swid),0)+1 from REQUIREMENTS_REQUESTS),sysdate," + glb_function.glb_strUserId + ","+ dgvPurchaseRequest[9, i].Value.ToString() + "," + dgvPurchaseRequest[0, i].Value.ToString() + ","+ strREQUIREMENTS_LIST_ID + ",'فعال',null)");

                    if (icheck <= 0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ عند الموافقة على بيانات الصنف :" + dgvPurchaseRequest[2, i].Value.ToString());

                        return;
                    }

                }
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تم اعتماد الطلبات");

            FillBranchRequest();
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            Inventory.frmFindItem frm = new Inventory.frmFindItem();

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
        private void GetItemData(string strSwid)
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems = cnn.GetDataTable("select i.swid,item_no,item_name,c.category_name,a.act_name " +
                               "  from items i, CATEGORIES c, activities a  " +
                            "    where c.swid = i.category_id  " +
                              "  and a.swid = i.activity_id and i.swid=" + strSwid);

            txtItemNo.Text = dtItems.Rows[0]["item_no"].ToString();
            txtItemName.Text = dtItems.Rows[0]["item_name"].ToString();
            txtCatagory.Text = dtItems.Rows[0]["category_name"].ToString();
            txtActivity.Text = dtItems.Rows[0]["act_name"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtItemId.Text .Trim()=="" || txtItemNo.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء اختيار الصنف");
                return;
            }
            if(nmbQty.Value<=0)
            {
                glb_function.MsgBox("الرجاء ادخال الكمية المطلوبة");
                nmbQty.Focus();
                return;
            }

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtHelp = new DataTable();
            int icheck = 0;

            string strREQUIREMENTS_LIST_ID;
            dtHelp = cnn.GetDataTable("select swid,item_id from REQUIREMENTS_LIST_DE where item_id= " + txtItemId.Text .Trim());
            if (dtHelp == null || dtHelp.Rows.Count <= 0)
                strREQUIREMENTS_LIST_ID = "null";
            else if (dtHelp.Rows.Count == 1)
                strREQUIREMENTS_LIST_ID = dtHelp.Rows[0]["swid"].ToString();
            else
            {
                glb_function.MsgBox("عدد الصفوف للصنف مكرر" + "\n" + "الرجاء مراجعة مدير النظام");
                return;
            }

           
            if (strREQUIREMENTS_LIST_ID == "null")
            {
                dtHelp.Rows.Clear();
                dtHelp = cnn.GetDataTable("select nvl(max(swid),0)+1 from REQUIREMENTS_LIST_DE");
                strREQUIREMENTS_LIST_ID = dtHelp.Rows[0][0].ToString();
                icheck = cnn.TranDataToDB("insert into REQUIREMENTS_LIST_DE values((" + strREQUIREMENTS_LIST_ID + "),sysdate," + glb_function.glb_strUserId + ",'فعال'," + txtItemId.Text .Trim() + ")");

                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ عند الموافقة على بيانات الصنف :" + txtItemNo.Text );

                    return;
                }
            }


            icheck = cnn.TranDataToDB("insert into REQUIREMENTS_REQUESTS values((select nvl(max(swid),0)+1 from REQUIREMENTS_REQUESTS),sysdate," + glb_function.glb_strUserId + "," + nmbQty.Value.ToString()+ ",null," + strREQUIREMENTS_LIST_ID + ",'فعال',null)");

            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ عند الموافقة على بيانات الصنف :" + txtItemNo.Text );

                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الاضافة بنجاح");

        }

        private void nmbEditorUpdateReq_Leave(object sender, EventArgs e)
        {
            if (nmbEditorUpdateReq.Visible == true)
            {
                nmbEditorUpdateReq.Visible = false;

                dgvUpdatePurchaseRequest[9, Convert.ToUInt16(nmbEditorUpdateReq.Tag.ToString())].Value = nmbEditorUpdateReq.Value.ToString();

            }
        }

        private void nmbEditorUpdateReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.SendWait("{TAB}");
        }

        private void dgvUpdatePurchaseRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 9)
            {


                DataGridViewCell abc = dgvUpdatePurchaseRequest.CurrentCell;

                Rectangle RECT = dgvUpdatePurchaseRequest.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);

                nmbEditorUpdateReq.Value = Convert.ToDecimal(dgvUpdatePurchaseRequest[9, e.RowIndex].Value.ToString());
                nmbEditorUpdateReq.Tag = e.RowIndex.ToString();
                CtlLocation(RECT, nmbEditorUpdateReq, ref dgvUpdatePurchaseRequest);
            }
        }

        private void btnUpdateReq_Click(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = 0;
            for (int i = 0; i < dgvUpdatePurchaseRequest.Rows.Count; i++)
            {
                icheck = cnn.TranDataToDB("update REQUIREMENTS_REQUESTS rr set rr.in_out_qty="+ dgvUpdatePurchaseRequest[9, i].Value.ToString()+" where rr.swid = "+ dgvUpdatePurchaseRequest[0, i].Value.ToString());

                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ عند تحديث بيانات الصنف :" + dgvUpdatePurchaseRequest[2, i].Value.ToString());

                    return;
                }
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت تعديل البيانات بنجاح");
        }
    }
    
}
