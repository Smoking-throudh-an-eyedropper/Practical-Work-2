using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class DirectorScreenwriter
    {
        private string _name;
        private string _surname;
        private uint _age;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            private set { _surname = value; }
        }
        public uint Age
        {
            get { return _age; }
            private set { _age = value; }
        }
        public DirectorScreenwriter(string name, string surname, uint age)
        {
            if (Name == null)
                throw new NullReferenceException("Name");
            Name = name;
            Surname = surname;
            Age = age;
        }
        public virtual void Read()
        {
            Console.WriteLine("Укажите имя режиссёра сценариста:");
            Name = Convert.ToString(Console.Read());
            Console.WriteLine("Укажите фамилию режиссёра сценариста:");
            Surname = Convert.ToString(Console.Read());
            Console.WriteLine("Укажите возраст режиссёра сценариста:");
            Age = Convert.ToUInt16(Console.Read());
            Console.WriteLine("");
        }
        public virtual void Display()
        {
            Console.WriteLine("DirectorScreenwriter");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Surname:{Surname}");
            Console.WriteLine($"Age:{Age}");
        }
    }
}
