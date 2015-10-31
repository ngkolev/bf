namespace BF.Core
{
    class DataPointerIncrement : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}