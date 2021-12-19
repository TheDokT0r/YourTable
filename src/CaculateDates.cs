using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourTable
{
    //TODO: Run a debug on the entire thing (catch the error from last time)
    public class CaculateDates
    {
        //Desc: Gets the best timing to put the task in. Uses an alrogirthm that separets the datse into different lists of free dates.
        //Would choose the best dates by the priority of the list they're in.

        string name;
        int timeTakeHours;
        int priority;
        DateTime completionDate;
        int firstHour, lastHour;

        User user;

        public CaculateDates(string name, int timeTakeHours, int priority, DateTime completionDate)
        {
            this.name = name;
            this.timeTakeHours = timeTakeHours;
            this.priority = priority;
            this.completionDate = completionDate;

            user = new User();

            firstHour = user.HoursOfWork[0];
            lastHour = user.HoursOfWork[1];
        }



        public List<DateTime> GetDates() //Caculate the dates of the task
        {
            DBMannager task = new DBMannager();

            List<DateTime> freeDates = FindAllFreeTimes();

            if (!user.WorkInWeekends) //Removing all of the dates that are in the weekends if the user can't work at those times
            {
                freeDates = RemoveWeekends(freeDates);
            }


            List<DateTime> prefarableDates = GetTimeOfDay(freeDates); //Prefarable by the user...

            prefarableDates = HoursOfWork(prefarableDates);

            Queue<DateTime> removeQueue = new Queue<DateTime>();
            foreach (DateTime dateTime in freeDates) //Removes all of the extra hours from the prefarable dates DateTime List
            {
                if (prefarableDates.Contains(dateTime))
                {
                    //freeDates.Remove(dateTime);

                    removeQueue.Enqueue(dateTime);
                }
            }
            while(removeQueue.Count > 0)
            {
                freeDates.Remove(removeQueue.Dequeue());
            }


            var a = prefarableDates; //TODO: remove debug - just to check something in debug...

            prefarableDates = DevideBetweenDays(prefarableDates);

            List<DateTime> extraHours = freeDates; //Just a better name I guess

            List<DateTime> finalHours = AddRemoveExtraHours(prefarableDates, extraHours, timeTakeHours);
            

            return finalHours;
        }

        private List<DateTime> FindAllFreeTimes() //Finds all of the free hours
        {
            DBMannager db = new DBMannager();

            List<DateTime> dateTimes = new List<DateTime>();

            DateTime today = DateTime.Now;

            Queue<DateTime> addQueue = new Queue<DateTime>();
            for (var day = today; day.Date < completionDate.Date; day = day.AddDays(1)) //loops thorugh today to the day of assignmant to see the free dates
            {
                List<DateTime> dt = db.FreeHoursOfTheDay(day);

                foreach (DateTime d in dt)
                {
                    addQueue.Enqueue(d);
                }
            }

            while(addQueue.Count > 0)
            {
                dateTimes.Add(addQueue.Dequeue());
            }

            return dateTimes;
        }

        private List<DateTime> RemoveWeekends(List<DateTime> dt)
        {
            foreach (DateTime day in dt)
            {
                if (day.DayOfWeek == DayOfWeek.Friday && day.DayOfWeek == DayOfWeek.Saturday) //Checks if the date is a weekend
                {
                    dt.Remove(day);
                }
            }

            return dt;
        }



        private List<DateTime> StudyEachWeek(List<DateTime> dt) //8 hours a week on a subject (Early idea. Put on hold for now)
        {
            return null; //Do nothing for now
        }



        private List<DateTime> HoursOfWork(List<DateTime> dt) //The prefared amount of hours that the user wants to work
        {
            int hoursCounter = 0;

            DateTime prevDate = new DateTime(2010, 1, 1);
            Queue<DateTime> removeQueue = new Queue<DateTime>();

            foreach (DateTime date in dt.ToArray())
            {
                //check if changed day
                if (date.Day == prevDate.Day)
                {
                    hoursCounter++;

                    if (hoursCounter >= user.PrefarableHoursToWork)
                    {
                        //dt.Remove(day);
                        removeQueue.Enqueue(date);
                    }
                }
                else
                {
                    hoursCounter = 0;
                }

                prevDate = date;
            }

            while(removeQueue.Count > 0) //Removes the dates 
            {
                DateTime temp = removeQueue.Dequeue();

                if(dt.Contains(temp))
                {
                    dt.Remove(temp);
                }
            }

            return dt;
        }


        private List<DateTime> GetTimeOfDay(List<DateTime> freeDates)
        {
            List<DateTime> prefarableDates = new List<DateTime>();

            foreach (DateTime date in freeDates) //Adds all of the hours that the user prefer to the list
            {
                if (user.TimeOfDay == TimeOfDay(date))
                {
                    prefarableDates.Add(date);
                }
            }

            return prefarableDates;
        }


        private int TimeOfDay(DateTime dt) //Gets the time of day(morning, afternoon, evening)
        {
            int hour = dt.Hour;

            if (hour >= 6 && hour <= 12) //Morning
            {
                return 0;
            }
            else if (hour > 12 && hour <= 17) //Afrernoon
            {
                return 1;
            }

            return 3; //Evening
        }



        private List<DateTime> DevideBetweenDays(List<DateTime> dt) //So all of the times woudln't be in the same day
        {
            int counter = 0;
            DateTime prevDate = new DateTime(1, 1, 1, 0, 0, 0);

            counter = dt.Count;

            int workEachDay = 1;
            try
            {
                workEachDay = dt.Count / counter;
            }
            catch(Exception e)
            {
                Options.InsertToLog(e.Message, "CaculateDates");
                workEachDay = 1;
            }


            counter = 0;
            prevDate = new DateTime(1, 1, 1);
            var removeThoseDates = new Queue<DateTime>();

            for(int i = 0; i < dt.Count; i++)
            {
                if(counter == workEachDay)
                {
                    for(int j = i; j < dt.Count; j++)
                    {
                        if(dt[i].Day == dt[j].Day && dt[i].Month == dt[j].Month && dt[i].Year == dt[j].Year)
                        {
                            removeThoseDates.Enqueue(dt[j]);
                        }
                    }

                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }

            while(removeThoseDates.Count > 0)
            {
                dt.Remove(removeThoseDates.Dequeue());
            }

            return dt;
        }

       /*private List<DateTime> DevideBetweenDays(List<DateTime> dtList) //So all of the times woudln't be in the same day
        {
            int workEachDay = 1; //How much time he should work heach week
            try
            {
                workEachDay = dtList.Count / dtList.Count;
            }
            catch (Exception e)
            {
                Options op = new Options();
                if (op.checkHackerMode())
                {
                    MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK);
                }
            }

            List<List<DateTime>> days = new List<List<DateTime>>(); //List of days, in each days there're all of the hours of said day (also in a list)
            int hoursOfWorkInDay = 0;

            foreach(DateTime dt in dtList)
            {
                List<DateTime> day = new List<DateTime>();
                if(hoursOfWorkInDay != workEachDay) //Still the same day
                {
                    day.Add(dt);
                    hoursOfWorkInDay++;
                }
                else //A dawn of a new day...
                {
                    days.Add(day); //Add to days the new list of hours in a day that was just createds
                    hoursOfWorkInDay = 0;
                }
            }


            var newDtList = new List<DateTime>();
            foreach(List<DateTime> day in days)
            {
                foreach(DateTime hour in day)
                {
                    newDtList.Add(hour);
                }
            }

            return newDtList;
        }*/

        private List<DateTime> AddRemoveExtraHours(List<DateTime> prefarableDates, List<DateTime> extraDates, int taskHoursNeeded) //Removes or add dates accurding to the amount of dates to the list, compared to the amount of hours needed
        {
            if (extraDates.Count + prefarableDates.Count < taskHoursNeeded)
            {
                string message = "It seems like you don't have enough time left to complete this task! The task would still be uploaded to your task list, but it wouldn't have enough hours to feel all of your task needs.";
                string title = "Error";

                MessageBox.Show(message, title, MessageBoxButtons.OK);
            }

            while (prefarableDates.Count > taskHoursNeeded) //Too many hours
            {
                prefarableDates.RemoveAt(prefarableDates.Count - 1);
            }

            while (taskHoursNeeded > prefarableDates.Count) //Not enogugh hours
            {
                Random random = new Random();

                int rnd = random.Next(0, extraDates.Count);

                prefarableDates.Add(extraDates[rnd]);
                extraDates.RemoveAt(rnd);
            }

            return prefarableDates;
        }
    }
}