// List of employees: create a list of 12 different employees

using System;
using System.Collections.Generic;
using System.Text;

namespace P7T15
{
    class Solution
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 12; i++)
            {
                Employee employee = new Employee(i);
                employees.Add(employee);
                employee.ShowInfo();
            }
        }
    }

    class Employee
    {
        private int id;
        private string firstName;
        private string lastname;
        private double salary;
        private int age;
        private int[] grades;

        Random random = new Random();

        public Employee(int id)
        {
            this.id = id;
            this.firstName = RandomName();
            this.lastname = RandomName();
            this.salary = RandomSalary();
            this.age = RandomAge();
            this.grades = RandomGrades(4);
        }

        public Employee(int id, string firstName, string lastname, double salary, int age, int[] grades)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastname = lastname;
            this.salary = salary;
            this.age = age;
            this.grades = grades;
        }

        public int ID
        {
            get => id; 
            set => id = value; 
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public int[] Grades
        {
            get => grades;
            set => grades = value;
        }

        private char RandomChar()
        {
            return (char)random.Next(97, 122);
        }

        private string RandomName()
        {
            int length = random.Next(1, 10);
            StringBuilder s = new StringBuilder();
            s.Append(char.ToUpper(RandomChar()));
            for (int i = 0; i < length; i++)
                s.Append(RandomChar());
            return s.ToString();
        }

        private double RandomSalary()
        {
            return random.NextDouble() * 4000;
        }

        private int RandomAge()
        {
            return random.Next(18, 100);
        }

        private int[] RandomGrades(int number)
        {
            int[] grades = new int[number];
            for (int i = 0; i < number; i++)
                grades[i] = random.Next(1, 10);
            return grades;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID = {id}, name = {firstName} {lastname}, salary = {salary:F2}, age = {age}, grades = {string.Join("/", grades)}.");
        }
    }
}
