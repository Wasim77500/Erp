using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form1 : MyForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
            lblTemplet.Visible = true;
            lstTemplet.Visible = true;
            lblTemplet.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Side;
            for (int i = 1; i <= 100; i++)
            {
                myDataGrid1.Rows.Add();
                myDataGrid1[0, i-1].Value = i ;
                myDataGrid1[1, i-1].Value = "column" + (i );
                myDataGrid1[2, i-1].Value = "data" + (i);
            }
        }
        Rectangle RECT;
        DataGridViewCell abc;
        private void myDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            myDataGrid myPostion = new myDataGrid();
            myPostion = myDataGrid1;

            myPostion.RightToLeft = RightToLeft.No;
            abc = myPostion.CurrentCell;

            RECT = myPostion.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);

            myPostion.RightToLeft = RightToLeft.Yes;



            nmbEditor.Tag = e.RowIndex.ToString();
            nmbEditor.W_ColEgName = myDataGrid1.Columns[e.ColumnIndex].Name;

            //nmbEditor.Value = Convert.ToDecimal((myDataGrid1[e.ColumnIndex, e.RowIndex].Value.ToString() == "" ? "0" : myDataGrid1[e.ColumnIndex, e.RowIndex].Value.ToString()));

           



            CtlLocation(RECT, nmbEditor);
        }
        private void CtlLocation(Rectangle rect, Control ctrl)
        {
            //ctrl.Location = rect.Location;
            // ctrl.Size = rect.Size;
            ctrl.Top = myDataGrid1.Location.Y + rect.Y;
            ctrl.Left = myDataGrid1.Location.X + rect.X;
            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;
            ctrl.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (row.Cells[1].Value.ToString().Equals(txtSearch.Text ))
            //{
            //    rowIndex = row.Index;
            //    dgvSearchResults.ClearSelection();
            //    dgvSearchResults.Rows[rowIndex].Selected = true;
            //    dgvSearchResults.FirstDisplayedScrollingRowIndex = rowIndex;
            //    dgvSearchResults.Focus();
            //    break;
            //}
            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {
                if(myDataGrid1[0,i].Value.ToString().Equals(txtSearch.Text ))
                {
                    myDataGrid1.ClearSelection();
                    myDataGrid1.Rows[i].Selected = true;
                    myDataGrid1.FirstDisplayedScrollingRowIndex = i;
                    myDataGrid1.Focus();
                       break;
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                for (int i = 0; i < myDataGrid1.Rows.Count; i++)
                {
                    if (myDataGrid1[0, i].Value.ToString().Equals(txtSearch.Text))
                    {
                        myDataGrid1.ClearSelection();
                        myDataGrid1.Rows[i].Selected = true;
                        myDataGrid1.FirstDisplayedScrollingRowIndex = i;
                        myDataGrid1.Focus();
                        break;
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {
                if (myDataGrid1[0, i].Value.ToString().Equals(txtSearch.Text))
                {
                    myDataGrid1.ClearSelection();
                    myDataGrid1.Rows[i].Selected = true;
                    myDataGrid1.FirstDisplayedScrollingRowIndex = i;
                    //myDataGrid1.Focus();
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\MyProject\ssd\EXPORT_DATA_2.bat");
        }

        private void myBottun1_Click(object sender, EventArgs e)
        {
            ConnectionToDB cnn = new ConnectionToDB();

            if(txtItemSwid.Text =="")
            {
                if(txtItemNo.Text =="")
                {
                    glb_function.MsgBox("الرجاء ادخال رقم القطعة");
                    return;
                }
                DataTable dt = cnn.GetDataTable("select swid from items where item_no='" + txtItemNo.Text + "'");
                if (dt == null || dt.Rows.Count <= 0)
                {
                    glb_function.MsgBox("No data");
                    return;
                }
                else if (dt.Rows.Count > 1)
                {
                    glb_function.MsgBox("more than One Item");
                    txtItemSwid.Text = dt.Rows[0][0].ToString();
                    //  return;
                }
                else
                    return;

               
            }
           
            int icheck = cnn.TranDataToDB("delete from ITEM_UNITS where item_id="+txtItemSwid.Text );

            if(icheck < 0)
            {
                glb_function.MsgBox("Error in item units");
                return;
            }


            // icheck = cnn.TranDataToDB("delete from PROPERTY_ITEM where item_id=" + txtItemSwid.Text);

            //if (icheck < 0)
            //{
            //    glb_function.MsgBox("Error in item PROPERTY");
            //    cnn.glb_RollbackTransaction();
            //    return;
            //}

            
            icheck = cnn.TranDataToDB("delete from PROPERTY_ITEM where item_id=" + txtItemSwid.Text);

            if (icheck < 0)
            {
                glb_function.MsgBox("Error in item PROPERTY");
                cnn.glb_RollbackTransaction();
                return;
            }

            icheck = cnn.TranDataToDB("delete from PACK_ITEM where itemid=" + txtItemSwid.Text);

            if (icheck < 0)
            {
                glb_function.MsgBox("Error in item Package");
                cnn.glb_RollbackTransaction();
                return;
            }

            icheck = cnn.TranDataToDB("delete from items where swid=" + txtItemSwid.Text);

            if (icheck <= 0)
            {
                glb_function.MsgBox("Error in items");
                cnn.glb_RollbackTransaction();
                return;
            }


            cnn.glb_commitTransaction();

            glb_function.MsgBox("Deleted");



        }
    }
}
