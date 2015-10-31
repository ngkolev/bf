namespace BF.Core
{
    class DataValueIncrement : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}