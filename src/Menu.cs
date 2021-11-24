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
    public partial class Menu : Form
    {
        Json_File j;

        public Menu()
        {
            InitializeComponent();
            j = new Json_File();

            lbl_welcomeBack.Text = "Welcome back " + j.ReadAnswer("name") + "!";

            SetButtons();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            GetNextTask();
        }

        private void btn_changeInfo_Click(object sender, EventArgs e)
        {
            Questions q = new Questions();
            q.Show();
            Hide();
        }

        private void btn_yourTimeTable_Click(object sender, EventArgs e)
        {
            Calender timetable = new Calender();

            timetable.Show();
            Hide();
        }

        void SetButtons()
        {
            List<Button> buttons = new List<Button>();

            buttons.Add(btn_changeInfo);
            buttons.Add(btn_yourTimeTable);
            buttons.Add(btn_addTask);
            buttons.Add(btn_busyHours);
            buttons.Add(btn_AllTasks);
            buttons.Add(btn_About);

            foreach(Button btn in buttons) //Function: Removes the outer lines from the buttons. Just makes it looks better overall
            {
                btn.TabStop = false;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Border color transparent
            }


        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();
            Hide();
        }

        private void btn_busyHours_Click(object sender, EventArgs e)
        {
            BusyHours busyHours = new BusyHours();
            busyHours.Show();
            Hide();
        }

        private void btn_AllTasks_Click(object sender, EventArgs e)
        {
            TasksList tasksList = new TasksList();
            tasksList.Show();
            Hide();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            YourTable aboutPage = new YourTable();
            aboutPage.Show();
            Hide();
        }

        private void Menu_Close(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
        }

        //Nex task

        Dictionary<string, string> nextTask;
        void GetNextTask()
        {
            try
            {
                DBMannager db = new DBMannager();
                nextTask = db.GetNextTask();

                lbl_nextTaskName.Text = nextTask["name"];
                lbl_nextTaskTime.Text = nextTask["date"];
            }
            catch(Exception e)
            {
                Options op = new Options();
                if(op.checkHackerMode())
                {
                    MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK);
                }
            }
        }

        private void lbl_nextTaskName_Click(object sender, EventArgs e) //Get you to the task log of the next task
        {
            try
            {
                DBMannager db = new DBMannager();
                nextTask = db.GetNextTask();

                Task_Information task_Information = new Task_Information(Convert.ToInt32(nextTask["taskID"]));
                task_Information.Show();
                Hide();
            }
            catch(Exception ex)
            {
                Options options = new Options();
                if(options.checkHackerMode())
                {
                    MessageBox.Show(ex.Message, "Dev Error Log", MessageBoxButtons.OK);
                }
                Options.InsertToLog(ex.Message, "Menu");
            }
        }

        private void lbl_nextTaskTime_Click(object sender, EventArgs e) //Gets you to the date of the next task
        {
            try
            {
                DBMannager db = new DBMannager();
                nextTask = db.GetNextTask();

                Timetable timetable = new Timetable(Convert.ToDateTime(nextTask["date"]));
                timetable.Show();
                Hide();
            }
            catch(Exception ex)
            {
                Options options = new Options();
                if (options.checkHackerMode())
                {
                    MessageBox.Show(ex.Message, "Dev Error Log", MessageBoxButtons.OK);
                }
                Options.InsertToLog(ex.Message, "Menu");
            }
        }
    }
}
