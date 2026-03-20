using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp.NativeMessages;
using log4net;

namespace iSkorpionAiO_RE
{
    internal static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(
        MethodBase.GetCurrentMethod().DeclaringType);


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
                log4net.Config.XmlConfigurator.Configure();
                AppDomain currentDomain = default(AppDomain);
                currentDomain = AppDomain.CurrentDomain;
                log.Info("Application Started");
                currentDomain.UnhandledException += GlobalUnhandledExceptionHandler;

                System.Windows.Forms.Application.ThreadException += GlobalThreadExceptionHandler;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
          
            
        }
        public static DownloadMessage MSG = null;
        private static void GlobalUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = default(Exception);
            ex = (Exception)e.ExceptionObject;

            log.Error(ex.Message + "\n" + ex.StackTrace);
           
        }

        private static void GlobalThreadExceptionHandler(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Exception ex = default(Exception);
            ex = e.Exception;

            log.Error(ex.Message + "\n" + ex.StackTrace);

        }
    }
}
