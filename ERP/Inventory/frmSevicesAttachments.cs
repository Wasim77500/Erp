
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmSevicesAttachments : MyForm
    {
        public frmSevicesAttachments()
        {
            InitializeComponent();
        }

        private void btnFindServices_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(gbServices);
            frmFindServices frm = new frmFindServices();

            frm.ShowDialog();

            if (frm.strServiceID.Trim() != "")
            {
                txtSrvcSwid.Text = frm.strServiceID;
                GetSrvceData(txtSrvcSwid.Text);
                GetSrvceItemData(txtSrvcSwid.Text);
                
                if(dgServiceItems.Rows.Count>0  )
                {
                    dgServiceItems.Rows[0].Selected = true;

                    GetSrvceMaterialData(dgServiceItems[0, 0].Value.ToString());
                }
                
            }
        }
        private void GetSrvceData(string strSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtWareHouse = cnn.GetDataTable("select SERVICE_NO,SERVICE_NAME,PRICE_TYPE,PRICE from SERVICES where swid=" + strSwid);




         

            txtSERVICE_NO.Text = dtWareHouse.Rows[0]["SERVICE_NO"].ToString();
       

            txtSERVICE_NAME.Text = dtWareHouse.Rows[0]["SERVICE_NAME"].ToString();
         

           

            txtPrice_type.Text = dtWareHouse.Rows[0]["PRICE_TYPE"].ToString();




            txtService_price.Text  = (dtWareHouse.Rows[0]["PRICE"].ToString());
           

        }

        private void btnFindSrvceItem_Click(object sender, EventArgs e)
        {
            frmFindItem frm = new frmFindItem();

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtSrvceItemSwid.Text = frm.strItemID;
                GetSrvceItem(txtSrvceItemSwid.Text);
                dgServiceItems.Rows[0].Selected = true;

                GetSrvceMaterialData(dgServiceItems[0, 0].Value.ToString());
            }
        }
        private void GetSrvceItem(string strSwid)
        {
            new glb_function().clearItems(gbServiceItem);


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems = cnn.GetDataTable("select  i.item_no,i.item_name,i.item_type  from ITEMS i where swid=" + strSwid);
            txtSrvceItemSwid.Text = strSwid;
            txtITEM_NO_SI.Text = dtItems.Rows[0]["ITEM_NO"].ToString();

            txtITEM_NAME_SI.Text = dtItems.Rows[0]["item_name"].ToString();

            txtItemType_SI.Text = dtItems.Rows[0]["item_type"].ToString();




        }

        private void btnFindSrvce_Click(object sender, EventArgs e)
        {
            frmFindItem frm = new frmFindItem();

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtSrvceMaterialSwid.Text = frm.strItemID;
                GetSrvceMaterial(txtSrvceMaterialSwid.Text);
            }
        }

        private void GetSrvceMaterial(string strSwid)
        {
            new glb_function().clearItems(gbServiceMaterial);


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems = cnn.GetDataTable("select  i.item_no,i.item_name,i.item_type  from ITEMS i where swid=" + strSwid);
            txtSrvceMaterialSwid.Text = strSwid;
            txtITEM_NO_SM.Text = dtItems.Rows[0]["ITEM_NO"].ToString();

            txtITEM_NAME_SM.Text = dtItems.Rows[0]["item_name"].ToString();

            txtItemType_SM.Text = dtItems.Rows[0]["item_type"].ToString();




        }

        private void btnAddSrvceItem_Click(object sender, EventArgs e)
        {
            if(txtSrvcSwid.Text .Trim()=="" || txtSERVICE_NO.Text .Trim()=="" || txtSERVICE_NAME.Text .Trim()=="")
            {
                glb_function.MsgBox("الرجاء التاكد من ادخال الخدمة اولا");
                return;
            }
            if(txtSrvceItemSwid.Text.Trim()=="" || txtITEM_NO_SI.Text .Trim()=="" || txtITEM_NAME_SI.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء ادخال وتحديد بيانات الصنف");
                return;
            }

            if(nmbPrice.Value <=0)
            {
                glb_function.MsgBox("الرجاء تحديد السعر");
                nmbPrice.Focus();
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB(" insert into SERVICE_ITEMS values ((select nvl(max(swid),0)+1 from SERVICE_ITEMS),"+txtSrvceItemSwid.Text +","+txtSrvcSwid.Text +","+nmbPrice.Value.ToString()+") ");
            if(icheck <=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء العملية");
                return;
            }
            cnn.glb_commitTransaction();

            GetSrvceItemData(txtSrvcSwid.Text );
            new glb_function().clearItems(gbServiceItem);
        }

        private void btnAddSrvceMaterial_Click(object sender, EventArgs e)
        {
            if (txtSrvcSwid.Text.Trim() == "" || txtSERVICE_NO.Text.Trim() == "" || txtSERVICE_NAME.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء التاكد من ادخال الخدمة اولا");
                return;
            }
            if(dgServiceItems.Rows.Count <=0 || dgServiceItems.CurrentRow.Index < 0)
            {
                glb_function.MsgBox("الرجاء اختيار صنف الخدمة أولاً");
                return;
            }
            if (txtSrvceMaterialSwid.Text.Trim() == "" || txtITEM_NO_SM.Text.Trim() == "" || txtITEM_NAME_SM.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال وتحديد بيانات الصنف");
                return;
            }
            if(nmbQty.Value <=0)
            {
                glb_function.MsgBox("الرجاء تحديد الكمية");
                return;
            }


            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB(" insert into attachment_material values ((select nvl(max(swid),0)+1 from attachment_material)," + dgServiceItems[0,dgServiceItems.CurrentRow.Index].Value.ToString() + "," + txtSrvceMaterialSwid.Text  + "," + nmbQty.Value.ToString() + ") ");
            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء العملية");
                return;
            }
            cnn.glb_commitTransaction();

            GetSrvceMaterialData(dgServiceItems[0, dgServiceItems.CurrentRow.Index].Value.ToString());
            new glb_function().clearItems(gbServiceMaterial);
        }

        private void GetSrvceMaterialData(string strSrvceItemSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtSrvceMtrl = cnn.GetDataTable("select si.swid,i.item_no,i.item_name,si.qty from attachment_material si ,items i " +
                                                        "  where si.item_id = i.swid and  si.ser_item_id = " + strSrvceItemSwid);


            dgvServicesMaterial.Rows.Clear();

            for (int i = 0; i < dtSrvceMtrl.Rows.Count; i++)
            {
                dgvServicesMaterial.Rows.Add();
                dgvServicesMaterial[0, dgvServicesMaterial.Rows.Count - 1].Value = dtSrvceMtrl.Rows[i]["swid"].ToString();
                dgvServicesMaterial[1, dgvServicesMaterial.Rows.Count - 1].Value = dtSrvceMtrl.Rows[i]["item_no"].ToString();
                dgvServicesMaterial[2, dgvServicesMaterial.Rows.Count - 1].Value = dtSrvceMtrl.Rows[i]["item_name"].ToString();
                dgvServicesMaterial[3, dgvServicesMaterial.Rows.Count - 1].Value = dtSrvceMtrl.Rows[i]["qty"].ToString();
            }
        }
        private void GetSrvceItemData(string strSrvceSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtSrvceItem = cnn.GetDataTable("select si.swid,i.item_no,i.item_name,si.price from SERVICE_ITEMS si ,items i" +
                                    " where  si.itemid = i.swid and  si.service_id = " + strSrvceSwid );
            dgServiceItems.Rows.Clear();
            for (int i = 0; i < dtSrvceItem.Rows.Count; i++)
            {
                dgServiceItems.Rows.Add();
                dgServiceItems[0, dgServiceItems.Rows.Count - 1].Value = dtSrvceItem.Rows[i]["swid"].ToString();
                dgServiceItems[1, dgServiceItems.Rows.Count - 1].Value = dtSrvceItem.Rows[i]["item_no"].ToString();
                dgServiceItems[2, dgServiceItems.Rows.Count - 1].Value = dtSrvceItem.Rows[i]["item_name"].ToString();
                dgServiceItems[3, dgServiceItems.Rows.Count - 1].Value = dtSrvceItem.Rows[i]["price"].ToString();
            }
        }

        private void dgServiceItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgServiceItems.Rows[e.RowIndex].Selected = true;
                GetSrvceMaterialData(dgServiceItems[0, e.RowIndex].Value.ToString());
            }
               
        }

        private void dgvServicesMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvServicesMaterial.Rows[e.RowIndex].Selected = true;
        }
    }
}
