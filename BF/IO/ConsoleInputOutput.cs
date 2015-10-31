using System;
using BF.Core.Abstraction;

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

        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
