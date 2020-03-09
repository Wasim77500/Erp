using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;
using System.Net;
namespace ERP
{
  public class glb_SysFun
    {
     
        public string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            AppSettingsReader settingsReader = new AppSettingsReader();



            string key = "Hashpassword98549642";


            if (useHashing)
            {

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;

            tdes.Mode = CipherMode.ECB;


            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();

            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);

            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static void RunApp(Form f)
        {


            using (SingleProgramInstance spi = new SingleProgramInstance("x5k6yz"))
            {
                if (spi.IsSingleInstance)
                {
                    Application.Run(f);
                }
                else
                {
                    spi.RaiseOtherProcess();
                }
            }

        }

     
    }

    public class SingleProgramInstance : IDisposable
    {

        //Win32 API calls necesary to raise an unowned processs main window
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        private const int SW_RESTORE = 9;

        //private members 
        private Mutex _processSync;
        private bool _owned = false;


        public SingleProgramInstance()
        {
            //Initialize a named mutex and attempt to
            // get ownership immediatly 
            _processSync = new Mutex(
                true, // desire intial ownership
                Assembly.GetExecutingAssembly().GetName().Name,
                out _owned);
        }

        public SingleProgramInstance(string identifier)
        {
            //Initialize a named mutex and attempt to
            // get ownership immediately.
            //Use an addtional identifier to lower
            // our chances of another process creating
            // a mutex with the same name.
            _processSync = new Mutex(
                true, // desire intial ownership
                Assembly.GetExecutingAssembly().GetName().Name + identifier,
                out _owned);
        }

        ~SingleProgramInstance()
        {
            //Release mutex (if necessary) 
            //This should have been accomplished using Dispose() 
            Release();
        }

        public bool IsSingleInstance
        {
            //If we don't own the mutex than
            // we are not the first instance.
            get { return _owned; }
        }

        public void RaiseOtherProcess()
        {
            Process proc = Process.GetCurrentProcess();
            // Using Process.ProcessName does not function properly when
            // the name exceeds 15 characters. Using the assembly name
            // takes care of this problem and is more accruate than other
            // work arounds.
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            foreach (Process otherProc in Process.GetProcessesByName(assemblyName))
            {
                //ignore this process
                if (proc.Id != otherProc.Id)
                {
                    // Found a "same named process".
                    // Assume it is the one we want brought to the foreground.
                    // Use the Win32 API to bring it to the foreground.
                    IntPtr hWnd = otherProc.MainWindowHandle;
                    if (IsIconic(hWnd))
                    {
                        ShowWindowAsync(hWnd, SW_RESTORE);
                    }
                    SetForegroundWindow(hWnd);
                    return;
                }
            }
        }

        private void Release()
        {
            if (_owned)
            {
                //If we owne the mutex than release it so that
                // other "same" processes can now start.
                _processSync.ReleaseMutex();
                _owned = false;
            }
        }

        #region Implementation of IDisposable
        public void Dispose()
        {
            //release mutex (if necessary) and notify 
            // the garbage collector to ignore the destructor
            Release();
            GC.SuppressFinalize(this);
        }
        #endregion
    }

}
