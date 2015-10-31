using System;
using System.Collections.Generic;
using System.Linq;

namespace BF.Core
{
    internal class Lexer
    {
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
        };

        public Lexer(string programCode)
        {
            Code = programCode;
        }

        private string Code { get; set; }

        public ICollection<TokenType> ReadTokens()
        {
            return Code.Select(c => Mapping[c]).ToList();
        }
    }
}