using BF.Core;
using BF.Core.Abstraction;
using BF.Core.Walkers;
using BF.IO;

namespace BF
{
    class ConsoleManager
    {
        public ConsoleManager(string[] args)
        {
            ArgumentParser = new ArgumentParser(args);
        }

        private ArgumentParser ArgumentParser { get; set; }

        public void Run(string[] args)
        {
            if (ArgumentParser.ShouldPrintHelp)
            {
                PrintHelp();
            }
            else
            {
                WalkProgramFromArguments();
            }
        }

        private void WalkProgramFromArguments()
        {
            var io = new ConsoleInputOutput();

            var walker = ArgumentParser.HasPrettyPrintFlag
                ? (IWalker)new PrettyPrintWalker(io)
                : (IWalker)new ExecuteWalker(io);

            var fileReader = new FileReader(ArgumentParser.FilePath);
            var programCode = fileReader.Read();

            WalkProgramCode(walker, programCode);
        }

        private static void WalkProgramCode(IWalker walker, string programCode)
        {
            var lexer = new Lexer(programCode);
            var tokens = lexer.ReadTokens();

            var parser = new Parser(tokens);
            var program = parser.Parse();

            program.Accept(walker);
        }

        private static void PrintHelp()
        {
            throw new System.NotImplementedException();
        }
    }
}