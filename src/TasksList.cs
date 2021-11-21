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
    public partial class TasksList : Form
    {
        List<Dictionary<string, object>> tasks;

        public TasksList()
        {
            InitializeComponent();
            tasks = new List<Dictionary<string, object>>();
        }

        private void TasksList_Load(object sender, EventArgs e)
        {
            GetAllTasks();
        }

        private void lbx_tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_goToTask.Visible = true;
            btn_deleateTask.Visible = true;
        }


        //TODO: Finish this (suprising I know)
        private void btn_goToTask_Click(object sender, EventArgs e)
        {
            DBMannager db = new DBMannager();
            int index = lbx_tasks.SelectedIndex;
            Dictionary<string, object> task = tasks[index];

            Task_Information task_Information = new Task_Information(Convert.ToInt32(task["taskID"]));

            task_Information.Show();
            Hide();
        }


        void GetAllTasks()
        {
            lbx_tasks.Items.Clear();

            DBMannager db = new DBMannager();

            Queue<int> ids = db.GetAllTaskIDs();

            int counter = 1;
            while(ids.Count > 0)
            {
                int id = ids.Dequeue();

                Dictionary<string, object> task = db.GetTaskFromID(id);

                tasks.Add(task);

                string name = counter + ": " +  task["name"] + " (Task ID: " + task["taskID"] + ")";

                lbx_tasks.Items.Add(name);

                counter++;
            }
        }


        private void btn_deleateTask_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbx_tasks.SelectedIndex;
                int taskID = Convert.ToInt32(tasks[index]["taskID"]);

                string title = "Important";
                string msg = "Are you sure that you want to delete the following task? You'll have no way of recovering it";
                var results = MessageBox.Show(msg, title, MessageBoxButtons.YesNo);

                if(results == DialogResult.Yes)
                {
                    DBMannager db = new DBMannager();
                    db.DeleteTask(taskID);

                    GetAllTasks(); //Just to reset the text
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

                Options options = new Options();

                if(options.checkHackerMode())
                {
                    MessageBox.Show(e.ToString(), "Error!", MessageBoxButtons.OK);
                }
            }
        }


        private void btn_goBack_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Hide();
        }


        private void End_Program(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
        }
    }
}
