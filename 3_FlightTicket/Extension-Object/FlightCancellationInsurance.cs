using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class FlightCancellationInsurance : ITicketExtension
    {
        decimal insurancePrice;

        public FlightCancellationInsurance()
        {
            Console.WriteLine("Flight cancelation insurance added to ticket.");
            insurancePrice = 20m;
        }

        public decimal CalculatePrice()
        {
            Console.WriteLine("Flight cancelation insurance: " + insurancePrice);
            return insurancePrice;
        }
    }
}
