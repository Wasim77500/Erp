using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Sales
{
    public partial class frmReservedItems : ERP.MyForm
    {
        public frmReservedItems()
        {
            InitializeComponent();
        }

        private void btnPackageSearch_Click(object sender, EventArgs e)
        {
           Inventory. frmFindItem frm = new Inventory.frmFindItem();
            frm.strWhere = "";


            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtItemSwid.Text = frm.strItemID;

                //GetPacketItem(txtPackageItemSwid.Text);

            }
        }
    }
}
