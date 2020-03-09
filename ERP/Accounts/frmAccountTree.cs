
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ERP.Accounts 
{
    public partial class frmAccountTree : MyForm
    {
        DataTable dtPrepareAccTree;
        int iLevelCount;

        DataTable dtLevel;
        public frmAccountTree()
        {
            InitializeComponent();
        }

        private void frmAccountTree_Load(object sender, EventArgs e)
        {
            if (dtPri.Rows.Count <= 0)
                return;
            FillAccountTree();
            lstStat.Text = "فعال";
            FillBranch("0");
            iLevelCount = 0;
            FillCurrency("0");


        }
        private void FillCurrency(string strAccid)
        {

            dgCurrency.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCurrency = cnn.GetDataTable("select c.swid,c.curr_name,a.acc_id,a.swid CurrAccid from currency c " +
                                                    " left outer JOIN acc_curr a on(c.swid = a.curr_id and a.acc_id = " + strAccid + ") order by c.swid");

            for (int i = 0; i < dtCurrency.Rows.Count; i++)
            {
                dgCurrency.Rows.Add();
                dgCurrency[0, dgCurrency.Rows.Count - 1].Value = dtCurrency.Rows[i]["CurrAccid"].ToString();
                dgCurrency[1, dgCurrency.Rows.Count - 1].Value = (dtCurrency.Rows[i]["CurrAccid"].ToString() != "" ? true : false);
                dgCurrency[2, dgCurrency.Rows.Count - 1].Value = dtCurrency.Rows[i]["swid"].ToString();
                dgCurrency[3, dgCurrency.Rows.Count - 1].Value = dtCurrency.Rows[i]["curr_name"].ToString();
            }
        }
        private void FillBranch(string strAccid)
        {
            dgBranches.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtBranches = cnn.GetDataTable("select b.swid,b.branch_cost_center_name BRANCH_ANAME,a.acc_id,a.swid BranchAccid " +
                                                     " from branches_costcenter b " +
                                                     " join cost_center_types cct on (cct.swid=b.costcenter_type_id)" +
                                                    " left outer JOIN acc_branch a on(b.swid = a.branch_id and a.acc_id = " + strAccid + ") where cct.branch='1' order by b.swid");

            for (int i = 0; i < dtBranches.Rows.Count; i++)
            {
                dgBranches.Rows.Add();
                dgBranches[0, dgBranches.Rows.Count - 1].Value = dtBranches.Rows[i]["BranchAccid"].ToString();
                dgBranches[1, dgBranches.Rows.Count - 1].Value = (dtBranches.Rows[i]["BranchAccid"].ToString() != "" ? true : false);
                dgBranches[2, dgBranches.Rows.Count - 1].Value = dtBranches.Rows[i]["swid"].ToString();
                dgBranches[3, dgBranches.Rows.Count - 1].Value = dtBranches.Rows[i]["BRANCH_ANAME"].ToString();
            }
        }

        private void FillAccountTree()
        {

            dtPrepareAccTree = new DataTable();
            ConnectionToDB cnn = new ConnectionToDB();
            //dtPrepareAccTree = cnn.GetDataTable("select nvl(the_value,0) from DEFAULT_VALUES where VALUE_NAME='الرتبة'");

            // int iLevelNo =Convert.ToInt16(dtPrepareAccTree.Rows[0][0].ToString());
            dtPrepareAccTree.Rows.Clear();

            dtPrepareAccTree = cnn.GetDataTable("select swid, created_date, stat, acc_no, acc_type, acc_name, acc_level, acc_class, acc_note, acc_code, nvl(acc_parent,0) as acc_parent, created_user, acc_subject,ACC_REPORT,ACC_NATURE  from ACCOUNTS t " +
                                    " order by acc_no ");

            
            tvAccTreeMain.Nodes.Clear();
            PopulateTreeViewMain(0, null);



        }
        private void PopulateTreeViewPrint(int parentId, TreeNodeAdv parentNode)

        {


            TreeNodeAdv childNode;


            foreach (DataRow dr in dtPrepareAccTree.Select("[acc_parent]=" + parentId))

            {
               

                TreeNodeAdv t = new TreeNodeAdv();
                t.Text = dr["acc_no"].ToString() + " - " + dr["acc_name"].ToString();
                // t.Name = dr["acc_no"].ToString();

                t.Tag = dtPrepareAccTree.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    tvAccTree.Nodes.Add(t);
                    childNode = t;

                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeViewPrint(Convert.ToInt32(dr["swid"].ToString()), childNode);

            }

        }

        private void PopulateTreeViewMain(int parentId, TreeNode parentNode)

        {


            TreeNode childNode;


            foreach (DataRow dr in dtPrepareAccTree.Select("[acc_parent]=" + parentId))

            {


                TreeNode t = new TreeNode();
                t.Text = dr["acc_no"].ToString() + " - " + dr["acc_name"].ToString();
                // t.Name = dr["acc_no"].ToString();

                t.Tag = dtPrepareAccTree.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    tvAccTreeMain.Nodes.Add(t);
                    childNode = t;

                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }
                t.ContextMenuStrip = contextMenuStrip1;
                PopulateTreeViewMain(Convert.ToInt32(dr["swid"].ToString()), childNode);

            }

        }

        private void GetAcc_NameFromGrid(string strAccid)
        {

            for (int i = 0; i < dtPrepareAccTree.Rows.Count; i++)
            {
                if (dtPrepareAccTree.Rows[i]["swid"].ToString() == strAccid)
                {
                    txtParentName.Text = dtPrepareAccTree.Rows[i]["acc_name"].ToString();
                    txtACC_PARENT.Text = dtPrepareAccTree.Rows[i]["acc_no"].ToString();
                    return;
                    //txtParentName.Text = GetAcc_NameFromGrid(txtACC_PARENT.Text);
                }

            }
            txtParentName.Text = "";
            txtACC_PARENT.Text = "";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnAdd.Visible = true;
            btnNew.Visible = false;
            txtACC_NO.Enabled = true;

            btnUpdate.Enabled = false;
            FillBranch("0");
            FillCurrency("0");
            lstStat.Text = "فعال";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
         
            tvAccTree.Nodes.Clear();
          PopulateTreeViewPrint(0, null);
            int itemp = tvAccTree.Width;
           // tvAccTree.Visible = false;
            tvAccTree.Width = 600;
            tvAccTree.ExpandAll();

          

            tvAccTree.PrintDocument.HeaderText = "شجرة الحسابات";
            tvAccTree.PrintDocument.HeaderAlignment = TextAlignment.Right;

            tvAccTree.PrintDocument.ShowPageNumber = true;

            tvAccTree.PrintDocument.PrintPreview();

            tvAccTree.CollapseAll();
            tvAccTree.Width = itemp;
            // tvAccTree.Visible = true;

           
          //  tvAccTree.PrintDocument.Dispose();
            tvAccTree.PrintDocument = null;

        }

        private void txtACC_LEVEL_Leave(object sender, EventArgs e)
        {




        }

        private void txtACC_NO_Leave(object sender, EventArgs e)
        {



            CheckAccNo();



        }

        private void CheckAccNo()
        {
            string strTempNOacc = txtACC_NO.Text;
            ConnectionToDB cnn = new ConnectionToDB();
            dtLevel = cnn.GetDataTable("select * from DEFAULT_VALUES t " +
                   " where value_name like '%الرتبة%' order by value_name");
            iLevelCount = 0;





            iLevelCount = Convert.ToUInt16(dtLevel.Rows[0]["the_value"].ToString());





            string[] iLevel = new string[iLevelCount];

            int icount = 0;
            for (int i = 0; i < iLevelCount; i++)
            {
                if (strTempNOacc.Length > 0)
                {
                    string strro = dtLevel.Rows[i + 1]["the_value"].ToString();
                    if (strTempNOacc.Length >= Convert.ToUInt16(strro))
                    {
                        iLevel[i] = strTempNOacc.Substring(0, Convert.ToUInt16(dtLevel.Rows[i + 1]["the_value"].ToString()));
                        strTempNOacc = strTempNOacc.Substring(Convert.ToUInt16(dtLevel.Rows[i + 1]["the_value"].ToString()));
                        icount++;

                    }

                    else
                    {
                        glb_function.MsgBox("رقم الحساب المدخل غير صحيح");
                        txtACC_NO.Focus();
                        return;
                    }
                }


            }

            if (strTempNOacc.Length >= 1)
            {
                glb_function.MsgBox("رقم الحساب المدخل اكبر من ماهو متوقع" + "\n" + "الرجاء التاكد من رقم الحساب");
                txtACC_NO.Focus();
                return;
            }
            string strParent = "";
            string strParentName = "";
            string strParentId = "";
            for (int i = 0; i < icount - 1; i++)
            {
                strParent = strParent + iLevel[i];

            }
            int icheckParent = 0;
            for (int j = 0; j < dtPrepareAccTree.Rows.Count; j++)
            {
                string str = dtPrepareAccTree.Rows[j]["ACC_NO"].ToString();
                if (str == strParent)
                {
                    icheckParent = 1;
                    strParentName = dtPrepareAccTree.Rows[j]["ACC_Name"].ToString();
                    strParentId = dtPrepareAccTree.Rows[j]["swid"].ToString();

                }
                if (txtACC_NO.Text == str)
                {
                    icheckParent = 2;
                    break;
                }



            }


            if (icheckParent == 2)
            {
                glb_function.MsgBox("رقم الحساب مدخل من قبل");
                txtACC_NO.Focus();
                return;
            }
            else if (icheckParent != 1 && icount > 1)
            {
                glb_function.MsgBox("الاب المدخل غير صحيح");
                txtACC_NO.Focus();
                return;
            }
            else
            {
                if (icount == 1)
                {
                    lstACC_SUBJECT.Enabled = true;
                    strParent = "0";
                }

                else
                {
                    lstACC_SUBJECT.Enabled = false;
                    for (int i = 0; i < dtPrepareAccTree.Rows.Count; i++)
                    {
                        string str = dtPrepareAccTree.Rows[i]["ACC_NO"].ToString();
                        if (str == strParent)
                        {
                            lstACC_SUBJECT.Text = dtPrepareAccTree.Rows[i]["ACC_SUBJECT"].ToString();
                            break;
                        }
                    }
                }

            }


            txtACC_LEVEL.Text = icount.ToString();
            txtACC_LEVEL_Name.Text = GetLevelName((icount + 1).ToString());

            if (icount == iLevelCount)
            {
                lstACC_TYPE.Enabled = false;
                txtACC_CLASS.Text = "فرعي";
                dgBranches.Visible = true;
                dgCurrency.Visible = true;
                for (int i = 0; i < dtPrepareAccTree.Rows.Count; i++)
                {
                    string str = dtPrepareAccTree.Rows[i]["ACC_NO"].ToString();
                    if (str == strParent)
                    {
                        //lstACC_TYPE.Text = dtPrepareAccTree.Rows[i]["ACC_TYPE"].ToString();
                        lstACC_TYPE.SelectedIndex = lstACC_TYPE.FindStringExact(dtPrepareAccTree.Rows[i]["ACC_TYPE"].ToString());
                        break;
                    }
                }
            }

            else
            {
                lstACC_TYPE.Enabled = true;
                txtACC_CLASS.Text = "رئيسي";
                dgBranches.Visible = false;
                dgCurrency.Visible = false;
            }


            txtACC_PARENT.Text = strParent;
            txtParentName.Text = strParentName;
            txtParentId.Text = (strParentId == "" ? "null" : strParentId);



        }

        private string GetLevelName(string swid)
        {
            for (int i = 0; i < dtLevel.Rows.Count; i++)
            {
                if (dtLevel.Rows[i]["swid"].ToString() == swid)
                {
                    return dtLevel.Rows[i]["VALUE_DESCRIPTION"].ToString();

                }


            }

            return "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;
            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
               ("update ACCOUNTS set " +
                " ACC_NAME='" + txtACC_NAME.Text + "',ACC_TYPE=" + (lstACC_TYPE.SelectedIndex == -1 ? "null" : "'" + lstACC_TYPE.Text + "'") + "," +
                " Stat='" + lstStat.Text + "',ACC_CODE='" + txtACC_CODE.Text + "'" +
                ",ACC_NOTE='" + txtACC_NOTE.Text + "',ACC_NATURE='" + lstACC_NATURE.Text + "' ,ACC_REPORT='" + lstACC_REPORT.Text + "' where swid=" + txtSWID.Text);


            new glb_function().InsertToLogs(this, "ACCOUNTS", txtSWID.Text, "");
            //other table 

            for (int i = 0; i < dgBranches.Rows.Count; i++)
            {
                if (dgBranches[0, i].Value.ToString() == "" && dgBranches[1, i].Value.ToString() == "True")
                    glb_function.arrInsertLogs.Add("insert into ACC_BRANCH values ((select nvl(max(swid),0)+1 from ACC_BRANCH)," + txtSWID.Text + "," + dgBranches[2, i].Value.ToString() + ")");
                else if (dgBranches[0, i].Value.ToString() != "" && dgBranches[1, i].Value.ToString() == "False")
                {
                    glb_function.arrInsertLogs.Add("delete from ACC_BRANCH where swid=" + dgBranches[0, i].Value.ToString());
                    glb_function.arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                            "," + glb_function.glb_strUserId + ",sysdate," + dgBranches[0, i].Value.ToString() + ",'ACC_BRANCH','ACC_ID and BRANCH_ID',' فروع الحسابات','" + txtSWID.Text + " : " + dgBranches[2, i].Value.ToString() + "',null,'حذف صف بالكامل وهو عبارة عن الفروع المرتبطة بالحسابات ويتم ادخال رقم الفرع ورقم الحساب')");
                }

            }

            for (int i = 0; i < dgCurrency.Rows.Count; i++)
            {
                if (dgCurrency[0, i].Value.ToString() == "" && dgCurrency[1, i].Value.ToString() == "True")
                    glb_function.arrInsertLogs.Add("insert into ACC_CURR values ((select nvl(max(swid),0)+1 from ACC_CURR),sysdate," + glb_function.glb_strUserId + ", " + txtSWID.Text + "," + dgCurrency[2, i].Value.ToString() + ",null)");
                else if (dgCurrency[0, i].Value.ToString() != "" && dgCurrency[1, i].Value.ToString() == "False")
                {
                    glb_function.arrInsertLogs.Add("delete from ACC_CURR where swid=" + dgCurrency[0, i].Value.ToString());
                    glb_function.arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                            "," + glb_function.glb_strUserId + ",sysdate," + dgCurrency[0, i].Value.ToString() + ",'ACC_CURR','ACC_ID and CURR_ID',' عملات الحسابات','" + txtSWID.Text + " : " + dgCurrency[2, i].Value.ToString() + "',null,'حذف صف بالكامل وهو عبارة عن العملات المرتبطة بالحسابات ويتم ادخال رقم العملة ورقم الحساب')");
                }

            }


            if (glb_function.MultiTransData())

                FillAccountTree();

        }

        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;


            int iError = 0;
            if (txtACC_NO.Text == "")
            {

                errCheck.SetError(txtACC_NO, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtACC_NO, "");
            }



            if (txtACC_NAME.Text == "")
            {

                errCheck.SetError(txtACC_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtACC_NAME, "");
            }



            if (lstACC_TYPE.SelectedIndex == -1 && (iLevelCount == Convert.ToUInt16(txtACC_LEVEL.Text) || iLevelCount == Convert.ToUInt16(txtACC_LEVEL.Text) + 1))
            {

                errCheck.SetError(lstACC_TYPE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstACC_TYPE, "");
            }



            if (txtACC_LEVEL.Text == "")
            {

                errCheck.SetError(txtACC_LEVEL, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtACC_LEVEL, "");
            }


            if (txtACC_CLASS.Text == "")
            {

                errCheck.SetError(txtACC_CLASS, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtACC_CLASS, "");
            }

            if (txtACC_CLASS.Text == "فرعي")
            {
                if (lstACC_TYPE.SelectedValue.ToString() == "1")
                {

                    {
                        errCheck.SetError(lstACC_TYPE, "لايمكن اضافة الحسابات الفرعية لهذا النوع من الحسابات");
                        glb_function.MsgBox(" لايمكن اضافة الحسابات الفرعية لهذا النوع من الحسابات " + "\n" + "الرجاء مراجعة مدير النظام");
                        iError = 1;
                    }

                }

            }
            else
            {
                errCheck.SetError(txtACC_CLASS, "");
            }


            if (lstACC_SUBJECT.Text == "")
            {

                errCheck.SetError(lstACC_SUBJECT, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstACC_SUBJECT, "");
            }



            if (lstStat.Text == "")
            {

                errCheck.SetError(lstStat, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstStat, "");
            }


            if (lstACC_NATURE.Text == "")
            {

                errCheck.SetError(lstACC_NATURE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstACC_NATURE, "");
            }



            if (iError == 1)
                return false;


            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
               ("insert into ACCOUNTS values ((select nvl(max(swid),0)+1 from ACCOUNTS)," +
               " sysdate,'" + lstStat.Text + "','" + txtACC_NO.Text + "','" + lstACC_TYPE.Text + "','" +
               txtACC_NAME.Text + "'," + txtACC_LEVEL.Text + ",'" + txtACC_CLASS.Text +
               "','" + txtACC_NOTE.Text + "','" + txtACC_CODE.Text + "'," + txtParentId.Text +
               "," + glb_function.glb_strUserId + ",'" + lstACC_SUBJECT.Text + "',null,'" + lstACC_NATURE.Text + "','" + lstACC_REPORT.Text + "')");

            for (int i = 0; i < dgBranches.Rows.Count; i++)
            {
                if (dgBranches[1, i].Value.ToString() == "True")
                {
                    glb_function.arrInsertLogs.Add("insert into ACC_BRANCH values ((select nvl(max(swid),0)+1 from ACC_BRANCH),(select nvl(max(swid),0) from ACCOUNTS)," + dgBranches[2, i].Value.ToString() + ")");

                }
            }
            for (int j = 0; j < dgCurrency.Rows.Count; j++)
            {
                if (dgCurrency[1, j].Value.ToString() == "True")
                {
                    glb_function.arrInsertLogs.Add("insert into ACC_CURR values ((select nvl(max(swid),0)+1 from ACC_CURR),sysdate," + glb_function.glb_strUserId + ",(select nvl(max(swid),0) from ACCOUNTS)," + dgCurrency[2, j].Value.ToString() + ",null)");

                }
            }


            if (glb_function.MultiTransData())
            {
                FillAccountTree();
                btnNew_Click(null, null);
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!glb_function.AcceptTrans)
                return;


            if (txtSWID.Text == "")
            {
                glb_function.MsgBox("الرجاء تحديد حساب من الشجرة للحذفه");
                return;
            }

            if (txtACC_CLASS.Text == "رئيسي")
                if (tvAccTree.SelectedNode.HasChildren)
                {
                    glb_function.MsgBox("لايمكن حذف حساب رئيسي لديه حسابات");
                    return;
                }

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtDeleteAcc = cnn.GetDataTable(" select * from JOURNAL_DETAILS t" +
                    " where t.acc_id = " + txtSWID.Text);

            if (dtDeleteAcc != null && dtDeleteAcc.Rows.Count >= 1)
            {
                glb_function.MsgBox("لايمكنك حذف هذا الحساب بسبب ارتباطه" + "\n" + "بعمليات اخرى");
                return;
            }

            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            //  glb_function.arrInsertLogs.Add("delete from ACC_BRANCH where ");
            glb_function.arrInsertLogs.Add
               ("delete from  ACCOUNTS  " +
                "  where swid=" + txtSWID.Text);



            //other table 

            if (glb_function.MultiTransData())
            {
                btnNew_Click(null, null);
            }
            FillAccountTree();


        }



        private void tvAccTree_NodeMouseClick(object sender, Syncfusion.Windows.Forms.Tools.TreeViewAdvMouseClickEventArgs e)
        {
            txtSWID.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["swid"].ToString();

            txtACC_NO.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["acc_no"].ToString();

            txtACC_NAME.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["acc_name"].ToString();
            txtACC_NAME.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["acc_name"].ToString();

            lstACC_SUBJECT.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_SUBJECT"].ToString();


            string str = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["Acc_type"].ToString();
            lstACC_TYPE.Text = str;
            lstACC_TYPE.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["Acc_type"].ToString();

            txtACC_LEVEL.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_LEVEL"].ToString();
            txtACC_LEVEL_Name.Text = GetLevelName((Convert.ToInt16(txtACC_LEVEL.Text) + 1).ToString());
            txtACC_CLASS.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_CLASS"].ToString();

            txtACC_CODE.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_CODE"].ToString();
            txtACC_CODE.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_CODE"].ToString();

            txtParentId.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_PARENT"].ToString();
            GetAcc_NameFromGrid(txtParentId.Text);
            //txtACC_PARENT.Text =
            //txtParentName.Text = GetAcc_NameFromGrid(txtACC_PARENT.Text);


            txtACC_NOTE.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_NOTE"].ToString();
            txtACC_NOTE.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_NOTE"].ToString();

            lstStat.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["stat"].ToString();
            lstStat.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["stat"].ToString();


            lstACC_NATURE.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_NATURE"].ToString();
            lstACC_NATURE.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_NATURE"].ToString();

            lstACC_REPORT.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_REPORT"].ToString();
            lstACC_REPORT.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_REPORT"].ToString();

            btnNew.Location = btnAdd.Location;
            btnNew.Visible = true;
            btnAdd.Visible = false;
            txtACC_NO.Enabled = false;
            //lstACC_SUBJECT.Enabled = false;
            //lstACC_TYPE.Enabled = false;
            FillBranch(txtSWID.Text);
            FillCurrency(txtSWID.Text);
            TreeNodeAdv selectedNode = e.Node;

            if (selectedNode.Nodes.Count >= 1)
                lstACC_TYPE.Enabled = false;
            else
                lstACC_TYPE.Enabled = true;


            if (txtACC_CLASS.Text == "فرعي")
            {
                dgCurrency.Visible = true;
                dgBranches.Visible = true;
            }
            else
            {
                dgCurrency.Visible = false;
                dgBranches.Visible = false;
            }

            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;



        }

        private void lstACC_SUBJECT_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstACC_SUBJECT.SelectedValue == null)
            //    return;



            if (lstACC_SUBJECT.Text != "System.Data.DataRowView" && lstACC_SUBJECT.Text != "")
            {


                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtAccSub = cnn.GetDataTable("select doc_name,to_number(protected_entry) protected_entry from doc_type " +
                    " where DOC_TYPE = N'" + lstACC_SUBJECT.Text + "' order by doc_name");




                lstACC_TYPE.DataSource = dtAccSub;

                lstACC_TYPE.ValueMember = "protected_entry";
                lstACC_TYPE.DisplayMember = "doc_name";
                lstACC_TYPE.SelectedIndex = -1;

            }

        }



        private void tvAccTree_NodeMouseDoubleClick(object sender, TreeViewAdvMouseClickEventArgs e)
        {

        }

        private void lstACC_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int icheckFind = 0;
        private void btnGetNode_Click(object sender, EventArgs e)
        {

            tvAccTreeMain.CollapseAll();

            SearchTree(tvAccTreeMain.Nodes, txtNodeName.Text);

            if (icheckFind == 0)
                glb_function.MsgBox("لم يتم العثور على اسم مطابق");


            icheckFind = 0;
        }



        private TreeNodeAdv SearchTree(TreeNodeCollection nodes, string searchtext)
        {
            foreach (TreeNode node in nodes)
            {

                //if (node.Text == searchtext)
                if (node.Text.Contains(searchtext))
                {


                    // node.TextColor = System.Drawing.Color.Red;
                    node.ForeColor = System.Drawing.Color.Red;

                    tvAccTreeMain.SelectedNode = node;
                    icheckFind++;

                    // return node;

                }
                else

                    node.ForeColor = System.Drawing.Color.Black;
                SearchTree(node.Nodes, searchtext);
            }

            return null;
        }

        private TreeNodeAdv SearchPrintTree(TreeNodeAdvCollection nodes, string swid)
        {
            TreeNodeAdv ReturnNode = null;
            foreach (TreeNodeAdv node in nodes)
            {

                //if (node.Text == searchtext)
                if (node.Tag.ToString() == swid)
                {


                    

                    tvAccTree.SelectedNode = node;
                    icheckFind++;

                    ReturnNode = node;

                }
                else


                    SearchPrintTree(node.Nodes, swid);
            }

            return ReturnNode;
        }
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode SelectedNode = tvAccTreeMain.SelectedNode;
            string str = SelectedNode.Text;
            if (dtPrepareAccTree.Rows[Convert.ToInt16(SelectedNode.Tag.ToString())]["ACC_CLASS"].ToString() == "فرعي")
            {
                glb_function.MsgBox("لايمكن الاضافة الى مستوى فرعي");
                return;
            }
            new glb_function().clearItems(this);
            btnAdd.Visible = true;
            btnNew.Visible = false;
            txtACC_NO.Enabled = true;

            btnUpdate.Enabled = false;
            FillBranch("0");
            FillCurrency("0");
            lstStat.Text = "فعال";
            ConnectionToDB cnn = new ConnectionToDB();
            string strParentAccNo = dtPrepareAccTree.Rows[Convert.ToInt16(SelectedNode.Tag.ToString())]["acc_no"].ToString();
            DataTable dt = cnn.GetDataTable("select max( acc_no)+1 test from accounts a where a.acc_parent in  (select swid from accounts a where a.acc_no like '" + strParentAccNo + "')");

            if (dt == null || dt.Rows.Count <= 0 || dt.Rows[0][0].ToString() == "")
                dt = cnn.GetDataTable("select '"+ strParentAccNo + "'|| lpad('1', to_char( (select the_value from DEFAULT_VALUES where value_name = 'الرتبة' || to_char( (select a.acc_level+1 from accounts a where a.acc_no like '"+ strParentAccNo + "')))),'0') from dual");


            txtACC_NO.Focus();

            txtACC_NO.Text = dt.Rows[0][0].ToString();
            txtACC_NAME.Focus();

        }

      

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
          
            txtSWID.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["swid"].ToString();

            txtACC_NO.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["acc_no"].ToString();

            txtACC_NAME.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["acc_name"].ToString();
            txtACC_NAME.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["acc_name"].ToString();

            lstACC_SUBJECT.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_SUBJECT"].ToString();


            string str = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["Acc_type"].ToString();
            lstACC_TYPE.Text = str;
            lstACC_TYPE.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["Acc_type"].ToString();

            txtACC_LEVEL.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_LEVEL"].ToString();
            txtACC_LEVEL_Name.Text = GetLevelName((Convert.ToInt16(txtACC_LEVEL.Text) + 1).ToString());
            txtACC_CLASS.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_CLASS"].ToString();

            txtACC_CODE.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_CODE"].ToString();
            txtACC_CODE.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_CODE"].ToString();

            txtParentId.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_PARENT"].ToString();
            GetAcc_NameFromGrid(txtParentId.Text);
            //txtACC_PARENT.Text =
            //txtParentName.Text = GetAcc_NameFromGrid(txtACC_PARENT.Text);


            txtACC_NOTE.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_NOTE"].ToString();
            txtACC_NOTE.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_NOTE"].ToString();

            lstStat.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["stat"].ToString();
            lstStat.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["stat"].ToString();


            lstACC_NATURE.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_NATURE"].ToString();
            lstACC_NATURE.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_NATURE"].ToString();

            lstACC_REPORT.Text = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_REPORT"].ToString();
            lstACC_REPORT.W_OldValue = dtPrepareAccTree.Rows[Convert.ToInt16(e.Node.Tag.ToString())]["ACC_REPORT"].ToString();

            btnNew.Location = btnAdd.Location;
            btnNew.Visible = true;
            btnAdd.Visible = false;
            txtACC_NO.Enabled = false;
            //lstACC_SUBJECT.Enabled = false;
            //lstACC_TYPE.Enabled = false;
            FillBranch(txtSWID.Text);
            FillCurrency(txtSWID.Text);
            TreeNode selectedNode = e.Node;

            //if (selectedNode.Nodes.Count >= 1)
            //    lstACC_TYPE.Enabled = false;
            //else
            //    lstACC_TYPE.Enabled = true;
            lstACC_TYPE.Enabled = false;

            if (txtACC_CLASS.Text == "فرعي")
            {
                dgCurrency.Visible = true;
                dgBranches.Visible = true;
            }
            else
            {
                dgCurrency.Visible = false;
                dgBranches.Visible = false;
            }

            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }

       

        private void tvAccTreeMain_MouseDown(object sender, MouseEventArgs e)
        {


            TreeNode tn = tvAccTreeMain.GetNodeAt(e.X, e.Y);


            tvAccTreeMain.SelectedNode = tn;
        }

        private void rcmPrint_Click(object sender, EventArgs e)
        {
            TreeNode SelectedNode = tvAccTreeMain.SelectedNode;

          
           string  iSwid= dtPrepareAccTree.Rows[Convert.ToInt16(SelectedNode.Tag.ToString())]["swid"].ToString();
            TreeNodeAdv parentnode= SearchPrintTree(tvAccTree.Nodes, iSwid);
            tvAccTree.Nodes.Clear();
            PopulateTreeViewPrint(Convert.ToInt32( iSwid), parentnode);
            int itemp = tvAccTree.Width;
          
            tvAccTree.Width = 600;
            tvAccTree.ExpandAll();



            tvAccTree.PrintDocument.HeaderText = dtPrepareAccTree.Rows[Convert.ToInt16(SelectedNode.Tag.ToString())]["acc_name"].ToString();
            tvAccTree.PrintDocument.HeaderAlignment = TextAlignment.Right;

            tvAccTree.PrintDocument.ShowPageNumber = true;

            tvAccTree.PrintDocument.PrintPreview();

            tvAccTree.CollapseAll();
            tvAccTree.Width = itemp;
          //  tvAccTree.PrintDocument.Dispose();
            tvAccTree.PrintDocument = null;

        }
    }
}
