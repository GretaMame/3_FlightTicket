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
            int pattern = MenuUI.PrintMainMenu();
            switch (pattern)
            {
                case 1:
                    DecoratorController.DecoratorMenu();
                    break;
                case 2:
                    ExtensionObjectController.ExtensionObjectMenu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
