
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmPropertyList : MyForm
    {
        public string strPropId = "";
        public frmPropertyList()
        {
            InitializeComponent();
        }

        private void frmPropertyList_Load(object sender, EventArgs e)
        {
            if(strPropId !="")
                FillList();
            else
            {
                glb_function.MsgBox("لا توجد خاصية لاضافة قائمة لها");
                this.Close();
            }
            
        }
        private void FillList()
        {
            dgvPropertyList.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtPropList = cnn.GetDataTable("select LIST_VALUE,LIST_VALUE_EN from property_list where property_id=" + strPropId + " order by LIST_VALUE");

            for (int i = 0; i < dtPropList.Rows.Count; i++)
            {
                dgvPropertyList.Rows.Add();
                dgvPropertyList[0, dgvPropertyList.Rows.Count - 1].Value = dtPropList.Rows[i]["LIST_VALUE"].ToString();
                dgvPropertyList[1, dgvPropertyList.Rows.Count - 1].Value = dtPropList.Rows[i]["LIST_VALUE_EN"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPropertyValue.Text.Trim() =="")
            {
                glb_function.MsgBox("الرجاء ادخال القيمة");
                return;
            }
            if(IsDuplicatedValue ())
            {
                glb_function.MsgBox("القيمة مدخلة من قبل");
                return;
            }
            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into property_list values((select nvl(max(swid),0)+1 from property_list)," + strPropId +",'"+txtPropertyValue.Text.Trim().Replace(@"\", "-").Replace("/", "-") + "','"+ txtLIST_VALUE_EN.Text.Trim().Replace(@"\", "-").Replace("/", "-") + "')");

            if(icheck <=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء اضافة القيمة");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            FillList();
        }
        private bool IsDuplicatedValue()
        {
            for (int i = 0; i < dgvPropertyList.Rows.Count; i++)
            {
                if (dgvPropertyList[0, i].Value.ToString().Trim() == txtPropertyValue.Text.Trim())
                    return true ;
            }
            return false ;
        }
    }
}
