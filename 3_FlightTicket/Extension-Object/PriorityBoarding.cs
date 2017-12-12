using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class PriorityBoarding : ITicketExtension
    {
        public PriorityBoarding()
        {
            Console.WriteLine("Priority boarding added to ticket.");
        }

        public decimal GetPrice()
        {
            Console.WriteLine("Priority boarding: " + 5m);
            return 5m;
        }
    }
}
