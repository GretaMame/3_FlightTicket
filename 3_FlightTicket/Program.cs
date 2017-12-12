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
