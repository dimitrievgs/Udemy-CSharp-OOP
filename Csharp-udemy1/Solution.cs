/*
 * Dice Roller
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

public class Solution
{
	public static void Main(string[] args)
	{
		int x = 0;
		int y = 0;
		string g = "g";
		String g2 = "df";
		Console.WriteLine(WeekDay.Wednesday);

        var f = 33_444_444;
        Console.WriteLine(f);

        SortedList array = new SortedList();
        array.Add("ad", "ww");

        BitArray ba = new BitArray(4);
        var t = ba[1];

        var t2 = new Tuple<int, string> (0, "s");
        var t3 = Tuple.Create(0, "s");
        Console.WriteLine(t2.Item2);

        ValueTuple<int, string> k = GetTuple();
        Console.WriteLine(k.Item2);
    }

    /*public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator()
    {

        throw new NotImplementedException();
        yield return default(ElementType);
    }*/

    private DateTime ttt;

    public DateTime MyProperty
    {
        get { return ttt; }
        set { ttt = value; }
    }

    public static (int, string) GetTuple()
    {
        return (0, "sd");
    }

}

enum WeekDay
{
	Wednesday = 3,
	Friday = 5
}
