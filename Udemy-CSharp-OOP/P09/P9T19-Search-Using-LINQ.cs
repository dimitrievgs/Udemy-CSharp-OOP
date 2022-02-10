//Search in a list using LINQ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P9T19
{
    class Solution
    {
        public static void Main(string[] args)
        {
            List<P7T15.Employee> employees = new List<P7T15.Employee>();
            WriteLine("How many employees need to be generated?");
            int employeesNr = 0;
            int.TryParse(ReadLine(), out employeesNr);
            for (int i = 0; i < employeesNr; i++)
            {
                P7T15.Employee employee = new P7T15.Employee(i);
                employees.Add(employee);
            }
            ShowEmployees(employees);

            bool continueFiltering = true;
            do
            {
                string property = SelectProperty();
                var range = SelectRange();
                var filteredList = FilterEmployees(employees, property, range.Left, range.Right);
                ShowEmployees(filteredList);
                WriteLine("Continue? (Yes, No)");
                continueFiltering = "Yes".Contains(ReadLine().ToLower().Trim());
            }
            while (continueFiltering);
        }

        private static void ShowEmployees(List<P7T15.Employee> employees, ConsoleColor color = ConsoleColor.Cyan)
        {
            Console.ForegroundColor = color;
            WriteLine("-----\nEmployees:");
            int employeesNr = employees.Count;
            for (int i = 0; i < employeesNr; i++)
            {
                employees[i].ShowInfo();
            }
            WriteLine("-----");
            Console.ForegroundColor = color;
        }

        private static List<string> properties = new List<string> { "id", "firstName", "lastname", "salary", "age" };

        private static string SelectProperty()
        {
            int propertyIndex = -1;
            while (propertyIndex == -1)
            {
                WriteLine($"Select property to filter list ({string.Join(", ", properties)}):");
                string response = ReadLine().ToLower();
                propertyIndex = properties.FindIndex(o => o.Contains(response));
            }
            return properties[propertyIndex];
        }

        private static (string Left, string Right) SelectRange()
        {
            string a = "", b = "";
            while (string.IsNullOrWhiteSpace(a) && string.IsNullOrWhiteSpace(b))
            {
                WriteLine($"Select property's range to filter list:");
                a = ReadLine();
                b = ReadLine();
            }
            return (a, b);
        }

        private static List<P7T15.Employee> FilterEmployees(List<P7T15.Employee> employees, string propertyName, string left, string right)
        {
            List<P7T15.Employee> filteredList = null;
            double dLeft, dRight;
            switch (propertyName)
            {
                case "id":
                    double.TryParse(left, out dLeft);
                    double.TryParse(right, out dRight);
                    filteredList = (from emp in employees where (emp.ID >= dLeft && emp.ID <= dRight) select emp).ToList();
                    break;
                case "firstName":
                    filteredList = (from emp in employees where (emp.FirstName.CompareTo(left) >= 0 && emp.FirstName.CompareTo(right) <= 0) select emp).ToList();
                    break;
                case "lastname":
                    filteredList = (from emp in employees where (emp.Lastname.CompareTo(left) >= 0 && emp.Lastname.CompareTo(right) <= 0) select emp).ToList();
                    break;
                case "salary":
                    double.TryParse(left, out dLeft);
                    double.TryParse(right, out dRight);
                    filteredList = (from emp in employees where (emp.Salary >= dLeft && emp.Salary <= dRight) select emp).ToList();
                    break;
                case "age":
                    double.TryParse(left, out dLeft);
                    double.TryParse(right, out dRight);
                    filteredList = (from emp in employees where (emp.Age >= dLeft && emp.Age <= dRight) select emp).ToList();
                    break;
            }
            int k = employees[0].FirstName.CompareTo(left);
            int k2 = employees[0].FirstName.CompareTo(right);
            return filteredList;
        }

        private static string ReadLine(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            string text = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return text;
        }

        private static void WriteLine(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
