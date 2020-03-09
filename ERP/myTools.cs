using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections ;
using System.ComponentModel;
using System.Diagnostics;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace ERP
{
    #region Description
    /// <summary>
    /// 
    /// </summary>
    /// 

# endregion 
    public class myText : TextBoxExt
{
    public myText()
    {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
          

           
    }


       

        private string _OldValue = "";
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }


    private string _ColEgName = "";
    public string W_ColEgName
    {
        set
        {
                
            _ColEgName = value;
        }
        get
        {
            return _ColEgName;
        }
    }


    private string _ColArName = "";
    public string W_ColArName
    {
        set
        {
            _ColArName = value;
        }
        get
        {
            return _ColArName;
        }
    }


    private string _TableName = "";
    public string W_TableName
    {
        set
        {
            _TableName = value;
        }
        get
        {
            return _TableName;
        }
    }


        private bool _Clear = true ;
        public bool W_Clear
        {
            set
            {
                _Clear = value;
            }
            get
            {
                return _Clear;
            }
        }

    }


public  class myNumber2 : NumericUpDownExt
{
    public myNumber2()
    {
     
        this.Width = 100;
    
        this.Maximum = 99999999999;
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            
            
            this.Enter += new System.EventHandler(this.nudRequiredQty_Enter);
            this.ValueChanged += MyNumber_ValueChanged;
    }

        private void MyNumber_ValueChanged(object sender, EventArgs e)
        {
           /// doc الكنترول الاساسية عند تحويل القيمة الى سلسلة نصية 
           /// ياخذ كل القيمة المدخلة وحتى لو كانت محددة برقم عشري معين
           /// مثال
           /// myNumber1.DecimalPlaces=2
           /// اذا ادخلنا القيمة 5.22222
           /// عند التحويل الى سلسلة نصية 
           /// myNumber1.value.Tostring()
           /// تظهر القيمة 5.22 في العرض
           /// وتظهر القيمة 5.22222 كقيمة اساسية
           /// 

            this.Value = Math.Round(this.Value, this.DecimalPlaces);
        }

        //[DefaultValue(2)]
        //public new int DecimalPlaces
        //{

        //    get
        //    {
        //        return base.DecimalPlaces;
        //    }
        //    set
        //    {
        //        base.DecimalPlaces = value;
        //    }
        //}
        private void nudRequiredQty_Enter(object sender, EventArgs e)
    {
        this.Select(0, this.Value.ToString().Length + 3);
    }
   
    
    
   
    //*******************************
    //*******************************
    private string _OldValue = "";
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }
    private string _ColEgName = "";
    public string W_ColEgName
    {
        set
        {
            _ColEgName = value;
        }
        get
        {
            return _ColEgName;
        }
    }


    private string _ColArName = "";
    public string W_ColArName
    {
        set
        {
            _ColArName = value;
        }
        get
        {
            return _ColArName;
        }
    }


    private string _TableName = "";
    public string W_TableName
    {
        set
        {
            _TableName = value;
        }
        get
        {
            return _TableName;
        }
    }

        private bool _Clear = true;
        public bool W_Clear
        {
            set
            {
                _Clear = value;
            }
            get
            {
                return _Clear;
            }
        }


    }

    public class myNumber : DoubleTextBox
    {
        public myNumber()
        {

            this.Width = 100;
            this.NumberDecimalDigits = 0;
            this.MinValue = 0;
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.RightToLeft = RightToLeft.No;
            this.TextAlign = HorizontalAlignment.Right;
            this.Enter += new System.EventHandler(this.nudRequiredQty_Enter);
            this.KeyDown += MyNumber_KeyDown;
        }

        private void MyNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.SendWait ("{TAB}");
        }

        private void MyNumber_ValueChanged(object sender, EventArgs e)
        {
            /// doc الكنترول الاساسية عند تحويل القيمة الى سلسلة نصية 
            /// ياخذ كل القيمة المدخلة وحتى لو كانت محددة برقم عشري معين
            /// مثال
            /// myNumber1.DecimalPlaces=2
            /// اذا ادخلنا القيمة 5.22222
            /// عند التحويل الى سلسلة نصية 
            /// myNumber1.value.Tostring()
            /// تظهر القيمة 5.22 في العرض
            /// وتظهر القيمة 5.22222 كقيمة اساسية
            /// 

           
        }

        //[DefaultValue(2)]
        //public new int DecimalPlaces
        //{

        //    get
        //    {
        //        return base.DecimalPlaces;
        //    }
        //    set
        //    {
        //        base.DecimalPlaces = value;
        //    }
        //}
        private void nudRequiredQty_Enter(object sender, EventArgs e)
        {
            this.Select(0, this.Text .ToString().Length );
        }


        public decimal Value
        {
            set
            {
                this.DoubleValue = Convert.ToDouble(value);
            }
            get
            {
                return Convert.ToDecimal(this.DoubleValue);
            }
        }

        //*******************************
        //*******************************

        //public decimal Maximum
        //{
        //    set
        //    {
        //        this.MaxValue = Convert.ToDouble(value);
        //    }
        //    get
        //    {
        //        return Convert.ToDecimal(this.MaxValue);
        //    }
        //}

            

        public int DecimalPlaces
        {
            set
            {
                this.NumberDecimalDigits =Convert.ToInt32( value);
            }
            get
            {
                return Convert.ToInt32(this.NumberDecimalDigits);
            }
        }


        private string _OldValue = "";
        public string W_OldValue
        {
            set
            {
                _OldValue = value;
            }
            get
            {
                return _OldValue;
            }
        }
        private string _ColEgName = "";
        public string W_ColEgName
        {
            set
            {
                _ColEgName = value;
            }
            get
            {
                return _ColEgName;
            }
        }


        private string _ColArName = "";
        public string W_ColArName
        {
            set
            {
                _ColArName = value;
            }
            get
            {
                return _ColArName;
            }
        }

        private bool _Clear = true;
        public bool W_Clear
        {
            set
            {
                _Clear = value;
            }
            get
            {
                return _Clear;
            }
        }
        private string _TableName = "";
        public string W_TableName
        {
            set
            {
                _TableName = value;
            }
            get
            {
                return _TableName;
            }
        }




    }


    public class myDate : DateTimePickerAdv 
{
    public myDate()
    {
        this.Width = 100;
        this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.CustomFormat = "dd/MM/yyyy";
            this.NoneButtonVisible = false;
       // this.ShowCheckBox = true;
        //this.Checked = true;
       // this.ShowCheckBox = true;
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            //this.NullableValue = DateTime.Now;
            //this.Value = DateTime.Now;
            this.ShowCheckBox = false;

        }


       
        private string _OldValue = "";
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }

    private string _ColEgName = "";
    public string W_ColEgName
    {
        set
        {
            _ColEgName = value;
        }
        get
        {
            return _ColEgName;
        }
    }


    private string _ColArName = "";
    public string W_ColArName
    {
        set
        {
            _ColArName = value;
        }
        get
        {
            return _ColArName;
        }
    }


    private string _TableName = "";
    public string W_TableName
    {
        set
        {
            _TableName = value;
        }
        get
        {
            return _TableName;
        }
    }
        private bool _Clear = true;
        public bool W_Clear
        {
            set
            {
                _Clear = value;
            }
            get
            {
                return _Clear;
            }
        }

    }

public class myList : ComboBox 
{
    public myList()
    {

            this.FormattingEnabled = true;
             this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
        
            this.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


        }
        //[DefaultValue("")]

        //public new string DisplayMember
        //{
        //    get
        //    {
        //        return base.DisplayMember.ToUpper();
        //    }
        //    set
        //    {
        //        base.DisplayMember = value.ToUpper();
        //    }
        //}

        //[DefaultValue("")]

        //public new string ValueMember
        //{
        //    get
        //    {
        //        return base.ValueMember.ToUpper();
        //    }
        //    set
        //    {
        //        base.ValueMember = value.ToUpper();
        //    }
        //}


        private string _OldValue = "";
       
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }
    private string _ColEgName = "";
    public string W_ColEgName
    {
        set
        {
            _ColEgName = value;
        }
        get
        {
            return _ColEgName;
        }
    }


    private string _ColArName = "";
    public string W_ColArName
    {
        set
        {
            _ColArName = value;
        }
        get
        {
            return _ColArName;
        }
    }


    private string _TableName = "";
    public string W_TableName
    {
        set
        {
            _TableName = value;
        }
        get
        {
            return _TableName;
        }
    }

        private bool _Clear = true;
        public bool W_Clear
        {
            set
            {
                _Clear = value;
            }
            get
            {
                return _Clear;
            }
        } 


        public enum ValueType { TEXT, VALUE };
    private ValueType _ValueType = ValueType.TEXT;
    public ValueType w_ValueType
    {
        get { return _ValueType; }
        set
        {
            _ValueType = value;
        }
    }





}





public class myDataGrid : DataGridView
{
    public myDataGrid()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

        this.AllowUserToAddRows = false;
       // this.AllowUserToDeleteRows = false;
          
       
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
       
        this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      
        this.EnableHeadersVisualStyles = false;
        this.Location = new System.Drawing.Point(13, 128);
      this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RowHeadersVisible = false;
            this.RightToLeft = RightToLeft.Yes;
            //  base.RowsAdded  += new System.EventHandler(this.MyGridRowsAdded);
         
            //this.RowHeadersVisible = false;
            //this.EnableHeadersVisualStyles = false;
            //this.AllowUserToAddRows = false;
            //this.AllowUserToDeleteRows = false;
            //this.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            //this.BackColor = System.Drawing.Color.AliceBlue;
           
        }

     


        private bool _Clear = true;
        public bool W_Clear
        {
            set
            {
                _Clear = value;
            }
            get
            {
                return _Clear;
            }
        }

    }


public class myGroupBox : GroupBox  
{
    public myGroupBox()
    {
         this.BackColor = System.Drawing.Color.Transparent;
        this.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
    }
 
   
}

    public class myGroupBox2 : GroupBar 
    {
        public myGroupBox2()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.Font = new System.Drawing.Font("Arabic Transparent", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }


    }

    public class myPanal : GradientPanel
    {
    public myPanal()
    {
        this.BackColor = System.Drawing.Color.Transparent;
       
      
        this.Dock = DockStyle.Fill;

        this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;


    }
}

    public class myPanal2 : GradientPanelExt
    {
        public myPanal2()
        {
            this.BackColor = System.Drawing.Color.Transparent;


            this.Dock = DockStyle.Fill;

            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;


        }
    }

    public class myLabel : AutoLabel 
{
    public myLabel()

    {
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.Transparent;
        this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;

            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

           

    }

       
    }
    public class mycheck : CheckBoxAdv
    {
        public mycheck()
        {
            this.BackColor = System.Drawing.Color.Transparent;


            this.Dock = DockStyle.None ;

            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

         
            this.ImageCheckBox = true;
            this.CheckedImage = global::ERP.Properties.Resources.checked_checkbox_512;
            this.IndeterminateImage = global::ERP.Properties.Resources.indeterminate_checkbox;
            this.UncheckedImage = global::ERP.Properties.Resources.S43Qy;
        }
        private string _OldValue = "";
        public string W_OldValue
        {
            set
            {
                _OldValue = value;
            }
            get
            {
                return _OldValue;
            }
        }
        private string _ColEgName = "";
        public string W_ColEgName
        {
            set
            {
                _ColEgName = value;
            }
            get
            {
                return _ColEgName;
            }
        }


        private string _ColArName = "";
        public string W_ColArName
        {
            set
            {
                _ColArName = value;
            }
            get
            {
                return _ColArName;
            }
        }


        private string _TableName = "";
        public string W_TableName
        {
            set
            {
                _TableName = value;
            }
            get
            {
                return _TableName;
            }
        }

        private bool _Clear = true;
        public bool W_Clear
        {
            set
            {
                _Clear = value;
            }
            get
            {
                return _Clear;
            }
        }


















    }


    public class myRadio : RadioButtonAdv
    {
        public myRadio()
        {
            this.BackColor = System.Drawing.Color.Transparent;


            this.Dock = DockStyle.None;

            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ImageCheckBox = true;
            this.CheckedImage = global::ERP.Properties.Resources.checked_checkbox_512;
            this.AutoSize = false;
            this.UncheckedImage = global::ERP.Properties.Resources.S43Qy;

        }

        

    }
}