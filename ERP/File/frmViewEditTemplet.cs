
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmViewEditTemplet : MyForm
    {
        public frmViewEditTemplet()
        {
            InitializeComponent();
        }

        private void myLabel2_Click(object sender, EventArgs e)
        {

        }

        private void frmViewEditTemplet_Load(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtHeaderTemp = cnn.GetDataTable("select swid,form_name from templet_header "+
                    " where form_eng_name = '"+txtFormEnName.Text .Trim()+"' and form_type='"+ txtForm_type.Text.Trim()+ "'");

            for (int i = 0; i < dtHeaderTemp.Rows.Count; i++)
            {
                dgvTempHeader.Rows.Add();
                dgvTempHeader[0, dgvTempHeader.Rows.Count - 1].Value = dtHeaderTemp.Rows[i]["swid"].ToString();
                dgvTempHeader[1, dgvTempHeader.Rows.Count - 1].Value = dtHeaderTemp.Rows[i]["form_name"].ToString();
            }

            dgProperities.Rows.Clear();
            
            DataTable dtProp = cnn.GetDataTable("select swid,control_type,en_name,ar_name,list_id,free_list_name from FORM_PROPERITY t " +
                      " where t.form_id = " +txtFormId.Text );
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

        private void dgTempHeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            GetTempDetailsData(e.RowIndex);
        }

        private void GetTempDetailsData(int iRow)
        {
            dgvTempDetails.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTempDetail = cnn.GetDataTable("select swid, control_type, en_name, ar_name," +
                            " control_value, real_value" +
                           "  from templet_details" +
                           "  where temp_header_id = " + dgvTempHeader[0, iRow].Value.ToString());
            for (int i = 0; i < dtTempDetail.Rows.Count; i++)
            {
                dgvTempDetails.Rows.Add();
                dgvTempDetails[0, dgvTempDetails.Rows.Count - 1].Value = dtTempDetail.Rows[i]["swid"].ToString();
                dgvTempDetails[1, dgvTempDetails.Rows.Count - 1].Value = dtTempDetail.Rows[i]["ar_name"].ToString();
                dgvTempDetails[2, dgvTempDetails.Rows.Count - 1].Value = dtTempDetail.Rows[i]["control_value"].ToString();
                dgvTempDetails[3, dgvTempDetails.Rows.Count - 1].Value = dtTempDetail.Rows[i]["control_type"].ToString();
                dgvTempDetails[4, dgvTempDetails.Rows.Count - 1].Value = dtTempDetail.Rows[i]["en_name"].ToString();
                dgvTempDetails[5, dgvTempDetails.Rows.Count - 1].Value = dtTempDetail.Rows[i]["real_value"].ToString();
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
                        DataTable dtFreeList = cnn.GetDataTable("select display_member,value_member from free_list " +
                        " where list_name = '" + dgProperities[5, e.RowIndex].Value.ToString() + "'");

                        lstEditor.DataSource = dtFreeList;
                        lstEditor.ValueMember = "value_member";
                        lstEditor.DisplayMember = "display_member";



                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "List")
                    {
                        ConnectionToDB cnn = new ConnectionToDB();
                        DataTable dtListTable = cnn.GetDataTable("select  table_name,display_member,value_member from LIST_TYPE t " +
                            " where swid =  '" + dgProperities[4, e.RowIndex].Value.ToString() + "'");

                        DataTable dtGetList = cnn.GetDataTable("select " + dtListTable.Rows[0]["display_member"].ToString() + " name," +
                            dtListTable.Rows[0]["value_member"].ToString() +
                            " id from " + dtListTable.Rows[0]["table_name"].ToString() +
                            "  ");

                        lstEditor.DataSource = dtGetList;
                        lstEditor.ValueMember = "id";
                        lstEditor.DisplayMember = "name";


                        if (dgProperities[5, e.RowIndex].Value.ToString() != "")

                        {
                            DataTable dtFreeList = cnn.GetDataTable("select display_member,value_member from free_list " +
                       " where list_name = '" + dgProperities[5, e.RowIndex].Value.ToString() + "'");

                            DataRow dr;

                            for (int i = 0; i < dtFreeList.Rows.Count; i++)
                            {
                                string str1= dtFreeList.Rows[i]["display_member"].ToString();
                                string str2= dtFreeList.Rows[i]["value_member"].ToString();
                                dr = dtGetList.NewRow();
                                dr["name"] = dtFreeList.Rows[i]["display_member"].ToString();
                                dr["id"] = Convert.ToInt16(dtFreeList.Rows[i]["value_member"].ToString());
                                dtGetList.Rows.InsertAt(dr, 0);
                            }


                            //MyDataTable.Rows.InsertAt(dr, 0);


                            //dr = MyDataTable.NewRow();
                            //dr["BRANCHE_ANAME"] = "فرع المستخدم";
                            //dr["swid"] = glb_function.glb_strUserId;
                            //MyDataTable.Rows.InsertAt(dr, 0);
                        }
                    }
                    else
                    {
                        glb_function.MsgBox("قيمة غير معروفة");
                       
                        return;
                    }
                    DataGridViewCell abc = dgProperities.CurrentCell;

                    Rectangle RECT = dgProperities.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
                    if (dgProperities[2, e.RowIndex].Value.ToString() != "")
                        lstEditor.Text = dgProperities[2, e.RowIndex].Value.ToString();
                    lstEditor.Tag = e.RowIndex.ToString();
                    CtlLocation(RECT);
                }
                else if(e.ColumnIndex ==8)
                {
                    if (dgProperities[2, e.RowIndex].Value.ToString() == "")
                    {
                        glb_function.MsgBox("الرجاء ادخال القيمة");
                        return;
                    }
                    if(dgvTempDetails.Rows.Count <=0)
                    {
                        glb_function.MsgBox("الرجاء تحديد النموذج");
                        return;

                    }
                    ConnectionToDB cnn = new ConnectionToDB();
                    int icheck = 0;
                    if (glb_function.MsgBox("هل انت متاكد من عملية التعديل", "", true))
                    {
                        for (int i = 0; i < dgvTempDetails.Rows.Count; i++)
                        {
                            if(dgvTempDetails[4,i].Value.ToString()==dgProperities[6,e.RowIndex ].Value.ToString())
                            {
                                icheck = cnn.TranDataToDB("delete from TEMPLET_DETAILS where swid=" + dgvTempDetails[0, i].Value.ToString());

                            }
                        }


                        icheck = cnn.TranDataToDB ("insert into TEMPLET_DETAILS values((select nvl(max(swid),0)+1 from TEMPLET_DETAILS)" +
                        "," + dgvTempHeader [0,dgvTempHeader.CurrentRow.Index ].Value .ToString() +
                        ",'" + dgProperities[3, e.RowIndex ].Value.ToString() + "','" + dgProperities[6, e.RowIndex].Value.ToString() + "','" + dgProperities[1, e.RowIndex].Value.ToString() + "','" + dgProperities[2, e.RowIndex].Value.ToString() + "'," + glb_function.glb_strUserId + ",sysdate,'" + (dgProperities[7, e.RowIndex].Value==null? dgProperities[2, e.RowIndex].Value.ToString() : dgProperities[7, e.RowIndex].Value.ToString() )+ "')");

                        if(icheck <=0)
                        {
                            cnn.glb_RollbackTransaction();
                            glb_function.MsgBox("حدث خطا اثناء العملية");
                            return;
                        }
                        cnn.glb_commitTransaction();
                        glb_function.MsgBox("تمت العملية بنجاح.");
                        GetTempDetailsData(dgvTempHeader.CurrentRow.Index );
                    }

                }
            }
        }

        public void CtlLocation(Rectangle rect)
        {


            lstEditor.Top = dgProperities.Location.Y + rect.Y;
            lstEditor.Left = dgProperities.Location.X + rect.X + 95;
            lstEditor.Width = rect.Width;
            lstEditor.Height = rect.Height;
            lstEditor.BringToFront();
            lstEditor.Visible = true;
            lstEditor.Focus();


        }

        private void lstEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.SendWait("{TAB}");
        }

        private void lstEditor_Leave(object sender, EventArgs e)
        {
            if (lstEditor.Visible == true)
            {
                lstEditor.Visible = false;

                dgProperities[2, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.Text;

                if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Enability")
                {

                    if (lstEditor.Text == "تفعيل")
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "1";
                    else
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "0";



                }
                else if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Visability")
                {
                    if (lstEditor.Text == "اظهار")
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
                  
                    return;
                }


            }
        }
    }
}
