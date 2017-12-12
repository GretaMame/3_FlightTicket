using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class Voucher : TicketDecorator
    {
        decimal discount;
        public Voucher(ITicket ticket) : base(ticket)
        {
            Console.WriteLine("Discount added to ticket.");
            discount = 0.1m;
        }

        public override decimal GetPrice()
        {
           // ticket.TicketPrice -= ticket.TicketPrice * discount;
            return base.GetPrice();
        }

        public decimal CalculateDiscount()
        {
            return base.GetPrice() * discount;
        }

        //public override ITicket RemoveDecorator()
        //{
        //    return ticket;
        //}
    }
}
