using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;
using Syncfusion.Windows.Forms;
namespace ERP 
{
    public class myBottun : ButtonAdv
       {
        public Form F;
        public myBottun()
        {
            this.Size = new System.Drawing.Size(56, 28);
           // this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // this.Font = new System.Drawing.Font("bader_al gordabia", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            // this.Text = "";
            // this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // this.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // this.BackgroundImage = global::ERP.Properties.Resources.MainBG;
            //this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            // this.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
             this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
            // this.FlatStyle = System.Windows.Forms.FlatStyle.Flat ;
        }
       protected override void OnCreateControl()
       {
          // base.OnCreateControl();

           F = (Form)base.FindForm();
          
       }

       public enum Btton_type { none = 0, Save, Update, Delete, Close, Undo,Search,Print,Clear,OK,Add,CloseForm,Help,delterow };
       private Btton_type _Type = Btton_type.none;
       public Btton_type w_Type
       {
           get { return _Type; }
           set
           {
               _Type = value;

                if (this.w_Type != Btton_type.none)
                {

                    this.Text = "";
                    this.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                }
                
                
                this.FlatAppearance.BorderSize = 0;
               
                this.Cursor = Cursors.Hand;
                this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

                base.Click += new System.EventHandler(this.myclick_Click);
                
               switch (_Type)
               {
                   case Btton_type.Save:
                       this.Image = global::ERP.Properties.Resources.Save;
                      
                       //if (this.Text == this.Name)
                       //this.Text = "حفظ";
                        break;
                   case Btton_type.Close:
                       this.Image = global::ERP.Properties.Resources.Exit;
                      
                      // if (this.Text == this.Name)
                      // this.Text = "خروج";
                       break;
                   case Btton_type.Undo:
                       this.Image = global::ERP.Properties.Resources.New;
                       
                     //  if (this.Text == this.Name)
                      // this.Text = "جديد";
                       break;
                   case Btton_type.Update :
                       this.Image = global::ERP.Properties.Resources.Update ;
                    
                      
                     //  if (this.Text == this.Name)
                      // this.Text = "تحديث";
                       break;

                   case Btton_type.Delete:
                       this.Image = global::ERP.Properties.Resources.Delete;
                        
                       //if (this.Text == this.Name)
                      // this.Text = "حذف";
                       break;
                   case Btton_type.Clear :
                       this.Image = global::ERP.Properties.Resources.clear     ;
                     
                      
                     //  if (this.Text == this.Name)
                       //    this.Text = "مسـح";
                       break;
                   case Btton_type.Search :
                       this.Image = global::ERP.Properties.Resources.Search;
                       this.Size = new System.Drawing.Size(37, 23);
                       this.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                     
                      // if (this.Text == this.Name)
                      // this.Text = "";
                       break;
                
                   case Btton_type.Print :

                      this.Image = global::ERP.Properties.Resources.Print ;
                    
                      // if (this.Text == this.Name )
                       //this.Text = "طباعة";

                       
                       break;
                   case Btton_type.OK:
                       this.Image = global::ERP.Properties.Resources.Ok;
                    
                      // if (this.Text == this.Name )
                      // this.Text = "موافق";
                       

                           break;
                   case Btton_type.Add :
                           this.Image = global::ERP.Properties.Resources.Add ;

                          // if (this.Text == this.Name)
                            //   this.Text = "إضافة";
                           break;
                    case Btton_type.CloseForm :
                        this.Image = global::ERP.Properties.Resources.CloseForm ;

                        // if (this.Text == this.Name)
                        //   this.Text = "إضافة";
                        break;
                    case Btton_type.Help :
                        this.Image = global::ERP.Properties.Resources.Help ;

                        // if (this.Text == this.Name)
                        //   this.Text = "إضافة";
                        break;
                    case Btton_type.delterow:
                        this.Image = global::ERP.Properties.Resources.clear;
                        break;
                }
                if (this.Image !=null && this.w_Type != Btton_type.none)
                     this.Size = this.Image.Size;

            }
       }

       

        public enum Btton_Priv { none = 0, Save_D, Update_D, Delete_D, Select_D,Print_D, Other_D };
    private Btton_Priv _Priv = Btton_Priv.none;
    public Btton_Priv w_Priv
    {
        get { return _Priv; }
        set
        {
            _Priv = value;

            

        }
    }




    private void myclick_Click(object sender, EventArgs e)
       {
           switch (_Type)
           {
               case Btton_type.Save:

                   glb_function. AcceptTrans =    glb_function.MsgBox("هل تريد حفظ البيانات؟", "", true);
                   
                   break;
               case Btton_type.Close:
                   F.Close();
                   break;

               case Btton_type.Undo:
                  // new ERP.glb_function().clearItems(f);
                  
                 
                   break;


               case Btton_type.Update:
                    glb_function. AcceptTrans = glb_function.MsgBox("هل تريد تعديل البيانات؟", "", true);
                    break;

                case Btton_type.Add:
                    glb_function.AcceptTrans = glb_function.MsgBox("هل تريد اضافة البيانات؟", "", true);

                    break;
                case Btton_type.Delete :
                    glb_function.AcceptTrans = glb_function.MsgBox("هل انت متأكد من عملية حذف البيانات؟", "", true);

                    break;


            }
       }

      


   }


}