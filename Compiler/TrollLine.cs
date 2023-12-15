using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troll.Compiler
{
    class TrollLine
    {
        public TrollLanguage.TrollCommand trollCommand;
        public string[] arguments;
        public bool isBlank = false; // Yes this means that having a bunch of blank lines wastes memory, but hey thats troll for you

        public TrollLine(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                isBlank = true;
                return;
            }

            trollCommand = StringToCommand(line);
            arguments = StringToArguments(line);
        }

        private static TrollLanguage.TrollCommand StringToCommand(string line)
        {
            TrollLanguage.TrollCommand trollComand = TrollLanguage.TrollCommand.trlol; // we assign it because why the hell not
            try
            {
                string _trollCommandStr;
                if (!line.Contains(' '))
                {
                    _trollCommandStr = line;
                }
                else
                {
                    _trollCommandStr = line.Split(' ')[0];
                }

                trollComand = (TrollLanguage.TrollCommand)Enum.Parse(typeof(TrollLanguage.TrollCommand), _trollCommandStr);
            }
            catch
            {
                Terminal.Throw("oopsie on line " + line);
            }

            return trollComand;
        }

        private static string[] StringToArguments(string line)
        {
            if (!line.Contains(' '))
            {
                return new string[0]; // there are no arguments
            }

            string[] _argumentsStr;
            if (line.Contains(" lol "))
            {
                _argumentsStr = line.Split(new[] { " lol " }, StringSplitOptions.None); // Splits the line up between "lol"s
                List<string> firstArgument = _argumentsStr[0].Split(' ').ToList();
                firstArgument.RemoveAt(0);
                _argumentsStr[0] = string.Join(" ", firstArgument);
            }
            else
            {
                List<string> argument = line.Split(' ').ToList();
                argument.RemoveAt(0);
                _argumentsStr = new string[] { string.Join(" ", argument )};
            }

            return _argumentsStr;
        }
    }
}
