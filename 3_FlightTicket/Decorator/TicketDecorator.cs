using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    abstract class TicketDecorator : ITicket
    {
        protected ITicket ticket;
        protected string roleName;
        public abstract decimal GetPrice();
        public abstract ITicket RemoveDecorator();
        //{
        //    return new TicketDecorator();
        //}
    }
}
