using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Interfaces
{
    internal interface IAcceptor
    {
        void Accept(IVisitor visitor);
        object Item { get; }
    }
}
