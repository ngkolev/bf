namespace BF.Core
{
    interface IExpression
    {
        void Accept(IWalker walker);
    }
}