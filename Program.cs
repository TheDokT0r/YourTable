using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YourTable
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
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

            Options options = new Options();
            Application.Run(new Op()); //Used as a placeholder
        }

    }
}
