using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troll
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteTrollApplication(args);
            Console.ReadKey(true);
        }

        private static void ExecuteTrollApplication(string[] args)
        {
            if (args.Length == 0)
            {
                NoLaunch.StartNoLaunch();
            }
            else if (args.Length == 1)
            {
                Compiler.Compiler.MainCompile(args[0]);
            }
        }
    }
}
