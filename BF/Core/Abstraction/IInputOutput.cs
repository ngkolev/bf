namespace BF.Core.Abstraction
{
    interface IInputOutput
    {
        char ReadChar();
        void WriteChar(char character);
        void WriteText(string text);
    }
}
