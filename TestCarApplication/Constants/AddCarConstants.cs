using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCarApplication.Constants
{
    class AddCarConstants
    {
        public const string AddCarHeader = "======= ADD CAR MENU ======= ";

        public const string AskForBrand = "Enter car brand:";
        public const string AskForModel = "Enter car model:";
        public const string AskForYear = "Enter car year:";
        public const string AskForMileage = "Enter car mileage:";
        public const string CarAddedMessage = "Car has been succesfully added!";
        public const string AddCarMenuText = "1. Add car.";
        public const string ViewCarMenuText = "2. View added car.";
        public const string EditCarMenuText = "3. Edit car.";
        

        public static List<string> AddCarMenuOptionsList = new List<string> { AddCarMenuText, ViewCarMenuText, EditCarMenuText, MainMenuConstants.GoBackMenuText };
    }
}
