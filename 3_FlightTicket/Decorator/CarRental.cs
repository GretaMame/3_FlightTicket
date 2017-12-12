using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class CarRental : TicketDecorator
    {
        decimal rentalCarInsurancePrice;
        decimal rentalCarPrice;

        public CarRental(ITicket ticket)
        {
            Console.WriteLine("Car rental added to ticket price.");
            this.ticket = ticket;
            rentalCarPrice = 100m;
        }


        public override decimal GetPrice()
        {
            AddRentalCarInsurance();
            Console.WriteLine("Car rental: " + rentalCarPrice);
            return ticket.GetPrice() + rentalCarPrice + rentalCarInsurancePrice;
        }

        public override ITicket RemoveDecorator()
        {
            if (ticket is PriorityBoarding)
            {
                Console.WriteLine("Removing car rental");
                return ticket;
            }
            else return ticket;
        }

        public void AddRentalCarInsurance()
        {
            rentalCarInsurancePrice = 20m;
            Console.WriteLine("Rental car insurance: " + rentalCarInsurancePrice);
        }
    }
}
