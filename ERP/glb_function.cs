using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Globalization;

namespace ERP
{

    public class glb_function
    {
        

        public  static ArrayList arrInsertLogs;

        //when program statr
        public static string glb_strUserId="" ;
        public static string glb_strUserName ="";
        public static string glb_strUserLogin = "";
        public static string glb_BranchName = "";
        public static int glb_BranchNo;
        public static short glb_deptId;
        public static string glb_DeptName;
        public static bool AcceptTrans = false;
        public static int glb_MainCurrencyId;
        public static string glbMainCurrencyName="";
        public static string glbFrictionDiffAccId = "";
        public static int glbMainDecimalPoint;
        public static DateTime dtSysdate;


        //**************************
        public static string glbServerNameUrl = "http://192.168.1.249:7070/erp/";
      // public static string glbServerNameUrl = "http://192.168.0.3:7070/erp/";
        public enum ProgramType { none = 0, File, Account, Inventory, Sales, Purchase, Charities };
       

        internal static bool blMsg;
      

        public static  string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }



        #region chat
       
      
        public  string name;

      
      

      

        #endregion


       
        public static void FillList(ref myList lstRequired, string strTable, string strCol)
        {
            ConnectionToDB conn = new ConnectionToDB();
            DataTable MyDataTable;
            //myList lstBranch = new myList();
            MyDataTable = conn.GetDataTable("Select  distinct "+strCol +" From  "+strTable +"  order by 1");
            if (MyDataTable != null)
            {


                lstRequired.DataSource = MyDataTable;


                lstRequired.DisplayMember = strCol ;

                lstRequired.SelectedIndex = -1;


            }
        }
        public static void   FillListWithId(ref myList lstBranch, string strTable, string strCol)
        {

            ConnectionToDB conn = new ConnectionToDB();
            DataTable MyDataTable;
            //myList lstBranch = new myList();
            MyDataTable = conn.GetDataTable("Select  SWID,"+ strCol + " From  "+ strTable + "  order by "+ strCol + "");
            if (MyDataTable != null)
            {


                lstBranch.DataSource = MyDataTable;

                lstBranch.ValueMember = "SWID";
                lstBranch.DisplayMember = strCol;
               
                lstBranch.SelectedIndex = -1;


            }

           
        }
        public static void OpenForm(Form Parent,MyForm frm, bool isDialog)
        {
            if (isDialog)
                frm.ShowDialog();
            else
            {
                MyForm f = new MyForm();
                f = (MyForm)Application.OpenForms[frm.Name];
                if (f != null)
                    f.BringToFront();
                else
                {
                    //frm f1 = new frmChangePassword();
                    frm.Show(Parent);
                }
            }
           
        }

        public void clearItems(Control myControl)
    {

        try
        {
            foreach (Control ctrl in myControl.Controls)
            {




                if (ctrl.GetType() == typeof(TextBox)  )
                {
                    ((TextBox)ctrl).Text = "";

                }
                else if (ctrl.GetType() == typeof(myText ) && ((myText)ctrl).W_Clear==true)
                {
                    ((myText )ctrl).Text = "";

                }
                else if (ctrl.GetType() == typeof(NumericUpDown) )
                {
                        if (((NumericUpDown)ctrl).Minimum >= 0)
                            ((NumericUpDown)ctrl).Value = ((NumericUpDown)ctrl).Minimum;
                        else
                            ((NumericUpDown)ctrl).Value = 0;

                    }
                else if (ctrl.GetType() == typeof(myNumber) && ((myNumber)ctrl).W_Clear == true)
                    {
                        if(((myNumber)ctrl).MinValue>=0)
                            ((myNumber)ctrl).Value =(decimal) ((myNumber)ctrl).MinValue;
                        else

                        ((myNumber)ctrl).Value = 0;
                    }
                   

                else if (ctrl.GetType() == typeof(myList) && ((myList)ctrl).W_Clear == true)
                {
                    ((myList)ctrl).SelectedIndex = -1;
                     
                    ((myList)ctrl).Text = "";

                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                    ((ComboBox)ctrl).Text = "";

                }
                else if (ctrl.GetType() == typeof(myDate ) && ((myDate)ctrl).W_Clear == true)
                {
                    ((myDate )ctrl).Value = DateTime.Now;

                }
                    else if (ctrl.GetType() == typeof(mycheck ) && ((mycheck)ctrl).W_Clear == true)
                    {
                        ((mycheck)ctrl).Checked = false;
                    }
                    else if (ctrl.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;

                }
                else if (ctrl.GetType() == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)ctrl).Text = "";
                }
                else if (ctrl.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                else if (ctrl.GetType() == typeof(DataGridView))
                {
                    if (((DataGridView)ctrl) != null)
                    {
                        if (((DataGridView)ctrl).DataSource == null)
                            ((DataGridView)ctrl).Rows.Clear();
                        else
                            ((DataGridView)ctrl).DataSource = null;
                    }
                }
                else if (ctrl.GetType() == typeof(myDataGrid) && ((myDataGrid)ctrl).W_Clear == true)
                {
                    if (((myDataGrid)ctrl) != null)
                    {
                        if (((myDataGrid)ctrl).DataSource == null)
                            ((myDataGrid)ctrl).Rows.Clear();
                        else
                            ((myDataGrid)ctrl).DataSource = null;
                    }
                }
                //else if (ctrl.GetType() == typeof(PictureBox))
                //{
                //    ((PictureBox)ctrl).Image = null;
                //}
                else
                    clearItems(ctrl);


            }


        }// main foreach


        catch (Exception ex)
        {
           
            MessageBox.Show(ex.ToString());
        }
    }//end clearItems

        public void InsertToLogs(Control myControl,string strTable,string rid,string strNote)
        {
          
            
            foreach (Control ctrl in myControl.Controls)
            {
                if (ctrl.GetType() == typeof(myText))
                {
                   if(((myText )ctrl).W_TableName ==strTable )
                    if (((myText)ctrl).Text.Trim() != ((myText)ctrl).W_OldValue.Trim())
                    {

                            arrInsertLogs .Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                            ","+glb_strUserId+",sysdate,"+rid +",'"+strTable +"','"+ ((myText)ctrl) .W_ColEgName + "','" + ((myText)ctrl).W_ColArName + "','" + ((myText)ctrl) .W_OldValue.Trim()+ "','" + ((myText)ctrl) .Text .Trim ()+ "','"+ strNote + "')");

                            
                    }
                }
                else if (ctrl.GetType() == typeof(myNumber ))
                {
                    if (((myNumber)ctrl).W_TableName == strTable)
                        if (((myNumber)ctrl).Value.ToString() != ((myNumber)ctrl).W_OldValue.Trim())
                        {

                            arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                            "," + glb_strUserId + ",sysdate," + rid + ",'" + strTable + "','" + ((myNumber)ctrl).W_ColEgName + "','" + ((myNumber)ctrl).W_ColArName + "','" + ((myNumber)ctrl).W_OldValue.Trim() + "','" + ((myNumber)ctrl).Value.ToString() + "','"+strNote +"')");


                        }
                }

                else if (ctrl.GetType() == typeof(myList ))
                {
                    if (((myList)ctrl).W_TableName == strTable)

                        if (((myList)ctrl).w_ValueType.ToString() == "TEXT")
                        {
                            if (((myList)ctrl).Text.ToString() != ((myList)ctrl).W_OldValue.Trim())
                                arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                                "," + glb_strUserId + ",sysdate," + rid + ",'" + strTable + "','" + ((myList)ctrl).W_ColEgName + "','" + ((myList)ctrl).W_ColArName + "','" + ((myList)ctrl).W_OldValue.Trim() + "','" + ((myList)ctrl).Text.ToString() + "','"+strNote +"')");

                        }
                        else
                        {
                            string strValue = (((myList)ctrl).SelectedValue == null ? "" : ((myList)ctrl).SelectedValue.ToString());
                            if (strValue != ((myList)ctrl).W_OldValue.Trim())
                                arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                                "," + glb_strUserId + ",sysdate," + rid + ",'" + strTable + "','" + ((myList)ctrl).W_ColEgName + "','" + ((myList)ctrl).W_ColArName + "','" + ((myList)ctrl).W_OldValue.Trim() + "','" + strValue + "','" + strNote + "')");
                        }




                }
                else if (ctrl.GetType() == typeof(myDate ))
                {
                    if (((myDate)ctrl).W_TableName == strTable)
                        if (((myDate)ctrl).Value.ToString("dd/MM/yyyy") != ((myDate)ctrl).W_OldValue.Trim())
                        {

                            arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                            "," + glb_strUserId + ",sysdate," + rid + ",'" + strTable + "','" + ((myDate)ctrl).W_ColEgName + "','" + ((myDate)ctrl).W_ColArName + "','" + ((myDate)ctrl).W_OldValue.Trim() + "','" + ((myDate)ctrl).Value.ToString("dd/MM/yyyy") + "','" + strNote + "')");


                        }
                }
                else if (ctrl.GetType() == typeof(mycheck ))
                {
                
                    if (((mycheck)ctrl).W_TableName == strTable)
                        if ( ( ((mycheck)ctrl).Checked==true ?"1":"0" )!= ((mycheck)ctrl).W_OldValue.Trim())
                        {

                            arrInsertLogs.Add("insert into logs values((select nvl(max(swid),0)+1 from logs)" +
                            "," + glb_strUserId + ",sysdate," + rid + ",'" + strTable + "','" + ((mycheck)ctrl).W_ColEgName + "','" + ((mycheck)ctrl).W_ColArName + "','" + ((mycheck)ctrl).W_OldValue.Trim() + "','" + (((mycheck)ctrl).Checked == true ? "1" : "0") + "','" + strNote + "')");


                        }
                }
                else
                    InsertToLogs(ctrl, strTable, rid ,strNote );

            }
          }
        public static  void MsgBox(string strMsg)
          {
              frmMsg frm = new frmMsg();
              frm.lblMsg.Text  = strMsg;
              frm.Text = "Massage";
              frm.btnOk.Visible = true;
              frm.ShowDialog();
              frm.Dispose();

          }
        public static void MsgBox(string strMsg, string strTitle)
          {
              frmMsg frm = new frmMsg();
              frm.lblMsg.Text = strMsg;
              frm.Text = strTitle;
              frm.btnOk.Visible = true;
              frm.ShowDialog();
              frm.Dispose();

          }

        public static bool MsgBox(string strMsg, string strTitle, bool blDialog)
          {
              frmMsg frm = new frmMsg();
              frm.lblMsg.Text = strMsg;
              frm.Text = strTitle;
              frm.btnYes.Visible = true;
              frm.btnNO.Visible = true;
              frm.ShowDialog();
              frm.Dispose();

              return blMsg ;

          }

        public static string  GetSelectHash(string strStat)
        {
            strStat=strStat.Replace("'", "''");
            ConnectionToDB cnnHash = new ConnectionToDB();
            DataTable dtHash = cnnHash.GetDataTable("select dbms_sqlhash.getHash('"+strStat +"', 1) from dual");
            string strHash = BitConverter.ToString((byte[])dtHash.Rows[0][0]).Replace("-", string.Empty);
            return strHash;
        }
       

        public static string GetProcessorId()
        {
            string processorId = string.Empty;

         ManagementClass processorManagement = new ManagementClass("Win32_Processor");

            foreach (var processor in processorManagement.GetInstances())

            {
                
                    processorId = processor["ProcessorId"].ToString();
 
            }


            return processorId;
        }

        public static DateTime  StringToDate(string strDate)
        {
            if (strDate.Length > 10)
                strDate = strDate.Substring(0, 10);

            string[] allFormats ={"yyyy/MM/dd","yyyy/M/d",
            "dd/MM/yyyy","d/M/yyyy",
            "dd/M/yyyy","d/MM/yyyy","yyyy-MM-dd",
            "yyyy-M-d","dd-MM-yyyy","d-M-yyyy",
            "dd-M-yyyy","d-MM-yyyy","yyyy MM dd",
            "yyyy M d","dd MM yyyy","d M yyyy",
            "dd M yyyy","d MM yyyy","dd-MMM-yyyy","dd-MMM-yy"};
            //CultureInfo arCul;
            CultureInfo enCul;
            //arCul = new CultureInfo("ar-SA");
            enCul = new CultureInfo("en-US");
            DateTime tempDate = DateTime.ParseExact(strDate, allFormats, enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
            return tempDate;
            //return tempDate.ToString("yyyyMMdd", arCul.DateTimeFormat);
        }


        public static bool MultiTransData()
        {
            if (arrInsertLogs.Count == 0)
            {
                MsgBox("Error saving MultiTransData");
                return false ;
            }

            int iTransCount = arrInsertLogs.Count;
            ConnectionToDB cnn = new ConnectionToDB();
            ConnectionToDB.objCmd = new Oracle.ManagedDataAccess.Client.OracleCommand();


            string strResult = "";
            DataTable dt = new DataTable();
          
            dt.Columns.Add("sqlstcol");

            foreach (var item in glb_function.arrInsertLogs)
            {
                DataRow dRow = dt.NewRow();
                string str = item.ToString();

                dRow[0] = str;

                dt.Rows.Add(dRow);
            }
           


                dt.TableName = "sqlsttab";
                System.IO.StringWriter writer = new System.IO.StringWriter();
                dt.WriteXml(writer);
                string strDataAsXML = writer.ToString();
          

           
            string str1 = strDataAsXML.Length.ToString();

                ConnectionToDB.objCmd.Parameters.Add("mytab", Oracle.ManagedDataAccess.Client.OracleDbType.Clob).Value = strDataAsXML;

                ConnectionToDB.objCmd.Parameters.Add("ExcutSqlStCout", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
                strResult = cnn.ExecutePro("GeneralTrans.ExcuteSqlSt", "ExcutSqlStCout");



                 arrInsertLogs.Clear();
                if ( iTransCount.ToString()==strResult.Trim() )
                {
                    cnn.glb_commitTransaction();
                    glb_function.MsgBox("تمت العملية بنجاح");

                return true;
                }
                else
                {

                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء العملية");
                     return false;
                }

          

        }

        public static decimal Exchanging(decimal dValue,int iSourceCurrId,int iDestinationCurrId)
        {
            //تستخدم في المصارفة بين العملات
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtcurr = cnn.GetDataTable("select e.curr_price from currency c,currency_exchange e " +
                                   " where e.curr_id = c.swid and c.swid = "+ iSourceCurrId.ToString() + 
                         " and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");
            if (dtcurr == null || dtcurr.Rows.Count <= 0)
            {
                glb_function.MsgBox("لايوجد سعر صرف للعملة " + "\n" + "سيتم اقفال الشاشة");
                Application.Exit();
            }
            decimal dSourceValueInMainCurr = Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString()) * dValue;
         

            dtcurr.Rows.Clear();
            dtcurr = cnn.GetDataTable("select e.curr_price from currency c,currency_exchange e " +
                           "  where e.curr_id = c.swid and c.swid = "+ iDestinationCurrId + 
                 "  and e.swid = (select max(x.swid) from currency_exchange x where x.curr_id = c.swid)  ");
            if (dtcurr == null || dtcurr.Rows.Count <= 0)
            {
                glb_function.MsgBox("لايوجد سعر صرف للعملة" + "\n" + "سيتم اقفال الشاشة");
                Application.Exit();
            }

            decimal dValueInDestinationCurr = dSourceValueInMainCurr / Convert.ToDecimal(dtcurr.Rows[0]["curr_price"].ToString());
          


            return dValueInDestinationCurr;
        }
        
        public static decimal GetAccBalance(string Currid,string accId)
        {
            //تستخدم لمعرفة رصيد حساب معين
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetAcc = cnn.GetDataTable("select nvl( sum(jd.jour_value),0) from journal_header jh join journal_details jd on(jh.swid=jd.jour_id) " +
                           " where jd.curr_id =" + Currid +
                           " and jd.acc_id = " + accId + " and jd.stat <> 'ملغي' and jh.stat <> 'ملغي'" );
            decimal balance = 0;
            if (dtGetAcc == null || dtGetAcc.Rows.Count <= 0)
                balance = 0;
            else
                balance = Convert.ToDecimal(dtGetAcc.Rows[0][0].ToString());

            return balance;
        }

        public static  string GetListFromMultList(string strListAsString)
        {
            string strMult = strListAsString.Trim();
            string iindexx = "";
            string strInStat = "";
            while (strMult != "")
            {


                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                // lstBranchHeader.Items.Add(iindexx);
                strInStat = (strInStat == "" ? "'" + iindexx + "'" : strInStat + ",'" + iindexx + "'");


            }

            return strInStat;
        }

       
    }

}
