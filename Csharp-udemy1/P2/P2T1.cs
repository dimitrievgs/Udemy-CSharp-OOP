/*
 * Friendly conversation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Solution
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        string appName = RandName(rand, rand.Next(3, 7));
        int appYear = rand.Next(1950, 2010);
        int appAge = DateTime.Now.Year - appYear;

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Nice to meet you {name}. My name is {appName}, How old are you?");
        int.TryParse(Console.ReadLine(), out int age);
        Console.WriteLine($"{age} is good. As I was born in " + appYear
            + " so I am " + appAge + " years old.");
    }

    private static char RandChar(Random rand)
    {
        char c = (char)((byte)('A') + rand.Next(0, 25));
        return c;
    }

    private static string RandName(Random rand, int charsNumber)
    {
        string name = "";
        for (int i = 0; i < charsNumber; i++)
            name += RandChar(rand);
        return name;
    }
}
