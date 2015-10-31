using BF.Core.Abstraction;

namespace BF.Core.Expressions
{
    class DataValueIncrementExpression : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}