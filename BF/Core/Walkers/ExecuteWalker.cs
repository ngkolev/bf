using System;
using BF.Core.Abstraction;
using BF.Core.Expressions;
using BF.IO;

namespace BF.Core.Walkers
{
    class ExecuteWalker : IWalker
    {
        public ExecuteWalker(IInputOutput io)
        {
            Context = new Context();
            IO = io;
        }
        private Context Context { get; set; }
        private IInputOutput IO { get; set; }

        public void Walk(DataValueDecrementExpression expression)
        {
            Context.DecrementValue();
        }

        public void Walk(DataValueIncrementExpression expression)
        {
            Context.IncrementValue();
        }

        public void Walk(DataPointerDecrementExpression expression)
        {
            Context.PreviousValue();
        }

        public void Walk(DataPointerIncrementExpression expression)
        {
            Context.NextValue();
        }

        public void Walk(WriteCharacterExpression expression)
        {
            Context.Value = IO.ReadChar();
        }

        public void Walk(ReadCharacterExpression expression)
        {
            IO.WriteChar(Context.Value);
        }

        public void Walk(LoopExpression expression)
        {
            while (Context.Value!= '\0')
            {
                expression.Body.Accept(this);
            }
        }

        public void Walk(ProgramExpression expression)
        {
            foreach (var item in expression.Expressions)
            {
                item.Accept(this);
            }
        }
    }
}
