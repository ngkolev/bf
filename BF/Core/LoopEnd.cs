namespace BF.Core
{
    class LoopEnd : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}