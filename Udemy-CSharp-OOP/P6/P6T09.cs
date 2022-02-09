// Caesar Cipher App

using System;
using System.Collections.Generic;
using System.Text;

namespace P6T09
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            WriteLine("Welcome!");
            bool repeat = true;
            while (repeat)
            {
                WriteLine("What do you want? (0 = Encrypt, 1 = Decrypt)");
                string input = ReadLine();
                int.TryParse(input, out int action);
                if (action == 0)
                    Encrypt();
                else if (action == 1)
                    Decrypt();
                WriteLine("Repeat? (Y = Yes, N = No)");
                input = ReadLine();
                repeat = (input.Length > 0 && char.ToLower(input[0]) == 'y');
            }
            WriteLine("Goodbye!");
        }

        private static void Encrypt()
        {
            WriteLine("Enter the message to encrypt:");
            string input = ReadLine();
            WriteLine("Enter the shift:");
            string strShift = ReadLine();
            int.TryParse(strShift, out int shift);
            WriteLine($"Encrypted text with shift {shift}:");
            string encrypted = CaesarCipher.Encrypt(input, shift);
            WriteLine(encrypted);
        }

        private static void Decrypt()
        {
            WriteLine("Enter the message to decrypt:");
            string input = ReadLine();
            WriteLine("Enter the shift:");
            string strShift = ReadLine();
            int.TryParse(strShift, out int shift);
            WriteLine($"Decrypted text with shift {shift}:");
            string decrypted = CaesarCipher.Decrypt(input, shift);
            WriteLine(decrypted);
        }

        private static void WriteLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private static string ReadLine()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string text = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return text;
        }
    }

    class CaesarCipher
    {
        public static string Encrypt(string plainText, int shift)
        {
            return ShiftText(plainText, shift);
        }

        public static string Decrypt(string cipherText, int shift)
        {
            return ShiftText(cipherText, -shift);
        }

        private static string ShiftText(string text, int shift)
        {
            char[] inputArray = text.ToCharArray();
            char[] outputArray = new char[text.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                char c = inputArray[i];
                if (char.IsLetter(c))
                {
                    char shiftedC = (char)(char.ToLower(c) + shift);
                    c = (char)(c + shift);
                    if (shiftedC > 'z')
                        c = (char)(c - 26);
                    else if (shiftedC < 'a')
                        c = (char)(c + 26);
                }
                outputArray[i] = c;
            }
            return string.Concat(outputArray);
        }
    }
}
