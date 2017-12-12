using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class ExcessLuggage : ITicketExtension
    {
        public ExcessLuggage()
        {
            Console.WriteLine("Excess luggage added to ticket price.");
        }

        public decimal GetPrice()
        {
            Console.WriteLine("Excess luggage: " + 30m);
            return 30m;
        }
    }
}
