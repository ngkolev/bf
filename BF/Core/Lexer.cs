using System;
using System.Collections.Generic;
using System.Linq;

namespace BF.Core
{
    internal class Lexer
    {
        private const char NEW_LINE = '\n';

        private static readonly IDictionary<char, TokenType> Mapping = new Dictionary<char, TokenType>
        {
            {'-', TokenType.DataValueDecrement},
            {'+', TokenType.DataValueIncrement},
            {'<', TokenType.DataPointerDecrement},
            {'>', TokenType.DataPointerIncrement},
            {'.', TokenType.WriteCharacter},
            {',', TokenType.ReadCharacter},
            {'[', TokenType.LoopStart},
            {']', TokenType.LoopEnd},
            {'#', TokenType.Comment},
        };

        public Lexer(string programCode)
        {
            Code = programCode.Replace(Environment.NewLine, NEW_LINE.ToString());
        }

        private string Code { get; set; }

        public IList<TokenType> ReadTokens()
        {
            var result = new List<TokenType>();
            for (int i = 0; i < Code.Length; i++)
            {
                var character = Code[i];
                var token = Mapping[character];
                if (token == TokenType.Comment)
                {
                    do
                    {
                        character = Code[i];
                        i++;
                    } while (character != NEW_LINE);
                }
                result.Add(token);
            }
            return result;
        }
    }
}