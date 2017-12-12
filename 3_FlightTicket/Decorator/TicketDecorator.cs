using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    abstract class TicketDecorator : ITicket
    {
        public decimal TicketPrice { get; set; }
        private ITicket ticket;

        public TicketDecorator(ITicket ticket)
        {
            this.ticket = ticket;
        }

        public virtual decimal GetPrice()
        {
            return ticket.GetPrice();
        }
       // public abstract ITicket RemoveDecorator();
        //{
        //    return new TicketDecorator();
        //}
    }
}
