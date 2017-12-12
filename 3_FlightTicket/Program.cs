using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int pattern = PrintMainMenu();
            switch(pattern)
            {
                case 1:
                    DecoratorMenu();
                    break;
                case 2:
                    ExtensionObjectMenu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void ExtensionObjectMenu()
        {
            int ticketSelection = PrintTicketSelectionMenu();
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
            int selection = PrintExtraSelctionMenu();
            while (selection != 9) //exit number 9
            {
                switch (selection)
                {
                    case 1:
                        //if (!(ticket is Decorator.ExcessLuggage))
                        {
                            //ticket = new Decorator.ExcessLuggage(ticket);
                        }
                        break;
                    case 2:
                        //ticket = new Decorator.PriorityBoarding(ticket);
                        break;
                    case 3:
                        //ticket = new Decorator.FlightCancelationInsurance(ticket);
                        break;
                    case 4:
                        //ticket = new Decorator.CarRental(ticket);
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
                selection = PrintExtraSelctionMenu();
            }
            Console.WriteLine("");
            Console.WriteLine("\\-- CHECKOUT --//");
            Console.WriteLine("Total price: " + ticket.GetPrice());
            Console.WriteLine("");
            DecoratorMenu();

        }

        public static void DecoratorMenu()
        {
            int ticketSelection = PrintTicketSelectionMenu();
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
            int selection = PrintExtraSelctionMenu();
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
                selection = PrintExtraSelctionMenu();
            }
            Console.WriteLine("");
            Console.WriteLine("\\-- CHECKOUT --//");
            Console.WriteLine("Total price: " + ticket.GetPrice());
            Console.WriteLine("");
            DecoratorMenu();

        }



        public static int PrintExtraSelctionMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following ticket types");
            Console.WriteLine("1. Add excess luggage");
            Console.WriteLine("2. Add priority boarding");
            Console.WriteLine("3. Add flight cancellation insurance");
            Console.WriteLine("4. Add car rental");
            Console.WriteLine("5. Remove excess luggage");
            Console.WriteLine("6. Remove priority boarding");
            Console.WriteLine("7. Remove flight cancellation insurance");
            Console.WriteLine("8. Remove car rental");
            Console.WriteLine("9. Proceed to checkout");

            int selection = GetIntInput();
            while (selection != 1 && selection != 2 && selection != 3 && selection != 4 && selection != 5 &&
                selection != 6 && selection != 7 && selection != 8 && selection != 9)
            {
                selection = GetIntInput();
            }
            return selection;
        }

        public static int PrintTicketSelectionMenu()
        {
            Console.WriteLine("\\-- Welcome to our flight ticket reservation program --//");
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following ticket types");
            Console.WriteLine("1. Paper ticket");
            Console.WriteLine("2. Electronic ticket");
            Console.WriteLine("3. Exit program");
            Console.WriteLine("");
            int selection = GetIntInput();
            while (selection != 1 && selection != 2 && selection != 3)
            {
                Console.WriteLine("Please enter valid selection");
                selection = GetIntInput();
            }
            return selection;
        }

        static int GetIntInput()
        {
            int selection;
            while (!Int32.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine("Please enter valid selection");
            }
            return selection;
        }

        public static int PrintMainMenu()
        {
            Console.WriteLine("Please select one of th design patterns");
            Console.WriteLine("1. Decorator pattern");
            Console.WriteLine("2. Extension object");
            Console.WriteLine("3. Exit program");
            int selection = GetIntInput();
            while(selection != 1 && selection != 2 && selection != 3)
            {
                Console.WriteLine("Please enter valid selection");
                selection = GetIntInput();
            }
            return selection;
        }
    }
}
