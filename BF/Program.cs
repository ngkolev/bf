﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF
{
    static class Program
    {
        static void Main(string[] args)
        {
            var manager = new ConsoleManager(args);
            manager.Run(args);
        }
    }
}
