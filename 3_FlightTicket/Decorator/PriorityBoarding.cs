using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class PriorityBoarding : TicketDecorator
    {
        decimal priorityBoarding;
        public PriorityBoarding(ITicket ticket) : base(ticket)
        {
            Console.WriteLine("Priority boarding added to ticket.");
            priorityBoarding = 5m;
        }

        public override decimal CalculatePrice()
        {
            Console.WriteLine("Priority boarding: " + priorityBoarding);
            return base.CalculatePrice() + priorityBoarding;
        }
    }
}
