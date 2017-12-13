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


        public Voucher()
        {
            Console.WriteLine("Discount added to ticket.");
            discount = 0.1m;
        }

        public decimal CalculatePrice()
        {
            //reikia kazkaip nueit iki pagrindinio ir is jo pasiimt kaina
            return 0m;
        }

        public decimal CalculateDiscount()
        {
            return discount;//*
        }
    }
}
