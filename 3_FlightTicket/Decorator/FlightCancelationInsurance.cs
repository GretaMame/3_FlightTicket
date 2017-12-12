﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    class FlightCancelationInsurance : TicketDecorator
    {
        public FlightCancelationInsurance(ITicket ticket)
        {
            Console.WriteLine("Flight cancelation insurance added to ticket price.");
            this.ticket = ticket;
        }

        public override decimal GetPrice()
        {
            Console.WriteLine("Flight cancelation insurance: " + 20m);
            return ticket.GetPrice() + 20m;
        }

        public override ITicket RemoveDecorator()
        {
            if (ticket is FlightCancelationInsurance)
            {
                Console.WriteLine("Removing flight ticket cancellation insurance");
                return ticket;
            }
            else return ticket;
        }
    }
}