﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Interfaces
{
    internal interface IVisitor
    {
        void Visit(IAcceptor acceptor);
    }
}
