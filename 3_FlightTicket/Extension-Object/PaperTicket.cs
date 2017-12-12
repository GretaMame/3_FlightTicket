using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class PaperTicket : Ticket
    {
        public PaperTicket()
        {
            Console.WriteLine("Paper ticket created.");
            AddPaperFee();
        }

        public void AddPaperFee()
        {
            TicketPrice += 20m;
        }
    }
}
