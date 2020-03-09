using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmCollection : MyForm
    {
        public frmCollection()
        {
            InitializeComponent();
        }

        private void frmCollection_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
        }
    }
}
