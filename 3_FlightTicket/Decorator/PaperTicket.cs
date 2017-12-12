using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class PaperTicket : ITicket
    {
        public decimal TicketPrice { get; set; }
        public PaperTicket()
        {
            TicketPrice = 120m;
            Console.WriteLine("Paper ticket created.");
            Console.WriteLine("Original price: "+ TicketPrice);
        }
        public decimal GetPrice()
        {
            Console.WriteLine("Ticket price: " + TicketPrice);
            return TicketPrice;
        }
    }
}
