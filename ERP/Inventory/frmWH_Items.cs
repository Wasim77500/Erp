
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmWH_Items : MyForm
    {
        public frmWH_Items()
        {
            InitializeComponent();
        }

        private void frmWH_Items_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }

        private void PrepareForm()
        {
            btnUpdate.Enabled = false;
            
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (txtItemId.Text == "")
            {

                errCheck.SetError(txtItemNo, "الرجاء اختيار الصنف");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtItemNo, "");
            }

            if (txtWarehouseId.Text == "")
            {
                errCheck.SetError(txtWareouseNo, "الرجاء اختيار المخزن");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtWareouseNo, "");

            }

            if (iError == 1)
                return false;

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into WAREHOUSE_ITEMS values ((select nvl( max(swid),0)+1 from  WAREHOUSE_ITEMS),"+glb_function.glb_strUserId +",sysdate,'فعال',"+
                                           txtWarehouseId.Text +","+txtItemId.Text +","+nmbHIGHEST_QTY.Value .ToString()+","+nmbMINIMAL_QTY.Value.ToString()+")");

            if(icheck <=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الحفظ");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الحفظ بنجاح");

            GetData();
        }

        private void myBottun1_Click(object sender, EventArgs e)
        {
            frmFindWarehouse frm = new frmFindWarehouse();

            frm.ShowDialog();

            if (frm.strWarehouseId.Trim() != "")
            {
                txtWarehouseId.Text = frm.strWarehouseId;
                GetWareHouseData(txtWarehouseId.Text);
                GetData();
            }
        }
       private void GetWareHouseData(string swid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtWarehouse = cnn.GetDataTable("select w.swid,w_no,w_name,w_description,b.branch_aname from warehouse w,branches b " +
                        " where b.swid = w.w_branch and w.swid="+swid );

            txtWareouseNo.Text =dtWarehouse.Rows[0]["w_no"].ToString();
            txtW_NAME.Text = dtWarehouse.Rows[0]["w_name"].ToString();
            txtW_Descreption.Text = dtWarehouse.Rows[0]["w_description"].ToString();
            txtW_Branch.Text = dtWarehouse.Rows[0]["branch_aname"].ToString();

        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            frmFindItem frm = new frmFindItem();

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtItemId.Text = frm.strItemID;
                GetItemData(txtItemId.Text);
                GetData();
            }
        }
        private void GetItemData(string strSwid)
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems = cnn.GetDataTable("select i.swid,item_no,item_name,c.category_name,a.act_name "+
                               "  from items i, CATEGORIES c, activities a  "+
                            "    where c.swid = i.category_id  "+
                              "  and a.swid = i.activity_id and i.swid="+strSwid );

            txtItemNo.Text =dtItems.Rows[0]["item_no"].ToString();
            txtItemName.Text = dtItems.Rows[0]["item_name"].ToString();
            txtCatagory.Text = dtItems.Rows[0]["category_name"].ToString();
            txtActivity.Text = dtItems.Rows[0]["act_name"].ToString();
        }

        private void GetData()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtWI = cnn.GetDataTable("select swid,highest_qty,minimal_qty from warehouse_items wi "+
                                " where item_id = '"+txtItemId.Text .Trim()+"' and warehouse_id = '"+txtWarehouseId.Text .Trim()+"' ");

            if(dtWI!=null && dtWI.Rows.Count==1)
            {
                txtSwid.Text = dtWI.Rows[0]["swid"].ToString();
                nmbHIGHEST_QTY.Value = Convert.ToDecimal(dtWI.Rows[0]["highest_qty"].ToString());
                nmbMINIMAL_QTY.Value = Convert.ToDecimal(dtWI.Rows[0]["minimal_qty"].ToString());


                btnSave.Visible = false;
                btnNew.Location = btnSave.Location;
                btnNew.Visible = true;
                if (HasPrivilege("btnUpdate"))
                    btnUpdate.Enabled = true;

            }
            else
            {
                nmbHIGHEST_QTY.Value = 0;
                nmbMINIMAL_QTY.Value = 0;
                btnUpdate.Enabled = false;
                btnNew.Visible = false;
                btnSave.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("update  WAREHOUSE_ITEMS set " +
                                           "HIGHEST_QTY=" + nmbHIGHEST_QTY.Value.ToString() + ",MINIMAL_QTY=" + nmbMINIMAL_QTY.Value.ToString() + " where swid= "+txtSwid.Text );

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية التعديل");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية التعديل بنجاح");

            GetData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);


            PrepareForm();
           
            btnNew.Visible = false;
            btnSave.Visible = true;
        }
    }
}
