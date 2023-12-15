using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troll
{
    class NoLaunch
    {
        public static bool isNoLaunch = false;

        public static void StartNoLaunch()
        {
            isNoLaunch = true;

            Terminal.Write(@"Welcome to:

████████╗██████╗  ██████╗ ██╗     ██╗     
╚══██╔══╝██╔══██╗██╔═══██╗██║     ██║     
   ██║   ██████╔╝██║   ██║██║     ██║     
   ██║   ██╔══██╗██║   ██║██║     ██║     
██╗██║   ██║  ██║╚██████╔╝███████╗███████╗
╚═╝╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚══════╝
░░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄░░░░░░░
░░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄░░░░
░░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█░░░
░░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░░█░░
░▄▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░░█░
█░▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒░█
█░▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█
░█░▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█░
░░█░░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█░░
░░░█░░░░██░░▀█▄▄▄█▄▄█▄████░█░░░
░░░░█░░░░▀▀▄░█░░░█░█▀██████░█░░
░░░░░▀▄░░░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█░░
░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░▒░░░█░
░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░░░░█░
░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░░░░█░░
");
            Home();
        }

        private static void Home()
        {
            Terminal.Write("Type clean .troll code to execute it or type file directory to run .troll code");
            Console.Write(" >");
            string input = Console.ReadLine();

            if (File.Exists(input))
            {
                Compiler.Compiler.MainCompile(input);
            }
            else
            {
                try
                {
                    Compiler.Compiler.CompileLine(new Compiler.TrollLine(input));
                }
                catch (Exception e)
                {
                    Terminal.Write("Not valid .troll file location or valid .troll code :(");
                    Terminal.Write(e.Message);
                }
            }

            Terminal.ChangeTextColour(ConsoleColor.White);
            Home();
        }
    }
}
