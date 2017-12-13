using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class CarRental : ITicketExtension
    {
        decimal rentalCarPrice;
        public Ticket ticket { private get; set;}

        public CarRental()
        {
            Console.WriteLine("Car rental added to ticket.");
            rentalCarPrice = 100m;
        }

        public decimal CalculatePrice()
        {
            Console.WriteLine("Car rental: " + rentalCarPrice);
            return ticket.CalculatePrice() + rentalCarPrice;
        }
    }
}
