using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourTable
{
    //All of the data of user is given from the JSON file
    public class User
    {
        public string Name { get; }
        public int[] HoursOfWork { get; } //0 = first hour, 1 = last hour
        public int TimeOfDay { get; } //0 = morning, 1 = noon, 2 = evening
        public int PrefarableHoursToWork { get; } //Amount of hours
        public bool WorkInWeekends { get; }


        /*Shoutout to those amzing researchers (based the data of my program on their resarch)
        *https://www.verywellhealth.com/how-much-sleep-does-your-teen-need-2606870
        *https://www.cdc.gov/sleep/about_sleep/how_much_sleep.html
        */

        public User() 
        {
            Json_File j = new Json_File();
            var userData = j.ReadAllAnswers();

            Name = userData["name"];

            int age = int.Parse(userData["age"]);
            HoursOfWork = GetHoursOfWork(age);

            string timeOfDayString = userData["timeOfDay"];
            TimeOfDay = GetTimeOfDay(timeOfDayString);

            string prefarableHoursStr = userData["prefarableHoursToWork"];
            PrefarableHoursToWork = GetPrefarableAmountOfHours(prefarableHoursStr);


            WorkInWeekends = GetWeekends(userData["weekends"].ToLower());
        }



        private int[] GetHoursOfWork(int age)
        {
            int hours = 0;

            if (age > 14 && age < 18)
            {
                hours = 15;
            }
            else if (age >= 18)
            {
                hours = 16;
            }
            else
            {
                hours = 16; //Just in case...
            }

            return new int[] { 7, 7 + hours };
        }

        private int GetTimeOfDay(string timeOfDayString)
        {
            if (timeOfDayString.ToLower() == "morning")
            {
                return 0;
            }
            else if (timeOfDayString.ToLower() == "afternoon")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private int GetPrefarableAmountOfHours(string prefarableStr)
        {
            if (prefarableStr.ToLower() == "2 hours")
            {
                return 2;
            }
            else if (prefarableStr.ToLower() == "3 hours")
            {
                return 3;
            }
            else if (prefarableStr.ToLower() == "4 hours")
            {
                return 4;
            }
            else if (prefarableStr.ToLower() == "5 hours")
            {
                return 5;
            }
            else if (prefarableStr.ToLower() == "6 hours")
            {
                return 6;
            }
            else if (prefarableStr.ToLower() == "7 hours")
            {
                return 7;
            }
            else
            {
                return 100000;
            }
        }

        private bool GetWeekends(string weekends)
        {
            if (weekends.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool GetWorkInRow(string wayOfWork)
        {
            if (wayOfWork.ToLower() == "in a row")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
