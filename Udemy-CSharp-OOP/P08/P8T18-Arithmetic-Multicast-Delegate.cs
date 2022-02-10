// Math Operations - Arithmetic operations and multicast delegate

using System;
using System.Collections.Generic;
using System.Text;

namespace P8T18
{
    class Solution
    {
        private delegate void MathMethod(double x, double y);

        public static void Main(string[] args)
        {
            MathMethod performArithmeticOperations = null;
            performArithmeticOperations += Add;
            performArithmeticOperations += Subtract;
            performArithmeticOperations += Multiply;
            performArithmeticOperations += Divide;
            performArithmeticOperations += Rem;
            Console.WriteLine("Enter double numbers x and y:");
            int x, y;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            performArithmeticOperations(x, y);
        }

        private static void Add(double x, double y)
        => Console.WriteLine($"{x} + {y} = {x + y}");

        private static void Subtract(double x, double y)
        => Console.WriteLine($"{x} - {y} = {x - y}");

        private static void Multiply(double x, double y)
        => Console.WriteLine($"{x} * {y} = {x * y}");

        private static void Divide(double x, double y)
        => Console.WriteLine($"{x} / {y} = {x / y}");

        private static void Rem(double x, double y)
        => Console.WriteLine($"{x} % {y} = {x % y}");
    }
}
