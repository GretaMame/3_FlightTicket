using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FlightTicket
{
    class MenuUI
    {
        public static int PrintExtraSelctionMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following ticket types");
            Console.WriteLine("1. Add excess luggage");
            Console.WriteLine("2. Add priority boarding");
            Console.WriteLine("3. Add flight cancellation insurance");
            Console.WriteLine("4. Add car rental");
            Console.WriteLine("5. Add voucher");
            Console.WriteLine("6. Remove excess luggage");
            Console.WriteLine("7. Remove priority boarding");
            Console.WriteLine("8. Remove flight cancellation insurance");
            Console.WriteLine("9. Remove car rental");
            Console.WriteLine("10. Remove voucher");
            Console.WriteLine("11. Calculate discount");
            Console.WriteLine("12. Proceed to checkout");

            int selection = GetIntInput();
            while (selection != 1 && selection != 2 && selection != 3 && selection != 4 && selection != 5 &&
                selection != 6 && selection != 7 && selection != 8 && selection != 9 && selection != 10 && 
                selection != 11 && selection != 12)
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

        public static int GetIntInput()
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
            Console.WriteLine("Please select one of the design patterns");
            Console.WriteLine("1. Decorator pattern");
            Console.WriteLine("2. Extension object");
            Console.WriteLine("3. Exit program");
            int selection = GetIntInput();
            while (selection != 1 && selection != 2 && selection != 3)
            {
                Console.WriteLine("Please enter valid selection");
                selection = GetIntInput();
            }
            return selection;
        }
        public static void PrintCheckout(decimal price)
        {
            Console.WriteLine("Total price: " + price);
            Console.WriteLine("");
        }

        public static void PrintDiscount(decimal discount)
        {
            Console.WriteLine("Discount: " + discount);
        }
    }
}
