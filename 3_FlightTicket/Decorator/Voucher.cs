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

        public override decimal CalculatePrice()
        {
            Console.WriteLine("Price before discount: " + GetTicket().ticketPrice);
            decimal disc = GetTicket().ticketPrice * discount;
            GetTicket().ticketPrice -= disc;
            Console.WriteLine("Discount: -"+ disc);
            Console.WriteLine("Price after discount: " + GetTicket().ticketPrice);
            return base.CalculatePrice();
        }

        public void setDiscount(decimal discount)
        {
            this.discount = discount;
        }

        public decimal CalculateDiscount()
        {
            return (GetTicket().ticketPrice * discount);
        }
    }
}
