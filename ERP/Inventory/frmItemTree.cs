
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmItemTree : MyForm
    {
        private DataTable dtPrepareItemTree;

        public frmItemTree()
        {
            InitializeComponent();
        }

        private void frmItemTree_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            glb_function.FillListWithId(ref lstPROPERTY_ID, "PROPERTIES", "PROPERTY_NAME");
            FillItemParent();
            FillItemTree();

        }
        private void FillItemParent()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtParent = cnn.GetDataTable("select swid, CATEGORY_NAME from CATEGORIES where CATEGORY_CLASS ='رئيسي'");

            lstPARENT_ID.DataSource = dtParent;
            lstPARENT_ID.ValueMember = "swid";
            lstPARENT_ID.DisplayMember = "CATEGORY_NAME";
            lstPARENT_ID.SelectedIndex = -1;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if(txtCATEGORY_NAME.Text .Trim()=="")
            {
                glb_function.MsgBox("الرجاء ادخال اسم التصنيف");
                txtCATEGORY_NAME.Focus();
                return;
            }

            if(lstCATEGORY_CLASS.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء اختيار مستوى التصنيف");
                lstCATEGORY_CLASS.Focus();
                return;
            }
            if(txtCode.Text .Trim()=="" && lstCATEGORY_CLASS.Text == "فرعي")
            {
                glb_function.MsgBox("الرجاء ادخال الكود");
                txtCode.Focus();
                return;
            }
            if(txtCode.Text.Length < 3 && lstCATEGORY_CLASS.Text == "فرعي")
            {
                glb_function.MsgBox("طول الكود يجب ان يساوي ثلاثة ارقام");
                txtCode.Focus();
                return;
            }

            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into CATEGORIES values ((select nvl(max(swid),0)+1 from CATEGORIES),sysdate,"+glb_function.glb_strUserId +",'فعال',"+
                                ""+ (lstPARENT_ID.SelectedIndex ==-1?"null":lstPARENT_ID.SelectedValue.ToString())+",'"+txtCATEGORY_NAME.Text.Trim() +"','"+lstCATEGORY_CLASS.Text .Trim()+"','"+txtCode.Text +"')");

            if(icheck <=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الاضافة");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");

            txtCATEGORY_NAME.Text = "";
           
            txtCode.Text = "";
            lstCATEGORY_CLASS.Text = "";
            lstCATEGORY_CLASS.SelectedIndex = -1;
            FillItemParent();
            FillItemTree();
        }
        private void FillItemTree()
        {
            dtPrepareItemTree = new DataTable();
            ConnectionToDB cnn = new ConnectionToDB();
            
            dtPrepareItemTree.Rows.Clear();

            dtPrepareItemTree = cnn.GetDataTable("select swid,nvl(PARENT_ID,0) PARENT_ID,CATEGORY_NAME,CATEGORY_CLASS from CATEGORIES order by swid");

            tvItemsTree .Nodes.Clear();
            PopulateTreeView(0, null);

        }

        private void PopulateTreeView(int parentId, TreeNodeAdv parentNode)

        {


            TreeNodeAdv childNode;


            foreach (DataRow dr in dtPrepareItemTree.Select("[PARENT_ID]=" + parentId))

            {

                TreeNodeAdv t = new TreeNodeAdv();
                t.Text = dr["CATEGORY_NAME"].ToString();
               

                t.Tag = dtPrepareItemTree.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    tvItemsTree .Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView(Convert.ToInt32(dr["swid"].ToString()), childNode);

            }

        }

        private void tvItemsTree_NodeMouseClick(object sender, TreeViewAdvMouseClickEventArgs e)
        {
            if(dtPrepareItemTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["CATEGORY_CLASS"].ToString()=="فرعي")
            {
                lblCurrentCategoryId.Text = dtPrepareItemTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["swid"].ToString();
                lstPARENT_ID.SelectedIndex = -1;
                lstCATEGORY_CLASS.Text = "فرعي";
                FillProperties();

            }
            else
            {
                dgvProperties.Rows.Clear();
                lblCurrentCategoryId.Text = "";
                lstCATEGORY_CLASS.Text = "رئيسي";
                lstPARENT_ID.SelectedValue = dtPrepareItemTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["swid"].ToString();
            }
                

        }
        private void FillProperties()
        {
            dgvProperties.Rows.Clear();

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtProp = cnn.GetDataTable("select swid,property_id,cat_pro_value_type,SORT_INDEX, " +
                               " (select property_name from properties"+
                                " where swid = cp.property_id) property_name"+
                               "  from category_prop cp"+
                               "  where cp.category_id =  " + lblCurrentCategoryId.Text.Trim());
            for (int i = 0; i < dtProp.Rows.Count; i++)
            {
                dgvProperties.Rows.Add();
                dgvProperties[0, dgvProperties.Rows.Count - 1].Value = dtProp.Rows[i]["swid"].ToString();
                dgvProperties[1, dgvProperties.Rows.Count - 1].Value = dtProp.Rows[i]["property_name"].ToString();
                dgvProperties[2, dgvProperties.Rows.Count - 1].Value = dtProp.Rows[i]["cat_pro_value_type"].ToString();
                dgvProperties[3, dgvProperties.Rows.Count - 1].Value = dtProp.Rows[i]["SORT_INDEX"].ToString();

            }

        }

        private void btnAddProp_Click(object sender, EventArgs e)
        {
            if(lstPROPERTY_ID.SelectedIndex ==-1)
            {
                glb_function.MsgBox("الرجاء اختيار الخاصية");
                lstPROPERTY_ID.Focus();
                return;
            }
            if(lstCAT_PRO_VALUE_TYPE.Text =="")
            {
                glb_function.MsgBox("الرجاء اختيار نوع الخاصية");
                lstCAT_PRO_VALUE_TYPE.Focus();
                return;

            }
            if(lblCurrentCategoryId.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء اختيار التصنيف");
                return;
            }
            for (int i = 0; i < dgvProperties.Rows.Count; i++)
            {
                if(lstPROPERTY_ID .Text ==dgvProperties[1,i].Value.ToString())
                {
                    glb_function.MsgBox("هذه الخاصية مدخلة من قبل");
                    lstPROPERTY_ID.Focus();
                    return;
                }
                if(nmbSORT_INDEX.Value ==Convert.ToDecimal( dgvProperties[3, i].Value.ToString()) && nmbSORT_INDEX.Value !=0)
                {
                    glb_function.MsgBox("هذا الترتيب مدخل من قبل");
                    nmbSORT_INDEX.Focus();
                    return;
                }
            }

            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into CATEGORY_PROP values((select nvl(max(swid),0)+1 from CATEGORY_PROP),sysdate," + glb_function.glb_strUserId +",'فعال',"+lblCurrentCategoryId.Text .Trim()+","+lstPROPERTY_ID.SelectedValue.ToString()+",'"+lstCAT_PRO_VALUE_TYPE.Text +"',"+ nmbSORT_INDEX .Value.ToString()+ ")");
            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الاضافة");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");

            lstPROPERTY_ID.SelectedIndex = -1;
            lstCAT_PRO_VALUE_TYPE.SelectedIndex = -1;
            nmbSORT_INDEX.Value = 0;
            FillProperties();
        }

        private void dgvProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0 && (e.ColumnIndex == 4 || e.ColumnIndex == clmOrder.Index || e.ColumnIndex ==clmDelete.Index)) )
                return;

            if(e.ColumnIndex ==4)
            {
                if (dgvProperties[2, e.RowIndex].Value.ToString() == "قائمة")
                {
                    frmPropertyList frm = new frmPropertyList();
                    frm.strPropId = dgvProperties[0, e.RowIndex].Value.ToString();
                    frm.ShowDialog();
                }
                else
                {
                    glb_function.MsgBox("هذا الزر لايعمل الا مع القوائم فقط");
                }
            }
            else if(clmOrder.Index ==e.ColumnIndex )
            {
                dgvProperties.RightToLeft = RightToLeft.No;
                DataGridViewCell abc = dgvProperties.CurrentCell;
                Rectangle RECT = dgvProperties.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
                dgvProperties.RightToLeft = RightToLeft.Yes;
                nmbEditor.W_ColEgName = e.ColumnIndex.ToString();

                nmbEditor.Tag = e.RowIndex.ToString();



                nmbEditor.Value = Convert.ToDecimal(dgvProperties[e.ColumnIndex, e.RowIndex].Value.ToString());






                nmbEditor.Top = dgvProperties.Location.Y + RECT.Y;
                nmbEditor.Left = dgvProperties.Location.X + RECT.X;

                nmbEditor.Width = RECT.Width;
                nmbEditor.Height = RECT.Height;
                nmbEditor.BringToFront();
                nmbEditor.Visible = true;

                nmbEditor.Focus();
            }
            else if (clmDelete.Index == e.ColumnIndex)
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtProItem = cnn.GetDataTable("select swid from property_item pi" +
                        " where cate_property_id = " + dgvProperties[clmPropSwid.Index ,e.RowIndex].Value.ToString());

                if(dtProItem .Rows .Count >0)
                {
                    glb_function.MsgBox("الخاصية مضافة الى صنف"+"\n"+ "لايمكن حذف الخاصية");
                    return;
                }

                int icheck = cnn.TranDataToDB("delete from category_prop pi where swid = " + dgvProperties[clmPropSwid.Index, e.RowIndex].Value.ToString());
                if(icheck <=0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                    return;
                }
                cnn.glb_commitTransaction();
                dgvProperties.Rows.Remove(dgvProperties.Rows[e.RowIndex]);
               

            }





        }

        private void dgvProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void myBottun1_Click(object sender, EventArgs e)
        {
            frmProperties frm = new frmProperties();
            frm.ShowDialog();

            glb_function.FillListWithId(ref lstPROPERTY_ID, "PROPERTIES", "PROPERTY_NAME");
        }

        private void lstCATEGORY_CLASS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCATEGORY_CLASS.Text.Trim() == "فرعي")
            {
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtCode = cnn.GetDataTable("select lpad( ( to_char(nvl( max( to_number(code))+1,1))),3,'0') from CATEGORIES c " +
                            " where c.category_class = 'فرعي'");

                txtCode.Text = dtCode.Rows[0][0].ToString();
            }
            else
                txtCode.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (glb_function.MsgBox("هل انت متاكد من اتمام العملية", "", true) == false)
                return;

            string strSwid = dtPrepareItemTree.Rows[Convert.ToInt16(tvItemsTree.SelectedNode.Tag)]["swid"].ToString();
            string strClass= dtPrepareItemTree.Rows[Convert.ToInt16(tvItemsTree.SelectedNode.Tag)]["category_class"].ToString();


            ConnectionToDB cnn = new ConnectionToDB();
            if(strClass == "رئيسي")
            {
                DataTable dtGetCatChild = cnn.GetDataTable("select swid from CATEGORIES c where parent_id=" + strSwid);
                int icheck = 0;
                if (dtGetCatChild is null || dtGetCatChild.Rows.Count <= 0)
                {
                    icheck = cnn.TranDataToDB("delete from CATEGORIES where swid=" + strSwid);
                    if(icheck <=0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                        return;
                    }
                    cnn.glb_commitTransaction();
                    glb_function.MsgBox("تمت عملية الحذف بنجاح");
                    PrepareForm();
                }
                   
                else
                {
                    glb_function.MsgBox("لا يمكن حذف تصنيف لديه متعلقات");
                    return;
                }
            }
            else if (strClass == "فرعي")
            {
                DataTable dtGetCatChild = cnn.GetDataTable("select swid from items i where category_id=" + strSwid);
                int icheck = 0;
                if (dtGetCatChild is null || dtGetCatChild.Rows.Count <= 0)
                {
                    icheck = cnn.TranDataToDB("delete from CATEGORIES where swid=" + strSwid);
                    if (icheck <= 0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                        return;
                    }
                    cnn.glb_commitTransaction();
                    glb_function.MsgBox("تمت عملية الحذف بنجاح");
                    PrepareForm();
                }

                else
                {
                    glb_function.MsgBox("هذا التصنيف مربوط بصنف" +"\n"+"لايمكن الحذف");
                    return;
                }
            }





        }

        private void lblCurrentCategoryId_Click(object sender, EventArgs e)
        {

        }

        private void nmbEditor_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void nmbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void nmbEditor_Leave(object sender, EventArgs e)
        {
            if (nmbEditor.Visible == true)
            {
                nmbEditor.Visible = false;

                if(dgvProperties[0, dgvProperties.CurrentRow.Index].Value.ToString()!="")
                {
                    ConnectionToDB cnn = new ConnectionToDB();
                    cnn.TranDataToDB("update CATEGORY_PROP set sort_index="+ nmbEditor.Value.ToString() + " where swid="+ dgvProperties[0, dgvProperties.CurrentRow.Index].Value.ToString());
                    cnn.glb_commitTransaction();
                }
               

                dgvProperties[clmOrder.Index, dgvProperties.CurrentRow.Index].Value = nmbEditor.Value.ToString();
                 
                

            }
        }
    }
}
