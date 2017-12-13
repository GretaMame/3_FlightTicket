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
            //Decorator.ITicket ticket = new Decorator.ExcessLuggage( new Decorator.PriorityBoarding( new Decorator.PaperTicket()));
            //Decorator.TicketDecorator dec = (ticket as Decorator.TicketDecorator).GetDecorator<Decorator.PriorityBoarding>();
            //Decorator.TicketDecorator dec2 = (ticket as Decorator.TicketDecorator).GetDecorator<Decorator.FlightCancelationInsurance>();
            //if (dec != null)
            //{
            //    Console.WriteLine("dec:" + dec.GetType().ToString());
            //}
            //if (dec2 != null)
            //{
            //    Console.WriteLine("dec2: " + dec2.GetType().ToString());
            //}
            int pattern = MenuUI.PrintMainMenu();
            switch (pattern)
            {
                case 1:
                    DecoratorController.DecoratorMenu();
                    break;
                    //SITAM LIKO:
                    //1. PADARYTI, KAD GALIMA BUTU NUIMTI DEKORATORIUS
                    //2. PASIEKT OBJEKTU KONKRECIUS LAUKUS
                case 2:
                    ExtensionObjectController.ExtensionObjectMenu();
                    break;
                    //SITAM LIKO:
                    //1. PASIEKTI OBJEKTU KONKRECIUS LAUKUS // reikia kompozicija naudot, viska bus girai
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
