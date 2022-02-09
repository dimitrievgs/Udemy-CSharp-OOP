// Time Machine

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace P2T02
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int day = 0, month = 0, year = 0;
            DateTime dateTime = new DateTime();

            while (dateTime.Year == 1 && dateTime.Month == 1 && dateTime.Day == 1)
            {
                Console.WriteLine("Enter the day...");
                int.TryParse(Console.ReadLine(), out day);
                Console.WriteLine("Enter the month...");
                int.TryParse(Console.ReadLine(), out month);
                Console.WriteLine("Enter the year...");
                int.TryParse(Console.ReadLine(), out year);
                try
                {
                    dateTime = new DateTime(year, month, day);
                }
                catch (ArgumentOutOfRangeException)
                { }
            }
            string dayName = dateTime.ToString("dddd", CultureInfo.InvariantCulture);
            Console.WriteLine($"This day ({dateTime:dd-MM-yyyy}) should be {dayName}.");
        }
    }
}
