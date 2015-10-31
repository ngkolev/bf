using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF
{
    class ArgumentParser
    {
        public ArgumentParser(string[] args)
        {
        }

        // TODO: Print help if help flag is on or no filePath is provided
        public bool ShouldPrintHelp { get; private set; }
        public bool HasPrettyPrintFlag { get; private set; }
        public string FilePath { get; private set; }
    }
}
