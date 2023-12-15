using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troll.Compiler.TrollCommands
{
    class trlol
    {
        public static void CompileLine(string[] lettersStr)
        {
            Terminal.Write(TrollLanguage.TrollArgumentToText(lettersStr));
        }
    }
}
