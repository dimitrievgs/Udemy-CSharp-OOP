// Fastest task

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P9T21
{
    class Solution
    {
        private static CancellationTokenSource cTSource = new CancellationTokenSource();
        private static CancellationToken token = cTSource.Token;

        public static void Main(string[] args)
        {
            WriteLine("How many iterations are needed for each task?");
            int n = 0;
            while (n == 0)
                int.TryParse(ReadLine(), out n);
            Task task1 = new Task(() => DoTask("One", n, ConsoleColor.Yellow));
            Task task2 = new Task(() => DoTask("Two", n, ConsoleColor.Blue));
            task1.Start();
            task2.Start();
            Task.WaitAll(task1, task2);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void DoTask(string taskName, int n, ConsoleColor color)
        {
            //Task One take number: 2
            int i = 0;
            for (i = 0; i < n; i++)
            {
                if (!token.IsCancellationRequested)
                    WriteLine($"Task {taskName} takes number: {i}.", color);
                else
                {
                    WriteLine($"Task {taskName} is cancelled at iteration = {i}.", color);
                    return;
                }
            }
            WriteLine($"Task {taskName} is completed at iteration = {i}.", color);
            cTSource.Cancel();
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
    }
}
