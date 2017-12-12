using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket
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

        public override void RemoveDecorator(TicketDecorator decorator)
        {
            if(decorator is PriorityBoarding)
            {
                Console.WriteLine("Removing priority boarding");
            }
        }
    }
}
