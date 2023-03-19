using System;

namespace DateTimeTimeSpan
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(1998, 04, 22);
            Console.WriteLine("Day of the week: {0}", awesomeDate.DayOfWeek);

            awesomeDate.AddDays(4);
            awesomeDate.AddMonths(3);
            awesomeDate.AddYears(2);

            Console.WriteLine("New Date: {0}", awesomeDate.Date);


            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));

            Console.WriteLine("TimeSpan: {0}", lunchTime.ToString());
        }
    }
}