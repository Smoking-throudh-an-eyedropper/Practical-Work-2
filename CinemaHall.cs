using System;

namespace WeatherApp
{
    class CinemaHall
    {
        private string _title;
        private uint _numberOfSeats;
        public string Titel
        {
            get { return _title; }
            private set { _title = value; }
        }
        public uint NumberOfSeats
        {
            get { return _numberOfSeats; }
            private set { _numberOfSeats = value; }
        }
        public CinemaHall(string title, uint numberOfSeats)
        {
            Titel = title;
            NumberOfSeats = numberOfSeats;
        }
        public void Read()
        {
            Console.WriteLine("Укажите кинозал:");
            Titel = Convert.ToString(Console.Read());
            Console.WriteLine("Укажите количество мест в кинозале:");
            NumberOfSeats = Convert.ToUInt32(Console.Read());
            Console.WriteLine("");
        }
        public void Display()
        {
            Console.WriteLine("CinemaHall");
            Console.WriteLine($"Titel:{Titel}");
            Console.WriteLine($"NumberOfSeats:{NumberOfSeats}");
        }
    }
}
