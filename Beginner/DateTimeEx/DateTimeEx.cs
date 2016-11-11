using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx
{
    class DateTimeEx
    {
        static void Main(string[] args)
        {
            // DateTime ----------------------------
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour is: " + now.Hour);
            Console.WriteLine("Minute is: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            //Convert to string - format options
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToString());

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //Time Span
            var timeSpan = new TimeSpan(1, 2, 3);
            TimeSpan.FromHours(1); // equal to (1, 0, 0)

            //Difference between two DateTimes is a TimeSpan
            var startTime = DateTime.Now;
            var endTime = DateTime.Now.AddHours(2);
            var duration = endTime - startTime;
            Console.WriteLine("Duration: " + duration);

            //two types - value and totalValue
            Console.WriteLine("minutes: " + timeSpan.Minutes);
            //total - includes hour and seconds as part of calculation
            Console.WriteLine("total minutes: " + timeSpan.TotalMinutes);

            // Add and subtract to timeSpan
            Console.WriteLine("Addition: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtraction: " + timeSpan.Subtract(TimeSpan.FromMinutes(4)));

            // ToString
            Console.WriteLine("To String: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
