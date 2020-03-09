using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.File
{
    public partial class frmLocation : MyForm
    {
        ConnectionToDB cnnfillData = new ConnectionToDB();
        public frmLocation()
        {
            InitializeComponent();
        }

        private void myPanal1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (txtLOCATION_NAME.Text == "")
            {

                errCheck.SetError(txtLOCATION_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtLOCATION_NAME, "");
            }

            if (lstLOCATION_TYPE .Text == "")
            {

                errCheck.SetError(lstLOCATION_TYPE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstLOCATION_TYPE, "");
            }


            if (iError == 1)
                return false;

            return true;
        }
            private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

           ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select nvl(max(swid),0)+1 from location");
            
            txtSWID.Text = dtLocation.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
            ("insert into LOCATION values(" + txtSWID.Text +
                ", '" + txtLOCATION_NAME.Text + "','" + lstLOCATION_TYPE.Text + "'," +
                "" + (lstPARENT_ID.SelectedValue==null?"null": lstPARENT_ID.SelectedValue.ToString()) + "," + glb_function.glb_strUserId + ","+
                " sysdate,'ACTIVE','"+txtLOC_NOTE.Text +"')");

           if(glb_function.MultiTransData ())
            {
                GetData( txtSWID.Text .Trim());
                //btnSave.Visible  = false;
                //btnNew.Location = btnSave.Location;
                //btnNew.Visible = true;
                //btnUpdate.Enabled = true;
            }
           
            

        }
        private void GetData(string strPk)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select * from location where swid="+strPk);

            txtLOCATION_NAME.Text = dtLocation.Rows[0]["LOCATION_NAME"].ToString();
            txtLOCATION_NAME.W_OldValue  = dtLocation.Rows[0]["LOCATION_NAME"].ToString();
            

            lstLOCATION_TYPE.Text = dtLocation.Rows[0]["LOCATION_TYPE"].ToString();
            lstLOCATION_TYPE.W_OldValue  = dtLocation.Rows[0]["LOCATION_TYPE"].ToString();

            lstPARENT_ID  .SelectedValue =(dtLocation.Rows[0]["PARENT_ID"].ToString().Trim() == ""?-1: Convert.ToInt16( dtLocation.Rows[0]["PARENT_ID"].ToString()));
            lstPARENT_ID.W_OldValue  = (dtLocation.Rows[0]["PARENT_ID"].ToString());

            txtLOC_NOTE.Text = dtLocation.Rows[0]["LOC_NOTE"].ToString();
            txtLOC_NOTE.W_OldValue = dtLocation.Rows[0]["LOC_NOTE"].ToString();

          
            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if(HasPrivilege("btnUpdate" ) )
              btnUpdate.Enabled = true;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            //int icheck = cnn.TranDataToDB("update  LOCATION set "  +
            //    " LOCATION_NAME='" + txtLOCATION_NAME.Text + "',LOCATION_TYPE='" + lstLOCATION_TYPE.Text + "'," +
            //    "PARENT_ID=" + lstPARENT_ID.SelectedValue.ToString() + "" +
            //    " LOC_NOTE='" + txtLOC_NOTE.Text + "' where swid="+txtSWID.Text );
            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add ("update  LOCATION set " +
                " LOCATION_NAME='" + txtLOCATION_NAME.Text + "',LOCATION_TYPE='" + lstLOCATION_TYPE.Text + "'," +
                "PARENT_ID=" + (lstPARENT_ID.SelectedValue == null ? "null" : lstPARENT_ID.SelectedValue.ToString()) + "," +
                " LOC_NOTE='" + txtLOC_NOTE.Text + "' where swid=" + txtSWID.Text);

            new glb_function().InsertToLogs(this, "LOCATION", txtSWID.Text,"");
            //other table 

          if(  glb_function.MultiTransData())

            GetData(txtSWID.Text );
           
           
           
        }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;

            btnUpdate.Enabled = false;

            FillLocationType();
            FillParent();
        }
  
       
        private void FillParent()
        {
            //ConnectionToDB myconn = new ConnectionToDB();
            DataTable MyDataTable;
            MyDataTable = cnnfillData.GetDataTable("Select swid, LOCATION_NAME From  location order by LOCATION_NAME");
            if (MyDataTable != null)
            {


                lstPARENT_ID.DataSource = MyDataTable;


                lstPARENT_ID.DisplayMember = "LOCATION_NAME";
                lstPARENT_ID.ValueMember = "swid";

                lstPARENT_ID.SelectedIndex = -1;
            }
        }
        private void FillLocationType()
        {
            //ConnectionToDB myconn = new ConnectionToDB();


            DataTable MyDataTable;
            MyDataTable = cnnfillData.GetDataTable("Select distinct LOCATION_TYPE From  location order by LOCATION_TYPE");
            if (MyDataTable != null)
            {


                lstLOCATION_TYPE.DataSource = MyDataTable;


                lstLOCATION_TYPE.DisplayMember = "LOCATION_TYPE";
             //   lstLOCATION_TYPE.ValueMember = "branch_no";

                lstLOCATION_TYPE.SelectedIndex = -1;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
           

            FillLocationType();
            FillParent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindLocationData frm = new frmFindLocationData();

            frm.ShowDialog();

            if (frm.strLocationId  != "")
            {
                txtSWID .Text = frm.strLocationId;
                GetData(txtSWID.Text);
            }
        }
    }
}
