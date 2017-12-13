using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class ExcessLuggage : TicketDecorator
    {
        decimal luggagePrice;

        public ExcessLuggage(ITicket ticket) : base(ticket)
        {
            Console.WriteLine("Excess luggage added to ticket.");
            luggagePrice = 30m;
        }

        public override decimal CalculatePrice()
        {
            Console.WriteLine("Excess luggage: "+ luggagePrice);
            return base.CalculatePrice() + luggagePrice;
        }
    }
}
