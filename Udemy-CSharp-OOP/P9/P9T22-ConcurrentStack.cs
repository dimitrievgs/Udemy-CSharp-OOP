using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace P9T22
{
    class Solution
    {
        private static ConcurrentStack<string> stack = new ConcurrentStack<string>();
        private static string[] threadNames = new string[] { "a", "b" };
        private static Dictionary<string, int> poppedElementsNumber = 
            new Dictionary<string, int>
            {
                { threadNames[0], 0 },
                { threadNames[1], 0 }
            };

        public static void Main(string[] args)
        {
            WriteLine("How many elements are needed for stack?");
            int n = 0;
            while (n == 0)
                int.TryParse(ReadLine(), out n);

            Thread thread1 = new Thread(new ThreadStart(() => PushStackWithIntegers(threadNames[0], n)));
            Thread thread2 = new Thread(new ThreadStart(() => PushStackWithIntegers(threadNames[1], n)));
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            Thread thread3 = new Thread(new ThreadStart(() => PopStack(threadNames[0])));
            Thread thread4 = new Thread(new ThreadStart(() => PopStack(threadNames[1])));
            thread3.Start();
            thread4.Start();
            thread3.Join();
            thread4.Join();

            foreach (string threadName in threadNames)
            {
                int number = poppedElementsNumber[threadName];
                WriteLine($"Thread {threadName} accessed {poppedElementsNumber[threadName]} elements.");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void PushStackWithIntegers(string threadName, int n)
        {
            for (int i = 0; i < n; i++)
            {
                stack.Push(threadName + i);
                Thread.Sleep(50);
            }
        }

        private static void PopStack(string threadName)
        {
            int i = 0;
            while (!stack.IsEmpty)
            {
                if (stack.TryPop(out string result))
                {
                    WriteLine(threadName + " pops " + result);
                    i++;
                }
            }
            poppedElementsNumber[threadName] = i;
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
