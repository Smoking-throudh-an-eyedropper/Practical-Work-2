using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeatherApp
{
    internal class TicketOffice
    {
        private uint _numberTicketOffice;
        public uint NumberTicketOffice
        {
            get { return _numberTicketOffice; }
            private set { _numberTicketOffice = value; }
        }
        public TicketOffice(uint numberTicketOffice)
        {
            if (NumberTicketOffice == null)
                throw new NullReferenceException("NumberTicketOffice");
            NumberTicketOffice = numberTicketOffice;
        }
        public void Read()
        {
            Console.WriteLine("Укажите номер кассы:");
            NumberTicketOffice = Convert.ToUInt32(Console.Read());
            Console.WriteLine("");
        }
        public void Display()
        {
            Console.WriteLine("TicketOffice");
            Console.WriteLine($"NumberTicketOffice:{NumberTicketOffice}");
        }
    }
}
