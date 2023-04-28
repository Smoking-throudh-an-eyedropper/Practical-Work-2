using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static WeatherApp.Movie;

namespace WeatherApp
{
    internal class Movie
    {
        public enum TheGenresOfTheFilms
        {
            Action,
            Comedy,
            Drama,
            Romance,
            SciFi
        }
        private string _theNameOfTheMovie;
        private double _duration;
        private uint _ageRestriction;
        private TheGenresOfTheFilms _theGenreOfTheFilm = TheGenresOfTheFilms.Action;
        public string TheNameOfTheMovie
        {
            get { return _theNameOfTheMovie; }
            private set { _theNameOfTheMovie = value; }
        }
        public double Duration
        {
            get { return _duration; }
            private set { _duration = value; }
        }
        public uint AgeRestriction
        {
            get { return _ageRestriction; }
            private set { _ageRestriction = value; }
        }
        public TheGenresOfTheFilms TheGenreOfTheFilm
        {
            get { return _theGenreOfTheFilm; }
            private set { _theGenreOfTheFilm = value; }
        }
        public Movie(string theNameOfTheMovie, double duration, uint ageRestriction, TheGenresOfTheFilms theGenreOfTheFilm)
        {
            TheNameOfTheMovie = theNameOfTheMovie;
            Duration = duration;
            AgeRestriction = ageRestriction;
            TheGenreOfTheFilm = theGenreOfTheFilm;
        }
        public void Read()
        {
            Console.WriteLine("Укажите название фильма:");
            TheNameOfTheMovie = Convert.ToString(Console.Read());
            Console.WriteLine("Укажите длительность фильма:");
            Duration = Convert.ToDouble(Console.Read());
            Console.WriteLine("Укажите возрастное ограничение фильма:");
            AgeRestriction = Convert.ToUInt32(Console.Read());
            Console.WriteLine("Укажите жанр фильма:");
            TheGenreOfTheFilm = TheGenresOfTheFilms.Action;
            Console.WriteLine("");
        }
        public void Display()
        {
            Console.WriteLine("Movie");
            Console.WriteLine($"TheNameOfTheMovie:{TheNameOfTheMovie}");
            Console.WriteLine($"Duration:{Duration}");
            Console.WriteLine($"AgeRestriction:{AgeRestriction}");
            Console.WriteLine($"TheGenreOfTheFilm:{TheGenreOfTheFilm}");
        }
    }
}
