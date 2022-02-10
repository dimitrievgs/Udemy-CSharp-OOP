// Movie struct

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace P5T07
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            Movie movie = new Movie("Простые вещи",
                7.0d, new DateTime(2007, 7, 5),
                new List<Genre> { Genre.Comedy, Genre.Drama },
                new List<Language> { Language.Russian },
                new List<Country> { Country.Russia });
            movie.ShowInfo();
        }
    }

    public struct Movie
    {
        private string name;
        private double rate;
        private DateTime releaseDate;
        private List<Genre> genres;
        private List<Language> languages;
        private List<Country> countries;

        public Movie(string name, double rate, DateTime releaseDate,
            List<Genre> genres, List<Language> languages, 
            List<Country> countries)
        {
            this.name = name;
            this.rate = rate;
            this.releaseDate = releaseDate;
            this.genres = genres;
            this.languages = languages;
            this.countries = countries;
        }

        public string Name
        {
            get => name; 
            set => name = value;
        }

        public double Rate
        {
            get => rate;
            set => rate = value;
        }

        public DateTime ReleaseDate
        {
            get => releaseDate;
            set => releaseDate = value;
        }

        public List<Genre> Genres
        {
            get => genres;
            set => genres = value;
        }

        public List<Language> Languages
        {
            get => languages;
            set => languages = value;
        }

        public List<Country> Countries
        {
            get => countries;
            set => countries = value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Movie name: {name}");
            string strRate = rate.ToString("F1", CultureInfo.InvariantCulture);
            Console.WriteLine($"Rate (IMDB): {strRate} out of 10");
            Console.WriteLine($"Released on: {releaseDate:dd.MM.yyyy}");
            Console.WriteLine($"Languages: {string.Join(", ", languages)}");
            Console.WriteLine($"Countries: {string.Join(", ", countries)}");
            Console.WriteLine($"Genres: {string.Join(", ", genres)}");
        }
    }

    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Fantasy,
        Horror,
        Mystery,
        Romance,
        Thriller
    }

    public enum Language
    {
        ChineseMandarin,
        English,
        Spanish,
        Arabic,
        Bengali,
        Hindi,
        Russian,
        Portuguese,
        Japanese,
        German
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
