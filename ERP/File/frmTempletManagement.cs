
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmTempletManagement : MyForm
    {
        public frmTempletManagement()
        {
            InitializeComponent();
        }

        private void frmTempletManagement_Load(object sender, EventArgs e)
        {
          
            glb_function.FillList(ref lstFORM_TYPE, "FORMS", "form_type");
        }

        

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgForms.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();


            DataTable dtLocationData = cnn.GetDataTable("select * from forms where ar_name like '%" +
                                 txtAR_NAME.Text + "%'  and form_type like '%" + lstFORM_TYPE.Text +
                                "%'  ");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgForms.Rows.Add();
                dgForms[0, dgForms.Rows.Count - 1].Value = dtLocationData.Rows[i]["swid"].ToString();
                dgForms[1, dgForms.Rows.Count - 1].Value = dtLocationData.Rows[i]["AR_NAME"].ToString();
                dgForms[2, dgForms.Rows.Count - 1].Value = dtLocationData.Rows[i]["EN_NAME"].ToString();
                dgForms[3, dgForms.Rows.Count - 1].Value = dtLocationData.Rows[i]["FORM_TYPE"].ToString();
                dgForms[4, dgForms.Rows.Count - 1].Value = dtLocationData.Rows[i]["SUB_FORM"].ToString();
                dgForms[6, dgForms.Rows.Count - 1].Value = dtLocationData.Rows[i]["MULTI_FORM_FOR_USER"].ToString();
            }
        }

        private void dgForms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;
            if(e.ColumnIndex==5)
            {
                frmViewEditTemplet frm = new frmViewEditTemplet();
                frm.txtFormName.Text = dgForms[1, e.RowIndex].Value.ToString();
                frm.txtFormEnName.Text =  dgForms[2, e.RowIndex].Value.ToString();
                frm.txtFormId.Text = dgForms[0, e.RowIndex].Value.ToString();
                frm.txtForm_type.Text  = dgForms[3, e.RowIndex].Value.ToString();
                frm.ShowDialog();
                return;
            }
            dgProperities.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtProp = cnn.GetDataTable("select swid,control_type,en_name,ar_name,list_id,free_list_name from FORM_PROPERITY t "+
                      " where t.form_id = "+ dgForms[0,e.RowIndex ].Value.ToString() +" order by swid");
            for (int i = 0; i < dtProp.Rows.Count; i++)
            {
                dgProperities.Rows.Add();
                dgProperities[0, dgProperities.Rows.Count - 1].Value = dtProp.Rows[i]["swid"].ToString();
                dgProperities[1, dgProperities.Rows.Count - 1].Value = dtProp.Rows[i]["ar_name"].ToString();
                dgProperities[2, dgProperities.Rows.Count - 1].Value = "";
                dgProperities[3, dgProperities.Rows.Count - 1].Value = dtProp.Rows[i]["control_type"].ToString();
                dgProperities[4, dgProperities.Rows.Count - 1].Value = dtProp.Rows[i]["list_id"].ToString();
                dgProperities[5, dgProperities.Rows.Count - 1].Value = dtProp.Rows[i]["free_list_name"].ToString();
                dgProperities[6, dgProperities.Rows.Count - 1].Value = dtProp.Rows[i]["en_name"].ToString();
            }
        }

        private void dgProperities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    lstEditor.DataSource = null;
                    lstEditor.Items.Clear();
                    lstMultiEditor.Items.Clear();

                    if (dgProperities[3, e.RowIndex].Value.ToString() == "Enability")
                    {
                        lstEditor.Items.Add("تفعيل");
                        lstEditor.Items.Add("اغلاق");
                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "Visability")
                    {
                        lstEditor.Items.Add("اظهار");
                        lstEditor.Items.Add("اخفاء");
                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "Text")
                    {
                        return;
                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "Free List")
                    {
                        ConnectionToDB cnn = new ConnectionToDB();
                        DataTable dtFreeList = cnn.GetDataTable("select display_member,value_member from free_list "+
                        " where list_name = '"+ dgProperities[5, e.RowIndex].Value.ToString() + "'");

                        lstEditor.DataSource = dtFreeList;
                        lstEditor.ValueMember = "value_member";
                        lstEditor.DisplayMember = "display_member";
                       
                        

                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "Free MultiChoices")
                    {
                        ConnectionToDB cnn = new ConnectionToDB();
                        DataTable dtFreeList = cnn.GetDataTable("select display_member,value_member from free_list " +
                        " where list_name = '" + dgProperities[5, e.RowIndex].Value.ToString() + "'");

                        for (int i = 0; i < dtFreeList.Rows.Count; i++)
                        {
                            lstMultiEditor.Items.Add(dtFreeList.Rows[i][0].ToString());


                        }
                        dgProperities.RightToLeft = RightToLeft.No;
                        DataGridViewCell abc1 = dgProperities.CurrentCell;

                        Rectangle RECT1 = dgProperities.GetCellDisplayRectangle(abc1.ColumnIndex, abc1.RowIndex, true);
                        dgProperities.RightToLeft = RightToLeft.Yes;
                        if (dgProperities[2, e.RowIndex].Value.ToString() != "")
                        {
                           
                            for (int i = 0; i < lstMultiEditor.Items.Count; i++)
                                lstMultiEditor.SetItemChecked(i, false);


                            string strMult = dgProperities[2, e.RowIndex].Value.ToString();

                            string iindexx = "";

                            while (strMult != "")
                            {


                                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                                for (int i = 0; i < lstMultiEditor.Items.Count; i++)
                                {

                                    if (lstMultiEditor.Items[i].ToString() == iindexx)
                                        lstMultiEditor.SetItemChecked(i, true);
                                }


                            }
                            //***************************
                        }

                        lstMultiEditor.Tag = e.RowIndex.ToString();
                        CtlLocation(RECT1, lstMultiEditor);
                        return;


                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "List")
                    {
                        ConnectionToDB cnn = new ConnectionToDB();
                        DataTable dtListTable = cnn.GetDataTable("select  select_statement from LIST_TYPE t " +
                             " where swid =  '" + dgProperities[4, e.RowIndex].Value.ToString() + "'");

                        DataTable dtGetList = cnn.GetDataTable(dtListTable.Rows[0][0].ToString());
                     

                        lstEditor.DataSource = dtGetList;
                        lstEditor.ValueMember = "swid";
                        lstEditor.DisplayMember = "name";


                        if(dgProperities[5, e.RowIndex].Value.ToString()!="")

                        {
                            DataTable dtFreeList = cnn.GetDataTable("select display_member,value_member from free_list " +
                       " where list_name = '" + dgProperities[5, e.RowIndex].Value.ToString() + "'");

                            DataRow dr;

                            for (int i = 0; i < dtFreeList.Rows.Count; i++)
                            {
                                dr = dtGetList.NewRow();
                                dr["name"] = dtFreeList.Rows[i]["display_member"].ToString();
                                dr["id"] =Convert.ToInt16( dtFreeList.Rows[i]["value_member"].ToString());
                                dtGetList.Rows.InsertAt(dr, 0);
                            }
                            

                            //MyDataTable.Rows.InsertAt(dr, 0);


                            //dr = MyDataTable.NewRow();
                            //dr["BRANCHE_ANAME"] = "فرع المستخدم";
                            //dr["swid"] = glb_function.glb_strUserId;
                            //MyDataTable.Rows.InsertAt(dr, 0);
                        }
                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "MultiChoices")
                    {
                        ConnectionToDB cnn = new ConnectionToDB();
                        DataTable dtListTable = cnn.GetDataTable("select  select_statement from LIST_TYPE t " +
                            " where swid =  '" + dgProperities[4, e.RowIndex].Value.ToString() + "'");

                        DataTable dtGetList = cnn.GetDataTable(dtListTable.Rows[0][0].ToString());

                        for (int i = 0; i < dtGetList.Rows.Count; i++)
                        {
                            lstMultiEditor.Items.Add(dtGetList.Rows[i][1].ToString());


                        }



                        dgProperities.RightToLeft = RightToLeft.No;
                        DataGridViewCell abc1 = dgProperities.CurrentCell;

                        Rectangle RECT1 = dgProperities.GetCellDisplayRectangle(abc1.ColumnIndex, abc1.RowIndex, true);
                        dgProperities.RightToLeft = RightToLeft.Yes;
                        if (dgProperities[2, e.RowIndex].Value.ToString() != "")
                        {
                            //lstMultiEditor
                            //lstEditor.Text = dgProperities[2, e.RowIndex].Value.ToString();

                            //***************************
                            for (int i = 0; i < lstMultiEditor.Items.Count; i++)
                                lstMultiEditor.SetItemChecked(i, false);


                          string  strMult = dgProperities[2, e.RowIndex].Value.ToString();

                            string iindexx = "";

                            while (strMult != "")
                            {


                                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                                for (int i = 0; i < lstMultiEditor.Items.Count; i++)
                                {

                                    if (lstMultiEditor.Items[i].ToString() == iindexx)
                                        lstMultiEditor.SetItemChecked(i, true);
                                }


                            }
                            //***************************
                        }
                            
                        lstMultiEditor.Tag = e.RowIndex.ToString();
                        CtlLocation(RECT1,lstMultiEditor);
                        return;

                    }
                    else
                    {
                        glb_function.MsgBox("قيمة غير معروفة");
                        txtAR_NAME.Focus();
                        return;
                    }
                    dgProperities.RightToLeft = RightToLeft.No;
                    DataGridViewCell abc = dgProperities.CurrentCell;
                
                    Rectangle RECT = dgProperities.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
                    dgProperities.RightToLeft = RightToLeft.Yes;
                    if (dgProperities[2, e.RowIndex].Value.ToString() != "")
                        lstEditor.Text  = dgProperities[2, e.RowIndex].Value.ToString();
                    lstEditor.Tag = e.RowIndex.ToString();
                    CtlLocation(RECT,lstEditor);
                }
            }
        }
        //public void CtlLocation(Rectangle rect)
        //{

           
        //    lstEditor.Top = dgProperities.Location.Y + rect.Y;
        //    lstEditor.Left = dgProperities.Location.X + rect.X+70  ;
        //    lstEditor.Width = rect.Width;
        //    lstEditor.Height = rect.Height;
        //    lstEditor.BringToFront();
        //    lstEditor.Visible = true;
        //    lstEditor.Focus();


        //}
        private void CtlLocation(Rectangle rect, Control ctrl)
        {


            ctrl.Top = dgProperities.Location.Y + rect.Y;
            ctrl.Left = dgProperities.Location.X + rect.X ;
            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;
            ctrl.Focus();
            if (ctrl.GetType() == typeof(CheckedListBox))
                ctrl.Height = rect.Height * 5;


        }

        private void lstEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void lstEditor_Leave(object sender, EventArgs e)
        {
            if (lstEditor.Visible == true)
            {
                lstEditor.Visible = false;

                dgProperities[2, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.Text ;

                if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Enability")
                {

                    if (lstEditor.Text == "تفعيل")
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "1";
                    else
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "0";

               

                }
                else if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Visability")
                {
                   if(lstEditor.Text == "اظهار")
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "1";
                    else
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "0";


                }
                else if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Text")
                {
                    dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.Text;
                }
                else if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Free List")
                {

                    dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.Text;


                }
                else if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "List")
                {
                    dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.SelectedValue.ToString();

                }
                else
                {
                    glb_function.MsgBox("قيمة غير معروفة");
                    txtAR_NAME.Focus();
                    return;
                }


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTemplte = cnn.GetDataTable("select nvl(max(swid),0)+1 from TEMPLET_HEADER");

            txtSWID.Text = dtTemplte.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("insert into TEMPLET_HEADER values(" + txtSWID.Text + "," +
                      glb_function.glb_strUserId + ",sysdate,'" + txtFormName.Text + "','" +
                      dgForms[2, dgForms.CurrentRow.Index].Value.ToString() + "','" +
                      dgForms[3, dgForms.CurrentRow.Index].Value.ToString() + "','" +
                      dgForms[4, dgForms.CurrentRow.Index].Value.ToString() + "','فعال','" +
                      dgForms[1, dgForms.CurrentRow.Index].Value.ToString() + "','" + dgForms[6, dgForms.CurrentRow.Index].Value.ToString() + "')");


            //int icheck = cnn.TranDataToDB("insert into TEMPLET_HEADER values(" + txtSWID.Text + "," +
            //            glb_function.glb_strUserId + ",sysdate,'" + txtFormName.Text + "','" +
            //            dgForms[2, dgForms.CurrentRow.Index].Value.ToString() + "','" +
            //            dgForms[3, dgForms.CurrentRow.Index].Value.ToString() + "','" +
            //            dgForms[4, dgForms.CurrentRow.Index].Value.ToString() + "','فعال','" +
            //            dgForms[1, dgForms.CurrentRow.Index].Value.ToString() + "','" + dgForms[6, dgForms.CurrentRow.Index].Value.ToString() + "')");
            //if (icheck <= 0)
            //{
            //    glb_function.MsgBox("حدث خطأ اثناء عملية الحفظ");
            //    return;
            //}
            int iProSwid = 0;
            dtTemplte.Clear();
            dtTemplte = cnn.GetDataTable("select nvl(max(swid),0)+1 from TEMPLET_DETAILS");
            iProSwid = Convert.ToInt16(dtTemplte.Rows[0][0].ToString());
            for (int i = 0; i < dgProperities.Rows.Count; i++)
            {

                glb_function.arrInsertLogs.Add("insert into TEMPLET_DETAILS values(" + iProSwid.ToString() +
                        "," + txtSWID.Text +
                        ",'" + dgProperities[3, i].Value.ToString() + "','" + dgProperities[6, i].Value.ToString() + "','" + dgProperities[1, i].Value.ToString() + "','" + dgProperities[2, i].Value.ToString() + "'," + glb_function.glb_strUserId + ",sysdate,'" + (dgProperities[7, i].Value == null ? dgProperities[2, i].Value.ToString() : dgProperities[7, i].Value.ToString()) + "')");
                iProSwid++;

                //icheck = cnn.TranDataToDB("insert into TEMPLET_DETAILS values(" + iProSwid.ToString() +
                //         "," + txtSWID.Text +
                //         ",'" + dgProperities[3, i].Value.ToString() + "','" + dgProperities[6, i].Value.ToString() + "','" + dgProperities[1, i].Value.ToString() + "','" + dgProperities[2, i].Value.ToString() + "'," + glb_function.glb_strUserId + ",sysdate,'" + (dgProperities[7, i].Value == null ? dgProperities[2, i].Value.ToString() : dgProperities[7, i].Value.ToString()) + "')");
                //iProSwid++;

                //if (icheck <= 0)
                //{
                //    cnn.glb_RollbackTransaction();
                //    glb_function.MsgBox("حدث خطأ اثناء عملية الحفظ");
                //    return;
                //}

            }
            //cnn.glb_commitTransaction();
            //glb_function.MsgBox("تمت عملية الحفظ بنجاح");


            if (glb_function.MultiTransData())
            { }

            //dgProperities.Rows.Clear();
            //    txtFormName.Text = "";
           



        }

        private bool CheckEntries()
        {

            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (txtFormName.Text == "")
            {

                errCheck.SetError(txtFormName, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtFormName, "");
            }



            for (int i = 0; i < dgProperities.Rows.Count; i++)
            {
                if(dgProperities[2,i].Value.ToString()=="")
                {
                    glb_function.MsgBox("الرجاء اختيار قيمة لك الخصائص");
                    return false;
                }
            }
          
            

            if (iError == 1)
                return false;

            return true;
        }

        private void lstMultiEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void lstMultiEditor_Leave(object sender, EventArgs e)
        {
            if (lstMultiEditor.Visible == true)
            {
                lstMultiEditor.Visible = false;

                // dgProperities[2, Convert.ToUInt16(lstMultiEditor.Tag.ToString())].Value = lstMultiEditor.Text;

                dgProperities[2, Convert.ToUInt16(lstMultiEditor.Tag.ToString())].Value = "";

                for (int i = 0; i < lstMultiEditor.Items.Count; i++)
                {
                    if (lstMultiEditor.GetItemCheckState(i) == CheckState.Checked)
                        dgProperities[2, Convert.ToUInt16(lstMultiEditor.Tag.ToString())].Value = dgProperities[2, Convert.ToUInt16(lstMultiEditor.Tag.ToString())].Value.ToString() + lstMultiEditor.Items[i].ToString() + ";";
                }

                dgProperities[7, Convert.ToUInt16(lstMultiEditor.Tag.ToString())].Value = dgProperities[2, Convert.ToUInt16(lstMultiEditor.Tag.ToString())].Value;
            }
        }
    }
}
