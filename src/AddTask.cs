using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourTable
{
    public partial class AddTask : Form
    {
        //Desc: Add tasks to the program (FrontEnd back of the program. Backend can be found in DBMannager.cs and CaculateDates.cs)

        public AddTask()
        {
            InitializeComponent();

            Stickers s = new Stickers();

            //Displaying the stickers
            img_sticker.ImageLocation = s.GetRandom();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Hide();
        }

        
        private void img_sticker_Click(object sender, EventArgs e) //Don't like the sticker? Get a new one!
        {
            Stickers s = new Stickers();
            img_sticker.ImageLocation = s.GetRandom();
        }


        private void btn_done_Click(object sender, EventArgs e) //Done with the task. Moves the data to the backend.
        {
            string name = TaskName;
            int hoursForCompletion = HoursForCompletion;
            int priority = Priority;
            string date = new DateTime(Date.Year, Date.Month, Date.Day, Hour, 0, 0).ToString();

            DBMannager db = new DBMannager();
            db.InsertTask(name, hoursForCompletion, priority, date);

            if (CheckErrors(name, hoursForCompletion, priority, date))
            {
                return;
            }

            Menu m = new Menu();

            m.Show();
            Hide();
        }



        bool CheckErrors(string name, int hour, int priority, string date) //As the name suggests, check for errors in the data.
        {
            List<string> errors = new List<string>();

            if (DateTime.Parse(date).Date < DateTime.Now.Date)
            {
                errors.Add("Invalid date,");
            }

            if (hour < 0)
            {
                errors.Add("Invalid hours,");
            }

            if (priority < 0)
            {
                errors.Add("Invalid priority");
            }


            if (errors.Count > 0) //Check if there are any errors
            {
                string errorList = "";

                foreach(string error in errors)
                {
                    errorList = errorList + ", " + error;
                }

                MessageBox.Show(errorList, "Error", MessageBoxButtons.OK);
                Options.InsertToLog(errorList, "AddTask");
            }

            return false;
        }


        //The name of the task
        private string TaskName
        {
            get { return txt_name.Text; }
        }


        //Amount of hours for completion
        private int HoursForCompletion
        {
            get
            {
                if (int.TryParse(txt_hours.Text, out int hour))
                {
                    return hour;
                }

                return -1; //returns an error
            }
        }


        //The priority of the task
        private int Priority
        {
            get
            {
                Dictionary<string, int> prDic = new Dictionary<string, int>();

                for (int i = 0; i < cmb_priority.Items.Count; i++)
                {
                    prDic.Add(cmb_priority.Items[i].ToString(), i);
                }

                if (prDic.ContainsKey(cmb_priority.Text))
                {
                    return prDic[cmb_priority.Text];
                }

                return -1;
            }
        }


        //The date of completion
        private DateTime Date
        {
            get { return dt_complition.Value; }
        }

        //The hour of completion
        private int Hour
        {
            get
            {
                if(cmb_hour.SelectedIndex + 8 == 24) //If it's midnight (prevent error)
                {
                    return 0;
                }

                return cmb_hour.SelectedIndex + 8;
            }
        }



        private void AddTask_Close(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
        }

        void Test() //TODO: Remove (debug)
        {
            DBMannager db = new DBMannager();
        }
    }
}