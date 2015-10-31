namespace BF.Core
{
    class DataPointerDecrement : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}