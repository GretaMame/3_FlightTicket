using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class FlightCancellationInsurance : ITicketExtension
    {
        public FlightCancellationInsurance()
        {
            Console.WriteLine("Flight cancelation insurance added to ticket price.");
        }

        public decimal GetPrice()
        {
            Console.WriteLine("Flight cancelation insurance: " + 20m);
            return 20m;
        }
    }
}
