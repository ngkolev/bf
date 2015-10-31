using BF.Core.Abstraction;

namespace BF.Core.Expressions
{
    class LoopExpression : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }

        public ProgramExpression Body { get; set; }
    }
}