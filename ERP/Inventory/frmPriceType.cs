
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmPriceType : MyForm
    {
        public frmPriceType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into PRICE_TYPE values((select nvl( max(swid),0)+1 from PRICE_TYPE),sysdate,"+
                glb_function.glb_strUserId +",'فعال','"+txtPRICEING_Name.Text.Trim()+"')");

            if(icheck<=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية اضافة النوع");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية اضافة النوع بنجاح");
            
        }

        private bool CheckEntries()
        {

            if (!glb_function.AcceptTrans)
                return false;


            if(txtPRICEING_Name.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء ادخال نوع التسعير");
                return false;
            }

            return true;
        }
    }
}
