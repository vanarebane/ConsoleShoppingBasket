using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoppingBasket.Interface
{
    public class ConsolePresets
    {
        public static void WriteLine(string message) {
            Console.WriteLine(message);
        }
        public static void Message(string message) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Suggest(string message, string tip)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(message);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(tip);
            Console.ResetColor();
        }
    }
}
