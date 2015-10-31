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
        }

        public void Walk(DataValueDecrementExpression expression)
        {
            throw new NotImplementedException();
        }

        public void Walk(DataValueIncrementExpression expression)
        {
            throw new NotImplementedException();
        }

        public void Walk(DataPointerDecrementExpression expression)
        {
            throw new NotImplementedException();
        }

        public void Walk(DataPointerIncrementExpression expression)
        {
            throw new NotImplementedException();
        }

        public void Walk(WriteCharacterExpression expression)
        {
            throw new NotImplementedException();
        }

        public void Walk(ReadCharacterExpression expression)
        {
            throw new NotImplementedException();
        }

        public void Walk(LoopExpression expression)
        {
            throw new NotImplementedException();
        }

        public void Walk(ProgramExpression expression)
        {
            throw new NotImplementedException();
        }
    }
}
