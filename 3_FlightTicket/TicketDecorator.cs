using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket
{
    abstract class TicketDecorator : ITicket
    {
        protected ITicket ticket;
        public abstract decimal GetPrice();
        public abstract void RemoveDecorator(TicketDecorator decorator);
    }
}
