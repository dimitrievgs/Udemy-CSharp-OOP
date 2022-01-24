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
	static string s = "d";

	public static void Main(string[] args)
	{
		Console.WriteLine(s);
		DoSmth();
		Console.WriteLine(s);
		
	}

	private static void DoSmth()
    {
		s = "dfdf";
		Console.WriteLine(s);
	}
}
