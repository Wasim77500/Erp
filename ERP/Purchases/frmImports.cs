using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Purchases
{
    public partial class frmImports : MyForm
    {
        public frmImports()
        {
            InitializeComponent();
        }

        private void frmImports_Load(object sender, EventArgs e)
        {
            glb_function.FillListWithId(ref lstCURRENCY_ID, "CURRENCY", "curr_name");
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToDB cnn = new ConnectionToDB();

            glb_function.arrInsertLogs = new System.Collections.ArrayList();


            DataTable dtImport= cnn.GetDataTable("select nvl(max(swid),0)+1 from imports ");

            txtSwid.Text = dtImport.Rows[0][0].ToString();

            dtImport.Clear();

            dtImport = cnn.GetDataTable("select swid from accounts a where stat = N'فعال' and system_acc_type = N'وارد' and acc_class = N'فرعي' order by swid");

            if (dtImport == null || dtImport.Rows.Count <= 0)
            {
                glb_function.MsgBox("لايوجد حساب للواردات");
                return;
            }


            txtIMP_ACCOUNT_ID.Text = dtImport.Rows[0][0].ToString();
            glb_function.arrInsertLogs.Add("insert into imports values("+txtSwid.Text +",sysdate,"+
                glb_function.glb_strUserId+ ",'فعال','"+ lstImport_NATURE.Text + 
                "','"+txtImport_no.Text +"',to_date('"+ dtpImport_DATE .Value.ToString("dd/MM/yyyy")+ "','dd/mm/yyyy'),'"+
                lstSHIPPING_Way.Text +"','"+lstOPERATION_TYPE.Text +
                "',to_date('"+ dtpVESSEL_DATE .Value.ToString("dd/MM/yyyy")+ "','dd/mm/yyyy'),'"+
                txtPORT_LOADING.Text +"','"+txtPORT_LOADING_COUNTRY.Text +
                "',to_date('"+ dtpESTIMATED_ARRIVAL_date .Value.ToString("dd/MM/yyyy")+ "','dd/mm/yyyy'),'"+
                txtPORT_DISCHARGE.Text +"','"+txtPORT_DISCHARGE_COUNTRY.Text +"','"+
                txtShipping_trip_no.Text +
                "',to_date('"+dtpDEPARTURE_DATE.Value.ToString("dd/MM/yyyy")+"','dd/mm/yyyy')," +
                "to_date('"+ dtpARRIVAL_DATE .Value.ToString("dd/MM/yyyy")+ "','dd/mm/yyyy'),"+txtIMP_ACCOUNT_ID.Text +","+lstCURRENCY_ID.SelectedValue.ToString()+")");

            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);


        }
        private void GetData(string strSwid)
        {
              btnNew_Click(null, null);
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtImport = cnn.GetDataTable("select import_nature, import_no," +
                " import_date, shipping_way, operation_type, vessel_date, port_loading," +
                " port_loading_country, estimated_arrival_date, port_discharge, port_discharge_country," +
                " shipping_trip_no, departure_date, arrival_date, imp_account_id,CURRENCY_ID from imports where swid= " + strSwid);


            txtSwid.Text = strSwid;
            lstImport_NATURE.Text = dtImport.Rows[0]["import_nature"].ToString();
            txtImport_no.Text = dtImport.Rows[0]["import_no"].ToString();
            dtpImport_DATE.Value =Convert.ToDateTime( dtImport.Rows[0]["import_date"].ToString());
            lstSHIPPING_Way.Text = dtImport.Rows[0]["shipping_way"].ToString();
            lstOPERATION_TYPE.Text = dtImport.Rows[0]["operation_type"].ToString();
            dtpVESSEL_DATE.Value = Convert.ToDateTime(dtImport.Rows[0]["vessel_date"].ToString());
            txtPORT_LOADING .Text = dtImport.Rows[0]["port_loading"].ToString();
            txtPORT_LOADING_COUNTRY.Text = dtImport.Rows[0]["port_loading_country"].ToString();
            dtpESTIMATED_ARRIVAL_date.Value = Convert.ToDateTime(dtImport.Rows[0]["estimated_arrival_date"].ToString());
            txtPORT_DISCHARGE.Text = dtImport.Rows[0]["port_discharge"].ToString();
            txtPORT_DISCHARGE_COUNTRY.Text = dtImport.Rows[0]["port_discharge_country"].ToString();
            txtShipping_trip_no.Text = dtImport.Rows[0]["shipping_trip_no"].ToString();
            dtpDEPARTURE_DATE.Value = Convert.ToDateTime(dtImport.Rows[0]["departure_date"].ToString());
            dtpARRIVAL_DATE.Value = Convert.ToDateTime(dtImport.Rows[0]["arrival_date"].ToString());
            txtIMP_ACCOUNT_ID.Text = dtImport.Rows[0]["imp_account_id"].ToString();
            lstCURRENCY_ID.SelectedValue = Convert.ToInt16(dtImport.Rows[0]["CURRENCY_ID"].ToString());

            LoadInvoices();

            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (txtImport_no.Text  =="")
            {

                errCheckDetails.SetError(txtImport_no, "الرجاء اختيار العملة");
                iError = 1;
            }
            else
            {
                errCheckDetails.SetError(txtImport_no, "");
            }



            if (iError == 1)
                return false;

            return true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            PrepareForm();
        }
        private void PrepareForm()
        {
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFindImport frm = new frmFindImport();
            frm.strWhere = " and stat='فعال'";
            frm.ShowDialog();

            if (frm.strImportID != "")
            {
                GetData(frm.strImportID);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


           

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            
          
            glb_function.arrInsertLogs.Add("update  imports set Import_NATURE='" + lstImport_NATURE.Text +
                "',Import_no='" + txtImport_no.Text + "',Import_DATE=to_date('" + dtpImport_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')," +
                "SHIPPING_Way='" + lstSHIPPING_Way.Text + "',OPERATION_TYPE='" + lstOPERATION_TYPE.Text +
                "',VESSEL_DATE=to_date('" + dtpVESSEL_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')," +
                "PORT_LOADING='" +
                txtPORT_LOADING.Text + "',PORT_LOADING_COUNTRY='" + txtPORT_LOADING_COUNTRY.Text +
                "',ESTIMATED_ARRIVAL_date=to_date('" + dtpESTIMATED_ARRIVAL_date.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')," +
                "PORT_DISCHARGE='" +
                txtPORT_DISCHARGE.Text + "',PORT_DISCHARGE_COUNTRY='" + txtPORT_DISCHARGE_COUNTRY.Text + "',Shipping_trip_no='" +
                txtShipping_trip_no.Text +
                "',DEPARTURE_DATE=to_date('" + dtpDEPARTURE_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy')," +
                "ARRIVAL_DATE=to_date('" + dtpARRIVAL_DATE.Value.ToString("dd/MM/yyyy") + "','dd/mm/yyyy') where swid="+txtSwid.Text );

            if (glb_function.MultiTransData())
                GetData(txtSwid.Text);
        }

        private void btnAddExpeness_Click(object sender, EventArgs e)
        {
            if (txtSwid.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار الوارد");
                return;
            }
            if(lstCURRENCY_ID.SelectedIndex ==-1)
            {
                glb_function.MsgBox("الرجاء اختيار العملة");
                return;
            }

           frmPrecurementExpensess frm = new frmPrecurementExpensess();
            frm.txtISSUED_ID.Text = txtSwid.Text;
            frm.txtISSUED_TYPE.Text = "وارد";
            frm.txtTempletId.Text = lstTemplet.SelectedValue.ToString();
           
            frm.ShowDialog();
        }

        private void btnAddLcRollOver_Click(object sender, EventArgs e)
        {
            if (txtSwid.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار الوارد");
                return;
            }

            frmPurchasesBill frm = new frmPurchasesBill();
            frm.strImportNo = txtSwid.Text;
            frm.strThisFormFromWhere = "Import";
            
            frm.ShowDialog();
            LoadInvoices();
        }
        private void LoadInvoices()
        {
            if( txtSwid.Text =="")
            {
                glb_function.MsgBox("الرجاء اختيار او حفظ وارد");
                return;
            }
            dgInvoice.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtInvoece = cnn.GetDataTable("select swid,bill_number,bill_type " +
                "from  purchases_bill b " +
                "where b.imports_id="+txtSwid.Text );

            for (int i = 0; i < dtInvoece.Rows.Count; i++)
            {
                dgInvoice.Rows.Add();
                dgInvoice[clmSwid.Index, dgInvoice.Rows.Count - 1].Value = dtInvoece.Rows[i]["swid"].ToString();
                dgInvoice[clmBill_number.Index, dgInvoice.Rows.Count - 1].Value = dtInvoece.Rows[i]["bill_number"].ToString();
                dgInvoice[clmBill_type.Index, dgInvoice.Rows.Count - 1].Value = dtInvoece.Rows[i]["bill_type"].ToString();
            }
        }
    }
}
