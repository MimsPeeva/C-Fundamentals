using System;

namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7];
            days[0] = "Monday";
            days[1] = "Tuesday";
            days[2] = "Wednesday";
            days[3] = "Thursday";
            days[4] = "Friday";
            days[5] = "Saturday";
            days[6] = "Sunday";
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 7)
            { Console.WriteLine(days[n-1]); }
            else { Console.WriteLine("Invalid day!"); }
        }
    }
}
