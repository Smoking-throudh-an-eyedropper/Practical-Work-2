using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static WeatherApp.Movie;

namespace WeatherApp
{
    internal class Ticket
    {
        private DateTime _time;
        private uint _price;
        private uint _place;
        private Movie _movie;
        private CinemaHall _cinemaHall;
        public DateTime Time
        {
            get { return _time; }
            private set { _time = value; }
        }
        public uint Price
        {
            get { return _price; }
            private set { _price = value; }
        }
        public uint Place
        {
            get { return _place; }
            private set { _place = value; }
        }
        public Movie Movie
        {
            get { return _movie; }
            private set { _movie = value; }
        }
        public CinemaHall CinemaHall
        {
            get { return _cinemaHall; }
            private set { _cinemaHall = value; }
        }
        public Ticket(DateTime time, uint price, uint place, Movie movie, CinemaHall cinemaHall)
        {
            if (Time == null)
                throw new NullReferenceException("Time");
            Time = time;
            Price = price;
            Place = place;
            Movie = movie;
            CinemaHall = cinemaHall;
        }
        public void Read()
        {
            Console.WriteLine("Укажите время:");
            Time = Convert.ToDateTime(Console.Read());
            Console.WriteLine("Укажите цену:");
            Price = Convert.ToUInt32(Console.Read());
            Console.WriteLine("Укажите место:");
            Place = Convert.ToUInt32(Console.Read());
            Console.WriteLine("Укажите фильм:");
            Movie Movie = new Movie(Convert.ToString(Console.Read()), Convert.ToDouble(Console.Read()), Convert.ToUInt32(Console.Read()), Movie.TheGenresOfTheFilms.Action);
            Console.WriteLine("Укажите зал:");
            CinemaHall CinemaHall =  new CinemaHall(Convert.ToString(Console.Read()), Convert.ToUInt32(Console.Read()));
        }
        public void Display()
        {
            Console.WriteLine("Ticket");
            Console.WriteLine($"Time:{Time}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Place:{Place}");
            Console.WriteLine($"Movie:{Movie}");
            Console.WriteLine($"CinemaHall:{CinemaHall}");
        }
    }
}