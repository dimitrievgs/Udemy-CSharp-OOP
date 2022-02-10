// Enhancement of Jagged Multidimensional Array

using System;
using System.Collections.Generic;
using System.Text;

namespace P10T24
{
    class Solution
    {
        public static void Main(string[] args)
        {
            var jaggedArray = AskToFillJaggedArray();
            ShowJaggedArray(jaggedArray);
        }

        private static object[][,] AskToFillJaggedArray()
        {
            int z = 0, y = 0, x = 0;
            while (z == 0)
            {
                WriteLine("Enter the number of 2D arrays in jagged array:");
                int.TryParse(ReadLine(), out z);
            }
            object[][,] jaggedArray = new object[z][,];
            for (int k = 0; k < z; k++)
            {
                WriteLine($"k = {k}:");
                y = 0;
                while (y == 0)
                {
                    WriteLine("Enter the number of rows:");
                    int.TryParse(ReadLine(), out y);
                }
                x = 0;
                while (x == 0)
                {
                    WriteLine("Enter the number of columns:");
                    int.TryParse(ReadLine(), out x);
                }
                object[,] array2D = AskToFillArray2D(x, y);
                jaggedArray[k] = array2D;
            }
            return jaggedArray;
        }

        private static object[,] AskToFillArray2D(int x, int y)
        {
            object[,] array2D = new object[y, x];
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    WriteLine($"Element at y = {j}, x = {i}:");
                    string s = Console.ReadLine();
                    array2D[j, i] = s;
                }
            }
            return array2D;
        }

        private static void ShowJaggedArray(object[][,] jaggedArray)
        {
            WriteLine("Result jagged array:", ConsoleColor.Gray);
            int z = jaggedArray.Length;
            for (int k = 0; k < z; k++)
            {
                WriteLine("-------------------", ConsoleColor.Gray);
                WriteLine($"k = {k}", ConsoleColor.Gray);
                object[,] array2D = jaggedArray[k];
                int y = array2D.GetLength(0);
                int x = array2D.GetLength(1);
                for (int j = 0; j < y; j++)
                {
                    for (int i= 0; i < x; i++)
                    {
                        Write(array2D[j, i] + "\t", ConsoleColor.Cyan);
                    }
                    WriteLine("");
                }
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
