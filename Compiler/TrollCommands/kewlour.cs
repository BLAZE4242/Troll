using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troll.Compiler.TrollCommands
{
    class kewlour
    {
        public static void CompileLine(string[] arguments)
        {
            string terminalColourStr = TrollLanguage.TrollArgumentToText(arguments);
            ConsoleColor terminalColour = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), terminalColourStr);
            Terminal.ChangeTextColour(terminalColour);
        }
    }
}
