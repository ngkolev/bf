using BF.Core.Abstraction;

namespace BF.Core.Expressions
{
    class DataValueDecrementExpression : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}