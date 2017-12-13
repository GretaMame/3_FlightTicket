using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class ExcessLuggage : ITicketExtension
    {
        decimal luggagePrice;

        public ExcessLuggage()
        {
            Console.WriteLine("Excess luggage added to ticket.");
            luggagePrice = 30m;
        }

        public decimal CalculatePrice()
        {
            Console.WriteLine("Excess luggage: " + luggagePrice);
            return luggagePrice;
        }
    }
}
