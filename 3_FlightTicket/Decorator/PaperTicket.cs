using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class PaperTicket : ITicket
    {
        public decimal ticketPrice { get; set; }
        public PaperTicket()
        {
            ticketPrice = 100m;
            AddPaperFee(20m);
            Console.WriteLine("Paper ticket created.");
            Console.WriteLine("Original price: "+ ticketPrice);
        }
        public decimal CalculatePrice()
        {
            Console.WriteLine("Ticket price: " + ticketPrice);
            return ticketPrice;
        }

        public void AddPaperFee(decimal fee)
        {
            ticketPrice += fee;
        }
    }
}
