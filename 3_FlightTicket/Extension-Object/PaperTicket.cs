using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    class PaperTicket : Ticket
    {
        decimal fee;
        public PaperTicket()
        {
            Console.WriteLine("Paper ticket created.");
            AddPaperFee(20m);
        }

        public void AddPaperFee(decimal fee)
        {
            this.fee = fee;
            ChangePrice(GetPrice() + fee);
        }
    }
}
