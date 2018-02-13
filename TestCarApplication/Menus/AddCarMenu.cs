using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCarApplication.Constants;
using TestCarApplication.Workers;

namespace TestCarApplication.Menus
{
    class AddCarMenu
    {
        public static void Display()
        {
            Console.WriteLine();
            Console.WriteLine(AddCarConstants.AddCarHeader);
            Console.WriteLine();

            foreach (string menuOption in AddCarConstants.AddCarMenuOptionsList)
            {
                Console.WriteLine(menuOption);
                Console.WriteLine();
            }
            Console.WriteLine(MainMenuConstants.QuitAppMenuText);
            var UserEntry = Console.ReadLine();

            switch (UserEntry.ToUpper())
            {
                case AddCarConstants.AddCarMenuText:
                    //AddCarMenu.AskForCarData();
                    break;
                case AddCarConstants.ViewCarMenuText:
                    //AddCarMenu.ViewAddedCar();
                    break;
                case AddCarConstants.EditCarMenuText:
                    //AddCarMenu.EditLastAddedCar();
                    break;
                case MainMenuConstants.GoBackChoice:
                    break;
                case MainMenuConstants.QuitAppChoice:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine();
                    Statics.WarningConsole();
                    Console.WriteLine(MainMenuConstants.EntryNotRecognized);
                    Statics.NormalConsole();
                    AddCarMenu.Display();
                    break;

            }
        }
    }
}
