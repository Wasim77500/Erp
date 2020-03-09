
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ERP
{
  public  class ConnectionToDB
    {
        //string strConnectionMoreAddress = "Data Source=(DESCRIPTION="
        //    + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.11)(PORT=1521))" +
        //    "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=elaghil.dyndns.org)(PORT=1521))" +
        //    ")"
        //    + "(CONNECT_DATA=(SERVICE_NAME=etcobrnh)));"
        //    + "User Id=etcois;Password=elaghil;";


   public static OracleConnection glb_cnn = new OracleConnection("data source = 192.168.1.249:1521/orcl ;user id = ammar ; password=123");


    //public static OracleConnection glb_cnn = new OracleConnection("data source = localhost:1521/orclw ;user id = ammar ; password=123");

        public static OracleCommand comm;
        public static OracleTransaction trns;
        public static bool isTrns = false;
        //for procedure 
        public static OracleCommand objCmd;

        public  DataTable GetDataTable(string SqlSt)
        {
           // OleDbCommand MyComm = new OleDbCommand(SqlSt, glb_cnn);
            if (isTrns == true)
            {
                comm.CommandText = SqlSt;
            }
            else
            {
                comm = new OracleCommand(SqlSt, glb_cnn);
            }


          
            OracleDataReader MyDatareadre = null;
            DataTable MyTable = new DataTable();
            DataRow MyDataRow = null;
            int ColsCount = 0;

            try
            {
                if (glb_cnn.State == System.Data.ConnectionState.Closed)
                    glb_cnn.Open();


                MyDatareadre = comm.ExecuteReader();


                for (ColsCount = 0; ColsCount < MyDatareadre.FieldCount; ColsCount++)
                {
                    //if (MyDatareadre.GetFieldType(ColsCount).ToString() == "System.Decimal")
                    //    MyTable.Columns.Add(MyDatareadre.GetName(ColsCount), typeof(System.String ));
                    //else
                    MyTable.Columns.Add(MyDatareadre.GetName(ColsCount), MyDatareadre.GetFieldType(ColsCount));
                }
                while (MyDatareadre.Read())
                {

                    MyDataRow = MyTable.NewRow();
                    for (ColsCount = 0; ColsCount < MyDatareadre.FieldCount; ColsCount++)
                    {
                        try
                        {
                            if (MyDatareadre.GetFieldType(ColsCount).ToString() == "System.Decimal")
                            {
                                if (MyDatareadre.IsDBNull(ColsCount))
                                    MyDataRow[ColsCount] = DBNull.Value;
                                else
                                    MyDataRow[ColsCount] = MyDatareadre.GetDouble(ColsCount);
                            }
                               // MyDataRow[ColsCount] = MyDatareadre.GetOracleValue  (ColsCount).ToString();
                         
                            else
                                MyDataRow[ColsCount] = MyDatareadre.GetValue(ColsCount);
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms. MessageBox.Show(ColsCount + ":" + ex.Message + "\n" + MyDatareadre.GetFieldType(ColsCount));
                        }

                    }
                    MyTable.Rows.Add(MyDataRow);
                }


                if (MyDatareadre != null)
                {
                    if (MyDatareadre.IsClosed)
                        MyDatareadre.Close();
                }

                MyDatareadre.Close();
                MyDatareadre.Dispose();
                return MyTable;
            }
            catch (Exception ErrGetData)
            {
                System.Windows.Forms.MessageBox.Show(ErrGetData.Source + Convert.ToChar(13) + ErrGetData.Message, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error );
                return null;

            }

        }
     
        public int TranDataToDB(string SqlSt)
        {
            try
            {

                if (glb_cnn.State == ConnectionState.Closed)
                    glb_cnn.Open();

               

                if (isTrns == false)
                {
                    comm = new OracleCommand(SqlSt, glb_cnn);
                    trns =  glb_cnn.BeginTransaction();
                    comm.Transaction = trns;
                   
                    isTrns = true;
                }
                else
                    comm.CommandText = SqlSt;

                comm.CommandType = CommandType.Text;
                return (comm.ExecuteNonQuery());
            }
            catch (Exception ErrGetData)
            {
                string str = SqlSt;
                System.Windows.Forms.MessageBox.Show(ErrGetData.Source + Convert.ToChar(13) + ErrGetData.Message, "Error", MessageBoxButtons.OK  , MessageBoxIcon.Error  );
                return -1;
            }
        }

        public void glb_commitTransaction()
        {
            trns.Commit();
            isTrns = false;

        }

        public void glb_RollbackTransaction()
        {
            trns.Rollback();
            isTrns = false;

        }

        public string  ExecutePro(string ProName,string strResult)
        {
             
          //  OleDbConnection objCnn = new OleDbConnection("Provider=MSDAORA;Data Source=dev;User ID=etcois;password=elaghil");
            objCmd.Connection = glb_cnn;
            objCmd.CommandText = ProName;
            objCmd.CommandType = CommandType.StoredProcedure;


            try
            {
                if (isTrns == false)
                {
                   // objCmd = new OleDbCommand(ProName, glb_cnn);
                    if (glb_cnn.State == ConnectionState.Closed)
                        glb_cnn.Open();

                    trns = glb_cnn.BeginTransaction();
                    objCmd.Transaction = trns;
                    
                   
                    isTrns = true;
                    objCmd.ExecuteNonQuery();

                   
                    return objCmd.Parameters[strResult].Value.ToString();
                }
                else
                {
                  
                    objCmd.ExecuteNonQuery();
                   
                    return objCmd.Parameters[strResult].Value.ToString();
                   
                }
            }

            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Source + Convert.ToChar(13) + ex.Message, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error );
               // glb_cnn.Close();
                return "";
            }
            
        }
        public void ExecutePro(string ProName)
        {

           // objCmd.Connection = glb_cnn;
            objCmd.Connection = glb_cnn;
            objCmd.CommandText = ProName;
            objCmd.CommandType = CommandType.StoredProcedure;

            try
            {

                glb_cnn.Open();

                objCmd.ExecuteNonQuery();
                glb_cnn.Close();
               

            }

            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Exception: {0}", ex.ToString());
                glb_cnn.Close();
                
            }

        }
    }
}
