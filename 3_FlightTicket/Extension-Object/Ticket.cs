﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    abstract class Ticket
    {
        protected decimal ticketPrice;
        Dictionary<string, ITicketExtension> extensions;

        public Ticket()
        {
            extensions = new Dictionary<string, ITicketExtension>();
            ticketPrice = 100m;
        }

        public ITicketExtension GetExtension(string extensionName)
        {
            ITicketExtension toReturn = null;
            extensions.TryGetValue(extensionName, out toReturn);
            return toReturn;
        }
        public void AddExtension(string extensionName, ITicketExtension extension)
        {
            extensions.Add(extensionName, extension);
        }


        public void RemoveExtension(string extensionName)
        {
            extensions.Remove(extensionName);   
        }

        public decimal GetPrice()
        {
            decimal toReturn = ticketPrice;
            foreach(var ext in extensions.Values)
            {
                toReturn += ext.GetPrice();
            }
            return toReturn;
        }
    }
}