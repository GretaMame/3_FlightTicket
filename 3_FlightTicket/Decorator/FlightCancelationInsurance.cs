using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class FlightCancelationInsurance : TicketDecorator
    {
        decimal flightCancelationInsurance;
        public FlightCancelationInsurance(ITicket ticket) : base(ticket)
        {
            Console.WriteLine("Flight cancelation insurance added to ticket.");
            flightCancelationInsurance = 20m;
        }

        public override decimal CalculatePrice()
        {
            Console.WriteLine("Flight cancelation insurance: " + flightCancelationInsurance);
            return base.CalculatePrice() + flightCancelationInsurance;
        }
    }
}
