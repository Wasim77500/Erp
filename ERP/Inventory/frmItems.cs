
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ERP.Inventory
{
    public partial class frmItems : MyForm
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          

            if (!CheckEntries())
                return;

            glb_function.arrInsertLogs = new System.Collections.ArrayList();
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtSwid = cnn.GetDataTable("select nvl(max(swid),0)+1 from ITEMS");
            txtSwid.Text = dtSwid.Rows[0][0].ToString();
            dtSwid.Clear();
            dtSwid = cnn.GetDataTable("select item_no from items where item_no='"+ txtCategoryCode.Text + txtITEM_NO.Text.Trim() + "'");
            if(dtSwid != null && dtSwid.Rows.Count >0)
            {

                glb_function.MsgBox("رقم الصنف مدخل من قبل"+"\n"+"لايمكن تكرار رقم الصنف");
                return;
            }
            //Item Information
             glb_function.arrInsertLogs.Add("insert into ITEMS values ((" + txtSwid.Text + "),sysdate,"+glb_function.glb_strUserId +",'فعال',"+
                                           (lstCATEGORY_ID.SelectedIndex== -1 ? "null" : lstCATEGORY_ID.SelectedValue.ToString())   + ",null,"+lstACTIVITY_ID.SelectedValue.ToString() +","+
                                            "'"+txtCategoryCode.Text + txtITEM_NO.Text.Trim()+"','" + txtITEM_NAME.Text .Trim()+"','"+lstINVENTORY_SYSTEM.Text +"',"+
                                            "'"+txtITEM_NOTE.Text .Trim()+"','"+ GetPropItemAsString() + "','"+lstITEM_TYPE.Text +"',"+
                                            "'"+ (ckbITEM_NFS.Checked?"1":"0") +"','" + (ckbHAS_EXPIRED_DATE.Checked ? "1" : "0") + "',"+
                                            "'"+ (ckbITEM_HAS_SERIALNUMBER.Checked ? "1" : "0") + "','"+lstUNIT_SIZING.Text +"',"+
                                            "'"+txtITEM_BARCODE.Text.Trim()+"',"+(lstStandard_unit .SelectedIndex ==-1?"null": lstStandard_unit.SelectedValue.ToString()) +","+
                                            (lstMAIN_UNIT_SALE.SelectedIndex == -1 ? "null" : lstMAIN_UNIT_SALE.SelectedValue.ToString()) +","+
                                            (lstMAIN_UNIT_BUY.SelectedIndex == -1 ? "null" : lstMAIN_UNIT_BUY.SelectedValue.ToString())+
                                            ","+lstMAIN_UNIT.SelectedValue.ToString()+","+lstMAIN_UNIT_INVENTORY.SelectedValue.ToString()+",'"+ txtENGLISH_NAME.Text  + "',"+ nmbSHIPPINGWEIGHT.Value  + ")");

            for (int i = 0; i < dgvItemProperities.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add("insert into PROPERTY_ITEM values((select nvl(max(swid),0)+1 from PROPERTY_ITEM),"+dgvItemProperities[1,i].Value.ToString()+",'"+dgvItemProperities[6,i].Value.ToString()+"',"+
                    "(" + txtSwid.Text + "),'"+ dgvItemProperities[7, i].Value.ToString() + "')");
            }

            for (int i = 0; i < dgPricingMethod.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add("insert into PRICES values((select nvl(max(swid),0)+1 from PRICES),sysdate,"+
                    glb_function.glb_strUserId + ",(" + txtSwid.Text + "),"+ dgPricingMethod[1,i].Value.ToString()+
                    ",'فعال','" + dgPricingMethod[3, i].Value.ToString() + "','" + dgPricingMethod[4, i].Value.ToString() + "','" +
                  (  dgPricingMethod[5, i].Value.ToString()=="لا"?"0":"1") + "'," + dgPricingMethod[6, i].Value.ToString() + "," +
                    dgPricingMethod[10, i].Value.ToString() + "," + dgPricingMethod[11, i].Value.ToString() + "," + 
                    dgPricingMethod[12, i].Value.ToString() + "," + dgPricingMethod[7, i].Value.ToString() + "," + dgPricingMethod[8, i].Value.ToString() + ")");
            }

            for (int i = 0; i < dgSuppliers.Rows.Count; i++)
            {
                if(dgSuppliers[clmSuppItmSwid.Index ,i].Value .ToString()=="")
                glb_function.arrInsertLogs.Add("insert into ITEM_SUPPLIER values((select nvl(max(swid),0)+1 from ITEM_SUPPLIER),sysdate," +
                    "'فعال',(" + txtSwid.Text + "),'" + dgSuppliers[3, i].Value.ToString() + "','" + dgSuppliers[4, i].Value.ToString() + "'," + dgSuppliers[1,i].Value.ToString()+","+glb_function.glb_strUserId +",'"+ dgSuppliers["clmSuppItmInfo", i].Value.ToString() + "')");
                else
                    glb_function.arrInsertLogs.Add("update ITEM_SUPPLIER set itemid=" + txtSwid.Text + ",item_no='" + dgSuppliers[clmSuppItmNo.Index , i].Value.ToString() + "',item_name='" + dgSuppliers[clmSuppItmName.Index , i].Value.ToString() + "',item_info='" + dgSuppliers[clmSuppItmInfo.Index, i].Value.ToString() + "',people_id="+ dgSuppliers[clmSuppPeopleId.Index, i].Value.ToString() + " where swid="+dgSuppliers[clmSuppItmSwid.Index, i].Value.ToString());
            }


            for (int i = 0; i < dgvUnits.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add("insert into ITEM_UNITS values((select nvl(max(swid),0)+1 from ITEM_UNITS)," + dgvUnits[1,i].Value.ToString()+ ",(" + txtSwid.Text + "))");
            }

            for (int i = 0; i < dgvPackages.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add("insert into PACK_ITEM values((select nvl(max(swid),0)+1 from PACK_ITEM),sysdate," +glb_function.glb_strUserId +","+
                    "'فعال',(" + txtSwid.Text + ")," + dgvPackages[4, i].Value.ToString() + "," + dgvPackages[1, i].Value.ToString() + ")");
            }
            for (int i = 0; i < dgvSPDevice.Rows.Count; i++)
            {
                glb_function.arrInsertLogs.Add("insert into SPAREPART_DEVISE values((select nvl(max(swid),0)+1 from SPAREPART_DEVISE)" +
                    ",(" + txtSwid.Text + ")," + dgvSPDevice[clmSPDeviceItemId.Index, i].Value.ToString() + ",'" + dgvSPDevice[clmSP_deviceNote.Index, i].Value.ToString() + "')");
            }


            for (int i = 0; i < dgvImages.Rows.Count; i++)
            {
                string strFileExtension = "";
                if (dgvImages[clmDocType.Index, i].Value.ToString() == "وورد")
                {
                    strFileExtension = "docx";

                }
                else if (dgvImages[clmDocType.Index, i].Value.ToString() == "صورة")
                {
                    strFileExtension = "jpg";
                  
                }
                else if (dgvImages[clmDocType.Index, i].Value.ToString() == "بي دي اف")
                {
                    strFileExtension = "pdf";
                }
                else if (dgvImages[clmDocType.Index, i].Value.ToString() == "اكسل")
                {
                    strFileExtension = "xlsx";
                }


                DataTable dtImageId = cnn.GetDataTable("select nvl(max(swid),0)+1 from IMAGE_item");
                glb_function.arrInsertLogs.Add
                 ("insert into IMAGE_item values((" + dtImageId.Rows[0][0].ToString() + " ),(" + txtSwid.Text + "),BFILENAME('ITEMS_DIR', " + "'" + (Convert.ToInt32(dtImageId.Rows[0][0].ToString()) + i).ToString() + "." + strFileExtension + "'),'" + dgvImages[clmDocType.Index, i].Value.ToString() + "','" + dgvImages[clmAttachFileName.Index, i].Value.ToString() + "',sysdate," + glb_function.glb_strUserId + ")");

                SaveImgeToSrvrHard(dgvImages[clmByteAsString.Index , i].Value.ToString(),(Convert.ToInt32( dtImageId.Rows[0][0].ToString())+ i).ToString(),strFileExtension );
              
            }


            if (glb_function.MultiTransData())
                GetData(txtSwid .Text);
        }
        private bool SaveImgeToSrvrHard(string strFileAsBytes, string strFilename,string strFileExtinsion)
        {


            ImageConverter converter = new ImageConverter();
           
            byte[] rowData = System.Text.ASCIIEncoding.Default.GetBytes(strFileAsBytes);
            //if (File.Exists(@"d:\image\charities777.jpg"))
            //    File.Delete(@"d:\image\charities777.jpg");

            if (strFileExtinsion=="jpg")
            {
                Image img = Image.FromStream(new MemoryStream(rowData));

                img = DecreseResolution(img);

                rowData = (byte[])converter.ConvertTo(img, typeof(byte[]));
            }
          

           



            ConnectionToDB cnn = new ConnectionToDB();
            ConnectionToDB.objCmd = new Oracle.ManagedDataAccess.Client.OracleCommand();


            ConnectionToDB.objCmd.Parameters.Add("blobfile", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = rowData;
            ConnectionToDB.objCmd.Parameters.Add("myfilename", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = strFilename + "."+ strFileExtinsion + "";
            ConnectionToDB.objCmd.Parameters.Add("DirName", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2).Value = "ITEMS_DIR";

            ConnectionToDB.objCmd.Parameters.Add("Result", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            string strResult = cnn.ExecutePro("insertfile", "Result");
            if (strResult.ToUpper() == "SUCCESS")
            {
                cnn.glb_commitTransaction();
                return true;
            }

            else
            {

                glb_function.MsgBox("لم يتم ادخال الملف بشكل صحيح");
                return false;
            }

        }
        private Image DecreseResolution(Image strPicture)
        {
            PictureBox img = new PictureBox();

            Bitmap bitmap = (Bitmap)ScaleImage(strPicture, 400, 400);
            {
                Bitmap newBitmap = new Bitmap(bitmap);
                {

                    //MessageBox.Show("test 1");

                    newBitmap.SetResolution(300, 300);
                    img.Image = newBitmap;
                    //  newBitmap.Save(@"d:\image\charities777.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    // img.Load(@"d:\image\charities777.jpg");
                }
            }

            return img.Image;



        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
        private bool CheckEntries()
        {
            if (!glb_function.AcceptTrans)
                return false;

            int iError = 0;
            if (txtITEM_NO.Text =="")
            {

                errCheck.SetError(txtITEM_NO, "الرجاء ادخال رقم القطعة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtITEM_NO, "");
            }

            

            
            if (txtITEM_NAME.Text == "")
            {

                errCheck.SetError(txtITEM_NAME, "الرجاء ادخال اسم الصنف");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtITEM_NAME, "");
            }


            if (lstITEM_TYPE.Text.Trim()=="صنف")
            {
                if (lstCATEGORY_ID.SelectedIndex == -1)
                {
                    errCheck.SetError(lstCATEGORY_ID, "الرجاء ادخال اختيار التصنيف");
                    iError = 1;
                }
                else
                {
                    errCheck.SetError(lstCATEGORY_ID, "");
                }
            }
               
           if( lstACTIVITY_ID.SelectedIndex ==-1)
            {
                errCheck.SetError(lstACTIVITY_ID, "الرجاء ادخال اختيار النشاط");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstACTIVITY_ID, "");
            }

            if (lstINVENTORY_SYSTEM.SelectedIndex == -1)
            {
                errCheck.SetError(lstINVENTORY_SYSTEM, "الرجاء ادخال اختيار طريقة حساب المخزون");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstINVENTORY_SYSTEM, "");
            }
         

            if (lstITEM_TYPE .SelectedIndex == -1)
            {
                errCheck.SetError(lstITEM_TYPE, "الرجاء ادخال اختيار نوع الصنف");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstITEM_TYPE, "");
            }


            if (lstStandard_unit.SelectedIndex == -1)
            {
                errCheck.SetError(lstStandard_unit, "الرجاء اختيار الوحدة القياسية");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstStandard_unit, "");
            }


            if (lstMAIN_UNIT.SelectedIndex == -1)
            {
                errCheck.SetError(lstMAIN_UNIT, "الرجاء اختيار الوحدة الرئيسية");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstMAIN_UNIT, "");
            }

            if (lstMAIN_UNIT_INVENTORY.SelectedIndex == -1)
            {
                errCheck.SetError(lstMAIN_UNIT_INVENTORY, "الرجاء اختيار المخزون");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstMAIN_UNIT_INVENTORY, "");
            }

            if (lstMAIN_UNIT_SALE.SelectedIndex == -1)
            {
                errCheck.SetError(lstMAIN_UNIT_SALE, "الرجاء اختيار وحدة البيع");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstMAIN_UNIT_SALE, "");
            }

            if (lstMAIN_UNIT_BUY.SelectedIndex == -1)
            {
                errCheck.SetError(lstMAIN_UNIT_BUY, "الرجاء اختيار وحدة الشراء");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstMAIN_UNIT_BUY, "");
            }


            if(lstITEM_TYPE.Text .Trim()=="صنف")
                {

                if (dgvItemProperities.Rows.Count <= 0)
                {
                    glb_function.MsgBox("لايوجد خصائص لهذا الصنف");
                    return false;
                }
                for (int i = 0; i < dgvItemProperities.Rows.Count; i++)
                {
                    if (dgvItemProperities[5, i].Value.ToString() == "")
                    {
                        glb_function.MsgBox("لايوجد قيمة للخاصية :" + dgvItemProperities[2, i].Value.ToString());
                        return false;
                    }
                }
            }

            if (lstITEM_TYPE.Text.Trim() != "صنف")
            {
                if (dgvPackages.Rows.Count <= 0)
                {
                    glb_function.MsgBox("لايوجد اصناف لهذه" +" "+ lstITEM_TYPE.Text.Trim());
                    return false;
                }
            }
                //if(dgPricingMethod.Rows.Count<=0)
                //{
                //    glb_function.MsgBox("الرجاء ادخال الاسعار");
                //    tabControlAdv1.SelectedIndex = 1;
                //    iError = 1;
                //}

                if (iError == 1)
                return false;

            return true;

        }

    private string GetPropItemAsString()
        {
            string strPropItem = "{";


            for (int i = 0; i < dgvItemProperities.Rows.Count; i++)
            {
                if(i== dgvItemProperities.Rows.Count-1)
                strPropItem += "\""+ dgvItemProperities[2, i].Value.ToString().Trim() + "\":\""+dgvItemProperities[6, i].Value.ToString().Trim() + "\"";
                else
                    strPropItem += "\"" + dgvItemProperities[2, i].Value.ToString().Trim() + "\":\"" + dgvItemProperities[6, i].Value.ToString().Trim() + "\",";

            }

            return strPropItem+"}";


        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            PrepareForm();

        }
        private void PrepareForm()
        {
            try
            {
                btnUpdate.Enabled = false;
                txtCategoryCode.Enabled = false;
                lstCATEGORY_ID.Enabled = true ;
                btnOpenCategories.Enabled = true;
                lstStandard_unit.Enabled = true ;
                lstITEM_TYPE.Enabled = true ;
                FillCategories();

                glb_function.FillListWithId(ref lstACTIVITY_ID, "activities", "act_name");
           
                glb_function.FillListWithId(ref lstPRICE_TYPE_ID, "PRICE_TYPE", "PRICE_NAME");
                glb_function.FillListWithId(ref lstStandard_unit, "STANDARD_UNIT", "UNIT_NAME");
                FillCurrency();
               
            }
            catch (Exception ex)
            {

                glb_function.MsgBox(ex.Message );
            }
           

        }
        private void FillCurrency()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCate = cnn.GetDataTable("select swid,curr_name from currency t where t.is_main_curr =1 or t.is_stock_curr=1");

            lstCurrency.DataSource = dtCate;
            lstCurrency.ValueMember = "swid";
            lstCurrency.DisplayMember = "curr_name";

            lstCurrency.SelectedIndex = -1;
        }
        private void FillCategories()
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCate = cnn.GetDataTable("select swid, category_name from CATEGORIES t where category_class='فرعي'");

            lstCATEGORY_ID.DataSource = dtCate;
            lstCATEGORY_ID.ValueMember = "swid";
            lstCATEGORY_ID.DisplayMember = "category_name";

            lstCATEGORY_ID.SelectedIndex = -1;
           
        }

        private void lstCATEGORY_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCATEGORY_ID.SelectedValue == null)
            {

                dgvItemProperities.Rows.Clear();
                txtCategoryCode.Text = "";
                txtITEM_NO.Enabled = false;
                return;
            }

            if (lstCATEGORY_ID.SelectedValue.ToString() != "System.Data.DataRowView" && lstCATEGORY_ID.SelectedValue.ToString() != "")
            {
               
                    dgvItemProperities.Rows.Clear();
                    ConnectionToDB cnn = new ConnectionToDB();
                    string strStat = "";
                    if (txtSwid.Text == "")
                        strStat = "select '' swid ,c.swid property_cate_id, property_Name,PROPERTY_NAME_EN,p.property_type,cat_pro_value_type,'' property_value ,'' property_value_en ,p.swid property_id,c.sort_index " +
                                   " from category_prop c,PROPERTIES p "+
                                    " where p.swid = c.property_id " +
                                    " and  c.category_id = "+ lstCATEGORY_ID.SelectedValue.ToString() + " order by c.sort_index";
                    else
                        strStat = "select i.swid ,c.swid property_cate_id, PROPERTY_NAME ,PROPERTY_NAME_EN,p.property_type, " +
                                   " cat_pro_value_type,i.property_value,i.property_value_en,p.swid property_id,c.sort_index " +
                                   "  from category_prop c,property_item i, PROPERTIES p"+
                                   "  where i.cate_property_id = c.swid"+
                                   " and p.swid = c.property_id"+
                                  "  and i.item_id = "+txtSwid.Text +" order by c.sort_index" ;

                    DataTable dtItemProp = cnn.GetDataTable(strStat);

                    for (int i = 0; i < dtItemProp.Rows.Count; i++)
                    {
                        dgvItemProperities.Rows.Add();

                        dgvItemProperities[0, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["swid"].ToString();
                    dgvItemProperities[1, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["property_cate_id"].ToString();
                    dgvItemProperities[2, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["property_Name"].ToString();
                        dgvItemProperities[3, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["PROPERTY_NAME_EN"].ToString();
                        dgvItemProperities[4, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["property_type"].ToString();
                        dgvItemProperities[5, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["cat_pro_value_type"].ToString();
                    dgvItemProperities[6, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["property_value"].ToString();
                    dgvItemProperities[7, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["property_value_en"].ToString();
                    dgvItemProperities[8, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["property_id"].ToString();
                    dgvItemProperities[9, dgvItemProperities.Rows.Count - 1].Value = dtItemProp.Rows[i]["sort_index"].ToString();
                    
                }

                txtITEM_NO.Enabled = true;
                txtCategoryCode.Text = GetCateCode(lstCATEGORY_ID.SelectedValue.ToString());
             
            }
                else
                {
                    dgvItemProperities.Rows.Clear();
                txtITEM_NO.Enabled = false ;
                txtCategoryCode.Text = "";

            }

            
        }
        private string  GetCateCode(string strCateSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtCode = cnn.GetDataTable("select code from CATEGORIES where swid="+strCateSwid );
            
            return dtCode .Rows[0][0].ToString();

        }



        private void btnAddPriceType_Click(object sender, EventArgs e)
        {
            frmPriceType frm = new frmPriceType();
            frm.ShowDialog();
            glb_function.FillListWithId(ref lstPRICE_TYPE_ID, "PRICE_TYPE", "PRICE_NAME");

        }
        private void ClearPrice()
        {

            lstPRICEING_METHOD.Text = "";
            lstSPECIFIC_COST.Text = "";
            nmbADDED_PROFIT_PRICE.Value  =0;
            nmbDISCOUNT.Value = 0;
            nmbLESS_QUANTITY.Value = 0;
            nmbSELLING_PRICE.Value = 0;

        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            if (!CheckPriceEntries())
                return;
            dgPricingMethod.Rows.Add();
            dgPricingMethod[0, dgPricingMethod.Rows.Count - 1].Value = "";
            dgPricingMethod[1, dgPricingMethod.Rows.Count - 1].Value = lstPRICE_TYPE_ID.SelectedValue.ToString();
            dgPricingMethod[2, dgPricingMethod.Rows.Count - 1].Value = lstPRICE_TYPE_ID.Text ;
            dgPricingMethod[3, dgPricingMethod.Rows.Count - 1].Value = lstPRICEING_METHOD.Text .Trim();
            dgPricingMethod[4, dgPricingMethod.Rows.Count - 1].Value = lstSPECIFIC_COST.Text .Trim();
            dgPricingMethod[5, dgPricingMethod.Rows.Count - 1].Value =(ckbEXCEED_THE_COST.Checked ?"نعم":"لا");
            dgPricingMethod[6, dgPricingMethod.Rows.Count - 1].Value =nmbADDED_PROFIT_PRICE.Value.ToString();
            dgPricingMethod[7, dgPricingMethod.Rows.Count - 1].Value = nmbADDED_PROFIT_PERCENTAGE.Value.ToString();
            dgPricingMethod[8, dgPricingMethod.Rows.Count - 1].Value = lstCurrency.SelectedValue.ToString();
            dgPricingMethod[9, dgPricingMethod.Rows.Count - 1].Value = lstCurrency.Text;


            dgPricingMethod[10, dgPricingMethod.Rows.Count - 1].Value = nmbSELLING_PRICE.Value .ToString();
            dgPricingMethod[11, dgPricingMethod.Rows.Count - 1].Value = nmbLESS_QUANTITY.Value.ToString();
            dgPricingMethod[12, dgPricingMethod.Rows.Count - 1].Value =nmbDISCOUNT.Value.ToString();

            nmbADDED_PROFIT_PERCENTAGE.Enabled = false;
            nmbADDED_PROFIT_PRICE.Enabled = false;
            nmbSELLING_PRICE.Enabled = false;

        }
        private bool CheckPriceEntries()
        {
            int iError = 0;
          if(  lstPRICE_TYPE_ID.SelectedIndex ==-1)
            {

                errCheck.SetError(lstPRICE_TYPE_ID, "الرجاء اختيار نوع التسعير");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstPRICE_TYPE_ID, "");
            }


            if (lstPRICEING_METHOD.Text == "")
            {

                errCheck.SetError(lstPRICEING_METHOD, "الرجاء ادخال طريقة البيع");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstPRICEING_METHOD, "");
            }

            if(lstSPECIFIC_COST.Text =="" )
            {

                errCheck.SetError(lstSPECIFIC_COST, "الرجاء ادخال نوع التكلفة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstSPECIFIC_COST, "");
            }


            if(lstCurrency.SelectedIndex ==-1)
            {

                errCheck.SetError(lstCurrency, "الرجاء اختيار العملة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstCurrency, "");
            }



            if (iError == 1)
                return false;

            return true;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (!CheckSupplierEntries())
                return;

            dgSuppliers.Rows.Add();
            dgSuppliers["clmSuppItmSwid", dgSuppliers.Rows.Count - 1].Value = "";
            dgSuppliers["clmSuppPeopleId", dgSuppliers.Rows.Count - 1].Value = txtPEOPLE_ID.Text ;
            dgSuppliers["clmSuppPeopleName", dgSuppliers.Rows.Count - 1].Value = txtSupplierName.Text.Trim();
            dgSuppliers["clmSuppItmNo", dgSuppliers.Rows.Count - 1].Value = txtSupplierItemNo.Text .Trim();
            dgSuppliers["clmSuppItmName", dgSuppliers.Rows.Count - 1].Value = txtSupplierItemName.Text.Trim();
            dgSuppliers["clmSuppItmInfo", dgSuppliers.Rows.Count - 1].Value = txtSupplierItemInfo.Text.Trim();


            txtPEOPLE_ID.Text = "";
            txtSupplierName.Text = "";
            txtSupplierItemNo.Text = "";
            txtSupplierItemName.Text = "";
            txtSupplierItemInfo.Text = "";
        }

        private bool CheckSupplierEntries()
        {
            int iError = 0;
            if (txtSupplierItemName.Text .Trim()=="")
            {

                errCheck.SetError(txtSupplierItemName, "الرجاء اختيار اسم الصنف");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtSupplierItemName, "");
            }


            if (txtSupplierItemNo.Text .Trim() == "")
            {

                errCheck.SetError(txtSupplierItemNo, "الرجاء اختيار قم الصنف عند المورد");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtSupplierItemNo, "");
            }

            if (txtSupplierName.Text .Trim() == "")
            {

                errCheck.SetError(txtSupplierName, "الرجاء اختيار المورد");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtSupplierName, "");
            }





            if (iError == 1)
                return false;

            return true;
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (!CheckUnitsEntries())
                return;

            dgvUnits .Rows.Add();
            dgvUnits[0, dgvUnits.Rows.Count - 1].Value = "";
            dgvUnits[1, dgvUnits.Rows.Count - 1].Value = lstUnitId.SelectedValue.ToString();
            
            dgvUnits[2, dgvUnits.Rows.Count - 1].Value = lstUnitId.Text ;
            dgvUnits[3, dgvUnits.Rows.Count - 1].Value = txtArCode.Text ;
            dgvUnits[4, dgvUnits.Rows.Count - 1].Value = txtEnCode.Text ;
            dgvUnits[5, dgvUnits.Rows.Count - 1].Value =txtUnitValue.Text ;

            FillUnitSale();
          

            lstUnitId.SelectedIndex = -1;
            txtUnitValue.Text = "";
            txtEnCode.Text = "";
            txtArCode.Text = "";

        }
       private void FillUnitSale()
        {

            string strMAIN_UNIT_SALE = "";
            string strMAIN_UNIT = "";
            string strMAIN_UNIT_INVENTORY = "";
            string strMAIN_UNIT_BUY = "";

            if (lstMAIN_UNIT_INVENTORY.Text.Trim() != "")
                strMAIN_UNIT_INVENTORY = lstMAIN_UNIT_INVENTORY.Text;

            if (lstMAIN_UNIT_SALE.Text.Trim() != "")
                strMAIN_UNIT_SALE = lstMAIN_UNIT_SALE.Text;

            if (lstMAIN_UNIT.Text.Trim() != "")
                strMAIN_UNIT = lstMAIN_UNIT.Text;

            if (lstMAIN_UNIT_BUY.Text.Trim() != "")
                strMAIN_UNIT_BUY = lstMAIN_UNIT_BUY.Text;


           

            lstMAIN_UNIT .DataSource = ConverFromDGtoDT(dgvUnits);
            lstMAIN_UNIT.ValueMember = "clmUnitId";
            lstMAIN_UNIT.DisplayMember = "clmUnitName";
          
            lstMAIN_UNIT_INVENTORY.DataSource = ConverFromDGtoDT(dgvUnits);
            lstMAIN_UNIT_INVENTORY.ValueMember = "clmUnitId";
            lstMAIN_UNIT_INVENTORY.DisplayMember = "clmUnitName";

            lstMAIN_UNIT_SALE.DataSource = ConverFromDGtoDT(dgvUnits);
            lstMAIN_UNIT_SALE.ValueMember = "clmUnitId";
            lstMAIN_UNIT_SALE.DisplayMember = "clmUnitName";

            lstMAIN_UNIT_BUY.DataSource = ConverFromDGtoDT(dgvUnits);
            lstMAIN_UNIT_BUY.ValueMember = "clmUnitId";
            lstMAIN_UNIT_BUY.DisplayMember = "clmUnitName";


            if (strMAIN_UNIT_SALE != "")
                lstMAIN_UNIT_SALE.Text = strMAIN_UNIT_SALE;
            else
                lstMAIN_UNIT_SALE.SelectedIndex = -1;

            if (strMAIN_UNIT != "")
                lstMAIN_UNIT.Text = strMAIN_UNIT;
            else
                lstMAIN_UNIT.SelectedIndex = -1;

            if (strMAIN_UNIT_INVENTORY != "")
                lstMAIN_UNIT_INVENTORY.Text = strMAIN_UNIT_INVENTORY;
            else
                lstMAIN_UNIT_INVENTORY.SelectedIndex = -1;

            if (strMAIN_UNIT_BUY != "")
                lstMAIN_UNIT_BUY.Text = strMAIN_UNIT_BUY;
            else
                lstMAIN_UNIT_BUY.SelectedIndex = -1;



        }
        private DataTable ConverFromDGtoDT(DataGridView dataGrid)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGrid.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            return dt;
        }
        private bool CheckUnitsEntries()
        {
            int iError = 0;
            if (lstUnitId .SelectedIndex  == -1)
            {

                errCheck.SetError(lstUnitId, "الرجاء اختيار اسم الوحدة");
                iError = 1;
            }
            else
            {
                errCheck.SetError(lstUnitId, "");
            }



            for (int i = 0; i < dgvUnits.Rows.Count; i++)
            {
                if(lstUnitId.SelectedIndex !=-1 && lstUnitId.SelectedValue.ToString().Trim()==dgvUnits[1,i].Value.ToString().Trim())
                {
                    glb_function.MsgBox("الوحدة مدخلة من قبل");
                    return false;
                }
            }
            if (iError == 1)
                return false;

            return true;

        }

        private void lstStandard_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStandard_unit.SelectedValue == null)
            {

                lstUnitId.DataSource = null;
                if (bFillUnit == false )
                dgvUnits.Rows.Clear();

                return;
            }
            if (lstStandard_unit.SelectedValue.ToString() != "System.Data.DataRowView" && lstStandard_unit.SelectedValue.ToString() != "")
            {
                if (bFillUnit == false)
                    dgvUnits.Rows.Clear();
                lstUnitId.DataSource = null;
                lstUnitId.Text = "";
                ConnectionToDB conn = new ConnectionToDB();
                DataTable MyDataTable;

                MyDataTable = conn.GetDataTable("select swid,unit_name from units where standard_unit_id="+lstStandard_unit.SelectedValue.ToString()+"  order by unit_name ");
                if (MyDataTable != null)
                {


                    lstUnitId.DataSource = MyDataTable;

                    lstUnitId.ValueMember = "SWID";
                    lstUnitId.DisplayMember = "UNIT_NAME";

                    lstUnitId.SelectedIndex = -1;

                }
            }
            else
            {


                lstUnitId.DataSource = null;
            }
        }

        private void lstUnitId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUnitId.SelectedValue == null)
            {

                txtUnitValue.Text = "";
                txtArCode.Text = "";
                txtEnCode.Text = "";    

                return;
            }
            if (lstUnitId.SelectedValue.ToString() != "System.Data.DataRowView" && lstUnitId.SelectedValue.ToString() != "")
            {

                ConnectionToDB conn = new ConnectionToDB();
                DataTable MyDataTable;

                MyDataTable = conn.GetDataTable("select *  from units where swid=" + lstUnitId.SelectedValue.ToString() + "  ");
                if(MyDataTable.Rows.Count >0)
                {
                    txtUnitValue.Text = MyDataTable.Rows[0]["UNIT_VALUE"].ToString();
                    txtArCode.Text = MyDataTable.Rows[0]["ARABIC_CODE"].ToString();
                    txtEnCode.Text = MyDataTable.Rows[0]["EN_CODE"].ToString();
                }
               
            }
            else
            {


                txtUnitValue.Text = "";
                txtArCode.Text = "";
                txtEnCode.Text = "";
            }
        }

        private void dgvUnits_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lstMAIN_UNIT_SALE.DataSource = null;
            lstMAIN_UNIT_SALE.Text = "";

            lstMAIN_UNIT.DataSource = null;
            lstMAIN_UNIT.Text = "";

            lstMAIN_UNIT_INVENTORY.DataSource = null;
            lstMAIN_UNIT_INVENTORY.Text = "";

            lstMAIN_UNIT_BUY.DataSource = null;
            lstMAIN_UNIT_BUY.Text = "";
        }

        private bool CheckPackageEntries()
        {
            int iError = 0;
            if (txtPackItemID.Text  == "")
            {

                errCheck.SetError(txtPackItemID, "الرجاء اختيار الصنف");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtPackItemID, "");
            }

            if (txtItemName.Text == "")
            {

                errCheck.SetError(txtItemName, "الرجاء اختيار الصنف");
                iError = 1;
            }
            else
            {
                errCheck.SetError(txtItemName, "");
            }
            if (nmbQTY.Value <=0)
            {

                errCheck.SetError(nmbQTY, "الرجاء ادخال الكمية");
                iError = 1;
            }
            else
            {
                errCheck.SetError(nmbQTY, "");
            }


            for (int i = 0; i < dgvPackages.Rows.Count; i++)
            {
                if (txtPackItemID.Text  == dgvPackages[1, i].Value.ToString().Trim())
                {
                    glb_function.MsgBox("الصنف مدخلة من قبل");
                    return false;
                }
            }
            if (iError == 1)
                return false;

            return true;

        }


        private void btnAddPackage_Click(object sender, EventArgs e)
        {

            if (!CheckPackageEntries())
                return;


            dgvPackages.Rows.Add();

            dgvPackages[0, dgvPackages.Rows.Count - 1].Value = "";
            dgvPackages[1, dgvPackages.Rows.Count - 1].Value = txtPackageItemSwid.Text ;
            dgvPackages[2, dgvPackages.Rows.Count - 1].Value = txtPackItemID.Text ;
            dgvPackages[3, dgvPackages.Rows.Count - 1].Value = txtItemName.Text ;
            dgvPackages[4, dgvPackages.Rows.Count - 1].Value = nmbQTY.Value.ToString();


            txtPackageItemSwid.Text = "";
            txtPackItemID.Text = "";
            txtItemName.Text = "";
            nmbQTY.Value = 0;

        }

        private void myBottun1_Click(object sender, EventArgs e)
        {

            byte[] ReturnedImageByte = null;
            Image img = null;
            if (lstDoc_type.Text =="")
            {
                glb_function.MsgBox("الرجاء ادخال نوع الملف");
                return;
            }

            if(lstDoc_type.Text == "صورة")
            {
               ReturnedImageByte = GetImageFromFile();
                img = ERP.Properties.Resources.LaST__Cobalt__Pictures;

                //string str = System.Text.ASCIIEncoding.Default.GetString(ReturnedImageByte);
                //byte[] bytes = System.Text.ASCIIEncoding.Default.GetBytes(str );

                //Image img = Image.FromStream(new MemoryStream(bytes));

                //pictureBox1.Image = img;
                //pictureBox1.Image.Save(@"C:\images\1.jpg");
                //System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"c:\images\1.jpg";
                //p.StartInfo.Verb = "Open";
                //p.Start();





            }
            else if (lstDoc_type.Text == "وورد")
            {
                ReturnedImageByte = GetWordFromFile();
                img = ERP.Properties.Resources.LaST__Cobalt__Word;





            }
            else if (lstDoc_type.Text == "بي دي اف")
            {
                 ReturnedImageByte = GetPDFFromFile();
               
                img = ERP.Properties.Resources.LaST__Cobalt__Acrobat;
                //dgvImages[2, dgvImages.Rows.Count - 1].Value = lstDoc_type.Text;
                //dgvImages[3, dgvImages.Rows.Count - 1].Value = txtAttachFileName.Text;
                //dgvImages[4, dgvImages.Rows.Count - 1].Value = System.Text.ASCIIEncoding.Default.GetString(ReturnedImageByte);
            }
            else if (lstDoc_type.Text == "اكسل")
            {
                ReturnedImageByte = GetExcelFromFile();
                img = ERP.Properties.Resources.LaST__Cobalt__Excel;





            }
            else
            {
                glb_function.MsgBox("نوع الملف غير معروف");
                return;
            }


            if (ReturnedImageByte == null)
                return;

            dgvImages.Rows.Add();
            dgvImages[0, dgvImages.Rows.Count - 1].Value = "";
            dgvImages[1, dgvImages.Rows.Count - 1].Value =img ;
            dgvImages[2, dgvImages.Rows.Count - 1].Value = lstDoc_type.Text;
            dgvImages[3, dgvImages.Rows.Count - 1].Value = txtAttachFileName.Text;
            dgvImages[4, dgvImages.Rows.Count - 1].Value = System.Text.ASCIIEncoding.Default.GetString(ReturnedImageByte);

            lstDoc_type.Text = "";
            txtAttachFileName.Text = "";
        }
        private byte[] GetImageFromFile()
        {
            byte[] MyImageByte = null;
            OpenFileDialog MyOpenFileDialog = new OpenFileDialog();
            MyOpenFileDialog.Title = "فتح ملف صور";
            MyOpenFileDialog.Multiselect = false;
            MyOpenFileDialog.Filter = "Image Files|*.jpg";
            MyOpenFileDialog.FilterIndex = 1;
            MyOpenFileDialog.ShowDialog(this);
            try
            {
                string ImageFileNam = MyOpenFileDialog.FileName;
                if (ImageFileNam != "")
                {
                    long ImageFileSize = (new FileInfo(ImageFileNam).Length);
                    if (ImageFileSize <= (1048576 * 5))
                    {
                        FileStream MyImageFile = new FileStream(ImageFileNam, FileMode.Open, FileAccess.Read);
                        MyImageByte = (new BinaryReader(MyImageFile).ReadBytes((int)ImageFileSize));


                    }
                    else
                    {
                        throw (new Exception("حجم الملف المحدد أكبر من الحجم المسموح به الحجم المسموح خمسه ميجا فقط"));
                    }
                }
                else
                {
                    throw (new Exception("لم يتم تحديد الملف المراد حفظه"));
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Source + " : " + Err.Message);
            }
            return MyImageByte;
        }


        private byte[] GetWordFromFile()
        {
            byte[] MyImageByte = null;
            OpenFileDialog MyOpenFileDialog = new OpenFileDialog();
            MyOpenFileDialog.Title = "فتح ملف وورد";
            MyOpenFileDialog.Multiselect = false;
            MyOpenFileDialog.Filter = "Image Files|*.docx";
            MyOpenFileDialog.FilterIndex = 1;
            MyOpenFileDialog.ShowDialog(this);
            try
            {
                string ImageFileNam = MyOpenFileDialog.FileName;
                if (ImageFileNam != "")
                {
                    long ImageFileSize = (new FileInfo(ImageFileNam).Length);
                   
                        FileStream MyImageFile = new FileStream(ImageFileNam, FileMode.Open, FileAccess.Read);
                        MyImageByte = (new BinaryReader(MyImageFile).ReadBytes((int)ImageFileSize));


                  
                }
                else
                {
                    throw (new Exception("لم يتم تحديد الملف المراد حفظه"));
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Source + " : " + Err.Message);
            }
            return MyImageByte;
        }
        private byte[] GetExcelFromFile()
        {
            byte[] MyImageByte = null;
            OpenFileDialog MyOpenFileDialog = new OpenFileDialog();
            MyOpenFileDialog.Title = "فتح ملف اكسل";
            MyOpenFileDialog.Multiselect = false;
            MyOpenFileDialog.Filter = "Image Files|*.xlsx";
            MyOpenFileDialog.FilterIndex = 1;
            MyOpenFileDialog.ShowDialog(this);
            try
            {
                string ImageFileNam = MyOpenFileDialog.FileName;
                if (ImageFileNam != "")
                {
                    long ImageFileSize = (new FileInfo(ImageFileNam).Length);

                    FileStream MyImageFile = new FileStream(ImageFileNam, FileMode.Open, FileAccess.Read);
                    MyImageByte = (new BinaryReader(MyImageFile).ReadBytes((int)ImageFileSize));



                }
                else
                {
                    throw (new Exception("لم يتم تحديد الملف المراد حفظه"));
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Source + " : " + Err.Message);
            }
            return MyImageByte;
        }
        private byte[] GetPDFFromFile()
        {
            byte[] MyImageByte = null;
            OpenFileDialog MyOpenFileDialog = new OpenFileDialog();
            MyOpenFileDialog.Title = "فتح ملف بي دي اف";
            MyOpenFileDialog.Multiselect = false;
            MyOpenFileDialog.Filter = "Image Files|*.pdf";
            MyOpenFileDialog.FilterIndex = 1;
            MyOpenFileDialog.ShowDialog(this);
            try
            {
                string ImageFileNam = MyOpenFileDialog.FileName;
                if (ImageFileNam != "")
                {
                    long ImageFileSize = (new FileInfo(ImageFileNam).Length);

                    FileStream MyImageFile = new FileStream(ImageFileNam, FileMode.Open, FileAccess.Read);
                    MyImageByte = (new BinaryReader(MyImageFile).ReadBytes((int)ImageFileSize));



                }
                else
                {
                    throw (new Exception("لم يتم تحديد الملف المراد حفظه"));
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Source + " : " + Err.Message);
            }
            return MyImageByte;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
         

            PrepareForm();
           
            btnNew.Visible = false;
            btnSave.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            lstCATEGORY_ID.Enabled = false;
            btnOpenCategories.Enabled = false;
            lstStandard_unit.Enabled = false;
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItems;
            dtItems = cnn.GetDataTable("select item_no from items where swid !="+txtSwid.Text.Trim()+" and item_no='" + txtCategoryCode.Text + txtITEM_NO.Text.Trim() + "'");
            if (dtItems != null && dtItems.Rows.Count > 0)
            {

                glb_function.MsgBox("رقم الصنف مدخل من قبل" + "\n" + "لايمكن تكرار رقم الصنف");
                return;
            }


            glb_function.arrInsertLogs = new System.Collections.ArrayList();

            glb_function.arrInsertLogs.Add("update  items set " +
            "ACTIVITY_ID=" + lstACTIVITY_ID.SelectedValue.ToString() + "," +
                                            "ITEM_NO='" + txtCategoryCode.Text + txtITEM_NO.Text.Trim() + "',ITEM_NAME='" + txtITEM_NAME.Text.Trim() + "',INVENTORY_SYSTEM='" + lstINVENTORY_SYSTEM.Text + "',item_properties_values='" + GetPropItemAsString() + "'," +
                                            "ITEM_NOTE='" + txtITEM_NOTE.Text.Trim() + "',ITEM_TYPE='" + lstITEM_TYPE.Text + "'," +
                                            "ITEM_NFS='" + (ckbITEM_NFS.Checked ? "1" : "0") + "',HAS_EXPIRED_DATE='" + (ckbHAS_EXPIRED_DATE.Checked ? "1" : "0") + "'," +
                                            "ITEM_HAS_SERIALNUMBER='" + (ckbITEM_HAS_SERIALNUMBER.Checked ? "1" : "0") + "',UNIT_SIZING='" + lstUNIT_SIZING.Text + "'," +
                                            "ITEM_BARCODE='" + txtITEM_BARCODE.Text.Trim() + "',MAIN_UNIT_SALE=" +
                                            (lstMAIN_UNIT_SALE.SelectedIndex == -1 ? "null" : lstMAIN_UNIT_SALE.SelectedValue.ToString()) + ",MAIN_UNIT_BUY=" +
                                            (lstMAIN_UNIT_BUY.SelectedIndex == -1 ? "null" : lstMAIN_UNIT_BUY.SelectedValue.ToString()) +
                                            ",MAIN_UNIT=" + lstMAIN_UNIT.SelectedValue.ToString() + ",MAIN_UNIT_INVENTORY=" + lstMAIN_UNIT_INVENTORY.SelectedValue.ToString() + ",ENGLISH_NAME='" + txtENGLISH_NAME.Text  + "',SHIPPINGWEIGHT=" + nmbSHIPPINGWEIGHT.Value + " " +
          " where swid=" + txtSwid.Text);

           // new glb_function().InsertToLogs(this, "ITEMS", txtSwid.Text, "");


            //other table 
            for (int i = 0; i < dgvItemProperities.Rows.Count; i++)
            {
                if(dgvItemProperities[0,i].Value .ToString()=="")
                glb_function.arrInsertLogs.Add("insert into PROPERTY_ITEM values((select nvl(max(swid),0)+1 from PROPERTY_ITEM)," + dgvItemProperities[1, i].Value.ToString() + ",'" + dgvItemProperities[6, i].Value.ToString() + "'," +
                    "(" + txtSwid.Text + "),'"+ dgvItemProperities[7, i].Value.ToString() + "')");
                else
                    glb_function.arrInsertLogs.Add("update PROPERTY_ITEM set property_value=" + "'" + dgvItemProperities[6, i].Value.ToString() + "'" +
                   ",property_value_en='" + dgvItemProperities[7, i].Value.ToString() + "' where swid="+ dgvItemProperities[0, i].Value.ToString());
            }

            for (int i = 0; i < dgPricingMethod.Rows.Count; i++)
            {
                if (dgPricingMethod[0, i].Value.ToString() == "")
                    glb_function.arrInsertLogs.Add("insert into PRICES values((select nvl(max(swid),0)+1 from PRICES),sysdate," +
                  glb_function.glb_strUserId + ",(" + txtSwid.Text + ")," + dgPricingMethod[1, i].Value.ToString() +
                  ",'فعال','" + dgPricingMethod[3, i].Value.ToString() + "','" + dgPricingMethod[4, i].Value.ToString() + "','" +
                (dgPricingMethod[5, i].Value.ToString() == "لا" ? "0" : "1") + "'," + dgPricingMethod[6, i].Value.ToString() + "," +
                  dgPricingMethod[10, i].Value.ToString() + "," + dgPricingMethod[11, i].Value.ToString() + "," +
                  dgPricingMethod[12, i].Value.ToString() + "," + dgPricingMethod[7, i].Value.ToString() + "," + dgPricingMethod[8, i].Value.ToString() + ")");
            }

            for (int i = 0; i < dgSuppliers.Rows.Count; i++)
            {
                if (dgSuppliers[clmSuppItmSwid.Index, i].Value.ToString() == "")
                    glb_function.arrInsertLogs.Add("insert into ITEM_SUPPLIER values((select nvl(max(swid),0)+1 from ITEM_SUPPLIER),sysdate," +
                        "'فعال',(" + txtSwid.Text + "),'" + dgSuppliers[3, i].Value.ToString() + "','" + dgSuppliers[4, i].Value.ToString() + "'," + dgSuppliers[1, i].Value.ToString() + "," + glb_function.glb_strUserId + ",'" + dgSuppliers["clmSuppItmInfo", i].Value.ToString() + "')");
                else
                    glb_function.arrInsertLogs.Add("update ITEM_SUPPLIER set itemid=" + txtSwid.Text + ",item_no='" + dgSuppliers[clmSuppItmNo.Index, i].Value.ToString() + "',item_name='" + dgSuppliers[clmSuppItmName.Index, i].Value.ToString() + "',item_info='" + dgSuppliers[clmSuppItmInfo.Index, i].Value.ToString() + "',people_id=" + dgSuppliers[clmSuppPeopleId.Index, i].Value.ToString() + " where swid=" + dgSuppliers[clmSuppItmSwid.Index, i].Value.ToString());
            }


            for (int i = 0; i < dgvUnits.Rows.Count; i++)
            {
                if (dgvUnits[0, i].Value.ToString() == "")
                    glb_function.arrInsertLogs.Add("insert into ITEM_UNITS values((select nvl(max(swid),0)+1 from ITEM_UNITS)," + dgvUnits[1, i].Value.ToString() + ",(" + txtSwid.Text + "))");
            }

            for (int i = 0; i < dgvPackages.Rows.Count; i++)
            {
                if (dgvPackages[0, i].Value.ToString() == "")
                    glb_function.arrInsertLogs.Add("insert into PACK_ITEM values((select nvl(max(swid),0)+1 from PACK_ITEM),sysdate," + glb_function.glb_strUserId + "," +
                    "'فعال',(" + txtSwid.Text + ")," + dgvPackages[4, i].Value.ToString() + "," + dgvPackages[1, i].Value.ToString() + ")");
            }
            for (int i = 0; i < dgvSPDevice.Rows.Count; i++)
            {
                if (dgvSPDevice[0, i].Value.ToString() == "")
                    glb_function.arrInsertLogs.Add("insert into SPAREPART_DEVISE values((select nvl(max(swid),0)+1 from SPAREPART_DEVISE)" +
                    ",(" + txtSwid.Text + ")," + dgvSPDevice[clmSPDeviceItemId.Index, i].Value.ToString() + ",'" + dgvSPDevice[clmSP_deviceNote.Index, i].Value.ToString() + "')");
            }


            for (int i = 0; i < dgvImages.Rows.Count; i++)
            {
                if (dgvImages[0, i].Value.ToString() == "")
                {
                    string strFileExtension = "";
                    if (dgvImages[clmDocType.Index, i].Value.ToString() == "وورد")
                    {
                        strFileExtension = "docx";

                    }
                    else if (dgvImages[clmDocType.Index, i].Value.ToString() == "صورة")
                    {
                        strFileExtension = "jpg";

                    }
                    else if (dgvImages[clmDocType.Index, i].Value.ToString() == "بي دي اف")
                    {
                        strFileExtension = "pdf";
                    }
                    else if (dgvImages[clmDocType.Index, i].Value.ToString() == "اكسل")
                    {
                        strFileExtension = "xlsx";
                    }
                   // ConnectionToDB cnn = new ConnectionToDB();

                    DataTable dtImageId = cnn.GetDataTable("select nvl(max(swid),0)+1 from IMAGE_item");
                    glb_function.arrInsertLogs.Add
                    ("insert into IMAGE_item values((" + (Convert.ToInt32(dtImageId.Rows[0][0].ToString()) + i).ToString() + " ),(" + txtSwid.Text + "),BFILENAME('ITEMS_DIR', " + "'" + (Convert.ToInt32(dtImageId.Rows[0][0].ToString()) + i).ToString() + "." + strFileExtension + "'),'" + dgvImages[clmDocType.Index, i].Value.ToString() + "','" + dgvImages[clmAttachFileName.Index, i].Value.ToString() + "',sysdate," + glb_function.glb_strUserId + ")");

                    SaveImgeToSrvrHard(dgvImages[clmByteAsString.Index, i].Value.ToString(), (Convert.ToInt32(dtImageId.Rows[0][0].ToString()) + i).ToString(), strFileExtension);

                }

            }



            if (glb_function.MultiTransData())

                GetData(txtSwid.Text);
        }

        bool bFillUnit = false;
      

        private void GetData(string strSwid)
        {
            new glb_function().clearItems(this);
            lstCATEGORY_ID.SelectedIndex = -1;
           

                ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtMainItems = cnn.GetDataTable("select * from ITEMS where swid=" + strSwid);
           
            txtSwid.Text = strSwid;

            lstITEM_TYPE.Text = dtMainItems.Rows[0]["ITEM_TYPE"].ToString();
            lstITEM_TYPE.W_OldValue = dtMainItems.Rows[0]["ITEM_TYPE"].ToString();

            if(lstITEM_TYPE.Text.Trim()=="صنف")
            {
                string strItemCateCode = dtMainItems.Rows[0]["ITEM_NO"].ToString().Substring(0, 3);
                string strItemNo = dtMainItems.Rows[0]["ITEM_NO"].ToString().Substring(3);
                //txtITEM_NO.Text  = dtMainItems.Rows[0]["ITEM_NO"].ToString();
                //txtITEM_NO.W_OldValue = dtMainItems.Rows[0]["ITEM_NO"].ToString();
                txtCategoryCode.Text = strItemCateCode;
                txtITEM_NO.Text = strItemNo;
                txtITEM_NO.W_OldValue = strItemNo;
            }
            else
            {
                txtCategoryCode.Text = "";
                txtITEM_NO.Text = dtMainItems.Rows[0]["ITEM_NO"].ToString();
                txtITEM_NO.W_OldValue = dtMainItems.Rows[0]["ITEM_NO"].ToString();
            }
           


            txtITEM_NAME.Text = dtMainItems.Rows[0]["ITEM_NAME"].ToString();
            txtITEM_NAME.W_OldValue = dtMainItems.Rows[0]["ITEM_NAME"].ToString();

            txtITEM_BARCODE.Text = dtMainItems.Rows[0]["ITEM_BARCODE"].ToString().Trim();
            txtITEM_BARCODE.W_OldValue = (dtMainItems.Rows[0]["ITEM_BARCODE"].ToString());

            txtENGLISH_NAME.Text = dtMainItems.Rows[0]["ENGLISH_NAME"].ToString().Trim();
            txtENGLISH_NAME.W_OldValue = (dtMainItems.Rows[0]["ENGLISH_NAME"].ToString());

            if(dtMainItems.Rows[0]["CATEGORY_ID"].ToString()=="")
            {
                lstCATEGORY_ID.SelectedIndex = -1;
                lstCATEGORY_ID.W_OldValue = "";

            }
            else
            {
                lstCATEGORY_ID.SelectedValue =  Convert.ToInt16(dtMainItems.Rows[0]["CATEGORY_ID"].ToString());
                lstCATEGORY_ID.W_OldValue = (dtMainItems.Rows[0]["CATEGORY_ID"].ToString());
            }
            

            lstINVENTORY_SYSTEM.Text = dtMainItems.Rows[0]["INVENTORY_SYSTEM"].ToString();
            lstINVENTORY_SYSTEM.W_OldValue = dtMainItems.Rows[0]["INVENTORY_SYSTEM"].ToString();

            lstACTIVITY_ID.SelectedValue  = Convert.ToInt16(dtMainItems.Rows[0]["ACTIVITY_ID"].ToString());
            lstACTIVITY_ID.W_OldValue = dtMainItems.Rows[0]["ACTIVITY_ID"].ToString();

           

            lstUNIT_SIZING.Text = dtMainItems.Rows[0]["UNIT_SIZING"].ToString();
            lstUNIT_SIZING.W_OldValue = dtMainItems.Rows[0]["UNIT_SIZING"].ToString();

            txtITEM_NOTE.Text = dtMainItems.Rows[0]["ITEM_NOTE"].ToString();
            txtITEM_NOTE.W_OldValue = dtMainItems.Rows[0]["ITEM_NOTE"].ToString();

            ckbITEM_NFS.Checked =(dtMainItems.Rows[0]["ITEM_NFS"].ToString()=="1"?true :false );
            ckbITEM_NFS.W_OldValue = (dtMainItems.Rows[0]["ITEM_NFS"].ToString() == "1" ? "1" : "0");

            ckbHAS_EXPIRED_DATE.Checked = (dtMainItems.Rows[0]["HAS_EXPIRED_DATE"].ToString() == "1" ? true : false);
            ckbHAS_EXPIRED_DATE.W_OldValue = (dtMainItems.Rows[0]["HAS_EXPIRED_DATE"].ToString() == "1" ? "1" : "0");

            ckbITEM_HAS_SERIALNUMBER.Checked = (dtMainItems.Rows[0]["ITEM_HAS_SERIALNUMBER"].ToString() == "1" ? true : false);
            ckbITEM_HAS_SERIALNUMBER.W_OldValue = (dtMainItems.Rows[0]["ITEM_HAS_SERIALNUMBER"].ToString() == "1" ? "1" : "0");
            nmbSHIPPINGWEIGHT.Value =Convert.ToDecimal( dtMainItems.Rows[0]["SHIPPINGWEIGHT"].ToString());
            nmbSHIPPINGWEIGHT.W_OldValue = dtMainItems.Rows[0]["SHIPPINGWEIGHT"].ToString();
           lstCATEGORY_ID.Enabled = false;
            btnOpenCategories.Enabled = false;
            lstITEM_TYPE.Enabled = false;

            DataTable dtItems = new DataTable();
            //load pricing data
            dtItems.Rows.Clear();
            dgPricingMethod.Rows.Clear();
            dtItems = cnn.GetDataTable("select p.swid,p.price_type_id,t.price_name,p.priceing_method,p.specific_cost,"+
                "p.exceed_the_cost,p.added_profit_price,p.added_profit_percentage,p.selling_price,p.less_quantity,p.discount,p.currency_id,(select c.curr_name from currency c where c.swid= p.currency_id ) curr_name from PRICES p,price_type t " +
                                        " where t.swid = p.price_type_id and  p.item_id =  " +strSwid);

            for (int i = 0; i < dtItems.Rows.Count; i++)
            {
               // (dgPricingMethod[5, i].Value.ToString() == "لا" ? "0" : "1")
                dgPricingMethod.Rows.Add();
                dgPricingMethod[0, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["swid"].ToString();
                dgPricingMethod[1, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["price_type_id"].ToString();
                dgPricingMethod[2, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["price_name"].ToString();
                dgPricingMethod[3, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["priceing_method"].ToString();
                dgPricingMethod[4, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["specific_cost"].ToString();
                dgPricingMethod[5, dgPricingMethod.Rows.Count - 1].Value =( dtItems.Rows[i]["exceed_the_cost"].ToString()=="1"?"نعم":"لا");
                dgPricingMethod[6, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["ADDED_PROFIT_PRICE"].ToString();
                dgPricingMethod[7, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["ADDED_PROFIT_PERCENTAGE"].ToString();
                dgPricingMethod[8, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["currency_id"].ToString();
                dgPricingMethod[9, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["curr_name"].ToString();
                dgPricingMethod[10, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["SELLING_PRICE"].ToString();
                dgPricingMethod[11, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["LESS_QUANTITY"].ToString();
                dgPricingMethod[12, dgPricingMethod.Rows.Count - 1].Value = dtItems.Rows[i]["DISCOUNT"].ToString();

               
               
            }

            //load supplier
            dtItems.Rows.Clear();
            dgSuppliers.Rows.Clear();
            dtItems =cnn.GetDataTable("select i.swid,i.people_id,p.p_name,i.item_no,i.item_name,i.ITEM_INFO from item_supplier i, people p" +
                                   " where i.people_id = p.swid"+
                                   " and i.itemid = "+ strSwid );
            for (int i = 0; i < dtItems.Rows.Count ; i++)
            {
                dgSuppliers.Rows.Add();
                dgSuppliers[0, dgSuppliers.Rows.Count - 1].Value = dtItems.Rows[i]["swid"].ToString();
                dgSuppliers[1, dgSuppliers.Rows.Count - 1].Value = dtItems.Rows[i]["people_id"].ToString();
                dgSuppliers[2, dgSuppliers.Rows.Count - 1].Value = dtItems.Rows[i]["p_name"].ToString();
                dgSuppliers[3, dgSuppliers.Rows.Count - 1].Value = dtItems.Rows[i]["item_no"].ToString();
                dgSuppliers[4, dgSuppliers.Rows.Count - 1].Value = dtItems.Rows[i]["item_name"].ToString();
                dgSuppliers["clmSuppItmInfo", dgSuppliers.Rows.Count - 1].Value = dtItems.Rows[i]["ITEM_INFO"].ToString();
            }

            //load Units data
            dtItems.Rows.Clear();
            dgvUnits.Rows.Clear();
            dtItems = cnn.GetDataTable("select i.swid,i.unit_id,u.unit_name,u.arabic_code,u.en_code,u.unit_value from item_units i,units u "+
                                        " where i.unit_id = u.swid and i.item_id = "+strSwid );
            for (int i = 0; i < dtItems.Rows.Count; i++)
            {
                dgvUnits.Rows.Add();
                dgvUnits[0, dgvUnits.Rows.Count - 1].Value = dtItems.Rows[i]["swid"].ToString();
                dgvUnits[1, dgvUnits.Rows.Count - 1].Value = dtItems.Rows[i]["unit_id"].ToString();
                dgvUnits[2, dgvUnits.Rows.Count - 1].Value = dtItems.Rows[i]["unit_name"].ToString();
                dgvUnits[3, dgvUnits.Rows.Count - 1].Value = dtItems.Rows[i]["arabic_code"].ToString();
                dgvUnits[4, dgvUnits.Rows.Count - 1].Value = dtItems.Rows[i]["en_code"].ToString();
                dgvUnits[5, dgvUnits.Rows.Count - 1].Value = dtItems.Rows[i]["unit_value"].ToString();

            }
          
            FillUnitSale();

            bFillUnit = true;
            lstStandard_unit.SelectedValue = Convert.ToInt16(dtMainItems.Rows[0]["standard_units_used"].ToString());
            lstStandard_unit.W_OldValue = (dtMainItems.Rows[0]["standard_units_used"].ToString());
            bFillUnit = false ;

            lstMAIN_UNIT.SelectedValue = Convert.ToInt16(dtMainItems.Rows[0]["MAIN_UNIT"].ToString());
            lstMAIN_UNIT.W_OldValue = (dtMainItems.Rows[0]["MAIN_UNIT"].ToString());

            lstMAIN_UNIT_INVENTORY.SelectedValue = Convert.ToInt16(dtMainItems.Rows[0]["MAIN_UNIT_INVENTORY"].ToString());
            lstMAIN_UNIT_INVENTORY.W_OldValue = (dtMainItems.Rows[0]["MAIN_UNIT_INVENTORY"].ToString());


            
            lstMAIN_UNIT_SALE.SelectedValue = Convert.ToInt16(dtMainItems.Rows[0]["MAIN_UNIT_SALE"].ToString());
            lstMAIN_UNIT_SALE.W_OldValue = (dtMainItems.Rows[0]["MAIN_UNIT_SALE"].ToString());

            lstMAIN_UNIT_BUY.SelectedValue = Convert.ToInt16(dtMainItems.Rows[0]["MAIN_UNIT_BUY"].ToString());
            lstMAIN_UNIT_BUY.W_OldValue = (dtMainItems.Rows[0]["MAIN_UNIT_BUY"].ToString());

            //load package data
            dtItems.Rows.Clear();
            dgvPackages.Rows.Clear();
            dtItems = cnn.GetDataTable("select p.swid,p.package_item_id,i.item_no,i.item_name,p.qty from PACK_ITEM p,items i"+
                                      "  where i.swid = p.package_item_id"+
                                     "   and p.itemid = " + strSwid);
            for (int i = 0; i < dtItems.Rows.Count; i++)
            {
                dgvPackages.Rows.Add();
                dgvPackages[0, dgvPackages.Rows.Count - 1].Value = dtItems.Rows[i]["swid"].ToString();
                dgvPackages[1, dgvPackages.Rows.Count - 1].Value = dtItems.Rows[i]["package_item_id"].ToString();
                dgvPackages[2, dgvPackages.Rows.Count - 1].Value = dtItems.Rows[i]["item_no"].ToString();
                dgvPackages[3, dgvPackages.Rows.Count - 1].Value = dtItems.Rows[i]["item_name"].ToString();
                dgvPackages[4, dgvPackages.Rows.Count - 1].Value = dtItems.Rows[i]["qty"].ToString();
              

            }

            //load SPAREPART_DEVISE
            dtItems.Rows.Clear();
            dgvPackages.Rows.Clear();
            dtItems = cnn.GetDataTable("select p.swid, spare_part_id, device_id,i.item_no,i.item_name, note " +
                                        " from sparepart_devise p,items i" +
                                        " where i.swid = p.device_id and spare_part_id =  " + strSwid);
            for (int i = 0; i < dtItems.Rows.Count; i++)
            {
                dgvSPDevice.Rows.Add();
                dgvSPDevice[0, dgvSPDevice.Rows.Count - 1].Value = dtItems.Rows[i]["swid"].ToString();
                dgvSPDevice[1, dgvSPDevice.Rows.Count - 1].Value = dtItems.Rows[i]["device_id"].ToString();
                dgvSPDevice[2, dgvSPDevice.Rows.Count - 1].Value = dtItems.Rows[i]["item_no"].ToString();
                dgvSPDevice[3, dgvSPDevice.Rows.Count - 1].Value = dtItems.Rows[i]["item_name"].ToString();
                dgvSPDevice[4, dgvSPDevice.Rows.Count - 1].Value = dtItems.Rows[i]["note"].ToString();


            }



            //load Images 

            //  byte[] TempImageByte = (byte[])dtLocation.Rows[0][0];

            // pictureBox1.Image = Image.FromStream(new MemoryStream(TempImageByte));


            dtItems.Rows.Clear();
            dgvImages .Rows.Clear();
            dtItems = cnn.GetDataTable("select swid,bfile_loc,DOC_TYPE,DOC_NAME from image_item" +
                        " where item_id = " + strSwid);
            for (int i = 0; i < dtItems.Rows.Count; i++)
            {
                byte[] TempImageByte = (byte[])dtItems.Rows[i]["bfile_loc"];
                Image img;
              

                if (dtItems.Rows[i]["DOC_TYPE"].ToString() == "صورة")
                {
                    
                    img = ERP.Properties.Resources.LaST__Cobalt__Pictures;

                    


                }
                else if (dtItems.Rows[i]["DOC_TYPE"].ToString() == "وورد")
                {
                  
                    img = ERP.Properties.Resources.LaST__Cobalt__Word;
                    

                }
                else if (dtItems.Rows[i]["DOC_TYPE"].ToString() == "بي دي اف")
                {
                    

                    img = ERP.Properties.Resources.LaST__Cobalt__Acrobat;
                   
                }
                else if (dtItems.Rows[i]["DOC_TYPE"].ToString() == "اكسل")
                {


                    img = ERP.Properties.Resources.LaST__Cobalt__Excel;

                }
                else
                {
                    glb_function.MsgBox("نوع الملف غير معروف");
                    return;
                }




                dgvImages.Rows.Add();
                dgvImages[0, i].Value = dtItems.Rows[i]["swid"].ToString();
                dgvImages[1, i].Value = img;
                dgvImages[2, i].Value = dtItems.Rows[i]["DOC_TYPE"].ToString();
                dgvImages[3, i].Value = dtItems.Rows[i]["DOC_NAME"].ToString();
                dgvImages[4, i].Value = System.Text.ASCIIEncoding.Default.GetString(TempImageByte);
            }


            btnSave.Visible = false;
            btnNew.Location = btnSave.Location;
            btnNew.Visible = true;
            if (HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;
        }

    


        private  void CtlLocation(Rectangle rect,Control ctrl)
        {


            ctrl.Top = dgvItemProperities.Location.Y + rect.Y;
            ctrl.Left = dgvItemProperities.Location.X + rect.X ;
            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;
            ctrl.Focus();


        }

        private void lstEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void nmbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void lstEditor_Leave(object sender, EventArgs e)
        {
            if (lstEditor.Visible == true)
            {
                lstEditor.Visible = false;

                dgvItemProperities[6, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.Text;
                dgvItemProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value =(lstEditor.SelectedIndex==-1?"": lstEditor.SelectedValue.ToString());

            }
        }

        private void dtpEditor_Leave(object sender, EventArgs e)
        {
            if (dtpEditor.Visible == true)
            {
                dtpEditor.Visible = false;

                dgvItemProperities[6, Convert.ToUInt16(dtpEditor.Tag.ToString())].Value = dtpEditor.Value.ToString("dd/MM/yyyy");

            }
        }

        private void nmbEditor_Leave(object sender, EventArgs e)
        {
            if (nmbEditor.Visible == true)
            {
                nmbEditor.Visible = false;
                
                dgvItemProperities[6, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = nmbEditor.Value.ToString();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            frmFindItem frm = new frmFindItem();

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtSwid.Text = frm.strItemID;
                GetData(txtSwid.Text);
            }
        }

        private void btnFindSupplier_Click(object sender, EventArgs e)
        {
           Purchases. frmFindVendor frm = new Purchases.frmFindVendor();

            frm.ShowDialog();

            if (frm.strVendorID.Trim() != "")
            {
                txtPEOPLE_ID.Text = frm.strVendorID;
                GetVendorData(txtPEOPLE_ID.Text);
            }
        }
        private void GetVendorData(string strVendorId)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtVendor = cnn.GetDataTable("select p_name from people where swid="+ strVendorId);

            txtSupplierName.Text = dtVendor.Rows[0]["p_name"].ToString();

        }

        private void lstSPECIFIC_COST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSPECIFIC_COST.Text == "نسبة الى سعر")
            {
                nmbADDED_PROFIT_PERCENTAGE.Enabled = true;

                nmbADDED_PROFIT_PRICE.Enabled = false ;
                nmbADDED_PROFIT_PRICE.Value  = 0;
                nmbSELLING_PRICE.Enabled = false ;
                nmbSELLING_PRICE.Value = 0;
            }
            else if(lstSPECIFIC_COST.Text == "مبلغ مضاف الى سعر ")
            {
                nmbADDED_PROFIT_PRICE.Enabled = true;
                nmbADDED_PROFIT_PERCENTAGE.Enabled = false ;
                nmbSELLING_PRICE.Enabled = false;

                nmbADDED_PROFIT_PERCENTAGE.Value  = 0;
                nmbSELLING_PRICE.Value  = 0;

            }
            else if(lstSPECIFIC_COST.Text == "مبلغ ثابت")
            {
                nmbSELLING_PRICE.Enabled = true;
                nmbADDED_PROFIT_PERCENTAGE.Enabled = false ;
                nmbADDED_PROFIT_PRICE.Enabled = false;
                nmbADDED_PROFIT_PERCENTAGE.Value  = 0;
                nmbADDED_PROFIT_PRICE.Value  = 0;

            }

        }

        private void dgPricingMethod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=13)
                return;

            if(dgPricingMethod[0,e.RowIndex].Value.ToString()=="")
            {
                glb_function.MsgBox("الرجاء حفظ الصنف اولا مع الاسعار قبل ادخال العروض");
                return;
            }

            frmOffers frm = new frmOffers();
            frm.txtPRICEID.Text = dgPricingMethod[0, e.RowIndex].Value.ToString();
            frm.ShowDialog();

        }

        private void lstCATEGORY_ID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lstACTIVITY_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEditor_Leave(object sender, EventArgs e)
        {
            if (txtEditor.Visible == true)
            {
                txtEditor.Visible = false;

                dgvItemProperities[Convert.ToUInt16(txtEditor.W_ColEgName.ToString()), Convert.ToUInt16(txtEditor.Tag.ToString())].Value = txtEditor.Text .ToString().Replace(@"\", "-").Replace("/", "-");

            }
        }

        private void txtEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.SendWait("{TAB}");
        }

        private void dgvItemProperities_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6 || e.ColumnIndex==7)
                {

                    if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "قائمة")
                    {
                        ConnectionToDB cnn = new ConnectionToDB();
                        DataTable dtList = cnn.GetDataTable("select list_value_en,list_value from property_list where property_id=" + dgvItemProperities[1, e.RowIndex].Value.ToString());

                        lstEditor.DataSource = dtList;
                        lstEditor.DisplayMember = "list_value";
                        lstEditor.ValueMember = "list_value_en";
                        lstEditor.SelectedValue = -1;

                    }

                    DataGridViewCell abc = dgvItemProperities.CurrentCell;

                    Rectangle RECT = dgvItemProperities.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);


                    if (dgvItemProperities[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                    {
                        if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "قائمة")
                        {
                            if (e.ColumnIndex == 7)
                                return;
                            lstEditor.Text = dgvItemProperities[e.ColumnIndex, e.RowIndex].Value.ToString();
                            lstEditor.Tag = e.RowIndex.ToString();
                            lstEditor.W_ColEgName = e.ColumnIndex.ToString();
                            CtlLocation(RECT, lstEditor);
                        }
                        else if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "رقم")
                        {
                            if (e.ColumnIndex == 7)
                                return;
                            nmbEditor.Value = Convert.ToDecimal(dgvItemProperities[e.ColumnIndex, e.RowIndex].Value.ToString());
                            nmbEditor.Tag = e.RowIndex.ToString();
                            nmbEditor.W_ColEgName = e.ColumnIndex.ToString();
                            CtlLocation(RECT, nmbEditor);
                        }
                        else if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "تاريخ")
                        {
                            if (e.ColumnIndex == 7)
                                return;
                            dtpEditor.Value = Convert.ToDateTime(dgvItemProperities[e.ColumnIndex, e.RowIndex].Value.ToString());
                            dtpEditor.Tag = e.RowIndex.ToString();
                            dtpEditor.W_ColEgName = e.ColumnIndex.ToString();
                            CtlLocation(RECT, dtpEditor);
                        }
                        else if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "قيمة نصية")
                        {
                            txtEditor.Text = dgvItemProperities[e.ColumnIndex, e.RowIndex].Value.ToString();
                            txtEditor.Tag = e.RowIndex.ToString();
                            txtEditor.W_ColEgName = e.ColumnIndex.ToString();
                           
                            CtlLocation(RECT, txtEditor);
                        }
                    }
                    else
                    {
                        if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "قائمة")
                        {
                            if (e.ColumnIndex == 7)
                                return;
                            lstEditor.Text = "";
                            lstEditor.Tag = e.RowIndex.ToString();
                            lstEditor.W_ColEgName = e.ColumnIndex.ToString();
                            CtlLocation(RECT, lstEditor);
                        }
                        else if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "رقم")
                        {
                            if (e.ColumnIndex == 7)
                                return;
                            nmbEditor.Value = 0;
                            nmbEditor.Tag = e.RowIndex.ToString();
                            nmbEditor.W_ColEgName = e.ColumnIndex.ToString();
                            CtlLocation(RECT, nmbEditor);
                        }
                        else if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "تاريخ")
                        {
                            if (e.ColumnIndex == 7)
                                return;
                            dtpEditor.Value = DateTime.Now;
                            dtpEditor.Tag = e.RowIndex.ToString();
                            dtpEditor.W_ColEgName = e.ColumnIndex.ToString();
                            CtlLocation(RECT, dtpEditor);
                        }
                        else if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "قيمة نصية")
                        {
                            txtEditor.Text = "";
                            txtEditor.Tag = e.RowIndex.ToString();
                            txtEditor.W_ColEgName = e.ColumnIndex.ToString();
                            CtlLocation(RECT, txtEditor);
                        }
                    }






                }
                else if (e.ColumnIndex == 10)
                {



                    if (dgvItemProperities[5, e.RowIndex].Value.ToString() == "قائمة")
                    {
                        frmPropertyList frm = new frmPropertyList();
                        frm.strPropId = dgvItemProperities[1, e.RowIndex].Value.ToString();
                        frm.ShowDialog();
                    }
                    else
                    {
                        glb_function.MsgBox("هذا الزر لايعمل الا مع القوائم فقط");
                    }
                }
              
            }
        }

        private void btnItemArabName_Click(object sender, EventArgs e)
        {
            txtITEM_NAME.Text = "";
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetPro = cnn.GetDataTable("select swid,nvl( sort_index,0) sort_index from category_prop where (sort_index!=0 and sort_index is not null) order by sort_index");

            for (int i = 0; i < dtGetPro.Rows.Count; i++)
            {
                for (int j = 0; j < dgvItemProperities.Rows.Count; j++)
                {
                    if (dtGetPro.Rows[i]["swid"].ToString() == dgvItemProperities[1, j].Value.ToString())
                        txtITEM_NAME.Text = txtITEM_NAME.Text + (dgvItemProperities[6, j].Value.ToString()==""?"": " " + dgvItemProperities[6, j].Value.ToString());
                }
            }
        }

        private void btnItemEngName_Click(object sender, EventArgs e)
        {
            txtENGLISH_NAME.Text = "";
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtGetPro = cnn.GetDataTable("select swid,nvl( sort_index,0) sort_index from category_prop where (sort_index!=0 and sort_index is not null) order by sort_index");

            for (int i = 0; i < dtGetPro.Rows.Count; i++)
            {
                for (int j = 0; j < dgvItemProperities.Rows.Count; j++)
                {
                    if (dtGetPro.Rows[i]["swid"].ToString() == dgvItemProperities[1, j].Value.ToString())
                        txtENGLISH_NAME.Text = txtENGLISH_NAME.Text + " " + dgvItemProperities[7, j].Value.ToString();
                }
            }
        }

        private void btnOpenCategories_Click(object sender, EventArgs e)
        {
            frmCatagoriesTree frm = new frmCatagoriesTree();
            frm.ShowDialog();
            if (frm.strCatSwid != "")
                lstCATEGORY_ID.SelectedValue = Convert.ToInt16(frm.strCatSwid);
        }

        private void dgvImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (clmOpenDoc.Index != e.ColumnIndex)
                return;

            byte[] bytes = System.Text.ASCIIEncoding.Default.GetBytes(dgvImages[clmByteAsString.Index,e.RowIndex].Value.ToString());
            string strFilePath = "";
            if (dgvImages[clmDocType.Index, e.RowIndex].Value.ToString() == "وورد")
            {


                strFilePath = @"C:\images\1.docx";



            }
            else if (dgvImages[clmDocType.Index, e.RowIndex].Value.ToString() == "صورة")
            {
                strFilePath = @"C:\images\1.jpg";
                //FileStream filst = new FileStream(@"C:\images\1.jpg", FileMode.Create);

                //filst.Write(bytes, 0, bytes.Length);
                //filst.Dispose();

                //filst.Close();

                ////Image img = Image.FromStream(new MemoryStream(bytes));

                ////Bitmap btm=new Bitmap(img) ;
                ////btm.Save(@"C:\images\1.jpg");
                //System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"c:\images\1.jpg";
                //p.StartInfo.Verb = "Open";
                //p.Start();


            }
            else if (dgvImages[clmDocType.Index, e.RowIndex].Value.ToString() == "بي دي اف")
            {
                strFilePath = @"C:\images\1.pdf";
            }
            else if (dgvImages[clmDocType.Index, e.RowIndex].Value.ToString() == "اكسل")
            {
                strFilePath = @"C:\images\1.xlsx";
            }

            FileStream filst = new FileStream(strFilePath, FileMode.Create);

            filst.Write(bytes, 0, bytes.Length);
            filst.Dispose();

            filst.Close();

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = strFilePath;
            p.StartInfo.Verb = "Open";
            p.Start();
        }

        private void myBottun2_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Image Files|*.jpg";
            //if (sfd.ShowDialog() == DialogResult.OK)
               

        }

        private void dgvItemProperities_Scroll(object sender, ScrollEventArgs e)
        {
            Control ctrl = null;
            if (dtpEditor.Visible == true)
                ctrl = dtpEditor;
            else if (lstEditor.Visible == true)
                ctrl = lstEditor;
            else if (txtEditor.Visible == true)
                ctrl = txtEditor;
            else if (nmbEditor.Visible == true)
                ctrl = nmbEditor;
            else
                return;


            DataGridViewCell abc = dgvItemProperities.CurrentCell;

            Rectangle RECT = dgvItemProperities.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);


             CtlLocation(RECT, ctrl);


        }

        private void lstPRICEING_METHOD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPRICEING_METHOD.Text.Trim() == "نسبة الى تكلفة")
            {
                nmbADDED_PROFIT_PERCENTAGE.Enabled = true;
                nmbADDED_PROFIT_PRICE.Enabled = false ;
                nmbSELLING_PRICE.Enabled = false ;

              
            }
               
            else if (lstPRICEING_METHOD.Text.Trim() == "مبلغ مضاف الى تكلفة")
            {
                nmbADDED_PROFIT_PRICE.Enabled = true;
                nmbADDED_PROFIT_PERCENTAGE.Enabled = false ;
                nmbSELLING_PRICE.Enabled = false ;
            }
               
            else if (lstPRICEING_METHOD.Text.Trim() == "مبلغ ثابت")
            {
                nmbSELLING_PRICE.Enabled = true;
                nmbADDED_PROFIT_PRICE.Enabled = false ;
                nmbADDED_PROFIT_PERCENTAGE.Enabled = false ;

            }
            nmbADDED_PROFIT_PERCENTAGE.Value = 0;
            nmbADDED_PROFIT_PRICE.Value = 0;
            nmbSELLING_PRICE.Value = 0;

        }

        private void btnPackageSearch_Click(object sender, EventArgs e)
        {
            if(lstITEM_TYPE.Text.Trim()== "صنف")
            {
                glb_function.MsgBox("لايمكن اضافة صنف الى صنف"+"\n"+"الرجاء تغيير نوع الصنف");
                return;
            }
            if(lstITEM_TYPE.Text.Trim()=="عبوة" && dgvPackages.Rows.Count >0)
            {
                glb_function.MsgBox("لايمكن اضافة اكثر من صنف للعبوة");
                return;
            }
            frmFindItem frm = new frmFindItem();
            frm.strWhere = " and i.item_type not in ('حزمة','عبوة') ";
            

            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtPackageItemSwid .Text = frm.strItemID;

                GetPacketItem(txtPackageItemSwid.Text);
               
            }
        }
        private void GetPacketItem(string strItemSwid)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtItem = cnn.GetDataTable(" select i.swid,i.item_no,i.item_name  from items i where swid="+strItemSwid );

            txtPackItemID.Text = dtItem.Rows[0]["item_no"].ToString();
            txtItemName.Text = dtItem.Rows[0]["item_name"].ToString();
           // txtPackItemID.Text = dtItem.Rows[0][""].ToString();

        }

        private void lstITEM_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstCATEGORY_ID.SelectedIndex = -1;
          

            if (lstITEM_TYPE.Text == "صنف")
            {
                lstCATEGORY_ID.Enabled = true;
                btnOpenCategories.Enabled = true;
                btnItemArabName.Enabled = true;
                btnItemEngName.Enabled = true;
                dgvItemProperities.Enabled = true;
                txtITEM_NO.Enabled = false ;
            }
            else
            {
               

                lstCATEGORY_ID.Enabled = false;
                btnOpenCategories.Enabled = false;
                btnItemArabName.Enabled = false;
                btnItemEngName.Enabled = false;
                dgvItemProperities.Enabled = false;
                txtITEM_NO.Enabled = true;
            }


        }

        private void myBottun2_Click_1(object sender, EventArgs e)
        {
            if(txtPEOPLE_ID.Text .Trim()=="")
            {
                glb_function.MsgBox("الرجاء اختيار المورد اولا");
                return;
            }
            frmFindVendorItems frm = new frmFindVendorItems();

            frm.strWhere = " and im.people_id="+txtPEOPLE_ID.Text.Trim();
            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtSwid.Text = frm.strItemID;
                GetVendorItems(txtSwid.Text);
            }
        }
        private void GetVendorItems(string strItemSupp)
        {
            ConnectionToDB cnn = new ConnectionToDB();
            DataTable dtVendorItem = cnn.GetDataTable("select im.swid,im.item_no,im.item_name,im.item_info from item_supplier im where im.swid= "+strItemSupp );

            dgSuppliers.Rows.Add();
            dgSuppliers[clmSuppItmSwid.Index, dgSuppliers.Rows.Count - 1].Value = dtVendorItem.Rows[0]["swid"].ToString();
            dgSuppliers[clmSuppPeopleId.Index, dgSuppliers.Rows.Count - 1].Value = txtPEOPLE_ID.Text.Trim();
            dgSuppliers[clmSuppPeopleName.Index, dgSuppliers.Rows.Count - 1].Value = txtSupplierName.Text .Trim();
            dgSuppliers[clmSuppItmNo.Index, dgSuppliers.Rows.Count - 1].Value = dtVendorItem.Rows[0]["item_no"].ToString();
            dgSuppliers[clmSuppItmName.Index, dgSuppliers.Rows.Count - 1].Value = dtVendorItem.Rows[0]["item_name"].ToString();
            dgSuppliers[clmSuppItmInfo.Index, dgSuppliers.Rows.Count - 1].Value = dtVendorItem.Rows[0]["item_info"].ToString();
        }

        private void myBottun4_Click(object sender, EventArgs e)
        {
           
            frmFindItem frm = new frmFindItem();
           // frm.strWhere = " and i.item_type not in ('حزمة','عبوة') ";


            frm.ShowDialog();

            if (frm.strItemID.Trim() != "")
            {
                txtSP_deviceItemId.Text = frm.strItemID;

                ConnectionToDB cnn = new ConnectionToDB();
                DataTable dtItem = cnn.GetDataTable(" select i.swid,i.item_no,i.item_name  from items i where swid=" + txtSP_deviceItemId.Text);

                txtDeviceNo.Text = dtItem.Rows[0]["item_no"].ToString();
                txtDeviceName.Text = dtItem.Rows[0]["item_name"].ToString();

            }
        }

        private void myBottun3_Click(object sender, EventArgs e)
        {
            dgvSPDevice.Rows.Add();

            dgvSPDevice[0, dgvSPDevice.Rows.Count - 1].Value = "";
            dgvSPDevice[1, dgvSPDevice.Rows.Count - 1].Value = txtSP_deviceItemId.Text;
            dgvSPDevice[2, dgvSPDevice.Rows.Count - 1].Value = txtDeviceNo.Text;
            dgvSPDevice[3, dgvSPDevice.Rows.Count - 1].Value = txtDeviceName.Text;
            dgvSPDevice[4, dgvSPDevice.Rows.Count - 1].Value = txtDeviceNote.Text.Trim();


            txtSP_deviceItemId.Text = "";
            txtDeviceNo.Text = "";
            txtDeviceName.Text = "";
            txtDeviceNote.Text = "";
        }
    }
}
