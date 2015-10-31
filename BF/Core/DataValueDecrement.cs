namespace BF.Core
{
    class DataValueDecrement : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}