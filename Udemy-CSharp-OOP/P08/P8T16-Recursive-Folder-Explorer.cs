// Enhancement of recursive methods exercise

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P8T16
{
    class Solution
    {
        public static void Main(string[] args)
        {
            bool dirExists = false;
            string path = "";
            while (!dirExists)
            {
                WriteLine("Enter the path to explore:");
                path = ReadLine();
                dirExists = Directory.Exists(path);
            }
            WriteLine("-----");
            ExploreFolder(path, 0);
        }

        private static string ReadLine(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            string text = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return text;
        }

        private static void Write(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void WriteLine(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ExploreFolder(string folder, int n)
        {
            string folderName = folder.Remove(0, folder.LastIndexOf('\\') + 1);
            string leftGap = (string.Concat(Enumerable.Repeat("  ", n)));
            string leftDirGap = leftGap + "+";
            string leftFileGap = leftGap + " ";
            WriteLine(leftDirGap + folderName, ConsoleColor.Gray);
            DirectoryInfo d = new DirectoryInfo(folder);
            FileInfo[] files = d.GetFiles("*");
            foreach (FileInfo fi in files)
            {
                Write($"{leftFileGap}{fi.Name}", ConsoleColor.Red);
                WriteLine($" - {fi.CreationTime:dd.MM.yyyy hh:mm:ss}", ConsoleColor.Blue);
            }
            string[] subfolders = Directory.GetDirectories(folder);
            foreach (string subfolder in subfolders)
                ExploreFolder(subfolder, n + 1);
        }
    }
}
