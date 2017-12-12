using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class CarRental : ITicketExtension
    {
        decimal rentalCarInsurancePrice;
        decimal rentalCarPrice;

        public CarRental()
        {
            Console.WriteLine("Car rental added to ticket.");
            rentalCarPrice = 100m;
        }

        public decimal GetPrice()
        {
            AddRentalCarInsurance();
            Console.WriteLine("Car rental: " + rentalCarPrice);
            return rentalCarPrice + rentalCarInsurancePrice;
        }

        public void AddRentalCarInsurance()
        {
            rentalCarInsurancePrice = 20m;
            Console.WriteLine("Rental car insurance: " + rentalCarInsurancePrice);
        }
    }
}
