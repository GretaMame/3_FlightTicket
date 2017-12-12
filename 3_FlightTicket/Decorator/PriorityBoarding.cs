using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class PriorityBoarding : TicketDecorator
    {
        public PriorityBoarding(ITicket ticket)
        {
            Console.WriteLine("Priority boarding added to ticket price.");
            this.ticket = ticket;
        }

        public override decimal GetPrice()
        {
            Console.WriteLine("Priority boarding: " + 5m);
            return ticket.GetPrice() + 5m;
        }

        public override ITicket RemoveDecorator()
        {
            if (ticket is PriorityBoarding)
            {
                Console.WriteLine("Removing priority boarding");
                return ticket;
            }
            else return ticket;
        }
    }
}
