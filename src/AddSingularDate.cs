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
    //Desc: Add a singular date to an already existing task (Works from Task_Information.cs)

    public partial class AddSingularDate : Form
    {
        int taskID;
        User user = new User();

        public AddSingularDate(int taskID, string name)
        {
            InitializeComponent();

            this.taskID = taskID;
            this.Name = name;
        }

        private void AddSingularDate_Load(object sender, EventArgs e)
        {
            int firstHour = user.HoursOfWork[0], lastHour = user.HoursOfWork[1];
            for (int i = firstHour; i < lastHour; i++)
            {
                cbx_hour.Items.Add(i + ":00");
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e) //Enters the data of the date to the task
        {
            int firstHour = user.HoursOfWork[0], lastHour = user.HoursOfWork[1];

            int hour = cbx_hour.SelectedIndex + firstHour; //Minimun hour = 7 on defult... just saying
            DateTime dt = new DateTime(dt_date.Value.Year, dt_date.Value.Month, dt_date.Value.Day, hour, 0, 0);

            DBMannager db = new DBMannager();
            if(!db.FreeHoursOfTheDay(dt).Contains(dt)) //Date already in the task
            {
                MessageBox.Show("Date has already taken, please choose another date/hour", "Error!", MessageBoxButtons.OK);

                return;
            }

            var dates = new List<string>() { dt.ToString() }; //InsertToSchedule can only take a list of strings as dates
            db.InsertToSchedule(Name, dates, taskID);

            Hide();
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            Options op = new Options();
            op.CloseProgram();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
