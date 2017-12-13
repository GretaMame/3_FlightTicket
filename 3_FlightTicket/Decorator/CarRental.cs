using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class CarRental : TicketDecorator
    {
        decimal rentalCarPrice;

        public CarRental(ITicket ticket) : base(ticket)
        {
            rentalCarPrice = 100m;
        }


        public override decimal CalculatePrice()
        {
            Console.WriteLine("Car rental: " + rentalCarPrice);
            return base.CalculatePrice() + rentalCarPrice;
        }
    }
}
