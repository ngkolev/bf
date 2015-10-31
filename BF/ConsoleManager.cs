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
            IO = new ConsoleInputOutput();
            ArgumentParser = new ArgumentParser(args);
        }

        private IInputOutput IO { get; set; }
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
            var walker = ArgumentParser.HasPrettyPrintFlag
                ? (IWalker)new PrettyPrintWalker(IO)
                : (IWalker)new ExecuteWalker(IO);

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

        private void PrintHelp()
        {
            var text = $@"
Brainfuck interpreter

Use: {System.AppDomain.CurrentDomain.FriendlyName} [-p] [-h] [PATH]
    -p - pretty print
    -h - prints this help";

            IO.WriteText(text);
        }
    }
}