using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCarApplication.Constants
{
    class MainMenuConstants
    {
        //Messages
        public const string WelcomeMessage = "                                      Welcome to Test car app! What would you like to do?";
        public const string MainMenuHeader = "======= MAIN MENU ======= ";
        public const string QuitMessage = "Bye!";
        public const string EntryNotRecognized = "Chosen option has not been recognized, please try again.";


        //Main menu items texts:
        
        public const string AddCarMenuText = "1. Add new car.";
        public const string LoadCarMenuText = "2. Load existing car.";
        public const string ViewExistingCarsText = "3. View existing cars";
        public const string QuitAppMenuText = "Q - Quit application.";
        
        //List of Menu options to iterate over:
        public static List<string> MenuOptionsDisplayList = new List<string> { AddCarMenuText, LoadCarMenuText, ViewExistingCarsText, QuitAppMenuText };

        //Main menu choices:
        public const string AddCarChoice = "1";
        public const string LoadCarChoice = "2";
        public const string ViewExisitngCarsChoice = "3";
        public const string QuitAppChoice = "Q";
        public const string GoBackChoice = "B";

        //GENERAL
        public const string GoBackMenuText = "B - Go back.";
    }
}
