using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket.Extension_Object
{
    abstract class Ticket
    {
        private decimal ticketPrice;
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
            if (!extensions.ContainsKey(extensionName))
            {
                extensions.Add(extensionName, extension);
            }
        }


        public void RemoveExtension(string extensionName)
        {
            if (extensions.ContainsKey(extensionName))
            {
                extensions.Remove(extensionName);
                Console.WriteLine(extensionName + " removed from ticket.");
            }
            else Console.WriteLine("Ticket has no "+ extensionName);
        }

        public decimal CalculatePrice()
        {
            decimal toReturn = 0;
            foreach(var ext in extensions.Values)
            {
                toReturn += ext.CalculatePrice();
            }
            Console.WriteLine("Original ticket price: "+ ticketPrice);
            return ticketPrice + toReturn;
        }

        public decimal GetPrice()
        {
            return ticketPrice;
        }

        public void ChangePrice(decimal price)
        {
            ticketPrice = price;
        }
    }
}
