using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourTable
{
    public class Month
    {
        public int daysInMonth;
        public int num;
        public string name;

        public Month(string name, int num)
        {
            this.name = name;
            this.num = num;

            if (num > 0 && num < 13)
                daysInMonth = daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, num);

            else
                daysInMonth = 0;
        }
    }
}
