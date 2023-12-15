using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troll.Compiler
{
    class TrollLanguage
    {
        public enum TrollCommand
        {
            trlol, // write to terminal
            woah, // waits for user input
            kewlour, // changes colour of text
            kys, // launches a game on steam
            hjsdlkfhsdiouygfhvjbniufgldghfljukgdfljkdbfn, // you can now comment
            twentyseventeen // closes the program
        }

        public static string TrollArgumentToText(string[] arguments)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz ";
            string numericalAlphabet = "ඞ9876543210";

            char[] lettersChr = new char[arguments.Length];
            for (int i = 0; i < arguments.Length; i++)
            {
                string targetAlphabet = alphabet;

                if(arguments[i].StartsWith("hoohoo")) // Numbers
                {
                    targetAlphabet = numericalAlphabet;
                }

                lettersChr[i] = targetAlphabet[arguments[i].Split(new[] { "troll" }, StringSplitOptions.None).Length - 2]; // idk man idk

                if (arguments[i].StartsWith("hehe")) // Capital letters
                {
                    lettersChr[i] = char.ToUpper(lettersChr[i]);
                }
            }

            return string.Concat(lettersChr);
        }
    }
}
