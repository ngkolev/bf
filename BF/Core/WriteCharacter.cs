namespace BF.Core
{
    class WriteCharacter : IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}