using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket
{
    class ExtensionObjectController
    {
        public static void ExtensionObjectMenu()
        {
            int ticketSelection = MenuUI.PrintTicketSelectionMenu();
            switch (ticketSelection)
            {
                case 1:
                    ExtensionObjectAddTicketServices(new Extension_Object.PaperTicket());
                    break;
                case 2:
                    ExtensionObjectAddTicketServices(new Extension_Object.ElectronicTicket());
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void ExtensionObjectAddTicketServices(Extension_Object.Ticket ticketType)
        {
            Extension_Object.Ticket ticket = ticketType;
            string excessLuggage = "Excess luggage";
            string priorityBoarding = "Priority boarding";
            string flightCancellationInsurance = "Flight cancellation insurance";
            string carRental = "Car rental";
            string voucher = "Voucher";
            int selection = MenuUI.PrintExtraSelctionMenu();
            while (selection != 12) //exit number 12
            {
                switch (selection)
                {
                    case 1:
                        ticket.AddExtension(excessLuggage, new Extension_Object.ExcessLuggage());
                        break;
                    case 2:
                        ticket.AddExtension(priorityBoarding, new Extension_Object.PriorityBoarding());
                        break;
                    case 3:
                        ticket.AddExtension(flightCancellationInsurance, new Extension_Object.FlightCancellationInsurance());
                        break;
                    case 4:
                        ticket.AddExtension(carRental, new Extension_Object.CarRental());
                        break;
                    case 5:
                        ticket.AddExtension(voucher, new Extension_Object.Voucher(ticket));
                        break;
                    case 6:
                        ticket.RemoveExtension(excessLuggage);
                        break;
                    case 7:
                        ticket.RemoveExtension(priorityBoarding);
                        break;
                    case 8:
                        ticket.RemoveExtension(flightCancellationInsurance);
                        break;
                    case 9:
                        ticket.RemoveExtension(carRental);
                        break;
                    case 10:
                        ticket.RemoveExtension(voucher);
                        break;
                    case 11:
                        if(ticket.GetExtension(voucher)!= null)
                        {
                            MenuUI.PrintDiscount(((Extension_Object.Voucher)ticket.GetExtension(voucher)).CalculateDiscount());
                        }
                        break;
                }
                selection = MenuUI.PrintExtraSelctionMenu();
            }
            MenuUI.PrintCheckout(ticket.CalculatePrice());
            ExtensionObjectMenu();
        }
    }
}
