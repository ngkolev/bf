using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BF.Core;

namespace BF.IO
{
    class ConsoleInputOutput : IInputOutput
    {
        public char ReadChar()
        {
            return (char)Console.Read();
        }

        public void WriteChar(char character)
        {
            Console.Write(character);
        }
    }
}
