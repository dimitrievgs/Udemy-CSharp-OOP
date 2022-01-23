/*
 * Dice Roller
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

public class Solution
{
	public static void Main(string[] args)
	{
		Random rand = new Random();
		bool continueLoop = true;
		while (continueLoop)
        {
			Console.WriteLine("Roll dice? (yes, no)");
			string answer = Console.ReadLine();
			if (answer.ToLower() == "yes")
			{
				int diceNumber = RollD6(rand);
				Console.WriteLine($"New dice number is {diceNumber}");
			}
			else
				continueLoop = false;
        }
	}

	private static int RollD6(Random rand)
    {
		return rand.Next(1, 7);
    }
}
