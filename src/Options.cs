using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YourTable
{
    public class Options
    {
        //Putting it here just in case I would like to add more stuff to the program before it closes
        //in the future... (Perhaps does something with the db idk)
        static string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public void CloseProgram()
        {
            Application.Exit();
            //InsertToLog("Program closed"); //Does it twice for some reason (I don't know why)
        }


        public bool checkHackerMode()
        {
            //string localAppData = Environment.GetEnvironmentVariable("LocalAppData");
            string path = localAppData + @"\YT_Data\gamer.png";
            string txt = File.ReadAllText(path);


            /*
             *Oh no, you've found me! This is not an image file!
             *Well then, you better find the secret code now ;)
             */
            if (txt.ToLower() == "it's gaming time")
            {
                return true;
            }

            return false;
        }


        public bool hasOpened()
        {
            string path = localAppData + @"\YT_Data\hasOpened.txt";
            string txt = File.ReadAllText(path);

            if (txt.ToLower() != "1")
            {
                return false;
            }

            return true;
        }


        public static void InsertToLog(string msg, string formName) //Insert data to program's log (Appdata)
        {
            string path = localAppData + @"\YT_DATA\program log.txt";

            DateTime now = DateTime.Now;
            using (StreamWriter w = File.AppendText(path))
            {
                w.WriteLine(now + ": (" + formName + ") " + msg);
            }
        }
    }
}
