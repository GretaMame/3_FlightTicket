using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket
{
    class PaperTicket : ITicket
    {
        public PaperTicket()
        {
            Console.WriteLine("Paper ticket created.");
        }
        public decimal GetPrice()
        {
            Console.WriteLine("Ticket price: " + 120m);
            return 120m;
        }
    }
}
