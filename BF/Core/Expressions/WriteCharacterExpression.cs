using BF.Core.Abstraction;

namespace BF.Core.Expressions
{
    class WriteCharacterExpression : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}