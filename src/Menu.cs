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

            foreach(Button btn in buttons)
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

        private void Menu_Close(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
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
    }
}
