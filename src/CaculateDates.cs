using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourTable
{
    public class CaculateDates
    {
        string name;
        int timeTakeHours;
        int priority;
        DateTime completionDate;
        int firstHour, lastHour;



        public CaculateDates(string name, int timeTakeHours, int priority, DateTime completionDate)
        {
            this.name = name;
            this.timeTakeHours = timeTakeHours;
            this.priority = priority;
            this.completionDate = completionDate;

            User user = new User();

            firstHour = user.HoursOfWork[0];
            lastHour = user.HoursOfWork[1];
        }



        public List<DateTime> GetDates() //Caculate the dates of the task
        {
            User user = new User();
            DBMannager task = new DBMannager();

            List<DateTime> freeDates = FindAllFreeTimes();

            if (!user.WorkInWeekends) //Removing all of the dates that are in the weekends if the user can't work at those times
            {
                freeDates = RemoveWeekends(freeDates);
            }


            List<DateTime> prefarableDates = GetTimeOfDay(freeDates); //Prefarable by the user...


            if (!user.workInARow)
            {
                prefarableDates = WorkInARow(prefarableDates);
            }

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


            prefarableDates = DevideBetweenDays(prefarableDates);

            List<DateTime> extraHours = freeDates; //Just a better name I guess

            List<DateTime> finalHours = AddRemoveExtraHours(prefarableDates, extraHours, timeTakeHours);

            return finalHours;
        }

        private List<DateTime> FindAllFreeTimes() //I hate this shit so fucking much
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

        private List<DateTime> WorkInARow(List<DateTime> prefatableDates) //TODO: Should probably change that method to be more "smart"
        {
            int counter = 0;
            Queue<DateTime> removeDates = new Queue<DateTime>();

            foreach(DateTime dt in prefatableDates)
            {
                if(counter % 2 == 0)
                {
                    removeDates.Enqueue(dt);
                }
            }

            while(removeDates.Count > 0)
            {
                prefatableDates.Remove(removeDates.Dequeue());
            }

            return prefatableDates;
        }

        //Shoutout to ma man: https://www.swinburneonline.edu.au/faqs/how-many-hours-of-study-per-week-are-recommended-per-unit
        private List<DateTime> StudyEachWeek(List<DateTime> dt) //8 hours a week on a subject
        {
            return null; //Do nothing for now
        }



        private List<DateTime> HoursOfWork(List<DateTime> dt) //The prefared amount of hours that the user wants to work
        {
            User user = new User();

            int hoursCounter = 0;

            DateTime prevDay = new DateTime(2010, 1, 1);
            Queue<DateTime> removeQueue = new Queue<DateTime>();

            foreach (DateTime day in dt.ToArray())
            {
                if (day.Day == prevDay.Day)
                {
                    hoursCounter++;

                    if (hoursCounter >= user.PrefarableHoursToWork)
                    {
                        //dt.Remove(day);
                        removeQueue.Enqueue(day);
                    }
                }

                else
                {
                    hoursCounter = 0;
                }

                prevDay = day;
            }

            while(removeQueue.Count > 0)
            {
                DateTime temp = removeQueue.Dequeue();

                if(dt.Contains(temp))
                {
                    dt.Remove(temp);
                }
            }

            return dt;
        }

        private List<DateTime> AddRemoveExtraHours(List<DateTime> prefarableDates, List<DateTime> extraDates, int taskHoursNeeded)
        {
            while (prefarableDates.Count > taskHoursNeeded) //Too many hours
            {
                prefarableDates.RemoveAt(prefarableDates.Count - 1);
            }

            while (taskHoursNeeded > prefarableDates.Count) //Not enough hours
            {
                Random random = new Random();

                int rnd = random.Next(0, extraDates.Count);

                prefarableDates.Add(extraDates[rnd]);
                extraDates.RemoveAt(rnd);

                taskHoursNeeded--;
            }

            return prefarableDates;
        }

        private List<DateTime> GetTimeOfDay(List<DateTime> freeDates)
        {
            User user = new User();

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



        private List<DateTime> DevideBetweenDays(List<DateTime> dt) //So all of the times woudln't be in the same day
        {
            int counter = 0;
            DateTime prevDate = new DateTime(1, 1, 1, 0, 0, 0);

            /*foreach(DateTime date in dt)
            {
                if (date.Day != prevDate.Day)
                {
                    prevDate = date;
                    counter++;
                }
            }*/


            counter = dt.Count;

            int workEachDay = 1;
            try
            {
                workEachDay = dt.Count / counter;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                workEachDay = 1;
            }


            counter = 0;
            prevDate = new DateTime(1, 1, 1);
            var removeThoseDates = new Queue<DateTime>();

            for(int i = 0; i < dt.Count; i++) //What the actual fuck
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



        private int TimeOfDay(DateTime dt) //Check what time of the day a date is
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
    }
}