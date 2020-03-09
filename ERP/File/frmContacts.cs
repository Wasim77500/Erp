
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmContacts : MyForm
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        private void myText1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            lstCONT_TYPE.SelectedIndex = 0;
            FillADBDesc();
            FillCONT_TITLE();
            FillLocation();
            FillJob();

            if (txtSWID.Text.Trim() != "")
                GetData(txtSWID.Text);
            
        }
        private void FillJob()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtFill = cnn.GetDataTable("select distinct job from address_book");
            lstJOB.DataSource = dtFill;
            lstJOB.DisplayMember = "job";


        }
        private void FillLocation()
        {

            ConnectionToDB myconn = new ConnectionToDB();
            DataTable MyDataTable;
            MyDataTable = myconn.GetDataTable("Select swid, LOCATION_NAME From  location order by LOCATION_NAME");
            if (MyDataTable != null)
            {


                lstADB_LOCATION.DataSource = MyDataTable;


                lstADB_LOCATION.DisplayMember = "LOCATION_NAME";
                lstADB_LOCATION.ValueMember = "swid";

                try {
                    lstADB_LOCATION.SelectedIndex = 0;
                }
                catch (Exception ee)
                {
                    glb_function.MsgBox("لايمكن فتح هذه الشاشة لعدم وجود مواقع ");
                    this.Close();
                }
               
            }


        }
        private void FillADBDesc()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtFill = cnn.GetDataTable("select distinct ADB_DESCRIBE from address_book");
            lstADB_DESCRIBE.DataSource = dtFill;
            lstADB_DESCRIBE.DisplayMember = "ADB_DESCRIBE";
           

        }
        private void FillCONT_TITLE()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtFill = cnn.GetDataTable("select distinct CONT_TITLE from CONTACT_DATA");
            lstCONT_TITLE.DataSource = dtFill;
            lstCONT_TITLE.DisplayMember = "CONT_TITLE";


        }
        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (txtCONT_VALUE.Text == "")
            {
                ERP.glb_function.MsgBox("الرجاء ادخال القيمة");
                txtCONT_VALUE.Focus();
                return;
            }

            for (int i = 0; i < dgCotactData.Rows.Count; i++)
            {
                if (txtCONT_VALUE.Text.Trim() == dgCotactData[3, i].Value.ToString().Trim())
                {
                    glb_function.MsgBox("القيمة مدخله من قبل");
                    return;
                }
            }
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtContactValue = cnn.GetDataTable("select cont_title,cont_value,a.adb_name from contact_data c,address_book a  "+
                    " where a.swid = c.adb_id and cont_value='" + txtCONT_VALUE.Text.Trim() + "'");
            if (dtContactValue != null && dtContactValue.Rows.Count > 0)
            {
                glb_function.MsgBox("هذا "+ lstCONT_TYPE.Text + " مسجل باسم " +dtContactValue.Rows[0]["adb_name"].ToString()+"\n"+"لايمكن اتمام العملية ");
                return;
            }

            dgCotactData.Rows.Add();
            dgCotactData[0, dgCotactData.Rows.Count - 1].Value = "";
            dgCotactData[1, dgCotactData.Rows.Count - 1].Value = lstCONT_TYPE.Text ;
            dgCotactData[2, dgCotactData.Rows.Count - 1].Value = lstCONT_TITLE.Text ;
            dgCotactData[3, dgCotactData.Rows.Count - 1].Value = txtCONT_VALUE.Text ;

            this.dgCotactData.Sort(this.dgCotactData.Columns["CONT_TYPE"], ListSortDirection.Ascending);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!glb_function.AcceptTrans)
                return ;
            if (txtADB_NAME.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم الشخص");
                txtADB_NAME.Focus();
                return;
            }
            if (lstADB_LOCATION .SelectedIndex  == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الموقع");
                lstADB_LOCATION.Focus();
                return;
            }

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
            string str;
            if (txtSWID.Text.Trim()!="")
            {
                 str = "update address_book set ADB_NAME='" + txtADB_NAME.Text + "',ADB_DESCRIBE='" + lstADB_DESCRIBE.Text + "',ADB_LOCATION=" + lstADB_LOCATION.SelectedValue.ToString() + ",JOB='" + lstJOB.Text + "' where swid=" + txtSWID.Text .Trim();

            }
            else
            {
                DataTable dtBranch = cnn.GetDataTable("select nvl(max(swid),0)+1 from address_book");


                txtSWID.Text = dtBranch.Rows[0][0].ToString();




                 str = "insert into address_book values (" + txtSWID.Text + ",sysdate," + glb_function.glb_strUserId + ",'فعال','" + txtADB_NAME.Text + "','" + lstADB_DESCRIBE.Text + "'," + lstADB_LOCATION.SelectedValue.ToString() + ",'"+lstJOB.Text +"')";
              
            }
            glb_function.arrInsertLogs.Add
                 (str);
            for (int i = 0; i < dgCotactData.Rows.Count; i++)
            {
                if (dgCotactData[0, i].Value.ToString() == "")
                    glb_function.arrInsertLogs.Add("insert into CONTACT_DATA values((select nvl(max(swid),0)+1 from CONTACT_DATA),sysdate,"+glb_function.glb_strUserId +","+txtSWID.Text +",'"+dgCotactData[2,i].Value.ToString()+ "','" + dgCotactData[1, i].Value.ToString() + "','" + dgCotactData[3, i].Value.ToString() + "')");
            }
           




            if (glb_function.MultiTransData ())
            {
                GetData(txtSWID.Text.Trim());

            }

        }
      
        private void GetData(string strPk)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtADB = cnn.GetDataTable("select * from address_book where swid=" + strPk);

            lstADB_DESCRIBE.Text = dtADB.Rows[0]["adb_describe"].ToString() ;
            if (dtADB.Rows[0]["adb_location"].ToString() != "")
                lstADB_LOCATION.SelectedValue = Convert.ToInt16(dtADB.Rows[0]["adb_location"].ToString());
            else
                lstADB_LOCATION.SelectedIndex = -1;

            txtADB_NAME.Text = dtADB.Rows[0]["adb_name"].ToString();
          
            lstJOB .Text = dtADB.Rows[0]["job"].ToString();

            dtADB.Rows.Clear();
            dtADB = cnn.GetDataTable("select * from CONTACT_DATA where ADB_ID= "+txtSWID.Text );
            dgCotactData.Rows.Clear();
            for (int i = 0; i < dtADB.Rows.Count; i++)
            {
                dgCotactData.Rows.Add();
                dgCotactData[0, dgCotactData.Rows.Count - 1].Value = dtADB.Rows[i]["SWID"].ToString();
                dgCotactData[1, dgCotactData.Rows.Count - 1].Value = dtADB.Rows[i]["CONT_TYPE"].ToString();
                dgCotactData[2, dgCotactData.Rows.Count - 1].Value = dtADB.Rows[i]["CONT_TITLE"].ToString();
                dgCotactData[3, dgCotactData.Rows.Count - 1].Value = dtADB.Rows[i]["CONT_VALUE"].ToString();
            }


            this.dgCotactData.Sort(this.dgCotactData.Columns["CONT_TYPE"], ListSortDirection.Ascending);
        }

        private void dgCotactData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (glb_function.MsgBox("هل تريد حذف الصف بالفعل؟", "", true) == false)
                    return;

                if (dgCotactData[0, e.RowIndex].Value.ToString() == "")
                {
                    dgCotactData.Rows.Remove(dgCotactData.Rows[e.RowIndex]);
                    return;
                }

                ConnectionToDB cnn = new ConnectionToDB();
                int ich = cnn.TranDataToDB("delete from CONTACT_DATA where swid=" + dgCotactData[0, e.RowIndex].Value.ToString());
                if(ich<=0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                    return;
                }
                cnn.glb_commitTransaction();
                dgCotactData.Rows.Remove(dgCotactData.Rows[e.RowIndex]);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            new glb_function().clearItems(this);
         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindContacts frm = new frmFindContacts();
            frm.ShowDialog();

            if(frm.strADBid !="")
            {
                txtSWID.Text = frm.strADBid;
                GetData(txtSWID.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
