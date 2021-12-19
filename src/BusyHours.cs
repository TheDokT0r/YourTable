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
    public partial class BusyHours : Form
    {
        //Desc: Add hours that cannot be used for a task, as the user has other things to do at that time.

        string name;
        int hour1, hour2;
        string occurrence;
        DateTime dt;

        public BusyHours()
        {
            InitializeComponent();
        }

        private void BusyHours_Load(object sender, EventArgs e)
        {
        }



        private void btn_confirm_Click(object sender, EventArgs e) //Gets all of the data, converts it to dates, and insert it to the db.
        {
            //lbl_loading.Visible = true;
            string title = "Loading";
            string msg = "The program is loading your changes, it might take a second. Please do not press your program until the proccess is done!";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(msg, title, button);
            
            name = txt_name.Text;
            hour1 = int.Parse(txt_hour1.Text);
            hour2 = int.Parse(txt_hour2.Text);
            dt = dt_date.Value;

            occurrence = lbx_occurrence.SelectedItem.ToString().ToLower();

            List<DateTime> dates = new List<DateTime>();

            if(occurrence == "only once")
            {
                for(int hour = hour1; hour <= hour2; hour++)
                {
                    var date = new DateTime(dt.Year, dt.Month, dt.Day, hour, 0, 0);
                    dates.Add(date);
                }
            }

            else if(occurrence == "daily")
            {
                for(int year = dt.Year; year < dt.Year + 1; year++) //year
                {
                    for(int month = 1; month <= 12; month++) //month
                    {
                        int daysInMonth = DateTime.DaysInMonth(year, month);

                        for(int day = 1; day <= daysInMonth; day++) //day
                        {
                            for (int hour = hour1; hour <= hour2; hour++) //hour
                            {
                                var date = new DateTime(year, month, day, hour, 0, 0);
                                dates.Add(date);
                            }
                        }
                    }
                }
            }

            else if(occurrence == "weekely")
            {
                for (int year = dt.Year; year < dt.Year + 1; year++) //year
                {
                    for (int month = 1; month <= 12; month++) //month
                    {
                        int daysInMonth = DateTime.DaysInMonth(year, month);
                        for (int day = 7; day <= daysInMonth; day = day + 7) //week
                        {
                            for (int hour = hour1; hour <= hour2; hour++) //hour
                            {
                                var date = new DateTime(year, month, day, hour, 0, 0);
                                dates.Add(date);
                            }
                        }
                    }
                }
            }

            else if(occurrence == "monthly")
            {
                for (int year = dt.Year; year < dt.Year + 1; year++) //year
                {
                    for (int month = 1; month <= 12; month++) //month
                    {
                        for (int hour = hour1; hour <= hour2; hour++) //hour
                        {
                            var date = new DateTime(year, month, dt.Day, hour, 0, 0);
                            dates.Add(date);
                        }
                    }
                }
            }

            var datesStr = new List<string>();

            foreach(DateTime date in dates)
            {
                datesStr.Add(date.ToString());
            }

            DBMannager db = new DBMannager();
            db.InsertToSchedule(name, datesStr, -100);

            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Hide();
        }

        private void btn_reset_Click(object sender, EventArgs e) //Removes all of the busy hours from the db (all have id = -100)
        {
            MessageBoxButtons button = new MessageBoxButtons();

            if (MessageBox.Show("Are you sure you want to reset your busy hours?", "Reset" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //If the user pressed yes
            {
                MessageBox.Show("Resets your data, might take a second...", "Loading", MessageBoxButtons.OK);

                DBMannager db = new DBMannager();

                db.DeleteBusyHours();
            }
        }

        private void BusyHours_FormClosing(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
        }
    }
}
