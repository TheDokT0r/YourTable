using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Security.Permissions;

namespace YourTable
{

    public static class Program
    {
        private static Options options = new Options();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        [STAThread]
        static void Main()
        {
            //CREDIT: Microsoft .NET Document
            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(UnhandledException);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //if (checkOpened())
            //{
            //    Application.Run(new src.Op());
            //}
            //else
            //{
            //    Application.Run(new src.Test());
            //}

            Options.InsertToLog("Program has opened", "Program");
            Application.Run(new Op()); //Used as a placeholder
        }

        private static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

        }

        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            if (options.checkHackerMode())
            {
                MessageBox.Show(t.Exception.Message + "\n" + t.Exception.StackTrace, "Error", MessageBoxButtons.OK);
            }

            Options.InsertToLog(t.Exception.Message, t.Exception.StackTrace);
        }
    }
}