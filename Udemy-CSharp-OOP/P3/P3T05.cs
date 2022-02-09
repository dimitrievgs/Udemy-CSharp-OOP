// Months & Days

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace P3T05
{
	public class Solution
	{
		public static void Main(string[] args)
		{
			for (int i = 1; i <= 12; i++)
			{
				DateTime day = new DateTime(2022, i, 1);
				DateTime day2 = day.AddMonths(1).AddDays(-1);
				string dayOfWeek = day2.ToString("MMMM", CultureInfo.InvariantCulture);
				Console.WriteLine($"{dayOfWeek} - {day2:dd} days");
			}
		}
	}
}
