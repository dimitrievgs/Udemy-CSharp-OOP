/*
 * Weekdays and Colors
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System.Drawing;

public class Solution
{
    private static ConsoleColor[] dayColors =
        new ConsoleColor[] { ConsoleColor.Blue, ConsoleColor.Gray,
            ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.White,
            ConsoleColor.Yellow, ConsoleColor.Green };

    public static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;
        var dW = dateTime.DayOfWeek;
        int dayColorIndex = (((int)dW) + 6) % 7;
        ConsoleColor dayColor = dayColors[dayColorIndex];
        Console.Write("Today is ");
        Console.ForegroundColor = dayColor;
        Console.WriteLine($"{dW}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
