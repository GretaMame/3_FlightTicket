using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class ElectronicTicket : ITicket
    {
        public decimal TicketPrice{get; set;}
        public ElectronicTicket()
        {
            TicketPrice = 100m;
            Console.WriteLine("Electronic ticket created");
            Console.WriteLine("Original price: " + TicketPrice);
        }

        public decimal GetPrice()
        {
            Console.WriteLine("Ticket price: " + TicketPrice);
            return TicketPrice;
        }
    }
}
