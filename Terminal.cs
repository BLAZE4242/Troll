using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troll
{
    class Terminal
    {
        public static void Write(string message)
        {
            Console.WriteLine(message);
        }

        public static void Throw(string message)
        {
            throw new Exception(message);
        }

        public static void Wait()
        {
            Console.ReadKey(true);
        }

        public static void ChangeTextColour(ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
        }
    }
}
