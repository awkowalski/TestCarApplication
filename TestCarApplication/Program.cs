using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestCarApplication.Classes;
using TestCarApplication.Constants;
using TestCarApplication.Menus;

namespace TestCarApplication
{
    class Program
    {

        public static bool continueApp { get; set; }

        static void Main(string[] args)
        {
            continueApp = true;

            do
            {
                Console.WriteLine(MainMenuConstants.WelcomeMessage);
                Console.WriteLine();

                MainMenu.DisplayMenu();
                Console.WriteLine();

                var UserEntry = Console.ReadLine();


                do
                {
                    switch (UserEntry.ToUpper())
                    {
                        case MainMenuConstants.AddCarChoice:
                            //Workers.AddCar();
                            break;
                        case MainMenuConstants.LoadCarChoice:
                            //Workers.LoadCar();
                            break;
                        case MainMenuConstants.ViewExisitngCarsChoice:
                            //Workers.ViewExistingCars();
                            break;
                        case MainMenuConstants.QuitAppChoice:
                            continueApp = false;
                            break;
                        default:
                            Console.WriteLine(MainMenuConstants.EntryNotRecognized);
                            break;
                    }
                } while (continueApp);

            } while (continueApp);

            Console.WriteLine(MainMenuConstants.QuitMessage);



        }
    }
}
