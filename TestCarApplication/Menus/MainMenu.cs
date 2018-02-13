using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCarApplication.Constants;
using TestCarApplication;

namespace TestCarApplication.Menus

{
    class MainMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine(MainMenuConstants.MainMenuHeader);
            Console.WriteLine();

            foreach (string optionText in MainMenuConstants.MenuOptionsDisplayList)
            {
                Console.WriteLine(optionText);
                Console.WriteLine();
            }

        }


    }
}

