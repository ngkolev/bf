using System.Collections.Generic;
using System.Linq;

namespace BF
{
    class ArgumentParser
    {
        public ArgumentParser(string[] args)
        {
            Flags = args
                .Where(a => a.StartsWith("-"))
                .Select(a => a.Substring(1))
                .ToList();

            FilePath = args.LastOrDefault(a => !a.StartsWith("-"));
        }

        private ICollection<string> Flags { get; set; }

        public bool ShouldPrintHelp => Flags.Contains("h") || string.IsNullOrEmpty(FilePath);

        public bool HasPrettyPrintFlag => Flags.Contains("p");

        public string FilePath { get; private set; }
    }
}
