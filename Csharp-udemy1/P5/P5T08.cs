// Dog interface

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace P5T08
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            ShowDogActions();
            ShowDogActions("Peter");
        }

        private static void ShowDogActions()
        {
            GermanShepard dog = new GermanShepard("Dog", DateTime.Now,
                Country.Brazil, 0.6d, 30, false);
            dog.ShowPossibleActions();
        }

        private static void ShowDogActions(string name)
        {
            GermanShepard dog = new GermanShepard(name, DateTime.Now,
                Country.Mexico, 0.6d, 30, true);
            dog.ShowPossibleActions();
        }
    }

    public class Animal
    {
        private string name;
        private DateTime birthDate;
        private Country origin;

        public Animal(string name, DateTime birthDate, Country origin)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.origin = origin;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public Country Origin
        {
            get { return origin; }
            set { origin = value; }
        }
    }

    public interface IDog
    {
        void Eat();
        void Drink();
        void Sit();
        void SayHi();
    }

    public class GermanShepard : Animal, IDog
    {
        private double height;
        private double weight;
        private bool trained;

        public GermanShepard(string name, DateTime birthDate, Country country,
            double height, double weight, bool trained) 
            : base(name, birthDate, country)
        {
            this.height = height;
            this.weight = weight;
            this.trained = trained;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public bool Trained
        {
            get { return trained; }
            set { trained = value; }
        }

        public void Drink()
        {
            Console.WriteLine($"{Name} drinks");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eats");
        }

        public void SayHi()
        {
            Console.WriteLine($"{Name} says \"Hi!\"");
        }

        public void Sit()
        {
            Console.WriteLine($"{Name} sits");
        }

        public void ShowPossibleActions()
        {
            Console.WriteLine($"The dog name is {Name}, was born on {BirthDate:dd-MM-yyyy}");
            string strWeight = Weight.ToString("F2", CultureInfo.InvariantCulture);
            string strHeight = Height.ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine($"{Name} weights {strWeight} and its height is {strHeight} m");
            Drink();
            Eat();
            SayHi();
            Sit();
        }
    }

    public enum Country
    {
        China,
        India,
        UnitedStates,
        Indonesia,
        Pakistan,
        Brazil,
        Nigeria,
        Bangladesh,
        Russia,
        Mexico
    }
}