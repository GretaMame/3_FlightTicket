using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class ExcessLuggage : TicketDecorator
    {

        public ExcessLuggage(ITicket ticket)
        {
            Console.WriteLine("Excess luggage added to ticket price.");
            this.ticket = ticket;
        }

        public override decimal GetPrice()
        {
            Console.WriteLine("Excess luggage: "+ 30m);
            return ticket.GetPrice() + 30m;
        }

        public override ITicket RemoveDecorator()
        {
            if (ticket is PriorityBoarding)
            {
                Console.WriteLine("Removing excess luggage");
                return ticket;
            }
            else return ticket;
        }
    }
}
