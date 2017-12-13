using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class PriorityBoarding : ITicketExtension
    {
        decimal priorityBoardingPrice;

        public PriorityBoarding()
        {
            Console.WriteLine("Priority boarding added to ticket.");
            priorityBoardingPrice = 5m;
        }

        public decimal CalculatePrice()
        {
            Console.WriteLine("Priority boarding: " + priorityBoardingPrice);
            return priorityBoardingPrice;
        }
    }
}
