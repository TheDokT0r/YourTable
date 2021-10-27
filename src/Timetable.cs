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

namespace YourTable
{
    public partial class Timetable : Form
    {
        List<Label> hours;
        List<Button> tasks;

        DateTime currentDate;
        public Timetable(DateTime currentDate)
        {
            InitializeComponent();
            this.currentDate = currentDate;


            hours = new List<Label>
            {
                lbl7, lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20, lbl21
            };

            tasks = new List<Button>
            {
                btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21
            };
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            Options options = new Options();
            if(options.checkHackerMode())
            {
                btn_Reset.Visible = true;
            }

            //lbl_tip.Text = GetTip(); //Set the tip... That's quite ob

            lbl_title.Text = currentDate.Date.ToString();

            SetHours();
            GetTasks();
        }

        void GetTasks()
        {
            DBMannager t = new DBMannager();

            int counter = 7;
            foreach(Button task in tasks)
            {
                DateTime currentHour = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, counter, 0, 0); //Sets the hour of the current task

                Dictionary<string, object> taskData = t.GetTaskInDate(currentHour);

                try
                {
                    task.Text = taskData["name"].ToString();

                    //sets color
                    int priority = Convert.ToInt32(taskData["priority"]);
                    int taskID = Convert.ToInt32(taskData["taskID"]);

                    switch(priority)
                    {
                        case 0:
                            task.BackColor = Color.White;
                            break;

                        case 1:
                            task.BackColor = Color.Yellow;
                            break;

                        case 2:
                            task.BackColor = Color.Orange;
                            break;

                        case 3:
                            task.BackColor = Color.Red;
                            break;

                        case 4:
                            task.BackColor = Color.DarkRed;
                            break;

                        default:
                            task.BackColor = Color.White;
                            break;
                    }

                    if(taskID == -100)
                    {
                        task.BackColor = Color.Black;
                        task.ForeColor = Color.White;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    task.Text = "Free hour!";
                }

                counter++;
            }
        }

        string GetHours(string dt)
        {
            DateTime dtHour = Convert.ToDateTime(dt);

            string hour = dtHour.ToString("HH:mm");

            return hour;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            DBMannager t = new DBMannager();
            t.ResetTable("TasksData");
            t.ResetTable("Schedule");

            GetTasks();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Hide();
        }

        private void Timetable_Close(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
        }

        /*string GetTip()
        {
            string path = @".\data\tips.txt";
            string[] lines = File.ReadAllLines(path);

            Random rnd = new Random();
            int num = rnd.Next(0, lines.Length);

            return lines[num];
        }*/

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SetHours()
        {
            int counter = 7;
            foreach(Label hour in hours)
            {
                hour.Text = counter + ":00:";
                counter++;
            }
        }

        private void PressButton(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn.Text == "Free hour!")
            {
                return;
            }

            int btnPos = tasks.IndexOf(btn);
            int hour = btnPos + 7;

            DateTime date = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, hour, 0, 0);

            DBMannager db = new DBMannager();
            var task = db.GetTaskInDate(date);

            try
            {
                Task_Information task_Information = new Task_Information(Convert.ToInt32(task["taskID"]));

                task_Information.Show();
                Hide();
            }
            catch(Exception er)
            {
                Console.WriteLine(er);
            }
        }
    }
}