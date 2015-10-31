using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BF.Core;
using BF.Core.Abstraction;
using BF.Core.Walkers;
using BF.IO;

namespace BF
{
    static class Program
    {
        static void Main(string[] args)
        {
            // TODO: Parse args to get options and program code filename
            const string programCode = "++++++++[>++++[>++>+++>+++>+<<<<-]>+>+>->>+[<]<-]>>.>---.+++++++..+++.>>.<-.<.+++.------.--------.>>+.>++.";

            var io = new ConsoleInputOutput();
            var walker = new ExecuteWalker(io);

            WalkProgramCode(programCode, walker);
        }

        private static void WalkProgramCode(string programCode, IWalker walker)
        {
            var lexer = new Lexer(programCode);
            var tokens = lexer.ReadTokens();

            var parser = new Parser(tokens);
            var program = parser.Parse();

            program.Accept(walker);
        }
    }
}
