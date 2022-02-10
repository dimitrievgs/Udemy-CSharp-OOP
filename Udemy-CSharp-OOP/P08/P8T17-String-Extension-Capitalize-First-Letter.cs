// Capitalize First Letter in a string

using System;
using System.Collections.Generic;
using System.Text;

namespace P8T17
{
    class Solution
    {
        public static void Main(string[] args)
        {
            WriteLine("Print a string:");
            string text = ReadLine();
            string textCFL = text.CapitalizeFirstLetter();
            WriteLine("String with capitalized first letter:");
            WriteLine(textCFL);
        }

        private static string ReadLine(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            string text = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return text;
        }

        private static void WriteLine(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    static class StringExtension
    {
        public static string CapitalizeFirstLetter(this string s)
        {
            string result = s;
            int sLength = s.Length;
            if (sLength > 0)
            {
                string sFirst = s.Substring(0, 1).ToUpper();
                string sRemained = s.Substring(1);
                s = sFirst + sRemained;
            }
            return s;
        }
    }
}
