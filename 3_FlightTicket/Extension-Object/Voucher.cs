using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class Voucher : ITicketExtension
    {
        decimal discount;
        Ticket ticket;

        public Voucher(Ticket ticket)
        {
            Console.WriteLine("Discount added to ticket.");
            this.ticket = ticket;
            discount = 0.1m;
        }

        public decimal CalculatePrice()
        {
            //reikia kazkaip nueit iki pagrindinio ir is jo pasiimt kaina
            Console.WriteLine("Before discount: " + ticket.GetPrice());
            decimal disc = ticket.GetPrice() * discount;
            Console.WriteLine("Discount: " + disc);
            ticket.ChangePrice(ticket.GetPrice() - disc);
            Console.WriteLine("After discount: " + ticket.GetPrice());
            return 0m;
        }

        public decimal CalculateDiscount()
        {
            return discount * ticket.GetPrice();
        }

        public void SetDiscount(decimal discount)
        {
            this.discount = discount;
        }
    }
}
