using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket
{
    class CarRental : TicketDecorator
    {
        public CarRental(ITicket ticket)
        {
            Console.WriteLine("Car rental added to ticket price.");
            this.ticket = ticket;
        }


        public override decimal GetPrice()
        {
            Console.WriteLine("Car rental: " + 100m);
            return ticket.GetPrice() + 100m;
        }

        public override void RemoveDecorator(TicketDecorator decorator)
        {
            if (decorator is PriorityBoarding)
            {
                Console.WriteLine("Removing car rental");
            }
        }
    }
}
