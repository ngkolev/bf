using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BF.Core.Abstraction;

namespace BF.Core.Expressions
{
    internal class ProgramExpression : IExpression
    {
        public ProgramExpression()
        {
            Expressions = new List<IExpression>();
        }

        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }

        public ICollection<IExpression> Expressions { get; private set; }
        public static ProgramExpression NullExpression { get; } = new ProgramExpression();
    }
}