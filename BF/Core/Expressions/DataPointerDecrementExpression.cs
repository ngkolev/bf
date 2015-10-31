using BF.Core.Abstraction;

namespace BF.Core.Expressions
{
    class DataPointerDecrementExpression : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}