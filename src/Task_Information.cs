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
    public partial class Task_Information : Form
    {
        int taskID;
        string name;
        int priority; //0 - 3
        DateTime completionDate;
        List<DateTime> dates;
        DateTime selectedItem;

        public Task_Information(int id)
        {
            InitializeComponent();

            DBMannager db = new DBMannager();

            Dictionary<string, object> taskData = db.GetTaskFromID(id);

            name = taskData["name"].ToString();
            completionDate = Convert.ToDateTime(taskData["completionDate"]);
            priority = Convert.ToInt32(taskData["priority"]);

            taskID = Convert.ToInt32(taskData["taskID"]);

            dates = db.GetAllDates(taskID);
        }

        private void Task_Information_Load(object sender, EventArgs e)
        {
            Stickers s = new Stickers();
            img_sticker.ImageLocation = s.GetRandom();

            lbl_name.Text = "Name: " + name;
            lbl_completionDate.Text = "Completion Date: " + completionDate;

            string priorityTxt;
            switch(priority)
            {
                case 0:
                    priorityTxt = "low";
                    break;

                case 1:
                    priorityTxt = "normal";
                    break;

                case 2:
                    priorityTxt = "high";
                    break;

                case 3:
                    priorityTxt = "very high";
                    break;

                case 4:
                    priorityTxt = "D E A T H";
                    break;

                default:
                    priorityTxt = "null";
                    break;
            }

            lbl_priority.Text = "priority: " + priorityTxt + " (" + priority + ")";

            lbl_count.Text = "Dates Count: " + dates.Count;

            foreach(DateTime date in dates)
            {
                lbx_workDates.Items.Add(date.ToString());
            }
        }

        private void From_Closing(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
        }

        private void SelectedItem(object sender, EventArgs e)
        {
            btn_goToDate.Visible = true;
            btn_remove.Visible = true;
        }


        private void btn_goToDate_Click(object sender, EventArgs e)
        {
            selectedItem = Convert.ToDateTime(lbx_workDates.SelectedItem);

            DateTime dt = new DateTime(selectedItem.Year, selectedItem.Month, selectedItem.Day);

            Timetable tb = new Timetable(dt);

            tb.Show();
            Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddSingularDate addSingularDate = new AddSingularDate(taskID, name);
            addSingularDate.Show();
        }

        private void btn_remove_Click(object sender, EventArgs e) //TODO: if haven't be implemented, delete this
        {
            MessageBox.Show("Uh oh, seems like this feture doesn't work yet!", "Error!", MessageBoxButtons.OK);

            selectedItem = Convert.ToDateTime(lbx_workDates.SelectedItem);

            DBMannager db = new DBMannager();
            db.DeleteFromSchedule(selectedItem);
        }
    }
}
