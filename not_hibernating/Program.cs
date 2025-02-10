using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_hibernating
{
    internal static class Program
    {

     // public  static Mutex mutex = new Mutex(true, "WinHibernating", out bool createdNew);

     
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var mutex =new Mutex(true, "WinHibernating", out bool createdNew);
            if (!createdNew)
            {
                // 如果创建mutex失败，表示已经有实例在运行
                MessageBox.Show("程序已经在运行！");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //设定不休眠
            SleepPrevention.PreventSleep(true);
           
            Application.Run(new FrmMain());
          
        }
    }
}
