using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmDefineTemplet : MyForm
    {
        public frmDefineTemplet()
        {
            InitializeComponent();
        }

        private void frmDefineTemplet_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            btnUpdate.Enabled = false ;
            glb_function.FillList(ref lstFORM_TYPE, "FORMS", "form_type");
          

            glb_function.FillListWithId(ref lstListType, "LIST_TYPE", "list_name");


        }

        private void lstControlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstControlType.Text  == "")
            {
                lstListType.Visible = false;
                return;
            }

            lstListType.Visible = false;
            if (lstControlType.Text == "Free List" || lstControlType.Text == "Free MultiChoices")
            {
                frmFreeList frm = new frmFreeList();
                frm.ShowDialog();
                txtFreeListId.Text = frm.strFreeListName ;

                if (txtFreeListId.Text == "")
                    lstControlType.SelectedIndex = -1;
            }
            else if (lstControlType.Text == "List" || lstControlType.Text == "MultiChoices")
            {
                lstListType.Visible = true;
            }

        }

        private void lstListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstListType.SelectedValue == null)
            //    return;

            //if (lstControlType.Text == "List")
            //{
            //    if (glb_function.MsgBox("هل تريد اضافة حقول اخرى للقائمة؟", "", true) == false)
            //        return;
            //    frmFreeList frm = new frmFreeList();
            //    frm.ShowDialog();
            //    txtFreeListId.Text = frm.strFreeListName ;

            //    if (txtFreeListId.Text == "")
            //        lstControlType.Text = "";
            //}
        }
        private bool CheckEntries()
        {

            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (txtAR_NAME.Text =="")
            {

                errCheck.SetError(txtAR_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtAR_NAME, "");
            }

            //txtFormInProgram
            if (txtEN_NAME.Text == "")
            {

                errCheck.SetError(txtEN_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtEN_NAME, "");
            }


            //lstProgramType
            if (lstFORM_TYPE.Text == "")
            {

                errCheck.SetError(lstFORM_TYPE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstFORM_TYPE, "");
            }

            //lstProgramSubType
            if (lstSUB_FORM.Text == "")
            {

                errCheck.SetError(lstSUB_FORM, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstSUB_FORM, "");
            }

            if (iError == 1)
                return false;

            return true;
        }
        private bool CheckDetailsEntries()
        {



            int iError = 0;
            if (lstControlType.Text == "")
            {

                errCheck.SetError(lstControlType, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstControlType, "");
            }

            if (lstControlType.Text == "List")
            {
                if (lstListType.Text == "")
                {
                    glb_function.MsgBox("الرجاء اختيار القائمة");
                    lstListType.Focus();
                    return false;
                }
            }
            else if (lstControlType.Text == "Free List")
            {

                if (txtFreeListId.Text == "")
                {
                    glb_function.MsgBox("الرجاء ادخال القائمة الحرة");
                    lstControlType.Focus();
                    return false;
                }
            }
            //txtArName
            if (txtArName.Text == "")
            {

                errCheck.SetError(txtArName, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtArName, "");
            }
            //txtEnName
            if (txtEnName.Text == "")
            {

                errCheck.SetError(txtEnName, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtEnName, "");
            }

            if (iError == 1)
                return false;

            return true;
        }

        private void btnAddPropority_Click(object sender, EventArgs e)
        {
            if (!CheckDetailsEntries())
                return;

            dgvProperities.Rows.Add();
            dgvProperities[0, dgvProperities.Rows.Count - 1].Value = "";
            dgvProperities[1, dgvProperities.Rows.Count - 1].Value = lstControlType.Text;
            dgvProperities[2, dgvProperities.Rows.Count - 1].Value = txtArName.Text;
            dgvProperities[3, dgvProperities.Rows.Count - 1].Value = txtEnName.Text;
            dgvProperities[4, dgvProperities.Rows.Count - 1].Value = txtPROPERITY_NOTE.Text;
            dgvProperities[5, dgvProperities.Rows.Count - 1].Value =(lstListType.SelectedIndex ==-1?"null": lstListType.SelectedValue.ToString());
            dgvProperities[6, dgvProperities.Rows.Count - 1].Value = lstListType.Text;
            dgvProperities[7, dgvProperities.Rows.Count - 1].Value = txtFreeListId.Text;

            txtArName.Text = "";
            txtEnName.Text = "";
            txtPROPERITY_NOTE.Text = "";
            lstListType.SelectedIndex = -1;
            lstListType.Text = "";
            txtFreeListId.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTemplte = cnn.GetDataTable("select nvl(max(swid),0)+1 from FORMS");

            txtSWID.Text = dtTemplte.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            

            glb_function.arrInsertLogs.Add("insert into FORMS values("+txtSWID.Text  +",'"+ txtAR_NAME.Text  + "','"+txtEN_NAME.Text +"','"+ lstFORM_TYPE .Text + "','"+lstSUB_FORM.Text +"','"+(ckbMULTI_FORM_FOR_USER.Checked ==true ?"1":"0")+"')");
            int strProSwid = 0;
            dtTemplte.Clear();
            dtTemplte = cnn.GetDataTable("select nvl(max(swid),0)+1 from FORM_PROPERITY");
            strProSwid = Convert.ToInt16(dtTemplte.Rows[0][0].ToString());
            for (int i = 0; i < dgvProperities.Rows.Count; i++)
            {
                if(dgvProperities[0,i].Value.ToString()=="")
                {
                    
                     
                    glb_function.arrInsertLogs.Add("insert into FORM_PROPERITY values("+ strProSwid.ToString() + "," + txtSWID.Text  + ",'"+ dgvProperities[1, i].Value.ToString() + "','" + dgvProperities[3, i].Value.ToString() + "','" + dgvProperities[2, i].Value.ToString() + "'," + dgvProperities[5, i].Value.ToString() + ",'" + dgvProperities[7, i].Value.ToString() + "','" + dgvProperities[4, i].Value.ToString() + "')");
                    strProSwid++;
                }
            }

            if (glb_function.MultiTransData())
            {
                GetData(txtSWID.Text.Trim());

            }



        }
        private void GetData(string strSwid)
        {
            new glb_function().clearItems(this);
            PrepareForm();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select * from forms where swid=" + strSwid);

            txtSWID.Text = strSwid;
            txtAR_NAME.Text = dtLocation.Rows[0]["AR_NAME"].ToString();


            txtEN_NAME.Text = dtLocation.Rows[0]["EN_NAME"].ToString();

            lstFORM_TYPE.Text = dtLocation.Rows[0]["FORM_TYPE"].ToString();
            lstSUB_FORM.Text = dtLocation.Rows[0]["SUB_FORM"].ToString();
            ckbMULTI_FORM_FOR_USER.Checked = (dtLocation.Rows[0]["MULTI_FORM_FOR_USER"].ToString() == "1" ? true : false);

            GetProperitiesData();

            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }
        private void GetProperitiesData()
        {
            dgvProperities.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtPorp = cnn.GetDataTable("select swid, control_type, en_name, ar_name, "+
                       "  list_id, (select l.list_name from list_type l where l.swid = list_id) listtype, "+
                         " free_list_name, properity_note "+
                         " from form_properity "+
                        "  where form_id = "+txtSWID.Text );
            for (int i = 0; i < dtPorp.Rows.Count; i++)
            {
                dgvProperities.Rows.Add();
                dgvProperities[0, i].Value = dtPorp.Rows[i]["swid"].ToString();
                dgvProperities[1, i].Value = dtPorp.Rows[i]["control_type"].ToString();
                dgvProperities[2, i].Value = dtPorp.Rows[i]["en_name"].ToString();
                dgvProperities[3, i].Value = dtPorp.Rows[i]["ar_name"].ToString();
                dgvProperities[4, i].Value = dtPorp.Rows[i]["properity_note"].ToString();
                dgvProperities[5, i].Value = dtPorp.Rows[i]["list_id"].ToString();
                dgvProperities[6, i].Value = dtPorp.Rows[i]["listtype"].ToString();
                dgvProperities[7, i].Value = dtPorp.Rows[i]["free_list_name"].ToString();
            }
        }
        private void lstProgramType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFORM_TYPE.Text  == "")
            {
                lstSUB_FORM.DataSource = null;
                return;
            }
           
                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtSubProgram = cnn.GetDataTable("select distinct sub_form from FORMS t" +
                            " where form_type ='" + lstFORM_TYPE.Text+"'");
                lstSUB_FORM.DataSource = dtSubProgram;

                lstSUB_FORM.DisplayMember = "sub_form";



                lstSUB_FORM.SelectedIndex = -1;



           
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindForms  frm = new frmFindForms();

            frm.ShowDialog();

            if (frm.strFormId != "")
            {

                txtSWID.Text = frm.strFormId;
                GetData(txtSWID.Text);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            PrepareForm();
            btnNew.Visible = false;
            btnSave.Visible = true;
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;
            DataTable dtTemplte = new DataTable();
            ConnectionToDB cnn = new ConnectionToDB();
          


            glb_function.arrInsertLogs = new System.Collections.ArrayList();



            glb_function.arrInsertLogs.Add("update FORMS set AR_NAME='" + txtAR_NAME.Text + "',EN_NAME='" + txtEN_NAME.Text + "',FORM_TYPE='" + lstFORM_TYPE.Text + "',SUB_FORM='" + lstSUB_FORM.Text + "',MULTI_FORM_FOR_USER='" + (ckbMULTI_FORM_FOR_USER.Checked == true ? "1" : "0") + "' where swid=" + txtSWID.Text );
            int strProSwid = 0;
            dtTemplte.Clear();
            dtTemplte = cnn.GetDataTable("select nvl(max(swid),0)+1 from FORM_PROPERITY");
            strProSwid = Convert.ToInt16(dtTemplte.Rows[0][0].ToString());
            for (int i = 0; i < dgvProperities.Rows.Count; i++)
            {
                if (dgvProperities[0, i].Value.ToString() == "")
                {


                    glb_function.arrInsertLogs.Add("insert into FORM_PROPERITY values(" + strProSwid.ToString() + "," + txtSWID.Text + ",'" + dgvProperities[1, i].Value.ToString() + "','" + dgvProperities[3, i].Value.ToString() + "','" + dgvProperities[2, i].Value.ToString() + "'," + dgvProperities[5, i].Value.ToString() + ",'" + dgvProperities[7, i].Value.ToString() + "','" + dgvProperities[4, i].Value.ToString() + "')");
                    strProSwid++;
                }
            }

            if (glb_function.MultiTransData())
            {
                GetData(txtSWID.Text.Trim());

            }
        }

        private void dgProperities_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex <= -1)
                return;
            if(e.ColumnIndex==9)
            {
                if (glb_function.MsgBox("هل تريد الحذف بالفعل؟", "", true) == false)
                    return;

                ConnectionToDB cnn = new ConnectionToDB();
                int icheck = cnn.TranDataToDB("delete from FORM_PROPERITY where swid="+ dgvProperities[0,e.RowIndex].Value.ToString()   );

                if(icheck <=0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                    return;
                }
                cnn.glb_commitTransaction();
                glb_function.MsgBox("تمت العملية بنجاح");
                GetProperitiesData();


            }
        }

        private void btnClearProp_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(gbDetails);
        }
    }
}
