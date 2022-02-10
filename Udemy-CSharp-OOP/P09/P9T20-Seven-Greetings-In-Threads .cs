// Say hi in 7 different languages

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace P9T20
{
    class Solution
    {
        public static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();
            List<string> languageCodes = Hi.GetLanguageCodes();
            int repeatNr = 0;
            while (repeatNr == 0)
            {
                Console.WriteLine("How many times to repeat?");
                int.TryParse(Console.ReadLine(), out repeatNr);
            }
            foreach (string code in languageCodes)
            {
                Thread thread = new Thread(new ThreadStart(() => Hi.SayHi(code, repeatNr)));
                threads.Add(thread);
            }
            foreach (Thread thread in threads)
                thread.Start();
            Console.ReadLine();
        }
    }

    class Hi
    {
        private static Dictionary<string, string> hiTranslations =
            new Dictionary<string, string>
            {
                { "ru", "Привет!" },
                { "en", "Hi!" },
                { "uk", "Привiт!" },
                { "fr", "Hey!" },
                { "de", "Hallo!" },
                { "it", "Ehi!" },
                { "fi", "Hei!" },
            };

        public static List<string> GetLanguageCodes()
        {
            return new List<string>(hiTranslations.Keys);
        }

        public static void SayHi(string code, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{code}: {hiTranslations[code]}");
                Thread.Sleep(100);
            }
        }
    }
}
