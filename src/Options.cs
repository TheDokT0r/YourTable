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

        public void CloseProgram()
        {
            Application.Exit();
        }


        public bool checkHackerMode()
        {
            string path = @".\data\gamer.png";
            string txt = File.ReadAllText(path);

            if (txt.ToLower() == "it's gaming time")
            {
                return true;
            }

            return false;
        }


        public bool hasOpened()
        {
            string path = @".\data\hasOpened";
            string txt = File.ReadAllText(path);

            if (txt.ToLower() != "1")
            {
                return false;
            }

            return true;
        }
    }
}
