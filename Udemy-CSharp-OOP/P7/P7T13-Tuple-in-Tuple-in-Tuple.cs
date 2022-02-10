// Tuple in tuple in tuple -> took ValueTuple for clarity

using System;
using System.Collections.Generic;
using System.Text;

namespace P7T13
{
    class Solution
    {
        public static void Main(string[] args)
        {
            ((double Plains, double Islands, double Mountains, double Forests) Land, 
                ((double PacificOcean, double AtlanticOcean, double IndianOcean, double ArcticOcean, double SouthOcean) WorldOcean,
                double GroundWater, double Glaciers, double Lakes) Water) earthArea
                = ((96d, 60d, 56d, 40d), 
                ((169.2d, 91.6d, 73.6d, 14.8d, 20.3d), 
                134.8d, 16.2d, 2.1d)); //million of square kilometers 
            Console.WriteLine($"The area of the Pacific Ocean is {earthArea.Water.WorldOcean.PacificOcean} million km2.");
        }
    }
}
