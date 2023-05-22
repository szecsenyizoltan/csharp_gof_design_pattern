using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{

    internal class Ticket
    {
        public Ticket(string title, string description)
        {
            Title = title;
            Description = description;
            State = new CreatedState();
        }

        public string StateText
        {
            get
            {
                Type t = State.GetType();
                return t.Name.Replace("State", "");
            }
        }

        public ITicketState State { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }


        public void Send()
        {
            State.Send(this);
        }

        public void Close()
        {
            State.Close(this);
        }
    }
}
