using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace YourTable
{
    public partial class Calender : Form
    {
        //Desc: Calender in which the user can choose dates from

        List<Month> MonthsList;
        //List<Label> Days;
        List<Label> Days;
        int currentMonth;
        int currentYear;
        
        public Calender()
        {
            InitializeComponent();
            MonthsList = new List<Month>();
            Days = new List<Label> //btn List of all dates of the month (buttons may be enabled or disabled according to the amount of days in the month)
            {
                lbl_placeholder, //As the name may suggest... It's a placeholder
                lbl_day1, lbl_day2, lbl_day3, lbl_day4, lbl_day5, lbl_day6, lbl_day7, lbl_day8, lbl_day9, lbl_day10,
                lbl_day11, lbl_day12, lbl_day13, lbl_day14, lbl_day15, lbl_day16, lbl_day17, lbl_day18, lbl_day19, lbl_day20,
                lbl_day21, lbl_day22, lbl_day23, lbl_day24, lbl_day25, lbl_day26, lbl_day27, lbl_day28, lbl_day29, lbl_day30,
                lbl_day31
            };

            currentMonth = DateTime.Now.Month;
            currentYear = DateTime.Now.Year;
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            SetMonths();
            GetMonth(currentMonth);
            GetDays();
        }

        private void lbl_month_Click(object sender, EventArgs e)
        {

        }

        void SetMonths() //set all of the months of the year into a list
        {
            MonthsList.Add(new Month("Placeholder", 0)); //As the name says, it's a placeholder... 
            for (int i = 1; i <= 12; i++)
            {
                DateTime d = new DateTime(DateTime.Now.Year, i, 1);
                string monthName = d.ToString("MMMM");

                MonthsList.Add(new Month(monthName, i));
            }
        }

        void GetMonth(int month) //Get the choosen month
        {
            DateTime d = new DateTime(DateTime.Now.Year, month, 1);
            string monthName = d.ToString("MMMM");

            lbl_month.Text = monthName + " (" + currentMonth + ")";
            lbl_year.Text = currentYear.ToString(); 
        }

        void GetDays() //Get the amount of days from the month.
        {
            int daysInMonth = MonthsList[currentMonth].daysInMonth;

            int counter = 1;
            for(counter = 1; counter <= daysInMonth; counter++)
            {
                Days[counter].Text = counter.ToString();
                Days[counter].Cursor = System.Windows.Forms.Cursors.Hand; //Changing the coursor to a pointer while on a day

                Days[counter].Visible = true; //In case they aren't...
            }

            for(int i = counter; i <= 31; i++) //Set the days that aren't in the current month to false (invisible)
            {
                Days[i].Visible = false;
            }
        }


        private void img_Next_Click(object sender, EventArgs e) //Next month
        {
            if(currentMonth >= 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            else
            {
                currentMonth++;
            }

            if (MonthsList[currentMonth].name == "placeholder") //to skip placeholder when going forward
            {
                currentMonth++;
            }

            GetMonth(currentMonth);
            GetDays();
        }


        private void img_back_Click(object sender, EventArgs e) //Prev month
        {
            if (currentMonth <= 1) //To loop back for the begining of the program
            {
                currentMonth = 12;
                currentYear--;
            }
            else
            {
                currentMonth--;
            }

            if(MonthsList[currentMonth].name == "placeholder") //to skip placeholder when going back
            {
                currentMonth--;
            }
            GetMonth(currentMonth);
            GetDays();
        }



        private void days_Click_Handler(object sender, EventArgs e) //btn, when the user clicks on a day, it shall take him to the data on said day
        {
            var btn = sender as Label; //Gets the text of the button (would be the name of the day)
            int day = int.Parse(btn.Text);

            DateTime dt = new DateTime(currentYear, currentMonth, day);

            if(DateTime.Today.Date <= dt.Date)
            {
                Timetable tmt = new Timetable(dt); //I see what you did there...

                tmt.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Date has alraedy passed, please try another date", "Error", MessageBoxButtons.OK);
            }
        }
        


        private void btn_goToToday_Click(object sender, EventArgs e) //Auto-click on the current date
        {
            var currentDay = DateTime.Now;
            Timetable tmt = new Timetable(currentDay);

            tmt.Show();
            Hide();
        }
        

        private void Calender_Close(object sender, FormClosingEventArgs e)
        {
            Options options = new Options();
            options.CloseProgram();
        }
    }
}
