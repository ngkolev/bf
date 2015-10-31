namespace BF.Core
{
    class ReadCharacter : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}