using System;
using System.Collections.Generic;
using System.Linq;
using BF.Core.Abstraction;
using BF.Core.Expressions;

namespace BF.Core
{
    class Parser
    {
        public Parser(IList<TokenType> tokens)
        {
            Tokens = tokens;
        }

        private IList<TokenType> Tokens { get; set; }
        private int CurrentIndex { get; set; }

        public ProgramExpression Parse()
        {
            var program = new ProgramExpression();
            while (true)
            {
                var expression = TryParseExpression();
                if (expression == ProgramExpression.NullExpression) break;

                program.Expressions.Add(expression);
                CurrentIndex++;
            }

            return program;
        }

        private IExpression TryParseExpression()
        {
            if (Tokens.Count <= CurrentIndex) return ProgramExpression.NullExpression;

            var token = Tokens[CurrentIndex];
            switch (token)
            {
                case TokenType.DataValueDecrement:
                    return new DataValueDecrementExpression();
                case TokenType.DataValueIncrement:
                    return new DataValueIncrementExpression();
                case TokenType.DataPointerDecrement:
                    return new DataPointerDecrementExpression();
                case TokenType.DataPointerIncrement:
                    return new DataPointerIncrementExpression();
                case TokenType.WriteCharacter:
                    return new WriteCharacterExpression();
                case TokenType.ReadCharacter:
                    return new ReadCharacterExpression();
                case TokenType.LoopStart:
                    return ParseLoopStatement();
                case TokenType.LoopEnd:
                    return ProgramExpression.NullExpression;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private IExpression ParseLoopStatement()
        {
            CurrentIndex++;
            var body = Parse();
            var result = new LoopExpression(body);

            return result;
        }
    }
}
