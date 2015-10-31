using System;
using BF.Core.Abstraction;
using BF.Core.Expressions;
using BF.IO;

namespace BF.Core.Walkers
{
    class PrettyPrintWalker : IWalker
    {
        public PrettyPrintWalker(IInputOutput io)
        {
            IO = io;
        }

        private IInputOutput IO { get; set; }
        private int Indentation { get; set; }

        public void Walk(DataValueDecrementExpression expression)
        {
            Print('-');
        }

        public void Walk(DataValueIncrementExpression expression)
        {
            Print('+');
        }

        public void Walk(DataPointerDecrementExpression expression)
        {
            Print('<');
        }

        public void Walk(DataPointerIncrementExpression expression)
        {
            Print('>');
        }

        public void Walk(WriteCharacterExpression expression)
        {
            Print('.');
        }

        public void Walk(ReadCharacterExpression expression)
        {
            Print(',');
        }

        public void Walk(LoopExpression expression)
        {
            NewLine();
            Print('[');
            NewLine();
            Indentation++;
            Walk(expression.Body);
            Indentation--;
            NewLine();
            Print(']');
            NewLine();
        }

        public void Walk(ProgramExpression expression)
        {
            foreach (var item in expression.Expressions)
            {
                item.Accept(this);
            }
        }

        private void Print(char character)
        {
            for (var i = 0; i < Indentation; i++)
            {
                IO.WriteChar(' ');
            }
            IO.WriteChar(character);
        }

        private void NewLine()
        {
            IO.WriteText(Environment.NewLine);
        }
    }
}
