using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket
{
    class ElectronicTicket : ITicket
    {
        public ElectronicTicket()
        {
            Console.WriteLine("Electronic ticket created");
        }

        public decimal GetPrice()
        {
            Console.WriteLine("Ticket price: " + 100m);
            return 100m;
        }
    }
}
