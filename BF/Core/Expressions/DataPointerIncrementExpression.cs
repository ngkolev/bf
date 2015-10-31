using BF.Core.Abstraction;

namespace BF.Core.Expressions
{
    class DataPointerIncrementExpression : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}