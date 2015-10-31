using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BF.Core.Abstraction;

namespace BF.Core.Expressions
{
    class ProgramExpression: IExpression
    {
        public void Accept(IWalker walker)
        {
            walker.Walk(this);
        }
    }
}
