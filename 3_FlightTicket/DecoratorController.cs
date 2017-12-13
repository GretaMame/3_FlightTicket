using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket
{
    class DecoratorController
    {
        public static void DecoratorMenu()
        {
            int ticketSelection = MenuUI.PrintTicketSelectionMenu();
            switch (ticketSelection)
            {
                case 1:
                    DecoratorAddTicketServices(new Decorator.PaperTicket());
                    break;
                case 2:
                    DecoratorAddTicketServices(new Decorator.ElectronicTicket());
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void DecoratorAddTicketServices(Decorator.ITicket ticketType)
        {
            Decorator.ITicket ticket = ticketType;
            int selection = MenuUI.PrintExtraSelctionMenu();
            while (selection != 12) //exit number 12
            {
                switch (selection)
                {
                    case 1:
                        ticket = new Decorator.ExcessLuggage(ticket);
                        break;
                    case 2:
                        ticket = new Decorator.PriorityBoarding(ticket);
                        break;
                    case 3:
                        ticket = new Decorator.FlightCancelationInsurance(ticket);
                        break;
                    case 4:
                        ticket = new Decorator.CarRental(ticket);
                        break;
                    case 5:
                        ticket = new Decorator.Voucher(ticket);
                        break;
                    case 6:
                        ticket = (ticket as Decorator.TicketDecorator).RemoveDecorator<Decorator.ExcessLuggage>();
                        break;
                    case 7:
                        ticket = (ticket as Decorator.TicketDecorator).RemoveDecorator<Decorator.PriorityBoarding>();
                        break;
                    case 8:
                        ticket = (ticket as Decorator.TicketDecorator).RemoveDecorator<Decorator.FlightCancelationInsurance>();
                        break;
                    case 9:
                        ticket = (ticket as Decorator.TicketDecorator).RemoveDecorator<Decorator.CarRental>();
                        break;
                    case 10:
                        ticket = (ticket as Decorator.TicketDecorator).RemoveDecorator<Decorator.Voucher>();
                        break;
                    case 11:
                        Decorator.Voucher voucher = (ticket as Decorator.TicketDecorator).GetDecorator<Decorator.Voucher>();
                        if (voucher != null)
                        {
                            MenuUI.PrintDiscount(voucher.CalculateDiscount());
                        }
                        break;
                }
                selection = MenuUI.PrintExtraSelctionMenu();
            }
            MenuUI.PrintCheckout(ticket.CalculatePrice());
            DecoratorMenu();
        }
    }
}
