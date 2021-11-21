using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


namespace YourTable
{
    public partial class Op : Form
    {
        public Op()
        {
            InitializeComponent();

            this.Text = "YourTable";

            Options options = new Options();

            if (options.checkHackerMode())
            {
                lbl_ver.Text = "gamer mode is on";
            }
        }

        private void Op_Load(object sender, EventArgs e)
        {
            //Just deletes past dates from the db before the program starts
            //DBMannager db = new DBMannager();
            //db.DeletePastTasks();
        }

        private void tmr_fade_Tick(object sender, EventArgs e) //A fade in event
        {
            if (Opacity == 1)
            {
                tmr_fade.Stop();
            }
            Opacity += .2; //20%

        }

        private void lbl_ver_Click(object sender, EventArgs e)
        {

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            /*Questions questions = new Questions();
            questions.Show();
            Hide();*/

            Options options = new Options();
            if (options.hasOpened())
            {
                Menu m = new Menu();
                m.Show();
                Hide();
            }
            else
            {
                Questions q = new Questions();
                q.Show();
                Hide();
            }
        }

        /*static bool HasOpened() //Checks if the program has been opened before
        {
            using(StreamReader sr = new StreamReader(@"E:\GHIS\Computer Science\IA\YourTable\YourTable\data\hasOpened.txt"))
            {
                string line = sr.ReadLine();

                if(line == "0")
                {
                    sr.Close();
                    using (StreamWriter sw = new StreamWriter(@"E:\GHIS\Computer Science\IA\YourTable\YourTable\data\hasOpened.txt"))
                    {
                        sw.Write("1");

                        return false;
                    }
                }
            }

            return true;
        }*/

        private void Op_Close(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram(); 
        }
    }
}
