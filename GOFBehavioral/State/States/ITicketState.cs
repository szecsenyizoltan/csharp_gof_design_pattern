using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    internal interface ITicketState
    {
        void Send(Ticket context);
        void Close(Ticket context);
    }
}
