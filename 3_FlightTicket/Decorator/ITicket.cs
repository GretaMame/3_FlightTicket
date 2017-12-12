using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    interface ITicket
    {
        decimal TicketPrice { get; set; }
        decimal GetPrice();
    }
}
