namespace BF.Core
{
    interface IWalker
    {
        void Walk(DataValueDecrement expression);
        void Walk(DataValueIncrement expression);
        void Walk(DataPointerDecrement expression);
        void Walk(DataPointerIncrement expression);
        void Walk(WriteCharacter expression);
        void Walk(ReadCharacter expression);
        void Walk(LoopStart expression);
        void Walk(LoopEnd expression);
    }
}