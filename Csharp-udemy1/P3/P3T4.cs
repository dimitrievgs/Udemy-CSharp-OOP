/*
 * Upside Down Triangle
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Solution
{
    public static void Main(string[] args)
    {
        const int top = 10;
        for (int i = 0; i < top; i++)
        {
            for (int j = 0; j < top - i; j++)
            {
                Console.Write("0 ");
            }
            Console.WriteLine();
        }
    }
}
