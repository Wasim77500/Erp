using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using Syncfusion.Windows.Forms.Tools;

namespace ERP.File
{
    public partial class frmUsers : MyForm
    {
     
        public frmUsers()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex) {
                glb_function.MsgBox(ex.Message);
            }
          
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {

            if (dtPri.Rows.Count <= 0)
              return;
            btnUpdate.Enabled = false;
            btnUserAccess.Enabled = false;
            FillBranches();

            GetAcc();

            FillTempletTree();

        }

        private void FillTempletTree()
        {



            tvTempletTree.Nodes.Clear();

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTemplet = cnn.GetDataTable("select distinct sub_form,form_type  " +
                    " from TEMPLET_HEADER t");
            foreach (DataRow row in dtTemplet.Rows)
            {
                TreeNodeAdv node = new TreeNodeAdv();
                node.Text = row["sub_form"].ToString();
                tvTempletTree.Nodes.Add(node);
                AddFormNode((string)row["form_type"], node);
            }

        }


        private void AddFormNode(string strform_type, TreeNodeAdv node)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTemplet = cnn.GetDataTable("select distinct t.form_arabic_name,t.form_eng_name " +
                           " from TEMPLET_HEADER t " +
                           " where form_type = '" + strform_type + "'");

            foreach (DataRow row in dtTemplet.Rows)
            {
                TreeNodeAdv childNode = new TreeNodeAdv();
                childNode.Text = row["form_arabic_name"].ToString();
                node.Nodes.Add(childNode);
                AddChildNodes((string)row["form_eng_name"], childNode,strform_type );
            }
        }
        private void AddChildNodes(string strFormName, TreeNodeAdv node,string strFormType)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtTemplet = cnn.GetDataTable("select swid, form_name,multi_form_for_user  " +
                       " from TEMPLET_HEADER t " +
                       " where form_eng_name = '" + strFormName + "' and form_type='"+ strFormType + "'");

            foreach (DataRow row in dtTemplet.Rows)
            {
                TreeNodeAdv childNode = new TreeNodeAdv();
                childNode.Text = row["form_name"].ToString();

                node.Nodes.Add(childNode);
                childNode.ShowCheckBox = true;
                childNode.Tag = row["swid"].ToString();
                childNode.HelpText = "";
                childNode.TagObject = row["multi_form_for_user"].ToString();
                childNode.Checked = false;
            }
        }


        private void GetAcc()
        {
            ConnectionToDB cnn = new ConnectionToDB();

            DataTable dtAccData = cnn.GetDataTable("select swid,acc_no,acc_name,acc_type from accounts where stat='فعال'" );
            lstAccNo.DataSource = dtAccData;
            lstAccNo.DisplayMember = "acc_no";
            lstAccNo.ValueMember = "swid";

            lstAccName.DataSource = dtAccData;
            lstAccName.DisplayMember = "acc_name";
            lstAccName.ValueMember = "swid";
            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
            //lstAccNo.Text = "";
            //lstAccName.Text = "";
        }


        private void FillBranches()
        {
            ConnectionToDB conn = new ConnectionToDB();
            DataTable MyDataTable;
            MyDataTable = conn.GetDataTable("Select  SWID,BRANCH_ANAME From  BRANCHES order by BRANCH_ANAME");
            if (MyDataTable != null)
            {


                lstUSER_BRANCH.DataSource = MyDataTable;


                lstUSER_BRANCH.DisplayMember = "BRANCH_ANAME";
                lstUSER_BRANCH.ValueMember = "SWID";

                lstUSER_BRANCH.SelectedIndex = -1;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtUsers = cnn.GetDataTable("select nvl(max(swid),0)+1 from USERINFO");

            txtSWID.Text = dtUsers.Rows[0][0].ToString();


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add
            ("insert into USERINFO values(" + txtSWID.Text +
            " ,sysdate,'ACTIVE'," + glb_function.glb_strUserId + "" +
                ",'" + txtUSER_LOGIN.Text + "', '" + txtUSER_NAME.Text + "',null" +
                ", '" + new glb_SysFun().Encrypt("123", true) + "','" + txtUSER_NOTE.Text + "'" +
                "," + (lstUSER_BRANCH.SelectedValue == null ? "null" : lstUSER_BRANCH.SelectedValue.ToString()) + "," +
                " '" + lstACCESS_TYPE.Text + "'," + lstDept.SelectedValue.ToString() + ")");


            SaveUserPreventedAcc();
           
            GetTempletToSave();

            if (glb_function.MultiTransData())
            {
                GetData(txtSWID.Text.Trim());

            }







        }
        private void GetTempletToSave()
        {
            foreach (TreeNodeAdv item in tvTempletTree.Nodes)
            {
                if (item.HasChildren==true )
                    SaveTemplet(item);
            }
        }
        private void SaveTemplet(TreeNodeAdv root)
        {

            foreach (TreeNodeAdv ctrl in root.Nodes)
            {
                if (ctrl.HasChildren == true)
                    SaveTemplet(ctrl);
                else
                {
                    if (ctrl.ShowCheckBox == true)
                    {
                        if (ctrl.HelpText =="" && ctrl.Checked == true)
                            glb_function.arrInsertLogs.Add("insert into USER_TEMPLET values ((select nvl(max(swid),0)+1 from USER_TEMPLET)," + glb_function.glb_strUserId + ",sysdate," + txtSWID.Text + "," + ctrl.Tag.ToString() + ")");
                        else if (ctrl.HelpText != "" && ctrl.Checked == false)
                            glb_function.arrInsertLogs.Add("delete from USER_TEMPLET where user_id=" + txtSWID.Text + " and templet_id=" + ctrl.Tag.ToString());
                    }
                }
               
            }
        }

     
        private void FillUserPreventAcc(string strSwid)
        {
            dgUserAccPervented.Rows.Clear();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtUserPreAcc = cnn.GetDataTable("select u.swid,u.acc_id,a.acc_no,a.acc_name from USER_PREVENTED_ACC u,accounts a " +
                                      "  where a.swid = u.acc_id" +
                                      "  and u.user_id = " + strSwid);
            for (int i = 0; i < dtUserPreAcc.Rows.Count; i++)
            {
                dgUserAccPervented.Rows.Add();
                dgUserAccPervented[0, dgUserAccPervented.Rows.Count - 1].Value = dtUserPreAcc.Rows[i]["swid"].ToString();
                dgUserAccPervented[1, dgUserAccPervented.Rows.Count - 1].Value = dtUserPreAcc.Rows[i]["acc_id"].ToString();
                dgUserAccPervented[2, dgUserAccPervented.Rows.Count - 1].Value = dtUserPreAcc.Rows[i]["acc_no"].ToString();
                dgUserAccPervented[3, dgUserAccPervented.Rows.Count - 1].Value = dtUserPreAcc.Rows[i]["acc_name"].ToString();
            }
        }
        private void SaveUserPreventedAcc()
        {
            for (int i = 0; i < dgUserAccPervented.Rows.Count; i++)
            {
                if (dgUserAccPervented[0, i].Value.ToString() == "")
                {
                    glb_function.arrInsertLogs.Add("insert into USER_PREVENTED_ACC values((select nvl(max(swid),0)+1 from USER_PREVENTED_ACC)" +
                          ",sysdate," + glb_function.glb_strUserId + "," + dgUserAccPervented[1, i].Value.ToString() + "," + txtSWID.Text + ")");
                }
            }
        }



        private void GetData(string strPk)
        {

            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtLocation = cnn.GetDataTable("select * from USERINFO where swid=" + strPk);

            txtUSER_LOGIN.Text = dtLocation.Rows[0]["USER_LOGIN"].ToString();
            txtUSER_LOGIN.W_OldValue = dtLocation.Rows[0]["USER_LOGIN"].ToString();

            txtUSER_NAME.Text = dtLocation.Rows[0]["USER_NAME"].ToString();
            txtUSER_NAME.W_OldValue = dtLocation.Rows[0]["USER_NAME"].ToString();

            txtUSER_NOTE.Text = dtLocation.Rows[0]["USER_NOTE"].ToString();
            txtUSER_NOTE.W_OldValue = dtLocation.Rows[0]["USER_NOTE"].ToString();



            lstUSER_BRANCH.SelectedValue = (dtLocation.Rows[0]["USER_BRANCH"].ToString().Trim() == "" ? -1 : Convert.ToInt16(dtLocation.Rows[0]["USER_BRANCH"].ToString()));
            lstUSER_BRANCH.W_OldValue = (dtLocation.Rows[0]["USER_BRANCH"].ToString());
            lstDept.SelectedValue = (dtLocation.Rows[0]["DEPT_ID"].ToString().Trim() == "" ? -1 : Convert.ToInt16(dtLocation.Rows[0]["DEPT_ID"].ToString()));
            lstDept.W_OldValue = (dtLocation.Rows[0]["DEPT_ID"].ToString());


            lstACCESS_TYPE.Text = dtLocation.Rows[0]["ACCESS_TYPE"].ToString();
            lstACCESS_TYPE.W_OldValue = dtLocation.Rows[0]["ACCESS_TYPE"].ToString();

           
            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
           if (HasPrivilege("btnUpdate"))
            {
                btnUpdate.Enabled = true;
                btnUserAccess.Enabled = true;
            }

            txtPassword.Text = "123";
        }
        private bool CheckEntries()
        {

            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;

            if (txtUSER_LOGIN.Text == "")
            {

                errCheck.SetError(txtUSER_LOGIN, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtUSER_LOGIN, "");
            }

            if (txtUSER_NAME.Text == "")
            {

                errCheck.SetError(txtUSER_NAME, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtUSER_NAME, "");
            }


            if (lstUSER_BRANCH.SelectedIndex == -1)
            {

                errCheck.SetError(lstUSER_BRANCH, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstUSER_BRANCH, "");
            }

            if (lstDept.SelectedIndex == -1)
            {

                errCheck.SetError(lstDept, "الرجاء اختيار القسم");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstDept, "");
            }


            if (lstACCESS_TYPE.Text == "")
            {

                errCheck.SetError(lstACCESS_TYPE, "حقل مطلوب");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstACCESS_TYPE, "");
            }

            if (iError == 1)
                return false;

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;
            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update USERINFO set " +
                " USER_LOGIN='" + txtUSER_LOGIN.Text + "', USER_NAME='" + txtUSER_NAME.Text + "'" +
                ",USER_NOTE='" + txtUSER_NOTE.Text + "'" +
                ",USER_BRANCH=" + (lstUSER_BRANCH.SelectedValue == null ? "null" : lstUSER_BRANCH.SelectedValue.ToString()) + ",ACCESS_TYPE='" + lstACCESS_TYPE.Text + "' ,DEPT_ID=" + lstDept.SelectedValue.ToString() +
               "  where swid=" + txtSWID.Text);



            new glb_function().InsertToLogs(this, "USERINFO", txtSWID.Text, "");
            //other table 

            SaveUserPreventedAcc();

           
            GetTempletToSave();
            if (glb_function.MultiTransData())
            {
                GetData(txtSWID.Text);

                FillUserPreventAcc(txtSWID.Text.Trim());
               

            }


        }
      
        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            btnUpdate.Enabled = false;
            btnUserAccess.Enabled = false;
            btnNew.Visible = false;
            btnSave.Visible = true;
            txtPassword.Text = "123";
            FillUserPreventAcc("0");
          
            FillTempletTree();
        }

        private void myPanal1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strWhereBranch = "";

            if (lstTempBranch.Text == "1000")
                strWhereBranch = " ";
            else if (lstTempBranch.Text == "2000")
                strWhereBranch = " and user_branch="+glb_function.glb_BranchNo;
            else if(lstTempBranch.Text!="")
                strWhereBranch = " and user_branch = "+lstTempBranch.Text ;
            else
            {
                glb_function.MsgBox("النموذج غير مرتبط بالفرع."+"\n"+"ستظهر البيانات بناء على فرع المستخدم");
                strWhereBranch = " and user_branch=" + glb_function.glb_BranchNo;
            }

                frmFindUsers frm = new frmFindUsers();
            frm.strWhere = strWhereBranch;
            frm.ShowDialog();

            if (frm.strUserId != "")
            {

                txtSWID.Text = frm.strUserId;
                GetData(txtSWID.Text);

                FillUserPreventAcc(txtSWID.Text.Trim());
              
                FillUserTemplet();
            }
        }

        private void FillUserTemplet()
        {
            FillTempletTree();
            ConnectionToDB cnn = new ConnectionToDB();
            //DataTable dtUserTemp = cnn.GetDataTable("select user_id,templet_id,h.multi_form_for_user from USER_TEMPLET t,templet_header h " +
            //                    " where t.templet_id=h.swid and  t.user_id =" + txtSWID.Text );

            DataTable dtUserTemp = cnn.GetDataTable("select h.swid,user_id,templet_id,h.multi_form_for_user" +
                       " from templet_header h "+
                        "   left outer JOIN  USER_TEMPLET t on(t.templet_id = h.swid and  t.user_id = "+txtSWID.Text+")");


            for (int i = 0; i < dtUserTemp.Rows.Count; i++)
            {
                foreach (TreeNodeAdv item in tvTempletTree.Nodes)
                {
                   
                        if (item.HasChildren == true)
                            GetTemplet(item, dtUserTemp.Rows[i]["swid"].ToString(), dtUserTemp.Rows[i]["templet_id"].ToString(), dtUserTemp.Rows[i]["multi_form_for_user"].ToString());
                   
                  
                }
            }


        }
        private void GetTemplet(TreeNodeAdv root,string strTempSwid,string strTempid,string strMulti_form_for_user)
        {
            foreach (TreeNodeAdv ctrl in root.Nodes )
            {

                if (ctrl.HasChildren == true)
                    GetTemplet(ctrl, strTempSwid, strTempid, strMulti_form_for_user);
                else
                {
                    if (ctrl.ShowCheckBox == true)
                    {
                      
                        if (ctrl.Tag.ToString() == strTempSwid)
                        {
                            if(ctrl.Tag.ToString()== strTempid)
                            {
                                ctrl.Checked = true;
                                ctrl.HelpText = ctrl.Checked.ToString();
                            }
                           
                            ctrl.TagObject = strMulti_form_for_user;
                        }
                      

                    }
                }
               
            }
        }

        

        private void btnUserAccess_Click(object sender, EventArgs e)
        {
            if (lstACCESS_TYPE.Text != "جزء")
            {
                glb_function.MsgBox("لايتم التحديد الا اذا كان الوصول جزئي");
                return;
            }

            frmUserComputers frm = new frmUserComputers();
            frm.txtSWID.Text = txtSWID.Text;
            frm.txtUSER_LOGIN.Text = txtUSER_LOGIN.Text;
            frm.txtUSER_NAME.Text = txtUSER_NAME.Text;
            
            frm.ShowDialog();
        }

        private void myDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (glb_function.MsgBox("هل انت متاكد من حذف الحساب؟", "", true) == false)
                    return;

                //delete acc from UserPreventAcc table
                if(dgUserAccPervented[0,e.RowIndex ].Value .ToString()=="")
                {
                    dgUserAccPervented.Rows.Remove(dgUserAccPervented.Rows[e.RowIndex]);
                    return;
                }
                ConnectionToDB cnn = new ConnectionToDB();
                int icheck = cnn.TranDataToDB("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                            "," + glb_function.glb_strUserId  + ",sysdate," + dgUserAccPervented[0,e.RowIndex].Value.ToString() + ",'USER_PREVENTED_ACC','ACC_ID:USER_ID','رقم الحساب ورقم المستخدم','" + dgUserAccPervented[1,e.RowIndex].Value.ToString() +":"+txtSWID.Text  + "',null,'تم حذف الصف بالكامل')");

                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطا عند عملية حذف الحساب");
                    return;
                }
                icheck = cnn.TranDataToDB("delete from USER_PREVENTED_ACC where swid =" + dgUserAccPervented[0, e.RowIndex].ToString());
               
                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطا عند عملية حذف الحساب");
                    cnn.glb_RollbackTransaction();
                    return;
                }
                cnn.glb_commitTransaction();
                glb_function.MsgBox("تمت العملية بنجاح");
                dgUserAccPervented.Rows.Remove(dgUserAccPervented.Rows[e.RowIndex]);


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckAccPreventedEentries())
                return;

            dgUserAccPervented.Rows.Add();
            dgUserAccPervented[0,dgUserAccPervented.Rows.Count -1].Value ="";
            dgUserAccPervented[1, dgUserAccPervented.Rows.Count - 1].Value = lstAccNo.SelectedValue.ToString() ;
            dgUserAccPervented[2, dgUserAccPervented.Rows.Count - 1].Value = lstAccNo.Text ;
            dgUserAccPervented[3, dgUserAccPervented.Rows.Count - 1].Value = lstAccName.Text ;



        }

        private bool CheckAccPreventedEentries()
        {
            int iError = 0;
            if (lstAccNo.SelectedIndex == -1)
            {

                errCheck.SetError(lstAccNo, "يجب ادخال رقم الحساب ");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstAccNo, "");
            }

            if (lstAccName.SelectedIndex == -1)
            {

                errCheck.SetError(lstAccName, "يجب ادخال اسم الحساب ");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstAccName, "");
            }

            //2**********************************************
            //فحص هل اسم الحساب لديه نفس رقم تعريف رقم الحساب
            //فقط للتاكيد
            if (lstAccNo.SelectedValue == lstAccName.SelectedValue)
            {
                glb_function.MsgBox("الرجاء التاكد ان رقم الحساب يطابقة اسم الحساب");
                return false;
            }
            //2 End****************************************************

            for (int i = 0; i < dgUserAccPervented.Rows.Count; i++)
            {
                if (dgUserAccPervented[1, i].Value.ToString() == lstAccNo.SelectedValue.ToString())
                {
                    glb_function.MsgBox("رقم الحساب المحدد مدخل من قبل");
                    return false;
                }
            }

            if (iError == 1)
                return false;


            return true;
        }

        private void frmFindAccount_Click(object sender, EventArgs e)
        {
            Accounts. frmFindAccount frm = new Accounts.frmFindAccount();
            frm.strWhere = " where a.stat='فعال' " ;
            frm.strSelect = "select  a.swid,acc_no,acc_name,acc_type,a.acc_class from accounts a  ";
            frm.ShowDialog();
            if (frm.strAccid != "")
            {
                lstAccName.SelectedValue = Convert.ToInt16(frm.strAccid);
            }
            else
            {
                lstAccNo.Text = "";
                lstAccName.Text = "";
                lstAccNo.SelectedIndex = -1;
                lstAccName.SelectedIndex = -1;
            }
        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {

                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;
              
            }
        }

        private void ckbCenterAcc_CheckStateChanged(object sender, EventArgs e)
        {
            GetAcc();
        }

        private void lstUSER_BRANCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUSER_BRANCH.SelectedValue == null)
            {
                lstDept.DataSource = null;
                return;
            }
               



            if (lstUSER_BRANCH.SelectedValue.ToString() != "System.Data.DataRowView" && lstUSER_BRANCH.SelectedValue.ToString() != "")
            {
              
                FillDepartements();

            }
            else
            {
                lstDept.DataSource = null;
            }


        }
        private void FillDepartements()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtDept = cnn.GetDataTable("select d.swid,d.dept_aname from departements d " +
                                " where d.branch_id =  " + lstUSER_BRANCH.SelectedValue.ToString());

            lstDept.DataSource = dtDept;
            lstDept.ValueMember = "swid";
            lstDept.DisplayMember = "dept_aname";

            lstDept.SelectedIndex = -1;
        }
       
       
      
       
        private void tvTempletTree_AfterCheck(object sender, TreeNodeAdvEventArgs e)
        {
            if(e.Node.TagObject!=null)
            if(e.Node.Checked && e.Node.TagObject.ToString()=="0")
            {
                foreach (TreeNodeAdv ctrl in e.Node.Parent.Nodes)
                {
                    if (e.Node.Text != ctrl.Text)
                        ctrl.Checked = false;
                }
            }
        }
        int icheckFind = 0;
        private void  btnGetNode_Click(object sender, EventArgs e)
        {
           
            tvTempletTree.CollapseAll();
           
             SearchTree(tvTempletTree .Nodes, txtNodeName.Text );

            if (icheckFind  == 0)
                glb_function.MsgBox("لم يتم العثور على اسم مطابق");


            icheckFind = 0;
        }

      

        private  TreeNodeAdv SearchTree(TreeNodeAdvCollection nodes, string searchtext)
        {
            foreach (TreeNodeAdv node in nodes)
            {

                //if (node.Text == searchtext)
                if (node.Text.Contains(searchtext))
                {


                    node.TextColor = System.Drawing.Color.Red;


                    tvTempletTree.SelectedNode = node;
                    icheckFind++;

                    // return node;

                }
                else
                    node.TextColor = System.Drawing.Color.Black ;
                SearchTree(node.Nodes, searchtext);
            }

            return null;
        }

        private void txtNodeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnGetNode_Click(null, null);
        }

        private void lstUserCnnBranchs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            int icheck = cnn.TranDataToDB("update USERINFO set USER_PASSWORD ='"+new glb_SysFun().Encrypt("123",true)+"' where swid="+txtSWID.Text );
            if(icheck<=0)
            {

                glb_function.MsgBox("حدث خطأ عند تعيين كلمة السر");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تم تغيير كلمة السر للمستخدم للقيمة الافتراضية" +"\n"+"القيمة الافتراضية : 123");
        }
    }
}
