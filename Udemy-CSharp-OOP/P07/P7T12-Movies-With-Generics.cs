// Enhancement of movies exercise (generic exercise)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace P7T12
{
    class Solution
    {
        public static void Main(string[] args)
        {
            var movie = new Movie<string, string> (
                "The Merchant of Venice", "Michael Radford",
                7.0d, new DateTime(2004, 9, 3),
                new List<Genre> { Genre.Drama, Genre.Romance },
                new List<Language> { Language.English },
                new List<Country> { Country.GreatBritain, Country.Luxembourg, Country.Italy });
            var movies = new List<Movie<string, string>>();
            movies.Add(movie);
            ShowMovies(movies);
        }

        private static void ShowMovies<T, V>(List<Movie<T, V>> moviesList)
        {
            foreach (var movie in moviesList)
                movie.ShowInfo();
        }
    }

    public struct Movie<T, V>
    {
        private T name;
        private V director;
        private double rate;
        private DateTime releaseDate;
        private List<Genre> genres;
        private List<Language> languages;
        private List<Country> countries;

        public Movie(T name, V director, double rate, DateTime releaseDate,
            List<Genre> genres, List<Language> languages,
            List<Country> countries)
        {
            this.name = name;
            this.director = director;
            this.rate = rate;
            this.releaseDate = releaseDate;
            this.genres = genres;
            this.languages = languages;
            this.countries = countries;
        }

        public T Name
        {
            get => name;
            set => name = value;
        }

        public V Director
        {
            get => director;
            set => director = value;
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
            Console.WriteLine($"Director: {director}");
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
        Mexico,
        GreatBritain,
        Luxembourg,
        Italy
    }
}
