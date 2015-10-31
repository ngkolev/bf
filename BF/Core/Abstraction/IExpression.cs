namespace BF.Core.Abstraction
{
    interface IExpression
    {
        void Accept(IWalker walker);
    }
}