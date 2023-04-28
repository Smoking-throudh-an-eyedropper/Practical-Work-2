using System;
using System.Collections.Generic;

namespace WeatherApp
{
    public class TicketDatabase
    {
        private Random _random = new Random();
        private uint RandomPraice
        {
            get => Convert.ToUInt32(_random.Next(100, 200));
        }
        private uint RandomPlace
        {
            get => Convert.ToUInt32(_random.Next(0, 500));
        }
        internal List<Ticket> Tickets 
        {
            get;
            private set;
        }

        public void Initialize()
        {
            Tickets = new List<Ticket>
            {
                new Ticket(new DateTime(2023,04,25,07,20,0),RandomPraice, RandomPlace, new Movie("Этот глупый свин не понимает мечту девочки зайки", 0.55, 16, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,08,20,0),RandomPraice, RandomPlace, new Movie("Страна чудес смертников", 0.45, 18, Movie.TheGenresOfTheFilms.Action), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,09,20,0),RandomPraice, RandomPlace, new Movie("Вайолет Эвергарден", 0.47, 18, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,10,20,0),RandomPraice, RandomPlace, new Movie("Эльфийская песнь", 0.56, 18, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,11,20,0),RandomPraice, RandomPlace, new Movie("Сквозь слёзы я притворяюсь кошкой", 0.54, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,12,20,0),RandomPraice, RandomPlace, new Movie("Патема наоборот", 0.55, 16, Movie.TheGenresOfTheFilms.Action), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,13,20,0),RandomPraice, RandomPlace, new Movie("Ветер крепчает", 0.53, 12, Movie.TheGenresOfTheFilms.Romance), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,14,20,0),RandomPraice, RandomPlace, new Movie("Унесённые призраками", 0.48, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,15,20,0),RandomPraice, RandomPlace, new Movie("Девочка которая видит это", 0.50, 16, Movie.TheGenresOfTheFilms.Action), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,16,20,0),RandomPraice, RandomPlace, new Movie("Кошечка из Сакурасо", 0.52, 16, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,17,20,0),RandomPraice, RandomPlace, new Movie("86", 0.55, 18, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,18,20,0),RandomPraice, RandomPlace, new Movie("SAO", 0.45, 16, Movie.TheGenresOfTheFilms.Action), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,19,20,0),RandomPraice, RandomPlace, new Movie("K-on!", 0.46, 12, Movie.TheGenresOfTheFilms.SciFi), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,20,20,0),RandomPraice, RandomPlace, new Movie("Одинокий рокер", 0.52, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,21,20,0),RandomPraice, RandomPlace, new Movie("Человек - бензопила", 0.49, 18, Movie.TheGenresOfTheFilms.Action), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,22,20,0),RandomPraice, RandomPlace, new Movie("Твоё имя", 0.48, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,23,20,0),RandomPraice, RandomPlace, new Movie("Дитя погоды", 0.55, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,25,23,40,0),RandomPraice, RandomPlace, new Movie("5 сантиметров в минуту", 0.42, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,00,20,0),RandomPraice, RandomPlace, new Movie("Сад изящных слов", 0.44, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,01,20,0),RandomPraice, RandomPlace, new Movie("Планетарианка", 0.45, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,02,20,0),RandomPraice, RandomPlace, new Movie("Черта дьявола", 0.46, 18, Movie.TheGenresOfTheFilms.Romance), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,03,20,0),RandomPraice, RandomPlace, new Movie("Дрейфующий дом", 0.42, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,04,20,0),RandomPraice, RandomPlace, new Movie("Время евы", 0.49, 16, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,05,20,0),RandomPraice, RandomPlace, new Movie("Пластиковые воспоминания", 0.52, 16, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,06,20,0),RandomPraice, RandomPlace, new Movie("Сердце хочет кричать", 0.55, 12, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,07,20,0),RandomPraice, RandomPlace, new Movie("Укрась прощальное утро цветами обещаний", 0.43, 18, Movie.TheGenresOfTheFilms.Drama), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,08,20,0),RandomPraice, RandomPlace, new Movie("Империя пертвецов", 0.50, 18, Movie.TheGenresOfTheFilms.Action), new CinemaHall("Малый", 500)),
                new Ticket(new DateTime(2023,04,26,09,20,0),RandomPraice, RandomPlace, new Movie("Мирай из будущего", 0.47, 12, Movie.TheGenresOfTheFilms.Action), new CinemaHall("Малый", 500)),
            };
        }
    }
}