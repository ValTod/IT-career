using System;

namespace p01_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var days = new string []{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
                Console.WriteLine(days[day - 1]);
            else
                Console.WriteLine("Invalid day!");
        }
    }
}
