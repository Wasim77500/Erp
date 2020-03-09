
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Accounts
{
    public partial class frmAccVariable : MyForm
    {
        DataTable dtLevel;
        public frmAccVariable()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nmbTHE_VALUE.Value <= 0)
            {
                glb_function.MsgBox("الراجاء ادخال عدد الرتب");
                return;
            }

            GetGridData();
        }
        private void GetGridData()
        {
            dgLevels.Rows.Clear();

            for (int j = 0; j < nmbTHE_VALUE.Value; j++)
            {
                dgLevels.Rows.Add();
                dgLevels[0, j].Value = dtLevel.Rows[j + 1]["VALUE_NAME"].ToString();
                dgLevels[1, j].Value = dtLevel.Rows[j + 1]["THE_VALUE"].ToString();
                dgLevels[2,j].Value = dtLevel.Rows[j + 1]["swid"].ToString();
                dgLevels[3,j].Value = dtLevel.Rows[j + 1]["VALUE_DESCRIPTION"].ToString();
            }
            if(dgLevels.Rows.Count >=1)
            dgLevels[1, 0].ReadOnly = true;
        }
        private void NmbValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.SendWait ("{TAB}");
        }

        private void nmbValue_Leave(object sender, EventArgs e)
        {
            if(nmbValue.Visible == true)
           {
                nmbValue.Visible = false;

                dgLevels[1, Convert.ToUInt16(nmbValue.Tag.ToString())].Value = nmbValue.Value;
            }
              
            
        }

        private void dgLevels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
            if (e.RowIndex >= 1)
            {
                if (e.ColumnIndex == 1 )
                {
                    
                    DataGridViewCell abc = dgLevels.CurrentCell;
                    Rectangle RECT = dgLevels.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
                    if (dgLevels[1, e.RowIndex].Value.ToString() != "")
                        nmbValue.Value = Convert.ToDecimal(dgLevels[1, e.RowIndex].Value);
                    nmbValue.Tag  = e.RowIndex.ToString();
                    CtlLocation(RECT);
                }
            }
           
        }
        public void CtlLocation(Rectangle rect)
        {

            nmbValue.Top = dgLevels.Location.Y + rect.Y;
            nmbValue.Left = dgLevels.Location.X + rect.X;
            nmbValue.Width = rect.Width;
            nmbValue.Height = rect.Height;
            nmbValue.BringToFront();
            nmbValue.Visible = true;
            nmbValue.Focus();


        }

        private void frmAccVariable_Load(object sender, EventArgs e)
        {

            FillLevel();
            FillCostCenterType();

        }
        private void FillCostCenterType()
        {
            dgvCostCenter.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCostCenter = cnn.GetDataTable("select swid,type_name,branch,administration,note from COST_CENTER_TYPES");
            for (int i = 0; i < dtCostCenter.Rows.Count; i++)
            {
                dgvCostCenter.Rows.Add();
                dgvCostCenter[clmCostCenterSwid.Index,i].Value = dtCostCenter.Rows[i]["swid"].ToString();
                dgvCostCenter[clmCostName.Index, i].Value = dtCostCenter.Rows[i]["type_name"].ToString();
                dgvCostCenter[clmCostNote.Index, i].Value = dtCostCenter.Rows[i]["note"].ToString();
                dgvCostCenter[clmBranch.Index, i].Value = (dtCostCenter.Rows[i]["branch"].ToString() == "1" ? true : false) ;
                dgvCostCenter[clmAdministration.Index, i].Value =( dtCostCenter.Rows[i]["administration"].ToString() == "1" ? true : false) ;
        }



        }
        private void FillLevel()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            dtLevel = cnn.GetDataTable("select VALUE_NAME,THE_VALUE,swid,VALUE_DESCRIPTION from DEFAULT_VALUES where  value_name like '%الرتبة%'" + "order by swid");

            // for (int i = 0; i < dtLevel.Rows.Count; i++)
            //  {
            if (dtLevel.Rows[0]["VALUE_NAME"].ToString() == "الرتبة")
                nmbTHE_VALUE.Value = Convert.ToInt16(dtLevel.Rows[0]["THE_VALUE"].ToString());

            //  }

            GetGridData();

            LockedLevelNo();

        }
        private void LockedLevelNo()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtAccRow = cnn.GetDataTable("select swid from ACCOUNTS ");
            if (dtAccRow != null && dtAccRow.Rows.Count >= 1)
            {
                btnAdd.Enabled = false;
                nmbTHE_VALUE.Enabled = false;
            }
                

        }

        private void dgLevels_Click(object sender, EventArgs e)
        {
            nmbValue_Leave(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgLevels.Rows.Count; i++)
            {
                for (int y = 0; y < dgLevels.Rows[i].Cells.Count - 1; y++)
                {
                    dgLevels.Rows[i].Cells[y].Style.BackColor = System.Drawing.Color.White ;
                }
            }
         


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
            ("update DEFAULT_VALUES set " +
                " THE_VALUE= '" + nmbTHE_VALUE.Value .ToString() + "' where swid=1");
           
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCheckLevels;
            for (int i = 0; i < dgLevels.Rows.Count; i++)
            {

                if (i == 0 && dgLevels[1, 0].Value.ToString() != "1")
                {
                    for (int y = 0; y < dgLevels.Rows[i].Cells.Count - 1; y++)
                    {
                        dgLevels.Rows[i].Cells[y].Style.BackColor = System.Drawing.Color.Red;
                    }
                 
                }
                else
                {
                    dtCheckLevels= cnn.GetDataTable("select nvl( max(acc_level),-1) from ACCOUNTS");
                    if (dtCheckLevels != null && dtCheckLevels.Rows.Count >= 1)
                    {
                       
                        if (Convert.ToInt16(dtCheckLevels.Rows[0][0].ToString()) >= Convert.ToInt16(dgLevels[1, i].Value.ToString()))
                        {
                            for (int y = 0; y < dgLevels.Rows[i].Cells.Count - 1; y++)
                            {
                                dgLevels.Rows[i].Cells[y].Style.BackColor = System.Drawing.Color.Red;
                            }
                           
                        }
                        else
                        {
                            glb_function.arrInsertLogs.Add
                            ("update DEFAULT_VALUES set " +
                " THE_VALUE= '" + dgLevels[1,i].Value.ToString() + "' where swid="+dgLevels[2,i].Value.ToString());
                        }
                        
                    }
                }


                glb_function.arrInsertLogs.Add
                          ("update DEFAULT_VALUES set " +
              " VALUE_DESCRIPTION= '" + (dgLevels[3, i].Value==null?"": dgLevels[3, i].Value.ToString()) + "' where swid=" + dgLevels[2, i].Value.ToString());


            }

          //  if (iError == 1)
              //  return;
            glb_function.MultiTransData ();




        }

        private void pnlGnrlSetting_Paint(object sender, PaintEventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
        }

        private void nmbValue_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void pnlAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        

        private void btnAddCostCenter_Click(object sender, EventArgs e)
        {
            if(txtCostCenterName.Text .Trim()=="")
            {
                glb_function.MsgBox("الرجاء ادخال الاسم لمركز التكلفة");
                return;
            }

            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("insert into COST_CENTER_TYPES values ((select nvl(max(swid),0)+1 from COST_CENTER_TYPES),"+glb_function.glb_strUserId+",sysdate,'فعال','"+txtCostCenterName.Text .Trim()+"','"+(ckbBranch.Checked ==true ?"1":"0")+ "','" + (ckbAdministation.Checked == true ? "1" : "0") + "','" + txtCostCenterNote.Text.Trim()+"')");

            if(icheck <=0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الاضافة");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الاضافة بنجاح");
            FillCostCenterType();

        }
    }
}
