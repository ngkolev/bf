using BF.Core.Abstraction;

namespace BF.Core.Expressions
{
    class ReadCharacterExpression : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}