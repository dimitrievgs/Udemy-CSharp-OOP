// Multidimensional Arrays Assignment

using System;
using System.Collections.Generic;
using System.Text;

namespace P10T23
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int y = 0;
            while (y == 0)
            {
                WriteLine("Enter the number of rows:");
                int.TryParse(ReadLine(), out y);
            }
            int x = 0;
            while (x == 0)
            {
                WriteLine("Enter the number of columns:");
                int.TryParse(ReadLine(), out x);
            }
            string[,] array2D = FillArray(x, y);
            WriteLine("The table:");
            WriteLine("----------------------------");
            ShowArray(array2D, x, y);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static string[,] FillArray(int x, int y)
        {
            string[,] array2D = new string[y, x];
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    array2D[j, i] = "R" + (j + 1) + "C" + (i + 1);
                }
            }
            return array2D;
        }

        private static void ShowArray(string[,] array2D, int x, int y)
        {
            for (int j = 0; j <= y + 1; j++)
            {
                for (int i = 0; i <= x; i++)
                {
                    if (j == 0)
                    {
                        if (i == 0)
                            Write("      ", ConsoleColor.Gray);
                        else
                            Write("\tColumn " + i, ConsoleColor.Gray);
                    }
                    else if (j == 1)
                    {
                        if (i == 0)
                            Write("      ");
                        else
                            Write("\t--------", ConsoleColor.Gray);
                    }
                    else
                    {
                        if (i == 0)
                            Write("Row " + (j - 1), ConsoleColor.Gray);
                        else
                            Write("\t" + array2D[j - 2, i - 1] + "\t", ConsoleColor.Cyan);
                    }
                }
                WriteLine("");
            }
        }

        private static string ReadLine(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            string text = Console.ReadLine();
            return text;
        }

        private static void WriteLine(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }

        private static void Write(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
        }
    }
}
