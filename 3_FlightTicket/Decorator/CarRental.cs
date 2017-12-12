using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class CarRental : TicketDecorator
    {
       // decimal rentalCarInsurancePrice;
        decimal rentalCarPrice;

        public CarRental(ITicket ticket) : base(ticket)
        {
            Console.WriteLine("Car rental added to ticket.");
            rentalCarPrice = 100m;
            //rentalCarInsurancePrice = 30m;
        }


        public override decimal GetPrice()
        {
            Console.WriteLine("Car rental: " + rentalCarPrice);
            return base.GetPrice() + rentalCarPrice;//+ rentalCarInsurancePrice;
        }

        //public override ITicket RemoveDecorator()
        //{
        //    if (ticket is PriorityBoarding)
        //    {
        //        Console.WriteLine("Removing car rental");
        //        return ticket;
        //    }
        //    else return ticket;
        //}
    }
}
