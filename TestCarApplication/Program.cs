using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestCarApplication.Classes;
using TestCarApplication.Constants;
using TestCarApplication.Menus;
using TestCarApplication.Workers;

namespace TestCarApplication
{
    class Program
    {

        public static bool continueApp { get; set; }

        static void Main(string[] args)
        {
            continueApp = true;
            Console.WriteLine(MainMenuConstants.WelcomeMessage);
            Console.WriteLine();
            do
            {
                MainMenu.DisplayMenu();
                Console.WriteLine();

                var UserEntry = Console.ReadLine();


                //do
                //{
                    switch (UserEntry.ToUpper())
                    {
                        case MainMenuConstants.AddCarChoice:
                            AddCarMenu.Display();
                            //Workers.AddCar();
                            break;
                        case MainMenuConstants.LoadCarChoice:
                            LoadCarMenu.Display();
                            break;
                        case MainMenuConstants.ViewExisitngCarsChoice:
                            //Workers.ViewExistingCars();
                            break;
                        case MainMenuConstants.QuitAppChoice:
                            continueApp = false;
                            break;
                        default:
                            Console.WriteLine();
                            Statics.WarningConsole();
                            Console.WriteLine(MainMenuConstants.EntryNotRecognized);
                            Statics.NormalConsole();
                            break;
                    }
                //} while (continueApp);

            } while (continueApp);

            Console.WriteLine(MainMenuConstants.QuitMessage);

        }

        public static void validateUserEntry(string UserEntry)
        {


        }
    }
}
