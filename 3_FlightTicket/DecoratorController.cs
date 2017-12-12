﻿using System;
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
            while (selection != 9) //exit number 9
            {
                switch (selection)
                {
                    case 1:
                        if (!(ticket is Decorator.ExcessLuggage))
                        {
                            ticket = new Decorator.ExcessLuggage(ticket);
                        }
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
                        //ticket = (ExcessLuggage)ticket.RemoveDecorator();
                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                }
                selection = MenuUI.PrintExtraSelctionMenu();
            }
            MenuUI.PrintCheckout(ticket.GetPrice());
            DecoratorMenu();
        }
    }
}
