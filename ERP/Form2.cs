using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form2 : Form
    {
        byte[] From = null;
        byte[] To = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void myBottun1_Click(object sender, EventArgs e)
        {

            From = GetWordFromFile();
            string str = "";
            for (int i = 0; i < From.Length; i++)
            {
                str +=  + From[i] + ",";
            }
            myText1.Text = str;
            MessageBox.Show("done");

        }
        private byte[] GetWordFromFile()
        {
            byte[] MyImageByte = null;
            OpenFileDialog MyOpenFileDialog = new OpenFileDialog();
            MyOpenFileDialog.Title = "فتح ملف اكسس";
            MyOpenFileDialog.Multiselect = false;
            MyOpenFileDialog.Filter = "Image Files|*.mdb";
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

        private void myBottun2_Click(object sender, EventArgs e)
        {
            To = GetWordFromFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] NewFile = null;

            NewFile = To;
          
            for (int i = 66; i <= 111; i++)
            {
                NewFile[i] = From[i];
            }


            FileStream filst = new FileStream("C:\\working\\Opened\\new.mdb", FileMode.Create);

            filst.Write(NewFile, 0, NewFile.Length);
            filst.Dispose();

            filst.Close();

        }
    }
}
