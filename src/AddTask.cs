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


        private void img_sticker_Click(object sender, EventArgs e)
        {
            Stickers s = new Stickers();
            img_sticker.ImageLocation = s.GetRandom();
        }


        private void btn_done_Click(object sender, EventArgs e)
        {
            string name = TaskName;
            int hoursForCompletion = HoursForCompletion;
            int priority = Priority;
            string date = new DateTime(Date.Year, Date.Month, Date.Day, Hour, 0, 0).ToString();

            DBMannager task = new DBMannager();
            task.InsertTask(name, hoursForCompletion, priority, date);

            if (CheckErrors(name, hoursForCompletion, priority, date))
            {
                return;
            }

            Menu m = new Menu();

            m.Show();
            Hide();
        }



        bool CheckErrors(string name, int hour, int priority, string date)
        {
            lbl_error.Text = ""; //Resets the error

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
                lbl_error.Text = "ERROR: ";
                foreach (string error in errors)
                    lbl_error.Text += " " + error;

                lbl_error.Visible = true;

                return true;
            }

            return false;
        }



        private string TaskName
        {
            get { return txt_name.Text; }
        }



        private int HoursForCompletion
        {
            get
            {
                if(int.TryParse(txt_hours.Text, out int hour))
                {
                    return hour;
                }

                return -1; //would throw an error
            }
        }



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



        private DateTime Date
        {
            get { return dt_complition.Value; }
        }

        private int Hour
        {
            get
            {
                if (int.TryParse(txb_hour.Text, out int hour))
                {
                    return hour;
                }

                return -1; //would throw an error
            }
        }



        private void AddTask_Close(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
        }

        void Test()
        {
            DBMannager db = new DBMannager();
        }
    }
}