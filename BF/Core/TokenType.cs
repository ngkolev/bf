namespace BF.Core
{
    enum TokenType
    {
        DataValueReduce,
        DataValueIncrement,
        DataPointerReduce,
        DataPointerIncrement,
        WriteCharacter,
        ReadCharacter,
        LoopStart,
        LoopEnd
    }

    interface IExpression
    {
        void Accept(IVisitor visitor);
    }

    interface IVisitor
    {
        
    }
}