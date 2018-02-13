using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCarApplication.Constants;

namespace TestCarApplication.Menus
{
    class LoadCarMenu
    {
        public static void Display()
        {
            Console.WriteLine(LoadCarConstants.LoadCarHeader);
            Console.WriteLine();
            Console.WriteLine(LoadCarConstants.LoadCarMenuText);
            Console.WriteLine();
            Console.WriteLine(MainMenuConstants.GoBackMenuText);
            Console.WriteLine(MainMenuConstants.QuitAppMenuText);
            Console.WriteLine();

            var userEntry = Console.ReadLine();

            switch (userEntry.ToUpper())
            {
                case MainMenuConstants.GoBackChoice:
                    break;
                case MainMenuConstants.QuitAppChoice:
                    Environment.Exit(1);
                    break;
                default:
                    //check entry with loaded cars list
                    break;
            }

            //Load cars from DB,
            //count loaded cars
            //foreach loaded car
            //get its name
            //combine with incremented index and put to the list (it will be used to check user entry)
            //console writeline
        }
    }
}
