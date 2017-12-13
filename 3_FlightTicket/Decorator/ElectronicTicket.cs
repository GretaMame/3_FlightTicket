using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class ElectronicTicket : ITicket
    {
        public decimal ticketPrice;
        public ElectronicTicket()
        {
            ticketPrice = 100m;
            Console.WriteLine("Electronic ticket created");
            Console.WriteLine("Original price: " + ticketPrice);
        }

        public decimal CalculatePrice()
        {
            Console.WriteLine("Ticket price: " + ticketPrice);
            return ticketPrice;
        }

        public void ChangePrice(decimal price)
        {
            ticketPrice = price;
        }

        public decimal GetPrice()
        {
            return ticketPrice;
        }
    }
}
