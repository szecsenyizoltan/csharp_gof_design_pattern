using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    internal class CreatedState : ITicketState
    {
        public void Close(Ticket context)
        {
            context.State = new ClosedState();
        }

        public void Send(Ticket context)
        {
            context.State = new SentState();
        }
    }
}
