using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmFindForms : MyForm
    {
        public string strFormId = "";
        public frmFindForms()
        {
            InitializeComponent();
        }

       

       

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (dgUser.CurrentRow.Index >= 0)
            {
                strFormId = dgUser[0, dgUser.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strFormId = "";
        }

        private void frmFindForms_Load(object sender, EventArgs e)
        {
            strFormId = "";
            glb_function.FillList(ref lstFORM_TYPE, "FORMS", "form_type");
        }

        private void dgUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click_1(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgUser.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
           
         
            DataTable dtLocationData = cnn.GetDataTable("select * from forms where ar_name like '%"+
                                 txtAR_NAME.Text +"%' and en_name like '%"+
                                txtEN_NAME.Text +"%' and form_type like '%"+lstFORM_TYPE.Text +
                                "%' and sub_form like '%"+lstSUB_FORM.Text +"%'  ");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgUser.Rows.Add();
                dgUser[0, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgUser[1, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["AR_NAME"].ToString();
                dgUser[2, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["EN_NAME"].ToString();
                dgUser[3, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["FORM_TYPE"].ToString();
                dgUser[4, dgUser.Rows.Count - 1].Value = dtLocationData.Rows[i]["SUB_FORM"].ToString();
            }
        }

        private void lstSUB_FORM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstFORM_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFORM_TYPE.Text == "")
            {
                lstSUB_FORM.DataSource = null;
                return;
            }

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtSubProgram = cnn.GetDataTable("select distinct sub_form from FORMS t" +
                        " where form_type ='" + lstFORM_TYPE.Text + "'");
            lstSUB_FORM.DataSource = dtSubProgram;

            lstSUB_FORM.DisplayMember = "sub_form";



            lstSUB_FORM.SelectedIndex = -1;

        }
    }
}
