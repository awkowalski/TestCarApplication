using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCarApplication.Workers
{
    class Statics
    {
        public static void WarningConsole()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void NormalConsole()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
