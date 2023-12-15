using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troll.Compiler
{
    class Compiler
    {
        static int lineNumber = 0;

        public static void MainCompile(string path) // Entry point
        {
            try
            {
                CompileFile(path);
            }
            catch (Exception e)
            {
                Terminal.Write("LMAO YOU RAN INTO AN ERROR ON LINE " + lineNumber + ": " + e.Message);
            }
        }

        private static void CompileFile(string path)
        {
            if (!path.EndsWith(".troll")) // If the file isn't a troll file (yes I know it could still technically be compiled but we do a lil trolling)
            {
                Terminal.Throw("Given file is corrupt/not a valid troll file.");
            }

            string trollText = TrollToText(path);
            string[] trollLinesStr = trollText.Split('\n');

            TrollLine[] trollLines = new TrollLine[trollLinesStr.Length];
            for(int i = 0; i < trollLines.Length; i++)
            {
                lineNumber++; // Records compile time errors
                trollLines[i] = new TrollLine(trollLinesStr[i]);
            }

            lineNumber = 0; // Resets in case any runtime errors show up

            foreach (TrollLine trollLine in trollLines)
            {
                if (trollLine.isBlank) continue;

                CompileLine(trollLine);
            }
        }

        static string TrollToText(string path)
        {
            if (!File.Exists(path))
            {
                Terminal.Throw("Path does not exist or insufficient privileges are at play."); // This should be a very rare case considering most people will drag in an existent file
            }

            return File.ReadAllText(path);
        }

        public static void CompileLine(TrollLine trollLine)
        {
            lineNumber++;

            switch (trollLine.trollCommand)
            {
                case TrollLanguage.TrollCommand.trlol:
                    TrollCommands.trlol.CompileLine(trollLine.arguments);
                    break;
                case TrollLanguage.TrollCommand.woah:
                    Terminal.Wait();
                    break;
                case TrollLanguage.TrollCommand.kewlour:
                    TrollCommands.kewlour.CompileLine(trollLine.arguments);
                    break;
                case TrollLanguage.TrollCommand.kys:
                    TrollCommands.kys.CompileLine(trollLine.arguments);
                    break;
                case TrollLanguage.TrollCommand.twentyseventeen:
                    if (NoLaunch.isNoLaunch) return;
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
