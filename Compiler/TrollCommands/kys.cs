using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troll.Compiler.TrollCommands
{
    class kys
    {
        public static void CompileLine(string[] arguments)
        {
            string steamId = TrollLanguage.TrollArgumentToText(arguments);
            System.Diagnostics.Process.Start("steam://rungameid/" + steamId);
        }
    }
}
