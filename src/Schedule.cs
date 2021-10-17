using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace YourTable
{
    class Schedule
    {
        int id;
        string name;
        string date; //The date the task would take place in
        int hour; //the hour

        public Schedule(int id, string name, string date, int hour)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.hour = hour;
        }
    }
}
