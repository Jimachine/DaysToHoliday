using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysToHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime holidayStart = new DateTime(2019, 8, 26);
            DateTime today = DateTime.Now;

            TimeSpan daysToGo = holidayStart.Date - today.Date;

            Console.WriteLine("There are " + daysToGo.ToString("dddd").TrimStart('0') + "days to go until your holiday!");
        }
    }
}
