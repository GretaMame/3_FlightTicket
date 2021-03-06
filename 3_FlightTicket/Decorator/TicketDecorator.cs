﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Decorator
{
    abstract class TicketDecorator : ITicket
    {
        private ITicket ticket;
        public decimal ticketPrice { get; set; }

        public TicketDecorator(ITicket ticket)
        {
            this.ticket = ticket;
        }

        public virtual decimal CalculatePrice()
        {
            return ticket.CalculatePrice();
        }

        public ITicket RemoveDecorator<T>() where T : TicketDecorator
        {
            if(this.GetDecorator<T>() != null)
            {
                if (this is T)
                {
                    return this.ticket;
                }
                else if (this.ticket is TicketDecorator)
                {
                    this.ticket = (this.ticket as TicketDecorator).RemoveDecorator<T>();
                }
            }
            return this;  
        }
        

        public T GetDecorator<T>() where T : TicketDecorator
        {
            //Console.WriteLine("Type of T: "+ typeof(T));
            //Console.WriteLine("Type of ticket: " + this.GetType().ToString());
            //Console.WriteLine("is: " + typeof(T).IsInstanceOfType(this));
            if (this is T)
            {
                return (T)this;
            }
            else if (ticket is TicketDecorator)
            {
                return (ticket as TicketDecorator).GetDecorator<T>();
            }
            else return null;
        }

        public ITicket GetTicket()
        {
            ITicket toReturn = ticket;
            if (toReturn is TicketDecorator)
            {
                toReturn = (ticket as TicketDecorator).GetTicket();
            }
            return toReturn;
        }
    }
}   
